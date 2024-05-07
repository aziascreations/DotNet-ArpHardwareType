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
// ReSharper disable InconsistentNaming
public enum EHardwareType: ushort {
    /// <summary>
    ///   Reserved ARP hardware address as defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc5494">RFC5494</a>.
    /// </summary>
    [ArpHardwareTypeName("Reserved")]
    Reserved = 0,
    
    /// <summary>
    ///   ARP hardware type for <i>"Ethernet (10Mb)"</i> originally defined explicitly in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc900">RFC900</a>.<br/>
    ///   This type is commonly used today to describe generic Ethernet hardware.
    /// </summary>
    // Reference: <a href="mailto:postel@isi.edu">Jon Postel &lt;postel@isi.edu&gt;</a>
    [ArpHardwareTypeName("Ethernet (10Mb)")]
    Ethernet_10Mb = 1,
    
    /// <summary>
    ///   ARP hardware type for <i>"Experimental Ethernet (3Mb)"</i> originally defined explicitly in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc900">RFC900</a>.
    /// </summary>
    // Reference: <a href="mailto:postel@isi.edu">Jon Postel &lt;postel@isi.edu&gt;</a>
    [ArpHardwareTypeName("Experimental Ethernet (3Mb)")]
    Experimental_Ethernet_3Mb = 2,
    
    /// <summary>
    ///   ARP hardware type for <i>"Amateur Radio AX.25"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc923">RFC923</a>.
    /// </summary>
    // Reference: <a href="mailto:philip.koch@dartmouth.edu">Philip Koch &lt;philip.koch@dartmouth.edu&gt;</a>
    [ArpHardwareTypeName("Amateur Radio AX.25")]
    Amateur_Radio_AX_25 = 3,
    
    /// <summary>
    ///   ARP hardware type for <i>"Proteon ProNET Token Ring"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc943">RFC943</a>.
    /// </summary>
    // Reference: <a href="mailto:avri@peoteon.com">Avri Doria &lt;avri@peoteon.com&gt;</a>
    // Outdated reference: <a href="mailto:postel@isi.edu">Jon Postel &lt;postel@isi.edu&gt;</a>
    [ArpHardwareTypeName("Proteon ProNET Token Ring")]
    Proteon_ProNET_Token_Ring = 4,
    
    /// <summary>
    ///   ARP hardware type for <i>"Chaos"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc960">RFC960</a>.<br/>
    /// </summary>
    // Reference: <a href="mailto:gill%25mit-ccc@mc.lcs.mit.edu">Gill Pratt &lt;gill%25mit-ccc@mc.lcs.mit.edu&gt;</a>
    [ArpHardwareTypeName("Chaos")]
    Chaos = 5,
    
    /// <summary>
    ///   ARP hardware type for <i>"IEEE 802 Networks"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc990">RFC990</a>.
    /// </summary>
    // Reference: <a href="mailto:postel@isi.edu">Jon Postel &lt;postel@isi.edu&gt;</a>
    [ArpHardwareTypeName("IEEE 802 Networks")]
    IEEE_802_Networks = 6,
    
    /// <summary>
    ///   ARP hardware type for <i>"ARCNET"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1010">RFC1010</a>.
    /// </summary>
    // Reference: https://www.rfc-editor.org/rfc/rfc1201.html
    // Outdated reference: <a href="mailto:postel@isi.edu">Jon Postel &lt;postel@isi.edu&gt;</a>
    [ArpHardwareTypeName("ARCNET")]
    ARCNET = 7,
    
    /// <summary>
    ///   ARP hardware type for <i>"Hyperchannel"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1060">RFC1060</a>.
    /// </summary>
    // Reference: <a href="mailto:postel@isi.edu">Jon Postel &lt;postel@isi.edu&gt;</a>
    [ArpHardwareTypeName("Hyperchannel")]
    Hyperchannel = 8,
    
    /// <summary>
    ///   ARP hardware type for <i>"Lanstar"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1060">RFC1060</a>.
    /// </summary>
    // Reference: <a href="mailto:tom@citi.umich.edu">Tom Unger &lt;tom@citi.umich.edu&gt;</a>
    [ArpHardwareTypeName("Lanstar")]
    Lanstar = 9,
    
    /// <summary>
    ///   ARP hardware type for <i>"Autonet Short Address"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1060">RFC1060</a>.
    /// </summary>
    // Reference: <a href="mailto:burrows@src.dec.com">Mike Burrows &lt;burrows@src.dec.com&gt;</a>
    [ArpHardwareTypeName("Autonet Short Address")]
    Autonet_Short_Address = 10,
    
    /// <summary>
    ///   ARP hardware type for <i>"LocalTalk"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1060">RFC1060</a>.
    /// </summary>
    // Reference: <a href="mailto:jkrey@isi.edu">Joyce K. Reynolds &lt;jkrey@isi.edu&gt;</a>
    // Outdated reference: <a href="mailto:len@tops.sun.com">Len Edmondson &lt;len@tops.sun.com&gt;</a>
    [ArpHardwareTypeName("LocalTalk")]
    LocalTalk = 11,
    
