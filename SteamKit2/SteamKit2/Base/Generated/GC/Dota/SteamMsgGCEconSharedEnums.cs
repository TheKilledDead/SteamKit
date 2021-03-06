//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: econ_shared_enums.proto
namespace SteamKit2.GC.Dota.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgGenericResult")]
  public partial class CMsgGenericResult : global::ProtoBuf.IExtensible
  {
    public CMsgGenericResult() {}
    

    private uint? _eresult;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"eresult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint eresult
    {
      get { return _eresult?? (uint)2; }
      set { _eresult = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool eresultSpecified
    {
      get { return _eresult != null; }
      set { if (value == (_eresult== null)) _eresult = value ? this.eresult : (uint?)null; }
    }
    private bool ShouldSerializeeresult() { return eresultSpecified; }
    private void Reseteresult() { eresultSpecified = false; }
    

    private string _debug_message;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"debug_message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string debug_message
    {
      get { return _debug_message?? ""; }
      set { _debug_message = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool debug_messageSpecified
    {
      get { return _debug_message != null; }
      set { if (value == (_debug_message== null)) _debug_message = value ? this.debug_message : (string)null; }
    }
    private bool ShouldSerializedebug_message() { return debug_messageSpecified; }
    private void Resetdebug_message() { debug_messageSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGCEconBaseMsg", EnumPassthru=true)]
    public enum EGCEconBaseMsg
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EMsgGCGenericResult", Value=2579)]
      k_EMsgGCGenericResult = 2579
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGCMsgResponse", EnumPassthru=true)]
    public enum EGCMsgResponse
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgResponseOK", Value=0)]
      k_EGCMsgResponseOK = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgResponseDenied", Value=1)]
      k_EGCMsgResponseDenied = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgResponseServerError", Value=2)]
      k_EGCMsgResponseServerError = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgResponseTimeout", Value=3)]
      k_EGCMsgResponseTimeout = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgResponseInvalid", Value=4)]
      k_EGCMsgResponseInvalid = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgResponseNoMatch", Value=5)]
      k_EGCMsgResponseNoMatch = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgResponseUnknownError", Value=6)]
      k_EGCMsgResponseUnknownError = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgResponseNotLoggedOn", Value=7)]
      k_EGCMsgResponseNotLoggedOn = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgFailedToCreate", Value=8)]
      k_EGCMsgFailedToCreate = 8
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGCPartnerRequestResponse", EnumPassthru=true)]
    public enum EGCPartnerRequestResponse
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EPartnerRequestOK", Value=1)]
      k_EPartnerRequestOK = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EPartnerRequestBadAccount", Value=2)]
      k_EPartnerRequestBadAccount = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EPartnerRequestNotLinked", Value=3)]
      k_EPartnerRequestNotLinked = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EPartnerRequestUnsupportedPartnerType", Value=4)]
      k_EPartnerRequestUnsupportedPartnerType = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"EGCMsgUseItemResponse", EnumPassthru=true)]
    public enum EGCMsgUseItemResponse
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_ItemUsed", Value=0)]
      k_EGCMsgUseItemResponse_ItemUsed = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_GiftNoOtherPlayers", Value=1)]
      k_EGCMsgUseItemResponse_GiftNoOtherPlayers = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_ServerError", Value=2)]
      k_EGCMsgUseItemResponse_ServerError = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_MiniGameAlreadyStarted", Value=3)]
      k_EGCMsgUseItemResponse_MiniGameAlreadyStarted = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_ItemUsed_ItemsGranted", Value=4)]
      k_EGCMsgUseItemResponse_ItemUsed_ItemsGranted = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_DropRateBonusAlreadyGranted", Value=5)]
      k_EGCMsgUseItemResponse_DropRateBonusAlreadyGranted = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_NotInLowPriorityPool", Value=6)]
      k_EGCMsgUseItemResponse_NotInLowPriorityPool = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_NotHighEnoughLevel", Value=7)]
      k_EGCMsgUseItemResponse_NotHighEnoughLevel = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_EventNotActive", Value=8)]
      k_EGCMsgUseItemResponse_EventNotActive = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_ItemUsed_EventPointsGranted", Value=9)]
      k_EGCMsgUseItemResponse_ItemUsed_EventPointsGranted = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_MissingRequirement", Value=10)]
      k_EGCMsgUseItemResponse_MissingRequirement = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_EmoticonUnlock_NoNew", Value=11)]
      k_EGCMsgUseItemResponse_EmoticonUnlock_NoNew = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_EmoticonUnlock_Complete", Value=12)]
      k_EGCMsgUseItemResponse_EmoticonUnlock_Complete = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"k_EGCMsgUseItemResponse_ItemUsed_Compendium", Value=13)]
      k_EGCMsgUseItemResponse_ItemUsed_Compendium = 13
    }
  
}
#pragma warning restore 1591
