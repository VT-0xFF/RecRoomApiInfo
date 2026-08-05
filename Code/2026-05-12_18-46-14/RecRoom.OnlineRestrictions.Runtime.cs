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
internal class TMRYTQGXOHE
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
	[Cpp2IlInjected.Address(RVA = "0x9D77350", Offset = "0x9D75D50", VA = "0x189D77350")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
	public TMRYTQGXOHE()
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
		[Cpp2IlInjected.Address(RVA = "0x9D78090", Offset = "0x9D76A90", VA = "0x189D78090", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2A16AE0", Offset = "0x2A154E0", VA = "0x182A16AE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : LWCSZZPQTXV
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class MXADJLHPKKM<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<DSRLWIHHTBI, a> XRWGOVHXGBY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a XHLSMLWWHCX;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public MXADJLHPKKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x70890E0", Offset = "0x7087AE0", VA = "0x1870890E0")]
			internal bool NIPPUNBUOFE(DSRLWIHHTBI a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class XKMSFCDUWSV<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> KOVRIKTEMVV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<DSRLWIHHTBI, a> XRWGOVHXGBY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a XHLSMLWWHCX;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
			public XKMSFCDUWSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5094C50", Offset = "0x5093650", VA = "0x185094C50")]
			internal bool VEBVCRZKTNZ(DSRLWIHHTBI a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<DSRLWIHHTBI> KKMNGIZFEHI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<DSRLWIHHTBI> GUBMDYZSYCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9D76C50", Offset = "0x9D75650", VA = "0x189D76C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9D76910", Offset = "0x9D75310", VA = "0x189D76910")]
		[ONTQUCAGRJW.Root.GameOnly]
		internal static void YITSWWEJPVO(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9D74E70", Offset = "0x9D73870", VA = "0x189D74E70")]
		private bool DUXBTYGSUFE(Func<DSRLWIHHTBI, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9D75700", Offset = "0x9D74100", VA = "0x189D75700")]
		private bool NXNSOQHIBTZ(Func<DSRLWIHHTBI, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3D78E00", Offset = "0x3D77800", VA = "0x183D78E00")]
		private bool BCWCJOZRLSY<a>(a a, Func<DSRLWIHHTBI, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D79160", Offset = "0x3D77B60", VA = "0x183D79160")]
		private bool RNMPGHUYCMX<b>(b a, Func<DSRLWIHHTBI, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9D748A0", Offset = "0x9D732A0", VA = "0x189D748A0", Slot = "4")]
		public bool BBKLWMEDLSB([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9D77120", Offset = "0x9D75B20", VA = "0x189D77120", Slot = "5")]
		public bool ZUTOKEOINAI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9D759B0", Offset = "0x9D743B0", VA = "0x189D759B0", Slot = "6")]
		public bool ORLRJHORXFE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9D749B0", Offset = "0x9D733B0", VA = "0x189D749B0", Slot = "7")]
		public bool BCINBKOHQUS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9D76390", Offset = "0x9D74D90", VA = "0x189D76390", Slot = "8")]
		public bool WATTFQRUMYU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9D74C90", Offset = "0x9D73690", VA = "0x189D74C90", Slot = "9")]
		public bool DPDXZWBFSUR(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9D74790", Offset = "0x9D73190", VA = "0x189D74790", Slot = "10")]
		public bool BBFQOWJRNEK([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9D76170", Offset = "0x9D74B70", VA = "0x189D76170", Slot = "11")]
		public bool UVWZJNNBPID([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9D766E0", Offset = "0x9D750E0", VA = "0x189D766E0", Slot = "12")]
		public bool XFZRFNCPQSO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9D76280", Offset = "0x9D74C80", VA = "0x189D76280", Slot = "13")]
		public bool UWTKYWJFGVV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9D76B40", Offset = "0x9D75540", VA = "0x189D76B40", Slot = "14")]
		public bool YPQHJTOVGCN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9D75BE0", Offset = "0x9D745E0", VA = "0x189D75BE0", Slot = "15")]
		public bool QRNBQGGHFAI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9D74550", Offset = "0x9D72F50", VA = "0x189D74550", Slot = "16")]
		public bool ARSAWDAHUOO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9D755E0", Offset = "0x9D73FE0", VA = "0x189D755E0", Slot = "17")]
		public bool NCMOXLHXCPF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9D764A0", Offset = "0x9D74EA0", VA = "0x189D764A0", Slot = "18")]
		public bool WCSDGRDAOCS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9D75CF0", Offset = "0x9D746F0", VA = "0x189D75CF0", Slot = "19")]
		public bool QRUDYAUVAFQ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9D754A0", Offset = "0x9D73EA0", VA = "0x189D754A0", Slot = "20")]
		public bool JBHZPOXETOL(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9D75360", Offset = "0x9D73D60", VA = "0x189D75360", Slot = "21")]
		public bool IFUGIMHYGMO(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9D75120", Offset = "0x9D73B20", VA = "0x189D75120", Slot = "22")]
		public bool HAKIOFGCTEV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9D77230", Offset = "0x9D75C30", VA = "0x189D77230", Slot = "23")]
		public bool ZYBRHRMXXBL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9D76EE0", Offset = "0x9D758E0", VA = "0x189D76EE0", Slot = "24")]
		public bool ZCFZWADLTFG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9D75AC0", Offset = "0x9D744C0", VA = "0x189D75AC0", Slot = "25")]
		public bool PAKLXIPIGRO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9D767F0", Offset = "0x9D751F0", VA = "0x189D767F0", Slot = "26")]
		public bool XJOIKCHMFCN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9D76050", Offset = "0x9D74A50", VA = "0x189D76050", Slot = "27")]
		public bool TTICXESCFGF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9D74410", Offset = "0x9D72E10", VA = "0x189D74410", Slot = "28")]
		public bool APGODWXHZLW(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9D74B70", Offset = "0x9D73570", VA = "0x189D74B70", Slot = "29")]
		public bool BWPIBHESLGE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9D75000", Offset = "0x9D73A00", VA = "0x189D75000", Slot = "30")]
		public bool GEAWWGHQWVN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9D77000", Offset = "0x9D75A00", VA = "0x189D77000", Slot = "31")]
		public bool ZMAEFIZKPLV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9D75F30", Offset = "0x9D74930", VA = "0x189D75F30", Slot = "32")]
		public bool TBUEIPJKDEE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9D76A00", Offset = "0x9D75400", VA = "0x189D76A00", Slot = "33")]
		public bool YOEIOFOSPHY(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9D74670", Offset = "0x9D73070", VA = "0x189D74670", Slot = "34")]
		public bool BAXKRVAWQHN([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9D765C0", Offset = "0x9D74FC0", VA = "0x189D765C0", Slot = "35")]
		public bool WXHEJBHXQYX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9D75E10", Offset = "0x9D74810", VA = "0x189D75E10", Slot = "36")]
		public bool RCZIPOIUIXO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9D75240", Offset = "0x9D73C40", VA = "0x189D75240", Slot = "37")]
		public bool HKAXRZCYGNZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9D75890", Offset = "0x9D74290", VA = "0x189D75890", Slot = "38")]
		public bool ODMVHXODIGO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9D74AC0", Offset = "0x9D734C0", VA = "0x189D74AC0", Slot = "39")]
		public string BMEWEWHUWUC(OnlineRestrictionsSources a)
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
