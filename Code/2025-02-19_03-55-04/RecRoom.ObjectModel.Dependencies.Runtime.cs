using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7608110", Offset = "0x7606D10", VA = "0x187608110", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset bitset0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private Type[] bindTypeSet1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1DFCDA0", Offset = "0x1DFB9A0", VA = "0x181DFCDA0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7608280", Offset = "0x7606E80", VA = "0x187608280")]
		private void MPLOOPBCFDI(IServiceRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7608610", Offset = "0x7607210", VA = "0x187608610", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7608670", Offset = "0x7607270", VA = "0x187608670")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[RegisterService(typeof(BHJBHCMBGHP), new string[] { "Photon" })]
public class FEEAHKCICCG : BHJBHCMBGHP
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private class BEHEOMBOENI : HOPAMIAMLDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public EventData MCKCODFDFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public StatusCode IADKPANPOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CHBBFJAILBD APDHIHOPKHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public JBLNFCIAPKC IPCFPMJFAGM;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public INFGBFLBCKM JCIALHFDOME
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7606F60", Offset = "0x7605B60", VA = "0x187606F60", Slot = "4")]
			get
			{
				return default(INFGBFLBCKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public GEDEGCEHLJI FOCIBNHJEOH
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x76072E0", Offset = "0x7605EE0", VA = "0x1876072E0", Slot = "5")]
			get
			{
				return default(GEDEGCEHLJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IIGOPABMBBE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7607200", Offset = "0x7605E00", VA = "0x187607200", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private bool JPIDOPMMCJC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7606DC0", Offset = "0x76059C0", VA = "0x187606DC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7606F80", Offset = "0x7605B80", VA = "0x187606F80", Slot = "8")]
		private (GEDEGCEHLJI, Dictionary<object, object>) IKAMJJGJEDG()
		{
			return default((GEDEGCEHLJI, Dictionary<object, object>));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7607210", Offset = "0x7605E10", VA = "0x187607210", Slot = "9")]
		private (FCEEFAMELLC, GEDEGCEHLJI) NDIJHIDFFJM()
		{
			return default((FCEEFAMELLC, GEDEGCEHLJI));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x76070E0", Offset = "0x7605CE0", VA = "0x1876070E0", Slot = "10")]
		private OAGNJIFNMLM<(FCEEFAMELLC, GEDEGCEHLJI)> JKJBDIKFAMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7606830", Offset = "0x7605430", VA = "0x187606830", Slot = "11")]
		private OAGNJIFNMLM<ONFOCFJPNHC> CCBNNHNOGLD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x76069A0", Offset = "0x76055A0", VA = "0x1876069A0", Slot = "12")]
		private (KADFMNJDFHC, byte[]) CDALCKDNKNF()
		{
			return default((KADFMNJDFHC, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7606BA0", Offset = "0x76057A0", VA = "0x187606BA0", Slot = "13")]
		private (NNOOGFJCHAK, byte[]) CMHHACAPPAJ()
		{
			return default((NNOOGFJCHAK, byte[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7607300", Offset = "0x7605F00", VA = "0x187607300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public BEHEOMBOENI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[DefaultMember("Item")]
	private class CHBBFJAILBD : OAGNJIFNMLM<(FCEEFAMELLC, GEDEGCEHLJI)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int[] CBFPJEMJJDH;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int FMELMONACEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76073B0", Offset = "0x7605FB0", VA = "0x1876073B0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public (FCEEFAMELLC view, GEDEGCEHLJI newOwner) MPDHFMNHCEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x76073D0", Offset = "0x7605FD0", VA = "0x1876073D0", Slot = "4")]
			get
			{
				return default((FCEEFAMELLC, GEDEGCEHLJI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CHBBFJAILBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DefaultMember("Item")]
	private class JBLNFCIAPKC : OAGNJIFNMLM<ONFOCFJPNHC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public object[] CBFPJEMJJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MAEFEDNCFEH KFKLNIAIIJP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int FMELMONACEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7607F60", Offset = "0x7606B60", VA = "0x187607F60", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ONFOCFJPNHC MPDHFMNHCEB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7607F80", Offset = "0x7606B80", VA = "0x187607F80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7608090", Offset = "0x7606C90", VA = "0x187608090")]
		public JBLNFCIAPKC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DefaultMember("Item")]
	private class MAEFEDNCFEH : ONFOCFJPNHC, OAGNJIFNMLM<KJOFAPGGGHI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public FCEEFAMELLC KFMOBMOKICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public object[] FKBJBKHIAAE;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FCEEFAMELLC CAJKBIGFBMC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9571A0", Offset = "0x955DA0", VA = "0x1809571A0", Slot = "4")]
			get
			{
				return default(FCEEFAMELLC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int FMELMONACEH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x76081A0", Offset = "0x7606DA0", VA = "0x1876081A0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KJOFAPGGGHI MPDHFMNHCEB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x76081C0", Offset = "0x7606DC0", VA = "0x1876081C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public MAEFEDNCFEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7607470", Offset = "0x7606070", VA = "0x187607470", Slot = "4")]
	public bool BBJMAAOBHIC(object LLDJIJICLJF, HOPAMIAMLDJ BJHNBEPINCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public FEEAHKCICCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class DNLELCDCKCF
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AlsoBindServiceAs(typeof(IFNHGENNFND))]
[RegisterService(typeof(BHKAFKBCAGJ), new string[] { "Photon" })]
public class IFNHGENNFND : PEGFAJCJPDH, HPCHENCNLKD, BHKAFKBCAGJ, KOCJNPNHOFD, EPCACDHCPJF, KKIFGLMKOAD
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[DependsOn]
	private PFNACAGABIF ENEHENBPLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[DependsOn]
	private DNIGMJDBIPO JPOIENOIFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Hashtable HBMPGPFHEDM;

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7607A60", Offset = "0x7606660", VA = "0x187607A60", Slot = "4")]
	public void InitReferences(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7607A10", Offset = "0x7606610", VA = "0x187607A10", Slot = "5")]
	public void GCKDBAMOHNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7607C90", Offset = "0x7606890", VA = "0x187607C90", Slot = "6")]
	public void MEIPBIKJOCA(NNOOGFJCHAK NKANGPLHEGE, ReadOnlySpan<byte> BFDCDDMLJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7607B70", Offset = "0x7606770", VA = "0x187607B70", Slot = "11")]
	public void MCMLCFFGNJE(NNOOGFJCHAK KFHJLJIAIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7607880", Offset = "0x7606480", VA = "0x187607880", Slot = "7")]
	public void DEEIPNMCPNA(ReadOnlySpan<NNOOGFJCHAK> DDEGCCKGOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7607620", Offset = "0x7606220", VA = "0x187607620")]
	private Hashtable ABALEMOLPBO(Hashtable LGEKHDFPEBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7607E00", Offset = "0x7606A00", VA = "0x187607E00", Slot = "8")]
	public void OnEvent(EventData MCKCODFDFLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7607B00", Offset = "0x7606700", VA = "0x187607B00", Slot = "9")]
	private void KOFKNPJJNIF(AILCBCECHFO CHJFHCEJGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xF92680", Offset = "0xF91280", VA = "0x180F92680", Slot = "10")]
	private void KNGPAJOOJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7607EE0", Offset = "0x7606AE0", VA = "0x187607EE0")]
	public IFNHGENNFND()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DLABOHGMBLK
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public DLABOHGMBLK()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
