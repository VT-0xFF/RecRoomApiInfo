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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x228AB40", Offset = "0x2289F40", VA = "0x18228AB40")]
		public static AMOGJGPNFMH<T> CreateTemporarySingleton<T>(this EntityManager entityManager, T componentData) where T : struct, IComponentData
		{
			return default(AMOGJGPNFMH<T>);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct JCDHMMOHNDH : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ACCFGGIJBGE]
public static class BDKLCCDHFLO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8CE0", Offset = "0x5DC80E0", VA = "0x185DC8CE0")]
	static BDKLCCDHFLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x219D590", Offset = "0x219C990", VA = "0x18219D590")]
	public static void IMGNBILILIM<T>(T ABNGLIALIJA, T DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8800", Offset = "0x5DC7C00", VA = "0x185DC8800")]
	public static void IMGNBILILIM(FixedString32Bytes ABNGLIALIJA, string DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8BB0", Offset = "0x5DC7FB0", VA = "0x185DC8BB0")]
	public static void IMGNBILILIM(string ABNGLIALIJA, FixedString32Bytes DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8BF0", Offset = "0x5DC7FF0", VA = "0x185DC8BF0")]
	public static void IMGNBILILIM(FixedString64Bytes ABNGLIALIJA, string DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8880", Offset = "0x5DC7C80", VA = "0x185DC8880")]
	public static void IMGNBILILIM(string ABNGLIALIJA, FixedString64Bytes DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8B00", Offset = "0x5DC7F00", VA = "0x185DC8B00")]
	public static void IMGNBILILIM(FixedList32Bytes<int> ABNGLIALIJA, DDIEEABEINH DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC88E0", Offset = "0x5DC7CE0", VA = "0x185DC88E0")]
	public static void IMGNBILILIM(DDIEEABEINH ABNGLIALIJA, FixedList32Bytes<int> DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8C20", Offset = "0x5DC8020", VA = "0x185DC8C20")]
	public static void IMGNBILILIM(HKFFEEHJGKG ABNGLIALIJA, Vector3 DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D15210", Offset = "0x5D14610", VA = "0x185D15210")]
	public static void IMGNBILILIM(Vector3 ABNGLIALIJA, HKFFEEHJGKG DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8850", Offset = "0x5DC7C50", VA = "0x185DC8850")]
	public static void IMGNBILILIM(FBLGBAPJDBN ABNGLIALIJA, Vector4 DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D150E0", Offset = "0x5D144E0", VA = "0x185D150E0")]
	public static void IMGNBILILIM(Vector4 ABNGLIALIJA, FBLGBAPJDBN DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8850", Offset = "0x5DC7C50", VA = "0x185DC8850")]
	public static void IMGNBILILIM(FBLGBAPJDBN ABNGLIALIJA, Quaternion DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D150E0", Offset = "0x5D144E0", VA = "0x185D150E0")]
	public static void IMGNBILILIM(Quaternion ABNGLIALIJA, FBLGBAPJDBN DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DC87D0", Offset = "0x5DC7BD0", VA = "0x185DC87D0")]
	public static void IMGNBILILIM(HKFFEEHJGKG ABNGLIALIJA, float3 DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D15210", Offset = "0x5D14610", VA = "0x185D15210")]
	public static void IMGNBILILIM(float3 ABNGLIALIJA, HKFFEEHJGKG DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8830", Offset = "0x5DC7C30", VA = "0x185DC8830")]
	public static void IMGNBILILIM(FBLGBAPJDBN ABNGLIALIJA, float4 DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D150E0", Offset = "0x5D144E0", VA = "0x185D150E0")]
	public static void IMGNBILILIM(float4 ABNGLIALIJA, FBLGBAPJDBN DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8830", Offset = "0x5DC7C30", VA = "0x185DC8830")]
	public static void IMGNBILILIM(FBLGBAPJDBN ABNGLIALIJA, quaternion DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8C80", Offset = "0x5DC8080", VA = "0x185DC8C80")]
	public static void IMGNBILILIM(quaternion ABNGLIALIJA, FBLGBAPJDBN DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8AC0", Offset = "0x5DC7EC0", VA = "0x185DC8AC0")]
	public static void IMGNBILILIM(Entity ABNGLIALIJA, IDPKABMOPJP DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8C50", Offset = "0x5DC8050", VA = "0x185DC8C50")]
	public static void IMGNBILILIM(IDPKABMOPJP ABNGLIALIJA, Entity DCAHFNCPDMJ, GILPKIILCCE GCLEDKPLBKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal class DAIEJNMMDAH : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEDB0", Offset = "0x5DCE1B0", VA = "0x185DCEDB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEE60", Offset = "0x5DCE260", VA = "0x185DCEE60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public DAIEJNMMDAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[HLDCAJNGFIO(PIEFJKINJBJ.OMRoom)]
internal class MKKKABHFMJC : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private AEMGHLGPJFG FIIKOMCPPNK;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1420", Offset = "0x5DE0820", VA = "0x185DE1420", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1470", Offset = "0x5DE0870", VA = "0x185DE1470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public MKKKABHFMJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[UnityEngine.Scripting.Preserve]
internal class OGLEKMNNCFA : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private EntityQuery KBPJKHLIPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7BC0", Offset = "0x5DE6FC0", VA = "0x185DE7BC0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7C10", Offset = "0x5DE7010", VA = "0x185DE7C10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7CA0", Offset = "0x5DE70A0", VA = "0x185DE7CA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public OGLEKMNNCFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[HLDCAJNGFIO(PIEFJKINJBJ.OMRoom)]
internal class CIDMDBACPJL : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private AEMGHLGPJFG FIIKOMCPPNK;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9E90", Offset = "0x5DC9290", VA = "0x185DC9E90", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9EE0", Offset = "0x5DC92E0", VA = "0x185DC9EE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public CIDMDBACPJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[HLDCAJNGFIO(PIEFJKINJBJ.OMRoom)]
internal class PLIMPKEHNPL : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private JKDKKFNOEFN EOJANGPGAOF;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DE96F0", Offset = "0x5DE8AF0", VA = "0x185DE96F0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9740", Offset = "0x5DE8B40", VA = "0x185DE9740", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public PLIMPKEHNPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[UnityEngine.Scripting.Preserve]
internal sealed class PLDKDPICNCG<T> : EJPAANLNCMB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFD10", Offset = "0x3DFF110", VA = "0x183DFFD10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFF30", Offset = "0x3DFF330", VA = "0x183DFFF30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public PLDKDPICNCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[NDGCLKCPJNE]
public class OGFMEEFILEK : ComponentSystem, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private FJPIIIPDBML OAFBJOCEDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x75C520", Offset = "0x75B920", VA = "0x18075C520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x75C7C0", Offset = "0x75BBC0", VA = "0x18075C7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7B50", Offset = "0x5DE6F50", VA = "0x185DE7B50", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
	public OGFMEEFILEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class CDEFNOKPBCK : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9C90", Offset = "0x5DC9090", VA = "0x185DC9C90", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9C00", Offset = "0x5DC9000", VA = "0x185DC9C00")]
	[UnityEngine.Scripting.Preserve]
	private void HAFEIJIJJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public CDEFNOKPBCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class ALKJGGFDELM : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DC82A0", Offset = "0x5DC76A0", VA = "0x185DC82A0", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public ALKJGGFDELM()
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
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5DE91B0", Offset = "0x5DE85B0", VA = "0x185DE91B0")]
		public static ObjectModelConfigAsset HHLLJHDLJIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84D6E0", Offset = "0x84CAE0", VA = "0x18084D6E0")]
		public ObjectModelConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PONJECHEKMH
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9B80", Offset = "0x5DE8F80", VA = "0x185DE9B80")]
	public static void EPIBAEMNPOC(FBKCBHAMJJJ AMAPEJENOPH, string LLFNPGDAELN, LHNHNFAONOD JJCBAPGMGLL, Action AEJHJMKCFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9BE0", Offset = "0x5DE8FE0", VA = "0x185DE9BE0")]
	public static void EPIBAEMNPOC(FBKCBHAMJJJ AMAPEJENOPH, string LLFNPGDAELN, DLCLMIEPGBN ONJHPPEIKKC, Action AEJHJMKCFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9E20", Offset = "0x5DE9220", VA = "0x185DE9E20")]
	public static void HDOLJDFMGMA(FBKCBHAMJJJ AMAPEJENOPH, string LLFNPGDAELN, LHNHNFAONOD PIBFDGEOBKF, Exception LCLIHGHPJEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HEHJCCNAECA
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KPKAMMPEBMG
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class LKOGIJKPJJD
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly FBKCBHAMJJJ AMAPEJENOPH;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0D80", Offset = "0x5DE0180", VA = "0x185DE0D80")]
		public static IJFILFNCAOA EONAKLFOEMB(int JLNELLOKMDE, CPKPDFPLDCI GBFAADEABMD)
		{
			return default(IJFILFNCAOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5DE10E0", Offset = "0x5DE04E0", VA = "0x185DE10E0")]
		private static LHNHNFAONOD IHLGAPNFBGJ(CPKPDFPLDCI MOFDGECMMGD, LHNHNFAONOD KKEMBCNPGHA)
		{
			return default(LHNHNFAONOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0C00", Offset = "0x5DE0000", VA = "0x185DE0C00")]
		private static void DDGDPDKKIKB(LHNHNFAONOD CPMAPMAIDNB, LHNHNFAONOD DAPCBJFIEDA, IJFILFNCAOA JNPKHIBFGKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5DE09C0", Offset = "0x5DDFDC0", VA = "0x185DE09C0")]
		public static int ALFGLEGHIEF(GameObject IPAGFDLNMDK, JPGOBCIEAFB ONCMAHMIPJG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static BJOIGMMCCHE APDHDLPNIGG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static KENPJEONHPC EPKJOOEACNA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static KENPJEONHPC DHFHHKAKAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB180", Offset = "0x5DDA580", VA = "0x185DDB180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool CMAOGEMIKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAD30", Offset = "0x5DDA130", VA = "0x185DDAD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static FJPIIIPDBML OAFBJOCEDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB950", Offset = "0x5DDAD50", VA = "0x185DDB950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBAB0", Offset = "0x5DDAEB0", VA = "0x185DDBAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static AAJHNHAHHBB HELCAPEGHFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBA40", Offset = "0x5DDAE40", VA = "0x185DDBA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBCA0", Offset = "0x5DDB0A0", VA = "0x185DDBCA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static NMDHGCKCBIM IKJMCNLLEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBB20", Offset = "0x5DDAF20", VA = "0x185DDBB20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static PMPMJLEMOAG CENPIFCHHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5DDACC0", Offset = "0x5DDA0C0", VA = "0x185DDACC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool PELLJEJNJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB9D0", Offset = "0x5DDADD0", VA = "0x185DDB9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool PPAOINGNPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBB90", Offset = "0x5DDAF90", VA = "0x185DDBB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static FDLKIDLAABP PBPMJEHLHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB710", Offset = "0x5DDAB10", VA = "0x185DDB710")]
		get
		{
			return default(FDLKIDLAABP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool JPIPDMPPHHH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAF90", Offset = "0x5DDA390", VA = "0x185DDAF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static byte DBKDEBDEBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB800", Offset = "0x5DDAC00", VA = "0x185DDB800")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static byte AHMOKCLOEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7785F0", Offset = "0x7779F0", VA = "0x1807785F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool IPKDOAIDMHE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB900", Offset = "0x5DDAD00", VA = "0x185DDB900")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool MCBOAAKFGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB7B0", Offset = "0x5DDABB0", VA = "0x185DDB7B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB330", Offset = "0x5DDA730", VA = "0x185DDB330")]
	public static void FHJAEKNAOMH(BJOIGMMCCHE EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBBE0", Offset = "0x5DDAFE0", VA = "0x185DDBBE0")]
	public static LHNHNFAONOD OLOICJPHOFL(GameObject IPAGFDLNMDK)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB2B0", Offset = "0x5DDA6B0", VA = "0x185DDB2B0")]
	public static FDLKIDLAABP EBNIIIDFCKA(IJFILFNCAOA JNPKHIBFGKN)
	{
		return default(FDLKIDLAABP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB480", Offset = "0x5DDA880", VA = "0x185DDB480")]
	public static bool GCGEMFIPLCM(GameObject IPAGFDLNMDK, [Out] IJFILFNCAOA[] JNPKHIBFGKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAB80", Offset = "0x5DD9F80", VA = "0x185DDAB80")]
	public static ECHNGDHAHOM AKEOPOJABHA(IEnumerable<BDDINDDAOMP> JJAIIAGNJLG)
	{
		return default(ECHNGDHAHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAEA0", Offset = "0x5DDA2A0", VA = "0x185DDAEA0")]
	private static KENPJEONHPC BLBPBNHPFHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB5D0", Offset = "0x5DDA9D0", VA = "0x185DDB5D0")]
	private static bool GDLJJIMOMAM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CLHPOKGCCCG
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAA20", Offset = "0x5DC9E20", VA = "0x185DCAA20")]
	public static bool PNJKBCJBOBP(PCCDMPNJHHD AIFEBPNHJLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA350", Offset = "0x5DC9750", VA = "0x185DCA350")]
	public static PCCDMPNJHHD KIPDOAILNDA(GameObject IPAGFDLNMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA650", Offset = "0x5DC9A50", VA = "0x185DCA650")]
	public static PCCDMPNJHHD KIPDOAILNDA(GameObject IPAGFDLNMDK, IJFILFNCAOA JNPKHIBFGKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA800", Offset = "0x5DC9C00", VA = "0x185DCA800")]
	public static bool LNFHODGDBPA(GameObject OCEAKGFKBEH, string HFCKFJICBCH, bool GMBFPACDPNM)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DisembodiedObjectView : MonoBehaviour, COAMOALCCMA
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool MDIKGCAGGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7785F0", Offset = "0x7779F0", VA = "0x1807785F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public LHNHNFAONOD NJBGKNJCFAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(LHNHNFAONOD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD2B4E0", Offset = "0xD2A8E0", VA = "0x180D2B4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5DCF310", Offset = "0x5DCE710", VA = "0x185DCF310")]
		public void SetName(string LFAIHEECJFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public sealed class EmbodiedObject : MonoBehaviour, PCCDMPNJHHD, COAMOALCCMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly FBKCBHAMJJJ AMAPEJENOPH;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const string IPIIALEPCNK = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private FDKLFGADELG JEPPHOGINNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private LHNHNFAONOD GIPGBEGNLCD;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public LHNHNFAONOD NJBGKNJCFAM
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x5DD0880", Offset = "0x5DCFC80", VA = "0x185DD0880", Slot = "15")]
			get
			{
				return default(LHNHNFAONOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public FDLKIDLAABP LOMBCMGOCKG
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x5DD0930", Offset = "0x5DCFD30", VA = "0x185DD0930", Slot = "6")]
			get
			{
				return default(FDLKIDLAABP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool MDIKGCAGGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x5DD0870", Offset = "0x5DCFC70", VA = "0x185DD0870", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public FDKLFGADELG CGHLFPGKMMK
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x889620", Offset = "0x888A20", VA = "0x180889620", Slot = "7")]
			get
			{
				return default(FDKLFGADELG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private GNGBPCPDDMI OHMNMMPCAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5DCFE60", Offset = "0x5DCF260", VA = "0x185DCFE60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool BOHFIPBHPDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7CAC20", Offset = "0x7CA020", VA = "0x1807CAC20", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x882360", Offset = "0x881760", VA = "0x180882360", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action<EmbodiedObject, bool> PMNGLOIFENN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5DD0760", Offset = "0x5DCFB60", VA = "0x185DD0760")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5DD0AA0", Offset = "0x5DCFEA0", VA = "0x185DD0AA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> IPMBKJIFDOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5DD0600", Offset = "0x5DCFA00", VA = "0x185DD0600")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5DD0940", Offset = "0x5DCFD40", VA = "0x185DD0940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<PCCDMPNJHHD> LKGDLFIICDC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x5DD06B0", Offset = "0x5DCFAB0", VA = "0x185DD06B0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5DD09F0", Offset = "0x5DCFDF0", VA = "0x185DD09F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFC80", Offset = "0x5DCF080", VA = "0x185DCFC80")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0440", Offset = "0x5DCF840", VA = "0x185DD0440", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFFF0", Offset = "0x5DCF3F0", VA = "0x185DCFFF0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0390", Offset = "0x5DCF790", VA = "0x185DD0390", Slot = "10")]
		public void OnEmbody(IMHPKNCJCOD MOIDEPLOCKC, LHNHNFAONOD GIPGBEGNLCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0430", Offset = "0x5DCF830", VA = "0x185DD0430", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0230", Offset = "0x5DCF630", VA = "0x185DD0230", Slot = "12")]
		public void OnDisembody(bool EOAMIPFFDKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFF10", Offset = "0x5DCF310", VA = "0x185DCFF10")]
		private void OPDKJGGDBIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5DCFED0", Offset = "0x5DCF2D0", VA = "0x185DCFED0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AD80", VA = "0x180A2B980", Slot = "9")]
		private GameObject HOMJMDOGIPC()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x75E5A0", Offset = "0x75D9A0", VA = "0x18075E5A0")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleComponent]
	public class NetworkedTransformEntity : MonoBehaviour, COAMOALCCMA
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly FBKCBHAMJJJ AMAPEJENOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private JMFEOGDEHDH prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private EntityBundlePartId entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private LHNHNFAONOD PIBFDGEOBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool CLIMOBJOFJB;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public JMFEOGDEHDH PFOBMBLEGKO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x75F130", Offset = "0x75E530", VA = "0x18075F130")]
			get
			{
				return default(JMFEOGDEHDH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public EntityBundlePartId PDKOPJKDKDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x785BA0", Offset = "0x784FA0", VA = "0x180785BA0")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool MDIKGCAGGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7CAC20", Offset = "0x7CA020", VA = "0x1807CAC20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public LHNHNFAONOD NJBGKNJCFAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "5")]
			get
			{
				return default(LHNHNFAONOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private INHGBAEAGHP JJDEFEEBFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5DE6D20", Offset = "0x5DE6120", VA = "0x185DE6D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private KFJHDAOPGPA GHHBICFAIFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5DE6CA0", Offset = "0x5DE60A0", VA = "0x185DE6CA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6D30", Offset = "0x5DE6130", VA = "0x185DE6D30")]
		public void OnEmbody(LHNHNFAONOD PIBFDGEOBKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6D40", Offset = "0x5DE6140", VA = "0x185DE6D40")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6EB0", Offset = "0x5DE62B0", VA = "0x185DE6EB0")]
		public NetworkedTransformEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DisallowMultipleComponent]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override JMFEOGDEHDH PFOBMBLEGKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5DEA090", Offset = "0x5DE9490", VA = "0x185DEA090", Slot = "6")]
			get
			{
				return default(JMFEOGDEHDH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA040", Offset = "0x5DE9440", VA = "0x185DEA040")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[DisallowMultipleComponent]
	public class TransformEntity : MonoBehaviour, COAMOALCCMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly FBKCBHAMJJJ AMAPEJENOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private JMFEOGDEHDH prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private LHNHNFAONOD PIBFDGEOBKF;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual JMFEOGDEHDH PFOBMBLEGKO
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x75F130", Offset = "0x75E530", VA = "0x18075F130", Slot = "6")]
			get
			{
				return default(JMFEOGDEHDH);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x769410", Offset = "0x768810", VA = "0x180769410", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public LHNHNFAONOD NJBGKNJCFAM
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x3117440", Offset = "0x3116840", VA = "0x183117440", Slot = "5")]
			get
			{
				return default(LHNHNFAONOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool MDIKGCAGGPK
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1026DB0", Offset = "0x10261B0", VA = "0x181026DB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1026DC0", Offset = "0x10261C0", VA = "0x181026DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal Entity PEHFADPIEPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5DEA130", Offset = "0x5DE9530", VA = "0x185DEA130")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal INHGBAEAGHP JJDEFEEBFNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x5DEA620", Offset = "0x5DE9A20", VA = "0x185DEA620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal KFJHDAOPGPA GHHBICFAIFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5DEA0B0", Offset = "0x5DE94B0", VA = "0x185DEA0B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA0A0", Offset = "0x5DE94A0", VA = "0x185DEA0A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA530", Offset = "0x5DE9930", VA = "0x185DEA530")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA150", Offset = "0x5DE9550", VA = "0x185DEA150")]
		internal void FGBNJEBGKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA460", Offset = "0x5DE9860", VA = "0x185DEA460")]
		private bool FHPOFDEEHFA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA500", Offset = "0x5DE9900", VA = "0x185DEA500")]
		private void MKLBJENBGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA530", Offset = "0x5DE9930", VA = "0x185DEA530")]
		internal void NPAMHCDPFNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA630", Offset = "0x5DE9A30", VA = "0x185DEA630")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA740", Offset = "0x5DE9B40", VA = "0x185DEA740")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[OPLOBPDEFMG(typeof(FDFCIENILNM))]
[PNAJALIKCOM(typeof(KENPJEONHPC), new string[] { })]
[OPLOBPDEFMG(typeof(FDJDNGGEHIB))]
public class ONEMJGFJLGK : KENPJEONHPC, PMEJGPCHMNC, FDJDNGGEHIB, IDisposable, FDFCIENILNM
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly ProfilerMarker KBCOEDPIIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private BJOIGMMCCHE NKEGKJEJLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private GNGBPCPDDMI LCDKABNLFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NBIPELNFGHB MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private ALLMMPKGJCM PNLDKELMCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public BJOIGMMCCHE OAFBJOCEDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public NBIPELNFGHB KOHEIAADMPK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public ALLMMPKGJCM DFHLBFHMNHH
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C80", Offset = "0x7B1080", VA = "0x1807B1C80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public PLGBKBNKNDI KPAPLDAGLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8124C0", Offset = "0x8118C0", VA = "0x1808124C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(PLGBKBNKNDI);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8124D0", Offset = "0x8118D0", VA = "0x1808124D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool FGAOPKACOEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xDD6E60", Offset = "0xDD6260", VA = "0x180DD6E60", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1C45CB0", Offset = "0x1C450B0", VA = "0x181C45CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LIODKINLCHA AMMFAOAPGAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7DBA00", Offset = "0x7DAE00", VA = "0x1807DBA00", Slot = "10")]
		get
		{
			return default(LIODKINLCHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8880", Offset = "0x5DE7C80", VA = "0x185DE8880", Slot = "14")]
	private void JJNCHAEJAAK(bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE85A0", Offset = "0x5DE79A0", VA = "0x185DE85A0")]
	public static ONEMJGFJLGK EECJKDKEFDC(BJOIGMMCCHE NKEGKJEJLFE, HHLFDCEHHDJ JGMEFAHDHAJ = HHLFDCEHHDJ.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void CKDGLMPFHNJ(BJOIGMMCCHE NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void OKPFFABAKLD(BJOIGMMCCHE NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8AE0", Offset = "0x5DE7EE0", VA = "0x185DE8AE0", Slot = "11")]
	public void LCOGFKBGGFM(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xBFE1A0", Offset = "0xBFD5A0", VA = "0x180BFE1A0")]
	private void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8750", Offset = "0x5DE7B50", VA = "0x185DE8750")]
	private void HKGPDMNJGPD(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8510", Offset = "0x5DE7910", VA = "0x185DE8510", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public ONEMJGFJLGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class IDCJNLNAIEN
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[Flags]
public enum HHLFDCEHHDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	ExcludeAssemblyCSharp = 4,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	IncludeMock = 8,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	IncludeEditor = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[PNAJALIKCOM(typeof(ALLMMPKGJCM), new string[] { })]
public class JCPHOLJBHAK : ALLMMPKGJCM, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly FBKCBHAMJJJ CIFNBGDOCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private BJOIGMMCCHE NKEGKJEJLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private FDFCIENILNM HNPMBIEFGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private NBIPELNFGHB MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private KENPJEONHPC EPKJOOEACNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NBCENCLEOLD AMEPNDNNGNC;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool FIJAEMDLBNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7E50", Offset = "0x5DD7250", VA = "0x185DD7E50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action DDCAGJFPANI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5DD80A0", Offset = "0x5DD74A0", VA = "0x185DD80A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7EC0", Offset = "0x5DD72C0", VA = "0x185DD7EC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8140", Offset = "0x5DD7540", VA = "0x185DD8140", Slot = "12")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7C60", Offset = "0x5DD7060", VA = "0x185DD7C60", Slot = "6")]
	public void AAOCABPFAHD(bool BDDLEBIAAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8220", Offset = "0x5DD7620", VA = "0x185DD8220", Slot = "7")]
	public bool PEHEHLEHJFM(ByteString EGFEGIMIICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8210", Offset = "0x5DD7610", VA = "0x185DD8210", Slot = "11")]
	public void LDMIFEDAPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1669520", Offset = "0x1668920", VA = "0x181669520", Slot = "9")]
	public void CCGGMHJMGHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7F60", Offset = "0x5DD7360", VA = "0x185DD7F60", Slot = "10")]
	public void FJCEJCMDELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public JCPHOLJBHAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class EGFFGHADFBP<T> : MNDJINKEOKO<T>, MGPJIDJKJFM<IJFILFNCAOA, T>, CMHIFLHHMKA<IJFILFNCAOA>, BAPMFMKMMNM, IDisposable, IELJJLAMLND where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly CMHIFLHHMKA<Entity> ANNDMLIIDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Delegate CNNBOLCGFAE;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string PCDEPGOAGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x304E270", Offset = "0x304D670", VA = "0x18304E270", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Type EANPJBEPKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x304AF20", Offset = "0x304A320", VA = "0x18304AF20", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public GLNELICFCEC MBPOBGFPGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x304B620", Offset = "0x304AA20", VA = "0x18304B620", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int BLNOGHNAOED
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x304B120", Offset = "0x304A520", VA = "0x18304B120", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CCFLNCABIJL FDKFEEBLCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x304CBF0", Offset = "0x304BFF0", VA = "0x18304CBF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event LNAAJLDGHKN<IJFILFNCAOA> NPLJOKABGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x304CFF0", Offset = "0x304C3F0", VA = "0x18304CFF0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x304B2D0", Offset = "0x304A6D0", VA = "0x18304B2D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3050090", Offset = "0x304F490", VA = "0x183050090")]
	public EGFFGHADFBP(CMHIFLHHMKA<Entity> ANNDMLIIDLL, INHGBAEAGHP NMNJDGCCMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x304E000", Offset = "0x304D400", VA = "0x18304E000")]
	private Entity IKKPPLEJDBO(IJFILFNCAOA JNPKHIBFGKN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x304DED0", Offset = "0x304D2D0", VA = "0x18304DED0")]
	private IJFILFNCAOA IKKPPLEJDBO(Entity FILKDLNBIJH)
	{
		return default(IJFILFNCAOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x304F020", Offset = "0x304E420", VA = "0x18304F020", Slot = "4")]
	public T OPODPAEFLEB(IJFILFNCAOA JNPKHIBFGKN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x304D430", Offset = "0x304C830", VA = "0x18304D430")]
	public bool GMFKOPHMECD(IJFILFNCAOA JNPKHIBFGKN, [In] T BDDLEBIAAAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x304A090", Offset = "0x3049490", VA = "0x18304A090", Slot = "7")]
	public bool AOKIEGPHIBB(IJFILFNCAOA JNPKHIBFGKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x304E680", Offset = "0x304DA80", VA = "0x18304E680", Slot = "8")]
	public void OPODPAEFLEB(IJFILFNCAOA JNPKHIBFGKN, KOKEBPMKNGL EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x304D820", Offset = "0x304CC20", VA = "0x18304D820", Slot = "9")]
	public bool GMFKOPHMECD(IJFILFNCAOA JNPKHIBFGKN, IBIHAHCALHC BDDLEBIAAAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x304E310", Offset = "0x304D710", VA = "0x18304E310", Slot = "16")]
	public void JMFFMJPABFF(AIBPBKLFHPF PLEDLHLLCJI, [Optional] object FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x304D2A0", Offset = "0x304C6A0", VA = "0x18304D2A0", Slot = "10")]
	public bool GFOOEPCPPKC(IJFILFNCAOA DCAHFNCPDMJ, IJFILFNCAOA ABNGLIALIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x304D0A0", Offset = "0x304C4A0", VA = "0x18304D0A0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x304FFE0", Offset = "0x304F3E0", VA = "0x18304FFE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x304A7D0", Offset = "0x3049BD0", VA = "0x18304A7D0")]
	private void BOGKAAAKDPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x304F520", Offset = "0x304E920", VA = "0x18304F520")]
	private void PJBLOCJBJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x304BED0", Offset = "0x304B2D0", VA = "0x18304BED0")]
	private void DIEJECBKFML(Entity FILKDLNBIJH, [In] IBIHAHCALHC LEMLHJJLMCO, [In] IBIHAHCALHC BDDLEBIAAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x304A020", Offset = "0x3049420", VA = "0x18304A020")]
	private void ANDCECJBEJF(Entity FILKDLNBIJH, [In] IBIHAHCALHC LEMLHJJLMCO, [In] IBIHAHCALHC BDDLEBIAAAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class GMNCHCCNINB<T> : LJLPBCHNEGF<T>, MGPJIDJKJFM<LHNHNFAONOD, T>, CMHIFLHHMKA<LHNHNFAONOD>, BAPMFMKMMNM, IDisposable, ADLHMGAHKNA where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly CMHIFLHHMKA<Entity> ANNDMLIIDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private Delegate CNNBOLCGFAE;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string PCDEPGOAGDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x34E1CF0", Offset = "0x34E10F0", VA = "0x1834E1CF0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Type EANPJBEPKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x34D8DF0", Offset = "0x34D81F0", VA = "0x1834D8DF0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public GLNELICFCEC MBPOBGFPGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x34DA150", Offset = "0x34D9550", VA = "0x1834DA150", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int BLNOGHNAOED
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x34D8FD0", Offset = "0x34D83D0", VA = "0x1834D8FD0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public CCFLNCABIJL FDKFEEBLCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x34DE350", Offset = "0x34DD750", VA = "0x1834DE350", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event LNAAJLDGHKN<LHNHNFAONOD> NPLJOKABGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x34DEE40", Offset = "0x34DE240", VA = "0x1834DEE40", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x34D9A00", Offset = "0x34D8E00", VA = "0x1834D9A00", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3050090", Offset = "0x304F490", VA = "0x183050090")]
	public GMNCHCCNINB(CMHIFLHHMKA<Entity> ANNDMLIIDLL, INHGBAEAGHP NMNJDGCCMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x34E1B80", Offset = "0x34E0F80", VA = "0x1834E1B80")]
	private Entity IKKPPLEJDBO(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x34E1B50", Offset = "0x34E0F50", VA = "0x1834E1B50")]
	private LHNHNFAONOD IKKPPLEJDBO(Entity FILKDLNBIJH)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x34E3070", Offset = "0x34E2470", VA = "0x1834E3070", Slot = "4")]
	public T OPODPAEFLEB(LHNHNFAONOD PIBFDGEOBKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x34E0940", Offset = "0x34DFD40", VA = "0x1834E0940")]
	public bool GMFKOPHMECD(LHNHNFAONOD PIBFDGEOBKF, [In] T BDDLEBIAAAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x34D6AF0", Offset = "0x34D5EF0", VA = "0x1834D6AF0", Slot = "7")]
	public bool AOKIEGPHIBB(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x34E2EC0", Offset = "0x34E22C0", VA = "0x1834E2EC0", Slot = "8")]
	public void OPODPAEFLEB(LHNHNFAONOD PIBFDGEOBKF, KOKEBPMKNGL EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x34E0FB0", Offset = "0x34E03B0", VA = "0x1834E0FB0", Slot = "9")]
	public bool GMFKOPHMECD(LHNHNFAONOD PIBFDGEOBKF, IBIHAHCALHC BDDLEBIAAAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x304E310", Offset = "0x304D710", VA = "0x18304E310", Slot = "16")]
	public void JMFFMJPABFF(AIBPBKLFHPF PLEDLHLLCJI, [Optional] object FJHKACIMEOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x34DF4D0", Offset = "0x34DE8D0", VA = "0x1834DF4D0", Slot = "10")]
	public bool GFOOEPCPPKC(LHNHNFAONOD DCAHFNCPDMJ, LHNHNFAONOD ABNGLIALIJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x34D7230", Offset = "0x34D6630", VA = "0x1834D7230")]
	private void BOGKAAAKDPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x34E5F30", Offset = "0x34E5330", VA = "0x1834E5F30")]
	private void PJBLOCJBJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x34DA380", Offset = "0x34D9780", VA = "0x1834DA380")]
	private void DIEJECBKFML(Entity FILKDLNBIJH, [In] IBIHAHCALHC LEMLHJJLMCO, [In] IBIHAHCALHC BDDLEBIAAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x34D6260", Offset = "0x34D5660", VA = "0x1834D6260")]
	private void ANDCECJBEJF(Entity FILKDLNBIJH, [In] IBIHAHCALHC LEMLHJJLMCO, [In] IBIHAHCALHC BDDLEBIAAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x34DF1B0", Offset = "0x34DE5B0", VA = "0x1834DF1B0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x34E7030", Offset = "0x34E6430", VA = "0x1834E7030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OOAAPMGBCFK : IPLKNLMFFDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class AFFMCFKPDLE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int IDEEPCEAJIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CA610", Offset = "0x7C9A10", VA = "0x1807CA610", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> ODCBGEMHLPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA9D400", Offset = "0xA9C800", VA = "0x180A9D400", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8CF0", Offset = "0x5DE80F0", VA = "0x185DE8CF0", Slot = "6")]
	public LHNHNFAONOD EDHDCECNBEG(LHNHNFAONOD GAKOOBMLEII)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public OOAAPMGBCFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NIBEAPHAFFJ : IPLKNLMFFDP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> DFBOKBMDDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int BCLBGCAIGLO;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> ODCBGEMHLPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA9D400", Offset = "0xA9C800", VA = "0x180A9D400", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int IDEEPCEAJIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8124E0", Offset = "0x8118E0", VA = "0x1808124E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3BFCC40", Offset = "0x3BFC040", VA = "0x183BFCC40")]
	public NIBEAPHAFFJ(NativeArray<EntityRemapUtility.EntityRemapInfo> DFBOKBMDDPM, int BCLBGCAIGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2E30", Offset = "0x5DE2230", VA = "0x185DE2E30", Slot = "6")]
	public LHNHNFAONOD EDHDCECNBEG(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2EB0", Offset = "0x5DE22B0", VA = "0x185DE2EB0", Slot = "8")]
	public LocalId EDHDCECNBEG(LocalId FILKDLNBIJH)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2DD0", Offset = "0x5DE21D0", VA = "0x185DE2DD0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
[PNAJALIKCOM(typeof(EKKHKJDOOEK), new string[] { "Editor" })]
public sealed class EKKHKJDOOEK
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate void DLHFNJHDOIH(IJFILFNCAOA AJLJLPIIIFD, EIDGNLJLKDK GHFAAPNAFDE, bool LBGPACJHGBI);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate void GKNDKIPPLJG(IJFILFNCAOA AJLJLPIIIFD, bool LBGPACJHGBI);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate void OKPMJMAMADH(IJFILFNCAOA AJLJLPIIIFD, EAAMNLEDMLN ANNDMLIIDLL, [In] IBIHAHCALHC EOHMJBFGDPD, bool LBGPACJHGBI);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public EKKHKJDOOEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum OAHNCEDJNNM
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	Main = 2,
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	Load = 4,
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	NetworkReceive = 8,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Suppressed = 0x10
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
[PNAJALIKCOM(typeof(LKEFCEFOADP), new string[] { "Editor" })]
public sealed class LKEFCEFOADP
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void NKICBPCPPDG(IJFILFNCAOA JNPKHIBFGKN, EIDGNLJLKDK GHFAAPNAFDE, OAHNCEDJNNM JGMEFAHDHAJ);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate void IONHEOCGPMI(IJFILFNCAOA JNPKHIBFGKN, OAHNCEDJNNM JGMEFAHDHAJ);

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate void HLCJFJPIBIM(IJFILFNCAOA JNPKHIBFGKN, EAAMNLEDMLN ANNDMLIIDLL, IBIHAHCALHC DIPNGLKFBLA, IBIHAHCALHC GBMOELLOINK, OAHNCEDJNNM JGMEFAHDHAJ);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public delegate void JPLONBEKIEE(OCNDOGNDAKK DGCJCBHPPBD, ReadOnlySpan<byte> HEFGEKEDAKE);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LKEFCEFOADP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[PNAJALIKCOM(typeof(PMPMJLEMOAG), new string[] { })]
internal class OHBEMHDIAEB : PMPMJLEMOAG, JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private enum Flag
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Allowed,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		AllowedInRoomV1,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		RoomUpgrade,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Clone,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Copy,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Undo,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		UndoCreation,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Physics,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		SerializationV4,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		HierarchyViewVisible,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		InventionLoading,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		RoomSaving,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		RoomPublishing
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class IFNAKIIKAID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public IFNAKIIKAID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7630", Offset = "0x5DD6A30", VA = "0x185DD7630")]
		internal object ECLIOIJCCIJ((string name, bool value) a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[MFFAOKEGCNH]
	private JHAPJOBBFII MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[MFFAOKEGCNH]
	private FDJDNGGEHIB EGKJFJONNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeBitArray CNACOCMPEDM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DJCLMCCBNGM GMFGGIPNMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7DD0", Offset = "0x5DE71D0", VA = "0x185DE7DD0", Slot = "4")]
		get
		{
			return default(DJCLMCCBNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public DJCLMCCBNGM PMCLJDDACFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE82F0", Offset = "0x5DE76F0", VA = "0x185DE82F0", Slot = "5")]
		get
		{
			return default(DJCLMCCBNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public DJCLMCCBNGM BJDGLOACJDI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE83A0", Offset = "0x5DE77A0", VA = "0x185DE83A0", Slot = "6")]
		get
		{
			return default(DJCLMCCBNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public DJCLMCCBNGM GFOOEPCPPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7F10", Offset = "0x5DE7310", VA = "0x185DE7F10", Slot = "7")]
		get
		{
			return default(DJCLMCCBNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public DJCLMCCBNGM GJHBAHDGHAC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7CF0", Offset = "0x5DE70F0", VA = "0x185DE7CF0", Slot = "8")]
		get
		{
			return default(DJCLMCCBNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public DJCLMCCBNGM PEEABEPDGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7CE0", Offset = "0x5DE70E0", VA = "0x185DE7CE0", Slot = "9")]
		get
		{
			return default(DJCLMCCBNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public DJCLMCCBNGM ELKECBPOJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8170", Offset = "0x5DE7570", VA = "0x185DE8170", Slot = "10")]
		get
		{
			return default(DJCLMCCBNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public DJCLMCCBNGM CBLEMNAMGBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7D10", Offset = "0x5DE7110", VA = "0x185DE7D10", Slot = "11")]
		get
		{
			return default(DJCLMCCBNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public DJCLMCCBNGM NCLGNNCBIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7D00", Offset = "0x5DE7100", VA = "0x185DE7D00", Slot = "12")]
		get
		{
			return default(DJCLMCCBNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public DJCLMCCBNGM CCDBGLNJIEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5DE82E0", Offset = "0x5DE76E0", VA = "0x185DE82E0", Slot = "13")]
		get
		{
			return default(DJCLMCCBNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public DJCLMCCBNGM CGIINMFIJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8390", Offset = "0x5DE7790", VA = "0x185DE8390", Slot = "14")]
		get
		{
			return default(DJCLMCCBNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public DJCLMCCBNGM CNPGAFNAFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7EE0", Offset = "0x5DE72E0", VA = "0x185DE7EE0", Slot = "15")]
		get
		{
			return default(DJCLMCCBNGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private int AGEMLEFNGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7DF0", Offset = "0x5DE71F0", VA = "0x185DE7DF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8180", Offset = "0x5DE7580", VA = "0x185DE8180", Slot = "16")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7D20", Offset = "0x5DE7120", VA = "0x185DE7D20", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7E90", Offset = "0x5DE7290", VA = "0x185DE7E90")]
	private void FCNLECCJLGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7F20", Offset = "0x5DE7320", VA = "0x185DE7F20")]
	private void IINIPNGACLA(Flag MIIJFFOGLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8310", Offset = "0x5DE7710", VA = "0x185DE8310")]
	private DJCLMCCBNGM LLLFOPKBLPJ(Flag MIIJFFOGLNG)
	{
		return default(DJCLMCCBNGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7EF0", Offset = "0x5DE72F0", VA = "0x185DE7EF0")]
	private DJCLMCCBNGM FJDALFGIHGB(Flag MIIJFFOGLNG)
	{
		return default(DJCLMCCBNGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public OHBEMHDIAEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
[PNAJALIKCOM(typeof(NFJDCGPFACM), new string[] { })]
internal class NFJDCGPFACM : CNJKPBKICBD
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2D80", Offset = "0x5DE2180", VA = "0x185DE2D80", Slot = "4")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public NFJDCGPFACM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(GEBNHBIGGAG), new string[] { })]
internal class GEBNHBIGGAG : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly FBKCBHAMJJJ EGAONLFOHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[MFFAOKEGCNH]
	private MJMAOFFIBEJ MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[MFFAOKEGCNH]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[MFFAOKEGCNH]
	private KFJHDAOPGPA IHBAGGIDMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NBCENCLEOLD AMEPNDNNGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private EntityQuery BDMIENIHDBE;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5DD35F0", Offset = "0x5DD29F0", VA = "0x185DD35F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5DD29F0", Offset = "0x5DD1DF0", VA = "0x185DD29F0", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1E00", Offset = "0x5DD1200", VA = "0x185DD1E00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1640", Offset = "0x5DD0A40", VA = "0x185DD1640")]
	public ECHNGDHAHOM AKEOPOJABHA(IEnumerable<BDDINDDAOMP> DKAPOIBLGNG)
	{
		return default(ECHNGDHAHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2890", Offset = "0x5DD1C90", VA = "0x185DD2890")]
	private static bool IFLGLBCCBMA(BDDINDDAOMP PLGCCHMKBMF, [Out] IJFILFNCAOA[] OMNMPNPKGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2D10", Offset = "0x5DD2110", VA = "0x185DD2D10")]
	private ECHNGDHAHOM JOOMGIIKFLF(IEnumerable<BDDINDDAOMP> DKAPOIBLGNG)
	{
		return default(ECHNGDHAHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1740", Offset = "0x5DD0B40", VA = "0x185DD1740")]
	private (List<BDDINDDAOMP>, int[], int) BPHHCKMJBAJ(IEnumerable<BDDINDDAOMP> DKAPOIBLGNG)
	{
		return default((List<BDDINDDAOMP>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2C50", Offset = "0x5DD2050", VA = "0x185DD2C50")]
	private Dictionary<IJFILFNCAOA, (BDDINDDAOMP, int)> JFDDGEDGMIN(IEnumerable<BDDINDDAOMP> DKAPOIBLGNG, Entity OCHAIMMHCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3640", Offset = "0x5DD2A40", VA = "0x185DD3640")]
	private void NNCLNHEKJFN(Dictionary<IJFILFNCAOA, (BDDINDDAOMP request, int srcIndex)> DGBALLFIAMH, IEnumerable<BDDINDDAOMP> DKAPOIBLGNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3C50", Offset = "0x5DD3050", VA = "0x185DD3C50")]
	private void OLKKNEPGLFC(Dictionary<IJFILFNCAOA, (BDDINDDAOMP request, int srcIndex)> DGBALLFIAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1E10", Offset = "0x5DD1210", VA = "0x185DD1E10")]
	private void EICEABNHPDB(Dictionary<IJFILFNCAOA, (BDDINDDAOMP request, int srcIndex)> DGBALLFIAMH, IJFILFNCAOA JNPKHIBFGKN, string LFAIHEECJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3200", Offset = "0x5DD2600", VA = "0x185DD3200")]
	private void KIHHBFMHAHO(Dictionary<IJFILFNCAOA, (BDDINDDAOMP request, int srcIndex)> DGBALLFIAMH, Entity OCHAIMMHCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1260", Offset = "0x5DD0660", VA = "0x185DD1260")]
	private (List<BDDINDDAOMP>, int[], int) AAPPKCFBABH(Dictionary<IJFILFNCAOA, (BDDINDDAOMP request, int srcIndex)> DGBALLFIAMH, Entity OCHAIMMHCFI)
	{
		return default((List<BDDINDDAOMP>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1B10", Offset = "0x5DD0F10", VA = "0x185DD1B10")]
	private void CNOAIIPJMPM(Dictionary<IJFILFNCAOA, (BDDINDDAOMP request, int srcIndex)> DGBALLFIAMH, List<BDDINDDAOMP> NKKJEMAJNDK, int[] CCKFOKMIHFC, NativeArray<Entity> BAPHNAADJCK, NativeList<IJFILFNCAOA> OMNMPNPKGPB, NativeList<Entity> JOPINHPDIJL, Entity OCHAIMMHCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3F80", Offset = "0x5DD3380", VA = "0x185DD3F80")]
	private static bool PFEDBJCDJHA(Entity FILKDLNBIJH, ComponentDataFromEntity<ParentData> KHKBGDEADFM, Entity OCHAIMMHCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2520", Offset = "0x5DD1920", VA = "0x185DD2520")]
	private void HIHPNMLEIHE(Dictionary<IJFILFNCAOA, (BDDINDDAOMP request, int srcIndex)> DGBALLFIAMH, List<BDDINDDAOMP> NKKJEMAJNDK, int[] CCKFOKMIHFC, NativeList<Entity> JOPINHPDIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2300", Offset = "0x5DD1700", VA = "0x185DD2300")]
	private NativeList<IJFILFNCAOA> GPKPJEAHMON(Dictionary<IJFILFNCAOA, (BDDINDDAOMP request, int srcIndex)> DGBALLFIAMH)
	{
		return default(NativeList<IJFILFNCAOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1940", Offset = "0x5DD0D40", VA = "0x185DD1940")]
	private NativeArray<Entity> CDIHOFHGNKN(NativeList<IJFILFNCAOA> OMNMPNPKGPB)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3B30", Offset = "0x5DD2F30", VA = "0x185DD3B30")]
	private static void NOHJPKGDKOB(Dictionary<IJFILFNCAOA, (BDDINDDAOMP request, int srcIndex)> DGBALLFIAMH, IJFILFNCAOA JNPKHIBFGKN, BDDINDDAOMP PLGCCHMKBMF, string LFAIHEECJFK, int OILGCPNOMDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3EC0", Offset = "0x5DD32C0", VA = "0x185DD3EC0")]
	private void PEBGDPOPJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GEBNHBIGGAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[PNAJALIKCOM(typeof(LPPICMFAKHE), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
internal class LPPICMFAKHE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	public void FLPDJNDEAKH(string LFAIHEECJFK, EntityManager OKJDPAMBACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LPPICMFAKHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[PNAJALIKCOM(typeof(NBCENCLEOLD), new string[] { })]
[OPLOBPDEFMG(typeof(GHNPFMHIOKA))]
internal class GHNPFMHIOKA : NBCENCLEOLD, IDisposable, JAKEGKENGGK, FFMIIDAKNCD
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly FBKCBHAMJJJ CIFNBGDOCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[MFFAOKEGCNH]
	private NBIPELNFGHB MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[MFFAOKEGCNH]
	private ALLMMPKGJCM PNLDKELMCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[MFFAOKEGCNH]
	private ADMBLJAMLBN FBIIJDILOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private KENPJEONHPC EPKJOOEACNA;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool FPJCFLLIABA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C80", Offset = "0x7B1080", VA = "0x1807B1C80", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CB0", Offset = "0x7B10B0", VA = "0x1807B1CB0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool LHIKIAAGGHO
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x10D8770", Offset = "0x10D7B70", VA = "0x1810D8770", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool FCMHLDLKONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8124C0", Offset = "0x8118C0", VA = "0x1808124C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8124D0", Offset = "0x8118D0", VA = "0x1808124D0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public CPKPDFPLDCI IHADLJLAJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x75C7E0", Offset = "0x75BBE0", VA = "0x18075C7E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x75C520", Offset = "0x75B920", VA = "0x18075C520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4AC0", Offset = "0x5DD3EC0", VA = "0x185DD4AC0", Slot = "15")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4620", Offset = "0x5DD3A20", VA = "0x185DD4620", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5DD53E0", Offset = "0x5DD47E0", VA = "0x185DD53E0", Slot = "8")]
	public JPGOBCIEAFB PIPAJEOKLFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4D30", Offset = "0x5DD4130", VA = "0x185DD4D30")]
	public JPGOBCIEAFB MNMAFFKLIIC(IEnumerable<LHNHNFAONOD> GAKOOBMLEII, [In] EKDOHGHOOFO FFGNHFDKOFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4B70", Offset = "0x5DD3F70", VA = "0x185DD4B70", Slot = "10")]
	public DCCFMDGIBCB JFPBNGMDKOO(ByteString EGFEGIMIICO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4F70", Offset = "0x5DD4370", VA = "0x185DD4F70")]
	public MFDFMBOIECB NBHOFAEMLGL(ByteString EGFEGIMIICO, LHNHNFAONOD EBFCMPBKGBM, [In] EKDOHGHOOFO CLFGJFGNNGG, JIKHBIMIMDL IFHPDALFBDB, bool HCKANGNGGLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4810", Offset = "0x5DD3C10", VA = "0x185DD4810", Slot = "12")]
	public void FBNDFBECIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4450", Offset = "0x5DD3850", VA = "0x185DD4450", Slot = "13")]
	public ECHNGDHAHOM AKEOPOJABHA(IEnumerable<BDDINDDAOMP> JJAIIAGNJLG)
	{
		return default(ECHNGDHAHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD52E0", Offset = "0x5DD46E0", VA = "0x185DD52E0")]
	public static bool PEHEHLEHJFM(ByteString EGFEGIMIICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4620", Offset = "0x5DD3A20", VA = "0x185DD4620")]
	private void COCHNNKHHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD54F0", Offset = "0x5DD48F0", VA = "0x185DD54F0")]
	private void PLIIHIOOGPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD49F0", Offset = "0x5DD3DF0", VA = "0x185DD49F0")]
	private void HKMLNKEGELH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4EC0", Offset = "0x5DD42C0", VA = "0x185DD4EC0", Slot = "16")]
	public void NAAAAHPDOKI(FJPIIIPDBML ICIBDGNEEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GHNPFMHIOKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4680", Offset = "0x5DD3A80", VA = "0x185DD4680", Slot = "9")]
	private JPGOBCIEAFB DHGIMDDBFLN(IEnumerable<LHNHNFAONOD> GAKOOBMLEII, [In] EKDOHGHOOFO FFGNHFDKOFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5120", Offset = "0x5DD4520", VA = "0x185DD5120", Slot = "11")]
	private MFDFMBOIECB OHEPBHMJLBC(ByteString EGFEGIMIICO, LHNHNFAONOD EBFCMPBKGBM, [In] EKDOHGHOOFO CLFGJFGNNGG, JIKHBIMIMDL IFHPDALFBDB, bool HCKANGNGGLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[OPLOBPDEFMG(typeof(ADMBLJAMLBN))]
[PNAJALIKCOM(typeof(GAHOIFMALLF), new string[] { })]
internal class ADMBLJAMLBN : GAHOIFMALLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[CompilerGenerated]
	private Action<IPLKNLMFFDP> HHELCGKEFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[CompilerGenerated]
	private Action AMGBHNCBGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[CompilerGenerated]
	private Action<IPLKNLMFFDP> HKAJDHJIGON;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action FJCEJCMDELL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5DC8100", Offset = "0x5DC7500", VA = "0x185DC8100", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7F20", Offset = "0x5DC7320", VA = "0x185DC7F20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action MJNIHLKJIEN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5DC8060", Offset = "0x5DC7460", VA = "0x185DC8060", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5DC7FC0", Offset = "0x5DC73C0", VA = "0x185DC7FC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0xAD6560", Offset = "0xAD5960", VA = "0x180AD6560")]
	public void FBNDFBECIAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0xAD6250", Offset = "0xAD5650", VA = "0x180AD6250")]
	public void EDNDPNCBEGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0xADC2C0", Offset = "0xADB6C0", VA = "0x180ADC2C0")]
	public void HBFJLCFLOBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x11EFD10", Offset = "0x11EF110", VA = "0x1811EFD10")]
	public void DJOFJFFGLFL(IPLKNLMFFDP GIDEAEKBMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x1763C30", Offset = "0x1763030", VA = "0x181763C30")]
	public void LBIDPNBJLHG(IPLKNLMFFDP GIDEAEKBMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public ADMBLJAMLBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
internal interface INAHANGECJF
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGFIMJJEJLG(global::POGJBDCDPAC PNLLBLBFPEJ);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[OPLOBPDEFMG(typeof(INAHANGECJF))]
[PNAJALIKCOM(typeof(NMDHGCKCBIM), new string[] { })]
public class LJGFKBFHDGJ : NMDHGCKCBIM, NPIGPPEOCFI, CNJKPBKICBD, JAKEGKENGGK, DFFDMFBJPHA, IDisposable, INAHANGECJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private JCCLPJHONHK JFLBEAFGHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private IOIHIPDJPNE LENGECAPJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private BCLKHHIKFMA PIOJMHPNEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private global::POGJBDCDPAC HLBEMEPBBFL;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private LJLPBCHNEGF<LHNHNFAONOD> NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x75C580", Offset = "0x75B980", VA = "0x18075C580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0830", Offset = "0x5DDFC30", VA = "0x185DE0830")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<HDHIDMCJGCD> FENGFCMOPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5DE03E0", Offset = "0x5DDF7E0", VA = "0x185DE03E0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0200", Offset = "0x5DDF600", VA = "0x185DE0200", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x15BEDC0", Offset = "0x15BE1C0", VA = "0x1815BEDC0", Slot = "17")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0590", Offset = "0x5DDF990", VA = "0x185DE0590", Slot = "18")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5DE06D0", Offset = "0x5DDFAD0", VA = "0x185DE06D0", Slot = "19")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x75C7C0", Offset = "0x75BBC0", VA = "0x18075C7C0", Slot = "21")]
	private void CBBFOCEMPAD(global::POGJBDCDPAC PNLLBLBFPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x15BED10", Offset = "0x15BE110", VA = "0x1815BED10", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0980", Offset = "0x5DDFD80", VA = "0x185DE0980")]
	private LHNHNFAONOD PMMGLGLIBGB(Entity FILKDLNBIJH)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0880", Offset = "0x5DDFC80", VA = "0x185DE0880", Slot = "6")]
	public LHNHNFAONOD NKAFPNBHAEE(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFF20", Offset = "0x5DDF320", VA = "0x185DDFF20", Slot = "7")]
	public void CBGNFIEJFNP(List<LHNHNFAONOD> BJEJBGEKBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0140", Offset = "0x5DDF540", VA = "0x185DE0140", Slot = "11")]
	public int DBNHBIOACAG(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0260", Offset = "0x5DDF660", VA = "0x185DE0260", Slot = "12")]
	public DLCLMIEPGBN EPALCICOBFP(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFE60", Offset = "0x5DDF260", VA = "0x185DDFE60", Slot = "15")]
	public LHNHNFAONOD BOFEBEAMOOA(LHNHNFAONOD BGICHGONLEL, LHNHNFAONOD AGPMPKBMMOB)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0440", Offset = "0x5DDF840", VA = "0x185DE0440", Slot = "16")]
	public bool GKMCHOHAPGM(LHNHNFAONOD BGICHGONLEL, LHNHNFAONOD AGPMPKBMMOB, [Out] LHNHNFAONOD MAKPPJALCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0900", Offset = "0x5DDFD00", VA = "0x185DE0900", Slot = "8")]
	public LHNHNFAONOD OBHLIPJDBGF(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5DE07C0", Offset = "0x5DDFBC0", VA = "0x185DE07C0", Slot = "14")]
	public bool MLAEFHBCNIM(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD MGPFGPKIGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0370", Offset = "0x5DDF770", VA = "0x185DE0370", Slot = "13")]
	public bool FLFPNBFPDPC(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD DFAAINNDBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0500", Offset = "0x5DDF900", VA = "0x185DE0500", Slot = "9")]
	public bool HEBPNKMJKGE(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD EBFCMPBKGBM, bool PANNPBLEODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0660", Offset = "0x5DDFA60", VA = "0x185DE0660", Slot = "10")]
	public bool LJDLEFCDHAM(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD EBFCMPBKGBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LJGFKBFHDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(EEKMFIANCNG), new string[] { })]
internal class EEKMFIANCNG : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[MFFAOKEGCNH]
	private BBAOLHNDKHB MFEJFLABCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Dictionary<int, FGGFOCNBCHP> MOAJBJHCNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF870", Offset = "0x5DCEC70", VA = "0x185DCF870", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF5E0", Offset = "0x5DCE9E0", VA = "0x185DCF5E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF8C0", Offset = "0x5DCECC0", VA = "0x185DCF8C0")]
	public FGGFOCNBCHP KNAOJKDANOI(PGMBACGNAAP IHPCGCBJCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF9C0", Offset = "0x5DCEDC0", VA = "0x185DCF9C0")]
	public FGGFOCNBCHP KNAOJKDANOI(EAAMNLEDMLN KMKGEGCGMGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF430", Offset = "0x5DCE830", VA = "0x185DCF430")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFBF0", Offset = "0x5DCEFF0", VA = "0x185DCFBF0")]
	public EEKMFIANCNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class FGGFOCNBCHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NativeList<KAIDKBAIDJE> PBAJBIEDAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private NativeList<OOPAIGCDJBO> HKILEHNDBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private NativeList<JJKHGHKNBKD> KJIDFFMIPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private NativeList<OOPAIGCDJBO> KOFNKHJCPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public NativeList<KAIDKBAIDJE> BHBIGOPBMDC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA9D400", Offset = "0xA9C800", VA = "0x180A9D400")]
		get
		{
			return default(NativeList<KAIDKBAIDJE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public NativeList<OOPAIGCDJBO> KFJANBCJBJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xD62290", Offset = "0xD61690", VA = "0x180D62290")]
		get
		{
			return default(NativeList<OOPAIGCDJBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public NativeList<JJKHGHKNBKD> HNEAICOHCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xD76A70", Offset = "0xD75E70", VA = "0x180D76A70")]
		get
		{
			return default(NativeList<JJKHGHKNBKD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public NativeList<OOPAIGCDJBO> LBJKIBHDDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x89FA30", Offset = "0x89EE30", VA = "0x18089FA30")]
		get
		{
			return default(NativeList<OOPAIGCDJBO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public JobHandle MFJEMAEPJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x95E350", Offset = "0x95D750", VA = "0x18095E350")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1009D90", Offset = "0x1009190", VA = "0x181009D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool CBELANCKJEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0BB0", Offset = "0x5DCFFB0", VA = "0x185DD0BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1150", Offset = "0x5DD0550", VA = "0x185DD1150")]
	public FGGFOCNBCHP(Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0C50", Offset = "0x5DD0050", VA = "0x185DD0C50")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0CE0", Offset = "0x5DD00E0", VA = "0x185DD0CE0")]
	public void DGELADFNLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0E10", Offset = "0x5DD0210", VA = "0x185DD0E10")]
	public void INMJBKGEACO(Entity FILKDLNBIJH, Entity JGNFAOENAOD, Entity JOOENMAHIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(HGICNBCKKOG), new string[] { })]
public class HGICNBCKKOG : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[MFFAOKEGCNH]
	private JKDKKFNOEFN BJPNEBJACGN;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD65B0", Offset = "0x5DD59B0", VA = "0x185DD65B0", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6590", Offset = "0x5DD5990", VA = "0x185DD6590", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HGICNBCKKOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[CDHEJLILMFK(PIEFJKINJBJ.PhotonRoom)]
[PNAJALIKCOM(typeof(JLOOOADOAFN), new string[] { })]
public class JLOOOADOAFN : NPIGPPEOCFI, CNJKPBKICBD, JAKEGKENGGK, DFFDMFBJPHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private OBDFANNJJFO MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private ALLMMPKGJCM ONGKEELOJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeList<int> MJBKAKLJFFD;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD88D0", Offset = "0x5DD7CD0", VA = "0x185DD88D0", Slot = "4")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8930", Offset = "0x5DD7D30", VA = "0x185DD8930", Slot = "5")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD89A0", Offset = "0x5DD7DA0", VA = "0x185DD89A0", Slot = "6")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5DD85E0", Offset = "0x5DD79E0", VA = "0x185DD85E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5DD86A0", Offset = "0x5DD7AA0", VA = "0x185DD86A0")]
	public void FBJGJFIDPCK(NativeParallelHashSet<int> LEABDJKHKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8890", Offset = "0x5DD7C90", VA = "0x185DD8890")]
	public void GMACAPDAFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public JLOOOADOAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal abstract class LNEJKIFIMJD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private uint JKFHKLNOKGE;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public abstract uint KGBAGHIOKLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3B47FC0", Offset = "0x3B473C0", VA = "0x183B47FC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5DE11C0", Offset = "0x5DE05C0", VA = "0x185DE11C0")]
	public IJFILFNCAOA CFHGIJBFKPO()
	{
		return default(IJFILFNCAOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5DE12B0", Offset = "0x5DE06B0", VA = "0x185DE12B0")]
	public void NDJIJLDPNCH(NativeArray<IJFILFNCAOA> OMNMPNPKGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1320", Offset = "0x5DE0720", VA = "0x185DE1320")]
	public void NDJIJLDPNCH(IJFILFNCAOA JNPKHIBFGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0xA955A0", Offset = "0xA949A0", VA = "0x180A955A0", Slot = "6")]
	public virtual void OAFECOOGBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1210", Offset = "0x5DE0610", VA = "0x185DE1210")]
	private unsafe void LOPDJAEOLKB(IJFILFNCAOA* CPNPELLBEAC, int OGEHFGGOGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1340", Offset = "0x5DE0740", VA = "0x185DE1340")]
	private unsafe void NDJIJLDPNCH(IJFILFNCAOA* CPNPELLBEAC, int OGEHFGGOGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	protected LNEJKIFIMJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(GKBJNBMEBDC), new string[] { })]
internal sealed class GKBJNBMEBDC : LNEJKIFIMJD, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[MFFAOKEGCNH]
	private KFJAFIJIKDB MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private uint LIECGMMBAAI;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public override uint KGBAGHIOKLO
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x8124E0", Offset = "0x8118E0", VA = "0x1808124E0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5620", Offset = "0x5DD4A20", VA = "0x185DD5620", Slot = "7")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5DD55D0", Offset = "0x5DD49D0", VA = "0x185DD55D0")]
	private void GKIPOPGHBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DD56B0", Offset = "0x5DD4AB0", VA = "0x185DD56B0", Slot = "6")]
	public override void OAFECOOGBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GKBJNBMEBDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[PNAJALIKCOM(typeof(FIHBIOAKNCJ), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
internal sealed class FIHBIOAKNCJ : LNEJKIFIMJD
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public override uint KGBAGHIOKLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public FIHBIOAKNCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(HLNOFBDJBEA), new string[] { })]
internal sealed class HLNOFBDJBEA : NPIGPPEOCFI, CNJKPBKICBD, JAKEGKENGGK, DFFDMFBJPHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private EntityQuery CAEOPIABONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private EntityQuery MJLGEJFFDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private EntityQuery KKPLJOAFLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private EntityQuery NJJEKGFKJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private EntityQuery JGOMLKNHDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private EntityQuery PHHDFIEAHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private EntityQuery DEOGIOOHFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7240", Offset = "0x5DD6640", VA = "0x185DD7240")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public EntityQuery NPAKINOEHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x95E370", Offset = "0x95D770", VA = "0x18095E370")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "4")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6BC0", Offset = "0x5DD5FC0", VA = "0x185DD6BC0", Slot = "5")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6C10", Offset = "0x5DD6010", VA = "0x185DD6C10", Slot = "6")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7290", Offset = "0x5DD6690", VA = "0x185DD7290")]
	private EntityQueryDesc ODMJBEJMLBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6B50", Offset = "0x5DD5F50", VA = "0x185DD6B50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7170", Offset = "0x5DD6570", VA = "0x185DD7170")]
	public NGBPNMOBPJE MMNDAFMFLJH(LHNHNFAONOD GIPGBEGNLCD)
	{
		return default(NGBPNMOBPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7300", Offset = "0x5DD6700", VA = "0x185DD7300")]
	public JMFEOGDEHDH PKPJNJIAHBH(Entity FILKDLNBIJH)
	{
		return default(JMFEOGDEHDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5DD73B0", Offset = "0x5DD67B0", VA = "0x185DD73B0")]
	public HLNOFBDJBEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[PNAJALIKCOM(typeof(INHGBAEAGHP), new string[] { })]
public class NDPGPNMNMAF : JAKEGKENGGK, INHGBAEAGHP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly FBKCBHAMJJJ KODICEGIOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[MFFAOKEGCNH]
	private GNGBPCPDDMI LCDKABNLFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[MFFAOKEGCNH]
	private EMLJAPIGCLK ENOFBOBGGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[MFFAOKEGCNH]
	private BCLKHHIKFMA AMEAOOFACPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[MFFAOKEGCNH]
	private EMJEIPEMFBH FELCGCIPFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[MFFAOKEGCNH]
	private HLNOFBDJBEA CKJDONFMJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[MFFAOKEGCNH]
	private PPDPMAOOACO ANANIEFDECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private AOIJIDDNGFE DKHFFJHAFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private IKGEFLGAOAF LGNEBDMIJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public GNGBPCPDDMI OHMNMMPCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public PLGBKBNKNDI KPAPLDAGLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8731A0", Offset = "0x8725A0", VA = "0x1808731A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(PLGBKBNKNDI);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8731B0", Offset = "0x8725B0", VA = "0x1808731B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<DLCLMIEPGBN, NativeArray<JMFEOGDEHDH>> DNFDBJHGGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2B00", Offset = "0x5DE1F00", VA = "0x185DE2B00", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1DA0", Offset = "0x5DE11A0", VA = "0x185DE1DA0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<DLCLMIEPGBN> PIBIAANAPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1E50", Offset = "0x5DE1250", VA = "0x185DE1E50", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2950", Offset = "0x5DE1D50", VA = "0x185DE2950", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1F00", Offset = "0x5DE1300", VA = "0x185DE1F00", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1990", Offset = "0x5DE0D90", VA = "0x185DE1990", Slot = "43")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2BB0", Offset = "0x5DE1FB0", VA = "0x185DE2BB0")]
	private void PMBGJMHJDID(NativeArray<IJFILFNCAOA> OMNMPNPKGPB, NativeArray<JMFEOGDEHDH> MKHHGJOGAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2310", Offset = "0x5DE1710", VA = "0x185DE2310")]
	private void LAFIKEOJEHO(DLCLMIEPGBN KAJFFCPILBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2CC0", Offset = "0x5DE20C0", VA = "0x185DE2CC0")]
	internal LHNHNFAONOD PMMGLGLIBGB(Entity FILKDLNBIJH)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE25F0", Offset = "0x5DE19F0", VA = "0x185DE25F0", Slot = "11")]
	public NGBPNMOBPJE MMNDAFMFLJH(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(NGBPNMOBPJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2AC0", Offset = "0x5DE1EC0", VA = "0x185DE2AC0", Slot = "12")]
	public JMFEOGDEHDH PKPJNJIAHBH(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(JMFEOGDEHDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1650", Offset = "0x5DE0A50", VA = "0x185DE1650", Slot = "42")]
	public bool AOKIEGPHIBB(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE23A0", Offset = "0x5DE17A0", VA = "0x185DE23A0", Slot = "37")]
	public void LEFNEIHNBJP(DLCLMIEPGBN GAKOOBMLEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1AD0", Offset = "0x5DE0ED0", VA = "0x185DE1AD0", Slot = "38")]
	public void FOEGEAAAFMJ(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE17A0", Offset = "0x5DE0BA0", VA = "0x185DE17A0", Slot = "39")]
	public void CJFFPOFKONJ(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2350", Offset = "0x5DE1750", VA = "0x185DE2350", Slot = "40")]
	public void LEFNEIHNBJP(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2A60", Offset = "0x5DE1E60", VA = "0x185DE2A60", Slot = "25")]
	public DLCLMIEPGBN OLOICJPHOFL(NativeArray<IJFILFNCAOA> JNPKHIBFGKN, Allocator KIKFOGPECEC)
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE27A0", Offset = "0x5DE1BA0", VA = "0x185DE27A0", Slot = "26")]
	public DLCLMIEPGBN NCFPNPLAFKO(NativeArray<IJFILFNCAOA> JNPKHIBFGKN, NativeArray<EIDGNLJLKDK> CHAFPPHFFEK, Allocator KIKFOGPECEC)
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2500", Offset = "0x5DE1900", VA = "0x185DE2500", Slot = "27")]
	public IJFILFNCAOA[] MBCOBOICKFL(string HFCKFJICBCH, FDLKIDLAABP DCLLGDLJCDH, bool CPLDJDAKCIM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1B70", Offset = "0x5DE0F70", VA = "0x185DE1B70", Slot = "28")]
	public void HADILHNEJHB(string HFCKFJICBCH, IJFILFNCAOA[] OMNMPNPKGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE22B0", Offset = "0x5DE16B0", VA = "0x185DE22B0", Slot = "29")]
	public FDLKIDLAABP KKPKACBLAKD(JMFEOGDEHDH INONPCNKMNK, bool IABBDCHOAPD)
	{
		return default(FDLKIDLAABP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2250", Offset = "0x5DE1650", VA = "0x185DE2250", Slot = "30")]
	public FDLKIDLAABP KKPKACBLAKD(JMFEOGDEHDH INONPCNKMNK)
	{
		return default(FDLKIDLAABP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1740", Offset = "0x5DE0B40", VA = "0x185DE1740", Slot = "31")]
	public FDLKIDLAABP BFGFKICLJCL(JMFEOGDEHDH INONPCNKMNK)
	{
		return default(FDLKIDLAABP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1800", Offset = "0x5DE0C00", VA = "0x185DE1800", Slot = "32")]
	public FDLKIDLAABP CMFODKOPDHJ(JMFEOGDEHDH INONPCNKMNK)
	{
		return default(FDLKIDLAABP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE26D0", Offset = "0x5DE1AD0", VA = "0x185DE26D0", Slot = "33")]
	public FDLKIDLAABP NCFPNPLAFKO(IJFILFNCAOA JNPKHIBFGKN, JMFEOGDEHDH INONPCNKMNK)
	{
		return default(FDLKIDLAABP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE15E0", Offset = "0x5DE09E0", VA = "0x185DE15E0", Slot = "34")]
	public MIMPJHHKPIA AJAACPDOBFL()
	{
		return default(MIMPJHHKPIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1CB0", Offset = "0x5DE10B0", VA = "0x185DE1CB0", Slot = "35")]
	public JKEKDMMJELC IGCCOCINEHG()
	{
		return default(JKEKDMMJELC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE28C0", Offset = "0x5DE1CC0", VA = "0x185DE28C0", Slot = "36")]
	public IDMBOMOIAMC NGFJKKMDBAC(AFADFPDANEE IJFAMCPOKBO)
	{
		return default(IDMBOMOIAMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE21C0", Offset = "0x5DE15C0", VA = "0x185DE21C0", Slot = "13")]
	public void KIPDOAILNDA(IJFILFNCAOA JNPKHIBFGKN, PCCDMPNJHHD FPKKJCBLEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1B30", Offset = "0x5DE0F30", VA = "0x185DE1B30", Slot = "14")]
	public void GAMIJMMLFLB(IJFILFNCAOA[] OMNMPNPKGPB, GameObject IPAGFDLNMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1C20", Offset = "0x5DE1020", VA = "0x185DE1C20", Slot = "15")]
	public FDLKIDLAABP HFGJIPKOLGA(LHNHNFAONOD PIBFDGEOBKF, [Optional] object KJAGMGIFCEM)
	{
		return default(FDLKIDLAABP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1940", Offset = "0x5DE0D40", VA = "0x185DE1940", Slot = "16")]
	public bool DHIPACEFKGL(LHNHNFAONOD PIBFDGEOBKF, [Out] PCCDMPNJHHD KNLODAPAGGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE24B0", Offset = "0x5DE18B0", VA = "0x185DE24B0", Slot = "17")]
	public bool LFEOLBBNFPA(LHNHNFAONOD PIBFDGEOBKF, [Out] Transform OLPLDGDFGHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1BE0", Offset = "0x5DE0FE0", VA = "0x185DE1BE0", Slot = "18")]
	public bool HEIAMNBIGPH(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2A00", Offset = "0x5DE1E00", VA = "0x185DE2A00", Slot = "19")]
	public void NOJOAOHGNKO(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE21E0", Offset = "0x5DE15E0", VA = "0x185DE21E0", Slot = "20")]
	public bool KJDJBAPPIFP(LocalId PIBFDGEOBKF, object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE18F0", Offset = "0x5DE0CF0", VA = "0x185DE18F0", Slot = "21")]
	public bool DCPFEBKPKND(LocalId PIBFDGEOBKF, object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1D40", Offset = "0x5DE1140", VA = "0x185DE1D40", Slot = "41")]
	public DLCLMIEPGBN IKFIBPFDHJJ(DLCLMIEPGBN FGKMGJALCKJ, Allocator KIKFOGPECEC)
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1B50", Offset = "0x5DE0F50", VA = "0x185DE1B50", Slot = "24")]
	public IJFILFNCAOA GEMBKIKECJJ(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(IJFILFNCAOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2A40", Offset = "0x5DE1E40", VA = "0x185DE2A40", Slot = "22")]
	public LHNHNFAONOD OLOICJPHOFL(IJFILFNCAOA JNPKHIBFGKN)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2230", Offset = "0x5DE1630", VA = "0x185DE2230", Slot = "23")]
	public bool KJMILBLALPL(IJFILFNCAOA JNPKHIBFGKN, [Out] LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1A90", Offset = "0x5DE0E90", VA = "0x185DE1A90")]
	private void EKFNEIBNOJO(JMFEOGDEHDH OCDLGNNMKIM, LHNHNFAONOD PIBFDGEOBKF, IJFILFNCAOA JNPKHIBFGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2D70", Offset = "0x5DE2170", VA = "0x185DE2D70")]
	public NDPGPNMNMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(OFECGAAIEIG), new string[] { })]
internal sealed class OFECGAAIEIG : JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private EMJEIPEMFBH FELCGCIPFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[MFFAOKEGCNH]
	private HLNOFBDJBEA CKJDONFMJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[MFFAOKEGCNH]
	private CCCMOPCHHIG GKMLAKMFINK;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7280", Offset = "0x5DE6680", VA = "0x185DE7280", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7130", Offset = "0x5DE6530", VA = "0x185DE7130")]
	public DLCLMIEPGBN IKFIBPFDHJJ(DLCLMIEPGBN FGKMGJALCKJ, Allocator KIKFOGPECEC)
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7330", Offset = "0x5DE6730", VA = "0x185DE7330")]
	private void KADCHIJBNBE(NativeParallelMultiHashMap<int, (LHNHNFAONOD src, LHNHNFAONOD dst)> KLFMMCNNKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE76D0", Offset = "0x5DE6AD0", VA = "0x185DE76D0")]
	private void OHAFJPGBJCM(NativeParallelMultiHashMap<int, (LHNHNFAONOD src, LHNHNFAONOD dst)> KLFMMCNNKBP, int INONPCNKMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7560", Offset = "0x5DE6960", VA = "0x185DE7560")]
	private void KENNOCNBJOL(NativeParallelMultiHashMap<int, (LHNHNFAONOD src, LHNHNFAONOD dst)> KLFMMCNNKBP, int INONPCNKMNK, FKMDJINEHMO MFEJFLABCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6EC0", Offset = "0x5DE62C0", VA = "0x185DE6EC0")]
	private NativeParallelMultiHashMap<int, (LHNHNFAONOD, LHNHNFAONOD)> BGHFCKICAMF(Allocator KIKFOGPECEC, DLCLMIEPGBN FGKMGJALCKJ, [Out] DLCLMIEPGBN DOOGCBOADDC)
	{
		return default(NativeParallelMultiHashMap<int, (LHNHNFAONOD, LHNHNFAONOD)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public OFECGAAIEIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[OPLOBPDEFMG(typeof(LDCIJBFGPJE))]
[PNAJALIKCOM(typeof(KFJHDAOPGPA), new string[] { })]
public class LDCIJBFGPJE : KFJHDAOPGPA, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly FBKCBHAMJJJ DJJFHJNIKFK;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly FBKCBHAMJJJ DNPAACMGJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private AFLJLAKFEOK MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private LGPKLAKDANM EOJANGPGAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private NMDHGCKCBIM BEOJNJDKKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private CALJHDDCOOA EOHCNMJHJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private BCLKHHIKFMA AMEAOOFACPA;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private EntityManager OKJDPAMBACM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF040", Offset = "0x5DDE440", VA = "0x185DDF040")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD800", Offset = "0x5DDCC00", VA = "0x185DDD800", Slot = "34")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDD20", Offset = "0x5DDD120", VA = "0x185DDDD20", Slot = "35")]
	public bool KJMILBLALPL(Transform OLPLDGDFGHL, [Out] LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD740", Offset = "0x5DDCB40", VA = "0x185DDD740", Slot = "36")]
	public Transform IMJFGLOPGCJ(Entity FILKDLNBIJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE020", Offset = "0x5DDD420", VA = "0x185DDE020", Slot = "31")]
	public bool LFEOLBBNFPA(Entity FILKDLNBIJH, [Out] Transform OLPLDGDFGHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF020", Offset = "0x5DDE420", VA = "0x185DDF020")]
	private void NFJNADOHEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE850", Offset = "0x5DDDC50", VA = "0x185DDE850", Slot = "30")]
	public void MDDLCAPBNMM(Entity FILKDLNBIJH, [Out] float4x4 CENNAHINDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF670", Offset = "0x5DDEA70", VA = "0x185DDF670", Slot = "4")]
	public void OKMMAOFGAAN(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDEB0", Offset = "0x5DDD2B0", VA = "0x185DDDEB0", Slot = "28")]
	public void KNMGLOIEFFH(Entity FILKDLNBIJH, [Out] float4x4 CENNAHINDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD050", Offset = "0x5DDC450", VA = "0x185DDD050")]
	public void GOCBLPONMOG(Entity FILKDLNBIJH, [In] float4x4 CENNAHINDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCCD0", Offset = "0x5DDC0D0", VA = "0x185DDCCD0")]
	public void FHGIOMOOJOM(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCA90", Offset = "0x5DDBE90", VA = "0x185DDCA90", Slot = "6")]
	public float3 EMKLLIFBIHI(Entity FILKDLNBIJH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE3C0", Offset = "0x5DDD7C0", VA = "0x185DDE3C0")]
	public void MBBPIMFGAGK(Entity FILKDLNBIJH, [In] quaternion EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCBC0", Offset = "0x5DDBFC0", VA = "0x185DDCBC0", Slot = "8")]
	public quaternion FGCBMPPKJED(Entity FILKDLNBIJH)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCE00", Offset = "0x5DDC200", VA = "0x185DDCE00")]
	public void GNNOCLCGJFD(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE900", Offset = "0x5DDDD00", VA = "0x185DDE900", Slot = "12")]
	public float3 MELIPNBOBPF(Entity FILKDLNBIJH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC680", Offset = "0x5DDBA80", VA = "0x185DDC680", Slot = "15")]
	public float BEJMJFDAAOG(Entity FILKDLNBIJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEB10", Offset = "0x5DDDF10", VA = "0x185DDEB10", Slot = "14")]
	public void NCPALADIGEO(Entity FILKDLNBIJH, float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC4C0", Offset = "0x5DDB8C0", VA = "0x185DDC4C0", Slot = "17")]
	public float3 BBHMKJIBMJJ(Entity FILKDLNBIJH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBFE0", Offset = "0x5DDB3E0", VA = "0x185DDBFE0")]
	public void AENFGGIMCKH(Entity FILKDLNBIJH, [In] float3 JANBANAPHND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE4E0", Offset = "0x5DDD8E0", VA = "0x185DDE4E0", Slot = "9")]
	public void MBIOPMBABME(Entity FILKDLNBIJH, [Out] float3 LPAPEIIOLFG, [Out] quaternion KBKHJHIFKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE650", Offset = "0x5DDDA50", VA = "0x185DDE650", Slot = "10")]
	public void MBIOPMBABME(Entity FILKDLNBIJH, [Out] RigidTransform DPJEBGDEPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE110", Offset = "0x5DDD510", VA = "0x185DDE110", Slot = "37")]
	public void LOOLBJMMENL(Entity FILKDLNBIJH, [Out] float3 LPAPEIIOLFG, [Out] quaternion KBKHJHIFKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE3A0", Offset = "0x5DDD7A0", VA = "0x185DDE3A0", Slot = "11")]
	public void LOOLBJMMENL(Entity FILKDLNBIJH, [Out] RigidTransform DPJEBGDEPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBEB0", Offset = "0x5DDB2B0", VA = "0x185DDBEB0")]
	public void AABNFNFJOED(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD910", Offset = "0x5DDCD10", VA = "0x185DDD910", Slot = "19")]
	public float3 JJDGJNMDPEO(Entity FILKDLNBIJH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC970", Offset = "0x5DDBD70", VA = "0x185DDC970")]
	public void CLGOCGLCHLF(Entity FILKDLNBIJH, [In] quaternion EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC160", Offset = "0x5DDB560", VA = "0x185DDC160", Slot = "21")]
	public quaternion AMIMBCINAKN(Entity FILKDLNBIJH)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC760", Offset = "0x5DDBB60", VA = "0x185DDC760")]
	public void BIOJKOBIMEI(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCF30", Offset = "0x5DDC330", VA = "0x185DDCF30", Slot = "22")]
	public float3 GNOLJMBOIBB(Entity FILKDLNBIJH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5DDECF0", Offset = "0x5DDE0F0", VA = "0x185DDECF0", Slot = "24")]
	public void NFGLIJNOKKA(Entity FILKDLNBIJH, float NDECIHNNPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEA30", Offset = "0x5DDDE30", VA = "0x185DDEA30", Slot = "25")]
	public float MPGNDNOGEJD(Entity FILKDLNBIJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF8F0", Offset = "0x5DDECF0", VA = "0x185DDF8F0")]
	public void PGHNOELEANF(Entity FILKDLNBIJH, [In] float3 OGHOBGEPGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDB80", Offset = "0x5DDCF80", VA = "0x185DDDB80", Slot = "27")]
	public float3 JKAGHHMENCF(Entity FILKDLNBIJH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF090", Offset = "0x5DDE490", VA = "0x185DDF090", Slot = "32")]
	public void OGCJPHICKOL(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD620", Offset = "0x5DDCA20", VA = "0x185DDD620")]
	private LHNHNFAONOD HPIIOKDCOFK(Transform OLPLDGDFGHL)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD320", Offset = "0x5DDC720", VA = "0x185DDD320")]
	private static TransformEntity HHMELCHMLAP(JMFEOGDEHDH IJFAMCPOKBO, GameObject OCEAKGFKBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x244DCA0", Offset = "0x244D0A0", VA = "0x18244DCA0")]
	private static T GCHAGHMBGLA<T>(GameObject OCEAKGFKBEH) where T : MonoBehaviour
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC3A0", Offset = "0x5DDB7A0", VA = "0x185DDC3A0", Slot = "33")]
	public void APACBCNCELF(Entity FILKDLNBIJH, Entity JGNFAOENAOD, Entity JOOENMAHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LDCIJBFGPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCCD0", Offset = "0x5DDC0D0", VA = "0x185DDCCD0", Slot = "5")]
	private void KEFLOIEDIKD(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE3C0", Offset = "0x5DDD7C0", VA = "0x185DDE3C0", Slot = "7")]
	private void NFOADIOLEEJ(Entity FILKDLNBIJH, [In] quaternion EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCE00", Offset = "0x5DDC200", VA = "0x185DDCE00", Slot = "13")]
	private void LLAOBPGLPLM(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBFE0", Offset = "0x5DDB3E0", VA = "0x185DDBFE0", Slot = "16")]
	private void ELHJNDNAPNN(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBEB0", Offset = "0x5DDB2B0", VA = "0x185DDBEB0", Slot = "18")]
	private void PLGBMKCCGLM(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC970", Offset = "0x5DDBD70", VA = "0x185DDC970", Slot = "20")]
	private void NEMPPPHPKDB(Entity FILKDLNBIJH, [In] quaternion EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEA20", Offset = "0x5DDDE20", VA = "0x185DDEA20", Slot = "23")]
	private void MLFPOPPMIHN(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCBB0", Offset = "0x5DDBFB0", VA = "0x185DDCBB0", Slot = "26")]
	private void FFIBDKLELBP(Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDD10", Offset = "0x5DDD110", VA = "0x185DDDD10", Slot = "29")]
	private void KFFPKENLMDA(Entity FILKDLNBIJH, [In] float4x4 HADNJFPICLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class CNILGBHJLLB
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDA90", Offset = "0x5DCCE90", VA = "0x185DCDA90")]
	public static void LOIIEMFBELM(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [In] float3 DPHLBKLFIPE, [In] quaternion CMOGOLPKHJO, [In] float3 JHIDGCOCDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE0E0", Offset = "0x5DCD4E0", VA = "0x185DCE0E0")]
	public static void MDDLCAPBNMM(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [Out] float4x4 CENNAHINDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDFA0", Offset = "0x5DCD3A0", VA = "0x185DCDFA0")]
	private static void MDDLCAPBNMM(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, Entity EBFCMPBKGBM, [Out] float4x4 CENNAHINDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD250", Offset = "0x5DCC650", VA = "0x185DCD250")]
	public static void GOCBLPONMOG(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [In] float4x4 CENNAHINDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE680", Offset = "0x5DCDA80", VA = "0x185DCE680")]
	public static void OJANADHDOOB(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [Out] float4x4 HCAELKBLCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD5E0", Offset = "0x5DCC9E0", VA = "0x185DCD5E0")]
	public static void HDGHPKIFFIC(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [In] float4x4 HCAELKBLCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCC80", Offset = "0x5DCC080", VA = "0x185DCCC80")]
	public static float3 EMKLLIFBIHI(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCE50", Offset = "0x5DCC250", VA = "0x185DCCE50")]
	public static void FHGIOMOOJOM(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCD70", Offset = "0x5DCC170", VA = "0x185DCCD70")]
	public static quaternion FGCBMPPKJED(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDCC0", Offset = "0x5DCD0C0", VA = "0x185DCDCC0")]
	public static void MBBPIMFGAGK(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [In] quaternion EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE200", Offset = "0x5DCD600", VA = "0x185DCE200")]
	public static float3 MELIPNBOBPF(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCF40", Offset = "0x5DCC340", VA = "0x185DCCF40")]
	public static void GNNOCLCGJFD(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC530", Offset = "0x5DCB930", VA = "0x185DCC530")]
	public static float BEJMJFDAAOG(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE490", Offset = "0x5DCD890", VA = "0x185DCE490")]
	public static void NCPALADIGEO(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC450", Offset = "0x5DCB850", VA = "0x185DCC450")]
	public static float3 BBHMKJIBMJJ(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC210", Offset = "0x5DCB610", VA = "0x185DCC210")]
	public static void AENFGGIMCKH(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDDB0", Offset = "0x5DCD1B0", VA = "0x185DCDDB0")]
	public static void MBIOPMBABME(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [Out] RigidTransform HCAELKBLCGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDE90", Offset = "0x5DCD290", VA = "0x185DCDE90")]
	public static void MBIOPMBABME(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [Out] float3 LPAPEIIOLFG, [Out] quaternion KBKHJHIFKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEA30", Offset = "0x5DCDE30", VA = "0x185DCEA30")]
	public static void OPIJAKLGCFA(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [In] float3 DPHLBKLFIPE, [In] quaternion CMOGOLPKHJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDB30", Offset = "0x5DCCF30", VA = "0x185DCDB30")]
	public static void LOOLBJMMENL(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [Out] float3 LPAPEIIOLFG, [Out] quaternion KBKHJHIFKGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD6B0", Offset = "0x5DCCAB0", VA = "0x185DCD6B0")]
	public static float3 JJDGJNMDPEO(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBFC0", Offset = "0x5DCB3C0", VA = "0x185DCBFC0")]
	public static void AABNFNFJOED(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC8F0", Offset = "0x5DCBCF0", VA = "0x185DCC8F0")]
	public static void CLGOCGLCHLF(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [In] quaternion EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC2E0", Offset = "0x5DCB6E0", VA = "0x185DCC2E0")]
	public static quaternion AMIMBCINAKN(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD030", Offset = "0x5DCC430", VA = "0x185DCD030")]
	public static float3 GNOLJMBOIBB(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC600", Offset = "0x5DCBA00", VA = "0x185DCC600")]
	public static void BIOJKOBIMEI(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [In] float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE2B0", Offset = "0x5DCD6B0", VA = "0x185DCE2B0")]
	public static float MPGNDNOGEJD(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE540", Offset = "0x5DCD940", VA = "0x185DCE540")]
	public static void NFGLIJNOKKA(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, float NDECIHNNPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD830", Offset = "0x5DCCC30", VA = "0x185DCD830")]
	public static float3 JKAGHHMENCF(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEB30", Offset = "0x5DCDF30", VA = "0x185DCEB30")]
	public static void PGHNOELEANF(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [In] float3 OGHOBGEPGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC850", Offset = "0x5DCBC50", VA = "0x185DCC850")]
	public static bool BLPDPDNNOAP(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [Out] Entity EBFCMPBKGBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
[PNAJALIKCOM(typeof(AIDLFMDCFLB), new string[] { })]
internal sealed class AIDLFMDCFLB : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[MFFAOKEGCNH]
	private ADOFIMCFGAO MKNFLEECOBD;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5DC81F0", Offset = "0x5DC75F0", VA = "0x185DC81F0", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x5DC81A0", Offset = "0x5DC75A0", VA = "0x185DC81A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public AIDLFMDCFLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(HIMIGLEIKCM), new string[] { })]
public class HIMIGLEIKCM
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct NCNLIDPKKJA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly HIMIGLEIKCM EBFCMPBKGBM;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE15A0", Offset = "0x5DE09A0", VA = "0x185DE15A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private int FCADKPDDNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[CompilerGenerated]
	private Action IGIPCEJAACG;

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6970", Offset = "0x5DD5D70", VA = "0x185DD6970")]
	public void PEPKDKNNNLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HIMIGLEIKCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(LCMBOOHOIHL), new string[] { })]
public class LCMBOOHOIHL
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private bool EGKJFJONNCD;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool FGAOPKACOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7AEE20", Offset = "0x7AE220", VA = "0x1807AEE20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBE10", Offset = "0x5DDB210", VA = "0x185DDBE10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LCMBOOHOIHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(NPDDCFNIDFD), new string[] { })]
public class NPDDCFNIDFD : JAKEGKENGGK, FFMIIDAKNCD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct CIOJNILBADD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private NativeArray<int> JLFCDCLNOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private NativeArray<int> PIHPAKAJMHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<ComponentSystemBase, int> AADEIHPMGHH;

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA330", Offset = "0x5DC9730", VA = "0x185DCA330")]
		public CIOJNILBADD(NativeArray<int> JLFCDCLNOBI, NativeArray<int> PIHPAKAJMHN, Dictionary<ComponentSystemBase, int> AADEIHPMGHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9F10", Offset = "0x5DC9310", VA = "0x185DC9F10")]
		public static void DMIHKBEFAAE(World MOIDEPLOCKC, PIEFJKINJBJ NKOBMHGFLDF, NativeArray<int> JLFCDCLNOBI, NativeArray<int> PIHPAKAJMHN, Dictionary<ComponentSystemBase, int> AADEIHPMGHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA040", Offset = "0x5DC9440", VA = "0x185DCA040")]
		public void MKIFMBIEIFE(IEnumerable<ComponentSystemBase> LCDKABNLFIH, PIEFJKINJBJ NKOBMHGFLDF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OPKEALFOBOP : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private ComponentSystemBase <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public NPDDCFNIDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private int start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public int <>3__start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public int <>3__end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x870E50", Offset = "0x870250", VA = "0x180870E50")]
		[DebuggerHidden]
		public OPKEALFOBOP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8F80", Offset = "0x5DE8380", VA = "0x185DE8F80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9160", Offset = "0x5DE8560", VA = "0x185DE9160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE90B0", Offset = "0x5DE84B0", VA = "0x185DE90B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5DE90B0", Offset = "0x5DE84B0", VA = "0x185DE90B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly FBKCBHAMJJJ ONILOCCCDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private World MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private FJPIIIPDBML NKEGKJEJLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private NativeArray<int> JBHENBBIDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private NativeArray<int> HHIPIHCKLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private int FOIKACEEEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private PIEFJKINJBJ FHAIKNOHEOD;

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x5DE66D0", Offset = "0x5DE5AD0", VA = "0x185DE66D0", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x5DE63D0", Offset = "0x5DE57D0", VA = "0x185DE63D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5AB0", Offset = "0x5DE4EB0", VA = "0x185DE5AB0")]
	[IteratorStateMachine(typeof(OPKEALFOBOP))]
	private IEnumerable<ComponentSystemBase> CHEKCLLLDOB(int NBBMHNNJHFB, int ICPDBPOHHIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6A00", Offset = "0x5DE5E00", VA = "0x185DE6A00", Slot = "5")]
	public void NAAAAHPDOKI(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6A00", Offset = "0x5DE5E00", VA = "0x185DE6A00")]
	private void NPDFBJAPPFP(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6A80", Offset = "0x5DE5E80", VA = "0x185DE6A80")]
	public void NPDFBJAPPFP(PIEFJKINJBJ LFENEGEDJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6150", Offset = "0x5DE5550", VA = "0x185DE6150")]
	private void DGAKFGPMJNO(PIEFJKINJBJ LFENEGEDJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6500", Offset = "0x5DE5900", VA = "0x185DE6500")]
	private void FABBHBEPGDM(PIEFJKINJBJ LFENEGEDJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6920", Offset = "0x5DE5D20", VA = "0x185DE6920")]
	private void KFOOJOLIBOK(PIEFJKINJBJ LFENEGEDJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE69B0", Offset = "0x5DE5DB0", VA = "0x185DE69B0")]
	private void LLJLGKKFLBH(int NBBMHNNJHFB, int ICPDBPOHHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6440", Offset = "0x5DE5840", VA = "0x185DE6440")]
	private void EEIOAAFEHLB(int NBBMHNNJHFB, int ICPDBPOHHIC, bool EGKJFJONNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE67B0", Offset = "0x5DE5BB0", VA = "0x185DE67B0")]
	private int JABBBBHGPDL(PIEFJKINJBJ LFENEGEDJDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5B90", Offset = "0x5DE4F90", VA = "0x185DE5B90")]
	private bool CPLHJFCHELE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6830", Offset = "0x5DE5C30", VA = "0x185DE6830")]
	private Dictionary<ComponentSystemBase, int> JLEABFFFFKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5B50", Offset = "0x5DE4F50", VA = "0x185DE5B50")]
	private void CJHFCMJGHDC(NativeArray<int> JLFCDCLNOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6620", Offset = "0x5DE5A20", VA = "0x185DE6620")]
	private void FICEEHNBJMH(NativeArray<int> PIHPAKAJMHN, NativeArray<int> JLFCDCLNOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5DE65C0", Offset = "0x5DE59C0", VA = "0x185DE65C0")]
	private static PIEFJKINJBJ FGKLDEANBNB(Type IJFAMCPOKBO, PIEFJKINJBJ DPPAMEJDDPD)
	{
		return default(PIEFJKINJBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6C90", Offset = "0x5DE6090", VA = "0x185DE6C90")]
	public NPDDCFNIDFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5DE67D0", Offset = "0x5DE5BD0", VA = "0x185DE67D0")]
	[CompilerGenerated]
	private void JHOAECFDJND(JAKEGKENGGK GKJGPNDDLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5A50", Offset = "0x5DE4E50", VA = "0x185DE5A50")]
	[CompilerGenerated]
	private void CGGMPBNPEHP(DFFDMFBJPHA GKJGPNDDLFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[PNAJALIKCOM(typeof(FMNCGEAPDKG), new string[] { })]
public class GLHEPAMFHJP : JAKEGKENGGK, FMNCGEAPDKG
{
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[MFFAOKEGCNH]
	private NBCENCLEOLD AMEPNDNNGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[MFFAOKEGCNH]
	private OAIGFOPCPFO DGFAJNPJEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[MFFAOKEGCNH]
	private FDJDNGGEHIB DGMLJBAGAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[MFFAOKEGCNH]
	private CALJHDDCOOA DNKMGGNGHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[MFFAOKEGCNH]
	private OOMLCKJIEGP MHIDGDMAFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private World GNEMMEMGKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private KNILDENLKDA GMIJBLBEKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private KNILDENLKDA FMNMMHHJKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private KNILDENLKDA NNBAFLGOJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private KNILDENLKDA ONHKCLFLLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private KNILDENLKDA IDBGDKOGOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private KNILDENLKDA KDDBDNLKPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private KNILDENLKDA NFJFAHANNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private KNILDENLKDA PDMCOJLBBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private KNILDENLKDA FAOPGCEOMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private KNILDENLKDA FMBFDDCNLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private KNILDENLKDA EMEOBLIMBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private KNILDENLKDA MINKHKAABCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private KNILDENLKDA JPNPNHMDHDN;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private bool APKCJNIOIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5DD5D60", Offset = "0x5DD5160", VA = "0x185DD5D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private bool IHPMPBMFJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5DD5DE0", Offset = "0x5DD51E0", VA = "0x185DD5DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	private bool AGPMFONOMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5DD5790", Offset = "0x5DD4B90", VA = "0x185DD5790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private bool OIPFDCLHKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5DD5790", Offset = "0x5DD4B90", VA = "0x185DD5790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5F00", Offset = "0x5DD5300", VA = "0x185DD5F00", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x239F9A0", Offset = "0x239EDA0", VA = "0x18239F9A0")]
	private KNILDENLKDA HGIBAIGMMOJ<T>() where T : LBKGDCALPNM
	{
		return default(KNILDENLKDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5E50", Offset = "0x5DD5250", VA = "0x185DD5E50")]
	private KNILDENLKDA HGIBAIGMMOJ(Type IJFAMCPOKBO)
	{
		return default(KNILDENLKDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6310", Offset = "0x5DD5710", VA = "0x185DD6310", Slot = "14")]
	public void JHJEEFGNLGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6450", Offset = "0x5DD5850", VA = "0x185DD6450", Slot = "15")]
	public void OGGPIKIBFMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5770", Offset = "0x5DD4B70", VA = "0x185DD5770", Slot = "5")]
	public void BHBJIEDONMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6340", Offset = "0x5DD5740", VA = "0x185DD6340", Slot = "6")]
	public void KHPNKDFLAFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5C50", Offset = "0x5DD5050", VA = "0x185DD5C50", Slot = "7")]
	public void FCILFEKJMPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5E80", Offset = "0x5DD5280", VA = "0x185DD5E80", Slot = "8")]
	public void HJPKPEDBMCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5880", Offset = "0x5DD4C80", VA = "0x185DD5880", Slot = "9")]
	public void DOOGMPIMBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5DD57A0", Offset = "0x5DD4BA0", VA = "0x185DD57A0", Slot = "10")]
	public void DOLGKEPDIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6480", Offset = "0x5DD5880", VA = "0x185DD6480", Slot = "11")]
	public void OMHNADMCNAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5730", Offset = "0x5DD4B30", VA = "0x185DD5730", Slot = "12")]
	public void BFCMIILNBHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5900", Offset = "0x5DD4D00", VA = "0x185DD5900", Slot = "13")]
	public void EBINAFLDDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5DD63C0", Offset = "0x5DD57C0", VA = "0x185DD63C0")]
	private void LPDCACDFKPI(KNILDENLKDA BPHADMLKFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5CD0", Offset = "0x5DD50D0", VA = "0x185DD5CD0")]
	private void FFHOCELBEKN(KNILDENLKDA BPHADMLKFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5710", Offset = "0x5DD4B10", VA = "0x185DD5710")]
	private void AOGPFILLCKK(KNILDENLKDA BPHADMLKFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GLHEPAMFHJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal readonly struct KNILDENLKDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly ComponentSystemBase BPHADMLKFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly ProfilerMarker PIHIFMEJDOB;

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9950", Offset = "0x5DD8D50", VA = "0x185DD9950")]
	public KNILDENLKDA(World MOIDEPLOCKC, Type IJFAMCPOKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9880", Offset = "0x5DD8C80", VA = "0x185DD9880")]
	public void AOGPFILLCKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[PNAJALIKCOM(typeof(IMHPKNCJCOD), new string[] { })]
public class JPOHGGNOPNN : IMHPKNCJCOD, IDisposable, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[MFFAOKEGCNH]
	private PAFDHAFMDMH KGNBJGFDKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[MFFAOKEGCNH]
	private LKEFCEFOADP CDJDLKEEKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private World GNEMMEMGKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private World DMNCBDLCGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private bool CLIMOBJOFJB;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public World MGNDKLKJBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public World PPGDOEHNLKI
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x5DD90A0", Offset = "0x5DD84A0", VA = "0x185DD90A0", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x3610790", Offset = "0x360FB90", VA = "0x183610790", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8F00", Offset = "0x5DD8300", VA = "0x185DD8F00", Slot = "10")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8DB0", Offset = "0x5DD81B0", VA = "0x185DD8DB0")]
	private void EECJKDKEFDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8AE0", Offset = "0x5DD7EE0", VA = "0x185DD8AE0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8EE0", Offset = "0x5DD82E0", VA = "0x185DD8EE0", Slot = "8")]
	public ComponentSystemBase HGIBAIGMMOJ(Type IJFAMCPOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public JPOHGGNOPNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[PNAJALIKCOM(typeof(PPDPMAOOACO), new string[] { })]
public class NLLLOKIOHMI : PPDPMAOOACO, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[MFFAOKEGCNH]
	private EMJEIPEMFBH ANMNHLGNOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[MFFAOKEGCNH]
	private BICEKDGEPFI EKCIIOMPBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[MFFAOKEGCNH]
	private IKGEFLGAOAF LGNEBDMIJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private AOIJIDDNGFE EIECOJMPGAC;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE44A0", Offset = "0x5DE38A0", VA = "0x185DE44A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3BF0", Offset = "0x5DE2FF0", VA = "0x185DE3BF0", Slot = "6")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE37B0", Offset = "0x5DE2BB0", VA = "0x185DE37B0", Slot = "5")]
	public void HADILHNEJHB(string HFCKFJICBCH, IJFILFNCAOA[] OMNMPNPKGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3E50", Offset = "0x5DE3250", VA = "0x185DE3E50", Slot = "4")]
	public IJFILFNCAOA[] MBCOBOICKFL(string HFCKFJICBCH, FDLKIDLAABP DCLLGDLJCDH, bool CPLDJDAKCIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE44F0", Offset = "0x5DE38F0", VA = "0x185DE44F0")]
	private bool NLCKBCMFKHD(LHNHNFAONOD OGEFIHKILIO, [Out] NativeArray<Entity> DKELPPJEAKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4280", Offset = "0x5DE3680", VA = "0x185DE4280")]
	private bool NDAFCCDJBPP(NativeArray<Entity> GGFGMFCGPNH, HHLJNONFIDL EGPMKMDMPPP, IJFILFNCAOA[] OMNMPNPKGPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3CC0", Offset = "0x5DE30C0", VA = "0x185DE3CC0")]
	private bool KBKNJICCKHI([In] EntityBundlePartId IMPIMKLFLDN, [In] HHLJNONFIDL EGPMKMDMPPP, [Out] int APOENOPNHBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3D40", Offset = "0x5DE3140", VA = "0x185DE3D40")]
	private void KCJENNKOAPM(Entity FILKDLNBIJH, Entity OGEFIHKILIO, EntityBundlePartId BLLBKIFLMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public NLLLOKIOHMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct HHLJNONFIDL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly NativeArray<EntityBundlePartId> JADHNDPJCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly NativeArray<JMFEOGDEHDH> MKHHGJOGAOF;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int EKAAEPEENKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1C782F0", Offset = "0x1C776F0", VA = "0x181C782F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6680", Offset = "0x5DD5A80", VA = "0x185DD6680")]
	public HHLJNONFIDL(IReadOnlyList<NetworkedTransformEntity> IJKBDHBGLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6600", Offset = "0x5DD5A00", VA = "0x185DD6600", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(BICEKDGEPFI), new string[] { })]
public class BICEKDGEPFI : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[MFFAOKEGCNH]
	private MJMAOFFIBEJ DOBNHFCFMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<string, HHLJNONFIDL> JIAFIEJPFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly List<NetworkedTransformEntity> ENFAHNOHNHK;

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9AE0", Offset = "0x5DC8EE0", VA = "0x185DC9AE0", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5DC96A0", Offset = "0x5DC8AA0", VA = "0x185DC96A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9930", Offset = "0x5DC8D30", VA = "0x185DC9930")]
	public HHLJNONFIDL EAPFJHNHHBF(string HFCKFJICBCH)
	{
		return default(HHLJNONFIDL);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5DC98D0", Offset = "0x5DC8CD0", VA = "0x185DC98D0")]
	private List<NetworkedTransformEntity> EAPEJMMLBEN(GameObject IPAGFDLNMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9B30", Offset = "0x5DC8F30", VA = "0x185DC9B30")]
	public BICEKDGEPFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(PDAMHPLIJOI), new string[] { })]
public class PDAMHPLIJOI : PMEJGPCHMNC, NPIGPPEOCFI, CNJKPBKICBD, JAKEGKENGGK, DFFDMFBJPHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class HJCINPIMNPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public FJPIIIPDBML services;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public HJCINPIMNPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6990", Offset = "0x5DD5D90", VA = "0x185DD6990")]
		internal void FCLHLDKMGJG(JAKEGKENGGK svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class NPALLLJHDLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public FJPIIIPDBML services;

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public NPALLLJHDLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE59F0", Offset = "0x5DE4DF0", VA = "0x185DE59F0")]
		internal void CBFBLFOPAHK(DFFDMFBJPHA svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[MFFAOKEGCNH]
	private KDBONONDPOD DBDNLFIDLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[MFFAOKEGCNH]
	private CCCMOPCHHIG JHCNLBAHAJP;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public LIODKINLCHA AMMFAOAPGAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7DBA00", Offset = "0x7DAE00", VA = "0x1807DBA00", Slot = "4")]
		get
		{
			return default(LIODKINLCHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9580", Offset = "0x5DE8980", VA = "0x185DE9580", Slot = "5")]
	public void LCOGFKBGGFM(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9380", Offset = "0x5DE8780", VA = "0x185DE9380", Slot = "6")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE94A0", Offset = "0x5DE88A0", VA = "0x185DE94A0", Slot = "7")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9610", Offset = "0x5DE8A10", VA = "0x185DE9610", Slot = "8")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9260", Offset = "0x5DE8660", VA = "0x185DE9260", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x2508C60", Offset = "0x2508060", VA = "0x182508C60")]
	private void PJLIDEOLAMA<T>(Action<T> PEJKPAHFHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public PDAMHPLIJOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[PNAJALIKCOM(typeof(BBAOLHNDKHB), new string[] { })]
[DefaultMember("Item")]
public class KOGCJJFBJGI : BBAOLHNDKHB, IEnumerable<EHEMBOJPNLK>, IEnumerable, NPIGPPEOCFI, CNJKPBKICBD, JAKEGKENGGK, DFFDMFBJPHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[MFFAOKEGCNH]
	private JDPIAIPAMHN MFEJFLABCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly Dictionary<(Type, string), int> PMBCLFDNBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeBitArray LMBEKNKBCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> JEJMMNNEKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private CIOPCHIHJBP KIONOGFAMJM;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public NativeBitArray MBLELDIBBCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xD62290", Offset = "0xD61690", VA = "0x180D62290", Slot = "4")]
		get
		{
			return default(NativeBitArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public NativeArray<int> MNKLPNONHEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xD76A70", Offset = "0xD75E70", VA = "0x180D76A70", Slot = "5")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private int DLPGAIMPNNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x84AC70", Offset = "0x84A070", VA = "0x18084AC70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x5DD9B10", Offset = "0x5DD8F10", VA = "0x185DD9B10", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public EHEMBOJPNLK LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x5DD9F00", Offset = "0x5DD9300", VA = "0x185DD9F00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public EHEMBOJPNLK LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x5DD9F00", Offset = "0x5DD9300", VA = "0x185DD9F00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA870", Offset = "0x5DD9C70", VA = "0x185DDA870", Slot = "13")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA8C0", Offset = "0x5DD9CC0", VA = "0x185DDA8C0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "15")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9F20", Offset = "0x5DD9320", VA = "0x185DD9F20")]
	private void FHLGIHAGOGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA940", Offset = "0x5DD9D40", VA = "0x185DDA940", Slot = "9")]
	public EHEMBOJPNLK KIODCLFIOFD(PGMBACGNAAP IHPCGCBJCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9DB0", Offset = "0x5DD91B0", VA = "0x185DD9DB0")]
	private bool EBJCICNIPOH(Type DFGIDJLDNDK, string LFAIHEECJFK, [Out] EHEMBOJPNLK NPHJLOJKBMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9B30", Offset = "0x5DD8F30", VA = "0x185DD9B30", Slot = "10")]
	public EAAMNLEDMLN CKOILIBPNJH(PGMBACGNAAP IHPCGCBJCJP)
	{
		return default(EAAMNLEDMLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA850", Offset = "0x5DD9C50", VA = "0x185DDA850", Slot = "11")]
	public IEnumerator<EHEMBOJPNLK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA850", Offset = "0x5DD9C50", VA = "0x185DDA850", Slot = "12")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9D60", Offset = "0x5DD9160", VA = "0x185DD9D60", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAAF0", Offset = "0x5DD9EF0", VA = "0x185DDAAF0")]
	public KOGCJJFBJGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[PNAJALIKCOM(typeof(IIALBECIDBK), new string[] { })]
[DefaultMember("Item")]
public class KADBEMKGHMJ : IIALBECIDBK, IEnumerable<IELJJLAMLND>, IEnumerable, NPIGPPEOCFI, CNJKPBKICBD, JAKEGKENGGK, DFFDMFBJPHA, AIBPBKLFHPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[MFFAOKEGCNH]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[MFFAOKEGCNH]
	private BBAOLHNDKHB CFEJKNDCHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private IELJJLAMLND[] OMMKBPADNDK;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x52A1E90", Offset = "0x52A1290", VA = "0x1852A1E90", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public IELJJLAMLND LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5DD9350", Offset = "0x5DD8750", VA = "0x185DD9350", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "10")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9460", Offset = "0x5DD8860", VA = "0x185DD9460", Slot = "11")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "12")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9740", Offset = "0x5DD8B40", VA = "0x185DD9740", Slot = "6")]
	public IELJJLAMLND KIODCLFIOFD(PGMBACGNAAP IHPCGCBJCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9150", Offset = "0x5DD8550", VA = "0x185DD9150", Slot = "7")]
	public EAAMNLEDMLN CKOILIBPNJH(PGMBACGNAAP IHPCGCBJCJP)
	{
		return default(EAAMNLEDMLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9380", Offset = "0x5DD8780", VA = "0x185DD9380", Slot = "8")]
	public IEnumerator<IELJJLAMLND> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9860", Offset = "0x5DD8C60", VA = "0x185DD9860", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x2410010", Offset = "0x240F410", VA = "0x182410010", Slot = "13")]
	public void DEOLGDEJGCG<TKey, T>(MGPJIDJKJFM<TKey, T> ANNDMLIIDLL, [Optional] object FJHKACIMEOO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9220", Offset = "0x5DD8620", VA = "0x185DD9220", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public KADBEMKGHMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9350", Offset = "0x5DD8750", VA = "0x185DD9350")]
	[CompilerGenerated]
	private IELJJLAMLND HJDCFHAKJMM(int KEFLNPGBJEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
[PNAJALIKCOM(typeof(BEIEPOGCFMG), new string[] { })]
public class NJMJLJKHAKM : BEIEPOGCFMG, IEnumerable<ADLHMGAHKNA>, IEnumerable, JAKEGKENGGK, DFFDMFBJPHA, AIBPBKLFHPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	[MFFAOKEGCNH]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	[MFFAOKEGCNH]
	private BBAOLHNDKHB CFEJKNDCHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private ADLHMGAHKNA[] OMMKBPADNDK;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DE2EF0", Offset = "0x5DE22F0", VA = "0x185DE2EF0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public ADLHMGAHKNA LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x5DE30B0", Offset = "0x5DE24B0", VA = "0x185DE30B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE31D0", Offset = "0x5DE25D0", VA = "0x185DE31D0", Slot = "10")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3420", Offset = "0x5DE2820", VA = "0x185DE3420", Slot = "11")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3240", Offset = "0x5DE2640", VA = "0x185DE3240")]
	private ADLHMGAHKNA JGEBALNIMAL(int APOENOPNHBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3300", Offset = "0x5DE2700", VA = "0x185DE3300", Slot = "6")]
	public ADLHMGAHKNA KIODCLFIOFD(PGMBACGNAAP IHPCGCBJCJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2F40", Offset = "0x5DE2340", VA = "0x185DE2F40", Slot = "7")]
	public EAAMNLEDMLN CKOILIBPNJH(PGMBACGNAAP IHPCGCBJCJP)
	{
		return default(EAAMNLEDMLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE30C0", Offset = "0x5DE24C0", VA = "0x185DE30C0", Slot = "8")]
	public IEnumerator<ADLHMGAHKNA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE30C0", Offset = "0x5DE24C0", VA = "0x185DE30C0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x24D7AE0", Offset = "0x24D6EE0", VA = "0x1824D7AE0", Slot = "12")]
	public void DEOLGDEJGCG<TKey, T>(MGPJIDJKJFM<TKey, T> ANNDMLIIDLL, [Optional] object FJHKACIMEOO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3010", Offset = "0x5DE2410", VA = "0x185DE3010", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public NJMJLJKHAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE30B0", Offset = "0x5DE24B0", VA = "0x185DE30B0")]
	[CompilerGenerated]
	private ADLHMGAHKNA HJDCFHAKJMM(int KEFLNPGBJEJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[PNAJALIKCOM(typeof(JDPIAIPAMHN), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
internal class JDPIAIPAMHN : JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private BBAOLHNDKHB CFEJKNDCHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private BEIEPOGCFMG JHKJDLGECCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private IIALBECIDBK IPJMPPLPMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	[MFFAOKEGCNH]
	private CCCMOPCHHIG JHCNLBAHAJP;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public CIOPCHIHJBP BFIPMNBDDMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x75C7E0", Offset = "0x75BBE0", VA = "0x18075C7E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x75C520", Offset = "0x75B920", VA = "0x18075C520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DD83F0", Offset = "0x5DD77F0", VA = "0x185DD83F0", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8540", Offset = "0x5DD7940", VA = "0x185DD8540")]
	private void LDAEGAFMCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8320", Offset = "0x5DD7720", VA = "0x185DD8320")]
	public EHEMBOJPNLK EKJIKMCFLAD(PGMBACGNAAP LFAIHEECJFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x23EFD90", Offset = "0x23EF190", VA = "0x1823EFD90")]
	public GMNCHCCNINB<T> JDFFFKJBPIJ<T>(PGMBACGNAAP LFAIHEECJFK) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public JDPIAIPAMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal static class CKPBAMCJGKN
{
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x220C920", Offset = "0x220BD20", VA = "0x18220C920")]
	public static PJFEPPCEHDM<T> EKJIKMCFLAD<T>(this JDPIAIPAMHN KMJIGIFKJHO, OFMDLNJBPPF<T> LFAIHEECJFK) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(OOMLCKJIEGP), new string[] { })]
public class OOMLCKJIEGP : CNJKPBKICBD, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	[MFFAOKEGCNH]
	private BGHOIHDELID FNDBOHEPMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool JDONGNKJIGP;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public TimeData ELPOFHMKADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8D30", Offset = "0x5DE8130", VA = "0x185DE8D30")]
		get
		{
			return default(TimeData);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8DF0", Offset = "0x5DE81F0", VA = "0x185DE8DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool NHDFIMLNCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7D0020", Offset = "0x7CF420", VA = "0x1807D0020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0xB934C0", Offset = "0xB928C0", VA = "0x180B934C0", Slot = "4")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8DA0", Offset = "0x5DE81A0", VA = "0x185DE8DA0", Slot = "5")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8E50", Offset = "0x5DE8250", VA = "0x185DE8E50")]
	public void LDAMFMPGLHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	public void APIJDKILEDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public OOMLCKJIEGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[PNAJALIKCOM(typeof(ANNGIPPNCGN), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
public class ANNGIPPNCGN : JAKEGKENGGK, DFFDMFBJPHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private AOIJIDDNGFE DKHFFJHAFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private IIALBECIDBK MFEJFLABCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private EAAMNLEDMLN[] HNGLHOJMLMK;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8500", Offset = "0x5DC7900", VA = "0x185DC8500", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DC8570", Offset = "0x5DC7970", VA = "0x185DC8570", Slot = "5")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DC83E0", Offset = "0x5DC77E0", VA = "0x185DC83E0")]
	public void IEGCLKDPKPE(IJFILFNCAOA JNPKHIBFGKN, bool EAJIBBKGJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public ANNGIPPNCGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[PNAJALIKCOM(typeof(MEEOILEJJHG), new string[] { })]
public sealed class CMPDADAOJDJ : MEEOILEJJHG, NPIGPPEOCFI, CNJKPBKICBD, JAKEGKENGGK, DFFDMFBJPHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class GGAFNIGNGJO : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x95E320", Offset = "0x95D720", VA = "0x18095E320", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x5DD4400", Offset = "0x5DD3800", VA = "0x185DD4400", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1B66460", Offset = "0x1B65860", VA = "0x181B66460")]
		[DebuggerHidden]
		public GGAFNIGNGJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x5DD4110", Offset = "0x5DD3510", VA = "0x185DD4110", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x5DD43B0", Offset = "0x5DD37B0", VA = "0x185DD43B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x5DD4300", Offset = "0x5DD3700", VA = "0x185DD4300", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x5DD4300", Offset = "0x5DD3700", VA = "0x185DD4300", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	[MFFAOKEGCNH]
	private BEIEPOGCFMG MFEJFLABCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly CKOCBJPEPBI LDEHBDCJHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<string, NAJBLPGIJLN> JLICFFCCGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly Dictionary<int, LBDCPCFBDCC> LLMBJIDENLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly List<ADLHMGAHKNA> PNBBKMBOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private JBLOAMOKHEB NHOMKCPDCKO;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public LBDCPCFBDCC EPDAJJCLAEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB880", Offset = "0x5DCAC80", VA = "0x185DCB880", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public List<ADLHMGAHKNA> EAALOBBKNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "9")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB500", Offset = "0x5DCA900", VA = "0x185DCB500", Slot = "10")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB8E0", Offset = "0x5DCACE0", VA = "0x185DCB8E0", Slot = "11")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB220", Offset = "0x5DCA620", VA = "0x185DCB220", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB470", Offset = "0x5DCA870", VA = "0x185DCB470", Slot = "6")]
	public bool IJHNFKABONC(ADLHMGAHKNA ANNDMLIIDLL, [Out] LBDCPCFBDCC KHCLELLAFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAE40", Offset = "0x5DCA240", VA = "0x185DCAE40")]
	private void DGJMOFCADHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB940", Offset = "0x5DCAD40", VA = "0x185DCB940")]
	private void MPOJICJGHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB410", Offset = "0x5DCA810", VA = "0x185DCB410")]
	private NAJBLPGIJLN HNEJFLHOCHC(string KMGDEPMFGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB880", Offset = "0x5DCAC80", VA = "0x185DCB880")]
	private NAJBLPGIJLN OFKLACLMIJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBB70", Offset = "0x5DCAF70", VA = "0x185DCBB70")]
	private NAJBLPGIJLN PNBMJHFKLCH(string KMGDEPMFGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DCABC0", Offset = "0x5DC9FC0", VA = "0x185DCABC0")]
	private NAJBLPGIJLN BEJPMFIKFBJ(string MLDHHBJPPMF, string KJAGMGIFCEM, [Optional] NAJBLPGIJLN EDNANOBKAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBAF0", Offset = "0x5DCAEF0", VA = "0x185DCBAF0")]
	[IteratorStateMachine(typeof(GGAFNIGNGJO))]
	private IEnumerable<(string, string)> OBKDONHIGOA(string KMGDEPMFGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB740", Offset = "0x5DCAB40", VA = "0x185DCB740")]
	private bool LADAMMCMABB(ADLHMGAHKNA ANNDMLIIDLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB560", Offset = "0x5DCA960", VA = "0x185DCB560")]
	private CKOCBJPEPBI JOGGELMADNC(ADLHMGAHKNA ANNDMLIIDLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB6F0", Offset = "0x5DCAAF0", VA = "0x185DCB6F0")]
	private CKOCBJPEPBI KKGFAEKJOAO(ADLHMGAHKNA ANNDMLIIDLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB380", Offset = "0x5DCA780", VA = "0x185DCB380")]
	private CKOCBJPEPBI HFOGDDANADA(ADLHMGAHKNA ANNDMLIIDLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x220D010", Offset = "0x220C410", VA = "0x18220D010")]
	private T GFMGEDDMGOG<T>(ADLHMGAHKNA ANNDMLIIDLL) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB790", Offset = "0x5DCAB90", VA = "0x185DCB790")]
	private FieldInfo MFKIMFLFCIH(ADLHMGAHKNA ANNDMLIIDLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB640", Offset = "0x5DCAA40", VA = "0x185DCB640", Slot = "7")]
	public void KIPDOAILNDA(ADLHMGAHKNA ANNDMLIIDLL, EOEOMGNNBCG HHDLGPINDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB2D0", Offset = "0x5DCA6D0", VA = "0x185DCB2D0", Slot = "8")]
	public void FOMBLDAJHNJ(ADLHMGAHKNA ANNDMLIIDLL, EOEOMGNNBCG HHDLGPINDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBE30", Offset = "0x5DCB230", VA = "0x185DCBE30")]
	public CMPDADAOJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5DCADB0", Offset = "0x5DCA1B0", VA = "0x185DCADB0")]
	[CompilerGenerated]
	private int DCCPADBBONO(ADLHMGAHKNA IFAOGMEBPFN, ADLHMGAHKNA DNPBOPMFFFF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class NAJBLPGIJLN : LBDCPCFBDCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public readonly string FAFGGKPBODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public readonly NAJBLPGIJLN EDNANOBKAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public readonly List<NAJBLPGIJLN> OHEAJJFNOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public readonly List<ADLHMGAHKNA> MFEJFLABCIK;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public string JCJIFLBLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public LBDCPCFBDCC PINIPGOECLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public IEnumerable<LBDCPCFBDCC> MPBAFNBOBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1490", Offset = "0x5DE0890", VA = "0x185DE1490")]
	public NAJBLPGIJLN(string LFAIHEECJFK, NAJBLPGIJLN EBFCMPBKGBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[PNAJALIKCOM(typeof(global::POGJBDCDPAC), new string[] { })]
internal class IOBBLNAECKO : global::POGJBDCDPAC, JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[MFFAOKEGCNH]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[MFFAOKEGCNH]
	private INAHANGECJF BEOJNJDKKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[MFFAOKEGCNH]
	private JDPIAIPAMHN MFEJFLABCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[MFFAOKEGCNH]
	private JBLOAMOKHEB LFANGALDMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Action<HDHIDMCJGCD> IOKENELNCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private PJFEPPCEHDM<Entity> EBFCMPBKGBM;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<HDHIDMCJGCD> FENGFCMOPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7930", Offset = "0x5DD6D30", VA = "0x185DD7930", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x5DD77C0", Offset = "0x5DD6BC0", VA = "0x185DD77C0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7AB0", Offset = "0x5DD6EB0", VA = "0x185DD7AB0", Slot = "6")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5DD76B0", Offset = "0x5DD6AB0", VA = "0x185DD76B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7930", Offset = "0x5DD6D30", VA = "0x185DD7930")]
	private void IPGDMBHJBNL(Action<HDHIDMCJGCD> EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5DD77C0", Offset = "0x5DD6BC0", VA = "0x185DD77C0")]
	private void HEAGCMENFHI(Action<HDHIDMCJGCD> EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7BF0", Offset = "0x5DD6FF0", VA = "0x185DD7BF0")]
	private void JPADJMIBBLJ(EOHKGDILIIA GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public IOBBLNAECKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
[PNAJALIKCOM(typeof(IFLEBCOIPGL), new string[] { })]
public class IFLEBCOIPGL : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[MFFAOKEGCNH]
	private LCMBOOHOIHL IIPKIJNFEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[MFFAOKEGCNH]
	private NPDDCFNIDFD ELLKMDOHNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[MFFAOKEGCNH]
	private JKDKKFNOEFN BJPNEBJACGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[MFFAOKEGCNH]
	private BCLKHHIKFMA PIOJMHPNEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7460", Offset = "0x5DD6860", VA = "0x185DD7460", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD73C0", Offset = "0x5DD67C0", VA = "0x185DD73C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD75A0", Offset = "0x5DD69A0", VA = "0x185DD75A0")]
	private void MPKKKMMFAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD73C0", Offset = "0x5DD67C0", VA = "0x185DD73C0")]
	private void ALALIBICPJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7410", Offset = "0x5DD6810", VA = "0x185DD7410")]
	private void GIGGDPEHGJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public IFLEBCOIPGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[PNAJALIKCOM(typeof(PEKDDHBDMJC), new string[] { })]
public class NMAJIBHNKHM : PEKDDHBDMJC, JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[MFFAOKEGCNH]
	private INHGBAEAGHP NFFIAJHDGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[MFFAOKEGCNH]
	private CBGFAEGLCDH FGHLBPECDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<NativeListAsync<Entity>> PKKHEMBJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<(NativeListAsync<Entity>, bool)> ICAPADDFOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private ALICEELGBJJ MBJAGJOJNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private Dictionary<Entity, EMBPHMDELIE> GIJAPGEIOCA;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4D90", Offset = "0x5DE4190", VA = "0x185DE4D90", Slot = "8")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5770", Offset = "0x5DE4B70", VA = "0x185DE5770", Slot = "4")]
	public void POMJFPJAFIK(NativeListAsync<Entity> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5DE48B0", Offset = "0x5DE3CB0", VA = "0x185DE48B0", Slot = "5")]
	public void DIACDPMKCGH(ALICEELGBJJ MBJAGJOJNGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4E00", Offset = "0x5DE4200", VA = "0x185DE4E00", Slot = "6")]
	public void KHOAJGCEOIA(NativeListAsync<Entity> BAPHNAADJCK, bool LECAJJLHOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5DE51D0", Offset = "0x5DE45D0", VA = "0x185DE51D0", Slot = "7")]
	public void OMEJLLCLAPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4900", Offset = "0x5DE3D00", VA = "0x185DE4900", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4670", Offset = "0x5DE3A70", VA = "0x185DE4670")]
	private int DHEGIICDBFD(NativeListAsync<Entity> PKKHEMBJFNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4F30", Offset = "0x5DE4330", VA = "0x185DE4F30")]
	private int NMNPLKNGHHL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5550", Offset = "0x5DE4950", VA = "0x185DE5550")]
	private int PNKDDKCMCHM(NativeListAsync<Entity> ICAPADDFOJH, bool HPGCDJNJIFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE58D0", Offset = "0x5DE4CD0", VA = "0x185DE58D0")]
	public NMAJIBHNKHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE51A0", Offset = "0x5DE45A0", VA = "0x185DE51A0")]
	[CompilerGenerated]
	private LHNHNFAONOD OENMNPAIPNB(Entity FILKDLNBIJH)
	{
		return default(LHNHNFAONOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[PNAJALIKCOM(typeof(KNNEEHBELFI), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public class KNNEEHBELFI : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly List<NativeListAsync<LLAEKIFBGBP>> LNBEBDFNDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5E03100", Offset = "0x5E02500", VA = "0x185E03100", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x5E03150", Offset = "0x5E02550", VA = "0x185E03150")]
	public void JGAABGHHMEA(NativeListAsync<LLAEKIFBGBP> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x5E02D00", Offset = "0x5E02100", VA = "0x185E02D00")]
	public void IHNOFAKDIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5E02B80", Offset = "0x5E01F80", VA = "0x185E02B80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x5E032B0", Offset = "0x5E026B0", VA = "0x185E032B0")]
	public KNNEEHBELFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[PNAJALIKCOM(typeof(CNCGGMKKCEC), new string[] { })]
public class LKKKACGGNME : JAKEGKENGGK, CNCGGMKKCEC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private EntityManager OKJDPAMBACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private FGAHOPPNDBO CKMMCHOMIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private CBGFAEGLCDH FGHLBPECDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5E038E0", Offset = "0x5E02CE0", VA = "0x185E038E0", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5E03870", Offset = "0x5E02C70", VA = "0x185E03870", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x5E03A50", Offset = "0x5E02E50", VA = "0x185E03A50", Slot = "5")]
	public bool NPMDNODOMAK(LHNHNFAONOD PIBFDGEOBKF, [Out] Collider LIMGOFLBOKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x5E036B0", Offset = "0x5E02AB0", VA = "0x185E036B0", Slot = "6")]
	public GameObject BIKAELNLAIF(LHNHNFAONOD LBOIPBILOBM, GameObject IJEONFKHLHI, Vector3 DPHLBKLFIPE, Quaternion CMOGOLPKHJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5E039B0", Offset = "0x5E02DB0", VA = "0x185E039B0", Slot = "7")]
	public void NIEAMCEDOJE(GameObject LIMGOFLBOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2450400", Offset = "0x244F800", VA = "0x182450400", Slot = "8")]
	public TCollider NMPPGADILKK<TCollider>(GameObject BPIILIEHLBN) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x5E03880", Offset = "0x5E02C80", VA = "0x185E03880", Slot = "9")]
	public void IPBAPBJJHCH(Collider LIMGOFLBOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x2450400", Offset = "0x244F800", VA = "0x182450400", Slot = "10")]
	public GameObject EIJOBENKDBN<TCollider>(string LFAIHEECJFK) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LKKKACGGNME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[PNAJALIKCOM(typeof(JICJPEPDNGF), new string[] { })]
public class CFMFPFMBMGH : JAKEGKENGGK, JICJPEPDNGF
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private KFJHDAOPGPA IHBAGGIDMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private World MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private DBCNAFKJFFO OAPFBONNKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[MFFAOKEGCNH]
	private BGHOIHDELID FNDBOHEPMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private EntityManager NMLBDJPHHPB;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF16D0", Offset = "0x5DF0AD0", VA = "0x185DF16D0", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2B60", Offset = "0x5DF1F60", VA = "0x185DF2B60", Slot = "6")]
	public CMHAFMKPEIJ NKKGNGNDAOD(LHNHNFAONOD PIBFDGEOBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFC50", Offset = "0x5DEF050", VA = "0x185DEFC50", Slot = "5")]
	public void CFMBDFNIABC(LHNHNFAONOD PIBFDGEOBKF, CMHAFMKPEIJ EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFD80", Offset = "0x5DEF180", VA = "0x185DEFD80", Slot = "31")]
	public CollisionDetectionMode DBJEKCCKJIA(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(CollisionDetectionMode);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2070", Offset = "0x5DF1470", VA = "0x185DF2070", Slot = "32")]
	public void LIEAHOEPIAF(LHNHNFAONOD PIBFDGEOBKF, CollisionDetectionMode EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFA60", Offset = "0x5DEEE60", VA = "0x185DEFA60", Slot = "33")]
	public CEAJINAKHIE BJKJLIKDDPO(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(CEAJINAKHIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0CF0", Offset = "0x5DF00F0", VA = "0x185DF0CF0", Slot = "34")]
	public void FKMDIJHJAAD(LHNHNFAONOD PIBFDGEOBKF, CEAJINAKHIE EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF430", Offset = "0x5DEE830", VA = "0x185DEF430", Slot = "35")]
	public bool AAPAPHCMAMN(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFED0", Offset = "0x5DEF2D0", VA = "0x185DEFED0", Slot = "36")]
	public void DCGLNLHGILI(LHNHNFAONOD PIBFDGEOBKF, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2AC0", Offset = "0x5DF1EC0", VA = "0x185DF2AC0", Slot = "37")]
	public LHNHNFAONOD NKAFPNBHAEE(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1D10", Offset = "0x5DF1110", VA = "0x185DF1D10", Slot = "38")]
	public void KOLJIHDPMJA(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2BF0", Offset = "0x5DF1FF0", VA = "0x185DF2BF0", Slot = "39")]
	public LHNHNFAONOD OBHLIPJDBGF(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1390", Offset = "0x5DF0790", VA = "0x185DF1390", Slot = "40")]
	public void HEBPNKMJKGE(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0B10", Offset = "0x5DEFF10", VA = "0x185DF0B10", Slot = "7")]
	public void FFDAFIGKKAE(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF4B0", Offset = "0x5DEE8B0", VA = "0x185DEF4B0", Slot = "8")]
	public void AEELOJHOFOJ(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFE00", Offset = "0x5DEF200", VA = "0x185DEFE00", Slot = "9")]
	public int DBNHBIOACAG(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1870", Offset = "0x5DF0C70", VA = "0x185DF1870", Slot = "10")]
	public LHNHNFAONOD JENKCCNLLLH(LHNHNFAONOD PIBFDGEOBKF, int APOENOPNHBG)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF10D0", Offset = "0x5DF04D0", VA = "0x185DF10D0", Slot = "11")]
	public void GNNLBIGHJPL(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1430", Offset = "0x5DF0830", VA = "0x185DF1430", Slot = "12")]
	public void HFAKOAMCFCM(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM, LHNHNFAONOD EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2E10", Offset = "0x5DF2210", VA = "0x185DF2E10", Slot = "13")]
	public void PBKBIAAKFOK(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x5DF02B0", Offset = "0x5DEF6B0", VA = "0x185DF02B0", Slot = "14")]
	public bool DOKPCFMHEEC(LHNHNFAONOD PIBFDGEOBKF, [Out] LHNHNFAONOD EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0700", Offset = "0x5DEFB00", VA = "0x185DF0700", Slot = "15")]
	public void EKLHCMIFDPE(LHNHNFAONOD PIBFDGEOBKF, float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1F10", Offset = "0x5DF1310", VA = "0x185DF1F10", Slot = "16")]
	public bool LGAFBGDOKIE(LHNHNFAONOD PIBFDGEOBKF, [Out] float3 EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5DF15A0", Offset = "0x5DF09A0", VA = "0x185DF15A0", Slot = "17")]
	public void IHNNMEFMLGK(LHNHNFAONOD PIBFDGEOBKF, float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0150", Offset = "0x5DEF550", VA = "0x185DF0150", Slot = "18")]
	public bool DNONFOBIGIA(LHNHNFAONOD PIBFDGEOBKF, [Out] float3 EOHMJBFGDPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0DA0", Offset = "0x5DF01A0", VA = "0x185DF0DA0", Slot = "23")]
	[Obsolete("Use SetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	public float3 FNIOJMPIAFN(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2100", Offset = "0x5DF1500", VA = "0x185DF2100", Slot = "24")]
	public float3 LJNKJPFBHGN(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF770", Offset = "0x5DEEB70", VA = "0x185DEF770", Slot = "25")]
	public void ALLOCBBAFBA(LHNHNFAONOD PIBFDGEOBKF, float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0A00", Offset = "0x5DEFE00", VA = "0x185DF0A00", Slot = "26")]
	public void FBPHLPGMKGG(LHNHNFAONOD PIBFDGEOBKF, float3 EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2280", Offset = "0x5DF1680", VA = "0x185DF2280", Slot = "27")]
	[Obsolete("Use GetMassOfSelf or TryGetMassOfHierarchy")]
	public float MEBCLADPJON(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1310", Offset = "0x5DF0710", VA = "0x185DF1310", Slot = "28")]
	public float HDPIINGMNCD(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0050", Offset = "0x5DEF450", VA = "0x185DF0050", Slot = "29")]
	public void DHMNCGOFAEM(LHNHNFAONOD PIBFDGEOBKF, float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFF40", Offset = "0x5DEF340", VA = "0x185DEFF40", Slot = "30")]
	public void DELCPHKJAGF(LHNHNFAONOD PIBFDGEOBKF, float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF04F0", Offset = "0x5DEF8F0", VA = "0x185DF04F0", Slot = "19")]
	public void EEHJEBMJHPL(LHNHNFAONOD PIBFDGEOBKF, (Quaternion rot, Vector3 moments) NCNIHGBNECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2460", Offset = "0x5DF1860", VA = "0x185DF2460", Slot = "20")]
	public bool MMDMNIPAEBP(LHNHNFAONOD PIBFDGEOBKF, [Out] quaternion OCCLANFLOLP, [Out] float3 KBOPNEPIKHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2EA0", Offset = "0x5DF22A0", VA = "0x185DF2EA0", Slot = "41")]
	public NCDNMOIPOGI PHFFJLGBGPA(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(NCDNMOIPOGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1B20", Offset = "0x5DF0F20", VA = "0x185DF1B20", Slot = "42")]
	public void KIDAFGHOIEO(LHNHNFAONOD PIBFDGEOBKF, NCDNMOIPOGI EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2D30", Offset = "0x5DF2130", VA = "0x185DF2D30", Slot = "66")]
	public void OGDCEDLIDCN(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0970", Offset = "0x5DEFD70", VA = "0x185DF0970", Slot = "67")]
	public void EOLHBLFGOIH(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5DF27C0", Offset = "0x5DF1BC0", VA = "0x185DF27C0", Slot = "68")]
	public bool MPFBAHEDAOG(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5DF11A0", Offset = "0x5DF05A0", VA = "0x185DF11A0", Slot = "82")]
	public bool HCGHILJJDJE(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0F20", Offset = "0x5DF0320", VA = "0x185DF0F20", Slot = "83")]
	public void GNJIIEEEEDB(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM, bool LLALDMDCIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFD10", Offset = "0x5DEF110", VA = "0x185DEFD10", Slot = "84")]
	public void DALMGKGAGEM(LHNHNFAONOD PIBFDGEOBKF, bool CAFHFPCMBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0AA0", Offset = "0x5DEFEA0", VA = "0x185DF0AA0", Slot = "86")]
	public bool FDEDIMAFEMP(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF12A0", Offset = "0x5DF06A0", VA = "0x185DF12A0", Slot = "85")]
	public void HCHAOIHMJIC(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF03F0", Offset = "0x5DEF7F0", VA = "0x185DF03F0", Slot = "43")]
	public bool EAMMPCLOOHK(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1C30", Offset = "0x5DF1030", VA = "0x185DF1C30", Slot = "44")]
	public void KKLECDBKGCO(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF17F0", Offset = "0x5DF0BF0", VA = "0x185DF17F0", Slot = "45")]
	public bool JBHGBMFDAIE(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0EB0", Offset = "0x5DF02B0", VA = "0x185DF0EB0", Slot = "46")]
	public void GIAKMJLHIKB(LHNHNFAONOD PIBFDGEOBKF, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFFD0", Offset = "0x5DEF3D0", VA = "0x185DEFFD0", Slot = "47")]
	public bool DELEGAJMBFC(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0C80", Offset = "0x5DF0080", VA = "0x185DF0C80", Slot = "48")]
	public void FJGKBLBAHDD(LHNHNFAONOD PIBFDGEOBKF, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x5DF08F0", Offset = "0x5DEFCF0", VA = "0x185DF08F0", Slot = "49")]
	public RigidbodyConstraints ENAICEEAFPC(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(RigidbodyConstraints);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1640", Offset = "0x5DF0A40", VA = "0x185DF1640", Slot = "50")]
	public void IIGMMCGGNOF(LHNHNFAONOD PIBFDGEOBKF, RigidbodyConstraints EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1970", Offset = "0x5DF0D70", VA = "0x185DF1970", Slot = "51")]
	public float JKJAIJBIBME(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x5DF28E0", Offset = "0x5DF1CE0", VA = "0x185DF28E0", Slot = "52")]
	public void NGNNHKCHEHC(LHNHNFAONOD PIBFDGEOBKF, float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0680", Offset = "0x5DEFA80", VA = "0x185DF0680", Slot = "53")]
	public float EHHFBLEHLHA(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFB40", Offset = "0x5DEEF40", VA = "0x185DEFB40", Slot = "54")]
	public void BJNPHPDGCFC(LHNHNFAONOD PIBFDGEOBKF, float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2F20", Offset = "0x5DF2320", VA = "0x185DF2F20", Slot = "55")]
	public bool PKCMOBNKNCE(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2210", Offset = "0x5DF1610", VA = "0x185DF2210", Slot = "56")]
	public void MCGKMBKEFBG(LHNHNFAONOD PIBFDGEOBKF, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1BB0", Offset = "0x5DF0FB0", VA = "0x185DF1BB0", Slot = "57")]
	public bool KIHGPNOJIHJ(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF00E0", Offset = "0x5DEF4E0", VA = "0x185DF00E0", Slot = "58")]
	public void DNIGOFOHCFD(LHNHNFAONOD PIBFDGEOBKF, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0BF0", Offset = "0x5DEFFF0", VA = "0x185DF0BF0", Slot = "59")]
	public void FHBEPFANBOA(LHNHNFAONOD PIBFDGEOBKF, int EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF9D0", Offset = "0x5DEEDD0", VA = "0x185DEF9D0", Slot = "73")]
	public Rigidbody BGAOOHMGOIM(LHNHNFAONOD PIBFDGEOBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2970", Offset = "0x5DF1D70", VA = "0x185DF2970", Slot = "74")]
	public void NHHBLLLHJEM(LHNHNFAONOD PIBFDGEOBKF, Rigidbody EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFBD0", Offset = "0x5DEEFD0", VA = "0x185DEFBD0", Slot = "75")]
	public void CEDEMEPPALB(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF23D0", Offset = "0x5DF17D0", VA = "0x185DF23D0", Slot = "76")]
	public void MLKIEMGEEPP(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1530", Offset = "0x5DF0930", VA = "0x185DF1530", Slot = "77")]
	public bool IBGGLOFOHOD(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2FA0", Offset = "0x5DF23A0", VA = "0x185DF2FA0", Slot = "60")]
	public object POCPOFDJAFJ(LHNHNFAONOD PIBFDGEOBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x5DF07A0", Offset = "0x5DEFBA0", VA = "0x185DF07A0", Slot = "61")]
	public void EMHIDPNLLKP(LHNHNFAONOD PIBFDGEOBKF, object EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x5DF19F0", Offset = "0x5DF0DF0", VA = "0x185DF19F0", Slot = "62")]
	public object JNIMDHBEHBN(LHNHNFAONOD PIBFDGEOBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF620", Offset = "0x5DEEA20", VA = "0x185DEF620", Slot = "63")]
	public void AJOGOGKKFHM(LHNHNFAONOD PIBFDGEOBKF, object EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1C90", Offset = "0x5DF1090", VA = "0x185DF1C90", Slot = "64")]
	public float KMFOJECMJHJ(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF890", Offset = "0x5DEEC90", VA = "0x185DEF890", Slot = "65")]
	public void BCDCHHFFOGO(LHNHNFAONOD PIBFDGEOBKF, float EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF810", Offset = "0x5DEEC10", VA = "0x185DEF810", Slot = "69")]
	public void AMLBGEOKINK(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF590", Offset = "0x5DEE990", VA = "0x185DEF590", Slot = "70")]
	public void AFKEKFKEDIE(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5DF21A0", Offset = "0x5DF15A0", VA = "0x185DF21A0", Slot = "71")]
	public bool MAIIOABMNJE(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2370", Offset = "0x5DF1770", VA = "0x185DF2370", Slot = "21")]
	public void MKJCDBPNEAF(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2DB0", Offset = "0x5DF21B0", VA = "0x185DF2DB0", Slot = "22")]
	public void ONIFDHPLKKH(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0470", Offset = "0x5DEF870", VA = "0x185DF0470", Slot = "72")]
	public bool EBHKBMGOCAE(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2C90", Offset = "0x5DF2090", VA = "0x185DF2C90", Slot = "78")]
	public void OBMCHKENEKI(LHNHNFAONOD PIBFDGEOBKF, float3 GKMPFMKFGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1A80", Offset = "0x5DF0E80", VA = "0x185DF1A80", Slot = "79")]
	public void KIANPIHCKME(LHNHNFAONOD PIBFDGEOBKF, float3 BADJPOOCLHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1DB0", Offset = "0x5DF11B0", VA = "0x185DF1DB0", Slot = "80")]
	public bool KPLLMDCILFE(LHNHNFAONOD PIBFDGEOBKF, [Out] float3 GKMPFMKFGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2660", Offset = "0x5DF1A60", VA = "0x185DF2660", Slot = "81")]
	public bool MOMIMOCLPKO(LHNHNFAONOD PIBFDGEOBKF, [Out] float3 BADJPOOCLHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2830", Offset = "0x5DF1C30", VA = "0x185DF2830")]
	private DynamicBuffer<Entity> NALNMNCIGBF(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF920", Offset = "0x5DEED20", VA = "0x185DEF920")]
	private DynamicBuffer<Entity> BEIMEEJMOIN(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2203B80", Offset = "0x2202F80", VA = "0x182203B80")]
	private void PFPEBPAKCNE<T>(LHNHNFAONOD PIBFDGEOBKF, object EOHMJBFGDPD, Func<object, T> AEJHJMKCFCE) where T : class, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CFMFPFMBMGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
[PNAJALIKCOM(typeof(CGHDBGHDKLB), new string[] { })]
public class CGHDBGHDKLB : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class IPGKHDGHOML : IEnumerable<CMHAFMKPEIJ>, IEnumerable, IEnumerator<CMHAFMKPEIJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private CMHAFMKPEIJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public CGHDBGHDKLB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public NativeArray<Entity> <>3__entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private EntityManager <entityManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private NativeArray<Entity>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		private CMHAFMKPEIJ System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x870E50", Offset = "0x870250", VA = "0x180870E50")]
		[DebuggerHidden]
		public IPGKHDGHOML(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E00840", Offset = "0x5DFFC40", VA = "0x185E00840", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E00510", Offset = "0x5DFF910", VA = "0x185E00510", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E004C0", Offset = "0x5DFF8C0", VA = "0x185E004C0")]
		private void GIBBEMGHDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E007F0", Offset = "0x5DFFBF0", VA = "0x185E007F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E00740", Offset = "0x5DFFB40", VA = "0x185E00740", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CMHAFMKPEIJ> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E00740", Offset = "0x5DFFB40", VA = "0x185E00740", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> JHAGJIDENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3D60", Offset = "0x5DF3160", VA = "0x185DF3D60", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3DB0", Offset = "0x5DF31B0", VA = "0x185DF3DB0")]
	public void JGAABGHHMEA(NativeArray<Entity> BAPHNAADJCK, bool AFFMGGHNOGK, bool NDIEKMGJBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3B20", Offset = "0x5DF2F20", VA = "0x185DF3B20")]
	public void IHNOFAKDIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x5DF31A0", Offset = "0x5DF25A0", VA = "0x185DF31A0")]
	private void BKOHMDDLHFI(NativeArray<Entity> BAPHNAADJCK, bool AFFMGGHNOGK, bool NDIEKMGJBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3110", Offset = "0x5DF2510", VA = "0x185DF3110")]
	[IteratorStateMachine(typeof(IPGKHDGHOML))]
	private IEnumerable<CMHAFMKPEIJ> ANFAEHLBAMH(NativeArray<Entity> BAPHNAADJCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF39B0", Offset = "0x5DF2DB0", VA = "0x185DF39B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3FA0", Offset = "0x5DF33A0", VA = "0x185DF3FA0")]
	public CGHDBGHDKLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[PNAJALIKCOM(typeof(OOHKDNCOFFD), new string[] { })]
public class BKOGKOEDAIA : OOHKDNCOFFD, JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private class BPIDGEHOIPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public List<CapsuleCollider> KBELDAKPCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public List<SphereCollider> GAKDDHONGPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public GameObject ENAMNNLOBOB;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF360", Offset = "0x5DEE760", VA = "0x185DEF360")]
		public BPIDGEHOIPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[MFFAOKEGCNH]
	private INHGBAEAGHP NFFIAJHDGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[MFFAOKEGCNH]
	private CNCGGMKKCEC FOFGLIKODGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly Dictionary<Entity, BPIDGEHOIPD> GDEILAIILMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private GameObject GFHCFAHJHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private GameObject DPJMMFALOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private GameObject DCLLGDLJCDH;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private GameObject GLAAHFGHBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE1D0", Offset = "0x5DED5D0", VA = "0x185DEE1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE160", Offset = "0x5DED560", VA = "0x185DEE160", Slot = "6")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE290", Offset = "0x5DED690", VA = "0x185DEE290", Slot = "4")]
	public void OEOEDOMKMEE(Entity OAKCPIKBPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDC10", Offset = "0x5DED010", VA = "0x185DEDC10", Slot = "5")]
	public void HNPMIIHHFAK(Entity OAKCPIKBPJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DED3F0", Offset = "0x5DEC7F0", VA = "0x185DED3F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DED7F0", Offset = "0x5DECBF0", VA = "0x185DED7F0")]
	private BPIDGEHOIPD GBECMEGIFLO(Entity OAKCPIKBPJF, JKEKDMMJELC ACICFHDBOLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE4D0", Offset = "0x5DED8D0", VA = "0x185DEE4D0")]
	private void OHANBDDPGDK(JKEKDMMJELC ACICFHDBOLC, BPIDGEHOIPD HKNAMNOHMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DED210", Offset = "0x5DEC610", VA = "0x185DED210")]
	private void DDKFBHAJKGM(JKEKDMMJELC ACICFHDBOLC, BPIDGEHOIPD HKNAMNOHMDG, int BPCNOHCBPIH, Vector3 LPAPEIIOLFG, Quaternion KBKHJHIFKGI, float NOEHIDPEPEC, float JLHCJGALPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDA50", Offset = "0x5DECE50", VA = "0x185DEDA50")]
	private void HELHMJCHDKG(BPIDGEHOIPD HKNAMNOHMDG, int AFPHDCOAICI, Vector3 LPAPEIIOLFG, float NOEHIDPEPEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DED510", Offset = "0x5DEC910", VA = "0x185DED510")]
	private void FJLPKLNKOME(JKEKDMMJELC ACICFHDBOLC, BPIDGEHOIPD HKNAMNOHMDG, int KMJDFMBCCKH, int ODJBELAHCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x21A3700", Offset = "0x21A2B00", VA = "0x1821A3700")]
	private T LFFLNEFIBFG<T>(JKEKDMMJELC ACICFHDBOLC, GameObject FOHPGKLHLGD, Vector3 DPHLBKLFIPE, Quaternion CMOGOLPKHJO) where T : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF0B0", Offset = "0x5DEE4B0", VA = "0x185DEF0B0")]
	public BKOGKOEDAIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[PNAJALIKCOM(typeof(AAJHNHAHHBB), new string[] { })]
public class DENIFLEGBGE : JAKEGKENGGK, DFFDMFBJPHA, AAJHNHAHHBB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private NMDHGCKCBIM BEOJNJDKKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private HABDGJEIGLI MDPJPABGGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private JBLOAMOKHEB NHOMKCPDCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private LANAGADPHLA JKDMDKEOPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private int FCEIEDCDKGB;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool PELLJEJNJAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8B80", Offset = "0x5DF7F80", VA = "0x185DF8B80", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public LHNHNFAONOD HKNOHNEGJBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8990", Offset = "0x5DF7D90", VA = "0x185DF8990", Slot = "9")]
		get
		{
			return default(LHNHNFAONOD);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x5DF89B0", Offset = "0x5DF7DB0", VA = "0x185DF89B0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public FDLKIDLAABP PBPMJEHLHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8730", Offset = "0x5DF7B30", VA = "0x185DF8730", Slot = "11")]
		get
		{
			return default(FDLKIDLAABP);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5DF89B0", Offset = "0x5DF7DB0", VA = "0x185DF89B0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private uint NLMDKCJIAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5DF86E0", Offset = "0x5DF7AE0", VA = "0x185DF86E0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event HJMEDKOBEMC NAAAAHPDOKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5DF83E0", Offset = "0x5DF77E0", VA = "0x185DF83E0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8640", Offset = "0x5DF7A40", VA = "0x185DF8640", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF88C0", Offset = "0x5DF7CC0", VA = "0x185DF88C0", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8BB0", Offset = "0x5DF7FB0", VA = "0x185DF8BB0", Slot = "5")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8550", Offset = "0x5DF7950", VA = "0x185DF8550", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8DF0", Offset = "0x5DF81F0", VA = "0x185DF8DF0")]
	private void PHGGJNHJPGB(EOHKGDILIIA GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8480", Offset = "0x5DF7880", VA = "0x185DF8480", Slot = "13")]
	public LHNHNFAONOD BOFEBEAMOOA(LHNHNFAONOD BGICHGONLEL, LHNHNFAONOD AGPMPKBMMOB)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8760", Offset = "0x5DF7B60", VA = "0x185DF8760", Slot = "14")]
	public bool GKMCHOHAPGM(LHNHNFAONOD BGICHGONLEL, LHNHNFAONOD AGPMPKBMMOB, [Out] LHNHNFAONOD MAKPPJALCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8A20", Offset = "0x5DF7E20", VA = "0x185DF8A20", Slot = "15")]
	public void KPLJFDBPDIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8850", Offset = "0x5DF7C50", VA = "0x185DF8850", Slot = "16")]
	public void HAJNBHAPBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DF82C0", Offset = "0x5DF76C0", VA = "0x185DF82C0", Slot = "17")]
	public bool AALEPNHGOIH(LHNHNFAONOD BGICHGONLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8D40", Offset = "0x5DF8140", VA = "0x185DF8D40", Slot = "18")]
	public bool NPLPGEABKJO(LHNHNFAONOD BGICHGONLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF89B0", Offset = "0x5DF7DB0", VA = "0x185DF89B0")]
	private void KFINLDOJPMF(LHNHNFAONOD POOALLOAFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public DENIFLEGBGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[PNAJALIKCOM(typeof(LIHDLACLGHM), new string[] { })]
public class HJKLDDHMIOB : JAKEGKENGGK, LIHDLACLGHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private EntityManager OKJDPAMBACM;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFC50", Offset = "0x5DFF050", VA = "0x185DFFC50", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFCD0", Offset = "0x5DFF0D0", VA = "0x185DFFCD0", Slot = "5")]
	public void MHFHGHHLHAL(LHNHNFAONOD GIPGBEGNLCD, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x23A87C0", Offset = "0x23A7BC0", VA = "0x1823A87C0")]
	private void GMFKOPHMECD<T>(LHNHNFAONOD GIPGBEGNLCD, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public HJKLDDHMIOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[PNAJALIKCOM(typeof(NLJBCKCCFIP), new string[] { })]
public class MBOCJNBMIBI : JAKEGKENGGK, NLJBCKCCFIP
{
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private EntityManager OKJDPAMBACM;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E03E70", Offset = "0x5E03270", VA = "0x185E03E70", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E03EF0", Offset = "0x5E032F0", VA = "0x185E03EF0", Slot = "5")]
	public void JOCHLFPDDND(LHNHNFAONOD GIPGBEGNLCD, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E03D30", Offset = "0x5E03130", VA = "0x185E03D30", Slot = "6")]
	public void EPGINAPDJGB(LHNHNFAONOD GIPGBEGNLCD, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E03D90", Offset = "0x5E03190", VA = "0x185E03D90", Slot = "7")]
	public void FMMPNIGDDAH(LHNHNFAONOD GIPGBEGNLCD, int EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x246AD10", Offset = "0x246A110", VA = "0x18246AD10")]
	private void GMFKOPHMECD<T>(LHNHNFAONOD GIPGBEGNLCD, bool EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x246AE70", Offset = "0x246A270", VA = "0x18246AE70")]
	private void GMFKOPHMECD<T>(LHNHNFAONOD GIPGBEGNLCD, T GHFAAPNAFDE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MBOCJNBMIBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[PNAJALIKCOM(typeof(FBEBFKELNNN), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public class FBEBFKELNNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly Dictionary<AFADFPDANEE, string> MLKHBKBJKGC;

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCA30", Offset = "0x5DFBE30", VA = "0x185DFCA30")]
	public GameObject PPPILOMHMGN(AFADFPDANEE PDALIFDBDDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCB00", Offset = "0x5DFBF00", VA = "0x185DFCB00")]
	public FBEBFKELNNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
[PNAJALIKCOM(typeof(KKLDOKNCECL), new string[] { })]
internal class KKLDOKNCECL : JAKEGKENGGK, DFFDMFBJPHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private KFJHDAOPGPA IHBAGGIDMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private PJFEPPCEHDM<Entity> EBFCMPBKGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private BCLKHHIKFMA AMEAOOFACPA;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E02120", Offset = "0x5E01520", VA = "0x185E02120", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E02190", Offset = "0x5E01590", VA = "0x185E02190", Slot = "5")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E01F40", Offset = "0x5E01340", VA = "0x185E01F40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E01FE0", Offset = "0x5E013E0", VA = "0x185E01FE0")]
	private void HFMLFIPCEIG(Entity FILKDLNBIJH, [In] IBIHAHCALHC LEMLHJJLMCO, [In] IBIHAHCALHC BDDLEBIAAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public KKLDOKNCECL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[DefaultMember("Item")]
public class MHFGMHKAEGP<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
public class LGHMHPPOMBB<From, To>
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[DefaultMember("Item")]
public class GNKCCOIDKLO<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly Func<From, To> CCHLMEBMLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly Func<To, From> GMBHCDACILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public NativeArray<From> FFAHMFOPGLA;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public To LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x34FD770", Offset = "0x34FCB70", VA = "0x1834FD770", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x34FD7D0", Offset = "0x34FCBD0", VA = "0x1834FD7D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x34FD760", Offset = "0x34FCB60", VA = "0x1834FD760", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool LIGHAHNLJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x7785F0", Offset = "0x7779F0", VA = "0x1807785F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x76B3A0", Offset = "0x76A7A0", VA = "0x18076B3A0")]
	public GNKCCOIDKLO(Func<From, To> CCHLMEBMLJJ, Func<To, From> GMBHCDACILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x34FD2D0", Offset = "0x34FC6D0", VA = "0x1834FD2D0", Slot = "11")]
	public void Add(To JJEIFGHOKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x34FD320", Offset = "0x34FC720", VA = "0x1834FD320", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x34FD370", Offset = "0x34FC770", VA = "0x1834FD370", Slot = "13")]
	public bool Contains(To JJEIFGHOKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x34FD450", Offset = "0x34FC850", VA = "0x1834FD450", Slot = "14")]
	public void CopyTo(To[] FFAHMFOPGLA, int FJCKEJMMOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x34FD510", Offset = "0x34FC910", VA = "0x1834FD510", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x34FD5D0", Offset = "0x34FC9D0", VA = "0x1834FD5D0", Slot = "6")]
	public int IndexOf(To JJEIFGHOKOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x34FD670", Offset = "0x34FCA70", VA = "0x1834FD670", Slot = "7")]
	public void Insert(int APOENOPNHBG, To JJEIFGHOKOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x34FD710", Offset = "0x34FCB10", VA = "0x1834FD710", Slot = "15")]
	public bool Remove(To JJEIFGHOKOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x34FD6C0", Offset = "0x34FCAC0", VA = "0x1834FD6C0", Slot = "8")]
	public void RemoveAt(int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x32CE540", Offset = "0x32CD940", VA = "0x1832CE540", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct KCDFHGGGJDK : IComparable<KCDFHGGGJDK>, IEquatable<KCDFHGGGJDK>
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public static readonly KCDFHGGGJDK JCNACNONIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public IJFILFNCAOA GIPGBEGNLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public EAAMNLEDMLN KMKGEGCGMGD;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool AAMDFDDBPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E01BF0", Offset = "0x5E00FF0", VA = "0x185E01BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x982310", Offset = "0x981710", VA = "0x180982310")]
	public KCDFHGGGJDK(IJFILFNCAOA GIPGBEGNLCD, EAAMNLEDMLN KMKGEGCGMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E019E0", Offset = "0x5E00DE0", VA = "0x185E019E0", Slot = "4")]
	public int CompareTo(KCDFHGGGJDK LJIBJAOOGGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E01C00", Offset = "0x5E01000", VA = "0x185E01C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E01AF0", Offset = "0x5E00EF0", VA = "0x185E01AF0", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E01A60", Offset = "0x5E00E60", VA = "0x185E01A60", Slot = "5")]
	public bool Equals(KCDFHGGGJDK LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5E01B80", Offset = "0x5E00F80", VA = "0x185E01B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct DBJPCLJMDLL : IEnumerable<KCDFHGGGJDK>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum PBEAGKHMIBO
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public struct NHDOJBBDAEE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private NativeList<byte> GHFAAPNAFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private DBJPCLJMDLL KEKPLKHNJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly KCDFHGGGJDK OAGNBNMPALP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly int NBBMHNNJHFB;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x5E09140", Offset = "0x5E08540", VA = "0x185E09140")]
		internal NHDOJBBDAEE(DBJPCLJMDLL KEKPLKHNJAG, KCDFHGGGJDK OAGNBNMPALP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x5E08F10", Offset = "0x5E08310", VA = "0x185E08F10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5E08FA0", Offset = "0x5E083A0", VA = "0x185E08FA0")]
		public void LMPIAEGAAMD(ReadOnlySpan<byte> EOHMJBFGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x5E09040", Offset = "0x5E08440", VA = "0x185E09040")]
		private void PFCEOOPOAEA(ReadOnlySpan<byte> EOHMJBFGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5E090E0", Offset = "0x5E084E0", VA = "0x185E090E0")]
		private unsafe void PFCEOOPOAEA(void* CPNPELLBEAC, int KIHHOMBMMEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public struct KAGFDGBCCLB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private DBJPCLJMDLL KEKPLKHNJAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private NativeArray<byte> GHFAAPNAFDE;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x5E01990", Offset = "0x5E00D90", VA = "0x185E01990")]
		internal KAGFDGBCCLB(DBJPCLJMDLL KEKPLKHNJAG, NativeArray<byte> GHFAAPNAFDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5E01820", Offset = "0x5E00C20", VA = "0x185E01820", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x5E01830", Offset = "0x5E00C30", VA = "0x185E01830")]
		public NativeArray<byte> HGJPBBOCNON(int KIHHOMBMMEI)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5E018F0", Offset = "0x5E00CF0", VA = "0x185E018F0")]
		public void OELGDCFEDAP(Span<byte> EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public struct MPOFOECMGGN : IEnumerator<KCDFHGGGJDK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly NativeList<KCDFHGGGJDK> FFAHMFOPGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private int APOENOPNHBG;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public KCDFHGGGJDK PNJHIMNMKKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x5E06A40", Offset = "0x5E05E40", VA = "0x185E06A40", Slot = "4")]
			get
			{
				return default(KCDFHGGGJDK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x5E069F0", Offset = "0x5E05DF0", VA = "0x185E069F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5E068A0", Offset = "0x5E05CA0", VA = "0x185E068A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5E069A0", Offset = "0x5E05DA0", VA = "0x185E069A0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private struct BPBGILKOCJP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private NativeArray<int> GHFAAPNAFDE;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public bool ONBNDEEHGPC
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x5DEF260", Offset = "0x5DEE660", VA = "0x185DEF260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int OKAKPLMCAFF
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x5DEF250", Offset = "0x5DEE650", VA = "0x185DEF250")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x5DEF160", Offset = "0x5DEE560", VA = "0x185DEF160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public PBEAGKHMIBO CNGDOHKCJIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x5DEF240", Offset = "0x5DEE640", VA = "0x185DEF240")]
			get
			{
				return default(PBEAGKHMIBO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x5DEF140", Offset = "0x5DEE540", VA = "0x185DEF140")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public bool KKKPPIOMEDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x5DEF1D0", Offset = "0x5DEE5D0", VA = "0x185DEF1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool PAKKJKANDEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x5DEF170", Offset = "0x5DEE570", VA = "0x185DEF170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF2D0", Offset = "0x5DEE6D0", VA = "0x185DEF2D0")]
		public BPBGILKOCJP(PBEAGKHMIBO LNJPLCFNBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF2A0", Offset = "0x5DEE6A0", VA = "0x185DEF2A0")]
		private int OPODPAEFLEB(int APBJNEFOGOC, int DKAEIGFECOJ = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF1F0", Offset = "0x5DEE5F0", VA = "0x185DEF1F0")]
		private void GMFKOPHMECD(int APBJNEFOGOC, int EOHMJBFGDPD, int DKAEIGFECOJ = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF190", Offset = "0x5DEE590", VA = "0x185DEF190", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly KCDFHGGGJDK FAJHDLHCCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeParallelHashMap<KCDFHGGGJDK, int> BEELIMHKLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private NativeList<KCDFHGGGJDK> FBIIJDILOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private NativeList<int> HHIPIHCKLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private NativeList<byte> CGKKGHHBGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private NativeList<byte> GHFAAPNAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private BPBGILKOCJP ILKHBODBFFI;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7C30", Offset = "0x5DF7030", VA = "0x185DF7C30")]
	public static DBJPCLJMDLL EECJKDKEFDC(PBEAGKHMIBO LNJPLCFNBPF = PBEAGKHMIBO.Last, int PGMCBNMJJEI = 16, int GFDCJBJBHAD = 256)
	{
		return default(DBJPCLJMDLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5DF80D0", Offset = "0x5DF74D0", VA = "0x185DF80D0")]
	private DBJPCLJMDLL(PBEAGKHMIBO LNJPLCFNBPF, int PGMCBNMJJEI, int GFDCJBJBHAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7B30", Offset = "0x5DF6F30", VA = "0x185DF7B30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7C70", Offset = "0x5DF7070", VA = "0x185DF7C70")]
	public NHDOJBBDAEE GANFBKGMHNA(KCDFHGGGJDK OAGNBNMPALP)
	{
		return default(NHDOJBBDAEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7940", Offset = "0x5DF6D40", VA = "0x185DF7940")]
	public bool DCICANEKOPG(KCDFHGGGJDK OAGNBNMPALP, [Out] KAGFDGBCCLB IBNLLHACJFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7AE0", Offset = "0x5DF6EE0", VA = "0x185DF7AE0")]
	public bool DFNLAOHAAHP(KCDFHGGGJDK OAGNBNMPALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5DF75A0", Offset = "0x5DF69A0", VA = "0x185DF75A0")]
	public bool ACGEDEKPBDC(KCDFHGGGJDK OAGNBNMPALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7860", Offset = "0x5DF6C60", VA = "0x185DF7860")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7D60", Offset = "0x5DF7160", VA = "0x185DF7D60")]
	private void MFFKJEPBOCB(KCDFHGGGJDK OAGNBNMPALP, int NBBMHNNJHFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7780", Offset = "0x5DF6B80", VA = "0x185DF7780")]
	private void BMIGNLKMMAL(int DFMOGDNKJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF76A0", Offset = "0x5DF6AA0", VA = "0x185DF76A0")]
	private void BCNLIHEFPKE(KCDFHGGGJDK OAGNBNMPALP, int NBBMHNNJHFB, int KIHHOMBMMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8020", Offset = "0x5DF7420", VA = "0x185DF8020", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7FD0", Offset = "0x5DF73D0", VA = "0x185DF7FD0", Slot = "4")]
	private IEnumerator<KCDFHGGGJDK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DefaultMember("Item")]
public class HAINNGCGPHD<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class MEOFIJGLICI
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class KPDNFEMDCMD
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class GCMIAIDGHLM
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class EHIKLNPDIBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public FJPIIIPDBML services;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public EHIKLNPDIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x5DFBEE0", Offset = "0x5DFB2E0", VA = "0x185DFBEE0")]
		internal void DEMLOAAHBBO(JAKEGKENGGK svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x5DFBF40", Offset = "0x5DFB340", VA = "0x185DFBF40")]
		internal void NDEBMPCNKHG(DFFDMFBJPHA svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD1F0", Offset = "0x5DFC5F0", VA = "0x185DFD1F0")]
	public static void OHGNNHJDICN(this World MOIDEPLOCKC, FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x237A990", Offset = "0x2379D90", VA = "0x18237A990")]
	public static void PHMOIKHGJOL<T>(this World MOIDEPLOCKC, Action<T> PEJKPAHFHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x237A530", Offset = "0x2379930", VA = "0x18237A530")]
	public static void BKEEKHLPAHM<T>(this World MOIDEPLOCKC, Action<T> PEJKPAHFHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x237A710", Offset = "0x2379B10", VA = "0x18237A710")]
	public static void BKEEKHLPAHM<T>(IEnumerable<ComponentSystemBase> LCDKABNLFIH, Action<T> PEJKPAHFHJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class BAAIDJMCPLF
{
	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5DECA20", Offset = "0x5DEBE20", VA = "0x185DECA20")]
	public static void KOHIIDKJHDH(ComponentSystemBase BPHADMLKFAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class IKFBDCNAAAO
{
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class NGDHGIMDMDC
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class DIHCPLLMMEM
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private sealed class <<CalculateTransformPath>g__getNames|0>d
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public DIHCPLLMMEM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class LEMGKACMKHA
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class HBDGPBPKPJO
{
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class KOLHKBNFBEN
{
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class OPGDPKIHNME
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class JMALCIIBMFJ
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static readonly ProfilerMarker OKMIEIEOACC;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly ProfilerMarker LPMDBKPBIOO;

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x5E00E20", Offset = "0x5E00220", VA = "0x185E00E20")]
	public static void CAGGLFMEPDA(this BJOIGMMCCHE NKEGKJEJLFE, HHLFDCEHHDJ JGMEFAHDHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5E01260", Offset = "0x5E00660", VA = "0x185E01260")]
	public static void EMFJAIOBCDA(this BJOIGMMCCHE NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5E01440", Offset = "0x5E00840", VA = "0x185E01440")]
	private static string[] KEOEHJBJPJJ(HHLFDCEHHDJ JGMEFAHDHAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5E01550", Offset = "0x5E00950", VA = "0x185E01550")]
	private static bool LANIFIDGEKE(HHLFDCEHHDJ JGMEFAHDHAJ, [Out] string[] DCGFKLANBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300")]
	private static bool HMPOIBFHNIM()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public abstract class KHNBCOCOAGD : ICGACOBKANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly MethodInfo KGBKAMNKJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly Type[] CAAIHKBHIAA;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5E01E90", Offset = "0x5E01290", VA = "0x185E01E90")]
	public KHNBCOCOAGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action NDMHMOFEILG();

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5E01E50", Offset = "0x5E01250", VA = "0x185E01E50")]
	public MethodInfo OAEGEOBECDJ(Action GMCEKENFDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5E01CC0", Offset = "0x5E010C0", VA = "0x185E01CC0", Slot = "4")]
	public void KIPDOAILNDA(Type IJFAMCPOKBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public abstract class BIIBNDFLAIJ : KHNBCOCOAGD
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private enum KAPPOGCJLHC
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5DED140", Offset = "0x5DEC540", VA = "0x185DED140", Slot = "5")]
	public override Action NDMHMOFEILG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void GMKKAPEGKHB<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5DED0B0", Offset = "0x5DEC4B0", VA = "0x185DED0B0")]
	[UnityEngine.Scripting.Preserve]
	public void EIJKAHPPJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB860", Offset = "0x5DEAC60", VA = "0x185DEB860")]
	protected BIIBNDFLAIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public abstract class AAAGEKMEIHF : KHNBCOCOAGD
{
	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB7C0", Offset = "0x5DEABC0", VA = "0x185DEB7C0", Slot = "5")]
	public override Action NDMHMOFEILG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void PGHKFIJNLEL<T>() where T : OGIDOOLIEGA;

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB730", Offset = "0x5DEAB30", VA = "0x185DEB730")]
	[UnityEngine.Scripting.Preserve]
	public void EIJKAHPPJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB860", Offset = "0x5DEAC60", VA = "0x185DEB860")]
	protected AAAGEKMEIHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public abstract class CLAHHAJJJIO : KHNBCOCOAGD
{
	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4270", Offset = "0x5DF3670", VA = "0x185DF4270", Slot = "5")]
	public override Action NDMHMOFEILG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void JOFLGFJMMDE<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5DF41E0", Offset = "0x5DF35E0", VA = "0x185DF41E0")]
	[UnityEngine.Scripting.Preserve]
	public void EIJKAHPPJAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB860", Offset = "0x5DEAC60", VA = "0x185DEB860")]
	protected CLAHHAJJJIO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct CGDGNDNJMOC : ISystem
{
	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "4")]
	public void OnCreate(SystemState JEPPHOGINNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
	public void OnDestroy(SystemState JEPPHOGINNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF30C0", Offset = "0x5DF24C0", VA = "0x185DF30C0", Slot = "6")]
	public void OnUpdate(SystemState JEPPHOGINNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void PEMDBNKCBGA(IntPtr LDMHFMNLDHG, IntPtr JEPPHOGINNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF30C0", Offset = "0x5DF24C0", VA = "0x185DF30C0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void AILCHJGHHMP(IntPtr LDMHFMNLDHG, IntPtr JEPPHOGINNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void OMMJIELJHLB(IntPtr LDMHFMNLDHG, IntPtr JEPPHOGINNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class MLFGNAKKFHM
{
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public static readonly ComponentType[] GJOEHDKINPA;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x5E04780", Offset = "0x5E03B80", VA = "0x185E04780")]
	public static Entity PGMJNEOBLOC(this EntityManager OKJDPAMBACM)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class MLLMJBPDHGB
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class KOFGNHDMBFF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class PNNLMEBEGEA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class JJEFLFGBAMI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5E04BE0", Offset = "0x5E03FE0", VA = "0x185E04BE0")]
	public static Entity DGGFCPAOCHD(this EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x5E04A20", Offset = "0x5E03E20", VA = "0x185E04A20")]
	public static DynamicBuffer<ChildrenData> BEIMEEJMOIN(this EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(DynamicBuffer<ChildrenData>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5E05410", Offset = "0x5E04810", VA = "0x185E05410")]
	public static bool MKFONILFPLC(this EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, Allocator KIKFOGPECEC, [Out] NativeArray<Entity> IKCJHPIMLLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x5E057E0", Offset = "0x5E04BE0", VA = "0x185E057E0")]
	public static NativeArray<Entity> PEGIJJPFDGE(this EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5E04AB0", Offset = "0x5E03EB0", VA = "0x185E04AB0")]
	public static int DBNHBIOACAG(this EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x5E05960", Offset = "0x5E04D60", VA = "0x185E05960")]
	public static void POFMJHBDCDJ(NativeArray<Entity> MFJIMBMOJGL, NativeArray<Entity> JHOBIGGNOKP, EntityManager OKJDPAMBACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5E054E0", Offset = "0x5E048E0", VA = "0x185E054E0")]
	public static bool MLAEFHBCNIM(this EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, Entity MGPFGPKIGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5E04C50", Offset = "0x5E04050", VA = "0x185E04C50")]
	public static bool FLFPNBFPDPC(this EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, Entity DFAAINNDBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5E05250", Offset = "0x5E04650", VA = "0x185E05250")]
	public static NativeList<Entity> JHFJPKHNDKL(this EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, bool KALBIOKEEGL = false, Allocator KIKFOGPECEC = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x5E056B0", Offset = "0x5E04AB0", VA = "0x185E056B0")]
	public static Entity NKAFPNBHAEE(this EntityManager OKJDPAMBACM, Entity FILKDLNBIJH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5E04F80", Offset = "0x5E04380", VA = "0x185E04F80")]
	public static bool GKMCHOHAPGM(this EntityManager OKJDPAMBACM, Entity BGICHGONLEL, Entity AGPMPKBMMOB, [Out] Entity AJCIPGIKNEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5E04900", Offset = "0x5E03D00", VA = "0x185E04900")]
	internal static void ALFKENNHBOM(EntityManager OKJDPAMBACM, Entity EBFCMPBKGBM, Entity JHAODPLJNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5E04E50", Offset = "0x5E04250", VA = "0x185E04E50")]
	private static bool GHOBDEHENLL(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, Entity MGPFGPKIGND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[PNAJALIKCOM(typeof(NKHLENJHNOG), new string[] { })]
internal sealed class FJAODIJHADO : NKHLENJHNOG, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	[MFFAOKEGCNH]
	private PMPMJLEMOAG FCDDACIHGFP;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public AMOJIFFONDA.CKPPJIHMFJA.KIMLPLLHIOK BLCJBBJLPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x5DFD130", Offset = "0x5DFC530", VA = "0x185DFD130", Slot = "4")]
		get
		{
			return default(AMOJIFFONDA.CKPPJIHMFJA.KIMLPLLHIOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD1A0", Offset = "0x5DFC5A0", VA = "0x185DFD1A0", Slot = "5")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public FJAODIJHADO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal class EBMOMHAJKIJ
{
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private static readonly FBKCBHAMJJJ CFFGOHLAJLN;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private static readonly FBKCBHAMJJJ CIFNBGDOCCJ;

	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private static readonly ProfilerMarker HHJOHMINCDN;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker CLCJKJCNIDK;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly ProfilerMarker DCIAFGLINNI;

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly ProfilerMarker KCLPBGJNCAC;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly ProfilerMarker MBFOBLHBFKJ;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly ProfilerMarker NLLPBJAANHB;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly ProfilerMarker JADIPJBKIOP;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static readonly ProfilerMarker PKEFABDEADL;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly ProfilerMarker NCIOFLOBGKM;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly ProfilerMarker DIJJOAOACBG;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly ProfilerMarker MHABBLIOCPO;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly ProfilerMarker GNMDAJECGIE;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly ProfilerMarker DAPLJBNCHJF;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly ProfilerMarker NKCNIKDOHPC;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly ProfilerMarker MLFMEOFEMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly HHKFMHGOMCH HDLPKLFGDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly ByteString EGFEGIMIICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly BJOIGMMCCHE NKEGKJEJLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly JPLLAMGFKJI MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly GHNPFMHIOKA INDGKDKJOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly ADMBLJAMLBN FBIIJDILOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly LPPICMFAKHE KCAMEIIACHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private readonly TaskCompletionSource<bool> OAONCJDELIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private readonly IMGNKCPOGPE ILKHBODBFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private readonly PEPHFDFHMGG.JOILDPEIOAM KFHLCNAPENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private PAFDHAFMDMH AEJHFHDGNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private FMNCGEAPDKG KOKCIFCPGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private AMOJIFFONDA GBMMPCPFKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private IPLKNLMFFDP GIDEAEKBMHF;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Action MCCPJPDCAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8111F0", Offset = "0x8105F0", VA = "0x1808111F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x8BB800", Offset = "0x8BAC00", VA = "0x1808BB800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public Action KIOHAKGGKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5C0", Offset = "0x8BA9C0", VA = "0x1808BB5C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x8BB880", Offset = "0x8BAC80", VA = "0x1808BB880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Action PAEJABGCJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x762900", Offset = "0x761D00", VA = "0x180762900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x7629A0", Offset = "0x761DA0", VA = "0x1807629A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public IEnumerable<BDDINDDAOMP> FENNFBLMAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x7D9590", Offset = "0x7D8990", VA = "0x1807D9590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7D95A0", Offset = "0x7D89A0", VA = "0x1807D95A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public ECHNGDHAHOM PGDNJMPKEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA8E0", Offset = "0x5DF9CE0", VA = "0x185DFA8E0")]
		[CompilerGenerated]
		get
		{
			return default(ECHNGDHAHOM);
		}
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAB50", Offset = "0x5DF9F50", VA = "0x185DFAB50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public IPLKNLMFFDP FLIDMMKFLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5B0", Offset = "0x8BA9B0", VA = "0x1808BB5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public LMGFAGPMGOB EBNJBDPPHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1A1ABD0", Offset = "0x1A19FD0", VA = "0x181A1ABD0")]
		get
		{
			return default(LMGFAGPMGOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public LocalId NCEKKJFNJNC
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9370", Offset = "0x5DF8770", VA = "0x185DF9370")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Task IKMGLLNDKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x5DF94F0", Offset = "0x5DF88F0", VA = "0x185DF94F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBC10", Offset = "0x5DFB010", VA = "0x185DFBC10")]
	public EBMOMHAJKIJ(ByteString EGFEGIMIICO, LMGFAGPMGOB COIIGIMFAFO, [In] IMGNKCPOGPE ILKHBODBFFI, BJOIGMMCCHE NKEGKJEJLFE, CPKPDFPLDCI NEELNELMBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9710", Offset = "0x5DF8B10", VA = "0x185DF9710")]
	public void DGELADFNLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB7B0", Offset = "0x5DFABB0", VA = "0x185DFB7B0")]
	public bool PKJOKDNDIPB(LMGFAGPMGOB BGICHGONLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5DF90A0", Offset = "0x5DF84A0", VA = "0x185DF90A0")]
	private bool AIBKFOFELJA(LMGFAGPMGOB ACCDAPFKBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAD30", Offset = "0x5DFA130", VA = "0x185DFAD30")]
	private void LPOLOOKHEEL(LMGFAGPMGOB HFAJDMOHFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9C50", Offset = "0x5DF9050", VA = "0x185DF9C50")]
	private bool EMLBLPDEGAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5DFADE0", Offset = "0x5DFA1E0", VA = "0x185DFADE0")]
	public bool MALODBPHMHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA590", Offset = "0x5DF9990", VA = "0x185DFA590")]
	private bool IEIECAAHMMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9E70", Offset = "0x5DF9270", VA = "0x185DF9E70")]
	private bool FKNDGPDCHIN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA930", Offset = "0x5DF9D30", VA = "0x185DFA930")]
	private bool JJAFHCAGIPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB630", Offset = "0x5DFAA30", VA = "0x185DFB630")]
	private bool OEIODAMCIAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF93B0", Offset = "0x5DF87B0", VA = "0x185DF93B0")]
	private bool DFEKLPGPJDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAF40", Offset = "0x5DFA340", VA = "0x185DFAF40")]
	public void MBFHDLOEBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9380", Offset = "0x5DF8780", VA = "0x185DF9380")]
	[CompilerGenerated]
	private void CIMKJHHMNNF(LMGFAGPMGOB ACCDAPFKBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB660", Offset = "0x5DFAA60", VA = "0x185DFB660")]
	[CompilerGenerated]
	private bool PBDANJFODIF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5DF97F0", Offset = "0x5DF8BF0", VA = "0x185DF97F0")]
	[CompilerGenerated]
	private void DOKHODDFLKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA460", Offset = "0x5DF9860", VA = "0x185DFA460")]
	[CompilerGenerated]
	private World IDNFNOBMGBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB490", Offset = "0x5DFA890", VA = "0x185DFB490")]
	[CompilerGenerated]
	private void NIJHKNHOAOL(World POGMIJKKFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA140", Offset = "0x5DF9540", VA = "0x185DFA140")]
	[CompilerGenerated]
	private int GMMPCGPAFAG(World POGMIJKKFOF, ByteString EGFEGIMIICO, AMOJIFFONDA.CKPPJIHMFJA.KIMLPLLHIOK FOIKACEEEGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9530", Offset = "0x5DF8930", VA = "0x185DF9530")]
	[CompilerGenerated]
	private void DFIIFHMDJNN(World MOIDEPLOCKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAB80", Offset = "0x5DF9F80", VA = "0x185DFAB80")]
	[CompilerGenerated]
	internal static NIBEAPHAFFJ KOAPILAEPDE(EntityManager PNNLDANJAOI, EntityManager IBHDEEJPAJI, int BCLBGCAIGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAA40", Offset = "0x5DF9E40", VA = "0x185DFAA40")]
	[CompilerGenerated]
	private void KBDMFFDBHHN(IPLKNLMFFDP GIDEAEKBMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA2A0", Offset = "0x5DF96A0", VA = "0x185DFA2A0")]
	[CompilerGenerated]
	private void HADLHKJBGDD(EntityManager OKJDPAMBACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB390", Offset = "0x5DFA790", VA = "0x185DFB390")]
	[CompilerGenerated]
	private void MPPOLMEGDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA910", Offset = "0x5DF9D10", VA = "0x185DFA910")]
	[CompilerGenerated]
	private void IPKJILPAFGD(string LFAIHEECJFK, EntityManager OKJDPAMBACM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB5C0", Offset = "0x5DFA9C0", VA = "0x185DFB5C0")]
	[CompilerGenerated]
	private AMOGJGPNFMH<IMGNKCPOGPE> NJHGMFPPEAC(EntityManager OKJDPAMBACM)
	{
		return default(AMOGJGPNFMH<IMGNKCPOGPE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class HHKFMHGOMCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum NDMHCEIGKCA
	{
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		Running,
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		Disposed
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class KMAKFFACMLA : IEnumerable<LMGFAGPMGOB>, IEnumerable, IEnumerator<LMGFAGPMGOB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private LMGFAGPMGOB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public HHKFMHGOMCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private LMGFAGPMGOB target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public LMGFAGPMGOB <>3__target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private int <allowedTarget>5__2;

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		private LMGFAGPMGOB System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Serialization.DeserializePhases>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x8C3200", Offset = "0x8C2600", VA = "0x1808C3200", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LMGFAGPMGOB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x5E024C0", Offset = "0x5E018C0", VA = "0x185E024C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xCCC950", Offset = "0xCCBD50", VA = "0x180CCC950")]
		[DebuggerHidden]
		public KMAKFFACMLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x5E02340", Offset = "0x5E01740", VA = "0x185E02340", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5E02470", Offset = "0x5E01870", VA = "0x185E02470", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5E023C0", Offset = "0x5E017C0", VA = "0x185E023C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LMGFAGPMGOB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Serialization.DeserializePhases>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5E023C0", Offset = "0x5E017C0", VA = "0x185E023C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class NDCFGPNDDLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public LMGFAGPMGOB phase;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public NDCFGPNDDLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E08D70", Offset = "0x5E08170", VA = "0x185E08D70")]
		internal object KNLMIFAHGLK(LMGFAGPMGOB a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private static readonly FBKCBHAMJJJ CIFNBGDOCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private readonly LMGFAGPMGOB COIIGIMFAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Func<LMGFAGPMGOB, bool> DIOEMPHNJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly Action<LMGFAGPMGOB> JHLCCCEJAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private int OPHDCGDJGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private NDMHCEIGKCA JEPPHOGINNJ;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public LMGFAGPMGOB EBNJBDPPHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x75C180", Offset = "0x75B580", VA = "0x18075C180")]
		get
		{
			return default(LMGFAGPMGOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x5DFF780", Offset = "0x5DFEB80", VA = "0x185DFF780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFBE0", Offset = "0x5DFEFE0", VA = "0x185DFFBE0")]
	public HHKFMHGOMCH(LMGFAGPMGOB COIIGIMFAFO, Func<LMGFAGPMGOB, bool> DIOEMPHNJGE, Action<LMGFAGPMGOB> JHLCCCEJAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF6F0", Offset = "0x5DFEAF0", VA = "0x185DFF6F0")]
	[IteratorStateMachine(typeof(KMAKFFACMLA))]
	private IEnumerable<LMGFAGPMGOB> FMHLDONLOOL(LMGFAGPMGOB BGICHGONLEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF790", Offset = "0x5DFEB90", VA = "0x185DFF790")]
	public bool PKJOKDNDIPB(LMGFAGPMGOB BGICHGONLEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF6B0", Offset = "0x5DFEAB0", VA = "0x185DFF6B0")]
	private void CDABEKCIJPM(LMGFAGPMGOB ACCDAPFKBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0430", Offset = "0x5DCF830", VA = "0x185DD0430", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal class ADONAGEGJEE : MFDFMBOIECB, CPKPDFPLDCI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly EBMOMHAJKIJ GBFAADEABMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly AEMGHLGPJFG ODEOFMHKBJG;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public JIKHBIMIMDL IGCEJJPMDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public LocalId JJPEIMIAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB8A0", Offset = "0x5DEACA0", VA = "0x185DEB8A0", Slot = "9")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Task IKMGLLNDKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB8D0", Offset = "0x5DEACD0", VA = "0x185DEB8D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IEnumerable<BDDINDDAOMP> FENNFBLMAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB980", Offset = "0x5DEAD80", VA = "0x185DEB980", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public ECHNGDHAHOM PGDNJMPKEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB940", Offset = "0x5DEAD40", VA = "0x185DEB940", Slot = "8")]
		get
		{
			return default(ECHNGDHAHOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public IPLKNLMFFDP BFFEGJPNAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB9B0", Offset = "0x5DEADB0", VA = "0x185DEB9B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBA20", Offset = "0x5DEAE20", VA = "0x185DEBA20")]
	public ADONAGEGJEE(ByteString EGFEGIMIICO, JIKHBIMIMDL HMEIEKLJFIK, [In] IMGNKCPOGPE ILKHBODBFFI, BJOIGMMCCHE NKEGKJEJLFE, Action GIAGFMCPJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB870", Offset = "0x5DEAC70", VA = "0x185DEB870", Slot = "5")]
	public void AEPLBNHKDFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB9F0", Offset = "0x5DEADF0", VA = "0x185DEB9F0", Slot = "12")]
	public bool PKJOKDNDIPB(LMGFAGPMGOB ACCDAPFKBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB9D0", Offset = "0x5DEADD0", VA = "0x185DEB9D0", Slot = "6")]
	public void MBFHDLOEBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB920", Offset = "0x5DEAD20", VA = "0x185DEB920", Slot = "13")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class CKPHAOPAFJP : DCCFMDGIBCB, CPKPDFPLDCI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly EBMOMHAJKIJ GBFAADEABMD;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public LocalId JJPEIMIAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4030", Offset = "0x5DF3430", VA = "0x185DF4030", Slot = "6")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public IEnumerable<BDDINDDAOMP> FENNFBLMAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB980", Offset = "0x5DEAD80", VA = "0x185DEB980", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public ECHNGDHAHOM PGDNJMPKEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB940", Offset = "0x5DEAD40", VA = "0x185DEB940", Slot = "5")]
		get
		{
			return default(ECHNGDHAHOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Task IKMGLLNDKFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB8D0", Offset = "0x5DEACD0", VA = "0x185DEB8D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public IPLKNLMFFDP BFFEGJPNAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB9B0", Offset = "0x5DEADB0", VA = "0x185DEB9B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4040", Offset = "0x5DF3440", VA = "0x185DF4040")]
	public CKPHAOPAFJP(ByteString EGFEGIMIICO, BJOIGMMCCHE NKEGKJEJLFE, Action PAFHGEGFOLP, Action BCPNENBIKED, Action GIAGFMCPJPC, bool KBPIGJGNNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB9F0", Offset = "0x5DEADF0", VA = "0x185DEB9F0", Slot = "9")]
	public bool PKJOKDNDIPB(LMGFAGPMGOB ACCDAPFKBCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB920", Offset = "0x5DEAD20", VA = "0x185DEB920", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal struct IMGNKCPOGPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public EKDOHGHOOFO CLFGJFGNNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public Entity EBFCMPBKGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public CEGGGNMKAAC DBIOKHIBDAG;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly DLFNBFPKEBB<IMGNKCPOGPE> BDJLOIHNJNG;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class NNLAKKJPMBK : JPGOBCIEAFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public IPLKNLMFFDP FLIDMMKFLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E09620", Offset = "0x5E08A20", VA = "0x185E09620", Slot = "5")]
	public ByteString PCENJPCJCHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E09680", Offset = "0x5E08A80", VA = "0x185E09680")]
	public NNLAKKJPMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[CDHEJLILMFK(PIEFJKINJBJ.Application)]
public interface NKHLENJHNOG
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	AMOJIFFONDA.CKPPJIHMFJA.KIMLPLLHIOK BLCJBBJLPEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal abstract class GEPDOBNLFPM : JPGOBCIEAFB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly ProfilerMarker DCIAFGLINNI;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ProfilerMarker MCKFPJJLMNI;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly ProfilerMarker KCLPBGJNCAC;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly ProfilerMarker NIJOAOBOAEO;

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private static readonly ProfilerMarker NLLPBJAANHB;

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly ProfilerMarker EPHJIALABFP;

	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static readonly ProfilerMarker KIDELFNANLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly BJOIGMMCCHE NKEGKJEJLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly PAFDHAFMDMH AEJHFHDGNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly LPPICMFAKHE KCAMEIIACHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly ADMBLJAMLBN FBIIJDILOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private readonly FBKCBHAMJJJ CIFNBGDOCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private readonly PEPHFDFHMGG.JOILDPEIOAM KFHLCNAPENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private World OHKFBKLNCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private IPLKNLMFFDP GIDEAEKBMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private IDisposable FANDHKOBGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private ByteString HENLAAAKKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private AMOJIFFONDA.CKPPJIHMFJA.KIMLPLLHIOK BHCFKOPILPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private bool POEOLLOCLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private LKEFCEFOADP CDJDLKEEKIF;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	protected World DAHNOMCAIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x7610A0", Offset = "0x7604A0", VA = "0x1807610A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	protected World MGNDKLKJBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x5DFE5B0", Offset = "0x5DFD9B0", VA = "0x185DFE5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public IPLKNLMFFDP FLIDMMKFLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x7610F0", Offset = "0x7604F0", VA = "0x1807610F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE7C0", Offset = "0x5DFDBC0", VA = "0x185DFE7C0")]
	public GEPDOBNLFPM(BJOIGMMCCHE NKEGKJEJLFE, FBKCBHAMJJJ AMAPEJENOPH, FBKCBHAMJJJ CIFNBGDOCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE530", Offset = "0x5DFD930", VA = "0x185DFE530", Slot = "5")]
	public ByteString PCENJPCJCHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD920", Offset = "0x5DFCD20", VA = "0x185DFD920", Slot = "7")]
	public void AEPLBNHKDFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE410", Offset = "0x5DFD810", VA = "0x185DFE410", Slot = "8")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE470", Offset = "0x5DFD870", VA = "0x185DFE470", Slot = "9")]
	protected virtual EONECAHIOFP GCBFCEJOEGD()
	{
		return default(EONECAHIOFP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void NFGDOPOCGCK();

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract NativeArray<EntityRemapUtility.EntityRemapInfo> IIOLDMMIPJI(NativeArray<EntityRemapUtility.EntityRemapInfo> MEBMPFDMHMN);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[BGDLFGMNLEM]
internal struct EONECAHIOFP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public EKDOHGHOOFO FFGNHFDKOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public OMIBOHIOEFO DBIOKHIBDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public AMOJIFFONDA.CKPPJIHMFJA.KIMLPLLHIOK FOIKACEEEGH;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public static readonly DLFNBFPKEBB<EONECAHIOFP> BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC7E0", Offset = "0x5DFBBE0", VA = "0x185DFC7E0")]
	public static EONECAHIOFP DFOLEPKIBKD([In] EKDOHGHOOFO FFGNHFDKOFB)
	{
		return default(EONECAHIOFP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class INBDKJAFOAJ : GEPDOBNLFPM
{
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly FBKCBHAMJJJ CIFNBGDOCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private readonly EONECAHIOFP ILKHBODBFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private NativeList<Entity> NEDCHCFPOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private NativeArray<Entity> CJOBDHFJOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> DAOBKEECLNO;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E00300", Offset = "0x5DFF700", VA = "0x185E00300")]
	public INBDKJAFOAJ(IEnumerable<LHNHNFAONOD> GAKOOBMLEII, [In] EONECAHIOFP ILKHBODBFFI, BJOIGMMCCHE NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFF30", Offset = "0x5DFF330", VA = "0x185DFFF30", Slot = "9")]
	protected override EONECAHIOFP GCBFCEJOEGD()
	{
		return default(EONECAHIOFP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E000B0", Offset = "0x5DFF4B0", VA = "0x185E000B0", Slot = "10")]
	protected override void NFGDOPOCGCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFF60", Offset = "0x5DFF360", VA = "0x185DFFF60", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> IIOLDMMIPJI(NativeArray<EntityRemapUtility.EntityRemapInfo> MEBMPFDMHMN)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFE80", Offset = "0x5DFF280", VA = "0x185DFFE80", Slot = "8")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal class GGDBPOLJOFC : GEPDOBNLFPM
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private static readonly FBKCBHAMJJJ CIFNBGDOCCJ;

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEE30", Offset = "0x5DFE230", VA = "0x185DFEE30")]
	public GGDBPOLJOFC(BJOIGMMCCHE NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DFECC0", Offset = "0x5DFE0C0", VA = "0x185DFECC0", Slot = "10")]
	protected override void NFGDOPOCGCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0xD82230", Offset = "0xD81630", VA = "0x180D82230", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> IIOLDMMIPJI(NativeArray<EntityRemapUtility.EntityRemapInfo> MEBMPFDMHMN)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class EKIOMEFILPK
{
	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC720", Offset = "0x5DFBB20", VA = "0x185DFC720")]
	public static PEPHFDFHMGG.JOILDPEIOAM JBEIHCOOCIJ(BJOIGMMCCHE NKEGKJEJLFE)
	{
		return default(PEPHFDFHMGG.JOILDPEIOAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC370", Offset = "0x5DFB770", VA = "0x185DFC370")]
	public static NativeList<Entity> GGJCGPOIBCG(EntityManager OKJDPAMBACM, IEnumerable<LHNHNFAONOD> GAKOOBMLEII)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC670", Offset = "0x5DFBA70", VA = "0x185DFC670")]
	public static void IIOLDMMIPJI(NativeArray<Entity> CJOBDHFJOFD, NativeList<Entity> NEDCHCFPOHB, NativeArray<EntityRemapUtility.EntityRemapInfo> MEBMPFDMHMN, NativeArray<EntityRemapUtility.EntityRemapInfo> DAOBKEECLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2259C00", Offset = "0x2259000", VA = "0x182259C00")]
	public static Entity AJAENKFMJBL<T>(EntityManager OKJDPAMBACM, [In] T EOHMJBFGDPD) where T : struct, IComponentData
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class MGGHMINCIBA
{
	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E03FE0", Offset = "0x5E033E0", VA = "0x185E03FE0")]
	public static EKDOHGHOOFO CFHPHKJHDHE(FDLKIDLAABP EBFCMPBKGBM)
	{
		return default(EKDOHGHOOFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct AMOGJGPNFMH<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private EntityManager OKJDPAMBACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly Entity CCDJHAPAJAH;

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x36FF650", Offset = "0x36FEA50", VA = "0x1836FF650")]
	public AMOGJGPNFMH(EntityManager OKJDPAMBACM, [In] T ILKHBODBFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x36FF5F0", Offset = "0x36FE9F0", VA = "0x1836FF5F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[PNAJALIKCOM(typeof(NBIPELNFGHB), new string[] { })]
public class AJKBLEJHBGE : NBIPELNFGHB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public ADOFIMCFGAO CJNCCAFDDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x75C7A0", Offset = "0x75BBA0", VA = "0x18075C7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private IGKLMANCLGL PNGALJCBPPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x75C560", Offset = "0x75B960", VA = "0x18075C560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private JKPJPBADHMP DJJEDAMMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private JHAPJOBBFII NKKFOIEMOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x764970", Offset = "0x763D70", VA = "0x180764970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public MJMAOFFIBEJ BNAFEJLEEDM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x7681F0", Offset = "0x7675F0", VA = "0x1807681F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public GIJNOGPDJNH NELLMLBHNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x75C7E0", Offset = "0x75BBE0", VA = "0x18075C7E0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x75C520", Offset = "0x75B920", VA = "0x18075C520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public OBDFANNJJFO HEBJDHHHPKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x764B70", Offset = "0x763F70", VA = "0x180764B70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x75C7C0", Offset = "0x75BBC0", VA = "0x18075C7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public DGGIPPFDHEO FDPKLJDGEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x75C7B0", Offset = "0x75BBB0", VA = "0x18075C7B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x75C580", Offset = "0x75B980", VA = "0x18075C580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private JPLLAMGFKJI LHMHPOPGABI
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x761100", Offset = "0x760500", VA = "0x180761100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public KFJAFIJIKDB GHBGPMIKACN
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x7610D0", Offset = "0x7604D0", VA = "0x1807610D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x7610B0", Offset = "0x7604B0", VA = "0x1807610B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public KNMOBKNCALK FEIHNKLKGKM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x7610A0", Offset = "0x7604A0", VA = "0x1807610A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x761110", Offset = "0x760510", VA = "0x180761110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private BODNLCIOGJO DIAEBNPLIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x7610C0", Offset = "0x7604C0", VA = "0x1807610C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public HKDMOLLIAMN HFCEGAEDEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x761D10", Offset = "0x761110", VA = "0x180761D10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x761D00", Offset = "0x761100", VA = "0x180761D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private MICHBMMIPGJ HELCAPEGHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x75F260", Offset = "0x75E660", VA = "0x18075F260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private AFLJLAKFEOK KAMKBENLKIO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x75F1F0", Offset = "0x75E5F0", VA = "0x18075F1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBBF0", Offset = "0x5DEAFF0", VA = "0x185DEBBF0", Slot = "13")]
	public virtual void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public AJKBLEJHBGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[PNAJALIKCOM(typeof(GNGBPCPDDMI), new string[] { })]
public class LBDJIGDJKIE : GNGBPCPDDMI, PMEJGPCHMNC, FFMIIDAKNCD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private FJPIIIPDBML NKEGKJEJLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private NBIPELNFGHB MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private FMNCGEAPDKG KOKCIFCPGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private KENPJEONHPC EPKJOOEACNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private NMDHGCKCBIM BEOJNJDKKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private KFJHDAOPGPA IHBAGGIDMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private NBCENCLEOLD AMEPNDNNGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private BEIEPOGCFMG MFEJFLABCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private CEJODIHFCGC HAGILIEDDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private JIIJKCLIHFI HKCCICONCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private DPBFPLBNLLG PLLOPODMMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private AAJHNHAHHBB IBNLLHACJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private CNCGGMKKCEC EFJDOCAENDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private LIHDLACLGHM BMHJIIAAOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private NLJBCKCCFIP KMOAAJBJMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private KCGPOJECAHP AAHMPKOCHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private FINDIDOCBAK AGFKLCOOLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private JICJPEPDNGF GOCPNHJEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private PMPMJLEMOAG OFFHKPEKPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private CCCMOPCHHIG JHCNLBAHAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public FJPIIIPDBML OAFBJOCEDHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public NBIPELNFGHB KOHEIAADMPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IMHPKNCJCOD KLNOCOBGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public KENPJEONHPC DHFHHKAKAEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public INHGBAEAGHP JJDEFEEBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x75C7E0", Offset = "0x75BBE0", VA = "0x18075C7E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public NMDHGCKCBIM IKJMCNLLEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x764B70", Offset = "0x763F70", VA = "0x180764B70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public KFJHDAOPGPA GHHBICFAIFA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x75C7B0", Offset = "0x75BBB0", VA = "0x18075C7B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public NBCENCLEOLD BIDKFJGGJJH
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x7610E0", Offset = "0x7604E0", VA = "0x1807610E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public CEJODIHFCGC HPMBALAHCBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x7610A0", Offset = "0x7604A0", VA = "0x1807610A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public JIIJKCLIHFI BOHNEDDGBBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7610F0", Offset = "0x7604F0", VA = "0x1807610F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public DPBFPLBNLLG DPDIDFCGDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x761D10", Offset = "0x761110", VA = "0x180761D10", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public AAJHNHAHHBB HELCAPEGHFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x75F220", Offset = "0x75E620", VA = "0x18075F220", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public CNCGGMKKCEC ELKECBPOJFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x75F1E0", Offset = "0x75E5E0", VA = "0x18075F1E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public LIHDLACLGHM PDBCOGGHPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x75F210", Offset = "0x75E610", VA = "0x18075F210", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public NLJBCKCCFIP FDGKHJCPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x826640", Offset = "0x825A40", VA = "0x180826640", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public KCGPOJECAHP LJMLCHKKNDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x75F2C0", Offset = "0x75E6C0", VA = "0x18075F2C0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public FINDIDOCBAK IECDKGKKBHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x8A01E0", Offset = "0x89F5E0", VA = "0x1808A01E0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public JICJPEPDNGF FDDMBMODNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x762990", Offset = "0x761D90", VA = "0x180762990", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public PMPMJLEMOAG CENPIFCHHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5A0", Offset = "0x8BA9A0", VA = "0x1808BB5A0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public CCCMOPCHHIG KOBLJGHDKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x83AD80", Offset = "0x83A180", VA = "0x18083AD80", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public LIODKINLCHA AMMFAOAPGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x7DC320", Offset = "0x7DB720", VA = "0x1807DC320", Slot = "24")]
		get
		{
			return default(LIODKINLCHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x5E03350", Offset = "0x5E02750", VA = "0x185E03350", Slot = "25")]
	public void LCOGFKBGGFM(FJPIIIPDBML ICIBDGNEEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x5E03340", Offset = "0x5E02740", VA = "0x185E03340", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x5E03650", Offset = "0x5E02A50", VA = "0x185E03650", Slot = "26")]
	public void NAAAAHPDOKI(FJPIIIPDBML ICIBDGNEEGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LBDJIGDJKIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[DefaultMember("Item")]
public class LNOOLJCPIAB : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class NIBJGNCIJKP : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public LNOOLJCPIAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x8C3200", Offset = "0x8C2600", VA = "0x1808C3200", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x5E093B0", Offset = "0x5E087B0", VA = "0x185E093B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x761060", Offset = "0x760460", VA = "0x180761060")]
		[DebuggerHidden]
		public NIBJGNCIJKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x5E091F0", Offset = "0x5E085F0", VA = "0x185E091F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x5E09360", Offset = "0x5E08760", VA = "0x185E09360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private readonly List<ulong> EIKBEBCCKJJ;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x75F130", Offset = "0x75E530", VA = "0x18075F130")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x5E03CA0", Offset = "0x5E030A0", VA = "0x185E03CA0")]
	public LNOOLJCPIAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x5E03C20", Offset = "0x5E03020", VA = "0x185E03C20", Slot = "4")]
	[IteratorStateMachine(typeof(NIBJGNCIJKP))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x5E03C20", Offset = "0x5E03020", VA = "0x185E03C20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[PNAJALIKCOM(typeof(DMNMIPIKKHC), new string[] { })]
[EEHDICKJDPC(typeof(NFJDCGPFACM))]
public class GONKFPFJNBN : DMNMIPIKKHC, CNJKPBKICBD, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private readonly Dictionary<int, CBJELEJDOHN> OMFOEOOBDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private readonly Dictionary<CBJELEJDOHN, int> KDCENMGGFKP;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF000", Offset = "0x5DFE400", VA = "0x185DFF000", Slot = "6")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF0C0", Offset = "0x5DFE4C0", VA = "0x185DFF0C0", Slot = "7")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF1C0", Offset = "0x5DFE5C0", VA = "0x185DFF1C0")]
	private void JKPMNEIFAGL(List<(CBJELEJDOHN nameHash, AIPJMJJAMPA stableTypeHash, Type type)> KEKPLKHNJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF3D0", Offset = "0x5DFE7D0", VA = "0x185DFF3D0", Slot = "4")]
	public CBJELEJDOHN PLIHNIGAMIL(int PIEALCBDGOA)
	{
		return default(CBJELEJDOHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEF90", Offset = "0x5DFE390", VA = "0x185DFEF90", Slot = "5")]
	public int ECLDCOBNOPP(CBJELEJDOHN MKFHNGHEFLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF520", Offset = "0x5DFE920", VA = "0x185DFF520")]
	public GONKFPFJNBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[PNAJALIKCOM(typeof(HABDGJEIGLI), new string[] { })]
public class GGKHFEGCGOA : HABDGJEIGLI, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	[MFFAOKEGCNH]
	private KFJAFIJIKDB MKNFLEECOBD;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private uint LKFOPFDBPBE
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x5DFEF40", Offset = "0x5DFE340", VA = "0x185DFEF40", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEEF0", Offset = "0x5DFE2F0", VA = "0x185DFEEF0", Slot = "5")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GGKHFEGCGOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[PNAJALIKCOM(typeof(DGGBEDJKEHK), new string[] { })]
public class MNPOBFLIGGC : DGGBEDJKEHK, CNJKPBKICBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private DBJPCLJMDLL ILJJGJOCFKA;

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5E05F60", Offset = "0x5E05360", VA = "0x185E05F60", Slot = "8")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5E05F10", Offset = "0x5E05310", VA = "0x185E05F10", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5E05C80", Offset = "0x5E05080", VA = "0x185E05C80", Slot = "4")]
	public void CCPGAEAJPGD(IJFILFNCAOA GIPGBEGNLCD, EAAMNLEDMLN KMKGEGCGMGD, ReadOnlySpan<byte> KFAOHDMIJNF, ReadOnlySpan<byte> EGFDIPNELEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5E06030", Offset = "0x5E05430", VA = "0x185E06030", Slot = "7")]
	public bool LDOHFNHJPIG(IJFILFNCAOA GIPGBEGNLCD, EAAMNLEDMLN KMKGEGCGMGD, Span<byte> KFAOHDMIJNF, Span<byte> EGFDIPNELEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5E06780", Offset = "0x5E05B80", VA = "0x185E06780", Slot = "5")]
	public bool NMFBBFCJGOP(IJFILFNCAOA GIPGBEGNLCD, EAAMNLEDMLN KMKGEGCGMGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x5E05EE0", Offset = "0x5E052E0", VA = "0x185E05EE0", Slot = "6")]
	public bool CFMPJKMJHNE(IJFILFNCAOA GIPGBEGNLCD, EAAMNLEDMLN KMKGEGCGMGD, ReadOnlySpan<byte> EGFDIPNELEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x5E063E0", Offset = "0x5E057E0", VA = "0x185E063E0")]
	private bool LOPOOHMFIDB(IJFILFNCAOA GIPGBEGNLCD, EAAMNLEDMLN KMKGEGCGMGD, ReadOnlySpan<byte> EGFDIPNELEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MNPOBFLIGGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class OKHLGLFJBIN<T> : IONDPMPACAM<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	protected GJBNPCAEDCF<T> NBOHHOPEGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	protected GIAAJBNLCFD<T> JMMHJAKHCJP;

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x33DB470", Offset = "0x33DA870", VA = "0x1833DB470")]
	public OKHLGLFJBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x3CF5CC0", Offset = "0x3CF50C0", VA = "0x183CF5CC0")]
	public OKHLGLFJBIN(GJBNPCAEDCF<T> NBOHHOPEGCF, GIAAJBNLCFD<T> JMMHJAKHCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x3CF56E0", Offset = "0x3CF4AE0", VA = "0x183CF56E0", Slot = "10")]
	protected override T ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x3CF5A70", Offset = "0x3CF4E70", VA = "0x183CF5A70", Slot = "11")]
	protected override void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN, T EOHMJBFGDPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class ODIHGCLALPE
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class OHOJIDCDOLF<T> : OKHLGLFJBIN<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8100", Offset = "0x3CE7500", VA = "0x183CE8100")]
	public OHOJIDCDOLF(T HMHBFKEMPJM, T NJNDGGPGGKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public sealed class FDBDLHDICFH<T> : IONDPMPACAM<T> where T : struct, OGIDOOLIEGA
{
	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x33C2080", Offset = "0x33C1480", VA = "0x1833C2080", Slot = "10")]
	protected override T ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x33C2210", Offset = "0x33C1610", VA = "0x1833C2210", Slot = "11")]
	protected override void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x3024EB0", Offset = "0x30242B0", VA = "0x183024EB0")]
	public FDBDLHDICFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal static class COBLGAJCBKE
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class COGMKNPKMJP
	{
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class GAPKHBKGAHM<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public GAPKHBKGAHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x347E920", Offset = "0x347DD20", VA = "0x18347E920")]
			internal void KEBOMKKGPJJ(LPHAAGNHOAH writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053E")]
			[Cpp2IlInjected.Address(RVA = "0x347E650", Offset = "0x347DA50", VA = "0x18347E650")]
			internal T IHJHFKJJLEJ(BDLPMJHFHLL reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6110", Offset = "0x5DF5510", VA = "0x185DF6110")]
		public static void IABCGNFDEFF(GFPNEIJFJOH IEGHBKFHLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x2984480", Offset = "0x2983880", VA = "0x182984480")]
		private static void ODFHLENKOMI<T>(GFPNEIJFJOH IEGHBKFHLGF, int NJNDGGPGGKK) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x2983E30", Offset = "0x2983230", VA = "0x182983E30")]
		private static void CPLHLAFLOIE<T>(LPHAAGNHOAH MKIOBJMIBCN, T DOJLNGFBAAB, int NJNDGGPGGKK) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x2983EC0", Offset = "0x29832C0", VA = "0x182983EC0")]
		private static T GGHOKOFPFKB<T>(BDLPMJHFHLL IOJEJAFBOHN, int NJNDGGPGGKK) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public COGMKNPKMJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class BFOLNJAIPLF : BIIBNDFLAIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private GFPNEIJFJOH IEGHBKFHLGF;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2983C70", Offset = "0x2983070", VA = "0x182983C70", Slot = "6")]
		public override void GMKKAPEGKHB<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x5DED000", Offset = "0x5DEC400", VA = "0x185DED000")]
		public static void HBLODPNDJPI(GFPNEIJFJOH IEGHBKFHLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB860", Offset = "0x5DEAC60", VA = "0x185DEB860")]
		public BFOLNJAIPLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class LHJDDKHEHHL
	{
		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		[CompilerGenerated]
		private sealed class CDFCDFGPLHK<T> where T : struct, INativeList<int>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
			public CDFCDFGPLHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0x347E8E0", Offset = "0x347DCE0", VA = "0x18347E8E0")]
			internal void DDHBGLFHKFC(LPHAAGNHOAH writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x347E4E0", Offset = "0x347D8E0", VA = "0x18347E4E0")]
			internal T POBOKIPICBJ(BDLPMJHFHLL reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x5E03670", Offset = "0x5E02A70", VA = "0x185E03670")]
		public static void ANEDNLLNIDB(GFPNEIJFJOH IEGHBKFHLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2984480", Offset = "0x2983880", VA = "0x182984480")]
		private static void HNGGPAMCMMD<T>(GFPNEIJFJOH IEGHBKFHLGF, int NJNDGGPGGKK) where T : struct, INativeList<int>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2985100", Offset = "0x2984500", VA = "0x182985100")]
		private static void OFMOJPFEAGG<T>(LPHAAGNHOAH MKIOBJMIBCN, T DOJLNGFBAAB, int NJNDGGPGGKK) where T : struct, INativeList<int>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x2985030", Offset = "0x2984430", VA = "0x182985030")]
		private static T LHLBBKLGPDO<T>(BDLPMJHFHLL IOJEJAFBOHN, int NJNDGGPGGKK) where T : struct, INativeList<int>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public LHJDDKHEHHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x5DF44F0", Offset = "0x5DF38F0", VA = "0x185DF44F0")]
	public static void MJELOIGEOFL(GFPNEIJFJOH IEGHBKFHLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5DF43F0", Offset = "0x5DF37F0", VA = "0x185DF43F0")]
	private static void MBKGBHENNNB(LPHAAGNHOAH JMLFIKJGAAF, quaternion DOJLNGFBAAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4310", Offset = "0x5DF3710", VA = "0x185DF4310")]
	private static quaternion GNPFBHCEMKF(BDLPMJHFHLL LNNNOJDNMEH)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x220D620", Offset = "0x220CA20", VA = "0x18220D620")]
	public static void EDLILOLGLHI<T>(GFPNEIJFJOH IEGHBKFHLGF, GJBNPCAEDCF<T> NBOHHOPEGCF, GIAAJBNLCFD<T> JMMHJAKHCJP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x220D6C0", Offset = "0x220CAC0", VA = "0x18220D6C0")]
	public static void JDNMIPOACLG<T>(GFPNEIJFJOH HOGACIGOPKL) where T : struct, OGIDOOLIEGA
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public abstract class ODPLKDKJOEJ : IMINMDJAAHH
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public abstract Type PJLEKBCNEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN, Span<byte> EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN, ReadOnlySpan<byte> EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	protected ODPLKDKJOEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public abstract class IONDPMPACAM<T> : ODPLKDKJOEJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public override Type PJLEKBCNEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x3691060", Offset = "0x3690460", VA = "0x183691060", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract T ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN, T EOHMJBFGDPD);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x3691C50", Offset = "0x3691050", VA = "0x183691C50", Slot = "8")]
	public override void ONLENKPGCBM(BDLPMJHFHLL IOJEJAFBOHN, Span<byte> BGICHGONLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x3692390", Offset = "0x3691790", VA = "0x183692390", Slot = "9")]
	public override void PJNKBIHCNDA(LPHAAGNHOAH MKIOBJMIBCN, ReadOnlySpan<byte> OAGNBNMPALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
	protected IONDPMPACAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal static class NCJJIDFOKAJ
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public struct JMAHCLEKNCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public INHGBAEAGHP NMNJDGCCMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public IIALBECIDBK FAAPHMFLLLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public BBAOLHNDKHB CFEJKNDCHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AOIJIDDNGFE DKHFFJHAFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public DGGBEDJKEHK HEPKNODKGNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public IOEPDKPCAAM IEGHBKFHLGF;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x5E00D30", Offset = "0x5E00130", VA = "0x185E00D30")]
		public void PICNJLOMOKL(FJPIIIPDBML NKEGKJEJLFE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public struct NEMNPEFGEIM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public NativeList<IJFILFNCAOA> FKNPDKLLGNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public NativeList<EIDGNLJLKDK> CHAFPPHFFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public NativeList<IJFILFNCAOA> HODIBOAAEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public NativeParallelMultiHashMap<IJFILFNCAOA, MBIJMHMIIKK> MFEJFLABCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public NativeList<byte> DOPCNACICCA;

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public bool HIDBJAFIILH
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x5E08E80", Offset = "0x5E08280", VA = "0x185E08E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x5E08DE0", Offset = "0x5E081E0", VA = "0x185E08DE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private struct BJKJJKHHJMK : IComparer<MBIJMHMIIKK>
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x5DED1E0", Offset = "0x5DEC5E0", VA = "0x185DED1E0", Slot = "4")]
		public int Compare(MBIJMHMIIKK MHJJOHHKIPH, MBIJMHMIIKK DFACBIDGKFM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private static readonly FBKCBHAMJJJ LLEIAFOMNGE;

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x5E07A30", Offset = "0x5E06E30", VA = "0x185E07A30")]
	public static void EMLKJFGJJEA(LPHAAGNHOAH MKIOBJMIBCN, NEMNPEFGEIM GHFAAPNAFDE, JMAHCLEKNCB NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x5E07CD0", Offset = "0x5E070D0", VA = "0x185E07CD0")]
	public static NEMNPEFGEIM ENNNHAMEIDH(BDLPMJHFHLL IOJEJAFBOHN, Allocator KIKFOGPECEC, JMAHCLEKNCB NKEGKJEJLFE)
	{
		return default(NEMNPEFGEIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x5E06A90", Offset = "0x5E05E90", VA = "0x185E06A90")]
	public static void CCPGAEAJPGD(NEMNPEFGEIM GHFAAPNAFDE, JMAHCLEKNCB NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5E06F60", Offset = "0x5E06360", VA = "0x185E06F60")]
	public static void CFMPJKMJHNE(NEMNPEFGEIM GHFAAPNAFDE, JMAHCLEKNCB NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x5E08020", Offset = "0x5E07420", VA = "0x185E08020")]
	public static int JHMPNIHGLLA(NEMNPEFGEIM GHFAAPNAFDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x5E06E90", Offset = "0x5E06290", VA = "0x185E06E90")]
	private static void CEODEGFBLGE(LPHAAGNHOAH MKIOBJMIBCN, NativeArray<IJFILFNCAOA> FKNPDKLLGNO, NativeArray<EIDGNLJLKDK> CHAFPPHFFEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5E08B10", Offset = "0x5E07F10", VA = "0x185E08B10")]
	private static void MENKMNGHILG(BDLPMJHFHLL IOJEJAFBOHN, Allocator KIKFOGPECEC, [Out] NativeList<IJFILFNCAOA> FKNPDKLLGNO, [Out] NativeList<EIDGNLJLKDK> EFKGECKFIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x5E07350", Offset = "0x5E06750", VA = "0x185E07350")]
	private static void CNJFFAEIOFK(LPHAAGNHOAH MKIOBJMIBCN, NativeArray<IJFILFNCAOA> HODIBOAAEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5E07250", Offset = "0x5E06650", VA = "0x185E07250")]
	private static void CHCDBDEEIIP(BDLPMJHFHLL IOJEJAFBOHN, Allocator KIKFOGPECEC, [Out] NativeList<IJFILFNCAOA> HODIBOAAEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5E08170", Offset = "0x5E07570", VA = "0x185E08170")]
	private static void KBDGIBNIPDD(LPHAAGNHOAH MKIOBJMIBCN, NativeParallelMultiHashMap<IJFILFNCAOA, MBIJMHMIIKK> MFEJFLABCIK, NativeList<byte> DOPCNACICCA, JMAHCLEKNCB NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5E073E0", Offset = "0x5E067E0", VA = "0x185E073E0")]
	private static void EBGMEEKDPKK(BDLPMJHFHLL IOJEJAFBOHN, Allocator KIKFOGPECEC, [Out] NativeParallelMultiHashMap<IJFILFNCAOA, MBIJMHMIIKK> MFEJFLABCIK, [Out] NativeList<byte> DOPCNACICCA, JMAHCLEKNCB NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5E07FE0", Offset = "0x5E073E0", VA = "0x185E07FE0")]
	private static void IHECFJKLJDN(int BIIPPCECIMO, int AAPBMHKGGBL, LPHAAGNHOAH MKIOBJMIBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5E08000", Offset = "0x5E07400", VA = "0x185E08000")]
	private static int INGEBBDMOME(int AAPBMHKGGBL, BDLPMJHFHLL IOJEJAFBOHN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[PNAJALIKCOM(typeof(GHBGCJBELNC), new string[] { })]
internal sealed class NKEGGOJDJJB : GHBGCJBELNC, CNJKPBKICBD, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly Dictionary<EAAMNLEDMLN, MPBADIPFPFK> IPKCMNJBBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private IIALBECIDBK MFEJFLABCIK;

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x5E09400", Offset = "0x5E08800", VA = "0x185E09400", Slot = "6")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5E09450", Offset = "0x5E08850", VA = "0x185E09450", Slot = "7")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5E094B0", Offset = "0x5E088B0", VA = "0x185E094B0", Slot = "4")]
	public void KIPDOAILNDA(EAAMNLEDMLN KMKGEGCGMGD, Type NHPINLBPLPD, MPBADIPFPFK MLPOPDPEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5E09520", Offset = "0x5E08920", VA = "0x185E09520", Slot = "5")]
	public bool NLPBEBDFKCA(EAAMNLEDMLN KMKGEGCGMGD, [Out] MPBADIPFPFK MLPOPDPEHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x5E09590", Offset = "0x5E08990", VA = "0x185E09590")]
	public NKEGGOJDJJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[PNAJALIKCOM(typeof(BENCMKIONLD), new string[] { })]
internal class BCOPALDJEDE : JAKEGKENGGK, BENCMKIONLD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	[MFFAOKEGCNH]
	private HABDGJEIGLI MDPJPABGGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private CBGNJCOKJKE LCICNAJNMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private int JBHFIGLOKGH;

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5DECE60", Offset = "0x5DEC260", VA = "0x185DECE60", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5DECED0", Offset = "0x5DEC2D0", VA = "0x185DECED0", Slot = "5")]
	public OCNDOGNDAKK OOMGEBCLGKC(ReadOnlySpan<byte> HEFGEKEDAKE)
	{
		return default(OCNDOGNDAKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5DECE50", Offset = "0x5DEC250", VA = "0x185DECE50", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public BCOPALDJEDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[PNAJALIKCOM(typeof(AOIJIDDNGFE), new string[] { })]
internal sealed class MKFEEONJEHI : AOIJIDDNGFE, JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	[MFFAOKEGCNH]
	private IIALBECIDBK MFEJFLABCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private NativeBitArray CNACOCMPEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private NativeParallelHashMap<IJFILFNCAOA, int> GEGIHDNKDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private NativeList<int> CIDHDCEJLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private int LPCCEJCILBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private int NEAGIAMKGOB;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool FGAOPKACOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x5E04600", Offset = "0x5E03A00", VA = "0x185E04600", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public OFOMCGLEDAP KKEGIONHGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x5E044A0", Offset = "0x5E038A0", VA = "0x185E044A0", Slot = "7")]
		get
		{
			return default(OFOMCGLEDAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x5E04580", Offset = "0x5E03980", VA = "0x185E04580", Slot = "4")]
	public bool GHCDJPAIEBP(IJFILFNCAOA JNPKHIBFGKN, EAAMNLEDMLN ANNDMLIIDLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x5E04620", Offset = "0x5E03A20", VA = "0x185E04620", Slot = "8")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x5E04310", Offset = "0x5E03710", VA = "0x185E04310", Slot = "6")]
	public void BMCBGEPDDJE(NativeArray<IJFILFNCAOA> OMNMPNPKGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x5E04090", Offset = "0x5E03490", VA = "0x185E04090", Slot = "5")]
	public void AMPGEEDPLEG(IJFILFNCAOA JNPKHIBFGKN, Span<EAAMNLEDMLN> MFEJFLABCIK, bool KFBHGNMLDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x5E044F0", Offset = "0x5E038F0", VA = "0x185E044F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MKFEEONJEHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[PNAJALIKCOM(typeof(IOEPDKPCAAM), new string[] { })]
public sealed class JMABGHBAFEC : IOEPDKPCAAM, GPOELIKPIAP<IOEPDKPCAAM>, CNJKPBKICBD, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly Dictionary<EAAMNLEDMLN, IMINMDJAAHH> IEGHBKFHLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private GFPNEIJFJOH DHNALPFKGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private IIALBECIDBK MFEJFLABCIK;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool PGBDKECMCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7CAC20", Offset = "0x7CA020", VA = "0x1807CAC20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x5E00CA0", Offset = "0x5E000A0", VA = "0x185E00CA0")]
	public JMABGHBAFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x5E00910", Offset = "0x5DFFD10", VA = "0x185E00910", Slot = "5")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x5E00B90", Offset = "0x5DFFF90", VA = "0x185E00B90", Slot = "6")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x5E00970", Offset = "0x5DFFD70", VA = "0x185E00970", Slot = "4")]
	public bool IIDAIDKPMAP(EAAMNLEDMLN PIKCMFPLBNL, [Out] IMINMDJAAHH HOGACIGOPKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(GFPNEIJFJOH), new string[] { })]
internal sealed class GFPNEIJFJOH : CNJKPBKICBD
{
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private readonly Dictionary<Type, IMINMDJAAHH> IEGHBKFHLGF;

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE960", Offset = "0x5DFDD60", VA = "0x185DFE960", Slot = "4")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEA80", Offset = "0x5DFDE80", VA = "0x185DFEA80")]
	public void KIPDOAILNDA(Type IJFAMCPOKBO, IMINMDJAAHH HOGACIGOPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE9B0", Offset = "0x5DFDDB0", VA = "0x185DFE9B0")]
	public bool IIDAIDKPMAP(Type IJFAMCPOKBO, [Out] IMINMDJAAHH HOGACIGOPKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEC30", Offset = "0x5DFE030", VA = "0x185DFEC30")]
	public GFPNEIJFJOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class COCDACLCFMG
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5FB0", Offset = "0x5DF53B0", VA = "0x185DF5FB0")]
	public static void KIPDOAILNDA(this GFPNEIJFJOH PDMNBLCHBOO, IMINMDJAAHH HOGACIGOPKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[AlwaysUpdateSystem]
internal class OBMIHPONONO : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public OBMIHPONONO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class NPEDPBFHMAJ : AddEntityBundlePartsToLinkedEntityGroupSystemBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EntityCommandBufferSystem PAKMEGEOHCF;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	protected override EntityCommandBufferSystem KCPGJDGFOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7610A0", Offset = "0x7604A0", VA = "0x1807610A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E09700", Offset = "0x5E08B00", VA = "0x185E09700", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public NPEDPBFHMAJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	public abstract class AddEntityBundlePartsToLinkedEntityGroupSystemBase : EJPAANLNCMB
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		private struct PrefabPartAddedTag : IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AddEntityBundlePartsToLinkedEntityGroupSystemBase_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400029E")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400029F")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x5DEC080", Offset = "0x5DEB480", VA = "0x185DEC080")]
			private void OJJILIFPAAA(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x5DEBFD0", Offset = "0x5DEB3D0", VA = "0x185DEBFD0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D3")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct AddEntityBundlePartsToLinkedEntityGroupSystemBase_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A0")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			public ComponentTypeHandle<MEBFJJJGPPA> __prefabPartDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x5DEC230", Offset = "0x5DEB630", VA = "0x185DEC230")]
			private void OJJILIFPAAA(Entity entity, [NoAlias] MEBFJJJGPPA prefabPartData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x5DEC0F0", Offset = "0x5DEB4F0", VA = "0x185DEC0F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private EntityQuery addQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery AddEntityBundlePartsToLinkedEntityGroupSystemBase_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery AddEntityBundlePartsToLinkedEntityGroupSystemBase_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private ComponentTypeHandle<MEBFJJJGPPA> __RecRoom_Components_EntityBundlePartData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		protected abstract EntityCommandBufferSystem Ecbs
		{
			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC730", Offset = "0x5DEBB30", VA = "0x185DEC730", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC2D0", Offset = "0x5DEB6D0", VA = "0x185DEC2D0")]
		private JobHandle MLJKNHHBEGP(EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBEB0", Offset = "0x5DEB2B0", VA = "0x185DEBEB0")]
		private JobHandle DPECFPFDFBE(EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC3B0", Offset = "0x5DEB7B0", VA = "0x185DEC3B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		protected AddEntityBundlePartsToLinkedEntityGroupSystemBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public class HNEEACHHBBN : AddEntityBundlePartsToLinkedEntityGroupSystemBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private EntityCommandBufferSystem PAKMEGEOHCF;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	protected override EntityCommandBufferSystem KCPGJDGFOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7610A0", Offset = "0x7604A0", VA = "0x1807610A0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFD30", Offset = "0x5DFF130", VA = "0x185DFFD30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public HNEEACHHBBN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class UpdateAuthoredChildrenFromParent : ParentSystemBase<AuthoredParentData, AuthoredPreviousParentData, AuthoredChildrenData>
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A7D0", Offset = "0x5E09BD0", VA = "0x185E0A7D0", Slot = "14")]
		protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D60", Offset = "0x7E3160", VA = "0x1807E3D60", Slot = "15")]
		protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A790", Offset = "0x5E09B90", VA = "0x185E0A790", Slot = "16")]
		protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A750", Offset = "0x5E09B50", VA = "0x185E0A750", Slot = "17")]
		protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A810", Offset = "0x5E09C10", VA = "0x185E0A810")]
		public UpdateAuthoredChildrenFromParent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class ODFIFJJJPIC : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private object HAHBPGBBCIK;

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E09760", Offset = "0x5E08B60", VA = "0x185E09760", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E097E0", Offset = "0x5E08BE0", VA = "0x185E097E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E09890", Offset = "0x5E08C90", VA = "0x185E09890", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public ODFIFJJJPIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class BABNBMJOJAJ : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private object HAHBPGBBCIK;

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DECA80", Offset = "0x5DEBE80", VA = "0x185DECA80", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DECB00", Offset = "0x5DEBF00", VA = "0x185DECB00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DECBB0", Offset = "0x5DEBFB0", VA = "0x185DECBB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public BABNBMJOJAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal abstract class EIKAAFCJFNF : KNCNEKLHJJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBFA0", Offset = "0x5DFB3A0", VA = "0x185DFBFA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC280", Offset = "0x5DFB680", VA = "0x185DFC280", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9050", Offset = "0x5DF8450", VA = "0x185DF9050")]
	protected EIKAAFCJFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[MNMKEMHOEGL]
internal abstract class KNCNEKLHJJB : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	protected INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	protected JICJPEPDNGF GOCPNHJEOMK;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	protected abstract JALPHNEDAHD IHODPLDPJND
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E02580", Offset = "0x5E01980", VA = "0x185E02580", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E02870", Offset = "0x5E01C70", VA = "0x185E02870")]
	protected void NOBBJNOGPLC(EntityQuery NGALCCNNOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E025F0", Offset = "0x5E019F0", VA = "0x185E025F0")]
	protected void KFKEHCDINIC(EntityQuery NGALCCNNOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E02510", Offset = "0x5E01910", VA = "0x185E02510")]
	protected DLCLMIEPGBN FFMGCLLBBEB(EntityQuery NGALCCNNOFF)
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	protected KNCNEKLHJJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal abstract class GDFDJODNEMH : KNCNEKLHJJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private EntityQuery CHNBDHOENJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private EntityQuery MGDCIDPEKHD;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD510", Offset = "0x5DFC910", VA = "0x185DFD510", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD870", Offset = "0x5DFCC70", VA = "0x185DFD870", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD420", Offset = "0x5DFC820", VA = "0x185DFD420")]
	private void CELBIBDMEBP(EntityQuery NGALCCNNOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBBA0", Offset = "0x5DEAFA0", VA = "0x185DEBBA0")]
	protected GDFDJODNEMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal class PLMJNAJDNIC : EIKAAFCJFNF
{
	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected override JALPHNEDAHD IHODPLDPJND
	{
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x5E09BA0", Offset = "0x5E08FA0", VA = "0x185E09BA0", Slot = "15")]
		get
		{
			return default(JALPHNEDAHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9050", Offset = "0x5DF8450", VA = "0x185DF9050")]
	public PLMJNAJDNIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal class KAEEIBHOLKE : GDFDJODNEMH
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	protected override JALPHNEDAHD IHODPLDPJND
	{
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E017B0", Offset = "0x5E00BB0", VA = "0x185E017B0", Slot = "15")]
		get
		{
			return default(JALPHNEDAHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBBA0", Offset = "0x5DEAFA0", VA = "0x185DEBBA0")]
	public KAEEIBHOLKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class DFJFEICEDLK : EIKAAFCJFNF
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	protected override JALPHNEDAHD IHODPLDPJND
	{
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DF8FE0", Offset = "0x5DF83E0", VA = "0x185DF8FE0", Slot = "15")]
		get
		{
			return default(JALPHNEDAHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9050", Offset = "0x5DF8450", VA = "0x185DF9050")]
	public DFJFEICEDLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class HDOKNDOHIFH : GDFDJODNEMH
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	protected override JALPHNEDAHD IHODPLDPJND
	{
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DFF640", Offset = "0x5DFEA40", VA = "0x185DFF640", Slot = "15")]
		get
		{
			return default(JALPHNEDAHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBBA0", Offset = "0x5DEAFA0", VA = "0x185DEBBA0")]
	public HDOKNDOHIFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal class OHCADKMDGLN : EIKAAFCJFNF
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected override JALPHNEDAHD IHODPLDPJND
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E09B30", Offset = "0x5E08F30", VA = "0x185E09B30", Slot = "15")]
		get
		{
			return default(JALPHNEDAHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9050", Offset = "0x5DF8450", VA = "0x185DF9050")]
	public OHCADKMDGLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class AEPODOOIKCD : GDFDJODNEMH
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	protected override JALPHNEDAHD IHODPLDPJND
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBB30", Offset = "0x5DEAF30", VA = "0x185DEBB30", Slot = "15")]
		get
		{
			return default(JALPHNEDAHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBBA0", Offset = "0x5DEAFA0", VA = "0x185DEBBA0")]
	public AEPODOOIKCD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal struct HLNGJDGAMNG : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal struct EPPGCIHLGNC : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal struct ALNOINFIIDO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public readonly struct JALPHNEDAHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public readonly ComponentType? IMBIEHFDDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public readonly ComponentType? FBDFMBPMOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public readonly ComponentType EIDCNFCDMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public readonly object KJAGMGIFCEM;

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E008D0", Offset = "0x5DFFCD0", VA = "0x185E008D0")]
	public JALPHNEDAHD(ComponentType? IMBIEHFDDPL, ComponentType? FBDFMBPMOLA, ComponentType EIDCNFCDMOH, object KJAGMGIFCEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x23EE960", Offset = "0x23EDD60", VA = "0x1823EE960")]
	public static JALPHNEDAHD DGCJAPDDOKE<TReq, TTag>(object KJAGMGIFCEM)
	{
		return default(JALPHNEDAHD);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x23EEC30", Offset = "0x23EE030", VA = "0x1823EEC30")]
	public static JALPHNEDAHD JPIGACJBPPF<TReq, TMissing, TTag>(object KJAGMGIFCEM)
	{
		return default(JALPHNEDAHD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class FAIAPGFBMII
{
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly JALPHNEDAHD FDGKHJCPFHO;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly JALPHNEDAHD ECEJLCDNENM;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly JALPHNEDAHD NNHINJMHAOI;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[AlwaysUpdateSystem]
	[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
	[CompilerGenerated]
	public class CalculateCollisionIslandUpdatesSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct CalculateCollisionIslandUpdatesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			public NativeList<Entity> rootsWithForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			public NativeList<Entity> rootsWithoutForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			[ReadOnly]
			public ComponentTypeHandle<MPHIBPINOKE> collisionIslandRootDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002BF")]
			[ReadOnly]
			public ComponentDataFromEntity<MPHIBPINOKE> collisionIslandRootDataFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002C0")]
			[ReadOnly]
			public ComponentTypeHandle<KNEGODHIADI> splineParentHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			public EntityQueryInJob changedLocalPoseQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002C2")]
			public EntityQueryInJob changedSplinePointsQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			public EntityQueryInJob splinesWithChangedChildrenQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40002C4")]
			public EntityQueryInJob changedCollisionModeQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public EntityQueryInJob changedScopeRootQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x5DF63D0", Offset = "0x5DF57D0", VA = "0x185DF63D0")]
			private void OJJILIFPAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x5DF63C0", Offset = "0x5DF57C0", VA = "0x185DF63C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private EntityQuery changedLocalPoseQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EntityQuery changedSplinePointsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private EntityQuery splinesWithChangedChildrenQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private EntityQuery changedCollisionModeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private EntityQuery scopeRootChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private PEKDDHBDMJC collisionIslandService;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6370", Offset = "0x5DF5770", VA = "0x185DF6370", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6BF0", Offset = "0x5DF5FF0", VA = "0x185DF6BF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6F80", Offset = "0x5DF6380", VA = "0x185DF6F80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DF61D0", Offset = "0x5DF55D0", VA = "0x185DF61D0")]
		private JobHandle CPGNKDNMKPD(NativeList<Entity> rootsWithForcedCollisionUpdate, NativeList<Entity> rootsWithoutForcedCollisionUpdate, ComponentTypeHandle<MPHIBPINOKE> collisionIslandRootDataHandleRO, ComponentDataFromEntity<MPHIBPINOKE> collisionIslandRootDataFromEntityRO, ComponentTypeHandle<KNEGODHIADI> splineParentHandleRO, EntityQueryInJob changedLocalPoseQueryInJob, EntityQueryInJob changedSplinePointsQueryInJob, EntityQueryInJob splinesWithChangedChildrenQueryInJob, EntityQueryInJob changedCollisionModeQueryInJob, EntityQueryInJob changedScopeRootQueryInJob, Allocator allocator, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public CalculateCollisionIslandUpdatesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[BurstCompatible]
internal readonly struct MMFLBMOJCBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private readonly DLIOHLHECNO FPIGOHGCHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private readonly IOIOGBEHOCO GOJIBFLGAID;

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x982310", Offset = "0x981710", VA = "0x180982310")]
	public MMFLBMOJCBG(DLIOHLHECNO FPIGOHGCHMA, IOIOGBEHOCO GOJIBFLGAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x1B87E60", Offset = "0x1B87260", VA = "0x181B87E60")]
	public bool FAKAJDEJHBE(MMFLBMOJCBG EBFCMPBKGBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x1B87E60", Offset = "0x1B87260", VA = "0x181B87E60")]
	public bool BCDCPGMILMI(MMFLBMOJCBG JHAODPLJNCN)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
	[CompilerGenerated]
	public class CalculateContainerCollisionIslandGraphChangesSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x20000EB")]
		[BurstCompile]
		private struct FindChangedIslandsJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D2")]
			[ReadOnly]
			public EntityQueryInJob deletedConnectablesQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002D3")]
			[ReadOnly]
			public EntityQueryInJob changedIslandQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002D4")]
			[ReadOnly]
			public EntityQueryInJob hierarchyChangeQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			[ReadOnly]
			public EntityQueryInJob newRootsQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			[ReadOnly]
			public ChunkFilterAnyOf2ComponentsChanged islandSplitChangeFilterRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			[ReadOnly]
			public ComponentTypeHandle<PLNNOOGNGHA> islandRootSystemDataTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			[ReadOnly]
			public ComponentDataFromEntity<GEMJFPKLADF> dontPropagatePhysicsPropertiesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			[ReadOnly]
			public ComponentDataFromEntity<DLIOHLHECNO> containerCollisionModeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			[ReadOnly]
			public ComponentDataFromEntity<IOIOGBEHOCO> containerCollisionLayerRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			[ReadOnly]
			public ComponentDataFromEntity<GOBHHHGNKIK> containerCollisionIslandRootTagRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[ReadOnly]
			public ComponentDataFromEntity<ParentData> parentRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> childrenRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			[WriteOnly]
			public NativeList<Entity> changedIslandComponentsBufferWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			[WriteOnly]
			public NativeList<HOGGGGKFFCP> changedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			[WriteOnly]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			[WriteOnly]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			public ComponentDataFromEntity<MPHIBPINOKE> collisionIslandRootDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			public NativeParallelHashSet<Entity> visitedRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			private int bufferHead;

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E146D0", Offset = "0x5E13AD0", VA = "0x185E146D0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x5E14E90", Offset = "0x5E14290", VA = "0x185E14E90")]
			private void LIFAJIEICCH(Entity startEntity, bool checkForUnchanged)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x5E14D80", Offset = "0x5E14180", VA = "0x185E14D80")]
			private Entity IBOLLDCCPAL(Entity curEntity, MMFLBMOJCBG classifier)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x5E14290", Offset = "0x5E13690", VA = "0x185E14290")]
			private bool BPHMAHBPNGL(Entity curEntity, MMFLBMOJCBG classifier, [Out] Entity parentEntity, [Out] MMFLBMOJCBG parentClassifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x5E15040", Offset = "0x5E14440", VA = "0x185E15040")]
			private void PKHDEJKMNHO(Entity islandRoot, MMFLBMOJCBG classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x5E14350", Offset = "0x5E13750", VA = "0x185E14350")]
			private void CIPAPOKPOPC(Entity islandRoot, Entity entity, MMFLBMOJCBG classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x5E145C0", Offset = "0x5E139C0", VA = "0x185E145C0")]
			private void ECCEGIHOHBH(Entity islandRoot, Entity component)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x5E14E00", Offset = "0x5E14200", VA = "0x185E14E00")]
			private bool LGDBLJLOGBK(Entity entity, [Out] MMFLBMOJCBG classifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x5E14210", Offset = "0x5E13610", VA = "0x185E14210")]
			private MMFLBMOJCBG AJBDPNBCILE(Entity entity)
			{
				return default(MMFLBMOJCBG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct CalculateContainerCollisionIslandGraphChangesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			[ReadOnly]
			public EntityTypeHandle entityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x5E0C850", Offset = "0x5E0BC50", VA = "0x185E0C850")]
			private void OJJILIFPAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x5E0C840", Offset = "0x5E0BC40", VA = "0x185E0C840", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		[MFFAOKEGCNH]
		private PEKDDHBDMJC collisionIslandService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private EntityQuery changedIslandStructureQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private EntityQuery hierarchyChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private EntityQuery newRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private EntityQuery deletedConnectablesQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private EntityQuery deletedRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private EntityQuery islandRootDataQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private EntityQuery islandRootTagQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private PDCBNKIBHOF ecbs;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E0C090", Offset = "0x5E0B490", VA = "0x185E0C090", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E0CD40", Offset = "0x5E0C140", VA = "0x185E0CD40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D190", Offset = "0x5E0C590", VA = "0x185E0D190", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E0C0E0", Offset = "0x5E0B4E0", VA = "0x185E0C0E0")]
		private JobHandle LKKBPDGKFJK(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E0C980", Offset = "0x5E0BD80", VA = "0x185E0C980")]
		private JobHandle NHJNMHOJEAL(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E0CC40", Offset = "0x5E0C040", VA = "0x185E0CC40")]
		private JobHandle NLILBGFGOAH(EntityCommandBuffer ecb, NativeList<Entity> removedIslandRootsWO, EntityTypeHandle entityType, EntityQueryInJob queryInJob, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public CalculateContainerCollisionIslandGraphChangesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
[AlwaysUpdateSystem]
public class LIFLKLLHJAP : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	[MFFAOKEGCNH]
	private PEKDDHBDMJC ADHKMFEMJCO;

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E300", Offset = "0x5E1D700", VA = "0x185E1E300", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E350", Offset = "0x5E1D750", VA = "0x185E1E350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public LIFLKLLHJAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class FPKKFDKLADA : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private NMDHGCKCBIM BEOJNJDKKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private EMNPAEAJLNA LLNHEAEIKHH;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x5E13B30", Offset = "0x5E12F30", VA = "0x185E13B30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x5E13AA0", Offset = "0x5E12EA0", VA = "0x185E13AA0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x5E13C40", Offset = "0x5E13040", VA = "0x185E13C40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public FPKKFDKLADA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class GHHDAIMBJFP : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public PCCDMPNJHHD PIOJMHPNEKO;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GHHDAIMBJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x763340", Offset = "0x762740", VA = "0x180763340")]
	public GHHDAIMBJFP(PCCDMPNJHHD PIOJMHPNEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x5E155E0", Offset = "0x5E149E0", VA = "0x185E155E0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public abstract class EOAAIODENLM : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private BCLKHHIKFMA AMEAOOFACPA;

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x5E11CC0", Offset = "0x5E110C0", VA = "0x185E11CC0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x5E11D20", Offset = "0x5E11120", VA = "0x185E11D20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x5E11D50", Offset = "0x5E11150", VA = "0x185E11D50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	protected EOAAIODENLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public class IPPCPEBLPFB : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private EntityQuery NDHCANPFMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private EntityQuery JMMEFOGHFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private EntityQuery DNLDDOPIMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private EntityQuery LNFBNKJDBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private BCLKHHIKFMA FFLHNJODMOF;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int BMPJPCDLNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x5E187E0", Offset = "0x5E17BE0", VA = "0x185E187E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x5E188F0", Offset = "0x5E17CF0", VA = "0x185E188F0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x5E18B00", Offset = "0x5E17F00", VA = "0x185E18B00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x5E18D30", Offset = "0x5E18130", VA = "0x185E18D30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x5E187C0", Offset = "0x5E17BC0", VA = "0x185E187C0")]
	public int DMMBKDMFJCH(SceneTag PMDINEBDLOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x5E18D50", Offset = "0x5E18150", VA = "0x185E18D50")]
	protected void PKHNHMKDADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x5E18620", Offset = "0x5E17A20", VA = "0x185E18620")]
	protected void CLHNFMGCGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x5E18A60", Offset = "0x5E17E60", VA = "0x185E18A60")]
	public NativeArrayAsync<Entity> NBOIMIFPAJB(SceneTag PMDINEBDLOA, Allocator KIKFOGPECEC = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x5E18AB0", Offset = "0x5E17EB0", VA = "0x185E18AB0")]
	public NativeArrayAsync<Entity> ONCABAEDOEF(SceneTag PMDINEBDLOA, Allocator KIKFOGPECEC = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x5E18950", Offset = "0x5E17D50", VA = "0x185E18950")]
	public bool JEHPOCJCOFF(SceneTag PMDINEBDLOA, [Out] NativeArrayAsync<Entity> PIOJMHPNEKO, Allocator KIKFOGPECEC = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x5E187F0", Offset = "0x5E17BF0", VA = "0x185E187F0")]
	public bool HEIAMNBIGPH(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x5E18750", Offset = "0x5E17B50", VA = "0x185E18750")]
	public bool DHIPACEFKGL(Entity FILKDLNBIJH, [Out] GHHDAIMBJFP PIOJMHPNEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x5E18870", Offset = "0x5E17C70", VA = "0x185E18870")]
	public void IGHFGHAPNIA(Entity FILKDLNBIJH, GHHDAIMBJFP PIOJMHPNEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x5E189E0", Offset = "0x5E17DE0", VA = "0x185E189E0")]
	public bool LCNEIFJMCKC(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public IPPCPEBLPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal class GEABGHJBMOJ : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private EntityQuery GKOJJAGMNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private AFLJLAKFEOK MKNFLEECOBD;

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x5E151E0", Offset = "0x5E145E0", VA = "0x185E151E0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x5E15230", Offset = "0x5E14630", VA = "0x185E15230", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x5E152F0", Offset = "0x5E146F0", VA = "0x185E152F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x2391A40", Offset = "0x2390E40", VA = "0x182391A40")]
	private bool IHFCIBFBLAP<TComponentData>(EntityQuery NGALCCNNOFF, [Out] NativeArray<Entity> BAPHNAADJCK, [Out] NativeArray<TComponentData> MGFLEBFIMPH) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x5E15150", Offset = "0x5E14550", VA = "0x185E15150")]
	public PCCDMPNJHHD AEFAHEBADIH(Entity FILKDLNBIJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public GEABGHJBMOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public class MFFFGGFNLGN : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery MEEDMANHLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private EntityQuery OAMKHFMGELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery ADJDFEBDEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private EntityQuery IIIHFKFIGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private MJMAOFFIBEJ MKNFLEECOBD;

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E840", Offset = "0x5E1DC40", VA = "0x185E1E840", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E890", Offset = "0x5E1DC90", VA = "0x185E1E890", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EB10", Offset = "0x5E1DF10", VA = "0x185E1EB10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E7B0", Offset = "0x5E1DBB0", VA = "0x185E1E7B0")]
	private void INMJBKGEACO(EntityQuery NGALCCNNOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E3A0", Offset = "0x5E1D7A0", VA = "0x185E1E3A0")]
	private void BLFHNKIOGCM(EntityQuery NGALCCNNOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EA80", Offset = "0x5E1DE80", VA = "0x185E1EA80", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E430", Offset = "0x5E1D830", VA = "0x185E1E430")]
	private void DKFDGMECGHO(EntityQuery NGALCCNNOFF, bool ELBHFFKMPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public MFFFGGFNLGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public sealed class HLOAMBOBDNE : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private EEKMFIANCNG NELCKHGKJPL;

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x5E182F0", Offset = "0x5E176F0", VA = "0x185E182F0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x5E18350", Offset = "0x5E17750", VA = "0x185E18350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public HLOAMBOBDNE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	public class GatherModifiedParentsSystem : EJPAANLNCMB, DFFDMFBJPHA
	{
		[Cpp2IlInjected.Token(Token = "0x20000F6")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherModifiedParents_AddNewParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			public NativeList<OOPAIGCDJBO> newParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __currentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x5E16820", Offset = "0x5E15C20", VA = "0x185E16820")]
			private void OJJILIFPAAA(Entity entity, [In][NoAlias] ParentData current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x5E16700", Offset = "0x5E15B00", VA = "0x185E16700", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherModifiedParents_AddChangedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public NativeList<JJKHGHKNBKD> changedParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __currentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			[ReadOnly]
			public ComponentTypeHandle<PreviousParentData> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x5E16640", Offset = "0x5E15A40", VA = "0x185E16640")]
			private void OJJILIFPAAA(Entity entity, [In][NoAlias] ParentData current, [In][NoAlias] PreviousParentData previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x5E164A0", Offset = "0x5E158A0", VA = "0x185E164A0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherModifiedParents_AddRemovedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public NativeList<OOPAIGCDJBO> oldParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			[ReadOnly]
			public ComponentTypeHandle<PreviousParentData> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x5E169C0", Offset = "0x5E15DC0", VA = "0x185E169C0")]
			private void OJJILIFPAAA(Entity entity, [In][NoAlias] PreviousParentData previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x5E168A0", Offset = "0x5E15CA0", VA = "0x185E168A0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private FGGFOCNBCHP parentEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private EntityQuery GatherModifiedParents_AddNewParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private EntityQuery GatherModifiedParents_AddChangedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private EntityQuery GatherModifiedParents_AddRemovedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private ComponentTypeHandle<PreviousParentData> __RecRoom_Components_PreviousParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x5E15A80", Offset = "0x5E14E80", VA = "0x185E15A80", Slot = "14")]
		public void MIEIACCMPNB(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x5E16130", Offset = "0x5E15530", VA = "0x185E16130", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x5E156E0", Offset = "0x5E14AE0", VA = "0x185E156E0")]
		private JobHandle CPLJLAFPIID(NativeList<OOPAIGCDJBO> newParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x5E15800", Offset = "0x5E14C00", VA = "0x185E15800")]
		private JobHandle JIJHJJLDLCO(NativeList<JJKHGHKNBKD> changedParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x5E15960", Offset = "0x5E14D60", VA = "0x185E15960")]
		private JobHandle JJKJGAKCOBC(NativeList<OOPAIGCDJBO> oldParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x5E15B60", Offset = "0x5E14F60", VA = "0x185E15B60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public GatherModifiedParentsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class MPPANNJOIAA : ParentSystemBase<ParentData, PreviousParentData, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x5E20DE0", Offset = "0x5E201E0", VA = "0x185E20DE0", Slot = "14")]
	protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc NGALCCNNOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D60", Offset = "0x7E3160", VA = "0x1807E3D60", Slot = "15")]
	protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc NGALCCNNOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x5E20DA0", Offset = "0x5E201A0", VA = "0x185E20DA0", Slot = "16")]
	protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc NGALCCNNOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x5E20D60", Offset = "0x5E20160", VA = "0x185E20D60", Slot = "17")]
	protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc NGALCCNNOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x5E20E20", Offset = "0x5E20220", VA = "0x185E20E20")]
	public MPPANNJOIAA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public abstract class ParentSystemBase<TParentData, TPreviousParentData, TChildrenData> : EJPAANLNCMB where TParentData : struct, IComponentData, OLCDGJMALOC where TPreviousParentData : struct, IComponentData, OLCDGJMALOC where TChildrenData : struct, ISystemStateBufferElementData, IEquatable<TChildrenData>, OLCDGJMALOC
	{
		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		[BurstCompile]
		internal struct GatherChangedParents : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter ParentChildrenToAdd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000319")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter ParentChildrenToRemove;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			public NativeParallelHashMap<Entity, int>.ParallelWriter UniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public ComponentTypeHandle<TPreviousParentData> PreviousParentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			[ReadOnly]
			public ComponentTypeHandle<TParentData> ParentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			[ReadOnly]
			public EntityTypeHandle EntityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			public uint LastSystemVersion;

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x3506750", Offset = "0x3505B50", VA = "0x183506750", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		[BurstCompile]
		internal struct FindMissingChild : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> UniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> ChildFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public NativeList<Entity> ParentsMissingChild;

			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x3417870", Offset = "0x3416C70", VA = "0x183417870", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		[BurstCompile]
		internal struct FixupChangedChildren : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> ParentChildrenToAdd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> ParentChildrenToRemove;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> UniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public BufferFromEntity<TChildrenData> ChildFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0x3420240", Offset = "0x341F640", VA = "0x183420240")]
			private int FindChildIndex(DynamicBuffer<TChildrenData> children, Entity entity)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x3420320", Offset = "0x341F720", VA = "0x183420320")]
			private void RemoveChildrenFromParent(Entity parent, DynamicBuffer<TChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x341FD60", Offset = "0x341F160", VA = "0x18341FD60")]
			private void AddChildrenToParent(Entity parent, DynamicBuffer<TChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x341FEA0", Offset = "0x341F2A0", VA = "0x18341FEA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		[BurstCompile]
		private struct GatherChildEntities : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			[ReadOnly]
			public NativeArray<Entity> Parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			public NativeList<Entity> Children;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> ChildFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public ComponentDataFromEntity<TParentData> ParentFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0x3506E70", Offset = "0x3506270", VA = "0x183506E70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected EntityQuery m_NewParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected EntityQuery m_RemovedParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected EntityQuery m_ExistingParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected EntityQuery m_DeletedParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected ProfilerMarker m_ProfileDeletedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected ProfilerMarker m_ProfileRemoveParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected ProfilerMarker m_ProfileChangeParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected ProfilerMarker m_ProfileNewParents;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E3A0", Offset = "0x3E1D7A0", VA = "0x183E1E3A0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x3E1BC50", Offset = "0x3E1B050", VA = "0x183E1BC50")]
		private int FindChildIndex(DynamicBuffer<TChildrenData> children, Entity entity)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C740", Offset = "0x3E1BB40", VA = "0x183E1C740")]
		private void RemoveChildFromParent(Entity childEntity, Entity parentEntity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D60", Offset = "0x7E3160", VA = "0x1807E3D60", Slot = "14")]
		protected virtual EntityQueryDesc FilterNewParentQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D60", Offset = "0x7E3160", VA = "0x1807E3D60", Slot = "15")]
		protected virtual EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7E3D60", Offset = "0x7E3160", VA = "0x1807E3D60", Slot = "16")]
		protected virtual EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc query);

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x3E1BD50", Offset = "0x3E1B150", VA = "0x183E1BD50", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x3E1DED0", Offset = "0x3E1D2D0", VA = "0x183E1DED0")]
		private void UpdateNewParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x3E1E1B0", Offset = "0x3E1D5B0", VA = "0x183E1E1B0")]
		private void UpdateRemoveParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x3E1CF40", Offset = "0x3E1C340", VA = "0x183E1CF40")]
		private JobHandle UpdateChangeParents(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x3E1D9C0", Offset = "0x3E1CDC0", VA = "0x183E1D9C0")]
		private void UpdateDeletedParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C4C0", Offset = "0x3E1B8C0", VA = "0x183E1C4C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x3E1C490", Offset = "0x3E1B890", VA = "0x183E1C490", Slot = "7")]
		protected override void OnStopRunning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[AlwaysUpdateSystem]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public abstract class DAPCNLHMJOC : EJPAANLNCMB, DFFDMFBJPHA
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private struct PAFPEDBHMFM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public NativeListAsync<Entity> FBECHCOEHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public NativeListAsync<Entity> DOBIAPPBKFP;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x5E21750", Offset = "0x5E20B50", VA = "0x185E21750")]
		public PAFPEDBHMFM(NativeList<Entity> FBECHCOEHCI, NativeList<Entity> DOBIAPPBKFP, JobHandle IJAGDFPAFEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x5E216D0", Offset = "0x5E20AD0", VA = "0x185E216D0")]
		public JobHandle FHPGGLNOMMP(JobHandle MCHBCAPEEON)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x5E21640", Offset = "0x5E20A40", VA = "0x185E21640", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[BurstCompile]
	private struct FLOJIAPLJHI : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[Flags]
		public enum GKBIALLFDHI
		{
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		[WriteOnly]
		public NativeList<Entity> DNLMOKBDGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		[WriteOnly]
		public NativeList<Entity> OIBEBEOLOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		[ReadOnly]
		public NativeArray<Entity> AEMPJDPJLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> FCFMIDCGCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		[ReadOnly]
		public ComponentDataFromEntity FIEHPIODOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		[ReadOnly]
		public ComponentDataFromEntity GNEEGJPAOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> BCBMOGIMHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public int BIHCINEODON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public int IDNLAJODFLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private GKBIALLFDHI JGLMGGBJBOL;

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x5E132A0", Offset = "0x5E126A0", VA = "0x185E132A0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x5E131F0", Offset = "0x5E125F0", VA = "0x185E131F0")]
		private bool CJMLEHJDDHD(Entity FILKDLNBIJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x5E13890", Offset = "0x5E12C90", VA = "0x185E13890")]
		private void NDJFLBPIKNM(Entity FILKDLNBIJH, bool GGCAIFOCBKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x5E139A0", Offset = "0x5E12DA0", VA = "0x185E139A0")]
		private void PJJKNGHOMFE(Entity FILKDLNBIJH, bool GGCAIFOCBKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x5E13730", Offset = "0x5E12B30", VA = "0x185E13730")]
		public PAFPEDBHMFM LHMKFHKAPKC(NativeArray<Entity> BJEJBGEKBMB, JobHandle MCHBCAPEEON)
		{
			return default(PAFPEDBHMFM);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x5E13920", Offset = "0x5E12D20", VA = "0x185E13920")]
		public PAFPEDBHMFM PFENBFJLPLI(NativeArray<Entity> BJEJBGEKBMB, JobHandle MCHBCAPEEON)
		{
			return default(PAFPEDBHMFM);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x5E13650", Offset = "0x5E12A50", VA = "0x185E13650")]
		public PAFPEDBHMFM JCEOBOMAJAF(NativeList<OOPAIGCDJBO> KEKPLKHNJAG, JobHandle MCHBCAPEEON)
		{
			return default(PAFPEDBHMFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x5E137B0", Offset = "0x5E12BB0", VA = "0x185E137B0")]
		public PAFPEDBHMFM MMGAFCCEKMA(NativeList<OOPAIGCDJBO> KEKPLKHNJAG, JobHandle MCHBCAPEEON)
		{
			return default(PAFPEDBHMFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x5E13110", Offset = "0x5E12510", VA = "0x185E13110")]
		public PAFPEDBHMFM CACNJGCOCAK(NativeList<JJKHGHKNBKD> KEKPLKHNJAG, JobHandle MCHBCAPEEON)
		{
			return default(PAFPEDBHMFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x29848A0", Offset = "0x2983CA0", VA = "0x1829848A0")]
		private PAFPEDBHMFM FJMDCJELGFO<T>(NativeList<T> KEKPLKHNJAG, int JCDBNHKFJMB, int CCOEGOAIBPO, GKBIALLFDHI DGDIMEGBJJP, JobHandle MCHBCAPEEON) where T : struct
		{
			return default(PAFPEDBHMFM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x5E133D0", Offset = "0x5E127D0", VA = "0x185E133D0")]
		private PAFPEDBHMFM FJMDCJELGFO(NativeArray<Entity> BAPHNAADJCK, int JCDBNHKFJMB, int CCOEGOAIBPO, GKBIALLFDHI DGDIMEGBJJP, JobHandle MCHBCAPEEON)
		{
			return default(PAFPEDBHMFM);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private EntityQuery NIGDHKHFANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private EntityQuery KKEHONGKFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private FGGFOCNBCHP EANCOPMANLH;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected abstract ComponentType ICGAGJNNNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	protected abstract ComponentType FMGPPLPBAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	protected abstract ComponentType JKIGKNNBLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x5E10690", Offset = "0x5E0FA90", VA = "0x185E10690")]
	protected DAPCNLHMJOC(FBKCBHAMJJJ AMAPEJENOPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x5E0EE30", Offset = "0x5E0E230", VA = "0x185E0EE30", Slot = "14")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x5E0F190", Offset = "0x5E0E590", VA = "0x185E0F190", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x5E0F3A0", Offset = "0x5E0E7A0", VA = "0x185E0F3A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x7FCC70", Offset = "0x7FC070", VA = "0x1807FCC70", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x5E0ED20", Offset = "0x5E0E120", VA = "0x185E0ED20")]
	private void GAIHGDJAALP(NativeArray<Entity> KEKPLKHNJAG, EntityCommandBuffer ECEKOIAALDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x5E0EC80", Offset = "0x5E0E080", VA = "0x185E0EC80")]
	private void FHGDHABEADN(NativeArray<Entity> KEKPLKHNJAG, EntityCommandBuffer ECEKOIAALDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x5E0EA00", Offset = "0x5E0DE00", VA = "0x185E0EA00")]
	private void BJPCGLDDGGG(PAFPEDBHMFM MCANAGCGEHE, string CADLFDCPDOM, EntityCommandBuffer ECEKOIAALDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x5E0EB50", Offset = "0x5E0DF50", VA = "0x185E0EB50")]
	private void BJPCGLDDGGG(NativeListAsync<Entity> HBFEALMMMDC, string CADLFDCPDOM, EntityCommandBuffer ECEKOIAALDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x5E0EF10", Offset = "0x5E0E310", VA = "0x185E0EF10")]
	private void MNOFBFKGFLK(PAFPEDBHMFM MCANAGCGEHE, string CADLFDCPDOM, EntityCommandBuffer ECEKOIAALDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x5E0F060", Offset = "0x5E0E460", VA = "0x185E0F060")]
	private void MNOFBFKGFLK(NativeListAsync<Entity> HBFEALMMMDC, string CADLFDCPDOM, EntityCommandBuffer ECEKOIAALDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x5E0EDC0", Offset = "0x5E0E1C0", VA = "0x185E0EDC0")]
	private bool IIKFAHDOAPE()
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
	[CompilerGenerated]
	public class PhysicsSceneAddCollidersSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		private struct PhysicsSceneAddCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public PhysicsSceneAddCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0x5E226C0", Offset = "0x5E21AC0", VA = "0x185E226C0")]
			private void OJJILIFPAAA(Entity e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x5E22610", Offset = "0x5E21A10", VA = "0x185E22610", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private IBDJAEPOLKK ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private FGAHOPPNDBO colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private EntityQuery PhysicsSceneAddCollidersSystem_Query;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x5E22AA0", Offset = "0x5E21EA0", VA = "0x185E22AA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x5E225B0", Offset = "0x5E219B0", VA = "0x185E225B0", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x5E22B00", Offset = "0x5E21F00", VA = "0x185E22B00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x5E227E0", Offset = "0x5E21BE0", VA = "0x185E227E0")]
		private void OLICHPMEEJJ(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x5E228D0", Offset = "0x5E21CD0", VA = "0x185E228D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PhysicsSceneAddCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[HLDCAJNGFIO(PIEFJKINJBJ.OMRoom)]
[MNMKEMHOEGL]
public class CPIDHAFBHGA : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private FGAHOPPNDBO DKKFMPOIGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private JKDKKFNOEFN EOJANGPGAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B6A0", Offset = "0x5E0AAA0", VA = "0x185E0B6A0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B710", Offset = "0x5E0AB10", VA = "0x185E0B710", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B7C0", Offset = "0x5E0ABC0", VA = "0x185E0B7C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public CPIDHAFBHGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public struct PNKBPONAMLA : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public LAPKFFFPOAD DELBIPHKFDD;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
	public static PNKBPONAMLA BNPEICKPPJA([In] LAPKFFFPOAD IKNEFBOPKPK)
	{
		return default(PNKBPONAMLA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0xAACA00", Offset = "0xAABE00", VA = "0x180AACA00")]
	public static LAPKFFFPOAD BNPEICKPPJA([In] PNKBPONAMLA GKPMIAOFLIO)
	{
		return default(LAPKFFFPOAD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
[AlwaysUpdateSystem]
public class IBDJAEPOLKK : AOKLLJPGCEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x5E185F0", Offset = "0x5E179F0", VA = "0x185E185F0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public IBDJAEPOLKK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
	[AlwaysUpdateSystem]
	public class PhysicsSceneRemoveCollidersSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		private struct PhysicsSceneRemoveCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public PhysicsSceneRemoveCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			[ReadOnly]
			public ComponentTypeHandle<PNKBPONAMLA> __chTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x5E22EB0", Offset = "0x5E222B0", VA = "0x185E22EB0")]
			private void OJJILIFPAAA(Entity e, [In] PNKBPONAMLA ch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x5E22D90", Offset = "0x5E22190", VA = "0x185E22D90", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private IBDJAEPOLKK ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private FGAHOPPNDBO colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private EntityQuery PhysicsSceneRemoveCollidersSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private ComponentTypeHandle<PNKBPONAMLA> __RecRoom_ObjectModel_Systems_PhysicsSceneColliderHandleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x5E23170", Offset = "0x5E22570", VA = "0x185E23170", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x5E22C00", Offset = "0x5E22000", VA = "0x185E22C00", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x5E231D0", Offset = "0x5E225D0", VA = "0x185E231D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x5E22C60", Offset = "0x5E22060", VA = "0x185E22C60")]
		private void JHGAOOCMCHJ(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x5E22F60", Offset = "0x5E22360", VA = "0x185E22F60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PhysicsSceneRemoveCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public class HICEDLIAAKP : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private struct MFMEEEFEKHN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public PFOOKIGEPDE IHBAGGIDMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public NativeParallelHashSet<Entity> BAPHNAADJCK;

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EDB0", Offset = "0x5E1E1B0", VA = "0x185E1EDB0")]
		public MFMEEEFEKHN(int OOIJDECJBIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1ED40", Offset = "0x5E1E140", VA = "0x185E1ED40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[BurstCompile]
	private struct DIJBLMPICAA : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		[ReadOnly]
		public NativeArray<Entity> BAPHNAADJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		[ReadOnly]
		public ComponentDataFromEntity<JBAAHJBHFEM> PIALBBFMBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		[ReadOnly]
		public ComponentDataFromEntity<MHHAAGLKIGL> IIFDKBHNABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		[ReadOnly]
		public ComponentDataFromEntity<COEKCHNJJDA> HKMLBAPLDGF;

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x5E10E90", Offset = "0x5E10290", VA = "0x185E10E90", Slot = "4")]
		public void Execute(int APOENOPNHBG, TransformAccess OLPLDGDFGHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[BurstCompile]
	private struct HDJLCFMFCPH : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		[ReadOnly]
		public NativeArray<Entity> BAPHNAADJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		[ReadOnly]
		public ComponentDataFromEntity<JBAAHJBHFEM> PIALBBFMBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		[ReadOnly]
		public ComponentDataFromEntity<COEKCHNJJDA> HKMLBAPLDGF;

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x5E16A40", Offset = "0x5E15E40", VA = "0x185E16A40", Slot = "4")]
		public void Execute(int APOENOPNHBG, TransformAccess OLPLDGDFGHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private FGAHOPPNDBO DKKFMPOIGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private EntityQuery DAGOGMOLFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private EntityQuery NOIPOLPBNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private EntityQuery EIFPBCIGCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private EntityQuery CHBAKIPNMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private EntityQuery CIHIJPOMHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private JobHandle PIKNBHDLMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private MFMEEEFEKHN FCECMOKGPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private MFMEEEFEKHN IJCAHAJFGIA;

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x5E16F80", Offset = "0x5E16380", VA = "0x185E16F80", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x5E173A0", Offset = "0x5E167A0", VA = "0x185E173A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x5E17680", Offset = "0x5E16A80", VA = "0x185E17680", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x5E17690", Offset = "0x5E16A90", VA = "0x185E17690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x5E16E40", Offset = "0x5E16240", VA = "0x185E16E40")]
	private void HEPNJLINGIH(EntityQuery NGALCCNNOFF, [Out] (NativeArrayAsync<PNKBPONAMLA> handles, NativeArrayAsync<CMLIFCOKLLM> bounds) GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x5E17EB0", Offset = "0x5E172B0", VA = "0x185E17EB0")]
	private void PEJPHLKELJN((NativeArrayAsync<PNKBPONAMLA> handles, NativeArrayAsync<CMLIFCOKLLM> bounds) GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x5E16FE0", Offset = "0x5E163E0", VA = "0x185E16FE0")]
	private void MCADPONLJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x5E16D00", Offset = "0x5E16100", VA = "0x185E16D00")]
	private void DJMKHGBBJOF(EntityQuery NGALCCNNOFF, [Out] (NativeArrayAsync<Entity> entities, NativeArrayAsync<PNKBPONAMLA> handles) GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x5E170E0", Offset = "0x5E164E0", VA = "0x185E170E0")]
	private void OKOAPLOACGJ((NativeArrayAsync<Entity> entities, NativeArrayAsync<PNKBPONAMLA> handles) GHFAAPNAFDE, MFMEEEFEKHN OCPCJNPGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x5E18100", Offset = "0x5E17500", VA = "0x185E18100")]
	private JobHandle PGOGFPKLDNO(MFMEEEFEKHN OCPCJNPGDLF, ComponentDataFromEntity<JBAAHJBHFEM> PIALBBFMBII, ComponentDataFromEntity<COEKCHNJJDA> HKMLBAPLDGF, ComponentDataFromEntity<MHHAAGLKIGL> IIFDKBHNABN)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x5E16BA0", Offset = "0x5E15FA0", VA = "0x185E16BA0")]
	private JobHandle BAJHDIMGHNL(MFMEEEFEKHN OCPCJNPGDLF, ComponentDataFromEntity<JBAAHJBHFEM> PIALBBFMBII, ComponentDataFromEntity<COEKCHNJJDA> HKMLBAPLDGF)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public HICEDLIAAKP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010E")]
public struct PAEMJGCHPAM : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[MNMKEMHOEGL]
public class KPKFFDBEJGN : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[BurstCompile]
	private struct MLPLFPOPHJN : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		[ReadOnly]
		public NativeArray<Entity> EKCMMEHCJEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		[ReadOnly]
		public ComponentDataFromEntity<KNEGODHIADI> OICAJAMKNMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		[ReadOnly]
		public ComponentDataFromEntity<CMLIFCOKLLM> OBNOECJGJJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		[ReadOnly]
		public EntityExistenceLookupByEntity EBGIDKJOCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		[WriteOnly]
		public NativeParallelHashSet<Entity>.ParallelWriter DGCIHMJAFKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter IIJCGDAFNFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter MJBJDIHEKCC;

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E1F450", Offset = "0x5E1E850", VA = "0x185E1F450", Slot = "4")]
		public void Execute(int APOENOPNHBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct IBDHGGIMALO : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		[ReadOnly]
		public NativeArray<Entity> HBJLHBPIFPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> EJMGIGDCIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		[ReadOnly]
		public ComponentDataFromEntity<PJMACGKKJMM> BNJKHFENDDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		[ReadOnly]
		public ComponentDataFromEntity<ELJOMKLCEJJ> DINPBGLNPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<CMLIFCOKLLM> BFMGONFMPMN;

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E18370", Offset = "0x5E17770", VA = "0x185E18370", Slot = "4")]
		public void Execute(int APOENOPNHBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private EntityQuery COHJGIOPGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private EntityQuery KDHGCNAEPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private EntityQuery DEMGAOAPEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private EntityQuery FAOENLGMELA;

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B910", Offset = "0x5E1AD10", VA = "0x185E1B910", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BB40", Offset = "0x5E1AF40", VA = "0x185E1BB40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AB80", Offset = "0x5E19F80", VA = "0x185E1AB80")]
	private JobHandle CNENMEEAOFM(NativeArrayAsync<Entity> FFAHMFOPGLA, int KIHHOMBMMEI, JobHandle MCHBCAPEEON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AC60", Offset = "0x5E1A060", VA = "0x185E1AC60")]
	private JobHandle CNENMEEAOFM(NativeArray<Entity> MECGPGDJLHP, int KIHHOMBMMEI, [Optional] JobHandle MCHBCAPEEON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B340", Offset = "0x5E1A740", VA = "0x185E1B340")]
	private (NativeListAsync<Entity>, NativeListAsync<Entity>) LMDNGJLFHIF(NativeArrayAsync<Entity> BAKFOGDFOFO)
	{
		return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B2C0", Offset = "0x5E1A6C0", VA = "0x185E1B2C0")]
	private void HPPMOIGIIMO([Out] NativeArray<Entity> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AE70", Offset = "0x5E1A270", VA = "0x185E1AE70")]
	private void DKAFKNJBLAC(NativeList<Entity> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AF00", Offset = "0x5E1A300", VA = "0x185E1AF00")]
	private void DKAFKNJBLAC(NativeArray<Entity> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B7A0", Offset = "0x5E1ABA0", VA = "0x185E1B7A0")]
	private void NADLNIIFLKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void JEOLJHFNGAH(int GNDCDNPPIJI, int JKIJANDELAD, int CJJCFICBHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AFE0", Offset = "0x5E1A3E0", VA = "0x185E1AFE0")]
	private static CMLIFCOKLLM GLNGAIBEOIO(NativeArray<Entity> LBPLHDOANKI, ComponentDataFromEntity<PJMACGKKJMM> BNJKHFENDDO, ComponentDataFromEntity<ELJOMKLCEJJ> DINPBGLNPFK)
	{
		return default(CMLIFCOKLLM);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public KPKFFDBEJGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
[MNMKEMHOEGL]
public class FDLCMFNJNIC : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000376")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private static readonly FBKCBHAMJJJ CECHAFPPACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	[MFFAOKEGCNH]
	private INHGBAEAGHP NFFIAJHDGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	[MFFAOKEGCNH]
	private IKGEFLGAOAF LGNEBDMIJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	[MFFAOKEGCNH]
	private EMLJAPIGCLK EINMFNFCNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private EntityQuery MPHCPGIMAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private EntityQuery IIIHFKFIGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E11D90", Offset = "0x5E11190", VA = "0x185E11D90", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E12070", Offset = "0x5E11470", VA = "0x185E12070")]
	public bool LGCFMICMIMC(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E12150", Offset = "0x5E11550", VA = "0x185E12150", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E11D70", Offset = "0x5E11170", VA = "0x185E11D70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0xF0DD80", Offset = "0xF0D180", VA = "0x180F0DD80", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E12240", Offset = "0x5E11640", VA = "0x185E12240", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E11D70", Offset = "0x5E11170", VA = "0x185E11D70")]
	private void CBNEPHLANMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E12260", Offset = "0x5E11660", VA = "0x185E12260")]
	private void PNJPAICFOLE(EntityQuery NGALCCNNOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E11E20", Offset = "0x5E11220", VA = "0x185E11E20")]
	private void JPOJLODOKHB(NativeArray<Entity> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public FDLCMFNJNIC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal struct AEJPINJKFKA : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
	[CompilerGenerated]
	internal class CopyOwnerToEntitySystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		private struct CopyOwnerToEntitySystem_RemoveDisembodied_Job
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public CopyOwnerToEntitySystem __this;

			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0x5E0E6D0", Offset = "0x5E0DAD0", VA = "0x185E0E6D0")]
			public void OJNGABLDLND(EntityQuery query)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000116")]
		private struct CopyOwnerToEntitySystem_Clear_Job
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public CopyOwnerToEntitySystem __this;

			[Cpp2IlInjected.Token(Token = "0x60006CA")]
			[Cpp2IlInjected.Address(RVA = "0x5E0D500", Offset = "0x5E0C900", VA = "0x185E0D500")]
			public void OJNGABLDLND(EntityQuery query)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private INHGBAEAGHP objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private IGKLMANCLGL dependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private EntityQuery add;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EntityQuery remove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private EntityQuery clear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private EntityQuery CopyOwnerToEntitySystem_RemoveDisembodied_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EntityQuery CopyOwnerToEntitySystem_Clear_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private ComponentTypeHandle<PNOEDJOJCME> __RecRoom_Components_PhotonOwnerData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private ComponentTypeHandle<GBDDNKFEMOE> __RecRoom_Components_PhotonOwnerWatcherData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D9E0", Offset = "0x5E0CDE0", VA = "0x185E0D9E0", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E0E3B0", Offset = "0x5E0D7B0", VA = "0x185E0E3B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E0E550", Offset = "0x5E0D950", VA = "0x185E0E550", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E0E480", Offset = "0x5E0D880", VA = "0x185E0E480", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E0DB10", Offset = "0x5E0CF10", VA = "0x185E0DB10")]
		private void MHLLOLLKCMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D850", Offset = "0x5E0CC50", VA = "0x185E0D850")]
		private void DFAHDAMPKKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E0DA50", Offset = "0x5E0CE50", VA = "0x185E0DA50")]
		private void LANKAMMEAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D290", Offset = "0x5E0C690", VA = "0x185E0D290")]
		private void CCBIEFDNKML(Entity e, [In] GBDDNKFEMOE watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D910", Offset = "0x5E0CD10", VA = "0x185E0D910")]
		private void DJEFIBBOIBP(LHNHNFAONOD localId, int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D280", Offset = "0x5E0C680", VA = "0x185E0D280")]
		private void HKGJMIOAEPE(Entity e, [In] PNOEDJOJCME _, [In] GBDDNKFEMOE watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x5E0E620", Offset = "0x5E0DA20", VA = "0x185E0E620")]
		private void PBBGBLKBIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D280", Offset = "0x5E0C680", VA = "0x185E0D280")]
		private void HELJAMLAJHB(Entity e, [In] PNOEDJOJCME _, [In] GBDDNKFEMOE watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D7A0", Offset = "0x5E0CBA0", VA = "0x185E0D7A0")]
		private void DAFIILLIEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E0DFF0", Offset = "0x5E0D3F0", VA = "0x185E0DFF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public CopyOwnerToEntitySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D280", Offset = "0x5E0C680", VA = "0x185E0D280")]
		[CompilerGenerated]
		private void BFEPLIJACJC(Entity e, [In] PNOEDJOJCME _, [In] GBDDNKFEMOE watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D280", Offset = "0x5E0C680", VA = "0x185E0D280")]
		[CompilerGenerated]
		private void IMAJCNKFEEG(Entity e, [In] PNOEDJOJCME _, [In] GBDDNKFEMOE watcherData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class KPEJACJFODK : EJPAANLNCMB, JAKEGKENGGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct PNPIFNLIEFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public NativeParallelHashMap<Entity, int> modifiedOwners;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public ComponentDataFromEntity<PNOEDJOJCME> ownershipDataRO;
	}

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private IGKLMANCLGL JDFDEGINJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private KFJAFIJIKDB NCHDKLHCEHI;

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A480", Offset = "0x5E19880", VA = "0x185E1A480", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A580", Offset = "0x5E19980", VA = "0x185E1A580", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A660", Offset = "0x5E19A60", VA = "0x185E1A660", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E19E40", Offset = "0x5E19240", VA = "0x185E19E40")]
	private void HIANGJGJFNI(NativeArray<Entity> BAPHNAADJCK, NativeParallelHashMap<Entity, int> EMJPHIMFNOL, ComponentDataFromEntity<PNOEDJOJCME> LEMJCIHBGHN, BufferFromEntity<ChildrenData> IKOMNIIIAFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public KPEJACJFODK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A4F0", Offset = "0x5E198F0", VA = "0x185E1A4F0")]
	[CompilerGenerated]
	internal static int OGHHAHPKINB(Entity FILKDLNBIJH, PNPIFNLIEFB P_1)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
[AlwaysUpdateSystem]
public class LCNJIMKJMOE : EJPAANLNCMB, JAKEGKENGGK, CNJKPBKICBD
{
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class PLEOEECHHEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public LHNHNFAONOD localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public JHONAEGJBJL collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public bool collidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public BBFODHJCEHL containerFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public bool physicsEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public bool gravityEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public bool hasUnityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public LCNJIMKJMOE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public PLEOEECHHEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E21840", Offset = "0x5E20C40", VA = "0x185E21840")]
		internal void DHDDLNLNMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E21A60", Offset = "0x5E20E60", VA = "0x185E21A60")]
		internal void LAFPAGGNDMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E21940", Offset = "0x5E20D40", VA = "0x185E21940")]
		internal void JFCPDIPENMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	[MFFAOKEGCNH]
	private BIPCGCLALOO EKHIOJOIGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	[MFFAOKEGCNH]
	private CBGFAEGLCDH FGHLBPECDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	[MFFAOKEGCNH]
	private PMPMJLEMOAG OFFHKPEKPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000395")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public ComponentTypeHandle<BBFODHJCEHL> JBBHCNJOICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public ComponentTypeHandle<DLIOHLHECNO> DMPGEHBABLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public ComponentTypeHandle<IOIOGBEHOCO> PKJFKIMKCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public ComponentTypeHandle<EFKEOBLLPPM> NKHIEILCPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public ComponentTypeHandle<LBGJAPKKMKF> OJLMJNMBLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public DynamicComponentTypeHandle FEBDKEIKJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public EntityTypeHandle FDHBEEEKMAE;

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CD50", Offset = "0x5E1C150", VA = "0x185E1CD50", Slot = "15")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D120", Offset = "0x5E1C520", VA = "0x185E1D120", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D1D0", Offset = "0x5E1C5D0", VA = "0x185E1D1D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CB90", Offset = "0x5E1BF90", VA = "0x185E1CB90")]
	private void HJGONDJFIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CE20", Offset = "0x5E1C220", VA = "0x185E1CE20")]
	private bool IIKFAHDOAPE([Out] int HCHDEDICLEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public LCNJIMKJMOE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[AlwaysUpdateSystem]
	[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
	[CompilerGenerated]
	public class UpdateSplineGameCollidersSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200011C")]
		public struct SplineGameCollisionSystemTag : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200011D")]
		private struct ProcessCollisionModeChangesForSplineGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			[ReadOnly]
			public ComponentDataFromEntity<HAKHPKNGODK> splineComponentAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			[ReadOnly]
			public ComponentTypeHandle<DLIOHLHECNO> __collisionModeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public BufferTypeHandle<ChildrenData> __childrenTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x5E23690", Offset = "0x5E22A90", VA = "0x185E23690")]
			private void OJJILIFPAAA([In] DLIOHLHECNO collisionMode, DynamicBuffer<ChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0x5E23520", Offset = "0x5E22920", VA = "0x185E23520", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011E")]
		private struct ProcessActiveSplineReparentsForGameCollision_Job : IJobEntityBatch
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
			public ComponentDataFromEntity<DLIOHLHECNO> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0x5E23440", Offset = "0x5E22840", VA = "0x185E23440")]
			private void OJJILIFPAAA(Entity entity, [In] ParentData parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x5E23320", Offset = "0x5E22720", VA = "0x185E23320", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011F")]
		private struct ProcessInactiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			[ReadOnly]
			public ComponentDataFromEntity<DLIOHLHECNO> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x5E23B30", Offset = "0x5E22F30", VA = "0x185E23B30")]
			private void OJJILIFPAAA(Entity entity, [In] ParentData parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x5E23A10", Offset = "0x5E22E10", VA = "0x185E23A10", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000120")]
		private struct UpdateSplineGameCollidersSystem_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x5E27DA0", Offset = "0x5E271A0", VA = "0x185E27DA0")]
			private void OJJILIFPAAA(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x5E27CF0", Offset = "0x5E270F0", VA = "0x185E27CF0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct ProcessSplineEditsForGameCollision_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			[ReadOnly]
			public ComponentTypeHandle<KNEGODHIADI> splinePointParentHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			[ReadOnly]
			public EntityTypeHandle entityHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public EntityQueryInJob splinePointEditedQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public EntityQueryInJob splineStructureChangedQueryInJob;

			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0x5E23C10", Offset = "0x5E23010", VA = "0x185E23C10")]
			private void OJJILIFPAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x5E23C00", Offset = "0x5E23000", VA = "0x185E23C00", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E24160", Offset = "0x5E23560", VA = "0x185E24160")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void OMEJGDPANOK(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private OOHKDNCOFFD splineCollisionService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private EntityQuery collisionModeChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private EntityQuery activeSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private EntityQuery inactiveSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private EntityQuery splinePointEditedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private EntityQuery splineStructureChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private EntityQuery splinesDeletedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private EntityQuery ProcessCollisionModeChangesForSplineGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private EntityQuery ProcessActiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private EntityQuery ProcessInactiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private EntityQuery UpdateSplineGameCollidersSystem_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private ComponentTypeHandle<DLIOHLHECNO> __RecRoom_Components_ContainerCollisionModeData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E277B0", Offset = "0x5E26BB0", VA = "0x185E277B0", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E28800", Offset = "0x5E27C00", VA = "0x185E28800", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E289E0", Offset = "0x5E27DE0", VA = "0x185E289E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E27440", Offset = "0x5E26840", VA = "0x185E27440")]
		private void EPMKCGHGLMM(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E27800", Offset = "0x5E26C00", VA = "0x185E27800")]
		private void KFBMOFHPKHB(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x5E271A0", Offset = "0x5E265A0", VA = "0x185E271A0")]
		private void ADNKNCNBFOB(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E27350", Offset = "0x5E26750", VA = "0x185E27350")]
		private void CMKLHAOMJFG(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E27E50", Offset = "0x5E27250", VA = "0x185E27E50")]
		private void MBOALPKDPJM(EntityCommandBuffer ecb, ComponentDataFromEntity<HAKHPKNGODK> splineComponentAccess, ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E27650", Offset = "0x5E26A50", VA = "0x185E27650")]
		private void FBMGCHELCDF(EntityCommandBuffer ecb, ComponentDataFromEntity<DLIOHLHECNO> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E29180", Offset = "0x5E28580", VA = "0x185E29180")]
		private void PBFEEBBENBB(EntityCommandBuffer ecb, ComponentDataFromEntity<DLIOHLHECNO> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E27C00", Offset = "0x5E27000", VA = "0x185E27C00")]
		private void LNFDFHACNNK(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E27AC0", Offset = "0x5E26EC0", VA = "0x185E27AC0")]
		private void LDPMLHLLBNG(ComponentTypeHandle<KNEGODHIADI> splinePointParentHandle, EntityTypeHandle entityHandle, ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess, EntityQueryInJob splinePointEditedQueryInJob, EntityQueryInJob splineStructureChangedQueryInJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E28040", Offset = "0x5E27440", VA = "0x185E28040", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public UpdateSplineGameCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
[MNMKEMHOEGL]
public class DBLKHLBKDJJ : EJPAANLNCMB, CNJKPBKICBD, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[BurstCompile]
	private struct OLEIIHPHAMC : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		[ReadOnly]
		public EntityTypeHandle FEAEBGJLBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		[ReadOnly]
		public ComponentTypeHandle<JBAAHJBHFEM> BEAALAKKCGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		[WriteOnly]
		public NativeList<LLAEKIFBGBP>.ParallelWriter NKLNCPJFAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public ComponentTypeHandle<FJGDDBCFBEF> MDBFNIJDBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public float3 BGICHGONLEL;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private static readonly float4x2 LMFFHGPPCLD;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private static readonly float4x2 HMFALDHIDNG;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private static readonly int4x2 OIIDKDIMHFA;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E210E0", Offset = "0x5E204E0", VA = "0x185E210E0", Slot = "4")]
		public void Execute(ArchetypeChunk KGJGPOJOPDJ, int NNKDNGMCGJN, int BJJLLIOKKAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private static FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private EntityQuery OILIMECMJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private EntityQuery HONAOJAFDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private double ALCGBKIDJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private KFJAFIJIKDB MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private KNNEEHBELFI JMOOOMMAMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private OOMLCKJIEGP MHIDGDMAFGC;

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E109D0", Offset = "0x5E0FDD0", VA = "0x185E109D0", Slot = "14")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E109E0", Offset = "0x5E0FDE0", VA = "0x185E109E0", Slot = "15")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E10A70", Offset = "0x5E0FE70", VA = "0x185E10A70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E10BE0", Offset = "0x5E0FFE0", VA = "0x185E10BE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E10960", Offset = "0x5E0FD60", VA = "0x185E10960")]
	private bool HIPIOGBHAII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E106C0", Offset = "0x5E0FAC0", VA = "0x185E106C0")]
	private void BALBNGEAMCM(EntityQuery NGALCCNNOFF, float3 HKDFPEPEKEH, string LFAIHEECJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public DBLKHLBKDJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public struct LLAEKIFBGBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public Entity FILKDLNBIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public AKBGEPMPOEB DIPNGLKFBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public AKBGEPMPOEB GBMOELLOINK;
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public class NHHHLMLCKIK : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private KNNEEHBELFI JMOOOMMAMKM;

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x5E20E60", Offset = "0x5E20260", VA = "0x185E20E60", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x5E20EB0", Offset = "0x5E202B0", VA = "0x185E20EB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public NHHHLMLCKIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public class PPACOCFGDFM : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x5E22280", Offset = "0x5E21680", VA = "0x185E22280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x5E22340", Offset = "0x5E21740", VA = "0x185E22340", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public PPACOCFGDFM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
	public class UpdateInertialPropertiesSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct UpdateInertialPropertiesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x2000129")]
			public delegate void RunWithoutJobSystem_000008AD$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x200012A")]
			internal static class RunWithoutJobSystem_000008AD$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40003F6")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40003F7")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000717")]
				[Cpp2IlInjected.Address(RVA = "0x5E24260", Offset = "0x5E23660", VA = "0x185E24260")]
				[BurstDiscard]
				private static void NDINILJDNKF(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0x5E24560", Offset = "0x5E23960", VA = "0x185E24560")]
				private static IntPtr ODONNLFFLBE()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x5E241B0", Offset = "0x5E235B0", VA = "0x185E241B0")]
				public static void CIFALECIABA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600071A")]
				[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
				public static void FGBNJEBGKMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600071C")]
				[Cpp2IlInjected.Address(RVA = "0x5E24390", Offset = "0x5E23790", VA = "0x185E24390")]
				public static void ODMDPACOFGF(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public EntityQueryInJob isTaggedForUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public EntityQueryInJob rootRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public EntityQueryInJob deformationScaleChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public EntityQueryInJob generalRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public ChunkFilterAnyOf5ComponentsChanged changeFilter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public int maxEntityCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public NativeList<Entity> changedRoots;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			[ReadOnly]
			public EntityExistenceLookupByEntity entityExists;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			[ReadOnly]
			public EntityTypeHandle entityTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			[ReadOnly]
			public ComponentTypeHandle<LNIEJGLPFGD> rbexRootTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			[ReadOnly]
			public ComponentDataFromEntity<KDCGIBFNKBB> rbexIsKinematicRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x5E24F40", Offset = "0x5E24340", VA = "0x185E24F40")]
			private void OJJILIFPAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x5E24EE0", Offset = "0x5E242E0", VA = "0x185E24EE0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x5E25590", Offset = "0x5E24990", VA = "0x185E25590")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void OMEJGDPANOK(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x5E24EF0", Offset = "0x5E242F0", VA = "0x185E24EF0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void NKLFAGEEENB(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private EntityQuery isTaggedForUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private EntityQuery generalRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private EntityQuery rootRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private EntityQuery deformationScaleChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private EntityQuery removeMassOfHierarchyQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private BIPCGCLALOO rbexServiceCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private INHGBAEAGHP objects;

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x5E24AF0", Offset = "0x5E23EF0", VA = "0x185E24AF0", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x5E258D0", Offset = "0x5E24CD0", VA = "0x185E258D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x5E25C70", Offset = "0x5E25070", VA = "0x185E25C70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x5E25D20", Offset = "0x5E25120", VA = "0x185E25D20")]
		protected void PLCHCHHMFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x5E24E40", Offset = "0x5E24240", VA = "0x185E24E40")]
		protected void KHHNHDCJDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x5E246C0", Offset = "0x5E23AC0", VA = "0x185E246C0")]
		private bool APKGNEGICGA(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, [Out] NativeList<Entity> results)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x5E24B60", Offset = "0x5E23F60", VA = "0x185E24B60")]
		private void JKDFIONGMKC(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, ChunkFilterAnyOf5ComponentsChanged changeFilter, int maxEntityCount, NativeList<Entity> changedRoots, EntityExistenceLookupByEntity entityExists, EntityTypeHandle entityTypeRO, ComponentTypeHandle<LNIEJGLPFGD> rbexRootTypeRO, ComponentDataFromEntity<KDCGIBFNKBB> rbexIsKinematicRO, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x5E257E0", Offset = "0x5E24BE0", VA = "0x185E257E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public UpdateInertialPropertiesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x5E257A0", Offset = "0x5E24BA0", VA = "0x185E257A0")]
		public static void MNJINCCMBCF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	public class UpdateMassOfShapesSystem : EJPAANLNCMB
	{
		[Cpp2IlInjected.Token(Token = "0x200012C")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct UpdateMassOfShapesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			[ReadOnly]
			public ComponentDataFromEntity<HGJKNBGMLIB> worldDeformableScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			[ReadOnly]
			public ComponentDataFromEntity<COEKCHNJJDA> worldUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			[ReadOnly]
			public ComponentDataFromEntity<AICPABOPBAK> physicsMaterialsRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			[ReadOnly]
			public ComponentDataFromEntity<DCKEAFDNEPM> primitiveShapesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			[ReadOnly]
			public ComponentDataFromEntity<OFGGBPENFAD> localUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public ComponentDataFromEntity<IPDFFKBKNAP> massesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public ComponentDataFromEntity<FEEFALEIPKO> centerOfMassesRW;

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x5E26550", Offset = "0x5E25950", VA = "0x185E26550")]
			private void OJJILIFPAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x5E26540", Offset = "0x5E25940", VA = "0x185E26540", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private EntityQuery query;

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x5E269A0", Offset = "0x5E25DA0", VA = "0x185E269A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x5E26AE0", Offset = "0x5E25EE0", VA = "0x185E26AE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x5E26230", Offset = "0x5E25630", VA = "0x185E26230")]
		private void CPDGKHAJJEN(NativeList<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x5E26060", Offset = "0x5E25460", VA = "0x185E26060")]
		private JobHandle ADODHMPHNBE(NativeList<Entity> entities, ComponentDataFromEntity<HGJKNBGMLIB> worldDeformableScalesRO, ComponentDataFromEntity<COEKCHNJJDA> worldUniformScalesRO, ComponentDataFromEntity<AICPABOPBAK> physicsMaterialsRO, ComponentDataFromEntity<DCKEAFDNEPM> primitiveShapesRO, ComponentDataFromEntity<OFGGBPENFAD> localUniformScalesRO, ComponentDataFromEntity<IPDFFKBKNAP> massesRW, ComponentDataFromEntity<FEEFALEIPKO> centerOfMassesRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public UpdateMassOfShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public class MKGDHHDLLPP : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[BurstCompile]
	private struct EFMOGHBOBOB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		[ReadOnly]
		public int PALPMMHONBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		[ReadOnly]
		public EntityQueryInJob BBEGHHFONDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		[ReadOnly]
		public EntityQueryInJob EGACBOEELHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		[ReadOnly]
		public ChunkFilterAnyOf3ComponentsChanged OIMJFFKGPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[ReadOnly]
		public EntityTypeHandle FDHBEEEKMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		[ReadOnly]
		public ComponentDataFromEntity<AICPABOPBAK> LDNOPIJJLON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		[ReadOnly]
		public ComponentDataFromEntity<COEKCHNJJDA> NMCNOCJJFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> PICKLEDAIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		[ReadOnly]
		public ComponentTypeHandle<KNEGODHIADI> EOJLKKIJAOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		[ReadOnly]
		public ComponentDataFromEntity<PJMACGKKJMM> BJLMJPJDHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		[ReadOnly]
		public ComponentDataFromEntity<ELJOMKLCEJJ> DINPBGLNPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		[WriteOnly]
		public ComponentDataFromEntity<IPDFFKBKNAP> EGBLLHIBIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		[WriteOnly]
		public ComponentDataFromEntity<FEEFALEIPKO> LPGIKMLOMPD;

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x5E11040", Offset = "0x5E10440", VA = "0x185E11040", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x5E11200", Offset = "0x5E10600", VA = "0x185E11200")]
		private void FGIDOJEDLNN(NativeList<Entity> HKCCICONCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x5E117D0", Offset = "0x5E10BD0", VA = "0x185E117D0")]
		private void MMJKJAJDBIM(Entity ACICFHDBOLC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private EntityQuery IDLNEFLLBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private EntityQuery KBNCBHILBJP;

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EE50", Offset = "0x5E1E250", VA = "0x185E1EE50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F030", Offset = "0x5E1E430", VA = "0x185E1F030", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x2479320", Offset = "0x2478720", VA = "0x182479320")]
	private bool DDHCPHLKOFL<T>(T MFIKHHOGCNK, [Out] int OOAOLMIPAEJ) where T : struct, IChunkChangeFilter
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public MKGDHHDLLPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
[MNMKEMHOEGL]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public class MNAJNKGHCNM : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DAFLILOEIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> JFGNFEFMING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> FDNLAGNOAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private CGHDBGHDKLB KBPAEEIKAIJ;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FD50", Offset = "0x5E1F150", VA = "0x185E1FD50", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x5E20450", Offset = "0x5E1F850", VA = "0x185E20450", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FF80", Offset = "0x5E1F380", VA = "0x185E1FF80")]
	private void NGHAFAGDPGH(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> KEKPLKHNJAG, EntityQueryDesc EEGKEKFBFGI, bool IMHHODKMCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x5E200F0", Offset = "0x5E1F4F0", VA = "0x185E200F0")]
	private void NGHAFAGDPGH(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> KEKPLKHNJAG, EntityQueryDesc EEGKEKFBFGI, bool IMHHODKMCIF, bool GKMPFMKFGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x5E206C0", Offset = "0x5E1FAC0", VA = "0x185E206C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F680", Offset = "0x5E1EA80", VA = "0x185E1F680")]
	private void DKHDPIPGLAN(EntityQuery NGALCCNNOFF, bool GHJDDPDPMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x5E209C0", Offset = "0x5E1FDC0", VA = "0x185E209C0")]
	private void PEAEEMGJOBA(EntityQuery NGALCCNNOFF, bool NDIEKMGJBCF, bool GHJDDPDPMOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F8D0", Offset = "0x5E1ECD0", VA = "0x185E1F8D0")]
	private void FPDKOAJPDHO(NativeArray<Entity> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x5E20280", Offset = "0x5E1F680", VA = "0x185E20280")]
	private void OKAMHNCNOPO(NativeList<Entity> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F540", Offset = "0x5E1E940", VA = "0x185E1F540")]
	private void BHOBFFHMHKL(NativeArray<Entity> BAPHNAADJCK, bool NDIEKMGJBCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FB40", Offset = "0x5E1EF40", VA = "0x185E1FB40")]
	private NativeList<Entity> GHLBFKFOGPP(NativeArray<Entity> BAPHNAADJCK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F890", Offset = "0x5E1EC90", VA = "0x185E1F890")]
	private NativeList<Entity> EGANDNAKAPI(NativeArray<Entity> BAPHNAADJCK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x5E20410", Offset = "0x5E1F810", VA = "0x185E20410")]
	private NativeList<Entity> OONADHGEKJL(NativeArray<Entity> BAPHNAADJCK)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FDA0", Offset = "0x5E1F1A0", VA = "0x185E1FDA0")]
	private NativeList<Entity> JLADHFEAMHD(NativeArray<Entity> BAPHNAADJCK, bool NHKGEMLIMEH)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x5E20C70", Offset = "0x5E20070", VA = "0x185E20C70")]
	public MNAJNKGHCNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public class AEFDADPBIHI : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private CGHDBGHDKLB KBPAEEIKAIJ;

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B630", Offset = "0x5E0AA30", VA = "0x185E0B630", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B680", Offset = "0x5E0AA80", VA = "0x185E0B680", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public AEFDADPBIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public class PNNAPCAGPKE : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private INHGBAEAGHP NFFIAJHDGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private BIPCGCLALOO GMMEAPJLOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private EntityQuery DBECOBJKBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private EntityQuery AEIKNNEMCIF;

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x5E21B70", Offset = "0x5E20F70", VA = "0x185E21B70", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x5E21BE0", Offset = "0x5E20FE0", VA = "0x185E21BE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x5E21CF0", Offset = "0x5E210F0", VA = "0x185E21CF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public PNNAPCAGPKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public class JIBHOGNFFMD : BNNLPOAHIHI
{
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private static FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private EntityQuery ADLCFGLLJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private EntityQuery GGNEBPEEFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private EntityQuery FLFECGKFNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private EntityQuery CGANNGJFLLM;

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x5E18F10", Offset = "0x5E18310", VA = "0x185E18F10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x5E190F0", Offset = "0x5E184F0", VA = "0x185E190F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x5E19340", Offset = "0x5E18740", VA = "0x185E19340")]
	private void PLCJIJHGJMF(EntityQuery NGALCCNNOFF, bool OCDLGNNMKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x5E19170", Offset = "0x5E18570", VA = "0x185E19170")]
	private void PEDNBHBDKBI(EntityQuery NGALCCNNOFF, bool OCDLGNNMKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public JIBHOGNFFMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
[AlwaysUpdateSystem]
public class CPIMFDOGIDP : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	[MFFAOKEGCNH]
	private BGHOIHDELID FNDBOHEPMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	[MFFAOKEGCNH]
	private BIPCGCLALOO EKHIOJOIGOE;

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x5E0BBC0", Offset = "0x5E0AFC0", VA = "0x185E0BBC0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x5E0BC50", Offset = "0x5E0B050", VA = "0x185E0BC50")]
	protected void NFKIGANFGCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x5E0BCD0", Offset = "0x5E0B0D0", VA = "0x185E0BCD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public CPIMFDOGIDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal class FHBMNONHHLF : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private KFJAFIJIKDB MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private EntityQuery LLNKAAOLOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private EntityQuery DEIIDPIHFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private JKDKKFNOEFN BJPNEBJACGN;

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x5E12DC0", Offset = "0x5E121C0", VA = "0x185E12DC0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x5E12F40", Offset = "0x5E12340", VA = "0x185E12F40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x5E13060", Offset = "0x5E12460", VA = "0x185E13060", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x5E12770", Offset = "0x5E11B70", VA = "0x185E12770")]
	private void FILIJNCOBEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x5E12530", Offset = "0x5E11930", VA = "0x185E12530")]
	private void DIMJKIPAHAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x5E128C0", Offset = "0x5E11CC0", VA = "0x185E128C0")]
	private void HFPCEBEGLCH(NativeArray<Entity> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x5E12C30", Offset = "0x5E12030", VA = "0x185E12C30")]
	private void HJFANGCOABI(NativeArray<Entity> BAPHNAADJCK, int GJCDNIJBKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x5E12E30", Offset = "0x5E12230", VA = "0x185E12E30")]
	private void NBKPPABBJAJ(NativeArray<Entity> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x5E126F0", Offset = "0x5E11AF0", VA = "0x185E126F0")]
	private void FFOOJNALBHK(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void INAFKEMOABM(int LIECGMMBAAI, Transform OLPLDGDFGHL, Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000759")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public FHBMNONHHLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal static class GKCIDAMAKLK
{
	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x5E15650", Offset = "0x5E14A50", VA = "0x185E15650")]
	public static bool CJGHAJEHFLL(this SystemBase BPHADMLKFAK, [Out] Entity FILKDLNBIJH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal class NMJIIHIEJBJ : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private EntityQuery IEIJDPPOAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private AAJHNHAHHBB CHOLBOMLMNC;

	[Cpp2IlInjected.Token(Token = "0x600075C")]
	[Cpp2IlInjected.Address(RVA = "0x5E20ED0", Offset = "0x5E202D0", VA = "0x185E20ED0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x5E20F20", Offset = "0x5E20320", VA = "0x185E20F20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x5E20FE0", Offset = "0x5E203E0", VA = "0x185E20FE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public NMJIIHIEJBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal class LANAGADPHLA : CMIFDIMPDHD<OHBBDBDGALJ>, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	private LIHDLACLGHM BMHJIIAAOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private EntityQuery NIMGOHGOJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private NHPFFAEKKJH OKLBKJMNODL;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private Entity NPHGPHCJOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C7F0", Offset = "0x5E1BBF0", VA = "0x185E1C7F0")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C470", Offset = "0x5E1B870", VA = "0x185E1C470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public LHNHNFAONOD DFGKMAHJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C850", Offset = "0x5E1BC50", VA = "0x185E1C850")]
		get
		{
			return default(LHNHNFAONOD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C410", Offset = "0x5E1B810", VA = "0x185E1C410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000765")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C970", Offset = "0x5E1BD70", VA = "0x185E1C970", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000766")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C760", Offset = "0x5E1BB60", VA = "0x185E1C760", Slot = "15")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CA20", Offset = "0x5E1BE20", VA = "0x185E1CA20", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000768")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C2D0", Offset = "0x5E1B6D0", VA = "0x185E1C2D0", Slot = "14")]
	protected override void CIAMKFNEBNC(NativeArray<Entity> BAPHNAADJCK, NativeArray<Entity> JLLFJENIOJB, NativeArray<Entity> GOOEKOIFJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000769")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C1F0", Offset = "0x5E1B5F0", VA = "0x185E1C1F0")]
	private void CHDIJPGGJPN(NativeArray<Entity> BAPHNAADJCK, NativeArray<Entity> GOOEKOIFJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C4D0", Offset = "0x5E1B8D0", VA = "0x185E1C4D0")]
	private void IIDHEBNALAO(Entity FILKDLNBIJH, Entity LDBHIAEAOBN, Entity GIDGAFEJHFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0x2444710", Offset = "0x2443B10", VA = "0x182444710")]
	private bool IIDAIDKPMAP<T>([Out] T EOHMJBFGDPD) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x24447A0", Offset = "0x2443BA0", VA = "0x1824447A0")]
	private void IPGJKNHJOBN<T>(T EOHMJBFGDPD) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C8F0", Offset = "0x5E1BCF0", VA = "0x185E1C8F0")]
	public bool OGAPMGICIKL(LHNHNFAONOD KCHIHOHPLPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600076E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C8D0", Offset = "0x5E1BCD0", VA = "0x185E1C8D0")]
	private static bool ODFACCHCHNG(LHNHNFAONOD CJEEKGGCLMH, LHNHNFAONOD BAHEKGKBFKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600076F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CB50", Offset = "0x5E1BF50", VA = "0x185E1CB50")]
	public LANAGADPHLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal class KBCHFOOGFBB : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.Token(Token = "0x6000771")]
	[Cpp2IlInjected.Address(RVA = "0x5E195A0", Offset = "0x5E189A0", VA = "0x185E195A0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000772")]
	[Cpp2IlInjected.Address(RVA = "0x5E19860", Offset = "0x5E18C60", VA = "0x185E19860", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x5E19930", Offset = "0x5E18D30", VA = "0x185E19930", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0x5E19720", Offset = "0x5E18B20", VA = "0x185E19720")]
	private NativeArray<Entity> MKDGKJIJFKI(int OGEHFGGOGMJ)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x5E195F0", Offset = "0x5E189F0", VA = "0x185E195F0")]
	private void JMDDFOADIBH(NativeArray<Entity> JHNIKGEPIPN, NativeArray<Entity> HBKDOENFKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public KBCHFOOGFBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal class PNBDELJFOOJ : EJPAANLNCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private EntityQuery LIGHFPPLMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private EntityQuery JFJFLDLNOHN;

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D6C0", Offset = "0x5E3CAC0", VA = "0x185E3D6C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D7C0", Offset = "0x5E3CBC0", VA = "0x185E3D7C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public PNBDELJFOOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal static class KHEGMMMKAKK
{
	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x24387C0", Offset = "0x2437BC0", VA = "0x1824387C0")]
	public static NativeArray<T> FJMDCJELGFO<T>(NativeArray<Entity> BAPHNAADJCK, EntityManager OKJDPAMBACM) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x5E38260", Offset = "0x5E37660", VA = "0x185E38260")]
	public static void NENJDMMEEGK(EntityQuery NGALCCNNOFF, EntityManager OKJDPAMBACM, INHGBAEAGHP NMNJDGCCMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x5E37FE0", Offset = "0x5E373E0", VA = "0x185E37FE0")]
	public static void GMJNODEDMDK(NativeArray<Entity> JHNIKGEPIPN, INHGBAEAGHP NMNJDGCCMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x5E38120", Offset = "0x5E37520", VA = "0x185E38120")]
	public static void KDEDHFAJOLE(NativeArray<Entity> JHNIKGEPIPN, INHGBAEAGHP NMNJDGCCMMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal class ABEMMBILHLI : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private LDCIJBFGPJE IHBAGGIDMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private EMLJAPIGCLK ENOFBOBGGKA;

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C6E0", Offset = "0x5E2BAE0", VA = "0x185E2C6E0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C770", Offset = "0x5E2BB70", VA = "0x185E2C770", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C820", Offset = "0x5E2BC20", VA = "0x185E2C820", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B240", Offset = "0x5E2A640", VA = "0x185E2B240")]
	private void AKNMCPILBGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C130", Offset = "0x5E2B530", VA = "0x185E2C130")]
	private void FGDMEDMAKHK(NativeArray<Entity> JHNIKGEPIPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000784")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B850", Offset = "0x5E2AC50", VA = "0x185E2B850")]
	private void FEAOCMCDADK(NativeArray<Entity> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000785")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C240", Offset = "0x5E2B640", VA = "0x185E2C240")]
	private void FPELKOOBGLA(NativeArray<Entity> HBKDOENFKLF, NativeArray<RigidTransform> POPEJLJIJKM, NativeArray<RigidTransform> NPHPFPPPIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000786")]
	[Cpp2IlInjected.Address(RVA = "0x5E2ADB0", Offset = "0x5E2A1B0", VA = "0x185E2ADB0")]
	private void AALHMBDOILC(NativeArray<RigidTransform> NPHPFPPPIOE, NativeArray<Entity> HBKDOENFKLF, NativeList<Entity> PPBJHOPLMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000787")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public ABEMMBILHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal class HLHNCKJMOGC : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private EntityQuery IEIJDPPOAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private EntityQuery AOIHFHMOPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private MICHBMMIPGJ MKNFLEECOBD;

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0x5E36350", Offset = "0x5E35750", VA = "0x185E36350", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x5E363A0", Offset = "0x5E357A0", VA = "0x185E363A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x5E36500", Offset = "0x5E35900", VA = "0x185E36500", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x5E362E0", Offset = "0x5E356E0", VA = "0x185E362E0")]
	private void CELBIBDMEBP(EntityQuery NGALCCNNOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public HLHNCKJMOGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal class LHHFJFAHJJO : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private EntityQuery LFJAOGBKPPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private JCCLPJHONHK JFLBEAFGHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private AAJHNHAHHBB CHOLBOMLMNC;

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x5E39120", Offset = "0x5E38520", VA = "0x185E39120", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x5E391B0", Offset = "0x5E385B0", VA = "0x185E391B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x5E39260", Offset = "0x5E38660", VA = "0x185E39260", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public LHHFJFAHJJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal class EINADPNLDDK : CMIFDIMPDHD<JMOFHAEKBFF>
{
	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x5E31C50", Offset = "0x5E31050", VA = "0x185E31C50", Slot = "14")]
	protected override void CIAMKFNEBNC(NativeArray<Entity> BAPHNAADJCK, NativeArray<Entity> JLLFJENIOJB, NativeArray<Entity> GOOEKOIFJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x5E31DB0", Offset = "0x5E311B0", VA = "0x185E31DB0")]
	private static void CIAMKFNEBNC(NativeArray<Entity> BAPHNAADJCK, NativeArray<Entity> GOOEKOIFJKN, ComponentDataFromEntity<global::CDCJJIOLPNI> FBGBDHMHCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x5E31E80", Offset = "0x5E31280", VA = "0x185E31E80")]
	public EINADPNLDDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal abstract class CMIFDIMPDHD<TPlayerTag> : EJPAANLNCMB where TPlayerTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery HECIBKGADCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private EntityQuery LLIKLLFOPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private EntityQuery HPMDNFBGCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	private EntityQuery LMKBIBCOFEO;

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x4AE8430", Offset = "0x4AE7830", VA = "0x184AE8430", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x4AE8880", Offset = "0x4AE7C80", VA = "0x184AE8880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x4AE8850", Offset = "0x4AE7C50", VA = "0x184AE8850", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0x4AE7870", Offset = "0x4AE6C70", VA = "0x184AE7870")]
	private void FLDMJOEGPOD(EntityQuery NGALCCNNOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x4AE8180", Offset = "0x4AE7580", VA = "0x184AE8180")]
	private void KFJOBAKNJNM(EntityQuery NGALCCNNOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x4AE71F0", Offset = "0x4AE65F0", VA = "0x184AE71F0")]
	private void DBJAHNHFONM(EntityQuery NGALCCNNOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract void CIAMKFNEBNC(NativeArray<Entity> BAPHNAADJCK, NativeArray<Entity> JLLFJENIOJB, NativeArray<Entity> GOOEKOIFJKN);

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	protected CMIFDIMPDHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct JPCIPINJALD : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public int CBNNNKAIBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public int EIHKBEAJCFH;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct BNMHDMGBPKJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public static class FGFOOPKJJMP
{
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly (ComponentType userTag, ComponentType stateTag, ComponentType componentTag)[] EGOFEAJIFCM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct CGENPFKMLPI : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct GJMIOFOPFLA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public class GFIONCIJLMC : EJPAANLNCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private EntityQuery CAPBDDPDCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private ComponentTypes MLBAKJBPBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private NativeParallelHashSet<int> KBOGENJIJEB;

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E335A0", Offset = "0x5E329A0", VA = "0x185E335A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E33930", Offset = "0x5E32D30", VA = "0x185E33930", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E339B0", Offset = "0x5E32DB0", VA = "0x185E339B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E33500", Offset = "0x5E32900", VA = "0x185E33500")]
	public JobHandle KONELGIMDBC(JobHandle MCHBCAPEEON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public GFIONCIJLMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public struct GFMMGFNIFHD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private NativeArray<HAJJCCPKKFD> CMBHMPFPPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private NativeArray<int> AIKHBPPBOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private NativeParallelHashMap<int, HAJJCCPKKFD> JKINBACHLKK;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public readonly int CEGGAOJIAIO
	{
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x764F00", Offset = "0x764300", VA = "0x180764F00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public readonly int GFHKGNIOPJI
	{
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0xAE4260", Offset = "0xAE3660", VA = "0x180AE4260")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E33C60", Offset = "0x5E33060", VA = "0x185E33C60")]
	public GFMMGFNIFHD(IReadOnlyCollection<FKMDJINEHMO> MGFLEBFIMPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E33B70", Offset = "0x5E32F70", VA = "0x185E33B70")]
	public readonly BOBCKFNACMM FBPGPEFKDJK(int PIEALCBDGOA)
	{
		return default(BOBCKFNACMM);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E33AF0", Offset = "0x5E32EF0", VA = "0x185E33AF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
[DefaultMember("Item")]
public readonly struct BOBCKFNACMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private readonly int PIEALCBDGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private readonly int LOHKNLJBECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	private readonly NativeArray<HAJJCCPKKFD>.ReadOnly MFEJFLABCIK;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public int EKAAEPEENKL
	{
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D070", Offset = "0x5E2C470", VA = "0x185E2D070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public IKBKMNOGMNI LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CFA0", Offset = "0x5E2C3A0", VA = "0x185E2CFA0")]
		get
		{
			return default(IKBKMNOGMNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int GPAMLKEEGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x200C1F0", Offset = "0x200B5F0", VA = "0x18200C1F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public NativeArray<HAJJCCPKKFD>.ReadOnly EDAKJMPPLPN
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x3955080", Offset = "0x3954480", VA = "0x183955080")]
		get
		{
			return default(NativeArray<HAJJCCPKKFD>.ReadOnly);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D0A0", Offset = "0x5E2C4A0", VA = "0x185E2D0A0")]
	public BOBCKFNACMM(int PIEALCBDGOA, int LOHKNLJBECK, NativeArray<HAJJCCPKKFD>.ReadOnly MFEJFLABCIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public readonly struct GBHIKEDMEJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public NativeList<Entity> JDNMIDEPMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xA9D3F0", Offset = "0xA9C7F0", VA = "0x180A9D3F0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public NativeList<Entity> NPAABPMFLKN
	{
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0xA9D400", Offset = "0xA9C800", VA = "0x180A9D400")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public NativeList<byte> NHDNIIBNNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0xD62290", Offset = "0xD61690", VA = "0x180D62290")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public NativeList<byte> KDAMDOGIIGA
	{
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xD76A70", Offset = "0xD75E70", VA = "0x180D76A70")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NativeList<byte> FABBHCBEPHO
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x89FA30", Offset = "0x89EE30", VA = "0x18089FA30")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public ComponentType LKDDOHLALPE
	{
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x7610E0", Offset = "0x7604E0", VA = "0x1807610E0")]
		[CompilerGenerated]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public JobHandle KPAPLDAGLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x95E350", Offset = "0x95D750", VA = "0x18095E350")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int GPAMLKEEGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x95E360", Offset = "0x95D760", VA = "0x18095E360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public int NNIMPBIKPOP
	{
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x794C30", Offset = "0x794030", VA = "0x180794C30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool EDHMCLDDDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E333D0", Offset = "0x5E327D0", VA = "0x185E333D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E33450", Offset = "0x5E32850", VA = "0x185E33450")]
	public GBHIKEDMEJK(ComponentType HDDPJGDCFBD, JobHandle DELBIPHKFDD, NativeList<Entity> BAPHNAADJCK, NativeList<Entity> JHMHJOMAGDH, NativeList<byte> EIGGGBGOBPL, NativeList<byte> GIIEPIKCBIM, NativeList<byte> EMLBDBENEGP, int LOHKNLJBECK, int ICHEEHJMLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E332B0", Offset = "0x5E326B0", VA = "0x185E332B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal interface BLJODAPBPOA
{
	[Cpp2IlInjected.Token(Token = "0x17000102")]
	bool EDHMCLDDDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	NativeArray<IJFILFNCAOA> NGEMFGIJODD
	{
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	NativeArray<EIDGNLJLKDK> HHBAILGAEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	NativeArray<IJFILFNCAOA> EAPJONCFGLN
	{
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KIBJBNLFLKH([Out] NativeArray<int> NEFEOLHPHOL, Allocator KIKFOGPECEC);

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NAGJABJOMEC(ComponentType HDDPJGDCFBD, [Out] GBHIKEDMEJK DJCDNPAPJCP, [Out] BOBCKFNACMM KLLMNJMAMGG);

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeMultiHashMapAsync<Entity, HJLMBJKKHBB> CEIKNEEIFFN();
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal static class HPNPBFEOJOM
{
	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E36650", Offset = "0x5E35A50", VA = "0x185E36650")]
	public static bool HIDBJAFIILH(this BLJODAPBPOA JEPPHOGINNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
internal interface CEEBBJKKAON
{
	[Cpp2IlInjected.Token(Token = "0x17000106")]
	NativeParallelMultiHashMap<Entity, HJLMBJKKHBB> NKDPCGHFJAF
	{
		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	uint LGIAKPOCPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DMMBPHJENCD(NativeArray<IJFILFNCAOA> FKNPDKLLGNO, NativeArray<EIDGNLJLKDK> CHAFPPHFFEK, NativeArray<IJFILFNCAOA> HODIBOAAEHA, int LOFBAPCFPAJ);

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCADGGLFJNJ([In] GBHIKEDMEJK NLADDKFNDPB);

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PIBHBICBLMB(JobHandle DELBIPHKFDD);
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
public readonly struct MBIJMHMIIKK : IEquatable<MBIJMHMIIKK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly EAAMNLEDMLN PIKCMFPLBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private readonly int ICHEEHJMLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private readonly int HDLEIOACEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private readonly int OJIAHHODKNI;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public EAAMNLEDMLN FPOLJBGEJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0")]
		get
		{
			return default(EAAMNLEDMLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E39510", Offset = "0x5E38910", VA = "0x185E39510")]
	public unsafe ReadOnlySpan<byte> IELCKNLHIBD(void* FCKGHFDGCOB)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E395A0", Offset = "0x5E389A0", VA = "0x185E395A0")]
	public unsafe ReadOnlySpan<byte> NDOJEBBAADN(void* FCKGHFDGCOB)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D3")]
	[Cpp2IlInjected.Address(RVA = "0x10902F0", Offset = "0x108F6F0", VA = "0x1810902F0")]
	public MBIJMHMIIKK(EAAMNLEDMLN PIKCMFPLBNL, int DAIAAPJIJOF, int HDLEIOACEDI, int OJIAHHODKNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E39300", Offset = "0x5E38700", VA = "0x185E39300", Slot = "4")]
	public bool Equals(MBIJMHMIIKK LJIBJAOOGGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E39390", Offset = "0x5E38790", VA = "0x185E39390", Slot = "0")]
	public override bool Equals(object BAFDGKKJJJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E394A0", Offset = "0x5E388A0", VA = "0x185E394A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
public readonly struct HJLMBJKKHBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly EAAMNLEDMLN PIKCMFPLBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly int ICHEEHJMLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private unsafe readonly byte* HDLEIOACEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private unsafe readonly byte* OJIAHHODKNI;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public EAAMNLEDMLN FPOLJBGEJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x7DFAD0", Offset = "0x7DEED0", VA = "0x1807DFAD0")]
		get
		{
			return default(EAAMNLEDMLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public int LMJBHMFNAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x200C1F0", Offset = "0x200B5F0", VA = "0x18200C1F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public unsafe byte* JKJINKBGAOP
	{
		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x998C40", Offset = "0x998040", VA = "0x180998C40")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public unsafe byte* BDGDGMDJDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E361D0", Offset = "0x5E355D0", VA = "0x185E361D0")]
	public IBIHAHCALHC NDOJEBBAADN(Type IJFAMCPOKBO)
	{
		return default(IBIHAHCALHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x23A8920", Offset = "0x23A7D20", VA = "0x1823A8920")]
	public T IELCKNLHIBD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x23A8940", Offset = "0x23A7D40", VA = "0x1823A8940")]
	public T NDOJEBBAADN<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E362C0", Offset = "0x5E356C0", VA = "0x185E362C0")]
	public unsafe HJLMBJKKHBB(EAAMNLEDMLN PIKCMFPLBNL, int DAIAAPJIJOF, byte* HDLEIOACEDI, byte* OJIAHHODKNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public readonly struct IKBKMNOGMNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private readonly int PIEALCBDGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private readonly int PIKCMFPLBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private readonly HAJJCCPKKFD EFAHGHGDOIA;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public HAJJCCPKKFD CAKFIJENPHF
	{
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x998C40", Offset = "0x998040", VA = "0x180998C40")]
		get
		{
			return default(HAJJCCPKKFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E36760", Offset = "0x5E35B60", VA = "0x185E36760")]
	public IKBKMNOGMNI(int PIEALCBDGOA, int PIKCMFPLBNL, HAJJCCPKKFD EFAHGHGDOIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal abstract class HEGKKONLNKG : EJJGNIPMDNB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	private AEMGHLGPJFG ODEOFMHKBJG;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	protected abstract AMLDKDEIAEE MKDBEIMJOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E34E10", Offset = "0x5E34210", VA = "0x185E34E10", Slot = "16")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E34E60", Offset = "0x5E34260", VA = "0x185E34E60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E34F10", Offset = "0x5E34310", VA = "0x185E34F10", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	protected HEGKKONLNKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal class DGIKHNGDDGL : HEGKKONLNKG
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	protected override AMLDKDEIAEE MKDBEIMJOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "17")]
		get
		{
			return default(AMLDKDEIAEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E620", Offset = "0x5E2DA20", VA = "0x185E2E620")]
	public DGIKHNGDDGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal class GEAFLOAFIBP : HEGKKONLNKG
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	protected override AMLDKDEIAEE MKDBEIMJOPM
	{
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x7DC320", Offset = "0x7DB720", VA = "0x1807DC320", Slot = "17")]
		get
		{
			return default(AMLDKDEIAEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E334B0", Offset = "0x5E328B0", VA = "0x185E334B0")]
	public GEAFLOAFIBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
public class NCBMKBDJFFP : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	[MFFAOKEGCNH]
	private AEMGHLGPJFG EABDACHGCMH;

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AF60", Offset = "0x5E3A360", VA = "0x185E3AF60", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AFB0", Offset = "0x5E3A3B0", VA = "0x185E3AFB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public NCBMKBDJFFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[AlwaysUpdateSystem]
public class DGEHMCMABJM : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public enum JANMPGGBGJB
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
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	[MFFAOKEGCNH]
	private AEMGHLGPJFG ODEOFMHKBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private LBMFHKLNDEH KHMFODHCODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private FPKOPGHBAJM BJCFOCMLGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private JMHCDICCMMH ANFHKAOPJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private HDEOADEFBKP CNOPCPBBLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private HFFFNDACGJI IOKHKFBNPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private EFMOCGODDIF KIFLHEJLBKG;

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DC00", Offset = "0x5E2D000", VA = "0x185E2DC00", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DF90", Offset = "0x5E2D390", VA = "0x185E2DF90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E100", Offset = "0x5E2D500", VA = "0x185E2E100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DA80", Offset = "0x5E2CE80", VA = "0x185E2DA80")]
	private void IPGJGNBHGMJ([Out] NativeArray<IJFILFNCAOA> FKNPDKLLGNO, [Out] NativeArray<EIDGNLJLKDK> CHAFPPHFFEK, [Out] NativeArray<IJFILFNCAOA> HODIBOAAEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E0B0", Offset = "0x5E2D4B0", VA = "0x185E2E0B0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E010", Offset = "0x5E2D410", VA = "0x185E2E010", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public DGEHMCMABJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal readonly struct LBMFHKLNDEH
{
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private static readonly ProfilerMarker PIHIFMEJDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private readonly EJPAANLNCMB BPHADMLKFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private readonly World DMNCBDLCGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private readonly EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private readonly EntityQuery NNFAJIJLEOL;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E38F30", Offset = "0x5E38330", VA = "0x185E38F30")]
	public LBMFHKLNDEH(EJPAANLNCMB BPHADMLKFAK, World DMNCBDLCGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E389D0", Offset = "0x5E37DD0", VA = "0x185E389D0")]
	public (NativeArray<IJFILFNCAOA>, NativeArray<EIDGNLJLKDK>) GFEAHGHFDLK()
	{
		return default((NativeArray<IJFILFNCAOA>, NativeArray<EIDGNLJLKDK>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct EFMOCGODDIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private static readonly ProfilerMarker PIHIFMEJDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private readonly EJPAANLNCMB BPHADMLKFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private NativeList<(EntityQuery query, int componentIndex)> LKPPHLNAOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private NativeList<(EntityQuery query, int componentIndex)> JEFFNAHGGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private NativeList<(EntityQuery query, int componentIndex)> LGCNDGCHNFH;

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E31A50", Offset = "0x5E30E50", VA = "0x185E31A50")]
	public EFMOCGODDIF(EJPAANLNCMB BPHADMLKFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E31650", Offset = "0x5E30A50", VA = "0x185E31650", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E31280", Offset = "0x5E30680", VA = "0x185E31280")]
	public NativeList<(EntityQuery, int, int, DGEHMCMABJM.JANMPGGBGJB)> CPCDMHDBFFM(uint ILEPIACKLKF, [Out] int FBJNGKKFCAK)
	{
		return default(NativeList<(EntityQuery, int, int, DGEHMCMABJM.JANMPGGBGJB)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E317F0", Offset = "0x5E30BF0", VA = "0x185E317F0")]
	private int OLHOLAHCDMF(DGEHMCMABJM.JANMPGGBGJB DGDIMEGBJJP, NativeList<(EntityQuery query, int typeIndex)> CEPHEIEJHPL, NativeList<(EntityQuery query, int typeIndex, int count, DGEHMCMABJM.JANMPGGBGJB mode)> GOPGHHGNMKB, uint ILEPIACKLKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E316B0", Offset = "0x5E30AB0", VA = "0x185E316B0")]
	private NativeList<(EntityQuery, int)> HMGBIKLCENO(NativeParallelHashSet<int> MGFLEBFIMPH, int KJFLAKJAJON)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E31750", Offset = "0x5E30B50", VA = "0x185E31750")]
	private NativeList<(EntityQuery, int)> MCJCHEGJOEE(NativeParallelHashSet<int> MGFLEBFIMPH, int KJFLAKJAJON)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E30BE0", Offset = "0x5E2FFE0", VA = "0x185E30BE0")]
	private NativeList<(EntityQuery, int)> CLAIMKPOOAB(NativeParallelHashSet<int> MGFLEBFIMPH, int KJFLAKJAJON, DGEHMCMABJM.JANMPGGBGJB DGDIMEGBJJP)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E30F90", Offset = "0x5E30390", VA = "0x185E30F90")]
	private NativeList<(EntityQuery, int)> CLGDJMBHOKM()
	{
		return default(NativeList<(EntityQuery, int)>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal readonly struct HFFFNDACGJI
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[BurstCompile]
	private struct KBGEIDILEAC : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		[ReadOnly]
		public EntityTypeHandle ILJFOLLMFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		[ReadOnly]
		public ComponentDataFromEntity<JPCIPINJALD> LCMADKOLMCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		[ReadOnly]
		public DynamicComponentTypeHandle LBEBFCILPGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> DNDGLHLCCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> JAKGHLNINCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		[ReadOnly]
		public ComponentDataFromEntity KACGGEEJNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		[ReadOnly]
		public NativeArray<byte>.ReadOnly OENLLHONNPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		[ReadOnly]
		public NativeArray<HAJJCCPKKFD>.ReadOnly LAOKCNBPILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public ComponentDataFromEntity EKLLIJHCLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public NativeList<Entity> DELDHPKEDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public NativeList<Entity> GFCCJBOPIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public NativeList<byte> IFIAMGDINHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public NativeList<byte> OPILLEGGLJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public NativeList<byte> KOOAEHDAKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int ICHEEHJMLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int LOHKNLJBECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public bool GOKMEHOKACN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public DGEHMCMABJM.JANMPGGBGJB DGDIMEGBJJP;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x5E37550", Offset = "0x5E36950", VA = "0x185E37550", Slot = "4")]
		public void Execute(ArchetypeChunk KGJGPOJOPDJ, int NNKDNGMCGJN, int BJJLLIOKKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x5E37330", Offset = "0x5E36730", VA = "0x185E37330")]
		private unsafe bool EELKNGFEIJC(Entity LMIDDGOJJDD, Entity EOJFNDFFIEG, byte* OKKJDGENLDJ, byte* FLIKDBOOLLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x5E37900", Offset = "0x5E36D00", VA = "0x185E37900")]
		private unsafe void GFOOEPCPPKC(byte* OKKJDGENLDJ, byte* FLIKDBOOLLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x5E37AB0", Offset = "0x5E36EB0", VA = "0x185E37AB0")]
		private unsafe byte* OJGIGDNPEOC(NativeArray<byte> PCLCEFFNDIC, int KEFLNPGBJEJ)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x5E37A40", Offset = "0x5E36E40", VA = "0x185E37A40")]
		private unsafe byte* HBDEACFKAPG(Entity EOJFNDFFIEG)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x5E37920", Offset = "0x5E36D20", VA = "0x185E37920")]
		private unsafe byte* GNEGMEMPGKF(ArchetypeChunk KGJGPOJOPDJ)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x5E37A10", Offset = "0x5E36E10", VA = "0x185E37A10")]
		private static Entity HANCCHONJLA([In] JPCIPINJALD GHFAAPNAFDE)
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[BurstCompile]
	private struct CPEMGKJLFAD : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		[ReadOnly]
		public NativeList<Entity> DMDOKPMMIIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		[ReadOnly]
		public NativeList<byte> PMFLCMLBKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		[ReadOnly]
		public NativeList<byte> DJKJBFLGGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		[ReadOnly]
		public NativeList<byte> EFNAOIJICIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		[ReadOnly]
		public NativeArray<HAJJCCPKKFD>.ReadOnly LAOKCNBPILC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public NativeParallelMultiHashMap<Entity, HJLMBJKKHBB> CBJEGIBDFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int ICHEEHJMLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public int LOHKNLJBECK;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D700", Offset = "0x5E2CB00", VA = "0x185E2D700", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly ProfilerMarker PIHIFMEJDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly EJPAANLNCMB BPHADMLKFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private readonly World DMNCBDLCGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private readonly GFMMGFNIFHD LOIKKDKOLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private readonly NativeParallelHashMap<int, Entity> EELFLDCAMNB;

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x5E36150", Offset = "0x5E35550", VA = "0x185E36150")]
	public HFFFNDACGJI(EJPAANLNCMB BPHADMLKFAK, World DMNCBDLCGMN, AEMGHLGPJFG ODEOFMHKBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x5E353A0", Offset = "0x5E347A0", VA = "0x185E353A0")]
	public JobHandle GFEAHGHFDLK(CEEBBJKKAON JEPPHOGINNJ, NativeList<(EntityQuery query, int typeIndex, int count, DGEHMCMABJM.JANMPGGBGJB mode)> CKJDONFMJCN, JobHandle MCHBCAPEEON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x5E35340", Offset = "0x5E34740", VA = "0x185E35340")]
	private CPEMGKJLFAD BDPCCNCPHLP([In] KBGEIDILEAC EBPPBOGCNCD, NativeParallelMultiHashMap<Entity, HJLMBJKKHBB> HEAONJJIIOH)
	{
		return default(CPEMGKJLFAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x5E35CE0", Offset = "0x5E350E0", VA = "0x185E35CE0")]
	private KBGEIDILEAC NFLJAAKLDLN(ComponentType HDDPJGDCFBD, EntityManager PCAFPOIFKOH, int AHKKEJLBCIE, DGEHMCMABJM.JANMPGGBGJB DGDIMEGBJJP)
	{
		return default(KBGEIDILEAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x5E35B80", Offset = "0x5E34F80", VA = "0x185E35B80")]
	private static void JMEDKIPNADD(CEEBBJKKAON JEPPHOGINNJ, ComponentType HDDPJGDCFBD, JobHandle IJAGDFPAFEE, [In] KBGEIDILEAC EBPPBOGCNCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal readonly struct HDEOADEFBKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private readonly GFIONCIJLMC JOAPLONMJNF;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private static readonly ProfilerMarker PIHIFMEJDOB;

	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0x5E34B90", Offset = "0x5E33F90", VA = "0x185E34B90")]
	public HDEOADEFBKP(World DMNCBDLCGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0x5E34960", Offset = "0x5E33D60", VA = "0x185E34960")]
	public JobHandle GFEAHGHFDLK(JobHandle LJHMNFJKGEP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal readonly struct FPKOPGHBAJM
{
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private static readonly ProfilerMarker PIHIFMEJDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private readonly EJPAANLNCMB BPHADMLKFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private readonly World DMNCBDLCGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private readonly EntityQuery CFACGOOGNPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private readonly EntityQuery NOGAGBHGDBH;

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x5E33180", Offset = "0x5E32580", VA = "0x185E33180")]
	public FPKOPGHBAJM(EJPAANLNCMB BPHADMLKFAK, World DMNCBDLCGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0x5E32B70", Offset = "0x5E31F70", VA = "0x185E32B70")]
	public NativeArray<IJFILFNCAOA> GFEAHGHFDLK()
	{
		return default(NativeArray<IJFILFNCAOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x5E32CF0", Offset = "0x5E320F0", VA = "0x185E32CF0")]
	public void NPGIPCHAPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x5E32D90", Offset = "0x5E32190", VA = "0x185E32D90")]
	private NativeArray<IJFILFNCAOA> PKJOKDNDIPB(EntityQuery NGALCCNNOFF)
	{
		return default(NativeArray<IJFILFNCAOA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal readonly struct JMHCDICCMMH
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class GPIFNDLJKKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public EJPAANLNCMB system;

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public GPIFNDLJKKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x5E34870", Offset = "0x5E33C70", VA = "0x185E34870")]
		internal (EntityQuery, ComponentType) OBMKNBAFMJE((ComponentType userTag, ComponentType stateTag, ComponentType componentTag) t)
		{
			return default((EntityQuery, ComponentType));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private static readonly ProfilerMarker PIHIFMEJDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private readonly EJPAANLNCMB BPHADMLKFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private readonly (EntityQuery userTagQuery, ComponentType stateTag)[] HEHFIHMCMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private readonly EntityQuery JDLMCMOPNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private readonly EntityQuery FEKJCGNJPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private readonly ComponentTypes NNDNIEIDLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private readonly ComponentTypes MFOFDKCDMBA;

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x5E36E30", Offset = "0x5E36230", VA = "0x185E36E30")]
	public JMHCDICCMMH(EJPAANLNCMB BPHADMLKFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(RVA = "0x5E36AB0", Offset = "0x5E35EB0", VA = "0x185E36AB0")]
	public void GFEAHGHFDLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal class MODMKEDHHBK : DAPCNLHMJOC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	public struct PKILIFBAMOL : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	protected override ComponentType ICGAGJNNNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x5E39630", Offset = "0x5E38A30", VA = "0x185E39630", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	protected override ComponentType FMGPPLPBAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x5E39660", Offset = "0x5E38A60", VA = "0x185E39660", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	protected override ComponentType JKIGKNNBLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x5E39690", Offset = "0x5E38A90", VA = "0x185E39690", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x5E39750", Offset = "0x5E38B50", VA = "0x185E39750")]
	public MODMKEDHHBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal class APNKFMMGACL : DAPCNLHMJOC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	public struct NJEMIGMLDIC : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	protected override ComponentType ICGAGJNNNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CE20", Offset = "0x5E2C220", VA = "0x185E2CE20", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	protected override ComponentType FMGPPLPBAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CE50", Offset = "0x5E2C250", VA = "0x185E2CE50", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	protected override ComponentType JKIGKNNBLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CE80", Offset = "0x5E2C280", VA = "0x185E2CE80", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CF40", Offset = "0x5E2C340", VA = "0x185E2CF40")]
	public APNKFMMGACL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000165")]
public struct DIDNDCCOFEI : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
[MNMKEMHOEGL]
public class GMLMFOCIEPI : BNNLPOAHIHI
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	private struct EOEBMBHMJBA : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		[ReadOnly]
		public NativeParallelHashSet<int> JHOKJHALAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		[ReadOnly]
		public EntityTypeHandle FDHBEEEKMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> LAFKKPOMGDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public NativeList<Entity>.ParallelWriter BNAGBLLMCMD;

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x5E32090", Offset = "0x5E31490", VA = "0x185E32090", Slot = "4")]
		public void Execute(ArchetypeChunk KGJGPOJOPDJ, int NNKDNGMCGJN, int BJJLLIOKKAK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x5E34300", Offset = "0x5E33700", VA = "0x185E34300", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x5E34390", Offset = "0x5E33790", VA = "0x185E34390", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x5E342B0", Offset = "0x5E336B0", VA = "0x185E342B0")]
	private EntityCommandBufferSystem MFALHIFKBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public GMLMFOCIEPI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[MNMKEMHOEGL]
	[CompilerGenerated]
	public class DebugPostDeserializeRemoveOrphanedSplinePointsSystem : BNNLPOAHIHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000169")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct DebugPostDeserializeRemoveOrphanedSplinePointsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004C9")]
			[ReadOnly]
			public ComponentDataFromEntity<HAKHPKNGODK> splineDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004CA")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public ComponentTypeHandle<KNEGODHIADI> __pointTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0x5E2F8D0", Offset = "0x5E2ECD0", VA = "0x185E2F8D0")]
			private void OJJILIFPAAA(Entity entity, [In][NoAlias] KNEGODHIADI point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000837")]
			[Cpp2IlInjected.Address(RVA = "0x5E2F7B0", Offset = "0x5E2EBB0", VA = "0x185E2F7B0", Slot = "4")]
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
		private ComponentTypeHandle<KNEGODHIADI> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FC20", Offset = "0x5E2F020", VA = "0x185E2FC20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F9B0", Offset = "0x5E2EDB0", VA = "0x185E2F9B0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void MNECBAFJLAB(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F960", Offset = "0x5E2ED60", VA = "0x185E2F960")]
		private EntityCommandBufferSystem MFALHIFKBBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F670", Offset = "0x5E2EA70", VA = "0x185E2F670")]
		private JobHandle KINKOPMMBCI(EntityCommandBuffer ecb, ComponentDataFromEntity<HAKHPKNGODK> splineDataRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FA40", Offset = "0x5E2EE40", VA = "0x185E2FA40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public DebugPostDeserializeRemoveOrphanedSplinePointsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
[MNMKEMHOEGL]
public class FBEHCPBJEIA : BNNLPOAHIHI
{
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0x5E321C0", Offset = "0x5E315C0", VA = "0x185E321C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000839")]
	[Cpp2IlInjected.Address(RVA = "0x5E32260", Offset = "0x5E31660", VA = "0x185E32260", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x5E32170", Offset = "0x5E31570", VA = "0x185E32170")]
	private EntityCommandBufferSystem MFALHIFKBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public FBEHCPBJEIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
[MNMKEMHOEGL]
public class KGLBLCGHKPI : BNNLPOAHIHI
{
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x5E37CC0", Offset = "0x5E370C0", VA = "0x185E37CC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x5E37D80", Offset = "0x5E37180", VA = "0x185E37D80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x5E37C70", Offset = "0x5E37070", VA = "0x185E37C70")]
	private EntityCommandBufferSystem MFALHIFKBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public KGLBLCGHKPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[UpdateAfter(typeof(GMLMFOCIEPI))]
public class JENLJLJKEFP : EJPAANLNCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private EntityArchetype LPMJLFKPCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x5E36810", Offset = "0x5E35C10", VA = "0x185E36810", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x5E36930", Offset = "0x5E35D30", VA = "0x185E36930", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x5E367C0", Offset = "0x5E35BC0", VA = "0x185E367C0")]
	private EntityCommandBufferSystem MFALHIFKBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public JENLJLJKEFP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	internal class PostDeserializeAddSplinePointsToSplinesSystem : EJPAANLNCMB
	{
		[Cpp2IlInjected.Token(Token = "0x200016E")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeAddSplinePointsToSplinesSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D7")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600084D")]
			[Cpp2IlInjected.Address(RVA = "0x5E3DA30", Offset = "0x5E3CE30", VA = "0x185E3DA30")]
			private void OJJILIFPAAA(Entity spline)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084E")]
			[Cpp2IlInjected.Address(RVA = "0x5E3D980", Offset = "0x5E3CD80", VA = "0x185E3D980", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016F")]
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
			public ComponentTypeHandle<KNEGODHIADI> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0x5E3DC00", Offset = "0x5E3D000", VA = "0x185E3DC00")]
			private void OJJILIFPAAA(Entity splinePoint, [In][NoAlias] KNEGODHIADI splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0x5E3DAE0", Offset = "0x5E3CEE0", VA = "0x185E3DAE0", Slot = "4")]
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
		private ComponentTypeHandle<KNEGODHIADI> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E010", Offset = "0x5E3D410", VA = "0x185E3E010", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E0D0", Offset = "0x5E3D4D0", VA = "0x185E3E0D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DCB0", Offset = "0x5E3D0B0", VA = "0x185E3DCB0")]
		private EntityCommandBufferSystem MFALHIFKBBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D880", Offset = "0x5E3CC80", VA = "0x185E3D880")]
		private void ECEMEPCEPJB(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E3F0", Offset = "0x5E3D7F0", VA = "0x185E3E3F0")]
		private void PNAEBIFHBFB(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DD00", Offset = "0x5E3D100", VA = "0x185E3DD00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PostDeserializeAddSplinePointsToSplinesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
public class AIKHNADFBBO : EJPAANLNCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C8C0", Offset = "0x5E2BCC0", VA = "0x185E2C8C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C990", Offset = "0x5E2BD90", VA = "0x185E2C990", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public AIKHNADFBBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal sealed class LDMFMLCCLEP : ParentSystemBase<ParentData, PreviousParentData, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D60", Offset = "0x7E3160", VA = "0x1807E3D60", Slot = "14")]
	protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc NGALCCNNOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D60", Offset = "0x7E3160", VA = "0x1807E3D60", Slot = "15")]
	protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc NGALCCNNOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x7E3D60", Offset = "0x7E3160", VA = "0x1807E3D60", Slot = "16")]
	protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc NGALCCNNOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x5E39060", Offset = "0x5E38460", VA = "0x185E39060", Slot = "17")]
	protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc NGALCCNNOFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x5E390A0", Offset = "0x5E384A0", VA = "0x185E390A0")]
	public LDMFMLCCLEP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[MNMKEMHOEGL]
	[CompilerGenerated]
	public class PostDeserializeRemoveComponentSerializedVersionDataSystem : EJPAANLNCMB
	{
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E730", Offset = "0x5E3DB30", VA = "0x185E3E730", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E7D0", Offset = "0x5E3DBD0", VA = "0x185E3E7D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E540", Offset = "0x5E3D940", VA = "0x185E3E540")]
		private EntityCommandBufferSystem MFALHIFKBBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E590", Offset = "0x5E3D990", VA = "0x185E3E590", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PostDeserializeRemoveComponentSerializedVersionDataSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
public class JDIHCCJEIFK : LDIOFIMAPDN
{
	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x5E36770", Offset = "0x5E35B70", VA = "0x185E36770", Slot = "14")]
	protected override EntityCommandBufferSystem MFALHIFKBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0x5E32980", Offset = "0x5E31D80", VA = "0x185E32980")]
	public JDIHCCJEIFK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	internal class PostDeserializeSortSplinePointsSystem : EJPAANLNCMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public ComponentDataFromEntity<BOPAAHHJEPL> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B890", Offset = "0x5E3AC90", VA = "0x185E3B890", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
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

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x5E3ECB0", Offset = "0x5E3E0B0", VA = "0x185E3ECB0")]
			private void OJJILIFPAAA(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0x5E3EB80", Offset = "0x5E3DF80", VA = "0x185E3EB80", Slot = "4")]
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

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F040", Offset = "0x5E3E440", VA = "0x185E3F040", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x5E3EA50", Offset = "0x5E3DE50", VA = "0x185E3EA50")]
		private void KEFMMDDPEJE(OrderComparer comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x5E3ED40", Offset = "0x5E3E140", VA = "0x185E3ED40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PostDeserializeSortSplinePointsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	public class PostDeserializeTransformRootsSystem : EJPAANLNCMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000178")]
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
			public ComponentTypeHandle<FBGNNPLAHMM> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000871")]
			[Cpp2IlInjected.Address(RVA = "0x5E29560", Offset = "0x5E28960", VA = "0x185E29560")]
			private void OJJILIFPAAA([NoAlias] FBGNNPLAHMM data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000872")]
			[Cpp2IlInjected.Address(RVA = "0x5E3FB00", Offset = "0x5E3EF00", VA = "0x185E3FB00", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000179")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeTransformRootsSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public ComponentTypeHandle<OFGGBPENFAD> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0x5E29790", Offset = "0x5E28B90", VA = "0x185E29790")]
			private void OJJILIFPAAA([NoAlias] OFGGBPENFAD data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000874")]
			[Cpp2IlInjected.Address(RVA = "0x5E3FBD0", Offset = "0x5E3EFD0", VA = "0x185E3FBD0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200017A")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeTransformRootsSystem_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public ComponentTypeHandle<CBFFFGCNAML> __authoredPoseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			[ReadOnly]
			public ComponentTypeHandle<FBGNNPLAHMM> __poseTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0x5E297A0", Offset = "0x5E28BA0", VA = "0x185E297A0")]
			private void OJJILIFPAAA([NoAlias] CBFFFGCNAML authoredPose, [In][NoAlias] FBGNNPLAHMM pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x5E3FCA0", Offset = "0x5E3F0A0", VA = "0x185E3FCA0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200017B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeTransformRootsSystem_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public ComponentTypeHandle<FAICCAODHCD> __authoredScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			[ReadOnly]
			public ComponentTypeHandle<OFGGBPENFAD> __scaleTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0x5E297C0", Offset = "0x5E28BC0", VA = "0x185E297C0")]
			private void OJJILIFPAAA([NoAlias] FAICCAODHCD authoredScale, [In][NoAlias] OFGGBPENFAD scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x5E3FDF0", Offset = "0x5E3F1F0", VA = "0x185E3FDF0", Slot = "4")]
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
		private ComponentTypeHandle<FBGNNPLAHMM> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private ComponentTypeHandle<OFGGBPENFAD> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private ComponentTypeHandle<CBFFFGCNAML> __RecRoom_Components_AuthoredLocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private ComponentTypeHandle<FBGNNPLAHMM> __RecRoom_Components_LocalPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private ComponentTypeHandle<FAICCAODHCD> __RecRoom_Components_AuthoredLocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private ComponentTypeHandle<OFGGBPENFAD> __RecRoom_Components_LocalUniformScaleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x5E407D0", Offset = "0x5E3FBD0", VA = "0x185E407D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F530", Offset = "0x5E3E930", VA = "0x185E3F530")]
		private void GBFDMBLPILI([In] EKDOHGHOOFO transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F2F0", Offset = "0x5E3E6F0", VA = "0x185E3F2F0")]
		private void GALGEEFDNPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F9D0", Offset = "0x5E3EDD0", VA = "0x185E3F9D0")]
		private JobHandle KFIPMAFGKKK(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F1F0", Offset = "0x5E3E5F0", VA = "0x185E3F1F0")]
		private JobHandle BMJHDGPIHCF(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F750", Offset = "0x5E3EB50", VA = "0x185E3F750")]
		private JobHandle HBCFPIIIEKN(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F890", Offset = "0x5E3EC90", VA = "0x185E3F890")]
		private JobHandle JCHFNEBHOHP(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FF40", Offset = "0x5E3F340", VA = "0x185E3FF40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PostDeserializeTransformRootsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public static class EECLMCAJMPP
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	public interface COBEHCOGCEC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	public interface EKICOEAMHKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	public class CFPBFECLBCI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public class LEPDKIFFFNE : EKICOEAMHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x5E390E0", Offset = "0x5E384E0", VA = "0x185E390E0")]
		public LEPDKIFFFNE(ComponentType OAGNBNMPALP, ComponentType JDNOLBBAOIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	public class KPFEDACNGCM : EKICOEAMHKO
	{
		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x3CFA700", Offset = "0x3CF9B00", VA = "0x183CFA700")]
		public KPFEDACNGCM(ComponentType OAGNBNMPALP, ComponentType[] JDNOLBBAOIO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	public class HOIFLNGGJFH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087B")]
	[Cpp2IlInjected.Address(RVA = "0x22529D0", Offset = "0x2251DD0", VA = "0x1822529D0")]
	public static EKICOEAMHKO IMGNBILILIM<TFrom, TTo>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600087C")]
	[Cpp2IlInjected.Address(RVA = "0x2252940", Offset = "0x2251D40", VA = "0x182252940")]
	public static EKICOEAMHKO IDCPFOMPBED<TFrom>(params ComponentType[] MMKIEIGFJGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public class IIGGAICOMKM : ICCFEBIBGCG
{
	[Cpp2IlInjected.Token(Token = "0x600087F")]
	[Cpp2IlInjected.Address(RVA = "0x76D100", Offset = "0x76C500", VA = "0x18076D100")]
	public IIGGAICOMKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class CAFPEENDBBF : BNNLPOAHIHI
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x6000880")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D100", Offset = "0x5E2C500", VA = "0x185E2D100", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000881")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D0B0", Offset = "0x5E2C4B0", VA = "0x185E2D0B0")]
	private EntityCommandBufferSystem MFALHIFKBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000882")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public CAFPEENDBBF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	[IIGGAICOMKM]
	public class PostDeserializeUpgrade_Convert_ObjectPolicyData : EJMGHCBLIND
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_ObjectPolicyData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			public HEKKPGLJEEJ<KLBFFBBOKEF> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			public HEKKPGLJEEJ<ANDJGNGIEHJ> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			public HEKKPGLJEEJ<HJPDGJAGHLL> v2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000505")]
			public HEKKPGLJEEJ<DBOENDEMDLM> v3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000506")]
			public EPGMMLCEIPK<LGKPPDFBNFO> v4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000507")]
			public HJPDGJAGHLL v2Default;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x5E41F40", Offset = "0x5E41340", VA = "0x185E41F40")]
			private void OJJILIFPAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0x5E41F30", Offset = "0x5E41330", VA = "0x185E41F30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		protected override FBKCBHAMJJJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0x5E42600", Offset = "0x5E41A00", VA = "0x185E42600", Slot = "14")]
			get
			{
				return default(FBKCBHAMJJJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x5E419D0", Offset = "0x5E40DD0", VA = "0x185E419D0", Slot = "15")]
		public override IEnumerable<EECLMCAJMPP.EKICOEAMHKO> IBKHJDHCCNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x5E41BB0", Offset = "0x5E40FB0", VA = "0x185E41BB0", Slot = "16")]
		protected override void JAMMAFLOMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x5E41830", Offset = "0x5E40C30", VA = "0x185E41830")]
		private static void HGJHNJNCMLC(EFKKFPPCMHF<ANDJGNGIEHJ> srcVersion, EFKKFPPCMHF<HJPDGJAGHLL> dstVersion, HJPDGJAGHLL dstDefault)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x5E414F0", Offset = "0x5E408F0", VA = "0x185E414F0")]
		private static void CPGFHOENCHL(EFKKFPPCMHF<HJPDGJAGHLL> srcVersion, EFKKFPPCMHF<DBOENDEMDLM> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x5E42650", Offset = "0x5E41A50", VA = "0x185E42650")]
		private static void ONJKGDKKFGF(EFKKFPPCMHF<DBOENDEMDLM> srcVersion, EFKKFPPCMHF<LGKPPDFBNFO> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x5E41610", Offset = "0x5E40A10", VA = "0x185E41610")]
		private JobHandle EHPMOFEACOL(HEKKPGLJEEJ<KLBFFBBOKEF> v0, HEKKPGLJEEJ<ANDJGNGIEHJ> v1, HEKKPGLJEEJ<HJPDGJAGHLL> v2, HEKKPGLJEEJ<DBOENDEMDLM> v3, EPGMMLCEIPK<LGKPPDFBNFO> v4, HJPDGJAGHLL v2Default, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PostDeserializeUpgrade_Convert_ObjectPolicyData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	[IIGGAICOMKM]
	public class PostDeserializeUpgrade_Convert_OMShapeContainerData : EJMGHCBLIND
	{
		[Cpp2IlInjected.Token(Token = "0x200018A")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_OMShapeContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000509")]
			public HEKKPGLJEEJ<ABLLDDHOOFD> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public EPGMMLCEIPK<EFKEOBLLPPM> v2;

			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0x5E41100", Offset = "0x5E40500", VA = "0x185E41100")]
			private void OJJILIFPAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x5E410F0", Offset = "0x5E404F0", VA = "0x185E410F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		protected override FBKCBHAMJJJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0x5E41410", Offset = "0x5E40810", VA = "0x185E41410", Slot = "14")]
			get
			{
				return default(FBKCBHAMJJJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x5E40EC0", Offset = "0x5E402C0", VA = "0x185E40EC0", Slot = "15")]
		public override IEnumerable<EECLMCAJMPP.EKICOEAMHKO> IBKHJDHCCNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x5E40F80", Offset = "0x5E40380", VA = "0x185E40F80", Slot = "16")]
		protected override void JAMMAFLOMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x5E40DF0", Offset = "0x5E401F0", VA = "0x185E40DF0")]
		private static void HGJHNJNCMLC(EFKKFPPCMHF<ABLLDDHOOFD> srcVersion, EFKKFPPCMHF<EFKEOBLLPPM> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x5E40CC0", Offset = "0x5E400C0", VA = "0x185E40CC0")]
		private JobHandle BOGLNCDAJEA(HEKKPGLJEEJ<ABLLDDHOOFD> v1, EPGMMLCEIPK<EFKEOBLLPPM> v2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PostDeserializeUpgrade_Convert_OMShapeContainerData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[IIGGAICOMKM]
	[MNMKEMHOEGL]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data : EJMGHCBLIND, EECLMCAJMPP.COBEHCOGCEC
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		private struct PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public HEKKPGLJEEJ<BLKLCJEOPIL> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public HEKKPGLJEEJ<IIAJEDFLLEH> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x5E42E50", Offset = "0x5E42250", VA = "0x185E42E50")]
			private void OJJILIFPAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0x5E42E40", Offset = "0x5E42240", VA = "0x185E42E40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		protected override FBKCBHAMJJJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x5E43270", Offset = "0x5E42670", VA = "0x185E43270", Slot = "14")]
			get
			{
				return default(FBKCBHAMJJJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x5E429A0", Offset = "0x5E41DA0", VA = "0x185E429A0", Slot = "15")]
		public override IEnumerable<EECLMCAJMPP.EKICOEAMHKO> IBKHJDHCCNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x5E42AC0", Offset = "0x5E41EC0", VA = "0x185E42AC0", Slot = "16")]
		protected override void JAMMAFLOMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E42810", Offset = "0x5E41C10", VA = "0x185E42810")]
		private static void DKMOPPODPKJ(LNINLLOMBEF<IIAJEDFLLEH> d1, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E42CF0", Offset = "0x5E420F0", VA = "0x185E42CF0")]
		private JobHandle KGMGJBLPGDI(HEKKPGLJEEJ<BLKLCJEOPIL> v0, HEKKPGLJEEJ<IIAJEDFLLEH> v1, EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	[IIGGAICOMKM]
	public class PostDeserializeUpgrade_Convert_SerializeEmbodiedData : EJMGHCBLIND
	{
		[Cpp2IlInjected.Token(Token = "0x200018E")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_SerializeEmbodiedData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public HEKKPGLJEEJ<KODBLLFOPAK> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public EPGMMLCEIPK<ODLBCNBKLEO> v1;

			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0x5E436C0", Offset = "0x5E42AC0", VA = "0x185E436C0")]
			private void OJJILIFPAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0x5E436B0", Offset = "0x5E42AB0", VA = "0x185E436B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		protected override FBKCBHAMJJJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x60008A7")]
			[Cpp2IlInjected.Address(RVA = "0x5E43910", Offset = "0x5E42D10", VA = "0x185E43910", Slot = "14")]
			get
			{
				return default(FBKCBHAMJJJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E43480", Offset = "0x5E42880", VA = "0x185E43480", Slot = "15")]
		public override IEnumerable<EECLMCAJMPP.EKICOEAMHKO> IBKHJDHCCNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E43540", Offset = "0x5E42940", VA = "0x185E43540", Slot = "16")]
		protected override void JAMMAFLOMPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E43350", Offset = "0x5E42750", VA = "0x185E43350")]
		private JobHandle BLPDDHMBBDP(HEKKPGLJEEJ<KODBLLFOPAK> v0, EPGMMLCEIPK<ODLBCNBKLEO> v1, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PostDeserializeUpgrade_Convert_SerializeEmbodiedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[IIGGAICOMKM]
public class KJEEGDGBHEG : EJPAANLNCMB, EECLMCAJMPP.COBEHCOGCEC
{
	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public IEnumerable<Type> OKJMFECCFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E383F0", Offset = "0x5E377F0", VA = "0x185E383F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E386B0", Offset = "0x5E37AB0", VA = "0x185E386B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E38660", Offset = "0x5E37A60", VA = "0x185E38660")]
	private EntityCommandBufferSystem MFALHIFKBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008B3")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public KJEEGDGBHEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class NHMEENNKOHN : ONOIOIMCLMO
{
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	protected override IIOKGAAOGMJ FKDINLDHBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "15")]
		get
		{
			return default(IIOKGAAOGMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AFD0", Offset = "0x5E3A3D0", VA = "0x185E3AFD0", Slot = "16")]
	protected override void HBLIMFFAECA(IIOKGAAOGMJ FOIKACEEEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B240", Offset = "0x5E3A640", VA = "0x185E3B240")]
	private EntityCommandBufferSystem MFALHIFKBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B320", Offset = "0x5E3A720", VA = "0x185E3B320")]
	public NHMEENNKOHN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[IIGGAICOMKM]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Split_ContainerData : EJPAANLNCMB, EECLMCAJMPP.COBEHCOGCEC
	{
		[Cpp2IlInjected.Token(Token = "0x2000192")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
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
			public NativeArray<PNCLLHBKFPF> v1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public ComponentTypes newComponents;

			[Cpp2IlInjected.Token(Token = "0x60008C0")]
			[Cpp2IlInjected.Address(RVA = "0x5E43AC0", Offset = "0x5E42EC0", VA = "0x185E43AC0")]
			private void OJJILIFPAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008C1")]
			[Cpp2IlInjected.Address(RVA = "0x5E43AB0", Offset = "0x5E42EB0", VA = "0x185E43AB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private ComponentType[] newComponentTypes;

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E439F0", Offset = "0x5E42DF0", VA = "0x185E439F0", Slot = "14")]
		public IEnumerable<EECLMCAJMPP.EKICOEAMHKO> IBKHJDHCCNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E43F30", Offset = "0x5E43330", VA = "0x185E43F30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E43DA0", Offset = "0x5E431A0", VA = "0x185E43DA0")]
		private EntityCommandBufferSystem MFALHIFKBBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E43DF0", Offset = "0x5E431F0", VA = "0x185E43DF0")]
		private JobHandle NLIDNBAMPKL(EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<PNCLLHBKFPF> v1Data, ComponentTypes newComponents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E44410", Offset = "0x5E43810", VA = "0x185E44410")]
		public PostDeserializeUpgrade_Split_ContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
[AlwaysUpdateSystem]
public abstract class EJMGHCBLIND : EJPAANLNCMB, EECLMCAJMPP.COBEHCOGCEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private NativeList<EntityQuery> CKJDONFMJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private bool CAPBKEMFPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private EntityCommandBufferSystem PAKMEGEOHCF;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	protected bool DDHCPHLKOFL
	{
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x557E710", Offset = "0x557DB10", VA = "0x18557E710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	protected abstract FBKCBHAMJJJ PECDFFDPILO
	{
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract IEnumerable<EECLMCAJMPP.EKICOEAMHKO> IBKHJDHCCNB();

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E31F10", Offset = "0x5E31310", VA = "0x185E31F10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E32030", Offset = "0x5E31430", VA = "0x185E32030", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E31FE0", Offset = "0x5E313E0", VA = "0x185E31FE0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void JAMMAFLOMPL();

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E31EC0", Offset = "0x5E312C0", VA = "0x185E31EC0")]
	protected EntityCommandBufferSystem MFALHIFKBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008CA")]
	[Cpp2IlInjected.Address(RVA = "0x2258070", Offset = "0x2257470", VA = "0x182258070")]
	protected EntityQuery PFGOFIJGJIP<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CB")]
	[Cpp2IlInjected.Address(RVA = "0x2256F20", Offset = "0x2256320", VA = "0x182256F20")]
	protected HEKKPGLJEEJ<T> KIDEOEPLAHN<T>() where T : struct, IComponentData
	{
		return default(HEKKPGLJEEJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0x2257F60", Offset = "0x2257360", VA = "0x182257F60")]
	protected EPGMMLCEIPK<T> PANKGFCFAHF<T>() where T : struct, IComponentData
	{
		return default(EPGMMLCEIPK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CD")]
	[Cpp2IlInjected.Address(RVA = "0x2257CE0", Offset = "0x22570E0", VA = "0x182257CE0")]
	protected static void MGOFIAOENCC<T1, T2>(LNINLLOMBEF<T1> PBJFFOFCGNN, LNINLLOMBEF<T2> OJMECOHDMON) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0x2257CE0", Offset = "0x22570E0", VA = "0x182257CE0")]
	protected static void MGOFIAOENCC<T1, T2>(LNINLLOMBEF<T1> PBJFFOFCGNN, FLJHOFFCALP<T2> OJMECOHDMON) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0x2257C20", Offset = "0x2257020", VA = "0x182257C20")]
	private static void MGOFIAOENCC<T1, T2>(EFKKFPPCMHF<T1> PBJFFOFCGNN, EFKKFPPCMHF<T2> OJMECOHDMON) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D0")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	protected EJMGHCBLIND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public abstract class ONOIOIMCLMO : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	protected virtual IIOKGAAOGMJ EEFFJOCGPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x75E5C0", Offset = "0x75D9C0", VA = "0x18075E5C0", Slot = "14")]
		get
		{
			return default(IIOKGAAOGMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	protected virtual IIOKGAAOGMJ FKDINLDHBOA
	{
		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x7DC320", Offset = "0x7DB720", VA = "0x1807DC320", Slot = "15")]
		get
		{
			return default(IIOKGAAOGMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void HBLIMFFAECA(IIOKGAAOGMJ FOIKACEEEGH);

	[Cpp2IlInjected.Token(Token = "0x60008D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B750", Offset = "0x5E3AB50", VA = "0x185E3B750", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B6F0", Offset = "0x5E3AAF0", VA = "0x185E3B6F0")]
	private IIOKGAAOGMJ MBMGBIMPEOK()
	{
		return default(IIOKGAAOGMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60008D6")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	protected ONOIOIMCLMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public class HEBCICMOLIH : EJPAANLNCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private ABGAPFKIENI PAKMEGEOHCF;

	[Cpp2IlInjected.Token(Token = "0x60008D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E34BF0", Offset = "0x5E33FF0", VA = "0x185E34BF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E34CC0", Offset = "0x5E340C0", VA = "0x185E34CC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public HEBCICMOLIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class AKIJMBLNHFD : EJPAANLNCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private ABGAPFKIENI PAKMEGEOHCF;

	[Cpp2IlInjected.Token(Token = "0x60008DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CC00", Offset = "0x5E2C000", VA = "0x185E2CC00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CCD0", Offset = "0x5E2C0D0", VA = "0x185E2CCD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DD")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public AKIJMBLNHFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
public class NIIEJIDHMKB : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private NAPCKLFHLCM LFANGALDMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.Token(Token = "0x60008DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B3E0", Offset = "0x5E3A7E0", VA = "0x185E3B3E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B370", Offset = "0x5E3A770", VA = "0x185E3B370", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B4B0", Offset = "0x5E3A8B0", VA = "0x185E3B4B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public NIIEJIDHMKB()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	public class DebugPostLoadValidateNetworkIdSystem : BNNLPOAHIHI, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private struct DebugPostLoadValidateNetworkIdSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public NativeParallelHashMap<IJFILFNCAOA, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			[ReadOnly]
			public ComponentTypeHandle<HBJCJBGLHOO> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0x5E300D0", Offset = "0x5E2F4D0", VA = "0x185E300D0")]
			private void OJJILIFPAAA(Entity entity, [In] HBJCJBGLHOO networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0x5E2FFB0", Offset = "0x5E2F3B0", VA = "0x185E2FFB0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private IKGEFLGAOAF networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private EntityQuery DebugPostLoadValidateNetworkIdSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private ComponentTypeHandle<HBJCJBGLHOO> __RecRoom_Components_ObjectNetworkIdComponentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FF50", Offset = "0x5E2F350", VA = "0x185E2FF50", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E30350", Offset = "0x5E2F750", VA = "0x185E30350", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FE60", Offset = "0x5E2F260", VA = "0x185E2FE60")]
		private void HIIOBLDJNJK(NativeParallelHashMap<IJFILFNCAOA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E30150", Offset = "0x5E2F550", VA = "0x185E30150", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public DebugPostLoadValidateNetworkIdSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	public class DebugPostLoadValidateParentDataSystem : BNNLPOAHIHI, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x200019B")]
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

			[Cpp2IlInjected.Token(Token = "0x60008F0")]
			[Cpp2IlInjected.Address(RVA = "0x5E30740", Offset = "0x5E2FB40", VA = "0x185E30740")]
			private void OJJILIFPAAA(Entity entity, [In] ParentData parentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x5E30620", Offset = "0x5E2FA20", VA = "0x185E30620", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private INHGBAEAGHP objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private EntityQuery DebugPostLoadValidateParentDataSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E30440", Offset = "0x5E2F840", VA = "0x185E30440", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E30910", Offset = "0x5E2FD10", VA = "0x185E30910", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E30910", Offset = "0x5E2FD10", VA = "0x185E30910")]
		private void NPPLKOJOLKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E309E0", Offset = "0x5E2FDE0", VA = "0x185E309E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public DebugPostLoadValidateParentDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E304A0", Offset = "0x5E2F8A0", VA = "0x185E304A0")]
		[CompilerGenerated]
		private void LIAFFILKKLE(Entity entity, [In] ParentData parentData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public class GIEGPCMJKJI : BNNLPOAHIHI, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private JKDKKFNOEFN BJPNEBJACGN;

	[Cpp2IlInjected.Token(Token = "0x60008F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E34250", Offset = "0x5E33650", VA = "0x185E34250", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F3")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F4")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public GIEGPCMJKJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
[UpdateBefore(typeof(DLDAPAKIKAH))]
public class FBFEDADKFHN : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x60008F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E324D0", Offset = "0x5E318D0", VA = "0x185E324D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E32580", Offset = "0x5E31980", VA = "0x185E32580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F7")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public FBFEDADKFHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public class PCFKJCOLIBN : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[BurstCompile]
	private struct CGIJHFIACGM : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		[ReadOnly]
		public NativeArray<EPFFGKPCMBJ> DABHPDFAJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		[ReadOnly]
		public NativeArray<Entity> BAPHNAADJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public ComponentDataFromEntity DBJLLLLAOAE;

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D5F0", Offset = "0x5E2C9F0", VA = "0x185E2D5F0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[BurstCompile]
	private struct DOGHIBDBAKA : IJob, INativeDisposable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> LNBGOPGEFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		[ReadOnly]
		public NativeParallelHashMap<int, EntityArchetype> GHFHGCMANMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		[ReadOnly]
		public NativeParallelHashMap<int, int> CFGKJIAJCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> IBMOBBGAFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> DFGFCIBEBND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public NativeList<EntityArchetype> EBNBKGDNLMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public NativeList<EntityArchetype> HKMJOLJOAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public NativeList<HAJJCCPKKFD> BLANBOGOEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public NativeList<HAJJCCPKKFD> JMMKGALNFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public NativeList<EPFFGKPCMBJ> PACHHAFDMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public NativeList<ComponentType> NAKAOODNAGC;

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F630", Offset = "0x5E2EA30", VA = "0x185E2F630", Slot = "6")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EE80", Offset = "0x5E2E280", VA = "0x185E2EE80", Slot = "5")]
		public JobHandle Dispose(JobHandle DELBIPHKFDD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F090", Offset = "0x5E2E490", VA = "0x185E2F090", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F590", Offset = "0x5E2E990", VA = "0x185E2F590")]
		private int JAKLCPABHIC(HAJJCCPKKFD NANAHAOMLLN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EC90", Offset = "0x5E2E090", VA = "0x185E2EC90")]
		private bool AEEEHDBOEMP(int LMCEOEDHBJD, EntityArchetype IFAAGAGMJPO, [Out] EntityArchetype CEMBJKJBMGA, [Out] Entity KHONMNAJFKE)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[BurstCompile]
	private struct AMALIGMFPMM : IComparer<EPFFGKPCMBJ>
	{
		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x95A8B0", Offset = "0x959CB0", VA = "0x18095A8B0", Slot = "4")]
		public int Compare(EPFFGKPCMBJ MHJJOHHKIPH, EPFFGKPCMBJ DFACBIDGKFM)
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[BurstCompile]
	private struct GLCLNCKGPKI : NLKEGPPPDFA<EPFFGKPCMBJ, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0xE06950", Offset = "0xE05D50", VA = "0x180E06950")]
		public int DBILEHAJOGJ([In] EPFFGKPCMBJ ABNGLIALIJA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0xE06950", Offset = "0xE05D50", VA = "0x180E06950", Slot = "4")]
		private int BNHCFGIHEKL([In] EPFFGKPCMBJ EOHMJBFGDPD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	private struct EPFFGKPCMBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public Entity KHONMNAJFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public HAJJCCPKKFD BAPHNAADJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int LGEBEOHAECM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000534")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private AGHFOJHGCAN HECNGKOMCHK;

	[Cpp2IlInjected.Token(Token = "0x60008F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C140", Offset = "0x5E3B540", VA = "0x185E3C140", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C780", Offset = "0x5E3BB80", VA = "0x185E3C780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C840", Offset = "0x5E3BC40", VA = "0x185E3C840", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BD80", Offset = "0x5E3B180", VA = "0x185E3BD80")]
	private DOGHIBDBAKA FICHCMLKGJH(NativeArray<ArchetypeChunk> HJKGGMKJMDK)
	{
		return default(DOGHIBDBAKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BFC0", Offset = "0x5E3B3C0", VA = "0x185E3BFC0")]
	private void GEMMCGNJPID(NativeArray<EntityArchetype> HKMJOLJOAGO, NativeArray<HAJJCCPKKFD> BLANBOGOEEA, NativeArray<HAJJCCPKKFD> JMMKGALNFAL, NativeArray<ComponentType> NAKAOODNAGC, NativeArray<ArchetypeChunk> HJKGGMKJMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BAE0", Offset = "0x5E3AEE0", VA = "0x185E3BAE0")]
	private EntityArchetype FFBHIKMMFCC(EntityArchetype AJPEJBBMPON, NativeArray<ComponentType> NAKAOODNAGC, HAJJCCPKKFD EFAHGHGDOIA)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C1A0", Offset = "0x5E3B5A0", VA = "0x185E3C1A0")]
	private JobHandle KLAJMHDEGED(NativeList<EPFFGKPCMBJ> DABHPDFAJBG, NativeArray<Entity> BAPHNAADJCK, JobHandle MCHBCAPEEON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000900")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B910", Offset = "0x5E3AD10", VA = "0x185E3B910")]
	private JobHandle ANDIJNPHKGB(NativeArray<Entity> BAPHNAADJCK, NativeArray<EPFFGKPCMBJ> DABHPDFAJBG, int PIEALCBDGOA, HAJJCCPKKFD EFAHGHGDOIA, JobHandle MCHBCAPEEON)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000901")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C190", Offset = "0x5E3B590", VA = "0x185E3C190")]
	public static bool KJFPFKCLFDM(ComponentType HDDPJGDCFBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000902")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public PCFKJCOLIBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[UpdateBefore(typeof(PCFKJCOLIBN))]
public class DLDAPAKIKAH : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private JKDKKFNOEFN BJPNEBJACGN;

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EA00", Offset = "0x5E2DE00", VA = "0x185E2EA00", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EA50", Offset = "0x5E2DE50", VA = "0x185E2EA50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public DLDAPAKIKAH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[HLDCAJNGFIO(PIEFJKINJBJ.OMRoom)]
	[CompilerGenerated]
	public class PostLoadInitializeNetworkIdSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x20001A6")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostLoadInitializeNetworkIdSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.Token(Token = "0x20001A7")]
			public delegate void RunWithoutJobSystem_00000ADE$PostfixBurstDelegate(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20001A8")]
			internal static class RunWithoutJobSystem_00000ADE$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x400055D")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x400055E")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000929")]
				[Cpp2IlInjected.Address(RVA = "0x5E4B0F0", Offset = "0x5E4A4F0", VA = "0x185E4B0F0")]
				[BurstDiscard]
				private static void NDINILJDNKF(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092A")]
				[Cpp2IlInjected.Address(RVA = "0x5E4B410", Offset = "0x5E4A810", VA = "0x185E4B410")]
				private static IntPtr ODONNLFFLBE()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x600092B")]
				[Cpp2IlInjected.Address(RVA = "0x5E4B040", Offset = "0x5E4A440", VA = "0x185E4B040")]
				public static void CIFALECIABA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092C")]
				[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
				public static void FGBNJEBGKMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092E")]
				[Cpp2IlInjected.Address(RVA = "0x5E4B220", Offset = "0x5E4A620", VA = "0x185E4B220")]
				public static void ODMDPACOFGF(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000556")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000557")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public NativeParallelHashMap<IJFILFNCAOA, Entity> map;

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
			public ComponentTypeHandle<HBJCJBGLHOO> __dstValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0x5E450C0", Offset = "0x5E444C0", VA = "0x185E450C0")]
			private void OJJILIFPAAA(Entity entity, int entityInQueryIndex, [NoAlias] HBJCJBGLHOO dstValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000924")]
			[Cpp2IlInjected.Address(RVA = "0x5E44F10", Offset = "0x5E44310", VA = "0x185E44F10", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0x5E45150", Offset = "0x5E44550", VA = "0x185E45150")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void OMEJGDPANOK(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0x5E45050", Offset = "0x5E44450", VA = "0x185E45050")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void NKLFAGEEENB(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostLoadInitializeNetworkIdSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.Token(Token = "0x20001AA")]
			public delegate void RunWithoutJobSystem_00000AE1$PostfixBurstDelegate(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20001AB")]
			internal static class RunWithoutJobSystem_00000AE1$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000565")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000566")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000935")]
				[Cpp2IlInjected.Address(RVA = "0x5E4B620", Offset = "0x5E4AA20", VA = "0x185E4B620")]
				[BurstDiscard]
				private static void NDINILJDNKF(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000936")]
				[Cpp2IlInjected.Address(RVA = "0x5E4B940", Offset = "0x5E4AD40", VA = "0x185E4B940")]
				private static IntPtr ODONNLFFLBE()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000937")]
				[Cpp2IlInjected.Address(RVA = "0x5E4B570", Offset = "0x5E4A970", VA = "0x185E4B570")]
				public static void CIFALECIABA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000938")]
				[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
				public static void FGBNJEBGKMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600093A")]
				[Cpp2IlInjected.Address(RVA = "0x5E4B750", Offset = "0x5E4AB50", VA = "0x185E4B750")]
				public static void ODMDPACOFGF(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400055F")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000560")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public NativeParallelHashMap<IJFILFNCAOA, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			public ComponentTypeHandle<HBJCJBGLHOO> __dstValueTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600092F")]
			[Cpp2IlInjected.Address(RVA = "0x5E45580", Offset = "0x5E44980", VA = "0x185E45580")]
			private void OJJILIFPAAA(Entity entity, [NoAlias] HBJCJBGLHOO dstValue, [In][NoAlias] OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0x5E45370", Offset = "0x5E44770", VA = "0x185E45370", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000931")]
			[Cpp2IlInjected.Address(RVA = "0x5E455F0", Offset = "0x5E449F0", VA = "0x185E455F0")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void OMEJGDPANOK(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0x5E45510", Offset = "0x5E44910", VA = "0x185E45510")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void NKLFAGEEENB(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AC")]
		private struct PostLoadInitializeNetworkIdSystem_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public NativeParallelHashMap<IJFILFNCAOA, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600093B")]
			[Cpp2IlInjected.Address(RVA = "0x5E45930", Offset = "0x5E44D30", VA = "0x185E45930")]
			private void OJJILIFPAAA(Entity entity, [In] OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600093C")]
			[Cpp2IlInjected.Address(RVA = "0x5E45810", Offset = "0x5E44C10", VA = "0x185E45810", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[MFFAOKEGCNH]
		private IKGEFLGAOAF networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		[MFFAOKEGCNH]
		private JKDKKFNOEFN scenes;

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
		private ComponentTypeHandle<HBJCJBGLHOO> __RecRoom_Components_ObjectNetworkIdComponentData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private ComponentTypeHandle<OverrideObjectNetworkIdData> __RecRoom_Components_OverrideObjectNetworkIdData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x5E44E60", Offset = "0x5E44260", VA = "0x185E44E60", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x5E466F0", Offset = "0x5E45AF0", VA = "0x185E466F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x5E46830", Offset = "0x5E45C30", VA = "0x185E46830", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x5E44DF0", Offset = "0x5E441F0", VA = "0x185E44DF0")]
		public void GIGGDPEHGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x5E45A40", Offset = "0x5E44E40", VA = "0x185E45A40")]
		private void MGGOLEADEIB(NativeParallelHashMap<IJFILFNCAOA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x5E46BD0", Offset = "0x5E45FD0", VA = "0x185E46BD0")]
		private void PFNOOKFGDOM(NativeParallelHashMap<IJFILFNCAOA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x5E449D0", Offset = "0x5E43DD0", VA = "0x185E449D0")]
		private void EJPLIBAKINC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x5E44860", Offset = "0x5E43C60", VA = "0x185E44860")]
		private void EHFDJLNEBLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x5E44840", Offset = "0x5E43C40", VA = "0x185E44840")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void DKLCODDMACC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x5E44D10", Offset = "0x5E44110", VA = "0x185E44D10")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void GGHABGOLGPF(NativeParallelHashMap<IJFILFNCAOA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x5E44B80", Offset = "0x5E43F80", VA = "0x185E44B80")]
		private void FCKFNJNEDBF(NativeParallelHashMap<IJFILFNCAOA, Entity> map, uint playerId, uint offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x5E446D0", Offset = "0x5E43AD0", VA = "0x185E446D0")]
		private void AHAOBGBMIJL(NativeParallelHashMap<IJFILFNCAOA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x5E445E0", Offset = "0x5E439E0", VA = "0x185E445E0")]
		private void ABJKLBCGEIP(NativeParallelHashMap<IJFILFNCAOA, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x5E45FA0", Offset = "0x5E453A0", VA = "0x185E45FA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PostLoadInitializeNetworkIdSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x5E44CD0", Offset = "0x5E440D0", VA = "0x185E44CD0")]
		public static void GDMEGPHICGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x5E44ED0", Offset = "0x5E442D0", VA = "0x185E44ED0")]
		public static void LLDJDKKCLOE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	public class PostLoadMoveRootsUnderParentSystem : EJPAANLNCMB
	{
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x5E47130", Offset = "0x5E46530", VA = "0x185E47130", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x5E47210", Offset = "0x5E46610", VA = "0x185E47210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x5E46F90", Offset = "0x5E46390", VA = "0x185E46F90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PostLoadMoveRootsUnderParentSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	[HLDCAJNGFIO(PIEFJKINJBJ.OMRoom)]
	public class PostLoadRemapCircuitIdsSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		private struct PostLoadRemapCircuitIdsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public JIKHBIMIMDL remap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			public ComponentTypeHandle<DGGFBJPDOBJ> __nodeTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000948")]
			[Cpp2IlInjected.Address(RVA = "0x5E47910", Offset = "0x5E46D10", VA = "0x185E47910")]
			private void OJJILIFPAAA(DGGFBJPDOBJ node)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0x5E47840", Offset = "0x5E46C40", VA = "0x185E47840", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		[MFFAOKEGCNH]
		private NBCENCLEOLD serialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private EntityQuery PostLoadRemapCircuitIdsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private ComponentTypeHandle<DGGFBJPDOBJ> __RecRoom_Components_ObjectBoardNodeData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x5E477F0", Offset = "0x5E46BF0", VA = "0x185E477F0", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x5E47D20", Offset = "0x5E47120", VA = "0x185E47D20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x5E47630", Offset = "0x5E46A30", VA = "0x185E47630")]
		private void DGNKILJDJKD(JIKHBIMIMDL remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x5E47710", Offset = "0x5E46B10", VA = "0x185E47710")]
		private void EOOALIEEONJ(JIKHBIMIMDL remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x5E47B20", Offset = "0x5E46F20", VA = "0x185E47B20", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PostLoadRemapCircuitIdsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class KFEONGNOLMP : EJPAANLNCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x600094A")]
	[Cpp2IlInjected.Address(RVA = "0x5E37B50", Offset = "0x5E36F50", VA = "0x185E37B50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094B")]
	[Cpp2IlInjected.Address(RVA = "0x5E37BE0", Offset = "0x5E36FE0", VA = "0x185E37BE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public KFEONGNOLMP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	[CompilerGenerated]
	public class PreSerializeDowngrade_RRObjectPrefabTypeData : EJPAANLNCMB
	{
		[Cpp2IlInjected.Token(Token = "0x20001B2")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
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
			public FMOLPLDIDEJ.KNENMKMLHKD<ArchetypeChunk, OFLOCJKLDNG<RRObjectPrefabV2Data>> it;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public NativeList<IIAJEDFLLEH> prefabTypeData;

			[Cpp2IlInjected.Token(Token = "0x6000954")]
			[Cpp2IlInjected.Address(RVA = "0x5E48B20", Offset = "0x5E47F20", VA = "0x185E48B20")]
			private void OJJILIFPAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000955")]
			[Cpp2IlInjected.Address(RVA = "0x5E48B10", Offset = "0x5E47F10", VA = "0x185E48B10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private EntityQuery queryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x5E49180", Offset = "0x5E48580", VA = "0x185E49180", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x5E49220", Offset = "0x5E48620", VA = "0x185E49220", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x5E48DE0", Offset = "0x5E481E0", VA = "0x185E48DE0")]
		private EntityCommandBufferSystem MFALHIFKBBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x5E48E30", Offset = "0x5E48230", VA = "0x185E48E30")]
		private JobHandle MIGHDLJPNCF(SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO, EntityTypeHandle entityTypeHandleRO, NativeArray<ArchetypeChunk> chunksRO, NativeParallelHashMap<int, int> prefabTypeFromIndexRO, FMOLPLDIDEJ.KNENMKMLHKD<ArchetypeChunk, OFLOCJKLDNG<RRObjectPrefabV2Data>> it, NativeList<Entity> entities, NativeList<IIAJEDFLLEH> prefabTypeData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0x5E48FE0", Offset = "0x5E483E0", VA = "0x185E48FE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PreSerializeDowngrade_RRObjectPrefabTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	[CompilerGenerated]
	public class PreSerializeConditionTagsSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		private struct PreSerializeConditionTagsSystem_Job
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000584")]
			public PreSerializeConditionTagsSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public Dictionary<string, int> tagToIdMap;

			[Cpp2IlInjected.Token(Token = "0x600095C")]
			[Cpp2IlInjected.Address(RVA = "0x5E47F10", Offset = "0x5E47310", VA = "0x185E47F10")]
			private void OJJILIFPAAA(Entity entity, EAMDAMACEOD tags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095D")]
			[Cpp2IlInjected.Address(RVA = "0x5E48100", Offset = "0x5E47500", VA = "0x185E48100")]
			public void OJNGABLDLND(EntityQuery query)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		[MFFAOKEGCNH]
		private AFLJLAKFEOK spawnableToolDependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		[MFFAOKEGCNH]
		private BGHOIHDELID singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		[MFFAOKEGCNH]
		private INHGBAEAGHP objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private EntityQuery PreSerializeConditionTagsSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private ComponentTypeHandle<EAMDAMACEOD> __RecRoom_Components_PersistentUserTagData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x5E47E80", Offset = "0x5E47280", VA = "0x185E47E80", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x5E48700", Offset = "0x5E47B00", VA = "0x185E48700", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x5E489B0", Offset = "0x5E47DB0", VA = "0x185E489B0")]
		private void PMGDMELEGLH(Dictionary<string, int> tagToIdMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x5E483C0", Offset = "0x5E477C0", VA = "0x185E483C0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PreSerializeConditionTagsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
public class FBOMCBBIKID : EJPAANLNCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private EntityQuery NDHCANPFMAC;

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x5E326F0", Offset = "0x5E31AF0", VA = "0x185E326F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x5E327A0", Offset = "0x5E31BA0", VA = "0x185E327A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x5E326A0", Offset = "0x5E31AA0", VA = "0x185E326A0")]
	private EntityCommandBufferSystem MEANBNJHBFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public FBOMCBBIKID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
[AlwaysUpdateSystem]
public class DGADBFCMJNP : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D940", Offset = "0x5E2CD40", VA = "0x185E2D940", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000963")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public DGADBFCMJNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public class DJHCJJIHGEP : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private static FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private EntityQuery CKLMLIODFHF;

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E670", Offset = "0x5E2DA70", VA = "0x185E2E670", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E8F0", Offset = "0x5E2DCF0", VA = "0x185E2E8F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public DJHCJJIHGEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
public class FENBJIPEELJ : LDIOFIMAPDN
{
	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x5E32930", Offset = "0x5E31D30", VA = "0x185E32930", Slot = "14")]
	protected override EntityCommandBufferSystem MFALHIFKBBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x5E32980", Offset = "0x5E31D80", VA = "0x185E32980")]
	public FENBJIPEELJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[CompilerGenerated]
	public class PreSerializeSaveNetworkIdsSystem : EJPAANLNCMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x5E49E90", Offset = "0x5E49290", VA = "0x185E49E90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x5E49F20", Offset = "0x5E49320", VA = "0x185E49F20", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x5E49CA0", Offset = "0x5E490A0", VA = "0x185E49CA0")]
		private EntityCommandBufferSystem MEANBNJHBFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x5E49CF0", Offset = "0x5E490F0", VA = "0x185E49CF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PreSerializeSaveNetworkIdsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[CompilerGenerated]
	public class PreSerializeTransformRootsSystem : EJPAANLNCMB
	{
		[Cpp2IlInjected.Token(Token = "0x20001BB")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PreSerializeTransformRootsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000590")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000591")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000592")]
			public ComponentTypeHandle<FBGNNPLAHMM> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0x5E2AB70", Offset = "0x5E29F70", VA = "0x185E2AB70")]
			private void OJJILIFPAAA([NoAlias] FBGNNPLAHMM data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x5E4A6F0", Offset = "0x5E49AF0", VA = "0x185E4A6F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001BC")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PreSerializeTransformRootsSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000593")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000594")]
			public ComponentTypeHandle<OFGGBPENFAD> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000977")]
			[Cpp2IlInjected.Address(RVA = "0x5E29790", Offset = "0x5E28B90", VA = "0x185E29790")]
			private void OJJILIFPAAA([NoAlias] OFGGBPENFAD data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0x5E4A7C0", Offset = "0x5E49BC0", VA = "0x185E4A7C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private EntityQuery PreSerializeTransformRootsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private EntityQuery PreSerializeTransformRootsSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private EntityQuery __query_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private ComponentTypeHandle<FBGNNPLAHMM> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private ComponentTypeHandle<OFGGBPENFAD> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AD60", Offset = "0x5E4A160", VA = "0x185E4AD60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A2A0", Offset = "0x5E496A0", VA = "0x185E4A2A0")]
		private void GBFDMBLPILI([In] EKDOHGHOOFO transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A4C0", Offset = "0x5E498C0", VA = "0x185E4A4C0")]
		private JobHandle GCHAPGODJAI(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A5F0", Offset = "0x5E499F0", VA = "0x185E4A5F0")]
		private JobHandle GDLIGKOABAC(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A890", Offset = "0x5E49C90", VA = "0x185E4A890", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PreSerializeTransformRootsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[AlwaysUpdateSystem]
public class PMBBFEHMLDD : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CF30", Offset = "0x5E3C330", VA = "0x185E3CF30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public PMBBFEHMLDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public static class MPCFJIPKPHK
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[BurstCompile]
	private struct BGHGBMBDNCD : IJob, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		[ReadOnly]
		public NativeParallelHashSet<int> HBAKEBNNNDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> IBMOBBGAFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public NativeList<EntityArchetype> INCKHDMMIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public NativeList<HAJJCCPKKFD> BLANBOGOEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public NativeList<HAJJCCPKKFD> JMMKGALNFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public NativeList<ComponentType> KPLEFJINKLJ;

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x5E557F0", Offset = "0x5E54BF0", VA = "0x185E557F0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(RVA = "0x5E55760", Offset = "0x5E54B60", VA = "0x185E55760", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AD60", Offset = "0x5E3A160", VA = "0x185E3AD60")]
	public static NativeParallelHashSet<int> LLGFCHPACFP(Allocator KIKFOGPECEC)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AE20", Offset = "0x5E3A220", VA = "0x185E3AE20")]
	public static NativeParallelHashSet<int> LMPDLPKLIBM(Allocator KIKFOGPECEC)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A490", Offset = "0x5E39890", VA = "0x185E3A490")]
	private static void HGMEHKOFOEO(NativeParallelHashSet<int> OCPCJNPGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AA40", Offset = "0x5E39E40", VA = "0x185E3AA40")]
	private static bool JLKACLGMADE(Type IJFAMCPOKBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A800", Offset = "0x5E39C00", VA = "0x185E3A800")]
	private static void HJOGIIPIGNP(NativeParallelHashSet<int> OCPCJNPGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A250", Offset = "0x5E39650", VA = "0x185E3A250")]
	private static void EECFCGJBIID(NativeParallelHashSet<int> OCPCJNPGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AB20", Offset = "0x5E39F20", VA = "0x185E3AB20")]
	private static void KDKOGDHDGAI(NativeParallelHashSet<int> OCPCJNPGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x5E39950", Offset = "0x5E38D50", VA = "0x185E39950")]
	public static void BCOMFBGACDB(EntityManager OKJDPAMBACM, EntityQuery NGALCCNNOFF, NativeParallelHashSet<int> KBOGENJIJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0x5E397B0", Offset = "0x5E38BB0", VA = "0x185E397B0")]
	public static void ADANBFPMFCJ(EntityManager OKJDPAMBACM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public static class EOPNEJLMHMD
{
	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D500", Offset = "0x5E5C900", VA = "0x185E5D500")]
	public static NativeParallelHashSet<int> EIMACLBKNMA(EntityManager OKJDPAMBACM, Allocator KIKFOGPECEC)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D9F0", Offset = "0x5E5CDF0", VA = "0x185E5D9F0")]
	public static NativeParallelHashMap<int, int> NLPNJGCPFKH(EntityManager OKJDPAMBACM, Allocator KIKFOGPECEC)
	{
		return default(NativeParallelHashMap<int, int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
public abstract class LDIOFIMAPDN : EJPAANLNCMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityQuery NGALCCNNOFF;

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract EntityCommandBufferSystem MFALHIFKBBC();

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x5E64180", Offset = "0x5E63580", VA = "0x185E64180", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x5E64210", Offset = "0x5E63610", VA = "0x185E64210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	protected LDIOFIMAPDN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001C2")]
public struct BLCDALCPMFK : ELIPJMCFOMJ<ParentData>
{
	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x5E56680", Offset = "0x5E55A80", VA = "0x185E56680", Slot = "4")]
	public bool BJMDOGMHFGF(ParentData EOHMJBFGDPD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
[BurstCompile]
public struct OFLOCJKLDNG<T> : IEqualityComparer<ArchetypeChunk> where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	[ReadOnly]
	public SharedComponentTypeHandle<T> DFGFCIBEBND;

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x1648B50", Offset = "0x1647F50", VA = "0x181648B50")]
	public OFLOCJKLDNG(SharedComponentTypeHandle<T> DFGFCIBEBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5D50", Offset = "0x3CE5150", VA = "0x183CE5D50", Slot = "4")]
	public bool Equals(ArchetypeChunk MHJJOHHKIPH, ArchetypeChunk DFACBIDGKFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5E50", Offset = "0x3CE5250", VA = "0x183CE5E50", Slot = "5")]
	public int GetHashCode(ArchetypeChunk KGJGPOJOPDJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
public struct FLJHOFFCALP<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	private EFKKFPPCMHF<T> FOIKACEEEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	private EntityCommandBuffer ECEKOIAALDA;

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x33E18B0", Offset = "0x33E0CB0", VA = "0x1833E18B0")]
	public FLJHOFFCALP(EFKKFPPCMHF<T> FOIKACEEEGH, EntityCommandBuffer ECEKOIAALDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x33E11E0", Offset = "0x33E05E0", VA = "0x1833E11E0", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x33D9C80", Offset = "0x33D9080", VA = "0x1833D9C80")]
	public static EFKKFPPCMHF<T> BNPEICKPPJA(FLJHOFFCALP<T> DOJLNGFBAAB)
	{
		return default(EFKKFPPCMHF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
public struct EPGMMLCEIPK<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A0")]
	private LCOPEINNIEI<T> FOIKACEEEGH;

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0x3091830", Offset = "0x3090C30", VA = "0x183091830")]
	public EPGMMLCEIPK(LCOPEINNIEI<T> FOIKACEEEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0x3091740", Offset = "0x3090B40", VA = "0x183091740")]
	public FLJHOFFCALP<T> MKKMOMHBJGO()
	{
		return default(FLJHOFFCALP<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
public struct LNINLLOMBEF<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	private EFKKFPPCMHF<T> FOIKACEEEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	private EntityCommandBuffer ECEKOIAALDA;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public EFKKFPPCMHF<T> IAFKBDENPJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x33D9C80", Offset = "0x33D9080", VA = "0x1833D9C80")]
		get
		{
			return default(EFKKFPPCMHF<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000997")]
	[Cpp2IlInjected.Address(RVA = "0x33E18B0", Offset = "0x33E0CB0", VA = "0x1833E18B0")]
	public LNINLLOMBEF(EFKKFPPCMHF<T> FOIKACEEEGH, EntityCommandBuffer ECEKOIAALDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000998")]
	[Cpp2IlInjected.Address(RVA = "0x3984950", Offset = "0x3983D50", VA = "0x183984950")]
	public void GPFFAFILCKF(LCOPEINNIEI<T> PLMGOBBILKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000999")]
	[Cpp2IlInjected.Address(RVA = "0x3984460", Offset = "0x3983860", VA = "0x183984460", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600099A")]
	[Cpp2IlInjected.Address(RVA = "0x33D9C80", Offset = "0x33D9080", VA = "0x1833D9C80")]
	public static EFKKFPPCMHF<T> BNPEICKPPJA(LNINLLOMBEF<T> DOJLNGFBAAB)
	{
		return default(EFKKFPPCMHF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
public struct HEKKPGLJEEJ<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A3")]
	private LCOPEINNIEI<T> FOIKACEEEGH;

	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0x3091830", Offset = "0x3090C30", VA = "0x183091830")]
	public HEKKPGLJEEJ(LCOPEINNIEI<T> FOIKACEEEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x353B890", Offset = "0x353AC90", VA = "0x18353B890")]
	public LNINLLOMBEF<T> HHCMEKPKFBN()
	{
		return default(LNINLLOMBEF<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
[DefaultMember("Item")]
public struct EFKKFPPCMHF<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	public NativeList<Entity> BAPHNAADJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	public NativeList<T> GHFAAPNAFDE;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public int EKAAEPEENKL
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x3042480", Offset = "0x3041880", VA = "0x183042480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public (Entity entity, T value) LGAFKLMJDKE
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x3040D10", Offset = "0x3040110", VA = "0x183040D10")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x3042100", Offset = "0x3041500", VA = "0x183042100")]
	public void INMJBKGEACO(Entity FILKDLNBIJH, T EOHMJBFGDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x3041C60", Offset = "0x3041060", VA = "0x183041C60")]
	public void ICMGDDMNEAM(NativeArray<Entity> FILKDLNBIJH, NativeArray<T> EOHMJBFGDPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
public struct LCOPEINNIEI<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A6")]
	[ReadOnly]
	public EntityQueryInJob NGALCCNNOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A7")]
	[ReadOnly]
	public EntityTypeHandle DJHKNAAMGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A8")]
	[ReadOnly]
	public ComponentTypeHandle<T> PBBADNHBFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A9")]
	[WriteOnly]
	public EntityCommandBuffer ECEKOIAALDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AA")]
	public AllocatorManager.AllocatorHandle KIKFOGPECEC;

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x3971FA0", Offset = "0x39713A0", VA = "0x183971FA0")]
	public EFKKFPPCMHF<T> MKKMOMHBJGO()
	{
		return default(EFKKFPPCMHF<T>);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[CompilerGenerated]
	public class SplineGeometryVersionSystem : EJPAANLNCMB
	{
		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		private struct SplinePointGeometryVersionJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			[ReadOnly]
			public ComponentTypeHandle<PJMACGKKJMM> positionDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			[ReadOnly]
			public ComponentTypeHandle<OJMAOAMNKDE> rotationDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			[ReadOnly]
			public ComponentTypeHandle<ELJOMKLCEJJ> scaleDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			[ReadOnly]
			public ComponentTypeHandle<KNEGODHIADI> splinePointParentDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			public ComponentDataFromEntity<HNBJNBHMKKH> geometryVersionFromEntityRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			public NativeParallelHashSet<Entity> parentHashset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public uint lastSystemVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public uint thisSystemVersion;

			[Cpp2IlInjected.Token(Token = "0x60009A7")]
			[Cpp2IlInjected.Address(RVA = "0x5E69AC0", Offset = "0x5E68EC0", VA = "0x185E69AC0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001CC")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SplineGeometryVersionSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public uint thisSystemVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public ComponentTypeHandle<HNBJNBHMKKH> __geometryVersionDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009A8")]
			[Cpp2IlInjected.Address(RVA = "0x2982240", Offset = "0x2981640", VA = "0x182982240")]
			private void OJJILIFPAAA([NoAlias] HNBJNBHMKKH geometryVersionData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A9")]
			[Cpp2IlInjected.Address(RVA = "0x5E692E0", Offset = "0x5E686E0", VA = "0x185E692E0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private EntityQuery splinePointQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private EntityQuery splineQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private EntityQuery SplineGeometryVersionSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private ComponentTypeHandle<HNBJNBHMKKH> __RecRoom_Components_SplineGeometryVersionData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E69600", Offset = "0x5E68A00", VA = "0x185E69600", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E69720", Offset = "0x5E68B20", VA = "0x185E69720", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E691E0", Offset = "0x5E685E0", VA = "0x185E691E0")]
		private JobHandle CKEGKCLAOLJ(uint thisSystemVersion, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E693B0", Offset = "0x5E687B0", VA = "0x185E693B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public SplineGeometryVersionSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CD")]
	[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
	[CompilerGenerated]
	internal class SplinePointOrderingUpdateSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		[BurstCompile]
		private struct AddSplinePointInsertsIndiciesJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BD")]
			[ReadOnly]
			public NativeArray<global::LLIEPMNOEAM> indexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005BE")]
			[ReadOnly]
			public ComponentDataFromEntity<KNEGODHIADI> splinePointParentDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			public ComponentDataFromEntity<BOPAAHHJEPL> splinePointOrderDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.Token(Token = "0x60009B3")]
			[Cpp2IlInjected.Address(RVA = "0x5E4F760", Offset = "0x5E4EB60", VA = "0x185E4F760", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001CF")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C1")]
			[ReadOnly]
			public ComponentDataFromEntity<BOPAAHHJEPL> orderRO;

			[Cpp2IlInjected.Token(Token = "0x60009B4")]
			[Cpp2IlInjected.Address(RVA = "0x5E678C0", Offset = "0x5E66CC0", VA = "0x185E678C0", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001D0")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SplinePointOrderingUpdateSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			public uint thisSystemVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			public ComponentTypeHandle<HNBJNBHMKKH> __versionDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x5E6A0D0", Offset = "0x5E694D0", VA = "0x185E6A0D0")]
			private void OJJILIFPAAA(DynamicBuffer<LinkedEntityGroup> buffer, [NoAlias] HNBJNBHMKKH versionData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E69F80", Offset = "0x5E69380", VA = "0x185E69F80", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private EntityQuery needsUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		[MFFAOKEGCNH]
		private BGHOIHDELID singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private EntityQuery SplinePointOrderingUpdateSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private ComponentTypeHandle<HNBJNBHMKKH> __RecRoom_Components_SplineGeometryVersionData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E69DA0", Offset = "0x5E691A0", VA = "0x185E69DA0", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A9E0", Offset = "0x5E69DE0", VA = "0x185E6A9E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A410", Offset = "0x5E69810", VA = "0x185E6A410")]
		private void OOLLCPGNFFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A2C0", Offset = "0x5E696C0", VA = "0x185E6A2C0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void NLECJBCMALN(NativeArray<global::LLIEPMNOEAM> indexUpdatesRO, ComponentDataFromEntity<KNEGODHIADI> splinePointParentDataRO, ComponentDataFromEntity<BOPAAHHJEPL> splinePointOrderDataRW, BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E69DF0", Offset = "0x5E691F0", VA = "0x185E69DF0")]
		private void KHMLGGGBNFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E69C60", Offset = "0x5E69060", VA = "0x185E69C60")]
		private static NHDPLENDLGL BEHABPFHOEL(int insertionIndex, ComponentDataFromEntity<BOPAAHHJEPL> splinePointOrderDataRO, NativeArray<Entity> children)
		{
			return default(NHDPLENDLGL);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A170", Offset = "0x5E69570", VA = "0x185E6A170")]
		private JobHandle MGDADHOCJLO(OrderComparer comparer, uint thisSystemVersion, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A770", Offset = "0x5E69B70", VA = "0x185E6A770", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public SplinePointOrderingUpdateSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
	[CompilerGenerated]
	internal class SplinePointParentChangedSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x20001D2")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SplinePointParentChangedSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CD")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005CE")]
			public DynamicBuffer<global::LLIEPMNOEAM> splineIndexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005CF")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupByEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005D0")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40005D1")]
			[ReadOnly]
			public ComponentTypeHandle<KNEGODHIADI> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x5E6B4E0", Offset = "0x5E6A8E0", VA = "0x185E6B4E0")]
			private void OJJILIFPAAA(Entity splinePoint, [In][NoAlias] KNEGODHIADI splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0x5E6B3C0", Offset = "0x5E6A7C0", VA = "0x185E6B3C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001D3")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SplinePointParentChangedSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005D2")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40005D4")]
			[ReadOnly]
			public ComponentTypeHandle<global::MOIMCOAIDGF> __splinePointParentSystemDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009C3")]
			[Cpp2IlInjected.Address(RVA = "0x5E6B780", Offset = "0x5E6AB80", VA = "0x185E6B780")]
			private void OJJILIFPAAA(Entity splinePoint, [In][NoAlias] global::MOIMCOAIDGF splinePointParentSystemData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C4")]
			[Cpp2IlInjected.Address(RVA = "0x5E6B660", Offset = "0x5E6AA60", VA = "0x185E6B660", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private EntityQuery needsAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private EntityQuery needsRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		[MFFAOKEGCNH]
		private BGHOIHDELID singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private ComponentTypeHandle<KNEGODHIADI> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private ComponentTypeHandle<global::MOIMCOAIDGF> __RecRoom_Components_SplinePointParentSystemData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B0D0", Offset = "0x5E6A4D0", VA = "0x185E6B0D0", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BCB0", Offset = "0x5E6B0B0", VA = "0x185E6BCB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BCA0", Offset = "0x5E6B0A0", VA = "0x185E6BCA0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B120", Offset = "0x5E6A520", VA = "0x185E6B120")]
		private void KFEIBJLOMEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AE20", Offset = "0x5E6A220", VA = "0x185E6AE20")]
		private void HKKNKELFCAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B8B0", Offset = "0x5E6ACB0", VA = "0x185E6B8B0")]
		private EntityCommandBufferSystem MFALHIFKBBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6ACB0", Offset = "0x5E6A0B0", VA = "0x185E6ACB0")]
		private JobHandle EHHHDDCAFGN(EntityCommandBuffer ecb, DynamicBuffer<global::LLIEPMNOEAM> splineIndexUpdatesRO, BufferFromEntity<LinkedEntityGroup> linkedEntityGroupByEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB80", Offset = "0x5E69F80", VA = "0x185E6AB80")]
		private JobHandle BACECGDPCLC(BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B900", Offset = "0x5E6AD00", VA = "0x185E6B900", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public SplinePointParentChangedSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal sealed class BCEGGNALIIH : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FF40", Offset = "0x5E4F340", VA = "0x185E4FF40", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public BCEGGNALIIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal sealed class DFEDECGNBIP : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E596C0", Offset = "0x5E58AC0", VA = "0x185E596C0", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public DFEDECGNBIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal sealed class GHNJDNINBIJ : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EF40", Offset = "0x5E5E340", VA = "0x185E5EF40", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public GHNJDNINBIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal sealed class JMCJMNGOHHH : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E635B0", Offset = "0x5E629B0", VA = "0x185E635B0", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public JMCJMNGOHHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal sealed class AFPEKHFEJKB : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D1D0", Offset = "0x5E4C5D0", VA = "0x185E4D1D0", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public AFPEKHFEJKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal sealed class LDEFFBHPMPB : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E63F60", Offset = "0x5E63360", VA = "0x185E63F60", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public LDEFFBHPMPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
[ExecuteAlways]
public class PDCBNKIBHOF : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x76D100", Offset = "0x76C500", VA = "0x18076D100")]
	public PDCBNKIBHOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal sealed class DEFKLOJFDND : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E58B90", Offset = "0x5E57F90", VA = "0x185E58B90", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public DEFKLOJFDND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class LKNEIDEHFHC : DEECDILBOJC
{
	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public LKNEIDEHFHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal sealed class CDPGAFNANOA : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E566B0", Offset = "0x5E55AB0", VA = "0x185E566B0", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public CDPGAFNANOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
internal class BBDKELDFOCP : DEECDILBOJC
{
	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public BBDKELDFOCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
internal class LMDDNDDDDAJ : DEECDILBOJC
{
	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public LMDDNDDDDAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public sealed class MOPCEFLKCMH : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E66000", Offset = "0x5E65400", VA = "0x185E66000", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public MOPCEFLKCMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[ExecuteAlways]
public class ABGAPFKIENI : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x76D100", Offset = "0x76C500", VA = "0x18076D100")]
	public ABGAPFKIENI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
public class GLFALDKDBPP : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public GLFALDKDBPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
[MNMKEMHOEGL]
public class CGEFMBIEBJA : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private OOMLCKJIEGP MHIDGDMAFGC;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E57670", Offset = "0x5E56A70", VA = "0x185E57670", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E576C0", Offset = "0x5E56AC0", VA = "0x185E576C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public CGEFMBIEBJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public class NEMMALAAPIH : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x20001E5")]
	[BurstCompile]
	private struct HBKADFJAIEF : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		[ReadOnly]
		public NativeArray<Entity> BAPHNAADJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<FBGNNPLAHMM> BEFABMKPPPI;

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F540", Offset = "0x5E5E940", VA = "0x185E5F540", Slot = "4")]
		public void Execute(int APOENOPNHBG, TransformAccess OLPLDGDFGHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F710", Offset = "0x5E5EB10", VA = "0x185E5F710")]
		private bool FAEFELCODLG(float3 GBMOELLOINK, float3 DIPNGLKFBLA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F740", Offset = "0x5E5EB40", VA = "0x185E5F740")]
		private bool OLFKMAOBNLK(quaternion GBMOELLOINK, quaternion DIPNGLKFBLA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001E6")]
	[BurstCompile]
	private struct HNMMGLBPCON : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		[ReadOnly]
		public NativeArray<Entity> BAPHNAADJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<OFGGBPENFAD> PDCAADBAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<HGJKNBGMLIB> IOFDIFENBCE;

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E60200", Offset = "0x5E5F600", VA = "0x185E60200", Slot = "4")]
		public void Execute(int APOENOPNHBG, TransformAccess OLPLDGDFGHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	private static readonly FBKCBHAMJJJ MFPEDDFJPCG;

	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	private static readonly FBKCBHAMJJJ BAHAJCPDFHE;

	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	private static readonly FBKCBHAMJJJ LFIILELGMHG;

	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private static readonly ProfilerMarker JPPKGCPJNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private OJJMIPKEBBC JBDMCGJDEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E66410", Offset = "0x5E65810", VA = "0x185E66410", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E66480", Offset = "0x5E65880", VA = "0x185E66480", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E664C0", Offset = "0x5E658C0", VA = "0x185E664C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public NEMMALAAPIH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001E7")]
	[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
	[CompilerGenerated]
	public class RegisterTransformsSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x20001E8")]
		private struct RegisterTransformsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005EA")]
			public RegisterTransformsSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005EB")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40005EC")]
			[ReadOnly]
			public ComponentTypeHandle<EAKLOIPPEOD> __arrayIndexTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			public ComponentTypeHandle<Transform> __transformTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009F8")]
			[Cpp2IlInjected.Address(RVA = "0x5E680D0", Offset = "0x5E674D0", VA = "0x185E680D0")]
			private void OriginalLambdaBody(Entity entity, [In] EAKLOIPPEOD arrayIndex, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x5E67EE0", Offset = "0x5E672E0", VA = "0x185E67EE0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private OJJMIPKEBBC embodiedTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private EntityQuery allTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private EntityQuery addNewTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private EntityQuery removeOldTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private EntityQuery clearTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private EntityQuery RegisterTransformsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private ComponentTypeHandle<EAKLOIPPEOD> __RecRoom_Components_TransformAccessArrayIndexData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E67E90", Offset = "0x5E67290", VA = "0x185E67E90", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E683E0", Offset = "0x5E677E0", VA = "0x185E683E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E686B0", Offset = "0x5E67AB0", VA = "0x185E686B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E67AA0", Offset = "0x5E66EA0", VA = "0x185E67AA0")]
		private void AddTransforms(EntityQuery query, PFOOKIGEPDE accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E689C0", Offset = "0x5E67DC0", VA = "0x185E689C0")]
		private void RemoveTransforms(EntityQuery query, PFOOKIGEPDE accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E68620", Offset = "0x5E67A20", VA = "0x185E68620", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E67940", Offset = "0x5E66D40", VA = "0x185E67940")]
		private void AddNewTransforms(NativeArray<Entity> entities, PFOOKIGEPDE accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E687A0", Offset = "0x5E67BA0", VA = "0x185E687A0")]
		internal static void RemoveOldTransforms(NativeArray<EAKLOIPPEOD> arrayIndices, ComponentDataFromEntity<EAKLOIPPEOD> transformAccess, PFOOKIGEPDE accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F2")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
		private static void DebugLogRemove(int index, PFOOKIGEPDE accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E67D40", Offset = "0x5E67140", VA = "0x185E67D40")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DebugLogUninitializedTransformAccessArrayIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E67D40", Offset = "0x5E67140", VA = "0x185E67D40")]
		private void RegisterTransformsSystem_LambdaJob_0_Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E681E0", Offset = "0x5E675E0", VA = "0x185E681E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public RegisterTransformsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EA")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public class CLHCMGHOPJC : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x20001EB")]
	[BurstCompile]
	private struct JEFDOFGEIPF : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		[ReadOnly]
		public ComponentDataFromEntity<FBGNNPLAHMM> BEFABMKPPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		[ReadOnly]
		public NativeArray<Entity> BAPHNAADJCK;

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x5E61D50", Offset = "0x5E61150", VA = "0x185E61D50", Slot = "4")]
		public void Execute(int APOENOPNHBG, TransformAccess OLPLDGDFGHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	[BurstCompile]
	private struct KPCKPJIFKDF : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		[ReadOnly]
		public ComponentDataFromEntity<OFGGBPENFAD> PDCAADBAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		[ReadOnly]
		public NativeArray<Entity> BAPHNAADJCK;

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x5E63EB0", Offset = "0x5E632B0", VA = "0x185E63EB0", Slot = "4")]
		public void Execute(int APOENOPNHBG, TransformAccess OLPLDGDFGHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001ED")]
	[BurstCompile]
	private struct FOIEBGPJIDH : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		[ReadOnly]
		public ComponentDataFromEntity<OFGGBPENFAD> PDCAADBAFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		[ReadOnly]
		public ComponentDataFromEntity<HGJKNBGMLIB> IOFDIFENBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		[ReadOnly]
		public NativeArray<Entity> BAPHNAADJCK;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x5E5ED70", Offset = "0x5E5E170", VA = "0x185E5ED70", Slot = "4")]
		public void Execute(int APOENOPNHBG, TransformAccess OLPLDGDFGHL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private static readonly FBKCBHAMJJJ MFPEDDFJPCG;

	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private static readonly FBKCBHAMJJJ BAHAJCPDFHE;

	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private static readonly FBKCBHAMJJJ LFIILELGMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private OJJMIPKEBBC JBDMCGJDEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private EntityQuery CNBADPGGDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private EntityQuery APKJOOAMEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private EntityQuery AIGBHLBKJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private TransformAccessArray PKLJPDBDLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private TransformAccessArray AHMHEFHMKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private TransformAccessArray KMGHKKIGLIL;

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E57920", Offset = "0x5E56D20", VA = "0x185E57920", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E57970", Offset = "0x5E56D70", VA = "0x185E57970", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E57B80", Offset = "0x5E56F80", VA = "0x185E57B80", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E57C10", Offset = "0x5E57010", VA = "0x185E57C10", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x5E57C40", Offset = "0x5E57040", VA = "0x185E57C40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0x5E577A0", Offset = "0x5E56BA0", VA = "0x185E577A0")]
	private NativeArray<Entity> BGKPMDAIEMI(NativeArray<EAKLOIPPEOD> PIHPAKAJMHN, NativeList<Entity> CIKOOGCEBCP, TransformAccessArray HKMLCOGFKOH, TransformAccessArray JJONOBACMFC)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A02")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public CLHCMGHOPJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EE")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public class OKEGNMBDOBF : EJPAANLNCMB, DFFDMFBJPHA
{
	[Cpp2IlInjected.Token(Token = "0x4000601")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	private EEKMFIANCNG NELCKHGKJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private FGGFOCNBCHP EDJCLBAFIOG;

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x5E39260", Offset = "0x5E38660", VA = "0x185E39260", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x5E66CB0", Offset = "0x5E660B0", VA = "0x185E66CB0", Slot = "14")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x5E66DB0", Offset = "0x5E661B0", VA = "0x185E66DB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x5E66AA0", Offset = "0x5E65EA0", VA = "0x185E66AA0")]
	private static void HIKOPHFKFPL(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, Entity EBFCMPBKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x5E66C10", Offset = "0x5E66010", VA = "0x185E66C10")]
	private static bool LFEOLBBNFPA(EntityManager OKJDPAMBACM, Entity FILKDLNBIJH, [Out] Transform OLPLDGDFGHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public OKEGNMBDOBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EF")]
public class MACKGLFGNCB : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x20001F0")]
	[BurstCompile]
	private struct DDMNPHICELJ : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		[ReadOnly]
		public ComponentTypeHandle<PCKBDGFINJN> GJIEJMHAJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		[ReadOnly]
		public BufferTypeHandle<ChildrenData> FCCNECOIHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> FCFMIDCGCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		[ReadOnly]
		public ComponentDataFromEntity<PCKBDGFINJN> IGPOHFHPALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public ComponentTypeHandle<CCKLCDOFFMI> GKDNIPANEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<CCKLCDOFFMI> AODMKOILBDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public uint LGIAKPOCPJB;

		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0x5E584B0", Offset = "0x5E578B0", VA = "0x185E584B0", Slot = "4")]
		public void Execute(ArchetypeChunk KGJGPOJOPDJ, int APOENOPNHBG, int MBMBCDKFLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x5E587B0", Offset = "0x5E57BB0", VA = "0x185E587B0")]
		private void KIHGBABKNGN(float4x4 LEGBGABMJKA, Entity FILKDLNBIJH, bool PAPNPPPJFFO, int MOLHCHBGJAP = 1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private EntityQuery EPAGBOAAICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private EntityQuery ABKMLGJJLOP;

	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x5E65A00", Offset = "0x5E64E00", VA = "0x185E65A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x5E65B30", Offset = "0x5E64F30", VA = "0x185E65B30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public MACKGLFGNCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F1")]
public class FHIFFILBKEJ : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x20001F2")]
	[BurstCompile]
	private struct MGJFMLOOPNH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		[ReadOnly]
		public ComponentTypeHandle<PCKBDGFINJN> GJIEJMHAJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public ComponentTypeHandle<CCKLCDOFFMI> GKDNIPANEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public uint LGIAKPOCPJB;

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0x5E65E60", Offset = "0x5E65260", VA = "0x185E65E60", Slot = "4")]
		public void Execute(ArchetypeChunk KGJGPOJOPDJ, int APOENOPNHBG, int MBMBCDKFLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0x5E65F70", Offset = "0x5E65370", VA = "0x185E65F70")]
		public bool OJNENBPOPJH(ArchetypeChunk KGJGPOJOPDJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private EntityQuery EPAGBOAAICM;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DBB0", Offset = "0x5E5CFB0", VA = "0x185E5DBB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DCE0", Offset = "0x5E5D0E0", VA = "0x185E5DCE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public FHIFFILBKEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F3")]
public class JOKBJCCHJBG : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x20001F4")]
	[BurstCompile]
	private struct BAHBKNNMHHP : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		[ReadOnly]
		public ComponentTypeHandle<CCKLCDOFFMI> FHAMABBMBLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public ComponentTypeHandle<JBAAHJBHFEM> OJGOODBPLPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public ComponentTypeHandle<COEKCHNJJDA> KJKDAGFNNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public ComponentTypeHandle<MHHAAGLKIGL> KLLKLLDIHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public uint LGIAKPOCPJB;

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FAC0", Offset = "0x5E4EEC0", VA = "0x185E4FAC0", Slot = "4")]
		public void Execute(ArchetypeChunk KGJGPOJOPDJ, int APOENOPNHBG, int MBMBCDKFLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FEB0", Offset = "0x5E4F2B0", VA = "0x185E4FEB0")]
		public bool OJNENBPOPJH(ArchetypeChunk KGJGPOJOPDJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private EntityQuery IHBAGGIDMKI;

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x5E63600", Offset = "0x5E62A00", VA = "0x185E63600", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x5E63710", Offset = "0x5E62B10", VA = "0x185E63710", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public JOKBJCCHJBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F5")]
public class GOMGHCCMAGL : EJPAANLNCMB
{
	[Cpp2IlInjected.Token(Token = "0x20001F6")]
	[BurstCompile]
	private struct LKHJKAPGAND : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		[ReadOnly]
		public ComponentTypeHandle<FBGNNPLAHMM> ILNCPICDOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		[ReadOnly]
		public ComponentTypeHandle<HGJKNBGMLIB> BINAHEILOKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		[ReadOnly]
		public ComponentTypeHandle<OFGGBPENFAD> EICMMCLNDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public ComponentTypeHandle<PCKBDGFINJN> KBPDJIIBPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public uint LGIAKPOCPJB;

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x5E64DC0", Offset = "0x5E641C0", VA = "0x185E64DC0", Slot = "4")]
		public void Execute(ArchetypeChunk KGJGPOJOPDJ, int APOENOPNHBG, int MBMBCDKFLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x5E65530", Offset = "0x5E64930", VA = "0x185E65530")]
		public bool OJNENBPOPJH(ArchetypeChunk KGJGPOJOPDJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private EntityQuery IHBAGGIDMKI;

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F250", Offset = "0x5E5E650", VA = "0x185E5F250", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F380", Offset = "0x5E5E780", VA = "0x185E5F380", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public GOMGHCCMAGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F7")]
public class HDJHOOJFAAK : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x400061E")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	[MFFAOKEGCNH]
	private AEMGHLGPJFG EABDACHGCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000620")]
	[MFFAOKEGCNH]
	private IKGEFLGAOAF AMOCKDOEOGI;

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FCB0", Offset = "0x5E5F0B0", VA = "0x185E5FCB0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x5E60050", Offset = "0x5E5F450", VA = "0x185E60050", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FD20", Offset = "0x5E5F120", VA = "0x185E5FD20")]
	private void LMBFFIBNDFF(NativeArray<IJFILFNCAOA> NFOCCHLBCEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public HDJHOOJFAAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F8")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal class IOBNOCAGLFD : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000621")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000622")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000623")]
	private AEMGHLGPJFG PPFIOOKIMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000624")]
	private EMLJAPIGCLK ENOFBOBGGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	private CALJHDDCOOA KHJECHBHLEK;

	[Cpp2IlInjected.Token(Token = "0x6000A28")]
	[Cpp2IlInjected.Address(RVA = "0x5E60D30", Offset = "0x5E60130", VA = "0x185E60D30", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x5E60DE0", Offset = "0x5E601E0", VA = "0x185E60DE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public IOBNOCAGLFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F9")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public sealed class GLIDGJFAGME : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000626")]
	private JBLOAMOKHEB GCLFDBLLOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000627")]
	private AEMGHLGPJFG ODEOFMHKBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	private CALJHDDCOOA KHJECHBHLEK;

	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F0E0", Offset = "0x5E5E4E0", VA = "0x185E5F0E0", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F170", Offset = "0x5E5E570", VA = "0x185E5F170", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public GLIDGJFAGME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FA")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal class EBAFIFHOKEB : EJPAANLNCMB, JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private static readonly FBKCBHAMJJJ PKJBHNBJCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	[MFFAOKEGCNH]
	private HABDGJEIGLI MDPJPABGGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	[MFFAOKEGCNH]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	[MFFAOKEGCNH]
	private DGGBEDJKEHK HEPKNODKGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	[MFFAOKEGCNH]
	private GHBGCJBELNC MLPOPDPEHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	[MFFAOKEGCNH]
	private LGIBJLNADBL CPHJFGPLCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	[MFFAOKEGCNH]
	private EKKHKJDOOEK CDJDLKEEKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private NCJJIDFOKAJ.JMAHCLEKNCB DMCOPCNKEDK;

	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B660", Offset = "0x5E5AA60", VA = "0x185E5B660", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A30")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AF20", Offset = "0x5E5A320", VA = "0x185E5AF20", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A31")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BDD0", Offset = "0x5E5B1D0", VA = "0x185E5BDD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A750", Offset = "0x5E59B50", VA = "0x185E5A750")]
	private void BGCCBHGMLEB(OCNDOGNDAKK DGCJCBHPPBD, NativeArray<byte> PDEHJHDJEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B600", Offset = "0x5E5AA00", VA = "0x185E5B600")]
	private bool IJDKAGEAEEP(OCNDOGNDAKK DGCJCBHPPBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AFC0", Offset = "0x5E5A3C0", VA = "0x185E5AFC0")]
	private NCJJIDFOKAJ.NEMNPEFGEIM ENNNHAMEIDH(NativeArray<byte> PDEHJHDJEHH, Allocator KIKFOGPECEC)
	{
		return default(NCJJIDFOKAJ.NEMNPEFGEIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x5E5ACA0", Offset = "0x5E5A0A0", VA = "0x185E5ACA0")]
	private void CFMPJKMJHNE(NCJJIDFOKAJ.NEMNPEFGEIM ILJJGJOCFKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BBD0", Offset = "0x5E5AFD0", VA = "0x185E5BBD0")]
	private void NFKMDILKJEA(NativeList<IJFILFNCAOA> FKNPDKLLGNO, NativeList<EIDGNLJLKDK> CHAFPPHFFEK, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B110", Offset = "0x5E5A510", VA = "0x185E5B110")]
	private void EPIIFNHDHEA(NativeParallelMultiHashMap<IJFILFNCAOA, MBIJMHMIIKK> PMJONGFLMPO, NativeList<byte> IABKHGFAEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B940", Offset = "0x5E5AD40", VA = "0x185E5B940")]
	private void MCIOEPFEAID(NativeList<IJFILFNCAOA> HODIBOAAEHA, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AD80", Offset = "0x5E5A180", VA = "0x185E5AD80")]
	private void CHGGPICKPPI(NCJJIDFOKAJ.NEMNPEFGEIM GHFAAPNAFDE, bool AMPPODDOAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B8A0", Offset = "0x5E5ACA0", VA = "0x185E5B8A0")]
	private void KCOMFEJIFDN(NativeList<IJFILFNCAOA> FKNPDKLLGNO, NativeList<EIDGNLJLKDK> CHAFPPHFFEK, bool AMPPODDOAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A120", Offset = "0x5E59520", VA = "0x185E5A120")]
	private void AHGOBMCNOOI(NativeParallelMultiHashMap<IJFILFNCAOA, MBIJMHMIIKK> PMJONGFLMPO, NativeList<byte> IABKHGFAEGG, bool AMPPODDOAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B800", Offset = "0x5E5AC00", VA = "0x185E5B800")]
	private void JAEKKLMLAEK(NativeList<IJFILFNCAOA> HODIBOAAEHA, bool AMPPODDOAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void OPLLNMMAAHA(OCNDOGNDAKK DGCJCBHPPBD, bool AMPPODDOAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public EBAFIFHOKEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FB")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal class IKBAMDJANOH : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private BCLKHHIKFMA AMEAOOFACPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private AEMGHLGPJFG PPFIOOKIMNN;

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x5E60460", Offset = "0x5E5F860", VA = "0x185E60460", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x5E604D0", Offset = "0x5E5F8D0", VA = "0x185E604D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public IKBAMDJANOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FC")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal class OKMPGDJKHKA : EJPAANLNCMB, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private AOIJIDDNGFE DKHFFJHAFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private AEMGHLGPJFG PPFIOOKIMNN;

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x5E67600", Offset = "0x5E66A00", VA = "0x185E67600", Slot = "14")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0x5E67670", Offset = "0x5E66A70", VA = "0x185E67670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public OKMPGDJKHKA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001FD")]
	[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	internal sealed class WriteDiffChangePacketToNetworkSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x20001FE")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct WriteDiffChangePacketToNetworkSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20001FF")]
			public delegate void RunWithoutJobSystem_00000C09$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000200")]
			internal static class RunWithoutJobSystem_00000C09$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x400064D")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x400064E")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000A61")]
				[Cpp2IlInjected.Address(RVA = "0x5E68D80", Offset = "0x5E68180", VA = "0x185E68D80")]
				[BurstDiscard]
				private static void NDINILJDNKF(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A62")]
				[Cpp2IlInjected.Address(RVA = "0x5E69080", Offset = "0x5E68480", VA = "0x185E69080")]
				private static IntPtr ODONNLFFLBE()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A63")]
				[Cpp2IlInjected.Address(RVA = "0x5E68CD0", Offset = "0x5E680D0", VA = "0x185E68CD0")]
				public static void CIFALECIABA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A64")]
				[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
				public static void FGBNJEBGKMH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A66")]
				[Cpp2IlInjected.Address(RVA = "0x5E68EB0", Offset = "0x5E682B0", VA = "0x185E68EB0")]
				public static void ODMDPACOFGF(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400063F")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000640")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			public OFOMCGLEDAP replication;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			public NativeBitArray entityByProperty;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000643")]
			[ReadOnly]
			public NativeArray<IJFILFNCAOA> srcCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000644")]
			[ReadOnly]
			public NativeArray<EIDGNLJLKDK> srcCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			[ReadOnly]
			public NativeArray<IJFILFNCAOA> srcDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000646")]
			[ReadOnly]
			public NativeKeyValueArrays<Entity, HJLMBJKKHBB> srcPropertyKeyValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000647")]
			public NativeList<IJFILFNCAOA> dstCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000648")]
			public NativeList<EIDGNLJLKDK> dstCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000649")]
			public NativeList<IJFILFNCAOA> dstDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400064A")]
			public NativeParallelMultiHashMap<IJFILFNCAOA, MBIJMHMIIKK> dstProperties;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400064B")]
			public NativeList<byte> dstPropertyData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			public ComponentDataFromEntity<HBJCJBGLHOO> __RecRoom_Components_ObjectNetworkIdComponentData_FromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000A5B")]
			[Cpp2IlInjected.Address(RVA = "0x5E6D770", Offset = "0x5E6CB70", VA = "0x185E6D770")]
			private void OJJILIFPAAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5C")]
			[Cpp2IlInjected.Address(RVA = "0x5E6D710", Offset = "0x5E6CB10", VA = "0x185E6D710", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0x5E6DBD0", Offset = "0x5E6CFD0", VA = "0x185E6DBD0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void OMEJGDPANOK(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0x5E6D720", Offset = "0x5E6CB20", VA = "0x185E6D720")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void NKLFAGEEENB(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private static readonly FBKCBHAMJJJ logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		[MFFAOKEGCNH]
		private BENCMKIONLD packetService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		[MFFAOKEGCNH]
		private AEMGHLGPJFG diffService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		[MFFAOKEGCNH]
		private LKEFCEFOADP editorEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		[MFFAOKEGCNH]
		private LCMBOOHOIHL transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private NCJJIDFOKAJ.JMAHCLEKNCB utilServices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		private bool HasEditorListeners
		{
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		private OAHNCEDJNNM EventFlagsForPhase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x5E6DEB0", Offset = "0x5E6D2B0", VA = "0x185E6DEB0")]
			get
			{
				return default(OAHNCEDJNNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D5F0", Offset = "0x5E6C9F0", VA = "0x185E6D5F0", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x5E6EA70", Offset = "0x5E6DE70", VA = "0x185E6EA70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DDE0", Offset = "0x5E6D1E0", VA = "0x185E6DDE0")]
		private bool MPKHGDBMAHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CE60", Offset = "0x5E6C260", VA = "0x185E6CE60")]
		private bool GCCFELNMPEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CE10", Offset = "0x5E6C210", VA = "0x185E6CE10")]
		private bool FDBBPOFDBBJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF50", Offset = "0x5E6D350", VA = "0x185E6DF50")]
		private NCJJIDFOKAJ.NEMNPEFGEIM OPEKBACJOIG(BLJODAPBPOA state)
		{
			return default(NCJJIDFOKAJ.NEMNPEFGEIM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CFC0", Offset = "0x5E6C3C0", VA = "0x185E6CFC0")]
		private NativeKeyValueArrays<Entity, HJLMBJKKHBB> GLOICDALFAD(BLJODAPBPOA state, [Out] int capacity)
		{
			return default(NativeKeyValueArrays<Entity, HJLMBJKKHBB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D2C0", Offset = "0x5E6C6C0", VA = "0x185E6D2C0")]
		private void HAHEFLAEAFN(NCJJIDFOKAJ.NEMNPEFGEIM data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C820", Offset = "0x5E6BC20", VA = "0x185E6C820")]
		private void CCPGAEAJPGD(NCJJIDFOKAJ.NEMNPEFGEIM data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C900", Offset = "0x5E6BD00", VA = "0x185E6C900")]
		private void CHGGPICKPPI(NCJJIDFOKAJ.NEMNPEFGEIM data, BLJODAPBPOA state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D6E0", Offset = "0x5E6CAE0", VA = "0x185E6D6E0")]
		private void KCOMFEJIFDN(NativeArray<IJFILFNCAOA> createdIds, NativeArray<EIDGNLJLKDK> creationData, OAHNCEDJNNM flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C080", Offset = "0x5E6B480", VA = "0x185E6C080")]
		private void AHGOBMCNOOI(NativeMultiHashMapAsync<Entity, HJLMBJKKHBB> differences, OAHNCEDJNNM flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D6B0", Offset = "0x5E6CAB0", VA = "0x185E6D6B0")]
		private void JAEKKLMLAEK(NativeArray<IJFILFNCAOA> destroyedIds, OAHNCEDJNNM flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CB40", Offset = "0x5E6BF40", VA = "0x185E6CB40")]
		private void EJBPABDOCAN(OFOMCGLEDAP replication, NativeBitArray entityByProperty, NativeArray<IJFILFNCAOA> srcCreatedIds, NativeArray<EIDGNLJLKDK> srcCreationData, NativeArray<IJFILFNCAOA> srcDestroyedIds, NativeKeyValueArrays<Entity, HJLMBJKKHBB> srcPropertyKeyValues, NativeList<IJFILFNCAOA> dstCreatedIds, NativeList<EIDGNLJLKDK> dstCreationData, NativeList<IJFILFNCAOA> dstDestroyedIds, NativeParallelMultiHashMap<IJFILFNCAOA, MBIJMHMIIKK> dstProperties, NativeList<byte> dstPropertyData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E800", Offset = "0x5E6DC00", VA = "0x185E6E800", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public WriteDiffChangePacketToNetworkSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CF80", Offset = "0x5E6C380", VA = "0x185E6CF80")]
		public static void GGKEIMDNJLB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000201")]
internal class LPOIGNPHCPI : DAPCNLHMJOC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000202")]
	public struct AHDALBDHFFI : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	protected override ComponentType ICGAGJNNNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0x5E65880", Offset = "0x5E64C80", VA = "0x185E65880", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	protected override ComponentType FMGPPLPBAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0x5E658B0", Offset = "0x5E64CB0", VA = "0x185E658B0", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	protected override ComponentType JKIGKNNBLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x5E658E0", Offset = "0x5E64CE0", VA = "0x185E658E0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x5E659A0", Offset = "0x5E64DA0", VA = "0x185E659A0")]
	public LPOIGNPHCPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000203")]
public sealed class EAHODGFMALL : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x5E59860", Offset = "0x5E58C60", VA = "0x185E59860", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public EAHODGFMALL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000204")]
[ExecuteAlways]
public class JKLGDOIJEPE : AOKLLJPGCEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public JKLGDOIJEPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000205")]
public sealed class LHCEMFGOAPL : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x5E64660", Offset = "0x5E63A60", VA = "0x185E64660", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public LHCEMFGOAPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000206")]
public sealed class BDPHBBNOLIL : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x5E55090", Offset = "0x5E54490", VA = "0x185E55090", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public BDPHBBNOLIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000207")]
[ExecuteAlways]
public class LLGGBFAGMGH : AOKLLJPGCEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
	public LLGGBFAGMGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000208")]
public sealed class FPDIPFEMGDN : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EE70", Offset = "0x5E5E270", VA = "0x185E5EE70", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public FPDIPFEMGDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000209")]
[EEHDICKJDPC(typeof(NFJDCGPFACM))]
[PNAJALIKCOM(typeof(CCCMOPCHHIG), new string[] { })]
public class KIMDJLFANHG : CCCMOPCHHIG, CNJKPBKICBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private readonly Dictionary<int, FKMDJINEHMO> PJJGDLILJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private readonly Dictionary<Type, FKMDJINEHMO> ABNNIEIDAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private readonly Dictionary<Type, FKMDJINEHMO> IGCNFIEJEIO;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public IReadOnlyCollection<FKMDJINEHMO> FLPDMOCOECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x5E63D50", Offset = "0x5E63150", VA = "0x185E63D50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x5E63A10", Offset = "0x5E62E10", VA = "0x185E63A10", Slot = "7")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x5E63920", Offset = "0x5E62D20", VA = "0x185E63920", Slot = "6")]
	public FKMDJINEHMO HBCLLHKOGEL(Type IJFAMCPOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x5E639A0", Offset = "0x5E62DA0", VA = "0x185E639A0", Slot = "5")]
	public bool HJKCFIGGHJO(int PIEALCBDGOA, [Out] FKMDJINEHMO MFEJFLABCIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x5E638D0", Offset = "0x5E62CD0", VA = "0x185E638D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7B")]
	[Cpp2IlInjected.Address(RVA = "0x5E63DA0", Offset = "0x5E631A0", VA = "0x185E63DA0")]
	public KIMDJLFANHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020A")]
[PNAJALIKCOM(typeof(KDBONONDPOD), new string[] { })]
[EEHDICKJDPC(typeof(NFJDCGPFACM))]
public class BDGOOGHEAHB : KDBONONDPOD, CNJKPBKICBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private readonly Dictionary<int, LDAMFPBECCI> GABFDFGFHPK;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public IEnumerable<LDAMFPBECCI> HHPIMJECGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x5E54B00", Offset = "0x5E53F00", VA = "0x185E54B00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7D")]
	[Cpp2IlInjected.Address(RVA = "0x5E54C10", Offset = "0x5E54010", VA = "0x185E54C10", Slot = "6")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x5E54B50", Offset = "0x5E53F50", VA = "0x185E54B50", Slot = "5")]
	public bool DKCBNGKBCMH(int PIEALCBDGOA, [Out] LDAMFPBECCI HOGACIGOPKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x5E54BC0", Offset = "0x5E53FC0", VA = "0x185E54BC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A80")]
	[Cpp2IlInjected.Address(RVA = "0x5E55000", Offset = "0x5E54400", VA = "0x185E55000")]
	public BDGOOGHEAHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020B")]
[PNAJALIKCOM(typeof(PMHNFJPNKBF), new string[] { })]
[EEHDICKJDPC(typeof(NFJDCGPFACM))]
public class INDEOBGCKEL : PMHNFJPNKBF, CNJKPBKICBD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private static readonly Dictionary<int, int> PINJJLNKMNP;

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x5E60910", Offset = "0x5E5FD10", VA = "0x185E60910", Slot = "5")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x5E60C00", Offset = "0x5E60000", VA = "0x185E60C00", Slot = "4")]
	public int MBMGBIMPEOK(int PIEALCBDGOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A83")]
	[Cpp2IlInjected.Address(RVA = "0x5E608A0", Offset = "0x5E5FCA0", VA = "0x185E608A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public INDEOBGCKEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020C")]
[PNAJALIKCOM(typeof(OICBHKENADA), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
internal class OICBHKENADA : DFFDMFBJPHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private JJHPOPGKCDK<AuthoredParentData, AuthoredPreviousParentData, GLODEBGBJAN, AuthoredChildrenData> EOPIDIGKEPL;

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0x5E669E0", Offset = "0x5E65DE0", VA = "0x185E669E0", Slot = "4")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public OICBHKENADA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020D")]
[PNAJALIKCOM(typeof(JCCLPJHONHK), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
internal sealed class JCCLPJHONHK : JAKEGKENGGK, DFFDMFBJPHA
{
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	[MFFAOKEGCNH]
	private KFJHDAOPGPA IHBAGGIDMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000658")]
	private PJFEPPCEHDM<Entity> ANNDMLIIDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000659")]
	private JJHPOPGKCDK<ParentData, PreviousParentData, DCOJIDIDKGB, ChildrenData> EOPIDIGKEPL;

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x5E61AA0", Offset = "0x5E60EA0", VA = "0x185E61AA0", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x5E61B50", Offset = "0x5E60F50", VA = "0x185E61B50", Slot = "5")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x5E61C70", Offset = "0x5E61070", VA = "0x185E61C70")]
	public Entity OBHLIPJDBGF(Entity FILKDLNBIJH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0x5E61AF0", Offset = "0x5E60EF0", VA = "0x185E61AF0")]
	public bool LJDLEFCDHAM(Entity FILKDLNBIJH, Entity JOOENMAHIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x5E61A00", Offset = "0x5E60E00", VA = "0x185E61A00")]
	public bool HEBPNKMJKGE(Entity FILKDLNBIJH, Entity JOOENMAHIDL, bool PANNPBLEODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0x5E617C0", Offset = "0x5E60BC0", VA = "0x185E617C0")]
	private bool GHMKKBELPKK(Entity FILKDLNBIJH, Entity JOOENMAHIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public JCCLPJHONHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020E")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(IOIHIPDJPNE), new string[] { })]
internal sealed class IOIHIPDJPNE : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400065A")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400065B")]
	private EntityQuery KNKOLNCNJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400065C")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x5E616D0", Offset = "0x5E60AD0", VA = "0x185E616D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x5E61520", Offset = "0x5E60920", VA = "0x185E61520", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x5E61390", Offset = "0x5E60790", VA = "0x185E61390", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0x5E61620", Offset = "0x5E60A20", VA = "0x185E61620")]
	public bool MLAEFHBCNIM(Entity FILKDLNBIJH, Entity MGPFGPKIGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x5E613B0", Offset = "0x5E607B0", VA = "0x185E613B0")]
	public bool FLFPNBFPDPC(Entity FILKDLNBIJH, Entity DFAAINNDBBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A95")]
	[Cpp2IlInjected.Address(RVA = "0x5E61720", Offset = "0x5E60B20", VA = "0x185E61720")]
	public Entity NKAFPNBHAEE(Entity FILKDLNBIJH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x5E61340", Offset = "0x5E60740", VA = "0x185E61340")]
	public NativeArray<Entity> CBGNFIEJFNP()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A97")]
	[Cpp2IlInjected.Address(RVA = "0x5E61460", Offset = "0x5E60860", VA = "0x185E61460")]
	public bool GKMCHOHAPGM(Entity BGICHGONLEL, Entity AGPMPKBMMOB, [Out] Entity MAKPPJALCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public IOIHIPDJPNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020F")]
public static class CHGCHIKPKFB
{
	[Cpp2IlInjected.Token(Token = "0x400065D")]
	internal static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0x220B9B0", Offset = "0x220ADB0", VA = "0x18220B9B0")]
	public static void PICNJLOMOKL<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(FJPIIIPDBML NKEGKJEJLFE, OFMDLNJBPPF<Entity> IHPCGCBJCJP, [Out] JJHPOPGKCDK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> DKMMODJBAIF) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, OLCDGJMALOC where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, OLCDGJMALOC, IEquatable<TChildrenData>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x5E576E0", Offset = "0x5E56AE0", VA = "0x185E576E0")]
	public static bool DMEGPOLMDCG(FDLKIDLAABP AMJJOGJHMOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000210")]
public class JJHPOPGKCDK<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, OLCDGJMALOC where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, OLCDGJMALOC, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private readonly IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private readonly PJFEPPCEHDM<Entity> ANNDMLIIDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private readonly HLNOFBDJBEA HDCMKJCBMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	private readonly IELJJLAMLND EBFCMPBKGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private readonly EntityManager OKJDPAMBACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private readonly FGGFOCNBCHP EDJCLBAFIOG;

	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x3849C00", Offset = "0x3849000", VA = "0x183849C00")]
	public JJHPOPGKCDK(FJPIIIPDBML NKEGKJEJLFE, OFMDLNJBPPF<Entity> IHPCGCBJCJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0x3849A20", Offset = "0x3848E20", VA = "0x183849A20")]
	private bool PABNINGJCNP(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x3848320", Offset = "0x3847720", VA = "0x183848320")]
	private bool BMJFNLFLPAB(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x38492E0", Offset = "0x38486E0", VA = "0x1838492E0")]
	private bool LOBOPIBNFOE(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA0")]
	[Cpp2IlInjected.Address(RVA = "0x3849220", Offset = "0x3848620", VA = "0x183849220")]
	private bool JBOIPIEPBJJ(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA1")]
	[Cpp2IlInjected.Address(RVA = "0x38492A0", Offset = "0x38486A0", VA = "0x1838492A0")]
	public bool LJDLEFCDHAM(Entity FILKDLNBIJH, [In] Entity JOOENMAHIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA2")]
	[Cpp2IlInjected.Address(RVA = "0x38487C0", Offset = "0x3847BC0", VA = "0x1838487C0")]
	public bool EHDJBLDNAKJ(Entity FILKDLNBIJH, [In] Entity JOOENMAHIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0x3848800", Offset = "0x3847C00", VA = "0x183848800")]
	private bool EHDJBLDNAKJ(Entity FILKDLNBIJH, [In] Entity JOOENMAHIDL, bool FENPLCKDIAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void EGFBNKJPCHH(Entity FILKDLNBIJH, [In] Entity JOOENMAHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void OCNKLKGJBFI(Entity FILKDLNBIJH, [In] Entity JOOENMAHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void JNIHBOHEMNJ(Entity FILKDLNBIJH, [In] Entity JOOENMAHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void KPJIGEMONBG(Entity FILKDLNBIJH, [In] Entity JOOENMAHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void HEKHJDGPGPE(Entity FILKDLNBIJH, [In] Entity JOOENMAHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x38494D0", Offset = "0x38488D0", VA = "0x1838494D0")]
	private bool MLAEFHBCNIM(Entity FILKDLNBIJH, Entity MGPFGPKIGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x38480E0", Offset = "0x38474E0", VA = "0x1838480E0")]
	private void BAAEINCAHJJ(Entity FILKDLNBIJH, [In] Entity JGNFAOENAOD, [In] Entity JOOENMAHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x3848F80", Offset = "0x3848380", VA = "0x183848F80")]
	private void GMALAAIBFPN(Entity FILKDLNBIJH, [In] Entity JGNFAOENAOD, [In] Entity JOOENMAHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAC")]
	[Cpp2IlInjected.Address(RVA = "0x38497B0", Offset = "0x3848BB0", VA = "0x1838497B0")]
	private bool MNHNDEKEFHK(DGGBEDJKEHK BBGCLNBNLJA, [In] IJFILFNCAOA FCNKMGFFNGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x3847F60", Offset = "0x3847360", VA = "0x183847F60")]
	private void AEELOJHOFOJ(Entity EBFCMPBKGBM, Entity JHAODPLJNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x3848C80", Offset = "0x3848080", VA = "0x183848C80")]
	private void FFDAFIGKKAE(Entity EBFCMPBKGBM, Entity JHAODPLJNCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private void IFHFCHBPEGD(Entity FILKDLNBIJH, Entity JGNFAOENAOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private void ICCGIKNJDHC(Entity FILKDLNBIJH, Entity JOOENMAHIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000211")]
[PNAJALIKCOM(typeof(BCLKHHIKFMA), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
internal sealed class BCLKHHIKFMA : NPIGPPEOCFI, CNJKPBKICBD, JAKEGKENGGK, DFFDMFBJPHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000668")]
	[MFFAOKEGCNH]
	private KFJHDAOPGPA IHBAGGIDMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	[MFFAOKEGCNH]
	private NBIPELNFGHB MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400066A")]
	[MFFAOKEGCNH]
	private GAHOIFMALLF AMEPNDNNGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	[MFFAOKEGCNH]
	private ANNGIPPNCGN DBEEMFLKCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	[MFFAOKEGCNH]
	private DBCNAFKJFFO OKHJJKDIFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	[MFFAOKEGCNH]
	private CALJHDDCOOA KHJECHBHLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private readonly Dictionary<IJFILFNCAOA, PCCDMPNJHHD> FEIBDDDDAEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private readonly List<NetworkedTransformEntity> BKKAEADDJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	private IPPCPEBLPFB MHAKDAOGPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x5E53400", Offset = "0x5E52800", VA = "0x185E53400")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x1C20650", Offset = "0x1C1FA50", VA = "0x181C20650", Slot = "4")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x5E51CC0", Offset = "0x5E510C0", VA = "0x185E51CC0", Slot = "5")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x5E50840", Offset = "0x5E4FC40", VA = "0x185E50840")]
	public void CJBGFICPHMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x5E53130", Offset = "0x5E52530", VA = "0x185E53130", Slot = "6")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x5E50AE0", Offset = "0x5E4FEE0", VA = "0x185E50AE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x5E50AC0", Offset = "0x5E4FEC0", VA = "0x185E50AC0")]
	public int DMMBKDMFJCH(SceneTag PMDINEBDLOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0x5E524B0", Offset = "0x5E518B0", VA = "0x185E524B0")]
	public bool KLPKKBDFFDN(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x5E518D0", Offset = "0x5E50CD0", VA = "0x185E518D0")]
	public bool HEIAMNBIGPH(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0x5E50910", Offset = "0x5E4FD10", VA = "0x185E50910")]
	public bool DHIPACEFKGL(Entity FILKDLNBIJH, [Out] PCCDMPNJHHD PIOJMHPNEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x5E50980", Offset = "0x5E4FD80", VA = "0x185E50980")]
	private bool DHIPACEFKGL(Transform OLPLDGDFGHL, [Out] PCCDMPNJHHD PIOJMHPNEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x5E51C30", Offset = "0x5E51030", VA = "0x185E51C30")]
	private void IGHFGHAPNIA(Entity FILKDLNBIJH, PCCDMPNJHHD PIOJMHPNEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x5E52680", Offset = "0x5E51A80", VA = "0x185E52680")]
	private bool LCNEIFJMCKC(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x5E52290", Offset = "0x5E51690", VA = "0x185E52290")]
	public void KIPDOAILNDA(IJFILFNCAOA JNPKHIBFGKN, PCCDMPNJHHD FPKKJCBLEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x5E521B0", Offset = "0x5E515B0", VA = "0x185E521B0")]
	public void KIPDOAILNDA(LHNHNFAONOD PIBFDGEOBKF, PCCDMPNJHHD FPKKJCBLEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x5E511D0", Offset = "0x5E505D0", VA = "0x185E511D0")]
	public void GAMIJMMLFLB(IJFILFNCAOA[] OMNMPNPKGPB, GameObject IPAGFDLNMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x5E53560", Offset = "0x5E52960", VA = "0x185E53560")]
	public bool NJGJJAJFGDA(LHNHNFAONOD PIBFDGEOBKF, object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x5E53500", Offset = "0x5E52900", VA = "0x185E53500")]
	public bool NJGJJAJFGDA(Entity FILKDLNBIJH, [Optional] object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x5E534A0", Offset = "0x5E528A0", VA = "0x185E534A0")]
	public bool NJGJJAJFGDA(PCCDMPNJHHD AMJJOGJHMOB, object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x5E53D40", Offset = "0x5E53140", VA = "0x185E53D40")]
	public bool NOJOAOHGNKO(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x5E534D0", Offset = "0x5E528D0", VA = "0x185E534D0")]
	public bool NJGJJAJFGDA(PCCDMPNJHHD PIOJMHPNEKO, bool EFLODOEECNL, [Optional] object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x5E50CE0", Offset = "0x5E500E0", VA = "0x185E50CE0")]
	private bool FNNPOAOELIG(PCCDMPNJHHD PIOJMHPNEKO, object KJAGMGIFCEM, bool EFLODOEECNL, bool JONDAAKDGOK, bool MEJODNHDEEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x5E53210", Offset = "0x5E52610", VA = "0x185E53210")]
	public Transform MOMICKJJADN(Entity FILKDLNBIJH, [Optional] object KJAGMGIFCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x5E526A0", Offset = "0x5E51AA0", VA = "0x185E526A0")]
	public bool LFEOLBBNFPA(Entity FILKDLNBIJH, [Out] Transform OLPLDGDFGHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x5E518F0", Offset = "0x5E50CF0", VA = "0x185E518F0")]
	public PCCDMPNJHHD HFGJIPKOLGA(Entity FILKDLNBIJH, [Optional] object KJAGMGIFCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x5E54670", Offset = "0x5E53A70", VA = "0x185E54670")]
	public void OLBICFGJCNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x5E54290", Offset = "0x5E53690", VA = "0x185E54290")]
	public void OFBFOHPMDIB(SceneTag PMDINEBDLOA, bool JONDAAKDGOK, NativeParallelHashSet<int> OFGLFJPOBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x5E52770", Offset = "0x5E51B70", VA = "0x185E52770")]
	private void LLKCOEJMDKE(Entity FILKDLNBIJH, bool JONDAAKDGOK, bool MEJODNHDEEF, NativeParallelHashSet<int> OFGLFJPOBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x5E51840", Offset = "0x5E50C40", VA = "0x185E51840")]
	private bool GHLFCACBCML(PCCDMPNJHHD PIOJMHPNEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x5E52430", Offset = "0x5E51830", VA = "0x185E52430")]
	public bool KJDJBAPPIFP(Entity FILKDLNBIJH, object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x5E50890", Offset = "0x5E4FC90", VA = "0x185E50890")]
	public bool DCPFEBKPKND(Entity FILKDLNBIJH, object KJAGMGIFCEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x5E50210", Offset = "0x5E4F610", VA = "0x185E50210")]
	public bool APJDLGPFDCI(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x5E502F0", Offset = "0x5E4F6F0", VA = "0x185E502F0")]
	private void BCDDNBDCCCD(bool BEMKKOAIGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x5E50080", Offset = "0x5E4F480", VA = "0x185E50080")]
	private bool AHLPEIAAIHP(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0x5E53450", Offset = "0x5E52850", VA = "0x185E53450")]
	public PCCDMPNJHHD NGKOFJLACHA(Entity FILKDLNBIJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x5E50A20", Offset = "0x5E4FE20", VA = "0x185E50A20")]
	private PCCDMPNJHHD DIMABENDKHK(Entity FILKDLNBIJH, object KJAGMGIFCEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD6")]
	[Cpp2IlInjected.Address(RVA = "0x5E51590", Offset = "0x5E50990", VA = "0x185E51590")]
	private PCCDMPNJHHD GENALLNFFEL(Entity FILKDLNBIJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x5E51440", Offset = "0x5E50840", VA = "0x185E51440")]
	public void GBMAINNGDPM(NativeArray<IJFILFNCAOA> OMNMPNPKGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x5E51DF0", Offset = "0x5E511F0", VA = "0x185E51DF0")]
	private void JNHABFGHFFK(PCCDMPNJHHD FPKKJCBLEJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x5E51EC0", Offset = "0x5E512C0", VA = "0x185E51EC0")]
	private void JOPNKHKOIFO(PCCDMPNJHHD PIOJMHPNEKO, Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x5E53AD0", Offset = "0x5E52ED0", VA = "0x185E53AD0")]
	private void NJGLLILMOJN(Entity FILKDLNBIJH, PCCDMPNJHHD PIOJMHPNEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0x5E50C00", Offset = "0x5E50000", VA = "0x185E50C00")]
	private void FKGBDDOLNID(Entity FILKDLNBIJH, Transform OLPLDGDFGHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x5E503D0", Offset = "0x5E4F7D0", VA = "0x185E503D0")]
	private void CFHCADGGIEJ(IJFILFNCAOA JNPKHIBFGKN, NetworkedTransformEntity OFMADAPFCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x5E519E0", Offset = "0x5E50DE0", VA = "0x185E519E0")]
	private void HOFEAGAAABO(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x5E50BA0", Offset = "0x5E4FFA0", VA = "0x185E50BA0")]
	private List<NetworkedTransformEntity> EAPEJMMLBEN(GameObject IPAGFDLNMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0980", Offset = "0x5DDFD80", VA = "0x185DE0980")]
	private LHNHNFAONOD LKMLJIBHKIA(Entity FILKDLNBIJH)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x5E54A30", Offset = "0x5E53E30", VA = "0x185E54A30")]
	public BCLKHHIKFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x5E50140", Offset = "0x5E4F540", VA = "0x185E50140")]
	[CompilerGenerated]
	private void AILGPEJOOAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000213")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(EMLJAPIGCLK), new string[] { })]
internal sealed class EMLJAPIGCLK : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private BCLKHHIKFMA PIOJMHPNEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	private FDLCMFNJNIC BJJFBGICIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	[CompilerGenerated]
	private Action<NativeArray<IJFILFNCAOA>> JMEOJFAPBFN;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CFC0", Offset = "0x5E5C3C0", VA = "0x185E5CFC0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<NativeArray<IJFILFNCAOA>, NativeArray<JMFEOGDEHDH>> OJONBGPEBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CBE0", Offset = "0x5E5BFE0", VA = "0x185E5CBE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D3C0", Offset = "0x5E5C7C0", VA = "0x185E5D3C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<DLCLMIEPGBN> KNCMKLLAGJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C450", Offset = "0x5E5B850", VA = "0x185E5C450")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C5C0", Offset = "0x5E5B9C0", VA = "0x185E5C5C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C670", Offset = "0x5E5BA70", VA = "0x185E5C670", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x20211C0", Offset = "0x20205C0", VA = "0x1820211C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BEB0", Offset = "0x5E5B2B0", VA = "0x185E5BEB0")]
	public void CJFFPOFKONJ(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C570", Offset = "0x5E5B970", VA = "0x185E5C570")]
	public void FPHPOMALHFN(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C300", Offset = "0x5E5B700", VA = "0x185E5C300")]
	private bool EDNLHCMFLAB(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C500", Offset = "0x5E5B900", VA = "0x185E5C500")]
	public void FOEGEAAAFMJ(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C120", Offset = "0x5E5B520", VA = "0x185E5C120")]
	private bool ECMCPBJMBNB(Entity FILKDLNBIJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CA90", Offset = "0x5E5BE90", VA = "0x185E5CA90")]
	public void LEFNEIHNBJP(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C710", Offset = "0x5E5BB10", VA = "0x185E5C710")]
	private void JBOGODOHIDA(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BEF0", Offset = "0x5E5B2F0", VA = "0x185E5BEF0")]
	private void DNIPAMMAHHP(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF60", Offset = "0x5E5C360", VA = "0x185E5CF60")]
	private void NBBFMPFIIPE(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CC90", Offset = "0x5E5C090", VA = "0x185E5CC90")]
	private void MNKEHABHFDM(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D220", Offset = "0x5E5C620", VA = "0x185E5D220")]
	public void PBOCIMMBABF(NativeArray<IJFILFNCAOA> OMNMPNPKGPB, NativeArray<JMFEOGDEHDH> MKHHGJOGAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C900", Offset = "0x5E5BD00", VA = "0x185E5C900")]
	public void KMDDEABAOIP(NativeArray<IJFILFNCAOA> OMNMPNPKGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C770", Offset = "0x5E5BB70", VA = "0x185E5C770")]
	public void KEBPFBIJDNG(DLCLMIEPGBN KAJFFCPILBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private void AFCOLMPFJIK(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D010", Offset = "0x5E5C410", VA = "0x185E5D010")]
	private void NOHMGNGJDMP(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public EMLJAPIGCLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000215")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(AGHFOJHGCAN), new string[] { })]
internal class AGHFOJHGCAN : JGNBMNCOBBD, JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000217")]
	[CompilerGenerated]
	private sealed class LPAKLCAPAHN : IEnumerable<(AFADFPDANEE, JMFEOGDEHDH)>, IEnumerable, IEnumerator<(AFADFPDANEE, JMFEOGDEHDH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private (AFADFPDANEE primitiveType, JMFEOGDEHDH prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public AGHFOJHGCAN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		private (AFADFPDANEE, JMFEOGDEHDH) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x30E4090", Offset = "0x30E3490", VA = "0x1830E4090", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((AFADFPDANEE, JMFEOGDEHDH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B22")]
			[Cpp2IlInjected.Address(RVA = "0x5E65830", Offset = "0x5E64C30", VA = "0x185E65830", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x32C75A0", Offset = "0x32C69A0", VA = "0x1832C75A0")]
		[DebuggerHidden]
		public LPAKLCAPAHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x5E65630", Offset = "0x5E64A30", VA = "0x185E65630", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x5E657E0", Offset = "0x5E64BE0", VA = "0x185E657E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x5E65730", Offset = "0x5E64B30", VA = "0x185E65730", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(AFADFPDANEE, JMFEOGDEHDH)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x5E65730", Offset = "0x5E64B30", VA = "0x185E65730", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private World MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private NativeParallelHashMap<int, Entity> FELCGCIPFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private NativeParallelHashMap<int, EntityArchetype> INCKHDMMIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private NativeParallelHashMap<int, int> CFGKJIAJCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private JMFEOGDEHDH[] MKHHGJOGAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private readonly Dictionary<AFADFPDANEE, JMFEOGDEHDH> LPGCEPMBIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private readonly Dictionary<GHDMILHLBBK, JMFEOGDEHDH> NJLKPCDHEIE;

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x5E4D5B0", Offset = "0x5E4C9B0", VA = "0x185E4D5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x7610F0", Offset = "0x7604F0", VA = "0x1807610F0")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x1882870", Offset = "0x1881C70", VA = "0x181882870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E1B0", Offset = "0x5E4D5B0", VA = "0x185E4E1B0", Slot = "5")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D6D0", Offset = "0x5E4CAD0", VA = "0x185E4D6D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0xD62290", Offset = "0xD61690", VA = "0x180D62290")]
	internal NativeParallelHashMap<int, Entity> LNIKGJHCGLB()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0xD76A70", Offset = "0xD75E70", VA = "0x180D76A70")]
	internal NativeParallelHashMap<int, EntityArchetype> PNBAHCMBAGG()
	{
		return default(NativeParallelHashMap<int, EntityArchetype>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x89FA30", Offset = "0x89EE30", VA = "0x18089FA30")]
	internal NativeParallelHashMap<int, int> FILCMBDDJGO()
	{
		return default(NativeParallelHashMap<int, int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D5F0", Offset = "0x5E4C9F0", VA = "0x185E4D5F0")]
	internal IEnumerable<Type> CKIKJIEDFHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DB70", Offset = "0x5E4CF70", VA = "0x185E4DB70")]
	internal LOBOHAAJOKC EMOECCKNCMJ(Type IJFAMCPOKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F0E0", Offset = "0x5E4E4E0", VA = "0x185E4F0E0")]
	public EntityArchetype PKGGAMGNHOF(JMFEOGDEHDH INONPCNKMNK)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D650", Offset = "0x5E4CA50", VA = "0x185E4D650", Slot = "4")]
	[IteratorStateMachine(typeof(LPAKLCAPAHN))]
	public IEnumerable<(AFADFPDANEE, JMFEOGDEHDH)> DCEFFKHOMGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E090", Offset = "0x5E4D490", VA = "0x185E4E090")]
	public Entity IKFIBPFDHJJ(JMFEOGDEHDH INONPCNKMNK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DBE0", Offset = "0x5E4CFE0", VA = "0x185E4DBE0")]
	public void FKEGAMJNAMA(NativeArray<JMFEOGDEHDH> MKHHGJOGAOF, NativeArray<Entity> IFNMNBKELBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ED40", Offset = "0x5E4E140", VA = "0x185E4ED40")]
	public void KHBGDHAAFJL(JMFEOGDEHDH INONPCNKMNK, NativeArray<Entity> BAPHNAADJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F150", Offset = "0x5E4E550", VA = "0x185E4F150")]
	public JMFEOGDEHDH PKPJNJIAHBH(AFADFPDANEE IJFAMCPOKBO)
	{
		return default(JMFEOGDEHDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DA80", Offset = "0x5E4CE80", VA = "0x185E4DA80")]
	public Entity EAHKIOOPPMI(JMFEOGDEHDH INONPCNKMNK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DD90", Offset = "0x5E4D190", VA = "0x185E4DD90")]
	private void HHNDNKOIAHM(LOBOHAAJOKC NJNKJONLNDB, NativeList<int> MKHHGJOGAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EDD0", Offset = "0x5E4E1D0", VA = "0x185E4EDD0")]
	internal void MBCOBADMDFN(JMFEOGDEHDH INONPCNKMNK, ComponentTypeList NAKAOODNAGC, PPHIMCBHLLA MCMHLCHAMPF, LOBOHAAJOKC NJNKJONLNDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D420", Offset = "0x5E4C820", VA = "0x185E4D420")]
	private EntityArchetype BHAIGDGJJME(JMFEOGDEHDH INONPCNKMNK, ComponentTypeList MGFLEBFIMPH)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B17")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F240", Offset = "0x5E4E640", VA = "0x185E4F240")]
	public AGHFOJHGCAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000218")]
public enum AMLDKDEIAEE
{
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000219")]
internal interface IDIEGDCBKBG
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	World MGNDKLKJBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	World PPGDOEHNLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	GFMMGFNIFHD ALODBJAJEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	uint LGIAKPOCPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200021A")]
internal class FLJOIEPHCPE : CEEBBJKKAON, BLJODAPBPOA
{
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private readonly IDIEGDCBKBG GKJGPNDDLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly AMLDKDEIAEE ACCDAPFKBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private readonly World DMNCBDLCGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private readonly List<GBHIKEDMEJK> FGDMJIIKOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private NativeParallelMultiHashMap<Entity, HJLMBJKKHBB> AMGLEBACAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private NativeParallelHashMap<int, int> JLIICIGJJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private NativeArray<IJFILFNCAOA> FKNPDKLLGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private NativeArray<EIDGNLJLKDK> CHAFPPHFFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private NativeArray<IJFILFNCAOA> HODIBOAAEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private JobHandle POPIMOOODDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private JobHandle BPFMDFJAOLD;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private NativeParallelMultiHashMap<Entity, HJLMBJKKHBB> IBEBJPPDJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0xD76A70", Offset = "0xD75E70", VA = "0x180D76A70", Slot = "4")]
		get
		{
			return default(NativeParallelMultiHashMap<Entity, HJLMBJKKHBB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private uint AKKAGAAPLNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E570", Offset = "0x5E5D970", VA = "0x185E5E570", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool GPADEFAGBPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E370", Offset = "0x5E5D770", VA = "0x185E5E370", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private NativeArray<IJFILFNCAOA> JFGJNIJIEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x1A18E40", Offset = "0x1A18240", VA = "0x181A18E40", Slot = "10")]
		get
		{
			return default(NativeArray<IJFILFNCAOA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private NativeArray<EIDGNLJLKDK> OLAHLJIGICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0xEC43B0", Offset = "0xEC37B0", VA = "0x180EC43B0", Slot = "11")]
		get
		{
			return default(NativeArray<EIDGNLJLKDK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private NativeArray<IJFILFNCAOA> CIIJKPHEPAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x33E3B10", Offset = "0x33E2F10", VA = "0x1833E3B10", Slot = "12")]
		get
		{
			return default(NativeArray<IJFILFNCAOA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EC80", Offset = "0x5E5E080", VA = "0x185E5EC80")]
	public FLJOIEPHCPE(IDIEGDCBKBG GKJGPNDDLFN, AMLDKDEIAEE ACCDAPFKBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E380", Offset = "0x5E5D780", VA = "0x185E5E380", Slot = "6")]
	private bool EHOKLFAKIGO(NativeArray<IJFILFNCAOA> FKNPDKLLGNO, NativeArray<EIDGNLJLKDK> CHAFPPHFFEK, NativeArray<IJFILFNCAOA> HODIBOAAEHA, int LOFBAPCFPAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E7F0", Offset = "0x5E5DBF0", VA = "0x185E5E7F0", Slot = "7")]
	private void KHPMPBMLFFM([In] GBHIKEDMEJK NLADDKFNDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B30")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E1F0", Offset = "0x5E5D5F0", VA = "0x185E5E1F0", Slot = "8")]
	private void DFLBINPIIGC(JobHandle DELBIPHKFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B35")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E960", Offset = "0x5E5DD60", VA = "0x185E5E960", Slot = "13")]
	private bool KOBDGMFJNKN([Out] NativeArray<int> NEFEOLHPHOL, Allocator KIKFOGPECEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B36")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EA10", Offset = "0x5E5DE10", VA = "0x185E5EA10", Slot = "14")]
	private bool PBKKCBCAJMG(ComponentType HDDPJGDCFBD, [Out] GBHIKEDMEJK DJCDNPAPJCP, [Out] BOBCKFNACMM KLLMNJMAMGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DE20", Offset = "0x5E5D220", VA = "0x185E5DE20", Slot = "15")]
	private NativeMultiHashMapAsync<Entity, HJLMBJKKHBB> AADIALKLBJD()
	{
		return default(NativeMultiHashMapAsync<Entity, HJLMBJKKHBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B38")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DEA0", Offset = "0x5E5D2A0", VA = "0x185E5DEA0")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B39")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E5C0", Offset = "0x5E5D9C0", VA = "0x185E5E5C0")]
	private bool JEDNHPGEFGO()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200021B")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(AEMGHLGPJFG), new string[] { })]
internal class AEMGHLGPJFG : JAKEGKENGGK, DFFDMFBJPHA, IDIEGDCBKBG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200021C")]
	internal readonly struct EAPNMCMFADD : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private readonly AMLDKDEIAEE FMECNGANLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private readonly AEMGHLGPJFG PDMNBLCHBOO;

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A0D0", Offset = "0x5E594D0", VA = "0x185E5A0D0")]
		public EAPNMCMFADD(AEMGHLGPJFG PDMNBLCHBOO, AMLDKDEIAEE HFLEBJGMHCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A0B0", Offset = "0x5E594B0", VA = "0x185E5A0B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private static readonly FBKCBHAMJJJ JOPAEPHEOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	[MFFAOKEGCNH]
	private CCCMOPCHHIG JHCNLBAHAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	[MFFAOKEGCNH]
	private AGHFOJHGCAN HECNGKOMCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private readonly FLJOIEPHCPE[] PHPMEDAAFIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private GFMMGFNIFHD LOIKKDKOLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private NativeParallelHashMap<int, Entity> EELFLDCAMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private AMLDKDEIAEE BELKCGPHAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public World MGNDKLKJBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x5E4D060", Offset = "0x5E4C460", VA = "0x185E4D060", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public World PPGDOEHNLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x75F1E0", Offset = "0x75E5E0", VA = "0x18075F1E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x75F1F0", Offset = "0x75E5F0", VA = "0x18075F1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public GFMMGFNIFHD ALODBJAJEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x202C7D0", Offset = "0x202BBD0", VA = "0x18202C7D0", Slot = "8")]
		get
		{
			return default(GFMMGFNIFHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public uint LGIAKPOCPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0xD02A10", Offset = "0xD01E10", VA = "0x180D02A10", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0xD024E0", Offset = "0xD018E0", VA = "0x180D024E0", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private bool FNLIEAMIKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x9B2640", Offset = "0x9B1A40", VA = "0x1809B2640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0xCECCF0", Offset = "0xCEC0F0", VA = "0x180CECCF0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public NativeParallelHashMap<int, Entity> COAGKFHFCIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0xD47C10", Offset = "0xD47010", VA = "0x180D47C10")]
		get
		{
			return default(NativeParallelHashMap<int, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public BLJODAPBPOA MPFINIFIFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CB60", Offset = "0x5E4BF60", VA = "0x185E4CB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public CEEBBJKKAON NEGHLKDIDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x5E4CB60", Offset = "0x5E4BF60", VA = "0x185E4CB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public AMLDKDEIAEE JOMPAEIGONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x95E340", Offset = "0x95D740", VA = "0x18095E340")]
		get
		{
			return default(AMLDKDEIAEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B44")]
	[Cpp2IlInjected.Address(RVA = "0x1B8F3F0", Offset = "0x1B8E7F0", VA = "0x181B8F3F0")]
	public BLJODAPBPOA OIOMFNHAJGO(AMLDKDEIAEE ACCDAPFKBCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B45")]
	[Cpp2IlInjected.Address(RVA = "0x1B8F3F0", Offset = "0x1B8E7F0", VA = "0x181B8F3F0")]
	public CEEBBJKKAON OCEOFOMHBCJ(AMLDKDEIAEE ACCDAPFKBCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B49")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CA90", Offset = "0x5E4BE90", VA = "0x185E4CA90", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CB90", Offset = "0x5E4BF90", VA = "0x185E4CB90", Slot = "5")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CDE0", Offset = "0x5E4C1E0", VA = "0x185E4CDE0")]
	private NativeParallelHashMap<int, Entity> NCBGNDGILJD()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C9E0", Offset = "0x5E4BDE0", VA = "0x185E4C9E0")]
	public void FLFJCPCJBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C7D0", Offset = "0x5E4BBD0", VA = "0x185E4C7D0")]
	public void BPHEMFKLBDC(AMLDKDEIAEE ACCDAPFKBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C810", Offset = "0x5E4BC10", VA = "0x185E4C810")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C8D0", Offset = "0x5E4BCD0", VA = "0x185E4C8D0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CA30", Offset = "0x5E4BE30", VA = "0x185E4CA30")]
	public EAPNMCMFADD GNIIFHBFDFC(AMLDKDEIAEE ACCDAPFKBCP)
	{
		return default(EAPNMCMFADD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B51")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D170", Offset = "0x5E4C570", VA = "0x185E4D170")]
	public AEMGHLGPJFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021D")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(JKDKKFNOEFN), new string[] { })]
internal class JKDKKFNOEFN : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	public static readonly SceneTag IJIKHDNFDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	[MFFAOKEGCNH]
	private FMNCGEAPDKG KOKCIFCPGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	[MFFAOKEGCNH]
	private BCLKHHIKFMA PIOJMHPNEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	[MFFAOKEGCNH]
	private HLNOFBDJBEA CKJDONFMJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	[MFFAOKEGCNH]
	private BGHOIHDELID NKPGFJHAJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	[MFFAOKEGCNH]
	private JLOOOADOAFN CJJHIFNDDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private EntityQuery OKMGPAMLJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private EntityQuery KMDACLKJMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	private EntityQuery AJAIPDJAJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	private Entity CGOBAGKNJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public NativeArray<Entity> PBHBBBPEPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0xBE36B0", Offset = "0xBE2AB0", VA = "0x180BE36B0")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0xBE24A0", Offset = "0xBE18A0", VA = "0x180BE24A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public Entity LKIJJAFHGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x5E61F00", Offset = "0x5E61300", VA = "0x185E61F00")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public SceneTag KIGNNHANLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x5E62600", Offset = "0x5E61A00", VA = "0x185E62600")]
		get
		{
			return default(SceneTag);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Entity LAJKIPPIEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x5E62600", Offset = "0x5E61A00", VA = "0x185E62600")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x5E622D0", Offset = "0x5E616D0", VA = "0x185E622D0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x5E63390", Offset = "0x5E62790", VA = "0x185E63390")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5C")]
	[Cpp2IlInjected.Address(RVA = "0x5E62B40", Offset = "0x5E61F40", VA = "0x185E62B40", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5D")]
	[Cpp2IlInjected.Address(RVA = "0x5E621F0", Offset = "0x5E615F0", VA = "0x185E621F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5E")]
	[Cpp2IlInjected.Address(RVA = "0x5E633E0", Offset = "0x5E627E0", VA = "0x185E633E0")]
	public void NLKGCLMNMDN(Entity FILKDLNBIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5F")]
	[Cpp2IlInjected.Address(RVA = "0x5E62340", Offset = "0x5E61740", VA = "0x185E62340")]
	public NativeArray<Entity> EJFLKEPDEBO(Allocator KIKFOGPECEC = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B60")]
	[Cpp2IlInjected.Address(RVA = "0x5E62650", Offset = "0x5E61A50", VA = "0x185E62650")]
	public void GFLEENICFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B61")]
	[Cpp2IlInjected.Address(RVA = "0x5E62E70", Offset = "0x5E62270", VA = "0x185E62E70")]
	public void KAFDOICELPL(Entity PMDINEBDLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B62")]
	[Cpp2IlInjected.Address(RVA = "0x5E62DC0", Offset = "0x5E621C0", VA = "0x185E62DC0")]
	public Entity JGBLDMPLEDB(string LFAIHEECJFK = "")
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B63")]
	[Cpp2IlInjected.Address(RVA = "0x5E62010", Offset = "0x5E61410", VA = "0x185E62010")]
	public void DMIAOLINDLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B64")]
	[Cpp2IlInjected.Address(RVA = "0x5E63370", Offset = "0x5E62770", VA = "0x185E63370")]
	public void MIPJFFGFCDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B65")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	public void JHEJGCDFGDN(Entity PMDINEBDLOA, string LFAIHEECJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B66")]
	[Cpp2IlInjected.Address(RVA = "0x5E62370", Offset = "0x5E61770", VA = "0x185E62370")]
	public void EPKMDCCDNNH(Entity PMDINEBDLOA, bool DCPMNOJLLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B67")]
	[Cpp2IlInjected.Address(RVA = "0x5E626E0", Offset = "0x5E61AE0", VA = "0x185E626E0")]
	public void IAFKMJKFHEI(Entity FILKDLNBIJH, Entity PMDINEBDLOA, bool INGHHBAHPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B68")]
	[Cpp2IlInjected.Address(RVA = "0x5E62910", Offset = "0x5E61D10", VA = "0x185E62910")]
	public void IAFKMJKFHEI(NativeArray<Entity> BAPHNAADJCK, Entity PMDINEBDLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B69")]
	[Cpp2IlInjected.Address(RVA = "0x5E62030", Offset = "0x5E61430", VA = "0x185E62030")]
	private void DPPNAAADFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6A")]
	[Cpp2IlInjected.Address(RVA = "0x5E63340", Offset = "0x5E62740", VA = "0x185E63340")]
	private void MCGCFJHGFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6B")]
	[Cpp2IlInjected.Address(RVA = "0x5E61F00", Offset = "0x5E61300", VA = "0x185E61F00")]
	private Entity HPKBJGMGCDJ()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6C")]
	[Cpp2IlInjected.Address(RVA = "0x5E63260", Offset = "0x5E62660", VA = "0x185E63260")]
	private void MAMNHCECBEI(EntityQuery EJNODELIHOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6D")]
	[Cpp2IlInjected.Address(RVA = "0x5E62F90", Offset = "0x5E62390", VA = "0x185E62F90")]
	private void MAMNHCECBEI(NativeArray<Entity> EOJANGPGAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6E")]
	[Cpp2IlInjected.Address(RVA = "0x5E63420", Offset = "0x5E62820", VA = "0x185E63420")]
	private void OHDCKJAFEII(Entity PMDINEBDLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6F")]
	[Cpp2IlInjected.Address(RVA = "0x5E61E30", Offset = "0x5E61230", VA = "0x185E61E30")]
	private void ABMDGGCKPFI(Entity PMDINEBDLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B70")]
	[Cpp2IlInjected.Address(RVA = "0x5E62C40", Offset = "0x5E62040", VA = "0x185E62C40")]
	private void JECIBCNCONI(SceneTag JCBKBFJJMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B71")]
	[Cpp2IlInjected.Address(RVA = "0x5E626A0", Offset = "0x5E61AA0", VA = "0x185E626A0")]
	private void HDEBDELIKLA(SceneTag JCBKBFJJMNA, NativeParallelHashSet<int> OFGLFJPOBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B72")]
	[Cpp2IlInjected.Address(RVA = "0x5E624C0", Offset = "0x5E618C0", VA = "0x185E624C0")]
	private void FCJGCPNBEDE(SceneTag JCBKBFJJMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x5E62230", Offset = "0x5E61630", VA = "0x185E62230")]
	private void EAKDIBPJGME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B74")]
	[Cpp2IlInjected.Address(RVA = "0x23F4DA0", Offset = "0x23F41A0", VA = "0x1823F4DA0")]
	private void CDPPLMAGOHO<T>() where T : ComponentSystemBase
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B75")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public JKDKKFNOEFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021E")]
[CDHEJLILMFK(PIEFJKINJBJ.PhotonRoom)]
[PNAJALIKCOM(typeof(LGPKLAKDANM), new string[] { })]
internal class HBNEMECLBPK : JAKEGKENGGK, LGPKLAKDANM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	[MFFAOKEGCNH]
	private JKDKKFNOEFN EOJANGPGAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private readonly Dictionary<int, Entity> CMGLHAOCIDE;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FA80", Offset = "0x5E5EE80", VA = "0x185E5FA80")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B78")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F820", Offset = "0x5E5EC20", VA = "0x185E5F820", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B79")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FAD0", Offset = "0x5E5EED0", VA = "0x185E5FAD0", Slot = "5")]
	public void NLKGCLMNMDN(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F8B0", Offset = "0x5E5ECB0", VA = "0x185E5F8B0", Slot = "6")]
	public bool MKNJGCMLMKG(LHNHNFAONOD PIBFDGEOBKF, Transform OLPLDGDFGHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F7B0", Offset = "0x5E5EBB0", VA = "0x185E5F7B0")]
	private bool ELPCADGKDFG(Scene PMDINEBDLOA, [Out] Entity ICBJHGOLCOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FC20", Offset = "0x5E5F020", VA = "0x185E5FC20")]
	public HBNEMECLBPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021F")]
[PNAJALIKCOM(typeof(BGHOIHDELID), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
internal sealed class BGHOIHDELID : JAKEGKENGGK, DFFDMFBJPHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	[MFFAOKEGCNH]
	private HLNOFBDJBEA CKJDONFMJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private Entity FILKDLNBIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private ComponentTypeList MGFLEBFIMPH;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x5E565A0", Offset = "0x5E559A0", VA = "0x185E565A0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7E")]
	[Cpp2IlInjected.Address(RVA = "0x21A1F20", Offset = "0x21A1320", VA = "0x1821A1F20")]
	public T OPODPAEFLEB<T>() where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7F")]
	[Cpp2IlInjected.Address(RVA = "0x21A1BF0", Offset = "0x21A0FF0", VA = "0x1821A1BF0")]
	public void GMFKOPHMECD<T>(T EOHMJBFGDPD) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x21A1D10", Offset = "0x21A1110", VA = "0x1821A1D10")]
	public DynamicBuffer<T> MEGHMMOIPCA<T>(bool BGPIOJOGCKM = false) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x21A1A80", Offset = "0x21A0E80", VA = "0x1821A1A80")]
	public void BPEOBDOEOAM<T>(T EOHMJBFGDPD) where T : struct, IBufferElementData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x5E56530", Offset = "0x5E55930", VA = "0x185E56530", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x5E56240", Offset = "0x5E55640", VA = "0x185E56240", Slot = "5")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x5E56240", Offset = "0x5E55640", VA = "0x185E56240")]
	private void FANBCBCPJFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x5E55EE0", Offset = "0x5E552E0", VA = "0x185E55EE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x5E55AA0", Offset = "0x5E54EA0", VA = "0x185E55AA0")]
	private ComponentTypeList ANKFMIGGIPH()
	{
		return default(ComponentTypeList);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void NANFBFNNMDM(int OGEHFGGOGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0")]
	private static void ELFLOKAGFHN(Type IJFAMCPOKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B89")]
	[Cpp2IlInjected.Address(RVA = "0x5E56430", Offset = "0x5E55830", VA = "0x185E56430")]
	private static void IBEHFGFNOOF(Type IJFAMCPOKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8A")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public BGHOIHDELID()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000220")]
[JDEFKFOMDEI]
internal struct MJAHOECFGGB : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000221")]
[PNAJALIKCOM(typeof(DBCNAFKJFFO), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
internal sealed class DBCNAFKJFFO : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private static readonly FBKCBHAMJJJ IHFOIGHGJHO;

	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private static readonly FBKCBHAMJJJ HKHFKGJDOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private BJMIDNIMEPB<LPMBPIFGCLI, Entity> IAOHBBLHFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private HKALNAIIIGG<IFDEHHKIDKL> GLKEOEOKEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private HKALNAIIIGG<KDCGIBFNKBB> MJDIEJIJHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private HKALNAIIIGG<IDGPBEIGONP> ODDKKMACCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private HKALNAIIIGG<PLGBOHNANAM> DOEPDDBKKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private HKALNAIIIGG<LMGHCLGNFJA> AMEAOOFACPA;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public MLCMPGDAIKL<Entity> FJOLAOJPMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public LLFOCGGLBGJ GIBFCKDLNMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public LLFOCGGLBGJ CHGKCAPAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public LLFOCGGLBGJ BLCMNDHEFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public LLFOCGGLBGJ GHOKFMEIOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x75C7E0", Offset = "0x75BBE0", VA = "0x18075C7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public LLFOCGGLBGJ BMNFEOBEMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x764B70", Offset = "0x763F70", VA = "0x180764B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x5E70590", Offset = "0x5E6F990", VA = "0x185E70590")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x5E70350", Offset = "0x5E6F750", VA = "0x185E70350", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x5E70260", Offset = "0x5E6F660", VA = "0x185E70260", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x222D030", Offset = "0x222C430", VA = "0x18222D030")]
	private void PICNJLOMOKL<T>(HKALNAIIIGG<T> KNIIHNPOBPI, EntityCommandBufferSystem PAKMEGEOHCF, FBKCBHAMJJJ AMAPEJENOPH) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x222D0E0", Offset = "0x222C4E0", VA = "0x18222D0E0")]
	private void PICNJLOMOKL<TC, TV>(BJMIDNIMEPB<TC, TV> KNIIHNPOBPI) where TC : struct, MKCCIJEBDNJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B97")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public DBCNAFKJFFO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000222")]
public struct KDCGIBFNKBB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000223")]
public struct IFDEHHKIDKL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000224")]
public struct IDGPBEIGONP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000225")]
public struct PLGBOHNANAM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000226")]
public struct LMGHCLGNFJA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000227")]
[ExecuteAlways]
public class JDPGFADPEGL : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x76D100", Offset = "0x76C500", VA = "0x18076D100")]
	public JDPGFADPEGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000228")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(OJJMIPKEBBC), new string[] { })]
internal sealed class OJJMIPKEBBC : CNJKPBKICBD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private PFOOKIGEPDE GHMDEGHDGDF;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public PFOOKIGEPDE JEJIFOENEBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0x1C03DC0", Offset = "0x1C031C0", VA = "0x181C03DC0")]
		get
		{
			return default(PFOOKIGEPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C7D0", Offset = "0x5E7BBD0", VA = "0x185E7C7D0", Slot = "4")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C7C0", Offset = "0x5E7BBC0", VA = "0x185E7C7C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public OJJMIPKEBBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000229")]
[PNAJALIKCOM(typeof(CALJHDDCOOA), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
internal sealed class CALJHDDCOOA
{
	[Cpp2IlInjected.Token(Token = "0x200022A")]
	public enum AOMLPDPEDGK
	{
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		Gameplay,
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		ObjectModel
	}

	[Cpp2IlInjected.Token(Token = "0x200022B")]
	public struct LEKHLCNBLMN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private AOMLPDPEDGK PMHCBGPELAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private readonly CALJHDDCOOA EBFCMPBKGBM;

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x5E79E90", Offset = "0x5E79290", VA = "0x185E79E90")]
		public LEKHLCNBLMN(CALJHDDCOOA EBFCMPBKGBM, AOMLPDPEDGK ACCDAPFKBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x5E79E70", Offset = "0x5E79270", VA = "0x185E79E70", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	public AOMLPDPEDGK ACCDAPFKBCP;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public AOMLPDPEDGK JOMPAEIGONB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B9E")]
		[Cpp2IlInjected.Address(RVA = "0x75C180", Offset = "0x75B580", VA = "0x18075C180")]
		get
		{
			return default(AOMLPDPEDGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B9F")]
		[Cpp2IlInjected.Address(RVA = "0x766EA0", Offset = "0x7662A0", VA = "0x180766EA0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool HGPNJOGIAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA0")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B3E0", Offset = "0x4F3A7E0", VA = "0x184F3B3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x5E6FCB0", Offset = "0x5E6F0B0", VA = "0x185E6FCB0")]
	public LEKHLCNBLMN NIDGKMPBEBL()
	{
		return default(LEKHLCNBLMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA2")]
	[Cpp2IlInjected.Address(RVA = "0x5E6FC60", Offset = "0x5E6F060", VA = "0x185E6FC60")]
	public LEKHLCNBLMN BDCNCMOMMPD()
	{
		return default(LEKHLCNBLMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA3")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CALJHDDCOOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022C")]
[PNAJALIKCOM(typeof(PAFDHAFMDMH), new string[] { })]
internal class GMGBILOPGKF : PAFDHAFMDMH, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	[MFFAOKEGCNH]
	private OAIGFOPCPFO DGFAJNPJEAA;

	[Cpp2IlInjected.Token(Token = "0x6000BA7")]
	[Cpp2IlInjected.Address(RVA = "0x5E742C0", Offset = "0x5E736C0", VA = "0x185E742C0", Slot = "8")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA8")]
	[Cpp2IlInjected.Address(RVA = "0x5E74310", Offset = "0x5E73710", VA = "0x185E74310", Slot = "4")]
	public World KJGAPLCOJCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA9")]
	[Cpp2IlInjected.Address(RVA = "0x5E74190", Offset = "0x5E73590", VA = "0x185E74190", Slot = "5")]
	public World FCENIBILJDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAA")]
	[Cpp2IlInjected.Address(RVA = "0x5E74420", Offset = "0x5E73820", VA = "0x185E74420", Slot = "6")]
	public World OCGEILIGGLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAB")]
	[Cpp2IlInjected.Address(RVA = "0x5E740F0", Offset = "0x5E734F0", VA = "0x185E740F0", Slot = "7")]
	public World BMLNGCNPPJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAC")]
	[Cpp2IlInjected.Address(RVA = "0x5E74230", Offset = "0x5E73630", VA = "0x185E74230")]
	private World FNPJBHNNAPE(string LFAIHEECJFK, LLFIBOALHBA JGMEFAHDHAJ, Type PFDEPHGNBPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAD")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GMGBILOPGKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022D")]
[PNAJALIKCOM(typeof(KCGPOJECAHP), new string[] { })]
public class OCBCMDBHNPG : JAKEGKENGGK, KCGPOJECAHP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200022E")]
	[CompilerGenerated]
	private struct APDJDKOOOGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public LHNHNFAONOD parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public OCBCMDBHNPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public JOIHKMPAGFE objBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private FDLKIDLAABP <parentObject>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private Vector3 <pos>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private Quaternion <rot>5__4;

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F240", Offset = "0x5E6E640", VA = "0x185E6F240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F780", Offset = "0x5E6EB80", VA = "0x185E6F780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200022F")]
	[CompilerGenerated]
	private struct GFEILGJPJJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public OCBCMDBHNPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public FDLKIDLAABP obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x5E73BA0", Offset = "0x5E72FA0", VA = "0x185E73BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x5E74090", Offset = "0x5E73490", VA = "0x185E74090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private Dictionary<LHNHNFAONOD, Task> GDBOFPHFPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	[MFFAOKEGCNH]
	private MMONOMOIAFI LFANGALDMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private EntityManager OKJDPAMBACM;

	[Cpp2IlInjected.Token(Token = "0x6000BAE")]
	[Cpp2IlInjected.Address(RVA = "0x5E7BD70", Offset = "0x5E7B170", VA = "0x185E7BD70", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAF")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B2E0", Offset = "0x5E7A6E0", VA = "0x185E7B2E0", Slot = "5")]
	public bool BLKAPNOLDPL(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB0")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C020", Offset = "0x5E7B420", VA = "0x185E7C020", Slot = "7")]
	public bool LFMJNBOLLJF(LHNHNFAONOD PIBFDGEOBKF, [Out] Guid PDHLDIFODOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB1")]
	[Cpp2IlInjected.Address(RVA = "0x5E7BF60", Offset = "0x5E7B360", VA = "0x185E7BF60", Slot = "8")]
	public Guid KBJIENCFAFN(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB2")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B3A0", Offset = "0x5E7A7A0", VA = "0x185E7B3A0", Slot = "9")]
	public void BOBKCCPBOGP(LHNHNFAONOD PIBFDGEOBKF, Guid PDHLDIFODOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB3")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C170", Offset = "0x5E7B570", VA = "0x185E7C170", Slot = "10")]
	public bool OBCEOACDMOI(LHNHNFAONOD PIBFDGEOBKF, [Out] Guid EKIGMNBCJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB4")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B680", Offset = "0x5E7AA80", VA = "0x185E7B680", Slot = "11")]
	public Guid DEDMACFGKJK(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB5")]
	[Cpp2IlInjected.Address(RVA = "0x5E7BB90", Offset = "0x5E7AF90", VA = "0x185E7BB90", Slot = "12")]
	public void HGMECABFBME(LHNHNFAONOD PIBFDGEOBKF, Guid EKIGMNBCJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB6")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C0E0", Offset = "0x5E7B4E0", VA = "0x185E7C0E0", Slot = "13")]
	public void NFMBMIJNPEP(LHNHNFAONOD PIBFDGEOBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB7")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B820", Offset = "0x5E7AC20", VA = "0x185E7B820", Slot = "14")]
	public void HEIJOJEDKOM(LHNHNFAONOD BGICHGONLEL, LHNHNFAONOD EBFCMPBKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB8")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B1D0", Offset = "0x5E7A5D0", VA = "0x185E7B1D0")]
	[AsyncStateMachine(typeof(APDJDKOOOGG))]
	private Task BHHJFGDDILI(JOIHKMPAGFE LNNPIOLDMDP, LHNHNFAONOD EBFCMPBKGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB9")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AFB0", Offset = "0x5E7A3B0", VA = "0x185E7AFB0")]
	private void AGOELDFEKKA(JOIHKMPAGFE LNNPIOLDMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B740", Offset = "0x5E7AB40", VA = "0x185E7B740")]
	[AsyncStateMachine(typeof(GFEILGJPJJJ))]
	private Task GELBDMFPHFF(FDLKIDLAABP BAFDGKKJJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7BE10", Offset = "0x5E7B210", VA = "0x185E7BE10")]
	private Task JOODGCHELLD(FDLKIDLAABP BAFDGKKJJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBC")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B580", Offset = "0x5E7A980", VA = "0x185E7B580")]
	private Task CBEGIKNLJLH(FDLKIDLAABP BAFDGKKJJJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBD")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B150", Offset = "0x5E7A550", VA = "0x185E7B150", Slot = "6")]
	public bool BCPAMGCFCJA(LHNHNFAONOD GIPGBEGNLCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBE")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C2C0", Offset = "0x5E7B6C0", VA = "0x185E7C2C0")]
	public OCBCMDBHNPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000230")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[PNAJALIKCOM(typeof(OJEEDKGDBMC), new string[] { })]
public class OJEEDKGDBMC : JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006ED")]
	[MFFAOKEGCNH]
	private CCCMOPCHHIG JHCNLBAHAJP;

	[Cpp2IlInjected.Token(Token = "0x6000BC4")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C560", Offset = "0x5E7B960", VA = "0x185E7C560", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC5")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public OJEEDKGDBMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000231")]
[PNAJALIKCOM(typeof(EMJEIPEMFBH), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
internal sealed class EMJEIPEMFBH : JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x40006EE")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F0")]
	[MFFAOKEGCNH]
	private FIHBIOAKNCJ LLHHEJCFHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	[MFFAOKEGCNH]
	private GKBJNBMEBDC MFFGHPJGDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	[MFFAOKEGCNH]
	private IKGEFLGAOAF LGNEBDMIJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	[MFFAOKEGCNH]
	private AGHFOJHGCAN HECNGKOMCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	[MFFAOKEGCNH]
	private OFECGAAIEIG MHJPOIKODDL;

	[Cpp2IlInjected.Token(Token = "0x6000BC6")]
	[Cpp2IlInjected.Address(RVA = "0x5E72270", Offset = "0x5E71670", VA = "0x185E72270", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC7")]
	[Cpp2IlInjected.Address(RVA = "0x5E725F0", Offset = "0x5E719F0", VA = "0x185E725F0")]
	public void NCFPNPLAFKO(NativeArray<JMFEOGDEHDH> MKHHGJOGAOF, NativeArray<IJFILFNCAOA> OMNMPNPKGPB, NativeArray<Entity> IFNMNBKELBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC8")]
	[Cpp2IlInjected.Address(RVA = "0x5E72740", Offset = "0x5E71B40", VA = "0x185E72740")]
	public Entity NCFPNPLAFKO(JMFEOGDEHDH INONPCNKMNK, IJFILFNCAOA JNPKHIBFGKN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC9")]
	[Cpp2IlInjected.Address(RVA = "0x5E724D0", Offset = "0x5E718D0", VA = "0x185E724D0")]
	public Entity KKPKACBLAKD(JMFEOGDEHDH INONPCNKMNK, bool IABBDCHOAPD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCA")]
	[Cpp2IlInjected.Address(RVA = "0x5E72360", Offset = "0x5E71760", VA = "0x185E72360")]
	public Entity KKPKACBLAKD(JMFEOGDEHDH INONPCNKMNK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCB")]
	[Cpp2IlInjected.Address(RVA = "0x5E721D0", Offset = "0x5E715D0", VA = "0x185E721D0")]
	public Entity IGCCOCINEHG()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCC")]
	[Cpp2IlInjected.Address(RVA = "0x5E72750", Offset = "0x5E71B50", VA = "0x185E72750")]
	public Entity NGFJKKMDBAC(AFADFPDANEE IJFAMCPOKBO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCD")]
	[Cpp2IlInjected.Address(RVA = "0x5E72210", Offset = "0x5E71610", VA = "0x185E72210")]
	public DLCLMIEPGBN IKFIBPFDHJJ(DLCLMIEPGBN FGKMGJALCKJ, Allocator KIKFOGPECEC)
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCE")]
	[Cpp2IlInjected.Address(RVA = "0x5E727A0", Offset = "0x5E71BA0", VA = "0x185E727A0")]
	public EntityArchetype PKGGAMGNHOF(JMFEOGDEHDH INONPCNKMNK)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCF")]
	[Cpp2IlInjected.Address(RVA = "0x5E72060", Offset = "0x5E71460", VA = "0x185E72060")]
	public Entity BFGFKICLJCL(JMFEOGDEHDH INONPCNKMNK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD0")]
	[Cpp2IlInjected.Address(RVA = "0x5E724D0", Offset = "0x5E718D0", VA = "0x185E724D0")]
	private Entity JBCBPGPDBIC(JMFEOGDEHDH INONPCNKMNK, bool IABBDCHOAPD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD1")]
	[Cpp2IlInjected.Address(RVA = "0x5E72360", Offset = "0x5E71760", VA = "0x185E72360")]
	private Entity JBCBPGPDBIC(JMFEOGDEHDH INONPCNKMNK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD2")]
	[Cpp2IlInjected.Address(RVA = "0x5E723A0", Offset = "0x5E717A0", VA = "0x185E723A0")]
	private Entity JBCBPGPDBIC(JMFEOGDEHDH INONPCNKMNK, IJFILFNCAOA JNPKHIBFGKN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD3")]
	[Cpp2IlInjected.Address(RVA = "0x5E72520", Offset = "0x5E71920", VA = "0x185E72520")]
	private void KHBGDHAAFJL(JMFEOGDEHDH INONPCNKMNK, NativeArray<IJFILFNCAOA> OMNMPNPKGPB, NativeArray<Entity> IFNMNBKELBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD4")]
	[Cpp2IlInjected.Address(RVA = "0x5E72080", Offset = "0x5E71480", VA = "0x185E72080")]
	private void FKEGAMJNAMA(NativeArray<JMFEOGDEHDH> MKHHGJOGAOF, NativeArray<IJFILFNCAOA> OMNMPNPKGPB, NativeArray<Entity> IFNMNBKELBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD5")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public EMJEIPEMFBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000232")]
[PNAJALIKCOM(typeof(IKGEFLGAOAF), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
internal sealed class IKGEFLGAOAF : JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	public static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	[MFFAOKEGCNH]
	private IMHPKNCJCOD HBALCJECAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	[MFFAOKEGCNH]
	private FIHBIOAKNCJ DMJIPAJCDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	[MFFAOKEGCNH]
	private GKBJNBMEBDC JOILCEEMNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006F9")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006FA")]
	private NativeParallelHashMap<IJFILFNCAOA, Entity> BHMMCPAHJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006FB")]
	private EntityManager OKJDPAMBACM;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	internal NativeParallelHashMap<IJFILFNCAOA, Entity> KNKIGMALCKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0xD76A70", Offset = "0xD75E70", VA = "0x180D76A70")]
		get
		{
			return default(NativeParallelHashMap<IJFILFNCAOA, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	internal uint PGDFAOPNIEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x5E75640", Offset = "0x5E74A40", VA = "0x185E75640")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x8432A0", Offset = "0x8426A0", VA = "0x1808432A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDA")]
	[Cpp2IlInjected.Address(RVA = "0x5E75520", Offset = "0x5E74920", VA = "0x185E75520", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDB")]
	[Cpp2IlInjected.Address(RVA = "0x5E75140", Offset = "0x5E74540", VA = "0x185E75140", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDC")]
	[Cpp2IlInjected.Address(RVA = "0x5E74F00", Offset = "0x5E74300", VA = "0x185E74F00")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDD")]
	[Cpp2IlInjected.Address(RVA = "0x5E751B0", Offset = "0x5E745B0", VA = "0x185E751B0")]
	public IJFILFNCAOA ELIIHBGBBMG(int OGEHFGGOGMJ)
	{
		return default(IJFILFNCAOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDE")]
	[Cpp2IlInjected.Address(RVA = "0x5E74F80", Offset = "0x5E74380", VA = "0x185E74F80")]
	public void CAJEINFFNBM(IJFILFNCAOA JNPKHIBFGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDF")]
	[Cpp2IlInjected.Address(RVA = "0x5E758E0", Offset = "0x5E74CE0", VA = "0x185E758E0")]
	public LHNHNFAONOD OLOICJPHOFL(IJFILFNCAOA JNPKHIBFGKN)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE0")]
	[Cpp2IlInjected.Address(RVA = "0x5E75670", Offset = "0x5E74A70", VA = "0x185E75670")]
	public bool KJMILBLALPL(IJFILFNCAOA JNPKHIBFGKN, [Out] LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE1")]
	[Cpp2IlInjected.Address(RVA = "0x5E757B0", Offset = "0x5E74BB0", VA = "0x185E757B0")]
	public DLCLMIEPGBN OLOICJPHOFL(NativeArray<IJFILFNCAOA> JNPKHIBFGKN, Allocator KIKFOGPECEC)
	{
		return default(DLCLMIEPGBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE2")]
	[Cpp2IlInjected.Address(RVA = "0x5E75310", Offset = "0x5E74710", VA = "0x185E75310")]
	public IJFILFNCAOA GEMBKIKECJJ(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(IJFILFNCAOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE3")]
	[Cpp2IlInjected.Address(RVA = "0x5E75280", Offset = "0x5E74680", VA = "0x185E75280")]
	public IJFILFNCAOA GEMBKIKECJJ(Entity FILKDLNBIJH)
	{
		return default(IJFILFNCAOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE4")]
	[Cpp2IlInjected.Address(RVA = "0x5E753C0", Offset = "0x5E747C0", VA = "0x185E753C0")]
	public void GPPHDFCMNCB(NativeArray<Entity> BAPHNAADJCK, NativeArray<IJFILFNCAOA> OMNMPNPKGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE5")]
	[Cpp2IlInjected.Address(RVA = "0x5E75770", Offset = "0x5E74B70", VA = "0x185E75770")]
	private LHNHNFAONOD LKMLJIBHKIA(Entity FILKDLNBIJH)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE6")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public IKGEFLGAOAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000233")]
[PNAJALIKCOM(typeof(FGAHOPPNDBO), new string[] { })]
public sealed class GCPJJHBOOKK : FGAHOPPNDBO, PCIIECOCADI, CNJKPBKICBD, JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	[MFFAOKEGCNH]
	private GAHOIFMALLF AMEPNDNNGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006FF")]
	private Collider[] AMJGNGHLELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000700")]
	private RaycastHit[] NNEAJHKFKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	private OIFHGLGDACC<LAPKFFFPOAD, BoxCollider> AABKFNFAIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	private Scene PMDINEBDLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	private PhysicsScene OAHJHMDNFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000704")]
	private GameObject FOHPGKLHLGD;

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x5E72DA0", Offset = "0x5E721A0", VA = "0x185E72DA0", Slot = "9")]
	public void IFHFAFGBMJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x5E72F00", Offset = "0x5E72300", VA = "0x185E72F00", Slot = "10")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x5E72BD0", Offset = "0x5E71FD0", VA = "0x185E72BD0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x5E739D0", Offset = "0x5E72DD0", VA = "0x185E739D0", Slot = "4")]
	public LAPKFFFPOAD PLNAIKEGLDI(Entity FILKDLNBIJH)
	{
		return default(LAPKFFFPOAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEC")]
	[Cpp2IlInjected.Address(RVA = "0x5E728F0", Offset = "0x5E71CF0", VA = "0x185E728F0", Slot = "5")]
	public void BEEJDJFKAKD(NativeArray<LAPKFFFPOAD> AGMEADBOBGM, NativeArray<CMLIFCOKLLM> OFKFPFOEFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x5E72CE0", Offset = "0x5E720E0", VA = "0x185E72CE0", Slot = "6")]
	public void EHAJAAOIMIF(LAPKFFFPOAD DELBIPHKFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x5E734B0", Offset = "0x5E728B0", VA = "0x185E734B0", Slot = "7")]
	public bool MMLJKBBAMCB(LAPKFFFPOAD DELBIPHKFDD, [Out] Collider LIMGOFLBOKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x5E736F0", Offset = "0x5E72AF0", VA = "0x185E736F0")]
	public bool NNJLPEJLDHA([In] float3 HJGLLCKAOEB, [In] float3 PIOPMIBANBL, float EJKOOCGEPCD, Allocator KIKFOGPECEC, [Out] NativeArray<Entity> BAPHNAADJCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF0")]
	[Cpp2IlInjected.Address(RVA = "0x5E736A0", Offset = "0x5E72AA0", VA = "0x185E736A0")]
	private void NFKIMPHAHGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF1")]
	[Cpp2IlInjected.Address(RVA = "0x86DE10", Offset = "0x86D210", VA = "0x18086DE10")]
	private void PLOCOLJMCLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF2")]
	[Cpp2IlInjected.Address(RVA = "0x5E72B50", Offset = "0x5E71F50", VA = "0x185E72B50")]
	private void BILNBCKMNHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF3")]
	[Cpp2IlInjected.Address(RVA = "0x59A5880", Offset = "0x59A4C80", VA = "0x1859A5880")]
	private void GMJDFPJMIHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF4")]
	[Cpp2IlInjected.Address(RVA = "0x5E73550", Offset = "0x5E72950", VA = "0x185E73550")]
	private BoxCollider MPHLJJLMEOO(Entity FILKDLNBIJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF5")]
	[Cpp2IlInjected.Address(RVA = "0x5E72870", Offset = "0x5E71C70", VA = "0x185E72870")]
	private void BBIAFCGJMEM(BoxCollider LKILGJOBAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF6")]
	[Cpp2IlInjected.Address(RVA = "0x5E72FE0", Offset = "0x5E723E0", VA = "0x185E72FE0")]
	private void KHAMKPLLHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF7")]
	[Cpp2IlInjected.Address(RVA = "0x5E733B0", Offset = "0x5E727B0", VA = "0x185E733B0")]
	private void MFPPIAOIHGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF8")]
	[Cpp2IlInjected.Address(RVA = "0x5E73190", Offset = "0x5E72590", VA = "0x185E73190")]
	private void LIANLJEMLHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF9")]
	[Cpp2IlInjected.Address(RVA = "0x5E72BA0", Offset = "0x5E71FA0", VA = "0x185E72BA0")]
	private void CKOFJGODEHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFA")]
	[Cpp2IlInjected.Address(RVA = "0x5E733A0", Offset = "0x5E727A0", VA = "0x185E733A0")]
	private void MEGLEPKPLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFB")]
	[Cpp2IlInjected.Address(RVA = "0x5E73660", Offset = "0x5E72A60", VA = "0x185E73660")]
	private void NFJMLFGDHGL(Scene MDJNHLEFMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFC")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GCPJJHBOOKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFE")]
	[Cpp2IlInjected.Address(RVA = "0x5E72FD0", Offset = "0x5E723D0", VA = "0x185E72FD0", Slot = "8")]
	private bool KCBCFAOLHEI([In] float3 HJGLLCKAOEB, [In] float3 PIOPMIBANBL, float EJKOOCGEPCD, Allocator KIKFOGPECEC, [Out] NativeArray<Entity> BAPHNAADJCK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000234")]
[CDHEJLILMFK(PIEFJKINJBJ.OMRoom)]
[OPLOBPDEFMG(typeof(AHAAPFOIKPK))]
[PNAJALIKCOM(typeof(LGIBJLNADBL), new string[] { })]
internal class LGIBJLNADBL : JAKEGKENGGK, AHAAPFOIKPK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000705")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000707")]
	[MFFAOKEGCNH]
	private LCMBOOHOIHL IIPKIJNFEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000708")]
	private LKEFCEFOADP GFKONGFLEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private NativeList<byte> GHFAAPNAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	private NativeList<OCNDOGNDAKK> OIBLIDEECJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400070B")]
	private NativeList<HAJJCCPKKFD> MCBAGIPHEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400070C")]
	private int IHLABHLLBID;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<OCNDOGNDAKK, NativeArray<byte>> DJEEIOOMPCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A2B0", Offset = "0x5E796B0", VA = "0x185E7A2B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A360", Offset = "0x5E79760", VA = "0x185E7A360")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A180", Offset = "0x5E79580", VA = "0x185E7A180", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A100", Offset = "0x5E79500", VA = "0x185E7A100", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x5E79EE0", Offset = "0x5E792E0", VA = "0x185E79EE0", Slot = "5")]
	public void ABLLGMLPLDH(OCNDOGNDAKK OAGNBNMPALP, ReadOnlySpan<byte> HEFGEKEDAKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A080", Offset = "0x5E79480", VA = "0x185E7A080")]
	public void BPHEMFKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C05")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LGIBJLNADBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000235")]
[PNAJALIKCOM(typeof(FINDIDOCBAK), new string[] { })]
internal class KADILEALKKH : FINDIDOCBAK, JAKEGKENGGK, DFFDMFBJPHA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000236")]
	[CompilerGenerated]
	private sealed class JOBCBPMMHKE : IEnumerable<LHNHNFAONOD>, IEnumerable, IEnumerator<LHNHNFAONOD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		private LHNHNFAONOD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public KADILEALKKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		private LHNHNFAONOD localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public LHNHNFAONOD <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private NativeArray<Entity> <childEntitiesCopy>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private NativeArray<Entity>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		private LHNHNFAONOD System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x30E4090", Offset = "0x30E3490", VA = "0x1830E4090", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LHNHNFAONOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x5E77C40", Offset = "0x5E77040", VA = "0x185E77C40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x32C75A0", Offset = "0x32C69A0", VA = "0x1832C75A0")]
		[DebuggerHidden]
		public JOBCBPMMHKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x5E77C90", Offset = "0x5E77090", VA = "0x185E77C90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x5E777B0", Offset = "0x5E76BB0", VA = "0x185E777B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x5E77760", Offset = "0x5E76B60", VA = "0x185E77760")]
		private void GIBBEMGHDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x5E77710", Offset = "0x5E76B10", VA = "0x185E77710")]
		private void CLLKEDEGMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x5E77BF0", Offset = "0x5E76FF0", VA = "0x185E77BF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0x5E77B40", Offset = "0x5E76F40", VA = "0x185E77B40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LHNHNFAONOD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0x5E77B40", Offset = "0x5E76F40", VA = "0x185E77B40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400070D")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.Token(Token = "0x400070E")]
	private static readonly FBKCBHAMJJJ DCGEKAPLLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000713")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000714")]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	private JKPJPBADHMP MKNFLEECOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private JBLOAMOKHEB NHOMKCPDCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private PJFEPPCEHDM<Entity> MLMKBNGBJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	private PJFEPPCEHDM<float3> IKIEBEECJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private PJFEPPCEHDM<quaternion> LGOMJBFIOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private PJFEPPCEHDM<float> NKCCONBEDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private HashSet<Entity> LELLEPMCEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400071C")]
	private HashSet<Entity> INAIEJLNMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	private EntityQuery KNKOLNCNJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	private bool EJHKEMCAIJC;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<LHNHNFAONOD, LHNHNFAONOD> KOMJCMDLJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x5E79A10", Offset = "0x5E78E10", VA = "0x185E79A10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x5E789C0", Offset = "0x5E77DC0", VA = "0x185E789C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<LHNHNFAONOD, LHNHNFAONOD> KAKPMHHCILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000C09")]
		[Cpp2IlInjected.Address(RVA = "0x5E78A70", Offset = "0x5E77E70", VA = "0x185E78A70", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(RVA = "0x5E78470", Offset = "0x5E77870", VA = "0x185E78470", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<LHNHNFAONOD, LHNHNFAONOD, LHNHNFAONOD> CAKBDKPBFAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(RVA = "0x5E785C0", Offset = "0x5E779C0", VA = "0x185E785C0", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C0C")]
		[Cpp2IlInjected.Address(RVA = "0x5E78D90", Offset = "0x5E78190", VA = "0x185E78D90", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<LHNHNFAONOD> DIBLOCNAECE
	{
		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x5E77F40", Offset = "0x5E77340", VA = "0x185E77F40", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x5E78E40", Offset = "0x5E78240", VA = "0x185E78E40", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0F")]
	[Cpp2IlInjected.Address(RVA = "0x5E79070", Offset = "0x5E78470", VA = "0x185E79070", Slot = "22")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C10")]
	[Cpp2IlInjected.Address(RVA = "0x5E79530", Offset = "0x5E78930", VA = "0x185E79530", Slot = "23")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C11")]
	[Cpp2IlInjected.Address(RVA = "0x5E78670", Offset = "0x5E77A70", VA = "0x185E78670", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C12")]
	[Cpp2IlInjected.Address(RVA = "0x5E79270", Offset = "0x5E78670", VA = "0x185E79270")]
	private void LDFNFAHBJCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C13")]
	[Cpp2IlInjected.Address(RVA = "0x5E78EF0", Offset = "0x5E782F0", VA = "0x185E78EF0")]
	private void IDJKDPCLKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C14")]
	[Cpp2IlInjected.Address(RVA = "0x5E77FF0", Offset = "0x5E773F0", VA = "0x185E77FF0")]
	private void BDIEGDMMMPP(EOHKGDILIIA GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C15")]
	[Cpp2IlInjected.Address(RVA = "0x5E79B40", Offset = "0x5E78F40", VA = "0x185E79B40")]
	private void OGOODOJMACH(EOHKGDILIIA GHFAAPNAFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C16")]
	[Cpp2IlInjected.Address(RVA = "0x5E791D0", Offset = "0x5E785D0", VA = "0x185E791D0", Slot = "12")]
	public bool JHGDDIBIACA(LHNHNFAONOD PIBFDGEOBKF, LHNHNFAONOD KBPCHFHDIBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C17")]
	[Cpp2IlInjected.Address(RVA = "0x5E78520", Offset = "0x5E77920", VA = "0x185E78520", Slot = "13")]
	public LHNHNFAONOD DHLPIOCFDEA(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C18")]
	[Cpp2IlInjected.Address(RVA = "0x5E78BB0", Offset = "0x5E77FB0", VA = "0x185E78BB0", Slot = "16")]
	public void GNLGFEENMGJ(LHNHNFAONOD PIBFDGEOBKF, Vector3 KCJMDKMCCLM, Quaternion NIFBONPNAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C19")]
	[Cpp2IlInjected.Address(RVA = "0x5E79AC0", Offset = "0x5E78EC0", VA = "0x185E79AC0", Slot = "17")]
	public void NEPHBJDBLEL(LHNHNFAONOD PIBFDGEOBKF, float BKLOJAMMHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1A")]
	[Cpp2IlInjected.Address(RVA = "0x5E78B20", Offset = "0x5E77F20", VA = "0x185E78B20", Slot = "20")]
	public float3 GGAMGHMJKEP(PEILNHFAGGO AAINKMJJJEG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1B")]
	[Cpp2IlInjected.Address(RVA = "0x5E794B0", Offset = "0x5E788B0", VA = "0x185E794B0", Slot = "21")]
	public quaternion MDLMBNDBEAH(PEILNHFAGGO AAINKMJJJEG)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1C")]
	[Cpp2IlInjected.Address(RVA = "0x5E792D0", Offset = "0x5E786D0", VA = "0x185E792D0", Slot = "18")]
	public bool LFDJFJNGAPG(LHNHNFAONOD PIBFDGEOBKF, [Out] RigidTransform HGDMPDAHIGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1D")]
	[Cpp2IlInjected.Address(RVA = "0x5E77DD0", Offset = "0x5E771D0", VA = "0x185E77DD0", Slot = "19")]
	public bool AMAKJOPGGFN(LHNHNFAONOD PIBFDGEOBKF, [Out] float BKLOJAMMHDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1E")]
	[Cpp2IlInjected.Address(RVA = "0x5E78D00", Offset = "0x5E78100", VA = "0x185E78D00", Slot = "14")]
	[IteratorStateMachine(typeof(JOBCBPMMHKE))]
	public IEnumerable<LHNHNFAONOD> GPMBMCMDHDC(LHNHNFAONOD PIBFDGEOBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1F")]
	[Cpp2IlInjected.Address(RVA = "0x5E78310", Offset = "0x5E77710", VA = "0x185E78310", Slot = "15")]
	public LHNHNFAONOD BENGNMIJNMG(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C20")]
	[Cpp2IlInjected.Address(RVA = "0x5E781F0", Offset = "0x5E775F0", VA = "0x185E781F0")]
	private Entity BENGNMIJNMG(Entity FILKDLNBIJH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C21")]
	[Cpp2IlInjected.Address(RVA = "0x5E79CC0", Offset = "0x5E790C0", VA = "0x185E79CC0")]
	public KADILEALKKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000237")]
[PNAJALIKCOM(typeof(DPBFPLBNLLG), new string[] { })]
public sealed class ELIPBIAEJOG : DPBFPLBNLLG, JAKEGKENGGK
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000238")]
	private struct DEKFPFMLKAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public float JKHIFGJJLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public uint MPBHGBNDKDG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	[MFFAOKEGCNH]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	[MFFAOKEGCNH]
	private PCIIECOCADI MCBJDBHHDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	[MFFAOKEGCNH]
	private KHFEJHGDIKF NNOJIFFJDNH;

	[Cpp2IlInjected.Token(Token = "0x6000C2D")]
	[Cpp2IlInjected.Address(RVA = "0x5E71A30", Offset = "0x5E70E30", VA = "0x185E71A30", Slot = "5")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2E")]
	[Cpp2IlInjected.Address(RVA = "0x5E71AD0", Offset = "0x5E70ED0", VA = "0x185E71AD0")]
	public bool NNJLPEJLDHA([In] float3 HJGLLCKAOEB, [In] float3 PIOPMIBANBL, float EJKOOCGEPCD, [Out] IKAHLCGAFCI PFKOENMJOPI, [Out] LHNHNFAONOD ACICFHDBOLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2F")]
	[Cpp2IlInjected.Address(RVA = "0x5E71F80", Offset = "0x5E71380", VA = "0x185E71F80")]
	public static bool OBNHMDCBFFO([In] Span<IKAHLCGAFCI> MMLKIFOAGKM, float EJKOOCGEPCD, [Out] int APOENOPNHBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C30")]
	[Cpp2IlInjected.Address(RVA = "0x5E71A00", Offset = "0x5E70E00", VA = "0x185E71A00")]
	public static float IMPAGOMEKJF(float JKHIFGJJLLD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C31")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public ELIPBIAEJOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C32")]
	[Cpp2IlInjected.Address(RVA = "0x5E71AC0", Offset = "0x5E70EC0", VA = "0x185E71AC0", Slot = "4")]
	private bool KDMNPDPNOJN([In] float3 HJGLLCKAOEB, [In] float3 PIOPMIBANBL, float EJKOOCGEPCD, [Out] IKAHLCGAFCI PFKOENMJOPI, [Out] LHNHNFAONOD ACICFHDBOLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000239")]
[PNAJALIKCOM(typeof(KHFEJHGDIKF), new string[] { })]
public sealed class CFIFOHAJJJP : KHFEJHGDIKF, JAKEGKENGGK
{
	[Cpp2IlInjected.Token(Token = "0x200023A")]
	[BurstCompile]
	private struct DONNCGKCLNO : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		[ReadOnly]
		public NativeArray<Entity> BAPHNAADJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		[ReadOnly]
		public float3 ONOHGKIFNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		[ReadOnly]
		public float3 LJLLLNPGBGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> GKBGLIKOBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		[ReadOnly]
		public ComponentDataFromEntity<CCKLCDOFFMI> NNHLHOBCGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> EJMGIGDCIFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		[ReadOnly]
		public ComponentDataFromEntity<PJMACGKKJMM> BJLMJPJDHGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		[ReadOnly]
		public ComponentDataFromEntity<ELJOMKLCEJJ> DINPBGLNPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		[WriteOnly]
		public NativeArray<IKAHLCGAFCI> FAGDHIJNDCI;

		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private static readonly IKAHLCGAFCI FHLCGJOAGGD;

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x5E711E0", Offset = "0x5E705E0", VA = "0x185E711E0", Slot = "4")]
		public void Execute(int APOENOPNHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x5E71600", Offset = "0x5E70A00", VA = "0x185E71600")]
		private static float3 HMNJPNFDPLH([In] float4x4 AJJIEOEHDOG, [In] float3 DCHCBCCCIIP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x5E71480", Offset = "0x5E70880", VA = "0x185E71480")]
		private static float3 GGANNHJGPNG([In] float4x4 AJJIEOEHDOG, [In] float3 EGKDMEOOPIK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x5E708B0", Offset = "0x5E6FCB0", VA = "0x185E708B0")]
		private static float3 CAGKBPGENPO([In] float4x4 AJJIEOEHDOG, [In] float3 DCHCBCCCIIP)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x5E709B0", Offset = "0x5E6FDB0", VA = "0x185E709B0")]
		private static float3 DACDLHJBHMD([In] float4x4 AJJIEOEHDOG, [In] float3 EGKDMEOOPIK)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x5E716B0", Offset = "0x5E70AB0", VA = "0x185E716B0")]
		private bool PMDFJNNKCMB([In] float3 HJGLLCKAOEB, [In] float3 PIOPMIBANBL, [In] NativeArray<Entity> EGBDIEGKBBE, [Out] float3 PFKOENMJOPI, [Out] float3 MBCOBAGMLHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x5E70B90", Offset = "0x5E6FF90", VA = "0x185E70B90")]
		public static bool EPPPNOIFKFD([In] float3 OOMGONMPGPP, [In] float3 IEPLIOFHAJD, [In] float3 NLDOJBNNENC, [In] float3 DJANAEKAPFI, float MOFAHCNHFBN, float AGBFHFNMOFE, [Out] float PDOICOFDEIB, [Out] float3 HKKGEHMHEGP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072C")]
	private EntityManager OKJDPAMBACM;

	[Cpp2IlInjected.Token(Token = "0x6000C33")]
	[Cpp2IlInjected.Address(RVA = "0x5E6FDA0", Offset = "0x5E6F1A0", VA = "0x185E6FDA0", Slot = "5")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C34")]
	[Cpp2IlInjected.Address(RVA = "0x5E6FE20", Offset = "0x5E6F220", VA = "0x185E6FE20")]
	public void NNJLPEJLDHA([In] NativeArray<Entity> BAPHNAADJCK, [In] float3 HJGLLCKAOEB, [In] float3 PIOPMIBANBL, [In] NativeArray<IKAHLCGAFCI> PBLNGJMBFOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C35")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public CFIFOHAJJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C36")]
	[Cpp2IlInjected.Address(RVA = "0x5E6FD90", Offset = "0x5E6F190", VA = "0x185E6FD90", Slot = "4")]
	private void FDDMNKHJLAI([In] NativeArray<Entity> BAPHNAADJCK, [In] float3 HJGLLCKAOEB, [In] float3 PIOPMIBANBL, [In] NativeArray<IKAHLCGAFCI> PBLNGJMBFOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023B")]
[OPLOBPDEFMG(typeof(CEJODIHFCGC))]
[PNAJALIKCOM(typeof(JBLOAMOKHEB), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public class JBLOAMOKHEB : CEJODIHFCGC, JAKEGKENGGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200023C")]
	private struct IHJIPOGGHKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public EOEOMGNNBCG APNFDGPCBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public Type IJFAMCPOKBO;
	}

	[Cpp2IlInjected.Token(Token = "0x200023D")]
	private struct HGINLAJILNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public IHJIPOGGHKF[] MFEJFLABCIK;
	}

	[Cpp2IlInjected.Token(Token = "0x200023E")]
	[BurstCompile]
	private struct ABPGFOEFOEN : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		[ReadOnly]
		public NativeArray<byte> BONCLLIALDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		[ReadOnly]
		public NativeArray<Entity> FEAEBGJLBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		[ReadOnly]
		public NativeArray<byte> PIJNIMENDOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		[ReadOnly]
		public NativeArray<byte> BDLCJNIAKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		[WriteOnly]
		public NativeList<Entity> IJBAJJMMPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		[WriteOnly]
		public NativeList<byte> CGCCLLCCMCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		[WriteOnly]
		public NativeList<byte> CAOJGGAAPKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public int NEAGIAMKGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public int GAGEHKOAIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public int IAFEHDJNHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public int PIBMNCBGNAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public int OCMDIKCBANO;

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F080", Offset = "0x5E6E480", VA = "0x185E6F080", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000737")]
	private static readonly FBKCBHAMJJJ AMAPEJENOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400073A")]
	private readonly Dictionary<EAAMNLEDMLN, EOEOMGNNBCG> DKNHBAKNBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	private readonly Dictionary<int, HGINLAJILNC> PIGFFMKEFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	private BBAOLHNDKHB MFEJFLABCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action LOLJBOOLAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x5E76790", Offset = "0x5E75B90", VA = "0x185E76790")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x5E768A0", Offset = "0x5E75CA0", VA = "0x185E768A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action FOALGEIMEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x5E76F50", Offset = "0x5E76350", VA = "0x185E76F50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x5E766F0", Offset = "0x5E75AF0", VA = "0x185E766F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C43")]
	[Cpp2IlInjected.Address(RVA = "0x5E76830", Offset = "0x5E75C30", VA = "0x185E76830", Slot = "6")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C44")]
	[Cpp2IlInjected.Address(RVA = "0x5E763F0", Offset = "0x5E757F0", VA = "0x185E763F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C45")]
	[Cpp2IlInjected.Address(RVA = "0x5E76A30", Offset = "0x5E75E30", VA = "0x185E76A30", Slot = "4")]
	public void KIPDOAILNDA(PGMBACGNAAP ANNDMLIIDLL, EOEOMGNNBCG HHDLGPINDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C46")]
	[Cpp2IlInjected.Address(RVA = "0x5E76480", Offset = "0x5E75880", VA = "0x185E76480", Slot = "5")]
	public void FOMBLDAJHNJ(PGMBACGNAAP ANNDMLIIDLL, EOEOMGNNBCG HHDLGPINDHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C47")]
	[Cpp2IlInjected.Address(RVA = "0x5E76940", Offset = "0x5E75D40", VA = "0x185E76940", Slot = "8")]
	public void KIPDOAILNDA(EAAMNLEDMLN KMKGEGCGMGD, EOEOMGNNBCG IOKENELNCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C48")]
	[Cpp2IlInjected.Address(RVA = "0x5E765D0", Offset = "0x5E759D0", VA = "0x185E765D0", Slot = "9")]
	public void FOMBLDAJHNJ(EAAMNLEDMLN KMKGEGCGMGD, EOEOMGNNBCG IOKENELNCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C49")]
	[Cpp2IlInjected.Address(RVA = "0x5E773B0", Offset = "0x5E767B0", VA = "0x185E773B0")]
	private void OOLGDJLBDMG(EAAMNLEDMLN KMKGEGCGMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4A")]
	[Cpp2IlInjected.Address(RVA = "0x5E770C0", Offset = "0x5E764C0", VA = "0x185E770C0")]
	internal void OLOPJFCNBPC(BLJODAPBPOA JEPPHOGINNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4B")]
	[Cpp2IlInjected.Address(RVA = "0x5E75AB0", Offset = "0x5E74EB0", VA = "0x185E75AB0")]
	private void DKPNBMOHOBH(BLJODAPBPOA JEPPHOGINNJ, int PIEALCBDGOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4C")]
	[Cpp2IlInjected.Address(RVA = "0x5E76D00", Offset = "0x5E76100", VA = "0x185E76D00")]
	private void MDMKNMBMBDC(EHEMBOJPNLK NPHJLOJKBMK, GLNELICFCEC IGOHNIPOMPC, IHJIPOGGHKF DAGNOBLEHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4D")]
	[Cpp2IlInjected.Address(RVA = "0x5E76B80", Offset = "0x5E75F80", VA = "0x185E76B80")]
	private HGINLAJILNC LANDPPLOCCK(EHEMBOJPNLK NPHJLOJKBMK, GLNELICFCEC IGOHNIPOMPC)
	{
		return default(HGINLAJILNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4E")]
	[Cpp2IlInjected.Address(RVA = "0x5E76FF0", Offset = "0x5E763F0", VA = "0x185E76FF0")]
	private IHJIPOGGHKF OIJLJJPKLDL(HGINLAJILNC KLLMNJMAMGG, EHEMBOJPNLK NPHJLOJKBMK, GLNELICFCEC IGOHNIPOMPC)
	{
		return default(IHJIPOGGHKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4F")]
	[Cpp2IlInjected.Address(RVA = "0x5E77600", Offset = "0x5E76A00", VA = "0x185E77600")]
	public JBLOAMOKHEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023F")]
[PNAJALIKCOM(typeof(JIIJKCLIHFI), new string[] { })]
public class ONLMOPKIBDC : JAKEGKENGGK, DFFDMFBJPHA, JIIJKCLIHFI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000240")]
	[CompilerGenerated]
	private sealed class APIONCNOBIB : IEnumerable<LHNHNFAONOD>, IEnumerable, IEnumerator<LHNHNFAONOD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private LHNHNFAONOD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public ONLMOPKIBDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private LHNHNFAONOD splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public LHNHNFAONOD <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		private LHNHNFAONOD System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C67")]
			[Cpp2IlInjected.Address(RVA = "0x30E4090", Offset = "0x30E3490", VA = "0x1830E4090", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(LHNHNFAONOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C69")]
			[Cpp2IlInjected.Address(RVA = "0x5E6F9A0", Offset = "0x5E6EDA0", VA = "0x185E6F9A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x32C75A0", Offset = "0x32C69A0", VA = "0x1832C75A0")]
		[DebuggerHidden]
		public APIONCNOBIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C65")]
		[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F7E0", Offset = "0x5E6EBE0", VA = "0x185E6F7E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F950", Offset = "0x5E6ED50", VA = "0x185E6F950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F8A0", Offset = "0x5E6ECA0", VA = "0x185E6F8A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LHNHNFAONOD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F8A0", Offset = "0x5E6ECA0", VA = "0x185E6F8A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400074D")]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400074E")]
	private INHGBAEAGHP NMNJDGCCMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400074F")]
	private CCCMOPCHHIG JHCNLBAHAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000750")]
	private EMJEIPEMFBH FELCGCIPFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private EMLJAPIGCLK ENOFBOBGGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private BGHOIHDELID FNDBOHEPMMO;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	private EntityManager NAALHPNIIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D510", Offset = "0x5E7C910", VA = "0x185E7D510")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C53")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D010", Offset = "0x5E7C410", VA = "0x185E7D010", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C54")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "5")]
	public void MIEIACCMPNB(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C55")]
	[Cpp2IlInjected.Address(RVA = "0x75E5B0", Offset = "0x75D9B0", VA = "0x18075E5B0", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C56")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CAC0", Offset = "0x5E7BEC0", VA = "0x185E7CAC0")]
	private void FFKNJBOBJJF(Entity MMJOMPMOBHI, int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C57")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D100", Offset = "0x5E7C500", VA = "0x185E7D100", Slot = "10")]
	public void KCOOIDELICO(LHNHNFAONOD PIBFDGEOBKF, MHNILHILJOG ILKHBODBFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C58")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CC60", Offset = "0x5E7C060", VA = "0x185E7CC60", Slot = "9")]
	public MHNILHILJOG GCBFCEJOEGD(LHNHNFAONOD PIBFDGEOBKF)
	{
		return default(MHNILHILJOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C59")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C8F0", Offset = "0x5E7BCF0", VA = "0x185E7C8F0", Slot = "11")]
	public LHNHNFAONOD BJCFFFHEGNM(LHNHNFAONOD IBBKOFMNBLI, [Optional] float3? LPAPEIIOLFG, [Optional] quaternion? KBKHJHIFKGI, [Optional] float3? NMGPAHAPPCF)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CA50", Offset = "0x5E7BE50", VA = "0x185E7CA50", Slot = "12")]
	public LHNHNFAONOD EAJMAHEBBHE(LHNHNFAONOD IBBKOFMNBLI, int APOENOPNHBG, [Optional] float3? LPAPEIIOLFG, [Optional] quaternion? KBKHJHIFKGI, [Optional] float3? NMGPAHAPPCF)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CD90", Offset = "0x5E7C190", VA = "0x185E7CD90")]
	private LHNHNFAONOD HIGHEFNJGPO(LHNHNFAONOD IBBKOFMNBLI, int APOENOPNHBG, [Optional] float3? LPAPEIIOLFG, [Optional] quaternion? KBKHJHIFKGI, [Optional] float3? NMGPAHAPPCF)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D430", Offset = "0x5E7C830", VA = "0x185E7D430", Slot = "7")]
	public LHNHNFAONOD LCECEMFKAKO(LHNHNFAONOD IBBKOFMNBLI, int APOENOPNHBG)
	{
		return default(LHNHNFAONOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C960", Offset = "0x5E7BD60", VA = "0x185E7C960", Slot = "16")]
	public void BLFLJMIBHKK(LHNHNFAONOD IBBKOFMNBLI, LHNHNFAONOD MMJOMPMOBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CB40", Offset = "0x5E7BF40", VA = "0x185E7CB40", Slot = "13")]
	public void FKFBBINNHDM(LHNHNFAONOD IBBKOFMNBLI, int APOENOPNHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D1A0", Offset = "0x5E7C5A0", VA = "0x185E7D1A0", Slot = "14")]
	public void KDOHNFAPJMP(LHNHNFAONOD IBBKOFMNBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C860", Offset = "0x5E7BC60", VA = "0x185E7C860", Slot = "8")]
	public int AJKFLPALNNO(LHNHNFAONOD IBBKOFMNBLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CD00", Offset = "0x5E7C100", VA = "0x185E7CD00", Slot = "6")]
	[IteratorStateMachine(typeof(APIONCNOBIB))]
	public IEnumerable<LHNHNFAONOD> HADBNIDPNPF(LHNHNFAONOD IBBKOFMNBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C9C0", Offset = "0x5E7BDC0", VA = "0x185E7C9C0")]
	private bool CJLJGOLNHCI(LHNHNFAONOD IBBKOFMNBLI, [Out] NativeArray<Entity> JHOBIGGNOKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public ONLMOPKIBDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000241")]
[PNAJALIKCOM(typeof(LJKCOAOGFEM), new string[] { })]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
public class LJKCOAOGFEM : JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	[MFFAOKEGCNH]
	private BGHOIHDELID CBJOGHLNPOJ;

	[Cpp2IlInjected.Token(Token = "0x6000C6C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A4A0", Offset = "0x5E798A0", VA = "0x185E7A4A0", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A4F0", Offset = "0x5E798F0", VA = "0x185E7A4F0")]
	public void MAIDIOFBBHK(IEnumerable<string> DEOAHMDEFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public LJKCOAOGFEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000242")]
[CDHEJLILMFK(PIEFJKINJBJ.LoadInstance)]
[PNAJALIKCOM(typeof(PCAEAHCDPBO), new string[] { })]
internal sealed class PCAEAHCDPBO : JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	private IMHPKNCJCOD MOIDEPLOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	private CALJHDDCOOA DNKMGGNGHKG;

	[Cpp2IlInjected.Token(Token = "0x6000C6F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D590", Offset = "0x5E7C990", VA = "0x185E7D590", Slot = "4")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C70")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public PCAEAHCDPBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000243")]
[DefaultMember("Item")]
public struct MGDHNEFBMFE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075E")]
	private T[] GHFAAPNAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075F")]
	private int KIHHOMBMMEI;

	[Cpp2IlInjected.Token(Token = "0x6000C71")]
	[Cpp2IlInjected.Address(RVA = "0x3B64E90", Offset = "0x3B64290", VA = "0x183B64E90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000244")]
[DefaultMember("Item")]
public struct FOKCCHJECCO<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000760")]
	private MGDHNEFBMFE<T> GHFAAPNAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private int KIHHOMBMMEI;

	[Cpp2IlInjected.Token(Token = "0x6000C72")]
	[Cpp2IlInjected.Address(RVA = "0x33EC3E0", Offset = "0x33EB7E0", VA = "0x1833EC3E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C73")]
	[Cpp2IlInjected.Address(RVA = "0x33EC420", Offset = "0x33EB820", VA = "0x1833EC420", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000245")]
public struct PFOOKIGEPDE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private NativeList<Entity> BAPHNAADJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000763")]
	private TransformAccessArray IHBAGGIDMKI;

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public int EJNDKIEMIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D660", Offset = "0x5E7CA60", VA = "0x185E7D660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public NativeList<Entity> JDNMIDEPMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0xA9D3F0", Offset = "0xA9C7F0", VA = "0x180A9D3F0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public TransformAccessArray DHPGBAMAKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x75C530", Offset = "0x75B930", VA = "0x18075C530")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool GHLFCACBCML
	{
		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D7F0", Offset = "0x5E7CBF0", VA = "0x185E7D7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C74")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D8D0", Offset = "0x5E7CCD0", VA = "0x185E7D8D0")]
	public PFOOKIGEPDE(int OOIJDECJBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C79")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D610", Offset = "0x5E7CA10", VA = "0x185E7D610")]
	public Entity AINIKFEFHIF(int APOENOPNHBG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D880", Offset = "0x5E7CC80", VA = "0x185E7D880")]
	public void OFNIDBDFPCB(int OOIJDECJBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D730", Offset = "0x5E7CB30", VA = "0x185E7D730")]
	public int INMJBKGEACO(Transform OLPLDGDFGHL, Entity FILKDLNBIJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D810", Offset = "0x5E7CC10", VA = "0x185E7D810")]
	public int MICLFLKCKPP(int APOENOPNHBG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D670", Offset = "0x5E7CA70", VA = "0x185E7D670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D6F0", Offset = "0x5E7CAF0", VA = "0x185E7D6F0")]
	private void HAABPELBMAI(int KNBMNPNOMOG = 0)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000246")]
public struct NDKHPFEPNBD : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x4000764")]
	public static readonly NDKHPFEPNBD BDJLOIHNJNG;

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A840", Offset = "0x5E79C40", VA = "0x185E7A840", Slot = "4")]
	public bool Equals(LinkedEntityGroup MHJJOHHKIPH, LinkedEntityGroup DFACBIDGKFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A860", Offset = "0x5E79C60", VA = "0x185E7A860", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup BAFDGKKJJJD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000247")]
internal class EHHFBFEFMLC
{
	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public EHHFBFEFMLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000248")]
public struct JJKHGHKNBKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000765")]
	public Entity FILKDLNBIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000766")]
	public Entity JGNFAOENAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000767")]
	public Entity JOOENMAHIDL;

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x4286B50", Offset = "0x4285F50", VA = "0x184286B50")]
	public JJKHGHKNBKD(Entity FILKDLNBIJH, Entity JGNFAOENAOD, Entity JOOENMAHIDL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x5E776D0", Offset = "0x5E76AD0", VA = "0x185E776D0")]
	public static JJKHGHKNBKD BNPEICKPPJA((Entity entity, Entity oldParent, Entity newParent) OODFPGJPLPP)
	{
		return default(JJKHGHKNBKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x5E776F0", Offset = "0x5E76AF0", VA = "0x185E776F0")]
	public void LHHELOIEGGD([Out] Entity FILKDLNBIJH, [Out] Entity JGNFAOENAOD, [Out] Entity JOOENMAHIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000249")]
public struct OOPAIGCDJBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000768")]
	public Entity FILKDLNBIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000769")]
	public Entity EBFCMPBKGBM;

	[Cpp2IlInjected.Token(Token = "0x6000C85")]
	[Cpp2IlInjected.Address(RVA = "0x201FF20", Offset = "0x201F320", VA = "0x18201FF20")]
	public OOPAIGCDJBO(Entity FILKDLNBIJH, Entity EBFCMPBKGBM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C86")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D560", Offset = "0x5E7C960", VA = "0x185E7D560")]
	public static OOPAIGCDJBO BNPEICKPPJA((Entity entity, Entity parent) OODFPGJPLPP)
	{
		return default(OOPAIGCDJBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C87")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D580", Offset = "0x5E7C980", VA = "0x185E7D580")]
	public void LHHELOIEGGD([Out] Entity FILKDLNBIJH, [Out] Entity EBFCMPBKGBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024A")]
public struct CLJIEGNHEPK<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400076A")]
	private GCHandle DELBIPHKFDD;

	[Cpp2IlInjected.Token(Token = "0x6000C88")]
	[Cpp2IlInjected.Address(RVA = "0x4AE3A90", Offset = "0x4AE2E90", VA = "0x184AE3A90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024B")]
public enum DMLBNJLJDMN
{
	[Cpp2IlInjected.Token(Token = "0x400076C")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x400076D")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x400076E")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x200024C")]
public struct KAIDKBAIDJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400076F")]
	public DMLBNJLJDMN DDNAIIAEIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000770")]
	public int DFMOGDNKJPN;

	[Cpp2IlInjected.Token(Token = "0x6000C89")]
	[Cpp2IlInjected.Address(RVA = "0x982310", Offset = "0x981710", VA = "0x180982310")]
	public KAIDKBAIDJE(DMLBNJLJDMN DDNAIIAEIKD, int DFMOGDNKJPN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C8A")]
	[Cpp2IlInjected.Address(RVA = "0x5D618D0", Offset = "0x5D60CD0", VA = "0x185D618D0")]
	public static KAIDKBAIDJE BNPEICKPPJA((DMLBNJLJDMN eventType, int eventIndex) MHJJOHHKIPH)
	{
		return default(KAIDKBAIDJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8B")]
	[Cpp2IlInjected.Address(RVA = "0x5E79D80", Offset = "0x5E79180", VA = "0x185E79D80")]
	public void LHHELOIEGGD([Out] DMLBNJLJDMN DDNAIIAEIKD, [Out] int DFMOGDNKJPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024D")]
[PNAJALIKCOM(typeof(PCIIECOCADI), new string[] { })]
public sealed class MEHJCDCFHLN : PCIIECOCADI, JAKEGKENGGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000771")]
	private FGAHOPPNDBO DKKFMPOIGEA;

	[Cpp2IlInjected.Token(Token = "0x6000C8C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A750", Offset = "0x5E79B50", VA = "0x185E7A750", Slot = "5")]
	public void InitReferences(FJPIIIPDBML NKEGKJEJLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A7A0", Offset = "0x5E79BA0", VA = "0x185E7A7A0")]
	public bool NNJLPEJLDHA([In] float3 HJGLLCKAOEB, [In] float3 PIOPMIBANBL, float EJKOOCGEPCD, Allocator KIKFOGPECEC, [Out] NativeArray<Entity> BAPHNAADJCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8E")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public MEHJCDCFHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A7A0", Offset = "0x5E79BA0", VA = "0x185E7A7A0", Slot = "4")]
	private bool KCBCFAOLHEI([In] float3 HJGLLCKAOEB, [In] float3 PIOPMIBANBL, float EJKOOCGEPCD, Allocator KIKFOGPECEC, [Out] NativeArray<Entity> BAPHNAADJCK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200024E")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
public sealed class BHNGHMEMGDF : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000C90")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F9F0", Offset = "0x5E6EDF0", VA = "0x185E6F9F0", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C91")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public BHNGHMEMGDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024F")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal sealed class HPMHHBCHJMP : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000C92")]
	[Cpp2IlInjected.Address(RVA = "0x5E74580", Offset = "0x5E73980", VA = "0x185E74580", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C93")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public HPMHHBCHJMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000250")]
internal class LNGHMMNFBPC : DEECDILBOJC
{
	[Cpp2IlInjected.Token(Token = "0x6000C94")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public LNGHMMNFBPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000251")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal sealed class NENNHAIDHKP : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000C95")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A8C0", Offset = "0x5E79CC0", VA = "0x185E7A8C0", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C96")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public NENNHAIDHKP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems.Tags
{
	[Cpp2IlInjected.Token(Token = "0x2000252")]
	[CompilerGenerated]
	public class PostInstantiatePushTagsToTaggedEntitiesSystem : EJPAANLNCMB, JAKEGKENGGK
	{
		[Cpp2IlInjected.Token(Token = "0x2000253")]
		private struct PostInstantiatePushTagsToTaggedEntitiesSystem_Job
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000778")]
			public PostInstantiatePushTagsToTaggedEntitiesSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000779")]
			public Dictionary<int, FixedString32Bytes> serializedTagMap;

			[Cpp2IlInjected.Token(Token = "0x6000C9D")]
			[Cpp2IlInjected.Address(RVA = "0x5E7D9F0", Offset = "0x5E7CDF0", VA = "0x185E7D9F0")]
			private void OJJILIFPAAA(Entity entity, EAMDAMACEOD tags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0x5E7DD70", Offset = "0x5E7D170", VA = "0x185E7DD70")]
			public void OJNGABLDLND(EntityQuery query)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private static readonly FBKCBHAMJJJ log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		[MFFAOKEGCNH]
		private AFLJLAKFEOK spawnableToolDependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		[MFFAOKEGCNH]
		private INHGBAEAGHP objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		[MFFAOKEGCNH]
		private BGHOIHDELID singletonComponentService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private EntityQuery PostInstantiatePushTagsToTaggedEntitiesSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private ComponentTypeHandle<EAMDAMACEOD> __RecRoom_Components_PersistentUserTagData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D960", Offset = "0x5E7CD60", VA = "0x185E7D960", Slot = "14")]
		public void InitReferences(FJPIIIPDBML services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E300", Offset = "0x5E7D700", VA = "0x185E7E300", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E030", Offset = "0x5E7D430", VA = "0x185E7E030")]
		private void LOCANLLHGCI(Dictionary<int, FixedString32Bytes> serializedTagMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E100", Offset = "0x5E7D500", VA = "0x185E7E100", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x3DFFFF0", Offset = "0x3DFF3F0", VA = "0x183DFFFF0")]
		public PostInstantiatePushTagsToTaggedEntitiesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000254")]
internal class HAAGDFDDBOH : HEGKKONLNKG
{
	[Cpp2IlInjected.Token(Token = "0x17000164")]
	protected override AMLDKDEIAEE MKDBEIMJOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C9F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB430", Offset = "0x7CA830", VA = "0x1807CB430", Slot = "17")]
		get
		{
			return default(AMLDKDEIAEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x5E74530", Offset = "0x5E73930", VA = "0x185E74530")]
	public HAAGDFDDBOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000255")]
[HLDCAJNGFIO(PIEFJKINJBJ.LoadInstance)]
internal sealed class NLNHLPECHBA : EJJGNIPMDNB
{
	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A990", Offset = "0x5E79D90", VA = "0x185E7A990", Slot = "15")]
	protected override ComponentSystemBase PKMFPDDAKEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x5DBC4D0", Offset = "0x5DBB8D0", VA = "0x185DBC4D0")]
	public NLNHLPECHBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000256")]
public class HBENNLDMGIJ : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x76D100", Offset = "0x76C500", VA = "0x18076D100")]
	public HBENNLDMGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000257")]
[JKMDIICCHDE(typeof(CBFFFGCNAML))]
public sealed class DGJGIPKPLDC : IDGMHABECIE
{
	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x5E707A0", Offset = "0x5E6FBA0", VA = "0x185E707A0", Slot = "8")]
	protected override bool MKDBEDAHKLG(ReadOnlySpan<CBFFFGCNAML> DLBJPBJAFGL, GILPKIILCCE GCLEDKPLBKL, [Out] ReadOnlySpan<byte> EGFEGIMIICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x5E706A0", Offset = "0x5E6FAA0", VA = "0x185E706A0", Slot = "9")]
	protected override bool FMFPJIDGABL(int FOIKACEEEGH, Span<CBFFFGCNAML> DLBJPBJAFGL, [In] ReadOnlySpan<byte> EGFEGIMIICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x5E708A0", Offset = "0x5E6FCA0", VA = "0x185E708A0")]
	public DGJGIPKPLDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000258")]
[JKMDIICCHDE(typeof(FBGNNPLAHMM))]
public sealed class ODPBGEGCFPG : EJIOHCFDAPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C450", Offset = "0x5E7B850", VA = "0x185E7C450", Slot = "8")]
	protected override bool MKDBEDAHKLG(ReadOnlySpan<FBGNNPLAHMM> DLBJPBJAFGL, GILPKIILCCE GCLEDKPLBKL, [Out] ReadOnlySpan<byte> EGFEGIMIICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C350", Offset = "0x5E7B750", VA = "0x185E7C350", Slot = "9")]
	protected override bool FMFPJIDGABL(int FOIKACEEEGH, Span<FBGNNPLAHMM> DLBJPBJAFGL, [In] ReadOnlySpan<byte> EGFEGIMIICO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C550", Offset = "0x5E7B950", VA = "0x185E7C550")]
	public ODPBGEGCFPG()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000259")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : BAFBLMKEIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E7C0", Offset = "0x5E7DBC0", VA = "0x185E7E7C0", Slot = "6")]
		public sealed override void CAGGLFMEPDA(PGKEOEMFGED IOKENELNCLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F980", Offset = "0x5E7ED80", VA = "0x185E7F980", Slot = "4")]
		public sealed override void LIPDHMGDINI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200025A")]
internal class __UnmanagedPostProcessorOutput__1354147581
{
	[Cpp2IlInjected.Token(Token = "0x6000CAD")]
	[Cpp2IlInjected.Address(RVA = "0x5E80C10", Offset = "0x5E80010", VA = "0x185E80C10")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200025B")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1354147581
{
	[Cpp2IlInjected.Token(Token = "0x6000CAE")]
	[Cpp2IlInjected.Address(RVA = "0x5E7FB40", Offset = "0x5E7EF40", VA = "0x185E7FB40")]
	public static void EPEMCFLOMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAF")]
	[Cpp2IlInjected.Address(RVA = "0x5E80C00", Offset = "0x5E80000", VA = "0x185E80C00")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200025C")]
internal class KDNHFNKMBNC : ContainerPropertyBag<GHHDAIMBJFP>
{
	[Cpp2IlInjected.Token(Token = "0x200025D")]
	private class GNLHMBKMNEA : Property<GHHDAIMBJFP, PCCDMPNJHHD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public override string PCDEPGOAGDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB1")]
			[Cpp2IlInjected.Address(RVA = "0x5E74500", Offset = "0x5E73900", VA = "0x185E74500", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public override bool LIGHAHNLJDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB2")]
			[Cpp2IlInjected.Address(RVA = "0x7A7300", Offset = "0x7A6700", VA = "0x1807A7300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB3")]
		[Cpp2IlInjected.Address(RVA = "0x5E744C0", Offset = "0x5E738C0", VA = "0x185E744C0")]
		public GNLHMBKMNEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB4")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F210", Offset = "0x5D2E610", VA = "0x185D2F210", Slot = "14")]
		public override PCCDMPNJHHD GetValue(GHHDAIMBJFP KBPJCNHNBHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB5")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F230", Offset = "0x5D2E630", VA = "0x185D2F230", Slot = "15")]
		public override void SetValue(GHHDAIMBJFP KBPJCNHNBHJ, PCCDMPNJHHD EOHMJBFGDPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB0")]
	[Cpp2IlInjected.Address(RVA = "0x5E79D90", Offset = "0x5E79190", VA = "0x185E79D90")]
	public KDNHFNKMBNC()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200025E")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB6")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E620", Offset = "0x5E7DA20", VA = "0x185E7E620")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200025F")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000CB7")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E740", Offset = "0x5E7DB40", VA = "0x185E7E740")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000260")]
public class GJFEHICIKAF
{
	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public GJFEHICIKAF()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000261")]
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
