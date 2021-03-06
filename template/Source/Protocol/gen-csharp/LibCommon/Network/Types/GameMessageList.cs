/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace LibCommon.Network.Types
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class GameMessageList : TBase
  {

    public List<string> Messages { get; set; }

    public GameMessageList() {
    }

    public GameMessageList(List<string> messages) : this() {
      this.Messages = messages;
    }

    public void Read (TProtocol iprot)
    {
      bool isset_messages = false;
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.List) {
              {
                Messages = new List<string>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  string _elem2 = null;
                  _elem2 = iprot.ReadString();
                  Messages.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
              isset_messages = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
      if (!isset_messages)
        throw new TProtocolException(TProtocolException.INVALID_DATA);
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("GameMessageList");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      field.Name = "messages";
      field.Type = TType.List;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      {
        oprot.WriteListBegin(new TList(TType.String, Messages.Count));
        foreach (string _iter3 in Messages)
        {
          oprot.WriteString(_iter3);
        }
        oprot.WriteListEnd();
      }
      oprot.WriteFieldEnd();
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("GameMessageList(");
      sb.Append("Messages: ");
      sb.Append(Messages);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
