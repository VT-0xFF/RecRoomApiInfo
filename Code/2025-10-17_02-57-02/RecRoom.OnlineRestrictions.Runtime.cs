using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using UJect;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class ZFXGPLLYWZU
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x88E16B0", Offset = "0x88DFCB0", VA = "0x1888E16B0")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
	public ZFXGPLLYWZU()
	{
	}
}
namespace _AssemblyRegistry.RecRoom_OnlineRestrictions_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88E1790", Offset = "0x88DFD90", VA = "0x1888E1790", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : SLGKQDZWFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class HGOUKDFWUVK<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<VFPQIWZTZAG, a> HBZFZBZFOLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a PHVDAZUACKP;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public HGOUKDFWUVK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x511D8C0", Offset = "0x511BEC0", VA = "0x18511D8C0")]
			internal bool UVWICWSFRTI(VFPQIWZTZAG a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DXGQBPQUBDD<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> UUCLCXWCXHR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<VFPQIWZTZAG, a> HBZFZBZFOLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a PHVDAZUACKP;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public DXGQBPQUBDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x431F6D0", Offset = "0x431DCD0", VA = "0x18431F6D0")]
			internal bool TXYUYKCQOET(VFPQIWZTZAG a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<VFPQIWZTZAG> PNDCQPXRKZY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<VFPQIWZTZAG> NASDTXZWBNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x88DE810", Offset = "0x88DCE10", VA = "0x1888DE810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88DF5E0", Offset = "0x88DDBE0", VA = "0x1888DF5E0")]
		[ZOKCDQOPSGU.Root.GameOnly]
		internal static void RHSGAVCKHMM(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88DE680", Offset = "0x88DCC80", VA = "0x1888DE680")]
		private bool IVMGFBNWKRQ(Func<VFPQIWZTZAG, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88DE1B0", Offset = "0x88DC7B0", VA = "0x1888DE1B0")]
		private bool HNQLQMYREVF(Func<VFPQIWZTZAG, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3B25510", Offset = "0x3B23B10", VA = "0x183B25510")]
		private bool XCXNRJJBKGY<a>(a a, Func<VFPQIWZTZAG, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3B25260", Offset = "0x3B23860", VA = "0x183B25260")]
		private bool AUZJOPFXJDZ<b>(b a, Func<VFPQIWZTZAG, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88DF4D0", Offset = "0x88DDAD0", VA = "0x1888DF4D0", Slot = "4")]
		public bool QVEDIWDTPUR([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88DDD40", Offset = "0x88DC340", VA = "0x1888DDD40", Slot = "5")]
		public bool EGOKSSCFYYQ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88DECD0", Offset = "0x88DD2D0", VA = "0x1888DECD0", Slot = "6")]
		public bool MAHLQHZNJDE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88DE460", Offset = "0x88DCA60", VA = "0x1888DE460", Slot = "7")]
		public bool HWLPSIBDJJA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88DE570", Offset = "0x88DCB70", VA = "0x1888DE570", Slot = "8")]
		public bool IHNUAMNCERW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88E0620", Offset = "0x88DEC20", VA = "0x1888E0620", Slot = "9")]
		public bool XDLQMEDXEPX(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88DF7F0", Offset = "0x88DDDF0", VA = "0x1888DF7F0", Slot = "10")]
		public bool RXJDQMSYTYO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88DFEC0", Offset = "0x88DE4C0", VA = "0x1888DFEC0", Slot = "11")]
		public bool TUDLLGSLSID([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88DDC30", Offset = "0x88DC230", VA = "0x1888DDC30", Slot = "12")]
		public bool BWZOSYVIMFU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88E0800", Offset = "0x88DEE00", VA = "0x1888E0800", Slot = "13")]
		public bool XIYPYRULTEH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88DEF00", Offset = "0x88DD500", VA = "0x1888DEF00", Slot = "14")]
		public bool MQKMFHYWCFD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88DEBC0", Offset = "0x88DD1C0", VA = "0x1888DEBC0", Slot = "15")]
		public bool LSDVEJSAOWU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x88DF6D0", Offset = "0x88DDCD0", VA = "0x1888DF6D0", Slot = "16")]
		public bool RWEZNFTDEZE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88DDE50", Offset = "0x88DC450", VA = "0x1888DDE50", Slot = "17")]
		public bool GJRIVSNAEIX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88E0080", Offset = "0x88DE680", VA = "0x1888E0080", Slot = "18")]
		public bool UVDFFMOSYKG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x88DF900", Offset = "0x88DDF00", VA = "0x1888DF900", Slot = "19")]
		public bool RXZQZEVKESS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x88DF010", Offset = "0x88DD610", VA = "0x1888DF010", Slot = "20")]
		public bool NXCJQNNQRCH(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88E0910", Offset = "0x88DEF10", VA = "0x1888E0910", Slot = "21")]
		public bool XMRCNKLWOMS(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88DE090", Offset = "0x88DC690", VA = "0x1888DE090", Slot = "22")]
		public bool HBVAEZCJMZL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88DF290", Offset = "0x88DD890", VA = "0x1888DF290", Slot = "23")]
		public bool PHZTWFURTJH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88DEDE0", Offset = "0x88DD3E0", VA = "0x1888DEDE0", Slot = "24")]
		public bool MEINEUJWHGI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88DFB40", Offset = "0x88DE140", VA = "0x1888DFB40", Slot = "25")]
		public bool SXHQSTDUTII([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88DFA20", Offset = "0x88DE020", VA = "0x1888DFA20", Slot = "26")]
		public bool SRPOLKMJTOJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x88E01A0", Offset = "0x88DE7A0", VA = "0x1888E01A0", Slot = "27")]
		public bool UWBWAUEEHOJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88DF150", Offset = "0x88DD750", VA = "0x1888DF150", Slot = "28")]
		public bool PCPSJGBXAKY(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x88DFDA0", Offset = "0x88DE3A0", VA = "0x1888DFDA0", Slot = "29")]
		public bool TTCPMTPFTUE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88DDF70", Offset = "0x88DC570", VA = "0x1888DDF70", Slot = "30")]
		public bool GSEHRIBREOH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88DEAA0", Offset = "0x88DD0A0", VA = "0x1888DEAA0", Slot = "31")]
		public bool KKNDVNSNAGP([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x88E02C0", Offset = "0x88DE8C0", VA = "0x1888E02C0", Slot = "32")]
		public bool WCKFAIUMLMQ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x88DFC60", Offset = "0x88DE260", VA = "0x1888DFC60", Slot = "33")]
		public bool TCUHKXJTRJA(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88E0500", Offset = "0x88DEB00", VA = "0x1888E0500", Slot = "34")]
		public bool WZBPKEOXWTR([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88E03E0", Offset = "0x88DE9E0", VA = "0x1888E03E0", Slot = "35")]
		public bool WOLNLOWAOZJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x88DDB10", Offset = "0x88DC110", VA = "0x1888DDB10", Slot = "36")]
		public bool BRIIRPWSOSE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x88DF3B0", Offset = "0x88DD9B0", VA = "0x1888DF3B0", Slot = "37")]
		public bool QNJMOUGFUUX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88DE340", Offset = "0x88DC940", VA = "0x1888DE340", Slot = "38")]
		public bool HOHKPXWPKFM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88DFFD0", Offset = "0x88DE5D0", VA = "0x1888DFFD0", Slot = "39")]
		public string TWYDKRHFZHE(OnlineRestrictionsSources a)
		{
			return null;
		}
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
