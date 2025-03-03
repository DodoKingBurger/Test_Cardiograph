﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO;
using Test_Cardiograph.Properties;

namespace Test_Cardiograph.Services.Controller
{
  /// <summary>
  /// Кардиограф
  /// </summary>
  internal class Controller
  {
    #region Поля и свойства 

    private bool monitorRead { get; set; } = false;
    private SerialPort port;

    /// <summary>
    /// COM порт.
    /// </summary>
    public SerialPort Port
    {
      get { return port; }
      set
      {
        if(this.port == null)
          throw new ArgumentNullException("port");
        this.port = value;
      }
    }

    #endregion

    #region Методы

    #region Методы работы с пакетами данных

    #region Получение измерений в реальном времени (0x5A)

    /// <summary>
    /// Получение измерений в реальном времени(0x5A).
    /// </summary>
    public async void USB_Monitor_Data()
    {
      if (this.Port.IsOpen)
      {
        await Task.Run(() =>
        {
          int byte1 = -1;
          UInt16 byte_i = 1;
          byte processing = 0;
          UInt16 Packet_size = 0;
          byte crc = 0;
          /* Добавить условия для проверки
          на отправку команды о прекращении
          стрима данных */
          while (this.Port.IsOpen)
          {
            byte1 = this.Port.ReadByte();
            if(byte1 == 240)
            {
              byte1 = this.Port.ReadByte();
              if (byte1 == 240)
              {
                byte_i = 0;
                processing = 1;
                Packet_size = 0;
                crc = 0;
              }
            }
            else
            {
              if (processing == 1)
              {
                processing = 0;
                if(byte_i == 23)
                {
                  Packet_size = byte_i;
                  Read_DATA_STREAM();
                }
                else
                {
                  Parametr.buffer[byte_i] = Convert.ToByte(byte1);
                  byte_i++;
                  if (byte_i >= Parametr.USB_RX_DATA_LEN_MAX)
                  {
                    processing = 0;
                  }
                }
              }
            }
          }
        });
      }
      else
        throw new IOException("Порт закрыт.");
    }

    /// <summary>
    /// Разбор пакета полученных данных
    /// </summary>
    public void Read_DATA_STREAM()
    {

    }

    #endregion

    /// <summary>
    /// Отправка команды SerialPort.
    /// </summary>
    /// <param name="cmd_code">Код команды.</param>
    /// <param name="rw_flag">1.</param>
    /// <param name="parameter_val">1.</param>
    /// <param name="parametr_size">1.</param>
    /// <exception cref="IOException">Плата не отвечает.</exception>
    public void USB_TX_short_Msg(byte cmd_code)
    {
          //public void USB_TX_short_Msg(byte cmd_code, byte rw_flag, ref byte parameter_val, int parametr_size)
      //byte cnt;
      //short i_byte = 1;
      //byte CRC_val = 0;
      //byte byte_buf;

      //Parametr.usb_tx_cmd_packet[0] = Convert.ToByte(Parametr.USB_BYTE_START);
      //USB_Paket_Constructor(ref i_byte, ref CRC_val, (byte)cmd_code);
      //USB_Paket_Constructor(ref i_byte, ref CRC_val, (byte)rw_flag);

      //for (cnt = 0; cnt < parametr_size; cnt++)
      //{
      //  byte_buf = (byte)(parameter_val + cnt);
      //  USB_Paket_Constructor(ref i_byte, ref CRC_val, byte_buf);
      //}

      //USB_Paket_Constructor(ref i_byte, ref CRC_val, CRC_val); //CRC

      //Parametr.usb_tx_cmd_packet[i_byte++] = Parametr.USB_BYTE_STOP;
      Parametr.usb_tx_cmd_packet[0] = cmd_code;
      if (this.Port.IsOpen)
      {
        this.Port.Write(Parametr.usb_tx_cmd_packet, 0, 1);
        //this.Port.Write(Parametr.usb_tx_cmd_packet, 0, i_byte);
      }
      else
      {
        this.Port.Close();
        throw new IOException("Error writing to serial port\n");
      }
    }

    /// <summary>
    /// Формерования пакета данных для передачи на плату.
    /// </summary>
    /// <param name="i_byte">Какой байт по счетчику.</param>
    /// <param name="CRC_val">CRC value.</param>
    /// <param name="data_byte">Данные.</param>
    public void USB_Paket_Constructor(ref short i_byte, ref byte CRC_val, byte data_byte)
    {
      CRC_val ^= data_byte;
      if ((data_byte == Parametr.USB_BYTE_START) || (data_byte == Parametr.USB_BYTE_STOP) || (data_byte == Parametr.USB_BYTE_ESC) || (data_byte == Parametr.USB_BYTE_DUMMY0) || (data_byte == Parametr.USB_BYTE_DUMMY1))
      {
        Parametr.usb_tx_cmd_packet[i_byte] = Parametr.USB_BYTE_ESC;
        data_byte = data_byte ^= 0x21;
        i_byte++;
      }
      Parametr.usb_tx_cmd_packet[i_byte] = data_byte;
      i_byte++;
    }

    #endregion

    #region Методы подключения и отключения

    /// <summary>
    /// Подключение к Serial Port.
    /// </summary>
    public void Connected()
    {
      this.Port.Open();
      if (!this.Port.IsOpen)
        throw new IOException();
    }

    /// <summary>
    /// Отключение к Serial Port.
    /// </summary>
    public void Disconnected()
    {
      if(this.Port.IsOpen)
        this.Port.Close();
      else
        throw new IOException();
    }

    #endregion

    #endregion

    #region Конструкторы

    public Controller(SerialPort port)
    {
      this.Port = port;
    }

    public Controller() 
    {
      this.Port = new SerialPort();
    }

    #endregion
  }
}
