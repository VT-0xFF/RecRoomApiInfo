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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F70F0", Offset = "0x99F5EF0", VA = "0x1899F70F0")]
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
	[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F6F30", Offset = "0x99F5D30", VA = "0x1899F6F30", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x222F190", Offset = "0x222DF90", VA = "0x18222F190", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99FB210", Offset = "0x99FA010", VA = "0x1899FB210")]
		private void TZCLDGRTUGE(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99FB5C0", Offset = "0x99FA3C0", VA = "0x1899FB5C0")]
		private void TZHSANLRDRN(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99FB160", Offset = "0x99F9F60", VA = "0x1899FB160", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99FB8C0", Offset = "0x99FA6C0", VA = "0x1899FB8C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x99F81A0", Offset = "0x99F6FA0", VA = "0x1899F81A0", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId LQBQFLVQZAE
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x99F8060", Offset = "0x99F6E60", VA = "0x1899F8060", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool QLXEZHBAHXN
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool CNUGUTYQZAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x99F7E70", Offset = "0x99F6C70", VA = "0x1899F7E70", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x99F8750", Offset = "0x99F7550", VA = "0x1899F8750", Slot = "9")]
			public bool TJGEXAHVRPF([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCE77B0", Offset = "0xCE65B0", VA = "0x180CE77B0", Slot = "8")]
			public object XLZXWLOOZCX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x99F85C0", Offset = "0x99F73C0", VA = "0x1899F85C0", Slot = "10")]
			private (PlayerId, object) SVAUKDDRITX()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x99F80B0", Offset = "0x99F6EB0", VA = "0x1899F80B0", Slot = "11")]
			private (ObjectNetworkId, PlayerId) NFGFBSWTKNH()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x99F8490", Offset = "0x99F7290", VA = "0x1899F8490", Slot = "12")]
			private YBXPVZWPMAU<(ObjectNetworkId, PlayerId)> SMMUDZUFTQU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x99F8910", Offset = "0x99F7710", VA = "0x1899F8910", Slot = "13")]
			private (OutOfBandMessageType, byte[]) VMGKXJIQUWI()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x99F81F0", Offset = "0x99F6FF0", VA = "0x1899F81F0", Slot = "14")]
			private (PacketSource, byte[]) RSYTCWOYTPJ()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4130620", Offset = "0x412F420", VA = "0x184130620", Slot = "15")]
			public a YQSIIWPSZBS<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x99F8820", Offset = "0x99F7620", VA = "0x1899F8820", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
				[Cpp2IlInjected.Address(RVA = "0x99F7030", Offset = "0x99F5E30", VA = "0x1899F7030", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x99F7050", Offset = "0x99F5E50", VA = "0x1899F7050", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public NPBJFCYYWII()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99F6350", Offset = "0x99F5150", VA = "0x1899F6350", Slot = "4")]
		public bool PPXSQRKLNWN(object a, CKZGVBDYEVA b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F74E0", Offset = "0x99F62E0", VA = "0x1899F74E0", Slot = "4")]
		public void InitReferences(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99F79A0", Offset = "0x99F67A0", VA = "0x1899F79A0", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99F7630", Offset = "0x99F6430", VA = "0x1899F7630", Slot = "6")]
		public void QDIEDQJSUCU(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99F7820", Offset = "0x99F6620", VA = "0x1899F7820", Slot = "10")]
		public void RQZBQRGBOVT(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99F7270", Offset = "0x99F6070", VA = "0x1899F7270", Slot = "7")]
		public void BQLBAHCGDHA(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99F7A40", Offset = "0x99F6840", VA = "0x1899F7A40")]
		private IDictionary<object, object> YFCKUXTJGQD(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99F7480", Offset = "0x99F6280", VA = "0x1899F7480")]
		public void EWGFALHVYVC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99F75C0", Offset = "0x99F63C0", VA = "0x1899F75C0", Slot = "8")]
		private void MBYFDPTTQYS(IKBIXEGYPOI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1025A60", Offset = "0x1024860", VA = "0x181025A60", Slot = "9")]
		private void NXHIFSUZYIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x99F7DF0", Offset = "0x99F6BF0", VA = "0x1899F7DF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99F71C0", Offset = "0x99F5FC0", VA = "0x1899F71C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99FAF10", Offset = "0x99F9D10", VA = "0x1899FAF10", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99FB110", Offset = "0x99F9F10", VA = "0x1899FB110")]
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
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public KGMFPJNILMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x99F6DF0", Offset = "0x99F5BF0", VA = "0x1899F6DF0")]
			internal string ZISXILQCDRP(XHRZBUOCUVQ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99F6C70", Offset = "0x99F5A70", VA = "0x1899F6C70")]
		public static string XUXMTMAIBKJ(this XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99F6B30", Offset = "0x99F5930", VA = "0x1899F6B30")]
		public static NetworkEventType UXTITAEDEAC(this XHRZBUOCUVQ a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x99F6910", Offset = "0x99F5710", VA = "0x1899F6910")]
		public static ViewId ONLCTEZMNBD(this XHRZBUOCUVQ a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x99F6760", Offset = "0x99F5560", VA = "0x1899F6760")]
		public static string NZQSPRWIWAL(this XHRZBUOCUVQ a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99F6820", Offset = "0x99F5620", VA = "0x1899F6820")]
		private static string OFYQMZACSPP(XHRZBUOCUVQ a, Func<XHRZBUOCUVQ, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99F6C90", Offset = "0x99F5A90", VA = "0x1899F6C90")]
		public static string ZVNENGDURKT(this XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99F6460", Offset = "0x99F5260", VA = "0x1899F6460")]
		public static ViewId KAZRAANOKEA(this XHRZBUOCUVQ a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99F6650", Offset = "0x99F5450", VA = "0x1899F6650")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F5D40", Offset = "0x99F4B40", VA = "0x1899F5D40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE8BC0", Offset = "0xCE79C0", VA = "0x180CE8BC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x99F8DB0", Offset = "0x99F7BB0", VA = "0x1899F8DB0", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x99F8C30", Offset = "0x99F7A30", VA = "0x1899F8C30", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x99F8B40", Offset = "0x99F7940", VA = "0x1899F8B40")]
		private void ISUYTEJUJCH(XHRZBUOCUVQ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x99F8C00", Offset = "0x99F7A00", VA = "0x1899F8C00")]
		private void NPAEZXBCAMK(XHRZBUOCUVQ a, OGEXSFQHDBH b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x99F8F30", Offset = "0x99F7D30", VA = "0x1899F8F30")]
		public void ZEGDIHAHWOG(XHRZBUOCUVQ a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x99F8B50", Offset = "0x99F7950", VA = "0x1899F8B50")]
		private static Log LAZNOHIQDLA(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x99F9200", Offset = "0x99F8000", VA = "0x1899F9200")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F9990", Offset = "0x99F8790", VA = "0x1899F9990")]
		public static EventWriter EDHTDDFJZAC([In] this EventWriter evt, XHRZBUOCUVQ a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99FA7A0", Offset = "0x99F95A0", VA = "0x1899FA7A0")]
		public static EventWriter RKQWQNJSTYZ([In] this EventWriter evt, XHRZBUOCUVQ a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99FA5C0", Offset = "0x99F93C0", VA = "0x1899FA5C0")]
		public static string MGODSVEJGDA(XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x99FAAF0", Offset = "0x99F98F0", VA = "0x1899FAAF0")]
		public static string STTBDLNWNRL(XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99F97F0", Offset = "0x99F85F0", VA = "0x1899F97F0")]
		public static string DLBEQQGCPMV(XHRZBUOCUVQ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99FA530", Offset = "0x99F9330", VA = "0x1899FA530")]
		[CompilerGenerated]
		internal static bool JERVFZTASRT([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99F9690", Offset = "0x99F8490", VA = "0x1899F9690")]
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
