using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Networking_R1NetworkData_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x849FA50", Offset = "0x849E850", VA = "0x18849FA50", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class ENOBHMMMIEN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x849FA00", Offset = "0x849E800", VA = "0x18849FA00")]
	private static int FDODHKEMJMP(int GOHCCLMFAGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3B85500", Offset = "0x3B84300", VA = "0x183B85500")]
	public static int GFMNOIDINPM<T>(this T HGMAIPELJHM, int GOHCCLMFAGA) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OOLBMEIDPHF
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	public class R1SandboxDeformableShapeNetworkData : PGJGHOMCGCB, JPAPPDAPEEO, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected internal PCPGENHLMHE<float3> scale;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x84A06C0", Offset = "0x849F4C0", VA = "0x1884A06C0", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x84A07F0", Offset = "0x849F5F0", VA = "0x1884A07F0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x84A0920", Offset = "0x849F720", VA = "0x1884A0920", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x84A0650", Offset = "0x849F450", VA = "0x1884A0650", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x84A0860", Offset = "0x849F660", VA = "0x1884A0860", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x84A0730", Offset = "0x849F530", VA = "0x1884A0730", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x84A0510", Offset = "0x849F310", VA = "0x1884A0510", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x84A05B0", Offset = "0x849F3B0", VA = "0x1884A05B0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		protected R1SandboxDeformableShapeNetworkData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84A0A00", Offset = "0x849F800", VA = "0x1884A0A00")]
		public R1SandboxDeformableShapeNetworkData(NKDNONFKBGJ context, [Optional] PGJGHOMCGCB defaults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x13091E0", Offset = "0x1307FE0", VA = "0x1813091E0")]
		protected void IBAAIANNOFK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public static class SandboxDeformableShapeNetworkDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84A0C00", Offset = "0x849FA00", VA = "0x1884A0C00")]
		public static ISandboxDeformableShapeNetworkDataSerialized HIBJBNFBJPE(this PGJGHOMCGCB networkData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	public class R1MeshPresenterNetworkData : PHKKLOIBKBL, JPAPPDAPEEO, IMeshPresenterNetworkDataAuthored
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly ALMLLDBPKBM log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected internal NMNGNBCKNAM<FixedString32Bytes> meshStorageFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected internal NMNGNBCKNAM<(long RequestId, int ActorNumber, int ServerTimestamp)> meshGenerationRequest;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FixedString32Bytes RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x84A0390", Offset = "0x849F190", VA = "0x1884A0390", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x84A0140", Offset = "0x849EF40", VA = "0x1884A0140", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private (long RequestId, int ActorNumber, int ServerTimestamp) RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x84A0080", Offset = "0x849EE80", VA = "0x1884A0080", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x849FFD0", Offset = "0x849EDD0", VA = "0x18849FFD0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshStorageFilenameSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x84A00F0", Offset = "0x849EEF0", VA = "0x1884A00F0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshGenerationRequestSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x84A0030", Offset = "0x849EE30", VA = "0x1884A0030", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x84A01B0", Offset = "0x849EFB0", VA = "0x1884A01B0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x84A0400", Offset = "0x849F200", VA = "0x1884A0400", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x84A0250", Offset = "0x849F050", VA = "0x1884A0250", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x84A02F0", Offset = "0x849F0F0", VA = "0x1884A02F0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		protected R1MeshPresenterNetworkData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public static class MeshPresenterNetworkDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x849FF70", Offset = "0x849ED70", VA = "0x18849FF70")]
		public static IMeshPresenterNetworkDataAuthored GPCECHMFPDC(this PHKKLOIBKBL networkData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x849FB20", Offset = "0x849E920", VA = "0x18849FB20")]
		public static GKFOCMGEGLF<GFJAPJIFDGB> FMHCHJNOGFO(this PHKKLOIBKBL networkData, OGBLMALEBJH e, FixedString32Bytes value)
		{
			return default(GKFOCMGEGLF<GFJAPJIFDGB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x849FD50", Offset = "0x849EB50", VA = "0x18849FD50")]
		public static GKFOCMGEGLF<GFJAPJIFDGB> GHMOLHJCGBH(this PHKKLOIBKBL networkData, OGBLMALEBJH e, (long RequestId, int ActorNumber, int ServerTimestamp) value)
		{
			return default(GKFOCMGEGLF<GFJAPJIFDGB>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PMGDLPOJFPI
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EDFFLPDHNEN
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
	public EDFFLPDHNEN()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
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
