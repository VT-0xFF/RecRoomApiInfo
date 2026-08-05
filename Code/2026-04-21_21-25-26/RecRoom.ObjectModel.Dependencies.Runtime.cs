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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B7A5A0", Offset = "0x9B78FA0", VA = "0x189B7A5A0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class IXBFVIJSSFJ
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
	[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
	public IXBFVIJSSFJ()
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
		[Cpp2IlInjected.Address(RVA = "0x9B7A3E0", Offset = "0x9B78DE0", VA = "0x189B7A3E0", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		private int[] SSKDGXUXNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] SSEWJRBADRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset DGANWLFFZHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset DGFUTRZDISL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] XNXXTFOZKOX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22688A0", Offset = "0x22672A0", VA = "0x1822688A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E6D0", Offset = "0x9B7D0D0", VA = "0x189B7E6D0")]
		private void TZCLDGRTUGE(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9B7EA80", Offset = "0x9B7D480", VA = "0x189B7EA80")]
		private void TZHSANLRDRN(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E620", Offset = "0x9B7D020", VA = "0x189B7E620", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9B7ED90", Offset = "0x9B7D790", VA = "0x189B7ED90")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(OFIJIDBYOLO), new string[] { "Photon" })]
	public class GFJBQYOVMVV : OFIJIDBYOLO
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class QOHJWHQBZXR : CKZGVBDYEVA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public XHRZBUOCUVQ XZXERBSZYLV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public NPBJFCYYWII NGIJRRFWHEM;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType YFKMMNNXMAZ
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x9B7B660", Offset = "0x9B7A060", VA = "0x189B7B660", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId LQBQFLVQZAE
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x9B7B520", Offset = "0x9B79F20", VA = "0x189B7B520", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool QLXEZHBAHXN
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool CNUGUTYQZAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x9B7B320", Offset = "0x9B79D20", VA = "0x189B7B320", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BC10", Offset = "0x9B7A610", VA = "0x189B7BC10", Slot = "9")]
			public bool TJGEXAHVRPF([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "8")]
			public object XLZXWLOOZCX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BA80", Offset = "0x9B7A480", VA = "0x189B7BA80", Slot = "10")]
			private (PlayerId, object) SVAUKDDRITX()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9B7B570", Offset = "0x9B79F70", VA = "0x189B7B570", Slot = "11")]
			private (ObjectNetworkId, PlayerId) NFGFBSWTKNH()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9B7B950", Offset = "0x9B7A350", VA = "0x189B7B950", Slot = "12")]
			private YBXPVZWPMAU<(ObjectNetworkId, PlayerId)> SMMUDZUFTQU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BDD0", Offset = "0x9B7A7D0", VA = "0x189B7BDD0", Slot = "13")]
			private (OutOfBandMessageType, byte[]) VMGKXJIQUWI()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9B7B6B0", Offset = "0x9B7A0B0", VA = "0x189B7B6B0", Slot = "14")]
			private (PacketSource, byte[]) RSYTCWOYTPJ()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4180F10", Offset = "0x417F910", VA = "0x184180F10", Slot = "15")]
			public a YQSIIWPSZBS<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9B7BCE0", Offset = "0x9B7A6E0", VA = "0x189B7BCE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public QOHJWHQBZXR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class NPBJFCYYWII : YBXPVZWPMAU<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] MLDFTQFUHQF;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int ORLIDGXUSPD
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x9B7A4E0", Offset = "0x9B78EE0", VA = "0x189B7A4E0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x9B7A500", Offset = "0x9B78F00", VA = "0x189B7A500", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public NPBJFCYYWII()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9B79800", Offset = "0x9B78200", VA = "0x189B79800", Slot = "4")]
		public bool PPXSQRKLNWN(object a, CKZGVBDYEVA b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public GFJBQYOVMVV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class IIDZPSAVGEU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(NTOKUXVJURL), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : YWYIFNCKTFV, FGDXYNTAWZN, NTOKUXVJURL, JIKZVPRDGWM, ORELWRZKHYY
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private XJMTTKAGRKL IMRLHXLEJWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private URSCUCRRGBK DRQMHYXNBWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> OEYQDSPEYVO;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A990", Offset = "0x9B79390", VA = "0x189B7A990", Slot = "4")]
		public void InitReferences(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B7AE50", Offset = "0x9B79850", VA = "0x189B7AE50", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B7AAE0", Offset = "0x9B794E0", VA = "0x189B7AAE0", Slot = "6")]
		public void QDIEDQJSUCU(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B7ACD0", Offset = "0x9B796D0", VA = "0x189B7ACD0", Slot = "10")]
		public void RQZBQRGBOVT(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A720", Offset = "0x9B79120", VA = "0x189B7A720", Slot = "7")]
		public void BQLBAHCGDHA(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B7AEF0", Offset = "0x9B798F0", VA = "0x189B7AEF0")]
		private IDictionary<object, object> YFCKUXTJGQD(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A930", Offset = "0x9B79330", VA = "0x189B7A930")]
		public void EWGFALHVYVC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9B7AA70", Offset = "0x9B79470", VA = "0x189B7AA70", Slot = "8")]
		private void MBYFDPTTQYS(IKBIXEGYPOI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x104F170", Offset = "0x104DB70", VA = "0x18104F170", Slot = "9")]
		private void NXHIFSUZYIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B7B2A0", Offset = "0x9B79CA0", VA = "0x189B7B2A0")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.XTEFMZKMCUO), new string[] { })]
	internal class OFFMXYHUPQR : YSRLXQDHHJX, RecRoom.RoomLoading.RoomOperation.XTEFMZKMCUO
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log ZJHULEZTUGM;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] BGIKFSNARDH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A670", Offset = "0x9B79070", VA = "0x189B7A670")]
		public OFFMXYHUPQR()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ZSMOKHKSVVE : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E3D0", Offset = "0x9B7CDD0", VA = "0x189B7E3D0", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9B7E5D0", Offset = "0x9B7CFD0", VA = "0x189B7E5D0")]
		public ZSMOKHKSVVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class IFKATFNSNDF
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class KGMFPJNILMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings TQUYWCNNDMC;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A2A0", Offset = "0x9B78CA0", VA = "0x189B7A2A0")]
			internal string ZISXILQCDRP(XHRZBUOCUVQ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A120", Offset = "0x9B78B20", VA = "0x189B7A120")]
		public static string XUXMTMAIBKJ(this XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9B79FE0", Offset = "0x9B789E0", VA = "0x189B79FE0")]
		public static NetworkEventType UXTITAEDEAC(this XHRZBUOCUVQ a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9B79DC0", Offset = "0x9B787C0", VA = "0x189B79DC0")]
		public static ViewId ONLCTEZMNBD(this XHRZBUOCUVQ a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9B79C10", Offset = "0x9B78610", VA = "0x189B79C10")]
		public static string NZQSPRWIWAL(this XHRZBUOCUVQ a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9B79CD0", Offset = "0x9B786D0", VA = "0x189B79CD0")]
		private static string OFYQMZACSPP(XHRZBUOCUVQ a, Func<XHRZBUOCUVQ, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A140", Offset = "0x9B78B40", VA = "0x189B7A140")]
		public static string ZVNENGDURKT(this XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B79910", Offset = "0x9B78310", VA = "0x189B79910")]
		public static ViewId KAZRAANOKEA(this XHRZBUOCUVQ a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9B79B00", Offset = "0x9B78500", VA = "0x189B79B00")]
		public static string MCDYDDKZNNG(this XHRZBUOCUVQ a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FCOPFPDOQJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class VQTHZUJWDMR
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string PXWICFQJHRG;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9B791F0", Offset = "0x9B77BF0", VA = "0x189B791F0")]
		public static string CZHHTDAQBIG(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(RCTUKNMYNQS), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class RCTUKNMYNQS : YSRLXQDHHJX
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log OALCTDRWSMZ;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log ZJOKCTYSUVM;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log FUGMDJFBIBO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] BGIKFSNARDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C270", Offset = "0x9B7AC70", VA = "0x189B7C270", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C0F0", Offset = "0x9B7AAF0", VA = "0x189B7C0F0", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C000", Offset = "0x9B7AA00", VA = "0x189B7C000")]
		private void ISUYTEJUJCH(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C0C0", Offset = "0x9B7AAC0", VA = "0x189B7C0C0")]
		private void NPAEZXBCAMK(XHRZBUOCUVQ a, OGEXSFQHDBH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C3F0", Offset = "0x9B7ADF0", VA = "0x189B7C3F0")]
		public void ZEGDIHAHWOG(XHRZBUOCUVQ a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C010", Offset = "0x9B7AA10", VA = "0x189B7C010")]
		private static Log LAZNOHIQDLA(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9B7C6C0", Offset = "0x9B7B0C0", VA = "0x189B7C6C0")]
		public RCTUKNMYNQS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class XYJLBXPMVQR
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
		private static readonly JsonSerializerSettings YTPEMFTASUY;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CE50", Offset = "0x9B7B850", VA = "0x189B7CE50")]
		public static EventWriter EDHTDDFJZAC([In] this EventWriter evt, XHRZBUOCUVQ a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9B7DC60", Offset = "0x9B7C660", VA = "0x189B7DC60")]
		public static EventWriter RKQWQNJSTYZ([In] this EventWriter evt, XHRZBUOCUVQ a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9B7DA80", Offset = "0x9B7C480", VA = "0x189B7DA80")]
		public static string MGODSVEJGDA(XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9B7DFB0", Offset = "0x9B7C9B0", VA = "0x189B7DFB0")]
		public static string STTBDLNWNRL(XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CCB0", Offset = "0x9B7B6B0", VA = "0x189B7CCB0")]
		public static string DLBEQQGCPMV(XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D9F0", Offset = "0x9B7C3F0", VA = "0x189B7D9F0")]
		[CompilerGenerated]
		internal static bool JERVFZTASRT([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9B7CB50", Offset = "0x9B7B550", VA = "0x189B7CB50")]
		[CompilerGenerated]
		internal static bool CGJUCDBKYUM([Out] string a, <>c__DisplayClass6_0 b)
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
