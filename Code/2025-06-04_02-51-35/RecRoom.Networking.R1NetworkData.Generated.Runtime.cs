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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x80B5690", Offset = "0x80B3E90", VA = "0x1880B5690", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class PHPNEMHMHEE
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AOHAGDDDIMJ
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	public class R1SandboxDeformableShapeNetworkData : AJMOHKGFDEI, DLEFIPJOGKA, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected internal IPMBLMMANMH<float3> scale;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x80B5B30", Offset = "0x80B4330", VA = "0x1880B5B30", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x80B5720", Offset = "0x80B3F20", VA = "0x1880B5720", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x80B5790", Offset = "0x80B3F90", VA = "0x1880B5790", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x80B58C0", Offset = "0x80B40C0", VA = "0x1880B58C0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x80B5930", Offset = "0x80B4130", VA = "0x1880B5930", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x80B5800", Offset = "0x80B4000", VA = "0x1880B5800", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x80B5A90", Offset = "0x80B4290", VA = "0x1880B5A90", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x80B59F0", Offset = "0x80B41F0", VA = "0x1880B59F0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		protected R1SandboxDeformableShapeNetworkData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80B5C10", Offset = "0x80B4410", VA = "0x1880B5C10")]
		public R1SandboxDeformableShapeNetworkData(MBOKBFNEDFM context, [Optional] AJMOHKGFDEI defaults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x119A3C0", Offset = "0x1198BC0", VA = "0x18119A3C0")]
		protected void LMGLJAPFGGA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public static class SandboxDeformableShapeNetworkDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80B5E10", Offset = "0x80B4610", VA = "0x1880B5E10")]
		public static ISandboxDeformableShapeNetworkDataSerialized OLNCPIGEDHG(this AJMOHKGFDEI networkData)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class APFOGJLPKIB
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LBHJJCIMPIK
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
	public LBHJJCIMPIK()
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
