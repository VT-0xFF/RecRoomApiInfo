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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x864A320", Offset = "0x8649320", VA = "0x18864A320")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class RTCNTVNETXX
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
	[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
	public RTCNTVNETXX()
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
		[Cpp2IlInjected.Address(RVA = "0x864A220", Offset = "0x8649220", VA = "0x18864A220", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		private int[] DGVDDFJHVEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] DGPWFYPKLTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset XRLFBVIQUFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset XRQLZCCODQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] YGVBEQSVBOZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1FBC640", Offset = "0x1FBB640", VA = "0x181FBC640", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x864CC10", Offset = "0x864BC10", VA = "0x18864CC10")]
		private void ZASTUGVTQWC(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x864CFC0", Offset = "0x864BFC0", VA = "0x18864CFC0")]
		private void ZAYARNPRAHL(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x864CB60", Offset = "0x864BB60", VA = "0x18864CB60", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x864D2D0", Offset = "0x864C2D0", VA = "0x18864D2D0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(EJFZYLZYFPA), new string[] { "Photon" })]
	public class DNLBSSBPWYZ : EJFZYLZYFPA
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class QKEPCWDSQRT : NTECVXIYEBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public VASLQQLLDVS MNCBXCHCPER;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public EHSSIDINBWW KHKGLRFFNLU;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType GLAENVNETGX
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x864B390", Offset = "0x864A390", VA = "0x18864B390", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId VMRGAQPOMHU
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x864B1B0", Offset = "0x864A1B0", VA = "0x18864B1B0", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool TDMPXUQJTRD
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool UTTTORAXHIE
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x864B3E0", Offset = "0x864A3E0", VA = "0x18864B3E0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x864B5E0", Offset = "0x864A5E0", VA = "0x18864B5E0", Slot = "9")]
			public bool MRTOWDLRHSZ([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "8")]
			public object CJKLBSHTFHD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x864B200", Offset = "0x864A200", VA = "0x18864B200", Slot = "10")]
			private (PlayerId, object) IPOIDTJKWOP()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x864BA20", Offset = "0x864AA20", VA = "0x18864BA20", Slot = "11")]
			private (ObjectNetworkId, PlayerId) VLKFUJBKVOL()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x864BB10", Offset = "0x864AB10", VA = "0x18864BB10", Slot = "12")]
			private PEVTNSCBFNQ<(ObjectNetworkId, PlayerId)> ZEKLXVQDYMO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x864AF90", Offset = "0x8649F90", VA = "0x18864AF90", Slot = "13")]
			private (OutOfBandMessageType, byte[]) EUKXFGJWCOO()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x864B6A0", Offset = "0x864A6A0", VA = "0x18864B6A0", Slot = "14")]
			private (PacketSource, byte[]) QJILHGQTUOR()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3C9ECA0", Offset = "0x3C9DCA0", VA = "0x183C9ECA0", Slot = "15")]
			public a GGBDYZLIQZQ<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x864B930", Offset = "0x864A930", VA = "0x18864B930", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public QKEPCWDSQRT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class EHSSIDINBWW : PEVTNSCBFNQ<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] MSEOWBRXXFJ;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int KNJNUUEZHUL
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x86479D0", Offset = "0x86469D0", VA = "0x1886479D0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x86479F0", Offset = "0x86469F0", VA = "0x1886479F0", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public EHSSIDINBWW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86478C0", Offset = "0x86468C0", VA = "0x1886478C0", Slot = "4")]
		public bool FMGGDPLVGDZ(object a, NTECVXIYEBW b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public DNLBSSBPWYZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class HNGGKBSIWNY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(ZARTHUIHIQP), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : AXDTJKLCJPD, OIEOCLRSVGV, ZARTHUIHIQP, FGJPSHLXWSW, OZDTSOBLUVI
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private IBYOWALYHCF ZOLYTZVOMLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private MGRARTTRKFA EBOSXLPWXBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> FGQHRAKTPES;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x864A5F0", Offset = "0x86495F0", VA = "0x18864A5F0", Slot = "4")]
		public void InitReferences(MEMEGXEKDDM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x864AC00", Offset = "0x8649C00", VA = "0x18864AC00", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x864ACA0", Offset = "0x8649CA0", VA = "0x18864ACA0", Slot = "6")]
		public void ZZBWKDBBGLM(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x864A470", Offset = "0x8649470", VA = "0x18864A470", Slot = "10")]
		public void FMGOVBPBABF(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x864A6D0", Offset = "0x86496D0", VA = "0x18864A6D0", Slot = "7")]
		public void JCPMNDJKDWE(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x864A8E0", Offset = "0x86498E0", VA = "0x18864A8E0")]
		private IDictionary<object, object> SBVHGDNMCTD(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x864A3A0", Offset = "0x86493A0", VA = "0x18864A3A0")]
		public void DLFTRAQXPZQ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x864A400", Offset = "0x8649400", VA = "0x18864A400", Slot = "8")]
		private void DRCAJKSLWZO(MEMEGXEKDDM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xDC7100", Offset = "0xDC6100", VA = "0x180DC7100", Slot = "9")]
		private void ZWDRINULYCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x864AF10", Offset = "0x8649F10", VA = "0x18864AF10")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.KSSBCRBNDUE), new string[] { })]
	internal class YBJFXTOZUPF : HSBHPUIISLF, RecRoom.RoomLoading.RoomOperation.KSSBCRBNDUE
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log UWJFIMBGZZY;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] IHEBNJWGVED
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x864C970", Offset = "0x864B970", VA = "0x18864C970")]
		public YBJFXTOZUPF()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UWVQILLOQOI : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x864BF70", Offset = "0x864AF70", VA = "0x18864BF70", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x864C160", Offset = "0x864B160", VA = "0x18864C160")]
		public UWVQILLOQOI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class GZCWZDTIMFT
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ZKMPBACDFNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings XLYHWFHRHCU;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public ZKMPBACDFNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x864CA20", Offset = "0x864BA20", VA = "0x18864CA20")]
			internal string BUEWGCQYDBJ(VASLQQLLDVS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86498C0", Offset = "0x86488C0", VA = "0x1886498C0")]
		public static string POLKPIJVJDV(this VASLQQLLDVS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8649AE0", Offset = "0x8648AE0", VA = "0x188649AE0")]
		public static NetworkEventType ZEODWLIFDRW(this VASLQQLLDVS a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8649290", Offset = "0x8648290", VA = "0x188649290")]
		public static ViewId IFZXGPVCSYP(this VASLQQLLDVS a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8649600", Offset = "0x8648600", VA = "0x188649600")]
		public static string LHMYZKVCNTL(this VASLQQLLDVS a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86498E0", Offset = "0x86488E0", VA = "0x1886498E0")]
		private static string PTOWHDKPYFF(VASLQQLLDVS a, Func<VASLQQLLDVS, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86494B0", Offset = "0x86484B0", VA = "0x1886494B0")]
		public static string JYCJPHQBPQJ(this VASLQQLLDVS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86496C0", Offset = "0x86486C0", VA = "0x1886496C0")]
		public static ViewId MYTGKZTNQGW(this VASLQQLLDVS a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86499D0", Offset = "0x86489D0", VA = "0x1886499D0")]
		public static string SLYOVKOMOWW(this VASLQQLLDVS a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class LLOTYPDEQVB
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class ARLKGHYSZBR
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string HJJUAKFAXWO;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8649C10", Offset = "0x8648C10", VA = "0x188649C10")]
		public static string VXDHBVQASTK(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(WLUGWQWZPYM), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class WLUGWQWZPYM : HSBHPUIISLF
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log NVSJQKMPIBZ;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log ZEAPKZRVYRC;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log GYTAYLTXMOS;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] IHEBNJWGVED
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x864C580", Offset = "0x864B580", VA = "0x18864C580", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x864C410", Offset = "0x864B410", VA = "0x18864C410", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x864C400", Offset = "0x864B400", VA = "0x18864C400")]
		private void KWHKSXCEAZD(VASLQQLLDVS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x864C1B0", Offset = "0x864B1B0", VA = "0x18864C1B0")]
		private void CMRCTGVAYLG(VASLQQLLDVS a, XSNAFSFANWP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x864C1E0", Offset = "0x864B1E0", VA = "0x18864C1E0")]
		public void GRSBYJEOTQI(VASLQQLLDVS a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x864C6F0", Offset = "0x864B6F0", VA = "0x18864C6F0")]
		private static Log YXLTEAJUCWU(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x864C840", Offset = "0x864B840", VA = "0x18864C840")]
		public WLUGWQWZPYM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class EUVYSWCPDFV
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
		private static readonly JsonSerializerSettings EGAIQTVYLGG;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8648030", Offset = "0x8647030", VA = "0x188648030")]
		public static EventWriter MHJPLMUQGTO([In] this EventWriter evt, VASLQQLLDVS a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8648B70", Offset = "0x8647B70", VA = "0x188648B70")]
		public static EventWriter MOQJVWSTOFN([In] this EventWriter evt, VASLQQLLDVS a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8647BF0", Offset = "0x8646BF0", VA = "0x188647BF0")]
		public static string DJBUDABOOIQ(VASLQQLLDVS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8647DD0", Offset = "0x8646DD0", VA = "0x188647DD0")]
		public static string HWXQXKANQNJ(VASLQQLLDVS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8648EB0", Offset = "0x8647EB0", VA = "0x188648EB0")]
		public static string RCAXMCESAWL(VASLQQLLDVS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8649050", Offset = "0x8648050", VA = "0x188649050")]
		[CompilerGenerated]
		internal static bool TBUVBDGQXJJ([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8647A90", Offset = "0x8646A90", VA = "0x188647A90")]
		[CompilerGenerated]
		internal static bool BBGJDOBVYTM([Out] string a, <>c__DisplayClass6_0 b)
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
