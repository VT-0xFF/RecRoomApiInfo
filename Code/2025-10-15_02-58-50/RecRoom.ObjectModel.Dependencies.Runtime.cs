using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8639F20", Offset = "0x8638D20", VA = "0x188639F20")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class WTBFLPCTUEB
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
	[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
	public WTBFLPCTUEB()
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
		[Cpp2IlInjected.Address(RVA = "0x8639BD0", Offset = "0x86389D0", VA = "0x188639BD0", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		private int[] DAADMOFRSKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] CZUWPHLUIZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset RDSSOODTNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset RDXZLUXQWUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] RCACTWBUXFL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x242C360", Offset = "0x242B160", VA = "0x18242C360", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x863CBE0", Offset = "0x863B9E0", VA = "0x18863CBE0")]
		private void ZZHVSKGGGUO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x863CFA0", Offset = "0x863BDA0", VA = "0x18863CFA0")]
		private void ZZNCPRADQFX(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x863CB30", Offset = "0x863B930", VA = "0x18863CB30", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x863D2B0", Offset = "0x863C0B0", VA = "0x18863D2B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(INGDSDGWGDM), new string[] { "Photon" })]
	public class SGHQVVETIWN : INGDSDGWGDM
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class QCRGIXQGVQB : QAFVYCSWBHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public PQDMMRYYGHS BUBTABFBQUN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public StatusCode BQOTGBKLLOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public CVYJYUQJZXU CAYLZIRBMDA;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType QHIGGIBDJUD
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x863ACA0", Offset = "0x8639AA0", VA = "0x18863ACA0", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId NQVZPJSYJEW
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x863B560", Offset = "0x863A360", VA = "0x18863B560", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool MNVHAMAKZFD
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x863AF10", Offset = "0x8639D10", VA = "0x18863AF10", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool LVRTMAZQDYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x863B1A0", Offset = "0x8639FA0", VA = "0x18863B1A0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x863B360", Offset = "0x863A160", VA = "0x18863B360", Slot = "9")]
			public bool TOANBVPPINP([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x863B510", Offset = "0x863A310", VA = "0x18863B510", Slot = "8")]
			public object WPOHWTNOQUF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x863B010", Offset = "0x8639E10", VA = "0x18863B010", Slot = "10")]
			private (PlayerId, object) RLLLFPBVYZJ()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x863AF20", Offset = "0x8639D20", VA = "0x18863AF20", Slot = "11")]
			private (ObjectNetworkId, PlayerId) QIXVEQYFJPB()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x863AB70", Offset = "0x8639970", VA = "0x18863AB70", Slot = "12")]
			private ERNIHWHJZYK<(ObjectNetworkId, PlayerId)> JDTZGCHUBAS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x863ACF0", Offset = "0x8639AF0", VA = "0x18863ACF0", Slot = "13")]
			private (OutOfBandMessageType, byte[]) LGFWFCEMRFE()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x863A950", Offset = "0x8639750", VA = "0x18863A950", Slot = "14")]
			private (PacketSource, byte[]) FEXSHCMXQPP()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3F19D30", Offset = "0x3F18B30", VA = "0x183F19D30", Slot = "15")]
			public a WXVSWDMKRGC<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x863B420", Offset = "0x863A220", VA = "0x18863B420", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public QCRGIXQGVQB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class CVYJYUQJZXU : ERNIHWHJZYK<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public int[] MJPPUKLJQDR;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int WKYILYEQKLZ
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x86374C0", Offset = "0x86362C0", VA = "0x1886374C0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x86374E0", Offset = "0x86362E0", VA = "0x1886374E0", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public CVYJYUQJZXU()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x863B6F0", Offset = "0x863A4F0", VA = "0x18863B6F0", Slot = "4")]
		public bool CUOXAFRLPOP(object a, QAFVYCSWBHO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public SGHQVVETIWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class KRIGTYHNMJI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(JCNCLMIQHQD), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : LYBXKQOLIUF, JFNNEAWOERD, JCNCLMIQHQD, OQVTAWVSILE, CKMVDEYKLMG
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private MLMDFPLHWFL CHVUAIGFBDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[DependsOn]
		private TKOFBYUEPOS OLPAJMAMGCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Hashtable TWZTREBIHPU;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x863A4E0", Offset = "0x86392E0", VA = "0x18863A4E0", Slot = "4")]
		public void InitReferences(YKMTYEBAAOC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x863A6E0", Offset = "0x86394E0", VA = "0x18863A6E0", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8639FA0", Offset = "0x8638DA0", VA = "0x188639FA0", Slot = "6")]
		public void AYDFIJIYYVQ(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x863A5C0", Offset = "0x86393C0", VA = "0x18863A5C0", Slot = "10")]
		public void RZSXWNLGDPN(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x863A100", Offset = "0x8638F00", VA = "0x18863A100", Slot = "7")]
		public void CGYOZTGVGTW(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x863A290", Offset = "0x8639090", VA = "0x18863A290")]
		private Hashtable DEGCRJTHHWR(Hashtable a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x863A7F0", Offset = "0x86395F0", VA = "0x18863A7F0")]
		public void YXNBLWXFTWG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x863A780", Offset = "0x8639580", VA = "0x18863A780", Slot = "8")]
		private void VROTAZPKECM(YKMTYEBAAOC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x108FBC0", Offset = "0x108E9C0", VA = "0x18108FBC0", Slot = "9")]
		private void WEWODNDDDHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x863A8E0", Offset = "0x86396E0", VA = "0x18863A8E0")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.FMHLFGVDJJC), new string[] { })]
	internal class GSZFRHRYFDZ : ZRWMXXGFEWP, RecRoom.RoomLoading.RoomOperation.FMHLFGVDJJC
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Log JEGQGEZRUJM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] JPGPRGWKFUL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8637D80", Offset = "0x8636B80", VA = "0x188637D80")]
		public GSZFRHRYFDZ()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MUWPRVBWTMY : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8639CD0", Offset = "0x8638AD0", VA = "0x188639CD0", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8639ED0", Offset = "0x8638CD0", VA = "0x188639ED0")]
		public MUWPRVBWTMY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class WAUOSUCKSAV
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class RYMNRJREOIY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public JsonSerializerSettings XUWENKJHBCU;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
			public RYMNRJREOIY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x863B5B0", Offset = "0x863A3B0", VA = "0x18863B5B0")]
			internal string XHGTBCNGHDN(PQDMMRYYGHS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x863C1F0", Offset = "0x863AFF0", VA = "0x18863C1F0")]
		public static string HFMWEQCVKJN(this PQDMMRYYGHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x863C210", Offset = "0x863B010", VA = "0x18863C210")]
		public static NetworkEventType HRKXXQJCCTW(this PQDMMRYYGHS a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x863C610", Offset = "0x863B410", VA = "0x18863C610")]
		public static ViewId TURIKCVSRVZ(this PQDMMRYYGHS a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x863C910", Offset = "0x863B710", VA = "0x18863C910")]
		public static string XEIIFHTXIQN(this PQDMMRYYGHS a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x863C520", Offset = "0x863B320", VA = "0x18863C520")]
		private static string OVKJKRUIRTV(PQDMMRYYGHS a, Func<PQDMMRYYGHS, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x863C9D0", Offset = "0x863B7D0", VA = "0x18863C9D0")]
		public static string YDBVDCZNNKV(this PQDMMRYYGHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x863C350", Offset = "0x863B150", VA = "0x18863C350")]
		public static ViewId NYFQIHAOHKS(this PQDMMRYYGHS a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x863C800", Offset = "0x863B600", VA = "0x18863C800")]
		public static string VCOWCBSHABQ(this PQDMMRYYGHS a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class STUGZKRRGUT
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class SIMBEHHOZGX
		{
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static string BESGMBXWWKS;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x863B8E0", Offset = "0x863A6E0", VA = "0x18863B8E0")]
		public static string LFRZZNGOIBO(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(FWDYUYZVMOU), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class FWDYUYZVMOU : ZRWMXXGFEWP
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log XODHDFTEPJN;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log ZUELZKEPYGY;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly Log HVJKDETLCDQ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] JPGPRGWKFUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8637960", Offset = "0x8636760", VA = "0x188637960", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86377E0", Offset = "0x86365E0", VA = "0x1886377E0", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86375B0", Offset = "0x86363B0", VA = "0x1886375B0")]
		private void JJTZLDGRBBP(PQDMMRYYGHS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8637580", Offset = "0x8636380", VA = "0x188637580")]
		private void ELHRZVNKGTW(PQDMMRYYGHS a, ZPXXLQJTGDJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86375C0", Offset = "0x86363C0", VA = "0x1886375C0")]
		public void JLZXWYBQHBW(PQDMMRYYGHS a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8637AE0", Offset = "0x86368E0", VA = "0x188637AE0")]
		private static Log VDBFMWSEUQA(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8637C40", Offset = "0x8636A40", VA = "0x188637C40")]
		public FWDYUYZVMOU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class JUAZSAGKCXF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <>c__DisplayClass6_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public byte[] payload;
		}

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly JsonSerializerSettings SLNPOHHUQKC;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8637EC0", Offset = "0x8636CC0", VA = "0x188637EC0")]
		public static EventWriter COXOWJTPJYA([In] this EventWriter evt, PQDMMRYYGHS a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8639120", Offset = "0x8637F20", VA = "0x188639120")]
		public static EventWriter FBWPVHZAQZN([In] this EventWriter evt, PQDMMRYYGHS a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8639830", Offset = "0x8638630", VA = "0x188639830")]
		public static string SROEQKQLMDK(PQDMMRYYGHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x86395D0", Offset = "0x86383D0", VA = "0x1886395D0")]
		public static string QARAMVCPNUX(PQDMMRYYGHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8638F90", Offset = "0x8637D90", VA = "0x188638F90")]
		public static string DUHUEAPDABN(PQDMMRYYGHS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8637E30", Offset = "0x8636C30", VA = "0x188637E30")]
		[CompilerGenerated]
		internal static bool ASZOVECSTRB([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8639470", Offset = "0x8638270", VA = "0x188639470")]
		[CompilerGenerated]
		internal static bool LHPJFHAMPBU([Out] string a, <>c__DisplayClass6_0 b)
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
