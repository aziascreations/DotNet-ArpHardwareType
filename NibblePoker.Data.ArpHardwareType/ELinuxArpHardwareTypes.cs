/*! \file ELinuxArpHardwareTypes.cs */

namespace NibblePoker.Data.ArpHardwareType {
    /// <summary>
    ///   Contains all <i>"Hardware Types"</i> from the
    ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
    /// </summary>
    /// <warning>
    ///   This list has conflicts with the
    ///    <a href="https://www.iana.org/assignments/arp-parameters/arp-parameters.xhtml">IANA On-Line Database</a> and
    ///    <a href="https://datatracker.ietf.org/doc/html/rfc5494">RFC5494</a> !
    /// </warning>
    // ReSharper disable InconsistentNaming
    public enum ELinuxArpHardwareTypes: ushort {
        /// <summary>
        ///   ARP hardware type for <i>"from KA9Q: NET/ROM pseudo"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("from KA9Q: NET/ROM pseudo")]
        NETROM = 0,
        
        /// <summary>
        ///   ARP hardware type for <i>"Ethernet 10Mbps"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("Ethernet 10Mbps")]
        ETHER = 1,

        /// <summary>
        ///   ARP hardware type for <i>"Experimental Ethernet"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("Experimental Ethernet")]
        EETHER = 2,

        /// <summary>
        ///   ARP hardware type for <i>"AX.25 Level 2"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("AX.25 Level 2")]
        AX25 = 3,

        /// <summary>
        ///   ARP hardware type for <i>"PROnet token ring"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("PROnet token ring")]
        PRONET = 4,

        /// <summary>
        ///   ARP hardware type for <i>"Chaosnet"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("Chaosnet")]
        CHAOS = 5,

        /// <summary>
        ///   ARP hardware type for <i>"IEEE 802.2 Ethernet/TR/TB"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("IEEE 802.2 Ethernet/TR/TB")] 
        IEEE802 = 6,

        /// <summary>
        ///   ARP hardware type for <i>"ARCnet"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("ARCnet")] 
        ARCNET = 7,

        /// <summary>
        ///   ARP hardware type for <i>"APPLEtalk"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("APPLEtalk")]
        APPLETLK = 8,
        
        // 9-14 - Unassigned

        /// <summary>
        ///   ARP hardware type for <i>"Frame Relay DLCI"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("Frame Relay DLCI")]
        DLCI = 15,

        // 16-18 - Unassigned

        /// <summary>
        ///   ARP hardware type for <i>"ATM"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("ATM")]
        ATM = 19,

        // 20-22 - Unassigned

        /// <summary>
        ///   ARP hardware type for <i>"Metricom STRIP (new IANA id)"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("Metricom STRIP (new IANA id)")]
        METRICOM = 23,

        /// <summary>
        ///   ARP hardware type for <i>"IEEE 1394 IPv4 - RFC 2734"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("IEEE 1394 IPv4 - RFC 2734")]
        IEEE1394 = 24,

        // 25-26 - Unassigned

        /// <summary>
        ///   ARP hardware type for <i>"EUI-64"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("EUI-64")]
        EUI64 = 27,

        // 28-31 - Unassigned

        /// <summary>
        ///   ARP hardware type for <i>"InfiniBand"</i> as defined in the
        ///    <a href="https://github.com/torvalds/linux/blob/master/include/uapi/linux/if_arp.h">Linux Kernel</a>.
        /// </summary>
        [ArpHardwareTypeName("InfiniBand")]
        INFINIBAND = 32,
        
        // FIXME: Add the "Dummy types for non ARP hardware" and later entries. 
    }
}
