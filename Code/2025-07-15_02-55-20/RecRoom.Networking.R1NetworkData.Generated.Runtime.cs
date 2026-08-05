using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Networking_R1NetworkData_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8213A20", Offset = "0x8212620", VA = "0x188213A20", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class KIMIFFKIPCC
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CCFMMNMIFEC
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	public class R1SandboxDeformableShapeNetworkData : MAAIGLGFMMK, GKNPGOIAOJL, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected internal BHCLHBFEPMH<float3> scale;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8213B20", Offset = "0x8212720", VA = "0x188213B20", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8213E50", Offset = "0x8212A50", VA = "0x188213E50", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8213EC0", Offset = "0x8212AC0", VA = "0x188213EC0", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8213AB0", Offset = "0x82126B0", VA = "0x188213AB0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8213B90", Offset = "0x8212790", VA = "0x188213B90", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8213D90", Offset = "0x8212990", VA = "0x188213D90", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8213CF0", Offset = "0x82128F0", VA = "0x188213CF0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8213C50", Offset = "0x8212850", VA = "0x188213C50", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		protected R1SandboxDeformableShapeNetworkData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8213FA0", Offset = "0x8212BA0", VA = "0x188213FA0")]
		public R1SandboxDeformableShapeNetworkData(NJMPDLBKJDJ context, [Optional] MAAIGLGFMMK defaults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1289A70", Offset = "0x1288670", VA = "0x181289A70")]
		protected void MIMOBEGINPP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public static class SandboxDeformableShapeNetworkDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x82141A0", Offset = "0x8212DA0", VA = "0x1882141A0")]
		public static ISandboxDeformableShapeNetworkDataSerialized DCEIMCPPFAC(this MAAIGLGFMMK networkData)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HCMIPIABPGN
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MBCOCJPKMMG
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public MBCOCJPKMMG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
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
