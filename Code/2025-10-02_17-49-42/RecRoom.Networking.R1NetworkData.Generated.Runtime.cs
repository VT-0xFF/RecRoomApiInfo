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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x860E300", Offset = "0x860CD00", VA = "0x18860E300", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class GKCFNCPFAII
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x860E2B0", Offset = "0x860CCB0", VA = "0x18860E2B0")]
	private static int JFMKFABIGPI(int GFFIPEFBEIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3DB6650", Offset = "0x3DB5050", VA = "0x183DB6650")]
	public static int HKKHGFKKKDA<T>(this T KMAFNKGMDCF, int GFFIPEFBEIK) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CNIAKEGAMHC
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	public class R1SandboxDeformableShapeNetworkData : GBBMODPOPBK, MBOKBPJPMMM, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected internal IEJEGKIFFLB<float3> scale;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x860F1D0", Offset = "0x860DBD0", VA = "0x18860F1D0", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x860F160", Offset = "0x860DB60", VA = "0x18860F160", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x860EED0", Offset = "0x860D8D0", VA = "0x18860EED0", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x860EE60", Offset = "0x860D860", VA = "0x18860EE60", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x860F0A0", Offset = "0x860DAA0", VA = "0x18860F0A0", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x860EFE0", Offset = "0x860D9E0", VA = "0x18860EFE0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x860EF40", Offset = "0x860D940", VA = "0x18860EF40", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x860EDC0", Offset = "0x860D7C0", VA = "0x18860EDC0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		protected R1SandboxDeformableShapeNetworkData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x860F2B0", Offset = "0x860DCB0", VA = "0x18860F2B0")]
		public R1SandboxDeformableShapeNetworkData(MEDDKFIHEPM context, [Optional] GBBMODPOPBK defaults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1366E70", Offset = "0x1365870", VA = "0x181366E70")]
		protected void NEDAPOMPAMN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public static class SandboxDeformableShapeNetworkDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x860F4B0", Offset = "0x860DEB0", VA = "0x18860F4B0")]
		public static ISandboxDeformableShapeNetworkDataSerialized EINGHLEABBP(this GBBMODPOPBK networkData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	public class R1MeshPresenterNetworkData : FOGHKHKPFMM, MBOKBPJPMMM, IMeshPresenterNetworkDataAuthored
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly OLFEOKKCIEG log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected internal ANIGAAGFKEA<FixedString32Bytes> meshStorageFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected internal ANIGAAGFKEA<(long RequestId, int ActorNumber, int ServerTimestamp)> meshGenerationRequest;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FixedString32Bytes RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x860E8D0", Offset = "0x860D2D0", VA = "0x18860E8D0", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x860ECE0", Offset = "0x860D6E0", VA = "0x18860ECE0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private (long RequestId, int ActorNumber, int ServerTimestamp) RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x860EB30", Offset = "0x860D530", VA = "0x18860EB30", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x860E990", Offset = "0x860D390", VA = "0x18860E990", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshStorageFilenameSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x860E940", Offset = "0x860D340", VA = "0x18860E940", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshGenerationRequestSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x860E880", Offset = "0x860D280", VA = "0x18860E880", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x860EBA0", Offset = "0x860D5A0", VA = "0x18860EBA0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x860EC40", Offset = "0x860D640", VA = "0x18860EC40", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x860EA90", Offset = "0x860D490", VA = "0x18860EA90", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x860E9F0", Offset = "0x860D3F0", VA = "0x18860E9F0", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		protected R1MeshPresenterNetworkData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public static class MeshPresenterNetworkDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x860E3D0", Offset = "0x860CDD0", VA = "0x18860E3D0")]
		public static IMeshPresenterNetworkDataAuthored LDBOHONPHIC(this FOGHKHKPFMM networkData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x860E650", Offset = "0x860D050", VA = "0x18860E650")]
		public static NPFKNIJFGHB<LJBIGLJNMFO> PJPKGCCMIEJ(this FOGHKHKPFMM networkData, GOGDLCPEJKJ e, FixedString32Bytes value)
		{
			return default(NPFKNIJFGHB<LJBIGLJNMFO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x860E430", Offset = "0x860CE30", VA = "0x18860E430")]
		public static NPFKNIJFGHB<LJBIGLJNMFO> NEAOEJBCNLG(this FOGHKHKPFMM networkData, GOGDLCPEJKJ e, (long RequestId, int ActorNumber, int ServerTimestamp) value)
		{
			return default(NPFKNIJFGHB<LJBIGLJNMFO>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class IHKMOFDMGKE
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class HOMBPOKEPHI
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HOMBPOKEPHI()
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
