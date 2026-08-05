using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Foundation.Logging;
using RecRoom.Foundation.Service;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.ObjectModel.Logging;
using RecRoom.RoomLoading.RoomOperation;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86D69D0", Offset = "0x86D57D0", VA = "0x1886D69D0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class XABYAYWDHUK
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
	public XABYAYWDHUK()
	{
	}
}
namespace _LogRegistration.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86D6790", Offset = "0x86D5590", VA = "0x1886D6790", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_Dependencies_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int[] TDVEOKFWPNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] TEALLQZTYYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset GMAWWHUIGYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset GLVPZBAKXNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] XYXWOAINHHQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x200DEC0", Offset = "0x200CCC0", VA = "0x18200DEC0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86DA790", Offset = "0x86D9590", VA = "0x1886DA790")]
		private void BUNBWTHGJFJ(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86DA490", Offset = "0x86D9290", VA = "0x1886DA490")]
		private void BUHUZMNIZUA(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86DAB40", Offset = "0x86D9940", VA = "0x1886DAB40", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86DABF0", Offset = "0x86D99F0", VA = "0x1886DABF0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(XIYZQHSOFYZ), new string[] { "Photon" })]
	public class FNFWZKREUUE : XIYZQHSOFYZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class IFJFVECKNSC : YHYTGFZVPSB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public XQAWTLZFHQF OFQFDTNHDLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public UDZWUDGOCUF ZNPIZLOSJKN;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType ULTKTFGCAFO
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x86D5C80", Offset = "0x86D4A80", VA = "0x1886D5C80", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId LOUVYGZEAQB
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x86D5C30", Offset = "0x86D4A30", VA = "0x1886D5C30", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool QWBDKLDTXAW
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool LKBKFYTXLJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x86D5340", Offset = "0x86D4140", VA = "0x1886D5340", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x86D59E0", Offset = "0x86D47E0", VA = "0x1886D59E0", Slot = "9")]
			public bool ISOIKIFXHDM([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "8")]
			public object ZVDUEYYKOKY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x86D5AA0", Offset = "0x86D48A0", VA = "0x1886D5AA0", Slot = "10")]
			private (PlayerId, object) JBNRVMHFXPC()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x86D5CD0", Offset = "0x86D4AD0", VA = "0x1886D5CD0", Slot = "11")]
			private (ObjectNetworkId, PlayerId) QCVMTRTRYOE()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x86D5EB0", Offset = "0x86D4CB0", VA = "0x1886D5EB0", Slot = "12")]
			private SRZXHBNOLNH<(ObjectNetworkId, PlayerId)> VZPRISNLRZN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x86D5530", Offset = "0x86D4330", VA = "0x1886D5530", Slot = "13")]
			private (OutOfBandMessageType, byte[]) BGDOIZLDQUL()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x86D5750", Offset = "0x86D4550", VA = "0x1886D5750", Slot = "14")]
			private (PacketSource, byte[]) GHFNSOHCPBS()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3CCBA70", Offset = "0x3CCA870", VA = "0x183CCBA70", Slot = "15")]
			public a CIRHIEBOLGP<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x86D5DC0", Offset = "0x86D4BC0", VA = "0x1886D5DC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IFJFVECKNSC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class UDZWUDGOCUF : SRZXHBNOLNH<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] PJWZTMYLSQO;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int ZLALHUOTOGI
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x86D9A50", Offset = "0x86D8850", VA = "0x1886D9A50", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x86D9A70", Offset = "0x86D8870", VA = "0x1886D9A70", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public UDZWUDGOCUF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86D51C0", Offset = "0x86D3FC0", VA = "0x1886D51C0", Slot = "4")]
		public bool XFEWASNMRQE(object a, YHYTGFZVPSB b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public FNFWZKREUUE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class VJVBIZHEZFZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(FCSOYQPCSAE), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : EYUUBVPPSNU, EXFJNOPECCW, FCSOYQPCSAE, KCNRTBNFQOT, XREDDEZXVJN
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private HVSINVQKOZE DRXTGXCTIUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private XXSIJJIPAEZ AFGEMXBZRPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> FWMWRJFAKZL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86D7220", Offset = "0x86D6020", VA = "0x1886D7220", Slot = "4")]
		public void InitReferences(ODEDMYTJIPB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86D7690", Offset = "0x86D6490", VA = "0x1886D7690", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86D7030", Offset = "0x86D5E30", VA = "0x1886D7030", Slot = "6")]
		public void ISAUYSYVXJJ(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86D7300", Offset = "0x86D6100", VA = "0x1886D7300", Slot = "10")]
		public void KBXPAQZJEWE(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86D7480", Offset = "0x86D6280", VA = "0x1886D7480", Slot = "7")]
		public void QVVSTPIFCZH(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86D6D10", Offset = "0x86D5B10", VA = "0x1886D6D10")]
		private IDictionary<object, object> ILQGMPQIXGI(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86D7730", Offset = "0x86D6530", VA = "0x1886D7730")]
		public void ZIEVGZEYGPN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86D6CA0", Offset = "0x86D5AA0", VA = "0x1886D6CA0", Slot = "8")]
		private void GXDLTINPSCT(ODEDMYTJIPB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xE07220", Offset = "0xE06020", VA = "0x180E07220", Slot = "9")]
		private void WXTEKSAVTDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86D7820", Offset = "0x86D6620", VA = "0x1886D7820")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.ZQBKRFXMECT), new string[] { })]
	internal class ERDBKXXSODA : MUOIQIMZKIY, RecRoom.RoomLoading.RoomOperation.ZQBKRFXMECT
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log JRROJJZNABT;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] AWABQMSBNDY
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86D5110", Offset = "0x86D3F10", VA = "0x1886D5110")]
		public ERDBKXXSODA()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class OCTSKGMYEIJ : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A50", Offset = "0x86D5850", VA = "0x1886D6A50", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86D6C50", Offset = "0x86D5A50", VA = "0x1886D6C50")]
		public OCTSKGMYEIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class YQUNYGDIAPY
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class NLBGUTCZJKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings ZJVBNRGIFSR;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public NLBGUTCZJKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x86D6890", Offset = "0x86D5690", VA = "0x1886D6890")]
			internal string CIWYGBKMFSY(XQAWTLZFHQF a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86DA470", Offset = "0x86D9270", VA = "0x1886DA470")]
		public static string YTTYXGQHKBM(this XQAWTLZFHQF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86D9F50", Offset = "0x86D8D50", VA = "0x1886D9F50")]
		public static NetworkEventType PXXHYFZBRGN(this XQAWTLZFHQF a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86DA080", Offset = "0x86D8E80", VA = "0x1886DA080")]
		public static ViewId SGKQPWRGFVC(this XQAWTLZFHQF a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86DA2A0", Offset = "0x86D90A0", VA = "0x1886DA2A0")]
		public static string WHZJWRQEBAC(this XQAWTLZFHQF a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86D9B10", Offset = "0x86D8910", VA = "0x1886D9B10")]
		private static string FXUBWMBCSZW(XQAWTLZFHQF a, Func<XQAWTLZFHQF, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86D9C00", Offset = "0x86D8A00", VA = "0x1886D9C00")]
		public static string IWAEKWWOFDK(this XQAWTLZFHQF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86D9D60", Offset = "0x86D8B60", VA = "0x1886D9D60")]
		public static ViewId JDNPZJAZLYR(this XQAWTLZFHQF a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86DA360", Offset = "0x86D9160", VA = "0x1886DA360")]
		public static string XTSDOQGHZNZ(this XQAWTLZFHQF a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class RPMXQZLFDMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class HRKFOZGVKKO
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string DSNLBJDGZUR;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x86D9110", Offset = "0x86D7F10", VA = "0x1886D9110")]
		public static string GDIECNZCXGN(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(LVMOKLEMXXZ), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class LVMOKLEMXXZ : MUOIQIMZKIY
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log YHMDATZVSOU;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log WCFZTQPZVKT;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log OIIPVFPNTGN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] AWABQMSBNDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86D6460", Offset = "0x86D5260", VA = "0x1886D6460", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86D62E0", Offset = "0x86D50E0", VA = "0x1886D62E0", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86D65E0", Offset = "0x86D53E0", VA = "0x1886D65E0")]
		private void RAYNEEBRXZW(XQAWTLZFHQF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86D62B0", Offset = "0x86D50B0", VA = "0x1886D62B0")]
		private void NXCONEEKERT(XQAWTLZFHQF a, BFNGJDNRMXE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86D5FE0", Offset = "0x86D4DE0", VA = "0x1886D5FE0")]
		public void GOPZTBEXIPJ(XQAWTLZFHQF a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86D6200", Offset = "0x86D5000", VA = "0x1886D6200")]
		private static Log LRSPMRFGMFP(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x86D66A0", Offset = "0x86D54A0", VA = "0x1886D66A0")]
		public LVMOKLEMXXZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class RNSYDABWYDM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <>c__DisplayClass6_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public byte[] payload;
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly JsonSerializerSettings IWTXFIMDLAD;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86D8080", Offset = "0x86D6E80", VA = "0x1886D8080")]
		public static EventWriter MHIIMTJBWUZ([In] this EventWriter evt, XQAWTLZFHQF a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x86D7930", Offset = "0x86D6730", VA = "0x1886D7930")]
		public static EventWriter DUKEAVYTQNE([In] this EventWriter evt, XQAWTLZFHQF a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x86D8D70", Offset = "0x86D7B70", VA = "0x1886D8D70")]
		public static string RPHCYOUNPZP(XQAWTLZFHQF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x86D7C80", Offset = "0x86D6A80", VA = "0x1886D7C80")]
		public static string HDMGBUISWZG(XQAWTLZFHQF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x86D7EE0", Offset = "0x86D6CE0", VA = "0x1886D7EE0")]
		public static string KUDQMJRJQNE(XQAWTLZFHQF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86D78A0", Offset = "0x86D66A0", VA = "0x1886D78A0")]
		[CompilerGenerated]
		internal static bool CONHTPLVSNI([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86D8C10", Offset = "0x86D7A10", VA = "0x1886D8C10")]
		[CompilerGenerated]
		internal static bool NHGWEXBCHXZ([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
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
