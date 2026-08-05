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
internal class SVGOSYYBXCW
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
	[Cpp2IlInjected.Address(RVA = "0x9DD5090", Offset = "0x9DD4090", VA = "0x189DD5090")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
	public SVGOSYYBXCW()
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
		[Cpp2IlInjected.Address(RVA = "0x9DD5DD0", Offset = "0x9DD4DD0", VA = "0x189DD5DD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2A0E020", Offset = "0x2A0D020", VA = "0x182A0E020")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : BEXQCYIXEDV
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class ZSPODLREJLS<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<HZJYCFMSXGS, a> BQPVEDANDTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a JNWDLXQRNSD;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public ZSPODLREJLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x519BD50", Offset = "0x519AD50", VA = "0x18519BD50")]
			internal bool JHDNJMYYKQC(HZJYCFMSXGS a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MIUEGKWZJUZ<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> BFYQFUHNICP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<HZJYCFMSXGS, a> BQPVEDANDTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a JNWDLXQRNSD;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public MIUEGKWZJUZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7015430", Offset = "0x7014430", VA = "0x187015430")]
			internal bool AXECQPYZGCH(HZJYCFMSXGS a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<HZJYCFMSXGS> CNTDUWZJNRE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<HZJYCFMSXGS> OAGVARRRFGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9DD3B40", Offset = "0x9DD2B40", VA = "0x189DD3B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9DD37B0", Offset = "0x9DD27B0", VA = "0x189DD37B0")]
		[GEPWJNEAFDW.Root.GameOnly]
		internal static void OOJUVPXBNPG(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4C00", Offset = "0x9DD3C00", VA = "0x189DD4C00")]
		private bool XMSZMYVYJTY(Func<HZJYCFMSXGS, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4820", Offset = "0x9DD3820", VA = "0x189DD4820")]
		private bool VDLATKQMYMP(Func<HZJYCFMSXGS, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3DA4B70", Offset = "0x3DA3B70", VA = "0x183DA4B70")]
		private bool GEDQKBXUOCA<a>(a a, Func<HZJYCFMSXGS, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3DA4ED0", Offset = "0x3DA3ED0", VA = "0x183DA4ED0")]
		private bool WJYWYXUZAQT<b>(b a, Func<HZJYCFMSXGS, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4F70", Offset = "0x9DD3F70", VA = "0x189DD4F70", Slot = "4")]
		public bool ZUICRIERSND([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4250", Offset = "0x9DD3250", VA = "0x189DD4250", Slot = "5")]
		public bool SIYUKQPRAAI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD44A0", Offset = "0x9DD34A0", VA = "0x189DD44A0", Slot = "6")]
		public bool TYKBNLXUQEO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3430", Offset = "0x9DD2430", VA = "0x189DD3430", Slot = "7")]
		public bool JGGVLSQLJAC([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4AE0", Offset = "0x9DD3AE0", VA = "0x189DD4AE0", Slot = "8")]
		public bool WJWUTMHHZWA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3DF0", Offset = "0x9DD2DF0", VA = "0x189DD3DF0", Slot = "9")]
		public bool RFYEJMGRTHT(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2740", Offset = "0x9DD1740", VA = "0x189DD2740", Slot = "10")]
		public bool EKHCDSFIIAC([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9DD22A0", Offset = "0x9DD12A0", VA = "0x189DD22A0", Slot = "11")]
		public bool CFYBRIGYPXZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2030", Offset = "0x9DD1030", VA = "0x189DD2030", Slot = "12")]
		public bool BOZLBMPAQZU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2E30", Offset = "0x9DD1E30", VA = "0x189DD2E30", Slot = "13")]
		public bool HQZIGVCJQTV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9DD24F0", Offset = "0x9DD14F0", VA = "0x189DD24F0", Slot = "14")]
		public bool DAIJARSNKFT([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2990", Offset = "0x9DD1990", VA = "0x189DD2990", Slot = "15")]
		public bool GUZUNZEUKAY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2BE0", Offset = "0x9DD1BE0", VA = "0x189DD2BE0", Slot = "16")]
		public bool HGLPPPUZDDM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2860", Offset = "0x9DD1860", VA = "0x189DD2860", Slot = "17")]
		public bool ENKLJBSLOXZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9DD46F0", Offset = "0x9DD36F0", VA = "0x189DD46F0", Slot = "18")]
		public bool UYJHHJLGRWS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3300", Offset = "0x9DD2300", VA = "0x189DD3300", Slot = "19")]
		public bool JDBLHVMNFTU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2150", Offset = "0x9DD1150", VA = "0x189DD2150", Slot = "20")]
		public bool CCYINPMPKPB(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD38A0", Offset = "0x9DD28A0", VA = "0x189DD38A0", Slot = "21")]
		public bool OQNGBOZRCYK(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3680", Offset = "0x9DD2680", VA = "0x189DD3680", Slot = "22")]
		public bool OJOEZAEVAXH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD1F00", Offset = "0x9DD0F00", VA = "0x189DD1F00", Slot = "23")]
		public bool BJTAGDAMBGN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2D00", Offset = "0x9DD1D00", VA = "0x189DD2D00", Slot = "24")]
		public bool HIYRQBUHPAE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4D90", Offset = "0x9DD3D90", VA = "0x189DD4D90", Slot = "25")]
		public bool YXSLJITIGZK([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3550", Offset = "0x9DD2550", VA = "0x189DD3550", Slot = "26")]
		public bool KMMLDTZMIVP([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4370", Offset = "0x9DD3370", VA = "0x189DD4370", Slot = "27")]
		public bool SWTPKHYFBEV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2F50", Offset = "0x9DD1F50", VA = "0x189DD2F50", Slot = "28")]
		public bool HXDYNQCERSU(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9DD23C0", Offset = "0x9DD13C0", VA = "0x189DD23C0", Slot = "29")]
		public bool CHCYRGWSOEY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2610", Offset = "0x9DD1610", VA = "0x189DD2610", Slot = "30")]
		public bool DDHSLFOECCH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4120", Offset = "0x9DD3120", VA = "0x189DD4120", Slot = "31")]
		public bool RYXVHPSQMTN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DD3FF0", Offset = "0x9DD2FF0", VA = "0x189DD3FF0", Slot = "32")]
		public bool ROLYLIRKIZC([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DD39F0", Offset = "0x9DD29F0", VA = "0x189DD39F0", Slot = "33")]
		public bool PDDVINBBLBA(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9DD31D0", Offset = "0x9DD21D0", VA = "0x189DD31D0", Slot = "34")]
		public bool IXMPFMDSOOT([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DD2AB0", Offset = "0x9DD1AB0", VA = "0x189DD2AB0", Slot = "35")]
		public bool HBPSWVKAJGD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DD49B0", Offset = "0x9DD39B0", VA = "0x189DD49B0", Slot = "36")]
		public bool WDFUJOEOEFG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD30A0", Offset = "0x9DD20A0", VA = "0x189DD30A0", Slot = "37")]
		public bool IPNHCGZKSLZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9DD45C0", Offset = "0x9DD35C0", VA = "0x189DD45C0", Slot = "38")]
		public bool UQBSBZLMISC([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9DD4EC0", Offset = "0x9DD3EC0", VA = "0x189DD4EC0", Slot = "39")]
		public string ZPWBXRKALNA(OnlineRestrictionsSources a)
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
