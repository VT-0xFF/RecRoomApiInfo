using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;
using RecRoom.CodeGen.Attributes;
using RecRoom.Components;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.Systems;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Core;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace Unity.Entities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class EntityManagerTemporarySingletonExtensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2272D90", Offset = "0x2271590", VA = "0x182272D90")]
		public static JLLEMCAIFLB<T> CreateTemporarySingleton<T>(this EntityManager entityManager, T componentData) where T : struct, IComponentData
		{
			return default(JLLEMCAIFLB<T>);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct IEEMBBHOPNA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PELBEBCDLPI]
public static class MGLDLPIIEKC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CEE0", Offset = "0x5E3B6E0", VA = "0x185E3CEE0")]
	static MGLDLPIIEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2442BA0", Offset = "0x24413A0", VA = "0x182442BA0")]
	public static void INLNMAKKHJG<T>(T INOEECCONEM, T HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CDF0", Offset = "0x5E3B5F0", VA = "0x185E3CDF0")]
	public static void INLNMAKKHJG(FixedString32Bytes INOEECCONEM, string HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CC80", Offset = "0x5E3B480", VA = "0x185E3CC80")]
	public static void INLNMAKKHJG(string INOEECCONEM, FixedString32Bytes HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CD20", Offset = "0x5E3B520", VA = "0x185E3CD20")]
	public static void INLNMAKKHJG(FixedString64Bytes INOEECCONEM, string HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CD90", Offset = "0x5E3B590", VA = "0x185E3CD90")]
	public static void INLNMAKKHJG(string INOEECCONEM, FixedString64Bytes HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CE20", Offset = "0x5E3B620", VA = "0x185E3CE20")]
	public static void INLNMAKKHJG(BOJCABCAEKF INOEECCONEM, Vector3 HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D71DD0", Offset = "0x5D705D0", VA = "0x185D71DD0")]
	public static void INLNMAKKHJG(Vector3 INOEECCONEM, BOJCABCAEKF HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CCC0", Offset = "0x5E3B4C0", VA = "0x185E3CCC0")]
	public static void INLNMAKKHJG(FNAGNNKNHCE INOEECCONEM, Vector4 HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D6FBC0", Offset = "0x5D6E3C0", VA = "0x185D6FBC0")]
	public static void INLNMAKKHJG(Vector4 INOEECCONEM, FNAGNNKNHCE HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CCC0", Offset = "0x5E3B4C0", VA = "0x185E3CCC0")]
	public static void INLNMAKKHJG(FNAGNNKNHCE INOEECCONEM, Quaternion HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D6FBC0", Offset = "0x5D6E3C0", VA = "0x185D6FBC0")]
	public static void INLNMAKKHJG(Quaternion INOEECCONEM, FNAGNNKNHCE HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CCF0", Offset = "0x5E3B4F0", VA = "0x185E3CCF0")]
	public static void INLNMAKKHJG(BOJCABCAEKF INOEECCONEM, float3 HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D71DD0", Offset = "0x5D705D0", VA = "0x185D71DD0")]
	public static void INLNMAKKHJG(float3 INOEECCONEM, BOJCABCAEKF HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CC60", Offset = "0x5E3B460", VA = "0x185E3CC60")]
	public static void INLNMAKKHJG(FNAGNNKNHCE INOEECCONEM, float4 HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D6FBC0", Offset = "0x5D6E3C0", VA = "0x185D6FBC0")]
	public static void INLNMAKKHJG(float4 INOEECCONEM, FNAGNNKNHCE HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CC60", Offset = "0x5E3B460", VA = "0x185E3CC60")]
	public static void INLNMAKKHJG(FNAGNNKNHCE INOEECCONEM, quaternion HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CE50", Offset = "0x5E3B650", VA = "0x185E3CE50")]
	public static void INLNMAKKHJG(quaternion INOEECCONEM, FNAGNNKNHCE HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CD50", Offset = "0x5E3B550", VA = "0x185E3CD50")]
	public static void INLNMAKKHJG(Entity INOEECCONEM, FPBDDHDAEMG HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CEB0", Offset = "0x5E3B6B0", VA = "0x185E3CEB0")]
	public static void INLNMAKKHJG(FPBDDHDAEMG INOEECCONEM, Entity HMIAICAALJL, DHNDNMFMONI GLLIFKANKFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal class CDAGICAOKHH : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E21960", Offset = "0x5E20160", VA = "0x185E21960", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E21A10", Offset = "0x5E20210", VA = "0x185E21A10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public CDAGICAOKHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DMDOGFFEKFK(PJHIMKBCGDP.OMRoom)]
internal class JANHFGANGJL : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LKNNFAHLOJG KNCHFLCNMFH;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E38B80", Offset = "0x5E37380", VA = "0x185E38B80", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E38BD0", Offset = "0x5E373D0", VA = "0x185E38BD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public JANHFGANGJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[UnityEngine.Scripting.Preserve]
internal class AKICALDPOPK : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private EntityQuery GLAEOLMGIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F730", Offset = "0x5E1DF30", VA = "0x185E1F730", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F780", Offset = "0x5E1DF80", VA = "0x185E1F780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F810", Offset = "0x5E1E010", VA = "0x185E1F810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public AKICALDPOPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DMDOGFFEKFK(PJHIMKBCGDP.OMRoom)]
internal class DIMFKGEMOLG : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private LKNNFAHLOJG KNCHFLCNMFH;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E23B80", Offset = "0x5E22380", VA = "0x185E23B80", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E23BD0", Offset = "0x5E223D0", VA = "0x185E23BD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public DIMFKGEMOLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DMDOGFFEKFK(PJHIMKBCGDP.OMRoom)]
internal class JEFCEEOGBIO : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private NGKJMLHKKJA MJIDHJMLMMA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E38EB0", Offset = "0x5E376B0", VA = "0x185E38EB0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E38F00", Offset = "0x5E37700", VA = "0x185E38F00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public JEFCEEOGBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[UnityEngine.Scripting.Preserve]
internal sealed class MCCEIGEDDIL<T> : DPGFJAECHAF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6A90", Offset = "0x3AE5290", VA = "0x183AE6A90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6C00", Offset = "0x3AE5400", VA = "0x183AE6C00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public MCCEIGEDDIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[GPKGGHMNPIO]
public class MBIAIOBFFLL : ComponentSystem, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private HMNFMHNMJBH HKPFEANEPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76E4B0", Offset = "0x76CCB0", VA = "0x18076E4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LAIAFMADGKP BKFHKDJCBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x766310", Offset = "0x764B10", VA = "0x180766310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C4A0", Offset = "0x5E3ACA0", VA = "0x185E3C4A0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
	public MBIAIOBFFLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class CPPDPPMONIE : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E23890", Offset = "0x5E22090", VA = "0x185E23890", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E23A90", Offset = "0x5E22290", VA = "0x185E23A90")]
	[UnityEngine.Scripting.Preserve]
	private void FDGGLPJGJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public CPPDPPMONIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class CEHLDMFHGGL : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E22440", Offset = "0x5E20C40", VA = "0x185E22440", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public CEHLDMFHGGL()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ObjectModelConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FA60", Offset = "0x5E3E260", VA = "0x185E3FA60")]
		public static ObjectModelConfigAsset GIPNPFNCJME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x848550", Offset = "0x846D50", VA = "0x180848550")]
		public ObjectModelConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GCPJGKHGLBB
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F230", Offset = "0x5E2DA30", VA = "0x185E2F230")]
	public static void JOEEDOBCBFN(DGJIKJLGCCH KFIEDGIKACP, string JKNJBKKEFEH, INJNNPDEJLM CHOIABKOLCK, Action PPECMLCFPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F460", Offset = "0x5E2DC60", VA = "0x185E2F460")]
	public static void JOEEDOBCBFN(DGJIKJLGCCH KFIEDGIKACP, string JKNJBKKEFEH, AJLMOHPDADI ILKGCMEIKLC, Action PPECMLCFPKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class OFEMIFICLCF
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class CILLACBJELK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class HIIJJJAJFCK
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly DGJIKJLGCCH KFIEDGIKACP;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5E31B50", Offset = "0x5E30350", VA = "0x185E31B50")]
		public static AFCHODDKGEA GIDCGENOPBA(int GBLKJMGFPJD, FPGIHDDJKFI NFBNNCDBMIA)
		{
			return default(AFCHODDKGEA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5E31EB0", Offset = "0x5E306B0", VA = "0x185E31EB0")]
		private static INJNNPDEJLM HGHIDNIDGJM(FPGIHDDJKFI BNGJEHAGCLG, INJNNPDEJLM BNKNCJCBJGG)
		{
			return default(INJNNPDEJLM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E319D0", Offset = "0x5E301D0", VA = "0x185E319D0")]
		private static void CDHGIBEFBIP(INJNNPDEJLM FKLLFPDOAPO, INJNNPDEJLM GPFGBPNCKIA, AFCHODDKGEA NFLGLAGMLAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E31F40", Offset = "0x5E30740", VA = "0x185E31F40")]
		public static int MABHFJOIBJB(GameObject GOGHJGCCDJI, MGOIFNPCOHN LKCCOOJBOCB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static AOCJHGPOFOG PILDAKCKHDL;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static EHNBALNPIJE OHCKDBMMLJD;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static EHNBALNPIJE PNPIIFPHFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5E22A40", Offset = "0x5E21240", VA = "0x185E22A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool JDICDIOOCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E22D00", Offset = "0x5E21500", VA = "0x185E22D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static HMNFMHNMJBH HKPFEANEPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5E22F10", Offset = "0x5E21710", VA = "0x185E22F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static LAIAFMADGKP BKFHKDJCBDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5E22880", Offset = "0x5E21080", VA = "0x185E22880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static JDHDACCAMDF MDPOAGJFEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E234C0", Offset = "0x5E21CC0", VA = "0x185E234C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static LDNONJHJNKB AOCEPDFNMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E22F90", Offset = "0x5E21790", VA = "0x185E22F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static KMLALHOKNKB DNDCCOBNFMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5E22810", Offset = "0x5E21010", VA = "0x185E22810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static EJDAAEMCDOG EGEPIPGLFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E231D0", Offset = "0x5E219D0", VA = "0x185E231D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool EOOOACJGJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E23720", Offset = "0x5E21F20", VA = "0x185E23720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool ACIJKPGBPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E22B70", Offset = "0x5E21370", VA = "0x185E22B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static NNONLMNKHJH AAEDHCONLGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E22E70", Offset = "0x5E21670", VA = "0x185E22E70")]
		get
		{
			return default(NNONLMNKHJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool GJEJDEGJEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E23530", Offset = "0x5E21D30", VA = "0x185E23530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static byte EHGJAIIAPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E23000", Offset = "0x5E21800", VA = "0x185E23000")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static byte FMOJCBJKAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool FDLOFLKMKFO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5E23180", Offset = "0x5E21980", VA = "0x185E23180")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool DBKMMAOLAHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5E22670", Offset = "0x5E20E70", VA = "0x185E22670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E226C0", Offset = "0x5E20EC0", VA = "0x185E226C0")]
	public static void BGINIOMJIHH(AOCJHGPOFOG FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E23380", Offset = "0x5E21B80", VA = "0x185E23380")]
	public static INJNNPDEJLM OGCAMABILPC(GameObject GOGHJGCCDJI)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E23100", Offset = "0x5E21900", VA = "0x185E23100")]
	public static NNONLMNKHJH JKIKLJFOCBD(AFCHODDKGEA NFLGLAGMLAA)
	{
		return default(NNONLMNKHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E228F0", Offset = "0x5E210F0", VA = "0x185E228F0")]
	public static bool BOEPLFNANEH(GameObject GOGHJGCCDJI, [Out] AFCHODDKGEA NFLGLAGMLAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E22BC0", Offset = "0x5E213C0", VA = "0x185E22BC0")]
	public static HAFKINAIAFI GLJLHLCKMJG(IEnumerable<KFOICHFNJOO> EKIKDOJOMMA)
	{
		return default(HAFKINAIAFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E22580", Offset = "0x5E20D80", VA = "0x185E22580")]
	private static EHNBALNPIJE AKPFEGDAHJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E23240", Offset = "0x5E21A40", VA = "0x185E23240")]
	private static bool NIJPFGNIHMG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MBLHIBLCMEI
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C6D0", Offset = "0x5E3AED0", VA = "0x185E3C6D0")]
	public static bool KGEAGMNADGJ(JNHCKHFIJLH JBOJPLNIPBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C990", Offset = "0x5E3B190", VA = "0x185E3C990")]
	public static JNHCKHFIJLH NJMEIPIEAKJ(GameObject GOGHJGCCDJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C7E0", Offset = "0x5E3AFE0", VA = "0x185E3C7E0")]
	public static JNHCKHFIJLH NJMEIPIEAKJ(GameObject GOGHJGCCDJI, AFCHODDKGEA NFLGLAGMLAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C510", Offset = "0x5E3AD10", VA = "0x185E3C510")]
	public static bool KEKGKCAAJJB(GameObject JFHKBBJBKEA, string MJGKNDPHJPG, bool HDGDGBIJFDD)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DisembodiedObjectView : MonoBehaviour, HOKIJCGLMBB
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PODDKBEPHJP
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public INJNNPDEJLM NPICDLBODMG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(INJNNPDEJLM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD151F0", Offset = "0xD139F0", VA = "0x180D151F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A900", Offset = "0x5E29100", VA = "0x185E2A900")]
		public void SetName(string HNHMJGCODBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public sealed class EmbodiedObject : MonoBehaviour, JNHCKHFIJLH, HOKIJCGLMBB
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly DGJIKJLGCCH KFIEDGIKACP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private const string LLPECJEDJIJ = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JAIFBPOBGDK CDOGIGHJFKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private INJNNPDEJLM LHIGGCOIHEC;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public INJNNPDEJLM NPICDLBODMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CA60", Offset = "0x5E2B260", VA = "0x185E2CA60", Slot = "15")]
			get
			{
				return default(INJNNPDEJLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public NNONLMNKHJH IOCOFAMFJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CB10", Offset = "0x5E2B310", VA = "0x185E2CB10", Slot = "6")]
			get
			{
				return default(NNONLMNKHJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool PODDKBEPHJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CA50", Offset = "0x5E2B250", VA = "0x185E2CA50", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public JAIFBPOBGDK NKKEFJOIEAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x870060", Offset = "0x86E860", VA = "0x180870060", Slot = "7")]
			get
			{
				return default(JAIFBPOBGDK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private LAIAFMADGKP BKFHKDJCBDC
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5E2C220", Offset = "0x5E2AA20", VA = "0x185E2C220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool GAPIBOGOKOG
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FB580", VA = "0x1807FCD80", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x86B8B0", Offset = "0x86A0B0", VA = "0x18086B8B0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> LFFOCNGGLHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5E2C8F0", Offset = "0x5E2B0F0", VA = "0x185E2C8F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CB20", Offset = "0x5E2B320", VA = "0x185E2CB20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<JNHCKHFIJLH> CIPOIBOICBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5E2C9A0", Offset = "0x5E2B1A0", VA = "0x185E2C9A0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5E2CBD0", Offset = "0x5E2B3D0", VA = "0x185E2CBD0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C040", Offset = "0x5E2A840", VA = "0x185E2C040")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C730", Offset = "0x5E2AF30", VA = "0x185E2C730", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C3B0", Offset = "0x5E2ABB0", VA = "0x185E2C3B0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C6F0", Offset = "0x5E2AEF0", VA = "0x185E2C6F0", Slot = "10")]
		public void OnEmbody(CIKNOIPMHLH NMJLCHEIIPL, INJNNPDEJLM LHIGGCOIHEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C720", Offset = "0x5E2AF20", VA = "0x185E2C720", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C5F0", Offset = "0x5E2ADF0", VA = "0x185E2C5F0", Slot = "12")]
		public void OnDisembody(bool AODDAOIDPEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C290", Offset = "0x5E2AA90", VA = "0x185E2C290")]
		private void ICBAONGBBGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C370", Offset = "0x5E2AB70", VA = "0x185E2C370", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA233D0", Offset = "0xA21BD0", VA = "0x180A233D0", Slot = "9")]
		private GameObject PHOEEBHCKOO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7644E0", Offset = "0x762CE0", VA = "0x1807644E0")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleComponent]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override ILMCDCGEOPC KDFHBKOMOJH
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5E40050", Offset = "0x5E3E850", VA = "0x185E40050", Slot = "6")]
			get
			{
				return default(ILMCDCGEOPC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E40000", Offset = "0x5E3E800", VA = "0x185E40000")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DisallowMultipleComponent]
	public class TransformEntity : MonoBehaviour, HOKIJCGLMBB
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly DGJIKJLGCCH KFIEDGIKACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private ILMCDCGEOPC prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private INJNNPDEJLM JFIBILKOJPE;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual ILMCDCGEOPC KDFHBKOMOJH
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x768D90", Offset = "0x767590", VA = "0x180768D90", Slot = "6")]
			get
			{
				return default(ILMCDCGEOPC);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x76B5C0", Offset = "0x769DC0", VA = "0x18076B5C0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public INJNNPDEJLM NPICDLBODMG
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x3132A10", Offset = "0x3131210", VA = "0x183132A10", Slot = "5")]
			get
			{
				return default(INJNNPDEJLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool PODDKBEPHJP
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x10092D0", Offset = "0x1007AD0", VA = "0x1810092D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x10092E0", Offset = "0x1007AE0", VA = "0x1810092E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		internal Entity KOKGOFCOJJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5E40440", Offset = "0x5E3EC40", VA = "0x185E40440")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal LDNONJHJNKB AOCEPDFNMKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5E403B0", Offset = "0x5E3EBB0", VA = "0x185E403B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal LJJGONKGMDG FNDDFFOHHHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5E403C0", Offset = "0x5E3EBC0", VA = "0x185E403C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E40060", Offset = "0x5E3E860", VA = "0x185E40060")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5E40500", Offset = "0x5E3ED00", VA = "0x185E40500")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5E400A0", Offset = "0x5E3E8A0", VA = "0x185E400A0")]
		internal void GLJEDCMMNGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5E40460", Offset = "0x5E3EC60", VA = "0x185E40460")]
		private bool IIFPOIKNKKP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E40070", Offset = "0x5E3E870", VA = "0x185E40070")]
		private void EAKKJEMNOEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E40500", Offset = "0x5E3ED00", VA = "0x185E40500")]
		internal void MIPIJDCBCOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E405F0", Offset = "0x5E3EDF0", VA = "0x185E405F0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E40700", Offset = "0x5E3EF00", VA = "0x185E40700")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DEONFKEHMJD(typeof(EHNBALNPIJE), new string[] { })]
[CIJINFPJIAB(typeof(DEDLLFMJKEO))]
[CIJINFPJIAB(typeof(CAFJCJJFAEN))]
public class HCJLEEELFBF : EHNBALNPIJE, IKHNKAPNHGJ, DEDLLFMJKEO, IDisposable, CAFJCJJFAEN
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly ProfilerMarker BENCPHAIKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private AOCJHGPOFOG CJEADCONOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LAIAFMADGKP FOCFONOKHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JKEGAAHHGLK AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private CMHDFMPGDKC INJJFABGALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public AOCJHGPOFOG HKPFEANEPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public JKEGAAHHGLK MHGBJPCGLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public LAIAFMADGKP BKFHKDJCBDC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public CMHDFMPGDKC OBKLKHLGMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool AMDAEMPIIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7B7C00", Offset = "0x7B6400", VA = "0x1807B7C00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public JKJLANOOPAE PJMEDLCAIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x80C110", Offset = "0x80A910", VA = "0x18080C110", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(JKJLANOOPAE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x80C120", Offset = "0x80A920", VA = "0x18080C120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CFNCBLLJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xDBED00", Offset = "0xDBD500", VA = "0x180DBED00", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1C121C0", Offset = "0x1C109C0", VA = "0x181C121C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public GKJIGEDKBPA EMOENIDPGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7E07D0", Offset = "0x7DEFD0", VA = "0x1807E07D0", Slot = "10")]
		get
		{
			return default(GKJIGEDKBPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5E30F60", Offset = "0x5E2F760", VA = "0x185E30F60", Slot = "14")]
	private void IOLICIFFEAE(bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5E311C0", Offset = "0x5E2F9C0", VA = "0x185E311C0")]
	public static HCJLEEELFBF KLKFANDJKFE(AOCJHGPOFOG CJEADCONOPM, EJMCFOHDECJ ODJEHGDEAEP = EJMCFOHDECJ.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void IMEFNKCAPDL(AOCJHGPOFOG CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void IMACFPKPNKN(AOCJHGPOFOG CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E30DE0", Offset = "0x5E2F5E0", VA = "0x185E30DE0", Slot = "11")]
	public void IJALEBCDNGI(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xBEC700", Offset = "0xBEAF00", VA = "0x180BEC700")]
	private void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E31370", Offset = "0x5E2FB70", VA = "0x185E31370")]
	private void LFLCPKOHLEL(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5E30D50", Offset = "0x5E2F550", VA = "0x185E30D50", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HCJLEEELFBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KLCCKJDFOJE
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum EJMCFOHDECJ
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DEONFKEHMJD(typeof(CMHDFMPGDKC), new string[] { })]
public class FAMODFMNOEJ : CMHDFMPGDKC, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly DGJIKJLGCCH LODPDBADFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private AOCJHGPOFOG CJEADCONOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private CAFJCJJFAEN OJMKLKDIMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private JKEGAAHHGLK AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EHNBALNPIJE OHCKDBMMLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private FJGKMPJNNPH IKCAIPFFHGG;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool PKHCPGLHJCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CDC0", Offset = "0x5E2B5C0", VA = "0x185E2CDC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action ADJJLLONICG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CED0", Offset = "0x5E2B6D0", VA = "0x185E2CED0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CE30", Offset = "0x5E2B630", VA = "0x185E2CE30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CF70", Offset = "0x5E2B770", VA = "0x185E2CF70", Slot = "12")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D090", Offset = "0x5E2B890", VA = "0x185E2D090", Slot = "6")]
	public void MIJIMJFCLFI(bool OPLCONEPBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D040", Offset = "0x5E2B840", VA = "0x185E2D040", Slot = "7")]
	public bool KKHGIICBGDH(ByteString KDMODAMJKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D280", Offset = "0x5E2BA80", VA = "0x185E2D280", Slot = "11")]
	public void PMBGHFGPJNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1643510", Offset = "0x1641D10", VA = "0x181643510", Slot = "9")]
	public void EKGHJONBLLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CC80", Offset = "0x5E2B480", VA = "0x185E2CC80", Slot = "10")]
	public void DBFDBHBFBCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public FAMODFMNOEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public class EBMNOMKIALG<T> : HLGNIJGJFCJ<T>, POPLGHHELHE<AFCHODDKGEA, T>, KJDBNGFPDGG<AFCHODDKGEA>, FLFJBBKIFNA, IDisposable, PKPLGAMLPEK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly KJDBNGFPDGG<Entity> EJKGILKDBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private Delegate DBMPCLBGNMK;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string MBENGICGPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3034490", Offset = "0x3032C90", VA = "0x183034490", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Type DAKFPFPAGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x3037B80", Offset = "0x3036380", VA = "0x183037B80", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public EANCAGBLBGP LCCJMBAMPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x303A760", Offset = "0x3038F60", VA = "0x18303A760", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int INDDELLEDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3036DB0", Offset = "0x30355B0", VA = "0x183036DB0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public IEGMKHGMAGH IDOIIBJIBLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x303CAB0", Offset = "0x303B2B0", VA = "0x18303CAB0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event JKCCPPEAHMK<AFCHODDKGEA> JAGPDCDIFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3037430", Offset = "0x3035C30", VA = "0x183037430", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x303AE00", Offset = "0x3039600", VA = "0x18303AE00", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x303D230", Offset = "0x303BA30", VA = "0x18303D230")]
	public EBMNOMKIALG(KJDBNGFPDGG<Entity> EJKGILKDBHL, LDNONJHJNKB CLODAHGGILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3037080", Offset = "0x3035880", VA = "0x183037080")]
	private Entity GEJJKAGDKLH(AFCHODDKGEA NFLGLAGMLAA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3036E50", Offset = "0x3035650", VA = "0x183036E50")]
	private AFCHODDKGEA GEJJKAGDKLH(Entity KCMPKMKBCOO)
	{
		return default(AFCHODDKGEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3035150", Offset = "0x3033950", VA = "0x183035150", Slot = "4")]
	public T FBPOFKNEBFB(AFCHODDKGEA NFLGLAGMLAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x303B9D0", Offset = "0x303A1D0", VA = "0x18303B9D0")]
	public bool NLGFMFNDGBJ(AFCHODDKGEA NFLGLAGMLAA, [In] T OPLCONEPBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3034940", Offset = "0x3033140", VA = "0x183034940", Slot = "7")]
	public bool EIPNNPFGJKC(AFCHODDKGEA NFLGLAGMLAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3035AC0", Offset = "0x30342C0", VA = "0x183035AC0", Slot = "8")]
	public void FBPOFKNEBFB(AFCHODDKGEA NFLGLAGMLAA, EKOOGHMJGEG FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x303C4E0", Offset = "0x303ACE0", VA = "0x18303C4E0", Slot = "9")]
	public bool NLGFMFNDGBJ(AFCHODDKGEA NFLGLAGMLAA, ICHPGDLGCBL OPLCONEPBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x303B0C0", Offset = "0x30398C0", VA = "0x18303B0C0", Slot = "16")]
	public void LMLNHFMBFGI(KKJABINMDJF MCHLFDCLMFC, [Optional] object FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x3031630", Offset = "0x302FE30", VA = "0x183031630", Slot = "10")]
	public bool APFJFNBJOAO(AFCHODDKGEA HMIAICAALJL, AFCHODDKGEA INOEECCONEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x30341A0", Offset = "0x30329A0", VA = "0x1830341A0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x303CE10", Offset = "0x303B610", VA = "0x18303CE10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3038EA0", Offset = "0x30376A0", VA = "0x183038EA0")]
	private void KJMBPEKCEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x303A0C0", Offset = "0x30388C0", VA = "0x18303A0C0")]
	private void KKNJCHMJEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3033D70", Offset = "0x3032570", VA = "0x183033D70")]
	private void CINBNDLHGIF(Entity KCMPKMKBCOO, [In] ICHPGDLGCBL HKBFNIGOHGM, [In] ICHPGDLGCBL OPLCONEPBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x303C7C0", Offset = "0x303AFC0", VA = "0x18303C7C0")]
	private void OBJDHHDBNGN(Entity KCMPKMKBCOO, [In] ICHPGDLGCBL HKBFNIGOHGM, [In] ICHPGDLGCBL OPLCONEPBPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class OONIBNJFANM<T> : GMMDICOBPCK<T>, POPLGHHELHE<INJNNPDEJLM, T>, KJDBNGFPDGG<INJNNPDEJLM>, FLFJBBKIFNA, IDisposable, DNPLMCKHBDK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly KJDBNGFPDGG<Entity> EJKGILKDBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private Delegate DBMPCLBGNMK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string MBENGICGPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3CFDC50", Offset = "0x3CFC450", VA = "0x183CFDC50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Type DAKFPFPAGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3D03970", Offset = "0x3D02170", VA = "0x183D03970", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public EANCAGBLBGP LCCJMBAMPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3D08600", Offset = "0x3D06E00", VA = "0x183D08600", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int INDDELLEDEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3D024E0", Offset = "0x3D00CE0", VA = "0x183D024E0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEGMKHGMAGH IDOIIBJIBLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3D0C0F0", Offset = "0x3D0A8F0", VA = "0x183D0C0F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event JKCCPPEAHMK<INJNNPDEJLM> JAGPDCDIFKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3D03450", Offset = "0x3D01C50", VA = "0x183D03450", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3D09250", Offset = "0x3D07A50", VA = "0x183D09250", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x303D230", Offset = "0x303BA30", VA = "0x18303D230")]
	public OONIBNJFANM(KJDBNGFPDGG<Entity> EJKGILKDBHL, LDNONJHJNKB CLODAHGGILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3D02920", Offset = "0x3D01120", VA = "0x183D02920")]
	private Entity GEJJKAGDKLH(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3D028F0", Offset = "0x3D010F0", VA = "0x183D028F0")]
	private INJNNPDEJLM GEJJKAGDKLH(Entity KCMPKMKBCOO)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3D00420", Offset = "0x3CFEC20", VA = "0x183D00420", Slot = "4")]
	public T FBPOFKNEBFB(INJNNPDEJLM JFIBILKOJPE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3D0BA40", Offset = "0x3D0A240", VA = "0x183D0BA40")]
	public bool NLGFMFNDGBJ(INJNNPDEJLM JFIBILKOJPE, [In] T OPLCONEPBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3CFE830", Offset = "0x3CFD030", VA = "0x183CFE830", Slot = "7")]
	public bool EIPNNPFGJKC(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3035AC0", Offset = "0x30342C0", VA = "0x183035AC0", Slot = "8")]
	public void FBPOFKNEBFB(INJNNPDEJLM JFIBILKOJPE, EKOOGHMJGEG FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3D0AA60", Offset = "0x3D09260", VA = "0x183D0AA60", Slot = "9")]
	public bool NLGFMFNDGBJ(INJNNPDEJLM JFIBILKOJPE, ICHPGDLGCBL OPLCONEPBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x303B0C0", Offset = "0x30398C0", VA = "0x18303B0C0", Slot = "16")]
	public void LMLNHFMBFGI(KKJABINMDJF MCHLFDCLMFC, [Optional] object FJNGJOFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3CF88D0", Offset = "0x3CF70D0", VA = "0x183CF88D0", Slot = "10")]
	public bool APFJFNBJOAO(INJNNPDEJLM HMIAICAALJL, INJNNPDEJLM INOEECCONEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3D05870", Offset = "0x3D04070", VA = "0x183D05870")]
	private void KJMBPEKCEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3D08270", Offset = "0x3D06A70", VA = "0x183D08270")]
	private void KKNJCHMJEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3CFC580", Offset = "0x3CFAD80", VA = "0x183CFC580")]
	private void CINBNDLHGIF(Entity KCMPKMKBCOO, [In] ICHPGDLGCBL HKBFNIGOHGM, [In] ICHPGDLGCBL OPLCONEPBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3D0BE00", Offset = "0x3D0A600", VA = "0x183D0BE00")]
	private void OBJDHHDBNGN(Entity KCMPKMKBCOO, [In] ICHPGDLGCBL HKBFNIGOHGM, [In] ICHPGDLGCBL OPLCONEPBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3018290", Offset = "0x3016A90", VA = "0x183018290", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C950", Offset = "0x3D0B150", VA = "0x183D0C950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class PCCNIJINIHG : KMBBFJPCIKF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OGHGDPGNGLJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int CGAHCFHCMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D0160", Offset = "0x7CE960", VA = "0x1807D0160", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> LKHDDFHFJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FB10", Offset = "0x5E3E310", VA = "0x185E3FB10", Slot = "6")]
	public INJNNPDEJLM BDJGGLGJGPH(INJNNPDEJLM CEMOLHELFPB)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public PCCNIJINIHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class AHNIAPDEIDG : KMBBFJPCIKF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> DKMPMPMIHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int DKPGAAMNHOG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> LKHDDFHFJOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int CGAHCFHCMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x80C100", Offset = "0x80A900", VA = "0x18080C100", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x351E9E0", Offset = "0x351D1E0", VA = "0x18351E9E0")]
	public AHNIAPDEIDG(NativeArray<EntityRemapUtility.EntityRemapInfo> DKMPMPMIHBM, int DKPGAAMNHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F610", Offset = "0x5E1DE10", VA = "0x185E1F610", Slot = "6")]
	public INJNNPDEJLM BDJGGLGJGPH(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F690", Offset = "0x5E1DE90", VA = "0x185E1F690", Slot = "8")]
	public LocalId BDJGGLGJGPH(LocalId KCMPKMKBCOO)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F6D0", Offset = "0x5E1DED0", VA = "0x185E1F6D0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[PHKIPGBLCCH(PJHIMKBCGDP.Application)]
[DEONFKEHMJD(typeof(BHDDONJLECH), new string[] { "Editor" })]
public sealed class BHDDONJLECH
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void OJCJADHBPCB(AFCHODDKGEA IOBHBJFNDII, GEPBLNPDOFJ AELCABDCBDD, bool APANPPEPBOO);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate void DBPHPNCJPFA(AFCHODDKGEA IOBHBJFNDII, bool APANPPEPBOO);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate void EBFMGLGCHJC(AFCHODDKGEA IOBHBJFNDII, OJBFPODPDEH EJKGILKDBHL, [In] ICHPGDLGCBL FKKGMPDEPMA, bool APANPPEPBOO);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public BHDDONJLECH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Flags]
public enum PKOKFDIAPOJ
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Main = 2,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	Load = 4,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	NetworkReceive = 8,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Suppressed = 0x10
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DEONFKEHMJD(typeof(NOBCMIJEINK), new string[] { "Editor" })]
[PHKIPGBLCCH(PJHIMKBCGDP.Application)]
public sealed class NOBCMIJEINK
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void JGIJLFHGHPE(AFCHODDKGEA NFLGLAGMLAA, GEPBLNPDOFJ AELCABDCBDD, PKOKFDIAPOJ ODJEHGDEAEP);

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void HDBKKALBGKB(AFCHODDKGEA NFLGLAGMLAA, PKOKFDIAPOJ ODJEHGDEAEP);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate void IPHLGLICCCP(AFCHODDKGEA NFLGLAGMLAA, OJBFPODPDEH EJKGILKDBHL, ICHPGDLGCBL OEHHBJMJCPL, ICHPGDLGCBL JHENJKJEFON, PKOKFDIAPOJ ODJEHGDEAEP);

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate void IJEALNDNCAO(KABIMFKAPPA OHPCNPKOLBJ, ReadOnlySpan<byte> KAAIDPFBBBH);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NOBCMIJEINK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DEONFKEHMJD(typeof(EJDAAEMCDOG), new string[] { })]
internal class HNJPLIONFPA : EJDAAEMCDOG, GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private enum Flag
	{
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Allowed,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		AllowedInRoomV1,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		RoomUpgrade,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Clone,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Copy,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		Undo,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		UndoCreation,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		Physics,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		SerializationV4,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		HierarchyViewVisible,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		InventionLoading,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		RoomSaving,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		RoomPublishing
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class NOIIENJGLKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public NOIIENJGLKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E4A0", Offset = "0x5E3CCA0", VA = "0x185E3E4A0")]
		internal object FGKNHMIOCIJ((string name, bool value) a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[NMIHDJKFGCM]
	private IPADCDPAMLC AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[NMIHDJKFGCM]
	private DEDLLFMJKEO PLMDMDMKAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private NativeBitArray OOMIGIEFHJN;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public GJGCDJJDGFB HJCPEOIBEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E32870", Offset = "0x5E31070", VA = "0x185E32870", Slot = "4")]
		get
		{
			return default(GJGCDJJDGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public GJGCDJJDGFB HBJAPHFBKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E32270", Offset = "0x5E30A70", VA = "0x185E32270", Slot = "5")]
		get
		{
			return default(GJGCDJJDGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public GJGCDJJDGFB CIDLCGIGDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E326D0", Offset = "0x5E30ED0", VA = "0x185E326D0", Slot = "6")]
		get
		{
			return default(GJGCDJJDGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public GJGCDJJDGFB APFJFNBJOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E32340", Offset = "0x5E30B40", VA = "0x185E32340", Slot = "7")]
		get
		{
			return default(GJGCDJJDGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GJGCDJJDGFB IPKGAKMBBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E328A0", Offset = "0x5E310A0", VA = "0x185E328A0", Slot = "8")]
		get
		{
			return default(GJGCDJJDGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public GJGCDJJDGFB EPIBOBJLPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E32890", Offset = "0x5E31090", VA = "0x185E32890", Slot = "9")]
		get
		{
			return default(GJGCDJJDGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public GJGCDJJDGFB DEKGIMCALGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E32840", Offset = "0x5E31040", VA = "0x185E32840", Slot = "10")]
		get
		{
			return default(GJGCDJJDGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public GJGCDJJDGFB CPHPLEPDCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5E325C0", Offset = "0x5E30DC0", VA = "0x185E325C0", Slot = "11")]
		get
		{
			return default(GJGCDJJDGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public GJGCDJJDGFB KGLKBPENEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5E32360", Offset = "0x5E30B60", VA = "0x185E32360", Slot = "12")]
		get
		{
			return default(GJGCDJJDGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public GJGCDJJDGFB ODIOIPABJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5E32260", Offset = "0x5E30A60", VA = "0x185E32260", Slot = "13")]
		get
		{
			return default(GJGCDJJDGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GJGCDJJDGFB KLAAJPFBCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5E32350", Offset = "0x5E30B50", VA = "0x185E32350", Slot = "14")]
		get
		{
			return default(GJGCDJJDGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public GJGCDJJDGFB EKPAJBMMHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5E325D0", Offset = "0x5E30DD0", VA = "0x185E325D0", Slot = "15")]
		get
		{
			return default(GJGCDJJDGFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private int CAHAIFOEPLI
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5E32630", Offset = "0x5E30E30", VA = "0x185E32630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E326E0", Offset = "0x5E30EE0", VA = "0x185E326E0", Slot = "16")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E32290", Offset = "0x5E30A90", VA = "0x185E32290", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5E325E0", Offset = "0x5E30DE0", VA = "0x185E325E0")]
	private void HAACBKIKJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5E32370", Offset = "0x5E30B70", VA = "0x185E32370")]
	private void FMIFHEHIJBM(Flag HBIOBOOAGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5E328B0", Offset = "0x5E310B0", VA = "0x185E328B0")]
	private GJGCDJJDGFB PAODEHGHJJA(Flag HBIOBOOAGLC)
	{
		return default(GJGCDJJDGFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5E32850", Offset = "0x5E31050", VA = "0x185E32850")]
	private GJGCDJJDGFB NALGKBKLJNO(Flag HBIOBOOAGLC)
	{
		return default(GJGCDJJDGFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HNJPLIONFPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[DEONFKEHMJD(typeof(ODFFABDNAGO), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.Application)]
internal class ODFFABDNAGO : GMMHILFNMPG
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F920", Offset = "0x5E3E120", VA = "0x185E3F920", Slot = "4")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public ODFFABDNAGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DEONFKEHMJD(typeof(MBFFLFDFIHE), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal class MBFFLFDFIHE : GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly DGJIKJLGCCH BLGHHLFIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[NMIHDJKFGCM]
	private HKIHKIGHNML AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[NMIHDJKFGCM]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[NMIHDJKFGCM]
	private LJJGONKGMDG DFJLJGOOCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private FJGKMPJNNPH IKCAIPFFHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private EntityQuery BIIBLHGGHOK;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A4C0", Offset = "0x5E38CC0", VA = "0x185E3A4C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B030", Offset = "0x5E39830", VA = "0x185E3B030", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A5D0", Offset = "0x5E38DD0", VA = "0x185E3A5D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AB40", Offset = "0x5E39340", VA = "0x185E3AB40")]
	public HAFKINAIAFI GLJLHLCKMJG(IEnumerable<KFOICHFNJOO> AEIDMONFLFF)
	{
		return default(HAFKINAIAFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AC40", Offset = "0x5E39440", VA = "0x185E3AC40")]
	public static bool GOBCBGLBPHD(KFOICHFNJOO LJEEHJLDFLC, [Out] AFCHODDKGEA NFLGLAGMLAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B290", Offset = "0x5E39A90", VA = "0x185E3B290")]
	private HAFKINAIAFI JEEFPOEKHJA(IEnumerable<KFOICHFNJOO> AEIDMONFLFF)
	{
		return default(HAFKINAIAFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E39770", Offset = "0x5E37F70", VA = "0x185E39770")]
	private (List<KFOICHFNJOO>, int[], int) APAMKJGJMEO(IEnumerable<KFOICHFNJOO> AEIDMONFLFF)
	{
		return default((List<KFOICHFNJOO>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BF40", Offset = "0x5E3A740", VA = "0x185E3BF40")]
	private Dictionary<AFCHODDKGEA, (KFOICHFNJOO, int)> OBHEKOMHLDK(IEnumerable<KFOICHFNJOO> AEIDMONFLFF, Entity FCEJPDAPBPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5E39970", Offset = "0x5E38170", VA = "0x185E39970")]
	private void BJPIHOHIJEB(Dictionary<AFCHODDKGEA, (KFOICHFNJOO request, int srcIndex)> MEMKKNNDEPK, IEnumerable<KFOICHFNJOO> AEIDMONFLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A6B0", Offset = "0x5E38EB0", VA = "0x185E3A6B0")]
	private void EEFOCJJCFDF(Dictionary<AFCHODDKGEA, (KFOICHFNJOO request, int srcIndex)> MEMKKNNDEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BA70", Offset = "0x5E3A270", VA = "0x185E3BA70")]
	private void NPMLCKCAMGD(Dictionary<AFCHODDKGEA, (KFOICHFNJOO request, int srcIndex)> MEMKKNNDEPK, AFCHODDKGEA NFLGLAGMLAA, string HNHMJGCODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A0D0", Offset = "0x5E388D0", VA = "0x185E3A0D0")]
	private void CGFACHJOAED(Dictionary<AFCHODDKGEA, (KFOICHFNJOO request, int srcIndex)> MEMKKNNDEPK, Entity FCEJPDAPBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C000", Offset = "0x5E3A800", VA = "0x185E3C000")]
	private (List<KFOICHFNJOO>, int[], int) OHBNLMNFLCJ(Dictionary<AFCHODDKGEA, (KFOICHFNJOO request, int srcIndex)> MEMKKNNDEPK, Entity FCEJPDAPBPO)
	{
		return default((List<KFOICHFNJOO>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AD40", Offset = "0x5E39540", VA = "0x185E3AD40")]
	private void IHDGHDOGJML(Dictionary<AFCHODDKGEA, (KFOICHFNJOO request, int srcIndex)> MEMKKNNDEPK, List<KFOICHFNJOO> OGADMNFDEOG, int[] DCJJFDEELPE, NativeArray<Entity> FAIFKAKJOPP, NativeList<AFCHODDKGEA> LILIIJHBMME, NativeList<Entity> ADICBNCGKJD, Entity FCEJPDAPBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A5E0", Offset = "0x5E38DE0", VA = "0x185E3A5E0")]
	private static bool ECGIAICEFOB(Entity KCMPKMKBCOO, ComponentDataFromEntity<ParentData> PCDIAJOKOAF, Entity FCEJPDAPBPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5E39D60", Offset = "0x5E38560", VA = "0x185E39D60")]
	private void BLJNDIJHGAN(Dictionary<AFCHODDKGEA, (KFOICHFNJOO request, int srcIndex)> MEMKKNNDEPK, List<KFOICHFNJOO> OGADMNFDEOG, int[] DCJJFDEELPE, NativeList<Entity> ADICBNCGKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A920", Offset = "0x5E39120", VA = "0x185E3A920")]
	private NativeList<AFCHODDKGEA> GCCOHIDFOBD(Dictionary<AFCHODDKGEA, (KFOICHFNJOO request, int srcIndex)> MEMKKNNDEPK)
	{
		return default(NativeList<AFCHODDKGEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B8A0", Offset = "0x5E3A0A0", VA = "0x185E3B8A0")]
	private NativeArray<Entity> MFCJBCKPILC(NativeList<AFCHODDKGEA> LILIIJHBMME)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B780", Offset = "0x5E39F80", VA = "0x185E3B780")]
	private static void LEKCKAMLJKJ(Dictionary<AFCHODDKGEA, (KFOICHFNJOO request, int srcIndex)> MEMKKNNDEPK, AFCHODDKGEA NFLGLAGMLAA, KFOICHFNJOO LJEEHJLDFLC, string HNHMJGCODBA, int MGLPBFNGHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A510", Offset = "0x5E38D10", VA = "0x185E3A510")]
	private void DNDLBJENGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MBFFLFDFIHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[PHKIPGBLCCH(PJHIMKBCGDP.Application)]
[DEONFKEHMJD(typeof(JINDNJAHDBB), new string[] { })]
internal class JINDNJAHDBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	public void HMNAIHCEMFJ(string HNHMJGCODBA, EntityManager IDCNBIGHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JINDNJAHDBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[CIJINFPJIAB(typeof(FNIJCGNLDDI))]
[DEONFKEHMJD(typeof(FJGKMPJNNPH), new string[] { })]
internal class FNIJCGNLDDI : FJGKMPJNNPH, IDisposable, GJOKPFDLDCJ, DMOCALIGOJA
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly DGJIKJLGCCH LODPDBADFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[NMIHDJKFGCM]
	private JKEGAAHHGLK AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[NMIHDJKFGCM]
	private CMHDFMPGDKC INJJFABGALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[NMIHDJKFGCM]
	private LNJCPDCPJDF CGFCBDPFKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private EHNBALNPIJE OHCKDBMMLJD;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool IGCMHEALJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7B7C00", Offset = "0x7B6400", VA = "0x1807B7C00", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8160", Offset = "0x7B6960", VA = "0x1807B8160", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool KAJLDHMICAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x10BAE60", Offset = "0x10B9660", VA = "0x1810BAE60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LBAKKIAHLFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x80C110", Offset = "0x80A910", VA = "0x18080C110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x80C120", Offset = "0x80A920", VA = "0x18080C120", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public FPGIHDDJKFI LMMFNPBCAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x76E4B0", Offset = "0x76CCB0", VA = "0x18076E4B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E960", Offset = "0x5E2D160", VA = "0x185E2E960", Slot = "15")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E2F0", Offset = "0x5E2CAF0", VA = "0x185E2E2F0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F060", Offset = "0x5E2D860", VA = "0x185E2F060", Slot = "8")]
	public MGOIFNPCOHN PLLMJNHMGLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EEB0", Offset = "0x5E2D6B0", VA = "0x185E2EEB0")]
	public MGOIFNPCOHN MOCFJGGLIOF(IEnumerable<INJNNPDEJLM> CEMOLHELFPB, [In] DDNODGNMOKA AMGKMBAIPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5E2ECF0", Offset = "0x5E2D4F0", VA = "0x185E2ECF0", Slot = "10")]
	public CKLPPCFCCOB LOFOADIOJKF(ByteString KDMODAMJKPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E350", Offset = "0x5E2CB50", VA = "0x185E2E350")]
	public MOKNKNAAMMF FBKCABOGMGL(ByteString KDMODAMJKPD, INJNNPDEJLM OBIIIBPBMLD, [In] DDNODGNMOKA DDEEHHNBOKM, NFPDFHOMGOB DIAADMDGPBA, bool PDNJGMCGCMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EA10", Offset = "0x5E2D210", VA = "0x185E2EA10", Slot = "12")]
	public void JGBINKFHIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E6C0", Offset = "0x5E2CEC0", VA = "0x185E2E6C0", Slot = "13")]
	public HAFKINAIAFI GLJLHLCKMJG(IEnumerable<KFOICHFNJOO> EKIKDOJOMMA)
	{
		return default(HAFKINAIAFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EBF0", Offset = "0x5E2D3F0", VA = "0x185E2EBF0")]
	public static bool KKHGIICBGDH(ByteString KDMODAMJKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E2F0", Offset = "0x5E2CAF0", VA = "0x185E2E2F0")]
	private void DMLLHHDOOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F040", Offset = "0x5E2D840", VA = "0x185E2F040")]
	private void NCABMBPDMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E890", Offset = "0x5E2D090", VA = "0x185E2E890")]
	private void ICCHDGIMFIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E240", Offset = "0x5E2CA40", VA = "0x185E2E240", Slot = "16")]
	public void CNKMLPJMACA(HMNFMHNMJBH KNILJBDIHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public FNIJCGNLDDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E0B0", Offset = "0x5E2C8B0", VA = "0x185E2E0B0", Slot = "9")]
	private MGOIFNPCOHN CJGNKCDCCLN(IEnumerable<INJNNPDEJLM> CEMOLHELFPB, [In] DDNODGNMOKA AMGKMBAIPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E500", Offset = "0x5E2CD00", VA = "0x185E2E500", Slot = "11")]
	private MOKNKNAAMMF FNNONHGCONH(ByteString KDMODAMJKPD, INJNNPDEJLM OBIIIBPBMLD, [In] DDNODGNMOKA DDEEHHNBOKM, NFPDFHOMGOB DIAADMDGPBA, bool PDNJGMCGCMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[CIJINFPJIAB(typeof(LNJCPDCPJDF))]
[DEONFKEHMJD(typeof(NAHFHNGCNNC), new string[] { })]
internal class LNJCPDCPJDF : NAHFHNGCNNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[CompilerGenerated]
	private Action<KMBBFJPCIKF> NLGJHLGJDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[CompilerGenerated]
	private Action MDIGNFPODCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[CompilerGenerated]
	private Action<KMBBFJPCIKF> LCNIPAMDBCB;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action DBFDBHBFBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5E39590", Offset = "0x5E37D90", VA = "0x185E39590", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5E394F0", Offset = "0x5E37CF0", VA = "0x185E394F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action PDPKFEHHIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5E39630", Offset = "0x5E37E30", VA = "0x185E39630", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5E39450", Offset = "0x5E37C50", VA = "0x185E39450", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xACECC0", Offset = "0xACD4C0", VA = "0x180ACECC0")]
	public void JGBINKFHIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xACED80", Offset = "0xACD580", VA = "0x180ACED80")]
	public void BOEDONPIACO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0xADD6B0", Offset = "0xADBEB0", VA = "0x180ADD6B0")]
	public void KLNMKJDGOIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x11D15C0", Offset = "0x11CFDC0", VA = "0x1811D15C0")]
	public void LNEHKCGPNKB(KMBBFJPCIKF MHHPBFKFIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x1740B10", Offset = "0x173F310", VA = "0x181740B10")]
	public void NPJPCNHIHAH(KMBBFJPCIKF MHHPBFKFIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public LNJCPDCPJDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal interface FGPPMMNJDIL
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HONNBDMACGI(global::AOGDCIFPGBN LDGJLLAHGBA);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[CIJINFPJIAB(typeof(FGPPMMNJDIL))]
[DEONFKEHMJD(typeof(KMLALHOKNKB), new string[] { })]
public class AGGBMJHBPDE : KMLALHOKNKB, LKDNHKMMDCB, GMMHILFNMPG, GJOKPFDLDCJ, FIBMJMMLGPO, IDisposable, FGPPMMNJDIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private ILCKJNFILLB LPHEEOLMCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private HBAFNDJCPFO MAOPFAAEFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NHCACALFIKB IBKDOLMCEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private global::AOGDCIFPGBN OHAFKJOPEGI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private GMMDICOBPCK<INJNNPDEJLM> MLDLDJMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x768E00", Offset = "0x767600", VA = "0x180768E00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E0C0", Offset = "0x5E1C8C0", VA = "0x185E1E0C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<BKPDEAFDJBG> GJEBJKHGOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E6D0", Offset = "0x5E1CED0", VA = "0x185E1E6D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E1D0", Offset = "0x5E1C9D0", VA = "0x185E1E1D0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1599060", Offset = "0x1597860", VA = "0x181599060", Slot = "17")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E370", Offset = "0x5E1CB70", VA = "0x185E1E370", Slot = "18")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DD00", Offset = "0x5E1C500", VA = "0x185E1DD00", Slot = "19")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x766310", Offset = "0x764B10", VA = "0x180766310", Slot = "21")]
	private void OJIIPCEKPNJ(global::AOGDCIFPGBN LDGJLLAHGBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1598FB0", Offset = "0x15977B0", VA = "0x181598FB0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E080", Offset = "0x5E1C880", VA = "0x185E1E080")]
	private INJNNPDEJLM BOGNAEDNDDO(Entity KCMPKMKBCOO)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E540", Offset = "0x5E1CD40", VA = "0x185E1E540", Slot = "6")]
	public INJNNPDEJLM KHJHAPEDKKI(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DDF0", Offset = "0x5E1C5F0", VA = "0x185E1DDF0", Slot = "7")]
	public void AKNMPALEJNB(List<INJNNPDEJLM> JABEPOLDBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DC40", Offset = "0x5E1C440", VA = "0x185E1DC40", Slot = "11")]
	public int AEDBNOCDBMA(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E5C0", Offset = "0x5E1CDC0", VA = "0x185E1E5C0", Slot = "12")]
	public AJLMOHPDADI NHHBBHFGFIB(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(AJLMOHPDADI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E110", Offset = "0x5E1C910", VA = "0x185E1E110", Slot = "15")]
	public INJNNPDEJLM FEOPONCANLO(INJNNPDEJLM KMJKCJJHEFM, INJNNPDEJLM OPJAPJDAKJE)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E2B0", Offset = "0x5E1CAB0", VA = "0x185E1E2B0", Slot = "16")]
	public bool GFDLEAEGIJN(INJNNPDEJLM KMJKCJJHEFM, INJNNPDEJLM OPJAPJDAKJE, [Out] INJNNPDEJLM BNKDAHKOHOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E230", Offset = "0x5E1CA30", VA = "0x185E1E230", Slot = "8")]
	public INJNNPDEJLM GADDKJOEJFO(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E440", Offset = "0x5E1CC40", VA = "0x185E1E440", Slot = "14")]
	public bool JDBAHLMABOE(INJNNPDEJLM JFIBILKOJPE, INJNNPDEJLM KNHMPHIEBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E010", Offset = "0x5E1C810", VA = "0x185E1E010", Slot = "13")]
	public bool BGGKKFIEAIB(INJNNPDEJLM JFIBILKOJPE, INJNNPDEJLM BIANJFLNPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E4B0", Offset = "0x5E1CCB0", VA = "0x185E1E4B0", Slot = "9")]
	public bool JLJFDADNEME(INJNNPDEJLM JFIBILKOJPE, INJNNPDEJLM OBIIIBPBMLD, bool BNNILCCPPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E730", Offset = "0x5E1CF30", VA = "0x185E1E730", Slot = "10")]
	public bool PIFIIBOFGBO(INJNNPDEJLM JFIBILKOJPE, INJNNPDEJLM OBIIIBPBMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public AGGBMJHBPDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(NGPBKFGDAEA), new string[] { })]
internal class NGPBKFGDAEA : GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[NMIHDJKFGCM]
	private FMKLLJOIEFE CBHFJDMCLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<int, AGPODNPCKBE> NALLGLCNKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DF70", Offset = "0x5E3C770", VA = "0x185E3DF70", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DCE0", Offset = "0x5E3C4E0", VA = "0x185E3DCE0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D9B0", Offset = "0x5E3C1B0", VA = "0x185E3D9B0")]
	public AGPODNPCKBE BHIFHLOEACF(IPJNDHGBNHD IACPFKBCIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DAB0", Offset = "0x5E3C2B0", VA = "0x185E3DAB0")]
	public AGPODNPCKBE BHIFHLOEACF(OJBFPODPDEH OJNPMCODCBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D800", Offset = "0x5E3C000", VA = "0x185E3D800")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DFC0", Offset = "0x5E3C7C0", VA = "0x185E3DFC0")]
	public NGPBKFGDAEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class AGPODNPCKBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<MPMDFMLEFEP> HDOKKNGGPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private NativeList<LDDDAGKCJBG> ELGJKIJKKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private NativeList<HLDGGCFJEBG> OBBIAFFOGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private NativeList<LDDDAGKCJBG> BIPLLCIGHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<MPMDFMLEFEP> NLMFCECDLOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40")]
		get
		{
			return default(NativeList<MPMDFMLEFEP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<LDDDAGKCJBG> FGHKLKLFIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD474A0", VA = "0x180D48CA0")]
		get
		{
			return default(NativeList<LDDDAGKCJBG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public NativeList<HLDGGCFJEBG> JBGNNELGIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5DC60", VA = "0x180D5F460")]
		get
		{
			return default(NativeList<HLDGGCFJEBG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public NativeList<LDDDAGKCJBG> BPDCACHHOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A60", Offset = "0x8A7260", VA = "0x1808A8A60")]
		get
		{
			return default(NativeList<LDDDAGKCJBG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public JobHandle AOEHGPJOELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x955E50", Offset = "0x954650", VA = "0x180955E50")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xFED1E0", Offset = "0xFEB9E0", VA = "0x180FED1E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool NNHNDIBHIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F460", Offset = "0x5E1DC60", VA = "0x185E1F460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F500", Offset = "0x5E1DD00", VA = "0x185E1F500")]
	public AGPODNPCKBE(Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EF60", Offset = "0x5E1D760", VA = "0x185E1EF60")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F330", Offset = "0x5E1DB30", VA = "0x185E1F330")]
	public void FILLLFKPAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EFF0", Offset = "0x5E1D7F0", VA = "0x185E1EFF0")]
	public void BONJGFNEKBE(Entity KCMPKMKBCOO, Entity LGPCNJNBLBP, Entity KEDAAEKKLOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(GNBAFKLCGNN), new string[] { })]
public class GNBAFKLCGNN : GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[NMIHDJKFGCM]
	private NGKJMLHKKJA BFGNFEGPODM;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5E30BC0", Offset = "0x5E2F3C0", VA = "0x185E30BC0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5E30BA0", Offset = "0x5E2F3A0", VA = "0x185E30BA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public GNBAFKLCGNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[PHKIPGBLCCH(PJHIMKBCGDP.PhotonRoom)]
[DEONFKEHMJD(typeof(FAONCNBNGHJ), new string[] { })]
public class FAONCNBNGHJ : LKDNHKMMDCB, GMMHILFNMPG, GJOKPFDLDCJ, FIBMJMMLGPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private GDGADODNMPD AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private CMHDFMPGDKC JHLMKFBAKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private NativeList<int> CKCDOLHBBFN;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D6A0", Offset = "0x5E2BEA0", VA = "0x185E2D6A0", Slot = "4")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D700", Offset = "0x5E2BF00", VA = "0x185E2D700", Slot = "5")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D340", Offset = "0x5E2BB40", VA = "0x185E2D340", Slot = "6")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D5E0", Offset = "0x5E2BDE0", VA = "0x185E2D5E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D3F0", Offset = "0x5E2BBF0", VA = "0x185E2D3F0")]
	public void CNGNBOLOIDG(NativeParallelHashSet<int> PJCDDNOEGIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D770", Offset = "0x5E2BF70", VA = "0x185E2D770")]
	public void OHOGGLIEECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public FAONCNBNGHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal abstract class PNCEKCLJJGN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private uint PAHANGPDKPH;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public abstract uint LABMAOGKJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3AD0600", Offset = "0x3ACEE00", VA = "0x183AD0600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FDA0", Offset = "0x5E3E5A0", VA = "0x185E3FDA0")]
	public AFCHODDKGEA AMLFEIIEMJP()
	{
		return default(AFCHODDKGEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FF90", Offset = "0x5E3E790", VA = "0x185E3FF90")]
	public void PBMIOKCLDIH(NativeArray<AFCHODDKGEA> LILIIJHBMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FE90", Offset = "0x5E3E690", VA = "0x185E3FE90")]
	public void PBMIOKCLDIH(AFCHODDKGEA NFLGLAGMLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xA86B20", Offset = "0xA85320", VA = "0x180A86B20", Slot = "6")]
	public virtual void FCKDKLKEHNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FDF0", Offset = "0x5E3E5F0", VA = "0x185E3FDF0")]
	private unsafe void LPEFBLGFDMM(AFCHODDKGEA* NEBNNPOPPNJ, int EHGKBCBKPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FEB0", Offset = "0x5E3E6B0", VA = "0x185E3FEB0")]
	private unsafe void PBMIOKCLDIH(AFCHODDKGEA* NEBNNPOPPNJ, int EHGKBCBKPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected PNCEKCLJJGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[DEONFKEHMJD(typeof(GPLNKFNBPCC), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal sealed class GPLNKFNBPCC : PNCEKCLJJGN, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[NMIHDJKFGCM]
	private NCJBBOLFFDA AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private uint DMAJKGMCJKP;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override uint LABMAOGKJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x80C100", Offset = "0x80A900", VA = "0x18080C100", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5E30CC0", Offset = "0x5E2F4C0", VA = "0x185E30CC0", Slot = "7")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5E30C10", Offset = "0x5E2F410", VA = "0x185E30C10")]
	private void EIIBMIPOHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5E30C60", Offset = "0x5E2F460", VA = "0x185E30C60", Slot = "6")]
	public override void FCKDKLKEHNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public GPLNKFNBPCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(KCBONGHGBLL), new string[] { })]
internal sealed class KCBONGHGBLL : PNCEKCLJJGN
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public override uint LABMAOGKJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public KCBONGHGBLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[DEONFKEHMJD(typeof(FBAOJJNEOIC), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal sealed class FBAOJJNEOIC : LKDNHKMMDCB, GMMHILFNMPG, GJOKPFDLDCJ, FIBMJMMLGPO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery PCJJBKOMBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery PBJPOCOMOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery BMKKOFAFBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery ADEHIIDBEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery AMLNAHFDKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private EntityQuery IMFKGGKDACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private EntityQuery JLNODKPHBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5E2DE50", Offset = "0x5E2C650", VA = "0x185E2DE50")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery CEDAOOAFCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x955E70", Offset = "0x954670", VA = "0x180955E70")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "4")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E050", Offset = "0x5E2C850", VA = "0x185E2E050", Slot = "5")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D840", Offset = "0x5E2C040", VA = "0x185E2D840", Slot = "6")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DF10", Offset = "0x5E2C710", VA = "0x185E2DF10")]
	private EntityQueryDesc HMLDKEDPJNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DEA0", Offset = "0x5E2C6A0", VA = "0x185E2DEA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DF80", Offset = "0x5E2C780", VA = "0x185E2DF80")]
	public ELNNHIPONMC IHGKOMFMEME(INJNNPDEJLM LHIGGCOIHEC)
	{
		return default(ELNNHIPONMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DDA0", Offset = "0x5E2C5A0", VA = "0x185E2DDA0")]
	public ILMCDCGEOPC BEFHDKOJCLP(Entity KCMPKMKBCOO)
	{
		return default(ILMCDCGEOPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E0A0", Offset = "0x5E2C8A0", VA = "0x185E2E0A0")]
	public FBAOJJNEOIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[DEONFKEHMJD(typeof(LDNONJHJNKB), new string[] { })]
public class AODDPBICMOD : GJOKPFDLDCJ, LDNONJHJNKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly DGJIKJLGCCH HNGMGOKELBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[NMIHDJKFGCM]
	private LAIAFMADGKP FOCFONOKHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[NMIHDJKFGCM]
	private JEIJFNDLCFE KOJOEBGFGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[NMIHDJKFGCM]
	private NHCACALFIKB PEENKKOKGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[NMIHDJKFGCM]
	private IBNBDHFMKLE CLEKEDNIBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[NMIHDJKFGCM]
	private FBAOJJNEOIC CJGPOMHFPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private MPONBMGLGEH DMEBAJIIFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private OGDIMNHIMAP NAAMDKNABOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public LAIAFMADGKP BKFHKDJCBDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public JKJLANOOPAE PJMEDLCAIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x76F4F0", Offset = "0x76DCF0", VA = "0x18076F4F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(JKJLANOOPAE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x76F5C0", Offset = "0x76DDC0", VA = "0x18076F5C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<AJLMOHPDADI, NativeArray<ILMCDCGEOPC>> POCBNGMDCDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E20730", Offset = "0x5E1EF30", VA = "0x185E20730", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FE80", Offset = "0x5E1E680", VA = "0x185E1FE80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<AJLMOHPDADI> LLJAPKCIHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FF30", Offset = "0x5E1E730", VA = "0x185E1FF30", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E20360", Offset = "0x5E1EB60", VA = "0x185E20360", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E200C0", Offset = "0x5E1E8C0", VA = "0x185E200C0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FB80", Offset = "0x5E1E380", VA = "0x185E1FB80", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F920", Offset = "0x5E1E120", VA = "0x185E1F920")]
	private void BDCNHNEMOLI(AJLMOHPDADI HMNPDHIGFFO, NativeArray<ILMCDCGEOPC> AMHNNCEJBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F850", Offset = "0x5E1E050", VA = "0x185E1F850")]
	private void AGOBFJKIKIM(AJLMOHPDADI HMNPDHIGFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F9B0", Offset = "0x5E1E1B0", VA = "0x185E1F9B0")]
	internal INJNNPDEJLM BOGNAEDNDDO(Entity KCMPKMKBCOO)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FFE0", Offset = "0x5E1E7E0", VA = "0x185E1FFE0", Slot = "11")]
	public ELNNHIPONMC IHGKOMFMEME(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(ELNNHIPONMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F970", Offset = "0x5E1E170", VA = "0x185E1F970", Slot = "12")]
	public ILMCDCGEOPC BEFHDKOJCLP(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(ILMCDCGEOPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FD40", Offset = "0x5E1E540", VA = "0x185E1FD40", Slot = "39")]
	public bool EIPNNPFGJKC(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E20910", Offset = "0x5E1F110", VA = "0x185E20910", Slot = "34")]
	public void NLHDBDGIHOC(AJLMOHPDADI CEMOLHELFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E207E0", Offset = "0x5E1EFE0", VA = "0x185E207E0", Slot = "35")]
	public void NAKDAJJPGKJ(INJNNPDEJLM JFIBILKOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E20840", Offset = "0x5E1F040", VA = "0x185E20840", Slot = "36")]
	public void NDDAMNIGMMB(INJNNPDEJLM JFIBILKOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E208C0", Offset = "0x5E1F0C0", VA = "0x185E208C0", Slot = "37")]
	public void NLHDBDGIHOC(INJNNPDEJLM JFIBILKOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E20AB0", Offset = "0x5E1F2B0", VA = "0x185E20AB0", Slot = "24")]
	public AJLMOHPDADI OGCAMABILPC(NativeArray<AFCHODDKGEA> NFLGLAGMLAA, Allocator JONICLHJBEP)
	{
		return default(AJLMOHPDADI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E20610", Offset = "0x5E1EE10", VA = "0x185E20610", Slot = "25")]
	public AJLMOHPDADI LNPEJOMFMHK(NativeArray<AFCHODDKGEA> NFLGLAGMLAA, NativeArray<GEPBLNPDOFJ> EIGLBIKONIC, Allocator JONICLHJBEP)
	{
		return default(AJLMOHPDADI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E20B30", Offset = "0x5E1F330", VA = "0x185E20B30", Slot = "26")]
	public NNONLMNKHJH OLLHDCOJNKM(ILMCDCGEOPC CCAOKKILBOM, bool GLOKJGOMGAG)
	{
		return default(NNONLMNKHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E20B90", Offset = "0x5E1F390", VA = "0x185E20B90", Slot = "27")]
	public NNONLMNKHJH OLLHDCOJNKM(ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(NNONLMNKHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FDE0", Offset = "0x5E1E5E0", VA = "0x185E1FDE0", Slot = "28")]
	public NNONLMNKHJH FMJGLACGPOC(ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(NNONLMNKHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FA90", Offset = "0x5E1E290", VA = "0x185E1FA90", Slot = "29")]
	public NNONLMNKHJH DPJFLLODJIG(ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(NNONLMNKHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E20540", Offset = "0x5E1ED40", VA = "0x185E20540", Slot = "30")]
	public NNONLMNKHJH LNPEJOMFMHK(AFCHODDKGEA NFLGLAGMLAA, ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(NNONLMNKHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FC80", Offset = "0x5E1E480", VA = "0x185E1FC80", Slot = "31")]
	public JAMOBKGFMDK EFLFDBPICDF()
	{
		return default(JAMOBKGFMDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F890", Offset = "0x5E1E090", VA = "0x185E1F890", Slot = "32")]
	public BKFLOKEAPNO ALFPNKJNGII()
	{
		return default(BKFLOKEAPNO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E20A20", Offset = "0x5E1F220", VA = "0x185E20A20", Slot = "33")]
	public HIKCFPNDNOL NOEPOHDBCGF(IHOKJCEFOEN GFGNPBCFEMC)
	{
		return default(HIKCFPNDNOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E208A0", Offset = "0x5E1F0A0", VA = "0x185E208A0", Slot = "13")]
	public void NJMEIPIEAKJ(AFCHODDKGEA NFLGLAGMLAA, JNHCKHFIJLH JJEHEFGHFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E20C30", Offset = "0x5E1F430", VA = "0x185E20C30", Slot = "14")]
	public NNONLMNKHJH PNHALGKEDCE(INJNNPDEJLM JFIBILKOJPE, [Optional] object KIAKEGJPMAL)
	{
		return default(NNONLMNKHJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FA40", Offset = "0x5E1E240", VA = "0x185E1FA40", Slot = "15")]
	public bool CPKMHGLBLBP(INJNNPDEJLM JFIBILKOJPE, [Out] JNHCKHFIJLH KMHAEDONIKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F9F0", Offset = "0x5E1E1F0", VA = "0x185E1F9F0", Slot = "16")]
	public bool CHKJBCJNDCM(INJNNPDEJLM JFIBILKOJPE, [Out] Transform CPMBJLDHCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E20470", Offset = "0x5E1EC70", VA = "0x185E20470", Slot = "17")]
	public bool KLCLHJJFDOB(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E20500", Offset = "0x5E1ED00", VA = "0x185E20500", Slot = "18")]
	public void LDCDEDNFNOI(INJNNPDEJLM JFIBILKOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FCF0", Offset = "0x5E1E4F0", VA = "0x185E1FCF0", Slot = "19")]
	public bool EHIOPBFDOLH(LocalId JFIBILKOJPE, object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E204B0", Offset = "0x5E1ECB0", VA = "0x185E204B0", Slot = "20")]
	public bool KPJHIEIKBJM(LocalId JFIBILKOJPE, object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E20410", Offset = "0x5E1EC10", VA = "0x185E20410", Slot = "38")]
	public AJLMOHPDADI KGFLJBHMKJF(AJLMOHPDADI BIONNJIHGCI, Allocator JONICLHJBEP)
	{
		return default(AJLMOHPDADI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FE40", Offset = "0x5E1E640", VA = "0x185E1FE40", Slot = "23")]
	public AFCHODDKGEA GJHNEMLALPJ(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(AFCHODDKGEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E20B10", Offset = "0x5E1F310", VA = "0x185E20B10", Slot = "21")]
	public INJNNPDEJLM OGCAMABILPC(AFCHODDKGEA NFLGLAGMLAA)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FE60", Offset = "0x5E1E660", VA = "0x185E1FE60", Slot = "22")]
	public bool GPAFOHEEBAA(AFCHODDKGEA NFLGLAGMLAA, [Out] INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E20BF0", Offset = "0x5E1F3F0", VA = "0x185E20BF0")]
	private void PLMJBGBOKEM(ILMCDCGEOPC LHEMNDHOIFD, INJNNPDEJLM JFIBILKOJPE, AFCHODDKGEA NFLGLAGMLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E20D30", Offset = "0x5E1F530", VA = "0x185E20D30")]
	public AODDPBICMOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[DEONFKEHMJD(typeof(INBFCFKGDFF), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal sealed class INBFCFKGDFF : GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private IBNBDHFMKLE CLEKEDNIBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[NMIHDJKFGCM]
	private FBAOJJNEOIC CJGPOMHFPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[NMIHDJKFGCM]
	private CBDHEEDCCOH PDMHOECPGJH;

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E33650", Offset = "0x5E31E50", VA = "0x185E33650", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E33700", Offset = "0x5E31F00", VA = "0x185E33700")]
	public AJLMOHPDADI KGFLJBHMKJF(AJLMOHPDADI BIONNJIHGCI, Allocator JONICLHJBEP)
	{
		return default(AJLMOHPDADI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E33E40", Offset = "0x5E32640", VA = "0x185E33E40")]
	private void NIJJCAAMLIA(NativeParallelMultiHashMap<int, (INJNNPDEJLM src, INJNNPDEJLM dst)> DBBOKAICNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E33850", Offset = "0x5E32050", VA = "0x185E33850")]
	private void LDDCMCAGPDE(NativeParallelMultiHashMap<int, (INJNNPDEJLM src, INJNNPDEJLM dst)> DBBOKAICNKD, int CCAOKKILBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E33CD0", Offset = "0x5E324D0", VA = "0x185E33CD0")]
	private void NIHDCOMOKLG(NativeParallelMultiHashMap<int, (INJNNPDEJLM src, INJNNPDEJLM dst)> DBBOKAICNKD, int CCAOKKILBOM, MDPDCPPKJHK CBHFJDMCLMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E333E0", Offset = "0x5E31BE0", VA = "0x185E333E0")]
	private NativeParallelMultiHashMap<int, (INJNNPDEJLM, INJNNPDEJLM)> IDKOFNAJLJN(Allocator JONICLHJBEP, AJLMOHPDADI BIONNJIHGCI, [Out] AJLMOHPDADI PAPIGFIGMMM)
	{
		return default(NativeParallelMultiHashMap<int, (INJNNPDEJLM, INJNNPDEJLM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public INBFCFKGDFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[DEONFKEHMJD(typeof(LJJGONKGMDG), new string[] { })]
[CIJINFPJIAB(typeof(DNNIDJCFDHC))]
public class DNNIDJCFDHC : LJJGONKGMDG, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly DGJIKJLGCCH CNOPLONJBNP;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly DGJIKJLGCCH EALMLDIHMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private PAPFBDJEGGN AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private DHMIJGJOMFI MJIDHJMLMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private KMLALHOKNKB DEIGKNMHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private NODGOFCBOKD BJMOGIMCPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private NHCACALFIKB PEENKKOKGPE;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private EntityManager IDCNBIGHJII
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5E269F0", Offset = "0x5E251F0", VA = "0x185E269F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E28F30", Offset = "0x5E27730", VA = "0x185E28F30", Slot = "34")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E285B0", Offset = "0x5E26DB0", VA = "0x185E285B0", Slot = "35")]
	public bool GPAFOHEEBAA(Transform CPMBJLDHCID, [Out] INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E279D0", Offset = "0x5E261D0", VA = "0x185E279D0", Slot = "36")]
	public Transform EBJNEOCPDGN(Entity KCMPKMKBCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E27200", Offset = "0x5E25A00", VA = "0x185E27200", Slot = "31")]
	public bool CHKJBCJNDCM(Entity KCMPKMKBCOO, [Out] Transform CPMBJLDHCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E29BE0", Offset = "0x5E283E0", VA = "0x185E29BE0")]
	private void LPPMKHEJGFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E29B30", Offset = "0x5E28330", VA = "0x185E29B30", Slot = "30")]
	public void LEPKLLLNEKC(Entity KCMPKMKBCOO, [Out] float4x4 FOHOBBCECFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E27420", Offset = "0x5E25C20", VA = "0x185E27420", Slot = "4")]
	public void CNFEKPICLME(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A680", Offset = "0x5E28E80", VA = "0x185E2A680", Slot = "28")]
	public void OCPJAGKHAMM(Entity KCMPKMKBCOO, [Out] float4x4 FOHOBBCECFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A290", Offset = "0x5E28A90", VA = "0x185E2A290")]
	public void NHBOLCMOLPP(Entity KCMPKMKBCOO, [In] float4x4 FOHOBBCECFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E272F0", Offset = "0x5E25AF0", VA = "0x185E272F0")]
	public void MIIIKADDLOA(Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E27E10", Offset = "0x5E26610", VA = "0x185E27E10", Slot = "6")]
	public float3 EMEMGGEIENI(Entity KCMPKMKBCOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E29200", Offset = "0x5E27A00", VA = "0x185E29200")]
	public void JJILKKNPGPB(Entity KCMPKMKBCOO, [In] quaternion FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E29C00", Offset = "0x5E28400", VA = "0x185E29C00", Slot = "8")]
	public quaternion MGIIBFEFBHI(Entity KCMPKMKBCOO)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E289A0", Offset = "0x5E271A0", VA = "0x185E289A0")]
	public void MBELKCJKOIO(Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E29440", Offset = "0x5E27C40", VA = "0x185E29440", Slot = "12")]
	public float3 KDHMEJBGJAM(Entity KCMPKMKBCOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E288C0", Offset = "0x5E270C0", VA = "0x185E288C0", Slot = "15")]
	public float HKFCJCIAHFF(Entity KCMPKMKBCOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E29D10", Offset = "0x5E28510", VA = "0x185E29D10", Slot = "14")]
	public void MIIDBPEDDDF(Entity KCMPKMKBCOO, float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E29040", Offset = "0x5E27840", VA = "0x185E29040", Slot = "17")]
	public float3 JBNENNEGNLM(Entity KCMPKMKBCOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E28420", Offset = "0x5E26C20", VA = "0x185E28420")]
	public void GJONJIBEHKA(Entity KCMPKMKBCOO, [In] float3 MAAMAOKPMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E27A90", Offset = "0x5E26290", VA = "0x185E27A90", Slot = "9")]
	public void EDOGFIHMOGJ(Entity KCMPKMKBCOO, [Out] float3 MCLBBPPAHAP, [Out] quaternion OHMBDAJNEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E27C00", Offset = "0x5E26400", VA = "0x185E27C00", Slot = "10")]
	public void EDOGFIHMOGJ(Entity KCMPKMKBCOO, [Out] RigidTransform DPGPLOPHPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E28190", Offset = "0x5E26990", VA = "0x185E28190", Slot = "37")]
	public void FKGKONDHPFD(Entity KCMPKMKBCOO, [Out] float3 MCLBBPPAHAP, [Out] quaternion OHMBDAJNEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E28170", Offset = "0x5E26970", VA = "0x185E28170", Slot = "11")]
	public void FKGKONDHPFD(Entity KCMPKMKBCOO, [Out] RigidTransform DPGPLOPHPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E28E00", Offset = "0x5E27600", VA = "0x185E28E00")]
	public void ICBBFHPMNGB(Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E26A40", Offset = "0x5E25240", VA = "0x185E26A40", Slot = "19")]
	public float3 AGMKGKNKPKD(Entity KCMPKMKBCOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E29320", Offset = "0x5E27B20", VA = "0x185E29320")]
	public void NKAFKFOKKOO(Entity KCMPKMKBCOO, [In] quaternion FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E27F30", Offset = "0x5E26730", VA = "0x185E27F30", Slot = "21")]
	public quaternion FEFJILIMJIP(Entity KCMPKMKBCOO)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E276A0", Offset = "0x5E25EA0", VA = "0x185E276A0")]
	public void DKBNEPAAMCP(Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E278B0", Offset = "0x5E260B0", VA = "0x185E278B0", Slot = "22")]
	public float3 DNKOOHCHAGJ(Entity KCMPKMKBCOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E28AD0", Offset = "0x5E272D0", VA = "0x185E28AD0", Slot = "24")]
	public void HMIPODEBEMO(Entity KCMPKMKBCOO, float JBDNONPCDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E27120", Offset = "0x5E25920", VA = "0x185E27120", Slot = "25")]
	public float BFEAJOELJLH(Entity KCMPKMKBCOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E26CB0", Offset = "0x5E254B0", VA = "0x185E26CB0")]
	public void AMANKIFLNGI(Entity KCMPKMKBCOO, [In] float3 AKFPELJFPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E28730", Offset = "0x5E26F30", VA = "0x185E28730", Slot = "27")]
	public float3 HJNLHEJIFBA(Entity KCMPKMKBCOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E29560", Offset = "0x5E27D60", VA = "0x185E29560", Slot = "32")]
	public void KFOKOFMNHBN(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A170", Offset = "0x5E28970", VA = "0x185E2A170")]
	private INJNNPDEJLM MMCCOMDEGBC(Transform CPMBJLDHCID)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E29EF0", Offset = "0x5E286F0", VA = "0x185E29EF0")]
	private static TransformEntity MJBCPIMBIMC(ILMCDCGEOPC GFGNPBCFEMC, GameObject JFHKBBJBKEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x22287C0", Offset = "0x2226FC0", VA = "0x1822287C0")]
	private static T LJECCAEBPAE<T>(GameObject JFHKBBJBKEA) where T : MonoBehaviour
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A560", Offset = "0x5E28D60", VA = "0x185E2A560", Slot = "33")]
	public void OAINHKHPLMO(Entity KCMPKMKBCOO, Entity LGPCNJNBLBP, Entity KEDAAEKKLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DNNIDJCFDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E272F0", Offset = "0x5E25AF0", VA = "0x185E272F0", Slot = "5")]
	private void CHLEDGAAONC(Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E29200", Offset = "0x5E27A00", VA = "0x185E29200", Slot = "7")]
	private void KKBNLGDPNAE(Entity KCMPKMKBCOO, [In] quaternion FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E289A0", Offset = "0x5E271A0", VA = "0x185E289A0", Slot = "13")]
	private void HMIFGIIBNEH(Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E28420", Offset = "0x5E26C20", VA = "0x185E28420", Slot = "16")]
	private void LKOKOOODNMJ(Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5E28E00", Offset = "0x5E27600", VA = "0x185E28E00", Slot = "18")]
	private void OLIOBCHGIHB(Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5E29320", Offset = "0x5E27B20", VA = "0x185E29320", Slot = "20")]
	private void KDDAIHAPJAB(Entity KCMPKMKBCOO, [In] quaternion FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5E27E00", Offset = "0x5E26600", VA = "0x185E27E00", Slot = "23")]
	private void EILGNCGCCIP(Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5E285A0", Offset = "0x5E26DA0", VA = "0x185E285A0", Slot = "26")]
	private void GOOCEIOMABC(Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A7F0", Offset = "0x5E28FF0", VA = "0x185E2A7F0", Slot = "29")]
	private void OPHPPAILOHL(Entity KCMPKMKBCOO, [In] float4x4 NNJGENDBEIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class DNIMIDGIDDF
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5E267C0", Offset = "0x5E24FC0", VA = "0x185E267C0")]
	public static void OIAGDGCEHPE(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [In] float3 ALAOAMBMFBH, [In] quaternion KCMFIPCJPAM, [In] float3 HFFOOPIIHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5E25C10", Offset = "0x5E24410", VA = "0x185E25C10")]
	public static void LEPKLLLNEKC(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [Out] float4x4 FOHOBBCECFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5E25AD0", Offset = "0x5E242D0", VA = "0x185E25AD0")]
	private static void LEPKLLLNEKC(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, Entity OBIIIBPBMLD, [Out] float4x4 FOHOBBCECFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5E260A0", Offset = "0x5E248A0", VA = "0x185E260A0")]
	public static void NHBOLCMOLPP(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [In] float4x4 FOHOBBCECFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5E254A0", Offset = "0x5E23CA0", VA = "0x185E254A0")]
	public static void IDLNFLHKLOF(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [Out] float4x4 ENGPBGFJPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5E23D80", Offset = "0x5E22580", VA = "0x185E23D80")]
	public static void AIPNEDDIKGO(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [In] float4x4 ENGPBGFJPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5E24880", Offset = "0x5E23080", VA = "0x185E24880")]
	public static float3 EMEMGGEIENI(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5E25FB0", Offset = "0x5E247B0", VA = "0x185E25FB0")]
	public static void MIIIKADDLOA(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5E25E20", Offset = "0x5E24620", VA = "0x185E25E20")]
	public static quaternion MGIIBFEFBHI(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5E25930", Offset = "0x5E24130", VA = "0x185E25930")]
	public static void JJILKKNPGPB(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [In] quaternion FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5E25A20", Offset = "0x5E24220", VA = "0x185E25A20")]
	public static float3 KDHMEJBGJAM(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5E25D30", Offset = "0x5E24530", VA = "0x185E25D30")]
	public static void MBELKCJKOIO(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5E25040", Offset = "0x5E23840", VA = "0x185E25040")]
	public static float HKFCJCIAHFF(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5E25F00", Offset = "0x5E24700", VA = "0x185E25F00")]
	public static void MIIDBPEDDDF(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5E25850", Offset = "0x5E24050", VA = "0x185E25850")]
	public static float3 JBNENNEGNLM(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5E24D10", Offset = "0x5E23510", VA = "0x185E24D10")]
	public static void GJONJIBEHKA(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5E24690", Offset = "0x5E22E90", VA = "0x185E24690")]
	public static void EDOGFIHMOGJ(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [Out] RigidTransform ENGPBGFJPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5E24770", Offset = "0x5E22F70", VA = "0x185E24770")]
	public static void EDOGFIHMOGJ(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [Out] float3 MCLBBPPAHAP, [Out] quaternion OHMBDAJNEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5E26860", Offset = "0x5E25060", VA = "0x185E26860")]
	public static void PBFEAJCEOOC(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [In] float3 ALAOAMBMFBH, [In] quaternion KCMFIPCJPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5E24AE0", Offset = "0x5E232E0", VA = "0x185E24AE0")]
	public static void FKGKONDHPFD(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [Out] float3 MCLBBPPAHAP, [Out] quaternion OHMBDAJNEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5E23C00", Offset = "0x5E22400", VA = "0x185E23C00")]
	public static float3 AGMKGKNKPKD(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5E25250", Offset = "0x5E23A50", VA = "0x185E25250")]
	public static void ICBBFHPMNGB(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5E26430", Offset = "0x5E24C30", VA = "0x185E26430")]
	public static void NKAFKFOKKOO(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [In] quaternion FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5E24970", Offset = "0x5E23170", VA = "0x185E24970")]
	public static quaternion FEFJILIMJIP(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5E24470", Offset = "0x5E22C70", VA = "0x185E24470")]
	public static float3 DNKOOHCHAGJ(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5E24220", Offset = "0x5E22A20", VA = "0x185E24220")]
	public static void DKBNEPAAMCP(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [In] float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5E24040", Offset = "0x5E22840", VA = "0x185E24040")]
	public static float BFEAJOELJLH(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5E25110", Offset = "0x5E23910", VA = "0x185E25110")]
	public static void HMIPODEBEMO(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, float JBDNONPCDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5E24DE0", Offset = "0x5E235E0", VA = "0x185E24DE0")]
	public static float3 HJNLHEJIFBA(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5E23E50", Offset = "0x5E22650", VA = "0x185E23E50")]
	public static void AMANKIFLNGI(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [In] float3 AKFPELJFPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5E24C70", Offset = "0x5E23470", VA = "0x185E24C70")]
	public static bool FMOHEBIIDEC(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [Out] Entity OBIIIBPBMLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[DEONFKEHMJD(typeof(BEODFFKGANF), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.LoadInstance)]
internal sealed class BEODFFKGANF : GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[NMIHDJKFGCM]
	private BFGGNHMHFPC AJDKMCHGGOD;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5E214C0", Offset = "0x5E1FCC0", VA = "0x185E214C0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5E21470", Offset = "0x5E1FC70", VA = "0x185E21470", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public BEODFFKGANF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[DEONFKEHMJD(typeof(LFPOIHKEEPN), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
public class LFPOIHKEEPN
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct GILKDHKFCJA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly LFPOIHKEEPN OBIIIBPBMLD;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F6A0", Offset = "0x5E2DEA0", VA = "0x185E2F6A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private int NFJGNFBPMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[CompilerGenerated]
	private Action OKLGKPDELDA;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5E39430", Offset = "0x5E37C30", VA = "0x185E39430")]
	public void NALJBLDGLLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public LFPOIHKEEPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(LPGGEAMFNMM), new string[] { })]
public class LPGGEAMFNMM
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool PLMDMDMKAAB;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool CFNCBLLJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7B39F0", Offset = "0x7B21F0", VA = "0x1807B39F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5E396D0", Offset = "0x5E37ED0", VA = "0x185E396D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public LPGGEAMFNMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DEONFKEHMJD(typeof(GKLMHFHJBLO), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
public class GKLMHFHJBLO : GJOKPFDLDCJ, DMOCALIGOJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct HHLKBIDDLPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private NativeArray<int> PANBGKBEBMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private NativeArray<int> GPEAFMNEBLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private Dictionary<ComponentSystemBase, int> ODMLHMPBONM;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5E319B0", Offset = "0x5E301B0", VA = "0x185E319B0")]
		public HHLKBIDDLPM(NativeArray<int> PANBGKBEBMG, NativeArray<int> GPEAFMNEBLH, Dictionary<ComponentSystemBase, int> ODMLHMPBONM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5E31590", Offset = "0x5E2FD90", VA = "0x185E31590")]
		public static void FBJIINJGCLE(World NMJLCHEIIPL, PJHIMKBCGDP EFMKACJPIAM, NativeArray<int> PANBGKBEBMG, NativeArray<int> GPEAFMNEBLH, Dictionary<ComponentSystemBase, int> ODMLHMPBONM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5E316C0", Offset = "0x5E2FEC0", VA = "0x185E316C0")]
		public void HLDEAJDJAHM(IEnumerable<ComponentSystemBase> FOCFONOKHED, PJHIMKBCGDP EFMKACJPIAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class EBGILGPIJGN : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private ComponentSystemBase <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public GKLMHFHJBLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int <>3__start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private int end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int <>3__end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public EBGILGPIJGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AB10", Offset = "0x5E29310", VA = "0x185E2AB10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5E2ACF0", Offset = "0x5E294F0", VA = "0x185E2ACF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AC40", Offset = "0x5E29440", VA = "0x185E2AC40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AC40", Offset = "0x5E29440", VA = "0x185E2AC40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly DGJIKJLGCCH GCNIHJPJMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private World NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private HMNFMHNMJBH CJEADCONOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private NativeArray<int> JLJCBEAGEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private NativeArray<int> DGNOGMIECLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int IFOEKNINMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PJHIMKBCGDP KNAIKHFCKNL;

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FC30", Offset = "0x5E2E430", VA = "0x185E2FC30", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FA30", Offset = "0x5E2E230", VA = "0x185E2FA30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5E300E0", Offset = "0x5E2E8E0", VA = "0x185E300E0")]
	[IteratorStateMachine(typeof(EBGILGPIJGN))]
	private IEnumerable<ComponentSystemBase> NDKOBNPHDHN(int OKLBOBFEAFH, int NHGOLACKIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F860", Offset = "0x5E2E060", VA = "0x185E2F860", Slot = "5")]
	public void CNKMLPJMACA(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F860", Offset = "0x5E2E060", VA = "0x185E2F860")]
	private void DDAOIGNJLHH(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F8E0", Offset = "0x5E2E0E0", VA = "0x185E2F8E0")]
	public void DDAOIGNJLHH(PJHIMKBCGDP FOLMCAPLOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FD10", Offset = "0x5E2E510", VA = "0x185E2FD10")]
	private void KAHMLJMAFFM(PJHIMKBCGDP FOLMCAPLOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5E30180", Offset = "0x5E2E980", VA = "0x185E30180")]
	private void NHFOKDGLJAJ(PJHIMKBCGDP FOLMCAPLOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F6E0", Offset = "0x5E2DEE0", VA = "0x185E2F6E0")]
	private void ADOGHMAOKLK(PJHIMKBCGDP FOLMCAPLOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F7B0", Offset = "0x5E2DFB0", VA = "0x185E2F7B0")]
	private void BHCDCCAAPON(int OKLBOBFEAFH, int NHGOLACKIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FAA0", Offset = "0x5E2E2A0", VA = "0x185E2FAA0")]
	private void GNCDMODIAJJ(int OKLBOBFEAFH, int NHGOLACKIAD, bool PLMDMDMKAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FB60", Offset = "0x5E2E360", VA = "0x185E2FB60")]
	private int IGLJFDNEGJN(PJHIMKBCGDP FOLMCAPLOOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x5E302A0", Offset = "0x5E2EAA0", VA = "0x185E302A0")]
	private bool OBIBAEPFLKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FF90", Offset = "0x5E2E790", VA = "0x185E2FF90")]
	private Dictionary<ComponentSystemBase, int> LJGBIPFDBAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F770", Offset = "0x5E2DF70", VA = "0x185E2F770")]
	private void ANOKMHHJGDH(NativeArray<int> PANBGKBEBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FB80", Offset = "0x5E2E380", VA = "0x185E2FB80")]
	private void IHHEJABCODF(NativeArray<int> GPEAFMNEBLH, NativeArray<int> PANBGKBEBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x5E30240", Offset = "0x5E2EA40", VA = "0x185E30240")]
	private static PJHIMKBCGDP NJMMAFLFFEO(Type GFGNPBCFEMC, PJHIMKBCGDP LOJDAJFIDPG)
	{
		return default(PJHIMKBCGDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x5E30920", Offset = "0x5E2F120", VA = "0x185E30920")]
	public GKLMHFHJBLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x5E30080", Offset = "0x5E2E880", VA = "0x185E30080")]
	[CompilerGenerated]
	private void MMCEDLFNCFP(GJOKPFDLDCJ AIOIJNHOCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F800", Offset = "0x5E2E000", VA = "0x185E2F800")]
	[CompilerGenerated]
	private void BHKNFGJCENI(FIBMJMMLGPO AIOIJNHOCFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DEONFKEHMJD(typeof(PCPJLBDGAPJ), new string[] { })]
public class IPGPNOOLAAA : GJOKPFDLDCJ, PCPJLBDGAPJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[NMIHDJKFGCM]
	private FJGKMPJNNPH IKCAIPFFHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[NMIHDJKFGCM]
	private LPDEJHBNHJJ FAJMCMPDBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[NMIHDJKFGCM]
	private DEDLLFMJKEO FKILDDJFBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[NMIHDJKFGCM]
	private NODGOFCBOKD JNCEPLNFFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[NMIHDJKFGCM]
	private PDJBPFDHMMJ MLDHMBALKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private World HAKEGFOFOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private EFOIAGCHDMP OOKBCDHMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private EFOIAGCHDMP OGAJDEJEEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private EFOIAGCHDMP PLINHEJJEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private EFOIAGCHDMP INMPIBIKLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private EFOIAGCHDMP ELIMPPHMHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private EFOIAGCHDMP CFICNPAHDHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private EFOIAGCHDMP AEPIBDFLEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private EFOIAGCHDMP HIEDOCFCDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private EFOIAGCHDMP GAEKEILLEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private EFOIAGCHDMP HKHEJOJICHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private EFOIAGCHDMP PEDEFLJMLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private EFOIAGCHDMP HAGPMGFCAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private EFOIAGCHDMP LFLPHHHCBEG;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private bool FCCFDJPAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5E38910", Offset = "0x5E37110", VA = "0x185E38910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private bool HGEHKFFMFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x5E38420", Offset = "0x5E36C20", VA = "0x185E38420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private bool DKIJMOIHIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5E37C20", Offset = "0x5E36420", VA = "0x185E37C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private bool KKKIHBLHAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5E37C20", Offset = "0x5E36420", VA = "0x185E37C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5E37E70", Offset = "0x5E36670", VA = "0x185E37E70", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x239FE50", Offset = "0x239E650", VA = "0x18239FE50")]
	private EFOIAGCHDMP MMOFJHJEBCC<T>() where T : LAGILAHGKFH
	{
		return default(EFOIAGCHDMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x5E38490", Offset = "0x5E36C90", VA = "0x185E38490")]
	private EFOIAGCHDMP MMOFJHJEBCC(Type GFGNPBCFEMC)
	{
		return default(EFOIAGCHDMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x5E38390", Offset = "0x5E36B90", VA = "0x185E38390", Slot = "14")]
	public void KEBFOHMHAJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x5E37D30", Offset = "0x5E36530", VA = "0x185E37D30", Slot = "15")]
	public void HEAJCFAEABC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x5E38400", Offset = "0x5E36C00", VA = "0x185E38400", Slot = "5")]
	public void LJOBKOFGEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x5E38310", Offset = "0x5E36B10", VA = "0x185E38310", Slot = "6")]
	public void KBDJLIAEHNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5E38540", Offset = "0x5E36D40", VA = "0x185E38540", Slot = "7")]
	public void NHMDNABBGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x5E37D60", Offset = "0x5E36560", VA = "0x185E37D60", Slot = "8")]
	public void HFHIAJLKEFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x5E37BA0", Offset = "0x5E363A0", VA = "0x185E37BA0", Slot = "9")]
	public void EDCFOPEMDEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x5E37C50", Offset = "0x5E36450", VA = "0x185E37C50", Slot = "10")]
	public void GKCKDIGLFDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5E384C0", Offset = "0x5E36CC0", VA = "0x185E384C0", Slot = "11")]
	public void NGKNAOLHEJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5E383C0", Offset = "0x5E36BC0", VA = "0x185E383C0", Slot = "12")]
	public void LDDAEICNDPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x5E385C0", Offset = "0x5E36DC0", VA = "0x185E385C0", Slot = "13")]
	public void NLEOFAPBMAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x5E38280", Offset = "0x5E36A80", VA = "0x185E38280")]
	private void JPOOCJABCMN(EFOIAGCHDMP JPKIBHPPOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x5E37DE0", Offset = "0x5E365E0", VA = "0x185E37DE0")]
	private void IOAIMFJMOJC(EFOIAGCHDMP JPKIBHPPOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x5E37C30", Offset = "0x5E36430", VA = "0x185E37C30")]
	private void FGHAIFBMEBG(EFOIAGCHDMP JPKIBHPPOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public IPGPNOOLAAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal readonly struct EFOIAGCHDMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly ComponentSystemBase JPKIBHPPOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly ProfilerMarker IFAELGPLEAM;

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BE80", Offset = "0x5E2A680", VA = "0x185E2BE80")]
	public EFOIAGCHDMP(World NMJLCHEIIPL, Type GFGNPBCFEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BDB0", Offset = "0x5E2A5B0", VA = "0x185E2BDB0")]
	public void FGHAIFBMEBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[DEONFKEHMJD(typeof(CIKNOIPMHLH), new string[] { })]
public class CEDENAICCHF : CIKNOIPMHLH, IDisposable, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[NMIHDJKFGCM]
	private EHJKEAAEBEM FBNEDKLKGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[NMIHDJKFGCM]
	private NOBCMIJEINK NKAPFCJKAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private World HAKEGFOFOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private World JJDPLCCFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool JDKHPFLJFLC;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public World PANADLMAEKB
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public World BAPJGFNLPHO
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5E21DD0", Offset = "0x5E205D0", VA = "0x185E21DD0", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool AMDAEMPIIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3622E70", Offset = "0x3621670", VA = "0x183622E70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x5E220C0", Offset = "0x5E208C0", VA = "0x185E220C0", Slot = "10")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x5E22260", Offset = "0x5E20A60", VA = "0x185E22260")]
	private void KLKFANDJKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5E21DF0", Offset = "0x5E205F0", VA = "0x185E21DF0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5E22390", Offset = "0x5E20B90", VA = "0x185E22390", Slot = "8")]
	public ComponentSystemBase MMOFJHJEBCC(Type GFGNPBCFEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CEDENAICCHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DEONFKEHMJD(typeof(IGMADLKHOBA), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
public class IGMADLKHOBA : IKHNKAPNHGJ, LKDNHKMMDCB, GMMHILFNMPG, GJOKPFDLDCJ, FIBMJMMLGPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class HEEACCEABBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public HMNFMHNMJBH services;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public HEEACCEABBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5E31530", Offset = "0x5E2FD30", VA = "0x185E31530")]
		internal void BMLCALLLECD(GJOKPFDLDCJ svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class DAMPLIBFLIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public HMNFMHNMJBH services;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public DAMPLIBFLIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5E23B20", Offset = "0x5E22320", VA = "0x185E23B20")]
		internal void EDMCAGHKPDJ(FIBMJMMLGPO svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[NMIHDJKFGCM]
	private GMEDPFHIIAE EFEPLPGFMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[NMIHDJKFGCM]
	private CBDHEEDCCOH EFGNGNHGGFC;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public GKJIGEDKBPA EMOENIDPGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7E07D0", Offset = "0x7DEFD0", VA = "0x1807E07D0", Slot = "4")]
		get
		{
			return default(GKJIGEDKBPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x5E32CC0", Offset = "0x5E314C0", VA = "0x185E32CC0", Slot = "5")]
	public void IJALEBCDNGI(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x5E32BA0", Offset = "0x5E313A0", VA = "0x185E32BA0", Slot = "6")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x5E32D50", Offset = "0x5E31550", VA = "0x185E32D50", Slot = "7")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5E329A0", Offset = "0x5E311A0", VA = "0x185E329A0", Slot = "8")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5E32A80", Offset = "0x5E31280", VA = "0x185E32A80", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x2393A70", Offset = "0x2392270", VA = "0x182393A70")]
	private void IGLDEENCOIH<T>(Action<T> OFKGFGLJEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public IGMADLKHOBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[DefaultMember("Item")]
[DEONFKEHMJD(typeof(FMKLLJOIEFE), new string[] { })]
public class EBKHBODMCCL : FMKLLJOIEFE, IEnumerable<DFAONIGDOMP>, IEnumerable, LKDNHKMMDCB, GMMHILFNMPG, GJOKPFDLDCJ, FIBMJMMLGPO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[NMIHDJKFGCM]
	private JBAMOKIPOCH CBHFJDMCLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly Dictionary<(Type, string), int> JBEKAPMJBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private NativeBitArray FGLDDAIAFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private NativeArray<int> PPHGDPNCBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private LLJGMINJOAD KBPHLFOGJGG;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public NativeBitArray KHEBCLIEPAL
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD474A0", VA = "0x180D48CA0", Slot = "4")]
		get
		{
			return default(NativeBitArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public NativeArray<int> KNDNDLHIPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5DC60", VA = "0x180D5F460", Slot = "5")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private int CBLPJPHJFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x847760", Offset = "0x845F60", VA = "0x180847760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B310", Offset = "0x5E29B10", VA = "0x185E2B310", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public DFAONIGDOMP HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x5E2BD00", Offset = "0x5E2A500", VA = "0x185E2BD00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public DFAONIGDOMP HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5E2BD00", Offset = "0x5E2A500", VA = "0x185E2BD00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B110", Offset = "0x5E29910", VA = "0x185E2B110", Slot = "13")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B350", Offset = "0x5E29B50", VA = "0x185E2B350", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "15")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B3D0", Offset = "0x5E29BD0", VA = "0x185E2B3D0")]
	private void MAAKLMPAFFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B160", Offset = "0x5E29960", VA = "0x185E2B160", Slot = "9")]
	public DFAONIGDOMP GEFPFIOJENA(IPJNDHGBNHD IACPFKBCIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AF70", Offset = "0x5E29770", VA = "0x185E2AF70")]
	private bool DCIJCLJKHNL(Type EHLLOFCHICP, string HNHMJGCODBA, [Out] DFAONIGDOMP DHNIGJBMBBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AD40", Offset = "0x5E29540", VA = "0x185E2AD40", Slot = "10")]
	public OJBFPODPDEH CLDMJDHPOJM(IPJNDHGBNHD IACPFKBCIBD)
	{
		return default(OJBFPODPDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B330", Offset = "0x5E29B30", VA = "0x185E2B330", Slot = "11")]
	public IEnumerator<DFAONIGDOMP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B330", Offset = "0x5E29B30", VA = "0x185E2B330", Slot = "12")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B0C0", Offset = "0x5E298C0", VA = "0x185E2B0C0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BD20", Offset = "0x5E2A520", VA = "0x185E2BD20")]
	public EBKHBODMCCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
[DEONFKEHMJD(typeof(GDPMKDOKMND), new string[] { })]
public class BAGABHFDGNB : GDPMKDOKMND, IEnumerable<PKPLGAMLPEK>, IEnumerable, LKDNHKMMDCB, GMMHILFNMPG, GJOKPFDLDCJ, FIBMJMMLGPO, KKJABINMDJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[NMIHDJKFGCM]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[NMIHDJKFGCM]
	private FMKLLJOIEFE OGOEFIDFEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private PKPLGAMLPEK[] PILHFFLPNFB;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x5304D20", Offset = "0x5303520", VA = "0x185304D20", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public PKPLGAMLPEK HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x5E21420", Offset = "0x5E1FC20", VA = "0x185E21420", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "10")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5E21140", Offset = "0x5E1F940", VA = "0x185E21140", Slot = "11")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "12")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5E20F40", Offset = "0x5E1F740", VA = "0x185E20F40", Slot = "6")]
	public PKPLGAMLPEK GEFPFIOJENA(IPJNDHGBNHD IACPFKBCIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E20D40", Offset = "0x5E1F540", VA = "0x185E20D40", Slot = "7")]
	public OJBFPODPDEH CLDMJDHPOJM(IPJNDHGBNHD IACPFKBCIBD)
	{
		return default(OJBFPODPDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E21060", Offset = "0x5E1F860", VA = "0x185E21060", Slot = "8")]
	public IEnumerator<PKPLGAMLPEK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E21450", Offset = "0x5E1FC50", VA = "0x185E21450", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x2177940", Offset = "0x2176140", VA = "0x182177940", Slot = "13")]
	public void LMKLIIHHDPA<TKey, T>(POPLGHHELHE<TKey, T> EJKGILKDBHL, [Optional] object FJNGJOFLBMD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E20E10", Offset = "0x5E1F610", VA = "0x185E20E10", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public BAGABHFDGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E21420", Offset = "0x5E1FC20", VA = "0x185E21420")]
	[CompilerGenerated]
	private PKPLGAMLPEK LKDICJGGNON(int DKLECPOCCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DEONFKEHMJD(typeof(INPEDOFCAMM), new string[] { })]
[DefaultMember("Item")]
public class AFEMDCIBJPO : INPEDOFCAMM, IEnumerable<DNPLMCKHBDK>, IEnumerable, GJOKPFDLDCJ, FIBMJMMLGPO, KKJABINMDJF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[NMIHDJKFGCM]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[NMIHDJKFGCM]
	private FMKLLJOIEFE OGOEFIDFEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private DNPLMCKHBDK[] PILHFFLPNFB;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D9A0", Offset = "0x5E1C1A0", VA = "0x185E1D9A0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public DNPLMCKHBDK HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DC30", Offset = "0x5E1C430", VA = "0x185E1DC30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DB00", Offset = "0x5E1C300", VA = "0x185E1DB00", Slot = "10")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D470", Offset = "0x5E1BC70", VA = "0x185E1D470", Slot = "11")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DB70", Offset = "0x5E1C370", VA = "0x185E1DB70")]
	private DNPLMCKHBDK KFNAPFAFEHO(int LFEFGCGCIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D880", Offset = "0x5E1C080", VA = "0x185E1D880", Slot = "6")]
	public DNPLMCKHBDK GEFPFIOJENA(IPJNDHGBNHD IACPFKBCIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D710", Offset = "0x5E1BF10", VA = "0x185E1D710", Slot = "7")]
	public OJBFPODPDEH CLDMJDHPOJM(IPJNDHGBNHD IACPFKBCIBD)
	{
		return default(OJBFPODPDEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D9F0", Offset = "0x5E1C1F0", VA = "0x185E1D9F0", Slot = "8")]
	public IEnumerator<DNPLMCKHBDK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D9F0", Offset = "0x5E1C1F0", VA = "0x185E1D9F0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2999E20", Offset = "0x2998620", VA = "0x182999E20", Slot = "12")]
	public void LMKLIIHHDPA<TKey, T>(POPLGHHELHE<TKey, T> EJKGILKDBHL, [Optional] object FJNGJOFLBMD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D7E0", Offset = "0x5E1BFE0", VA = "0x185E1D7E0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public AFEMDCIBJPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DC30", Offset = "0x5E1C430", VA = "0x185E1DC30")]
	[CompilerGenerated]
	private DNPLMCKHBDK LKDICJGGNON(int DKLECPOCCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[DEONFKEHMJD(typeof(JBAMOKIPOCH), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal class JBAMOKIPOCH : GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private FMKLLJOIEFE OGOEFIDFEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private INPEDOFCAMM LBJEHFDMILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private GDPMKDOKMND MPKLNAMFPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[NMIHDJKFGCM]
	private CBDHEEDCCOH EFGNGNHGGFC;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public LLJGMINJOAD JGBBCGFCCOB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x76E4B0", Offset = "0x76CCB0", VA = "0x18076E4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E38CC0", Offset = "0x5E374C0", VA = "0x185E38CC0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E38E10", Offset = "0x5E37610", VA = "0x185E38E10")]
	private void JMEKDMPLNPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E38BF0", Offset = "0x5E373F0", VA = "0x185E38BF0")]
	public DFAONIGDOMP AKJNMNKEGEJ(IPJNDHGBNHD HNHMJGCODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x23BC240", Offset = "0x23BAA40", VA = "0x1823BC240")]
	public OONIBNJFANM<T> KBGMGEMFDDK<T>(IPJNDHGBNHD HNHMJGCODBA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JBAMOKIPOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal static class DGDHDBCFFBL
{
	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x22146D0", Offset = "0x2212ED0", VA = "0x1822146D0")]
	public static FAOOFKFDMAN<T> AKJNMNKEGEJ<T>(this JBAMOKIPOCH JNPEOGGNGFP, GCEJGJJCPNB<T> HNHMJGCODBA) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(PDJBPFDHMMJ), new string[] { })]
public class PDJBPFDHMMJ : GMMHILFNMPG, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[NMIHDJKFGCM]
	private PPEDACELMBL ONNHHFMGKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool BNKHANONGAD;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public TimeData KFDIGGONKFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FB50", Offset = "0x5E3E350", VA = "0x185E3FB50")]
		get
		{
			return default(TimeData);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FBC0", Offset = "0x5E3E3C0", VA = "0x185E3FBC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool IHOLAMMJOHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D07D0", Offset = "0x7CEFD0", VA = "0x1807D07D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0xB831C0", Offset = "0xB819C0", VA = "0x180B831C0", Slot = "4")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FC20", Offset = "0x5E3E420", VA = "0x185E3FC20", Slot = "5")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FC70", Offset = "0x5E3E470", VA = "0x185E3FC70")]
	public void MKGJGDLFCFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	public void ABPABCHBKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public PDJBPFDHMMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(CCAKIPGLEFJ), new string[] { })]
public class CCAKIPGLEFJ : GJOKPFDLDCJ, FIBMJMMLGPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private MPONBMGLGEH DMEBAJIIFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private GDPMKDOKMND CBHFJDMCLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private OJBFPODPDEH[] HBBNGEKCBGM;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E218F0", Offset = "0x5E200F0", VA = "0x185E218F0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E21570", Offset = "0x5E1FD70", VA = "0x185E21570", Slot = "5")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E217D0", Offset = "0x5E1FFD0", VA = "0x185E217D0")]
	public void HJJPMLIBOFJ(AFCHODDKGEA NFLGLAGMLAA, bool GIAEHOGEIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CCAKIPGLEFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DEONFKEHMJD(typeof(FLJCOMNOBDO), new string[] { })]
public sealed class OCEEIFADAEM : FLJCOMNOBDO, LKDNHKMMDCB, GMMHILFNMPG, GJOKPFDLDCJ, FIBMJMMLGPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class NJLOCHHFDPM : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x955E20", Offset = "0x954620", VA = "0x180955E20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x5E3E450", Offset = "0x5E3CC50", VA = "0x185E3E450", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1B32A80", Offset = "0x1B31280", VA = "0x181B32A80")]
		[DebuggerHidden]
		public NJLOCHHFDPM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E160", Offset = "0x5E3C960", VA = "0x185E3E160", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E400", Offset = "0x5E3CC00", VA = "0x185E3E400", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E350", Offset = "0x5E3CB50", VA = "0x185E3E350", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E350", Offset = "0x5E3CB50", VA = "0x185E3E350", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[NMIHDJKFGCM]
	private INPEDOFCAMM CBHFJDMCLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly MOPEJKIOMJP NKBKLLOJMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly Dictionary<string, NHELCJBADNG> HLDPPAKJHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<int, KBNCBBCPKEE> BJECDOKODBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly List<DNPLMCKHBDK> HMBNPBMGPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private GAHJBAOIADM GLKFLDDFJDD;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public KBNCBBCPKEE BCLHMPDFFHN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E870", Offset = "0x5E3D070", VA = "0x185E3E870", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<DNPLMCKHBDK> KOEJJBPEGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "9")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E3ED00", Offset = "0x5E3D500", VA = "0x185E3ED00", Slot = "10")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E520", Offset = "0x5E3CD20", VA = "0x185E3E520", Slot = "11")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E930", Offset = "0x5E3D130", VA = "0x185E3E930", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F450", Offset = "0x5E3DC50", VA = "0x185E3F450", Slot = "6")]
	public bool NFEGOGNPJNF(DNPLMCKHBDK EJKGILKDBHL, [Out] KBNCBBCPKEE KFGNDBNPGJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F070", Offset = "0x5E3D870", VA = "0x185E3F070")]
	private void MDICOHEPEKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EA70", Offset = "0x5E3D270", VA = "0x185E3EA70")]
	private void GGIKMEAMHNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E8D0", Offset = "0x5E3D0D0", VA = "0x185E3E8D0")]
	private NHELCJBADNG DEIKJPHALNP(string FAFAODKLBFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E870", Offset = "0x5E3D070", VA = "0x185E3E870")]
	private NHELCJBADNG GKPPCLBAFCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E3ED60", Offset = "0x5E3D560", VA = "0x185E3ED60")]
	private NHELCJBADNG LDJECAIDJEE(string FAFAODKLBFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E580", Offset = "0x5E3CD80", VA = "0x185E3E580")]
	private NHELCJBADNG BEGABBIBIPK(string EPIKKECCKMG, string KIAKEGJPMAL, [Optional] NHELCJBADNG HMIHPDEBKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F620", Offset = "0x5E3DE20", VA = "0x185E3F620")]
	[IteratorStateMachine(typeof(NJLOCHHFDPM))]
	private IEnumerable<(string, string)> PJCCNNFAADD(string FAFAODKLBFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E770", Offset = "0x5E3CF70", VA = "0x185E3E770")]
	private bool BMPHPMOBBAJ(DNPLMCKHBDK EJKGILKDBHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EC20", Offset = "0x5E3D420", VA = "0x185E3EC20")]
	private MOPEJKIOMJP HABHHACCDLD(DNPLMCKHBDK EJKGILKDBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F020", Offset = "0x5E3D820", VA = "0x185E3F020")]
	private MOPEJKIOMJP LGJHAILDGLE(DNPLMCKHBDK EJKGILKDBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E9E0", Offset = "0x5E3D1E0", VA = "0x185E3E9E0")]
	private MOPEJKIOMJP ELHNNBDBPLH(DNPLMCKHBDK EJKGILKDBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x24D69D0", Offset = "0x24D51D0", VA = "0x1824D69D0")]
	private T LHPJBEKNHKG<T>(DNPLMCKHBDK EJKGILKDBHL) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F6A0", Offset = "0x5E3DEA0", VA = "0x185E3F6A0")]
	private FieldInfo PNHONHHBNEM(DNPLMCKHBDK EJKGILKDBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F4E0", Offset = "0x5E3DCE0", VA = "0x185E3F4E0", Slot = "7")]
	public void NJMEIPIEAKJ(DNPLMCKHBDK EJKGILKDBHL, KGKKGEFDIKG DOMFMMLMKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E7C0", Offset = "0x5E3CFC0", VA = "0x185E3E7C0", Slot = "8")]
	public void CDCOKJBLGCF(DNPLMCKHBDK EJKGILKDBHL, KGKKGEFDIKG DOMFMMLMKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F790", Offset = "0x5E3DF90", VA = "0x185E3F790")]
	public OCEEIFADAEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F590", Offset = "0x5E3DD90", VA = "0x185E3F590")]
	[CompilerGenerated]
	private int ONFIPOPJAJD(DNPLMCKHBDK EOFAJFKEBLN, DNPLMCKHBDK DNOEGKBPKDC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class NHELCJBADNG : KBNCBBCPKEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public readonly string HPGNKEKGPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public readonly NHELCJBADNG HMIHPDEBKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public readonly List<NHELCJBADNG> ILPJPKAMOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public readonly List<DNPLMCKHBDK> CBHFJDMCLMP;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public string AENOAFLLKHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public KBNCBBCPKEE DNBLBNEMHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<KBNCBBCPKEE> JOKJBCKPMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E050", Offset = "0x5E3C850", VA = "0x185E3E050")]
	public NHELCJBADNG(string HNHMJGCODBA, NHELCJBADNG OBIIIBPBMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[DEONFKEHMJD(typeof(global::AOGDCIFPGBN), new string[] { })]
internal class IMJDMCGDIBL : global::AOGDCIFPGBN, GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	[NMIHDJKFGCM]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	[NMIHDJKFGCM]
	private FGPPMMNJDIL DEIGKNMHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	[NMIHDJKFGCM]
	private JBAMOKIPOCH CBHFJDMCLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	[NMIHDJKFGCM]
	private GAHJBAOIADM HGOFPLJJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private Action<BKPDEAFDJBG> ABCKGGDLEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private FAOOFKFDMAN<Entity> OBIIIBPBMLD;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<BKPDEAFDJBG> GJEBJKHGOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E33260", Offset = "0x5E31A60", VA = "0x185E33260", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E32E30", Offset = "0x5E31630", VA = "0x185E32E30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E33120", Offset = "0x5E31920", VA = "0x185E33120", Slot = "6")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E32FA0", Offset = "0x5E317A0", VA = "0x185E32FA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E33260", Offset = "0x5E31A60", VA = "0x185E33260")]
	private void MHEBLJPKNLO(Action<BKPDEAFDJBG> FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E32E30", Offset = "0x5E31630", VA = "0x185E32E30")]
	private void DDBPBCBDDHN(Action<BKPDEAFDJBG> FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E330B0", Offset = "0x5E318B0", VA = "0x185E330B0")]
	private void EKLMCNFIKDP(GDGCFENIDIN AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public IMJDMCGDIBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[PHKIPGBLCCH(PJHIMKBCGDP.LoadInstance)]
[DEONFKEHMJD(typeof(GLINBODGGGB), new string[] { })]
public class GLINBODGGGB : GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	[NMIHDJKFGCM]
	private LPGGEAMFNMM MKMECJFCOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[NMIHDJKFGCM]
	private GKLMHFHJBLO MIPJFBFODGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[NMIHDJKFGCM]
	private NGKJMLHKKJA BFGNFEGPODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	[NMIHDJKFGCM]
	private NHCACALFIKB IBKDOLMCEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E30980", Offset = "0x5E2F180", VA = "0x185E30980", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E30930", Offset = "0x5E2F130", VA = "0x185E30930", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E30AC0", Offset = "0x5E2F2C0", VA = "0x185E30AC0")]
	private void MJMKEMBJGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E30930", Offset = "0x5E2F130", VA = "0x185E30930")]
	private void LMKGMBDHNLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E30B50", Offset = "0x5E2F350", VA = "0x185E30B50")]
	private void PDAJLHDFKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public GLINBODGGGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DEONFKEHMJD(typeof(NCLGOBJOGHN), new string[] { })]
public class AACCJJJMNED : NCLGOBJOGHN, GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[NMIHDJKFGCM]
	private LDNONJHJNKB GDDMPKMBLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[NMIHDJKFGCM]
	private FLLLIFEEDMK BPABABDKIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly List<NativeListAsync<Entity>> DEFBPAMMCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly List<(NativeListAsync<Entity>, bool)> IEJMLGAKJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private MABNELIJHEC FODEBHNOFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private Dictionary<Entity, JLFJIKPKDGP> NOHILJBAEJH;

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C490", Offset = "0x5E1AC90", VA = "0x185E1C490", Slot = "8")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BCC0", Offset = "0x5E1A4C0", VA = "0x185E1BCC0", Slot = "4")]
	public void BGEEOEIAKGK(NativeListAsync<Entity> FAIFKAKJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CAF0", Offset = "0x5E1B2F0", VA = "0x185E1CAF0", Slot = "5")]
	public void LCJPNPBJGOM(MABNELIJHEC FODEBHNOFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CB40", Offset = "0x5E1B340", VA = "0x185E1CB40", Slot = "6")]
	public void PEIKPGLEAKH(NativeListAsync<Entity> FAIFKAKJOPP, bool NAFHMPNGMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C770", Offset = "0x5E1AF70", VA = "0x185E1C770", Slot = "7")]
	public void JPIOKCOGFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BD90", Offset = "0x5E1A590", VA = "0x185E1BD90", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C250", Offset = "0x5E1AA50", VA = "0x185E1C250")]
	private int GJAGBPACEJD(NativeListAsync<Entity> DEFBPAMMCML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C500", Offset = "0x5E1AD00", VA = "0x185E1C500")]
	private int JFJMDMFMOMK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BAA0", Offset = "0x5E1A2A0", VA = "0x185E1BAA0")]
	private int AAIGDODNCEK(NativeListAsync<Entity> IEJMLGAKJAP, bool IKEONGLELGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CD00", Offset = "0x5E1B500", VA = "0x185E1CD00")]
	public AACCJJJMNED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C220", Offset = "0x5E1AA20", VA = "0x185E1C220")]
	[CompilerGenerated]
	private INJNNPDEJLM FCGAHLMHOEF(Entity KCMPKMKBCOO)
	{
		return default(INJNNPDEJLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DEONFKEHMJD(typeof(AGLDANFEMLE), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.LoadInstance)]
public class AGLDANFEMLE : GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly List<NativeListAsync<DOIHIGCEKFD>> LAJBJPNGAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E9F0", Offset = "0x5E1D1F0", VA = "0x185E1E9F0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E920", Offset = "0x5E1D120", VA = "0x185E1E920")]
	public void EAIDLINDAII(NativeListAsync<DOIHIGCEKFD> FAIFKAKJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EA40", Offset = "0x5E1D240", VA = "0x185E1EA40")]
	public void MLJBOBEEFIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E7A0", Offset = "0x5E1CFA0", VA = "0x185E1E7A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EED0", Offset = "0x5E1D6D0", VA = "0x185E1EED0")]
	public AGLDANFEMLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DEONFKEHMJD(typeof(JLPKDNBELME), new string[] { })]
public class ABOBDCNKJAA : GJOKPFDLDCJ, JLPKDNBELME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private EntityManager IDCNBIGHJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private JPCLBEACHKO FPIJDFHMBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private FLLLIFEEDMK BPABABDKIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D1D0", Offset = "0x5E1B9D0", VA = "0x185E1D1D0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CE20", Offset = "0x5E1B620", VA = "0x185E1CE20", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D2A0", Offset = "0x5E1BAA0", VA = "0x185E1D2A0", Slot = "5")]
	public bool PPENIDIEMMB(INJNNPDEJLM JFIBILKOJPE, [Out] Collider ICCDLLEGOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CF40", Offset = "0x5E1B740", VA = "0x185E1CF40", Slot = "6")]
	public GameObject FPDDCJOJAOB(INJNNPDEJLM LJFNPBOGFKE, GameObject OCMOLCOCAGI, Vector3 ALAOAMBMFBH, Quaternion KCMFIPCJPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CE30", Offset = "0x5E1B630", VA = "0x185E1CE30", Slot = "7")]
	public void FKKCEABIPBJ(GameObject ICCDLLEGOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x2997960", Offset = "0x2996160", VA = "0x182997960", Slot = "8")]
	public TCollider GDOHMEKNKDB<TCollider>(GameObject AICHCNJNAKM) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D100", Offset = "0x5E1B900", VA = "0x185E1D100", Slot = "9")]
	public void IIDLFJHEBKC(Collider ICCDLLEGOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2997A30", Offset = "0x2996230", VA = "0x182997A30", Slot = "10")]
	public GameObject OFEIGODGEBI<TCollider>(string HNHMJGCODBA) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public ABOBDCNKJAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[DEONFKEHMJD(typeof(HCLOJIAEBDJ), new string[] { })]
public class IOMNCCFBNHJ : GJOKPFDLDCJ, HCLOJIAEBDJ
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class HMOMHJGNIDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public INJNNPDEJLM localId;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public HMOMHJGNIDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D40", Offset = "0x5E50540", VA = "0x185E51D40")]
		internal object LKCKLEAPIFA(IOMNCCFBNHJ a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class ICAONPKKEIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public INJNNPDEJLM localId;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ICAONPKKEIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x5E51DD0", Offset = "0x5E505D0", VA = "0x185E51DD0")]
		internal object MGINCKFHNAL(IOMNCCFBNHJ a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private LJJGONKGMDG DFJLJGOOCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private World NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private BCPMIOAIJEL MLIJLJDKNJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[NMIHDJKFGCM]
	private PPEDACELMBL ONNHHFMGKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private EntityManager AOHONJMGBDI;

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5E36590", Offset = "0x5E34D90", VA = "0x185E36590", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5E37610", Offset = "0x5E35E10", VA = "0x185E37610", Slot = "6")]
	public BOFNPIGFHNE OOFAJLJFFBD(INJNNPDEJLM JFIBILKOJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5E35660", Offset = "0x5E33E60", VA = "0x185E35660", Slot = "5")]
	public void EEIHCADCPIL(INJNNPDEJLM JFIBILKOJPE, BOFNPIGFHNE FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x5E34880", Offset = "0x5E33080", VA = "0x185E34880", Slot = "31")]
	public CollisionDetectionMode CBFMEHMBJCD(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(CollisionDetectionMode);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x5E361B0", Offset = "0x5E349B0", VA = "0x185E361B0", Slot = "32")]
	public void ICAAEAKJAEB(INJNNPDEJLM JFIBILKOJPE, CollisionDetectionMode FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x5E35050", Offset = "0x5E33850", VA = "0x185E35050", Slot = "33")]
	public ABDACCGDOPN DBMBHKJOFMD(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(ABDACCGDOPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x5E359B0", Offset = "0x5E341B0", VA = "0x185E359B0", Slot = "34")]
	public void FEFFNPALPCB(INJNNPDEJLM JFIBILKOJPE, ABDACCGDOPN FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x5E34460", Offset = "0x5E32C60", VA = "0x185E34460", Slot = "35")]
	public bool AJKBGHECIFE(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x5E37AA0", Offset = "0x5E362A0", VA = "0x185E37AA0", Slot = "36")]
	public void PKPLCCPIDND(INJNNPDEJLM JFIBILKOJPE, bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5E36A40", Offset = "0x5E35240", VA = "0x185E36A40", Slot = "37")]
	public INJNNPDEJLM KHJHAPEDKKI(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5E35280", Offset = "0x5E33A80", VA = "0x185E35280", Slot = "38")]
	public void DGEDOGIJEFN(INJNNPDEJLM JFIBILKOJPE, INJNNPDEJLM FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x5E35D20", Offset = "0x5E34520", VA = "0x185E35D20", Slot = "39")]
	public INJNNPDEJLM GADDKJOEJFO(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5E36730", Offset = "0x5E34F30", VA = "0x185E36730", Slot = "40")]
	public void JLJFDADNEME(INJNNPDEJLM JFIBILKOJPE, INJNNPDEJLM FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5E34960", Offset = "0x5E33160", VA = "0x185E34960", Slot = "7")]
	public void CCIOJOCPJBE(INJNNPDEJLM JFIBILKOJPE, INJNNPDEJLM FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5E362B0", Offset = "0x5E34AB0", VA = "0x185E362B0", Slot = "8")]
	public void IIMOIKPKMHN(INJNNPDEJLM JFIBILKOJPE, INJNNPDEJLM FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5E341A0", Offset = "0x5E329A0", VA = "0x185E341A0", Slot = "9")]
	public int AEDBNOCDBMA(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5E379A0", Offset = "0x5E361A0", VA = "0x185E379A0", Slot = "10")]
	public INJNNPDEJLM PJKNEBDEOPC(INJNNPDEJLM JFIBILKOJPE, int LFEFGCGCIAG)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5E360E0", Offset = "0x5E348E0", VA = "0x185E360E0", Slot = "11")]
	public void HLPIELOPCJH(INJNNPDEJLM JFIBILKOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5E35E60", Offset = "0x5E34660", VA = "0x185E35E60", Slot = "12")]
	public void GKCBJKKPHIA(INJNNPDEJLM JFIBILKOJPE, object KIAKEGJPMAL, INJNNPDEJLM FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5E35F60", Offset = "0x5E34760", VA = "0x185E35F60", Slot = "13")]
	public void HELLLGMGIMO(INJNNPDEJLM JFIBILKOJPE, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x5E34A40", Offset = "0x5E33240", VA = "0x185E34A40", Slot = "14")]
	public bool CDFHOIMHGIE(INJNNPDEJLM JFIBILKOJPE, [Out] INJNNPDEJLM FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5E34070", Offset = "0x5E32870", VA = "0x185E34070", Slot = "15")]
	public void ABJJGOFLAJJ(INJNNPDEJLM JFIBILKOJPE, float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x5E34E20", Offset = "0x5E33620", VA = "0x185E34E20", Slot = "16")]
	public bool CMPFAHKFION(INJNNPDEJLM JFIBILKOJPE, [Out] float3 FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5E37570", Offset = "0x5E35D70", VA = "0x185E37570", Slot = "17")]
	public void OKOONJMDEMF(INJNNPDEJLM JFIBILKOJPE, float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x5E35720", Offset = "0x5E33F20", VA = "0x185E35720", Slot = "18")]
	public bool EEJDFOOFEKJ(INJNNPDEJLM JFIBILKOJPE, [Out] float3 FKKGMPDEPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x5E371F0", Offset = "0x5E359F0", VA = "0x185E371F0", Slot = "23")]
	[Obsolete("Use SetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	public float3 NDNNHHEBCCJ(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5E347E0", Offset = "0x5E32FE0", VA = "0x185E347E0", Slot = "24")]
	public float3 BPFKHPLOGNB(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x5E35DC0", Offset = "0x5E345C0", VA = "0x185E35DC0", Slot = "25")]
	public void GJHMJCDBJPJ(INJNNPDEJLM JFIBILKOJPE, float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x5E35910", Offset = "0x5E34110", VA = "0x185E35910", Slot = "26")]
	public void FAHBGNPNBLE(INJNNPDEJLM JFIBILKOJPE, float3 FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5E34370", Offset = "0x5E32B70", VA = "0x185E34370", Slot = "27")]
	[Obsolete("Use GetMassOfSelf or TryGetMassOfHierarchy")]
	public float AIILJLLEEFK(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5E355E0", Offset = "0x5E33DE0", VA = "0x185E355E0", Slot = "28")]
	public float EDDJBNIIFDL(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x5E34D90", Offset = "0x5E33590", VA = "0x185E34D90", Slot = "29")]
	public void CLPJMBCAHEL(INJNNPDEJLM JFIBILKOJPE, float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x5E346C0", Offset = "0x5E32EC0", VA = "0x185E346C0", Slot = "30")]
	public void BJJFOIAAPND(INJNNPDEJLM JFIBILKOJPE, float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5E373E0", Offset = "0x5E35BE0", VA = "0x185E373E0", Slot = "19")]
	public void OBLPJPAJNPG(INJNNPDEJLM JFIBILKOJPE, (Quaternion rot, Vector3 moments) MOGJAEMHOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x5E376A0", Offset = "0x5E35EA0", VA = "0x185E376A0", Slot = "20")]
	public bool PDILMOJNOJI(INJNNPDEJLM JFIBILKOJPE, [Out] quaternion MCLAOGPNEMN, [Out] float3 EBBGOLOKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x5E36F00", Offset = "0x5E35700", VA = "0x185E36F00", Slot = "41")]
	public LKCJDGFAJNM MELCNAHIIGG(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(LKCJDGFAJNM);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5E36490", Offset = "0x5E34C90", VA = "0x185E36490", Slot = "42")]
	public void ILDKOABFJNB(INJNNPDEJLM JFIBILKOJPE, LKCJDGFAJNM FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5E37300", Offset = "0x5E35B00", VA = "0x185E37300", Slot = "66")]
	public void NIDDAEIHJLH(INJNNPDEJLM JFIBILKOJPE, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x5E36F80", Offset = "0x5E35780", VA = "0x185E36F80", Slot = "67")]
	public void MMPPDCNOHBA(INJNNPDEJLM JFIBILKOJPE, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5E36BE0", Offset = "0x5E353E0", VA = "0x185E36BE0", Slot = "68")]
	public bool LHNEIFGKNBL(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5E34270", Offset = "0x5E32A70", VA = "0x185E34270", Slot = "82")]
	public bool AIFLGAACHML(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5E35AE0", Offset = "0x5E342E0", VA = "0x185E35AE0", Slot = "83")]
	public void FOFEDMKFNCA(INJNNPDEJLM JFIBILKOJPE, object KIAKEGJPMAL, bool JMNDFKAOINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x5E36C50", Offset = "0x5E35450", VA = "0x185E36C50", Slot = "84")]
	public void LJIGMFGHCNK(INJNNPDEJLM JFIBILKOJPE, bool BAPEHNBDFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5E36950", Offset = "0x5E35150", VA = "0x185E36950", Slot = "86")]
	public bool KCLBAAONMEK(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5E35570", Offset = "0x5E33D70", VA = "0x185E35570", Slot = "85")]
	public void DNKADIHICCP(INJNNPDEJLM JFIBILKOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x5E34FD0", Offset = "0x5E337D0", VA = "0x185E34FD0", Slot = "43")]
	public bool CPKEAKKBLLC(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x5E37380", Offset = "0x5E35B80", VA = "0x185E37380", Slot = "44")]
	public void NIMJNILPHPF(INJNNPDEJLM JFIBILKOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x5E36E80", Offset = "0x5E35680", VA = "0x185E36E80", Slot = "45")]
	public bool MDHPFMJENHA(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x5E36070", Offset = "0x5E34870", VA = "0x185E36070", Slot = "46")]
	public void HHEKONODBCD(INJNNPDEJLM JFIBILKOJPE, bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x5E367D0", Offset = "0x5E34FD0", VA = "0x185E367D0", Slot = "47")]
	public bool JOEIPDCEKDN(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5E36240", Offset = "0x5E34A40", VA = "0x185E36240", Slot = "48")]
	public void IFFKPHADLJO(INJNNPDEJLM JFIBILKOJPE, bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5E35FF0", Offset = "0x5E347F0", VA = "0x185E35FF0", Slot = "49")]
	public RigidbodyConstraints HGFKHMAJCBA(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(RigidbodyConstraints);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5E35C90", Offset = "0x5E34490", VA = "0x185E35C90", Slot = "50")]
	public void FOLCFPIHOBH(INJNNPDEJLM JFIBILKOJPE, RigidbodyConstraints FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x5E369C0", Offset = "0x5E351C0", VA = "0x185E369C0", Slot = "51")]
	public float KECCIMLPOLB(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5E34550", Offset = "0x5E32D50", VA = "0x185E34550", Slot = "52")]
	public void AOFFKJFPGME(INJNNPDEJLM JFIBILKOJPE, float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5E354F0", Offset = "0x5E33CF0", VA = "0x185E354F0", Slot = "53")]
	public float DMFFKFIPAPN(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5E35880", Offset = "0x5E34080", VA = "0x185E35880", Slot = "54")]
	public void EOKOAKLKBOP(INJNNPDEJLM JFIBILKOJPE, float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x5E345E0", Offset = "0x5E32DE0", VA = "0x185E345E0", Slot = "55")]
	public bool BGNEJLCPODB(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5E344E0", Offset = "0x5E32CE0", VA = "0x185E344E0", Slot = "56")]
	public void ANGEHLCBPAM(INJNNPDEJLM JFIBILKOJPE, bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x5E36CC0", Offset = "0x5E354C0", VA = "0x185E36CC0", Slot = "57")]
	public bool LLOCAPHEGNA(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x5E36B70", Offset = "0x5E35370", VA = "0x185E36B70", Slot = "58")]
	public void LENDPFBNFOG(INJNNPDEJLM JFIBILKOJPE, bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5E34750", Offset = "0x5E32F50", VA = "0x185E34750", Slot = "59")]
	public void BOGFJPENDNM(INJNNPDEJLM JFIBILKOJPE, int FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5E36DF0", Offset = "0x5E355F0", VA = "0x185E36DF0", Slot = "73")]
	public Rigidbody LOHMFBPIOLE(INJNNPDEJLM JFIBILKOJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5E370A0", Offset = "0x5E358A0", VA = "0x185E370A0", Slot = "74")]
	public void MPEMJEJDJIN(INJNNPDEJLM JFIBILKOJPE, Rigidbody FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x5E366B0", Offset = "0x5E34EB0", VA = "0x185E366B0", Slot = "75")]
	public void JBAEFNMGPHP(INJNNPDEJLM JFIBILKOJPE, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5E37010", Offset = "0x5E35810", VA = "0x185E37010", Slot = "76")]
	public void MODGFAKLIIP(INJNNPDEJLM JFIBILKOJPE, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5E37930", Offset = "0x5E36130", VA = "0x185E37930", Slot = "77")]
	public bool PGPBGCLGLAI(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5E378A0", Offset = "0x5E360A0", VA = "0x185E378A0", Slot = "60")]
	public object PGCPBCOAAFB(INJNNPDEJLM JFIBILKOJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x5E353A0", Offset = "0x5E33BA0", VA = "0x185E353A0", Slot = "61")]
	public void DLHPBOCDHMH(INJNNPDEJLM JFIBILKOJPE, object FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x5E34D00", Offset = "0x5E33500", VA = "0x185E34D00", Slot = "62")]
	public object CJNGGCNPDGA(INJNNPDEJLM JFIBILKOJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x5E35130", Offset = "0x5E33930", VA = "0x185E35130", Slot = "63")]
	public void DDNANOBKMLL(INJNNPDEJLM JFIBILKOJPE, object FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x5E35A60", Offset = "0x5E34260", VA = "0x185E35A60", Slot = "64")]
	public float FGBEMAEBHIM(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x5E34110", Offset = "0x5E32910", VA = "0x185E34110", Slot = "65")]
	public void ABMCLIFBNMI(INJNNPDEJLM JFIBILKOJPE, float FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x5E34B80", Offset = "0x5E33380", VA = "0x185E34B80", Slot = "69")]
	public void CDLMKIBLDBI(INJNNPDEJLM JFIBILKOJPE, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x5E36AE0", Offset = "0x5E352E0", VA = "0x185E36AE0", Slot = "70")]
	public void KNENJJNLFKP(INJNNPDEJLM JFIBILKOJPE, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x5E36520", Offset = "0x5E34D20", VA = "0x185E36520", Slot = "71")]
	public bool INDKDJNDLJF(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5E34660", Offset = "0x5E32E60", VA = "0x185E34660", Slot = "21")]
	public void BIMPIIKAPHE(INJNNPDEJLM JFIBILKOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5E34900", Offset = "0x5E33100", VA = "0x185E34900", Slot = "22")]
	public void CCEMEMOBIMK(INJNNPDEJLM JFIBILKOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5E35320", Offset = "0x5E33B20", VA = "0x185E35320", Slot = "72")]
	public bool DGJJKNPHDBA(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5E36390", Offset = "0x5E34B90", VA = "0x185E36390", Slot = "78")]
	public void IIMPAJAOGEO(INJNNPDEJLM JFIBILKOJPE, float3 NOCGKJGODHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x5E36850", Offset = "0x5E35050", VA = "0x185E36850", Slot = "79")]
	public void KCAMIPHOOCP(INJNNPDEJLM JFIBILKOJPE, float3 NMAGMMAOJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x5E34F80", Offset = "0x5E33780", VA = "0x185E34F80", Slot = "80")]
	public bool CPBJNHGJFMM(INJNNPDEJLM JFIBILKOJPE, [Out] float3 NOCGKJGODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x5E34CB0", Offset = "0x5E334B0", VA = "0x185E34CB0", Slot = "81")]
	public bool CJEENCIGOMH(INJNNPDEJLM JFIBILKOJPE, [Out] float3 NMAGMMAOJAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x5E34C00", Offset = "0x5E33400", VA = "0x185E34C00")]
	private DynamicBuffer<Entity> CHAMMCDDKDJ(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x5E36D40", Offset = "0x5E35540", VA = "0x185E36D40")]
	private DynamicBuffer<Entity> LNKPBEIAMJH(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x239AE20", Offset = "0x2399620", VA = "0x18239AE20")]
	private void FLMLMHIJGHD<T>(INJNNPDEJLM JFIBILKOJPE, object FKKGMPDEPMA, Func<object, T> PPECMLCFPKG) where T : class, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public IOMNCCFBNHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[PHKIPGBLCCH(PJHIMKBCGDP.LoadInstance)]
[DEONFKEHMJD(typeof(JAGAAHOHNNB), new string[] { })]
public class JAGAAHOHNNB : GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class ADELNGOAHEN : IEnumerable<BOFNPIGFHNE>, IEnumerable, IEnumerator<BOFNPIGFHNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private BOFNPIGFHNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public JAGAAHOHNNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public NativeArray<Entity> <>3__entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private EntityManager <entityManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private NativeArray<Entity>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		private BOFNPIGFHNE System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x86AE20", Offset = "0x869620", VA = "0x18086AE20")]
		[DebuggerHidden]
		public ADELNGOAHEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5E41A70", Offset = "0x5E40270", VA = "0x185E41A70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5E416F0", Offset = "0x5E3FEF0", VA = "0x185E416F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x5E41920", Offset = "0x5E40120", VA = "0x185E41920")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x5E41A20", Offset = "0x5E40220", VA = "0x185E41A20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x5E41970", Offset = "0x5E40170", VA = "0x185E41970", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BOFNPIGFHNE> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5E41970", Offset = "0x5E40170", VA = "0x185E41970", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> NLCAMCOFPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x5E53490", Offset = "0x5E51C90", VA = "0x185E53490", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x5E53330", Offset = "0x5E51B30", VA = "0x185E53330")]
	public void EAIDLINDAII(NativeArray<Entity> FAIFKAKJOPP, bool OKMKNIJCJAO, bool HPDBEIBMALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x5E53570", Offset = "0x5E51D70", VA = "0x185E53570")]
	public void MLJBOBEEFIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5E529B0", Offset = "0x5E511B0", VA = "0x185E529B0")]
	private void AJNNAJENCHN(NativeArray<Entity> FAIFKAKJOPP, bool OKMKNIJCJAO, bool HPDBEIBMALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x5E534E0", Offset = "0x5E51CE0", VA = "0x185E534E0")]
	[IteratorStateMachine(typeof(ADELNGOAHEN))]
	private IEnumerable<BOFNPIGFHNE> KOHLCPHEGPC(NativeArray<Entity> FAIFKAKJOPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x5E531C0", Offset = "0x5E519C0", VA = "0x185E531C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x5E53840", Offset = "0x5E52040", VA = "0x185E53840")]
	public JAGAAHOHNNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[DEONFKEHMJD(typeof(CGJJOCFJIKF), new string[] { })]
public class AGHAPDGCPPC : CGJJOCFJIKF, GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class POECGPALECI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public List<CapsuleCollider> KOEGEADFDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public List<SphereCollider> FPDJEGFJPLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public GameObject IGFGHCDNJDA;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A620", Offset = "0x5E58E20", VA = "0x185E5A620")]
		public POECGPALECI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[NMIHDJKFGCM]
	private LDNONJHJNKB GDDMPKMBLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[NMIHDJKFGCM]
	private JLPKDNBELME CFKOJHMGIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<Entity, POECGPALECI> NKDLILBFNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private GameObject APHKAGANALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private GameObject HALKKDJCHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private GameObject DNDLEIKIPFB;

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private GameObject HPEKEBKECKH
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x5E424A0", Offset = "0x5E40CA0", VA = "0x185E424A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5E42720", Offset = "0x5E40F20", VA = "0x185E42720", Slot = "6")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5E42260", Offset = "0x5E40A60", VA = "0x185E42260", Slot = "4")]
	public void EFOLMJIMOHM(Entity HEMBEFIBMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5E42790", Offset = "0x5E40F90", VA = "0x185E42790", Slot = "5")]
	public void KHNFLMFNGGI(Entity HEMBEFIBMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5E42140", Offset = "0x5E40940", VA = "0x185E42140", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x5E43830", Offset = "0x5E42030", VA = "0x185E43830")]
	private POECGPALECI PLLHBHGPCLH(Entity HEMBEFIBMKH, BKFLOKEAPNO JBJEFMHIIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x5E42CE0", Offset = "0x5E414E0", VA = "0x185E42CE0")]
	private void OGAAPNGHEOD(BKFLOKEAPNO JBJEFMHIIMG, POECGPALECI ENGEEPMGIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x5E41F60", Offset = "0x5E40760", VA = "0x185E41F60")]
	private void DEKFIDJDEAD(BKFLOKEAPNO JBJEFMHIIMG, POECGPALECI ENGEEPMGIDP, int NNFMPDGKKKO, Vector3 MCLBBPPAHAP, Quaternion OHMBDAJNEIJ, float PNEBFNHCLKM, float ICNNOLEOCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x5E42560", Offset = "0x5E40D60", VA = "0x185E42560")]
	private void IIJFPBNNOHN(POECGPALECI ENGEEPMGIDP, int IHGGCOPKKNF, Vector3 MCLBBPPAHAP, float PNEBFNHCLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5E41C80", Offset = "0x5E40480", VA = "0x185E41C80")]
	private void DBBHCFCPPKI(BKFLOKEAPNO JBJEFMHIIMG, POECGPALECI ENGEEPMGIDP, int LHIEKFFIGKL, int GIHACFDIMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x29A5920", Offset = "0x29A4120", VA = "0x1829A5920")]
	private T HBOJHBAJOJK<T>(BKFLOKEAPNO JBJEFMHIIMG, GameObject ABPIJCGDOPA, Vector3 ALAOAMBMFBH, Quaternion KCMFIPCJPAM) where T : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x5E43B20", Offset = "0x5E42320", VA = "0x185E43B20")]
	public AGHAPDGCPPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[DEONFKEHMJD(typeof(JDHDACCAMDF), new string[] { })]
public class NKBHGBCKMBP : GJOKPFDLDCJ, FIBMJMMLGPO, JDHDACCAMDF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private KMLALHOKNKB DEIGKNMHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private OGNNNIMMEPN KNCOEFOICAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private GAHJBAOIADM GLKFLDDFJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private AHJKJHLOOJP KJONHFEEEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private int AFLBEKBHACL;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public bool EOOOACJGJND
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E56CD0", Offset = "0x5E554D0", VA = "0x185E56CD0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public INJNNPDEJLM FLJLIMIIGIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E56370", Offset = "0x5E54B70", VA = "0x185E56370", Slot = "9")]
		get
		{
			return default(INJNNPDEJLM);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E56940", Offset = "0x5E55140", VA = "0x185E56940", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public NNONLMNKHJH AAEDHCONLGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E56790", Offset = "0x5E54F90", VA = "0x185E56790", Slot = "11")]
		get
		{
			return default(NNONLMNKHJH);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E56940", Offset = "0x5E55140", VA = "0x185E56940", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private uint DHEOHPLKLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E56460", Offset = "0x5E54C60", VA = "0x185E56460")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event DOLCPJBIBMO CNKMLPJMACA
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5E55FE0", Offset = "0x5E547E0", VA = "0x185E55FE0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5E56C30", Offset = "0x5E55430", VA = "0x185E56C30", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E567C0", Offset = "0x5E54FC0", VA = "0x185E567C0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E56080", Offset = "0x5E54880", VA = "0x185E56080", Slot = "5")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E56280", Offset = "0x5E54A80", VA = "0x185E56280", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E565A0", Offset = "0x5E54DA0", VA = "0x185E565A0")]
	private void GJONPLGOJII(GDGCFENIDIN AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E56390", Offset = "0x5E54B90", VA = "0x185E56390", Slot = "13")]
	public INJNNPDEJLM FEOPONCANLO(INJNNPDEJLM KMJKCJJHEFM, INJNNPDEJLM OPJAPJDAKJE)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E564B0", Offset = "0x5E54CB0", VA = "0x185E564B0", Slot = "14")]
	public bool GFDLEAEGIJN(INJNNPDEJLM KMJKCJJHEFM, INJNNPDEJLM OPJAPJDAKJE, [Out] INJNNPDEJLM BNKDAHKOHOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E56AD0", Offset = "0x5E552D0", VA = "0x185E56AD0", Slot = "15")]
	public void MOFNKJDEHHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E56210", Offset = "0x5E54A10", VA = "0x185E56210", Slot = "16")]
	public void CCOOIHOOFNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E569B0", Offset = "0x5E551B0", VA = "0x185E569B0", Slot = "17")]
	public bool LBBLFMIEGID(INJNNPDEJLM KMJKCJJHEFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E56890", Offset = "0x5E55090", VA = "0x185E56890", Slot = "18")]
	public bool JOONJDAOKBO(INJNNPDEJLM KMJKCJJHEFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E56940", Offset = "0x5E55140", VA = "0x185E56940")]
	private void LJHPDJFKANA(INJNNPDEJLM LPEKLCDBGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NKBHGBCKMBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[DEONFKEHMJD(typeof(KMMJLLOECBC), new string[] { })]
public class BIPNDGLJPBB : GJOKPFDLDCJ, KMMJLLOECBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private EntityManager IDCNBIGHJII;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E43E30", Offset = "0x5E42630", VA = "0x185E43E30", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E43DD0", Offset = "0x5E425D0", VA = "0x185E43DD0", Slot = "5")]
	public void ACJDABGBNIH(INJNNPDEJLM LHIGGCOIHEC, bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2186AF0", Offset = "0x21852F0", VA = "0x182186AF0")]
	private void NLGFMFNDGBJ<T>(INJNNPDEJLM LHIGGCOIHEC, bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public BIPNDGLJPBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DEONFKEHMJD(typeof(ACCFLENNIHP), new string[] { })]
public class MHPDCFJAKEN : GJOKPFDLDCJ, ACCFLENNIHP
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private EntityManager IDCNBIGHJII;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E554C0", Offset = "0x5E53CC0", VA = "0x185E554C0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E55620", Offset = "0x5E53E20", VA = "0x185E55620", Slot = "5")]
	public void NPCKOMFHNPI(INJNNPDEJLM LHIGGCOIHEC, bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E55460", Offset = "0x5E53C60", VA = "0x185E55460", Slot = "6")]
	public void HAPKBDCACLF(INJNNPDEJLM LHIGGCOIHEC, bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E55540", Offset = "0x5E53D40", VA = "0x185E55540", Slot = "7")]
	public void KHLGGLEPOBN(INJNNPDEJLM LHIGGCOIHEC, int FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x2443290", Offset = "0x2441A90", VA = "0x182443290")]
	private void NLGFMFNDGBJ<T>(INJNNPDEJLM LHIGGCOIHEC, bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2443200", Offset = "0x2441A00", VA = "0x182443200")]
	private void NLGFMFNDGBJ<T>(INJNNPDEJLM LHIGGCOIHEC, T AELCABDCBDD) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MHPDCFJAKEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[PHKIPGBLCCH(PJHIMKBCGDP.LoadInstance)]
[DEONFKEHMJD(typeof(HEDLKEMBHHI), new string[] { })]
public class HEDLKEMBHHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Dictionary<IHOKJCEFOEN, string> NHGCCGFDPED;

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D110", Offset = "0x5E4B910", VA = "0x185E4D110")]
	public GameObject DNGPAJMGDLK(IHOKJCEFOEN JNLDJKGHMNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D1E0", Offset = "0x5E4B9E0", VA = "0x185E4D1E0")]
	public HEDLKEMBHHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[PHKIPGBLCCH(PJHIMKBCGDP.LoadInstance)]
[DEONFKEHMJD(typeof(DGDGCOPANOO), new string[] { })]
internal class DGDGCOPANOO : GJOKPFDLDCJ, FIBMJMMLGPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private LJJGONKGMDG DFJLJGOOCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private FAOOFKFDMAN<Entity> OBIIIBPBMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private NHCACALFIKB PEENKKOKGPE;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E49FA0", Offset = "0x5E487A0", VA = "0x185E49FA0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E49DE0", Offset = "0x5E485E0", VA = "0x185E49DE0", Slot = "5")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E49F00", Offset = "0x5E48700", VA = "0x185E49F00", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A010", Offset = "0x5E48810", VA = "0x185E4A010")]
	private void NAGMHIKGHAL(Entity KCMPKMKBCOO, [In] ICHPGDLGCBL HKBFNIGOHGM, [In] ICHPGDLGCBL OPLCONEPBPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DGDGCOPANOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
public class DMHMFBABBGM<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[DefaultMember("Item")]
public class NNCGEAFHOHA<From, To>
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
public class AHKIFABIDHK<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Func<From, To> CHDGBHFLAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Func<To, From> BJNIJFBHFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public NativeArray<From> INLAJDDNHAO;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public To HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x34BCBB0", Offset = "0x34BB3B0", VA = "0x1834BCBB0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x34BCC10", Offset = "0x34BB410", VA = "0x1834BCC10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x34BCBA0", Offset = "0x34BB3A0", VA = "0x1834BCBA0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool BHLLMPIDEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7619F0", Offset = "0x7601F0", VA = "0x1807619F0")]
	public AHKIFABIDHK(Func<From, To> CHDGBHFLAMF, Func<To, From> BJNIJFBHFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x34BC710", Offset = "0x34BAF10", VA = "0x1834BC710", Slot = "11")]
	public void Add(To BBKHFDEMMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x34BC760", Offset = "0x34BAF60", VA = "0x1834BC760", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x34BC7B0", Offset = "0x34BAFB0", VA = "0x1834BC7B0", Slot = "13")]
	public bool Contains(To BBKHFDEMMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x34BC890", Offset = "0x34BB090", VA = "0x1834BC890", Slot = "14")]
	public void CopyTo(To[] INLAJDDNHAO, int ILBHPPPGDPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x34BC950", Offset = "0x34BB150", VA = "0x1834BC950", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x34BCA10", Offset = "0x34BB210", VA = "0x1834BCA10", Slot = "6")]
	public int IndexOf(To BBKHFDEMMEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x34BCAB0", Offset = "0x34BB2B0", VA = "0x1834BCAB0", Slot = "7")]
	public void Insert(int LFEFGCGCIAG, To BBKHFDEMMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x34BCB50", Offset = "0x34BB350", VA = "0x1834BCB50", Slot = "15")]
	public bool Remove(To BBKHFDEMMEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x34BCB00", Offset = "0x34BB300", VA = "0x1834BCB00", Slot = "8")]
	public void RemoveAt(int LFEFGCGCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x322BB10", Offset = "0x322A310", VA = "0x18322BB10", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct HGNJMNOLGEO : IComparable<HGNJMNOLGEO>, IEquatable<HGNJMNOLGEO>
{
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public static readonly HGNJMNOLGEO HEADMFFNPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public AFCHODDKGEA LHIGGCOIHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public OJBFPODPDEH OJNPMCODCBJ;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public bool ODGHFELEPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DA20", Offset = "0x5E4C220", VA = "0x185E4DA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x979D20", Offset = "0x978520", VA = "0x180979D20")]
	public HGNJMNOLGEO(AFCHODDKGEA LHIGGCOIHEC, OJBFPODPDEH OJNPMCODCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D810", Offset = "0x5E4C010", VA = "0x185E4D810", Slot = "4")]
	public int CompareTo(HGNJMNOLGEO IFHFGCDLDEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DA30", Offset = "0x5E4C230", VA = "0x185E4DA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D920", Offset = "0x5E4C120", VA = "0x185E4D920", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D890", Offset = "0x5E4C090", VA = "0x185E4D890", Slot = "5")]
	public bool Equals(HGNJMNOLGEO IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D9B0", Offset = "0x5E4C1B0", VA = "0x185E4D9B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct HIFNMALGGKJ : IEnumerable<HGNJMNOLGEO>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum BCNGAMDOOCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public struct JEEKGJAGAKN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private NativeList<byte> AELCABDCBDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private HIFNMALGGKJ HBKECNHANOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private readonly HGNJMNOLGEO KLIANGHAKAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly int OKLBOBFEAFH;

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E53B00", Offset = "0x5E52300", VA = "0x185E53B00")]
		internal JEEKGJAGAKN(HIFNMALGGKJ HBKECNHANOP, HGNJMNOLGEO KLIANGHAKAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E53970", Offset = "0x5E52170", VA = "0x185E53970", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E538D0", Offset = "0x5E520D0", VA = "0x185E538D0")]
		public void CGEJDGGLIKO(ReadOnlySpan<byte> FKKGMPDEPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E53A60", Offset = "0x5E52260", VA = "0x185E53A60")]
		private void FEJBCIFCIOL(ReadOnlySpan<byte> FKKGMPDEPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E53A00", Offset = "0x5E52200", VA = "0x185E53A00")]
		private unsafe void FEJBCIFCIOL(void* NEBNNPOPPNJ, int HPFMIMMLOKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct KPGJLPLHPGO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private HIFNMALGGKJ HBKECNHANOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private NativeArray<byte> AELCABDCBDD;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E55100", Offset = "0x5E53900", VA = "0x185E55100")]
		internal KPGJLPLHPGO(HIFNMALGGKJ HBKECNHANOP, NativeArray<byte> AELCABDCBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E54F90", Offset = "0x5E53790", VA = "0x185E54F90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E55040", Offset = "0x5E53840", VA = "0x185E55040")]
		public NativeArray<byte> HINDEJJNGBM(int HPFMIMMLOKB)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E54FA0", Offset = "0x5E537A0", VA = "0x185E54FA0")]
		public void FGKAGBCKPMF(Span<byte> FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct KFNAJMJBAKO : IEnumerator<HGNJMNOLGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly NativeList<HGNJMNOLGEO> INLAJDDNHAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int LFEFGCGCIAG;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public HGNJMNOLGEO NPBPBJCHJJL
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x5E54830", Offset = "0x5E53030", VA = "0x185E54830", Slot = "4")]
			get
			{
				return default(HGNJMNOLGEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E547E0", Offset = "0x5E52FE0", VA = "0x185E547E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E54690", Offset = "0x5E52E90", VA = "0x185E54690", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E54790", Offset = "0x5E52F90", VA = "0x185E54790", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private struct FCFCGIPDLCF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private NativeArray<int> AELCABDCBDD;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool HLNECFAPNGC
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x5E4C3C0", Offset = "0x5E4ABC0", VA = "0x185E4C3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public int AOBBJLAOJLH
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x5E4C430", Offset = "0x5E4AC30", VA = "0x185E4C430")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x5E4C320", Offset = "0x5E4AB20", VA = "0x185E4C320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public BCNGAMDOOCP DHJKCIPDPJF
		{
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x5E4C420", Offset = "0x5E4AC20", VA = "0x185E4C420")]
			get
			{
				return default(BCNGAMDOOCP);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x5E4C400", Offset = "0x5E4AC00", VA = "0x185E4C400")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public bool GIMIJEKACIA
		{
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x5E4C300", Offset = "0x5E4AB00", VA = "0x185E4C300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool IHKBBCDAMOH
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x5E4C3A0", Offset = "0x5E4ABA0", VA = "0x185E4C3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C490", Offset = "0x5E4AC90", VA = "0x185E4C490")]
		public FCFCGIPDLCF(BCNGAMDOOCP DOAAFCGOCAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C370", Offset = "0x5E4AB70", VA = "0x185E4C370")]
		private int FBPOFKNEBFB(int GDMKPCJDDGD, int GHCMBOCONMB = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C440", Offset = "0x5E4AC40", VA = "0x185E4C440")]
		private void NLGFMFNDGBJ(int GDMKPCJDDGD, int FKKGMPDEPMA, int GHCMBOCONMB = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C330", Offset = "0x5E4AB30", VA = "0x185E4C330", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static readonly HGNJMNOLGEO DDLEAKODCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeParallelHashMap<HGNJMNOLGEO, int> OPOFBAIIDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeList<HGNJMNOLGEO> CGFCBDPFKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeList<int> DGNOGMIECLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeList<byte> HPJFPNGCNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private NativeList<byte> AELCABDCBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private FCFCGIPDLCF GCMLNHCMFKE;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E510A0", Offset = "0x5E4F8A0", VA = "0x185E510A0")]
	public static HIFNMALGGKJ KLKFANDJKFE(BCNGAMDOOCP DOAAFCGOCAA = BCNGAMDOOCP.Last, int LEMBMOFFBHG = 16, int DEBNKODKMMH = 256)
	{
		return default(HIFNMALGGKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E51460", Offset = "0x5E4FC60", VA = "0x185E51460")]
	private HIFNMALGGKJ(BCNGAMDOOCP DOAAFCGOCAA, int LEMBMOFFBHG, int DEBNKODKMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E50C30", Offset = "0x5E4F430", VA = "0x185E50C30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E50B40", Offset = "0x5E4F340", VA = "0x185E50B40")]
	public JEEKGJAGAKN DFEOEHNLJLO(HGNJMNOLGEO KLIANGHAKAC)
	{
		return default(JEEKGJAGAKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E510E0", Offset = "0x5E4F8E0", VA = "0x185E510E0")]
	public bool MGLDBIOCLGN(HGNJMNOLGEO KLIANGHAKAC, [Out] KPGJLPLHPGO DIBLJPGANBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E50AF0", Offset = "0x5E4F2F0", VA = "0x185E50AF0")]
	public bool CIPCFIDEPIC(HGNJMNOLGEO KLIANGHAKAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E50FA0", Offset = "0x5E4F7A0", VA = "0x185E50FA0")]
	public bool ILOIDKOCOJP(HGNJMNOLGEO KLIANGHAKAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E50930", Offset = "0x5E4F130", VA = "0x185E50930")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E50D30", Offset = "0x5E4F530", VA = "0x185E50D30")]
	private void FIMLMJCIPDM(HGNJMNOLGEO KLIANGHAKAC, int OKLBOBFEAFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E51280", Offset = "0x5E4FA80", VA = "0x185E51280")]
	private void NFLMBPLFMGH(int BENEDPIEKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E50A10", Offset = "0x5E4F210", VA = "0x185E50A10")]
	private void BFIDPFNOJGG(HGNJMNOLGEO KLIANGHAKAC, int OKLBOBFEAFH, int HPFMIMMLOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E513B0", Offset = "0x5E4FBB0", VA = "0x185E513B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E51360", Offset = "0x5E4FB60", VA = "0x185E51360", Slot = "4")]
	private IEnumerator<HGNJMNOLGEO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DefaultMember("Item")]
public class NLEPHDLKIJH<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class MJNNKKCEABN
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class KJPFMACDFFN
{
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class OPHBFJAONBB
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class MHIJFPMGAEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public HMNFMHNMJBH services;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public MHIJFPMGAEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x5E55400", Offset = "0x5E53C00", VA = "0x185E55400")]
		internal void NGFGLBBLPMF(GJOKPFDLDCJ svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5E553A0", Offset = "0x5E53BA0", VA = "0x185E553A0")]
		internal void BCNDFPDMPNE(FIBMJMMLGPO svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5E58CF0", Offset = "0x5E574F0", VA = "0x185E58CF0")]
	public static void HLFIPDIBPLB(this World NMJLCHEIIPL, HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x240E500", Offset = "0x240CD00", VA = "0x18240E500")]
	public static void DMKKKLGLNOI<T>(this World NMJLCHEIIPL, Action<T> OFKGFGLJEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x24E1890", Offset = "0x24E0090", VA = "0x1824E1890")]
	public static void HJLFHGKLCON<T>(this World NMJLCHEIIPL, Action<T> OFKGFGLJEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x24E1A70", Offset = "0x24E0270", VA = "0x1824E1A70")]
	public static void HJLFHGKLCON<T>(IEnumerable<ComponentSystemBase> FOCFONOKHED, Action<T> OFKGFGLJEPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class NJPDBKNEOEO
{
	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5E55F80", Offset = "0x5E54780", VA = "0x185E55F80")]
	public static void GPAIFAKANKE(ComponentSystemBase JPKIBHPPOBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class AIHPOBIPDDG
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class JLEDKPIDDHB
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class BKFIHLNAGPL
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class <<CalculateTransformPath>g__getNames|0>d
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public BKFIHLNAGPL()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class GBGCDKGAKPI
{
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class BDAJGOILANE
{
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class JAFNEHIMENI
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class MOHGEILBJGO
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal static class PJJCKGADKOL
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static readonly ProfilerMarker NDDOCBPOJJI;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static readonly ProfilerMarker AOPELIFBBDA;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5E59B30", Offset = "0x5E58330", VA = "0x185E59B30")]
	public static void KOKMPMBBHDI(this AOCJHGPOFOG CJEADCONOPM, EJMCFOHDECJ ODJEHGDEAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5E59F70", Offset = "0x5E58770", VA = "0x185E59F70")]
	public static void MPDPCEJBMGK(this AOCJHGPOFOG CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A150", Offset = "0x5E58950", VA = "0x185E5A150")]
	private static string[] NDJFKGAHEKN(EJMCFOHDECJ ODJEHGDEAEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5E599D0", Offset = "0x5E581D0", VA = "0x185E599D0")]
	private static bool HJIHHAKCPDA(EJMCFOHDECJ ODJEHGDEAEP, [Out] string[] NFPKCHFBPBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370")]
	private static bool FAGHBGAKLBO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public abstract class PBPPJELHGKF : DEMDKDDLALO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly MethodInfo OPNPCLDIMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly Type[] CCBNPDAGICC;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5E595F0", Offset = "0x5E57DF0", VA = "0x185E595F0")]
	public PBPPJELHGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action KHFIGOAAKKL();

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x5E59420", Offset = "0x5E57C20", VA = "0x185E59420")]
	public MethodInfo GONALHAEKAO(Action OONIIOMBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x5E59460", Offset = "0x5E57C60", VA = "0x185E59460", Slot = "4")]
	public void NJMEIPIEAKJ(Type GFGNPBCFEMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public abstract class NAJEHEJPBKG : PBPPJELHGKF
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private enum JALBOINOHDA
	{

	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x5E55B50", Offset = "0x5E54350", VA = "0x185E55B50", Slot = "5")]
	public override Action KHFIGOAAKKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void EIBOLODONFM<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x5E55BF0", Offset = "0x5E543F0", VA = "0x185E55BF0")]
	[UnityEngine.Scripting.Preserve]
	public void PEHFOBJECOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5E549B0", Offset = "0x5E531B0", VA = "0x185E549B0")]
	protected NAJEHEJPBKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public abstract class KGBKCIMNNJE : PBPPJELHGKF
{
	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5E54880", Offset = "0x5E53080", VA = "0x185E54880", Slot = "5")]
	public override Action KHFIGOAAKKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void IFDCKGHDNHC<T>() where T : AHHAJJLHJMC;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5E54920", Offset = "0x5E53120", VA = "0x185E54920")]
	[UnityEngine.Scripting.Preserve]
	public void PEHFOBJECOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5E549B0", Offset = "0x5E531B0", VA = "0x185E549B0")]
	protected KGBKCIMNNJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public abstract class NHHCHDCKFOE : PBPPJELHGKF
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5E55C80", Offset = "0x5E54480", VA = "0x185E55C80", Slot = "5")]
	public override Action KHFIGOAAKKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void MPNPDIBILMP<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5E55D20", Offset = "0x5E54520", VA = "0x185E55D20")]
	[UnityEngine.Scripting.Preserve]
	public void PEHFOBJECOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5E549B0", Offset = "0x5E531B0", VA = "0x185E549B0")]
	protected NHHCHDCKFOE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct KDMCILFKCEH : ISystem
{
	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "4")]
	public void OnCreate(SystemState CDOGIGHJFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
	public void OnDestroy(SystemState CDOGIGHJFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x5E54060", Offset = "0x5E52860", VA = "0x185E54060", Slot = "6")]
	public void OnUpdate(SystemState CDOGIGHJFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void BLEAKPFKHMN(IntPtr AFFJMIFONEM, IntPtr CDOGIGHJFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5E54060", Offset = "0x5E52860", VA = "0x185E54060")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void PEDJFALNADP(IntPtr AFFJMIFONEM, IntPtr CDOGIGHJFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void LBCOOHMLNOO(IntPtr AFFJMIFONEM, IntPtr CDOGIGHJFKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class AEMLPEHNMOA
{
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public static readonly ComponentType[] GJJFNDBDPME;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5E41B00", Offset = "0x5E40300", VA = "0x185E41B00")]
	public static Entity NCGJMKLAAPO(this EntityManager IDCNBIGHJII)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class DICAKBBPLDM
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class BLOACBGDEIF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class CHLHIEBMHLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class PCJKMBCFKJA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A6D0", Offset = "0x5E48ED0", VA = "0x185E4A6D0")]
	public static Entity EGONCFMPDMD(this EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ADE0", Offset = "0x5E495E0", VA = "0x185E4ADE0")]
	public static DynamicBuffer<ChildrenData> LNKPBEIAMJH(this EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(DynamicBuffer<ChildrenData>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ABE0", Offset = "0x5E493E0", VA = "0x185E4ABE0")]
	public static bool JIMOOAMDFMM(this EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, Allocator JONICLHJBEP, [Out] NativeArray<Entity> CIDEEPJLIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AFA0", Offset = "0x5E497A0", VA = "0x185E4AFA0")]
	public static NativeArray<Entity> MJBBNEHCIKG(this EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A1E0", Offset = "0x5E489E0", VA = "0x185E4A1E0")]
	public static int AEDBNOCDBMA(this EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B240", Offset = "0x5E49A40", VA = "0x185E4B240")]
	public static void OFIAHNECNHL(NativeArray<Entity> DAGCPHCNFMP, NativeArray<Entity> NLFNHIPAONL, EntityManager IDCNBIGHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AA10", Offset = "0x5E49210", VA = "0x185E4AA10")]
	public static bool JDBAHLMABOE(this EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, Entity KNHMPHIEBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A310", Offset = "0x5E48B10", VA = "0x185E4A310")]
	public static bool BGGKKFIEAIB(this EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, Entity BIANJFLNPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A510", Offset = "0x5E48D10", VA = "0x185E4A510")]
	public static NativeList<Entity> EEJFNBPAIKC(this EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, bool CCLNIANCLOD = false, Allocator JONICLHJBEP = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ACB0", Offset = "0x5E494B0", VA = "0x185E4ACB0")]
	public static Entity KHJHAPEDKKI(this EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A740", Offset = "0x5E48F40", VA = "0x185E4A740")]
	public static bool GFDLEAEGIJN(this EntityManager IDCNBIGHJII, Entity KMJKCJJHEFM, Entity OPJAPJDAKJE, [Out] Entity IDPGKMKGGFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B120", Offset = "0x5E49920", VA = "0x185E4B120")]
	internal static void MOLNOOEMGAP(EntityManager IDCNBIGHJII, Entity OBIIIBPBMLD, Entity EFKEIDIJBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AE70", Offset = "0x5E49670", VA = "0x185E4AE70")]
	private static bool MAOLLAPACMH(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, Entity KNHMPHIEBND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[DEONFKEHMJD(typeof(MDBFMIJPAEP), new string[] { })]
internal sealed class GNDOOCNKHNC : MDBFMIJPAEP, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	[NMIHDJKFGCM]
	private EJDAAEMCDOG HOILBIPFMOB;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public FKIGDGGLJEI.EDLGDKFEDAM.CIBJDJHAALG PICOLJKLHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CFE0", Offset = "0x5E4B7E0", VA = "0x185E4CFE0", Slot = "4")]
		get
		{
			return default(FKIGDGGLJEI.EDLGDKFEDAM.CIBJDJHAALG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D050", Offset = "0x5E4B850", VA = "0x185E4D050", Slot = "5")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public GNDOOCNKHNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal class HHDNGHCNBAE
{
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private static readonly DGJIKJLGCCH KKMCJGKMCPD;

	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private static readonly DGJIKJLGCCH LODPDBADFHI;

	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private static readonly ProfilerMarker FFFDDNHMCLM;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly ProfilerMarker MPJBINBPLFA;

	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private static readonly ProfilerMarker DALCOHHCBMJ;

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private static readonly ProfilerMarker LCCNJILBNAJ;

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly ProfilerMarker DICOOFKFFAP;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly ProfilerMarker KIDKHPIECPI;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static readonly ProfilerMarker OKBBBFPHDPH;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static readonly ProfilerMarker HAFBPPFHOBO;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly ProfilerMarker IIGEGOCDLHO;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static readonly ProfilerMarker ACOHLMNPICK;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly ProfilerMarker CLPBKNNCMCG;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static readonly ProfilerMarker JDBOBDNLFGF;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly ProfilerMarker BOMLPJGGKAP;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly ProfilerMarker BMCCPFKFEFC;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static readonly ProfilerMarker ALBFCFOCIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly EJBGDMGEEID DLDINMNGBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly ByteString KDMODAMJKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly AOCJHGPOFOG CJEADCONOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly ONABCELCNNN AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private readonly FNIJCGNLDDI OBMAIIIIGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly LNJCPDCPJDF CGFCBDPFKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly JINDNJAHDBB JJAPIFKIFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly TaskCompletionSource<bool> LPGJFJPDIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly LAFAPIMFLLP GCMLNHCMFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly DOOFOCFIFEA.HACFKPOHBJA DDKPEFPFKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private EHJKEAAEBEM GELPBCGEMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private PCPJLBDGAPJ CJGLLKCJNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private FKIGDGGLJEI OGMMBNFIOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private KMBBFJPCIKF MHHPBFKFIAK;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Action GJGKAMOGMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x818210", Offset = "0x816A10", VA = "0x180818210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6630", Offset = "0x8B4E30", VA = "0x1808B6630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Action OPIDDBIAFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x8B6360", Offset = "0x8B4B60", VA = "0x1808B6360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8B65D0", Offset = "0x8B4DD0", VA = "0x1808B65D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Action GFIDHDNIAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x768290", Offset = "0x766A90", VA = "0x180768290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x768270", Offset = "0x766A70", VA = "0x180768270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public IEnumerable<KFOICHFNJOO> PNCLFKBJJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAD0", Offset = "0x7DC2D0", VA = "0x1807DDAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x7DDAE0", Offset = "0x7DC2E0", VA = "0x1807DDAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public HAFKINAIAFI JCFECJBLHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DC60", Offset = "0x5E4C460", VA = "0x185E4DC60")]
		[CompilerGenerated]
		get
		{
			return default(HAFKINAIAFI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E410", Offset = "0x5E4CC10", VA = "0x185E4E410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public KMBBFJPCIKF ADOAPDJKHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x8B6350", Offset = "0x8B4B50", VA = "0x1808B6350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public CKHELBILLOJ BIPJJILOIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x19F54A0", Offset = "0x19F3CA0", VA = "0x1819F54A0")]
		get
		{
			return default(CKHELBILLOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public LocalId MLDLDJMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DE70", Offset = "0x5E4C670", VA = "0x185E4DE70")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Task CFKJAPPNFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DAF0", Offset = "0x5E4C2F0", VA = "0x185E4DAF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5E50660", Offset = "0x5E4EE60", VA = "0x185E50660")]
	public HHDNGHCNBAE(ByteString KDMODAMJKPD, CKHELBILLOJ PGFPHILIMMC, [In] LAFAPIMFLLP GCMLNHCMFKE, AOCJHGPOFOG CJEADCONOPM, FPGIHDDJKFI GJIOGBCNNCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DEA0", Offset = "0x5E4C6A0", VA = "0x185E4DEA0")]
	public void FILLLFKPAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E8C0", Offset = "0x5E4D0C0", VA = "0x185E4E8C0")]
	public bool HPKKAMDMNCC(CKHELBILLOJ KMJKCJJHEFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EC80", Offset = "0x5E4D480", VA = "0x185E4EC80")]
	private bool KKPKBFCGAGJ(CKHELBILLOJ CLBAKDLDGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F700", Offset = "0x5E4DF00", VA = "0x185E4F700")]
	private void ODNHCGHGOLP(CKHELBILLOJ HIBOODELAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E950", Offset = "0x5E4D150", VA = "0x185E4E950")]
	private bool IFLPMJEGDBB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F250", Offset = "0x5E4DA50", VA = "0x185E4F250")]
	public bool LNIKKLPDMFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E440", Offset = "0x5E4CC40", VA = "0x185E4E440")]
	private bool HIDPGIEJBCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DFE0", Offset = "0x5E4C7E0", VA = "0x185E4DFE0")]
	private bool HEKKEHGIPGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F3B0", Offset = "0x5E4DBB0", VA = "0x185E4F3B0")]
	private bool MPJPLOGNJKK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DF80", Offset = "0x5E4C780", VA = "0x185E4DF80")]
	private bool GBBFMNDDGDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F5C0", Offset = "0x5E4DDC0", VA = "0x185E4F5C0")]
	private bool NJEGKDDDPJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F970", Offset = "0x5E4E170", VA = "0x185E4F970")]
	public void PKLJGBLBFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DFB0", Offset = "0x5E4C7B0", VA = "0x185E4DFB0")]
	[CompilerGenerated]
	private void GDPNDAIHJNI(CKHELBILLOJ CLBAKDLDGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F100", Offset = "0x5E4D900", VA = "0x185E4F100")]
	[CompilerGenerated]
	private bool LMFIPFKMOAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FDC0", Offset = "0x5E4E5C0", VA = "0x185E4FDC0")]
	[CompilerGenerated]
	private void PPIBDHMGOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DB30", Offset = "0x5E4C330", VA = "0x185E4DB30")]
	[CompilerGenerated]
	private World AEHCMHIBHEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E790", Offset = "0x5E4CF90", VA = "0x185E4E790")]
	[CompilerGenerated]
	private void HMPPOPJEACI(World AFKBGDFEBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E2B0", Offset = "0x5E4CAB0", VA = "0x185E4E2B0")]
	[CompilerGenerated]
	private int HGJIBIBPDBJ(World AFKBGDFEBKJ, ByteString KDMODAMJKPD, FKIGDGGLJEI.EDLGDKFEDAM.CIBJDJHAALG IFOEKNINMPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DC90", Offset = "0x5E4C490", VA = "0x185E4DC90")]
	[CompilerGenerated]
	private void APJCIIAFCBC(World NMJLCHEIIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EF50", Offset = "0x5E4D750", VA = "0x185E4EF50")]
	[CompilerGenerated]
	internal static AHNIAPDEIDG LHIANPPBGKO(EntityManager IKHIDFBMDPA, EntityManager GJEJKMCDBAK, int DKPGAAMNHOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EB70", Offset = "0x5E4D370", VA = "0x185E4EB70")]
	[CompilerGenerated]
	private void JPCILBDKMPD(KMBBFJPCIKF MHHPBFKFIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F7B0", Offset = "0x5E4DFB0", VA = "0x185E4F7B0")]
	[CompilerGenerated]
	private void PCLHOOBCIBM(EntityManager IDCNBIGHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F4C0", Offset = "0x5E4DCC0", VA = "0x185E4F4C0")]
	[CompilerGenerated]
	private void NBNAEBKLAML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DE80", Offset = "0x5E4C680", VA = "0x185E4DE80")]
	[CompilerGenerated]
	private void EILGEPMODLF(string HNHMJGCODBA, EntityManager IDCNBIGHJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E8E0", Offset = "0x5E4D0E0", VA = "0x185E4E8E0")]
	[CompilerGenerated]
	private JLLEMCAIFLB<LAFAPIMFLLP> IFCNKKLFKFP(EntityManager IDCNBIGHJII)
	{
		return default(JLLEMCAIFLB<LAFAPIMFLLP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal class EJBGDMGEEID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private enum JIEPJODOHOO
	{
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		Running,
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		Disposed
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class NIKPEGIHNJF : IEnumerable<CKHELBILLOJ>, IEnumerable, IEnumerator<CKHELBILLOJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private CKHELBILLOJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public EJBGDMGEEID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private CKHELBILLOJ target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public CKHELBILLOJ <>3__target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private int <allowedTarget>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		private CKHELBILLOJ System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Serialization.DeserializePhases>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x8C9910", Offset = "0x8C8110", VA = "0x1808C9910", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CKHELBILLOJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x5E55F30", Offset = "0x5E54730", VA = "0x185E55F30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xCBFD00", Offset = "0xCBE500", VA = "0x180CBFD00")]
		[DebuggerHidden]
		public NIKPEGIHNJF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x5E55DB0", Offset = "0x5E545B0", VA = "0x185E55DB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x5E55EE0", Offset = "0x5E546E0", VA = "0x185E55EE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x5E55E30", Offset = "0x5E54630", VA = "0x185E55E30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CKHELBILLOJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Serialization.DeserializePhases>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x5E55E30", Offset = "0x5E54630", VA = "0x185E55E30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class ILGLLMHOBHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public CKHELBILLOJ phase;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ILGLLMHOBHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x5E52850", Offset = "0x5E51050", VA = "0x185E52850")]
		internal object MCLFCJLOGND(CKHELBILLOJ a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly DGJIKJLGCCH LODPDBADFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly CKHELBILLOJ PGFPHILIMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Func<CKHELBILLOJ, bool> PMOGHBLBNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private readonly Action<CKHELBILLOJ> GEJJAGFKLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private int GCBNOKOAAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private JIEPJODOHOO CDOGIGHJFKJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public CKHELBILLOJ BIPJJILOIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
		get
		{
			return default(CKHELBILLOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool AMDAEMPIIPG
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B7B0", Offset = "0x5E49FB0", VA = "0x185E4B7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BC50", Offset = "0x5E4A450", VA = "0x185E4BC50")]
	public EJBGDMGEEID(CKHELBILLOJ PGFPHILIMMC, Func<CKHELBILLOJ, bool> PMOGHBLBNGL, Action<CKHELBILLOJ> GEJJAGFKLJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B720", Offset = "0x5E49F20", VA = "0x185E4B720")]
	[IteratorStateMachine(typeof(NIKPEGIHNJF))]
	private IEnumerable<CKHELBILLOJ> GFCGEDAJPGK(CKHELBILLOJ KMJKCJJHEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B7C0", Offset = "0x5E49FC0", VA = "0x185E4B7C0")]
	public bool HPKKAMDMNCC(CKHELBILLOJ KMJKCJJHEFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BB50", Offset = "0x5E4A350", VA = "0x185E4BB50")]
	private void PJCBOPOMMKH(CKHELBILLOJ CLBAKDLDGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C720", Offset = "0x5E2AF20", VA = "0x185E2C720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class BMGAPGBMDDE : MOKNKNAAMMF, FPGIHDDJKFI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private readonly HHDNGHCNBAE NFBNNCDBMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private readonly LKNNFAHLOJG AJBGICFOANP;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public NFPDFHOMGOB FMBBHHCBEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public LocalId PIEHCHMIEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x5E43FC0", Offset = "0x5E427C0", VA = "0x185E43FC0", Slot = "9")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Task CFKJAPPNFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x5E43EB0", Offset = "0x5E426B0", VA = "0x185E43EB0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public IEnumerable<KFOICHFNJOO> PNCLFKBJJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x5E43F60", Offset = "0x5E42760", VA = "0x185E43F60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public HAFKINAIAFI JCFECJBLHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x5E43F00", Offset = "0x5E42700", VA = "0x185E43F00", Slot = "8")]
		get
		{
			return default(HAFKINAIAFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public KMBBFJPCIKF LCHEPGNNLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x5E43FF0", Offset = "0x5E427F0", VA = "0x185E43FF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x5E44060", Offset = "0x5E42860", VA = "0x185E44060")]
	public BMGAPGBMDDE(ByteString KDMODAMJKPD, NFPDFHOMGOB LPEIBOJJIJK, [In] LAFAPIMFLLP GCMLNHCMFKE, AOCJHGPOFOG CJEADCONOPM, Action CBPCANBMLCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5E44010", Offset = "0x5E42810", VA = "0x185E44010", Slot = "5")]
	public void MFGPHFHEOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5E43F90", Offset = "0x5E42790", VA = "0x185E43F90", Slot = "12")]
	public bool HPKKAMDMNCC(CKHELBILLOJ CLBAKDLDGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5E44040", Offset = "0x5E42840", VA = "0x185E44040", Slot = "6")]
	public void PKLJGBLBFBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5E43F40", Offset = "0x5E42740", VA = "0x185E43F40", Slot = "13")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal class NKLLFPFPBAC : CKLPPCFCCOB, FPGIHDDJKFI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly HHDNGHCNBAE NFBNNCDBMIA;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public LocalId PIEHCHMIEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x5E56D00", Offset = "0x5E55500", VA = "0x185E56D00", Slot = "6")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public IEnumerable<KFOICHFNJOO> PNCLFKBJJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x5E43F60", Offset = "0x5E42760", VA = "0x185E43F60", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public HAFKINAIAFI JCFECJBLHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x5E43F00", Offset = "0x5E42700", VA = "0x185E43F00", Slot = "5")]
		get
		{
			return default(HAFKINAIAFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task CFKJAPPNFJI
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x5E43EB0", Offset = "0x5E426B0", VA = "0x185E43EB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public KMBBFJPCIKF LCHEPGNNLMG
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x5E43FF0", Offset = "0x5E427F0", VA = "0x185E43FF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5E56D10", Offset = "0x5E55510", VA = "0x185E56D10")]
	public NKLLFPFPBAC(ByteString KDMODAMJKPD, AOCJHGPOFOG CJEADCONOPM, Action EEPNKIGEHJL, Action MNHHIIBNMCJ, Action CBPCANBMLCP, bool GAHJJIMMEPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5E43F90", Offset = "0x5E42790", VA = "0x185E43F90", Slot = "9")]
	public bool HPKKAMDMNCC(CKHELBILLOJ CLBAKDLDGPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5E43F40", Offset = "0x5E42740", VA = "0x185E43F40", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal struct LAFAPIMFLLP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public DDNODGNMOKA DDEEHHNBOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public Entity OBIIIBPBMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public MGIFFONGDGI AMKPPIJBFNG;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static readonly KEBFNKMCAKC<LAFAPIMFLLP> MHFKJLABGMI;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal class JLLEAEHLNAG : MGOIFNPCOHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public KMBBFJPCIKF ADOAPDJKHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x5E53F80", Offset = "0x5E52780", VA = "0x185E53F80", Slot = "5")]
	public ByteString DLFBMNIIFKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x5E53FE0", Offset = "0x5E527E0", VA = "0x185E53FE0")]
	public JLLEAEHLNAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[PHKIPGBLCCH(PJHIMKBCGDP.Application)]
public interface MDBFMIJPAEP
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	FKIGDGGLJEI.EDLGDKFEDAM.CIBJDJHAALG PICOLJKLHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal abstract class DAKNOFFHMIB : MGOIFNPCOHN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly ProfilerMarker DALCOHHCBMJ;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly ProfilerMarker DMDGAGOOCNE;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly ProfilerMarker LCCNJILBNAJ;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly ProfilerMarker EOEBIBPCGEE;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ProfilerMarker KIDKHPIECPI;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly ProfilerMarker FMBHFCIBCJN;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly ProfilerMarker EBFOGCEPBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly AOCJHGPOFOG CJEADCONOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly EHJKEAAEBEM GELPBCGEMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly JINDNJAHDBB JJAPIFKIFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly LNJCPDCPJDF CGFCBDPFKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly DGJIKJLGCCH LODPDBADFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly DOOFOCFIFEA.HACFKPOHBJA DDKPEFPFKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private World DCAIOJLKBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private KMBBFJPCIKF MHHPBFKFIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private IDisposable FLOMDOKHHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private ByteString FAGMJCBLBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private FKIGDGGLJEI.EDLGDKFEDAM.CIBJDJHAALG KJGBEIAEMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private bool FPMGFDEKPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private NOBCMIJEINK NKAPFCJKAJI;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	protected World ILEJCDDLBOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x761C00", Offset = "0x760400", VA = "0x180761C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	protected World PANADLMAEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x5E46A20", Offset = "0x5E45220", VA = "0x185E46A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public KMBBFJPCIKF ADOAPDJKHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x761C30", Offset = "0x760430", VA = "0x180761C30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5E477E0", Offset = "0x5E45FE0", VA = "0x185E477E0")]
	public DAKNOFFHMIB(AOCJHGPOFOG CJEADCONOPM, DGJIKJLGCCH KFIEDGIKACP, DGJIKJLGCCH LODPDBADFHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x5E46940", Offset = "0x5E45140", VA = "0x185E46940", Slot = "5")]
	public ByteString DLFBMNIIFKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x5E46B30", Offset = "0x5E45330", VA = "0x185E46B30", Slot = "7")]
	public void MFGPHFHEOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x5E469C0", Offset = "0x5E451C0", VA = "0x185E469C0", Slot = "8")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x5E46A70", Offset = "0x5E45270", VA = "0x185E46A70", Slot = "9")]
	protected virtual GEEPPKCNEDM LIIPALOEPBP()
	{
		return default(GEEPPKCNEDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void EKDJDJNPHII();

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract NativeArray<EntityRemapUtility.EntityRemapInfo> DDEHHOEHOBP(NativeArray<EntityRemapUtility.EntityRemapInfo> LGFNILFLECB);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[EFBINMDOMDB]
internal struct GEEPPKCNEDM : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public DDNODGNMOKA AMGKMBAIPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public PAHOLCOMLMM AMKPPIJBFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public FKIGDGGLJEI.EDLGDKFEDAM.CIBJDJHAALG IFOEKNINMPE;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly KEBFNKMCAKC<GEEPPKCNEDM> MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CDB0", Offset = "0x5E4B5B0", VA = "0x185E4CDB0")]
	public static GEEPPKCNEDM AHPBOJHMGDK([In] DDNODGNMOKA AMGKMBAIPAJ)
	{
		return default(GEEPPKCNEDM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class EPJKGKNKDMI : DAKNOFFHMIB
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static readonly DGJIKJLGCCH LODPDBADFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly GEEPPKCNEDM GCMLNHCMFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private NativeList<Entity> DAMOHMICNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private NativeArray<Entity> JINHBKCFLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> PCPJLCGPDGN;

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C140", Offset = "0x5E4A940", VA = "0x185E4C140")]
	public EPJKGKNKDMI(IEnumerable<INJNNPDEJLM> CEMOLHELFPB, [In] GEEPPKCNEDM GCMLNHCMFKE, AOCJHGPOFOG CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C050", Offset = "0x5E4A850", VA = "0x185E4C050", Slot = "9")]
	protected override GEEPPKCNEDM LIIPALOEPBP()
	{
		return default(GEEPPKCNEDM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BEC0", Offset = "0x5E4A6C0", VA = "0x185E4BEC0", Slot = "10")]
	protected override void EKDJDJNPHII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BCC0", Offset = "0x5E4A4C0", VA = "0x185E4BCC0", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> DDEHHOEHOBP(NativeArray<EntityRemapUtility.EntityRemapInfo> LGFNILFLECB)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BE10", Offset = "0x5E4A610", VA = "0x185E4BE10", Slot = "8")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class CIBDAJLGIKB : DAKNOFFHMIB
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private static readonly DGJIKJLGCCH LODPDBADFHI;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E454D0", Offset = "0x5E43CD0", VA = "0x185E454D0")]
	public CIBDAJLGIKB(AOCJHGPOFOG CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E45360", Offset = "0x5E43B60", VA = "0x185E45360", Slot = "10")]
	protected override void EKDJDJNPHII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0xD6A330", Offset = "0xD68B30", VA = "0x180D6A330", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> DDEHHOEHOBP(NativeArray<EntityRemapUtility.EntityRemapInfo> LGFNILFLECB)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class CHHHIFMJDLA
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E452A0", Offset = "0x5E43AA0", VA = "0x185E452A0")]
	public static DOOFOCFIFEA.HACFKPOHBJA IDHEFLLGMBB(AOCJHGPOFOG CJEADCONOPM)
	{
		return default(DOOFOCFIFEA.HACFKPOHBJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E44FA0", Offset = "0x5E437A0", VA = "0x185E44FA0")]
	public static NativeList<Entity> GCILJFKPGIE(EntityManager IDCNBIGHJII, IEnumerable<INJNNPDEJLM> CEMOLHELFPB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E44EF0", Offset = "0x5E436F0", VA = "0x185E44EF0")]
	public static void DDEHHOEHOBP(NativeArray<Entity> JINHBKCFLGE, NativeList<Entity> DAMOHMICNCK, NativeArray<EntityRemapUtility.EntityRemapInfo> LGFNILFLECB, NativeArray<EntityRemapUtility.EntityRemapInfo> PCPJLCGPDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x21F09E0", Offset = "0x21EF1E0", VA = "0x1821F09E0")]
	public static Entity GDNIFJPMFBN<T>(EntityManager IDCNBIGHJII, [In] T FKKGMPDEPMA) where T : struct, IComponentData
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class EHIDKHFPOLD
{
	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B670", Offset = "0x5E49E70", VA = "0x185E4B670")]
	public static DDNODGNMOKA PBMPOOHOBJM(NNONLMNKHJH OBIIIBPBMLD)
	{
		return default(DDNODGNMOKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct JLLEMCAIFLB<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private EntityManager IDCNBIGHJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Entity LIBACJIJEIM;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x3819020", Offset = "0x3817820", VA = "0x183819020")]
	public JLLEMCAIFLB(EntityManager IDCNBIGHJII, [In] T GCMLNHCMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x3818F60", Offset = "0x3817760", VA = "0x183818F60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[DEONFKEHMJD(typeof(JKEGAAHHGLK), new string[] { })]
public class PMJMHOMBAAL : JKEGAAHHGLK, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public BFGGNHMHFPC HGHIDMGNKKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x766300", Offset = "0x764B00", VA = "0x180766300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private FAKFCMGGDPE NJHCJGDIADH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x766130", Offset = "0x764930", VA = "0x180766130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private FGKEDJEKEGI HPECLGBDBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x7662F0", Offset = "0x764AF0", VA = "0x1807662F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	private IPADCDPAMLC IOJDNHMNDNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x766120", Offset = "0x764920", VA = "0x180766120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public HKIHKIGHNML MNICCBIOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x76BD00", Offset = "0x76A500", VA = "0x18076BD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public DMFKDGGILDO IHAICJCJPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x76E4B0", Offset = "0x76CCB0", VA = "0x18076E4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public GDGADODNMPD KCLLMOHFPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x766140", Offset = "0x764940", VA = "0x180766140", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x766310", Offset = "0x764B10", VA = "0x180766310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public EKBPLICOMHJ IKNDOMLNBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x768D80", Offset = "0x767580", VA = "0x180768D80", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x768E00", Offset = "0x767600", VA = "0x180768E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private ONABCELCNNN LPPCKBLGIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x761BD0", Offset = "0x7603D0", VA = "0x180761BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public NCJBBOLFFDA GCACPEBMCCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x761BF0", Offset = "0x7603F0", VA = "0x180761BF0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x761C10", Offset = "0x760410", VA = "0x180761C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public LGFIKMGGKBA PKFGKAHMDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x761C00", Offset = "0x760400", VA = "0x180761C00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x761BE0", Offset = "0x7603E0", VA = "0x180761BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private AJFDDFNJOBB HKEGLCEGPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x761C60", Offset = "0x760460", VA = "0x180761C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public AEDGGLEJNDA JODHBJOBDFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x761C20", Offset = "0x760420", VA = "0x180761C20", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x761C40", Offset = "0x760440", VA = "0x180761C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private OPDMLJEFMHA MDPOAGJFEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x768CD0", Offset = "0x7674D0", VA = "0x180768CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private PAPFBDJEGGN LIIHLEGLEIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x768C90", Offset = "0x767490", VA = "0x180768C90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A360", Offset = "0x5E58B60", VA = "0x185E5A360", Slot = "13")]
	public virtual void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public PMJMHOMBAAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[DEONFKEHMJD(typeof(LAIAFMADGKP), new string[] { })]
public class PCAOFNEFBJJ : LAIAFMADGKP, IKHNKAPNHGJ, DMOCALIGOJA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private HMNFMHNMJBH CJEADCONOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private JKEGAAHHGLK AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private PCPJLBDGAPJ CJGLLKCJNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private EHNBALNPIJE OHCKDBMMLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private KMLALHOKNKB DEIGKNMHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private LJJGONKGMDG DFJLJGOOCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private FJGKMPJNNPH IKCAIPFFHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private INPEDOFCAMM CBHFJDMCLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private BKMMIGNMLKP GBFNIPMDBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private JPPHIDMLLDL LOILEBKEBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private LPAIOCMDJPJ MENBMADGMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private JDHDACCAMDF DIBLJPGANBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private JLPKDNBELME HIEGHMEGDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private KMMJLLOECBC GNMDEOAFJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private ACCFLENNIHP MCIAOEBIKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private KCNLGBKOOKP GLGEJEDMGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private HMPNEEDBEAL ODFDNHELJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private HCLOJIAEBDJ AHGOPBJOELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private EJDAAEMCDOG MFJCOKIGLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private CBDHEEDCCOH EFGNGNHGGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public HMNFMHNMJBH HKPFEANEPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public JKEGAAHHGLK MHGBJPCGLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public CIKNOIPMHLH GKEFGCAHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public EHNBALNPIJE PNPIIFPHFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public LDNONJHJNKB AOCEPDFNMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public KMLALHOKNKB DNDCCOBNFMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x766140", Offset = "0x764940", VA = "0x180766140", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public LJJGONKGMDG FNDDFFOHHHL
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x768D80", Offset = "0x767580", VA = "0x180768D80", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public FJGKMPJNNPH LIBIAFOBDLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x761C50", Offset = "0x760450", VA = "0x180761C50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public BKMMIGNMLKP FOKHIODNAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x761C00", Offset = "0x760400", VA = "0x180761C00", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public JPPHIDMLLDL LCAEGDGGJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x761C30", Offset = "0x760430", VA = "0x180761C30", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public LPAIOCMDJPJ MLGDNGDLNHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x761C20", Offset = "0x760420", VA = "0x180761C20", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public JDHDACCAMDF MDPOAGJFEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x768CA0", Offset = "0x7674A0", VA = "0x180768CA0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public JLPKDNBELME DEKGIMCALGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x768D30", Offset = "0x767530", VA = "0x180768D30", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public KMMJLLOECBC LPGLOBCKGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x768CB0", Offset = "0x7674B0", VA = "0x180768CB0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public ACCFLENNIHP GDOGIAEAPCG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x8120A0", Offset = "0x8108A0", VA = "0x1808120A0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public KCNLGBKOOKP CPJODMMJCME
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x768E20", Offset = "0x767620", VA = "0x180768E20", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public HMPNEEDBEAL KCMDEICLNCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x8A33B0", Offset = "0x8A1BB0", VA = "0x1808A33B0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public HCLOJIAEBDJ IPICGLFKMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x768200", Offset = "0x766A00", VA = "0x180768200", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public EJDAAEMCDOG EGEPIPGLFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B6300", Offset = "0x8B4B00", VA = "0x1808B6300", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public CBDHEEDCCOH GAFGMPABAJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x83D270", Offset = "0x83BA70", VA = "0x18083D270", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public GKJIGEDKBPA EMOENIDPGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x7E1100", Offset = "0x7DF900", VA = "0x1807E1100", Slot = "24")]
		get
		{
			return default(GKJIGEDKBPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E596D0", Offset = "0x5E57ED0", VA = "0x185E596D0", Slot = "25")]
	public void IJALEBCDNGI(HMNFMHNMJBH KNILJBDIHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E596C0", Offset = "0x5E57EC0", VA = "0x185E596C0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E596A0", Offset = "0x5E57EA0", VA = "0x185E596A0", Slot = "26")]
	public void CNKMLPJMACA(HMNFMHNMJBH KNILJBDIHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public PCAOFNEFBJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[DefaultMember("Item")]
public class EDAHNECEMKG : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class KFEKKONBBKD : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public EDAHNECEMKG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x8C9910", Offset = "0x8C8110", VA = "0x1808C9910", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x5E54640", Offset = "0x5E52E40", VA = "0x185E54640", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x765710", Offset = "0x763F10", VA = "0x180765710")]
		[DebuggerHidden]
		public KFEKKONBBKD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E54480", Offset = "0x5E52C80", VA = "0x185E54480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E545F0", Offset = "0x5E52DF0", VA = "0x185E545F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private readonly List<ulong> FGKKIKCJAKJ;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x768D90", Offset = "0x767590", VA = "0x180768D90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B5E0", Offset = "0x5E49DE0", VA = "0x185E4B5E0")]
	public EDAHNECEMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B560", Offset = "0x5E49D60", VA = "0x185E4B560", Slot = "4")]
	[IteratorStateMachine(typeof(KFEKKONBBKD))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B560", Offset = "0x5E49D60", VA = "0x185E4B560", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[OAEOFLFLIGA(typeof(ODFFABDNAGO))]
[DEONFKEHMJD(typeof(LHPAKAHDGIF), new string[] { })]
public class IFDCDPKBIBM : LHPAKAHDGIF, GMMHILFNMPG, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private readonly Dictionary<int, MEFHJGEEAGN> EGAOHCHJPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private readonly Dictionary<MEFHJGEEAGN, int> AIBHNFKJDFG;

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E52050", Offset = "0x5E50850", VA = "0x185E52050", Slot = "6")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E52180", Offset = "0x5E50980", VA = "0x185E52180", Slot = "7")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E51E40", Offset = "0x5E50640", VA = "0x185E51E40")]
	private void BGGKKJMLJIJ(List<(MEFHJGEEAGN nameHash, GBADJBPMIOO stableTypeHash, Type type)> HBKECNHANOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E52280", Offset = "0x5E50A80", VA = "0x185E52280", Slot = "4")]
	public MEFHJGEEAGN JDNEJMHIOPC(int JIBGFHDMIBK)
	{
		return default(MEFHJGEEAGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E52110", Offset = "0x5E50910", VA = "0x185E52110", Slot = "5")]
	public int GAAGJKJLHAH(MEFHJGEEAGN FAGOHLPPLFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E523D0", Offset = "0x5E50BD0", VA = "0x185E523D0")]
	public IFDCDPKBIBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[DEONFKEHMJD(typeof(OGNNNIMMEPN), new string[] { })]
public class GFNOOJGBHNI : OGNNNIMMEPN, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	[NMIHDJKFGCM]
	private NCJBBOLFFDA AJDKMCHGGOD;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private uint CLJLMLHJPHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CE80", Offset = "0x5E4B680", VA = "0x185E4CE80", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CED0", Offset = "0x5E4B6D0", VA = "0x185E4CED0", Slot = "5")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public GFNOOJGBHNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[DEONFKEHMJD(typeof(CHOGKACALOP), new string[] { })]
public class BOKAMBDDHCG : CHOGKACALOP, GMMHILFNMPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private HIFNMALGGKJ LECKHJELHJK;

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E44420", Offset = "0x5E42C20", VA = "0x185E44420", Slot = "8")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E44170", Offset = "0x5E42970", VA = "0x185E44170", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E441C0", Offset = "0x5E429C0", VA = "0x185E441C0", Slot = "4")]
	public void EHMOKEALPJD(AFCHODDKGEA LHIGGCOIHEC, OJBFPODPDEH OJNPMCODCBJ, ReadOnlySpan<byte> LCFMAJDOEKC, ReadOnlySpan<byte> COMFLNBNMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E44520", Offset = "0x5E42D20", VA = "0x185E44520", Slot = "7")]
	public bool OBOFHNKNAFP(AFCHODDKGEA LHIGGCOIHEC, OJBFPODPDEH OJNPMCODCBJ, Span<byte> LCFMAJDOEKC, Span<byte> COMFLNBNMEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5E44C70", Offset = "0x5E43470", VA = "0x185E44C70", Slot = "5")]
	public bool POJEBDBFKLK(AFCHODDKGEA LHIGGCOIHEC, OJBFPODPDEH OJNPMCODCBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5E444F0", Offset = "0x5E42CF0", VA = "0x185E444F0", Slot = "6")]
	public bool LBGALJNOAHD(AFCHODDKGEA LHIGGCOIHEC, OJBFPODPDEH OJNPMCODCBJ, ReadOnlySpan<byte> COMFLNBNMEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5E448D0", Offset = "0x5E430D0", VA = "0x185E448D0")]
	private bool OICJKNKKKDO(AFCHODDKGEA LHIGGCOIHEC, OJBFPODPDEH OJNPMCODCBJ, ReadOnlySpan<byte> COMFLNBNMEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public BOKAMBDDHCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class ENLBDDCIDHF<T> : NCIEOOBKALG<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected JFDEEFLJAHK<T> FMKJAGDENDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected FPGDACDEBDO<T> BCKFDECCCGA;

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x302DE60", Offset = "0x302C660", VA = "0x18302DE60")]
	public ENLBDDCIDHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x30A47A0", Offset = "0x30A2FA0", VA = "0x1830A47A0")]
	public ENLBDDCIDHF(JFDEEFLJAHK<T> FMKJAGDENDM, FPGDACDEBDO<T> BCKFDECCCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x30A43D0", Offset = "0x30A2BD0", VA = "0x1830A43D0", Slot = "10")]
	protected override T PFKIHJFLILM(HMLBDOBHPJH OGNANCFBCDL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x30A4260", Offset = "0x30A2A60", VA = "0x1830A4260", Slot = "11")]
	protected override void BBOAPHOFBBK(BNNEIIHKPAC MCLDKNNIMFL, T FKKGMPDEPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class EEBCIOHDPMI
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public sealed class IMKNACKPNIA<T> : ENLBDDCIDHF<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x365B0A0", Offset = "0x36598A0", VA = "0x18365B0A0")]
	public IMKNACKPNIA(T NBPDHCAMINO, T JEGKJPODFLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class JPCALKKJPND<T> : NCIEOOBKALG<T> where T : struct, AHHAJJLHJMC
{
	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x3829C10", Offset = "0x3828410", VA = "0x183829C10", Slot = "10")]
	protected override T PFKIHJFLILM(HMLBDOBHPJH OGNANCFBCDL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x3829B40", Offset = "0x3828340", VA = "0x183829B40", Slot = "11")]
	protected override void BBOAPHOFBBK(BNNEIIHKPAC MCLDKNNIMFL, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x30272D0", Offset = "0x3025AD0", VA = "0x1830272D0")]
	public JPCALKKJPND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal static class ODFHOMMAAAI
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private class GMIGAIKAIAD
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[CompilerGenerated]
		private sealed class LKCBALCCPAC<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000244")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public LKCBALCCPAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x39242D0", Offset = "0x3922AD0", VA = "0x1839242D0")]
			internal void EDOIAAHJILC(BNNEIIHKPAC writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x39241A0", Offset = "0x39229A0", VA = "0x1839241A0")]
			internal T DELBCIHDGFB(HMLBDOBHPJH reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CF20", Offset = "0x5E4B720", VA = "0x185E4CF20")]
		public static void FMNOEEGCFPO(IGBLBBEHFCC NHBLKHDNJOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x296B420", Offset = "0x2969C20", VA = "0x18296B420")]
		private static void BKOFNOBHAKI<T>(IGBLBBEHFCC NHBLKHDNJOI, int JEGKJPODFLL) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x296BB10", Offset = "0x296A310", VA = "0x18296BB10")]
		private static void NPKDNFCOIIK<T>(BNNEIIHKPAC MCLDKNNIMFL, T EJBGEGKBPNL, int JEGKJPODFLL) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x296B550", Offset = "0x2969D50", VA = "0x18296B550")]
		private static T IMFJDCCNIBN<T>(HMLBDOBHPJH OGNANCFBCDL, int JEGKJPODFLL) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public GMIGAIKAIAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class LAFFFKIENHD : NAJEHEJPBKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private IGBLBBEHFCC NHBLKHDNJOI;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x296C0D0", Offset = "0x296A8D0", VA = "0x18296C0D0", Slot = "6")]
		public override void EIBOLODONFM<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x5E55240", Offset = "0x5E53A40", VA = "0x185E55240")]
		public static void NGPLIOKFKMP(IGBLBBEHFCC NHBLKHDNJOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x5E549B0", Offset = "0x5E531B0", VA = "0x185E549B0")]
		public LAFFFKIENHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x5E56EB0", Offset = "0x5E556B0", VA = "0x185E56EB0")]
	public static void EILMDLMOCEL(IGBLBBEHFCC NHBLKHDNJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x5E58940", Offset = "0x5E57140", VA = "0x185E58940")]
	private static void HJOABLDKJMI(BNNEIIHKPAC OANPIMIBBEM, quaternion EJBGEGKBPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x5E58A40", Offset = "0x5E57240", VA = "0x185E58A40")]
	private static quaternion NDEPGHLOKJH(HMLBDOBHPJH FPMFDFOAOMK)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x24D6B10", Offset = "0x24D5310", VA = "0x1824D6B10")]
	public static void OOGFJIEDDLG<T>(IGBLBBEHFCC NHBLKHDNJOI, JFDEEFLJAHK<T> FMKJAGDENDM, FPGDACDEBDO<T> BCKFDECCCGA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x24D6A90", Offset = "0x24D5290", VA = "0x1824D6A90")]
	public static void HFDOPAPHNPG<T>(IGBLBBEHFCC MHIDINMCICE) where T : struct, AHHAJJLHJMC
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public abstract class HJCMCKKLLIA : NJJINADEEIE
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public abstract Type AFLNCBAKNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void PFKIHJFLILM(HMLBDOBHPJH OGNANCFBCDL, Span<byte> FKKGMPDEPMA);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void BBOAPHOFBBK(BNNEIIHKPAC MCLDKNNIMFL, ReadOnlySpan<byte> FKKGMPDEPMA);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected HJCMCKKLLIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public abstract class NCIEOOBKALG<T> : HJCMCKKLLIA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public override Type AFLNCBAKNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x3B9C310", Offset = "0x3B9AB10", VA = "0x183B9C310", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract T PFKIHJFLILM(HMLBDOBHPJH OGNANCFBCDL);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void BBOAPHOFBBK(BNNEIIHKPAC MCLDKNNIMFL, T FKKGMPDEPMA);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x3B9CD30", Offset = "0x3B9B530", VA = "0x183B9CD30", Slot = "8")]
	public override void PFKIHJFLILM(HMLBDOBHPJH OGNANCFBCDL, Span<byte> KMJKCJJHEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x3B9C620", Offset = "0x3B9AE20", VA = "0x183B9C620", Slot = "9")]
	public override void BBOAPHOFBBK(BNNEIIHKPAC MCLDKNNIMFL, ReadOnlySpan<byte> KLIANGHAKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
	protected NCIEOOBKALG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class DDACIDEFPPF
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public struct IPLLPHHCBPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public LDNONJHJNKB CLODAHGGILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public GDPMKDOKMND KGMJNLNABOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public FMKLLJOIEFE OGOEFIDFEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public MPONBMGLGEH DMEBAJIIFPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public CHOGKACALOP DCDDAGNGHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public HAOKDOHOGIB NHBLKHDNJOI;

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x5E528C0", Offset = "0x5E510C0", VA = "0x185E528C0")]
		public void FCMGAGDDFDK(HMNFMHNMJBH CJEADCONOPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct OLPAMBMAFMM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public NativeList<AFCHODDKGEA> BFBKFPJFMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public NativeList<GEPBLNPDOFJ> EIGLBIKONIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public NativeList<AFCHODDKGEA> GCPBAFELODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public NativeParallelMultiHashMap<AFCHODDKGEA, LBMALLKEHFP> CBHFJDMCLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public NativeList<byte> IBDHFLBOEAF;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool NBOFKIDLABG
		{
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x5E58BF0", Offset = "0x5E573F0", VA = "0x185E58BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x5E58B50", Offset = "0x5E57350", VA = "0x185E58B50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct OFOMAPCODIJ : IComparer<LBMALLKEHFP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x5E58B20", Offset = "0x5E57320", VA = "0x185E58B20", Slot = "4")]
		public int Compare(LBMALLKEHFP IILAPOMEGLM, LBMALLKEHFP BNBBAPGFCCO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private static readonly DGJIKJLGCCH FOGODBKLKAN;

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x5E491D0", Offset = "0x5E479D0", VA = "0x185E491D0")]
	public static void NPMPMLPPNMA(BNNEIIHKPAC MCLDKNNIMFL, OLPAMBMAFMM AELCABDCBDD, IPLLPHHCBPN CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x5E47980", Offset = "0x5E46180", VA = "0x185E47980")]
	public static OLPAMBMAFMM AMGMIBPHIFF(HMLBDOBHPJH OGNANCFBCDL, Allocator JONICLHJBEP, IPLLPHHCBPN CJEADCONOPM)
	{
		return default(OLPAMBMAFMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x5E48630", Offset = "0x5E46E30", VA = "0x185E48630")]
	public static void EHMOKEALPJD(OLPAMBMAFMM AELCABDCBDD, IPLLPHHCBPN CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5E48EC0", Offset = "0x5E476C0", VA = "0x185E48EC0")]
	public static void LBGALJNOAHD(OLPAMBMAFMM AELCABDCBDD, IPLLPHHCBPN CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5E48D70", Offset = "0x5E47570", VA = "0x185E48D70")]
	public static int KKKNMHIHGLF(OLPAMBMAFMM AELCABDCBDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5E49AC0", Offset = "0x5E482C0", VA = "0x185E49AC0")]
	private static void OOFJCFCFCBK(BNNEIIHKPAC MCLDKNNIMFL, NativeArray<AFCHODDKGEA> BFBKFPJFMOH, NativeArray<GEPBLNPDOFJ> EIGLBIKONIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5E48AE0", Offset = "0x5E472E0", VA = "0x185E48AE0")]
	private static void ILJCIMOEBEA(HMLBDOBHPJH OGNANCFBCDL, Allocator JONICLHJBEP, [Out] NativeList<AFCHODDKGEA> BFBKFPJFMOH, [Out] NativeList<GEPBLNPDOFJ> BCDOHCICMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5E48A30", Offset = "0x5E47230", VA = "0x185E48A30")]
	private static void FFGLGPJBOKF(BNNEIIHKPAC MCLDKNNIMFL, NativeArray<AFCHODDKGEA> GCPBAFELODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5E48C70", Offset = "0x5E47470", VA = "0x185E48C70")]
	private static void KAKOOEPIFLO(HMLBDOBHPJH OGNANCFBCDL, Allocator JONICLHJBEP, [Out] NativeList<AFCHODDKGEA> GCPBAFELODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5E47C90", Offset = "0x5E46490", VA = "0x185E47C90")]
	private static void EFLFDLHICJB(BNNEIIHKPAC MCLDKNNIMFL, NativeParallelMultiHashMap<AFCHODDKGEA, LBMALLKEHFP> CBHFJDMCLMP, NativeList<byte> IBDHFLBOEAF, IPLLPHHCBPN CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5E49470", Offset = "0x5E47C70", VA = "0x185E49470")]
	private static void ONBDGELPKFD(HMLBDOBHPJH OGNANCFBCDL, Allocator JONICLHJBEP, [Out] NativeParallelMultiHashMap<AFCHODDKGEA, LBMALLKEHFP> CBHFJDMCLMP, [Out] NativeList<byte> IBDHFLBOEAF, IPLLPHHCBPN CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5E48AC0", Offset = "0x5E472C0", VA = "0x185E48AC0")]
	private static void HFDBBKNDDFN(int PANKGCEEIAP, int DNNHHJOGLNJ, BNNEIIHKPAC MCLDKNNIMFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5E491B0", Offset = "0x5E479B0", VA = "0x185E491B0")]
	private static int MKKOGLBKOPA(int DNNHHJOGLNJ, HMLBDOBHPJH OGNANCFBCDL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[DEONFKEHMJD(typeof(HBEALOBIFKA), new string[] { })]
internal sealed class BADHKACHMLO : HBEALOBIFKA, GMMHILFNMPG, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private readonly Dictionary<OJBFPODPDEH, NCADLMHKOMN> PDEJIEOMNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private GDPMKDOKMND CBHFJDMCLMP;

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5E43BB0", Offset = "0x5E423B0", VA = "0x185E43BB0", Slot = "6")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5E43C00", Offset = "0x5E42400", VA = "0x185E43C00", Slot = "7")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x5E43CD0", Offset = "0x5E424D0", VA = "0x185E43CD0", Slot = "4")]
	public void NJMEIPIEAKJ(OJBFPODPDEH OJNPMCODCBJ, Type OLJOCCCLJKJ, NCADLMHKOMN CICGACDDBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5E43C60", Offset = "0x5E42460", VA = "0x185E43C60", Slot = "5")]
	public bool LEOCHDMNHOH(OJBFPODPDEH OJNPMCODCBJ, [Out] NCADLMHKOMN CICGACDDBCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x5E43D40", Offset = "0x5E42540", VA = "0x185E43D40")]
	public BADHKACHMLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[DEONFKEHMJD(typeof(EGGLLMDPOBO), new string[] { })]
internal class KKKKEBEJGCM : GJOKPFDLDCJ, EGGLLMDPOBO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	[NMIHDJKFGCM]
	private OGNNNIMMEPN KNCOEFOICAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private PPAMEJKDMIC NPLCLPBBIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private int IMHFNLGPHEB;

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x5E54B00", Offset = "0x5E53300", VA = "0x185E54B00", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5E549D0", Offset = "0x5E531D0", VA = "0x185E549D0", Slot = "5")]
	public KABIMFKAPPA HBFLIHBDBNO(ReadOnlySpan<byte> KAAIDPFBBBH)
	{
		return default(KABIMFKAPPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5E549C0", Offset = "0x5E531C0", VA = "0x185E549C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public KKKKEBEJGCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[DEONFKEHMJD(typeof(MPONBMGLGEH), new string[] { })]
internal sealed class HLHKKHLONIG : MPONBMGLGEH, GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	[NMIHDJKFGCM]
	private GDPMKDOKMND CBHFJDMCLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private NativeBitArray OOMIGIEFHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private NativeParallelHashMap<AFCHODDKGEA, int> JJNDCJINHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private NativeList<int> HBALEHIOJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private int LJACJPHICGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private int OHNFICPEEFC;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool CFNCBLLJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D20", Offset = "0x5E50520", VA = "0x185E51D20", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public DCECDHHIHFP JPPMLEKGBMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x5E51870", Offset = "0x5E50070", VA = "0x185E51870", Slot = "7")]
		get
		{
			return default(DCECDHHIHFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x5E51A20", Offset = "0x5E50220", VA = "0x185E51A20", Slot = "4")]
	public bool JLFALKCKFCM(AFCHODDKGEA NFLGLAGMLAA, OJBFPODPDEH EJKGILKDBHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x5E518C0", Offset = "0x5E500C0", VA = "0x185E518C0", Slot = "8")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x5E51650", Offset = "0x5E4FE50", VA = "0x185E51650", Slot = "6")]
	public void CJKLHLFFBBG(NativeArray<AFCHODDKGEA> LILIIJHBMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x5E51AA0", Offset = "0x5E502A0", VA = "0x185E51AA0", Slot = "5")]
	public void JLGDGNDLKBG(AFCHODDKGEA NFLGLAGMLAA, Span<OJBFPODPDEH> CBHFJDMCLMP, bool FGDIDGENBIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x5E517E0", Offset = "0x5E4FFE0", VA = "0x185E517E0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HLHKKHLONIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[DEONFKEHMJD(typeof(HAOKDOHOGIB), new string[] { })]
public sealed class KKNCHBGFECA : HAOKDOHOGIB, KGFJNFPOHDD<HAOKDOHOGIB>, GMMHILFNMPG, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly Dictionary<OJBFPODPDEH, NJJINADEEIE> NHBLKHDNJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private IGBLBBEHFCC NMDCFNLBMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private GDPMKDOKMND CBHFJDMCLMP;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool DIJKGIFMLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FB580", VA = "0x1807FCD80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x5E54F00", Offset = "0x5E53700", VA = "0x185E54F00")]
	public KKNCHBGFECA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x5E54B70", Offset = "0x5E53370", VA = "0x185E54B70", Slot = "5")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x5E54DF0", Offset = "0x5E535F0", VA = "0x185E54DF0", Slot = "6")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x5E54BD0", Offset = "0x5E533D0", VA = "0x185E54BD0", Slot = "4")]
	public bool HFGKLMCKFNO(OJBFPODPDEH NENKFFLNHCE, [Out] NJJINADEEIE MHIDINMCICE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(IGBLBBEHFCC), new string[] { })]
internal sealed class IGBLBBEHFCC : GMMHILFNMPG
{
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private readonly Dictionary<Type, NJJINADEEIE> NHBLKHDNJOI;

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x5E524F0", Offset = "0x5E50CF0", VA = "0x185E524F0", Slot = "4")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5E52610", Offset = "0x5E50E10", VA = "0x185E52610")]
	public void NJMEIPIEAKJ(Type GFGNPBCFEMC, NJJINADEEIE MHIDINMCICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x5E52540", Offset = "0x5E50D40", VA = "0x185E52540")]
	public bool HFGKLMCKFNO(Type GFGNPBCFEMC, [Out] NJJINADEEIE MHIDINMCICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x5E527C0", Offset = "0x5E50FC0", VA = "0x185E527C0")]
	public IGBLBBEHFCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class CGFKBBGKGGE
{
	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x5E44D90", Offset = "0x5E43590", VA = "0x185E44D90")]
	public static void NJMEIPIEAKJ(this IGBLBBEHFCC HOKHBOHACNK, NJJINADEEIE MHIDINMCICE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[AlwaysUpdateSystem]
internal class CNFHLLDLLNB : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public CNFHLLDLLNB()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public class UpdateAuthoredChildrenFromParent : ParentSystemBase<AuthoredParentData, AuthoredPreviousParentData, AuthoredChildrenData>
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B380", Offset = "0x5E59B80", VA = "0x185E5B380", Slot = "14")]
		protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x89A900", Offset = "0x899100", VA = "0x18089A900", Slot = "15")]
		protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B340", Offset = "0x5E59B40", VA = "0x185E5B340", Slot = "16")]
		protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B300", Offset = "0x5E59B00", VA = "0x185E5B300", Slot = "17")]
		protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B3C0", Offset = "0x5E59BC0", VA = "0x185E5B3C0")]
		public UpdateAuthoredChildrenFromParent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class KDOMPOPOLCP : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private object IKIBDACBDBP;

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5E540B0", Offset = "0x5E528B0", VA = "0x185E540B0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5E54130", Offset = "0x5E52930", VA = "0x185E54130", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5E541E0", Offset = "0x5E529E0", VA = "0x185E541E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public KDOMPOPOLCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class MKKOKOEDEOO : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private object IKIBDACBDBP;

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5E55780", Offset = "0x5E53F80", VA = "0x185E55780", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5E55800", Offset = "0x5E54000", VA = "0x185E55800", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5E558B0", Offset = "0x5E540B0", VA = "0x185E558B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public MKKOKOEDEOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[InternalBufferCapacity(1)]
internal struct LHBIGPDICNA : ISystemStateBufferElementData, IBufferElementData, IEquatable<LHBIGPDICNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public FEPNNFCCMDN KPAMIOKBGLD;

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C520", Offset = "0x5E4AD20", VA = "0x185E4C520", Slot = "4")]
	public bool Equals(LHBIGPDICNA IFHFGCDLDEA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
	public static LHBIGPDICNA FEBAGKLNOCP(FEPNNFCCMDN KPAMIOKBGLD)
	{
		return default(LHBIGPDICNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[InternalBufferCapacity(4)]
internal struct FEPIALMAKLP : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public FEPNNFCCMDN KPAMIOKBGLD;
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal abstract class JKLMJBLNHOB : FFIAJJPGIKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5E53BB0", Offset = "0x5E523B0", VA = "0x185E53BB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5E53E90", Offset = "0x5E52690", VA = "0x185E53E90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CCA0", Offset = "0x5E4B4A0", VA = "0x185E4CCA0")]
	protected JKLMJBLNHOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[AMCOHLDKFON]
internal abstract class FFIAJJPGIKF : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	protected LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	protected HCLOJIAEBDJ AHGOPBJOELE;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	protected abstract LKLAKCMANMB AIEGPKOELOP
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CAC0", Offset = "0x5E4B2C0", VA = "0x185E4CAC0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C5C0", Offset = "0x5E4ADC0", VA = "0x185E4C5C0")]
	protected void AGAAKJELGKH(EntityQuery LGGGLPHDMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C840", Offset = "0x5E4B040", VA = "0x185E4C840")]
	protected void CBPEAKAGADG(EntityQuery LGGGLPHDMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CB30", Offset = "0x5E4B330", VA = "0x185E4CB30")]
	protected AJLMOHPDADI PDCGABMMMNN(EntityQuery LGGGLPHDMCK)
	{
		return default(AJLMOHPDADI);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	protected FFIAJJPGIKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class PBJFGJAKGNO : FFIAJJPGIKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private EntityQuery HFJCEJEBDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private EntityQuery LIEEGMAPNOD;

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x5E59010", Offset = "0x5E57810", VA = "0x185E59010", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x5E59370", Offset = "0x5E57B70", VA = "0x185E59370", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x5E58F20", Offset = "0x5E57720", VA = "0x185E58F20")]
	private void AIFPAKDOEDI(EntityQuery LGGGLPHDMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CD60", Offset = "0x5E4B560", VA = "0x185E4CD60")]
	protected PBJFGJAKGNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class FGKKGMJHCDG : JKLMJBLNHOB
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	protected override LKLAKCMANMB AIEGPKOELOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CC30", Offset = "0x5E4B430", VA = "0x185E4CC30", Slot = "15")]
		get
		{
			return default(LKLAKCMANMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CCA0", Offset = "0x5E4B4A0", VA = "0x185E4CCA0")]
	public FGKKGMJHCDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class LNHCCNPKOAA : PBJFGJAKGNO
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	protected override LKLAKCMANMB AIEGPKOELOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x5E55330", Offset = "0x5E53B30", VA = "0x185E55330", Slot = "15")]
		get
		{
			return default(LKLAKCMANMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CD60", Offset = "0x5E4B560", VA = "0x185E4CD60")]
	public LNHCCNPKOAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class OMODIOOCOLF : JKLMJBLNHOB
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	protected override LKLAKCMANMB AIEGPKOELOP
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x5E58C80", Offset = "0x5E57480", VA = "0x185E58C80", Slot = "15")]
		get
		{
			return default(LKLAKCMANMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CCA0", Offset = "0x5E4B4A0", VA = "0x185E4CCA0")]
	public OMODIOOCOLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class MKCAIIDMBGD : PBJFGJAKGNO
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	protected override LKLAKCMANMB AIEGPKOELOP
	{
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x5E55710", Offset = "0x5E53F10", VA = "0x185E55710", Slot = "15")]
		get
		{
			return default(LKLAKCMANMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CD60", Offset = "0x5E4B560", VA = "0x185E4CD60")]
	public MKCAIIDMBGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class GODGCLJOJLN : JKLMJBLNHOB
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	protected override LKLAKCMANMB AIEGPKOELOP
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x5E4D0A0", Offset = "0x5E4B8A0", VA = "0x185E4D0A0", Slot = "15")]
		get
		{
			return default(LKLAKCMANMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CCA0", Offset = "0x5E4B4A0", VA = "0x185E4CCA0")]
	public GODGCLJOJLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal class FKIEMPOBAGK : PBJFGJAKGNO
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	protected override LKLAKCMANMB AIEGPKOELOP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CCF0", Offset = "0x5E4B4F0", VA = "0x185E4CCF0", Slot = "15")]
		get
		{
			return default(LKLAKCMANMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CD60", Offset = "0x5E4B560", VA = "0x185E4CD60")]
	public FKIEMPOBAGK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct BGPJFJJDAEL : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct CNMIKOPEEKB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal struct KJNJAMDCBFB : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct LKLAKCMANMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly ComponentType? HKCMHNOADBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly ComponentType? LAPHGBMOCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly ComponentType KJCLKLAEONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly object KIAKEGJPMAL;

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E552F0", Offset = "0x5E53AF0", VA = "0x185E552F0")]
	public LKLAKCMANMB(ComponentType? HKCMHNOADBH, ComponentType? LAPHGBMOCLO, ComponentType KJCLKLAEONE, object KIAKEGJPMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x2412F40", Offset = "0x2411740", VA = "0x182412F40")]
	public static LKLAKCMANMB MJOHDFMKECH<TReq, TTag>(object KIAKEGJPMAL)
	{
		return default(LKLAKCMANMB);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x2413320", Offset = "0x2411B20", VA = "0x182413320")]
	public static LKLAKCMANMB POFOFMAEPAE<TReq, TMissing, TTag>(object KIAKEGJPMAL)
	{
		return default(LKLAKCMANMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class DFOKHMCBHAP
{
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly LKLAKCMANMB GDOGIAEAPCG;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly LKLAKCMANMB POKFINLCCAI;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly LKLAKCMANMB GLFBJIFLNMM;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal struct FEPNNFCCMDN : KHMBLBDKHME, IEquatable<FEPNNFCCMDN>
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public int NEMCGPAIDHF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F1550", Offset = "0x7EFD50", VA = "0x1807F1550", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public int OGGABIEKFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE230", Offset = "0x1FBCA30", VA = "0x181FBE230", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x51FC7D0", Offset = "0x51FAFD0", VA = "0x1851FC7D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C520", Offset = "0x5E4AD20", VA = "0x185E4C520", Slot = "8")]
	public bool Equals(FEPNNFCCMDN IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C570", Offset = "0x5E4AD70", VA = "0x185E4C570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
	[CompilerGenerated]
	[AMCOHLDKFON]
	public class UpdateConnectableVisualsSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		private struct HandlePosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public FEPNNFCCMDN handle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public float3 position;

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x41D09A0", Offset = "0x41CF1A0", VA = "0x1841D09A0")]
			public HandlePosition(FEPNNFCCMDN handle, float3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x5E51DB0", Offset = "0x5E505B0", VA = "0x185E51DB0")]
			public void FFNFLPIKFMM([Out] FEPNNFCCMDN handle, [Out] float3 position)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		private struct UpdateVisualPositions_ParentWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			public UpdateConnectableVisualsSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			[ReadOnly]
			public ComponentTypeHandle<HDPLCCLBLHA> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public BufferTypeHandle<FEPIALMAKLP> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x5E602F0", Offset = "0x5E5EAF0", VA = "0x185E602F0")]
			private void KJMBDHFEAAM(Entity entity, [In] HDPLCCLBLHA pose, DynamicBuffer<FEPIALMAKLP> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x5E60130", Offset = "0x5E5E930", VA = "0x185E60130", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct UpdateVisualPositions_ChildWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			[ReadOnly]
			public ComponentTypeHandle<HDPLCCLBLHA> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			public BufferTypeHandle<LHBIGPDICNA> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x5E60040", Offset = "0x5E5E840", VA = "0x185E60040")]
			private void KJMBDHFEAAM([In][NoAlias] HDPLCCLBLHA pose, DynamicBuffer<LHBIGPDICNA> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x5E5FED0", Offset = "0x5E5E6D0", VA = "0x185E5FED0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct UpdateVisualPositions_ChildWithCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			[ReadOnly]
			public ComponentTypeHandle<HDPLCCLBLHA> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			[ReadOnly]
			public ComponentTypeHandle<MHDKDBLBEIC> __comTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			public BufferTypeHandle<LHBIGPDICNA> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x5E5FD60", Offset = "0x5E5E560", VA = "0x185E5FD60")]
			private void KJMBDHFEAAM([In][NoAlias] HDPLCCLBLHA pose, [In][NoAlias] MHDKDBLBEIC com, DynamicBuffer<LHBIGPDICNA> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x5E5FB80", Offset = "0x5E5E380", VA = "0x185E5FB80", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery addGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery addGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery updateGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private EntityQuery updateGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private EntityQuery removeExpiredGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private EntityQuery removeExpiredGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private EntityQuery removeAllGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private EntityQuery queryLegacyGizmoParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private EntityQuery queryChildrenWoutCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private EntityQuery queryChildrenWithCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private JAMMDJGAEKI<FEPNNFCCMDN, IGINIAKAODA> linkVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private HMPNEEDBEAL connectables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private LDNONJHJNKB objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private JDHDACCAMDF scope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private CPLHLHOLEDD makerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private EntityQuery UpdateVisualPositions_ParentWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private EntityQuery UpdateVisualPositions_ChildWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private EntityQuery UpdateVisualPositions_ChildWithCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private ComponentTypeHandle<HDPLCCLBLHA> __RecRoom_Components_WorldPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private ComponentTypeHandle<MHDKDBLBEIC> __RecRoom_Rbex_RbexLocalCenterOfMassOfSelfData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x5E5CA20", Offset = "0x5E5B220", VA = "0x185E5CA20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E5BE60", Offset = "0x5E5A660", VA = "0x185E5BE60")]
		internal IGINIAKAODA CEELBABLGBK(FEPNNFCCMDN handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D780", Offset = "0x5E5BF80", VA = "0x185E5D780", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EF90", Offset = "0x5E5D790", VA = "0x185E5EF90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F220", Offset = "0x5E5DA20", VA = "0x185E5F220", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F3B0", Offset = "0x5E5DBB0", VA = "0x185E5F3B0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F1E0", Offset = "0x5E5D9E0", VA = "0x185E5F1E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CA60", Offset = "0x5E5B260", VA = "0x185E5CA60")]
		private void GIILIMLDCGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E4A0", Offset = "0x5E5CCA0", VA = "0x185E5E4A0")]
		private void LJCCGKMIGBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CB80", Offset = "0x5E5B380", VA = "0x185E5CB80")]
		private void HEPHEJOAMEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F3F0", Offset = "0x5E5DBF0", VA = "0x185E5F3F0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D060", Offset = "0x5E5B860", VA = "0x185E5D060")]
		private void IDAKBLNHKFP(EntityQuery add, EntityQuery update, EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F520", Offset = "0x5E5DD20", VA = "0x185E5F520")]
		private void PJFBCFIPABD(EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B660", Offset = "0x5E59E60", VA = "0x185E5B660")]
		private void ANFNFHNBHFH(NativeArrayAsync<Entity> oldEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C6A0", Offset = "0x5E5AEA0", VA = "0x185E5C6A0")]
		private void FEEBAJEPIED(NativeArrayAsync<Entity> newEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E5F0", Offset = "0x5E5CDF0", VA = "0x185E5E5F0")]
		private void MBNMJLLGAEC(NativeArrayAsync<Entity> updateEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E320", Offset = "0x5E5CB20", VA = "0x185E5E320")]
		private void LIPPOPAFIOP(NativeList<FEPNNFCCMDN> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E5BEB0", Offset = "0x5E5A6B0", VA = "0x185E5BEB0")]
		private NativeList<FEPNNFCCMDN> DJBPCICIABN(NativeArray<Entity> entities)
		{
			return default(NativeList<FEPNNFCCMDN>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DBC0", Offset = "0x5E5C3C0", VA = "0x185E5DBC0")]
		private void KLBDGHJOIFP(NativeArray<Entity> entities, NativeList<FEPNNFCCMDN> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B8D0", Offset = "0x5E5A0D0", VA = "0x185E5B8D0")]
		private void BJMCMIBMOAF(NativeArray<Entity> addParents, NativeArray<Entity> addChildren, NativeList<FEPNNFCCMDN> freeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F610", Offset = "0x5E5DE10", VA = "0x185E5F610")]
		private void PNLPLIBHLCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C750", Offset = "0x5E5AF50", VA = "0x185E5C750")]
		private NativeListAsync<HandlePosition> GBMIDJBECKK(EntityQuery query, Func<NativeList<HandlePosition>, JobHandle> populateHandles)
		{
			return default(NativeListAsync<HandlePosition>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DA60", Offset = "0x5E5C260", VA = "0x185E5DA60")]
		private JobHandle KIAGOHBCJEF(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E1B0", Offset = "0x5E5C9B0", VA = "0x185E5E1B0")]
		private JobHandle KMBLOJEGLCK(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C890", Offset = "0x5E5B090", VA = "0x185E5C890")]
		private JobHandle GGDIHJENGGF(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B400", Offset = "0x5E59C00", VA = "0x185E5B400")]
		private void AKLAJDDAHIC(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D520", Offset = "0x5E5BD20", VA = "0x185E5D520")]
		private void INKJPKJLJBO(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C620", Offset = "0x5E5AE20", VA = "0x185E5C620")]
		private bool ELJBHEOHBPK(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E880", Offset = "0x5E5D080", VA = "0x185E5E880")]
		private NativeArray<Entity> NIBPMOEAHJG(Entity entity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C460", Offset = "0x5E5AC60", VA = "0x185E5C460")]
		private FEPNNFCCMDN EABCPOPCENJ(NativeList<FEPNNFCCMDN> freeList)
		{
			return default(FEPNNFCCMDN);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D9D0", Offset = "0x5E5C1D0", VA = "0x185E5D9D0")]
		private void KBDLEOAKLEE(FEPNNFCCMDN handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E740", Offset = "0x5E5CF40", VA = "0x185E5E740")]
		private void MCOHKMBPJMP(NativeList<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CF00", Offset = "0x5E5B700", VA = "0x185E5CF00")]
		private JobHandle IAOABAGBMPG(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D840", Offset = "0x5E5C040", VA = "0x185E5D840")]
		private JobHandle JEPEJPOFBMF(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E950", Offset = "0x5E5D150", VA = "0x185E5E950", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public UpdateConnectableVisualsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	public class CalculateCollisionIslandUpdatesSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct CalculateCollisionIslandUpdatesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public NativeList<Entity> rootsWithForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public NativeList<Entity> rootsWithoutForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			[ReadOnly]
			public ComponentTypeHandle<KMJAKLDPLLL> collisionIslandRootDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			[ReadOnly]
			public ComponentDataFromEntity<KMJAKLDPLLL> collisionIslandRootDataFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			[ReadOnly]
			public ComponentTypeHandle<AABJHPEEABP> splineParentHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public EntityQueryInJob changedLocalPoseQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public EntityQueryInJob changedSplinePointsQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public EntityQueryInJob splinesWithChangedChildrenQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			public EntityQueryInJob changedCollisionModeQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40002CE")]
			public EntityQueryInJob changedScopeRootQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40002CF")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x5E455F0", Offset = "0x5E43DF0", VA = "0x185E455F0")]
			private void KJMBDHFEAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x5E455E0", Offset = "0x5E43DE0", VA = "0x185E455E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery changedLocalPoseQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery changedSplinePointsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private EntityQuery splinesWithChangedChildrenQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private EntityQuery changedCollisionModeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private EntityQuery scopeRootChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private NCLGOBJOGHN collisionIslandService;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E45590", Offset = "0x5E43D90", VA = "0x185E45590", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E45F90", Offset = "0x5E44790", VA = "0x185E45F90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E46320", Offset = "0x5E44B20", VA = "0x185E46320", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E45DF0", Offset = "0x5E445F0", VA = "0x185E45DF0")]
		private JobHandle MLEJJEIGPPB(NativeList<Entity> rootsWithForcedCollisionUpdate, NativeList<Entity> rootsWithoutForcedCollisionUpdate, ComponentTypeHandle<KMJAKLDPLLL> collisionIslandRootDataHandleRO, ComponentDataFromEntity<KMJAKLDPLLL> collisionIslandRootDataFromEntityRO, ComponentTypeHandle<AABJHPEEABP> splineParentHandleRO, EntityQueryInJob changedLocalPoseQueryInJob, EntityQueryInJob changedSplinePointsQueryInJob, EntityQueryInJob splinesWithChangedChildrenQueryInJob, EntityQueryInJob changedCollisionModeQueryInJob, EntityQueryInJob changedScopeRootQueryInJob, Allocator allocator, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public CalculateCollisionIslandUpdatesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[BurstCompatible]
internal readonly struct LBOHLIPIOMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private readonly CNJKOAPMJNK KBNMHOACJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private readonly BGBBDBFDLLI FBIMFNEOECE;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x979D20", Offset = "0x978520", VA = "0x180979D20")]
	public LBOHLIPIOMD(CNJKOAPMJNK KBNMHOACJLB, BGBBDBFDLLI FBIMFNEOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x1B54480", Offset = "0x1B52C80", VA = "0x181B54480")]
	public bool LDACIOAEJMN(LBOHLIPIOMD OBIIIBPBMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x1B54480", Offset = "0x1B52C80", VA = "0x181B54480")]
	public bool FDKLIMMADNC(LBOHLIPIOMD EFKEIDIJBGE)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
	public class CalculateContainerCollisionIslandGraphChangesSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000E9")]
		[BurstCompile]
		private struct FindChangedIslandsJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			[ReadOnly]
			public EntityQueryInJob deletedConnectablesQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			[ReadOnly]
			public EntityQueryInJob changedIslandQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[ReadOnly]
			public EntityQueryInJob hierarchyChangeQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			[ReadOnly]
			public EntityQueryInJob newRootsQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			[ReadOnly]
			public ChunkFilterAnyOf2ComponentsChanged islandSplitChangeFilterRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			[ReadOnly]
			public ComponentTypeHandle<BEMNNEKFNPK> islandRootSystemDataTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			[ReadOnly]
			public ComponentDataFromEntity<MNJNHNEKGLP> dontPropagatePhysicsPropertiesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			[ReadOnly]
			public ComponentDataFromEntity<CNJKOAPMJNK> containerCollisionModeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			[ReadOnly]
			public ComponentDataFromEntity<BGBBDBFDLLI> containerCollisionLayerRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			[ReadOnly]
			public ComponentDataFromEntity<CLKEMIAJMNG> containerCollisionIslandRootTagRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			[ReadOnly]
			public ComponentDataFromEntity<ParentData> parentRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> childrenRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			[WriteOnly]
			public NativeList<Entity> changedIslandComponentsBufferWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			[WriteOnly]
			public NativeList<DMGBFHKMEFD> changedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			[WriteOnly]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			[WriteOnly]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			public ComponentDataFromEntity<KMJAKLDPLLL> collisionIslandRootDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public NativeParallelHashSet<Entity> visitedRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			private int bufferHead;

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x5E6D6E0", Offset = "0x5E6BEE0", VA = "0x185E6D6E0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x5E6E030", Offset = "0x5E6C830", VA = "0x185E6E030")]
			private void IENMEKLEIEP(Entity startEntity, bool checkForUnchanged)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x5E6DEA0", Offset = "0x5E6C6A0", VA = "0x185E6DEA0")]
			private Entity FIDJOFDEIHK(Entity curEntity, LBOHLIPIOMD classifier)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x5E6D620", Offset = "0x5E6BE20", VA = "0x185E6D620")]
			private bool CGODOCDCDOA(Entity curEntity, LBOHLIPIOMD classifier, [Out] Entity parentEntity, [Out] LBOHLIPIOMD parentClassifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x5E6DD90", Offset = "0x5E6C590", VA = "0x185E6DD90")]
			private void FFMPOBLFMDO(Entity islandRoot, LBOHLIPIOMD classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E6E1E0", Offset = "0x5E6C9E0", VA = "0x185E6E1E0")]
			private void LHFACKLGPMC(Entity islandRoot, Entity entity, LBOHLIPIOMD classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x5E6DF20", Offset = "0x5E6C720", VA = "0x185E6DF20")]
			private void HNPDADAMKBC(Entity islandRoot, Entity component)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x5E6E420", Offset = "0x5E6CC20", VA = "0x185E6E420")]
			private bool MOOHIKCNHDE(Entity entity, [Out] LBOHLIPIOMD classifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x5E6D580", Offset = "0x5E6BD80", VA = "0x185E6D580")]
			private LBOHLIPIOMD BELOBFENBNH(Entity entity)
			{
				return default(LBOHLIPIOMD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EA")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct CalculateContainerCollisionIslandGraphChangesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			[ReadOnly]
			public EntityTypeHandle entityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x5E68830", Offset = "0x5E67030", VA = "0x185E68830")]
			private void KJMBDHFEAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x5E68820", Offset = "0x5E67020", VA = "0x185E68820", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		[NMIHDJKFGCM]
		private NCLGOBJOGHN collisionIslandService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private EntityQuery changedIslandStructureQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private EntityQuery hierarchyChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private EntityQuery newRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private EntityQuery deletedConnectablesQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private EntityQuery deletedRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private EntityQuery islandRootDataQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private EntityQuery islandRootTagQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private KMIEDMOIFHD ecbs;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E687D0", Offset = "0x5E66FD0", VA = "0x185E687D0", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E68960", Offset = "0x5E67160", VA = "0x185E68960", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E68DB0", Offset = "0x5E675B0", VA = "0x185E68DB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E68070", Offset = "0x5E66870", VA = "0x185E68070")]
		private JobHandle IMGCPKFCLCP(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E67DB0", Offset = "0x5E665B0", VA = "0x185E67DB0")]
		private JobHandle GEPLKCLBBLG(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E67CB0", Offset = "0x5E664B0", VA = "0x185E67CB0")]
		private JobHandle APABDAKJLHN(EntityCommandBuffer ecb, NativeList<Entity> removedIslandRootsWO, EntityTypeHandle entityType, EntityQueryInJob queryInJob, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public CalculateContainerCollisionIslandGraphChangesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
[AlwaysUpdateSystem]
public class BDOABLFMAPM : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	[NMIHDJKFGCM]
	private NCLGOBJOGHN KFIBFECJHHP;

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E64960", Offset = "0x5E63160", VA = "0x185E64960", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E649B0", Offset = "0x5E631B0", VA = "0x185E649B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public BDOABLFMAPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class BNHKMKILCNG : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private KMLALHOKNKB DEIGKNMHENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private NOOBBKBLILA LKAEENHCIFJ;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E664B0", Offset = "0x5E64CB0", VA = "0x185E664B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E66420", Offset = "0x5E64C20", VA = "0x185E66420", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x5E665C0", Offset = "0x5E64DC0", VA = "0x185E665C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public BNHKMKILCNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class HKHMICMPKOM : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public JNHCKHFIJLH IBKDOLMCEFO;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HKHMICMPKOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public HKHMICMPKOM(JNHCKHFIJLH IBKDOLMCEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x5E70310", Offset = "0x5E6EB10", VA = "0x185E70310", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public abstract class CCKOLHIDHLM : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private NHCACALFIKB PEENKKOKGPE;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x5E672A0", Offset = "0x5E65AA0", VA = "0x185E672A0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x5E67300", Offset = "0x5E65B00", VA = "0x185E67300", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x5E67330", Offset = "0x5E65B30", VA = "0x185E67330", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	protected CCKOLHIDHLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class JLFIMFFKJBB : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private EntityQuery GDGDHCOPEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery JLFHJMEMOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private EntityQuery KGGMPFBBNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private EntityQuery CJGBBPDACLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private NHCACALFIKB HFLLAGEJGKH;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public int HIPPDDPEIKM
	{
		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x5E73510", Offset = "0x5E71D10", VA = "0x185E73510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x5E73430", Offset = "0x5E71C30", VA = "0x185E73430", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x5E736A0", Offset = "0x5E71EA0", VA = "0x185E736A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x5E738D0", Offset = "0x5E720D0", VA = "0x185E738D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x5E73630", Offset = "0x5E71E30", VA = "0x185E73630")]
	public int NMNDDAIIDBK(SceneTag AGEHAEDLOFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x5E731F0", Offset = "0x5E719F0", VA = "0x185E731F0")]
	protected void IJNBCDIONCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x5E73000", Offset = "0x5E71800", VA = "0x185E73000")]
	protected void AFCKKNBCBJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x5E73650", Offset = "0x5E71E50", VA = "0x185E73650")]
	public NativeArrayAsync<Entity> OFGMFHOEAGM(SceneTag AGEHAEDLOFL, Allocator JONICLHJBEP = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x5E73130", Offset = "0x5E71930", VA = "0x185E73130")]
	public NativeArrayAsync<Entity> AJNJNLNEOKE(SceneTag AGEHAEDLOFL, Allocator JONICLHJBEP = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x5E73520", Offset = "0x5E71D20", VA = "0x185E73520")]
	public bool KAIBJLOHMJF(SceneTag AGEHAEDLOFL, [Out] NativeArrayAsync<Entity> IBKDOLMCEFO, Allocator JONICLHJBEP = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x5E735B0", Offset = "0x5E71DB0", VA = "0x185E735B0")]
	public bool KLCLHJJFDOB(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x5E73180", Offset = "0x5E71980", VA = "0x185E73180")]
	public bool CPKMHGLBLBP(Entity KCMPKMKBCOO, [Out] HKHMICMPKOM IBKDOLMCEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x5E73490", Offset = "0x5E71C90", VA = "0x185E73490")]
	public void JHNEAEGGLIK(Entity KCMPKMKBCOO, HKHMICMPKOM IBKDOLMCEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x5E733B0", Offset = "0x5E71BB0", VA = "0x185E733B0")]
	public bool IKIEKLDLIIC(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public JLFIMFFKJBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class CLNPPBMBBOA : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private EntityQuery HMGFHCIPPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private PAPFBDJEGGN AJDKMCHGGOD;

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x5E673E0", Offset = "0x5E65BE0", VA = "0x185E673E0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x5E67430", Offset = "0x5E65C30", VA = "0x185E67430", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x5E674F0", Offset = "0x5E65CF0", VA = "0x185E674F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x21F15D0", Offset = "0x21EFDD0", VA = "0x1821F15D0")]
	private bool PNIPMNPENBF<TComponentData>(EntityQuery LGGGLPHDMCK, [Out] NativeArray<Entity> FAIFKAKJOPP, [Out] NativeArray<TComponentData> DKEGFJKDJBN) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x5E67350", Offset = "0x5E65B50", VA = "0x185E67350")]
	public JNHCKHFIJLH GFGOBPFLDJL(Entity KCMPKMKBCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public CLNPPBMBBOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public class AONGJPBKJDL : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private EntityQuery DGGJJMEAJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private EntityQuery DCDKOGJKMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private EntityQuery IPPHMKNIKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private EntityQuery PBPFENGGCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private HKIHKIGHNML AJDKMCHGGOD;

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x5E64050", Offset = "0x5E62850", VA = "0x185E64050", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x5E64420", Offset = "0x5E62C20", VA = "0x185E64420", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x5E646A0", Offset = "0x5E62EA0", VA = "0x185E646A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x5E63FC0", Offset = "0x5E627C0", VA = "0x185E63FC0")]
	private void BONJGFNEKBE(EntityQuery LGGGLPHDMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x5E64840", Offset = "0x5E63040", VA = "0x185E64840")]
	private void PJFBCFIPABD(EntityQuery LGGGLPHDMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x5E64610", Offset = "0x5E62E10", VA = "0x185E64610", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x5E640A0", Offset = "0x5E628A0", VA = "0x185E640A0")]
	private void LPNBJLAIPAC(EntityQuery LGGGLPHDMCK, bool JLCNOMOAIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public AONGJPBKJDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
public sealed class FKPAHMBMEBD : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private NGPBKFGDAEA CJLECODJBKA;

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D500", Offset = "0x5E6BD00", VA = "0x185E6D500", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D560", Offset = "0x5E6BD60", VA = "0x185E6D560", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public FKPAHMBMEBD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	public class GatherModifiedParentsSystem : DPGFJAECHAF, FIBMJMMLGPO
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherModifiedParents_AddNewParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public NativeList<LDDDAGKCJBG> newParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __currentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F750", Offset = "0x5E6DF50", VA = "0x185E6F750")]
			private void KJMBDHFEAAM(Entity entity, [In][NoAlias] ParentData current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F630", Offset = "0x5E6DE30", VA = "0x185E6F630", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherModifiedParents_AddChangedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			public NativeList<HLDGGCFJEBG> changedParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __currentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			[ReadOnly]
			public ComponentTypeHandle<PreviousParentData> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F570", Offset = "0x5E6DD70", VA = "0x185E6F570")]
			private void KJMBDHFEAAM(Entity entity, [In][NoAlias] ParentData current, [In][NoAlias] PreviousParentData previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F3D0", Offset = "0x5E6DBD0", VA = "0x185E6F3D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F6")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherModifiedParents_AddRemovedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			public NativeList<LDDDAGKCJBG> oldParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			[ReadOnly]
			public ComponentTypeHandle<PreviousParentData> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F8F0", Offset = "0x5E6E0F0", VA = "0x185E6F8F0")]
			private void KJMBDHFEAAM(Entity entity, [In][NoAlias] PreviousParentData previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F7D0", Offset = "0x5E6DFD0", VA = "0x185E6F7D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private AGPODNPCKBE parentEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private EntityQuery GatherModifiedParents_AddNewParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private EntityQuery GatherModifiedParents_AddChangedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private EntityQuery GatherModifiedParents_AddRemovedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private ComponentTypeHandle<PreviousParentData> __RecRoom_Components_PreviousParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E610", Offset = "0x5E6CE10", VA = "0x185E6E610", Slot = "14")]
		public void AIOKCKNKHOD(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F060", Offset = "0x5E6D860", VA = "0x185E6F060", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E850", Offset = "0x5E6D050", VA = "0x185E6E850")]
		private JobHandle HMDKLJNMKLJ(NativeList<LDDDAGKCJBG> newParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E6F0", Offset = "0x5E6CEF0", VA = "0x185E6E6F0")]
		private JobHandle GCAFPFIFICI(NativeList<HLDGGCFJEBG> changedParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E970", Offset = "0x5E6D170", VA = "0x185E6E970")]
		private JobHandle ONICFBMFEKA(NativeList<LDDDAGKCJBG> oldParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x5E6EA90", Offset = "0x5E6D290", VA = "0x185E6EA90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public GatherModifiedParentsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public class PCJDHPKBKEA : ParentSystemBase<ParentData, PreviousParentData, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x5E79220", Offset = "0x5E77A20", VA = "0x185E79220", Slot = "14")]
	protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc LGGGLPHDMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x89A900", Offset = "0x899100", VA = "0x18089A900", Slot = "15")]
	protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc LGGGLPHDMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x5E791E0", Offset = "0x5E779E0", VA = "0x185E791E0", Slot = "16")]
	protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc LGGGLPHDMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x5E791A0", Offset = "0x5E779A0", VA = "0x185E791A0", Slot = "17")]
	protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc LGGGLPHDMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x5E79260", Offset = "0x5E77A60", VA = "0x185E79260")]
	public PCJDHPKBKEA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public abstract class ParentSystemBase<TParentData, TPreviousParentData, TChildrenData> : DPGFJAECHAF where TParentData : struct, IComponentData, AMBALLNBDNE where TPreviousParentData : struct, IComponentData, AMBALLNBDNE where TChildrenData : struct, ISystemStateBufferElementData, IEquatable<TChildrenData>, AMBALLNBDNE
	{
		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[BurstCompile]
		internal struct GatherChangedParents : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter ParentChildrenToAdd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter ParentChildrenToRemove;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public NativeParallelHashMap<Entity, int>.ParallelWriter UniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public ComponentTypeHandle<TPreviousParentData> PreviousParentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			[ReadOnly]
			public ComponentTypeHandle<TParentData> ParentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			[ReadOnly]
			public EntityTypeHandle EntityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public uint LastSystemVersion;

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x35102C0", Offset = "0x350EAC0", VA = "0x1835102C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		[BurstCompile]
		internal struct FindMissingChild : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> UniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> ChildFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			public NativeList<Entity> ParentsMissingChild;

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x3446780", Offset = "0x3444F80", VA = "0x183446780", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		[BurstCompile]
		internal struct FixupChangedChildren : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> ParentChildrenToAdd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> ParentChildrenToRemove;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> UniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public BufferFromEntity<TChildrenData> ChildFromEntity;

			[Cpp2IlInjected.Token(Token = "0x600064D")]
			[Cpp2IlInjected.Address(RVA = "0x344EBB0", Offset = "0x344D3B0", VA = "0x18344EBB0")]
			private int FindChildIndex(DynamicBuffer<TChildrenData> children, Entity entity)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x344EC90", Offset = "0x344D490", VA = "0x18344EC90")]
			private void RemoveChildrenFromParent(Entity parent, DynamicBuffer<TChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x344E6D0", Offset = "0x344CED0", VA = "0x18344E6D0")]
			private void AddChildrenToParent(Entity parent, DynamicBuffer<TChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x344E810", Offset = "0x344D010", VA = "0x18344E810", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		[BurstCompile]
		private struct GatherChildEntities : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			[ReadOnly]
			public NativeArray<Entity> Parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public NativeList<Entity> Children;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> ChildFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			[ReadOnly]
			public ComponentDataFromEntity<TParentData> ParentFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x35109E0", Offset = "0x350F1E0", VA = "0x1835109E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected EntityQuery m_NewParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected EntityQuery m_RemovedParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected EntityQuery m_ExistingParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected EntityQuery m_DeletedParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected ProfilerMarker m_ProfileDeletedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected ProfilerMarker m_ProfileRemoveParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected ProfilerMarker m_ProfileChangeParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected ProfilerMarker m_ProfileNewParents;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x3DDCAF0", Offset = "0x3DDB2F0", VA = "0x183DDCAF0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA3A0", Offset = "0x3DD8BA0", VA = "0x183DDA3A0")]
		private int FindChildIndex(DynamicBuffer<TChildrenData> children, Entity entity)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAE90", Offset = "0x3DD9690", VA = "0x183DDAE90")]
		private void RemoveChildFromParent(Entity childEntity, Entity parentEntity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x89A900", Offset = "0x899100", VA = "0x18089A900", Slot = "14")]
		protected virtual EntityQueryDesc FilterNewParentQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x89A900", Offset = "0x899100", VA = "0x18089A900", Slot = "15")]
		protected virtual EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x89A900", Offset = "0x899100", VA = "0x18089A900", Slot = "16")]
		protected virtual EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc query);

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x3DDA4A0", Offset = "0x3DD8CA0", VA = "0x183DDA4A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC620", Offset = "0x3DDAE20", VA = "0x183DDC620")]
		private void UpdateNewParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC900", Offset = "0x3DDB100", VA = "0x183DDC900")]
		private void UpdateRemoveParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x3DDB690", Offset = "0x3DD9E90", VA = "0x183DDB690")]
		private JobHandle UpdateChangeParents(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x3DDC110", Offset = "0x3DDA910", VA = "0x183DDC110")]
		private void UpdateDeletedParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x3DDAC10", Offset = "0x3DD9410", VA = "0x183DDAC10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x3DDABE0", Offset = "0x3DD93E0", VA = "0x183DDABE0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
[AlwaysUpdateSystem]
public abstract class AMEMCDCEAHM : DPGFJAECHAF, FIBMJMMLGPO
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private struct BLCGALOKHEC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public NativeListAsync<Entity> CDAOMHHDGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public NativeListAsync<Entity> KIBHKENKJEP;

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x5E66330", Offset = "0x5E64B30", VA = "0x185E66330")]
		public BLCGALOKHEC(NativeList<Entity> CDAOMHHDGHA, NativeList<Entity> KIBHKENKJEP, JobHandle EKJLKMKCKOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x5E662B0", Offset = "0x5E64AB0", VA = "0x185E662B0")]
		public JobHandle IIBABJGNIJD(JobHandle DNKOAJMNLIH)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x5E66220", Offset = "0x5E64A20", VA = "0x185E66220", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[BurstCompile]
	private struct FBDILFPKHCP : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[Flags]
		public enum KJEFMHLMPGH
		{
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		[WriteOnly]
		public NativeList<Entity> FMDAFNHLCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		[WriteOnly]
		public NativeList<Entity> ALIIEAMDFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		[ReadOnly]
		public NativeArray<Entity> FCLABHMAFFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> EJKFGPPGGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[ReadOnly]
		public ComponentDataFromEntity NFBIDHJOIOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[ReadOnly]
		public ComponentDataFromEntity FLHMBPHOGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> PDPJAFKKDMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int BKGLMOKCJFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public int HLMNAGECIAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private KJEFMHLMPGH LHLDLDFNNPI;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CD20", Offset = "0x5E6B520", VA = "0x185E6CD20", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CBE0", Offset = "0x5E6B3E0", VA = "0x185E6CBE0")]
		private bool CDEFCNDELDC(Entity KCMPKMKBCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CC90", Offset = "0x5E6B490", VA = "0x185E6CC90")]
		private void EELGEMGBFLB(Entity KCMPKMKBCOO, bool BMOABABKOGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CFB0", Offset = "0x5E6B7B0", VA = "0x185E6CFB0")]
		private void MOEDGHDMJJD(Entity KCMPKMKBCOO, bool BMOABABKOGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D410", Offset = "0x5E6BC10", VA = "0x185E6D410")]
		public BLCGALOKHEC OCDBEOKNJIL(NativeArray<Entity> JABEPOLDBEF, JobHandle DNKOAJMNLIH)
		{
			return default(BLCGALOKHEC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CF30", Offset = "0x5E6B730", VA = "0x185E6CF30")]
		public BLCGALOKHEC LJBDEFFNBFE(NativeArray<Entity> JABEPOLDBEF, JobHandle DNKOAJMNLIH)
		{
			return default(BLCGALOKHEC);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CB00", Offset = "0x5E6B300", VA = "0x185E6CB00")]
		public BLCGALOKHEC AHIAPMHGAOB(NativeList<LDDDAGKCJBG> HBKECNHANOP, JobHandle DNKOAJMNLIH)
		{
			return default(BLCGALOKHEC);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CE50", Offset = "0x5E6B650", VA = "0x185E6CE50")]
		public BLCGALOKHEC KPONEDMMJHF(NativeList<LDDDAGKCJBG> HBKECNHANOP, JobHandle DNKOAJMNLIH)
		{
			return default(BLCGALOKHEC);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D330", Offset = "0x5E6BB30", VA = "0x185E6D330")]
		public BLCGALOKHEC NMCCFIIMLDB(NativeList<HLDGGCFJEBG> HBKECNHANOP, JobHandle DNKOAJMNLIH)
		{
			return default(BLCGALOKHEC);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x2954F00", Offset = "0x2953700", VA = "0x182954F00")]
		private BLCGALOKHEC NFKFPKFICCO<T>(NativeList<T> HBKECNHANOP, int LOMLDFJDJHE, int POAJBPPNNHO, KJEFMHLMPGH FDFIAAFCBPI, JobHandle DNKOAJMNLIH) where T : struct
		{
			return default(BLCGALOKHEC);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D0B0", Offset = "0x5E6B8B0", VA = "0x185E6D0B0")]
		private BLCGALOKHEC NFKFPKFICCO(NativeArray<Entity> FAIFKAKJOPP, int LOMLDFJDJHE, int POAJBPPNNHO, KJEFMHLMPGH FDFIAAFCBPI, JobHandle DNKOAJMNLIH)
		{
			return default(BLCGALOKHEC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private EntityQuery NPKAFMCGBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private EntityQuery POBDHNMDEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private AGPODNPCKBE JPAFMOCGAFD;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	protected abstract ComponentType PMPMCBLIALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected abstract ComponentType IOCAMNDAIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	protected abstract ComponentType DLJIGOFNNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x5E63F90", Offset = "0x5E62790", VA = "0x185E63F90")]
	protected AMEMCDCEAHM(DGJIKJLGCCH KFIEDGIKACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x5E62300", Offset = "0x5E60B00", VA = "0x185E62300", Slot = "14")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x5E62A90", Offset = "0x5E61290", VA = "0x185E62A90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x5E62CA0", Offset = "0x5E614A0", VA = "0x185E62CA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x7E7FB0", Offset = "0x7E67B0", VA = "0x1807E7FB0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x5E62950", Offset = "0x5E61150", VA = "0x185E62950")]
	private void MNJJANLONFL(NativeArray<Entity> HBKECNHANOP, EntityCommandBuffer FBMJLIEEDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x5E629F0", Offset = "0x5E611F0", VA = "0x185E629F0")]
	private void OJBJDDEHCKP(NativeArray<Entity> HBKECNHANOP, EntityCommandBuffer FBMJLIEEDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x5E62660", Offset = "0x5E60E60", VA = "0x185E62660")]
	private void HCNKCOPCKOB(BLCGALOKHEC EOKEJLCPIKB, string JLLCDOEMBKB, EntityCommandBuffer FBMJLIEEDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x5E627B0", Offset = "0x5E60FB0", VA = "0x185E627B0")]
	private void HCNKCOPCKOB(NativeListAsync<Entity> INNDNHEFPLJ, string JLLCDOEMBKB, EntityCommandBuffer FBMJLIEEDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x5E623E0", Offset = "0x5E60BE0", VA = "0x185E623E0")]
	private void GHELNKLABBP(BLCGALOKHEC EOKEJLCPIKB, string JLLCDOEMBKB, EntityCommandBuffer FBMJLIEEDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x5E62530", Offset = "0x5E60D30", VA = "0x185E62530")]
	private void GHELNKLABBP(NativeListAsync<Entity> INNDNHEFPLJ, string JLLCDOEMBKB, EntityCommandBuffer FBMJLIEEDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x5E628E0", Offset = "0x5E610E0", VA = "0x185E628E0")]
	private bool JACJFHJECND()
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
	public class PhysicsSceneAddCollidersSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		private struct PhysicsSceneAddCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			public PhysicsSceneAddCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0x5E79C60", Offset = "0x5E78460", VA = "0x185E79C60")]
			private void KJMBDHFEAAM(Entity e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x5E79BB0", Offset = "0x5E783B0", VA = "0x185E79BB0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private IKBDCBDDCKM ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private JPCLBEACHKO colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private EntityQuery PhysicsSceneAddCollidersSystem_Query;

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A040", Offset = "0x5E78840", VA = "0x185E7A040", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x5E79B50", Offset = "0x5E78350", VA = "0x185E79B50", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A0A0", Offset = "0x5E788A0", VA = "0x185E7A0A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x5E79D80", Offset = "0x5E78580", VA = "0x185E79D80")]
		private void LBGLLGOAJMP(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x5E79E70", Offset = "0x5E78670", VA = "0x185E79E70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PhysicsSceneAddCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[DMDOGFFEKFK(PJHIMKBCGDP.OMRoom)]
[AMCOHLDKFON]
public class KECKCDLJJGN : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private JPCLBEACHKO AGAOCMCEOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private NGKJMLHKKJA MJIDHJMLMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x5E738F0", Offset = "0x5E720F0", VA = "0x185E738F0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x5E73960", Offset = "0x5E72160", VA = "0x185E73960", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x5E73A10", Offset = "0x5E72210", VA = "0x185E73A10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public KECKCDLJJGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public struct NJAHFALEOKO : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public JAOCJEPKNDC KPAMIOKBGLD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0")]
	public static NJAHFALEOKO FEBAGKLNOCP([In] JAOCJEPKNDC GLLMFKDOPLK)
	{
		return default(NJAHFALEOKO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA60A0", VA = "0x180AA78A0")]
	public static JAOCJEPKNDC FEBAGKLNOCP([In] NJAHFALEOKO IAFMADOJDEK)
	{
		return default(JAOCJEPKNDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[AlwaysUpdateSystem]
public class IKBDCBDDCKM : MHNPHMEOCAG
{
	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x5E72830", Offset = "0x5E71030", VA = "0x185E72830", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public IKBDCBDDCKM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
	public class PhysicsSceneRemoveCollidersSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000107")]
		private struct PhysicsSceneRemoveCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public PhysicsSceneRemoveCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			[ReadOnly]
			public ComponentTypeHandle<NJAHFALEOKO> __chTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A450", Offset = "0x5E78C50", VA = "0x185E7A450")]
			private void KJMBDHFEAAM(Entity e, [In] NJAHFALEOKO ch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A330", Offset = "0x5E78B30", VA = "0x185E7A330", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private IKBDCBDDCKM ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private JPCLBEACHKO colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private EntityQuery PhysicsSceneRemoveCollidersSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private ComponentTypeHandle<NJAHFALEOKO> __RecRoom_ObjectModel_Systems_PhysicsSceneColliderHandleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A710", Offset = "0x5E78F10", VA = "0x185E7A710", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A2D0", Offset = "0x5E78AD0", VA = "0x185E7A2D0", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A770", Offset = "0x5E78F70", VA = "0x185E7A770", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A1A0", Offset = "0x5E789A0", VA = "0x185E7A1A0")]
		private void DDHBEJBLDKC(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A500", Offset = "0x5E78D00", VA = "0x185E7A500", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PhysicsSceneRemoveCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
public class DAHLIOCMIGM : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private struct ILJAGPDBBNK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public EJIFDEEOFIA DFJLJGOOCKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public NativeParallelHashSet<Entity> FAIFKAKJOPP;

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x5E728D0", Offset = "0x5E710D0", VA = "0x185E728D0")]
		public ILJAGPDBBNK(int AFOFPPEGLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x5E72860", Offset = "0x5E71060", VA = "0x185E72860", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[BurstCompile]
	private struct EPIBFMLJBCK : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[ReadOnly]
		public NativeArray<Entity> FAIFKAKJOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[ReadOnly]
		public ComponentDataFromEntity<HDPLCCLBLHA> BLKEHNCAMNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		[ReadOnly]
		public ComponentDataFromEntity<DFNEPJFFJAA> CABKBJDJIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		[ReadOnly]
		public ComponentDataFromEntity<MILHEFEKDGC> CGPMINHMNIB;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C950", Offset = "0x5E6B150", VA = "0x185E6C950", Slot = "4")]
		public void Execute(int LFEFGCGCIAG, TransformAccess CPMBJLDHCID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[BurstCompile]
	private struct GGGOGOOIJPG : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		[ReadOnly]
		public NativeArray<Entity> FAIFKAKJOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		[ReadOnly]
		public ComponentDataFromEntity<HDPLCCLBLHA> BLKEHNCAMNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		[ReadOnly]
		public ComponentDataFromEntity<MILHEFEKDGC> CGPMINHMNIB;

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E4B0", Offset = "0x5E6CCB0", VA = "0x185E6E4B0", Slot = "4")]
		public void Execute(int LFEFGCGCIAG, TransformAccess CPMBJLDHCID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private JPCLBEACHKO AGAOCMCEOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private EntityQuery JNDNECGAKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private EntityQuery EIEGNEDGMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery OCJOJGBAIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private EntityQuery JCAONFKNGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery BNMEAHEGPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private JobHandle NGKEPPMLENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private ILJAGPDBBNK LNNBALBJEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private ILJAGPDBBNK KJLIIDDLJNK;

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB10", Offset = "0x5E69310", VA = "0x185E6AB10", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B090", Offset = "0x5E69890", VA = "0x185E6B090", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B370", Offset = "0x5E69B70", VA = "0x185E6B370", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B380", Offset = "0x5E69B80", VA = "0x185E6B380", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BBA0", Offset = "0x5E6A3A0", VA = "0x185E6BBA0")]
	private void PJKLMCAHGAM(EntityQuery LGGGLPHDMCK, [Out] (NativeArrayAsync<NJAHFALEOKO> handles, NativeArrayAsync<MGNOMCEDPAJ> bounds) AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A8C0", Offset = "0x5E690C0", VA = "0x185E6A8C0")]
	private void INHJJGIPMJA((NativeArrayAsync<NJAHFALEOKO> handles, NativeArrayAsync<MGNOMCEDPAJ> bounds) AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB70", Offset = "0x5E69370", VA = "0x185E6AB70")]
	private void JIDADDNDNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A620", Offset = "0x5E68E20", VA = "0x185E6A620")]
	private void BDBIPHJHCLP(EntityQuery LGGGLPHDMCK, [Out] (NativeArrayAsync<Entity> entities, NativeArrayAsync<NJAHFALEOKO> handles) AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AC70", Offset = "0x5E69470", VA = "0x185E6AC70")]
	private void LOAMNNLMECH((NativeArrayAsync<Entity> entities, NativeArrayAsync<NJAHFALEOKO> handles) AELCABDCBDD, ILJAGPDBBNK EEGIPOEDBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AF30", Offset = "0x5E69730", VA = "0x185E6AF30")]
	private JobHandle OGGNEAHKHHB(ILJAGPDBBNK EEGIPOEDBDO, ComponentDataFromEntity<HDPLCCLBLHA> BLKEHNCAMNI, ComponentDataFromEntity<MILHEFEKDGC> CGPMINHMNIB, ComponentDataFromEntity<DFNEPJFFJAA> CABKBJDJIDA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A760", Offset = "0x5E68F60", VA = "0x185E6A760")]
	private JobHandle BEICHNMJOFF(ILJAGPDBBNK EEGIPOEDBDO, ComponentDataFromEntity<HDPLCCLBLHA> BLKEHNCAMNI, ComponentDataFromEntity<MILHEFEKDGC> CGPMINHMNIB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public DAHLIOCMIGM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010C")]
public struct PDDKBALEPAC : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
[AMCOHLDKFON]
public class MOEGPBMJPJK : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct PNHCEPHLPEF : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		[ReadOnly]
		public NativeArray<Entity> PNCFEKGOPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		[ReadOnly]
		public ComponentDataFromEntity<AABJHPEEABP> PLFMFEFPGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		[ReadOnly]
		public ComponentDataFromEntity<MGNOMCEDPAJ> DPBKKLCCNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		[WriteOnly]
		public NativeParallelHashSet<Entity>.ParallelWriter EAJBMFOEOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter KCKMCFBEJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter AMGCMAOLDLI;

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E79A70", Offset = "0x5E78270", VA = "0x185E79A70", Slot = "4")]
		public void Execute(int LFEFGCGCIAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[BurstCompile]
	private struct HGPEBCPPFBK : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[ReadOnly]
		public NativeArray<Entity> BALNPNLOHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> ECLPLGEEBPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		[ReadOnly]
		public ComponentDataFromEntity<DFMOOBPAIKI> NCEBIJIJDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		[ReadOnly]
		public ComponentDataFromEntity<GLIEJDBHEBG> LKLLBBKNFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		[NativeDisableParallelForRestriction]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<MGNOMCEDPAJ> GHKLBEIBCEJ;

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E70090", Offset = "0x5E6E890", VA = "0x185E70090", Slot = "4")]
		public void Execute(int LFEFGCGCIAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private EntityQuery EJHGNIPKMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private EntityQuery KIJMLAABKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private EntityQuery PLFEOPMCEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery DKNBBGNAEEG;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x5E75550", Offset = "0x5E73D50", VA = "0x185E75550", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x5E75780", Offset = "0x5E73F80", VA = "0x185E75780", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x5E74CB0", Offset = "0x5E734B0", VA = "0x185E74CB0")]
	private JobHandle FMJACBHGPIL(NativeArrayAsync<Entity> INLAJDDNHAO, int HPFMIMMLOKB, JobHandle DNKOAJMNLIH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x5E74D90", Offset = "0x5E73590", VA = "0x185E74D90")]
	private JobHandle FMJACBHGPIL(NativeArray<Entity> NJCLAPEMLIH, int HPFMIMMLOKB, [Optional] JobHandle DNKOAJMNLIH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x5E74FA0", Offset = "0x5E737A0", VA = "0x185E74FA0")]
	private (NativeListAsync<Entity>, NativeListAsync<Entity>) FNPBEBFPBPC(NativeArrayAsync<Entity> FMNFFINHFGA)
	{
		return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x5E74AC0", Offset = "0x5E732C0", VA = "0x185E74AC0")]
	private void BALFGOPIDJK([Out] NativeArray<Entity> FAIFKAKJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x5E754C0", Offset = "0x5E73CC0", VA = "0x185E754C0")]
	private void OLOGNMPBCCA(NativeList<Entity> FAIFKAKJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x5E753E0", Offset = "0x5E73BE0", VA = "0x185E753E0")]
	private void OLOGNMPBCCA(NativeArray<Entity> FAIFKAKJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E74B40", Offset = "0x5E73340", VA = "0x185E74B40")]
	private void DIAKLOBMIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void IIPFEMDPNEP(int HEFKEEBINPB, int DPGDPJBPEFA, int EICGNGFCCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E75DA0", Offset = "0x5E745A0", VA = "0x185E75DA0")]
	private static MGNOMCEDPAJ PHOHCIGIDND(NativeArray<Entity> DLBNMHAPODK, ComponentDataFromEntity<DFMOOBPAIKI> NCEBIJIJDJK, ComponentDataFromEntity<GLIEJDBHEBG> LKLLBBKNFGH)
	{
		return default(MGNOMCEDPAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public MOEGPBMJPJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[AMCOHLDKFON]
public class BPMIJDOIEMI : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private static readonly DGJIKJLGCCH DMJNBJCNDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	[NMIHDJKFGCM]
	private OGDIMNHIMAP NAAMDKNABOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private EntityQuery MGEJJDIGOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000382")]
	private EntityQuery PBPFENGGCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E66B90", Offset = "0x5E65390", VA = "0x185E66B90", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E66FB0", Offset = "0x5E657B0", VA = "0x185E66FB0")]
	public bool PGEOOOFCIGK(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E66EA0", Offset = "0x5E656A0", VA = "0x185E66EA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E66BE0", Offset = "0x5E653E0", VA = "0x185E66BE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x81A510", Offset = "0x818D10", VA = "0x18081A510", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E66F90", Offset = "0x5E65790", VA = "0x185E66F90", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E66BE0", Offset = "0x5E653E0", VA = "0x185E66BE0")]
	private void JMLKOONIEGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E66C00", Offset = "0x5E65400", VA = "0x185E66C00")]
	private void MCGAPLJDACM(EntityQuery LGGGLPHDMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E67090", Offset = "0x5E65890", VA = "0x185E67090")]
	private void PKLOMJGMAFI(NativeArray<Entity> FAIFKAKJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public BPMIJDOIEMI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal struct DNJIBJOLAAM : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
	internal class CopyOwnerToEntitySystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct CopyOwnerToEntitySystem_RemoveDisembodied_Job
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public CopyOwnerToEntitySystem __this;

			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x5E6A2F0", Offset = "0x5E68AF0", VA = "0x185E6A2F0")]
			public void BGFNMCFNONH(EntityQuery query)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000114")]
		private struct CopyOwnerToEntitySystem_Clear_Job
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public CopyOwnerToEntitySystem __this;

			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0x5E68F70", Offset = "0x5E67770", VA = "0x185E68F70")]
			public void BGFNMCFNONH(EntityQuery query)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private LDNONJHJNKB objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private FAKFCMGGDPE dependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private EntityQuery add;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private EntityQuery remove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private EntityQuery clear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private EntityQuery CopyOwnerToEntitySystem_RemoveDisembodied_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private EntityQuery CopyOwnerToEntitySystem_Clear_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private ComponentTypeHandle<PFDPMNJGABK> __RecRoom_Components_PhotonOwnerData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private ComponentTypeHandle<CKFFMKFJMKD> __RecRoom_Components_PhotonOwnerWatcherData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E695F0", Offset = "0x5E67DF0", VA = "0x185E695F0", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E69FD0", Offset = "0x5E687D0", VA = "0x185E69FD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A170", Offset = "0x5E68970", VA = "0x185E6A170", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A0A0", Offset = "0x5E688A0", VA = "0x185E6A0A0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E69730", Offset = "0x5E67F30", VA = "0x185E69730")]
		private void LOPPCMNONEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E68EB0", Offset = "0x5E676B0", VA = "0x185E68EB0")]
		private void BBJABLALEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E69530", Offset = "0x5E67D30", VA = "0x185E69530")]
		private void HEADDPCPPFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E692C0", Offset = "0x5E67AC0", VA = "0x185E692C0")]
		private void HBLCBDEBEJK(Entity e, [In] CKFFMKFJMKD watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E69660", Offset = "0x5E67E60", VA = "0x185E69660")]
		private void JGPLMHFMPLM(INJNNPDEJLM localId, int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E68EA0", Offset = "0x5E676A0", VA = "0x185E68EA0")]
		private void EKPEKODCJPN(Entity e, [In] PFDPMNJGABK _, [In] CKFFMKFJMKD watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A240", Offset = "0x5E68A40", VA = "0x185E6A240")]
		private void PGLAPHBHGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E68EA0", Offset = "0x5E676A0", VA = "0x185E68EA0")]
		private void AIBLNNKPGEC(Entity e, [In] PFDPMNJGABK _, [In] CKFFMKFJMKD watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E69210", Offset = "0x5E67A10", VA = "0x185E69210")]
		private void GBJHADLLJBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E69C10", Offset = "0x5E68410", VA = "0x185E69C10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public CopyOwnerToEntitySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x5E68EA0", Offset = "0x5E676A0", VA = "0x185E68EA0")]
		[CompilerGenerated]
		private void FAMJGMPBGGA(Entity e, [In] PFDPMNJGABK _, [In] CKFFMKFJMKD watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E68EA0", Offset = "0x5E676A0", VA = "0x185E68EA0")]
		[CompilerGenerated]
		private void OGJIIEJJEKP(Entity e, [In] PFDPMNJGABK _, [In] CKFFMKFJMKD watcherData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class HKPPIGNDENN : DPGFJAECHAF, GJOKPFDLDCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct NNLHHPOHCMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public NativeParallelHashMap<Entity, int> modifiedOwners;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public ComponentDataFromEntity<PFDPMNJGABK> ownershipDataRO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private FAKFCMGGDPE LDGALPGEMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private NCJBBOLFFDA FBFHEKKFIJH;

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E70380", Offset = "0x5E6EB80", VA = "0x185E70380", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E70AC0", Offset = "0x5E6F2C0", VA = "0x185E70AC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E70BA0", Offset = "0x5E6F3A0", VA = "0x185E70BA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E70480", Offset = "0x5E6EC80", VA = "0x185E70480")]
	private void MNOBOOBMIAJ(NativeArray<Entity> FAIFKAKJOPP, NativeParallelHashMap<Entity, int> EODJBEDADOP, ComponentDataFromEntity<PFDPMNJGABK> GLCJIMNMGGP, BufferFromEntity<ChildrenData> HOGKJDCEOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public HKPPIGNDENN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E703F0", Offset = "0x5E6EBF0", VA = "0x185E703F0")]
	[CompilerGenerated]
	internal static int MMLLFBJMHDF(Entity KCMPKMKBCOO, NNLHHPOHCMB P_1)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
[AlwaysUpdateSystem]
public class IHCJJEJMGAG : DPGFJAECHAF, GJOKPFDLDCJ, GMMHILFNMPG
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class LEOHALFLJGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public INJNNPDEJLM localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public NDKHHGHCMFD collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public bool collidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public GNAOGINMILN containerFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public bool physicsEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public bool gravityEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public bool hasUnityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public IHCJJEJMGAG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public LEOHALFLJGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E743E0", Offset = "0x5E72BE0", VA = "0x185E743E0")]
		internal void HBCKJNEPBJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E742D0", Offset = "0x5E72AD0", VA = "0x185E742D0")]
		internal void HALMIFLEOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E741B0", Offset = "0x5E729B0", VA = "0x185E741B0")]
		internal void BOBDONCLOLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	[NMIHDJKFGCM]
	private BMDAIBCMAJA NDHJOJBKKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	[NMIHDJKFGCM]
	private FLLLIFEEDMK BPABABDKIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	[NMIHDJKFGCM]
	private EJDAAEMCDOG MFJCOKIGLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public ComponentTypeHandle<GNAOGINMILN> LGLMGKFJJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public ComponentTypeHandle<CNJKOAPMJNK> LFFKNJDGNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public ComponentTypeHandle<BGBBDBFDLLI> HJLABKCJCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public ComponentTypeHandle<AKKHNLKGCGO> HHFCCMONKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public ComponentTypeHandle<ADFAAGPOMMJ> AOMNGLOFCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public DynamicComponentTypeHandle JCCGKKMJEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public EntityTypeHandle DOJJJLJPKLK;

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E71280", Offset = "0x5E6FA80", VA = "0x185E71280", Slot = "15")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E71350", Offset = "0x5E6FB50", VA = "0x185E71350", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E71700", Offset = "0x5E6FF00", VA = "0x185E71700", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E710C0", Offset = "0x5E6F8C0", VA = "0x185E710C0")]
	private void CDEPCKKCHAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E71400", Offset = "0x5E6FC00", VA = "0x185E71400")]
	private bool JACJFHJECND([Out] int FFONELOKCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public IHCJJEJMGAG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[AlwaysUpdateSystem]
	[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
	[CompilerGenerated]
	public class UpdateSplineGameCollidersSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200011A")]
		public struct SplineGameCollisionSystemTag : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct ProcessCollisionModeChangesForSplineGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			[ReadOnly]
			public ComponentDataFromEntity<CIADMAIBJCK> splineComponentAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ComponentTypeHandle<CNJKOAPMJNK> __collisionModeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public BufferTypeHandle<ChildrenData> __childrenTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AC30", Offset = "0x5E79430", VA = "0x185E7AC30")]
			private void KJMBDHFEAAM([In] CNJKOAPMJNK collisionMode, DynamicBuffer<ChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AAC0", Offset = "0x5E792C0", VA = "0x185E7AAC0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011C")]
		private struct ProcessActiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			[ReadOnly]
			public ComponentDataFromEntity<CNJKOAPMJNK> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A9E0", Offset = "0x5E791E0", VA = "0x185E7A9E0")]
			private void KJMBDHFEAAM(Entity entity, [In] ParentData parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A8C0", Offset = "0x5E790C0", VA = "0x185E7A8C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011D")]
		private struct ProcessInactiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			[ReadOnly]
			public ComponentDataFromEntity<CNJKOAPMJNK> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B0D0", Offset = "0x5E798D0", VA = "0x185E7B0D0")]
			private void KJMBDHFEAAM(Entity entity, [In] ParentData parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AFB0", Offset = "0x5E797B0", VA = "0x185E7AFB0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct UpdateSplineGameCollidersSystem_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0x5E7F1A0", Offset = "0x5E7D9A0", VA = "0x185E7F1A0")]
			private void KJMBDHFEAAM(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0x5E7F0F0", Offset = "0x5E7D8F0", VA = "0x185E7F0F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		private struct ProcessSplineEditsForGameCollision_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			[ReadOnly]
			public ComponentTypeHandle<AABJHPEEABP> splinePointParentHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			[ReadOnly]
			public EntityTypeHandle entityHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public EntityQueryInJob splinePointEditedQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public EntityQueryInJob splineStructureChangedQueryInJob;

			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B1B0", Offset = "0x5E799B0", VA = "0x185E7B1B0")]
			private void KJMBDHFEAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B1A0", Offset = "0x5E799A0", VA = "0x185E7B1A0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B700", Offset = "0x5E79F00", VA = "0x185E7B700")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void NCKDDFJJGEJ(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private CGJJOCFJIKF splineCollisionService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private EntityQuery collisionModeChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private EntityQuery activeSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private EntityQuery inactiveSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private EntityQuery splinePointEditedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private EntityQuery splineStructureChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private EntityQuery splinesDeletedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private EntityQuery ProcessCollisionModeChangesForSplineGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private EntityQuery ProcessActiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private EntityQuery ProcessInactiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private EntityQuery UpdateSplineGameCollidersSystem_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private ComponentTypeHandle<CNJKOAPMJNK> __RecRoom_Components_ContainerCollisionModeData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E7ED00", Offset = "0x5E7D500", VA = "0x185E7ED00", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E7FDC0", Offset = "0x5E7E5C0", VA = "0x185E7FDC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E7FFA0", Offset = "0x5E7E7A0", VA = "0x185E7FFA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E7EAF0", Offset = "0x5E7D2F0", VA = "0x185E7EAF0")]
		private void HGCJEJACLLL(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F250", Offset = "0x5E7DA50", VA = "0x185E7F250")]
		private void MLDCCNBPIGJ(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E7EF40", Offset = "0x5E7D740", VA = "0x185E7EF40")]
		private void LOHKBBMNNKC(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E740", Offset = "0x5E7CF40", VA = "0x185E7E740")]
		private void GGJANFKMMHK(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E7ED50", Offset = "0x5E7D550", VA = "0x185E7ED50")]
		private void KNGMIKPEABG(EntityCommandBuffer ecb, ComponentDataFromEntity<CIADMAIBJCK> splineComponentAccess, ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E830", Offset = "0x5E7D030", VA = "0x185E7E830")]
		private void GPIHAPNINDN(EntityCommandBuffer ecb, ComponentDataFromEntity<CNJKOAPMJNK> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E990", Offset = "0x5E7D190", VA = "0x185E7E990")]
		private void HCEDJKLDHHB(EntityCommandBuffer ecb, ComponentDataFromEntity<CNJKOAPMJNK> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F510", Offset = "0x5E7DD10", VA = "0x185E7F510")]
		private void MOJJBDNALON(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E80740", Offset = "0x5E7EF40", VA = "0x185E80740")]
		private void PKNJOHFCCGH(ComponentTypeHandle<AABJHPEEABP> splinePointParentHandle, EntityTypeHandle entityHandle, ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess, EntityQueryInJob splinePointEditedQueryInJob, EntityQueryInJob splineStructureChangedQueryInJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F600", Offset = "0x5E7DE00", VA = "0x185E7F600", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public UpdateSplineGameCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
[AMCOHLDKFON]
public class PKJLLKAHJJB : DPGFJAECHAF, GMMHILFNMPG, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[BurstCompile]
	private struct HFAADLBDKCN : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		[ReadOnly]
		public EntityTypeHandle EOMOOPCJFMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		[ReadOnly]
		public ComponentTypeHandle<HDPLCCLBLHA> LCOBLOMHCDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		[WriteOnly]
		public NativeList<DOIHIGCEKFD>.ParallelWriter GBBPDLJCCKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public ComponentTypeHandle<FNELLBMCOOE> DEIJLPGIOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public float3 KMJKCJJHEFM;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly float4x2 KDBEJHGOJEM;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private static readonly float4x2 JMECEAOPALM;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly int4x2 JKFKFCAAIMH;

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F970", Offset = "0x5E6E170", VA = "0x185E6F970", Slot = "4")]
		public void Execute(ArchetypeChunk CKCLFCHPNMG, int EHIGJHACLEP, int CNOFOJCHNJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private static DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private EntityQuery LOEMGIFMCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private EntityQuery JIBEAHLPJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private double KEFMJOEMKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private NCJBBOLFFDA AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private AGLDANFEMLE KFBJHEHMNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private PDJBPFDHMMJ MLDHMBALKBH;

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E792A0", Offset = "0x5E77AA0", VA = "0x185E792A0", Slot = "14")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E79320", Offset = "0x5E77B20", VA = "0x185E79320", Slot = "15")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E79650", Offset = "0x5E77E50", VA = "0x185E79650", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E797C0", Offset = "0x5E77FC0", VA = "0x185E797C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E792B0", Offset = "0x5E77AB0", VA = "0x185E792B0")]
	private bool ICJEMAGMHIK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E793B0", Offset = "0x5E77BB0", VA = "0x185E793B0")]
	private void MGJIBKGAPHM(EntityQuery LGGGLPHDMCK, float3 KCPCJIILFFI, string HNHMJGCODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public PKJLLKAHJJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public struct DOIHIGCEKFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public Entity KCMPKMKBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public DAIDGMABGPE OEHHBJMJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public DAIDGMABGPE JHENJKJEFON;
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
public class LBAKLAGJCBJ : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private AGLDANFEMLE KFBJHEHMNOG;

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E74140", Offset = "0x5E72940", VA = "0x185E74140", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E74190", Offset = "0x5E72990", VA = "0x185E74190", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public LBAKLAGJCBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public class KKHLCLPACIF : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E73E10", Offset = "0x5E72610", VA = "0x185E73E10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E73ED0", Offset = "0x5E726D0", VA = "0x185E73ED0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public KKHLCLPACIF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
	[CompilerGenerated]
	public class UpdateInertialPropertiesSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct UpdateInertialPropertiesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x2000127")]
			public delegate void RunWithoutJobSystem_000008A8$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000128")]
			internal static class RunWithoutJobSystem_000008A8$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40003FC")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40003FD")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000712")]
				[Cpp2IlInjected.Address(RVA = "0x5E7B9D0", Offset = "0x5E7A1D0", VA = "0x185E7B9D0")]
				[BurstDiscard]
				private static void JBJHKKNLKOD(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000713")]
				[Cpp2IlInjected.Address(RVA = "0x5E7BB00", Offset = "0x5E7A300", VA = "0x185E7BB00")]
				private static IntPtr JLNOMCGJAEF()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000714")]
				[Cpp2IlInjected.Address(RVA = "0x5E7B920", Offset = "0x5E7A120", VA = "0x185E7B920")]
				public static void BMLNCOHHOFB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000715")]
				[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
				public static void GLJEDCMMNGN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000717")]
				[Cpp2IlInjected.Address(RVA = "0x5E7B750", Offset = "0x5E79F50", VA = "0x185E7B750")]
				public static void BHJKEIPKKOJ(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public EntityQueryInJob isTaggedForUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public EntityQueryInJob rootRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public EntityQueryInJob deformationScaleChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public EntityQueryInJob generalRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public ChunkFilterAnyOf5ComponentsChanged changeFilter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public int maxEntityCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public NativeList<Entity> changedRoots;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			[ReadOnly]
			public EntityExistenceLookupByEntity entityExists;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			[ReadOnly]
			public EntityTypeHandle entityTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			[ReadOnly]
			public ComponentTypeHandle<CMIGNGCNIDC> rbexRootTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			[ReadOnly]
			public ComponentDataFromEntity<DEHNLKNIHLL> rbexIsKinematicRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C810", Offset = "0x5E7B010", VA = "0x185E7C810")]
			private void KJMBDHFEAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C800", Offset = "0x5E7B000", VA = "0x185E7C800", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x5E7CE60", Offset = "0x5E7B660", VA = "0x185E7CE60")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void NCKDDFJJGEJ(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x5E7D070", Offset = "0x5E7B870", VA = "0x185E7D070")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void PJJPMCMDDHM(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery isTaggedForUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private EntityQuery generalRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private EntityQuery rootRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private EntityQuery deformationScaleChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private EntityQuery removeMassOfHierarchyQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private BMDAIBCMAJA rbexServiceCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private LDNONJHJNKB objects;

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C790", Offset = "0x5E7AF90", VA = "0x185E7C790", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D1B0", Offset = "0x5E7B9B0", VA = "0x185E7D1B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D550", Offset = "0x5E7BD50", VA = "0x185E7D550", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BC60", Offset = "0x5E7A460", VA = "0x185E7BC60")]
		protected void FJHOJGMHILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BFA0", Offset = "0x5E7A7A0", VA = "0x185E7BFA0")]
		protected void GMNIEKIHMMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C040", Offset = "0x5E7A840", VA = "0x185E7C040")]
		private bool HEJHDNHEBEG(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, [Out] NativeList<Entity> results)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C470", Offset = "0x5E7AC70", VA = "0x185E7C470")]
		private void HMHPAGAJANC(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, ChunkFilterAnyOf5ComponentsChanged changeFilter, int maxEntityCount, NativeList<Entity> changedRoots, EntityExistenceLookupByEntity entityExists, EntityTypeHandle entityTypeRO, ComponentTypeHandle<CMIGNGCNIDC> rbexRootTypeRO, ComponentDataFromEntity<DEHNLKNIHLL> rbexIsKinematicRO, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D0C0", Offset = "0x5E7B8C0", VA = "0x185E7D0C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public UpdateInertialPropertiesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C750", Offset = "0x5E7AF50", VA = "0x185E7C750")]
		public static void IJGKBCMPJGG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	public class UpdateMassOfShapesSystem : DPGFJAECHAF
	{
		[Cpp2IlInjected.Token(Token = "0x200012A")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct UpdateMassOfShapesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			[ReadOnly]
			public ComponentDataFromEntity<CLPIGHNAAHL> worldDeformableScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			[ReadOnly]
			public ComponentDataFromEntity<MILHEFEKDGC> worldUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			[ReadOnly]
			public ComponentDataFromEntity<HFIACICKMAP> physicsMaterialsRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			[ReadOnly]
			public ComponentDataFromEntity<IEJIMBDOILN> primitiveShapesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			[ReadOnly]
			public ComponentDataFromEntity<JLCBOGGNFCI> localUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			public ComponentDataFromEntity<EOBIIEGEJIN> massesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public ComponentDataFromEntity<MHDKDBLBEIC> centerOfMassesRW;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DAF0", Offset = "0x5E7C2F0", VA = "0x185E7DAF0")]
			private void KJMBDHFEAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DAE0", Offset = "0x5E7C2E0", VA = "0x185E7DAE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private EntityQuery query;

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DF40", Offset = "0x5E7C740", VA = "0x185E7DF40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E080", Offset = "0x5E7C880", VA = "0x185E7E080", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D600", Offset = "0x5E7BE00", VA = "0x185E7D600")]
		private void GPPKHPLPGOE(NativeList<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D910", Offset = "0x5E7C110", VA = "0x185E7D910")]
		private JobHandle LMHHJFEDAFF(NativeList<Entity> entities, ComponentDataFromEntity<CLPIGHNAAHL> worldDeformableScalesRO, ComponentDataFromEntity<MILHEFEKDGC> worldUniformScalesRO, ComponentDataFromEntity<HFIACICKMAP> physicsMaterialsRO, ComponentDataFromEntity<IEJIMBDOILN> primitiveShapesRO, ComponentDataFromEntity<JLCBOGGNFCI> localUniformScalesRO, ComponentDataFromEntity<EOBIIEGEJIN> massesRW, ComponentDataFromEntity<MHDKDBLBEIC> centerOfMassesRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public UpdateMassOfShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
public class MBCFEIPIMAI : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[BurstCompile]
	private struct NBLANMBBECA : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		[ReadOnly]
		public int HDMKEAHIELI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[ReadOnly]
		public EntityQueryInJob JCFBCNFECJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		[ReadOnly]
		public EntityQueryInJob FOEPJADHJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		[ReadOnly]
		public ChunkFilterAnyOf3ComponentsChanged GKBDFFEHFGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		[ReadOnly]
		public EntityTypeHandle DOJJJLJPKLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		[ReadOnly]
		public ComponentDataFromEntity<HFIACICKMAP> KBMOBLKGEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		[ReadOnly]
		public ComponentDataFromEntity<MILHEFEKDGC> ACAJNLBLIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> LJFOMPNPPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		[ReadOnly]
		public ComponentTypeHandle<AABJHPEEABP> GMGEKHKFHAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		[ReadOnly]
		public ComponentDataFromEntity<DFMOOBPAIKI> HDMPODHJHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		[ReadOnly]
		public ComponentDataFromEntity<GLIEJDBHEBG> LKLLBBKNFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		[WriteOnly]
		public ComponentDataFromEntity<EOBIIEGEJIN> HPMLDIIJLBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		[WriteOnly]
		public ComponentDataFromEntity<MHDKDBLBEIC> ENANCOIIDFB;

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x5E76110", Offset = "0x5E74910", VA = "0x185E76110", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x5E76790", Offset = "0x5E74F90", VA = "0x185E76790")]
		private void HFBOPDEDGED(NativeList<Entity> LOILEBKEBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x5E762D0", Offset = "0x5E74AD0", VA = "0x185E762D0")]
		private void HDDHHNPGALL(Entity JBJEFMHIIMG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private EntityQuery BHLAEHMKJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private EntityQuery IHAEOPPAFDJ;

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x5E744E0", Offset = "0x5E72CE0", VA = "0x185E744E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x5E746A0", Offset = "0x5E72EA0", VA = "0x185E746A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x24329F0", Offset = "0x24311F0", VA = "0x1824329F0")]
	private bool NJJJJBFIMNL<T>(T HEIMOINGAHP, [Out] int OMKPPOOBAKJ) where T : struct, IChunkChangeFilter
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public MBCFEIPIMAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
[AMCOHLDKFON]
public class BEMHOHDKCKF : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> BGKPEJKHCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> CLPFJGMLEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> BAAMFLKNMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private JAGAAHOHNNB BOCCKBIBIEE;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x5E656F0", Offset = "0x5E63EF0", VA = "0x185E656F0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x5E65920", Offset = "0x5E64120", VA = "0x185E65920", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x5E64A00", Offset = "0x5E63200", VA = "0x185E64A00")]
	private void BFBGKAAHEBH(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> HBKECNHANOP, EntityQueryDesc EGGOEPDOPKM, bool KFJMODPJOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x5E64B70", Offset = "0x5E63370", VA = "0x185E64B70")]
	private void BFBGKAAHEBH(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> HBKECNHANOP, EntityQueryDesc EGGOEPDOPKM, bool KFJMODPJOOA, bool NOCGKJGODHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x5E65B90", Offset = "0x5E64390", VA = "0x185E65B90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x5E64D00", Offset = "0x5E63500", VA = "0x185E64D00")]
	private void BHMFFCOHDEE(EntityQuery LGGGLPHDMCK, bool EJCEDCKMINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x5E65050", Offset = "0x5E63850", VA = "0x185E65050")]
	private void DIKEKFACICJ(EntityQuery LGGGLPHDMCK, bool HPDBEIBMALN, bool EJCEDCKMINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x5E65480", Offset = "0x5E63C80", VA = "0x185E65480")]
	private void IGHKJOILOLJ(NativeArray<Entity> FAIFKAKJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x5E652F0", Offset = "0x5E63AF0", VA = "0x185E652F0")]
	private void ICIJCOKMHMN(NativeList<Entity> FAIFKAKJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x5E64F10", Offset = "0x5E63710", VA = "0x185E64F10")]
	private void CDMGOEIPJKG(NativeArray<Entity> FAIFKAKJOPP, bool HPDBEIBMALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x5E65E90", Offset = "0x5E64690", VA = "0x185E65E90")]
	private NativeList<Entity> PJJKNLFEAOM(NativeArray<Entity> FAIFKAKJOPP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x5E65270", Offset = "0x5E63A70", VA = "0x185E65270")]
	private NativeList<Entity> GKHCCJMNGKC(NativeArray<Entity> FAIFKAKJOPP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x5E652B0", Offset = "0x5E63AB0", VA = "0x185E652B0")]
	private NativeList<Entity> GMELIFFEAOF(NativeArray<Entity> FAIFKAKJOPP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x5E65740", Offset = "0x5E63F40", VA = "0x185E65740")]
	private NativeList<Entity> JEAOAKKPFEH(NativeArray<Entity> FAIFKAKJOPP, bool HLPLHBGBEKB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x5E66130", Offset = "0x5E64930", VA = "0x185E66130")]
	public BEMHOHDKCKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
public class FBGFCOEKOHC : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private JAGAAHOHNNB BOCCKBIBIEE;

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D490", Offset = "0x5E6BC90", VA = "0x185E6D490", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D4E0", Offset = "0x5E6BCE0", VA = "0x185E6D4E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public FBGFCOEKOHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
public class IPCJNAAMPME : LILACEBNEFC
{
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private static DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private EntityQuery OKAOCOLIFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private EntityQuery NGDFKFBHKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private EntityQuery PIHIODHLBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private EntityQuery IFLAPFNNNND;

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x5E72D10", Offset = "0x5E71510", VA = "0x185E72D10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x5E72EF0", Offset = "0x5E716F0", VA = "0x185E72EF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x5E72B40", Offset = "0x5E71340", VA = "0x185E72B40")]
	private void IPJLMLAPGLL(EntityQuery LGGGLPHDMCK, bool LHEMNDHOIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x5E72970", Offset = "0x5E71170", VA = "0x185E72970")]
	private void FDFGMGJKIGO(EntityQuery LGGGLPHDMCK, bool LHEMNDHOIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public IPCJNAAMPME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
[AlwaysUpdateSystem]
public class COBPDFPHEAO : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	[NMIHDJKFGCM]
	private PPEDACELMBL ONNHHFMGKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	[NMIHDJKFGCM]
	private BMDAIBCMAJA NDHJOJBKKAC;

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x5E677E0", Offset = "0x5E65FE0", VA = "0x185E677E0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x5E67870", Offset = "0x5E66070", VA = "0x185E67870")]
	protected void JLOKJBHLPEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x5E678F0", Offset = "0x5E660F0", VA = "0x185E678F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public COBPDFPHEAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal class DOAGBCAGLPL : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private NCJBBOLFFDA AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private EntityQuery BFIFCKICIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private EntityQuery BANEIKNLMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private NGKJMLHKKJA BFGNFEGPODM;

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C710", Offset = "0x5E6AF10", VA = "0x185E6C710", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C780", Offset = "0x5E6AF80", VA = "0x185E6C780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C8A0", Offset = "0x5E6B0A0", VA = "0x185E6C8A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BFB0", Offset = "0x5E6A7B0", VA = "0x185E6BFB0")]
	private void CBFKCJDHDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BD70", Offset = "0x5E6A570", VA = "0x185E6BD70")]
	private void BKFGIDINFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C290", Offset = "0x5E6AA90", VA = "0x185E6C290")]
	private void ICLAOOGJBLJ(NativeArray<Entity> FAIFKAKJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C100", Offset = "0x5E6A900", VA = "0x185E6C100")]
	private void HEKLCBPCMIG(NativeArray<Entity> FAIFKAKJOPP, int NKJBAGNNFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C600", Offset = "0x5E6AE00", VA = "0x185E6C600")]
	private void IHOEMNFJLAF(NativeArray<Entity> FAIFKAKJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BF30", Offset = "0x5E6A730", VA = "0x185E6BF30")]
	private void BPGDOMJOBMF(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void EGCBGCNLAAL(int DMAJKGMCJKP, Transform CPMBJLDHCID, Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public DOAGBCAGLPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal static class OINCHEOIGBN
{
	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x5E76D60", Offset = "0x5E75560", VA = "0x185E76D60")]
	public static bool FLDNLCJBNOE(this SystemBase JPKIBHPPOBG, [Out] Entity KCMPKMKBCOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal class ADJCEMEGLBI : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private EntityQuery MCOHDPNPNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private JDHDACCAMDF JPEANGNDJAA;

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x5E61360", Offset = "0x5E5FB60", VA = "0x185E61360", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x5E613B0", Offset = "0x5E5FBB0", VA = "0x185E613B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x5E61470", Offset = "0x5E5FC70", VA = "0x185E61470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public ADJCEMEGLBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal class AHJKJHLOOJP : EEBAJJFAACB<OFDGBECOLFM>, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private KMMJLLOECBC GNMDEOAFJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private EntityQuery BHNHOEFHJJC;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private Entity KKKIOEDLGOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x5E61DC0", Offset = "0x5E605C0", VA = "0x185E61DC0")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x5E617B0", Offset = "0x5E5FFB0", VA = "0x185E617B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public INJNNPDEJLM OLPKBNBBEMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x5E61730", Offset = "0x5E5FF30", VA = "0x185E61730")]
		get
		{
			return default(INJNNPDEJLM);
		}
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x5E61570", Offset = "0x5E5FD70", VA = "0x185E61570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x5E61C70", Offset = "0x5E60470", VA = "0x185E61C70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075C")]
	[Cpp2IlInjected.Address(RVA = "0x5E61AC0", Offset = "0x5E602C0", VA = "0x185E61AC0", Slot = "15")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x5E61D20", Offset = "0x5E60520", VA = "0x185E61D20", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x5E61B30", Offset = "0x5E60330", VA = "0x185E61B30", Slot = "14")]
	protected override void KJFGPPKLEOF(NativeArray<Entity> FAIFKAKJOPP, NativeArray<Entity> LKIDBJBCMBA, NativeArray<Entity> NPECCOIJPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075F")]
	[Cpp2IlInjected.Address(RVA = "0x5E615D0", Offset = "0x5E5FDD0", VA = "0x185E615D0")]
	private void DGLBEJIBEGA(NativeArray<Entity> FAIFKAKJOPP, NativeArray<Entity> NPECCOIJPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000760")]
	[Cpp2IlInjected.Address(RVA = "0x5E61830", Offset = "0x5E60030", VA = "0x185E61830")]
	private void INKJOOFIMGP(Entity KCMPKMKBCOO, Entity NPHIPENOMEG, Entity HKLOLAGCEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000761")]
	[Cpp2IlInjected.Address(RVA = "0x29A8BF0", Offset = "0x29A73F0", VA = "0x1829A8BF0")]
	private bool HFGKLMCKFNO<T>([Out] T FKKGMPDEPMA) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000762")]
	[Cpp2IlInjected.Address(RVA = "0x29A8C80", Offset = "0x29A7480", VA = "0x1829A8C80")]
	private void IFDKEMKFOBG<T>(T FKKGMPDEPMA) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000763")]
	[Cpp2IlInjected.Address(RVA = "0x5E616B0", Offset = "0x5E5FEB0", VA = "0x185E616B0")]
	public bool DILFKDPMBBD(INJNNPDEJLM CAAEFNAKJIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000764")]
	[Cpp2IlInjected.Address(RVA = "0x5E61810", Offset = "0x5E60010", VA = "0x185E61810")]
	private static bool HLKBGDHCAOI(INJNNPDEJLM EAKCFJJJNKE, INJNNPDEJLM BIJCGNJGBLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000765")]
	[Cpp2IlInjected.Address(RVA = "0x5E61EB0", Offset = "0x5E606B0", VA = "0x185E61EB0")]
	public AHJKJHLOOJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal class OPMLFAHDJIH : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0x5E78A30", Offset = "0x5E77230", VA = "0x185E78A30", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000768")]
	[Cpp2IlInjected.Address(RVA = "0x5E78BC0", Offset = "0x5E773C0", VA = "0x185E78BC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000769")]
	[Cpp2IlInjected.Address(RVA = "0x5E78C90", Offset = "0x5E77490", VA = "0x185E78C90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x5E78A80", Offset = "0x5E77280", VA = "0x185E78A80")]
	private NativeArray<Entity> LPCAPGPCPEL(int EHGKBCBKPCI)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0x5E78900", Offset = "0x5E77100", VA = "0x185E78900")]
	private void EOLHDDPPFPD(NativeArray<Entity> FNFCCLLKAJA, NativeArray<Entity> NKAOGFMCAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public OPMLFAHDJIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal class HFEFLNKDHNG : DPGFJAECHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private EntityQuery PKJNPPGKCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private EntityQuery HPDICDKFCIL;

	[Cpp2IlInjected.Token(Token = "0x600076E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6FED0", Offset = "0x5E6E6D0", VA = "0x185E6FED0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6FFD0", Offset = "0x5E6E7D0", VA = "0x185E6FFD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000770")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public HFEFLNKDHNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal static class AKGEBMEMMGE
{
	[Cpp2IlInjected.Token(Token = "0x6000771")]
	[Cpp2IlInjected.Address(RVA = "0x29A92C0", Offset = "0x29A7AC0", VA = "0x1829A92C0")]
	public static NativeArray<T> NFKFPKFICCO<T>(NativeArray<Entity> FAIFKAKJOPP, EntityManager IDCNBIGHJII) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000772")]
	[Cpp2IlInjected.Address(RVA = "0x5E61EF0", Offset = "0x5E606F0", VA = "0x185E61EF0")]
	public static void GFCHHMKDGNC(EntityQuery LGGGLPHDMCK, EntityManager IDCNBIGHJII, LDNONJHJNKB CLODAHGGILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x5E62080", Offset = "0x5E60880", VA = "0x185E62080")]
	public static void MLGGOBFJCHM(NativeArray<Entity> FNFCCLLKAJA, LDNONJHJNKB CLODAHGGILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0x5E621C0", Offset = "0x5E609C0", VA = "0x185E621C0")]
	public static void PDPANCPDCOC(NativeArray<Entity> FNFCCLLKAJA, LDNONJHJNKB CLODAHGGILA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal class OOHLIHOBMJF : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private DNNIDJCFDHC DFJLJGOOCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private JEIJFNDLCFE KOJOEBGFGAH;

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x5E78610", Offset = "0x5E76E10", VA = "0x185E78610", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x5E787B0", Offset = "0x5E76FB0", VA = "0x185E787B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x5E78860", Offset = "0x5E77060", VA = "0x185E78860", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x5E78000", Offset = "0x5E76800", VA = "0x185E78000")]
	private void HDLGIOFBOFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x5E786A0", Offset = "0x5E76EA0", VA = "0x185E786A0")]
	private void JBIOCDDIJGL(NativeArray<Entity> FNFCCLLKAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x5E77720", Offset = "0x5E75F20", VA = "0x185E77720")]
	private void GPIAJBFPFLK(NativeArray<Entity> FAIFKAKJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x5E76DF0", Offset = "0x5E755F0", VA = "0x185E76DF0")]
	private void APNGLFNDFOG(NativeArray<Entity> NKAOGFMCAEN, NativeArray<RigidTransform> JGDEHMBPOED, NativeArray<RigidTransform> PLINLPCJCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x5E77290", Offset = "0x5E75A90", VA = "0x185E77290")]
	private void CFNEDKKELIA(NativeArray<RigidTransform> PLINLPCJCAI, NativeArray<Entity> NKAOGFMCAEN, NativeList<Entity> OEGPDPLMEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public OOHLIHOBMJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal class FMKAGHFJBMN : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private EntityQuery MCOHDPNPNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private EntityQuery LMGMFAFDEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private OPDMLJEFMHA AJDKMCHGGOD;

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x5E89AF0", Offset = "0x5E882F0", VA = "0x185E89AF0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x5E89B40", Offset = "0x5E88340", VA = "0x185E89B40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x5E89CA0", Offset = "0x5E884A0", VA = "0x185E89CA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x5E89A80", Offset = "0x5E88280", VA = "0x185E89A80")]
	private void AIFPAKDOEDI(EntityQuery LGGGLPHDMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public FMKAGHFJBMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal class ABOBKACGEIA : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private EntityQuery EKKPLOEPCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private ILCKJNFILLB LPHEEOLMCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private JDHDACCAMDF JPEANGNDJAA;

	[Cpp2IlInjected.Token(Token = "0x6000785")]
	[Cpp2IlInjected.Address(RVA = "0x5E823E0", Offset = "0x5E80BE0", VA = "0x185E823E0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000786")]
	[Cpp2IlInjected.Address(RVA = "0x5E82470", Offset = "0x5E80C70", VA = "0x185E82470", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000787")]
	[Cpp2IlInjected.Address(RVA = "0x5E82520", Offset = "0x5E80D20", VA = "0x185E82520", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000788")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public ABOBKACGEIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal class BMBDCDIDOFD : EEBAJJFAACB<POEKPNADFNC>
{
	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x5E82E00", Offset = "0x5E81600", VA = "0x185E82E00", Slot = "14")]
	protected override void KJFGPPKLEOF(NativeArray<Entity> FAIFKAKJOPP, NativeArray<Entity> LKIDBJBCMBA, NativeArray<Entity> NPECCOIJPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x5E82D30", Offset = "0x5E81530", VA = "0x185E82D30")]
	private static void KJFGPPKLEOF(NativeArray<Entity> FAIFKAKJOPP, NativeArray<Entity> NPECCOIJPPC, ComponentDataFromEntity<global::KIFGGDMCCIB> FIOJBAOMNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x5E82F60", Offset = "0x5E81760", VA = "0x185E82F60")]
	public BMBDCDIDOFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal abstract class EEBAJJFAACB<TPlayerTag> : DPGFJAECHAF where TPlayerTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery MAPLJHAHEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private EntityQuery GIEHFNFMGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private EntityQuery LKCIKFFKANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	private EntityQuery BENCDICEKEK;

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x3060610", Offset = "0x305EE10", VA = "0x183060610", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x3060A60", Offset = "0x305F260", VA = "0x183060A60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x3060A30", Offset = "0x305F230", VA = "0x183060A30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x305FC60", Offset = "0x305E460", VA = "0x18305FC60")]
	private void OICGLPFJAFD(EntityQuery LGGGLPHDMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x305F3D0", Offset = "0x305DBD0", VA = "0x18305F3D0")]
	private void GELPAGBJDFO(EntityQuery LGGGLPHDMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x30602D0", Offset = "0x305EAD0", VA = "0x1830602D0")]
	private void OPHOACAPCOH(EntityQuery LGGGLPHDMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract void KJFGPPKLEOF(NativeArray<Entity> FAIFKAKJOPP, NativeArray<Entity> LKIDBJBCMBA, NativeArray<Entity> NPECCOIJPPC);

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	protected EEBAJJFAACB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct LENJBFKFKHA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public int NEMCGPAIDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public int OGGABIEKFMI;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal struct ICHBKEKJPPB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
public static class OKLNOMLFDBE
{
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly (ComponentType userTag, ComponentType stateTag, ComponentType componentTag)[] NFEFMEBDCGA;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct DDHBCKDLGKA : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct KPEMNCEHABP : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public class KFBOPKCFDEJ : DPGFJAECHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private EntityQuery BEPMMFKHGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private ComponentTypes PGMIHMPFKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private NativeParallelHashSet<int> CHGMBIOFLAN;

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FF80", Offset = "0x5E8E780", VA = "0x185E8FF80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x5E90310", Offset = "0x5E8EB10", VA = "0x185E90310", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x5E90390", Offset = "0x5E8EB90", VA = "0x185E90390", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x5E904D0", Offset = "0x5E8ECD0", VA = "0x185E904D0")]
	public JobHandle PKMLKMDBFHK(JobHandle DNKOAJMNLIH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public KFBOPKCFDEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct PCINNFAAPHH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private NativeArray<DDIOAHAKKEH> GDDOCNJJEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private NativeArray<int> BCGALHGHJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private NativeParallelHashMap<int, DDIOAHAKKEH> JPBFNMGIDBH;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public readonly int PJJOAFPMMLK
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x766100", Offset = "0x764900", VA = "0x180766100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public readonly int KJFONKBDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xADFDB0", Offset = "0xADE5B0", VA = "0x180ADFDB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E930D0", Offset = "0x5E918D0", VA = "0x185E930D0")]
	public PCINNFAAPHH(IReadOnlyCollection<MDPDCPPKJHK> DKEGFJKDJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E92FE0", Offset = "0x5E917E0", VA = "0x185E92FE0")]
	public readonly HMIKALELNFC MOOKDJFLFMC(int JIBGFHDMIBK)
	{
		return default(HMIKALELNFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E92F60", Offset = "0x5E91760", VA = "0x185E92F60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
[DefaultMember("Item")]
public readonly struct HMIKALELNFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private readonly int JIBGFHDMIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private readonly int AMJCJLDHBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	private readonly NativeArray<DDIOAHAKKEH>.ReadOnly CBHFJDMCLMP;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int LPJHKGAOANG
	{
		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E8BE20", Offset = "0x5E8A620", VA = "0x185E8BE20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public DKMHINBNMNP HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E8BE50", Offset = "0x5E8A650", VA = "0x185E8BE50")]
		get
		{
			return default(DKMHINBNMNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public int HEBFKFCDMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE230", Offset = "0x1FBCA30", VA = "0x181FBE230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public NativeArray<DDIOAHAKKEH>.ReadOnly HDADHBBMDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x38FFB60", Offset = "0x38FE360", VA = "0x1838FFB60")]
		get
		{
			return default(NativeArray<DDIOAHAKKEH>.ReadOnly);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BF20", Offset = "0x5E8A720", VA = "0x185E8BF20")]
	public HMIKALELNFC(int JIBGFHDMIBK, int AMJCJLDHBFF, NativeArray<DDIOAHAKKEH>.ReadOnly CBHFJDMCLMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public readonly struct NMKNLLNOEON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public NativeList<Entity> CANHKBHGPMM
	{
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public NativeList<Entity> EODHFKICMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public NativeList<byte> FCPDGMBHPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD474A0", VA = "0x180D48CA0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public NativeList<byte> KDMCJOBECJH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5DC60", VA = "0x180D5F460")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public NativeList<byte> JEFEBLJIHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A60", Offset = "0x8A7260", VA = "0x1808A8A60")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public ComponentType LEKLFNKABPL
	{
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x761C50", Offset = "0x760450", VA = "0x180761C50")]
		[CompilerGenerated]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public JobHandle PJMEDLCAIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x955E50", Offset = "0x954650", VA = "0x180955E50")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public int HEBFKFCDMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x955E60", Offset = "0x954660", VA = "0x180955E60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public int PPDCBMDEPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x7994C0", Offset = "0x797CC0", VA = "0x1807994C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public bool CMCADFPFLJI
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E92280", Offset = "0x5E90A80", VA = "0x185E92280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E92300", Offset = "0x5E90B00", VA = "0x185E92300")]
	public NMKNLLNOEON(ComponentType IPLGGDBFLNE, JobHandle KPAMIOKBGLD, NativeList<Entity> FAIFKAKJOPP, NativeList<Entity> KCHBKDLEPIF, NativeList<byte> ONOBNKPLHCB, NativeList<byte> PIBJOFCOPFL, NativeList<byte> BGCAFEFHGMD, int AMJCJLDHBFF, int GBBCHOLKNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E92160", Offset = "0x5E90960", VA = "0x185E92160", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal interface LKEAAHCANFE
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	bool CMCADFPFLJI
	{
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	NativeArray<AFCHODDKGEA> KKJDDNPHGIM
	{
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	NativeArray<GEPBLNPDOFJ> EMADPKLPHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	NativeArray<AFCHODDKGEA> DMKKFLCINPP
	{
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LJOKPHGHEKP([Out] NativeArray<int> GCADMFLPGGA, Allocator JONICLHJBEP);

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HODFCMIEGLO(ComponentType IPLGGDBFLNE, [Out] NMKNLLNOEON MNBBCMBHBBH, [Out] HMIKALELNFC EBKCCOGJBDL);

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeMultiHashMapAsync<Entity, HDMJOKNPAGJ> GBAECDHKPMJ();
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal static class PIHNDHCAOOK
{
	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E93740", Offset = "0x5E91F40", VA = "0x185E93740")]
	public static bool NBOFKIDLABG(this LKEAAHCANFE CDOGIGHJFKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[PHKIPGBLCCH(PJHIMKBCGDP.LoadInstance)]
internal interface MMAPEGDHBAO
{
	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	NativeParallelMultiHashMap<Entity, HDMJOKNPAGJ> LMONEGDKNIA
	{
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	uint PAMKBMMMMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FFDDEOOLEDE(NativeArray<AFCHODDKGEA> BFBKFPJFMOH, NativeArray<GEPBLNPDOFJ> EIGLBIKONIC, NativeArray<AFCHODDKGEA> GCPBAFELODG, int FPDOMJLBGKN);

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOKCGEPBNEJ([In] NMKNLLNOEON IFDNFIGNFDD);

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHOAIKBPMDC(JobHandle KPAMIOKBGLD);
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
public readonly struct LBMALLKEHFP : IEquatable<LBMALLKEHFP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly OJBFPODPDEH NENKFFLNHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private readonly int GBBCHOLKNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private readonly int IIPEFDGJJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private readonly int HJHABDMAAIM;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public OJBFPODPDEH KFOGLCOKPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80")]
		get
		{
			return default(OJBFPODPDEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E90DD0", Offset = "0x5E8F5D0", VA = "0x185E90DD0")]
	public unsafe ReadOnlySpan<byte> LNAHJEKGBPD(void* CFBMIDIKIBB)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E90B30", Offset = "0x5E8F330", VA = "0x185E90B30")]
	public unsafe ReadOnlySpan<byte> BPPEHLEOHHK(void* CFBMIDIKIBB)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x106F8A0", Offset = "0x106E0A0", VA = "0x18106F8A0")]
	public LBMALLKEHFP(OJBFPODPDEH NENKFFLNHCE, int ALCHALOFNIJ, int IIPEFDGJJAM, int HJHABDMAAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E90BC0", Offset = "0x5E8F3C0", VA = "0x185E90BC0", Slot = "4")]
	public bool Equals(LBMALLKEHFP IFHFGCDLDEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E90C50", Offset = "0x5E8F450", VA = "0x185E90C50", Slot = "0")]
	public override bool Equals(object CBBCDNDPNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E90D60", Offset = "0x5E8F560", VA = "0x185E90D60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
public readonly struct HDMJOKNPAGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly OJBFPODPDEH NENKFFLNHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly int GBBCHOLKNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private unsafe readonly byte* IIPEFDGJJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private unsafe readonly byte* HJHABDMAAIM;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public OJBFPODPDEH KFOGLCOKPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x98FA80", Offset = "0x98E280", VA = "0x18098FA80")]
		get
		{
			return default(OJBFPODPDEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int JFBFKJBMEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x1FBE230", Offset = "0x1FBCA30", VA = "0x181FBE230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public unsafe byte* COPCKBAFDHL
	{
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x98F9E0", Offset = "0x98E1E0", VA = "0x18098F9E0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public unsafe byte* OAKOFMLJKLG
	{
		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E8ADA0", Offset = "0x5E895A0", VA = "0x185E8ADA0")]
	public ICHPGDLGCBL BPPEHLEOHHK(Type GFGNPBCFEMC)
	{
		return default(ICHPGDLGCBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0x2371680", Offset = "0x236FE80", VA = "0x182371680")]
	public T LNAHJEKGBPD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0x2371660", Offset = "0x236FE60", VA = "0x182371660")]
	public T BPPEHLEOHHK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AE90", Offset = "0x5E89690", VA = "0x185E8AE90")]
	public unsafe HDMJOKNPAGJ(OJBFPODPDEH NENKFFLNHCE, int ALCHALOFNIJ, byte* IIPEFDGJJAM, byte* HJHABDMAAIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
public readonly struct DKMHINBNMNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private readonly int JIBGFHDMIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private readonly int NENKFFLNHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private readonly DDIOAHAKKEH PIGGPAHNFPO;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public DDIOAHAKKEH PGFCJOONKON
	{
		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x98F9E0", Offset = "0x98E1E0", VA = "0x18098F9E0")]
		get
		{
			return default(DDIOAHAKKEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E85D10", Offset = "0x5E84510", VA = "0x185E85D10")]
	public DKMHINBNMNP(int JIBGFHDMIBK, int NENKFFLNHCE, DDIOAHAKKEH PIGGPAHNFPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal abstract class HKBPHJBHAML : PAOJLKNKBDD, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	private LKNNFAHLOJG AJBGICFOANP;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	protected abstract DBGBAOPKBDJ NMNNJJJNNDL
	{
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BC90", Offset = "0x5E8A490", VA = "0x185E8BC90", Slot = "16")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BCE0", Offset = "0x5E8A4E0", VA = "0x185E8BCE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B8F0", Offset = "0x5E8A0F0", VA = "0x185E8B8F0", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	protected HKBPHJBHAML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal class OGGLENAAGAM : HKBPHJBHAML
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	protected override DBGBAOPKBDJ NMNNJJJNNDL
	{
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "17")]
		get
		{
			return default(DBGBAOPKBDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E923B0", Offset = "0x5E90BB0", VA = "0x185E923B0")]
	public OGGLENAAGAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal class OGAFIEBCJBO : HKBPHJBHAML
{
	[Cpp2IlInjected.Token(Token = "0x17000108")]
	protected override DBGBAOPKBDJ NMNNJJJNNDL
	{
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x7E1100", Offset = "0x7DF900", VA = "0x1807E1100", Slot = "17")]
		get
		{
			return default(DBGBAOPKBDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E92360", Offset = "0x5E90B60", VA = "0x185E92360")]
	public OGAFIEBCJBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
public class BLOAAKCOPCC : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	[NMIHDJKFGCM]
	private LKNNFAHLOJG OGAAJFBIIBB;

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E82CC0", Offset = "0x5E814C0", VA = "0x185E82CC0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E82D10", Offset = "0x5E81510", VA = "0x185E82D10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public BLOAAKCOPCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
[AlwaysUpdateSystem]
public class ICAHEKLHHLM : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public enum NEBEJCNACMJ
	{
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		Remove
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	[NMIHDJKFGCM]
	private LKNNFAHLOJG AJBGICFOANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private IPFADIAMJIA MKDBLKOLGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private IODEHALNCKK KFAFCMDBGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private OPLBPDHGDCJ KONIEJDHFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private DNMPOAJODHO NNEJEFILFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private DFIIBHOPGKG GAHBKFPMAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private EFICPEDBKFH BMPONKDICHG;

	[Cpp2IlInjected.Token(Token = "0x60007E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C0B0", Offset = "0x5E8A8B0", VA = "0x185E8C0B0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C440", Offset = "0x5E8AC40", VA = "0x185E8C440", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C5B0", Offset = "0x5E8ADB0", VA = "0x185E8C5B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BF30", Offset = "0x5E8A730", VA = "0x185E8BF30")]
	private void GGNJPHBPFGO([Out] NativeArray<AFCHODDKGEA> BFBKFPJFMOH, [Out] NativeArray<GEPBLNPDOFJ> EIGLBIKONIC, [Out] NativeArray<AFCHODDKGEA> GCPBAFELODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C560", Offset = "0x5E8AD60", VA = "0x185E8C560", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C4C0", Offset = "0x5E8ACC0", VA = "0x185E8C4C0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public ICAHEKLHHLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal readonly struct IPFADIAMJIA
{
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private static readonly ProfilerMarker IFAELGPLEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private readonly DPGFJAECHAF JPKIBHPPOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private readonly World JJDPLCCFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private readonly EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private readonly EntityQuery CAIIIDGEAHG;

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E090", Offset = "0x5E8C890", VA = "0x185E8E090")]
	public IPFADIAMJIA(DPGFJAECHAF JPKIBHPPOBG, World JJDPLCCFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DB30", Offset = "0x5E8C330", VA = "0x185E8DB30")]
	public (NativeArray<AFCHODDKGEA>, NativeArray<GEPBLNPDOFJ>) IDAKBLNHKFP()
	{
		return default((NativeArray<AFCHODDKGEA>, NativeArray<GEPBLNPDOFJ>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct EFICPEDBKFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private static readonly ProfilerMarker IFAELGPLEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private readonly DPGFJAECHAF JPKIBHPPOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private NativeList<(EntityQuery query, int componentIndex)> DNNICHMCOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private NativeList<(EntityQuery query, int componentIndex)> CPFFLJGEOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private NativeList<(EntityQuery query, int componentIndex)> MFAADLJJOFN;

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E88620", Offset = "0x5E86E20", VA = "0x185E88620")]
	public EFICPEDBKFH(DPGFJAECHAF JPKIBHPPOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E87850", Offset = "0x5E86050", VA = "0x185E87850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E881A0", Offset = "0x5E869A0", VA = "0x185E881A0")]
	public NativeList<(EntityQuery, int, int, ICAHEKLHHLM.NEBEJCNACMJ)> PMKNBNHELAB(uint PJCFOEAPJHL, [Out] int EMFCPLOPMBA)
	{
		return default(NativeList<(EntityQuery, int, int, ICAHEKLHHLM.NEBEJCNACMJ)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E878B0", Offset = "0x5E860B0", VA = "0x185E878B0")]
	private int IMAHECGPGHK(ICAHEKLHHLM.NEBEJCNACMJ FDFIAAFCBPI, NativeList<(EntityQuery query, int typeIndex)> EIGOIPKAPOI, NativeList<(EntityQuery query, int typeIndex, int count, ICAHEKLHHLM.NEBEJCNACMJ mode)> DEDFPNOAEBD, uint PJCFOEAPJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E87E10", Offset = "0x5E86610", VA = "0x185E87E10")]
	private NativeList<(EntityQuery, int)> KENIIFOOKDJ(NativeParallelHashSet<int> DKEGFJKDJBN, int EBPDLALEFID)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E877B0", Offset = "0x5E85FB0", VA = "0x185E877B0")]
	private NativeList<(EntityQuery, int)> CHBONFBFKGA(NativeParallelHashSet<int> DKEGFJKDJBN, int EBPDLALEFID)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E87A60", Offset = "0x5E86260", VA = "0x185E87A60")]
	private NativeList<(EntityQuery, int)> KDGBAGEAJMJ(NativeParallelHashSet<int> DKEGFJKDJBN, int EBPDLALEFID, ICAHEKLHHLM.NEBEJCNACMJ FDFIAAFCBPI)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E87EB0", Offset = "0x5E866B0", VA = "0x185E87EB0")]
	private NativeList<(EntityQuery, int)> OMCAIELKFOJ()
	{
		return default(NativeList<(EntityQuery, int)>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal readonly struct DFIIBHOPGKG
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[BurstCompile]
	private struct HJIEEALLMLA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		[ReadOnly]
		public EntityTypeHandle OOJIHHACAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		[ReadOnly]
		public ComponentDataFromEntity<LENJBFKFKHA> DHGMOEONKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		[ReadOnly]
		public DynamicComponentTypeHandle IPGLKEFBMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> PBIFCHKOGNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> KIKKOOJMJML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		[ReadOnly]
		public ComponentDataFromEntity ODHCMGDPNFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		[ReadOnly]
		public NativeArray<byte>.ReadOnly NJOKNFKEIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		[ReadOnly]
		public NativeArray<DDIOAHAKKEH>.ReadOnly PKGPBLLKNGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public ComponentDataFromEntity CPEKFIKIJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public NativeList<Entity> PHLFODMMDDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public NativeList<Entity> DAIIMBAGGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public NativeList<byte> NAAPBJEIFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public NativeList<byte> MIPAFNEDIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public NativeList<byte> ELLPINEDHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int GBBCHOLKNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int AMJCJLDHBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public bool FHBJHEKBOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public ICAHEKLHHLM.NEBEJCNACMJ FDFIAAFCBPI;

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B310", Offset = "0x5E89B10", VA = "0x185E8B310", Slot = "4")]
		public void Execute(ArchetypeChunk CKCLFCHPNMG, int EHIGJHACLEP, int CNOFOJCHNJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B0F0", Offset = "0x5E898F0", VA = "0x185E8B0F0")]
		private unsafe bool DAHABLGGOGD(Entity NEIIPPNOFCP, Entity JGIDFNCOAIB, byte* BBHDJMCMFGG, byte* CGFCNHDAKOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B0D0", Offset = "0x5E898D0", VA = "0x185E8B0D0")]
		private unsafe void APFJFNBJOAO(byte* BBHDJMCMFGG, byte* CGFCNHDAKOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B820", Offset = "0x5E8A020", VA = "0x185E8B820")]
		private unsafe byte* JBJCPIPGLAP(NativeArray<byte> KMOPHCCGHFM, int DKLECPOCCOI)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B7B0", Offset = "0x5E89FB0", VA = "0x185E8B7B0")]
		private unsafe byte* JBCPPOEOMOG(Entity JGIDFNCOAIB)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B6C0", Offset = "0x5E89EC0", VA = "0x185E8B6C0")]
		private unsafe byte* HHCBABPEJFF(ArchetypeChunk CKCLFCHPNMG)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x5E8B8C0", Offset = "0x5E8A0C0", VA = "0x185E8B8C0")]
		private static Entity OMKFPECDIEA([In] LENJBFKFKHA AELCABDCBDD)
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[BurstCompile]
	private struct DHOILDDKKHH : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		[ReadOnly]
		public NativeList<Entity> OJILLBGEAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		[ReadOnly]
		public NativeList<byte> DIJBEGIMPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		[ReadOnly]
		public NativeList<byte> BIMGAAPNLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		[ReadOnly]
		public NativeList<byte> LOICBOONBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		[ReadOnly]
		public NativeArray<DDIOAHAKKEH>.ReadOnly PKGPBLLKNGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public NativeParallelMultiHashMap<Entity, HDMJOKNPAGJ> DCHALMKJBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int GBBCHOLKNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public int AMJCJLDHBFF;

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x5E844B0", Offset = "0x5E82CB0", VA = "0x185E844B0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly ProfilerMarker IFAELGPLEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly DPGFJAECHAF JPKIBHPPOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private readonly World JJDPLCCFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private readonly PCINNFAAPHH KOPHBFKIOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private readonly NativeParallelHashMap<int, Entity> LDBGEIIMCFG;

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E84430", Offset = "0x5E82C30", VA = "0x185E84430")]
	public DFIIBHOPGKG(DPGFJAECHAF JPKIBHPPOBG, World JJDPLCCFOHL, LKNNFAHLOJG AJBGICFOANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E83620", Offset = "0x5E81E20", VA = "0x185E83620")]
	public JobHandle IDAKBLNHKFP(MMAPEGDHBAO CDOGIGHJFKJ, NativeList<(EntityQuery query, int typeIndex, int count, ICAHEKLHHLM.NEBEJCNACMJ mode)> CJGPOMHFPKB, JobHandle DNKOAJMNLIH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E84370", Offset = "0x5E82B70", VA = "0x185E84370")]
	private DHOILDDKKHH PFKDLIDCALM([In] HJIEEALLMLA PGGENIGEONF, NativeParallelMultiHashMap<Entity, HDMJOKNPAGJ> ILPIBMMDIFB)
	{
		return default(DHOILDDKKHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E83F60", Offset = "0x5E82760", VA = "0x185E83F60")]
	private HJIEEALLMLA LBBLMMBAGPH(ComponentType IPLGGDBFLNE, EntityManager ANIHIDKMJOA, int BNFDIENJKNP, ICAHEKLHHLM.NEBEJCNACMJ FDFIAAFCBPI)
	{
		return default(HJIEEALLMLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E83E00", Offset = "0x5E82600", VA = "0x185E83E00")]
	private static void KCGCHJDFEMC(MMAPEGDHBAO CDOGIGHJFKJ, ComponentType IPLGGDBFLNE, JobHandle EKJLKMKCKOI, [In] HJIEEALLMLA PGGENIGEONF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal readonly struct DNMPOAJODHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private readonly KFBOPKCFDEJ EGKOBDEGKLI;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private static readonly ProfilerMarker IFAELGPLEAM;

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x5E85F50", Offset = "0x5E84750", VA = "0x185E85F50")]
	public DNMPOAJODHO(World JJDPLCCFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x5E85D20", Offset = "0x5E84520", VA = "0x185E85D20")]
	public JobHandle IDAKBLNHKFP(JobHandle FFKDNLEFKBA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal readonly struct IODEHALNCKK
{
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private static readonly ProfilerMarker IFAELGPLEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private readonly DPGFJAECHAF JPKIBHPPOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private readonly World JJDPLCCFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private readonly EntityQuery NMIAECGLMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private readonly EntityQuery OIFDONHKMDK;

	[Cpp2IlInjected.Token(Token = "0x6000808")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DA00", Offset = "0x5E8C200", VA = "0x185E8DA00")]
	public IODEHALNCKK(DPGFJAECHAF JPKIBHPPOBG, World JJDPLCCFOHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000809")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D730", Offset = "0x5E8BF30", VA = "0x185E8D730")]
	public NativeArray<AFCHODDKGEA> IDAKBLNHKFP()
	{
		return default(NativeArray<AFCHODDKGEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D8B0", Offset = "0x5E8C0B0", VA = "0x185E8D8B0")]
	public void KEDPBPGPIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D3F0", Offset = "0x5E8BBF0", VA = "0x185E8D3F0")]
	private NativeArray<AFCHODDKGEA> HPKKAMDMNCC(EntityQuery LGGGLPHDMCK)
	{
		return default(NativeArray<AFCHODDKGEA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal readonly struct OPLBPDHGDCJ
{
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class CBLNIJICBKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public DPGFJAECHAF system;

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public CBLNIJICBKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x5E83500", Offset = "0x5E81D00", VA = "0x185E83500")]
		internal (EntityQuery, ComponentType) AEJJFODBBKI((ComponentType userTag, ComponentType stateTag, ComponentType componentTag) t)
		{
			return default((EntityQuery, ComponentType));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private static readonly ProfilerMarker IFAELGPLEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private readonly DPGFJAECHAF JPKIBHPPOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private readonly (EntityQuery userTagQuery, ComponentType stateTag)[] IJCGDCEPHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private readonly EntityQuery LFPBHFHKFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private readonly EntityQuery AGNINOJKDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private readonly ComponentTypes CHFOPHJGAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private readonly ComponentTypes DLAAOKLKKKL;

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x5E92960", Offset = "0x5E91160", VA = "0x185E92960")]
	public OPLBPDHGDCJ(DPGFJAECHAF JPKIBHPPOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x5E925E0", Offset = "0x5E90DE0", VA = "0x185E925E0")]
	public void IDAKBLNHKFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal class JKDMFOOHLAK : AMEMCDCEAHM
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct CKGIICOHEMK : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	protected override ComponentType PMPMCBLIALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E6B0", Offset = "0x5E8CEB0", VA = "0x185E8E6B0", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected override ComponentType IOCAMNDAIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E650", Offset = "0x5E8CE50", VA = "0x185E8E650", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	protected override ComponentType DLJIGOFNNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E680", Offset = "0x5E8CE80", VA = "0x185E8E680", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E770", Offset = "0x5E8CF70", VA = "0x185E8E770")]
	public JKDMFOOHLAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal class MKBJNKBDIKN : AMEMCDCEAHM
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	public struct KKDLFCADDND : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	protected override ComponentType PMPMCBLIALC
	{
		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x5E91B80", Offset = "0x5E90380", VA = "0x185E91B80", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected override ComponentType IOCAMNDAIGP
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x5E91B20", Offset = "0x5E90320", VA = "0x185E91B20", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	protected override ComponentType DLJIGOFNNFM
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x5E91B50", Offset = "0x5E90350", VA = "0x185E91B50", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x5E91C40", Offset = "0x5E90440", VA = "0x185E91C40")]
	public MKBJNKBDIKN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000162")]
public struct HCOLLMKGKEK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[AMCOHLDKFON]
public class KPDEDKJCFNI : LILACEBNEFC
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	private struct NHBKFFEEOKC : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		[ReadOnly]
		public NativeParallelHashSet<int> GCGBPFPEGHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		[ReadOnly]
		public EntityTypeHandle DOJJJLJPKLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> NDGMDFHAGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public NativeList<Entity>.ParallelWriter EAPMBPNKMEB;

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x5E91D30", Offset = "0x5E90530", VA = "0x185E91D30", Slot = "4")]
		public void Execute(ArchetypeChunk CKCLFCHPNMG, int EHIGJHACLEP, int CNOFOJCHNJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x5E905C0", Offset = "0x5E8EDC0", VA = "0x185E905C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x5E90650", Offset = "0x5E8EE50", VA = "0x185E90650", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x5E90570", Offset = "0x5E8ED70", VA = "0x185E90570")]
	private EntityCommandBufferSystem CMCIMJNMJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public KPDEDKJCFNI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	[AMCOHLDKFON]
	public class DebugPostDeserializeRemoveOrphanedSplinePointsSystem : LILACEBNEFC
	{
		[Cpp2IlInjected.Token(Token = "0x2000166")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct DebugPostDeserializeRemoveOrphanedSplinePointsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004C9")]
			[ReadOnly]
			public ComponentDataFromEntity<CIADMAIBJCK> splineDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004CA")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public ComponentTypeHandle<AABJHPEEABP> __pointTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0x5E862F0", Offset = "0x5E84AF0", VA = "0x185E862F0")]
			private void KJMBDHFEAAM(Entity entity, [In][NoAlias] AABJHPEEABP point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0x5E861D0", Offset = "0x5E849D0", VA = "0x185E861D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private EntityQuery DebugPostDeserializeRemoveOrphanedSplinePointsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private ComponentTypeHandle<AABJHPEEABP> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x5E86560", Offset = "0x5E84D60", VA = "0x185E86560", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x5E86140", Offset = "0x5E84940", VA = "0x185E86140")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void IJGOONPOMDF(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x5E85FB0", Offset = "0x5E847B0", VA = "0x185E85FB0")]
		private EntityCommandBufferSystem CMCIMJNMJOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x5E86000", Offset = "0x5E84800", VA = "0x185E86000")]
		private JobHandle FGFKNGADAND(EntityCommandBuffer ecb, ComponentDataFromEntity<CIADMAIBJCK> splineDataRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x5E86380", Offset = "0x5E84B80", VA = "0x185E86380", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public DebugPostDeserializeRemoveOrphanedSplinePointsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
[AMCOHLDKFON]
public class FHIHDNLOIFN : LILACEBNEFC
{
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x600082E")]
	[Cpp2IlInjected.Address(RVA = "0x5E88D90", Offset = "0x5E87590", VA = "0x185E88D90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(RVA = "0x5E88E30", Offset = "0x5E87630", VA = "0x185E88E30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(RVA = "0x5E88D40", Offset = "0x5E87540", VA = "0x185E88D40")]
	private EntityCommandBufferSystem CMCIMJNMJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000831")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public FHIHDNLOIFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
[AMCOHLDKFON]
public class LODPMJADICJ : LILACEBNEFC
{
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x6000833")]
	[Cpp2IlInjected.Address(RVA = "0x5E91800", Offset = "0x5E90000", VA = "0x185E91800", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(RVA = "0x5E918C0", Offset = "0x5E900C0", VA = "0x185E918C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0x5E917B0", Offset = "0x5E8FFB0", VA = "0x185E917B0")]
	private EntityCommandBufferSystem CMCIMJNMJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public LODPMJADICJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
[UpdateAfter(typeof(KPDEDKJCFNI))]
public class NJJCBINIOPH : DPGFJAECHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private EntityArchetype KOEIHAKMLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0x5E91EC0", Offset = "0x5E906C0", VA = "0x185E91EC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000839")]
	[Cpp2IlInjected.Address(RVA = "0x5E91FE0", Offset = "0x5E907E0", VA = "0x185E91FE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x5E91E70", Offset = "0x5E90670", VA = "0x185E91E70")]
	private EntityCommandBufferSystem CMCIMJNMJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public NJJCBINIOPH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	internal class PostDeserializeAddSplinePointsToSplinesSystem : DPGFJAECHAF
	{
		[Cpp2IlInjected.Token(Token = "0x200016B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeAddSplinePointsToSplinesSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D7")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000843")]
			[Cpp2IlInjected.Address(RVA = "0x5E93EE0", Offset = "0x5E926E0", VA = "0x185E93EE0")]
			private void KJMBDHFEAAM(Entity spline)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0x5E93E30", Offset = "0x5E92630", VA = "0x185E93E30", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016C")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeAddSplinePointsToSplinesSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			[ReadOnly]
			public ComponentTypeHandle<AABJHPEEABP> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0x5E940B0", Offset = "0x5E928B0", VA = "0x185E940B0")]
			private void KJMBDHFEAAM(Entity splinePoint, [In][NoAlias] AABJHPEEABP splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(RVA = "0x5E93F90", Offset = "0x5E92790", VA = "0x185E93F90", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private EntityQuery PostDeserializeAddSplinePointsToSplinesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private EntityQuery PostDeserializeAddSplinePointsToSplinesSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private ComponentTypeHandle<AABJHPEEABP> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x5E94470", Offset = "0x5E92C70", VA = "0x185E94470", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x5E94530", Offset = "0x5E92D30", VA = "0x185E94530", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x5E93B90", Offset = "0x5E92390", VA = "0x185E93B90")]
		private EntityCommandBufferSystem CMCIMJNMJOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0x5E93BE0", Offset = "0x5E923E0", VA = "0x185E93BE0")]
		private void HKOCKPNPPNN(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0x5E93CE0", Offset = "0x5E924E0", VA = "0x185E93CE0")]
		private void LJJAHCGBHCA(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x5E94160", Offset = "0x5E92960", VA = "0x185E94160", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PostDeserializeAddSplinePointsToSplinesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class IDMOAHOCELA : DPGFJAECHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D0B0", Offset = "0x5E8B8B0", VA = "0x185E8D0B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D180", Offset = "0x5E8B980", VA = "0x185E8D180", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public IDMOAHOCELA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal sealed class PHMJDEAIJHG : ParentSystemBase<ParentData, PreviousParentData, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600084A")]
	[Cpp2IlInjected.Address(RVA = "0x89A900", Offset = "0x899100", VA = "0x18089A900", Slot = "14")]
	protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc LGGGLPHDMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600084B")]
	[Cpp2IlInjected.Address(RVA = "0x89A900", Offset = "0x899100", VA = "0x18089A900", Slot = "15")]
	protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc LGGGLPHDMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x89A900", Offset = "0x899100", VA = "0x18089A900", Slot = "16")]
	protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc LGGGLPHDMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x5E936C0", Offset = "0x5E91EC0", VA = "0x185E936C0", Slot = "17")]
	protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc LGGGLPHDMCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x5E93700", Offset = "0x5E91F00", VA = "0x185E93700")]
	public PHMJDEAIJHG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[AMCOHLDKFON]
	[CompilerGenerated]
	public class PostDeserializeRemoveComponentSerializedVersionDataSystem : DPGFJAECHAF
	{
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x5E94A40", Offset = "0x5E93240", VA = "0x185E94A40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x5E94AE0", Offset = "0x5E932E0", VA = "0x185E94AE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x5E94850", Offset = "0x5E93050", VA = "0x185E94850")]
		private EntityCommandBufferSystem CMCIMJNMJOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x5E948A0", Offset = "0x5E930A0", VA = "0x185E948A0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PostDeserializeRemoveComponentSerializedVersionDataSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
public class HCBDLCJMDCB : BHEEPGONHJF
{
	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AC10", Offset = "0x5E89410", VA = "0x185E8AC10", Slot = "14")]
	protected override EntityCommandBufferSystem CMCIMJNMJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public HCBDLCJMDCB()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	internal class PostDeserializeSortSplinePointsSystem : DPGFJAECHAF
	{
		[Cpp2IlInjected.Token(Token = "0x2000172")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public ComponentDataFromEntity<OLPFDHBGHHP> orderRO;

			[Cpp2IlInjected.Token(Token = "0x600085B")]
			[Cpp2IlInjected.Address(RVA = "0x5E92E60", Offset = "0x5E91660", VA = "0x185E92E60", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000173")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeSortSplinePointsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600085C")]
			[Cpp2IlInjected.Address(RVA = "0x5E94E90", Offset = "0x5E93690", VA = "0x185E94E90")]
			private void KJMBDHFEAAM(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600085D")]
			[Cpp2IlInjected.Address(RVA = "0x5E94D60", Offset = "0x5E93560", VA = "0x185E94D60", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private EntityQuery PostDeserializeSortSplinePointsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0x5E95350", Offset = "0x5E93B50", VA = "0x185E95350", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x5E94F20", Offset = "0x5E93720", VA = "0x185E94F20")]
		private void OJMELFKBNMP(OrderComparer comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x5E95050", Offset = "0x5E93850", VA = "0x185E95050", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PostDeserializeSortSplinePointsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	public class PostDeserializeTransformRootsSystem : DPGFJAECHAF
	{
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeTransformRootsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public ComponentTypeHandle<OAEOJOGLFPE> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0x5E80B00", Offset = "0x5E7F300", VA = "0x185E80B00")]
			private void KJMBDHFEAAM([NoAlias] OAEOJOGLFPE data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0x5E95AF0", Offset = "0x5E942F0", VA = "0x185E95AF0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeTransformRootsSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public ComponentTypeHandle<JLCBOGGNFCI> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000869")]
			[Cpp2IlInjected.Address(RVA = "0x5E80D30", Offset = "0x5E7F530", VA = "0x185E80D30")]
			private void KJMBDHFEAAM([NoAlias] JLCBOGGNFCI data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0x5E95BC0", Offset = "0x5E943C0", VA = "0x185E95BC0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000177")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeTransformRootsSystem_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public ComponentTypeHandle<CEFKKAMGNJB> __authoredPoseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			[ReadOnly]
			public ComponentTypeHandle<OAEOJOGLFPE> __poseTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600086B")]
			[Cpp2IlInjected.Address(RVA = "0x5E80D40", Offset = "0x5E7F540", VA = "0x185E80D40")]
			private void KJMBDHFEAAM([NoAlias] CEFKKAMGNJB authoredPose, [In][NoAlias] OAEOJOGLFPE pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0x5E95C90", Offset = "0x5E94490", VA = "0x185E95C90", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000178")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeTransformRootsSystem_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public ComponentTypeHandle<DEMCMLIOGEO> __authoredScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			[ReadOnly]
			public ComponentTypeHandle<JLCBOGGNFCI> __scaleTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0x5E80D60", Offset = "0x5E7F560", VA = "0x185E80D60")]
			private void KJMBDHFEAAM([NoAlias] DEMCMLIOGEO authoredScale, [In][NoAlias] JLCBOGGNFCI scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600086E")]
			[Cpp2IlInjected.Address(RVA = "0x5E95DE0", Offset = "0x5E945E0", VA = "0x185E95DE0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private EntityQuery PostDeserializeTransformRootsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private EntityQuery PostDeserializeTransformRootsSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private EntityQuery PostDeserializeTransformRootsSystem_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private EntityQuery PostDeserializeTransformRootsSystem_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private EntityQuery __query_4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private ComponentTypeHandle<OAEOJOGLFPE> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private ComponentTypeHandle<JLCBOGGNFCI> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private ComponentTypeHandle<CEFKKAMGNJB> __RecRoom_Components_AuthoredLocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private ComponentTypeHandle<OAEOJOGLFPE> __RecRoom_Components_LocalPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private ComponentTypeHandle<DEMCMLIOGEO> __RecRoom_Components_AuthoredLocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private ComponentTypeHandle<JLCBOGGNFCI> __RecRoom_Components_LocalUniformScaleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x5E96AE0", Offset = "0x5E952E0", VA = "0x185E96AE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x5E96030", Offset = "0x5E94830", VA = "0x185E96030")]
		private void ONDFDIDFHOF([In] DDNODGNMOKA transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x5E95770", Offset = "0x5E93F70", VA = "0x185E95770")]
		private void FPNJIABIAPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x5E95640", Offset = "0x5E93E40", VA = "0x185E95640")]
		private JobHandle EPIPKGPBMAH(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x5E95F30", Offset = "0x5E94730", VA = "0x185E95F30")]
		private JobHandle MAFPMJKDHKP(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x5E95500", Offset = "0x5E93D00", VA = "0x185E95500")]
		private JobHandle ECGLLDAMAHE(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x5E959B0", Offset = "0x5E941B0", VA = "0x185E959B0")]
		private JobHandle GCMPMAJGCOM(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0x5E96250", Offset = "0x5E94A50", VA = "0x185E96250", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PostDeserializeTransformRootsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public static class LGBNFFDFDKM
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	public interface FADKEOCAHMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	public interface MAAJIJEDDHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	public class EHKNBGNPJLC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017E")]
	public class NEHFMDKECDI : MAAJIJEDDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0x5E91CF0", Offset = "0x5E904F0", VA = "0x185E91CF0")]
		public NEHFMDKECDI(ComponentType KLIANGHAKAC, ComponentType HMAAPHDBILK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	public class IHHJGFEFOMH : MAAJIJEDDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x33FC540", Offset = "0x33FAD40", VA = "0x1833FC540")]
		public IHHJGFEFOMH(ComponentType KLIANGHAKAC, ComponentType[] HMAAPHDBILK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	public class OEJDCABOPBI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x240F290", Offset = "0x240DA90", VA = "0x18240F290")]
	public static MAAJIJEDDHI INLNMAKKHJG<TFrom, TTo>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x240F170", Offset = "0x240D970", VA = "0x18240F170")]
	public static MAAJIJEDDHI GBDDHOMFHLC<TFrom>(params ComponentType[] CAPCAEOFDEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
public class LHGEACKHNAO : LCBKPFMJPPL
{
	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	public LHGEACKHNAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class LCPOFIHOKGN : LILACEBNEFC
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x5E90EB0", Offset = "0x5E8F6B0", VA = "0x185E90EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000877")]
	[Cpp2IlInjected.Address(RVA = "0x5E90E60", Offset = "0x5E8F660", VA = "0x185E90E60")]
	private EntityCommandBufferSystem CMCIMJNMJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000878")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public LCPOFIHOKGN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	[LHGEACKHNAO]
	public class PostDeserializeUpgrade_Convert_ObjectPolicyData : BOJPJJCHION
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeUpgrade_Convert_ObjectPolicyData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			public NBEDEDGLAMG<GFCMPHJECKE> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			public NBEDEDGLAMG<NKBPNEBHCEI> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			public NBEDEDGLAMG<AAKHHKEJOEL> v2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000505")]
			public NBEDEDGLAMG<HPDJAAGOJNI> v3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000506")]
			public DGHBFGFNKGP<KIOFMNKMPGD> v4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000507")]
			public AAKHHKEJOEL v2Default;

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0x5E982A0", Offset = "0x5E96AA0", VA = "0x185E982A0")]
			private void KJMBDHFEAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x5E98290", Offset = "0x5E96A90", VA = "0x185E98290", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		protected override DGJIKJLGCCH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600087D")]
			[Cpp2IlInjected.Address(RVA = "0x5E97A20", Offset = "0x5E96220", VA = "0x185E97A20", Slot = "14")]
			get
			{
				return default(DGJIKJLGCCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x5E97A70", Offset = "0x5E96270", VA = "0x185E97A70", Slot = "15")]
		public override IEnumerable<LGBNFFDFDKM.MAAJIJEDDHI> GNFAOAKKOOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x5E97F10", Offset = "0x5E96710", VA = "0x185E97F10", Slot = "16")]
		protected override void KDFBJELFEMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x5E97C50", Offset = "0x5E96450", VA = "0x185E97C50")]
		private static void JEIJLKECBIH(CEKOJNBMIFL<NKBPNEBHCEI> srcVersion, CEKOJNBMIFL<AAKHHKEJOEL> dstVersion, AAKHHKEJOEL dstDefault)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x5E97DF0", Offset = "0x5E965F0", VA = "0x185E97DF0")]
		private static void JOEDJCNMJPD(CEKOJNBMIFL<AAKHHKEJOEL> srcVersion, CEKOJNBMIFL<HPDJAAGOJNI> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x5E98960", Offset = "0x5E97160", VA = "0x185E98960")]
		private static void OGLIEGIJFEH(CEKOJNBMIFL<HPDJAAGOJNI> srcVersion, CEKOJNBMIFL<KIOFMNKMPGD> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x5E97800", Offset = "0x5E96000", VA = "0x185E97800")]
		private JobHandle AFBMAMIPMEM(NBEDEDGLAMG<GFCMPHJECKE> v0, NBEDEDGLAMG<NKBPNEBHCEI> v1, NBEDEDGLAMG<AAKHHKEJOEL> v2, NBEDEDGLAMG<HPDJAAGOJNI> v3, DGHBFGFNKGP<KIOFMNKMPGD> v4, AAKHHKEJOEL v2Default, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PostDeserializeUpgrade_Convert_ObjectPolicyData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[LHGEACKHNAO]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_OMShapeContainerData : BOJPJJCHION
	{
		[Cpp2IlInjected.Token(Token = "0x2000187")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_OMShapeContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000509")]
			public NBEDEDGLAMG<GGIDAABBPCO> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public DGHBFGFNKGP<AKKHNLKGCGO> v2;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x5E97460", Offset = "0x5E95C60", VA = "0x185E97460")]
			private void KJMBDHFEAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0x5E97450", Offset = "0x5E95C50", VA = "0x185E97450", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		protected override DGJIKJLGCCH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0x5E97100", Offset = "0x5E95900", VA = "0x185E97100", Slot = "14")]
			get
			{
				return default(DGJIKJLGCCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x5E97150", Offset = "0x5E95950", VA = "0x185E97150", Slot = "15")]
		public override IEnumerable<LGBNFFDFDKM.MAAJIJEDDHI> GNFAOAKKOOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x5E972E0", Offset = "0x5E95AE0", VA = "0x185E972E0", Slot = "16")]
		protected override void KDFBJELFEMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x5E97210", Offset = "0x5E95A10", VA = "0x185E97210")]
		private static void JEIJLKECBIH(CEKOJNBMIFL<GGIDAABBPCO> srcVersion, CEKOJNBMIFL<AKKHNLKGCGO> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x5E96FD0", Offset = "0x5E957D0", VA = "0x185E96FD0")]
		private JobHandle CKLIHFIBINI(NBEDEDGLAMG<GGIDAABBPCO> v1, DGHBFGFNKGP<AKKHNLKGCGO> v2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PostDeserializeUpgrade_Convert_OMShapeContainerData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	[LHGEACKHNAO]
	[AMCOHLDKFON]
	public class PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data : BOJPJJCHION, LGBNFFDFDKM.FADKEOCAHMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		private struct PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public NBEDEDGLAMG<FNMKCECIFBJ> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public NBEDEDGLAMG<EEMKJLIKBGC> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0x5E991B0", Offset = "0x5E979B0", VA = "0x185E991B0")]
			private void KJMBDHFEAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x5E991A0", Offset = "0x5E979A0", VA = "0x185E991A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		protected override DGJIKJLGCCH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0x5E98CB0", Offset = "0x5E974B0", VA = "0x185E98CB0", Slot = "14")]
			get
			{
				return default(DGJIKJLGCCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x5E98E50", Offset = "0x5E97650", VA = "0x185E98E50", Slot = "15")]
		public override IEnumerable<LGBNFFDFDKM.MAAJIJEDDHI> GNFAOAKKOOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x5E98F70", Offset = "0x5E97770", VA = "0x185E98F70", Slot = "16")]
		protected override void KDFBJELFEMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x5E98B20", Offset = "0x5E97320", VA = "0x185E98B20")]
		private static void CJDNKAIKGAP(KAAKBLDCHLJ<EEMKJLIKBGC> d1, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x5E98D00", Offset = "0x5E97500", VA = "0x185E98D00")]
		private JobHandle GLIIFIKLMKK(NBEDEDGLAMG<FNMKCECIFBJ> v0, NBEDEDGLAMG<EEMKJLIKBGC> v1, EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[LHGEACKHNAO]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_SerializeEmbodiedData : BOJPJJCHION
	{
		[Cpp2IlInjected.Token(Token = "0x200018B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_SerializeEmbodiedData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public NBEDEDGLAMG<HEOFBMBFCOL> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public DGHBFGFNKGP<HKAOOKBJIOD> v1;

			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E99A20", Offset = "0x5E98220", VA = "0x185E99A20")]
			private void KJMBDHFEAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x5E99A10", Offset = "0x5E98210", VA = "0x185E99A10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		protected override DGJIKJLGCCH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x5E99790", Offset = "0x5E97F90", VA = "0x185E99790", Slot = "14")]
			get
			{
				return default(DGJIKJLGCCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x5E997E0", Offset = "0x5E97FE0", VA = "0x185E997E0", Slot = "15")]
		public override IEnumerable<LGBNFFDFDKM.MAAJIJEDDHI> GNFAOAKKOOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x5E998A0", Offset = "0x5E980A0", VA = "0x185E998A0", Slot = "16")]
		protected override void KDFBJELFEMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E99660", Offset = "0x5E97E60", VA = "0x185E99660")]
		private JobHandle BKHDPHNMGAK(NBEDEDGLAMG<HEOFBMBFCOL> v0, DGHBFGFNKGP<HKAOOKBJIOD> v1, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PostDeserializeUpgrade_Convert_SerializeEmbodiedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[LHGEACKHNAO]
public class ICCPFNBKPFJ : DPGFJAECHAF, LGBNFFDFDKM.FADKEOCAHMB
{
	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public IEnumerable<Type> DMFCCDDOCLN
	{
		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E8CB20", Offset = "0x5E8B320", VA = "0x185E8CB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CD90", Offset = "0x5E8B590", VA = "0x185E8CD90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CAD0", Offset = "0x5E8B2D0", VA = "0x185E8CAD0")]
	private EntityCommandBufferSystem CMCIMJNMJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008A9")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public ICCPFNBKPFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
public class GEEPAGNDOAK : LLMECIGAMIK
{
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	protected override HJHHOAIIMCD JDECALIEOBK
	{
		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "15")]
		get
		{
			return default(HJHHOAIIMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E89F60", Offset = "0x5E88760", VA = "0x185E89F60", Slot = "16")]
	protected override void GMIPDJEHGPL(HJHHOAIIMCD IFOEKNINMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E89F10", Offset = "0x5E88710", VA = "0x185E89F10")]
	private EntityCommandBufferSystem CMCIMJNMJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A260", Offset = "0x5E88A60", VA = "0x185E8A260")]
	public GEEPAGNDOAK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	[LHGEACKHNAO]
	public class PostDeserializeUpgrade_Split_ContainerData : DPGFJAECHAF, LGBNFFDFDKM.FADKEOCAHMB
	{
		[Cpp2IlInjected.Token(Token = "0x200018F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Split_ContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			public NativeArray<CCOAFMNIHKD> v1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public ComponentTypes newComponents;

			[Cpp2IlInjected.Token(Token = "0x60008B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E99F60", Offset = "0x5E98760", VA = "0x185E99F60")]
			private void KJMBDHFEAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0x5E99F50", Offset = "0x5E98750", VA = "0x185E99F50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private ComponentType[] newComponentTypes;

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E99D50", Offset = "0x5E98550", VA = "0x185E99D50", Slot = "14")]
		public IEnumerable<LGBNFFDFDKM.MAAJIJEDDHI> GNFAOAKKOOJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A240", Offset = "0x5E98A40", VA = "0x185E9A240", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E99D00", Offset = "0x5E98500", VA = "0x185E99D00")]
		private EntityCommandBufferSystem CMCIMJNMJOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E99E10", Offset = "0x5E98610", VA = "0x185E99E10")]
		private JobHandle JONBJPAABDO(EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<CCOAFMNIHKD> v1Data, ComponentTypes newComponents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A720", Offset = "0x5E98F20", VA = "0x185E9A720")]
		public PostDeserializeUpgrade_Split_ContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
[AlwaysUpdateSystem]
public abstract class BOJPJJCHION : DPGFJAECHAF, LGBNFFDFDKM.FADKEOCAHMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private NativeList<EntityQuery> CJGPOMHFPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private bool FBBBJGJIGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private EntityCommandBufferSystem HFDADGLHMNF;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	protected bool NJJJJBFIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x55CC6E0", Offset = "0x55CAEE0", VA = "0x1855CC6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	protected abstract DGJIKJLGCCH NOCJPHOMELN
	{
		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60008BA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract IEnumerable<LGBNFFDFDKM.MAAJIJEDDHI> GNFAOAKKOOJ();

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E82FF0", Offset = "0x5E817F0", VA = "0x185E82FF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E83110", Offset = "0x5E81910", VA = "0x185E83110", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E830C0", Offset = "0x5E818C0", VA = "0x185E830C0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void KDFBJELFEMP();

	[Cpp2IlInjected.Token(Token = "0x60008BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E82FA0", Offset = "0x5E817A0", VA = "0x185E82FA0")]
	protected EntityCommandBufferSystem CMCIMJNMJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008C0")]
	[Cpp2IlInjected.Address(RVA = "0x2193F40", Offset = "0x2192740", VA = "0x182193F40")]
	protected EntityQuery OBLMBBLIAPL<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C1")]
	[Cpp2IlInjected.Address(RVA = "0x2192DF0", Offset = "0x21915F0", VA = "0x182192DF0")]
	protected NBEDEDGLAMG<T> CBAJDFMKACJ<T>() where T : struct, IComponentData
	{
		return default(NBEDEDGLAMG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C2")]
	[Cpp2IlInjected.Address(RVA = "0x2193E30", Offset = "0x2192630", VA = "0x182193E30")]
	protected DGHBFGFNKGP<T> JNELNGKGLMK<T>() where T : struct, IComponentData
	{
		return default(DGHBFGFNKGP<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C3")]
	[Cpp2IlInjected.Address(RVA = "0x2193AF0", Offset = "0x21922F0", VA = "0x182193AF0")]
	protected static void JJHDAHCNPOG<T1, T2>(KAAKBLDCHLJ<T1> KJLLCCCCDGK, KAAKBLDCHLJ<T2> PPOFJFFLIAC) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(RVA = "0x2193AF0", Offset = "0x21922F0", VA = "0x182193AF0")]
	protected static void JJHDAHCNPOG<T1, T2>(KAAKBLDCHLJ<T1> KJLLCCCCDGK, CEOLJMNAFEA<T2> PPOFJFFLIAC) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x2193BF0", Offset = "0x21923F0", VA = "0x182193BF0")]
	private static void JJHDAHCNPOG<T1, T2>(CEKOJNBMIFL<T1> KJLLCCCCDGK, CEKOJNBMIFL<T2> PPOFJFFLIAC) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	protected BOJPJJCHION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public abstract class LLMECIGAMIK : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	protected virtual HJHHOAIIMCD MAEBHBKKICC
	{
		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "14")]
		get
		{
			return default(HJHHOAIIMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	protected virtual HJHHOAIIMCD JDECALIEOBK
	{
		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E1100", Offset = "0x7DF900", VA = "0x1807E1100", Slot = "15")]
		get
		{
			return default(HJHHOAIIMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void GMIPDJEHGPL(HJHHOAIIMCD IFOEKNINMPE);

	[Cpp2IlInjected.Token(Token = "0x60008CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E91670", Offset = "0x5E8FE70", VA = "0x185E91670", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E91610", Offset = "0x5E8FE10", VA = "0x185E91610")]
	private HJHHOAIIMCD GOEABFOMLFD()
	{
		return default(HJHHOAIIMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	protected LLMECIGAMIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
public class ADKNCCDFKDE : DPGFJAECHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private KBILGICPLHD HFDADGLHMNF;

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E825C0", Offset = "0x5E80DC0", VA = "0x185E825C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E82690", Offset = "0x5E80E90", VA = "0x185E82690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D0")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public ADKNCCDFKDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
public class HJDMOBOFIDM : DPGFJAECHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private KBILGICPLHD HFDADGLHMNF;

	[Cpp2IlInjected.Token(Token = "0x60008D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AEB0", Offset = "0x5E896B0", VA = "0x185E8AEB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AF80", Offset = "0x5E89780", VA = "0x185E8AF80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D3")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public HJDMOBOFIDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public class JEMFHGOFJEK : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private PFIOEDFHNMJ HGOFPLJJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.Token(Token = "0x60008D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E230", Offset = "0x5E8CA30", VA = "0x185E8E230", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E1C0", Offset = "0x5E8C9C0", VA = "0x185E8E1C0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E300", Offset = "0x5E8CB00", VA = "0x185E8E300", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D7")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public JEMFHGOFJEK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	public class DebugPostLoadValidateNetworkIdSystem : LILACEBNEFC, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		private struct DebugPostLoadValidateNetworkIdSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public NativeParallelHashMap<AFCHODDKGEA, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			[ReadOnly]
			public ComponentTypeHandle<KEHHIJFCONH> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0x5E86A10", Offset = "0x5E85210", VA = "0x185E86A10")]
			private void KJMBDHFEAAM(Entity entity, [In] KEHHIJFCONH networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0x5E868F0", Offset = "0x5E850F0", VA = "0x185E868F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private OGDIMNHIMAP networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private EntityQuery DebugPostLoadValidateNetworkIdSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private ComponentTypeHandle<KEHHIJFCONH> __RecRoom_Components_ObjectNetworkIdComponentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E86890", Offset = "0x5E85090", VA = "0x185E86890", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E86C90", Offset = "0x5E85490", VA = "0x185E86C90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E867A0", Offset = "0x5E84FA0", VA = "0x185E867A0")]
		private void AGEFFMHHFJA(NativeParallelHashMap<AFCHODDKGEA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E86A90", Offset = "0x5E85290", VA = "0x185E86A90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public DebugPostLoadValidateNetworkIdSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	public class DebugPostLoadValidateParentDataSystem : LILACEBNEFC, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000198")]
		private struct DebugPostLoadValidateParentDataSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			public DebugPostLoadValidateParentDataSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052F")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000530")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0x5E87150", Offset = "0x5E85950", VA = "0x185E87150")]
			private void KJMBDHFEAAM(Entity entity, [In] ParentData parentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0x5E87030", Offset = "0x5E85830", VA = "0x185E87030", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private LDNONJHJNKB objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private EntityQuery DebugPostLoadValidateParentDataSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E86FD0", Offset = "0x5E857D0", VA = "0x185E86FD0", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E86F00", Offset = "0x5E85700", VA = "0x185E86F00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x5E86F00", Offset = "0x5E85700", VA = "0x185E86F00")]
		private void FLBHGOKACKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E87320", Offset = "0x5E85B20", VA = "0x185E87320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public DebugPostLoadValidateParentDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E86D80", Offset = "0x5E85580", VA = "0x185E86D80")]
		[CompilerGenerated]
		private void ADKABLBHIBF(Entity entity, [In] ParentData parentData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class NHKBOGNPMFN : LILACEBNEFC, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private NGKJMLHKKJA BFGNFEGPODM;

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E91E10", Offset = "0x5E90610", VA = "0x185E91E10", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E9")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EA")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public NHKBOGNPMFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[UpdateBefore(typeof(EEHHIHOJBHK))]
public class GIHCAPCGBEM : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x60008EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A2B0", Offset = "0x5E88AB0", VA = "0x185E8A2B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A360", Offset = "0x5E88B60", VA = "0x185E8A360", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008ED")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public GIHCAPCGBEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class DJOMIMGNODH : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct JIIBKAPMBDG : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		[ReadOnly]
		public NativeArray<HFNKDHNJJAA> PMAFGGKOHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		[ReadOnly]
		public NativeArray<Entity> FAIFKAKJOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public ComponentDataFromEntity BMLBNADGLOB;

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E540", Offset = "0x5E8CD40", VA = "0x185E8E540", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[BurstCompile]
	private struct FMBIBHNIMCB : IJob, INativeDisposable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> APNMAEDAJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		[ReadOnly]
		public NativeParallelHashMap<int, EntityArchetype> FBLMIICFOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		[ReadOnly]
		public NativeParallelHashMap<int, int> EAMMMIBDLMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> KMDLGMKGIJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> NLJAIEKLGJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public NativeList<EntityArchetype> POMOMHPOPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public NativeList<EntityArchetype> DLCDMEDLJDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public NativeList<DDIOAHAKKEH> JAPICOLCEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public NativeList<DDIOAHAKKEH> CHBLMPEEOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public NativeList<HFNKDHNJJAA> AODCICPFHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public NativeList<ComponentType> NPLIHIJEIBH;

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E89A40", Offset = "0x5E88240", VA = "0x185E89A40", Slot = "6")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E890A0", Offset = "0x5E878A0", VA = "0x185E890A0", Slot = "5")]
		public JobHandle Dispose(JobHandle KPAMIOKBGLD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E892B0", Offset = "0x5E87AB0", VA = "0x185E892B0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E897B0", Offset = "0x5E87FB0", VA = "0x185E897B0")]
		private int NMJIJEECLPD(DDIOAHAKKEH HOPKICGPJAI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E89850", Offset = "0x5E88050", VA = "0x185E89850")]
		private bool PIFHHBPEEDP(int DPCDJHGAKOL, EntityArchetype LBIGLHIPNBI, [Out] EntityArchetype CNEIGJDBGPE, [Out] Entity FKFLMEBHIKK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct FFHOHCCCLDN : IComparer<HFNKDHNJJAA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x9523D0", Offset = "0x950BD0", VA = "0x1809523D0", Slot = "4")]
		public int Compare(HFNKDHNJJAA IILAPOMEGLM, HFNKDHNJJAA BNBBAPGFCCO)
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[BurstCompile]
	private struct BNFGJPFFDPK : GJNHHMMJPCM<HFNKDHNJJAA, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0xDF3320", Offset = "0xDF1B20", VA = "0x180DF3320")]
		public int OIDLIBPKLAB([In] HFNKDHNJJAA INOEECCONEM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0xDF3320", Offset = "0xDF1B20", VA = "0x180DF3320", Slot = "4")]
		private int JAFMPCDHPNP([In] HFNKDHNJJAA FKKGMPDEPMA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	private struct HFNKDHNJJAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public Entity FKFLMEBHIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public DDIOAHAKKEH FAIFKAKJOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int IABDIHAKIDF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000534")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private EKLAJGGMJNP MFACMNCIMMH;

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E84930", Offset = "0x5E83130", VA = "0x185E84930", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E84DB0", Offset = "0x5E835B0", VA = "0x185E84DB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E84E70", Offset = "0x5E83670", VA = "0x185E84E70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E846F0", Offset = "0x5E82EF0", VA = "0x185E846F0")]
	private FMBIBHNIMCB DIGKOJDDMCM(NativeArray<ArchetypeChunk> BOIIKNCHJHM)
	{
		return default(FMBIBHNIMCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E84C30", Offset = "0x5E83430", VA = "0x185E84C30")]
	private void NIBFHKGFDEB(NativeArray<EntityArchetype> DLCDMEDLJDO, NativeArray<DDIOAHAKKEH> JAPICOLCEAJ, NativeArray<DDIOAHAKKEH> CHBLMPEEOLB, NativeArray<ComponentType> NPLIHIJEIBH, NativeArray<ArchetypeChunk> BOIIKNCHJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E84990", Offset = "0x5E83190", VA = "0x185E84990")]
	private EntityArchetype NGHCIAAPNPC(EntityArchetype HJGKJCBHOCG, NativeArray<ComponentType> NPLIHIJEIBH, DDIOAHAKKEH PIGGPAHNFPO)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E854D0", Offset = "0x5E83CD0", VA = "0x185E854D0")]
	private JobHandle PFGPCALNENI(NativeList<HFNKDHNJJAA> PMAFGGKOHHL, NativeArray<Entity> FAIFKAKJOPP, JobHandle DNKOAJMNLIH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E85AB0", Offset = "0x5E842B0", VA = "0x185E85AB0")]
	private JobHandle PIOKAPMNPJC(NativeArray<Entity> FAIFKAKJOPP, NativeArray<HFNKDHNJJAA> PMAFGGKOHHL, int JIBGFHDMIBK, DDIOAHAKKEH PIGGPAHNFPO, JobHandle DNKOAJMNLIH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E84980", Offset = "0x5E83180", VA = "0x185E84980")]
	public static bool MIGDOCIFHJO(ComponentType IPLGGDBFLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F8")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public DJOMIMGNODH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[UpdateBefore(typeof(DJOMIMGNODH))]
public class EEHHIHOJBHK : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private NGKJMLHKKJA BFGNFEGPODM;

	[Cpp2IlInjected.Token(Token = "0x6000903")]
	[Cpp2IlInjected.Address(RVA = "0x5E87520", Offset = "0x5E85D20", VA = "0x185E87520", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000904")]
	[Cpp2IlInjected.Address(RVA = "0x5E87570", Offset = "0x5E85D70", VA = "0x185E87570", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000905")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public EEHHIHOJBHK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[CompilerGenerated]
	[DMDOGFFEKFK(PJHIMKBCGDP.OMRoom)]
	public class PostLoadInitializeNetworkIdSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x20001A3")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostLoadInitializeNetworkIdSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.Token(Token = "0x20001A4")]
			public delegate void RunWithoutJobSystem_00000AD4$PostfixBurstDelegate(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20001A5")]
			internal static class RunWithoutJobSystem_00000AD4$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x400055D")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x400055E")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x600091F")]
				[Cpp2IlInjected.Address(RVA = "0x5EA09D0", Offset = "0x5E9F1D0", VA = "0x185EA09D0")]
				[BurstDiscard]
				private static void JBJHKKNLKOD(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000920")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0B00", Offset = "0x5E9F300", VA = "0x185EA0B00")]
				private static IntPtr JLNOMCGJAEF()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000921")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0920", Offset = "0x5E9F120", VA = "0x185EA0920")]
				public static void BMLNCOHHOFB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000922")]
				[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
				public static void GLJEDCMMNGN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000924")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0730", Offset = "0x5E9EF30", VA = "0x185EA0730")]
				public static void BHJKEIPKKOJ(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000556")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000557")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public NativeParallelHashMap<AFCHODDKGEA, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			public uint playerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			public uint offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			public ComponentTypeHandle<KEHHIJFCONH> __dstValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B0A0", Offset = "0x5E998A0", VA = "0x185E9B0A0")]
			private void KJMBDHFEAAM(Entity entity, int entityInQueryIndex, [NoAlias] KEHHIJFCONH dstValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600091A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9AF60", Offset = "0x5E99760", VA = "0x185E9AF60", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600091B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B130", Offset = "0x5E99930", VA = "0x185E9B130")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void NCKDDFJJGEJ(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B350", Offset = "0x5E99B50", VA = "0x185E9B350")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void PJJPMCMDDHM(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001A6")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostLoadInitializeNetworkIdSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.Token(Token = "0x20001A7")]
			public delegate void RunWithoutJobSystem_00000AD7$PostfixBurstDelegate(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20001A8")]
			internal static class RunWithoutJobSystem_00000AD7$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000565")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000566")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x600092B")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0F00", Offset = "0x5E9F700", VA = "0x185EA0F00")]
				[BurstDiscard]
				private static void JBJHKKNLKOD(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092C")]
				[Cpp2IlInjected.Address(RVA = "0x5EA1030", Offset = "0x5E9F830", VA = "0x185EA1030")]
				private static IntPtr JLNOMCGJAEF()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x600092D")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0E50", Offset = "0x5E9F650", VA = "0x185EA0E50")]
				public static void BMLNCOHHOFB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092E")]
				[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
				public static void GLJEDCMMNGN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000930")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0C60", Offset = "0x5E9F460", VA = "0x185EA0C60")]
				public static void BHJKEIPKKOJ(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400055F")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000560")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public NativeParallelHashMap<AFCHODDKGEA, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			public ComponentTypeHandle<KEHHIJFCONH> __dstValueTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B560", Offset = "0x5E99D60", VA = "0x185E9B560")]
			private void KJMBDHFEAAM(Entity entity, [NoAlias] KEHHIJFCONH dstValue, [In][NoAlias] OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B3C0", Offset = "0x5E99BC0", VA = "0x185E9B3C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000927")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B5D0", Offset = "0x5E99DD0", VA = "0x185E9B5D0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void NCKDDFJJGEJ(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B7F0", Offset = "0x5E99FF0", VA = "0x185E9B7F0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void PJJPMCMDDHM(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		private struct PostLoadInitializeNetworkIdSystem_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public NativeParallelHashMap<AFCHODDKGEA, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000931")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B980", Offset = "0x5E9A180", VA = "0x185E9B980")]
			private void KJMBDHFEAAM(Entity entity, [In] OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B860", Offset = "0x5E9A060", VA = "0x185E9B860", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[NMIHDJKFGCM]
		private OGDIMNHIMAP networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		[NMIHDJKFGCM]
		private NGKJMLHKKJA scenes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private EntityQuery queryAllInScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private EntityQuery queryAllInActiveRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private EntityQuery additiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private EntityQuery PostLoadInitializeNetworkIdSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private EntityQuery PostLoadInitializeNetworkIdSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private EntityQuery PostLoadInitializeNetworkIdSystem_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private EntityQuery __query_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private ComponentTypeHandle<KEHHIJFCONH> __RecRoom_Components_ObjectNetworkIdComponentData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private ComponentTypeHandle<OverrideObjectNetworkIdData> __RecRoom_Components_OverrideObjectNetworkIdData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x5E9ADE0", Offset = "0x5E995E0", VA = "0x185E9ADE0", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CC50", Offset = "0x5E9B450", VA = "0x185E9CC50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CD90", Offset = "0x5E9B590", VA = "0x185E9CD90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D130", Offset = "0x5E9B930", VA = "0x185E9D130")]
		public void PDAJLHDFKHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BC00", Offset = "0x5E9A400", VA = "0x185E9BC00")]
		private void MLPIFIAFAAD(NativeParallelHashMap<AFCHODDKGEA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C1D0", Offset = "0x5E9A9D0", VA = "0x185E9C1D0")]
		private void NPAKLLGFDMD(NativeParallelHashMap<AFCHODDKGEA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AA60", Offset = "0x5E99260", VA = "0x185E9AA60")]
		private void AKJLAKLEBAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BA90", Offset = "0x5E9A290", VA = "0x185E9BA90")]
		private void MALPMCLPGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AF40", Offset = "0x5E99740", VA = "0x185E9AF40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void LDEGLDNJMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D1A0", Offset = "0x5E9B9A0", VA = "0x185E9D1A0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void PLLBNHPKDPC(NativeParallelHashMap<AFCHODDKGEA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AC90", Offset = "0x5E99490", VA = "0x185E9AC90")]
		private void GKAHHJGFEKD(NativeParallelHashMap<AFCHODDKGEA, Entity> map, uint playerId, uint offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A8F0", Offset = "0x5E990F0", VA = "0x185E9A8F0")]
		private void ADADFKOKKLI(NativeParallelHashMap<AFCHODDKGEA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AE50", Offset = "0x5E99650", VA = "0x185E9AE50")]
		private void KICMBKMJKOA(NativeParallelHashMap<AFCHODDKGEA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C500", Offset = "0x5E9AD00", VA = "0x185E9C500", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PostLoadInitializeNetworkIdSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AC50", Offset = "0x5E99450", VA = "0x185E9AC50")]
		public static void EPCAIGLMMFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AC10", Offset = "0x5E99410", VA = "0x185E9AC10")]
		public static void EFOALGCBACA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	public class PostLoadMoveRootsUnderParentSystem : DPGFJAECHAF
	{
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D4B0", Offset = "0x5E9BCB0", VA = "0x185E9D4B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D590", Offset = "0x5E9BD90", VA = "0x185E9D590", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D310", Offset = "0x5E9BB10", VA = "0x185E9D310", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PostLoadMoveRootsUnderParentSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[DMDOGFFEKFK(PJHIMKBCGDP.OMRoom)]
	[CompilerGenerated]
	public class PostLoadRemapCircuitIdsSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x20001AC")]
		private struct PostLoadRemapCircuitIdsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public NFPDFHOMGOB remap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			public ComponentTypeHandle<DANOOFAEPGD> __nodeTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600093E")]
			[Cpp2IlInjected.Address(RVA = "0x5E9DBB0", Offset = "0x5E9C3B0", VA = "0x185E9DBB0")]
			private void KJMBDHFEAAM(DANOOFAEPGD node)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600093F")]
			[Cpp2IlInjected.Address(RVA = "0x5E9DAE0", Offset = "0x5E9C2E0", VA = "0x185E9DAE0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		[NMIHDJKFGCM]
		private FJGKMPJNNPH serialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private EntityQuery PostLoadRemapCircuitIdsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private ComponentTypeHandle<DANOOFAEPGD> __RecRoom_Components_ObjectBoardNodeData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DA90", Offset = "0x5E9C290", VA = "0x185E9DA90", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DFC0", Offset = "0x5E9C7C0", VA = "0x185E9DFC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D9B0", Offset = "0x5E9C1B0", VA = "0x185E9D9B0")]
		private void HPLNCGILNIC(NFPDFHOMGOB remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E120", Offset = "0x5E9C920", VA = "0x185E9E120")]
		private void PHHOJOMPGFB(NFPDFHOMGOB remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DDC0", Offset = "0x5E9C5C0", VA = "0x185E9DDC0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PostLoadRemapCircuitIdsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public class FNMDDGKKDPN : DPGFJAECHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	[Cpp2IlInjected.Address(RVA = "0x5E89DF0", Offset = "0x5E885F0", VA = "0x185E89DF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x5E89E80", Offset = "0x5E88680", VA = "0x185E89E80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public FNMDDGKKDPN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	public class PreSerializeDowngrade_RRObjectPrefabTypeData : DPGFJAECHAF
	{
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PreSerializeDowngrade_RRObjectPrefabTypeData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			[ReadOnly]
			public SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000578")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunksRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			[ReadOnly]
			public NativeParallelHashMap<int, int> prefabTypeFromIndexRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			public ODCLMNEGLIA.JKCCLMJNNIE<ArchetypeChunk, KJMEPFJOGNK<RRObjectPrefabV2Data>> it;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public NativeList<EEMKJLIKBGC> prefabTypeData;

			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E260", Offset = "0x5E9CA60", VA = "0x185E9E260")]
			private void KJMBDHFEAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E250", Offset = "0x5E9CA50", VA = "0x185E9E250", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private EntityQuery queryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E6C0", Offset = "0x5E9CEC0", VA = "0x185E9E6C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E760", Offset = "0x5E9CF60", VA = "0x185E9E760", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E200", Offset = "0x5E9CA00", VA = "0x185E9E200")]
		private EntityCommandBufferSystem CMCIMJNMJOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F150", Offset = "0x5E9D950", VA = "0x185E9F150")]
		private JobHandle PBBPOPCMDML(SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO, EntityTypeHandle entityTypeHandleRO, NativeArray<ArchetypeChunk> chunksRO, NativeParallelHashMap<int, int> prefabTypeFromIndexRO, ODCLMNEGLIA.JKCCLMJNNIE<ArchetypeChunk, KJMEPFJOGNK<RRObjectPrefabV2Data>> it, NativeList<Entity> entities, NativeList<EEMKJLIKBGC> prefabTypeData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E520", Offset = "0x5E9CD20", VA = "0x185E9E520", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PreSerializeDowngrade_RRObjectPrefabTypeData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class LFHCBHGHDKG : DPGFJAECHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private EntityQuery GDGDHCOPEEF;

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x5E913F0", Offset = "0x5E8FBF0", VA = "0x185E913F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x5E91480", Offset = "0x5E8FC80", VA = "0x185E91480", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x5E913A0", Offset = "0x5E8FBA0", VA = "0x185E913A0")]
	private EntityCommandBufferSystem IBHMNNCGKJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public LFHCBHGHDKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
[AlwaysUpdateSystem]
public class HCIPOJEBMIL : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AC60", Offset = "0x5E89460", VA = "0x185E8AC60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public HCIPOJEBMIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class CAGJIAENDAF : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	private static DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057F")]
	private EntityQuery GMIONDCHAGH;

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x5E83170", Offset = "0x5E81970", VA = "0x185E83170", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x5E833F0", Offset = "0x5E81BF0", VA = "0x185E833F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public CAGJIAENDAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public class NEFDCMMAOAM : BHEEPGONHJF
{
	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x5E91CA0", Offset = "0x5E904A0", VA = "0x185E91CA0", Slot = "14")]
	protected override EntityCommandBufferSystem CMCIMJNMJOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public NEFDCMMAOAM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[CompilerGenerated]
	public class PreSerializeSaveNetworkIdsSystem : DPGFJAECHAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F580", Offset = "0x5E9DD80", VA = "0x185E9F580", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F610", Offset = "0x5E9DE10", VA = "0x185E9F610", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F390", Offset = "0x5E9DB90", VA = "0x185E9F390")]
		private EntityCommandBufferSystem IBHMNNCGKJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F3E0", Offset = "0x5E9DBE0", VA = "0x185E9F3E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PreSerializeSaveNetworkIdsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	[CompilerGenerated]
	public class PreSerializeTransformRootsSystem : DPGFJAECHAF
	{
		[Cpp2IlInjected.Token(Token = "0x20001B6")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PreSerializeTransformRootsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			public ComponentTypeHandle<OAEOJOGLFPE> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0x5E82110", Offset = "0x5E80910", VA = "0x185E82110")]
			private void KJMBDHFEAAM([NoAlias] OAEOJOGLFPE data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0x5E9FBC0", Offset = "0x5E9E3C0", VA = "0x185E9FBC0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B7")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PreSerializeTransformRootsSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400058A")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400058B")]
			public ComponentTypeHandle<JLCBOGGNFCI> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0x5E80D30", Offset = "0x5E7F530", VA = "0x185E80D30")]
			private void KJMBDHFEAAM([NoAlias] JLCBOGGNFCI data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0x5E9FC90", Offset = "0x5E9E490", VA = "0x185E9FC90", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private EntityQuery PreSerializeTransformRootsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private EntityQuery PreSerializeTransformRootsSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private EntityQuery __query_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private ComponentTypeHandle<OAEOJOGLFPE> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private ComponentTypeHandle<JLCBOGGNFCI> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0450", Offset = "0x5E9EC50", VA = "0x185EA0450", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FD60", Offset = "0x5E9E560", VA = "0x185E9FD60")]
		private void ONDFDIDFHOF([In] DDNODGNMOKA transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F990", Offset = "0x5E9E190", VA = "0x185E9F990")]
		private JobHandle DFPINEHPFJI(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FAC0", Offset = "0x5E9E2C0", VA = "0x185E9FAC0")]
		private JobHandle GKEIANBDEKN(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FF80", Offset = "0x5E9E780", VA = "0x185E9FF80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public PreSerializeTransformRootsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
[AlwaysUpdateSystem]
public class GIIFNHIMDJE : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A480", Offset = "0x5E88C80", VA = "0x185E8A480", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public GIIFNHIMDJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public static class KAFFBIFPBLB
{
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[BurstCompile]
	private struct PKODDJJMBEH : IJob, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		[ReadOnly]
		public NativeParallelHashSet<int> HJIBGBEFCNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> KMDLGMKGIJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public NativeList<EntityArchetype> DBHKDLICHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public NativeList<DDIOAHAKKEH> JAPICOLCEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public NativeList<DDIOAHAKKEH> CHBLMPEEOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public NativeList<ComponentType> DAINNKBLMME;

		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x5E938E0", Offset = "0x5E920E0", VA = "0x185E938E0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0x5E93850", Offset = "0x5E92050", VA = "0x185E93850", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600096A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E7D0", Offset = "0x5E8CFD0", VA = "0x185E8E7D0")]
	public static NativeParallelHashSet<int> ACLAMFALKIL(Allocator JONICLHJBEP)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F9F0", Offset = "0x5E8E1F0", VA = "0x185E8F9F0")]
	public static NativeParallelHashSet<int> KMBPMFBEAGH(Allocator JONICLHJBEP)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FC10", Offset = "0x5E8E410", VA = "0x185E8FC10")]
	private static void OECIGHMDECJ(NativeParallelHashSet<int> EEGIPOEDBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FB30", Offset = "0x5E8E330", VA = "0x185E8FB30")]
	private static bool NMHMJBLELLC(Type GFGNPBCFEMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F570", Offset = "0x5E8DD70", VA = "0x185E8F570")]
	private static void EDGDKHDJOJC(NativeParallelHashSet<int> EEGIPOEDBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E890", Offset = "0x5E8D090", VA = "0x185E8E890")]
	private static void AKNGFBNBEPN(NativeParallelHashSet<int> EEGIPOEDBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F7B0", Offset = "0x5E8DFB0", VA = "0x185E8F7B0")]
	private static void EMGGOKMEIMA(NativeParallelHashSet<int> EEGIPOEDBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EAD0", Offset = "0x5E8D2D0", VA = "0x185E8EAD0")]
	public static void CFHHGCIKLEC(EntityManager IDCNBIGHJII, EntityQuery LGGGLPHDMCK, NativeParallelHashSet<int> CHGMBIOFLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F3D0", Offset = "0x5E8DBD0", VA = "0x185E8F3D0")]
	public static void DFIMCCMIKBP(EntityManager IDCNBIGHJII)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public static class ELGDELBMMDK
{
	[Cpp2IlInjected.Token(Token = "0x6000975")]
	[Cpp2IlInjected.Address(RVA = "0x5E889E0", Offset = "0x5E871E0", VA = "0x185E889E0")]
	public static NativeParallelHashSet<int> JPMLONDJKGB(EntityManager IDCNBIGHJII, Allocator JONICLHJBEP)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x5E88820", Offset = "0x5E87020", VA = "0x185E88820")]
	public static NativeParallelHashMap<int, int> AJMIJONBPOD(EntityManager IDCNBIGHJII, Allocator JONICLHJBEP)
	{
		return default(NativeParallelHashMap<int, int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
public abstract class BHEEPGONHJF : DPGFJAECHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private EntityQuery LGGGLPHDMCK;

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract EntityCommandBufferSystem CMCIMJNMJOA();

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x5E827E0", Offset = "0x5E80FE0", VA = "0x185E827E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x5E82870", Offset = "0x5E81070", VA = "0x185E82870", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	protected BHEEPGONHJF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public struct CKIOLFHHILF : MPJKLBPKLOJ<ParentData>
{
	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x5E835F0", Offset = "0x5E81DF0", VA = "0x185E835F0", Slot = "4")]
	public bool KEHPCGJIGOP(ParentData FKKGMPDEPMA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[BurstCompile]
public struct KJMEPFJOGNK<T> : IEqualityComparer<ArchetypeChunk> where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	[ReadOnly]
	public SharedComponentTypeHandle<T> NLJAIEKLGJA;

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x1626D70", Offset = "0x1625570", VA = "0x181626D70")]
	public KJMEPFJOGNK(SharedComponentTypeHandle<T> NLJAIEKLGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x387A530", Offset = "0x3878D30", VA = "0x18387A530", Slot = "4")]
	public bool Equals(ArchetypeChunk IILAPOMEGLM, ArchetypeChunk BNBBAPGFCCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x387A630", Offset = "0x3878E30", VA = "0x18387A630", Slot = "5")]
	public int GetHashCode(ArchetypeChunk CKCLFCHPNMG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public struct CEOLJMNAFEA<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private CEKOJNBMIFL<T> IFOEKNINMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private EntityCommandBuffer FBMJLIEEDMG;

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x3851940", Offset = "0x3850140", VA = "0x183851940")]
	public CEOLJMNAFEA(CEKOJNBMIFL<T> IFOEKNINMPE, EntityCommandBuffer FBMJLIEEDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x4AB31C0", Offset = "0x4AB19C0", VA = "0x184AB31C0", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x340DEA0", Offset = "0x340C6A0", VA = "0x18340DEA0")]
	public static CEKOJNBMIFL<T> FEBAGKLNOCP(CEOLJMNAFEA<T> EJBGEGKBPNL)
	{
		return default(CEKOJNBMIFL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public struct DGHBFGFNKGP<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private JAGJHJFLDGF<T> IFOEKNINMPE;

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x3B98250", Offset = "0x3B96A50", VA = "0x183B98250")]
	public DGHBFGFNKGP(JAGJHJFLDGF<T> IFOEKNINMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x4D177A0", Offset = "0x4D15FA0", VA = "0x184D177A0")]
	public CEOLJMNAFEA<T> OHJEKKLFFKC()
	{
		return default(CEOLJMNAFEA<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
public struct KAAKBLDCHLJ<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private CEKOJNBMIFL<T> IFOEKNINMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private EntityCommandBuffer FBMJLIEEDMG;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public CEKOJNBMIFL<T> BDEJJMEKADL
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x340DEA0", Offset = "0x340C6A0", VA = "0x18340DEA0")]
		get
		{
			return default(CEKOJNBMIFL<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0x3851940", Offset = "0x3850140", VA = "0x183851940")]
	public KAAKBLDCHLJ(CEKOJNBMIFL<T> IFOEKNINMPE, EntityCommandBuffer FBMJLIEEDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x3850D50", Offset = "0x384F550", VA = "0x183850D50")]
	public void BONOGJOBGFA(JAGJHJFLDGF<T> EMCOEDMEIPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x3851440", Offset = "0x384FC40", VA = "0x183851440", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x340DEA0", Offset = "0x340C6A0", VA = "0x18340DEA0")]
	public static CEKOJNBMIFL<T> FEBAGKLNOCP(KAAKBLDCHLJ<T> EJBGEGKBPNL)
	{
		return default(CEKOJNBMIFL<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
public struct NBEDEDGLAMG<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059A")]
	private JAGJHJFLDGF<T> IFOEKNINMPE;

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x3B98250", Offset = "0x3B96A50", VA = "0x183B98250")]
	public NBEDEDGLAMG(JAGJHJFLDGF<T> IFOEKNINMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x3B97C90", Offset = "0x3B96490", VA = "0x183B97C90")]
	public KAAKBLDCHLJ<T> CHDPGADOFNI()
	{
		return default(KAAKBLDCHLJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
[DefaultMember("Item")]
public struct CEKOJNBMIFL<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	public NativeList<Entity> FAIFKAKJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	public NativeList<T> AELCABDCBDD;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public int LPJHKGAOANG
	{
		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x4AB1200", Offset = "0x4AAFA00", VA = "0x184AB1200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public (Entity entity, T value) HBLJIDEPNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x4AB1EE0", Offset = "0x4AB06E0", VA = "0x184AB1EE0")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x4AB0CB0", Offset = "0x4AAF4B0", VA = "0x184AB0CB0")]
	public void BONJGFNEKBE(Entity KCMPKMKBCOO, T FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x4AB17F0", Offset = "0x4AAFFF0", VA = "0x184AB17F0")]
	public void OIDAMBIIEFH(NativeArray<Entity> KCMPKMKBCOO, NativeArray<T> FKKGMPDEPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
public struct JAGJHJFLDGF<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	[ReadOnly]
	public EntityQueryInJob LGGGLPHDMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	[ReadOnly]
	public EntityTypeHandle KJFJLHBCBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	[ReadOnly]
	public ComponentTypeHandle<T> BPPALDMIIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A0")]
	[WriteOnly]
	public EntityCommandBuffer FBMJLIEEDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	public AllocatorManager.AllocatorHandle JONICLHJBEP;

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x37D8480", Offset = "0x37D6C80", VA = "0x1837D8480")]
	public CEKOJNBMIFL<T> OHJEKKLFFKC()
	{
		return default(CEKOJNBMIFL<T>);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
	[CompilerGenerated]
	internal class SplinePointOrderingUpdateSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x20001C6")]
		[BurstCompile]
		private struct UpdateSplineIndexJob : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A5")]
			[ReadOnly]
			public NativeArray<global::EOFKHAOHLOD> indexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			[ReadOnly]
			public ComponentDataFromEntity<AABJHPEEABP> splinePointParentDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			public ComponentDataFromEntity<OLPFDHBGHHP> splinePointOrderDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x5EA3030", Offset = "0x5EA1830", VA = "0x185EA3030", Slot = "4")]
			public void Execute(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C7")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			[ReadOnly]
			public ComponentDataFromEntity<OLPFDHBGHHP> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x5E92EE0", Offset = "0x5E916E0", VA = "0x185E92EE0", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C8")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SplinePointOrderingUpdateSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005AB")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40005AC")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600099A")]
			[Cpp2IlInjected.Address(RVA = "0x5EA1A70", Offset = "0x5EA0270", VA = "0x185EA1A70")]
			private void KJMBDHFEAAM(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0x5EA1940", Offset = "0x5EA0140", VA = "0x185EA1940", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private EntityQuery needsUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		[NMIHDJKFGCM]
		private PPEDACELMBL singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private EntityQuery SplinePointOrderingUpdateSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1660", Offset = "0x5E9FE60", VA = "0x185EA1660", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1D10", Offset = "0x5EA0510", VA = "0x185EA1D10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x5EA12D0", Offset = "0x5E9FAD0", VA = "0x185EA12D0")]
		private void HEIMJJKKDPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x5EA16B0", Offset = "0x5E9FEB0", VA = "0x185EA16B0")]
		private void LDHBOHDMLIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1190", Offset = "0x5E9F990", VA = "0x185EA1190")]
		private static FBHABIOPBAB CKCPLCFJKPM(int insertionIndex, ComponentDataFromEntity<OLPFDHBGHHP> splinePointOrderDataRO, NativeArray<Entity> children)
		{
			return default(FBHABIOPBAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1810", Offset = "0x5EA0010", VA = "0x185EA1810")]
		private JobHandle LFEAPCNJLNC(OrderComparer comparer, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1B00", Offset = "0x5EA0300", VA = "0x185EA1B00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public SplinePointOrderingUpdateSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[CompilerGenerated]
	[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
	internal class SplinePointParentChangedSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x20001CA")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SplinePointParentChangedSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public DynamicBuffer<global::EOFKHAOHLOD> splineIndexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			[ReadOnly]
			public ComponentTypeHandle<AABJHPEEABP> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009A6")]
			[Cpp2IlInjected.Address(RVA = "0x5EC3E00", Offset = "0x5EC2600", VA = "0x185EC3E00")]
			private void KJMBDHFEAAM(Entity splinePoint, [In][NoAlias] AABJHPEEABP splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A7")]
			[Cpp2IlInjected.Address(RVA = "0x5EC3CE0", Offset = "0x5EC24E0", VA = "0x185EC3CE0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SplinePointParentChangedSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B9")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40005BA")]
			[ReadOnly]
			public ComponentTypeHandle<global::PEOJNKFONGL> __splinePointParentSystemDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009A8")]
			[Cpp2IlInjected.Address(RVA = "0x5EC4070", Offset = "0x5EC2870", VA = "0x185EC4070")]
			private void KJMBDHFEAAM(Entity splinePoint, [In][NoAlias] global::PEOJNKFONGL splinePointParentSystemData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A9")]
			[Cpp2IlInjected.Address(RVA = "0x5EC3F50", Offset = "0x5EC2750", VA = "0x185EC3F50", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private EntityQuery needsAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private EntityQuery needsRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		[NMIHDJKFGCM]
		private PPEDACELMBL singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private ComponentTypeHandle<AABJHPEEABP> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private ComponentTypeHandle<global::PEOJNKFONGL> __RecRoom_Components_SplinePointParentSystemData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA24E0", Offset = "0x5EA0CE0", VA = "0x185EA24E0", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA28E0", Offset = "0x5EA10E0", VA = "0x185EA28E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA28D0", Offset = "0x5EA10D0", VA = "0x185EA28D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA22A0", Offset = "0x5EA0AA0", VA = "0x185EA22A0")]
		private void HNIJDKAEBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1EC0", Offset = "0x5EA06C0", VA = "0x185EA1EC0")]
		private void ELPBLPIINLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1E70", Offset = "0x5EA0670", VA = "0x185EA1E70")]
		private EntityCommandBufferSystem CMCIMJNMJOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2B20", Offset = "0x5EA1320", VA = "0x185EA2B20")]
		private JobHandle PLBPLCKKICO(EntityCommandBuffer ecb, DynamicBuffer<global::EOFKHAOHLOD> splineIndexUpdatesRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2170", Offset = "0x5EA0970", VA = "0x185EA2170")]
		private JobHandle GIFMPIDLPAA(BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2530", Offset = "0x5EA0D30", VA = "0x185EA2530", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public SplinePointParentChangedSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal sealed class PIGPKDEOMNK : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0840", Offset = "0x5EBF040", VA = "0x185EC0840", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public PIGPKDEOMNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal sealed class PJMHONEPCDH : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0980", Offset = "0x5EBF180", VA = "0x185EC0980", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public PJMHONEPCDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal sealed class LMCMLPCGJAE : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB35A0", Offset = "0x5EB1DA0", VA = "0x185EB35A0", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public LMCMLPCGJAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal sealed class BPHKBFNMGCI : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0x5EA54B0", Offset = "0x5EA3CB0", VA = "0x185EA54B0", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public BPHKBFNMGCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal sealed class AEHKIDDBJNA : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x60009B2")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3BB0", Offset = "0x5EA23B0", VA = "0x185EA3BB0", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public AEHKIDDBJNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal sealed class LDEGJHIBAKM : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2980", Offset = "0x5EB1180", VA = "0x185EB2980", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public LDEGJHIBAKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[ExecuteAlways]
public class KMIEDMOIFHD : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	public KMIEDMOIFHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal sealed class BBOFGIAFOHB : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3E70", Offset = "0x5EA2670", VA = "0x185EA3E70", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public BBOFGIAFOHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
internal class NHCMNPGEBGF : DCNNAKBCEBC
{
	[Cpp2IlInjected.Token(Token = "0x60009B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public NHCMNPGEBGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal sealed class MJMMLAIDBHO : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x60009BA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4920", Offset = "0x5EB3120", VA = "0x185EB4920", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public MJMMLAIDBHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
internal class BDIKGJMEFJM : DCNNAKBCEBC
{
	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public BDIKGJMEFJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
internal class JJNDPLLDCNL : DCNNAKBCEBC
{
	[Cpp2IlInjected.Token(Token = "0x60009BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public JJNDPLLDCNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public sealed class MEHJJCCIALG : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x60009BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3F20", Offset = "0x5EB2720", VA = "0x185EB3F20", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public MEHJJCCIALG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
[ExecuteAlways]
public class KBILGICPLHD : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009C0")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	public KBILGICPLHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public class AENMOOGPCJN : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x60009C1")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C2")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public AENMOOGPCJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
[AMCOHLDKFON]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
public class APBNKPHFHDC : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private PDJBPFDHMMJ MLDHMBALKBH;

	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3E00", Offset = "0x5EA2600", VA = "0x185EA3E00", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3E50", Offset = "0x5EA2650", VA = "0x185EA3E50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public APBNKPHFHDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
public class JOGADMNKIIK : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x20001DD")]
	[BurstCompile]
	private struct LAHIFJNAFCH : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		[ReadOnly]
		public NativeArray<Entity> FAIFKAKJOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<OAEOJOGLFPE> EAEMGOJMJDJ;

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2710", Offset = "0x5EB0F10", VA = "0x185EB2710", Slot = "4")]
		public void Execute(int LFEFGCGCIAG, TransformAccess CPMBJLDHCID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x5EB28E0", Offset = "0x5EB10E0", VA = "0x185EB28E0")]
		private bool IGKCCCHMOAP(float3 JHENJKJEFON, float3 OEHHBJMJCPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2910", Offset = "0x5EB1110", VA = "0x185EB2910")]
		private bool JHBCKDIDMDN(quaternion JHENJKJEFON, quaternion OEHHBJMJCPL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	[BurstCompile]
	private struct FDCBAIMOMAL : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		[ReadOnly]
		public NativeArray<Entity> FAIFKAKJOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<JLCBOGGNFCI> LHLPAJKPEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<CLPIGHNAAHL> KECINAODFLO;

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB790", Offset = "0x5EA9F90", VA = "0x185EAB790", Slot = "4")]
		public void Execute(int LFEFGCGCIAG, TransformAccess CPMBJLDHCID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private static readonly DGJIKJLGCCH MICGIHPBGKK;

	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private static readonly DGJIKJLGCCH PCBOCKIFFOO;

	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private static readonly DGJIKJLGCCH OLLNELFAEIB;

	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private static readonly ProfilerMarker LKJKJBEABPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private DBIGBNACKOL EPEGLBFPCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1C20", Offset = "0x5EB0420", VA = "0x185EB1C20", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1C90", Offset = "0x5EB0490", VA = "0x185EB1C90", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1CD0", Offset = "0x5EB04D0", VA = "0x185EB1CD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public JOGADMNKIIK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001DF")]
	[CompilerGenerated]
	[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
	public class RegisterTransformsSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x20001E0")]
		private struct RegisterTransformsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D0")]
			public RegisterTransformsSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005D1")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40005D2")]
			[ReadOnly]
			public ComponentTypeHandle<MLHMPIHECII> __arrayIndexTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			public ComponentTypeHandle<Transform> __transformTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009DD")]
			[Cpp2IlInjected.Address(RVA = "0x5EC2BD0", Offset = "0x5EC13D0", VA = "0x185EC2BD0")]
			private void OriginalLambdaBody(Entity entity, [In] MLHMPIHECII arrayIndex, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009DE")]
			[Cpp2IlInjected.Address(RVA = "0x5EC29E0", Offset = "0x5EC11E0", VA = "0x185EC29E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private DBIGBNACKOL embodiedTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private EntityQuery allTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private EntityQuery addNewTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private EntityQuery removeOldTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private EntityQuery clearTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private EntityQuery RegisterTransformsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private ComponentTypeHandle<MLHMPIHECII> __RecRoom_Components_TransformAccessArrayIndexData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2990", Offset = "0x5EC1190", VA = "0x185EC2990", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2EE0", Offset = "0x5EC16E0", VA = "0x185EC2EE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x5EC31B0", Offset = "0x5EC19B0", VA = "0x185EC31B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC25A0", Offset = "0x5EC0DA0", VA = "0x185EC25A0")]
		private void AddTransforms(EntityQuery query, EJIFDEEOFIA accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x5EC34C0", Offset = "0x5EC1CC0", VA = "0x185EC34C0")]
		private void RemoveTransforms(EntityQuery query, EJIFDEEOFIA accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3120", Offset = "0x5EC1920", VA = "0x185EC3120", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2440", Offset = "0x5EC0C40", VA = "0x185EC2440")]
		private void AddNewTransforms(NativeArray<Entity> entities, EJIFDEEOFIA accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x5EC32A0", Offset = "0x5EC1AA0", VA = "0x185EC32A0")]
		internal static void RemoveOldTransforms(NativeArray<MLHMPIHECII> arrayIndices, ComponentDataFromEntity<MLHMPIHECII> transformAccess, EJIFDEEOFIA accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
		private static void DebugLogRemove(int index, EJIFDEEOFIA accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2840", Offset = "0x5EC1040", VA = "0x185EC2840")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DebugLogUninitializedTransformAccessArrayIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2840", Offset = "0x5EC1040", VA = "0x185EC2840")]
		private void RegisterTransformsSystem_LambdaJob_0_Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2CE0", Offset = "0x5EC14E0", VA = "0x185EC2CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public RegisterTransformsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
public class OIJNLFLPMED : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x20001E3")]
	[BurstCompile]
	private struct IGKIONOLFMN : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		[ReadOnly]
		public ComponentDataFromEntity<OAEOJOGLFPE> EAEMGOJMJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		[ReadOnly]
		public NativeArray<Entity> FAIFKAKJOPP;

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x5EAF890", Offset = "0x5EAE090", VA = "0x185EAF890", Slot = "4")]
		public void Execute(int LFEFGCGCIAG, TransformAccess CPMBJLDHCID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001E4")]
	[BurstCompile]
	private struct MJNKOMILCJF : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		[ReadOnly]
		public ComponentDataFromEntity<JLCBOGGNFCI> LHLPAJKPEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		[ReadOnly]
		public NativeArray<Entity> FAIFKAKJOPP;

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x5EB58E0", Offset = "0x5EB40E0", VA = "0x185EB58E0", Slot = "4")]
		public void Execute(int LFEFGCGCIAG, TransformAccess CPMBJLDHCID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001E5")]
	[BurstCompile]
	private struct MHBJBNEOCBA : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		[ReadOnly]
		public ComponentDataFromEntity<JLCBOGGNFCI> LHLPAJKPEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		[ReadOnly]
		public ComponentDataFromEntity<CLPIGHNAAHL> KECINAODFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		[ReadOnly]
		public NativeArray<Entity> FAIFKAKJOPP;

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x5EB47B0", Offset = "0x5EB2FB0", VA = "0x185EB47B0", Slot = "4")]
		public void Execute(int LFEFGCGCIAG, TransformAccess CPMBJLDHCID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private static readonly DGJIKJLGCCH MICGIHPBGKK;

	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	private static readonly DGJIKJLGCCH PCBOCKIFFOO;

	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	private static readonly DGJIKJLGCCH OLLNELFAEIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	private DBIGBNACKOL EPEGLBFPCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private EntityQuery EFCEILALHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private EntityQuery NOPLGNFLMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private EntityQuery DMIFAEKJALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private TransformAccessArray PIHFBIGNJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private TransformAccessArray HKAEJDFOHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private TransformAccessArray MGBBHNCBFPG;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDDA0", Offset = "0x5EBC5A0", VA = "0x185EBDDA0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDF70", Offset = "0x5EBC770", VA = "0x185EBDF70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE180", Offset = "0x5EBC980", VA = "0x185EBE180", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE210", Offset = "0x5EBCA10", VA = "0x185EBE210", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E5")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE240", Offset = "0x5EBCA40", VA = "0x185EBE240", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E6")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDDF0", Offset = "0x5EBC5F0", VA = "0x185EBDDF0")]
	private NativeArray<Entity> OLKEPGMDIDE(NativeArray<MLHMPIHECII> GPEAFMNEBLH, NativeList<Entity> OGKCOBIFMBH, TransformAccessArray IJBBICAGIDM, TransformAccessArray LBNHHDHMJML)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public OIJNLFLPMED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
public class GJIBCOPMADK : DPGFJAECHAF, FIBMJMMLGPO
{
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private NGPBKFGDAEA CJLECODJBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	private AGPODNPCKBE IKEMBHLKPGK;

	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E82520", Offset = "0x5E80D20", VA = "0x185E82520", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC340", Offset = "0x5EAAB40", VA = "0x185EAC340", Slot = "14")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC650", Offset = "0x5EAAE50", VA = "0x185EAC650", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC4E0", Offset = "0x5EAACE0", VA = "0x185EAC4E0")]
	private static void JNPECJOPDHG(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, Entity OBIIIBPBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC440", Offset = "0x5EAAC40", VA = "0x185EAC440")]
	private static bool CHKJBCJNDCM(EntityManager IDCNBIGHJII, Entity KCMPKMKBCOO, [Out] Transform CPMBJLDHCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public GJIBCOPMADK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
public class DNPGHKIPEHM : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x20001E8")]
	[BurstCompile]
	private struct FOKLDFIDEKB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		[ReadOnly]
		public ComponentTypeHandle<BDJLHGAHJBG> FDBHOGHBAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		[ReadOnly]
		public BufferTypeHandle<ChildrenData> FKAHMBHHHJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> EJKFGPPGGKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		[ReadOnly]
		public ComponentDataFromEntity<BDJLHGAHJBG> KMOIGMCDELC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public ComponentTypeHandle<BCAHBAGLDKB> JNLFLHFJPDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<BCAHBAGLDKB> BBPDDNGBNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public uint PAMKBMMMMJM;

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x5EABDD0", Offset = "0x5EAA5D0", VA = "0x185EABDD0", Slot = "4")]
		public void Execute(ArchetypeChunk CKCLFCHPNMG, int LFEFGCGCIAG, int FDGFENCCGOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB9F0", Offset = "0x5EAA1F0", VA = "0x185EAB9F0")]
		private void EDINDHOBPNH(float4x4 CPDMHAHCOIL, Entity KCMPKMKBCOO, bool JCKBJDCJFDB, int IGMBNCEJALG = 1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private EntityQuery FCILOBLGKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private EntityQuery BCDHAMBFFBH;

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EA64A0", Offset = "0x5EA4CA0", VA = "0x185EA64A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA65D0", Offset = "0x5EA4DD0", VA = "0x185EA65D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public DNPGHKIPEHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
public class GFCFIMEKFPM : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[BurstCompile]
	private struct COLNMBHDAAA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		[ReadOnly]
		public ComponentTypeHandle<BDJLHGAHJBG> FDBHOGHBAAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public ComponentTypeHandle<BCAHBAGLDKB> JNLFLHFJPDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public uint PAMKBMMMMJM;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5500", Offset = "0x5EA3D00", VA = "0x185EA5500", Slot = "4")]
		public void Execute(ArchetypeChunk CKCLFCHPNMG, int LFEFGCGCIAG, int FDGFENCCGOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5610", Offset = "0x5EA3E10", VA = "0x185EA5610")]
		public bool MCLLCHOPEDG(ArchetypeChunk CKCLFCHPNMG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private EntityQuery FCILOBLGKKP;

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC0D0", Offset = "0x5EAA8D0", VA = "0x185EAC0D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC200", Offset = "0x5EAAA00", VA = "0x185EAC200", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public GFCFIMEKFPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class KGCAAILBJMH : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	[BurstCompile]
	private struct MGFIPIOBEHN : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		[ReadOnly]
		public ComponentTypeHandle<BCAHBAGLDKB> PMMOLFGKLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public ComponentTypeHandle<HDPLCCLBLHA> KJGGNHENMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public ComponentTypeHandle<MILHEFEKDGC> DBFLLJBLNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public ComponentTypeHandle<DFNEPJFFJAA> LLILEDMIMBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public uint PAMKBMMMMJM;

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4330", Offset = "0x5EB2B30", VA = "0x185EB4330", Slot = "4")]
		public void Execute(ArchetypeChunk CKCLFCHPNMG, int LFEFGCGCIAG, int FDGFENCCGOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4720", Offset = "0x5EB2F20", VA = "0x185EB4720")]
		public bool MCLLCHOPEDG(ArchetypeChunk CKCLFCHPNMG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private EntityQuery DFJLJGOOCKN;

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB21F0", Offset = "0x5EB09F0", VA = "0x185EB21F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2300", Offset = "0x5EB0B00", VA = "0x185EB2300", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public KGCAAILBJMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001ED")]
public class FBCCMCEKOHJ : DPGFJAECHAF
{
	[Cpp2IlInjected.Token(Token = "0x20001EE")]
	[BurstCompile]
	private struct NGFONPICOEP : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		[ReadOnly]
		public ComponentTypeHandle<OAEOJOGLFPE> BJODODNEAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		[ReadOnly]
		public ComponentTypeHandle<CLPIGHNAAHL> EBDEHBBPKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		[ReadOnly]
		public ComponentTypeHandle<JLCBOGGNFCI> PNIMGGGIKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public ComponentTypeHandle<BDJLHGAHJBG> JEINBGNLNDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public uint PAMKBMMMMJM;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x5EB5990", Offset = "0x5EB4190", VA = "0x185EB5990", Slot = "4")]
		public void Execute(ArchetypeChunk CKCLFCHPNMG, int LFEFGCGCIAG, int FDGFENCCGOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6100", Offset = "0x5EB4900", VA = "0x185EB6100")]
		public bool MCLLCHOPEDG(ArchetypeChunk CKCLFCHPNMG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005FE")]
	private EntityQuery DFJLJGOOCKN;

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB4A0", Offset = "0x5EA9CA0", VA = "0x185EAB4A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB5D0", Offset = "0x5EA9DD0", VA = "0x185EAB5D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public FBCCMCEKOHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EF")]
public class HGLMOABIMOL : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	[NMIHDJKFGCM]
	private LKNNFAHLOJG OGAAJFBIIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	[NMIHDJKFGCM]
	private OGDIMNHIMAP DDGLGAPFCBH;

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD7C0", Offset = "0x5EABFC0", VA = "0x185EAD7C0", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x5EADC70", Offset = "0x5EAC470", VA = "0x185EADC70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD830", Offset = "0x5EAC030", VA = "0x185EAD830")]
	private void KINLIOMDDHJ(NativeArray<AFCHODDKGEA> ODIFMNHEBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public HGLMOABIMOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F0")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal class LNMBNIMDDJG : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private LKNNFAHLOJG HMIKAMPGKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private JEIJFNDLCFE KOJOEBGFGAH;

	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3740", Offset = "0x5EB1F40", VA = "0x185EB3740", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB37D0", Offset = "0x5EB1FD0", VA = "0x185EB37D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public LNMBNIMDDJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F1")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
public sealed class HKNCFOMIJJP : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private GAHJBAOIADM PNFHHOFJABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private LKNNFAHLOJG AJBGICFOANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private NODGOFCBOKD DDFGJFHNCLH;

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x5EADE20", Offset = "0x5EAC620", VA = "0x185EADE20", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x5EADEB0", Offset = "0x5EAC6B0", VA = "0x185EADEB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public HKNCFOMIJJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F2")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal class OJCFCGEPENE : DPGFJAECHAF, GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private static readonly DGJIKJLGCCH EBLJJPBJGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	[NMIHDJKFGCM]
	private OGNNNIMMEPN KNCOEFOICAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	[NMIHDJKFGCM]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	[NMIHDJKFGCM]
	private CHOGKACALOP DCDDAGNGHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	[NMIHDJKFGCM]
	private HBEALOBIFKA CICGACDDBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	[NMIHDJKFGCM]
	private DGHDNCBDPIG CDEDNLBBCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	[NMIHDJKFGCM]
	private BHDDONJLECH NKAPFCJKAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private DDACIDEFPPF.IPLLPHHCBPN DMCMOFKFMMA;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF590", Offset = "0x5EBDD90", VA = "0x185EBF590", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF2F0", Offset = "0x5EBDAF0", VA = "0x185EBF2F0", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0760", Offset = "0x5EBEF60", VA = "0x185EC0760", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF810", Offset = "0x5EBE010", VA = "0x185EBF810")]
	private void LEOJCKFKGFH(KABIMFKAPPA OHPCNPKOLBJ, NativeArray<byte> KGJAJFOOBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF290", Offset = "0x5EBDA90", VA = "0x185EBF290")]
	private bool DGHEAJPLNLH(KABIMFKAPPA OHPCNPKOLBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF140", Offset = "0x5EBD940", VA = "0x185EBF140")]
	private DDACIDEFPPF.OLPAMBMAFMM AMGMIBPHIFF(NativeArray<byte> KGJAJFOOBFO, Allocator JONICLHJBEP)
	{
		return default(DDACIDEFPPF.OLPAMBMAFMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF730", Offset = "0x5EBDF30", VA = "0x185EBF730")]
	private void LBGALJNOAHD(DDACIDEFPPF.OLPAMBMAFMM LECKHJELHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF390", Offset = "0x5EBDB90", VA = "0x185EBF390")]
	private void FHCIIHOEILM(NativeList<AFCHODDKGEA> BFBKFPJFMOH, NativeList<GEPBLNPDOFJ> EIGLBIKONIC, Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBEAB0", Offset = "0x5EBD2B0", VA = "0x185EBEAB0")]
	private void AGCFCDCLMKE(NativeParallelMultiHashMap<AFCHODDKGEA, LBMALLKEHFP> NMGFPBPBHOH, NativeList<byte> KAABFFNALEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC04D0", Offset = "0x5EBECD0", VA = "0x185EC04D0")]
	private void ONFGBHHJDPM(NativeList<AFCHODDKGEA> GCPBAFELODG, Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x5EBEFA0", Offset = "0x5EBD7A0", VA = "0x185EBEFA0")]
	private void AIAAMJBMKPL(DDACIDEFPPF.OLPAMBMAFMM AELCABDCBDD, bool BHEHMDFNBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFD60", Offset = "0x5EBE560", VA = "0x185EBFD60")]
	private void MFOLOIBAFOC(NativeList<AFCHODDKGEA> BFBKFPJFMOH, NativeList<GEPBLNPDOFJ> EIGLBIKONIC, bool BHEHMDFNBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFE00", Offset = "0x5EBE600", VA = "0x185EBFE00")]
	private void MIEFBGKFNMN(NativeParallelMultiHashMap<AFCHODDKGEA, LBMALLKEHFP> NMGFPBPBHOH, NativeList<byte> KAABFFNALEK, bool BHEHMDFNBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0430", Offset = "0x5EBEC30", VA = "0x185EC0430")]
	private void NAKLHKHBPGJ(NativeList<AFCHODDKGEA> GCPBAFELODG, bool BHEHMDFNBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void BEKFKHMBPJM(KABIMFKAPPA OHPCNPKOLBJ, bool BHEHMDFNBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public OJCFCGEPENE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F3")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal class EKKPEOEHMFP : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private NHCACALFIKB PEENKKOKGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private LKNNFAHLOJG HMIKAMPGKAM;

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8D30", Offset = "0x5EA7530", VA = "0x185EA8D30", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8DA0", Offset = "0x5EA75A0", VA = "0x185EA8DA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A27")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public EKKPEOEHMFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F4")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal class HOMNCGONKHK : DPGFJAECHAF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private MPONBMGLGEH DMEBAJIIFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private LKNNFAHLOJG HMIKAMPGKAM;

	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE090", Offset = "0x5EAC890", VA = "0x185EAE090", Slot = "14")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE100", Offset = "0x5EAC900", VA = "0x185EAE100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2B")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public HOMNCGONKHK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001F5")]
	[CompilerGenerated]
	[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
	[AlwaysUpdateSystem]
	internal sealed class WriteDiffChangePacketToNetworkSystem : DPGFJAECHAF, GJOKPFDLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x20001F6")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct WriteDiffChangePacketToNetworkSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20001F7")]
			public delegate void RunWithoutJobSystem_00000BEE$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20001F8")]
			internal static class RunWithoutJobSystem_00000BEE$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000632")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000633")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000A46")]
				[Cpp2IlInjected.Address(RVA = "0x5EC3A50", Offset = "0x5EC2250", VA = "0x185EC3A50")]
				[BurstDiscard]
				private static void JBJHKKNLKOD(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A47")]
				[Cpp2IlInjected.Address(RVA = "0x5EC3B80", Offset = "0x5EC2380", VA = "0x185EC3B80")]
				private static IntPtr JLNOMCGJAEF()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A48")]
				[Cpp2IlInjected.Address(RVA = "0x5EC39A0", Offset = "0x5EC21A0", VA = "0x185EC39A0")]
				public static void BMLNCOHHOFB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A49")]
				[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
				public static void GLJEDCMMNGN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A4B")]
				[Cpp2IlInjected.Address(RVA = "0x5EC37D0", Offset = "0x5EC1FD0", VA = "0x185EC37D0")]
				public static void BHJKEIPKKOJ(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000624")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000625")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000626")]
			public DCECDHHIHFP replication;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000627")]
			public NativeBitArray entityByProperty;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000628")]
			[ReadOnly]
			public NativeArray<AFCHODDKGEA> srcCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000629")]
			[ReadOnly]
			public NativeArray<GEPBLNPDOFJ> srcCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			[ReadOnly]
			public NativeArray<AFCHODDKGEA> srcDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			[ReadOnly]
			public NativeKeyValueArrays<Entity, HDMJOKNPAGJ> srcPropertyKeyValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			public NativeList<AFCHODDKGEA> dstCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400062D")]
			public NativeList<GEPBLNPDOFJ> dstCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400062E")]
			public NativeList<AFCHODDKGEA> dstDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400062F")]
			public NativeParallelMultiHashMap<AFCHODDKGEA, LBMALLKEHFP> dstProperties;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000630")]
			public NativeList<byte> dstPropertyData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000631")]
			public ComponentDataFromEntity<KEHHIJFCONH> __RecRoom_Components_ObjectNetworkIdComponentData_FromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0x5EC5040", Offset = "0x5EC3840", VA = "0x185EC5040")]
			private void KJMBDHFEAAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x5EC5030", Offset = "0x5EC3830", VA = "0x185EC5030", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x5EC54A0", Offset = "0x5EC3CA0", VA = "0x185EC54A0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void NCKDDFJJGEJ(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0x5EC56B0", Offset = "0x5EC3EB0", VA = "0x185EC56B0")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void PJJPMCMDDHM(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private static readonly DGJIKJLGCCH log;

		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private static readonly DGJIKJLGCCH logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		[NMIHDJKFGCM]
		private EGGLLMDPOBO packetService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		[NMIHDJKFGCM]
		private LKNNFAHLOJG diffService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		[NMIHDJKFGCM]
		private NOBCMIJEINK editorEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		[NMIHDJKFGCM]
		private LPGGEAMFNMM transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private DDACIDEFPPF.IPLLPHHCBPN utilServices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		private bool HasEditorListeners
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		private PKOKFDIAPOJ EventFlagsForPhase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x5EC49F0", Offset = "0x5EC31F0", VA = "0x185EC49F0")]
			get
			{
				return default(PKOKFDIAPOJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4EE0", Offset = "0x5EC36E0", VA = "0x185EC4EE0", Slot = "14")]
		public void InitReferences(HMNFMHNMJBH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6440", Offset = "0x5EC4C40", VA = "0x185EC6440", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4840", Offset = "0x5EC3040", VA = "0x185EC4840")]
		private bool AJLHEJOPICD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4DC0", Offset = "0x5EC35C0", VA = "0x185EC4DC0")]
		private bool IFEJNKOKCJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4FE0", Offset = "0x5EC37E0", VA = "0x185EC4FE0")]
		private bool KDJNHHOEOOG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x5EC68E0", Offset = "0x5EC50E0", VA = "0x185EC68E0")]
		private DDACIDEFPPF.OLPAMBMAFMM PAKGPFFFJDI(LKEAAHCANFE state)
		{
			return default(DDACIDEFPPF.OLPAMBMAFMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4300", Offset = "0x5EC2B00", VA = "0x185EC4300")]
		private NativeKeyValueArrays<Entity, HDMJOKNPAGJ> ABMAKGJLEEG(LKEAAHCANFE state, [Out] int capacity)
		{
			return default(NativeKeyValueArrays<Entity, HDMJOKNPAGJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4A90", Offset = "0x5EC3290", VA = "0x185EC4A90")]
		private void FEGGJMEGGGO(DDACIDEFPPF.OLPAMBMAFMM data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4910", Offset = "0x5EC3110", VA = "0x185EC4910")]
		private void EHMOKEALPJD(DDACIDEFPPF.OLPAMBMAFMM data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4600", Offset = "0x5EC2E00", VA = "0x185EC4600")]
		private void AIAAMJBMKPL(DDACIDEFPPF.OLPAMBMAFMM data, LKEAAHCANFE state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x5EC59D0", Offset = "0x5EC41D0", VA = "0x185EC59D0")]
		private void MFOLOIBAFOC(NativeArray<AFCHODDKGEA> createdIds, NativeArray<GEPBLNPDOFJ> creationData, PKOKFDIAPOJ flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5A00", Offset = "0x5EC4200", VA = "0x185EC5A00")]
		private void MIEFBGKFNMN(NativeMultiHashMapAsync<Entity, HDMJOKNPAGJ> differences, PKOKFDIAPOJ flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC61A0", Offset = "0x5EC49A0", VA = "0x185EC61A0")]
		private void NAKLHKHBPGJ(NativeArray<AFCHODDKGEA> destroyedIds, PKOKFDIAPOJ flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5700", Offset = "0x5EC3F00", VA = "0x185EC5700")]
		private void MCBJODLLHDC(DCECDHHIHFP replication, NativeBitArray entityByProperty, NativeArray<AFCHODDKGEA> srcCreatedIds, NativeArray<GEPBLNPDOFJ> srcCreationData, NativeArray<AFCHODDKGEA> srcDestroyedIds, NativeKeyValueArrays<Entity, HDMJOKNPAGJ> srcPropertyKeyValues, NativeList<AFCHODDKGEA> dstCreatedIds, NativeList<GEPBLNPDOFJ> dstCreationData, NativeList<AFCHODDKGEA> dstDestroyedIds, NativeParallelMultiHashMap<AFCHODDKGEA, LBMALLKEHFP> dstProperties, NativeList<byte> dstPropertyData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC61D0", Offset = "0x5EC49D0", VA = "0x185EC61D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
		public WriteDiffChangePacketToNetworkSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4FA0", Offset = "0x5EC37A0", VA = "0x185EC4FA0")]
		public static void JFBHHONAMNO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F9")]
internal class DLIDKNPOIEL : AMEMCDCEAHM
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001FA")]
	public struct EMHKDMKILNI : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	protected override ComponentType PMPMCBLIALC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5FB0", Offset = "0x5EA47B0", VA = "0x185EA5FB0", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	protected override ComponentType IOCAMNDAIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5F50", Offset = "0x5EA4750", VA = "0x185EA5F50", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	protected override ComponentType DLJIGOFNNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5F80", Offset = "0x5EA4780", VA = "0x185EA5F80", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6070", Offset = "0x5EA4870", VA = "0x185EA6070")]
	public DLIDKNPOIEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FB")]
public sealed class DFKCNFCFODE : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5700", Offset = "0x5EA3F00", VA = "0x185EA5700", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public DFKCNFCFODE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FC")]
[ExecuteAlways]
public class AODPOAICBDI : MHNPHMEOCAG
{
	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public AODPOAICBDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FD")]
public sealed class PNBIPGMBIEH : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0B20", Offset = "0x5EBF320", VA = "0x185EC0B20", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public PNBIPGMBIEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FE")]
public sealed class JIDEIDNAANL : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x5EB15B0", Offset = "0x5EAFDB0", VA = "0x185EB15B0", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public JIDEIDNAANL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FF")]
[ExecuteAlways]
public class IMIKFGABFIK : MHNPHMEOCAG
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x3060AF0", Offset = "0x305F2F0", VA = "0x183060AF0")]
	public IMIKFGABFIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000200")]
public sealed class HOEMOBKHHMB : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x5EADFC0", Offset = "0x5EAC7C0", VA = "0x185EADFC0", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public HOEMOBKHHMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000201")]
[OAEOFLFLIGA(typeof(ODFFABDNAGO))]
[DEONFKEHMJD(typeof(CBDHEEDCCOH), new string[] { })]
public class POIEOFDNGID : CBDHEEDCCOH, GMMHILFNMPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private readonly Dictionary<int, MDPDCPPKJHK> PDNDMFKGDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private readonly Dictionary<Type, MDPDCPPKJHK> EJLMAHPKPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	private readonly Dictionary<Type, MDPDCPPKJHK> NLELCEMLEJE;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public IReadOnlyCollection<MDPDCPPKJHK> GAHOFMFOHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1610", Offset = "0x5EBFE10", VA = "0x185EC1610", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC12D0", Offset = "0x5EBFAD0", VA = "0x185EC12D0", Slot = "7")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1660", Offset = "0x5EBFE60", VA = "0x185EC1660", Slot = "6")]
	public MDPDCPPKJHK JCKGALCBFIO(Type GFGNPBCFEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC16E0", Offset = "0x5EBFEE0", VA = "0x185EC16E0", Slot = "5")]
	public bool MDHCDLHHNON(int JIBGFHDMIBK, [Out] MDPDCPPKJHK CBHFJDMCLMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1280", Offset = "0x5EBFA80", VA = "0x185EC1280", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1750", Offset = "0x5EBFF50", VA = "0x185EC1750")]
	public POIEOFDNGID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000202")]
[OAEOFLFLIGA(typeof(ODFFABDNAGO))]
[DEONFKEHMJD(typeof(GMEDPFHIIAE), new string[] { })]
public class BJEIEADOKHA : GMEDPFHIIAE, GMMHILFNMPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000638")]
	private readonly Dictionary<int, CJOGNFGAALB> MFNPHMPODCD;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public IEnumerable<CJOGNFGAALB> HKMIGODOIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x5EA53D0", Offset = "0x5EA3BD0", VA = "0x185EA53D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4FE0", Offset = "0x5EA37E0", VA = "0x185EA4FE0", Slot = "6")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4F20", Offset = "0x5EA3720", VA = "0x185EA4F20", Slot = "5")]
	public bool DLOBMCMIGJM(int JIBGFHDMIBK, [Out] CJOGNFGAALB MHIDINMCICE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4F90", Offset = "0x5EA3790", VA = "0x185EA4F90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5420", Offset = "0x5EA3C20", VA = "0x185EA5420")]
	public BJEIEADOKHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000203")]
[OAEOFLFLIGA(typeof(ODFFABDNAGO))]
[DEONFKEHMJD(typeof(OBPJKLHEIGG), new string[] { })]
public class JDNJNBFCPCH : OBPJKLHEIGG, GMMHILFNMPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	private static readonly Dictionary<int, int> ONFODCMNIIE;

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFF70", Offset = "0x5EAE770", VA = "0x185EAFF70", Slot = "5")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0260", Offset = "0x5EAEA60", VA = "0x185EB0260", Slot = "4")]
	public int GOEABFOMLFD(int JIBGFHDMIBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFF00", Offset = "0x5EAE700", VA = "0x185EAFF00", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JDNJNBFCPCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000204")]
[DEONFKEHMJD(typeof(EBMENDDIABB), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal class EBMENDDIABB : FIBMJMMLGPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	private MFPIBOMMGJC<AuthoredParentData, AuthoredPreviousParentData, CELHHNGFGFD, AuthoredChildrenData> DADMPOEDILM;

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8A10", Offset = "0x5EA7210", VA = "0x185EA8A10", Slot = "4")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public EBMENDDIABB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000205")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(ILCKJNFILLB), new string[] { })]
internal sealed class ILCKJNFILLB : GJOKPFDLDCJ, FIBMJMMLGPO
{
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	[NMIHDJKFGCM]
	private LJJGONKGMDG DFJLJGOOCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	private FAOOFKFDMAN<Entity> EJKGILKDBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	private MFPIBOMMGJC<ParentData, PreviousParentData, CCENDLCIJHN, ChildrenData> DADMPOEDILM;

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFAE0", Offset = "0x5EAE2E0", VA = "0x185EAFAE0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF970", Offset = "0x5EAE170", VA = "0x185EAF970", Slot = "5")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFA90", Offset = "0x5EAE290", VA = "0x185EAFA90")]
	public Entity GADDKJOEJFO(Entity KCMPKMKBCOO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFE10", Offset = "0x5EAE610", VA = "0x185EAFE10")]
	public bool PIFIIBOFGBO(Entity KCMPKMKBCOO, Entity KEDAAEKKLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFB30", Offset = "0x5EAE330", VA = "0x185EAFB30")]
	public bool JLJFDADNEME(Entity KCMPKMKBCOO, Entity KEDAAEKKLOL, bool BNNILCCPPIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFBD0", Offset = "0x5EAE3D0", VA = "0x185EAFBD0")]
	private bool KLPANHKCJEP(Entity KCMPKMKBCOO, Entity KEDAAEKKLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public ILCKJNFILLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000206")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(HBAFNDJCPFO), new string[] { })]
internal sealed class HBAFNDJCPFO : GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063F")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000640")]
	private EntityQuery DHAIPKMBGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x5EAD440", Offset = "0x5EABC40", VA = "0x185EAD440")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD570", Offset = "0x5EABD70", VA = "0x185EAD570", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD490", Offset = "0x5EABC90", VA = "0x185EAD490", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD670", Offset = "0x5EABE70", VA = "0x185EAD670")]
	public bool JDBAHLMABOE(Entity KCMPKMKBCOO, Entity KNHMPHIEBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD390", Offset = "0x5EABB90", VA = "0x185EAD390")]
	public bool BGGKKFIEAIB(Entity KCMPKMKBCOO, Entity BIANJFLNPLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD720", Offset = "0x5EABF20", VA = "0x185EAD720")]
	public Entity KHJHAPEDKKI(Entity KCMPKMKBCOO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7B")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD340", Offset = "0x5EABB40", VA = "0x185EAD340")]
	public NativeArray<Entity> AKNMPALEJNB()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7C")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD4B0", Offset = "0x5EABCB0", VA = "0x185EAD4B0")]
	public bool GFDLEAEGIJN(Entity KMJKCJJHEFM, Entity OPJAPJDAKJE, [Out] Entity BNKDAHKOHOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public HBAFNDJCPFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000207")]
public static class BILEGJNCPDM
{
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	internal static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x2186410", Offset = "0x2184C10", VA = "0x182186410")]
	public static void FCMGAGDDFDK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(HMNFMHNMJBH CJEADCONOPM, GCEJGJJCPNB<Entity> IACPFKBCIBD, [Out] MFPIBOMMGJC<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> CPFGJIIMOIH) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, AMBALLNBDNE where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, AMBALLNBDNE, IEquatable<TChildrenData>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4E60", Offset = "0x5EA3660", VA = "0x185EA4E60")]
	public static bool AEIOGLCGBMK(NNONLMNKHJH CLOKEPECCEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000208")]
public class MFPIBOMMGJC<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, AMBALLNBDNE where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, AMBALLNBDNE, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private readonly CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	private readonly FAOOFKFDMAN<Entity> EJKGILKDBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000646")]
	private readonly FBAOJJNEOIC OAGHKEHKLHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000647")]
	private readonly PKPLGAMLPEK OBIIIBPBMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000648")]
	private readonly EntityManager IDCNBIGHJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000649")]
	private readonly AGPODNPCKBE IKEMBHLKPGK;

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x3AF36A0", Offset = "0x3AF1EA0", VA = "0x183AF36A0")]
	public MFPIBOMMGJC(HMNFMHNMJBH CJEADCONOPM, GCEJGJJCPNB<Entity> IACPFKBCIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1BA0", Offset = "0x3AF03A0", VA = "0x183AF1BA0")]
	private bool DDCBPAFDCHI(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A83")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2FC0", Offset = "0x3AF17C0", VA = "0x183AF2FC0")]
	private bool PBCODKGCFLO(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2F40", Offset = "0x3AF1740", VA = "0x183AF2F40")]
	private bool MFFKAHNFJNC(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A85")]
	[Cpp2IlInjected.Address(RVA = "0x3AF30C0", Offset = "0x3AF18C0", VA = "0x183AF30C0")]
	public bool PIFIIBOFGBO(Entity KCMPKMKBCOO, [In] Entity KEDAAEKKLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2680", Offset = "0x3AF0E80", VA = "0x183AF2680")]
	public bool IPLMHEPIIIG(Entity KCMPKMKBCOO, [In] Entity KEDAAEKKLOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1FA0", Offset = "0x3AF07A0", VA = "0x183AF1FA0")]
	private bool IPLMHEPIIIG(Entity KCMPKMKBCOO, [In] Entity KEDAAEKKLOL, bool EIAJNMNOIAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void OKKEAACDKBJ(Entity KCMPKMKBCOO, [In] Entity KEDAAEKKLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void ONHNHDHJGJM(Entity KCMPKMKBCOO, [In] Entity KEDAAEKKLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void LHJOLLGGMLI(Entity KCMPKMKBCOO, [In] Entity KEDAAEKKLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void JNIEKAAGGIB(Entity KCMPKMKBCOO, [In] Entity KEDAAEKKLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void FNPCELBOIHK(Entity KCMPKMKBCOO, [In] Entity KEDAAEKKLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2900", Offset = "0x3AF1100", VA = "0x183AF2900")]
	private bool JDBAHLMABOE(Entity KCMPKMKBCOO, Entity KNHMPHIEBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x3AF26C0", Offset = "0x3AF0EC0", VA = "0x183AF26C0")]
	private void JCEEOEHFFGC(Entity KCMPKMKBCOO, [In] Entity LGPCNJNBLBP, [In] Entity KEDAAEKKLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x3AF3320", Offset = "0x3AF1B20", VA = "0x183AF3320")]
	private void PJEIAHELBNN(Entity KCMPKMKBCOO, [In] Entity LGPCNJNBLBP, [In] Entity KEDAAEKKLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A90")]
	[Cpp2IlInjected.Address(RVA = "0x3AF2AE0", Offset = "0x3AF12E0", VA = "0x183AF2AE0")]
	private bool JLMLOBPFGAA(CHOGKACALOP NMBBDMICEDE, [In] AFCHODDKGEA PKACKNKLIOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1CA0", Offset = "0x3AF04A0", VA = "0x183AF1CA0")]
	private void IIMOIKPKMHN(Entity OBIIIBPBMLD, Entity EFKEIDIJBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x3AF19E0", Offset = "0x3AF01E0", VA = "0x183AF19E0")]
	private void CCIOJOCPJBE(Entity OBIIIBPBMLD, Entity EFKEIDIJBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private void JBKIMHLDDFJ(Entity KCMPKMKBCOO, Entity LGPCNJNBLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private void MDAOBEHHICJ(Entity KCMPKMKBCOO, Entity KEDAAEKKLOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000209")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(NHCACALFIKB), new string[] { })]
internal sealed class NHCACALFIKB : LKDNHKMMDCB, GMMHILFNMPG, GJOKPFDLDCJ, FIBMJMMLGPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400064A")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	[NMIHDJKFGCM]
	private LJJGONKGMDG DFJLJGOOCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	[NMIHDJKFGCM]
	private JKEGAAHHGLK AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	[NMIHDJKFGCM]
	private NAHFHNGCNNC IKCAIPFFHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	[NMIHDJKFGCM]
	private CCAKIPGLEFJ DMGDLLJPJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	[NMIHDJKFGCM]
	private BCPMIOAIJEL HMAMOADGBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	[NMIHDJKFGCM]
	private NODGOFCBOKD DDFGJFHNCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private readonly Dictionary<AFCHODDKGEA, JNHCKHFIJLH> PKKJCJAPBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private JLFIMFFKJBB ALGAKBJEMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A96")]
		[Cpp2IlInjected.Address(RVA = "0x5EB7C10", Offset = "0x5EB6410", VA = "0x185EB7C10")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A97")]
	[Cpp2IlInjected.Address(RVA = "0xB187F0", Offset = "0xB16FF0", VA = "0x180B187F0", Slot = "4")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9070", Offset = "0x5EB7870", VA = "0x185EB9070", Slot = "5")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8880", Offset = "0x5EB7080", VA = "0x185EB8880")]
	public void DPBOBDHDCBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7980", Offset = "0x5EB6180", VA = "0x185EB7980", Slot = "6")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9B")]
	[Cpp2IlInjected.Address(RVA = "0x5EB88D0", Offset = "0x5EB70D0", VA = "0x185EB88D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA680", Offset = "0x5EB8E80", VA = "0x185EBA680")]
	public int NMNDDAIIDBK(SceneTag AGEHAEDLOFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB8E0", Offset = "0x5EBA0E0", VA = "0x185EBB8E0")]
	public bool PEFOCCIAIDE(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB96F0", Offset = "0x5EB7EF0", VA = "0x185EB96F0")]
	public bool KLCLHJJFDOB(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8730", Offset = "0x5EB6F30", VA = "0x185EB8730")]
	public bool CPKMHGLBLBP(Entity KCMPKMKBCOO, [Out] JNHCKHFIJLH IBKDOLMCEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8690", Offset = "0x5EB6E90", VA = "0x185EB8690")]
	private bool CPKMHGLBLBP(Transform CPMBJLDHCID, [Out] JNHCKHFIJLH IBKDOLMCEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA1")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9660", Offset = "0x5EB7E60", VA = "0x185EB9660")]
	private void JHNEAEGGLIK(Entity KCMPKMKBCOO, JNHCKHFIJLH IBKDOLMCEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9050", Offset = "0x5EB7850", VA = "0x185EB9050")]
	private bool IKIEKLDLIIC(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA4E0", Offset = "0x5EB8CE0", VA = "0x185EBA4E0")]
	public void NJMEIPIEAKJ(AFCHODDKGEA NFLGLAGMLAA, JNHCKHFIJLH JJEHEFGHFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA400", Offset = "0x5EB8C00", VA = "0x185EBA400")]
	public void NJMEIPIEAKJ(INJNNPDEJLM JFIBILKOJPE, JNHCKHFIJLH JJEHEFGHFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA9C0", Offset = "0x5EB91C0", VA = "0x185EBA9C0")]
	public bool OGEFNJKHKBB(INJNNPDEJLM JFIBILKOJPE, object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA900", Offset = "0x5EB9100", VA = "0x185EBA900")]
	public bool OGEFNJKHKBB(Entity KCMPKMKBCOO, [Optional] object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA990", Offset = "0x5EB9190", VA = "0x185EBA990")]
	public bool OGEFNJKHKBB(JNHCKHFIJLH CLOKEPECCEF, object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9790", Offset = "0x5EB7F90", VA = "0x185EB9790")]
	public bool LDCDEDNFNOI(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA960", Offset = "0x5EB9160", VA = "0x185EBA960")]
	public bool OGEFNJKHKBB(JNHCKHFIJLH IBKDOLMCEFO, bool AKFFELDLHDA, [Optional] object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8A10", Offset = "0x5EB7210", VA = "0x185EB8A10")]
	private bool GHJFAFHNDJM(JNHCKHFIJLH IBKDOLMCEFO, object KIAKEGJPMAL, bool AKFFELDLHDA, bool ALBNMHDELJP, bool KCGCGPFFNHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAFA0", Offset = "0x5EB97A0", VA = "0x185EBAFA0")]
	public Transform OOADJJNOEAI(Entity KCMPKMKBCOO, [Optional] object KIAKEGJPMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAC")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7B40", Offset = "0x5EB6340", VA = "0x185EB7B40")]
	public bool CHKJBCJNDCM(Entity KCMPKMKBCOO, [Out] Transform CPMBJLDHCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBB80", Offset = "0x5EBA380", VA = "0x185EBBB80")]
	public JNHCKHFIJLH PNHALGKEDCE(Entity KCMPKMKBCOO, [Optional] object KIAKEGJPMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9EE0", Offset = "0x5EB86E0", VA = "0x185EB9EE0")]
	public void MKNAAKMPAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9280", Offset = "0x5EB7A80", VA = "0x185EB9280")]
	public void JHGONDIHBID(SceneTag AGEHAEDLOFL, bool ALBNMHDELJP, NativeParallelHashSet<int> IDKIFNAAEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7C60", Offset = "0x5EB6460", VA = "0x185EB7C60")]
	private void CJEJBJLDAHL(Entity KCMPKMKBCOO, bool ALBNMHDELJP, bool KCGCGPFFNHJ, NativeParallelHashSet<int> IDKIFNAAEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7A60", Offset = "0x5EB6260", VA = "0x185EB7A60")]
	private bool AMDAEMPIIPG(JNHCKHFIJLH IBKDOLMCEFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8990", Offset = "0x5EB7190", VA = "0x185EB8990")]
	public bool EHIOPBFDOLH(Entity KCMPKMKBCOO, object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9710", Offset = "0x5EB7F10", VA = "0x185EB9710")]
	public bool KPJHIEIKBJM(Entity KCMPKMKBCOO, object KIAKEGJPMAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x5EB91A0", Offset = "0x5EB79A0", VA = "0x185EB91A0")]
	public bool JAEOJHNFDMA(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8F70", Offset = "0x5EB7770", VA = "0x185EB8F70")]
	private void IJENBAPGMNJ(bool IHFOFCEKFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9E20", Offset = "0x5EB8620", VA = "0x185EB9E20")]
	private bool MCLLNIIAKCI(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7AF0", Offset = "0x5EB62F0", VA = "0x185EB7AF0")]
	public JNHCKHFIJLH BIBNGMAIDDH(Entity KCMPKMKBCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA360", Offset = "0x5EB8B60", VA = "0x185EBA360")]
	private JNHCKHFIJLH NHFLGPDAMBD(Entity KCMPKMKBCOO, object KIAKEGJPMAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA6A0", Offset = "0x5EB8EA0", VA = "0x185EBA6A0")]
	private JNHCKHFIJLH OBOEOLFKIHM(Entity KCMPKMKBCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA210", Offset = "0x5EB8A10", VA = "0x185EBA210")]
	public void MOCIILOCIGI(NativeArray<AFCHODDKGEA> LILIIJHBMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9D50", Offset = "0x5EB8550", VA = "0x185EB9D50")]
	private void LNLGJJLMEIJ(JNHCKHFIJLH JJEHEFGHFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB5F0", Offset = "0x5EB9DF0", VA = "0x185EBB5F0")]
	private void PDDIDJHOELG(JNHCKHFIJLH IBKDOLMCEFO, Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB190", Offset = "0x5EB9990", VA = "0x185EBB190")]
	private void PABJALLAILB(Entity KCMPKMKBCOO, JNHCKHFIJLH IBKDOLMCEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB87A0", Offset = "0x5EB6FA0", VA = "0x185EB87A0")]
	private void DICLKBJGAAI(Entity KCMPKMKBCOO, Transform CPMBJLDHCID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E080", Offset = "0x5E1C880", VA = "0x185E1E080")]
	private INJNNPDEJLM BOGKJEFOBCK(Entity KCMPKMKBCOO)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBD00", Offset = "0x5EBA500", VA = "0x185EBBD00")]
	public NHCACALFIKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBAB0", Offset = "0x5EBA2B0", VA = "0x185EBBAB0")]
	[CompilerGenerated]
	private void PJACIHLPHNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020A")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(JEIJFNDLCFE), new string[] { })]
internal sealed class JEIJFNDLCFE : GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000658")]
	private NHCACALFIKB IBKDOLMCEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000659")]
	private BPMIJDOIEMI MDGMNBMFFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400065A")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC7")]
		[Cpp2IlInjected.Address(RVA = "0x5EB05E0", Offset = "0x5EAEDE0", VA = "0x185EB05E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<AJLMOHPDADI, NativeArray<ILMCDCGEOPC>> POCBNGMDCDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x5EB1060", Offset = "0x5EAF860", VA = "0x185EB1060")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000AC4")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0B40", Offset = "0x5EAF340", VA = "0x185EB0B40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<AJLMOHPDADI> LLJAPKCIHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0BF0", Offset = "0x5EAF3F0", VA = "0x185EB0BF0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x5EB0F70", Offset = "0x5EAF770", VA = "0x185EB0F70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0ED0", Offset = "0x5EAF6D0", VA = "0x185EB0ED0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x1994470", Offset = "0x1992C70", VA = "0x181994470", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1180", Offset = "0x5EAF980", VA = "0x185EB1180")]
	public void NDDAMNIGMMB(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0540", Offset = "0x5EAED40", VA = "0x185EB0540")]
	public void APGCHJJJNAB(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x5EB03F0", Offset = "0x5EAEBF0", VA = "0x185EB03F0")]
	private bool AOPDGGHHBPH(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1110", Offset = "0x5EAF910", VA = "0x185EB1110")]
	public void NAKDAJJPGKJ(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0900", Offset = "0x5EAF100", VA = "0x185EB0900")]
	private bool EFGODNDEKEG(Entity KCMPKMKBCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x5EB13D0", Offset = "0x5EAFBD0", VA = "0x185EB13D0")]
	public void NLHDBDGIHOC(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0AE0", Offset = "0x5EAF2E0", VA = "0x185EB0AE0")]
	private void FJLCBFCNIPN(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0CA0", Offset = "0x5EAF4A0", VA = "0x185EB0CA0")]
	private void IHJLKGDMBDL(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0390", Offset = "0x5EAEB90", VA = "0x185EB0390")]
	private void AOBDADLCFPK(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0630", Offset = "0x5EAEE30", VA = "0x185EB0630")]
	private void COCNAEDFDAC(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0590", Offset = "0x5EAED90", VA = "0x185EB0590")]
	public void CHCIMCFPLLI(AJLMOHPDADI HMNPDHIGFFO, NativeArray<ILMCDCGEOPC> AMHNNCEJBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1020", Offset = "0x5EAF820", VA = "0x185EB1020")]
	public void MFGAGNIPHNG(AJLMOHPDADI HMNPDHIGFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD6")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private void OHGIKNLAGAI(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x5EB11C0", Offset = "0x5EAF9C0", VA = "0x185EB11C0")]
	private void NKODBOCMDAF(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public JEIJFNDLCFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020B")]
[DEONFKEHMJD(typeof(EKLAJGGMJNP), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal class EKLAJGGMJNP : FGDJJOLJALF, GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200020D")]
	[CompilerGenerated]
	private sealed class KNNIFKDBDEF : IEnumerable<(IHOKJCEFOEN, ILMCDCGEOPC)>, IEnumerable, IEnumerator<(IHOKJCEFOEN, ILMCDCGEOPC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private (IHOKJCEFOEN primitiveType, ILMCDCGEOPC prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public EKLAJGGMJNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		private (IHOKJCEFOEN, ILMCDCGEOPC) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF7")]
			[Cpp2IlInjected.Address(RVA = "0x31038C0", Offset = "0x31020C0", VA = "0x1831038C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((IHOKJCEFOEN, ILMCDCGEOPC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF9")]
			[Cpp2IlInjected.Address(RVA = "0x5EB26C0", Offset = "0x5EB0EC0", VA = "0x185EB26C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x3224EC0", Offset = "0x32236C0", VA = "0x183224EC0")]
		[DebuggerHidden]
		public KNNIFKDBDEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF5")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF6")]
		[Cpp2IlInjected.Address(RVA = "0x5EB24C0", Offset = "0x5EB0CC0", VA = "0x185EB24C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x5EB2670", Offset = "0x5EB0E70", VA = "0x185EB2670", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFA")]
		[Cpp2IlInjected.Address(RVA = "0x5EB25C0", Offset = "0x5EB0DC0", VA = "0x185EB25C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(IHOKJCEFOEN, ILMCDCGEOPC)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFB")]
		[Cpp2IlInjected.Address(RVA = "0x5EB25C0", Offset = "0x5EB0DC0", VA = "0x185EB25C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400065D")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private World NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private NativeParallelHashMap<int, Entity> CLEKEDNIBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private NativeParallelHashMap<int, EntityArchetype> DBHKDLICHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	private NativeParallelHashMap<int, int> EAMMMIBDLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private ILMCDCGEOPC[] AMHNNCEJBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private readonly Dictionary<IHOKJCEFOEN, ILMCDCGEOPC> LDBAKHINHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private readonly Dictionary<EIHFFOLKDOE, ILMCDCGEOPC> FPBHEKLJDHG;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADA")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9970", Offset = "0x5EA8170", VA = "0x185EA9970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x761C30", Offset = "0x760430", VA = "0x180761C30")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x1857630", Offset = "0x1855E30", VA = "0x181857630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9CB0", Offset = "0x5EA84B0", VA = "0x185EA9CB0", Slot = "5")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x5EA95C0", Offset = "0x5EA7DC0", VA = "0x185EA95C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD474A0", VA = "0x180D48CA0")]
	internal NativeParallelHashMap<int, Entity> NLEJBPDDIPL()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5DC60", VA = "0x180D5F460")]
	internal NativeParallelHashMap<int, EntityArchetype> NKAABCGAAMM()
	{
		return default(NativeParallelHashMap<int, EntityArchetype>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x8A8A60", Offset = "0x8A7260", VA = "0x1808A8A60")]
	internal NativeParallelHashMap<int, int> AKJFNHHKGDG()
	{
		return default(NativeParallelHashMap<int, int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9560", Offset = "0x5EA7D60", VA = "0x185EA9560")]
	internal IEnumerable<Type> DMJGPBPBBKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x5EA99B0", Offset = "0x5EA81B0", VA = "0x185EA99B0")]
	internal PCAPNCEMGNC HMLIDKNDKOB(Type GFGNPBCFEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAE80", Offset = "0x5EA9680", VA = "0x185EAAE80")]
	public EntityArchetype PJGCMJDPIJC(ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x5EA94E0", Offset = "0x5EA7CE0", VA = "0x185EA94E0", Slot = "4")]
	[IteratorStateMachine(typeof(KNNIFKDBDEF))]
	public IEnumerable<(IHOKJCEFOEN, ILMCDCGEOPC)> DKPHGGOAJNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA840", Offset = "0x5EA9040", VA = "0x185EAA840")]
	public Entity KGFLJBHMKJF(ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9B00", Offset = "0x5EA8300", VA = "0x185EA9B00")]
	public void IOPGCBDOCIC(NativeArray<ILMCDCGEOPC> AMHNNCEJBHK, NativeArray<Entity> EMPFGDEGKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAAF0", Offset = "0x5EA92F0", VA = "0x185EAAAF0")]
	public void MMPLCKLKAFC(ILMCDCGEOPC CCAOKKILBOM, NativeArray<Entity> FAIFKAKJOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9170", Offset = "0x5EA7970", VA = "0x185EA9170")]
	public ILMCDCGEOPC BEFHDKOJCLP(IHOKJCEFOEN GFGNPBCFEMC)
	{
		return default(ILMCDCGEOPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9A20", Offset = "0x5EA8220", VA = "0x185EA9A20")]
	public Entity IBDPPFKBCKB(ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAB80", Offset = "0x5EA9380", VA = "0x185EAAB80")]
	private void OCKNLJLJPGG(PCAPNCEMGNC BNIPOOOGHFB, NativeList<int> AMHNNCEJBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x5EA91D0", Offset = "0x5EA79D0", VA = "0x185EA91D0")]
	internal void BNGBGKFDKCG(ILMCDCGEOPC CCAOKKILBOM, ComponentTypeList NPLIHIJEIBH, JMNKOMAOELA DHAHIFIJLOJ, PCAPNCEMGNC BNIPOOOGHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA960", Offset = "0x5EA9160", VA = "0x185EAA960")]
	private EntityArchetype LNMCLEKIBNN(ILMCDCGEOPC CCAOKKILBOM, ComponentTypeList DKEGFJKDJBN)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAF80", Offset = "0x5EA9780", VA = "0x185EAAF80")]
	public EKLAJGGMJNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020E")]
public enum DBGBAOPKBDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200020F")]
internal interface PLKCAIEAFCD
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	World PANADLMAEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	World BAPJGFNLPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	PCINNFAAPHH HOPFAPJKHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	uint PAMKBMMMMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	bool AMDAEMPIIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B01")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000210")]
internal class DOJIDIFCGKO : MMAPEGDHBAO, LKEAAHCANFE
{
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private readonly PLKCAIEAFCD AIOIJNHOCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private readonly DBGBAOPKBDJ CLBAKDLDGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	private readonly World JJDPLCCFOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private readonly List<NMKNLLNOEON> JEOCBCFPDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000679")]
	private NativeParallelMultiHashMap<Entity, HDMJOKNPAGJ> MFFMJIGGDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private NativeParallelHashMap<int, int> EOBFAICKGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400067B")]
	private NativeArray<AFCHODDKGEA> BFBKFPJFMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400067C")]
	private NativeArray<GEPBLNPDOFJ> EIGLBIKONIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	private NativeArray<AFCHODDKGEA> GCPBAFELODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private JobHandle FJKMKNKLBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	private JobHandle IHIMACFFODD;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private NativeParallelMultiHashMap<Entity, HDMJOKNPAGJ> OHJNMOCEGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5DC60", VA = "0x180D5F460", Slot = "4")]
		get
		{
			return default(NativeParallelMultiHashMap<Entity, HDMJOKNPAGJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private uint MJBIEIDDHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8840", Offset = "0x5EA7040", VA = "0x185EA8840", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private bool ABPOMEMJDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B08")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8230", Offset = "0x5EA6A30", VA = "0x185EA8230", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private NativeArray<AFCHODDKGEA> HKEDKIMLIII
	{
		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x19E84B0", Offset = "0x19E6CB0", VA = "0x1819E84B0", Slot = "10")]
		get
		{
			return default(NativeArray<AFCHODDKGEA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private NativeArray<GEPBLNPDOFJ> GCOCAACMAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0xEB77E0", Offset = "0xEB5FE0", VA = "0x180EB77E0", Slot = "11")]
		get
		{
			return default(NativeArray<GEPBLNPDOFJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	private NativeArray<AFCHODDKGEA> IPIJBDOBMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x4A99FA0", Offset = "0x4A987A0", VA = "0x184A99FA0", Slot = "12")]
		get
		{
			return default(NativeArray<AFCHODDKGEA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B02")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8920", Offset = "0x5EA7120", VA = "0x185EA8920")]
	public DOJIDIFCGKO(PLKCAIEAFCD AIOIJNHOCFP, DBGBAOPKBDJ CLBAKDLDGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8040", Offset = "0x5EA6840", VA = "0x185EA8040", Slot = "6")]
	private bool DHEKKMBAHPD(NativeArray<AFCHODDKGEA> BFBKFPJFMOH, NativeArray<GEPBLNPDOFJ> EIGLBIKONIC, NativeArray<AFCHODDKGEA> GCPBAFELODG, int FPDOMJLBGKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x5EA84D0", Offset = "0x5EA6CD0", VA = "0x185EA84D0", Slot = "7")]
	private void KKNEPAHKHAD([In] NMKNLLNOEON IFDNFIGNFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x5EA86C0", Offset = "0x5EA6EC0", VA = "0x185EA86C0", Slot = "8")]
	private void MPMEFANIFCO(JobHandle KPAMIOKBGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8420", Offset = "0x5EA6C20", VA = "0x185EA8420", Slot = "13")]
	private bool FNEFOILPDBF([Out] NativeArray<int> GCADMFLPGGA, Allocator JONICLHJBEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8240", Offset = "0x5EA6A40", VA = "0x185EA8240", Slot = "14")]
	private bool FKABDHLOPCK(ComponentType IPLGGDBFLNE, [Out] NMKNLLNOEON MNBBCMBHBBH, [Out] HMIKALELNFC EBKCCOGJBDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8640", Offset = "0x5EA6E40", VA = "0x185EA8640", Slot = "15")]
	private NativeMultiHashMapAsync<Entity, HDMJOKNPAGJ> LBMEOMFDMKH()
	{
		return default(NativeMultiHashMapAsync<Entity, HDMJOKNPAGJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7CF0", Offset = "0x5EA64F0", VA = "0x185EA7CF0")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7AC0", Offset = "0x5EA62C0", VA = "0x185EA7AC0")]
	private bool AJMNEECMPML()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000211")]
[DEONFKEHMJD(typeof(LKNNFAHLOJG), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal class LKNNFAHLOJG : GJOKPFDLDCJ, FIBMJMMLGPO, PLKCAIEAFCD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000212")]
	internal readonly struct BGMDPGAKILP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private readonly DBGBAOPKBDJ KCEPMFMMMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private readonly LKNNFAHLOJG HOKHBOHACNK;

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4E10", Offset = "0x5EA3610", VA = "0x185EA4E10")]
		public BGMDPGAKILP(LKNNFAHLOJG HOKHBOHACNK, DBGBAOPKBDJ OEANDBCOIPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4DF0", Offset = "0x5EA35F0", VA = "0x185EA4DF0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private static readonly DGJIKJLGCCH JKHJLNEGFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	[NMIHDJKFGCM]
	private CBDHEEDCCOH EFGNGNHGGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	[NMIHDJKFGCM]
	private EKLAJGGMJNP MFACMNCIMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private readonly DOJIDIFCGKO[] NCGPNGOHGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private PCINNFAAPHH KOPHBFKIOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private NativeParallelHashMap<int, Entity> LDBGEIIMCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private DBGBAOPKBDJ NDAHEOAIMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public World PANADLMAEKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x5EB30B0", Offset = "0x5EB18B0", VA = "0x185EB30B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public World BAPJGFNLPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x768D30", Offset = "0x767530", VA = "0x180768D30", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x768C90", Offset = "0x767490", VA = "0x180768C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public PCINNFAAPHH HOPFAPJKHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x1FE9610", Offset = "0x1FE7E10", VA = "0x181FE9610", Slot = "8")]
		get
		{
			return default(PCINNFAAPHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public uint PAMKBMMMMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0xCE9970", Offset = "0xCE8170", VA = "0x180CE9970", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0xCE9A90", Offset = "0xCE8290", VA = "0x180CE9A90", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool ANFMAINELMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x9AA140", Offset = "0x9A8940", VA = "0x1809AA140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool AMDAEMPIIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0xCD3490", Offset = "0xCD1C90", VA = "0x180CD3490", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public NativeParallelHashMap<int, Entity> OCKAHINJOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x3CD0AB0", Offset = "0x3CCF2B0", VA = "0x183CD0AB0")]
		get
		{
			return default(NativeParallelHashMap<int, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public LKEAAHCANFE BPNPPHNAKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3100", Offset = "0x5EB1900", VA = "0x185EB3100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public MMAPEGDHBAO FGCMFHKGJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3100", Offset = "0x5EB1900", VA = "0x185EB3100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public DBGBAOPKBDJ HAJBDMGODFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x955E40", Offset = "0x954640", VA = "0x180955E40")]
		get
		{
			return default(DBGBAOPKBDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1B")]
	[Cpp2IlInjected.Address(RVA = "0x1B5BA10", Offset = "0x1B5A210", VA = "0x181B5BA10")]
	public LKEAAHCANFE FPAEKPABCEN(DBGBAOPKBDJ CLBAKDLDGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1C")]
	[Cpp2IlInjected.Address(RVA = "0x1B5BA10", Offset = "0x1B5A210", VA = "0x181B5BA10")]
	public MMAPEGDHBAO DFEPMOCECDM(DBGBAOPKBDJ CLBAKDLDGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B20")]
	[Cpp2IlInjected.Address(RVA = "0x5EB33B0", Offset = "0x5EB1BB0", VA = "0x185EB33B0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B21")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2BA0", Offset = "0x5EB13A0", VA = "0x185EB2BA0", Slot = "5")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B22")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3130", Offset = "0x5EB1930", VA = "0x185EB3130")]
	private NativeParallelHashMap<int, Entity> GPAMAJKOBBG()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B23")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2EF0", Offset = "0x5EB16F0", VA = "0x185EB2EF0")]
	public void DDMDMJPGAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B24")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2EB0", Offset = "0x5EB16B0", VA = "0x185EB2EB0")]
	public void BEIKHFOBAHI(DBGBAOPKBDJ CLBAKDLDGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B25")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2DF0", Offset = "0x5EB15F0", VA = "0x185EB2DF0")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B26")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2F40", Offset = "0x5EB1740", VA = "0x185EB2F40", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B27")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3050", Offset = "0x5EB1850", VA = "0x185EB3050")]
	public BGMDPGAKILP EJOKDBNLNCP(DBGBAOPKBDJ CLBAKDLDGPM)
	{
		return default(BGMDPGAKILP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B28")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3540", Offset = "0x5EB1D40", VA = "0x185EB3540")]
	public LKNNFAHLOJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000213")]
[DEONFKEHMJD(typeof(NGKJMLHKKJA), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal class NGKJMLHKKJA : GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x4000690")]
	public static readonly SceneTag MHJDFHPOLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	[NMIHDJKFGCM]
	private PCPJLBDGAPJ CJGLLKCJNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	[NMIHDJKFGCM]
	private NHCACALFIKB IBKDOLMCEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	[NMIHDJKFGCM]
	private FBAOJJNEOIC CJGPOMHFPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	[NMIHDJKFGCM]
	private PPEDACELMBL PGFIAEMHAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	[NMIHDJKFGCM]
	private FAONCNBNGHJ IGDGBBDPAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private EntityQuery PKIEJBFBCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private EntityQuery MLHDKDANNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private EntityQuery KMCOLHEMOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private Entity PLECLGJKDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public NativeArray<Entity> NJDINEOMOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0xBD2130", Offset = "0xBD0930", VA = "0x180BD2130")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0xBCFE00", Offset = "0xBCE600", VA = "0x180BCFE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public Entity MJKNEPMBPKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x5EB62D0", Offset = "0x5EB4AD0", VA = "0x185EB62D0")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public SceneTag EKKFFHBGNEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x5EB70B0", Offset = "0x5EB58B0", VA = "0x185EB70B0")]
		get
		{
			return default(SceneTag);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Entity CIOANBFAMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x5EB70B0", Offset = "0x5EB58B0", VA = "0x185EB70B0")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6220", Offset = "0x5EB4A20", VA = "0x185EB6220")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x5EB6500", Offset = "0x5EB4D00", VA = "0x185EB6500")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B33")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6FB0", Offset = "0x5EB57B0", VA = "0x185EB6FB0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B34")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6620", Offset = "0x5EB4E20", VA = "0x185EB6620", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B35")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7850", Offset = "0x5EB6050", VA = "0x185EB7850")]
	public void PGBDALLDMMH(Entity KCMPKMKBCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B36")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7100", Offset = "0x5EB5900", VA = "0x185EB7100")]
	public NativeArray<Entity> KKFCGLHHIOI(Allocator JONICLHJBEP = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7890", Offset = "0x5EB6090", VA = "0x185EB7890")]
	public void PLEMJEAPOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B38")]
	[Cpp2IlInjected.Address(RVA = "0x5EB63E0", Offset = "0x5EB4BE0", VA = "0x185EB63E0")]
	public void CFJGECCIOCC(Entity AGEHAEDLOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B39")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6550", Offset = "0x5EB4D50", VA = "0x185EB6550")]
	public Entity CPEBELIANJF(string HNHMJGCODBA = "")
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6200", Offset = "0x5EB4A00", VA = "0x185EB6200")]
	public void AGAFHEKCKGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3B")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6600", Offset = "0x5EB4E00", VA = "0x185EB6600")]
	public void DBIIBFEAFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3C")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	public void JPKCIJAHLFG(Entity AGEHAEDLOFL, string HNHMJGCODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6E60", Offset = "0x5EB5660", VA = "0x185EB6E60")]
	public void IDKJJJAPGHH(Entity AGEHAEDLOFL, bool EEGMHDGGMOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6A70", Offset = "0x5EB5270", VA = "0x185EB6A70")]
	public void HHIODGBGJEO(Entity KCMPKMKBCOO, Entity AGEHAEDLOFL, bool CNFMLGNPEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3F")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6840", Offset = "0x5EB5040", VA = "0x185EB6840")]
	public void HHIODGBGJEO(NativeArray<Entity> FAIFKAKJOPP, Entity AGEHAEDLOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B40")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6CA0", Offset = "0x5EB54A0", VA = "0x185EB6CA0")]
	private void ICDKOHOPAEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B41")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7820", Offset = "0x5EB6020", VA = "0x185EB7820")]
	private void PDJOANDNIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B42")]
	[Cpp2IlInjected.Address(RVA = "0x5EB62D0", Offset = "0x5EB4AD0", VA = "0x185EB62D0")]
	private Entity OPNBPLHPFAL()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B43")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7400", Offset = "0x5EB5C00", VA = "0x185EB7400")]
	private void LAMFHKGMENE(EntityQuery BJPAFOGOCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B44")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7130", Offset = "0x5EB5930", VA = "0x185EB7130")]
	private void LAMFHKGMENE(NativeArray<Entity> MJIDHJMLMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B45")]
	[Cpp2IlInjected.Address(RVA = "0x5EB74E0", Offset = "0x5EB5CE0", VA = "0x185EB74E0")]
	private void MMMFKLDOBAH(Entity AGEHAEDLOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B46")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7750", Offset = "0x5EB5F50", VA = "0x185EB7750")]
	private void OGPHNKEABMP(Entity AGEHAEDLOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B47")]
	[Cpp2IlInjected.Address(RVA = "0x5EB75D0", Offset = "0x5EB5DD0", VA = "0x185EB75D0")]
	private void OAEANNEAHNC(SceneTag AEFBGKHFHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B48")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6290", Offset = "0x5EB4A90", VA = "0x185EB6290")]
	private void BFCCMNMJGBJ(SceneTag AEFBGKHFHIB, NativeParallelHashSet<int> IDKIFNAAEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B49")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6660", Offset = "0x5EB4E60", VA = "0x185EB6660")]
	private void FLBLLBMLOLH(SceneTag AEFBGKHFHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB67A0", Offset = "0x5EB4FA0", VA = "0x185EB67A0")]
	private void FLCBJJFMPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4B")]
	[Cpp2IlInjected.Address(RVA = "0x24B3260", Offset = "0x24B1A60", VA = "0x1824B3260")]
	private void AFDADHJKGFG<T>() where T : ComponentSystemBase
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4C")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NGKJMLHKKJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000214")]
[DEONFKEHMJD(typeof(DHMIJGJOMFI), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.PhotonRoom)]
internal class IEADBNJDMPB : GJOKPFDLDCJ, DHMIJGJOMFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	[NMIHDJKFGCM]
	private NGKJMLHKKJA MJIDHJMLMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private readonly Dictionary<int, Entity> EABLKBEDMNA;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B4E")]
		[Cpp2IlInjected.Address(RVA = "0x5EAEDF0", Offset = "0x5EAD5F0", VA = "0x185EAEDF0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4F")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEEB0", Offset = "0x5EAD6B0", VA = "0x185EAEEB0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF110", Offset = "0x5EAD910", VA = "0x185EAF110", Slot = "5")]
	public void PGBDALLDMMH(INJNNPDEJLM JFIBILKOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B51")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEF40", Offset = "0x5EAD740", VA = "0x185EAEF40", Slot = "6")]
	public bool MGHBJPKHIDP(INJNNPDEJLM JFIBILKOJPE, Transform CPMBJLDHCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B52")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEE40", Offset = "0x5EAD640", VA = "0x185EAEE40")]
	private bool FHJADBKAJNP(Scene AGEHAEDLOFL, [Out] Entity BNHPEDMBOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B53")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF260", Offset = "0x5EADA60", VA = "0x185EAF260")]
	public IEADBNJDMPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000215")]
[DEONFKEHMJD(typeof(PPEDACELMBL), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal sealed class PPEDACELMBL : GJOKPFDLDCJ, FIBMJMMLGPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	[NMIHDJKFGCM]
	private FBAOJJNEOIC CJGPOMHFPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private Entity KCMPKMKBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private ComponentTypeList DKEGFJKDJBN;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1A50", Offset = "0x5EC0250", VA = "0x185EC1A50")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B55")]
	[Cpp2IlInjected.Address(RVA = "0x24FAE30", Offset = "0x24F9630", VA = "0x1824FAE30")]
	public T FBPOFKNEBFB<T>() where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B56")]
	[Cpp2IlInjected.Address(RVA = "0x24FB0A0", Offset = "0x24F98A0", VA = "0x1824FB0A0")]
	public void NLGFMFNDGBJ<T>(T FKKGMPDEPMA) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B57")]
	[Cpp2IlInjected.Address(RVA = "0x24FAF40", Offset = "0x24F9740", VA = "0x1824FAF40")]
	public DynamicBuffer<T> GCCJCJJLILN<T>(bool KLLJNIBCPAM = false) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B58")]
	[Cpp2IlInjected.Address(RVA = "0x24FB1C0", Offset = "0x24F99C0", VA = "0x1824FB1C0")]
	public void PFCHJBMFFEJ<T>(T FKKGMPDEPMA) where T : struct, IBufferElementData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B59")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1E00", Offset = "0x5EC0600", VA = "0x185EC1E00", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1860", Offset = "0x5EC0060", VA = "0x185EC1860", Slot = "5")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1860", Offset = "0x5EC0060", VA = "0x185EC1860")]
	private void GICNAJAIDNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1AA0", Offset = "0x5EC02A0", VA = "0x185EC1AA0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1E70", Offset = "0x5EC0670", VA = "0x185EC1E70")]
	private ComponentTypeList NKKADEODDNC()
	{
		return default(ComponentTypeList);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5E")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void GGPLKJJDHNI(int EHGKBCBKPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5F")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0")]
	private static void KGLABFIOOAF(Type GFGNPBCFEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B60")]
	[Cpp2IlInjected.Address(RVA = "0x5EC22B0", Offset = "0x5EC0AB0", VA = "0x185EC22B0")]
	private static void OHHPLADDHCE(Type GFGNPBCFEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B61")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public PPEDACELMBL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000216")]
[MFABNNCMDKF]
internal struct MPMEMPPNKKI : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000217")]
[DEONFKEHMJD(typeof(BCPMIOAIJEL), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal sealed class BCPMIOAIJEL : GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	private static readonly DGJIKJLGCCH EGMOEJHCFLK;

	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private static readonly DGJIKJLGCCH PEKAICBNMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private MMJIPEDJBAF<LNKBKLBMHDC, Entity> LFJLKJGOPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private IMHGNPPNKHF<FLHNJBOBMJG> AHDBNNIENNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private IMHGNPPNKHF<DEHNLKNIHLL> GFKDHGPPHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private IMHGNPPNKHF<DAJCGKCPDEM> GLNOAINHAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private IMHGNPPNKHF<HIGAKGABCKI> CMKCAGKEMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private IMHGNPPNKHF<GFPPJPOIIDB> PEENKKOKGPE;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public DOMLLFGMDGD<Entity> IEFHDPFGPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x765620", Offset = "0x763E20", VA = "0x180765620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public NIDDFONOPKD NHLAKJBGJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public NIDDFONOPKD LEGKBKKEGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public NIDDFONOPKD EGPBKNIDJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public NIDDFONOPKD MNKJHIJPNOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B67")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public NIDDFONOPKD HHMBMBEGDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B68")]
		[Cpp2IlInjected.Address(RVA = "0x766140", Offset = "0x764940", VA = "0x180766140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x5EA49B0", Offset = "0x5EA31B0", VA = "0x185EA49B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4AF0", Offset = "0x5EA32F0", VA = "0x185EA4AF0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4A00", Offset = "0x5EA3200", VA = "0x185EA4A00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6C")]
	[Cpp2IlInjected.Address(RVA = "0x2183900", Offset = "0x2182100", VA = "0x182183900")]
	private void FCMGAGDDFDK<T>(IMHGNPPNKHF<T> GBADDAGNAFH, EntityCommandBufferSystem HFDADGLHMNF, DGJIKJLGCCH KFIEDGIKACP) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6D")]
	[Cpp2IlInjected.Address(RVA = "0x21839B0", Offset = "0x21821B0", VA = "0x1821839B0")]
	private void FCMGAGDDFDK<TC, TV>(MMJIPEDJBAF<TC, TV> GBADDAGNAFH) where TC : struct, DJIOGJPHJOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6E")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public BCPMIOAIJEL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000218")]
public struct DEHNLKNIHLL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000219")]
public struct FLHNJBOBMJG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200021A")]
public struct DAJCGKCPDEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200021B")]
public struct HIGAKGABCKI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200021C")]
public struct GFPPJPOIIDB : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200021D")]
[ExecuteAlways]
public class GPALCCJBHHO : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000B70")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770900", VA = "0x180772100")]
	public GPALCCJBHHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021E")]
[DEONFKEHMJD(typeof(DBIGBNACKOL), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal sealed class DBIGBNACKOL : GMMHILFNMPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	private EJIFDEEOFIA JNNDICNDDKB;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public EJIFDEEOFIA BEPLLPAHMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x1BD03E0", Offset = "0x1BCEBE0", VA = "0x181BD03E0")]
		get
		{
			return default(EJIFDEEOFIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B72")]
	[Cpp2IlInjected.Address(RVA = "0x5EA56B0", Offset = "0x5EA3EB0", VA = "0x185EA56B0", Slot = "4")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x5EA56A0", Offset = "0x5EA3EA0", VA = "0x185EA56A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B74")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DBIGBNACKOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021F")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(NODGOFCBOKD), new string[] { })]
internal sealed class NODGOFCBOKD
{
	[Cpp2IlInjected.Token(Token = "0x2000220")]
	public enum DJHCLGMFEIM
	{
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		Gameplay,
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		ObjectModel
	}

	[Cpp2IlInjected.Token(Token = "0x2000221")]
	public struct MJJAKJMIJDB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private DJHCLGMFEIM CKDOPOIEIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private readonly NODGOFCBOKD OBIIIBPBMLD;

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x5EB48D0", Offset = "0x5EB30D0", VA = "0x185EB48D0")]
		public MJJAKJMIJDB(NODGOFCBOKD OBIIIBPBMLD, DJHCLGMFEIM CLBAKDLDGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x5EB48B0", Offset = "0x5EB30B0", VA = "0x185EB48B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006AF")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	public DJHCLGMFEIM CLBAKDLDGPM;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public DJHCLGMFEIM HAJBDMGODFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75F980", VA = "0x180761180")]
		get
		{
			return default(DJHCLGMFEIM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x76A250", Offset = "0x768A50", VA = "0x18076A250")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool DNNDJNENMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x4FB7920", Offset = "0x4FB6120", VA = "0x184FB7920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B78")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD0C0", Offset = "0x5EBB8C0", VA = "0x185EBD0C0")]
	public MJJAKJMIJDB KOGGNKGMELB()
	{
		return default(MJJAKJMIJDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B79")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD110", Offset = "0x5EBB910", VA = "0x185EBD110")]
	public MJJAKJMIJDB OKODHHHOFBE()
	{
		return default(MJJAKJMIJDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NODGOFCBOKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000222")]
[DEONFKEHMJD(typeof(EHJKEAAEBEM), new string[] { })]
internal class DNMLINOHLIL : EHJKEAAEBEM, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	[NMIHDJKFGCM]
	private LPDEJHBNHJJ FAJMCMPDBNC;

	[Cpp2IlInjected.Token(Token = "0x6000B7E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6210", Offset = "0x5EA4A10", VA = "0x185EA6210", Slot = "8")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6300", Offset = "0x5EA4B00", VA = "0x185EA6300", Slot = "4")]
	public World LCEEFFDKMGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6260", Offset = "0x5EA4A60", VA = "0x185EA6260", Slot = "5")]
	public World KHBHFLNKDLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6170", Offset = "0x5EA4970", VA = "0x185EA6170", Slot = "6")]
	public World EAHCFCCMOMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x5EA60D0", Offset = "0x5EA48D0", VA = "0x185EA60D0", Slot = "7")]
	public World CBHDHHAOLIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6410", Offset = "0x5EA4C10", VA = "0x185EA6410")]
	private World NACDAKGJGJD(string HNHMJGCODBA, HPHHJFOKEDC ODJEHGDEAEP, Type JAPGBHPNIDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DNMLINOHLIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000223")]
[DEONFKEHMJD(typeof(KCNLGBKOOKP), new string[] { })]
public class DOGAKAHHDDJ : GJOKPFDLDCJ, KCNLGBKOOKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000224")]
	[CompilerGenerated]
	private struct IGDEMAMBNPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public INJNNPDEJLM parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public DOGAKAHHDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public EPBBAEENEBB objBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private NNONLMNKHJH <parentObject>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private Vector3 <pos>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private Quaternion <rot>5__4;

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x5EAF2F0", Offset = "0x5EADAF0", VA = "0x185EAF2F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x5EAF830", Offset = "0x5EAE030", VA = "0x185EAF830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000225")]
	[CompilerGenerated]
	private struct GKGFGJGKAIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public DOGAKAHHDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public NNONLMNKHJH obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x5EACEA0", Offset = "0x5EAB6A0", VA = "0x185EACEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x5EAD2E0", Offset = "0x5EABAE0", VA = "0x185EAD2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	[NMIHDJKFGCM]
	private DDEDKNJDKDL HGOFPLJJILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private EntityManager IDCNBIGHJII;

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7040", Offset = "0x5EA5840", VA = "0x185EA7040", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x5EA72A0", Offset = "0x5EA5AA0", VA = "0x185EA72A0", Slot = "5")]
	public bool MCJHNMCIHIK(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6AA0", Offset = "0x5EA52A0", VA = "0x185EA6AA0", Slot = "7")]
	public bool CGEJPLDPHJG(INJNNPDEJLM JFIBILKOJPE, [Out] Guid HGPLGELHGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x5EA70E0", Offset = "0x5EA58E0", VA = "0x185EA70E0", Slot = "8")]
	public Guid KGKBNKKPANJ(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B89")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6D00", Offset = "0x5EA5500", VA = "0x185EA6D00", Slot = "9")]
	public void DKMECLKDFOO(INJNNPDEJLM JFIBILKOJPE, Guid HGPLGELHGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7970", Offset = "0x5EA6170", VA = "0x185EA7970", Slot = "10")]
	public bool OHIDAGJIIAP(INJNNPDEJLM JFIBILKOJPE, [Out] Guid AACPINCHENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7360", Offset = "0x5EA5B60", VA = "0x185EA7360", Slot = "11")]
	public Guid MCLMFCIMGJC(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7790", Offset = "0x5EA5F90", VA = "0x185EA7790", Slot = "12")]
	public void NIGMCGGDPMA(INJNNPDEJLM JFIBILKOJPE, Guid AACPINCHENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6B60", Offset = "0x5EA5360", VA = "0x185EA6B60", Slot = "13")]
	public void CLAPENIAECA(INJNNPDEJLM JFIBILKOJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7420", Offset = "0x5EA5C20", VA = "0x185EA7420", Slot = "14")]
	public void NEJMPBHCECE(INJNNPDEJLM KMJKCJJHEFM, INJNNPDEJLM OBIIIBPBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6BF0", Offset = "0x5EA53F0", VA = "0x185EA6BF0")]
	[AsyncStateMachine(typeof(IGDEMAMBNPM))]
	private Task CNJMCMBDMAN(EPBBAEENEBB DLHAEJCKFJP, INJNNPDEJLM OBIIIBPBMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B90")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6900", Offset = "0x5EA5100", VA = "0x185EA6900")]
	private void BOHLCNJBKPB(EPBBAEENEBB DLHAEJCKFJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B91")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6EE0", Offset = "0x5EA56E0", VA = "0x185EA6EE0")]
	[AsyncStateMachine(typeof(GKGFGJGKAIN))]
	private Task FBOJJGICJKP(NNONLMNKHJH CBBCDNDPNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B92")]
	[Cpp2IlInjected.Address(RVA = "0x5EA71A0", Offset = "0x5EA59A0", VA = "0x185EA71A0")]
	private Task KJHMFMCGCBO(NNONLMNKHJH CBBCDNDPNHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6FC0", Offset = "0x5EA57C0", VA = "0x185EA6FC0", Slot = "6")]
	public bool HFDLJFHDGBM(INJNNPDEJLM LHIGGCOIHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DOGAKAHHDDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000226")]
[DEONFKEHMJD(typeof(ECCLLPGLKIN), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
public class ECCLLPGLKIN : GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	[NMIHDJKFGCM]
	private CBDHEEDCCOH EFGNGNHGGFC;

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8AD0", Offset = "0x5EA72D0", VA = "0x185EA8AD0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public ECCLLPGLKIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000227")]
[DEONFKEHMJD(typeof(IBNBDHFMKLE), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
internal sealed class IBNBDHFMKLE : GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	[NMIHDJKFGCM]
	private KCBONGHGBLL LCPIDEBJNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	[NMIHDJKFGCM]
	private GPLNKFNBPCC BONCCEJDCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	[NMIHDJKFGCM]
	private OGDIMNHIMAP NAAMDKNABOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	[NMIHDJKFGCM]
	private EKLAJGGMJNP MFACMNCIMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	[NMIHDJKFGCM]
	private INBFCFKGDFF DFMLGLGMEJA;

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE990", Offset = "0x5EAD190", VA = "0x185EAE990", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEAE0", Offset = "0x5EAD2E0", VA = "0x185EAEAE0")]
	public void LNPEJOMFMHK(NativeArray<ILMCDCGEOPC> AMHNNCEJBHK, NativeArray<AFCHODDKGEA> LILIIJHBMME, NativeArray<Entity> EMPFGDEGKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEB20", Offset = "0x5EAD320", VA = "0x185EAEB20")]
	public Entity LNPEJOMFMHK(ILMCDCGEOPC CCAOKKILBOM, AFCHODDKGEA NFLGLAGMLAA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE520", Offset = "0x5EACD20", VA = "0x185EAE520")]
	public Entity OLLHDCOJNKM(ILMCDCGEOPC CCAOKKILBOM, bool GLOKJGOMGAG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE570", Offset = "0x5EACD70", VA = "0x185EAE570")]
	public Entity OLLHDCOJNKM(ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE350", Offset = "0x5EACB50", VA = "0x185EAE350")]
	public Entity ALFPNKJNGII()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA2")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEC50", Offset = "0x5EAD450", VA = "0x185EAEC50")]
	public Entity NOEPOHDBCGF(IHOKJCEFOEN GFGNPBCFEMC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA3")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEA80", Offset = "0x5EAD280", VA = "0x185EAEA80")]
	public AJLMOHPDADI KGFLJBHMKJF(AJLMOHPDADI BIONNJIHGCI, Allocator JONICLHJBEP)
	{
		return default(AJLMOHPDADI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAECE0", Offset = "0x5EAD4E0", VA = "0x185EAECE0")]
	public EntityArchetype PJGCMJDPIJC(ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA5")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE5B0", Offset = "0x5EACDB0", VA = "0x185EAE5B0")]
	public Entity FMJGLACGPOC(ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA6")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE520", Offset = "0x5EACD20", VA = "0x185EAE520")]
	private Entity FBCIIPDFLKO(ILMCDCGEOPC CCAOKKILBOM, bool GLOKJGOMGAG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA7")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE570", Offset = "0x5EACD70", VA = "0x185EAE570")]
	private Entity FBCIIPDFLKO(ILMCDCGEOPC CCAOKKILBOM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE390", Offset = "0x5EACB90", VA = "0x185EAE390")]
	private Entity FBCIIPDFLKO(ILMCDCGEOPC CCAOKKILBOM, AFCHODDKGEA NFLGLAGMLAA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA9")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEB30", Offset = "0x5EAD330", VA = "0x185EAEB30")]
	private void MMPLCKLKAFC(ILMCDCGEOPC CCAOKKILBOM, NativeArray<AFCHODDKGEA> LILIIJHBMME, NativeArray<Entity> EMPFGDEGKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAA")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE6E0", Offset = "0x5EACEE0", VA = "0x185EAE6E0")]
	private void IOPGCBDOCIC(NativeArray<ILMCDCGEOPC> AMHNNCEJBHK, NativeArray<AFCHODDKGEA> LILIIJHBMME, NativeArray<Entity> EMPFGDEGKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAB")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public IBNBDHFMKLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000228")]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(OGDIMNHIMAP), new string[] { })]
internal sealed class OGDIMNHIMAP : GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	public static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	[NMIHDJKFGCM]
	private CIKNOIPMHLH KNNPACEKKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	[NMIHDJKFGCM]
	private KCBONGHGBLL PCFGKJBOLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	[NMIHDJKFGCM]
	private GPLNKFNBPCC FHGKLMFMKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private NativeParallelHashMap<AFCHODDKGEA, Entity> OFJKOBIMEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private EntityManager IDCNBIGHJII;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	internal NativeParallelHashMap<AFCHODDKGEA, Entity> BMLKIPGLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5DC60", VA = "0x180D5F460")]
		get
		{
			return default(NativeParallelHashMap<AFCHODDKGEA, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	internal uint JIEOBOEGMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x5EBDC10", Offset = "0x5EBC410", VA = "0x185EBDC10")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private bool AMDAEMPIIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x84EF00", Offset = "0x84D700", VA = "0x18084EF00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB0")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD720", Offset = "0x5EBBF20", VA = "0x185EBD720", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB1")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD2B0", Offset = "0x5EBBAB0", VA = "0x185EBD2B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB2")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD1F0", Offset = "0x5EBB9F0", VA = "0x185EBD1F0")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB3")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDC40", Offset = "0x5EBC440", VA = "0x185EBDC40")]
	public AFCHODDKGEA PMPGDAGANED(int EHGKBCBKPCI)
	{
		return default(AFCHODDKGEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB4")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD560", Offset = "0x5EBBD60", VA = "0x185EBD560")]
	public void HFGJEIMJDNC(AFCHODDKGEA NFLGLAGMLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB5")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD970", Offset = "0x5EBC170", VA = "0x185EBD970")]
	public INJNNPDEJLM OGCAMABILPC(AFCHODDKGEA NFLGLAGMLAA)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB6")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD460", Offset = "0x5EBBC60", VA = "0x185EBD460")]
	public bool GPAFOHEEBAA(AFCHODDKGEA NFLGLAGMLAA, [Out] INJNNPDEJLM JFIBILKOJPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB7")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD840", Offset = "0x5EBC040", VA = "0x185EBD840")]
	public AJLMOHPDADI OGCAMABILPC(NativeArray<AFCHODDKGEA> NFLGLAGMLAA, Allocator JONICLHJBEP)
	{
		return default(AJLMOHPDADI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB8")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD320", Offset = "0x5EBBB20", VA = "0x185EBD320")]
	public AFCHODDKGEA GJHNEMLALPJ(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(AFCHODDKGEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB9")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD3D0", Offset = "0x5EBBBD0", VA = "0x185EBD3D0")]
	public AFCHODDKGEA GJHNEMLALPJ(Entity KCMPKMKBCOO)
	{
		return default(AFCHODDKGEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBA")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDAB0", Offset = "0x5EBC2B0", VA = "0x185EBDAB0")]
	public void PHMEHFPCOCD(NativeArray<Entity> FAIFKAKJOPP, NativeArray<AFCHODDKGEA> LILIIJHBMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBB")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD270", Offset = "0x5EBBA70", VA = "0x185EBD270")]
	private INJNNPDEJLM BOGKJEFOBCK(Entity KCMPKMKBCOO)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBC")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public OGDIMNHIMAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000229")]
[DEONFKEHMJD(typeof(JPCLBEACHKO), new string[] { })]
public sealed class NLAOJGICIIO : JPCLBEACHKO, AHDBNGLCNFH, GMMHILFNMPG, GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	[NMIHDJKFGCM]
	private NAHFHNGCNNC IKCAIPFFHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private Collider[] HGDOBDPNLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private RaycastHit[] FIJDPEPOGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private JAMMDJGAEKI<JAOCJEPKNDC, BoxCollider> IFIGGGBMEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private Scene AGEHAEDLOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private PhysicsScene JBFPBJGHCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private GameObject ABPIJCGDOPA;

	[Cpp2IlInjected.Token(Token = "0x6000BBE")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC5C0", Offset = "0x5EBADC0", VA = "0x185EBC5C0", Slot = "9")]
	public void FECLGOHHEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBF")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC890", Offset = "0x5EBB090", VA = "0x185EBC890", Slot = "10")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC0")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC3A0", Offset = "0x5EBABA0", VA = "0x185EBC3A0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC1")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC260", Offset = "0x5EBAA60", VA = "0x185EBC260", Slot = "4")]
	public JAOCJEPKNDC BGMBCDAIPLI(Entity KCMPKMKBCOO)
	{
		return default(JAOCJEPKNDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC2")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBE50", Offset = "0x5EBA650", VA = "0x185EBBE50", Slot = "5")]
	public void ANKPFCCEHDD(NativeArray<JAOCJEPKNDC> LJNLCPPFNHA, NativeArray<MGNOMCEDPAJ> FLFNJJPOPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC3")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBD90", Offset = "0x5EBA590", VA = "0x185EBBD90", Slot = "6")]
	public void ACHPGKFHPNB(JAOCJEPKNDC KPAMIOKBGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC4")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC7F0", Offset = "0x5EBAFF0", VA = "0x185EBC7F0", Slot = "7")]
	public bool HJGFCLBEGPK(JAOCJEPKNDC KPAMIOKBGLD, [Out] Collider ICCDLLEGOFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC5")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCCC0", Offset = "0x5EBB4C0", VA = "0x185EBCCC0")]
	public bool MOPGPDCKDNJ([In] float3 DPIMNMEPENP, [In] float3 GJMNPFFBJPA, float LNHOFLIBFND, Allocator JONICLHJBEP, [Out] NativeArray<Entity> FAIFKAKJOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC6")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCFA0", Offset = "0x5EBB7A0", VA = "0x185EBCFA0")]
	private void NBMGIANOKCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC7")]
	[Cpp2IlInjected.Address(RVA = "0xD56E60", Offset = "0xD55660", VA = "0x180D56E60")]
	private void JEIIFAEDHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC8")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCB70", Offset = "0x5EBB370", VA = "0x185EBCB70")]
	private void JPFNPOMAGJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC9")]
	[Cpp2IlInjected.Address(RVA = "0x846450", Offset = "0x844C50", VA = "0x180846450")]
	private void MENLLKFIJOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCA")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC4B0", Offset = "0x5EBACB0", VA = "0x185EBC4B0")]
	private BoxCollider ELFNGDJCIII(Entity KCMPKMKBCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCB")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC720", Offset = "0x5EBAF20", VA = "0x185EBC720")]
	private void GOFEKELAKHE(BoxCollider DAGCOGPFKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCC")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC0B0", Offset = "0x5EBA8B0", VA = "0x185EBC0B0")]
	private void BFDOOADBIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCD")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCBC0", Offset = "0x5EBB3C0", VA = "0x185EBCBC0")]
	private void KOEOABDFKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCE")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC960", Offset = "0x5EBB160", VA = "0x185EBC960")]
	private void JGOPJKECPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCF")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD000", Offset = "0x5EBB800", VA = "0x185EBD000")]
	private void PBKOGAFDLEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD0")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC7A0", Offset = "0x5EBAFA0", VA = "0x185EBC7A0")]
	private void GPJMNEAJDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD1")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC7B0", Offset = "0x5EBAFB0", VA = "0x185EBC7B0")]
	private void HBBCLDEDFGJ(Scene JJABOEJGAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD2")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public NLAOJGICIIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD4")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCFF0", Offset = "0x5EBB7F0", VA = "0x185EBCFF0", Slot = "8")]
	private bool NEGFMCDOMBH([In] float3 DPIMNMEPENP, [In] float3 GJMNPFFBJPA, float LNHOFLIBFND, Allocator JONICLHJBEP, [Out] NativeArray<Entity> FAIFKAKJOPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200022A")]
[CIJINFPJIAB(typeof(KMPONHKFGGL))]
[PHKIPGBLCCH(PJHIMKBCGDP.OMRoom)]
[DEONFKEHMJD(typeof(DGHDNCBDPIG), new string[] { })]
internal class DGHDNCBDPIG : GJOKPFDLDCJ, KMPONHKFGGL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	[NMIHDJKFGCM]
	private LPGGEAMFNMM MKMECJFCOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006E4")]
	private NOBCMIJEINK IJPDDFOJCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006E5")]
	private NativeList<byte> AELCABDCBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E6")]
	private NativeList<KABIMFKAPPA> GBDBHJCEALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006E7")]
	private NativeList<DDIOAHAKKEH> GCKBMIIPBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006E8")]
	private int HIDAOGOCPGJ;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<KABIMFKAPPA, NativeArray<byte>> EMNPFBOHDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x5EC76F0", Offset = "0x5EC5EF0", VA = "0x185EC76F0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7640", Offset = "0x5EC5E40", VA = "0x185EC7640")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD7")]
	[Cpp2IlInjected.Address(RVA = "0x5EC77A0", Offset = "0x5EC5FA0", VA = "0x185EC77A0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD8")]
	[Cpp2IlInjected.Address(RVA = "0x5EC75C0", Offset = "0x5EC5DC0", VA = "0x185EC75C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD9")]
	[Cpp2IlInjected.Address(RVA = "0x5EC78D0", Offset = "0x5EC60D0", VA = "0x185EC78D0", Slot = "5")]
	public void LNMHAAKFGIC(KABIMFKAPPA KLIANGHAKAC, ReadOnlySpan<byte> KAAIDPFBBBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDA")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7540", Offset = "0x5EC5D40", VA = "0x185EC7540")]
	public void BEIKHFOBAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDB")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public DGHDNCBDPIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022B")]
[DEONFKEHMJD(typeof(HMPNEEDBEAL), new string[] { })]
internal class LFNGJBPDMCP : HMPNEEDBEAL, GJOKPFDLDCJ, FIBMJMMLGPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200022C")]
	[CompilerGenerated]
	private sealed class PLOCNIJIAJK : IEnumerable<INJNNPDEJLM>, IEnumerable, IEnumerator<INJNNPDEJLM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private INJNNPDEJLM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public LFNGJBPDMCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private INJNNPDEJLM localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public INJNNPDEJLM <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private NativeArray<Entity> <childEntitiesCopy>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private NativeArray<Entity>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		private INJNNPDEJLM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C02")]
			[Cpp2IlInjected.Address(RVA = "0x31038C0", Offset = "0x31020C0", VA = "0x1831038C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(INJNNPDEJLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C04")]
			[Cpp2IlInjected.Address(RVA = "0x5ED0490", Offset = "0x5ECEC90", VA = "0x185ED0490", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x3224EC0", Offset = "0x32236C0", VA = "0x183224EC0")]
		[DebuggerHidden]
		public PLOCNIJIAJK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x5ED04E0", Offset = "0x5ECECE0", VA = "0x185ED04E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFF60", Offset = "0x5ECE760", VA = "0x185ECFF60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0340", Offset = "0x5ECEB40", VA = "0x185ED0340")]
		private void NINDIEOCHCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x5ED02F0", Offset = "0x5ECEAF0", VA = "0x185ED02F0")]
		private void NIGDNOCCEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0440", Offset = "0x5ECEC40", VA = "0x185ED0440", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0390", Offset = "0x5ECEB90", VA = "0x185ED0390", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<INJNNPDEJLM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0390", Offset = "0x5ECEB90", VA = "0x185ED0390", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private static readonly DGJIKJLGCCH KEBHLMCBBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006F0")]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private FGKEDJEKEGI AJDKMCHGGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private GAHJBAOIADM GLKFLDDFJDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	private FAOOFKFDMAN<Entity> KNDKGFMEFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private FAOOFKFDMAN<float3> OIOKBEDBCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private FAOOFKFDMAN<quaternion> FBLILEOJDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	private FAOOFKFDMAN<float> BCDCEMOPEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	private HashSet<Entity> PHGKBINMIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private HashSet<Entity> IMGBHLHLICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40006F9")]
	private EntityQuery DHAIPKMBGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40006FA")]
	private bool KIMEMKKPGDJ;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public Func<IGINIAKAODA> FFCMHEBHAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x768E20", Offset = "0x767620", VA = "0x180768E20", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x768DE0", Offset = "0x7675E0", VA = "0x180768DE0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<INJNNPDEJLM, INJNNPDEJLM> IOLNCBEJLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEC60", Offset = "0x5ECD460", VA = "0x185ECEC60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF010", Offset = "0x5ECD810", VA = "0x185ECF010", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<INJNNPDEJLM, INJNNPDEJLM> MCFDMFNGBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD090", Offset = "0x5ECB890", VA = "0x185ECD090", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD760", Offset = "0x5ECBF60", VA = "0x185ECD760", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<INJNNPDEJLM, INJNNPDEJLM, INJNNPDEJLM> AGIGNEECOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD6B0", Offset = "0x5ECBEB0", VA = "0x185ECD6B0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDF90", Offset = "0x5ECC790", VA = "0x185ECDF90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<INJNNPDEJLM> IOGKCADLKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD810", Offset = "0x5ECC010", VA = "0x185ECD810", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE0E0", Offset = "0x5ECC8E0", VA = "0x185ECE0E0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE3F0", Offset = "0x5ECCBF0", VA = "0x185ECE3F0", Slot = "26")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD1D0", Offset = "0x5ECB9D0", VA = "0x185ECD1D0", Slot = "27")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD8C0", Offset = "0x5ECC0C0", VA = "0x185ECD8C0", Slot = "28")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEC00", Offset = "0x5ECD400", VA = "0x185ECEC00")]
	private void MFNNKMBKHCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDC10", Offset = "0x5ECC410", VA = "0x185ECDC10")]
	private void GBBDMKLBGHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEC")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDD90", Offset = "0x5ECC590", VA = "0x185ECDD90")]
	private void GGBFKFKAOHN(GDGCFENIDIN AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEAB0", Offset = "0x5ECD2B0", VA = "0x185ECEAB0")]
	private void KKGNKMONIAK(GDGCFENIDIN AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x8198F0", Offset = "0x8180F0", VA = "0x1808198F0", Slot = "14")]
	public Color HAPDOEECIBN(INJNNPDEJLM JFIBILKOJPE, int BDCBPNEKBCF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE6C0", Offset = "0x5ECCEC0", VA = "0x185ECE6C0", Slot = "15")]
	public float3 KAJJNGCOGJC(INJNNPDEJLM JFIBILKOJPE, int BDCBPNEKBCF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF0")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8C0", Offset = "0x5ECD0C0", VA = "0x185ECE8C0", Slot = "16")]
	public bool KEMOAHBAOKB(INJNNPDEJLM JFIBILKOJPE, INJNNPDEJLM ANCBIKEPBGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF1")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE040", Offset = "0x5ECC840", VA = "0x185ECE040", Slot = "17")]
	public INJNNPDEJLM GHHBMGLHMPN(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF2")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE960", Offset = "0x5ECD160", VA = "0x185ECE960", Slot = "20")]
	public void KGICFCFLPDC(INJNNPDEJLM JFIBILKOJPE, Vector3 NDPCJBJIPHA, Quaternion OKAKPNBENIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF3")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE370", Offset = "0x5ECCB70", VA = "0x185ECE370", Slot = "21")]
	public void ILEPLGOLHLB(INJNNPDEJLM JFIBILKOJPE, float KJDBOBHCLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF4")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEB70", Offset = "0x5ECD370", VA = "0x185ECEB70", Slot = "24")]
	public float3 KOHJOGKOFIN(JJCAKKLOMJF MLPFBJPLEIN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECED10", Offset = "0x5ECD510", VA = "0x185ECED10", Slot = "25")]
	public quaternion NJLKLIEOAJH(JJCAKKLOMJF MLPFBJPLEIN)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF6")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE190", Offset = "0x5ECC990", VA = "0x185ECE190", Slot = "22")]
	public bool IBENNLEEFIP(INJNNPDEJLM JFIBILKOJPE, [Out] RigidTransform COPPNAHMKDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF7")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE550", Offset = "0x5ECCD50", VA = "0x185ECE550", Slot = "23")]
	public bool JIPMPGIKAHB(INJNNPDEJLM JFIBILKOJPE, [Out] float KJDBOBHCLDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF8")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD140", Offset = "0x5ECB940", VA = "0x185ECD140", Slot = "18")]
	[IteratorStateMachine(typeof(PLOCNIJIAJK))]
	public IEnumerable<INJNNPDEJLM> ADNGDJCBMLP(INJNNPDEJLM JFIBILKOJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF9")]
	[Cpp2IlInjected.Address(RVA = "0x5ECED90", Offset = "0x5ECD590", VA = "0x185ECED90", Slot = "19")]
	public INJNNPDEJLM NOPFHFBDCKG(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFA")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEEF0", Offset = "0x5ECD6F0", VA = "0x185ECEEF0")]
	private Entity NOPFHFBDCKG(Entity KCMPKMKBCOO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFB")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF180", Offset = "0x5ECD980", VA = "0x185ECF180")]
	public LFNGJBPDMCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022D")]
[DEONFKEHMJD(typeof(LPAIOCMDJPJ), new string[] { })]
public sealed class ENJOKLBNCKG : LPAIOCMDJPJ, GJOKPFDLDCJ
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200022E")]
	private struct IGEFBEHMIOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public float FLEKOMGPFFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public uint LOHBBMECPKB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000704")]
	[NMIHDJKFGCM]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000705")]
	[NMIHDJKFGCM]
	private AHDBNGLCNFH IMICBLFBHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000706")]
	[NMIHDJKFGCM]
	private PMPOCIFKPJF DHHELLIBDKK;

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8750", Offset = "0x5EC6F50", VA = "0x185EC8750", Slot = "5")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x5EC87E0", Offset = "0x5EC6FE0", VA = "0x185EC87E0")]
	public bool MOPGPDCKDNJ([In] float3 DPIMNMEPENP, [In] float3 GJMNPFFBJPA, float LNHOFLIBFND, [Out] NFJPHLAHAEN EOBBGNKPAPG, [Out] INJNNPDEJLM JBJEFMHIIMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C09")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8C90", Offset = "0x5EC7490", VA = "0x185EC8C90")]
	public static bool PGBPMJENAPJ([In] Span<NFJPHLAHAEN> GDLMPFEBHAB, float LNHOFLIBFND, [Out] int LFEFGCGCIAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8720", Offset = "0x5EC6F20", VA = "0x185EC8720")]
	public static float FFPJPLOKGCG(float FLEKOMGPFFE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0B")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public ENJOKLBNCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8710", Offset = "0x5EC6F10", VA = "0x185EC8710", Slot = "4")]
	private bool ALKBHJFFHLP([In] float3 DPIMNMEPENP, [In] float3 GJMNPFFBJPA, float LNHOFLIBFND, [Out] NFJPHLAHAEN EOBBGNKPAPG, [Out] INJNNPDEJLM JBJEFMHIIMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200022F")]
[DEONFKEHMJD(typeof(PMPOCIFKPJF), new string[] { })]
public sealed class PLBGGJGLODP : PMPOCIFKPJF, GJOKPFDLDCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000230")]
	[BurstCompile]
	private struct KHOCOJBEKKG : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		[ReadOnly]
		public NativeArray<Entity> FAIFKAKJOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		[ReadOnly]
		public float3 PLIKEHGHMDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		[ReadOnly]
		public float3 FGOPGONDOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> EPJGAGFGLIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		[ReadOnly]
		public ComponentDataFromEntity<BCAHBAGLDKB> GIINEKAENAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> ECLPLGEEBPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		[ReadOnly]
		public ComponentDataFromEntity<DFMOOBPAIKI> HDMPODHJHBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		[ReadOnly]
		public ComponentDataFromEntity<GLIEJDBHEBG> LKLLBBKNFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		[WriteOnly]
		public NativeArray<NFJPHLAHAEN> FKLIHCKBJEL;

		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private static readonly NFJPHLAHAEN MFEGMOAMBPB;

		[Cpp2IlInjected.Token(Token = "0x6000C11")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC040", Offset = "0x5ECA840", VA = "0x185ECC040", Slot = "4")]
		public void Execute(int LFEFGCGCIAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C12")]
		[Cpp2IlInjected.Address(RVA = "0x5ECBC80", Offset = "0x5ECA480", VA = "0x185ECBC80")]
		private static float3 AKLEALAIJPD([In] float4x4 GOCMAOEPKDG, [In] float3 EJOBIJGJEMN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCC10", Offset = "0x5ECB410", VA = "0x185ECCC10")]
		private static float3 NMFKAIDMNLD([In] float4x4 GOCMAOEPKDG, [In] float3 CLPHKIKLHHF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCB10", Offset = "0x5ECB310", VA = "0x185ECCB10")]
		private static float3 MPHKFPPDEHN([In] float4x4 GOCMAOEPKDG, [In] float3 EJOBIJGJEMN)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC2E0", Offset = "0x5ECAAE0", VA = "0x185ECC2E0")]
		private static float3 KMKKMHAHIIO([In] float4x4 GOCMAOEPKDG, [In] float3 CLPHKIKLHHF)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x5ECBD30", Offset = "0x5ECA530", VA = "0x185ECBD30")]
		private bool CLKJJMNNHDG([In] float3 DPIMNMEPENP, [In] float3 GJMNPFFBJPA, [In] NativeArray<Entity> DFADAIJDFCK, [Out] float3 EOBBGNKPAPG, [Out] float3 LOKKODLNJFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC4C0", Offset = "0x5ECACC0", VA = "0x185ECC4C0")]
		public static bool MKHLFAMKOBA([In] float3 OLCBDGIONHD, [In] float3 IHLKCPDBPEL, [In] float3 EDEJEHMDADM, [In] float3 FNCLKIMBPNL, float CICAOIPPAPB, float IGFBEKNILFA, [Out] float INGJCJMKCCN, [Out] float3 IOOIAIKIEIJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private EntityManager IDCNBIGHJII;

	[Cpp2IlInjected.Token(Token = "0x6000C0D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFAA0", Offset = "0x5ECE2A0", VA = "0x185ECFAA0", Slot = "5")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFB20", Offset = "0x5ECE320", VA = "0x185ECFB20")]
	public void MOPGPDCKDNJ([In] NativeArray<Entity> FAIFKAKJOPP, [In] float3 DPIMNMEPENP, [In] float3 GJMNPFFBJPA, [In] NativeArray<NFJPHLAHAEN> CBCGGKMFAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public PLBGGJGLODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C10")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFA90", Offset = "0x5ECE290", VA = "0x185ECFA90", Slot = "4")]
	private void INNPPOMKAEG([In] NativeArray<Entity> FAIFKAKJOPP, [In] float3 DPIMNMEPENP, [In] float3 GJMNPFFBJPA, [In] NativeArray<NFJPHLAHAEN> CBCGGKMFAEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000231")]
[DEONFKEHMJD(typeof(GAHJBAOIADM), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.LoadInstance)]
[CIJINFPJIAB(typeof(BKMMIGNMLKP))]
public class GAHJBAOIADM : BKMMIGNMLKP, GJOKPFDLDCJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000232")]
	private struct KLEADDJAHLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public KGKKGEFDIKG NNENGEANNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public Type GFGNPBCFEMC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000233")]
	private struct OFENKFNEEFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public KLEADDJAHLD[] CBHFJDMCLMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000234")]
	[BurstCompile]
	private struct ADOCMANLNEK : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		[ReadOnly]
		public NativeArray<byte> GOIHPLLIMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		[ReadOnly]
		public NativeArray<Entity> EOMOOPCJFMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		[ReadOnly]
		public NativeArray<byte> AGMFAIIODJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		[ReadOnly]
		public NativeArray<byte> AGJMAELLEJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		[WriteOnly]
		public NativeList<Entity> CMHHOFAPAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		[WriteOnly]
		public NativeList<byte> LCMKGIKMMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		[WriteOnly]
		public NativeList<byte> MDONMNFIJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public int OHNFICPEEFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public int NFCCCBHBENH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public int FDPPKJOEBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public int GFOIEDBEJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public int PNAGHKJDMOC;

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7300", Offset = "0x5EC5B00", VA = "0x185EC7300", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000714")]
	private static readonly DGJIKJLGCCH KFIEDGIKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private readonly Dictionary<OJBFPODPDEH, KGKKGEFDIKG> FAJMMALJHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	private readonly Dictionary<int, OFENKFNEEFN> LEDMHMKHEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private FMKLLJOIEFE CBHFJDMCLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action MJENENMFCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA960", Offset = "0x5EC9160", VA = "0x185ECA960")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECAE70", Offset = "0x5EC9670", VA = "0x185ECAE70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action KNEDINOLNFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECAF10", Offset = "0x5EC9710", VA = "0x185ECAF10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB4F0", Offset = "0x5EC9CF0", VA = "0x185ECB4F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAFB0", Offset = "0x5EC97B0", VA = "0x185ECAFB0", Slot = "6")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA8D0", Offset = "0x5EC90D0", VA = "0x185ECA8D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB0F0", Offset = "0x5EC98F0", VA = "0x185ECB0F0", Slot = "4")]
	public void NJMEIPIEAKJ(IPJNDHGBNHD EJKGILKDBHL, KGKKGEFDIKG DOMFMMLMKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C20")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9E40", Offset = "0x5EC8640", VA = "0x185EC9E40", Slot = "5")]
	public void CDCOKJBLGCF(IPJNDHGBNHD EJKGILKDBHL, KGKKGEFDIKG DOMFMMLMKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C21")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB240", Offset = "0x5EC9A40", VA = "0x185ECB240", Slot = "8")]
	public void NJMEIPIEAKJ(OJBFPODPDEH OJNPMCODCBJ, KGKKGEFDIKG ABCKGGDLEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C22")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9D20", Offset = "0x5EC8520", VA = "0x185EC9D20", Slot = "9")]
	public void CDCOKJBLGCF(OJBFPODPDEH OJNPMCODCBJ, KGKKGEFDIKG ABCKGGDLEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C23")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB330", Offset = "0x5EC9B30", VA = "0x185ECB330")]
	private void NOKNJKKPCJK(OJBFPODPDEH OJNPMCODCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C24")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAB80", Offset = "0x5EC9380", VA = "0x185ECAB80")]
	internal void GGIBPJNKHCJ(LKEAAHCANFE CDOGIGHJFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C25")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9F90", Offset = "0x5EC8790", VA = "0x185EC9F90")]
	private void DIDLCPJCGGG(LKEAAHCANFE CDOGIGHJFKJ, int JIBGFHDMIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C26")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9AD0", Offset = "0x5EC82D0", VA = "0x185EC9AD0")]
	private void BINPBNBICEM(DFAONIGDOMP DHNIGJBMBBC, EANCAGBLBGP GNEFKKDOEFH, KLEADDJAHLD GIGLGFEFJOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C27")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAA00", Offset = "0x5EC9200", VA = "0x185ECAA00")]
	private OFENKFNEEFN GAFAPKMDGOJ(DFAONIGDOMP DHNIGJBMBBC, EANCAGBLBGP GNEFKKDOEFH)
	{
		return default(OFENKFNEEFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C28")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB020", Offset = "0x5EC9820", VA = "0x185ECB020")]
	private KLEADDJAHLD MMMCECIFHEI(OFENKFNEEFN EBKCCOGJBDL, DFAONIGDOMP DHNIGJBMBBC, EANCAGBLBGP GNEFKKDOEFH)
	{
		return default(KLEADDJAHLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C29")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB620", Offset = "0x5EC9E20", VA = "0x185ECB620")]
	public GAHJBAOIADM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000235")]
[DEONFKEHMJD(typeof(JPPHIDMLLDL), new string[] { })]
public class FEPEIHHAOGM : GJOKPFDLDCJ, FIBMJMMLGPO, JPPHIDMLLDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000236")]
	[CompilerGenerated]
	private sealed class GKKIHPNFGIJ : IEnumerable<INJNNPDEJLM>, IEnumerable, IEnumerator<INJNNPDEJLM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private INJNNPDEJLM <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public FEPEIHHAOGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private INJNNPDEJLM splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public INJNNPDEJLM <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		private INJNNPDEJLM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C41")]
			[Cpp2IlInjected.Address(RVA = "0x31038C0", Offset = "0x31020C0", VA = "0x1831038C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(INJNNPDEJLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C43")]
			[Cpp2IlInjected.Address(RVA = "0x5ECBAC0", Offset = "0x5ECA2C0", VA = "0x185ECBAC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x3224EC0", Offset = "0x32236C0", VA = "0x183224EC0")]
		[DebuggerHidden]
		public GKKIHPNFGIJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB900", Offset = "0x5ECA100", VA = "0x185ECB900", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x5ECBA70", Offset = "0x5ECA270", VA = "0x185ECBA70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB9C0", Offset = "0x5ECA1C0", VA = "0x185ECB9C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<INJNNPDEJLM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB9C0", Offset = "0x5ECA1C0", VA = "0x185ECB9C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private LDNONJHJNKB CLODAHGGILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400072C")]
	private CBDHEEDCCOH EFGNGNHGGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400072D")]
	private IBNBDHFMKLE CLEKEDNIBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	private JEIJFNDLCFE KOJOEBGFGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private PPEDACELMBL ONNHHFMGKON;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private EntityManager CJKMFGKCEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8E10", Offset = "0x5EC7610", VA = "0x185EC8E10")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC94D0", Offset = "0x5EC7CD0", VA = "0x185EC94D0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2E")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
	public void AIOKCKNKHOD(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2F")]
	[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C30")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8FB0", Offset = "0x5EC77B0", VA = "0x185EC8FB0")]
	private void EPOGEMACDEC(Entity BDHANMOFOOJ, int LFEFGCGCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C31")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8D70", Offset = "0x5EC7570", VA = "0x185EC8D70", Slot = "10")]
	public void CGIANIMJCEB(INJNNPDEJLM JFIBILKOJPE, MFLINDAOODE GCMLNHCMFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C32")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9630", Offset = "0x5EC7E30", VA = "0x185EC9630", Slot = "9")]
	public MFLINDAOODE LIIPALOEPBP(INJNNPDEJLM JFIBILKOJPE)
	{
		return default(MFLINDAOODE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C33")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8F40", Offset = "0x5EC7740", VA = "0x185EC8F40", Slot = "11")]
	public INJNNPDEJLM DDGJNAEIEFO(INJNNPDEJLM OGPPFEEJHLN, [Optional] float3? MCLBBPPAHAP, [Optional] quaternion? OHMBDAJNEIJ, [Optional] float3? DCPNEEKOHBH)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C34")]
	[Cpp2IlInjected.Address(RVA = "0x5EC95C0", Offset = "0x5EC7DC0", VA = "0x185EC95C0", Slot = "12")]
	public INJNNPDEJLM JLAJDFMMFGF(INJNNPDEJLM OGPPFEEJHLN, int LFEFGCGCIAG, [Optional] float3? MCLBBPPAHAP, [Optional] quaternion? OHMBDAJNEIJ, [Optional] float3? DCPNEEKOHBH)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C35")]
	[Cpp2IlInjected.Address(RVA = "0x5EC96D0", Offset = "0x5EC7ED0", VA = "0x185EC96D0")]
	private INJNNPDEJLM MCEBDLHLPDN(INJNNPDEJLM OGPPFEEJHLN, int LFEFGCGCIAG, [Optional] float3? MCLBBPPAHAP, [Optional] quaternion? OHMBDAJNEIJ, [Optional] float3? DCPNEEKOHBH)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C36")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8E60", Offset = "0x5EC7660", VA = "0x185EC8E60", Slot = "7")]
	public INJNNPDEJLM DBMPKLKJNEK(INJNNPDEJLM OGPPFEEJHLN, int LFEFGCGCIAG)
	{
		return default(INJNNPDEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C37")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9470", Offset = "0x5EC7C70", VA = "0x185EC9470", Slot = "16")]
	public void IPKANPJEIHB(INJNNPDEJLM OGPPFEEJHLN, INJNNPDEJLM BDHANMOFOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C38")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9350", Offset = "0x5EC7B50", VA = "0x185EC9350", Slot = "13")]
	public void IBMGGDNIGNE(INJNNPDEJLM OGPPFEEJHLN, int LFEFGCGCIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C39")]
	[Cpp2IlInjected.Address(RVA = "0x5EC90C0", Offset = "0x5EC78C0", VA = "0x185EC90C0", Slot = "14")]
	public void IAMLNMMPJJO(INJNNPDEJLM OGPPFEEJHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC99D0", Offset = "0x5EC81D0", VA = "0x185EC99D0", Slot = "8")]
	public int PKJDJJGKBDD(INJNNPDEJLM OGPPFEEJHLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9030", Offset = "0x5EC7830", VA = "0x185EC9030", Slot = "6")]
	[IteratorStateMachine(typeof(GKKIHPNFGIJ))]
	public IEnumerable<INJNNPDEJLM> HJFAIHMCADA(INJNNPDEJLM OGPPFEEJHLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9940", Offset = "0x5EC8140", VA = "0x185EC9940")]
	private bool PCNHFOJHMFK(INJNNPDEJLM OGPPFEEJHLN, [Out] NativeArray<Entity> NLFNHIPAONL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public FEPEIHHAOGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000237")]
[DEONFKEHMJD(typeof(BPMGOMBNHJD), new string[] { })]
[PHKIPGBLCCH(PJHIMKBCGDP.LoadInstance)]
internal sealed class BPMGOMBNHJD : GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private CIKNOIPMHLH NMJLCHEIIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000739")]
	private NODGOFCBOKD JNCEPLNFFOM;

	[Cpp2IlInjected.Token(Token = "0x6000C46")]
	[Cpp2IlInjected.Address(RVA = "0x5EC74C0", Offset = "0x5EC5CC0", VA = "0x185EC74C0", Slot = "4")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C47")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public BPMGOMBNHJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000238")]
[DefaultMember("Item")]
public struct KHPDMLJPHMF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073A")]
	private T[] AELCABDCBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	private int HPFMIMMLOKB;

	[Cpp2IlInjected.Token(Token = "0x6000C48")]
	[Cpp2IlInjected.Address(RVA = "0x3875870", Offset = "0x3874070", VA = "0x183875870", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000239")]
[DefaultMember("Item")]
public struct KCBNOJDPGPK<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	private KHPDMLJPHMF<T> AELCABDCBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	private int HPFMIMMLOKB;

	[Cpp2IlInjected.Token(Token = "0x6000C49")]
	[Cpp2IlInjected.Address(RVA = "0x3855220", Offset = "0x3853A20", VA = "0x183855220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4A")]
	[Cpp2IlInjected.Address(RVA = "0x3855260", Offset = "0x3853A60", VA = "0x183855260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200023A")]
public struct EJIFDEEOFIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073E")]
	private NativeList<Entity> FAIFKAKJOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400073F")]
	private TransformAccessArray DFJLJGOOCKN;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public int HLNPNOBJJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8570", Offset = "0x5EC6D70", VA = "0x185EC8570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public NativeList<Entity> CANHKBHGPMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA50", Offset = "0xA8A250", VA = "0x180A8BA50")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public TransformAccessArray DOLIBBFPOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool AMDAEMPIIPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC85D0", Offset = "0x5EC6DD0", VA = "0x185EC85D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8680", Offset = "0x5EC6E80", VA = "0x185EC8680")]
	public EJIFDEEOFIA(int AFOFPPEGLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C50")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8580", Offset = "0x5EC6D80", VA = "0x185EC8580")]
	public Entity GLEOEOHJAED(int LFEFGCGCIAG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C51")]
	[Cpp2IlInjected.Address(RVA = "0x5EC85F0", Offset = "0x5EC6DF0", VA = "0x185EC85F0")]
	public void JAKGLOIBMBP(int AFOFPPEGLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C52")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8430", Offset = "0x5EC6C30", VA = "0x185EC8430")]
	public int BONJGFNEKBE(Transform CPMBJLDHCID, Entity KCMPKMKBCOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C53")]
	[Cpp2IlInjected.Address(RVA = "0x5EC83C0", Offset = "0x5EC6BC0", VA = "0x185EC83C0")]
	public int BOEFMMCLAAP(int LFEFGCGCIAG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C54")]
	[Cpp2IlInjected.Address(RVA = "0x5EC84F0", Offset = "0x5EC6CF0", VA = "0x185EC84F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C55")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8640", Offset = "0x5EC6E40", VA = "0x185EC8640")]
	private void LHJLFOMGANP(int MFNNOJAMHEP = 0)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200023B")]
public struct KOKANDCEHOA : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	public static readonly KOKANDCEHOA MHFKJLABGMI;

	[Cpp2IlInjected.Token(Token = "0x6000C56")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCDD0", Offset = "0x5ECB5D0", VA = "0x185ECCDD0", Slot = "4")]
	public bool Equals(LinkedEntityGroup IILAPOMEGLM, LinkedEntityGroup BNBBAPGFCCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C57")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCDF0", Offset = "0x5ECB5F0", VA = "0x185ECCDF0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup CBBCDNDPNHF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200023C")]
internal class AMBNOPDJOMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000C58")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public AMBNOPDJOMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023D")]
public struct HLDGGCFJEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000741")]
	public Entity KCMPKMKBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000742")]
	public Entity LGPCNJNBLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	public Entity KEDAAEKKLOL;

	[Cpp2IlInjected.Token(Token = "0x6000C59")]
	[Cpp2IlInjected.Address(RVA = "0x4243A40", Offset = "0x4242240", VA = "0x184243A40")]
	public HLDGGCFJEBG(Entity KCMPKMKBCOO, Entity LGPCNJNBLBP, Entity KEDAAEKKLOL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C5A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBB60", Offset = "0x5ECA360", VA = "0x185ECBB60")]
	public static HLDGGCFJEBG FEBAGKLNOCP((Entity entity, Entity oldParent, Entity newParent) OCANHHEFAKG)
	{
		return default(HLDGGCFJEBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBB80", Offset = "0x5ECA380", VA = "0x185ECBB80")]
	public void FFNFLPIKFMM([Out] Entity KCMPKMKBCOO, [Out] Entity LGPCNJNBLBP, [Out] Entity KEDAAEKKLOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023E")]
public struct LDDDAGKCJBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000744")]
	public Entity KCMPKMKBCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000745")]
	public Entity OBIIIBPBMLD;

	[Cpp2IlInjected.Token(Token = "0x6000C5C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDA380", Offset = "0x1FD8B80", VA = "0x181FDA380")]
	public LDDDAGKCJBG(Entity KCMPKMKBCOO, Entity OBIIIBPBMLD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C5D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCE50", Offset = "0x5ECB650", VA = "0x185ECCE50")]
	public static LDDDAGKCJBG FEBAGKLNOCP((Entity entity, Entity parent) OCANHHEFAKG)
	{
		return default(LDDDAGKCJBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCE70", Offset = "0x5ECB670", VA = "0x185ECCE70")]
	public void FFNFLPIKFMM([Out] Entity KCMPKMKBCOO, [Out] Entity OBIIIBPBMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023F")]
public struct HNPFIFEKIBI<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000746")]
	private GCHandle KPAMIOKBGLD;

	[Cpp2IlInjected.Token(Token = "0x6000C5F")]
	[Cpp2IlInjected.Address(RVA = "0x35A29A0", Offset = "0x35A11A0", VA = "0x1835A29A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000240")]
public enum PENJOANPPOE
{
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x4000749")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x2000241")]
public struct MPMDFMLEFEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	public PENJOANPPOE CBAOCALLDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	public int BENEDPIEKBK;

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x979D20", Offset = "0x978520", VA = "0x180979D20")]
	public MPMDFMLEFEP(PENJOANPPOE CBAOCALLDAL, int BENEDPIEKBK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x5DB93C0", Offset = "0x5DB7BC0", VA = "0x185DB93C0")]
	public static MPMDFMLEFEP FEBAGKLNOCP((PENJOANPPOE eventType, int eventIndex) IILAPOMEGLM)
	{
		return default(MPMDFMLEFEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF330", Offset = "0x5ECDB30", VA = "0x185ECF330")]
	public void FFNFLPIKFMM([Out] PENJOANPPOE CBAOCALLDAL, [Out] int BENEDPIEKBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000242")]
[DEONFKEHMJD(typeof(AHDBNGLCNFH), new string[] { })]
public sealed class MOEJLEMGAJF : AHDBNGLCNFH, GJOKPFDLDCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400074D")]
	private JPCLBEACHKO AGAOCMCEOAD;

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF240", Offset = "0x5ECDA40", VA = "0x185ECF240", Slot = "5")]
	public void InitReferences(HMNFMHNMJBH CJEADCONOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF290", Offset = "0x5ECDA90", VA = "0x185ECF290")]
	public bool MOPGPDCKDNJ([In] float3 DPIMNMEPENP, [In] float3 GJMNPFFBJPA, float LNHOFLIBFND, Allocator JONICLHJBEP, [Out] NativeArray<Entity> FAIFKAKJOPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public MOEJLEMGAJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF290", Offset = "0x5ECDA90", VA = "0x185ECF290", Slot = "4")]
	private bool NEGFMCDOMBH([In] float3 DPIMNMEPENP, [In] float3 GJMNPFFBJPA, float LNHOFLIBFND, Allocator JONICLHJBEP, [Out] NativeArray<Entity> FAIFKAKJOPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000243")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
public sealed class OAIFLKEGPKC : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF340", Offset = "0x5ECDB40", VA = "0x185ECF340", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public OAIFLKEGPKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000244")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal sealed class ECHPNEEKOIG : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6300", VA = "0x185EC7B00", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6A")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public ECHPNEEKOIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000245")]
internal class EEEKHPJPLDE : DCNNAKBCEBC
{
	[Cpp2IlInjected.Token(Token = "0x6000C6B")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public EEEKHPJPLDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000246")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal sealed class POFJGFDGKGJ : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000C6C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0620", Offset = "0x5ECEE20", VA = "0x185ED0620", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6D")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public POFJGFDGKGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000247")]
internal class GNIACCMICDK : HKBPHJBHAML
{
	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	protected override DBGBAOPKBDJ NMNNJJJNNDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x7D0D80", Offset = "0x7CF580", VA = "0x1807D0D80", Slot = "17")]
		get
		{
			return default(DBGBAOPKBDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBB10", Offset = "0x5ECA310", VA = "0x185ECBB10")]
	public GNIACCMICDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000248")]
[DMDOGFFEKFK(PJHIMKBCGDP.LoadInstance)]
internal sealed class PFJMFLGKEBK : PAOJLKNKBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000C70")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF540", Offset = "0x5ECDD40", VA = "0x185ECF540", Slot = "15")]
	protected override ComponentSystemBase ABBDPPGKKCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C71")]
	[Cpp2IlInjected.Address(RVA = "0x5E07AA0", Offset = "0x5E062A0", VA = "0x185E07AA0")]
	public PFJMFLGKEBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000249")]
[AHBEOEFJALG(typeof(CEFKKAMGNJB))]
public sealed class LFDGPAHGNGD : HINOMGJMKNG
{
	[Cpp2IlInjected.Token(Token = "0x6000C72")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCF80", Offset = "0x5ECB780", VA = "0x185ECCF80", Slot = "8")]
	protected override bool OEOFPBAGEJK(ReadOnlySpan<CEFKKAMGNJB> EGHGICGKMKC, DHNDNMFMONI GLLIFKANKFD, [Out] ReadOnlySpan<byte> KDMODAMJKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C73")]
	[Cpp2IlInjected.Address(RVA = "0x5ECCE80", Offset = "0x5ECB680", VA = "0x185ECCE80", Slot = "9")]
	protected override bool HFDKICJOFJH(int IFOEKNINMPE, Span<CEFKKAMGNJB> EGHGICGKMKC, [In] ReadOnlySpan<byte> KDMODAMJKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C74")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD080", Offset = "0x5ECB880", VA = "0x185ECD080")]
	public LFDGPAHGNGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024A")]
[AHBEOEFJALG(typeof(OAEOJOGLFPE))]
public sealed class GCLEDONNMGI : LHCHIFCBOCA
{
	[Cpp2IlInjected.Token(Token = "0x6000C75")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB7F0", Offset = "0x5EC9FF0", VA = "0x185ECB7F0", Slot = "8")]
	protected override bool OEOFPBAGEJK(ReadOnlySpan<OAEOJOGLFPE> EGHGICGKMKC, DHNDNMFMONI GLLIFKANKFD, [Out] ReadOnlySpan<byte> KDMODAMJKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C76")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB6F0", Offset = "0x5EC9EF0", VA = "0x185ECB6F0", Slot = "9")]
	protected override bool HFDKICJOFJH(int IFOEKNINMPE, Span<OAEOJOGLFPE> EGHGICGKMKC, [In] ReadOnlySpan<byte> KDMODAMJKPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C77")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB8F0", Offset = "0x5ECA0F0", VA = "0x185ECB8F0")]
	public GCLEDONNMGI()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200024B")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : DPPANEPAGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0890", Offset = "0x5ECF090", VA = "0x185ED0890", Slot = "6")]
		public sealed override void KOKMPMBBHDI(MAMGJDJIBCG ABCKGGDLEKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED19D0", Offset = "0x5ED01D0", VA = "0x185ED19D0", Slot = "4")]
		public sealed override void MCAEHMIINDF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200024C")]
internal class __UnmanagedPostProcessorOutput__3117703953
{
	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2C00", Offset = "0x5ED1400", VA = "0x185ED2C00")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024D")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3117703953
{
	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1BA0", Offset = "0x5ED03A0", VA = "0x185ED1BA0")]
	public static void HIBBMNNHLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1B90", Offset = "0x5ED0390", VA = "0x185ED1B90")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024E")]
internal class JAMHLIGLIFM : ContainerPropertyBag<HKHMICMPKOM>
{
	[Cpp2IlInjected.Token(Token = "0x200024F")]
	private class FFNCPPHKHDF : Property<HKHMICMPKOM, JNHCKHFIJLH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public override string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C7F")]
			[Cpp2IlInjected.Address(RVA = "0x5EC9AA0", Offset = "0x5EC82A0", VA = "0x185EC9AA0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public override bool BHLLMPIDEOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000C80")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9A60", Offset = "0x5EC8260", VA = "0x185EC9A60")]
		public FFNCPPHKHDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C82")]
		[Cpp2IlInjected.Address(RVA = "0x5D876F0", Offset = "0x5D85EF0", VA = "0x185D876F0", Slot = "14")]
		public override JNHCKHFIJLH GetValue(HKHMICMPKOM OKPDFALIJHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C83")]
		[Cpp2IlInjected.Address(RVA = "0x5D87710", Offset = "0x5D85F10", VA = "0x185D87710", Slot = "15")]
		public override void SetValue(HKHMICMPKOM OKPDFALIJHE, JNHCKHFIJLH FKKGMPDEPMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBBA0", Offset = "0x5ECA3A0", VA = "0x185ECBBA0")]
	public JAMHLIGLIFM()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000250")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0x5ED06F0", Offset = "0x5ECEEF0", VA = "0x185ED06F0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		[UnityEngine.Scripting.Preserve]
		public static void Initialize()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000251")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000C85")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0810", Offset = "0x5ECF010", VA = "0x185ED0810")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000252")]
public class CAANBFNPALO
{
	[Cpp2IlInjected.Token(Token = "0x6000C86")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public CAANBFNPALO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000253")]
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
