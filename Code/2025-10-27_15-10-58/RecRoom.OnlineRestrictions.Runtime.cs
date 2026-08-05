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
internal class MZHUOFNWOZJ
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
	[Cpp2IlInjected.Address(RVA = "0x8AFBBB0", Offset = "0x8AFABB0", VA = "0x188AFBBB0")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
	public MZHUOFNWOZJ()
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
		[Cpp2IlInjected.Address(RVA = "0x8AFFA80", Offset = "0x8AFEA80", VA = "0x188AFFA80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x29F5B20", Offset = "0x29F4B20", VA = "0x1829F5B20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : QRQGQCAFBFG
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class QDUEEIHCIQZ<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<TXVRNCOVDVL, a> JZIKEPRYBIX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a HJXXSDGPTVS;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public QDUEEIHCIQZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5E31740", Offset = "0x5E30740", VA = "0x185E31740")]
			internal bool IMACEBUSVMF(TXVRNCOVDVL a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class EHTNCMABYIA<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> JINUCXBJMEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<TXVRNCOVDVL, a> JZIKEPRYBIX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a HJXXSDGPTVS;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public EHTNCMABYIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4A72E30", Offset = "0x4A71E30", VA = "0x184A72E30")]
			internal bool NVVRULQNJKA(TXVRNCOVDVL a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<TXVRNCOVDVL> WMVZWRSFBCB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<TXVRNCOVDVL> NUYYDGYOCRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8AFC7A0", Offset = "0x8AFB7A0", VA = "0x188AFC7A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8AFDEE0", Offset = "0x8AFCEE0", VA = "0x188AFDEE0")]
		[OKVIBKJHYHD.Root.GameOnly]
		internal static void OWHETCSRPYN(QXIJOLGHAIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD780", Offset = "0x8AFC780", VA = "0x188AFD780")]
		private bool MIXWHOFZXMX(Func<TXVRNCOVDVL, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AFE5B0", Offset = "0x8AFD5B0", VA = "0x188AFE5B0")]
		private bool UTSTJAGDWVY(Func<TXVRNCOVDVL, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3B96FA0", Offset = "0x3B95FA0", VA = "0x183B96FA0")]
		private bool URGUVNYJABF<a>(a a, Func<TXVRNCOVDVL, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3B96CE0", Offset = "0x3B95CE0", VA = "0x183B96CE0")]
		private bool SRNECEZXYHG<b>(b a, Func<TXVRNCOVDVL, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCA50", Offset = "0x8AFBA50", VA = "0x188AFCA50", Slot = "4")]
		public bool DOCAGXHVNKO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBD40", Offset = "0x8AFAD40", VA = "0x188AFBD40", Slot = "5")]
		public bool AMCLSQWKAMR([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBF90", Offset = "0x8AFAF90", VA = "0x188AFBF90", Slot = "6")]
		public bool BEXUPQNCDBP([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8AFE860", Offset = "0x8AFD860", VA = "0x188AFE860", Slot = "7")]
		public bool XHYRFEBMRDP([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8AFE740", Offset = "0x8AFD740", VA = "0x188AFE740", Slot = "8")]
		public bool VKVTCMESSZH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC0B0", Offset = "0x8AFB0B0", VA = "0x188AFC0B0", Slot = "9")]
		public bool CFPBTUJSWXU(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCB70", Offset = "0x8AFBB70", VA = "0x188AFCB70", Slot = "10")]
		public bool DQNPZTMFTVV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8AFE980", Offset = "0x8AFD980", VA = "0x188AFE980", Slot = "11")]
		public bool XUPUWXEQLXE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8AFDDC0", Offset = "0x8AFCDC0", VA = "0x188AFDDC0", Slot = "12")]
		public bool OUCIWGXCTWZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC400", Offset = "0x8AFB400", VA = "0x188AFC400", Slot = "13")]
		public bool CMFXBGJZHYC([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8AFE360", Offset = "0x8AFD360", VA = "0x188AFE360", Slot = "14")]
		public bool TJJVHYRILSY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8AFDB70", Offset = "0x8AFCB70", VA = "0x188AFDB70", Slot = "15")]
		public bool ODLFPRPHBVF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8AFEBD0", Offset = "0x8AFDBD0", VA = "0x188AFEBD0", Slot = "16")]
		public bool YJKJRBBSCCX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8AFEAA0", Offset = "0x8AFDAA0", VA = "0x188AFEAA0", Slot = "17")]
		public bool YDMUBLXREXK([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8AFDC90", Offset = "0x8AFCC90", VA = "0x188AFDC90", Slot = "18")]
		public bool OQFOLFGXDYT([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD650", Offset = "0x8AFC650", VA = "0x188AFD650", Slot = "19")]
		public bool KGSFOIGZYER([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC2B0", Offset = "0x8AFB2B0", VA = "0x188AFC2B0", Slot = "20")]
		public bool CIISPJVPSZW(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD020", Offset = "0x8AFC020", VA = "0x188AFD020", Slot = "21")]
		public bool HFAZDTCHMPR(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFDFD0", Offset = "0x8AFCFD0", VA = "0x188AFDFD0", Slot = "22")]
		public bool QTJUBIHTNKI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC670", Offset = "0x8AFB670", VA = "0x188AFC670", Slot = "23")]
		public bool DNVFCIODWHS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD910", Offset = "0x8AFC910", VA = "0x188AFD910", Slot = "24")]
		public bool MUUOQDORYQN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCC90", Offset = "0x8AFBC90", VA = "0x188AFCC90", Slot = "25")]
		public bool EOESZPVRHKH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8AFE230", Offset = "0x8AFD230", VA = "0x188AFE230", Slot = "26")]
		public bool TGJUQVDLAOG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8AFE480", Offset = "0x8AFD480", VA = "0x188AFE480", Slot = "27")]
		public bool UJLGFEXVKPI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD2A0", Offset = "0x8AFC2A0", VA = "0x188AFD2A0", Slot = "28")]
		public bool IQJNAJGJYSL(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD520", Offset = "0x8AFC520", VA = "0x188AFD520", Slot = "29")]
		public bool JDTJKUIPQMN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCDC0", Offset = "0x8AFBDC0", VA = "0x188AFCDC0", Slot = "30")]
		public bool FTVFWDHHMCG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD170", Offset = "0x8AFC170", VA = "0x188AFD170", Slot = "31")]
		public bool IPEPSSDGCRO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8AFCEF0", Offset = "0x8AFBEF0", VA = "0x188AFCEF0", Slot = "32")]
		public bool GYKROQFZVFJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC520", Offset = "0x8AFB520", VA = "0x188AFC520", Slot = "33")]
		public bool CSZNDREMDOZ(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBE60", Offset = "0x8AFAE60", VA = "0x188AFBE60", Slot = "34")]
		public bool BBLTKFTAYFC([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8AFD3F0", Offset = "0x8AFC3F0", VA = "0x188AFD3F0", Slot = "35")]
		public bool JDDUIDYTZFG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8AFECF0", Offset = "0x8AFDCF0", VA = "0x188AFECF0", Slot = "36")]
		public bool ZIZXIAJUDOX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8AFDA40", Offset = "0x8AFCA40", VA = "0x188AFDA40", Slot = "37")]
		public bool NIKUUECKMMG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFE100", Offset = "0x8AFD100", VA = "0x188AFE100", Slot = "38")]
		public bool SUKLSTVPHNP([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8AFBC90", Offset = "0x8AFAC90", VA = "0x188AFBC90", Slot = "39")]
		public string AIRSSEQXYEN(OnlineRestrictionsSources a)
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
