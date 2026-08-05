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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8618600", Offset = "0x8616C00", VA = "0x188618600", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class BMDLIECJHGD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86185B0", Offset = "0x8616BB0", VA = "0x1886185B0")]
	private static int FBCHFFJGDNC(int GCGJPGCLODI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3B6CE10", Offset = "0x3B6B410", VA = "0x183B6CE10")]
	public static int DOPNHAHLNBJ<T>(this T KOPHBHGIACG, int GCGJPGCLODI) where T : struct
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AJHGIOMIPHP
{
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	public class R1SandboxDeformableShapeNetworkData : KGMKOBIBAKM, PKCPFDEDKBE, ISandboxDeformableShapeNetworkDataAuthored, ISandboxDeformableShapeNetworkDataSerialized
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected internal PMBMFMAHILG<float3> scale;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkData.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8619410", Offset = "0x8617A10", VA = "0x188619410", Slot = "4")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8619270", Offset = "0x8617870", VA = "0x188619270", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataAuthored.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8619160", Offset = "0x8617760", VA = "0x188619160", Slot = "8")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x86193A0", Offset = "0x86179A0", VA = "0x1886193A0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private float3 RecRoom.DataLayer.ISandboxDeformableShapeNetworkDataSerialized.Scale
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8619480", Offset = "0x8617A80", VA = "0x188619480", Slot = "10")]
			get
			{
				return default(float3);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x86192E0", Offset = "0x86178E0", VA = "0x1886192E0", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ScaleChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x86191D0", Offset = "0x86177D0", VA = "0x1886191D0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x86190C0", Offset = "0x86176C0", VA = "0x1886190C0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		protected R1SandboxDeformableShapeNetworkData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x86195B0", Offset = "0x8617BB0", VA = "0x1886195B0")]
		public R1SandboxDeformableShapeNetworkData(KELOMEIMGPP context, [Optional] KGMKOBIBAKM defaults)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x134F7B0", Offset = "0x134DDB0", VA = "0x18134F7B0")]
		protected void ECEHKGGONCC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public static class SandboxDeformableShapeNetworkDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x86197B0", Offset = "0x8617DB0", VA = "0x1886197B0")]
		public static ISandboxDeformableShapeNetworkDataSerialized MOACDIKIHEH(this KGMKOBIBAKM networkData)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	public class R1MeshPresenterNetworkData : DJAOOLGKHNI, PKCPFDEDKBE, IMeshPresenterNetworkDataAuthored
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly IPHNFELODMJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		protected internal NMMHJNDHKFC<FixedString32Bytes> meshStorageFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected internal NMMHJNDHKFC<(long RequestId, int ActorNumber, int ServerTimestamp)> meshGenerationRequest;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		private FixedString32Bytes RecRoom.DataLayer.IMeshPresenterNetworkData.MeshStorageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8618EC0", Offset = "0x86174C0", VA = "0x188618EC0", Slot = "4")]
			get
			{
				return default(FixedString32Bytes);
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8618F30", Offset = "0x8617530", VA = "0x188618F30", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private (long RequestId, int ActorNumber, int ServerTimestamp) RecRoom.DataLayer.IMeshPresenterNetworkData.MeshGenerationRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8618E50", Offset = "0x8617450", VA = "0x188618E50", Slot = "6")]
			get
			{
				return default((long, int, int));
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8618FF0", Offset = "0x86175F0", VA = "0x188618FF0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshStorageFilenameSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8618FA0", Offset = "0x86175A0", VA = "0x188618FA0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private bool RecRoom.DataLayer.IMeshPresenterNetworkDataAuthored.IsMeshGenerationRequestSynchronizing
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8618D60", Offset = "0x8617360", VA = "0x188618D60", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action MeshStorageFilenameChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8618DB0", Offset = "0x86173B0", VA = "0x188618DB0", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8618C20", Offset = "0x8617220", VA = "0x188618C20", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action MeshGenerationRequestChange
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8618CC0", Offset = "0x86172C0", VA = "0x188618CC0", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8618B80", Offset = "0x8617180", VA = "0x188618B80", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		protected R1MeshPresenterNetworkData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public static class MeshPresenterNetworkDataExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86188F0", Offset = "0x8616EF0", VA = "0x1886188F0")]
		public static IMeshPresenterNetworkDataAuthored JEGGECPFIBH(this DJAOOLGKHNI networkData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8618950", Offset = "0x8616F50", VA = "0x188618950")]
		public static EHLBGEAOMHP<IHJGGHCFJKD> KMMFMIEANIB(this DJAOOLGKHNI networkData, DIJNMNHGBEB e, FixedString32Bytes value)
		{
			return default(EHLBGEAOMHP<IHJGGHCFJKD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86186D0", Offset = "0x8616CD0", VA = "0x1886186D0")]
		public static EHLBGEAOMHP<IHJGGHCFJKD> JCFDANOPGHF(this DJAOOLGKHNI networkData, DIJNMNHGBEB e, (long RequestId, int ActorNumber, int ServerTimestamp) value)
		{
			return default(EHLBGEAOMHP<IHJGGHCFJKD>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class HFDPIEANKLG
{
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class IDEENHLMJMC
{
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public IDEENHLMJMC()
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
