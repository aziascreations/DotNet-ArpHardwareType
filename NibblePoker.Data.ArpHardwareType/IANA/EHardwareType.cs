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
public enum EHardwareType: ushort {
    /// <summary>
    ///   Reserved ARP hardware address defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc5494">RFC5494</a>.
    /// </summary>
    [ArpHardwareTypeName("Reserved")]
    Reserved = 0,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Ethernet (10Mb)")]
    Ethernet_10Mb = 1,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Experimental Ethernet (3Mb)")]
    Experimental_Ethernet_3Mb = 2,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Amateur Radio AX.25")]
    Amateur_Radio_AX_25 = 3,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Proteon ProNET Token Ring")]
    Proteon_ProNET_Token_Ring = 4,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Chaos")]
    Chaos = 5,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("IEEE 802 Networks")]
    IEEE_802_Networks = 6,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("ARCNET")]
    ARCNET = 7,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Hyperchannel")]
    Hyperchannel = 8,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Lanstar")]
    Lanstar = 9,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Autonet Short Address")]
    Autonet_Short_Address = 10,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("LocalTalk")]
    LocalTalk = 11,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("LocalNet (IBM PCNet or SYTEK LocalNET)")]
    LocalNet = 12,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Ultra link")]
    Ultra_link = 13,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("SMDS")]
    SMDS = 14,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Frame Relay")]
    Frame_Relay = 15,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Asynchronous Transmission Mode (ATM)")]
    Asynchronous_Transmission_Mode_1 = 16,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Asynchronous Transmission Mode (ATM)")]
    Asynchronous_Transmission_Mode_JXB2 = Asynchronous_Transmission_Mode_1,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("HDLC")]
    HDLC = 17,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Fibre Channel")]
    Fibre_Channel = 18,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Asynchronous Transmission Mode (ATM)")]
    Asynchronous_Transmission_Mode_2 = 19,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Asynchronous Transmission Mode (ATM)")]
    Asynchronous_Transmission_Mode_RFC2225 = Asynchronous_Transmission_Mode_2,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Serial Line")]
    Serial_Line = 20,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Asynchronous Transmission Mode (ATM)")]
    Asynchronous_Transmission_Mode_3 = 21,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Asynchronous Transmission Mode (ATM)")]
    Asynchronous_Transmission_Mode_MikeBurrows = Asynchronous_Transmission_Mode_3,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("MIL-STD-188-220")]
    MIL_STD_188_220 = 22,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Metricom")]
    Metricom = 23,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("IEEE 1394.1995")]
    IEEE_1394_1995 = 24,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("MAPOS")]
    MAPOS = 25,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Twinaxial")]
    Twinaxial = 26,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("EUI-64")]
    EUI_64 = 27,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("HIPARP")]
    HIPARP = 28,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("IP and ARP over ISO 7816-3")]
    IP_and_ARP_over_ISO_7816_3 = 29,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("ARPSec")]
    ARPSec = 30,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("IPsec tunnel")]
    IPsec_tunnel = 31,
    
    /// <summary>
    ///   IANA-specified number for <i>InfiniBand (IB)</i> defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc4391">RFC5494</a>
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc4391#section-9.2">section 9.2</a>.
    /// </summary>
    [ArpHardwareTypeName("InfiniBand (TM)")]
    InfiniBand = 32,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("TIA-102 Project 25 Common Air Interface (CAI)")]
    TIA_102_Project_25_Common_Air_Interface = 33,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Wiegand Interface")]
    Wiegand_Interface = 34,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Pure IP")]
    Pure_IP = 35,
    
    /// <summary>
    ///   ARP hardware address reserved for experimental purpose defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc5494">RFC5494</a>.
    /// </summary>
    [ArpHardwareTypeName("HW_EXP1")]
    HW_EXP1 = 36,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("HFI")]
    HFI = 37,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("Unified Bus (UB)")]
    Unified_Bus = 38,
    
    // 39-255 - Unassigned	
    
    /// <summary>
    ///   ARP hardware address reserved for experimental purpose defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc5494">RFC5494</a>.
    /// </summary>
    [ArpHardwareTypeName("HW_EXP2")]
    HW_EXP2 = 256,
    
    /// <summary>
    ///   ???
    /// </summary>
    [ArpHardwareTypeName("AEthernet")]
    AEthernet = 257,
    
    // 258-65534 - Unassigned	
    
    /// <summary>
    ///   Reserved ARP hardware address defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc5494">RFC5494</a>.
    /// </summary>
    [ArpHardwareTypeName("Reserved")]
    Reserved_RFC5494 = 65535,
}
