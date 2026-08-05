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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B6D5F0", Offset = "0x9B6C5F0", VA = "0x189B6D5F0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UFSCIDMSTJW
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
	[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
	public UFSCIDMSTJW()
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
		[Cpp2IlInjected.Address(RVA = "0x9B6D3F0", Offset = "0x9B6C3F0", VA = "0x189B6D3F0", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		private int[] DFSWPDPJVFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] DFYDMKJHEQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset QBNLPBWZQQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset QBIERVDCHEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] JCXDAUQCDCA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2240B50", Offset = "0x223FB50", VA = "0x182240B50", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B72050", Offset = "0x9B71050", VA = "0x189B72050")]
		private void ROXZSJHBEXH(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9B71D50", Offset = "0x9B70D50", VA = "0x189B71D50")]
		private void ROSSVCNDVLY(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B72400", Offset = "0x9B71400", VA = "0x189B72400", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9B724B0", Offset = "0x9B714B0", VA = "0x189B724B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(JJQCPHCVZHB), new string[] { "Photon" })]
	public class CKDEKJHWRNQ : JJQCPHCVZHB
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class SRURHREUCCI : KBQSCVBQQMX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public PKEJZTAIXED QZAYFRQXEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public DHWREDHIAVJ OEDQEJRQOQT;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType AHRPWOVSMCK
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x9B6F5B0", Offset = "0x9B6E5B0", VA = "0x189B6F5B0", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId DGCOIKJZOFR
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x9B6F3A0", Offset = "0x9B6E3A0", VA = "0x189B6F3A0", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool LPNOMENGLQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool EOTYEBEXKCX
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x9B6F600", Offset = "0x9B6E600", VA = "0x189B6F600", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9B6F3F0", Offset = "0x9B6E3F0", VA = "0x189B6F3F0", Slot = "9")]
			public bool GOBLDUNQTYU([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "8")]
			public object ROVLWJXJIXE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9B6F210", Offset = "0x9B6E210", VA = "0x189B6F210", Slot = "10")]
			private (PlayerId, object) AABEEJXVWTE()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9B6F4C0", Offset = "0x9B6E4C0", VA = "0x189B6F4C0", Slot = "11")]
			private (ObjectNetworkId, PlayerId) JXBHXFAZYGO()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9B6FDB0", Offset = "0x9B6EDB0", VA = "0x189B6FDB0", Slot = "12")]
			private NKHOOALWWTR<(ObjectNetworkId, PlayerId)> XSUCKPYHQYB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9B6FB80", Offset = "0x9B6EB80", VA = "0x189B6FB80", Slot = "13")]
			private (OutOfBandMessageType, byte[]) WKMHPMLVMHL()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9B6F7F0", Offset = "0x9B6E7F0", VA = "0x189B6F7F0", Slot = "14")]
			private (PacketSource, byte[]) PXRKIOFFKBQ()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x414E5E0", Offset = "0x414D5E0", VA = "0x18414E5E0", Slot = "15")]
			public a FCJTSIRFAQZ<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9B6FA90", Offset = "0x9B6EA90", VA = "0x189B6FA90", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public SRURHREUCCI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class DHWREDHIAVJ : NKHOOALWWTR<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] VNYSSIPAVNW;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int HEJIPADGNQW
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x9B6CA40", Offset = "0x9B6BA40", VA = "0x189B6CA40", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x9B6CA60", Offset = "0x9B6BA60", VA = "0x189B6CA60", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public DHWREDHIAVJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9B6C930", Offset = "0x9B6B930", VA = "0x189B6C930", Slot = "4")]
		public bool YDPNNFVXYAC(object a, KBQSCVBQQMX b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public CKDEKJHWRNQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class TZFLWTYBBQZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(HVUPBMDMAQG), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : FEPVKGQXMPS, AUTTUOFFQCM, HVUPBMDMAQG, QTEVQCUAZCJ, PLNLFWQKVZL
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private XXNVUPVSQNO OHYOWYTBMHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private BCUTGJPORHF SVSVHUPLMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> URYLDINBKTN;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DA70", Offset = "0x9B6CA70", VA = "0x189B6DA70", Slot = "4")]
		public void InitReferences(GLSTNWKFOLX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DD40", Offset = "0x9B6CD40", VA = "0x189B6DD40", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B6D880", Offset = "0x9B6C880", VA = "0x189B6D880", Slot = "6")]
		public void CYVZCAWALNL(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB50", Offset = "0x9B6CB50", VA = "0x189B6DB50", Slot = "10")]
		public void PSARQYRLMBA(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B6D670", Offset = "0x9B6C670", VA = "0x189B6D670", Slot = "7")]
		public void AIFRQLCYFSL(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DE40", Offset = "0x9B6CE40", VA = "0x189B6DE40")]
		private IDictionary<object, object> VBKSULSGYVM(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DDE0", Offset = "0x9B6CDE0", VA = "0x189B6DDE0")]
		public void UTVCXQZVRGN(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DCD0", Offset = "0x9B6CCD0", VA = "0x189B6DCD0", Slot = "8")]
		private void RYSBYWLQLAZ(GLSTNWKFOLX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x10360F0", Offset = "0x10350F0", VA = "0x1810360F0", Slot = "9")]
		private void KCNBXUAVHWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E1F0", Offset = "0x9B6D1F0", VA = "0x189B6E1F0")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.PIYAHXLZAON), new string[] { })]
	internal class NPCXUMAJGRS : WPJTEEVBZMC, RecRoom.RoomLoading.RoomOperation.PIYAHXLZAON
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log MMJGIFOUBWL;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] HJGUCVFJPUM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B6D540", Offset = "0x9B6C540", VA = "0x189B6D540")]
		public NPCXUMAJGRS()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class VJLNEONCINB : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B70210", Offset = "0x9B6F210", VA = "0x189B70210", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9B70410", Offset = "0x9B6F410", VA = "0x189B70410")]
		public VJLNEONCINB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class RHLHXLYKBUA
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class GWEWRBMCNCR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings TZRJDSVFCBV;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public GWEWRBMCNCR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9B6D2B0", Offset = "0x9B6C2B0", VA = "0x189B6D2B0")]
			internal string JUYQMLOTUAS(PKEJZTAIXED a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E5F0", Offset = "0x9B6D5F0", VA = "0x189B6E5F0")]
		public static string FWOMBPVYMAU(this PKEJZTAIXED a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E800", Offset = "0x9B6D800", VA = "0x189B6E800")]
		public static NetworkEventType LQZVNBMRJCX(this PKEJZTAIXED a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E3D0", Offset = "0x9B6D3D0", VA = "0x189B6E3D0")]
		public static ViewId FFZMRPPBRWO(this PKEJZTAIXED a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9B6EB40", Offset = "0x9B6DB40", VA = "0x189B6EB40")]
		public static string XBUMFXBVBYM(this PKEJZTAIXED a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E940", Offset = "0x9B6D940", VA = "0x189B6E940")]
		private static string TCIRJUDYAMS(PKEJZTAIXED a, Func<PKEJZTAIXED, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E270", Offset = "0x9B6D270", VA = "0x189B6E270")]
		public static string DLLTARDSWMO(this PKEJZTAIXED a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E610", Offset = "0x9B6D610", VA = "0x189B6E610")]
		public static ViewId IUABJVQLBXV(this PKEJZTAIXED a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9B6EA30", Offset = "0x9B6DA30", VA = "0x189B6EA30")]
		public static string UNFTKDYSQOR(this PKEJZTAIXED a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class SEKBALWSVTO
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class WMZWSBBVMFC
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string PRBNRALGHRB;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9B6EC00", Offset = "0x9B6DC00", VA = "0x189B6EC00")]
		public static string GROCWDOVRJF(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(ESCWPOVDKYN), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class ESCWPOVDKYN : WPJTEEVBZMC
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log TQBKIJRQVIW;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log RKAFMFGFMLL;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log LRYNTOKOJJF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] HJGUCVFJPUM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9B6CD60", Offset = "0x9B6BD60", VA = "0x189B6CD60", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9B6CBE0", Offset = "0x9B6BBE0", VA = "0x189B6CBE0", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B6D100", Offset = "0x9B6C100", VA = "0x189B6D100")]
		private void XUNNSPXRFHQ(PKEJZTAIXED a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9B6CBB0", Offset = "0x9B6BBB0", VA = "0x189B6CBB0")]
		private void NYNEWOCMSRN(PKEJZTAIXED a, GWNNVAAQPXK b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9B6CEE0", Offset = "0x9B6BEE0", VA = "0x189B6CEE0")]
		public void QBDYNSILOKN(PKEJZTAIXED a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9B6CB00", Offset = "0x9B6BB00", VA = "0x189B6CB00")]
		private static Log DBMSYZWMOEX(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9B6D1C0", Offset = "0x9B6C1C0", VA = "0x189B6D1C0")]
		public ESCWPOVDKYN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class WPSURTRHZSY
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
		private static readonly JsonSerializerSettings VRMTTOOBAXP;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9B70CB0", Offset = "0x9B6FCB0", VA = "0x189B70CB0")]
		public static EventWriter VJHWUXNMRZJ([In] this EventWriter evt, PKEJZTAIXED a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9B70670", Offset = "0x9B6F670", VA = "0x189B70670")]
		public static EventWriter DSPQQVCPBPW([In] this EventWriter evt, PKEJZTAIXED a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9B719B0", Offset = "0x9B709B0", VA = "0x189B719B0")]
		public static string ZHJJENOKUHJ(PKEJZTAIXED a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9B709C0", Offset = "0x9B6F9C0", VA = "0x189B709C0")]
		public static string EEKWPEHNIRI(PKEJZTAIXED a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B704D0", Offset = "0x9B6F4D0", VA = "0x189B704D0")]
		public static string BAINAZCTTSU(PKEJZTAIXED a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9B70C20", Offset = "0x9B6FC20", VA = "0x189B70C20")]
		[CompilerGenerated]
		internal static bool RKKMFKLEVIA([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9B71850", Offset = "0x9B70850", VA = "0x189B71850")]
		[CompilerGenerated]
		internal static bool YYIHTVPUBLX([Out] string a, <>c__DisplayClass6_0 b)
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
