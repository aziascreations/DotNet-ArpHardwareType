/*! \file EHardwareType.cs */

namespace NibblePoker.Data.ArpHardwareType.IANA;

/// <summary>
///   Contains all <i>"Hardware Types"</i> from the <i>"Address Resolution Protocol (ARP) Parameters"</i>
///    database maintained by the IANA in their
///    <a href="https://www.iana.org/assignments/arp-parameters/arp-parameters.xhtml">online database</a>.
///    <br/>
///   This list extends end obsoletes the old
///    <a href="https://datatracker.ietf.org/doc/html/rfc1700">RFC1700</a>.
/// </summary>
/// <see cref="NibblePoker.Data.ArpHardwareType.RFC1700"/>
/// 2023-05-19
public enum EHardwareType {
    /// <summary>
    ///   Reserved ARP hardware address as defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc5494">RFC5494</a>.
    /// </summary>
    Reserved = 0,
    
    /// <summary>
    ///   ???
    /// </summary>
    Ethernet_10Mb = 1,
    
    /// <summary>
    ///   ???
    /// </summary>
    Experimental_Ethernet_3Mb = 2,
    
    /// <summary>
    ///   ???
    /// </summary>
    Amateur_Radio_AX_25 = 3,
    
    /// <summary>
    ///   ???
    /// </summary>
    Proteon_ProNET_Token_Ring = 4,
    
    /// <summary>
    ///   ???
    /// </summary>
    Chaos = 5,
    
    /// <summary>
    ///   ???
    /// </summary>
    IEEE_802_Networks = 6,
    
    /// <summary>
    ///   ???
    /// </summary>
    ARCNET = 7,
    
    /// <summary>
    ///   ???
    /// </summary>
    Hyperchannel = 8,
    
    /// <summary>
    ///   ???
    /// </summary>
    Lanstar = 9,
    
    /// <summary>
    ///   ???
    /// </summary>
    Autonet_Short_Address = 10,
    
    /// <summary>
    ///   ???
    /// </summary>
    LocalTalk = 11,
    
    /// <summary>
    ///   ???
    /// </summary>
    LocalNet = 12,
    
    /// <summary>
    ///   ???
    /// </summary>
    Ultra_link = 13,
    
    /// <summary>
    ///   ???
    /// </summary>
    SMDS = 14,
    
    /// <summary>
    ///   ???
    /// </summary>
    Frame_Relay = 15,
    
    /// <summary>
    ///   ???
    /// </summary>
    Asynchronous_Transmission_Mode_1 = 16,
    Asynchronous_Transmission_Mode_JXB2 = Asynchronous_Transmission_Mode_1,
    
    /// <summary>
    ///   ???
    /// </summary>
    HDLC = 17,
    
    /// <summary>
    ///   ???
    /// </summary>
    Fibre_Channel = 18,
    
    /// <summary>
    ///   ???
    /// </summary>
    Asynchronous_Transmission_Mode_2 = 19,
    Asynchronous_Transmission_Mode_RFC2225 = Asynchronous_Transmission_Mode_2,
    
    /// <summary>
    ///   ???
    /// </summary>
    Serial_Line = 20,
    
    /// <summary>
    ///   ???
    /// </summary>
    Asynchronous_Transmission_Mode_3 = 21,
    Asynchronous_Transmission_Mode_MikeBurrows = Asynchronous_Transmission_Mode_3,
    
    /// <summary>
    ///   ???
    /// </summary>
    MIL_STD_188_220 = 22,
    
    /// <summary>
    ///   ???
    /// </summary>
    Metricom = 23,
    
    /// <summary>
    ///   ???
    /// </summary>
    IEEE_1394_1995 = 24,
    
    /// <summary>
    ///   ???
    /// </summary>
    MAPOS = 25,
    
    /// <summary>
    ///   ???
    /// </summary>
    Twinaxial = 26,
    
    /// <summary>
    ///   ???
    /// </summary>
    EUI_64 = 27,
    
    /// <summary>
    ///   ???
    /// </summary>
    HIPARP = 28,
    
    /// <summary>
    ///   ???
    /// </summary>
    IP_and_ARP_over_ISO_7816_3 = 29,
    
    /// <summary>
    ///   ???
    /// </summary>
    ARPSec = 30,
    
    /// <summary>
    ///   ???
    /// </summary>
    IPsec_tunnel = 31,
    
    /// <summary>
    ///   IANA-specified number for <i>InfiniBand (IB)</i> as defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc4391">RFC5494</a>
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc4391#section-9.2">section 9.2</a>.
    /// </summary>
    InfiniBand = 32,
    
    /// <summary>
    ///   ???
    /// </summary>
    TIA_102_Project_25_Common_Air_Interface = 33,
    
    /// <summary>
    ///   ???
    /// </summary>
    Wiegand_Interface = 34,
    
    /// <summary>
    ///   ???
    /// </summary>
    Pure_IP = 35,
    
    /// <summary>
    ///   ARP hardware address reserved for experimental purpose as defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc5494">RFC5494</a>.
    /// </summary>
    HW_EXP1 = 36,
    
    /// <summary>
    ///   ???
    /// </summary>
    HFI = 37,
    
    /// <summary>
    ///   ???
    /// </summary>
    Unified_Bus = 38,
    
    // 39-255 - Unassigned	
    
    /// <summary>
    ///   ARP hardware address reserved for experimental purpose as defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc5494">RFC5494</a>.
    /// </summary>
    HW_EXP2 = 256,
    
    /// <summary>
    ///   ???
    /// </summary>
    AEthernet = 257,
    
    // 258-65534 - Unassigned	
    
    /// <summary>
    ///   Reserved ARP hardware address as defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc5494">RFC5494</a>.
    /// </summary>
    Reserved_RFC5494 = 65535,
}
