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
internal class XZYMFDMNRDD
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
	[Cpp2IlInjected.Address(RVA = "0x870F1D0", Offset = "0x870DBD0", VA = "0x18870F1D0")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
	public XZYMFDMNRDD()
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
		[Cpp2IlInjected.Address(RVA = "0x870F2B0", Offset = "0x870DCB0", VA = "0x18870F2B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2748530", Offset = "0x2746F30", VA = "0x182748530")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.OnlineRestrictions
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[UnityEngine.Scripting.Preserve]
	public class OnlineRestrictions : VZVYRIFALVM
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class SCWKGOWGJNF<a> where a : Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Func<TUMPDAGUHBR, a> EDTGDOMBWIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public a OLLNIORNCPE;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public SCWKGOWGJNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5EE48A0", Offset = "0x5EE32A0", VA = "0x185EE48A0")]
			internal bool PONRYKYUODR(TUMPDAGUHBR a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class UUWDFCKUVFQ<a> where a : struct, Enum
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Func<a, int> DXHKBHANMHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Func<TUMPDAGUHBR, a> EDTGDOMBWIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public a OLLNIORNCPE;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public UUWDFCKUVFQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x623E770", Offset = "0x623D170", VA = "0x18623E770")]
			internal bool HKSCCEHKCHU(TUMPDAGUHBR a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<TUMPDAGUHBR> RPXFYDCFSUL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private List<TUMPDAGUHBR> MQADRBDAAEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x870CC40", Offset = "0x870B640", VA = "0x18870CC40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x870C810", Offset = "0x870B210", VA = "0x18870C810")]
		[UKOBXVXKPZF.Root.GameOnly]
		internal static void NLNDLFOXCAL(PKSJLYSCDCL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		[UnityEngine.Scripting.Preserve]
		internal OnlineRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x870D760", Offset = "0x870C160", VA = "0x18870D760")]
		private bool WDIYOKKZAON(Func<TUMPDAGUHBR, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x870D8F0", Offset = "0x870C2F0", VA = "0x18870D8F0")]
		private bool XQTYJDYRMGA(Func<TUMPDAGUHBR, bool> a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x38D2C20", Offset = "0x38D1620", VA = "0x1838D2C20")]
		private bool PBGITNMRXCV<a>(a a, Func<TUMPDAGUHBR, a> b, [Out] OnlineRestrictionsSources c) where a : Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x38D2960", Offset = "0x38D1360", VA = "0x1838D2960")]
		private bool MELBDPBCBHE<b>(b a, Func<TUMPDAGUHBR, b> b, Func<b, int> c, [Out] OnlineRestrictionsSources d) where b : struct, Enum
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x870C3A0", Offset = "0x870ADA0", VA = "0x18870C3A0", Slot = "4")]
		public bool KZSYOSAMMQY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x870CA20", Offset = "0x870B420", VA = "0x18870CA20", Slot = "5")]
		public bool PTHQWZETVBJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x870CFF0", Offset = "0x870B9F0", VA = "0x18870CFF0", Slot = "6")]
		public bool UEDHLHPOFGP([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x870E180", Offset = "0x870CB80", VA = "0x18870E180", Slot = "7")]
		public bool ZCBNOIRQDHF([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x870D510", Offset = "0x870BF10", VA = "0x18870D510", Slot = "8")]
		public bool VFVKLZCEMFJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x870D100", Offset = "0x870BB00", VA = "0x18870D100", Slot = "9")]
		public bool UGAPWDCTGEU(PlayerRelationships a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x870E3B0", Offset = "0x870CDB0", VA = "0x18870E3B0", Slot = "10")]
		public bool ZVPUNFYXXXL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x870B890", Offset = "0x870A290", VA = "0x18870B890", Slot = "11")]
		public bool DTWTHQAEWPS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x870BAC0", Offset = "0x870A4C0", VA = "0x18870BAC0", Slot = "12")]
		public bool DYTZNHUFNPZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x870BF30", Offset = "0x870A930", VA = "0x18870BF30", Slot = "13")]
		public bool IYGUPWZIRSY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x870D400", Offset = "0x870BE00", VA = "0x18870D400", Slot = "14")]
		public bool VFVDPHTJJUK([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x870CB30", Offset = "0x870B530", VA = "0x18870CB30", Slot = "15")]
		public bool QCMLZYEZECZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x870CED0", Offset = "0x870B8D0", VA = "0x18870CED0", Slot = "16")]
		public bool STYHNQEDAXH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x870DDE0", Offset = "0x870C7E0", VA = "0x18870DDE0", Slot = "17")]
		public bool YOMRTHZBHTM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x870DA80", Offset = "0x870C480", VA = "0x18870DA80", Slot = "18")]
		public bool XTJTADTXJPT([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x870DBA0", Offset = "0x870C5A0", VA = "0x18870DBA0", Slot = "19")]
		public bool XUOMFMUHOHJ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x870E040", Offset = "0x870CA40", VA = "0x18870E040", Slot = "20")]
		public bool YRQZHCGYJJM(CreationRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x870D620", Offset = "0x870C020", VA = "0x18870D620", Slot = "21")]
		public bool VKZXFSVAAIN(DrawingRooms a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x870B9A0", Offset = "0x870A3A0", VA = "0x18870B9A0", Slot = "22")]
		public bool DYPUCLJGVGC([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x870C5D0", Offset = "0x870AFD0", VA = "0x18870C5D0", Slot = "23")]
		public bool MVHLFYIRGXM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x870C6F0", Offset = "0x870B0F0", VA = "0x18870C6F0", Slot = "24")]
		public bool MYYHWFJXVCL([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x870BBD0", Offset = "0x870A5D0", VA = "0x18870BBD0", Slot = "25")]
		public bool EHZNUIRCQHD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x870C280", Offset = "0x870AC80", VA = "0x18870C280", Slot = "26")]
		public bool KBJXFWSIBRS([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x870C040", Offset = "0x870AA40", VA = "0x18870C040", Slot = "27")]
		public bool JGETYTSROWI([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x870DF00", Offset = "0x870C900", VA = "0x18870DF00", Slot = "28")]
		public bool YPMEWUYBQLD(SharecamVisibleObjects a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x870B630", Offset = "0x870A030", VA = "0x18870B630", Slot = "29")]
		public bool AGBHDIFYQMH([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x870C160", Offset = "0x870AB60", VA = "0x18870C160", Slot = "30")]
		public bool JWCWLJMJUCE([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x870C4B0", Offset = "0x870AEB0", VA = "0x18870C4B0", Slot = "31")]
		public bool LFSHSHYONZM([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x870D2E0", Offset = "0x870BCE0", VA = "0x18870D2E0", Slot = "32")]
		public bool UKGRCOZMWFD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x870B750", Offset = "0x870A150", VA = "0x18870B750", Slot = "33")]
		public bool CDAFVKRQYKX(UGCPublishedClubAnnouncements a, [Out] OnlineRestrictionsSources b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x870E290", Offset = "0x870CC90", VA = "0x18870E290", Slot = "34")]
		public bool ZKITWTRVZAW([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x870BCF0", Offset = "0x870A6F0", VA = "0x18870BCF0", Slot = "35")]
		public bool FTUKLEPRXFY([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x870C900", Offset = "0x870B300", VA = "0x18870C900", Slot = "36")]
		public bool OWYXPKADEKZ([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x870DCC0", Offset = "0x870C6C0", VA = "0x18870DCC0", Slot = "37")]
		public bool YLHGRPZRZLO([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x870BE10", Offset = "0x870A810", VA = "0x18870BE10", Slot = "38")]
		public bool GIXJQMHAYYD([Out] OnlineRestrictionsSources a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x870E4C0", Offset = "0x870CEC0", VA = "0x18870E4C0", Slot = "39")]
		public string ZZFQUBSIBGX(OnlineRestrictionsSources a)
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