    /// <summary>
    ///   ARP hardware type for <i>"LocalNet (IBM PCNet or SYTEK LocalNET)"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1060">RFC1060</a>.
    /// </summary>
    // Reference: Joseph Murdock (Network Resources Corporation)
    [ArpHardwareTypeName("LocalNet (IBM PCNet or SYTEK LocalNET)")]
    LocalNet = 12,
    
    /// <summary>
    ///   ARP hardware type for <i>"Ultra link"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1340">RFC1340</a>.
    /// </summary>
    // Reference: ([RXD2]    Rajiv Dhingra       Ultranet  rajiv@ULTRA.COM)
    [ArpHardwareTypeName("Ultra link")]
    Ultra_link = 13,
    
    /// <summary>
    ///   ARP hardware type for <i>"SMDS"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1340">RFC1340</a>.
    /// </summary>
    // Reference: ([GXC1]    George Clapp        Bellcore   meritec!clapp@bellcore.bellcore.com)
    [ArpHardwareTypeName("SMDS")]
    SMDS = 14,
    
    /// <summary>
    ///   ARP hardware type for <i>"Frame Relay"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1340">RFC1340</a>.
    /// </summary>
    // Reference: (Andy Malis          BBN       Malis@BBN.COM)
    [ArpHardwareTypeName("Frame Relay")]
    Frame_Relay = 15,
    
    /// <summary>
    ///   ARP hardware type for <i>"Asynchronous Transmission Mode (ATM)"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1340">RFC1340</a>.
    /// </summary>
    /// <seealso cref="Asynchronous_Transmission_Mode_JXB2"/>
    // Reference: (John Burnett        ATM       ---none---)
    [ArpHardwareTypeName("Asynchronous Transmission Mode (ATM)")]
    Asynchronous_Transmission_Mode_1 = 16,
    
    /// <summary>
    ///   ARP hardware type for <i>"Asynchronous Transmission Mode (ATM)"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1340">RFC1340</a>.
    /// </summary>
    /// <seealso cref="Asynchronous_Transmission_Mode_1"/>
    // Reference: (John Burnett        ATM       ---none---)
    [ArpHardwareTypeName("Asynchronous Transmission Mode (ATM)")]
    Asynchronous_Transmission_Mode_JXB2 = Asynchronous_Transmission_Mode_1,
    
    /// <summary>
    ///   ARP hardware type for <i>"HDLC"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1700">RFC1700</a>.
    /// </summary>
    // Reference: ([JBP]   Jon Postel <postel@isi.edu>)
    [ArpHardwareTypeName("HDLC")]
    HDLC = 17,
    
    /// <summary>
    ///   ARP hardware type for <i>"Fibre Channel"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1700">RFC1700</a>.
    /// </summary>
    // Reference: ([Yakov Rekhter])
    [ArpHardwareTypeName("Fibre Channel")]
    Fibre_Channel = 18,
    
    /// <summary>
    ///   ARP hardware type for <i>"Asynchronous Transmission Mode (ATM)"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1700">RFC1700</a>.
    /// </summary>
    /// <seealso cref="Asynchronous_Transmission_Mode_RFC2225"/>
    // Reference: ([Mark Laubach])
    [ArpHardwareTypeName("Asynchronous Transmission Mode (ATM)")]
    Asynchronous_Transmission_Mode_2 = 19,
    
    /// <summary>
    ///   ARP hardware type for <i>"Asynchronous Transmission Mode (ATM)"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1700">RFC1700</a>.
    /// </summary>
    /// <seealso cref="Asynchronous_Transmission_Mode_2"/>
    // Reference: ([Mark Laubach])
    [ArpHardwareTypeName("Asynchronous Transmission Mode (ATM)")]
    Asynchronous_Transmission_Mode_RFC2225 = Asynchronous_Transmission_Mode_2,
    
    /// <summary>
    ///   ARP hardware type for <i>"Serial Line"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1700">RFC1700</a>.
    /// </summary>
    // Reference: ([JBP]   Jon Postel <postel@isi.edu>)
    [ArpHardwareTypeName("Serial Line")]
    Serial_Line = 20,
    
    /// <summary>
    ///   ARP hardware type for <i>"Asynchronous Transmission Mode (ATM)"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1700">RFC1700</a>.
    /// </summary>
    /// <seealso cref="Asynchronous_Transmission_Mode_MikeBurrows"/>
    // Reference: ([MXB1] Mike Burrows <burrows@SRC.DEC.COM>)
    [ArpHardwareTypeName("Asynchronous Transmission Mode (ATM)")]
    Asynchronous_Transmission_Mode_3 = 21,
    
    /// <summary>
    ///   ARP hardware type for <i>"Asynchronous Transmission Mode (ATM)"</i> originally defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc1700">RFC1700</a>.
    /// </summary>
    /// <seealso cref="Asynchronous_Transmission_Mode_3"/>
    // Reference: ([MXB1] Mike Burrows <burrows@SRC.DEC.COM>)
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
    ///   IANA-specified number for <i>InfiniBand (IB)</i> as defined in
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
    ///   ARP hardware address reserved for experimental purpose as defined in
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
    ///   ARP hardware address reserved for experimental purpose as defined in
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
    ///   Reserved ARP hardware address as defined in
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc5494">RFC5494</a>.
    /// </summary>
    [ArpHardwareTypeName("Reserved")]
    Reserved_RFC5494 = 65535,
}
