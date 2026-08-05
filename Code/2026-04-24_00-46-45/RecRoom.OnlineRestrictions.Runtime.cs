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
internal class YKXBFGPKFMQ
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
	[Cpp2IlInjected.Address(RVA = "0x9DA5DB0", Offset = "0x9DA47B0", VA = "0x189DA5DB0")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
	public YKXBFGPKFMQ()
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
		[Cpp2IlInjected.Address(RVA = "0x9DA5E90", Offset = "0x9DA4890", VA = "0x189DA5E90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E140", Offset = "0x2A2CB40", VA = "0x182A2E140")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : BMITHGLGCIV
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class LOHVEAZHKAS<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<YFYTBBKICBC, a> KXXYZPIBHWI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a BSLJFOZKPBT;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LOHVEAZHKAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x68CF7F0", Offset = "0x68CE1F0", VA = "0x1868CF7F0")]
			internal bool XZKNMZAQIUM(YFYTBBKICBC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GOWPOWOBACT<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> YVLUVJIVPTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<YFYTBBKICBC, a> KXXYZPIBHWI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a BSLJFOZKPBT;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public GOWPOWOBACT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6469550", Offset = "0x6467F50", VA = "0x186469550")]
			internal bool PBXNAIVMMWF(YFYTBBKICBC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<YFYTBBKICBC> DEKVFGYUMJO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<YFYTBBKICBC> COZILMXTWIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9DA4480", Offset = "0x9DA2E80", VA = "0x189DA4480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9DA3DD0", Offset = "0x9DA27D0", VA = "0x189DA3DD0")]
		[BRMSZAJTATI.Root.GameOnly]
		internal static void RVLHKCZZZLE(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9DA4D40", Offset = "0x9DA3740", VA = "0x189DA4D40")]
		private bool YHTFEFVNRAQ(Func<YFYTBBKICBC, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9DA30E0", Offset = "0x9DA1AE0", VA = "0x189DA30E0")]
		private bool JEMYQVCDMEV(Func<YFYTBBKICBC, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3D9B930", Offset = "0x3D9A330", VA = "0x183D9B930")]
		private bool BVFQVSJPWXQ<a>(a a, Func<YFYTBBKICBC, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3D9BC90", Offset = "0x3D9A690", VA = "0x183D9BC90")]
		private bool HJCINBYVZVL<b>(b a, Func<YFYTBBKICBC, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2930", Offset = "0x9DA1330", VA = "0x189DA2930", Slot = "4")]
		public bool EZZRUIGRBVV([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2480", Offset = "0x9DA0E80", VA = "0x189DA2480", Slot = "5")]
		public bool BQPYTWUWOHE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9DA3940", Offset = "0x9DA2340", VA = "0x189DA3940", Slot = "6")]
		public bool OGRDBPBRSFC([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9DA3A60", Offset = "0x9DA2460", VA = "0x189DA3A60", Slot = "7")]
		public bool PGZXDTLSOXS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2CC0", Offset = "0x9DA16C0", VA = "0x189DA2CC0", Slot = "8")]
		public bool GQCOEDZPYDA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9DA33A0", Offset = "0x9DA1DA0", VA = "0x189DA33A0", Slot = "9")]
		public bool KUGVWIKJOWH(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2A50", Offset = "0x9DA1450", VA = "0x189DA2A50", Slot = "10")]
		public bool FSNEFUOJTAM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9DA4360", Offset = "0x9DA2D60", VA = "0x189DA4360", Slot = "11")]
		public bool UZFSSGXYTIF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2FC0", Offset = "0x9DA19C0", VA = "0x189DA2FC0", Slot = "12")]
		public bool IURNLRUHFJG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9DA3820", Offset = "0x9DA2220", VA = "0x189DA3820", Slot = "13")]
		public bool NIEMGMYPFUF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9DA3CB0", Offset = "0x9DA26B0", VA = "0x189DA3CB0", Slot = "14")]
		public bool ROVMKSAPQJF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9DA3EC0", Offset = "0x9DA28C0", VA = "0x189DA3EC0", Slot = "15")]
		public bool SRUBEGOTYTA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9DA3FE0", Offset = "0x9DA29E0", VA = "0x189DA3FE0", Slot = "16")]
		public bool SZODLQLWZOE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2220", Offset = "0x9DA0C20", VA = "0x189DA2220", Slot = "17")]
		public bool BCDLLISNDFD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2350", Offset = "0x9DA0D50", VA = "0x189DA2350", Slot = "18")]
		public bool BPLOXYMBAOA([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9DA4230", Offset = "0x9DA2C30", VA = "0x189DA4230", Slot = "19")]
		public bool UIMVTTPJNNS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9DA36D0", Offset = "0x9DA20D0", VA = "0x189DA36D0", Slot = "20")]
		public bool LYAYQQIVLKN(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2B70", Offset = "0x9DA1570", VA = "0x189DA2B70", Slot = "21")]
		public bool FWOJHSSVHVO(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9DA49B0", Offset = "0x9DA33B0", VA = "0x189DA49B0", Slot = "22")]
		public bool WPPUIGCOJOT([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9DA26D0", Offset = "0x9DA10D0", VA = "0x189DA26D0", Slot = "23")]
		public bool CSRCWBMETKD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9DA35A0", Offset = "0x9DA1FA0", VA = "0x189DA35A0", Slot = "24")]
		public bool LJOKVMRXSWG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9DA4880", Offset = "0x9DA3280", VA = "0x189DA4880", Slot = "25")]
		public bool WGYEIJNOTTY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9DA4AE0", Offset = "0x9DA34E0", VA = "0x189DA4AE0", Slot = "26")]
		public bool WSFQTQIYBAH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9DA20F0", Offset = "0x9DA0AF0", VA = "0x189DA20F0", Slot = "27")]
		public bool ALEPAQUGAQT([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9DA5000", Offset = "0x9DA3A00", VA = "0x189DA5000", Slot = "28")]
		public bool YXARQXDJVBM(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9DA4100", Offset = "0x9DA2B00", VA = "0x189DA4100", Slot = "29")]
		public bool TORYBMTRJTU([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2E90", Offset = "0x9DA1890", VA = "0x189DA2E90", Slot = "30")]
		public bool IJAUXCZONAR([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DA4ED0", Offset = "0x9DA38D0", VA = "0x189DA4ED0", Slot = "31")]
		public bool YHYYIPZBNXX([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DA3270", Offset = "0x9DA1C70", VA = "0x189DA3270", Slot = "32")]
		public bool KRDJHQWWWPY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DA4730", Offset = "0x9DA3130", VA = "0x189DA4730", Slot = "33")]
		public bool WFJOEWSNBLC(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9DA1FC0", Offset = "0x9DA09C0", VA = "0x189DA1FC0", Slot = "34")]
		public bool ABEZZBFSGAR([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DA4C10", Offset = "0x9DA3610", VA = "0x189DA4C10", Slot = "35")]
		public bool XLHYRZXLQON([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2800", Offset = "0x9DA1200", VA = "0x189DA2800", Slot = "36")]
		public bool EMNWWSMNCLM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DA3B80", Offset = "0x9DA2580", VA = "0x189DA3B80", Slot = "37")]
		public bool QKLCAAYYNFH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9DA25A0", Offset = "0x9DA0FA0", VA = "0x189DA25A0", Slot = "38")]
		public bool BWCTBLXGYRG([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9DA2DE0", Offset = "0x9DA17E0", VA = "0x189DA2DE0", Slot = "39")]
		public string HNUOZVEPDGU(OnlineRestrictionsSources a)
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
