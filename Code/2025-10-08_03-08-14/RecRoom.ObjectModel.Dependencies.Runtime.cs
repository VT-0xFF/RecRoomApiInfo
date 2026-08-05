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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87457F0", Offset = "0x87445F0", VA = "0x1887457F0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class MUPXUODILAN
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
	[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
	public MUPXUODILAN()
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
		[Cpp2IlInjected.Address(RVA = "0x87456F0", Offset = "0x87444F0", VA = "0x1887456F0", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		private int[] RBTJYOZOMSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] RBODBIFRDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset MXKLQTZDJEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset MXPSOATASPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] YNQJGGLYRIN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FC0", Offset = "0xABFDC0", VA = "0x180AC0FC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x23AEDE0", Offset = "0x23ADBE0", VA = "0x1823AEDE0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87470E0", Offset = "0x8745EE0", VA = "0x1887470E0")]
		private void GQKVENIQDUS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8747490", Offset = "0x8746290", VA = "0x188747490")]
		private void GQQCBUCNNGB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87477A0", Offset = "0x87465A0", VA = "0x1887477A0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8747850", Offset = "0x8746650", VA = "0x188747850")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(JTKDNJUPETU), new string[] { "Photon" })]
	public class YXDWDVIYEYJ : JTKDNJUPETU
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class LGKDOTSENMB : GJPMAIILVKQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public EREVFMKOODS ZPMVVRQYGTP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public StatusCode ADPFTHPPDGY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public OWAKWDCCAEG FYRMHZSSWVU;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType QCFSUOQZRCP
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x8744C90", Offset = "0x8743A90", VA = "0x188744C90", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId QMPBGCEBLTY
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x8744EA0", Offset = "0x8743CA0", VA = "0x188744EA0", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool FEENKQCDBVT
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x8745080", Offset = "0x8743E80", VA = "0x188745080", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool DLPGXRDCWGU
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8744CE0", Offset = "0x8743AE0", VA = "0x188744CE0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8745180", Offset = "0x8743F80", VA = "0x188745180", Slot = "9")]
			public bool OALOSAVRTZT([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8745250", Offset = "0x8744050", VA = "0x188745250", Slot = "8")]
			public object QRSVHRQTYMF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8744EF0", Offset = "0x8743CF0", VA = "0x188744EF0", Slot = "10")]
			private (PlayerId, object) IHFCCKZKGYL()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8745090", Offset = "0x8743E90", VA = "0x188745090", Slot = "11")]
			private (ObjectNetworkId, PlayerId) MKITSVUEVUP()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x87455C0", Offset = "0x87443C0", VA = "0x1887455C0", Slot = "12")]
			private ZPKLXYDUXOG<(ObjectNetworkId, PlayerId)> VTLGSVGCMNM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8745390", Offset = "0x8744190", VA = "0x188745390", Slot = "13")]
			private (OutOfBandMessageType, byte[]) UZSDRVKNVVE()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8744A70", Offset = "0x8743870", VA = "0x188744A70", Slot = "14")]
			private (PacketSource, byte[]) FOMHZZNAHER()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3ED83C0", Offset = "0x3ED71C0", VA = "0x183ED83C0", Slot = "15")]
			public a EBMWESRKLGC<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x87452A0", Offset = "0x87440A0", VA = "0x1887452A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public LGKDOTSENMB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class OWAKWDCCAEG : ZPKLXYDUXOG<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public int[] QZUMICANABN;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int UFYFSTWLMQP
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x8745870", Offset = "0x8744670", VA = "0x188745870", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x8745890", Offset = "0x8744690", VA = "0x188745890", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public OWAKWDCCAEG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8746E20", Offset = "0x8745C20", VA = "0x188746E20", Slot = "4")]
		public bool JWCZNXMOHLN(object a, GJPMAIILVKQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		public YXDWDVIYEYJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class NWATLPFSRYO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(MDJLEMKMODB), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : IUKSRZVFRMZ, KCNLFOLQCCZ, MDJLEMKMODB, KSWDMDRTSDM, ZDJVRLQDMXE
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private FBXOULORZSF XQDIIBKHXJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[DependsOn]
		private GITSWUVCFEG SWDUUCRBHZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Hashtable OCFWMYFJCWS;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8745930", Offset = "0x8744730", VA = "0x188745930", Slot = "4")]
		public void InitReferences(FCHQYTALOWK services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8745F70", Offset = "0x8744D70", VA = "0x188745F70", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8746010", Offset = "0x8744E10", VA = "0x188746010", Slot = "6")]
		public void YYURBTEIQKW(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8745E50", Offset = "0x8744C50", VA = "0x188745E50", Slot = "10")]
		public void SOPREBXMSTR(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8745CC0", Offset = "0x8744AC0", VA = "0x188745CC0", Slot = "7")]
		public void SIKQNPCFFKM(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8745A10", Offset = "0x8744810", VA = "0x188745A10")]
		private Hashtable LWVVEOVWUZP(Hashtable a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8745C60", Offset = "0x8744A60", VA = "0x188745C60")]
		public void QVEMTFCCSAW(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8746170", Offset = "0x8744F70", VA = "0x188746170", Slot = "8")]
		private void ZZSCPZJHWHS(FCHQYTALOWK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1026850", Offset = "0x1025650", VA = "0x181026850", Slot = "9")]
		private void NNPEZXMTYDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8746260", Offset = "0x8745060", VA = "0x188746260")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.ECINABZCRXW), new string[] { })]
	internal class ACSVFFNGJRF : KVJBPFUKJFV, RecRoom.RoomLoading.RoomOperation.ECINABZCRXW
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Log FAIDWCPBUSK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] KTAAHBRGEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8741B80", Offset = "0x8740980", VA = "0x188741B80")]
		public ACSVFFNGJRF()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class RVCLGBTROQE : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x87468E0", Offset = "0x87456E0", VA = "0x1887468E0", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8746AD0", Offset = "0x87458D0", VA = "0x188746AD0")]
		public RVCLGBTROQE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class IDLKUJQCATX
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class ZLLAWYXLGFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public JsonSerializerSettings FEANZURJNUI;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ZLLAWYXLGFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8746FA0", Offset = "0x8745DA0", VA = "0x188746FA0")]
			internal string PKQHSGYUZFJ(EREVFMKOODS a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x87443C0", Offset = "0x87431C0", VA = "0x1887443C0")]
		public static string CRKECKNXJJJ(this EREVFMKOODS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x87445D0", Offset = "0x87433D0", VA = "0x1887445D0")]
		public static NetworkEventType JTPTDWKYJLC(this EREVFMKOODS a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x87443E0", Offset = "0x87431E0", VA = "0x1887443E0")]
		public static ViewId FVSRRSEAEAX(this EREVFMKOODS a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8744710", Offset = "0x8743510", VA = "0x188744710")]
		public static string QBJJRZZMMMV(this EREVFMKOODS a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x87447D0", Offset = "0x87435D0", VA = "0x1887447D0")]
		private static string QIKPLZXQAFN(EREVFMKOODS a, Func<EREVFMKOODS, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x87448C0", Offset = "0x87436C0", VA = "0x1887448C0")]
		public static string VLVHQNYKRKV(this EREVFMKOODS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x87441F0", Offset = "0x8742FF0", VA = "0x1887441F0")]
		public static ViewId CKWWAUBMNSS(this EREVFMKOODS a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x87440E0", Offset = "0x8742EE0", VA = "0x1887440E0")]
		public static string BXYJVVHYYRA(this EREVFMKOODS a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class QNXRVIJXMZR
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class JRBPEJYJCVN
		{
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static string TBUIYZUOALI;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x87462D0", Offset = "0x87450D0", VA = "0x1887462D0")]
		public static string JUFBWWLZTWA(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(GVIUOEKLHGQ), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class GVIUOEKLHGQ : KVJBPFUKJFV
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log RKZCTAZMQFZ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log BTJKAIFSUYU;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly Log JOBVNUHUIWK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] KTAAHBRGEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8743B90", Offset = "0x8742990", VA = "0x188743B90", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8743A20", Offset = "0x8742820", VA = "0x188743A20", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8743D00", Offset = "0x8742B00", VA = "0x188743D00")]
		private void SANDUGOHEOZ(EREVFMKOODS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8743F30", Offset = "0x8742D30", VA = "0x188743F30")]
		private void XGYKNSHQSJS(EREVFMKOODS a, QBWHSXSYUOT b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8743D10", Offset = "0x8742B10", VA = "0x188743D10")]
		public void VTECLCXVZCU(EREVFMKOODS a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8743970", Offset = "0x8742770", VA = "0x188743970")]
		private static Log IWFDVKMSAZO(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8744000", Offset = "0x8742E00", VA = "0x188744000")]
		public GVIUOEKLHGQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class DKBRAYIDPMP
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
		private static readonly JsonSerializerSettings UJMCKPRPIDI;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8741C30", Offset = "0x8740A30", VA = "0x188741C30")]
		public static EventWriter JLZVDXTRRAY([In] this EventWriter evt, EREVFMKOODS a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x87430F0", Offset = "0x8741EF0", VA = "0x1887430F0")]
		public static EventWriter MFGUGNETGUH([In] this EventWriter evt, EREVFMKOODS a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8742CB0", Offset = "0x8741AB0", VA = "0x188742CB0")]
		public static string KSLRIDFYWVO(EREVFMKOODS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8742E90", Offset = "0x8741C90", VA = "0x188742E90")]
		public static string LFHBRYAKSJB(EREVFMKOODS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8743630", Offset = "0x8742430", VA = "0x188743630")]
		public static string XFAKHUDTDGH(EREVFMKOODS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8743440", Offset = "0x8742240", VA = "0x188743440")]
		[CompilerGenerated]
		internal static bool QVGELWHPUVV([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x87434D0", Offset = "0x87422D0", VA = "0x1887434D0")]
		[CompilerGenerated]
		internal static bool TIOQXFFQXXQ([Out] string a, <>c__DisplayClass6_0 b)
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
