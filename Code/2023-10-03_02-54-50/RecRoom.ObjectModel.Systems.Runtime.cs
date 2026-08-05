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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x227C390", Offset = "0x227AB90", VA = "0x18227C390")]
		public static HMNBGIAKLDO<T> CreateTemporarySingleton<T>(this EntityManager entityManager, T componentData) where T : struct, IComponentData
		{
			return default(HMNBGIAKLDO<T>);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct OJNGALEKOBC : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ABGLLKGMJHL]
public static class HAONGDFFBDD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0920", Offset = "0x5DEF120", VA = "0x185DF0920")]
	static HAONGDFFBDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2396500", Offset = "0x2394D00", VA = "0x182396500")]
	public static void LNNHONMKPFF<T>(T PMFLLGPMIME, T PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DF08F0", Offset = "0x5DEF0F0", VA = "0x185DF08F0")]
	public static void LNNHONMKPFF(FixedString32Bytes PMFLLGPMIME, string PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DF07C0", Offset = "0x5DEEFC0", VA = "0x185DF07C0")]
	public static void LNNHONMKPFF(string PMFLLGPMIME, FixedString32Bytes PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0880", Offset = "0x5DEF080", VA = "0x185DF0880")]
	public static void LNNHONMKPFF(FixedString64Bytes PMFLLGPMIME, string PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DF06D0", Offset = "0x5DEEED0", VA = "0x185DF06D0")]
	public static void LNNHONMKPFF(string PMFLLGPMIME, FixedString64Bytes PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0820", Offset = "0x5DEF020", VA = "0x185DF0820")]
	public static void LNNHONMKPFF(OIJIOGJJFDK PMFLLGPMIME, Vector3 PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D31CD0", Offset = "0x5D304D0", VA = "0x185D31CD0")]
	public static void LNNHONMKPFF(Vector3 PMFLLGPMIME, OIJIOGJJFDK PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0730", Offset = "0x5DEEF30", VA = "0x185DF0730")]
	public static void LNNHONMKPFF(CBCFNGPOECM PMFLLGPMIME, Vector4 PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F760", Offset = "0x5D2DF60", VA = "0x185D2F760")]
	public static void LNNHONMKPFF(Vector4 PMFLLGPMIME, CBCFNGPOECM PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0730", Offset = "0x5DEEF30", VA = "0x185DF0730")]
	public static void LNNHONMKPFF(CBCFNGPOECM PMFLLGPMIME, Quaternion PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F760", Offset = "0x5D2DF60", VA = "0x185D2F760")]
	public static void LNNHONMKPFF(Quaternion PMFLLGPMIME, CBCFNGPOECM PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DF06A0", Offset = "0x5DEEEA0", VA = "0x185DF06A0")]
	public static void LNNHONMKPFF(OIJIOGJJFDK PMFLLGPMIME, float3 PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D31CD0", Offset = "0x5D304D0", VA = "0x185D31CD0")]
	public static void LNNHONMKPFF(float3 PMFLLGPMIME, OIJIOGJJFDK PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0800", Offset = "0x5DEF000", VA = "0x185DF0800")]
	public static void LNNHONMKPFF(CBCFNGPOECM PMFLLGPMIME, float4 PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F760", Offset = "0x5D2DF60", VA = "0x185D2F760")]
	public static void LNNHONMKPFF(float4 PMFLLGPMIME, CBCFNGPOECM PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0800", Offset = "0x5DEF000", VA = "0x185DF0800")]
	public static void LNNHONMKPFF(CBCFNGPOECM PMFLLGPMIME, quaternion PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0760", Offset = "0x5DEEF60", VA = "0x185DF0760")]
	public static void LNNHONMKPFF(quaternion PMFLLGPMIME, CBCFNGPOECM PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DF08B0", Offset = "0x5DEF0B0", VA = "0x185DF08B0")]
	public static void LNNHONMKPFF(Entity PMFLLGPMIME, OAHHCDDHILP PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0850", Offset = "0x5DEF050", VA = "0x185DF0850")]
	public static void LNNHONMKPFF(OAHHCDDHILP PMFLLGPMIME, Entity PCLAHFAGOCH, NMKCGFFAGNA MDDDOHLBGMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal class LHPJLPGCNJN : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E00A00", Offset = "0x5DFF200", VA = "0x185E00A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E00AB0", Offset = "0x5DFF2B0", VA = "0x185E00AB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public LHPJLPGCNJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[PDJDECBPOKH(EOGANNGNDMH.OMRoom)]
internal class JNEDEEBHCMO : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private AIDABNJGIKJ GHEMOCKFMHP;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7630", Offset = "0x5DF5E30", VA = "0x185DF7630", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7680", Offset = "0x5DF5E80", VA = "0x185DF7680", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public JNEDEEBHCMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[UnityEngine.Scripting.Preserve]
internal class HEJCBDHMGCC : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private EntityQuery IKKCKMDOEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1240", Offset = "0x5DEFA40", VA = "0x185DF1240", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1290", Offset = "0x5DEFA90", VA = "0x185DF1290", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1320", Offset = "0x5DEFB20", VA = "0x185DF1320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public HEJCBDHMGCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[PDJDECBPOKH(EOGANNGNDMH.OMRoom)]
internal class PCHGHPICLIK : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private AIDABNJGIKJ GHEMOCKFMHP;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E05830", Offset = "0x5E04030", VA = "0x185E05830", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E05880", Offset = "0x5E04080", VA = "0x185E05880", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public PCHGHPICLIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[PDJDECBPOKH(EOGANNGNDMH.OMRoom)]
internal class LMMEJJOFECK : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private MKHOKPNBAOG EFAAPEICBJK;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E01520", Offset = "0x5DFFD20", VA = "0x185E01520", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E01570", Offset = "0x5DFFD70", VA = "0x185E01570", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public LMMEJJOFECK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[UnityEngine.Scripting.Preserve]
internal sealed class DKFNPFAKLCJ<T> : JMMMDIBDAGF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4CD8620", Offset = "0x4CD6E20", VA = "0x184CD8620", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4CD8840", Offset = "0x4CD7040", VA = "0x184CD8840", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public DKFNPFAKLCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[AOHPACHDGHC]
public class JFBEOMGIMHJ : ComponentSystem, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private FHMIKLMEDIH EFBOCBBNCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x762AF0", Offset = "0x7612F0", VA = "0x180762AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x762B70", Offset = "0x761370", VA = "0x180762B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7130", Offset = "0x5DF5930", VA = "0x185DF7130", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
	public JFBEOMGIMHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class DNONEAOGNHK : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA040", Offset = "0x5DE8840", VA = "0x185DEA040", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA240", Offset = "0x5DE8A40", VA = "0x185DEA240")]
	[UnityEngine.Scripting.Preserve]
	private void EONDKLFCGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public DNONEAOGNHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class BMDGDEBOICJ : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6BD0", Offset = "0x5DE53D0", VA = "0x185DE6BD0", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public BMDGDEBOICJ()
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
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E05780", Offset = "0x5E03F80", VA = "0x185E05780")]
		public static ObjectModelConfigAsset PBEJKHPENJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x825B10", Offset = "0x824310", VA = "0x180825B10")]
		public ObjectModelConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NJBFBAIAJFK
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E02E00", Offset = "0x5E01600", VA = "0x185E02E00")]
	public static void KGLAEINHMIP(PFECAMNMOCE ANEILBIOBIP, string ONIJGKCBNGC, JEDJBKOCEME DFEGGPKBMON, Action BIIOEMJLPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E03030", Offset = "0x5E01830", VA = "0x185E03030")]
	public static void KGLAEINHMIP(PFECAMNMOCE ANEILBIOBIP, string ONIJGKCBNGC, LKEHPHAMPJC KHCHGJHEBLH, Action BIIOEMJLPLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class JAPDAOMPDNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KHIPOGDMLBP
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class BMONBIJECCE
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly PFECAMNMOCE ANEILBIOBIP;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5DE71F0", Offset = "0x5DE59F0", VA = "0x185DE71F0")]
		public static KLEIPEFFJCP HPEGONMACHG(int MEHOBMHHMOH, CGIIEKIPGLL GOOGNEMPJCK)
		{
			return default(KLEIPEFFJCP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7160", Offset = "0x5DE5960", VA = "0x185DE7160")]
		private static JEDJBKOCEME EMNAFGEFHIO(CGIIEKIPGLL APPFCKJHCLO, JEDJBKOCEME LCKJGGMPGGN)
		{
			return default(JEDJBKOCEME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6D10", Offset = "0x5DE5510", VA = "0x185DE6D10")]
		private static void CAMJBKNDIBP(JEDJBKOCEME NKEIKBBGONI, JEDJBKOCEME FNHPBCOKONI, KLEIPEFFJCP LFHNIGHPLBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5DE6E90", Offset = "0x5DE5690", VA = "0x185DE6E90")]
		public static int DKBGBLDKJGH(GameObject AAAOHJGLLEG, EJKJGDNPOAM BCDJECCCDGH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static MDHODIMGPDH MMGBPKFAGPP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static EMFAHBILPMG IBCFJAAICJF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static EMFAHBILPMG PGDDJJAGELC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5DFBD60", Offset = "0x5DFA560", VA = "0x185DFBD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool GJMBOKINPHL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB7E0", Offset = "0x5DF9FE0", VA = "0x185DFB7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static FHMIKLMEDIH EFBOCBBNCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5DFBBA0", Offset = "0x5DFA3A0", VA = "0x185DFBBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB9C0", Offset = "0x5DFA1C0", VA = "0x185DFB9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static ALHOKAPBJCK EMECCKDFMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB950", Offset = "0x5DFA150", VA = "0x185DFB950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC7A0", Offset = "0x5DFAFA0", VA = "0x185DFC7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static GKGBAHAPFBD IABBJBIJJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC040", Offset = "0x5DFA840", VA = "0x185DFC040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static JDCOPOKIPOM IDKAMGHJFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC340", Offset = "0x5DFAB40", VA = "0x185DFC340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool EMICMDNOLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5DFBFD0", Offset = "0x5DFA7D0", VA = "0x185DFBFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool PIJHEHBHIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC950", Offset = "0x5DFB150", VA = "0x185DFC950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static EEKEIMNDBGI BKPEDCHIMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC0B0", Offset = "0x5DFA8B0", VA = "0x185DFC0B0")]
		get
		{
			return default(EEKEIMNDBGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool ONNCBBBBLCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC150", Offset = "0x5DFA950", VA = "0x185DFC150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static byte JCFHADCIJEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC550", Offset = "0x5DFAD50", VA = "0x185DFC550")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static byte MPCGONGADBB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool IMMDHHAOPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC9A0", Offset = "0x5DFB1A0", VA = "0x185DFC9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool IIGPDGCGNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC3B0", Offset = "0x5DFABB0", VA = "0x185DFC3B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC650", Offset = "0x5DFAE50", VA = "0x185DFC650")]
	public static void OKKLBBOIAOD(MDHODIMGPDH IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBC20", Offset = "0x5DFA420", VA = "0x185DFBC20")]
	public static JEDJBKOCEME FMGHHHBPNNI(GameObject AAAOHJGLLEG)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBA30", Offset = "0x5DFA230", VA = "0x185DFBA30")]
	public static EEKEIMNDBGI CIMNIINOJIK(KLEIPEFFJCP LFHNIGHPLBN)
	{
		return default(EEKEIMNDBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC400", Offset = "0x5DFAC00", VA = "0x185DFC400")]
	public static bool MPCCFNHJAPI(GameObject AAAOHJGLLEG, [Out] KLEIPEFFJCP LFHNIGHPLBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBE90", Offset = "0x5DFA690", VA = "0x185DFBE90")]
	public static EMCHIFDMDCK GGGEOAKANAC(IEnumerable<NDNCPECEFHH> HPFBMIPPKKG)
	{
		return default(EMCHIFDMDCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5DFBAB0", Offset = "0x5DFA2B0", VA = "0x185DFBAB0")]
	private static EMFAHBILPMG DGIHCCBCJJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5DFC810", Offset = "0x5DFB010", VA = "0x185DFC810")]
	private static bool PALOPGOBGBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FCMEOAPINOM
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC590", Offset = "0x5DEAD90", VA = "0x185DEC590")]
	public static bool OJJPKKJKBEL(HFBIDPNKJHF JIMHFHPEEID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC170", Offset = "0x5DEA970", VA = "0x185DEC170")]
	public static HFBIDPNKJHF JKCLJMACCFA(GameObject AAAOHJGLLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC3B0", Offset = "0x5DEABB0", VA = "0x185DEC3B0")]
	public static HFBIDPNKJHF JKCLJMACCFA(GameObject AAAOHJGLLEG, KLEIPEFFJCP LFHNIGHPLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBFB0", Offset = "0x5DEA7B0", VA = "0x185DEBFB0")]
	public static bool AINCJMJKAMI(GameObject LCKCBKEEMNI, string LKJPOGNICEK, bool IGBJKDNKAMJ)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DisembodiedObjectView : MonoBehaviour, BJHONPBLHDC
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool KCOGMFJCNBD
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public JEDJBKOCEME MIIIPHIJIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(JEDJBKOCEME);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD114F0", Offset = "0xD0FCF0", VA = "0x180D114F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA2D0", Offset = "0x5DE8AD0", VA = "0x185DEA2D0")]
		public void SetName(string BOBHOMKFHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public sealed class EmbodiedObject : MonoBehaviour, HFBIDPNKJHF, BJHONPBLHDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly PFECAMNMOCE ANEILBIOBIP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private const string MDBKOANEGOL = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private GHPHGOGKJOP KAFJGNMGLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JEDJBKOCEME ADMPFLAIEKN;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public JEDJBKOCEME MIIIPHIJIPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5DEAE70", Offset = "0x5DE9670", VA = "0x185DEAE70", Slot = "15")]
			get
			{
				return default(JEDJBKOCEME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public EEKEIMNDBGI HAMOKPMJNAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5DEAF20", Offset = "0x5DE9720", VA = "0x185DEAF20", Slot = "6")]
			get
			{
				return default(EEKEIMNDBGI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool KCOGMFJCNBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5DEAE60", Offset = "0x5DE9660", VA = "0x185DEAE60", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GHPHGOGKJOP JCKCILLABLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x86E4E0", Offset = "0x86CCE0", VA = "0x18086E4E0", Slot = "7")]
			get
			{
				return default(GHPHGOGKJOP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private GIMAKLLKNAL JBIHOCPBPAP
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5DEA630", Offset = "0x5DE8E30", VA = "0x185DEA630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool NDJPHOJOLCL
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7FD4F0", Offset = "0x7FBCF0", VA = "0x1807FD4F0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x867C80", Offset = "0x866480", VA = "0x180867C80", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> KBHOELOLEEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5DEAD00", Offset = "0x5DE9500", VA = "0x185DEAD00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5DEAF30", Offset = "0x5DE9730", VA = "0x185DEAF30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<HFBIDPNKJHF> NKJOAKEGNMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5DEADB0", Offset = "0x5DE95B0", VA = "0x185DEADB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5DEAFE0", Offset = "0x5DE97E0", VA = "0x185DEAFE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA450", Offset = "0x5DE8C50", VA = "0x185DEA450")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5DEAA60", Offset = "0x5DE9260", VA = "0x185DEAA60", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA6E0", Offset = "0x5DE8EE0", VA = "0x185DEA6E0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5DEAA20", Offset = "0x5DE9220", VA = "0x185DEAA20", Slot = "10")]
		public void OnEmbody(HLLCKCNCCJD LPBOBKJPICK, JEDJBKOCEME ADMPFLAIEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5DEAA50", Offset = "0x5DE9250", VA = "0x185DEAA50", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA920", Offset = "0x5DE9120", VA = "0x185DEA920", Slot = "12")]
		public void OnDisembody(bool HJMJHNEJCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5DEAB90", Offset = "0x5DE9390", VA = "0x185DEAB90")]
		private void PNMNCJOOCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA6A0", Offset = "0x5DE8EA0", VA = "0x185DEA6A0", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA21910", Offset = "0xA20110", VA = "0x180A21910", Slot = "9")]
		private GameObject AHEMIEBCFJD()
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
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleComponent]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override KNBFLDNEILM FDFICFOKLLL
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5E07950", Offset = "0x5E06150", VA = "0x185E07950", Slot = "6")]
			get
			{
				return default(KNBFLDNEILM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E07900", Offset = "0x5E06100", VA = "0x185E07900")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DisallowMultipleComponent]
	public class TransformEntity : MonoBehaviour, BJHONPBLHDC
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly PFECAMNMOCE ANEILBIOBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private KNBFLDNEILM prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JEDJBKOCEME JBPJNGFGLPC;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual KNBFLDNEILM FDFICFOKLLL
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x76CBA0", Offset = "0x76B3A0", VA = "0x18076CBA0", Slot = "6")]
			get
			{
				return default(KNBFLDNEILM);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x76C460", Offset = "0x76AC60", VA = "0x18076C460", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public JEDJBKOCEME MIIIPHIJIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x30C3220", Offset = "0x30C1A20", VA = "0x1830C3220", Slot = "5")]
			get
			{
				return default(JEDJBKOCEME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool KCOGMFJCNBD
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1008680", Offset = "0x1006E80", VA = "0x181008680", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x1008690", Offset = "0x1006E90", VA = "0x181008690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		internal Entity DKHAEHLCKFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5E07AE0", Offset = "0x5E062E0", VA = "0x185E07AE0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal HOKKMAFBPHI HMDFIBLPPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5E07EB0", Offset = "0x5E066B0", VA = "0x185E07EB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal CECLHBPNMGM MCMPNLKGJLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5E07970", Offset = "0x5E06170", VA = "0x185E07970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E07960", Offset = "0x5E06160", VA = "0x185E07960")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5E079F0", Offset = "0x5E061F0", VA = "0x185E079F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5E07B00", Offset = "0x5E06300", VA = "0x185E07B00")]
		internal void MJKJMKCCJMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5E07E10", Offset = "0x5E06610", VA = "0x185E07E10")]
		private bool OHNCEPBHHID()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E07F40", Offset = "0x5E06740", VA = "0x185E07F40")]
		private void PALEANFGCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E079F0", Offset = "0x5E061F0", VA = "0x185E079F0")]
		internal void FBKBPDEEJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E07EC0", Offset = "0x5E066C0", VA = "0x185E07EC0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E08000", Offset = "0x5E06800", VA = "0x185E08000")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[GJLJLBIABKM(typeof(EMFAHBILPMG), new string[] { })]
[EJJPDJHBEFJ(typeof(ELEFKBAOJOL))]
[EJJPDJHBEFJ(typeof(LAKKFPDMDNI))]
public class FHEPADHHJKC : EMFAHBILPMG, GIFDCKIGEDL, LAKKFPDMDNI, IDisposable, ELEFKBAOJOL
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly ProfilerMarker AICDDNMCGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private MDHODIMGPDH CNFBLEFPNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private GIMAKLLKNAL BKIDEJBLOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private KOALBKCLEGM KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private FBPCDIFNPDJ PDAOKHJIHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public MDHODIMGPDH EFBOCBBNCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public KOALBKCLEGM AAHFJAMBBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public FBPCDIFNPDJ GLPMIAODPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x762AE0", Offset = "0x7612E0", VA = "0x180762AE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PLFIBBCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CB0", Offset = "0x7B54B0", VA = "0x1807B6CB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public KJLFDPOCKCE EFMELCOCEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x807540", Offset = "0x805D40", VA = "0x180807540", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(KJLFDPOCKCE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x807530", Offset = "0x805D30", VA = "0x180807530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool HAOKFJJANAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xDB6070", Offset = "0xDB4870", VA = "0x180DB6070", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A140", Offset = "0x1C28940", VA = "0x181C2A140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public DMCLIOLBKII LMEMNHLLCGK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5B0", Offset = "0x7DBDB0", VA = "0x1807DD5B0", Slot = "10")]
		get
		{
			return default(DMCLIOLBKII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5DECC80", Offset = "0x5DEB480", VA = "0x185DECC80", Slot = "14")]
	private void MBNEGBMNDPB(bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5DECAD0", Offset = "0x5DEB2D0", VA = "0x185DECAD0")]
	public static FHEPADHHJKC GFPEABNIECK(MDHODIMGPDH CNFBLEFPNKP, JEALDGGAOGA PPFELFEMNEO = JEALDGGAOGA.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void JGAFHGLFFCD(MDHODIMGPDH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void FLKACECOJPG(MDHODIMGPDH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC950", Offset = "0x5DEB150", VA = "0x185DEC950", Slot = "11")]
	public void EAPAJNCJCIO(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xBAF530", Offset = "0xBADD30", VA = "0x180BAF530")]
	private void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC790", Offset = "0x5DEAF90", VA = "0x185DEC790")]
	private void ALPOPMKMCFE(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEC8C0", Offset = "0x5DEB0C0", VA = "0x185DEC8C0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public FHEPADHHJKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class AIMJIJFAMOE
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum JEALDGGAOGA
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
[GJLJLBIABKM(typeof(FBPCDIFNPDJ), new string[] { })]
public class AFCDMGKCEMH : FBPCDIFNPDJ, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly PFECAMNMOCE HKBPABOKHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private MDHODIMGPDH CNFBLEFPNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private ELEFKBAOJOL NJBMMNMHAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private KOALBKCLEGM KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private EMFAHBILPMG IBCFJAAICJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private FBKLHLEKBGM DCDGDLJLGPD;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool OGJFKDFIIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3FD0", Offset = "0x5DE27D0", VA = "0x185DE3FD0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action NMFGDAJNFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3F30", Offset = "0x5DE2730", VA = "0x185DE3F30", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5DE3D70", Offset = "0x5DE2570", VA = "0x185DE3D70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3E60", Offset = "0x5DE2660", VA = "0x185DE3E60", Slot = "12")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3B70", Offset = "0x5DE2370", VA = "0x185DE3B70", Slot = "6")]
	public void DBLFJEFFIEC(bool EPKJMINCAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3E10", Offset = "0x5DE2610", VA = "0x185DE3E10", Slot = "7")]
	public bool FELPLDHBPNL(ByteString BGGDIKOMABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3D60", Offset = "0x5DE2560", VA = "0x185DE3D60", Slot = "11")]
	public void DFHLKILPECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x16344D0", Offset = "0x1632CD0", VA = "0x1816344D0", Slot = "9")]
	public void IHKIJDKGJEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4040", Offset = "0x5DE2840", VA = "0x185DE4040", Slot = "10")]
	public void NFFICPMCDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public AFCDMGKCEMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public class ANFCKCHPDEF<T> : DOGKHPFFKKJ<T>, MONKJDIIJEC<KLEIPEFFJCP, T>, EMOGJLILLHF<KLEIPEFFJCP>, HHEDIONCJJG, IDisposable, MNOPJOLALGH where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly EMOGJLILLHF<Entity> OLJMCOBAMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private Delegate IDACEPFPPNJ;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string MJLCABAKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x36D1CC0", Offset = "0x36D04C0", VA = "0x1836D1CC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Type OHBHGCLHIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x36D1740", Offset = "0x36CFF40", VA = "0x1836D1740", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public BEMIKKNENEH BLNGLHDAFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x36D69B0", Offset = "0x36D51B0", VA = "0x1836D69B0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int MMNONFIBBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x36D7040", Offset = "0x36D5840", VA = "0x1836D7040", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public NLEALEPHPHJ DDPGAEFDEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x36D62C0", Offset = "0x36D4AC0", VA = "0x1836D62C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event AHNAMBIDMKA<KLEIPEFFJCP> BDAOFCBGCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x36D8E00", Offset = "0x36D7600", VA = "0x1836D8E00", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x36D94E0", Offset = "0x36D7CE0", VA = "0x1836D94E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3435D20", Offset = "0x3434520", VA = "0x183435D20")]
	public ANFCKCHPDEF(EMOGJLILLHF<Entity> OLJMCOBAMDO, HOKKMAFBPHI BAKIPPCJAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x36D66B0", Offset = "0x36D4EB0", VA = "0x1836D66B0")]
	private Entity KPKHGEOEKHP(KLEIPEFFJCP LFHNIGHPLBN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x36D6480", Offset = "0x36D4C80", VA = "0x1836D6480")]
	private KLEIPEFFJCP KPKHGEOEKHP(Entity MFFDEAINOPL)
	{
		return default(KLEIPEFFJCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x36D05C0", Offset = "0x36CEDC0", VA = "0x1836D05C0", Slot = "4")]
	public T BCFBOGKIONB(KLEIPEFFJCP LFHNIGHPLBN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x36CDC90", Offset = "0x36CC490", VA = "0x1836CDC90")]
	public bool ABNCEPDOIJI(KLEIPEFFJCP LFHNIGHPLBN, [In] T EPKJMINCAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x36D1E00", Offset = "0x36D0600", VA = "0x1836D1E00", Slot = "7")]
	public bool CHBJDEDBAAF(KLEIPEFFJCP LFHNIGHPLBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x36D1530", Offset = "0x36CFD30", VA = "0x1836D1530", Slot = "8")]
	public void BCFBOGKIONB(KLEIPEFFJCP LFHNIGHPLBN, IHMFBHLJOII IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x36CE2D0", Offset = "0x36CCAD0", VA = "0x1836CE2D0", Slot = "9")]
	public bool ABNCEPDOIJI(KLEIPEFFJCP LFHNIGHPLBN, LELJJGNMHGH EPKJMINCAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x342A800", Offset = "0x3429000", VA = "0x18342A800", Slot = "16")]
	public void GPHDFGIHBIL(MLPMOOACKBB MAAGNCIMNAP, [Optional] object LIODJEBJPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x36D2B80", Offset = "0x36D1380", VA = "0x1836D2B80", Slot = "10")]
	public bool FGACGACICLO(KLEIPEFFJCP PCLAHFAGOCH, KLEIPEFFJCP PMFLLGPMIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x36D2580", Offset = "0x36D0D80", VA = "0x1836D2580", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x36DBA00", Offset = "0x36DA200", VA = "0x1836DBA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x36D9FE0", Offset = "0x36D87E0", VA = "0x1836D9FE0")]
	private void PKMKIGGLIBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x36D8730", Offset = "0x36D6F30", VA = "0x1836D8730")]
	private void OHBNMKODAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x36D45B0", Offset = "0x36D2DB0", VA = "0x1836D45B0")]
	private void HNIHMIGLFFE(Entity MFFDEAINOPL, [In] LELJJGNMHGH DMLGIICOGHN, [In] LELJJGNMHGH EPKJMINCAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x36D6310", Offset = "0x36D4B10", VA = "0x1836D6310")]
	private void KLIEJAJFDEC(Entity MFFDEAINOPL, [In] LELJJGNMHGH DMLGIICOGHN, [In] LELJJGNMHGH EPKJMINCAGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class ABDOJNLIFHO<T> : OCJCHIJHGBA<T>, MONKJDIIJEC<JEDJBKOCEME, T>, EMOGJLILLHF<JEDJBKOCEME>, HHEDIONCJJG, IDisposable, AMEANBJHGMM where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly EMOGJLILLHF<Entity> OLJMCOBAMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private Delegate IDACEPFPPNJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string MJLCABAKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3429460", Offset = "0x3427C60", VA = "0x183429460", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Type OHBHGCLHIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3428CD0", Offset = "0x34274D0", VA = "0x183428CD0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public BEMIKKNENEH BLNGLHDAFMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x342F580", Offset = "0x342DD80", VA = "0x18342F580", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int MMNONFIBBKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x342F620", Offset = "0x342DE20", VA = "0x18342F620", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NLEALEPHPHJ DDPGAEFDEBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x342EE70", Offset = "0x342D670", VA = "0x18342EE70", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event AHNAMBIDMKA<JEDJBKOCEME> BDAOFCBGCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3431F40", Offset = "0x3430740", VA = "0x183431F40", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3432D00", Offset = "0x3431500", VA = "0x183432D00", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3435D20", Offset = "0x3434520", VA = "0x183435D20")]
	public ABDOJNLIFHO(EMOGJLILLHF<Entity> OLJMCOBAMDO, HOKKMAFBPHI BAKIPPCJAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x342F0C0", Offset = "0x342D8C0", VA = "0x18342F0C0")]
	private Entity KPKHGEOEKHP(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x342F0F0", Offset = "0x342D8F0", VA = "0x18342F0F0")]
	private JEDJBKOCEME KPKHGEOEKHP(Entity MFFDEAINOPL)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3428110", Offset = "0x3426910", VA = "0x183428110", Slot = "4")]
	public T BCFBOGKIONB(JEDJBKOCEME JBPJNGFGLPC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3423AF0", Offset = "0x34222F0", VA = "0x183423AF0")]
	public bool ABNCEPDOIJI(JEDJBKOCEME JBPJNGFGLPC, [In] T EPKJMINCAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3429F50", Offset = "0x3428750", VA = "0x183429F50", Slot = "7")]
	public bool CHBJDEDBAAF(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3426DF0", Offset = "0x34255F0", VA = "0x183426DF0", Slot = "8")]
	public void BCFBOGKIONB(JEDJBKOCEME JBPJNGFGLPC, IHMFBHLJOII IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x34239E0", Offset = "0x34221E0", VA = "0x1834239E0", Slot = "9")]
	public bool ABNCEPDOIJI(JEDJBKOCEME JBPJNGFGLPC, LELJJGNMHGH EPKJMINCAGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x342A800", Offset = "0x3429000", VA = "0x18342A800", Slot = "16")]
	public void GPHDFGIHBIL(MLPMOOACKBB MAAGNCIMNAP, [Optional] object LIODJEBJPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x342A600", Offset = "0x3428E00", VA = "0x18342A600", Slot = "10")]
	public bool FGACGACICLO(JEDJBKOCEME PCLAHFAGOCH, JEDJBKOCEME PMFLLGPMIME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3434D20", Offset = "0x3433520", VA = "0x183434D20")]
	private void PKMKIGGLIBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3430B20", Offset = "0x342F320", VA = "0x183430B20")]
	private void OHBNMKODAFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x342E6F0", Offset = "0x342CEF0", VA = "0x18342E6F0")]
	private void HNIHMIGLFFE(Entity MFFDEAINOPL, [In] LELJJGNMHGH DMLGIICOGHN, [In] LELJJGNMHGH EPKJMINCAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x342F050", Offset = "0x342D850", VA = "0x18342F050")]
	private void KLIEJAJFDEC(Entity MFFDEAINOPL, [In] LELJJGNMHGH DMLGIICOGHN, [In] LELJJGNMHGH EPKJMINCAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2FC7070", Offset = "0x2FC5870", VA = "0x182FC7070", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x34358A0", Offset = "0x34340A0", VA = "0x1834358A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class HAIJJGGOANE : HLHILOHMCCK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> OLDKNDICDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private int CPOINCHGJNJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> EBLDPCNAJMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA70070", Offset = "0xA6E870", VA = "0x180A70070", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int ABNIMCNEPAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x807520", Offset = "0x805D20", VA = "0x180807520", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3E7D960", Offset = "0x3E7C160", VA = "0x183E7D960")]
	public HAIJJGGOANE(NativeArray<EntityRemapUtility.EntityRemapInfo> OLDKNDICDPP, int CPOINCHGJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0620", Offset = "0x5DEEE20", VA = "0x185DF0620", Slot = "6")]
	public JEDJBKOCEME FNCLAMKMMGO(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF05E0", Offset = "0x5DEEDE0", VA = "0x185DF05E0", Slot = "8")]
	public LocalId FNCLAMKMMGO(LocalId MFFDEAINOPL)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0580", Offset = "0x5DEED80", VA = "0x185DF0580", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
[GJLJLBIABKM(typeof(PFEKJOPEDBB), new string[] { "Editor" })]
public sealed class PFEKJOPEDBB
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate void CNAAMGGIMDC(KLEIPEFFJCP LCAJFKKKEOL, ALDBGJKBJJO KOIMDAJNDOD, bool OBNLDHPNNOI);

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate void OBCBLHOKJGG(KLEIPEFFJCP LCAJFKKKEOL, bool OBNLDHPNNOI);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void NPHGFDOEFMC(KLEIPEFFJCP LCAJFKKKEOL, BCJCKPDGHHM OLJMCOBAMDO, [In] LELJJGNMHGH IFKKLLBODIE, bool OBNLDHPNNOI);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public PFEKJOPEDBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Flags]
public enum MACHANMKFIF
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	Main = 2,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Load = 4,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	NetworkReceive = 8,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	Suppressed = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
[GJLJLBIABKM(typeof(DKDHCMJLDBA), new string[] { "Editor" })]
public sealed class DKDHCMJLDBA
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate void ILPBJPOJPGL(KLEIPEFFJCP LFHNIGHPLBN, ALDBGJKBJJO KOIMDAJNDOD, MACHANMKFIF PPFELFEMNEO);

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate void LCDFOHEDJOB(KLEIPEFFJCP LFHNIGHPLBN, MACHANMKFIF PPFELFEMNEO);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void BCMKDCOOLEN(KLEIPEFFJCP LFHNIGHPLBN, BCJCKPDGHHM OLJMCOBAMDO, LELJJGNMHGH HCFJKNGNHKA, LELJJGNMHGH NIGNLJEOLLK, MACHANMKFIF PPFELFEMNEO);

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void FNMAJMOKEED(MMNLNLKKOGE EBICOEDOGKC, ReadOnlySpan<byte> AJPCNFDACDH);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public DKDHCMJLDBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[GJLJLBIABKM(typeof(JDCOPOKIPOM), new string[] { })]
internal class DAANOCBNJCN : JDCOPOKIPOM, OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private enum Flag
	{
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		Allowed,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		AllowedInRoomV1,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		RoomUpgrade,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Clone,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		Copy,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		Undo,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		UndoCreation,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		Physics,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		SerializationV4,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		HierarchyViewVisible,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		InventionLoading,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		RoomSaving,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		RoomPublishing
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class KMJCDAGKAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public KMJCDAGKAOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5DFCAF0", Offset = "0x5DFB2F0", VA = "0x185DFCAF0")]
		internal object EJAENJGGKLK((string name, bool value) a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[MCMLPKDBFJE]
	private JCIAOBDAFHE KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[MCMLPKDBFJE]
	private LAKKFPDMDNI ICGNKEDIKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private NativeBitArray FDKJHGILMDN;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public MNFBAAHKEIO NMCOEMBMGII
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9A20", Offset = "0x5DE8220", VA = "0x185DE9A20", Slot = "4")]
		get
		{
			return default(MNFBAAHKEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public MNFBAAHKEIO FLCKHBFKILB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9BB0", Offset = "0x5DE83B0", VA = "0x185DE9BB0", Slot = "5")]
		get
		{
			return default(MNFBAAHKEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public MNFBAAHKEIO HNDLGNHGPIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9740", Offset = "0x5DE7F40", VA = "0x185DE9740", Slot = "6")]
		get
		{
			return default(MNFBAAHKEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public MNFBAAHKEIO FGACGACICLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9640", Offset = "0x5DE7E40", VA = "0x185DE9640", Slot = "7")]
		get
		{
			return default(MNFBAAHKEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public MNFBAAHKEIO DPMJCCMAIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9BA0", Offset = "0x5DE83A0", VA = "0x185DE9BA0", Slot = "8")]
		get
		{
			return default(MNFBAAHKEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public MNFBAAHKEIO FGPEGCEMNMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9710", Offset = "0x5DE7F10", VA = "0x185DE9710", Slot = "9")]
		get
		{
			return default(MNFBAAHKEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public MNFBAAHKEIO DMOAKNOPDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9BD0", Offset = "0x5DE83D0", VA = "0x185DE9BD0", Slot = "10")]
		get
		{
			return default(MNFBAAHKEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MNFBAAHKEIO IDHALOIJDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9730", Offset = "0x5DE7F30", VA = "0x185DE9730", Slot = "11")]
		get
		{
			return default(MNFBAAHKEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MNFBAAHKEIO NPGBHPCMHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE95E0", Offset = "0x5DE7DE0", VA = "0x185DE95E0", Slot = "12")]
		get
		{
			return default(MNFBAAHKEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MNFBAAHKEIO EKGIBGFKKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5DE95D0", Offset = "0x5DE7DD0", VA = "0x185DE95D0", Slot = "13")]
		get
		{
			return default(MNFBAAHKEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public MNFBAAHKEIO FCBNLHCPKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9700", Offset = "0x5DE7F00", VA = "0x185DE9700", Slot = "14")]
		get
		{
			return default(MNFBAAHKEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public MNFBAAHKEIO OKOLLGNKKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9720", Offset = "0x5DE7F20", VA = "0x185DE9720", Slot = "15")]
		get
		{
			return default(MNFBAAHKEIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private int FFMNEJJNDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9530", Offset = "0x5DE7D30", VA = "0x185DE9530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9A40", Offset = "0x5DE8240", VA = "0x185DE9A40", Slot = "16")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9650", Offset = "0x5DE7E50", VA = "0x185DE9650", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5DE95F0", Offset = "0x5DE7DF0", VA = "0x185DE95F0")]
	private void CGFFGLOILPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9750", Offset = "0x5DE7F50", VA = "0x185DE9750")]
	private void HBLEDHCABKE(Flag BDGFIKIEHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5DE99A0", Offset = "0x5DE81A0", VA = "0x185DE99A0")]
	private MNFBAAHKEIO IDHPGPGKIIH(Flag BDGFIKIEHCP)
	{
		return default(MNFBAAHKEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9510", Offset = "0x5DE7D10", VA = "0x185DE9510")]
	private MNFBAAHKEIO ACGGOOAOJJH(Flag BDGFIKIEHCP)
	{
		return default(MNFBAAHKEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public DAANOCBNJCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[GJLJLBIABKM(typeof(OBKNLCGGCNM), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
internal class OBKNLCGGCNM : GAJGABMNKBI
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5E045B0", Offset = "0x5E02DB0", VA = "0x185E045B0", Slot = "4")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public OBKNLCGGCNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(GDGAJNNBFHC), new string[] { })]
internal class GDGAJNNBFHC : OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly PFECAMNMOCE GNLAPCCEDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[MCMLPKDBFJE]
	private GIBCPELIMEL KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[MCMLPKDBFJE]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[MCMLPKDBFJE]
	private CECLHBPNMGM NBODHKFBPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private FBKLHLEKBGM DCDGDLJLGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private EntityQuery PBEKHEIOGLI;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5DF00C0", Offset = "0x5DEE8C0", VA = "0x185DF00C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5DEED70", Offset = "0x5DED570", VA = "0x185DEED70", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE270", Offset = "0x5DECA70", VA = "0x185DEE270", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE280", Offset = "0x5DECA80", VA = "0x185DEE280")]
	public EMCHIFDMDCK GGGEOAKANAC(IEnumerable<NDNCPECEFHH> HLDGHNFNJDM)
	{
		return default(EMCHIFDMDCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5DED850", Offset = "0x5DEC050", VA = "0x185DED850")]
	public static bool ABCDKMFLAHH(NDNCPECEFHH FDOGBBKMGKO, [Out] KLEIPEFFJCP LFHNIGHPLBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF4A0", Offset = "0x5DEDCA0", VA = "0x185DEF4A0")]
	private EMCHIFDMDCK KHFNDJMPEBL(IEnumerable<NDNCPECEFHH> HLDGHNFNJDM)
	{
		return default(EMCHIFDMDCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDBC0", Offset = "0x5DEC3C0", VA = "0x185DEDBC0")]
	private (List<NDNCPECEFHH>, int[], int) AIIONOPMOIG(IEnumerable<NDNCPECEFHH> HLDGHNFNJDM)
	{
		return default((List<NDNCPECEFHH>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0110", Offset = "0x5DEE910", VA = "0x185DF0110")]
	private Dictionary<KLEIPEFFJCP, (NDNCPECEFHH, int)> OKDJIPGIDGK(IEnumerable<NDNCPECEFHH> HLDGHNFNJDM, Entity EJCKEKLJFFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE380", Offset = "0x5DECB80", VA = "0x185DEE380")]
	private void HKALEDNBKLJ(Dictionary<KLEIPEFFJCP, (NDNCPECEFHH request, int srcIndex)> OCFMFKJKCPM, IEnumerable<NDNCPECEFHH> HLDGHNFNJDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5DED950", Offset = "0x5DEC150", VA = "0x185DED950")]
	private void AHANAMJLLAL(Dictionary<KLEIPEFFJCP, (NDNCPECEFHH request, int srcIndex)> OCFMFKJKCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEFD0", Offset = "0x5DED7D0", VA = "0x185DEEFD0")]
	private void JHPALAGMCLL(Dictionary<KLEIPEFFJCP, (NDNCPECEFHH request, int srcIndex)> OCFMFKJKCPM, KLEIPEFFJCP LFHNIGHPLBN, string BOBHOMKFHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDDC0", Offset = "0x5DEC5C0", VA = "0x185DEDDC0")]
	private void BCHNLPCELEP(Dictionary<KLEIPEFFJCP, (NDNCPECEFHH request, int srcIndex)> OCFMFKJKCPM, Entity EJCKEKLJFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE990", Offset = "0x5DED190", VA = "0x185DEE990")]
	private (List<NDNCPECEFHH>, int[], int) INHDLPNEJPM(Dictionary<KLEIPEFFJCP, (NDNCPECEFHH request, int srcIndex)> OCFMFKJKCPM, Entity EJCKEKLJFFB)
	{
		return default((List<NDNCPECEFHH>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF01D0", Offset = "0x5DEE9D0", VA = "0x185DF01D0")]
	private void PIPEEKJCEFA(Dictionary<KLEIPEFFJCP, (NDNCPECEFHH request, int srcIndex)> OCFMFKJKCPM, List<NDNCPECEFHH> DCLFNPPAOGJ, int[] OGOEELLJHKP, NativeArray<Entity> EFLDIIILPLM, NativeList<KLEIPEFFJCP> BMJMOJMCGHB, NativeList<Entity> FHCPJHIKJIE, Entity EJCKEKLJFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFB60", Offset = "0x5DEE360", VA = "0x185DEFB60")]
	private static bool MCBIAGKPJMO(Entity MFFDEAINOPL, ComponentDataFromEntity<ParentData> KKHNKDFMIBO, Entity EJCKEKLJFFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFD50", Offset = "0x5DEE550", VA = "0x185DEFD50")]
	private void NPKEBIOKBAO(Dictionary<KLEIPEFFJCP, (NDNCPECEFHH request, int srcIndex)> OCFMFKJKCPM, List<NDNCPECEFHH> DCLFNPPAOGJ, int[] OGOEELLJHKP, NativeList<Entity> FHCPJHIKJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE770", Offset = "0x5DECF70", VA = "0x185DEE770")]
	private NativeList<KLEIPEFFJCP> HPKAMMMKOLI(Dictionary<KLEIPEFFJCP, (NDNCPECEFHH request, int srcIndex)> OCFMFKJKCPM)
	{
		return default(NativeList<KLEIPEFFJCP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF990", Offset = "0x5DEE190", VA = "0x185DEF990")]
	private NativeArray<Entity> LFFBJNDOJNG(NativeList<KLEIPEFFJCP> BMJMOJMCGHB)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFC30", Offset = "0x5DEE430", VA = "0x185DEFC30")]
	private static void NKPMNOLNGKP(Dictionary<KLEIPEFFJCP, (NDNCPECEFHH request, int srcIndex)> OCFMFKJKCPM, KLEIPEFFJCP LFHNIGHPLBN, NDNCPECEFHH FDOGBBKMGKO, string BOBHOMKFHJB, int HGBBMDONDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE1B0", Offset = "0x5DEC9B0", VA = "0x185DEE1B0")]
	private void BPMIFMEOEOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public GDGAJNNBFHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[GJLJLBIABKM(typeof(HLLHFLMFLOO), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
internal class HLLHFLMFLOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	public void DHAMLOHCNJA(string BOBHOMKFHJB, EntityManager DHDOKMIFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public HLLHFLMFLOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[GJLJLBIABKM(typeof(FBKLHLEKBGM), new string[] { })]
[EJJPDJHBEFJ(typeof(AOLNGGEIGHK))]
internal class AOLNGGEIGHK : FBKLHLEKBGM, IDisposable, OILIFCGGAMK, HLEOPNBKPID
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly PFECAMNMOCE HKBPABOKHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[MCMLPKDBFJE]
	private KOALBKCLEGM KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[MCMLPKDBFJE]
	private FBPCDIFNPDJ PDAOKHJIHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[MCMLPKDBFJE]
	private FLFJGEGKAJH CDJEKMIHKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EMFAHBILPMG IBCFJAAICJF;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool DCHEEEBHADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CB0", Offset = "0x7B54B0", VA = "0x1807B6CB0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6890", Offset = "0x7B5090", VA = "0x1807B6890", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool CBAHOLKLKNF
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x10A7630", Offset = "0x10A5E30", VA = "0x1810A7630", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool ANAJIHMOHHD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x807540", Offset = "0x805D40", VA = "0x180807540", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x807530", Offset = "0x805D30", VA = "0x180807530", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public CGIIEKIPGLL CHMEEMGNLAG
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x762D40", Offset = "0x761540", VA = "0x180762D40", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x762AF0", Offset = "0x7612F0", VA = "0x180762AF0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4E10", Offset = "0x5DE3610", VA = "0x185DE4E10", Slot = "15")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4230", Offset = "0x5DE2A30", VA = "0x185DE4230", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5DE45D0", Offset = "0x5DE2DD0", VA = "0x185DE45D0", Slot = "8")]
	public EJKJGDNPOAM DBLNJICLIJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5DE49C0", Offset = "0x5DE31C0", VA = "0x185DE49C0")]
	public EJKJGDNPOAM FOJGOEMNBIK(IEnumerable<JEDJBKOCEME> MGOMOGOCFIB, [In] PKIFHEFFKDB OBKIDCLEHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5130", Offset = "0x5DE3930", VA = "0x185DE5130", Slot = "10")]
	public GCBHCOCLCNM NNKIPHEIGCA(ByteString BGGDIKOMABC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4420", Offset = "0x5DE2C20", VA = "0x185DE4420")]
	public AKFDJCNPOFK CDACMPCKPIA(ByteString BGGDIKOMABC, JEDJBKOCEME KLGMOMIJPLM, [In] PKIFHEFFKDB GGJIEMCKGGE, DKFKBKKOBGP FAJOCDCHOMD, bool OCPLIKPJDLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5DE46E0", Offset = "0x5DE2EE0", VA = "0x185DE46E0", Slot = "12")]
	public void DKNLAPGFFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4C20", Offset = "0x5DE3420", VA = "0x185DE4C20", Slot = "13")]
	public EMCHIFDMDCK GGGEOAKANAC(IEnumerable<NDNCPECEFHH> HPFBMIPPKKG)
	{
		return default(EMCHIFDMDCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5DE48C0", Offset = "0x5DE30C0", VA = "0x185DE48C0")]
	public static bool FELPLDHBPNL(ByteString BGGDIKOMABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4230", Offset = "0x5DE2A30", VA = "0x185DE4230")]
	private void AEFADDLJCEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4DF0", Offset = "0x5DE35F0", VA = "0x185DE4DF0")]
	private void IDGLHNHBDDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4B50", Offset = "0x5DE3350", VA = "0x185DE4B50")]
	private void GFGDMMMMCPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5080", Offset = "0x5DE3880", VA = "0x185DE5080", Slot = "16")]
	public void MKOHONAJGCK(FHMIKLMEDIH CJDFCLLNGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public AOLNGGEIGHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4290", Offset = "0x5DE2A90", VA = "0x185DE4290", Slot = "9")]
	private EJKJGDNPOAM AMPGDFBIBGP(IEnumerable<JEDJBKOCEME> MGOMOGOCFIB, [In] PKIFHEFFKDB OBKIDCLEHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4EC0", Offset = "0x5DE36C0", VA = "0x185DE4EC0", Slot = "11")]
	private AKFDJCNPOFK MKAHNJPLJOJ(ByteString BGGDIKOMABC, JEDJBKOCEME KLGMOMIJPLM, [In] PKIFHEFFKDB GGJIEMCKGGE, DKFKBKKOBGP FAJOCDCHOMD, bool OCPLIKPJDLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[GJLJLBIABKM(typeof(KHMIANHLIDA), new string[] { })]
[EJJPDJHBEFJ(typeof(FLFJGEGKAJH))]
internal class FLFJGEGKAJH : KHMIANHLIDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[CompilerGenerated]
	private Action<HLHILOHMCCK> JGLLCADAFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[CompilerGenerated]
	private Action IBAGOEEANMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[CompilerGenerated]
	private Action<HLHILOHMCCK> CNFBGBCEEMM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action NFFICPMCDGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5DED150", Offset = "0x5DEB950", VA = "0x185DED150", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5DECF70", Offset = "0x5DEB770", VA = "0x185DECF70", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action EOEDPJLDECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5DED010", Offset = "0x5DEB810", VA = "0x185DED010", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5DED0B0", Offset = "0x5DEB8B0", VA = "0x185DED0B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC30", Offset = "0xAAE430", VA = "0x180AAFC30")]
	public void DKNLAPGFFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC70", Offset = "0xAAE470", VA = "0x180AAFC70")]
	public void DDFMCNPIDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC50", Offset = "0xAAE450", VA = "0x180AAFC50")]
	public void OKNNCHHKOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x11C7900", Offset = "0x11C6100", VA = "0x1811C7900")]
	public void LDFFJFHBEMM(HLHILOHMCCK AKGMOHLFIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x174EA00", Offset = "0x174D200", VA = "0x18174EA00")]
	public void GKLIANACKPE(HLHILOHMCCK AKGMOHLFIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public FLFJGEGKAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[GJLJLBIABKM(typeof(GKGBAHAPFBD), new string[] { })]
public class PFENANMACNC : GKGBAHAPFBD, CCGJODBGILF, GAJGABMNKBI, OILIFCGGAMK, OLNFMJBKLAF, IDisposable, PFENANMACNC.PLFFPOLHFPH
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal interface PLFFPOLHFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FECPMEHDCHO(global::NPOOFHNLFBB GBDHDLJFLIH);
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private IJIBKLNEOBB PELAJIMMKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private KJJICNHEKJM OOOPMKKKMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private PGHBFFANNIO IBCBDBLGJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private global::NPOOFHNLFBB KLGNOBIPGPE;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private OCJCHIJHGBA<JEDJBKOCEME> BPJPJIKDALM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x762D80", Offset = "0x761580", VA = "0x180762D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5E07760", Offset = "0x5E05F60", VA = "0x185E07760")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<HCBGKMEOBBG> GAALPPINDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5E078A0", Offset = "0x5E060A0", VA = "0x185E078A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5E07220", Offset = "0x5E05A20", VA = "0x185E07220", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x15ADEB0", Offset = "0x15AC6B0", VA = "0x1815ADEB0", Slot = "17")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5E07340", Offset = "0x5E05B40", VA = "0x185E07340", Slot = "18")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5E077B0", Offset = "0x5E05FB0", VA = "0x185E077B0", Slot = "19")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x762B70", Offset = "0x761370", VA = "0x180762B70", Slot = "21")]
	private void FMKCFOICADE(global::NPOOFHNLFBB GBDHDLJFLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x15ADE00", Offset = "0x15AC600", VA = "0x1815ADE00", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5E07610", Offset = "0x5E05E10", VA = "0x185E07610")]
	private JEDJBKOCEME MKHLJOFDEDL(Entity MFFDEAINOPL)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5E076E0", Offset = "0x5E05EE0", VA = "0x185E076E0", Slot = "6")]
	public JEDJBKOCEME OEBJBPNCIBI(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DA0", Offset = "0x5E055A0", VA = "0x185E06DA0", Slot = "7")]
	public void AIEGMIMLKAE(List<JEDJBKOCEME> BELHJIJANEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5E07160", Offset = "0x5E05960", VA = "0x185E07160", Slot = "11")]
	public int FAGDHMFPDCE(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5E07500", Offset = "0x5E05D00", VA = "0x185E07500", Slot = "12")]
	public LKEHPHAMPJC MEPAMCFEHGM(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5E07280", Offset = "0x5E05A80", VA = "0x185E07280", Slot = "15")]
	public JEDJBKOCEME HJLGGCKIIPA(JEDJBKOCEME HBMBMELELPF, JEDJBKOCEME OPFJANEEJKH)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5E070A0", Offset = "0x5E058A0", VA = "0x185E070A0", Slot = "16")]
	public bool EPHMNKOPEON(JEDJBKOCEME HBMBMELELPF, JEDJBKOCEME OPFJANEEJKH, [Out] JEDJBKOCEME NIPMIADLFPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5E07410", Offset = "0x5E05C10", VA = "0x185E07410", Slot = "8")]
	public JEDJBKOCEME KAHCMOIEBOO(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5E07030", Offset = "0x5E05830", VA = "0x185E07030", Slot = "14")]
	public bool EHHMCMCJOLD(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME INIMKGAHAEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5E06FC0", Offset = "0x5E057C0", VA = "0x185E06FC0", Slot = "13")]
	public bool DGPBLLKPAEP(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME HBIJIKOLFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5E07650", Offset = "0x5E05E50", VA = "0x185E07650", Slot = "9")]
	public bool OABOCDMKFCC(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME KLGMOMIJPLM, bool PMNMIAAPPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5E07490", Offset = "0x5E05C90", VA = "0x185E07490", Slot = "10")]
	public bool LKMEJDMDFEJ(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME KLGMOMIJPLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public PFENANMACNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(BJLOGACOAIO), new string[] { })]
internal class BJLOGACOAIO : OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[MCMLPKDBFJE]
	private AACGNIFANPK PBFNCDEJLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly Dictionary<int, LIEABLACGCP> GCHDDKBAIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6940", Offset = "0x5DE5140", VA = "0x185DE6940", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5DE66B0", Offset = "0x5DE4EB0", VA = "0x185DE66B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6380", Offset = "0x5DE4B80", VA = "0x185DE6380")]
	public LIEABLACGCP CAEKNKGIIIK(CBPEEJLPJDB JHFJPGOBMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6480", Offset = "0x5DE4C80", VA = "0x185DE6480")]
	public LIEABLACGCP CAEKNKGIIIK(BCJCKPDGHHM BFLLNKNNDBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6990", Offset = "0x5DE5190", VA = "0x185DE6990")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6B40", Offset = "0x5DE5340", VA = "0x185DE6B40")]
	public BJLOGACOAIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class LIEABLACGCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeList<GMAONOHMLPJ> PBOMMGDCPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<KPDILCFCHEL> LLDLIFFEGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private NativeList<MACOEFMOGFA> DICMKEGIJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private NativeList<KPDILCFCHEL> PHACHADNNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NativeList<GMAONOHMLPJ> FEKCLKDPPII
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA70070", Offset = "0xA6E870", VA = "0x180A70070")]
		get
		{
			return default(NativeList<GMAONOHMLPJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public NativeList<KPDILCFCHEL> MGIBINEGJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xD62CB0", Offset = "0xD614B0", VA = "0x180D62CB0")]
		get
		{
			return default(NativeList<KPDILCFCHEL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<MACOEFMOGFA> BEIJNENCALG
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xD3C790", Offset = "0xD3AF90", VA = "0x180D3C790")]
		get
		{
			return default(NativeList<MACOEFMOGFA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<KPDILCFCHEL> IFNCOACDONE
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x89E5C0", Offset = "0x89CDC0", VA = "0x18089E5C0")]
		get
		{
			return default(NativeList<KPDILCFCHEL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JobHandle NAEGBFEIOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x954C40", Offset = "0x953440", VA = "0x180954C40")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xFEC670", Offset = "0xFEAE70", VA = "0x180FEC670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool OMHONIFPLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5E00E70", Offset = "0x5DFF670", VA = "0x185E00E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5E01410", Offset = "0x5DFFC10", VA = "0x185E01410")]
	public LIEABLACGCP(Allocator OPPHPFNHPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5E01380", Offset = "0x5DFFB80", VA = "0x185E01380")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5E01250", Offset = "0x5DFFA50", VA = "0x185E01250")]
	public void FFAMFELMPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5E00F10", Offset = "0x5DFF710", VA = "0x185E00F10")]
	public void EIGFNHEIDIC(Entity MFFDEAINOPL, Entity HPAAJPNIILF, Entity IKMOPDEAPOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(BBGDDAFIEGE), new string[] { })]
public class BBGDDAFIEGE : OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[MCMLPKDBFJE]
	private MKHOKPNBAOG EMCGPGCLFIM;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5A20", Offset = "0x5DE4220", VA = "0x185DE5A20", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5A00", Offset = "0x5DE4200", VA = "0x185DE5A00", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public BBGDDAFIEGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[GJLJLBIABKM(typeof(FAHLHGMLHBM), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.PhotonRoom)]
public class FAHLHGMLHBM : CCGJODBGILF, GAJGABMNKBI, OILIFCGGAMK, OLNFMJBKLAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private FECOAHBOMEJ KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private FBPCDIFNPDJ FFKCLINBBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private NativeList<int> BLEGNKHCBKH;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB3F0", Offset = "0x5DE9BF0", VA = "0x185DEB3F0", Slot = "4")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB380", Offset = "0x5DE9B80", VA = "0x185DEB380", Slot = "5")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB450", Offset = "0x5DE9C50", VA = "0x185DEB450", Slot = "6")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB0D0", Offset = "0x5DE98D0", VA = "0x185DEB0D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB190", Offset = "0x5DE9990", VA = "0x185DEB190")]
	public void FPMOKGOAFPP(NativeParallelHashSet<int> LPIKOEJDGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB090", Offset = "0x5DE9890", VA = "0x185DEB090")]
	public void BACCIBIAPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public FAHLHGMLHBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal abstract class LGNBCFJCLIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private uint CDKNBFJPACN;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public abstract uint FMLCMIGMNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3B854D0", Offset = "0x3B83CD0", VA = "0x183B854D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5E00910", Offset = "0x5DFF110", VA = "0x185E00910")]
	public KLEIPEFFJCP ICFPMBBBFOK()
	{
		return default(KLEIPEFFJCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5E008A0", Offset = "0x5DFF0A0", VA = "0x185E008A0")]
	public void CLFHGLJDCEO(NativeArray<KLEIPEFFJCP> BMJMOJMCGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5E00880", Offset = "0x5DFF080", VA = "0x185E00880")]
	public void CLFHGLJDCEO(KLEIPEFFJCP LFHNIGHPLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0xA8EBB0", Offset = "0xA8D3B0", VA = "0x180A8EBB0", Slot = "6")]
	public virtual void HCOIPAFLDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5E00960", Offset = "0x5DFF160", VA = "0x185E00960")]
	private unsafe void NHPLNCNGEMA(KLEIPEFFJCP* IDCGNOPGNIG, int JEDNJDDHFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5E007A0", Offset = "0x5DFEFA0", VA = "0x185E007A0")]
	private unsafe void CLFHGLJDCEO(KLEIPEFFJCP* IDCGNOPGNIG, int JEDNJDDHFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected LGNBCFJCLIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(BCJEDJDJLLI), new string[] { })]
internal sealed class BCJEDJDJLLI : LGNBCFJCLIK, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[MCMLPKDBFJE]
	private FGIBAMAPNKP KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private uint AJEJCPPFLLB;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public override uint FMLCMIGMNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x807520", Offset = "0x805D20", VA = "0x180807520", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5B20", Offset = "0x5DE4320", VA = "0x185DE5B20", Slot = "7")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5A70", Offset = "0x5DE4270", VA = "0x185DE5A70")]
	private void AFHAHMLJPKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5AC0", Offset = "0x5DE42C0", VA = "0x185DE5AC0", Slot = "6")]
	public override void HCOIPAFLDEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public BCJEDJDJLLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(EKGODBBOPGM), new string[] { })]
internal sealed class EKGODBBOPGM : LGNBCFJCLIK
{
	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public override uint FMLCMIGMNMH
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x761FD0", Offset = "0x7607D0", VA = "0x180761FD0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public EKGODBBOPGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[GJLJLBIABKM(typeof(AANOMIFDJAK), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
internal sealed class AANOMIFDJAK : CCGJODBGILF, GAJGABMNKBI, OILIFCGGAMK, OLNFMJBKLAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private EntityQuery EAHBOEFIGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery DGDLFHKALGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery FPLBAPIHCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery OEOBBMHMJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery HHDNOFOGFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery HEAAKNJDALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private EntityQuery LPNDBLFFMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5DE35B0", Offset = "0x5DE1DB0", VA = "0x185DE35B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public EntityQuery BBMLJHAKIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x954C60", Offset = "0x953460", VA = "0x180954C60")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "4")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3370", Offset = "0x5DE1B70", VA = "0x185DE3370", Slot = "5")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3600", Offset = "0x5DE1E00", VA = "0x185DE3600", Slot = "6")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5DE33C0", Offset = "0x5DE1BC0", VA = "0x185DE33C0")]
	private EntityQueryDesc JNIJAHOGLJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3300", Offset = "0x5DE1B00", VA = "0x185DE3300", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3430", Offset = "0x5DE1C30", VA = "0x185DE3430")]
	public GALEJKINAHP NJLDOJCCPCF(JEDJBKOCEME ADMPFLAIEKN)
	{
		return default(GALEJKINAHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3500", Offset = "0x5DE1D00", VA = "0x185DE3500")]
	public KNBFLDNEILM NPLADJFCMGH(Entity MFFDEAINOPL)
	{
		return default(KNBFLDNEILM);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3B60", Offset = "0x5DE2360", VA = "0x185DE3B60")]
	public AANOMIFDJAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[GJLJLBIABKM(typeof(HOKKMAFBPHI), new string[] { })]
public class PCNNIDOGMDB : OILIFCGGAMK, HOKKMAFBPHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static readonly PFECAMNMOCE KHPNMJJINND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[MCMLPKDBFJE]
	private GIMAKLLKNAL BKIDEJBLOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[MCMLPKDBFJE]
	private ELALIKIJOON PHCBDJMCOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[MCMLPKDBFJE]
	private PGHBFFANNIO JPACBGFEFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[MCMLPKDBFJE]
	private CMMOHNBNCFL FNJHIEAKNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[MCMLPKDBFJE]
	private AANOMIFDJAK KOJGLBGNEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private MOJADNJPIHP PCANEKAMGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private CHHCBHMKOGM PGPBOKMMIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public GIMAKLLKNAL JBIHOCPBPAP
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public KJLFDPOCKCE EFMELCOCEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x762D70", Offset = "0x761570", VA = "0x180762D70", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(KJLFDPOCKCE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x762B60", Offset = "0x761360", VA = "0x180762B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<LKEHPHAMPJC, NativeArray<KNBFLDNEILM>> HKHPNKEMEME
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5E058F0", Offset = "0x5E040F0", VA = "0x185E058F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5E05F00", Offset = "0x5E04700", VA = "0x185E05F00", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<LKEHPHAMPJC> MBKONJONAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x5E066A0", Offset = "0x5E04EA0", VA = "0x185E066A0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x5E06170", Offset = "0x5E04970", VA = "0x185E06170", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E06390", Offset = "0x5E04B90", VA = "0x185E06390", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E05D10", Offset = "0x5E04510", VA = "0x185E05D10", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E06CD0", Offset = "0x5E054D0", VA = "0x185E06CD0")]
	private void PMCJELOCDNK(LKEHPHAMPJC BKPJJLPFOIL, NativeArray<KNBFLDNEILM> PEFPFEIKKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E06B50", Offset = "0x5E05350", VA = "0x185E06B50")]
	private void NGFDGKGKNLD(LKEHPHAMPJC BKPJJLPFOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E06B10", Offset = "0x5E05310", VA = "0x185E06B10")]
	internal JEDJBKOCEME MKHLJOFDEDL(Entity MFFDEAINOPL)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E06B90", Offset = "0x5E05390", VA = "0x185E06B90", Slot = "11")]
	public GALEJKINAHP NJLDOJCCPCF(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(GALEJKINAHP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E06C70", Offset = "0x5E05470", VA = "0x185E06C70", Slot = "12")]
	public KNBFLDNEILM NPLADJFCMGH(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(KNBFLDNEILM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E059A0", Offset = "0x5E041A0", VA = "0x185E059A0", Slot = "39")]
	public bool CHBJDEDBAAF(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E06000", Offset = "0x5E04800", VA = "0x185E06000", Slot = "34")]
	public void GFLGNEDPNAG(LKEHPHAMPJC MGOMOGOCFIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E06A70", Offset = "0x5E05270", VA = "0x185E06A70", Slot = "35")]
	public void LJGAFCKKELL(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E062E0", Offset = "0x5E04AE0", VA = "0x185E062E0", Slot = "36")]
	public void IDBPEFCBIMG(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E05FB0", Offset = "0x5E047B0", VA = "0x185E05FB0", Slot = "37")]
	public void GFLGNEDPNAG(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E05EA0", Offset = "0x5E046A0", VA = "0x185E05EA0", Slot = "24")]
	public LKEHPHAMPJC FMGHHHBPNNI(NativeArray<KLEIPEFFJCP> LFHNIGHPLBN, Allocator OPPHPFNHPMG)
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E06870", Offset = "0x5E05070", VA = "0x185E06870", Slot = "25")]
	public LKEHPHAMPJC LBMAOBBLIAO(NativeArray<KLEIPEFFJCP> LFHNIGHPLBN, NativeArray<ALDBGJKBJJO> PJDHECENIOE, Allocator OPPHPFNHPMG)
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E06220", Offset = "0x5E04A20", VA = "0x185E06220", Slot = "26")]
	public EEKEIMNDBGI ICDNAHMBOHK(KNBFLDNEILM FGDLEJGCDOG, bool JCAFFHKHKGP)
	{
		return default(EEKEIMNDBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E06280", Offset = "0x5E04A80", VA = "0x185E06280", Slot = "27")]
	public EEKEIMNDBGI ICDNAHMBOHK(KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(EEKEIMNDBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E06110", Offset = "0x5E04910", VA = "0x185E06110", Slot = "28")]
	public EEKEIMNDBGI HOOEEMONOLC(KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(EEKEIMNDBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E05A40", Offset = "0x5E04240", VA = "0x185E05A40", Slot = "29")]
	public EEKEIMNDBGI CJEAHKBADIA(KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(EEKEIMNDBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E067A0", Offset = "0x5E04FA0", VA = "0x185E067A0", Slot = "30")]
	public EEKEIMNDBGI LBMAOBBLIAO(KLEIPEFFJCP LFHNIGHPLBN, KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(EEKEIMNDBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E05E10", Offset = "0x5E04610", VA = "0x185E05E10", Slot = "31")]
	public JMAMHBBAHMA EBDAPBIFBLO()
	{
		return default(JMAMHBBAHMA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E05C20", Offset = "0x5E04420", VA = "0x185E05C20", Slot = "32")]
	public IIGOCDJOBNI DNMJJDELJGL()
	{
		return default(IIGOCDJOBNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E06990", Offset = "0x5E05190", VA = "0x185E06990", Slot = "33")]
	public NFEMEFJAPJB LEGEKJGKEJG(DFMGIJCAPCL BJKOKHNAAID)
	{
		return default(NFEMEFJAPJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E06680", Offset = "0x5E04E80", VA = "0x185E06680", Slot = "13")]
	public void JKCLJMACCFA(KLEIPEFFJCP LFHNIGHPLBN, HFBIDPNKJHF CILANNDFKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E05B30", Offset = "0x5E04330", VA = "0x185E05B30", Slot = "14")]
	public EEKEIMNDBGI CKHHEFMHFCG(JEDJBKOCEME JBPJNGFGLPC, [Optional] object PIPCHJCEPPJ)
	{
		return default(EEKEIMNDBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E06A20", Offset = "0x5E05220", VA = "0x185E06A20", Slot = "15")]
	public bool LGFAPDODONP(JEDJBKOCEME JBPJNGFGLPC, [Out] HFBIDPNKJHF PGNGICAKGGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E06340", Offset = "0x5E04B40", VA = "0x185E06340", Slot = "16")]
	public bool INAPGCCILNA(JEDJBKOCEME JBPJNGFGLPC, [Out] Transform KHFCFAPNPDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E06AD0", Offset = "0x5E052D0", VA = "0x185E06AD0", Slot = "17")]
	public bool LNCBCICGOEB(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E058B0", Offset = "0x5E040B0", VA = "0x185E058B0", Slot = "18")]
	public void AGLJDNIIPBG(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E06630", Offset = "0x5E04E30", VA = "0x185E06630", Slot = "19")]
	public bool JEDDAFCMBOC(LocalId JBPJNGFGLPC, object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E06750", Offset = "0x5E04F50", VA = "0x185E06750", Slot = "20")]
	public bool KJPIJIECLLM(LocalId JBPJNGFGLPC, object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E05CB0", Offset = "0x5E044B0", VA = "0x185E05CB0", Slot = "38")]
	public LKEHPHAMPJC DNOIDEGKJNI(LKEHPHAMPJC EPMKOOAIFAO, Allocator OPPHPFNHPMG)
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E05BC0", Offset = "0x5E043C0", VA = "0x185E05BC0", Slot = "23")]
	public KLEIPEFFJCP DFKMDGDCJGD(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(KLEIPEFFJCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E05E80", Offset = "0x5E04680", VA = "0x185E05E80", Slot = "21")]
	public JEDJBKOCEME FMGHHHBPNNI(KLEIPEFFJCP LFHNIGHPLBN)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E06CB0", Offset = "0x5E054B0", VA = "0x185E06CB0", Slot = "22")]
	public bool ODENBBBJBHB(KLEIPEFFJCP LFHNIGHPLBN, [Out] JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E05BE0", Offset = "0x5E043E0", VA = "0x185E05BE0")]
	private void DGHNCJEILCK(KNBFLDNEILM MJLEEPFNLFO, JEDJBKOCEME JBPJNGFGLPC, KLEIPEFFJCP LFHNIGHPLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E06D90", Offset = "0x5E05590", VA = "0x185E06D90")]
	public PCNNIDOGMDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(NFEHBALEDIH), new string[] { })]
internal sealed class NFEHBALEDIH : OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private CMMOHNBNCFL FNJHIEAKNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[MCMLPKDBFJE]
	private AANOMIFDJAK KOJGLBGNEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[MCMLPKDBFJE]
	private EIGPEOIKDPK IPCIGPCKHNO;

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E02480", Offset = "0x5E00C80", VA = "0x185E02480", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E01EB0", Offset = "0x5E006B0", VA = "0x185E01EB0")]
	public LKEHPHAMPJC DNOIDEGKJNI(LKEHPHAMPJC EPMKOOAIFAO, Allocator OPPHPFNHPMG)
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E02530", Offset = "0x5E00D30", VA = "0x185E02530")]
	private void JJOMBGHHELG(NativeParallelMultiHashMap<int, (JEDJBKOCEME src, JEDJBKOCEME dst)> AJODOEMGIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E02000", Offset = "0x5E00800", VA = "0x185E02000")]
	private void FPLPOPBKPLB(NativeParallelMultiHashMap<int, (JEDJBKOCEME src, JEDJBKOCEME dst)> AJODOEMGIKO, int FGDLEJGCDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E029D0", Offset = "0x5E011D0", VA = "0x185E029D0")]
	private void KJLIADEEHPG(NativeParallelMultiHashMap<int, (JEDJBKOCEME src, JEDJBKOCEME dst)> AJODOEMGIKO, int FGDLEJGCDOG, NGLBPOGABCB PBFNCDEJLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E02760", Offset = "0x5E00F60", VA = "0x185E02760")]
	private NativeParallelMultiHashMap<int, (JEDJBKOCEME, JEDJBKOCEME)> KJBEJJPNDMP(Allocator OPPHPFNHPMG, LKEHPHAMPJC EPMKOOAIFAO, [Out] LKEHPHAMPJC KJMKAEMHMIF)
	{
		return default(NativeParallelMultiHashMap<int, (JEDJBKOCEME, JEDJBKOCEME)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public NFEHBALEDIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[GJLJLBIABKM(typeof(CECLHBPNMGM), new string[] { })]
[EJJPDJHBEFJ(typeof(JNLNOBGHOEK))]
public class JNLNOBGHOEK : CECLHBPNMGM, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly PFECAMNMOCE JDEPJOLNCIG;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly PFECAMNMOCE NLCBLDKAJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private KAPOAGACOPL KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private ABILNOGAPGJ EFAAPEICBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private GKGBAHAPFBD IGBOANLHLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private LIGCKOLLPCB OAKFINDINOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private PGHBFFANNIO JPACBGFEFHP;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	private EntityManager DHDOKMIFNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5DFADD0", Offset = "0x5DF95D0", VA = "0x185DFADD0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9FD0", Offset = "0x5DF87D0", VA = "0x185DF9FD0", Slot = "34")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAFE0", Offset = "0x5DF97E0", VA = "0x185DFAFE0", Slot = "35")]
	public bool ODENBBBJBHB(Transform KHFCFAPNPDN, [Out] JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAE30", Offset = "0x5DF9630", VA = "0x185DFAE30", Slot = "36")]
	public Transform NFBOIDPEJFF(Entity MFFDEAINOPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9EE0", Offset = "0x5DF86E0", VA = "0x185DF9EE0", Slot = "31")]
	public bool INAPGCCILNA(Entity MFFDEAINOPL, [Out] Transform KHFCFAPNPDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA4B0", Offset = "0x5DF8CB0", VA = "0x185DFA4B0")]
	private void KEAGHCMBBED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8710", Offset = "0x5DF6F10", VA = "0x185DF8710", Slot = "30")]
	public void FDAMOPAPLIC(Entity MFFDEAINOPL, [Out] float4x4 NINJNMPBFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7FE0", Offset = "0x5DF67E0", VA = "0x185DF7FE0", Slot = "4")]
	public void EJECEOOKNJC(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB340", Offset = "0x5DF9B40", VA = "0x185DFB340", Slot = "28")]
	public void PHGNOICOEMF(Entity MFFDEAINOPL, [Out] float4x4 NINJNMPBFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9360", Offset = "0x5DF7B60", VA = "0x185DF9360")]
	public void HDKMMDABAHD(Entity MFFDEAINOPL, [In] float4x4 NINJNMPBFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9230", Offset = "0x5DF7A30", VA = "0x185DF9230")]
	public void HBBHLLMBFHE(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9630", Offset = "0x5DF7E30", VA = "0x185DF9630", Slot = "6")]
	public float3 IHGFPBPPIPI(Entity MFFDEAINOPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DF85F0", Offset = "0x5DF6DF0", VA = "0x185DF85F0")]
	public void ELMILBICGGO(Entity MFFDEAINOPL, [In] quaternion IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7DA0", Offset = "0x5DF65A0", VA = "0x185DF7DA0", Slot = "8")]
	public quaternion CGFFHINEJNH(Entity MFFDEAINOPL)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8D30", Offset = "0x5DF7530", VA = "0x185DF8D30")]
	public void OFDIEADNOLH(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8E60", Offset = "0x5DF7660", VA = "0x185DF8E60", Slot = "12")]
	public float3 GCMJJMGKIDK(Entity MFFDEAINOPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8260", Offset = "0x5DF6A60", VA = "0x185DF8260", Slot = "15")]
	public float EJOPFAAHEAG(Entity MFFDEAINOPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB160", Offset = "0x5DF9960", VA = "0x185DFB160", Slot = "14")]
	public void PEPPDALBKEN(Entity MFFDEAINOPL, float IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9750", Offset = "0x5DF7F50", VA = "0x185DF9750", Slot = "17")]
	public float3 IHOJOHHJHEF(Entity MFFDEAINOPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5DF90B0", Offset = "0x5DF78B0", VA = "0x185DF90B0")]
	public void OMNLGNICBHB(Entity MFFDEAINOPL, [In] float3 DPOOLEFLBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF76A0", Offset = "0x5DF5EA0", VA = "0x185DF76A0", Slot = "9")]
	public void BNBGHPKENHC(Entity MFFDEAINOPL, [Out] float3 OBAACBLACLC, [Out] quaternion AHLHKGGFBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7810", Offset = "0x5DF6010", VA = "0x185DF7810", Slot = "10")]
	public void BNBGHPKENHC(Entity MFFDEAINOPL, [Out] RigidTransform IFJLAEGOCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8360", Offset = "0x5DF6B60", VA = "0x185DF8360", Slot = "37")]
	public void EJPJNKLKFNO(Entity MFFDEAINOPL, [Out] float3 OBAACBLACLC, [Out] quaternion AHLHKGGFBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8340", Offset = "0x5DF6B40", VA = "0x185DF8340", Slot = "11")]
	public void EJPJNKLKFNO(Entity MFFDEAINOPL, [Out] RigidTransform IFJLAEGOCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7EB0", Offset = "0x5DF66B0", VA = "0x185DF7EB0")]
	public void DPECHGGPJEI(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7A10", Offset = "0x5DF6210", VA = "0x185DF7A10", Slot = "19")]
	public float3 CCMLCBBPAHG(Entity MFFDEAINOPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8F80", Offset = "0x5DF7780", VA = "0x185DF8F80")]
	public void HOAELCHFHGH(Entity MFFDEAINOPL, [In] quaternion IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF87C0", Offset = "0x5DF6FC0", VA = "0x185DF87C0", Slot = "21")]
	public quaternion FEBHODBBOCG(Entity MFFDEAINOPL)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA4D0", Offset = "0x5DF8CD0", VA = "0x185DFA4D0")]
	public void KHJHELBEAPB(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7C80", Offset = "0x5DF6480", VA = "0x185DF7C80", Slot = "22")]
	public float3 CEINPCLGFLC(Entity MFFDEAINOPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8A00", Offset = "0x5DF7200", VA = "0x185DF8A00", Slot = "24")]
	public void FHKELFMBAKA(Entity MFFDEAINOPL, float NCGDDONCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAEF0", Offset = "0x5DF96F0", VA = "0x185DFAEF0", Slot = "25")]
	public float OAFGKNILALL(Entity MFFDEAINOPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA960", Offset = "0x5DF9160", VA = "0x185DFA960")]
	public void MDIJLBBADLH(Entity MFFDEAINOPL, [In] float3 LAIPFLKJGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA320", Offset = "0x5DF8B20", VA = "0x185DFA320", Slot = "27")]
	public float3 KDOEDCEPBPD(Entity MFFDEAINOPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9910", Offset = "0x5DF8110", VA = "0x185DF9910", Slot = "32")]
	public void IKJIMFLEKAF(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA200", Offset = "0x5DF8A00", VA = "0x185DFA200")]
	private JEDJBKOCEME JDCOFADONML(Transform KHFCFAPNPDN)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA6E0", Offset = "0x5DF8EE0", VA = "0x185DFA6E0")]
	private static TransformEntity LIHJEGNNEMH(KNBFLDNEILM BJKOKHNAAID, GameObject LCKCBKEEMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x2427250", Offset = "0x2425A50", VA = "0x182427250")]
	private static T KKIDLBMCHCO<T>(GameObject LCKCBKEEMNI) where T : MonoBehaviour
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA0E0", Offset = "0x5DF88E0", VA = "0x185DFA0E0", Slot = "33")]
	public void JAIEFPJGNPM(Entity MFFDEAINOPL, Entity HPAAJPNIILF, Entity IKMOPDEAPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public JNLNOBGHOEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9230", Offset = "0x5DF7A30", VA = "0x185DF9230", Slot = "5")]
	private void POBOFOMHDDE(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DF85F0", Offset = "0x5DF6DF0", VA = "0x185DF85F0", Slot = "7")]
	private void INDLKGDHKLJ(Entity MFFDEAINOPL, [In] quaternion IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8D30", Offset = "0x5DF7530", VA = "0x185DF8D30", Slot = "13")]
	private void FHPADGHLOIC(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DF90B0", Offset = "0x5DF78B0", VA = "0x185DF90B0", Slot = "16")]
	private void GOIFIBIDLHL(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7EB0", Offset = "0x5DF66B0", VA = "0x185DF7EB0", Slot = "18")]
	private void KFOCPICLLLG(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8F80", Offset = "0x5DF7780", VA = "0x185DF8F80", Slot = "20")]
	private void GEEIJBOKELO(Entity MFFDEAINOPL, [In] quaternion IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAFD0", Offset = "0x5DF97D0", VA = "0x185DFAFD0", Slot = "23")]
	private void ODCNLICBNNK(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DF90A0", Offset = "0x5DF78A0", VA = "0x185DF90A0", Slot = "26")]
	private void GGNIGICOPPI(Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAE20", Offset = "0x5DF9620", VA = "0x185DFAE20", Slot = "29")]
	private void MNMMNLMMDAH(Entity MFFDEAINOPL, [In] float4x4 JBBMMCAIOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class ILIMNAIGALC
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4C10", Offset = "0x5DF3410", VA = "0x185DF4C10")]
	public static void ECNECGDBKFF(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [In] float3 CINCGMPJHMP, [In] quaternion LAEFAMPNPGA, [In] float3 HJFHFDDPJCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5140", Offset = "0x5DF3940", VA = "0x185DF5140")]
	public static void FDAMOPAPLIC(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [Out] float4x4 NINJNMPBFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5000", Offset = "0x5DF3800", VA = "0x185DF5000")]
	private static void FDAMOPAPLIC(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, Entity KLGMOMIJPLM, [Out] float4x4 NINJNMPBFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5DF56B0", Offset = "0x5DF3EB0", VA = "0x185DF56B0")]
	public static void HDKMMDABAHD(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [In] float4x4 NINJNMPBFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5FA0", Offset = "0x5DF47A0", VA = "0x185DF5FA0")]
	public static void JALNGNANGGC(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [Out] float4x4 PODEKJEMHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6800", Offset = "0x5DF5000", VA = "0x185DF6800")]
	public static void KJHAFILMFMH(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [In] float4x4 PODEKJEMHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5DD0", Offset = "0x5DF45D0", VA = "0x185DF5DD0")]
	public static float3 IHGFPBPPIPI(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5DF55C0", Offset = "0x5DF3DC0", VA = "0x185DF55C0")]
	public static void HBBHLLMBFHE(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4740", Offset = "0x5DF2F40", VA = "0x185DF4740")]
	public static quaternion CGFFHINEJNH(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4F10", Offset = "0x5DF3710", VA = "0x185DF4F10")]
	public static void ELMILBICGGO(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [In] quaternion IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5510", Offset = "0x5DF3D10", VA = "0x185DF5510")]
	public static float3 GCMJJMGKIDK(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6CA0", Offset = "0x5DF54A0", VA = "0x185DF6CA0")]
	public static void OFDIEADNOLH(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4CB0", Offset = "0x5DF34B0", VA = "0x185DF4CB0")]
	public static float EJOPFAAHEAG(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6E60", Offset = "0x5DF5660", VA = "0x185DF6E60")]
	public static void PEPPDALBKEN(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, float IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5EC0", Offset = "0x5DF46C0", VA = "0x185DF5EC0")]
	public static float3 IHOJOHHJHEF(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6D90", Offset = "0x5DF5590", VA = "0x185DF6D90")]
	public static void OMNLGNICBHB(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5DF41B0", Offset = "0x5DF29B0", VA = "0x185DF41B0")]
	public static void BNBGHPKENHC(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [Out] RigidTransform PODEKJEMHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4290", Offset = "0x5DF2A90", VA = "0x185DF4290")]
	public static void BNBGHPKENHC(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [Out] float3 OBAACBLACLC, [Out] quaternion AHLHKGGFBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4820", Offset = "0x5DF3020", VA = "0x185DF4820")]
	public static void DHELCHMIJFE(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [In] float3 CINCGMPJHMP, [In] quaternion LAEFAMPNPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4D80", Offset = "0x5DF3580", VA = "0x185DF4D80")]
	public static void EJPJNKLKFNO(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [Out] float3 OBAACBLACLC, [Out] quaternion AHLHKGGFBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5DF43A0", Offset = "0x5DF2BA0", VA = "0x185DF43A0")]
	public static float3 CCMLCBBPAHG(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5DF49C0", Offset = "0x5DF31C0", VA = "0x185DF49C0")]
	public static void DPECHGGPJEI(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5A40", Offset = "0x5DF4240", VA = "0x185DF5A40")]
	public static void HOAELCHFHGH(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [In] quaternion IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5260", Offset = "0x5DF3A60", VA = "0x185DF5260")]
	public static quaternion FEBHODBBOCG(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4520", Offset = "0x5DF2D20", VA = "0x185DF4520")]
	public static float3 CEINPCLGFLC(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5DF65B0", Offset = "0x5DF4DB0", VA = "0x185DF65B0")]
	public static void KHJHELBEAPB(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [In] float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6AC0", Offset = "0x5DF52C0", VA = "0x185DF6AC0")]
	public static float OAFGKNILALL(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF53D0", Offset = "0x5DF3BD0", VA = "0x185DF53D0")]
	public static void FHKELFMBAKA(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, float NCGDDONCOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6350", Offset = "0x5DF4B50", VA = "0x185DF6350")]
	public static float3 KDOEDCEPBPD(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF68D0", Offset = "0x5DF50D0", VA = "0x185DF68D0")]
	public static void MDIJLBBADLH(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [In] float3 LAIPFLKJGHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4920", Offset = "0x5DF3120", VA = "0x185DF4920")]
	public static bool DNAJKJFCDCN(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [Out] Entity KLGMOMIJPLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[GJLJLBIABKM(typeof(KPJGJGBIJCN), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
internal sealed class KPJGJGBIJCN : OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[MCMLPKDBFJE]
	private GPHJLMFLCDC KBCHPJJCKNB;

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCBC0", Offset = "0x5DFB3C0", VA = "0x185DFCBC0", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCB70", Offset = "0x5DFB370", VA = "0x185DFCB70", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public KPJGJGBIJCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[GJLJLBIABKM(typeof(ILAOLKELLJD), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public class ILAOLKELLJD
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct HMOOBGKKDEO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly ILAOLKELLJD KLGMOMIJPLM;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2760", Offset = "0x5DF0F60", VA = "0x185DF2760", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int LIKBOCOFBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[CompilerGenerated]
	private Action GCFNJHINOCG;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4190", Offset = "0x5DF2990", VA = "0x185DF4190")]
	public void JOBILGPCFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public ILAOLKELLJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(JCPLFOIFHBP), new string[] { })]
public class JCPLFOIFHBP
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool ICGNKEDIKDH;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool HAOKFJJANAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7B28A0", Offset = "0x7B10A0", VA = "0x1807B28A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5DF7090", Offset = "0x5DF5890", VA = "0x185DF7090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public JCPLFOIFHBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[GJLJLBIABKM(typeof(NKDCELCOEPP), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public class NKDCELCOEPP : OILIFCGGAMK, HLEOPNBKPID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private struct IAPMNGGDEOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private NativeArray<int> DCAFAMJBLNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private NativeArray<int> MBBDMHFOIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private Dictionary<ComponentSystemBase, int> CJJGKIGEPEB;

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5DF32F0", Offset = "0x5DF1AF0", VA = "0x185DF32F0")]
		public IAPMNGGDEOA(NativeArray<int> DCAFAMJBLNM, NativeArray<int> MBBDMHFOIDN, Dictionary<ComponentSystemBase, int> CJJGKIGEPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2ED0", Offset = "0x5DF16D0", VA = "0x185DF2ED0")]
		public static void DLEBMMOICCF(World LPBOBKJPICK, EOGANNGNDMH KJHLCCIGHLF, NativeArray<int> DCAFAMJBLNM, NativeArray<int> MBBDMHFOIDN, Dictionary<ComponentSystemBase, int> CJJGKIGEPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3000", Offset = "0x5DF1800", VA = "0x185DF3000")]
		public void HEOPGKFODHJ(IEnumerable<ComponentSystemBase> BKIDEJBLOMH, EOGANNGNDMH KJHLCCIGHLF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class KCCNJHDEAEH : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private ComponentSystemBase <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public NKDCELCOEPP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private int start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int <>3__start;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private int end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int <>3__end;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		ComponentSystemBase IEnumerator<ComponentSystemBase>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
		[DebuggerHidden]
		public KCCNJHDEAEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB5B0", Offset = "0x5DF9DB0", VA = "0x185DFB5B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB790", Offset = "0x5DF9F90", VA = "0x185DFB790", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB6E0", Offset = "0x5DF9EE0", VA = "0x185DFB6E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB6E0", Offset = "0x5DF9EE0", VA = "0x185DFB6E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly PFECAMNMOCE KKKDEKPLBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private World LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private FHMIKLMEDIH CNFBLEFPNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private NativeArray<int> PDCGEHLHMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private NativeArray<int> GMBADEGOHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int OJAHFIICKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private EOGANNGNDMH MMIGHFMKAPH;

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5E03760", Offset = "0x5E01F60", VA = "0x185E03760", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5E033D0", Offset = "0x5E01BD0", VA = "0x185E033D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5E03D30", Offset = "0x5E02530", VA = "0x185E03D30")]
	[IteratorStateMachine(typeof(KCCNJHDEAEH))]
	private IEnumerable<ComponentSystemBase> NEJJFKHBJGJ(int IAIBEBECMJB, int BMNCKBBLELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5E036E0", Offset = "0x5E01EE0", VA = "0x185E036E0", Slot = "5")]
	public void MKOHONAJGCK(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5E036E0", Offset = "0x5E01EE0", VA = "0x185E036E0")]
	private void FFOEMKDHBCH(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5E03590", Offset = "0x5E01D90", VA = "0x185E03590")]
	public void FFOEMKDHBCH(EOGANNGNDMH LOHDNGJKHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5E03840", Offset = "0x5E02040", VA = "0x185E03840")]
	private void KIFCNPGMNEB(EOGANNGNDMH LOHDNGJKHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5E03310", Offset = "0x5E01B10", VA = "0x185E03310")]
	private void DJEBCECGIGB(EOGANNGNDMH LOHDNGJKHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5E03CA0", Offset = "0x5E024A0", VA = "0x185E03CA0")]
	private void NDNMKAGPKHL(EOGANNGNDMH LOHDNGJKHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x5E03B70", Offset = "0x5E02370", VA = "0x185E03B70")]
	private void KMJFICFLPKD(int IAIBEBECMJB, int BMNCKBBLELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5E03BC0", Offset = "0x5E023C0", VA = "0x185E03BC0")]
	private void LCCKBFMBNHJ(int IAIBEBECMJB, int BMNCKBBLELB, bool ICGNKEDIKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5E03C80", Offset = "0x5E02480", VA = "0x185E03C80")]
	private int MDKKDHFNBDK(EOGANNGNDMH LOHDNGJKHDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5E03E30", Offset = "0x5E02630", VA = "0x185E03E30")]
	private bool PMKGDDAAGPB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5E034A0", Offset = "0x5E01CA0", VA = "0x185E034A0")]
	private Dictionary<ComponentSystemBase, int> EHPFFEDCMMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x5E03270", Offset = "0x5E01A70", VA = "0x185E03270")]
	private void BBGIMFMHBJN(NativeArray<int> DCAFAMJBLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x5E03AC0", Offset = "0x5E022C0", VA = "0x185E03AC0")]
	private void KJPDBIKHIHJ(NativeArray<int> MBBDMHFOIDN, NativeArray<int> DCAFAMJBLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5E03DD0", Offset = "0x5E025D0", VA = "0x185E03DD0")]
	private static EOGANNGNDMH NNMAIIKNEEL(Type BJKOKHNAAID, EOGANNGNDMH FEAAGHJCDLM)
	{
		return default(EOGANNGNDMH);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x5E044B0", Offset = "0x5E02CB0", VA = "0x185E044B0")]
	public NKDCELCOEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x5E03440", Offset = "0x5E01C40", VA = "0x185E03440")]
	[CompilerGenerated]
	private void EEPNKOAMLGG(OILIFCGGAMK LFMLECMDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x5E032B0", Offset = "0x5E01AB0", VA = "0x185E032B0")]
	[CompilerGenerated]
	private void CNNAPCCHPCM(OLNFMJBKLAF LFMLECMDDPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[GJLJLBIABKM(typeof(PHLKAMANPNI), new string[] { })]
public class IEKLPPLDHLJ : OILIFCGGAMK, PHLKAMANPNI
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[MCMLPKDBFJE]
	private FBKLHLEKBGM DCDGDLJLGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[MCMLPKDBFJE]
	private BNPBAMGOGIA FCOGNFMHJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[MCMLPKDBFJE]
	private LAKKFPDMDNI BMIBLOMHPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[MCMLPKDBFJE]
	private LIGCKOLLPCB FNFDJHBKNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[MCMLPKDBFJE]
	private FCENJDFCEED DGICCKHKNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private World FMPIOIENJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private MAEHJADFBFD GGHHKLMOKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private MAEHJADFBFD JEINOCEHGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private MAEHJADFBFD ODKKOBHNHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MAEHJADFBFD LPLCIHJPFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private MAEHJADFBFD GFOIFJOHCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private MAEHJADFBFD GCJOJIKDMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private MAEHJADFBFD EJFMFBHFHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private MAEHJADFBFD IMLMGLJGIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private MAEHJADFBFD LLLFKLHONJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private MAEHJADFBFD JGNHCOBFNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private MAEHJADFBFD FLKMFCALGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private MAEHJADFBFD BCGOIOMCADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private MAEHJADFBFD CCILLNPPCPD;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private bool HGAJJJMLBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3CF0", Offset = "0x5DF24F0", VA = "0x185DF3CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	private bool KLGMIAAEBOL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3E50", Offset = "0x5DF2650", VA = "0x185DF3E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private bool KEEABNEMPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x5DF33F0", Offset = "0x5DF1BF0", VA = "0x185DF33F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private bool BEDEGCMIAFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x5DF33F0", Offset = "0x5DF1BF0", VA = "0x185DF33F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5DF38C0", Offset = "0x5DF20C0", VA = "0x185DF38C0", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x23FC0B0", Offset = "0x23FA8B0", VA = "0x1823FC0B0")]
	private MAEHJADFBFD HCDALFIJJEN<T>() where T : LGOMPDENBAF
	{
		return default(MAEHJADFBFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3890", Offset = "0x5DF2090", VA = "0x185DF3890")]
	private MAEHJADFBFD HCDALFIJJEN(Type BJKOKHNAAID)
	{
		return default(MAEHJADFBFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5DF33C0", Offset = "0x5DF1BC0", VA = "0x185DF33C0", Slot = "14")]
	public void BPOIEOCFCPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3390", Offset = "0x5DF1B90", VA = "0x185DF3390", Slot = "15")]
	public void BNHGMKAFILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3CD0", Offset = "0x5DF24D0", VA = "0x185DF3CD0", Slot = "5")]
	public void KCLKDCELABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4080", Offset = "0x5DF2880", VA = "0x185DF4080", Slot = "6")]
	public void PFIFDHHKADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3400", Offset = "0x5DF1C00", VA = "0x185DF3400", Slot = "7")]
	public void DPJCPLNJPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x5DF37D0", Offset = "0x5DF1FD0", VA = "0x185DF37D0", Slot = "8")]
	public void GEDHAHNGGKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3310", Offset = "0x5DF1B10", VA = "0x185DF3310", Slot = "9")]
	public void BDCFBGEAMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3D70", Offset = "0x5DF2570", VA = "0x185DF3D70", Slot = "10")]
	public void MBILDHLJGBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3EC0", Offset = "0x5DF26C0", VA = "0x185DF3EC0", Slot = "11")]
	public void OBHHNLPNAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3850", Offset = "0x5DF2050", VA = "0x185DF3850", Slot = "12")]
	public void GLKPHCPGAEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3480", Offset = "0x5DF1C80", VA = "0x185DF3480", Slot = "13")]
	public void DPNHDPCLHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3F40", Offset = "0x5DF2740", VA = "0x185DF3F40")]
	private void ODBEHOJNPMB(MAEHJADFBFD HKHKOFLAFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3FF0", Offset = "0x5DF27F0", VA = "0x185DF3FF0")]
	private void ONNDEMAKKDA(MAEHJADFBFD HKHKOFLAFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3FD0", Offset = "0x5DF27D0", VA = "0x185DF3FD0")]
	private void OFEACLLFMBI(MAEHJADFBFD HKHKOFLAFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public IEKLPPLDHLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal readonly struct MAEHJADFBFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly ComponentSystemBase HKHKOFLAFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly ProfilerMarker IMGDALPLKBP;

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x5E01A80", Offset = "0x5E00280", VA = "0x185E01A80")]
	public MAEHJADFBFD(World LPBOBKJPICK, Type BJKOKHNAAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x5E019B0", Offset = "0x5E001B0", VA = "0x185E019B0")]
	public void OFEACLLFMBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[GJLJLBIABKM(typeof(HLLCKCNCCJD), new string[] { })]
public class BFFBFBFMCOD : HLLCKCNCCJD, IDisposable, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	[MCMLPKDBFJE]
	private GABKHNGOBOD PPELFIIGFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[MCMLPKDBFJE]
	private DKDHCMJLDBA JHIGIODAGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private World FMPIOIENJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private World KLEBCFIAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private bool FLINFKOPCPK;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public World CPJGAENFGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public World OENOGIIIABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x762AE0", Offset = "0x7612E0", VA = "0x180762AE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5DE62D0", Offset = "0x5DE4AD0", VA = "0x185DE62D0", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool PLFIBBCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x3657010", Offset = "0x3655810", VA = "0x183657010", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6130", Offset = "0x5DE4930", VA = "0x185DE6130", Slot = "10")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5FE0", Offset = "0x5DE47E0", VA = "0x185DE5FE0")]
	private void GFPEABNIECK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5D10", Offset = "0x5DE4510", VA = "0x185DE5D10", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6110", Offset = "0x5DE4910", VA = "0x185DE6110", Slot = "8")]
	public ComponentSystemBase HCDALFIJJEN(Type BJKOKHNAAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public BFFBFBFMCOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(JFPEPOBGGGL), new string[] { })]
public class JFPEPOBGGGL : GIFDCKIGEDL, CCGJODBGILF, GAJGABMNKBI, OILIFCGGAMK, OLNFMJBKLAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class EMEMDPEMJGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public FHMIKLMEDIH services;

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public EMEMDPEMJGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5DEA3F0", Offset = "0x5DE8BF0", VA = "0x185DEA3F0")]
		internal void JDGDIJLLGJN(OILIFCGGAMK svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class FEAHEJODMNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public FHMIKLMEDIH services;

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public FEAHEJODMNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC730", Offset = "0x5DEAF30", VA = "0x185DEC730")]
		internal void DHIADAIFNLM(OLNFMJBKLAF svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[MCMLPKDBFJE]
	private KJLCCDCFOPB CPPOMJJCBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[MCMLPKDBFJE]
	private EIGPEOIKDPK HOKINAOAABH;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public DMCLIOLBKII LMEMNHLLCGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5B0", Offset = "0x7DBDB0", VA = "0x1807DD5B0", Slot = "4")]
		get
		{
			return default(DMCLIOLBKII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x5DF72C0", Offset = "0x5DF5AC0", VA = "0x185DF72C0", Slot = "5")]
	public void EAPAJNCJCIO(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7430", Offset = "0x5DF5C30", VA = "0x185DF7430", Slot = "6")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7350", Offset = "0x5DF5B50", VA = "0x185DF7350", Slot = "7")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7550", Offset = "0x5DF5D50", VA = "0x185DF7550", Slot = "8")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5DF71A0", Offset = "0x5DF59A0", VA = "0x185DF71A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x2423920", Offset = "0x2422120", VA = "0x182423920")]
	private void PAMEIPMLJGG<T>(Action<T> PMMMJGPDPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public JFPEPOBGGGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[GJLJLBIABKM(typeof(AACGNIFANPK), new string[] { })]
[DefaultMember("Item")]
public class OHHLGMHACMO : AACGNIFANPK, IEnumerable<ACMAOFLJBJE>, IEnumerable, CCGJODBGILF, GAJGABMNKBI, OILIFCGGAMK, OLNFMJBKLAF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[MCMLPKDBFJE]
	private NIEALEGEBJP PBFNCDEJLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly Dictionary<(Type, string), int> JEGOILPDKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NativeBitArray HILJLLLNMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private NativeArray<int> KBGGJOKFEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private LHCHIBBJMCI LHNCODHGDIN;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public NativeBitArray HHODHICOEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0xD62CB0", Offset = "0xD614B0", VA = "0x180D62CB0", Slot = "4")]
		get
		{
			return default(NativeBitArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public NativeArray<int> DFOKADMDJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xD3C790", Offset = "0xD3AF90", VA = "0x180D3C790", Slot = "5")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private int NBABEFENOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x84B270", Offset = "0x849A70", VA = "0x18084B270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5E04730", Offset = "0x5E02F30", VA = "0x185E04730", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public ACMAOFLJBJE NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x5E04710", Offset = "0x5E02F10", VA = "0x185E04710", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public ACMAOFLJBJE NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5E04710", Offset = "0x5E02F10", VA = "0x185E04710", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5E04D70", Offset = "0x5E03570", VA = "0x185E04D70", Slot = "13")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5E04AC0", Offset = "0x5E032C0", VA = "0x185E04AC0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "15")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5E04DC0", Offset = "0x5E035C0", VA = "0x185E04DC0")]
	private void NBOKDEEHKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x5E048F0", Offset = "0x5E030F0", VA = "0x185E048F0", Slot = "9")]
	public ACMAOFLJBJE GPMFIJBJGKK(CBPEEJLPJDB JHFJPGOBMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x5E047A0", Offset = "0x5E02FA0", VA = "0x185E047A0")]
	private bool ENKALJEDIJB(Type LFPMIGGMBBJ, string BOBHOMKFHJB, [Out] ACMAOFLJBJE ECCHICFFMNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x5E04B40", Offset = "0x5E03340", VA = "0x185E04B40", Slot = "10")]
	public BCJCKPDGHHM MCCDHJKIPHH(CBPEEJLPJDB JHFJPGOBMLL)
	{
		return default(BCJCKPDGHHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5E04AA0", Offset = "0x5E032A0", VA = "0x185E04AA0", Slot = "11")]
	public IEnumerator<ACMAOFLJBJE> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5E04AA0", Offset = "0x5E032A0", VA = "0x185E04AA0", Slot = "12")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5E04750", Offset = "0x5E02F50", VA = "0x185E04750", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5E056F0", Offset = "0x5E03EF0", VA = "0x185E056F0")]
	public OHHLGMHACMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[GJLJLBIABKM(typeof(HCANMCICAMH), new string[] { })]
[DefaultMember("Item")]
public class IAEDJMBFIOG : HCANMCICAMH, IEnumerable<MNOPJOLALGH>, IEnumerable, CCGJODBGILF, GAJGABMNKBI, OILIFCGGAMK, OLNFMJBKLAF, MLPMOOACKBB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	[MCMLPKDBFJE]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[MCMLPKDBFJE]
	private AACGNIFANPK OMGNBKKNENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private MNOPJOLALGH[] NBPBGPMOMCO;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x52F1D50", Offset = "0x52F0550", VA = "0x1852F1D50", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public MNOPJOLALGH NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x5DF27A0", Offset = "0x5DF0FA0", VA = "0x185DF27A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "10")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2B00", Offset = "0x5DF1300", VA = "0x185DF2B00", Slot = "11")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "12")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2900", Offset = "0x5DF1100", VA = "0x185DF2900", Slot = "6")]
	public MNOPJOLALGH GPMFIJBJGKK(CBPEEJLPJDB JHFJPGOBMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2DE0", Offset = "0x5DF15E0", VA = "0x185DF2DE0", Slot = "7")]
	public BCJCKPDGHHM MCCDHJKIPHH(CBPEEJLPJDB JHFJPGOBMLL)
	{
		return default(BCJCKPDGHHM);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2A20", Offset = "0x5DF1220", VA = "0x185DF2A20", Slot = "8")]
	public IEnumerator<MNOPJOLALGH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2EB0", Offset = "0x5DF16B0", VA = "0x185DF2EB0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x23DB0F0", Offset = "0x23D98F0", VA = "0x1823DB0F0", Slot = "13")]
	public void JKNKCKNNCBG<TKey, T>(MONKJDIIJEC<TKey, T> OLJMCOBAMDO, [Optional] object LIODJEBJPCP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF27D0", Offset = "0x5DF0FD0", VA = "0x185DF27D0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public IAEDJMBFIOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DF27A0", Offset = "0x5DF0FA0", VA = "0x185DF27A0")]
	[CompilerGenerated]
	private MNOPJOLALGH AGEPLHMACLF(int PBGHCEIGALN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[DefaultMember("Item")]
[GJLJLBIABKM(typeof(ANGAFLNDJOG), new string[] { })]
public class FCFLJAKADKE : ANGAFLNDJOG, IEnumerable<AMEANBJHGMM>, IEnumerable, OILIFCGGAMK, OLNFMJBKLAF, MLPMOOACKBB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[MCMLPKDBFJE]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[MCMLPKDBFJE]
	private AACGNIFANPK OMGNBKKNENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private AMEANBJHGMM[] NBPBGPMOMCO;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB7F0", Offset = "0x5DE9FF0", VA = "0x185DEB7F0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public AMEANBJHGMM NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB7E0", Offset = "0x5DE9FE0", VA = "0x185DEB7E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBBD0", Offset = "0x5DEA3D0", VA = "0x185DEBBD0", Slot = "10")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBD10", Offset = "0x5DEA510", VA = "0x185DEBD10", Slot = "11")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB8E0", Offset = "0x5DEA0E0", VA = "0x185DEB8E0")]
	private AMEANBJHGMM FLGOODKAPBJ(int ADMJKDLHPCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB9A0", Offset = "0x5DEA1A0", VA = "0x185DEB9A0", Slot = "6")]
	public AMEANBJHGMM GPMFIJBJGKK(CBPEEJLPJDB JHFJPGOBMLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBC40", Offset = "0x5DEA440", VA = "0x185DEBC40", Slot = "7")]
	public BCJCKPDGHHM MCCDHJKIPHH(CBPEEJLPJDB JHFJPGOBMLL)
	{
		return default(BCJCKPDGHHM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBAC0", Offset = "0x5DEA2C0", VA = "0x185DEBAC0", Slot = "8")]
	public IEnumerator<AMEANBJHGMM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBAC0", Offset = "0x5DEA2C0", VA = "0x185DEBAC0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x235DD30", Offset = "0x235C530", VA = "0x18235DD30", Slot = "12")]
	public void JKNKCKNNCBG<TKey, T>(MONKJDIIJEC<TKey, T> OLJMCOBAMDO, [Optional] object LIODJEBJPCP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB840", Offset = "0x5DEA040", VA = "0x185DEB840", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public FCFLJAKADKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB7E0", Offset = "0x5DE9FE0", VA = "0x185DEB7E0")]
	[CompilerGenerated]
	private AMEANBJHGMM AGEPLHMACLF(int PBGHCEIGALN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(NIEALEGEBJP), new string[] { })]
internal class NIEALEGEBJP : OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private AACGNIFANPK OMGNBKKNENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private ANGAFLNDJOG EPEEAJEBADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private HCANMCICAMH POLDAFCGLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[MCMLPKDBFJE]
	private EIGPEOIKDPK HOKINAOAABH;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public LHCHIBBJMCI LGLMNKGHNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x762D40", Offset = "0x761540", VA = "0x180762D40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x762AF0", Offset = "0x7612F0", VA = "0x180762AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E02BE0", Offset = "0x5E013E0", VA = "0x185E02BE0", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E02B40", Offset = "0x5E01340", VA = "0x185E02B40")]
	private void HBEHDMCFHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E02D30", Offset = "0x5E01530", VA = "0x185E02D30")]
	public ACMAOFLJBJE OPCNICCGMJD(CBPEEJLPJDB BOBHOMKFHJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x24D17B0", Offset = "0x24CFFB0", VA = "0x1824D17B0")]
	public ABDOJNLIFHO<T> GBFAFFAJAIF<T>(CBPEEJLPJDB BOBHOMKFHJB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public NIEALEGEBJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal static class HFOGCINNAOH
{
	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x23ADA90", Offset = "0x23AC290", VA = "0x1823ADA90")]
	public static DDMJLFGLNGL<T> OPCNICCGMJD<T>(this NIEALEGEBJP KGLEDJJIMOJ, GOOBEKCPDHA<T> BOBHOMKFHJB) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[GJLJLBIABKM(typeof(FCENJDFCEED), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public class FCENJDFCEED : GAJGABMNKBI, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[MCMLPKDBFJE]
	private JFFIINNEBJC OHLFIPLFDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private bool AJKNGBCGFPD;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public TimeData EAOJAGIPLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB5F0", Offset = "0x5DE9DF0", VA = "0x185DEB5F0")]
		get
		{
			return default(TimeData);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB590", Offset = "0x5DE9D90", VA = "0x185DEB590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool BAOGDHAKIKF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7DE300", Offset = "0x7DCB00", VA = "0x1807DE300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xB7B520", Offset = "0xB79D20", VA = "0x180B7B520", Slot = "4")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB660", Offset = "0x5DE9E60", VA = "0x185DEB660", Slot = "5")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB6B0", Offset = "0x5DE9EB0", VA = "0x185DEB6B0")]
	public void OBKEFGNHEDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	public void IJOJECBGEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public FCENJDFCEED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(DHNGLBNANFJ), new string[] { })]
public class DHNGLBNANFJ : OILIFCGGAMK, OLNFMJBKLAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private MOJADNJPIHP PCANEKAMGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private HCANMCICAMH PBFNCDEJLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private BCJCKPDGHHM[] GJOOLIIJMNO;

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9D70", Offset = "0x5DE8570", VA = "0x185DE9D70", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9DE0", Offset = "0x5DE85E0", VA = "0x185DE9DE0", Slot = "5")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9C50", Offset = "0x5DE8450", VA = "0x185DE9C50")]
	public void CEJIKJCJBHD(KLEIPEFFJCP LFHNIGHPLBN, bool KCONFHICJHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public DHNGLBNANFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[GJLJLBIABKM(typeof(CKPCCLGFCBJ), new string[] { })]
public sealed class HGLPJJBJFJN : CKPCCLGFCBJ, CCGJODBGILF, GAJGABMNKBI, OILIFCGGAMK, OLNFMJBKLAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class BOKPJCOMNAK : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x954C10", Offset = "0x953410", VA = "0x180954C10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x5DE7890", Offset = "0x5DE6090", VA = "0x185DE7890", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1B3B7B0", Offset = "0x1B39FB0", VA = "0x181B3B7B0")]
		[DebuggerHidden]
		public BOKPJCOMNAK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x5DE75A0", Offset = "0x5DE5DA0", VA = "0x185DE75A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7840", Offset = "0x5DE6040", VA = "0x185DE7840", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7790", Offset = "0x5DE5F90", VA = "0x185DE7790", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7790", Offset = "0x5DE5F90", VA = "0x185DE7790", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[MCMLPKDBFJE]
	private ANGAFLNDJOG PBFNCDEJLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly DIDBKAFHJLB BOADCNMHJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly Dictionary<string, OFEGLBNPCKC> ECNBLGBOBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly Dictionary<int, DCPFKNBLOIN> FMIBDEDFHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly List<AMEANBJHGMM> DALHFLHNKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private LAGDCPPJAAI OAEPCFLENGI;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public DCPFKNBLOIN EEKBPFNPIJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x5DF1A30", Offset = "0x5DF0230", VA = "0x185DF1A30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public List<AMEANBJHGMM> LGPEMBMIPHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "9")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1D40", Offset = "0x5DF0540", VA = "0x185DF1D40", Slot = "10")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2420", Offset = "0x5DF0C20", VA = "0x185DF2420", Slot = "11")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1810", Offset = "0x5DF0010", VA = "0x185DF1810", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1F20", Offset = "0x5DF0720", VA = "0x185DF1F20", Slot = "6")]
	public bool NFOOEPBFDFJ(AMEANBJHGMM OLJMCOBAMDO, [Out] DCPFKNBLOIN ENJDCNEMLMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2040", Offset = "0x5DF0840", VA = "0x185DF2040")]
	private void NPEIFCJDLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1B40", Offset = "0x5DF0340", VA = "0x185DF1B40")]
	private void IKIGHDFLLEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2480", Offset = "0x5DF0C80", VA = "0x185DF2480")]
	private OFEGLBNPCKC PGGGAINEPBA(string GMFAFEGOEON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1A30", Offset = "0x5DF0230", VA = "0x185DF1A30")]
	private OFEGLBNPCKC KLNEOOKHIKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1550", Offset = "0x5DEFD50", VA = "0x185DF1550")]
	private OFEGLBNPCKC CFKDGCPPHBF(string GMFAFEGOEON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1360", Offset = "0x5DEFB60", VA = "0x185DF1360")]
	private OFEGLBNPCKC CEPJIFCDPPO(string OMHPAGCEPHJ, string PIPCHJCEPPJ, [Optional] OFEGLBNPCKC JBABNGAJFBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1EA0", Offset = "0x5DF06A0", VA = "0x185DF1EA0")]
	[IteratorStateMachine(typeof(BOKPJCOMNAK))]
	private IEnumerable<(string, string)> KOLBFMJLHIC(string GMFAFEGOEON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1CF0", Offset = "0x5DF04F0", VA = "0x185DF1CF0")]
	private bool ILOEGIFFHPJ(AMEANBJHGMM OLJMCOBAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1950", Offset = "0x5DF0150", VA = "0x185DF1950")]
	private DIDBKAFHJLB GCIGNBAOFDD(AMEANBJHGMM OLJMCOBAMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1E50", Offset = "0x5DF0650", VA = "0x185DF1E50")]
	private DIDBKAFHJLB KKIGCEDOGOK(AMEANBJHGMM OLJMCOBAMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1FB0", Offset = "0x5DF07B0", VA = "0x185DF1FB0")]
	private DIDBKAFHJLB NMJCHMJAMNF(AMEANBJHGMM OLJMCOBAMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x23ADD10", Offset = "0x23AC510", VA = "0x1823ADD10")]
	private T CABMFMCLMOH<T>(AMEANBJHGMM OLJMCOBAMDO) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF24E0", Offset = "0x5DF0CE0", VA = "0x185DF24E0")]
	private FieldInfo PLNCCBGGBLA(AMEANBJHGMM OLJMCOBAMDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1DA0", Offset = "0x5DF05A0", VA = "0x185DF1DA0", Slot = "7")]
	public void JKCLJMACCFA(AMEANBJHGMM OLJMCOBAMDO, IEMADMGHMDI LBLABPJPMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1A90", Offset = "0x5DF0290", VA = "0x185DF1A90", Slot = "8")]
	public void HOLDKHPGNLM(AMEANBJHGMM OLJMCOBAMDO, IEMADMGHMDI LBLABPJPMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DF25D0", Offset = "0x5DF0DD0", VA = "0x185DF25D0")]
	public HGLPJJBJFJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF18C0", Offset = "0x5DF00C0", VA = "0x185DF18C0")]
	[CompilerGenerated]
	private int FEMPBJJHEOF(AMEANBJHGMM FABNAGLLOKN, AMEANBJHGMM FCOICCIGANJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class OFEGLBNPCKC : DCPFKNBLOIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public readonly string DMNBDAJEMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public readonly OFEGLBNPCKC JBABNGAJFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public readonly List<OFEGLBNPCKC> JCDHAHPONOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public readonly List<AMEANBJHGMM> PBFNCDEJLIJ;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public string DCLBODHBAJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public DCPFKNBLOIN FFLAMFCLHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public IEnumerable<DCPFKNBLOIN> AJPLGJPKKCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E04600", Offset = "0x5E02E00", VA = "0x185E04600")]
	public OFEGLBNPCKC(string BOBHOMKFHJB, OFEGLBNPCKC KLGMOMIJPLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[GJLJLBIABKM(typeof(global::NPOOFHNLFBB), new string[] { })]
internal class GAHKPBOJIFC : global::NPOOFHNLFBB, OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	[MCMLPKDBFJE]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	[MCMLPKDBFJE]
	private GKGBAHAPFBD IGBOANLHLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	[MCMLPKDBFJE]
	private NIEALEGEBJP PBFNCDEJLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	[MCMLPKDBFJE]
	private LAGDCPPJAAI PEPBPPBDPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private Action<HCBGKMEOBBG> ELLFKJCIDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private DDMJLFGLNGL<Entity> KLGMOMIJPLM;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<HCBGKMEOBBG> GAALPPINDPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x5DED6D0", Offset = "0x5DEBED0", VA = "0x185DED6D0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x5DED360", Offset = "0x5DEBB60", VA = "0x185DED360", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DED4D0", Offset = "0x5DEBCD0", VA = "0x185DED4D0", Slot = "6")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5DED1F0", Offset = "0x5DEB9F0", VA = "0x185DED1F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DED6D0", Offset = "0x5DEBED0", VA = "0x185DED6D0")]
	private void ONNMMNPBBOG(Action<HCBGKMEOBBG> IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DED360", Offset = "0x5DEBB60", VA = "0x185DED360")]
	private void KPCOKADLJMA(Action<HCBGKMEOBBG> IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DED660", Offset = "0x5DEBE60", VA = "0x185DED660")]
	private void MNEIAJACJLB(ECFICEJMGLN KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public GAHKPBOJIFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[GJLJLBIABKM(typeof(NDCFFPHJBKL), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public class NDCFFPHJBKL : OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	[MCMLPKDBFJE]
	private JCPLFOIFHBP DHNGEFLBADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	[MCMLPKDBFJE]
	private NKDCELCOEPP MAOCIBLACEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[MCMLPKDBFJE]
	private MKHOKPNBAOG EMCGPGCLFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[MCMLPKDBFJE]
	private PGHBFFANNIO IBCBDBLGJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E01D70", Offset = "0x5E00570", VA = "0x185E01D70", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E01D20", Offset = "0x5E00520", VA = "0x185E01D20", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E01C40", Offset = "0x5E00440", VA = "0x185E01C40")]
	private void BIFFCPCEGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E01D20", Offset = "0x5E00520", VA = "0x185E01D20")]
	private void IDEMBCLMHJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E01CD0", Offset = "0x5E004D0", VA = "0x185E01CD0")]
	private void BMMMLPHIJOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public NDCFFPHJBKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[GJLJLBIABKM(typeof(ECPCCCMKFNI), new string[] { })]
public class CIEOMIMOBOO : ECPCCCMKFNI, OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	[MCMLPKDBFJE]
	private HOKKMAFBPHI MDMPLMBODCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[MCMLPKDBFJE]
	private DGCDFIAGJDB HCAPGGFCBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly List<NativeListAsync<Entity>> HHLMEFGMPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly List<(NativeListAsync<Entity>, bool)> FNPBGIOPPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private BKNKPPEAGMA HJPFOJOENMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private Dictionary<Entity, DHMCMFMECFD> OGJGLNAMFMK;

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8D70", Offset = "0x5DE7570", VA = "0x185DE8D70", Slot = "8")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE80A0", Offset = "0x5DE68A0", VA = "0x185DE80A0", Slot = "4")]
	public void DFENILBFJGD(NativeListAsync<Entity> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8D20", Offset = "0x5DE7520", VA = "0x185DE8D20", Slot = "5")]
	public void INAEBBEGAOI(BKNKPPEAGMA HJPFOJOENMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE89B0", Offset = "0x5DE71B0", VA = "0x185DE89B0", Slot = "6")]
	public void HOIAKKKELCJ(NativeListAsync<Entity> EFLDIIILPLM, bool ABIBFNBAHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8600", Offset = "0x5DE6E00", VA = "0x185DE8600", Slot = "7")]
	public void FHIKBDLBFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8170", Offset = "0x5DE6970", VA = "0x185DE8170", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8AE0", Offset = "0x5DE72E0", VA = "0x185DE8AE0")]
	private int IAFAJAPELIO(NativeListAsync<Entity> HHLMEFGMPJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8DE0", Offset = "0x5DE75E0", VA = "0x185DE8DE0")]
	private int LDOKMIENAHN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9050", Offset = "0x5DE7850", VA = "0x185DE9050")]
	private int PDLLNOCOPHJ(NativeListAsync<Entity> FNPBGIOPPOI, bool CGOADIFEIKK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9300", Offset = "0x5DE7B00", VA = "0x185DE9300")]
	public CIEOMIMOBOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8980", Offset = "0x5DE7180", VA = "0x185DE8980")]
	[CompilerGenerated]
	private JEDJBKOCEME GBODKDHJFIG(Entity MFFDEAINOPL)
	{
		return default(JEDJBKOCEME);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
[GJLJLBIABKM(typeof(CGEKBNLHEMJ), new string[] { })]
public class CGEKBNLHEMJ : OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly List<NativeListAsync<BNHBLFIGPPL>> HDADBIPDLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7F30", Offset = "0x5DE6730", VA = "0x185DE7F30", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5DE78E0", Offset = "0x5DE60E0", VA = "0x185DE78E0")]
	public void AGPMCPFDMOJ(NativeListAsync<BNHBLFIGPPL> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7B30", Offset = "0x5DE6330", VA = "0x185DE7B30")]
	public void INGIJIKGCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5DE79B0", Offset = "0x5DE61B0", VA = "0x185DE79B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8010", Offset = "0x5DE6810", VA = "0x185DE8010")]
	public CGEKBNLHEMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[GJLJLBIABKM(typeof(GCMHDFHOGLD), new string[] { })]
public class BBDKKKLMKPD : OILIFCGGAMK, GCMHDFHOGLD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private EntityManager DHDOKMIFNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private IJGBKLONMFB OLCDIDPCHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private DGCDFIAGJDB HCAPGGFCBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5500", Offset = "0x5DE3D00", VA = "0x185DE5500", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5DE54F0", Offset = "0x5DE3CF0", VA = "0x185DE54F0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE53B0", Offset = "0x5DE3BB0", VA = "0x185DE53B0", Slot = "5")]
	public bool CNJCCDOBAJF(JEDJBKOCEME JBPJNGFGLPC, [Out] Collider AFMGELLDLJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE55D0", Offset = "0x5DE3DD0", VA = "0x185DE55D0", Slot = "6")]
	public GameObject LPIGCKLIIJJ(JEDJBKOCEME COIGAFPEHAP, GameObject FLAMNAIIHJK, Vector3 CINCGMPJHMP, Quaternion LAEFAMPNPGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5860", Offset = "0x5DE4060", VA = "0x185DE5860", Slot = "7")]
	public void PEFMBIDFLKC(GameObject AFMGELLDLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x218C630", Offset = "0x218AE30", VA = "0x18218C630", Slot = "8")]
	public TCollider EGABHFCCJFL<TCollider>(GameObject GJLPKBPIBII) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5790", Offset = "0x5DE3F90", VA = "0x185DE5790", Slot = "9")]
	public void OGJABHOKEIG(Collider AFMGELLDLJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x218C630", Offset = "0x218AE30", VA = "0x18218C630", Slot = "10")]
	public GameObject JOKJHJACKFI<TCollider>(string BOBHOMKFHJB) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public BBDKKKLMKPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[GJLJLBIABKM(typeof(ENDHILGPLNG), new string[] { })]
public class KPKAIBNFKHB : OILIFCGGAMK, ENDHILGPLNG
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class NJFGPICAPEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public JEDJBKOCEME localId;

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public NJFGPICAPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x5E21AA0", Offset = "0x5E202A0", VA = "0x185E21AA0")]
		internal object LIKFPBDEACD(KPKAIBNFKHB a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class FOGGMNDIIIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public JEDJBKOCEME localId;

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public FOGGMNDIIIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x5E131B0", Offset = "0x5E119B0", VA = "0x185E131B0")]
		internal object DOIFIMNEHMJ(KPKAIBNFKHB a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private CECLHBPNMGM NBODHKFBPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private World LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private CNMOLKDLNOJ KPKGNGCLIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[MCMLPKDBFJE]
	private JFFIINNEBJC OHLFIPLFDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private EntityManager GFNLNEIKNMA;

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF620", Offset = "0x5DFDE20", VA = "0x185DFF620", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCD10", Offset = "0x5DFB510", VA = "0x185DFCD10", Slot = "6")]
	public APEBMOKBFMO ADLCCDLFKBK(JEDJBKOCEME JBPJNGFGLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF080", Offset = "0x5DFD880", VA = "0x185DFF080", Slot = "5")]
	public void IDJNBDCKNEO(JEDJBKOCEME JBPJNGFGLPC, APEBMOKBFMO IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD730", Offset = "0x5DFBF30", VA = "0x185DFD730", Slot = "31")]
	public CollisionDetectionMode BOIMHFBMNHE(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(CollisionDetectionMode);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFF00", Offset = "0x5DFE700", VA = "0x185DFFF00", Slot = "32")]
	public void NFCDBCIDGLE(JEDJBKOCEME JBPJNGFGLPC, CollisionDetectionMode IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF1B0", Offset = "0x5DFD9B0", VA = "0x185DFF1B0", Slot = "33")]
	public ACDLKJGOCEB IJOJEICANOI(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(ACDLKJGOCEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5E00660", Offset = "0x5DFEE60", VA = "0x185E00660", Slot = "34")]
	public void POPKEHJKHCN(JEDJBKOCEME JBPJNGFGLPC, ACDLKJGOCEB IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5E00180", Offset = "0x5DFE980", VA = "0x185E00180", Slot = "35")]
	public bool OBIPMIJMEMG(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDEA0", Offset = "0x5DFC6A0", VA = "0x185DFDEA0", Slot = "36")]
	public void DEJIMFJNPOK(JEDJBKOCEME JBPJNGFGLPC, bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x5E00200", Offset = "0x5DFEA00", VA = "0x185E00200", Slot = "37")]
	public JEDJBKOCEME OEBJBPNCIBI(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD340", Offset = "0x5DFBB40", VA = "0x185DFD340", Slot = "38")]
	public void BGDMOBMKPEP(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF8E0", Offset = "0x5DFE0E0", VA = "0x185DFF8E0", Slot = "39")]
	public JEDJBKOCEME KAHCMOIEBOO(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x5E00070", Offset = "0x5DFE870", VA = "0x185E00070", Slot = "40")]
	public void OABOCDMKFCC(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD550", Offset = "0x5DFBD50", VA = "0x185DFD550", Slot = "7")]
	public void BIJCLJDBJFN(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFF90", Offset = "0x5DFE790", VA = "0x185DFFF90", Slot = "8")]
	public void NMIJLKFFGOC(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE550", Offset = "0x5DFCD50", VA = "0x185DFE550", Slot = "9")]
	public int FAGDHMFPDCE(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF290", Offset = "0x5DFDA90", VA = "0x185DFF290", Slot = "10")]
	public JEDJBKOCEME IJPOHDMBNCL(JEDJBKOCEME JBPJNGFGLPC, int ADMJKDLHPCI)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5E002A0", Offset = "0x5DFEAA0", VA = "0x185E002A0", Slot = "11")]
	public void OPFMAOODMHA(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF410", Offset = "0x5DFDC10", VA = "0x185DFF410", Slot = "12")]
	public void INEGLMPLIJI(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ, JEDJBKOCEME IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE620", Offset = "0x5DFCE20", VA = "0x185DFE620", Slot = "13")]
	public void FBLAOPIDCJE(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5DFECD0", Offset = "0x5DFD4D0", VA = "0x185DFECD0", Slot = "14")]
	public bool GNKFCBMJMND(JEDJBKOCEME JBPJNGFGLPC, [Out] JEDJBKOCEME IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEEF0", Offset = "0x5DFD6F0", VA = "0x185DFEEF0", Slot = "15")]
	public void HOOLMEOMJIJ(JEDJBKOCEME JBPJNGFGLPC, float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE980", Offset = "0x5DFD180", VA = "0x185DFE980", Slot = "16")]
	public bool FODAOOGGFDN(JEDJBKOCEME JBPJNGFGLPC, [Out] float3 IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDF10", Offset = "0x5DFC710", VA = "0x185DFDF10", Slot = "17")]
	public void DHLGNIMEIAH(JEDJBKOCEME JBPJNGFGLPC, float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDD40", Offset = "0x5DFC540", VA = "0x185DFDD40", Slot = "18")]
	public bool DEEHGLALCJH(JEDJBKOCEME JBPJNGFGLPC, [Out] float3 IFKKLLBODIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x5E00370", Offset = "0x5DFEB70", VA = "0x185E00370", Slot = "23")]
	[Obsolete("Use SetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	public float3 PCAOACOIBDA(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCC70", Offset = "0x5DFB470", VA = "0x185DFCC70", Slot = "24")]
	public float3 ADHPFGALHMG(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE120", Offset = "0x5DFC920", VA = "0x185DFE120", Slot = "25")]
	public void DMPEBFBDADG(JEDJBKOCEME JBPJNGFGLPC, float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE6B0", Offset = "0x5DFCEB0", VA = "0x185DFE6B0", Slot = "26")]
	public void FBPGIPIFKPF(JEDJBKOCEME JBPJNGFGLPC, float3 IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD250", Offset = "0x5DFBA50", VA = "0x185DFD250", Slot = "27")]
	[Obsolete("Use GetMassOfSelf or TryGetMassOfHierarchy")]
	public float BFHHHEHGJHE(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE1C0", Offset = "0x5DFC9C0", VA = "0x185DFE1C0", Slot = "28")]
	public float EBIEOOBOFFF(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE750", Offset = "0x5DFCF50", VA = "0x185DFE750", Slot = "29")]
	public void FBPOOIAEPPI(JEDJBKOCEME JBPJNGFGLPC, float IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE8F0", Offset = "0x5DFD0F0", VA = "0x185DFE8F0", Slot = "30")]
	public void FJFGNOGNIPG(JEDJBKOCEME JBPJNGFGLPC, float IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD980", Offset = "0x5DFC180", VA = "0x185DFD980", Slot = "19")]
	public void CGPMENMPDBK(JEDJBKOCEME JBPJNGFGLPC, (Quaternion rot, Vector3 moments) JGHIMDFPNCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE240", Offset = "0x5DFCA40", VA = "0x185DFE240", Slot = "20")]
	public bool ECEOBPMANAA(JEDJBKOCEME JBPJNGFGLPC, [Out] quaternion CPFEILLBOLJ, [Out] float3 PBHIHEKOGGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE870", Offset = "0x5DFD070", VA = "0x185DFE870", Slot = "41")]
	public JEFEPIIEDML FFLMPCIJDNG(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(JEFEPIIEDML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF7D0", Offset = "0x5DFDFD0", VA = "0x185DFF7D0", Slot = "42")]
	public void JOHICBMMGMC(JEDJBKOCEME JBPJNGFGLPC, JEFEPIIEDML IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFC50", Offset = "0x5DFE450", VA = "0x185DFFC50", Slot = "66")]
	public void LMGGNPNHCDB(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEE10", Offset = "0x5DFD610", VA = "0x185DFEE10", Slot = "67")]
	public void HKAPCFMCLBE(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDFB0", Offset = "0x5DFC7B0", VA = "0x185DFDFB0", Slot = "68")]
	public bool DHONLPJLAOP(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFB50", Offset = "0x5DFE350", VA = "0x185DFFB50", Slot = "82")]
	public bool LKMIIIPIBNF(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD050", Offset = "0x5DFB850", VA = "0x185DFD050", Slot = "83")]
	public void AMGLABEOBOG(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ, bool NJMFKLMAKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEAE0", Offset = "0x5DFD2E0", VA = "0x185DFEAE0", Slot = "84")]
	public void GFEDIGIOGCL(JEDJBKOCEME JBPJNGFGLPC, bool JMHLHMDOJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF140", Offset = "0x5DFD940", VA = "0x185DFF140", Slot = "86")]
	public bool IGONBLFBHLO(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCFE0", Offset = "0x5DFB7E0", VA = "0x185DFCFE0", Slot = "85")]
	public void AJCGAKODIKP(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF9E0", Offset = "0x5DFE1E0", VA = "0x185DFF9E0", Slot = "43")]
	public bool KFLOMCKHFNP(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFAF0", Offset = "0x5DFE2F0", VA = "0x185DFFAF0", Slot = "44")]
	public void KONKPDAFHHD(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE440", Offset = "0x5DFCC40", VA = "0x185DFE440", Slot = "45")]
	public bool EGNCGMNJKHM(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD6C0", Offset = "0x5DFBEC0", VA = "0x185DFD6C0", Slot = "46")]
	public void BOFHFKCFBFE(JEDJBKOCEME JBPJNGFGLPC, bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEBD0", Offset = "0x5DFD3D0", VA = "0x185DFEBD0", Slot = "47")]
	public bool GNACBDJCOFO(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFE00", Offset = "0x5DFE600", VA = "0x185DFFE00", Slot = "48")]
	public void MGKNGPLIMBE(JEDJBKOCEME JBPJNGFGLPC, bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD900", Offset = "0x5DFC100", VA = "0x185DFD900", Slot = "49")]
	public RigidbodyConstraints CCDGOFOBEFK(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(RigidbodyConstraints);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF740", Offset = "0x5DFDF40", VA = "0x185DFF740", Slot = "50")]
	public void JBGHOPGBENE(JEDJBKOCEME JBPJNGFGLPC, RigidbodyConstraints IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFD80", Offset = "0x5DFE580", VA = "0x185DFFD80", Slot = "51")]
	public float MGFHFBPONOO(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD630", Offset = "0x5DFBE30", VA = "0x185DFD630", Slot = "52")]
	public void BKFACAEFAPB(JEDJBKOCEME JBPJNGFGLPC, float IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDCC0", Offset = "0x5DFC4C0", VA = "0x185DFDCC0", Slot = "53")]
	public float DCCLHLFILNI(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFE70", Offset = "0x5DFE670", VA = "0x185DFFE70", Slot = "54")]
	public void NAINPBDLHCD(JEDJBKOCEME JBPJNGFGLPC, float IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF860", Offset = "0x5DFE060", VA = "0x185DFF860", Slot = "55")]
	public bool JPGOJHAEBHE(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x5E00110", Offset = "0x5DFE910", VA = "0x185E00110", Slot = "56")]
	public void OAGKNKPIAAK(JEDJBKOCEME JBPJNGFGLPC, bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEC50", Offset = "0x5DFD450", VA = "0x185DFEC50", Slot = "57")]
	public bool GNBJNOHOJGE(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDC50", Offset = "0x5DFC450", VA = "0x185DFDC50", Slot = "58")]
	public void CONADDACDID(JEDJBKOCEME JBPJNGFGLPC, bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE7E0", Offset = "0x5DFCFE0", VA = "0x185DFE7E0", Slot = "59")]
	public void FCDLLIFCHJB(JEDJBKOCEME JBPJNGFGLPC, int IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x5E005D0", Offset = "0x5DFEDD0", VA = "0x185E005D0", Slot = "73")]
	public Rigidbody PEOJOCDELNF(JEDJBKOCEME JBPJNGFGLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5E00480", Offset = "0x5DFEC80", VA = "0x185E00480", Slot = "74")]
	public void PELFENJJLEC(JEDJBKOCEME JBPJNGFGLPC, Rigidbody IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCDA0", Offset = "0x5DFB5A0", VA = "0x185DFCDA0", Slot = "75")]
	public void AEFFGJKAICA(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF510", Offset = "0x5DFDD10", VA = "0x185DFF510", Slot = "76")]
	public void INPHNFIIGGF(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCE20", Offset = "0x5DFB620", VA = "0x185DFCE20", Slot = "77")]
	public bool AGDAIGECDLC(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEFF0", Offset = "0x5DFD7F0", VA = "0x185DFEFF0", Slot = "60")]
	public object IBMBDHLADFN(JEDJBKOCEME JBPJNGFGLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCE90", Offset = "0x5DFB690", VA = "0x185DFCE90", Slot = "61")]
	public void AIMINBMBFEM(JEDJBKOCEME JBPJNGFGLPC, object IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE4C0", Offset = "0x5DFCCC0", VA = "0x185DFE4C0", Slot = "62")]
	public object EGNMIMGKNNL(JEDJBKOCEME JBPJNGFGLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD7B0", Offset = "0x5DFBFB0", VA = "0x185DFD7B0", Slot = "63")]
	public void CCBCAMHGMLP(JEDJBKOCEME JBPJNGFGLPC, object IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF390", Offset = "0x5DFDB90", VA = "0x185DFF390", Slot = "64")]
	public float IMEABJDGKPL(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFA60", Offset = "0x5DFE260", VA = "0x185DFFA60", Slot = "65")]
	public void KIJOJFKOOLG(JEDJBKOCEME JBPJNGFGLPC, float IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF5A0", Offset = "0x5DFDDA0", VA = "0x185DFF5A0", Slot = "69")]
	public void IOPFONODHLH(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDB10", Offset = "0x5DFC310", VA = "0x185DFDB10", Slot = "70")]
	public void CJPMHOBDDOK(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD3E0", Offset = "0x5DFBBE0", VA = "0x185DFD3E0", Slot = "71")]
	public bool BGJCFKMOCMI(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF980", Offset = "0x5DFE180", VA = "0x185DFF980", Slot = "21")]
	public void KEADNDDAJAP(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEF90", Offset = "0x5DFD790", VA = "0x185DFEF90", Slot = "22")]
	public void IAHAACMDFPI(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEB50", Offset = "0x5DFD350", VA = "0x185DFEB50", Slot = "72")]
	public bool GLPILHNPIFA(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD450", Offset = "0x5DFBC50", VA = "0x185DFD450", Slot = "78")]
	public void BHLHPBLDOID(JEDJBKOCEME JBPJNGFGLPC, float3 NKFCPJHMPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE020", Offset = "0x5DFC820", VA = "0x185DFE020", Slot = "79")]
	public void DMIBDKPMJHG(JEDJBKOCEME JBPJNGFGLPC, float3 GNGHKECLLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD200", Offset = "0x5DFBA00", VA = "0x185DFD200", Slot = "80")]
	public bool BAPFICDKPHL(JEDJBKOCEME JBPJNGFGLPC, [Out] float3 NKFCPJHMPBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEEA0", Offset = "0x5DFD6A0", VA = "0x185DFEEA0", Slot = "81")]
	public bool HLMGGFKHOOK(JEDJBKOCEME JBPJNGFGLPC, [Out] float3 GNGHKECLLEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDBA0", Offset = "0x5DFC3A0", VA = "0x185DFDBA0")]
	private DynamicBuffer<Entity> CKLNPGAFOII(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFCD0", Offset = "0x5DFE4D0", VA = "0x185DFFCD0")]
	private DynamicBuffer<Entity> LNBEIJJBBFN(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x244B760", Offset = "0x2449F60", VA = "0x18244B760")]
	private void JLJLBHEBDIL<T>(JEDJBKOCEME JBPJNGFGLPC, object IFKKLLBODIE, Func<object, T> BIIOEMJLPLG) where T : class, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public KPKAIBNFKHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
[GJLJLBIABKM(typeof(FNNHLGFMHNI), new string[] { })]
public class FNNHLGFMHNI : OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class DFOJPBDNCOL : IEnumerable<APEBMOKBFMO>, IEnumerable, IEnumerator<APEBMOKBFMO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private APEBMOKBFMO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public FNNHLGFMHNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private NativeArray<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public NativeArray<Entity> <>3__entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private EntityManager <entityManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private NativeArray<Entity>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		private APEBMOKBFMO System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x866770", Offset = "0x864F70", VA = "0x180866770")]
		[DebuggerHidden]
		public DFOJPBDNCOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5E109A0", Offset = "0x5E0F1A0", VA = "0x185E109A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x5E10670", Offset = "0x5E0EE70", VA = "0x185E10670", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5E10620", Offset = "0x5E0EE20", VA = "0x185E10620")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5E10950", Offset = "0x5E0F150", VA = "0x185E10950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5E108A0", Offset = "0x5E0F0A0", VA = "0x185E108A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<APEBMOKBFMO> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x5E108A0", Offset = "0x5E0F0A0", VA = "0x185E108A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> GNCALEFJAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x5E13040", Offset = "0x5E11840", VA = "0x185E13040", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x5E12290", Offset = "0x5E10A90", VA = "0x185E12290")]
	public void AGPMCPFDMOJ(NativeArray<Entity> EFLDIIILPLM, bool NNHFHLJJNDD, bool GALOGOCDHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x5E12E00", Offset = "0x5E11600", VA = "0x185E12E00")]
	public void INGIJIKGCIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x5E125F0", Offset = "0x5E10DF0", VA = "0x185E125F0")]
	private void EANOJJGCEJF(NativeArray<Entity> EFLDIIILPLM, bool NNHFHLJJNDD, bool GALOGOCDHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x5E123F0", Offset = "0x5E10BF0", VA = "0x185E123F0")]
	[IteratorStateMachine(typeof(DFOJPBDNCOL))]
	private IEnumerable<APEBMOKBFMO> DAIADNPKLHN(NativeArray<Entity> EFLDIIILPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x5E12480", Offset = "0x5E10C80", VA = "0x185E12480", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x5E13120", Offset = "0x5E11920", VA = "0x185E13120")]
	public FNNHLGFMHNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[GJLJLBIABKM(typeof(ONKAIGMIMMN), new string[] { })]
public class JMLNBHPEHPP : ONKAIGMIMMN, OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private class AANCKEDAEBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public List<CapsuleCollider> JIOCDIFFICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public List<SphereCollider> CHCDLLLNFNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public GameObject INHDHPEJBKG;

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x5E08FF0", Offset = "0x5E077F0", VA = "0x185E08FF0")]
		public AANCKEDAEBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	[MCMLPKDBFJE]
	private HOKKMAFBPHI MDMPLMBODCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[MCMLPKDBFJE]
	private GCMHDFHOGLD EMPIMJEKDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly Dictionary<Entity, AANCKEDAEBP> HCNJDJOBKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private GameObject IEIBAPGDBEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private GameObject KDNBONMJAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private GameObject GHJAFLBEAAL;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private GameObject MFMEPGGHHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x5E1AE70", Offset = "0x5E19670", VA = "0x185E1AE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B210", Offset = "0x5E19A10", VA = "0x185E1B210", Slot = "6")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B280", Offset = "0x5E19A80", VA = "0x185E1B280", Slot = "4")]
	public void JBCNIMKDPDB(Entity APJPFCLOHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5E19DD0", Offset = "0x5E185D0", VA = "0x185E19DD0", Slot = "5")]
	public void BGNOAGNIPIH(Entity APJPFCLOHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AF30", Offset = "0x5E19730", VA = "0x185E1AF30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B6A0", Offset = "0x5E19EA0", VA = "0x185E1B6A0")]
	private AANCKEDAEBP PHEOAHKGDBL(Entity APJPFCLOHOC, IIGOCDJOBNI CPJMAEMAJBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A320", Offset = "0x5E18B20", VA = "0x185E1A320")]
	private void BIEONBDHJOL(IIGOCDJOBNI CPJMAEMAJBC, AANCKEDAEBP DDILHFCACPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B4C0", Offset = "0x5E19CC0", VA = "0x185E1B4C0")]
	private void LNKKHHLAHLK(IIGOCDJOBNI CPJMAEMAJBC, AANCKEDAEBP DDILHFCACPJ, int GCJOCCJGAAD, Vector3 OBAACBLACLC, Quaternion AHLHKGGFBGH, float KPOEIGEKNFE, float EECPDFLCEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B050", Offset = "0x5E19850", VA = "0x185E1B050")]
	private void FKBJIMJFJIM(AANCKEDAEBP DDILHFCACPJ, int JKEAAEOIGIC, Vector3 OBAACBLACLC, float KPOEIGEKNFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5E19AF0", Offset = "0x5E182F0", VA = "0x185E19AF0")]
	private void AJBHOMAAIPK(IIGOCDJOBNI CPJMAEMAJBC, AANCKEDAEBP DDILHFCACPJ, int LCNFCBPNLGE, int GFFDBAHPAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x24266E0", Offset = "0x2424EE0", VA = "0x1824266E0")]
	private T JFMFAHIGMHC<T>(IIGOCDJOBNI CPJMAEMAJBC, GameObject NDAADLGGBHN, Vector3 CINCGMPJHMP, Quaternion LAEFAMPNPGA) where T : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B990", Offset = "0x5E1A190", VA = "0x185E1B990")]
	public JMLNBHPEHPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[GJLJLBIABKM(typeof(ALHOKAPBJCK), new string[] { })]
public class COKAKMGNFPA : OILIFCGGAMK, OLNFMJBKLAF, ALHOKAPBJCK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private GKGBAHAPFBD IGBOANLHLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private KKDHBJBFPOF GKDFLIHPFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private LAGDCPPJAAI OAEPCFLENGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private FKIKNFLFAMI MFGBPFDJKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private int FMGGBIJFPAA;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public bool EMICMDNOLJB
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D970", Offset = "0x5E0C170", VA = "0x185E0D970", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public JEDJBKOCEME LBDDMOPJKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5E0DE00", Offset = "0x5E0C600", VA = "0x185E0DE00", Slot = "9")]
		get
		{
			return default(JEDJBKOCEME);
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D3F0", Offset = "0x5E0BBF0", VA = "0x185E0D3F0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public EEKEIMNDBGI BKPEDCHIMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5E0DB40", Offset = "0x5E0C340", VA = "0x185E0DB40", Slot = "11")]
		get
		{
			return default(EEKEIMNDBGI);
		}
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D3F0", Offset = "0x5E0BBF0", VA = "0x185E0D3F0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private uint ABDNOGHCJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D660", Offset = "0x5E0BE60", VA = "0x185E0D660")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event BDBNCJGLFHC MKOHONAJGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5E0DD60", Offset = "0x5E0C560", VA = "0x185E0DD60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5E0D4D0", Offset = "0x5E0BCD0", VA = "0x185E0D4D0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E0DA70", Offset = "0x5E0C270", VA = "0x185E0DA70", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E0DE20", Offset = "0x5E0C620", VA = "0x185E0DE20", Slot = "5")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D570", Offset = "0x5E0BD70", VA = "0x185E0D570", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E0DB70", Offset = "0x5E0C370", VA = "0x185E0DB70")]
	private void KHINMCCOELJ(ECFICEJMGLN KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D9A0", Offset = "0x5E0C1A0", VA = "0x185E0D9A0", Slot = "13")]
	public JEDJBKOCEME HJLGGCKIIPA(JEDJBKOCEME HBMBMELELPF, JEDJBKOCEME OPFJANEEJKH)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D6B0", Offset = "0x5E0BEB0", VA = "0x185E0D6B0", Slot = "14")]
	public bool EPHMNKOPEON(JEDJBKOCEME HBMBMELELPF, JEDJBKOCEME OPFJANEEJKH, [Out] JEDJBKOCEME NIPMIADLFPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E0DFB0", Offset = "0x5E0C7B0", VA = "0x185E0DFB0", Slot = "15")]
	public void OLGBIOFNHLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D460", Offset = "0x5E0BC60", VA = "0x185E0D460", Slot = "16")]
	public void BMABAHCPNMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D7A0", Offset = "0x5E0BFA0", VA = "0x185E0D7A0", Slot = "17")]
	public bool FOHLCEBFGFM(JEDJBKOCEME HBMBMELELPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D8C0", Offset = "0x5E0C0C0", VA = "0x185E0D8C0", Slot = "18")]
	public bool GHKNDPCLBLC(JEDJBKOCEME HBMBMELELPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D3F0", Offset = "0x5E0BBF0", VA = "0x185E0D3F0")]
	private void GCGOBGFJBCM(JEDJBKOCEME PCJOENEKCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public COKAKMGNFPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[GJLJLBIABKM(typeof(OELIOIGNFBB), new string[] { })]
public class EBGCFFLDFBL : OILIFCGGAMK, OELIOIGNFBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private EntityManager DHDOKMIFNAD;

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E11730", Offset = "0x5E0FF30", VA = "0x185E11730", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E116D0", Offset = "0x5E0FED0", VA = "0x185E116D0", Slot = "5")]
	public void DBJCJOALLJP(JEDJBKOCEME ADMPFLAIEKN, bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x2246900", Offset = "0x2245100", VA = "0x182246900")]
	private void ABNCEPDOIJI<T>(JEDJBKOCEME ADMPFLAIEKN, bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public EBGCFFLDFBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[GJLJLBIABKM(typeof(DIIBKKJDGKE), new string[] { })]
public class OGAKHFEKNOH : OILIFCGGAMK, DIIBKKJDGKE
{
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private EntityManager DHDOKMIFNAD;

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E21B40", Offset = "0x5E20340", VA = "0x185E21B40", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E21BC0", Offset = "0x5E203C0", VA = "0x185E21BC0", Slot = "5")]
	public void JCDNFBLLCNJ(JEDJBKOCEME ADMPFLAIEKN, bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E21C20", Offset = "0x5E20420", VA = "0x185E21C20", Slot = "6")]
	public void LGCIEALPAHC(JEDJBKOCEME ADMPFLAIEKN, bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E21C80", Offset = "0x5E20480", VA = "0x185E21C80", Slot = "7")]
	public void POCOFDDFHIM(JEDJBKOCEME ADMPFLAIEKN, int IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x24F1570", Offset = "0x24EFD70", VA = "0x1824F1570")]
	private void ABNCEPDOIJI<T>(JEDJBKOCEME ADMPFLAIEKN, bool IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x24F1620", Offset = "0x24EFE20", VA = "0x1824F1620")]
	private void ABNCEPDOIJI<T>(JEDJBKOCEME ADMPFLAIEKN, T KOIMDAJNDOD) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public OGAKHFEKNOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
[GJLJLBIABKM(typeof(DLACHKFBCNO), new string[] { })]
public class DLACHKFBCNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly Dictionary<DFMGIJCAPCL, string> EOEGCEMFOGL;

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E10A30", Offset = "0x5E0F230", VA = "0x185E10A30")]
	public GameObject EJMEKOFMJEJ(DFMGIJCAPCL CFOIOJGOMCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E10B00", Offset = "0x5E0F300", VA = "0x185E10B00")]
	public DLACHKFBCNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[GJLJLBIABKM(typeof(JLKEMEILCNJ), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
internal class JLKEMEILCNJ : OILIFCGGAMK, OLNFMJBKLAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private CECLHBPNMGM NBODHKFBPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private DDMJLFGLNGL<Entity> KLGMOMIJPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private PGHBFFANNIO JPACBGFEFHP;

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E19510", Offset = "0x5E17D10", VA = "0x185E19510", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E196C0", Offset = "0x5E17EC0", VA = "0x185E196C0", Slot = "5")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E19470", Offset = "0x5E17C70", VA = "0x185E19470", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E19580", Offset = "0x5E17D80", VA = "0x185E19580")]
	private void JJLKLPNCHPH(Entity MFFDEAINOPL, [In] LELJJGNMHGH DMLGIICOGHN, [In] LELJJGNMHGH EPKJMINCAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public JLKEMEILCNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DefaultMember("Item")]
public class NINMLHGGCPA<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
public class AGNAANDCODD<From, To>
{
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
public class LEPKMKNEFEI<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly Func<From, To> OCCPPAEAGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Func<To, From> BDLFPIHHOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public NativeArray<From> JMHHCKCLFBI;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public To NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x3997D50", Offset = "0x3996550", VA = "0x183997D50", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x3997DB0", Offset = "0x39965B0", VA = "0x183997DB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x3997D40", Offset = "0x3996540", VA = "0x183997D40", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public bool FCEGNANDKHA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x77C260", Offset = "0x77AA60", VA = "0x18077C260", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x760A40", Offset = "0x75F240", VA = "0x180760A40")]
	public LEPKMKNEFEI(Func<From, To> OCCPPAEAGOC, Func<To, From> BDLFPIHHOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x39978B0", Offset = "0x39960B0", VA = "0x1839978B0", Slot = "11")]
	public void Add(To AKPEBFBEHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x3997900", Offset = "0x3996100", VA = "0x183997900", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x3997950", Offset = "0x3996150", VA = "0x183997950", Slot = "13")]
	public bool Contains(To AKPEBFBEHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x3997A30", Offset = "0x3996230", VA = "0x183997A30", Slot = "14")]
	public void CopyTo(To[] JMHHCKCLFBI, int HPIBLFHGGKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x3997AF0", Offset = "0x39962F0", VA = "0x183997AF0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x3997BB0", Offset = "0x39963B0", VA = "0x183997BB0", Slot = "6")]
	public int IndexOf(To AKPEBFBEHGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3997C50", Offset = "0x3996450", VA = "0x183997C50", Slot = "7")]
	public void Insert(int ADMJKDLHPCI, To AKPEBFBEHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3997CF0", Offset = "0x39964F0", VA = "0x183997CF0", Slot = "15")]
	public bool Remove(To AKPEBFBEHGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3997CA0", Offset = "0x39964A0", VA = "0x183997CA0", Slot = "8")]
	public void RemoveAt(int ADMJKDLHPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x2FFA4C0", Offset = "0x2FF8CC0", VA = "0x182FFA4C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct GOACCCGGODP : IComparable<GOACCCGGODP>, IEquatable<GOACCCGGODP>
{
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public static readonly GOACCCGGODP GCBDJIKNIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public KLEIPEFFJCP ADMPFLAIEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public BCJCKPDGHHM BFLLNKNNDBB;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public bool NLJMBAJEDED
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E141B0", Offset = "0x5E129B0", VA = "0x185E141B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x978550", Offset = "0x976D50", VA = "0x180978550")]
	public GOACCCGGODP(KLEIPEFFJCP ADMPFLAIEKN, BCJCKPDGHHM BFLLNKNNDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E13FA0", Offset = "0x5E127A0", VA = "0x185E13FA0", Slot = "4")]
	public int CompareTo(GOACCCGGODP GHNNCJBDHKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E141C0", Offset = "0x5E129C0", VA = "0x185E141C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E140B0", Offset = "0x5E128B0", VA = "0x185E140B0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E14020", Offset = "0x5E12820", VA = "0x185E14020", Slot = "5")]
	public bool Equals(GOACCCGGODP GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E14140", Offset = "0x5E12940", VA = "0x185E14140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct OOMGJHEGCMJ : IEnumerable<GOACCCGGODP>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum JMHDNBEMGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public struct CNDKINBHKIM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private NativeList<byte> KOIMDAJNDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private OOMGJHEGCMJ KAEOEAACCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private readonly GOACCCGGODP MOHHJLIGFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private readonly int IAIBEBECMJB;

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E0CFE0", Offset = "0x5E0B7E0", VA = "0x185E0CFE0")]
		internal CNDKINBHKIM(OOMGJHEGCMJ KAEOEAACCCG, GOACCCGGODP MOHHJLIGFPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E0CDB0", Offset = "0x5E0B5B0", VA = "0x185E0CDB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E0CF40", Offset = "0x5E0B740", VA = "0x185E0CF40")]
		public void HBKPFHBBGAN(ReadOnlySpan<byte> IFKKLLBODIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E0CE40", Offset = "0x5E0B640", VA = "0x185E0CE40")]
		private void GAAGGFFDGKN(ReadOnlySpan<byte> IFKKLLBODIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E0CEE0", Offset = "0x5E0B6E0", VA = "0x185E0CEE0")]
		private unsafe void GAAGGFFDGKN(void* IDCGNOPGNIG, int OOHKMCMOCLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public struct KOBEHNBMLND : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private OOMGJHEGCMJ KAEOEAACCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private NativeArray<byte> KOIMDAJNDOD;

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E20850", Offset = "0x5E1F050", VA = "0x185E20850")]
		internal KOBEHNBMLND(OOMGJHEGCMJ KAEOEAACCCG, NativeArray<byte> KOIMDAJNDOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E206E0", Offset = "0x5E1EEE0", VA = "0x185E206E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E20790", Offset = "0x5E1EF90", VA = "0x185E20790")]
		public NativeArray<byte> OEKIAHMMOFH(int OOHKMCMOCLB)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E206F0", Offset = "0x5E1EEF0", VA = "0x185E206F0")]
		public void EBBPLHHBGBC(Span<byte> IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public struct NFGLAEIICMN : IEnumerator<GOACCCGGODP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private readonly NativeList<GOACCCGGODP> JMHHCKCLFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private int ADMJKDLHPCI;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public GOACCCGGODP IODFMFKEHHG
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x5E219F0", Offset = "0x5E201F0", VA = "0x185E219F0", Slot = "4")]
			get
			{
				return default(GOACCCGGODP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x5E219A0", Offset = "0x5E201A0", VA = "0x185E219A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E21850", Offset = "0x5E20050", VA = "0x185E21850", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E21950", Offset = "0x5E20150", VA = "0x185E21950", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private struct CFKFIJCIPMO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private NativeArray<int> KOIMDAJNDOD;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public bool GABGEKOCFIO
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x5E0B350", Offset = "0x5E09B50", VA = "0x185E0B350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public int IKMGLCLCBAK
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x5E0B410", Offset = "0x5E09C10", VA = "0x185E0B410")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E0B3E0", Offset = "0x5E09BE0", VA = "0x185E0B3E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public JMHDNBEMGEJ HGCJLKCODBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x5E0B3D0", Offset = "0x5E09BD0", VA = "0x185E0B3D0")]
			get
			{
				return default(JMHDNBEMGEJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x5E0B2E0", Offset = "0x5E09AE0", VA = "0x185E0B2E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool DBFIOPFIKPF
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x5E0B330", Offset = "0x5E09B30", VA = "0x185E0B330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public bool GANDFNBNILD
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x5E0B3F0", Offset = "0x5E09BF0", VA = "0x185E0B3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E0B420", Offset = "0x5E09C20", VA = "0x185E0B420")]
		public CFKFIJCIPMO(JMHDNBEMGEJ HHEHLHLOLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E0B300", Offset = "0x5E09B00", VA = "0x185E0B300")]
		private int BCFBOGKIONB(int INDDJJFOAAH, int HNNAPFLHCME = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E0B290", Offset = "0x5E09A90", VA = "0x185E0B290")]
		private void ABNCEPDOIJI(int INDDJJFOAAH, int IFKKLLBODIE, int HNNAPFLHCME = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E0B390", Offset = "0x5E09B90", VA = "0x185E0B390", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static readonly GOACCCGGODP GKBGLCEFJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private NativeParallelHashMap<GOACCCGGODP, int> PNBBHJGECNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeList<GOACCCGGODP> CDJEKMIHKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeList<int> GMBADEGOHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeList<byte> PCHJBJAEBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeList<byte> KOIMDAJNDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private CFKFIJCIPMO HIKDFDIFDNM;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E221C0", Offset = "0x5E209C0", VA = "0x185E221C0")]
	public static OOMGJHEGCMJ GFPEABNIECK(JMHDNBEMGEJ HHEHLHLOLOC = JMHDNBEMGEJ.Last, int JBHNKJGKDCO = 16, int DKDDBPBBIDN = 256)
	{
		return default(OOMGJHEGCMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E22920", Offset = "0x5E21120", VA = "0x185E22920")]
	private OOMGJHEGCMJ(JMHDNBEMGEJ HHEHLHLOLOC, int JBHNKJGKDCO, int DKDDBPBBIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E21E40", Offset = "0x5E20640", VA = "0x185E21E40", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E22200", Offset = "0x5E20A00", VA = "0x185E22200")]
	public CNDKINBHKIM HDBBDILJHLG(GOACCCGGODP MOHHJLIGFPM)
	{
		return default(CNDKINBHKIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E22020", Offset = "0x5E20820", VA = "0x185E22020")]
	public bool GFJLGLIEIHJ(GOACCCGGODP MOHHJLIGFPM, [Out] KOBEHNBMLND PDEHEGCALFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E21DF0", Offset = "0x5E205F0", VA = "0x185E21DF0")]
	public bool BBPGJMMADDC(GOACCCGGODP MOHHJLIGFPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E222F0", Offset = "0x5E20AF0", VA = "0x185E222F0")]
	public bool JJGPIMICGIP(GOACCCGGODP MOHHJLIGFPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E22740", Offset = "0x5E20F40", VA = "0x185E22740")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E223F0", Offset = "0x5E20BF0", VA = "0x185E223F0")]
	private void KGEBBJIHBIL(GOACCCGGODP MOHHJLIGFPM, int IAIBEBECMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E22660", Offset = "0x5E20E60", VA = "0x185E22660")]
	private void OOMKINNHEKB(int BDHAGEEEGGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E21F40", Offset = "0x5E20740", VA = "0x185E21F40")]
	private void FDHHIMCKBMM(GOACCCGGODP MOHHJLIGFPM, int IAIBEBECMJB, int OOHKMCMOCLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E22870", Offset = "0x5E21070", VA = "0x185E22870", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E22820", Offset = "0x5E21020", VA = "0x185E22820", Slot = "4")]
	private IEnumerator<GOACCCGGODP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DefaultMember("Item")]
public class JOMJCIGLHDM<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class KCCCEDFJNOC
{
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class OLMLIDGEGCC
{
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class PILIHGDICNH
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class MJOLPFFNOMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public FHMIKLMEDIH services;

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public MJOLPFFNOMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x5E210E0", Offset = "0x5E1F8E0", VA = "0x185E210E0")]
		internal void AFLOJHALKDL(OILIFCGGAMK svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x5E21140", Offset = "0x5E1F940", VA = "0x185E21140")]
		internal void CCAAIGGEBFM(OLNFMJBKLAF svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E22C90", Offset = "0x5E21490", VA = "0x185E22C90")]
	public static void LIBBDIPLLNF(this World LPBOBKJPICK, FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x23800C0", Offset = "0x237E8C0", VA = "0x1823800C0")]
	public static void EILGJAJEEJN<T>(this World LPBOBKJPICK, Action<T> PMMMJGPDPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x25032F0", Offset = "0x2501AF0", VA = "0x1825032F0")]
	public static void PLAAFIOMGIP<T>(this World LPBOBKJPICK, Action<T> PMMMJGPDPKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x25034D0", Offset = "0x2501CD0", VA = "0x1825034D0")]
	public static void PLAAFIOMGIP<T>(IEnumerable<ComponentSystemBase> BKIDEJBLOMH, Action<T> PMMMJGPDPKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class JJOJLNCJOAH
{
	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5E19410", Offset = "0x5E17C10", VA = "0x185E19410")]
	public static void JKFAEKBJIPK(ComponentSystemBase HKHKOFLAFNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class GGJAOFGGAOO
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class GNCENGMBIEL
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class GEKAOFNAIJF
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		private sealed class <<CalculateTransformPath>g__getNames|0>d
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GEKAOFNAIJF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class ADBEDBAIFGJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class MKJAPJNKNBP
{
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class OBHGBFEGFDD
{
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class HILLOIJEFAK
{
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal static class IDOCANJNCNN
{
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static readonly ProfilerMarker PEAAOBKDBLD;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static readonly ProfilerMarker FGJHKAGGDFH;

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5E181B0", Offset = "0x5E169B0", VA = "0x185E181B0")]
	public static void ONAHLMMGDBM(this MDHODIMGPDH CNFBLEFPNKP, JEALDGGAOGA PPFELFEMNEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x5E17FD0", Offset = "0x5E167D0", VA = "0x185E17FD0")]
	public static void NGLIFPKPHKG(this MDHODIMGPDH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5E17EC0", Offset = "0x5E166C0", VA = "0x185E17EC0")]
	private static string[] MCOBBGHJHJB(JEALDGGAOGA PPFELFEMNEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5E17D60", Offset = "0x5E16560", VA = "0x185E17D60")]
	private static bool GKAMMPPCFNN(JEALDGGAOGA PPFELFEMNEO, [Out] string[] FKDCCCMCHOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0")]
	private static bool HHGIDOKMBFD()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public abstract class JLOICNANNKH : KCJCNGJIECE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private readonly MethodInfo OJNEFJCKCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly Type[] DDNMEJONMEK;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5E19A40", Offset = "0x5E18240", VA = "0x185E19A40")]
	public JLOICNANNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action FEGJNJOOFFI();

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5E19A00", Offset = "0x5E18200", VA = "0x185E19A00")]
	public MethodInfo LHCOBFNCDCG(Action POMIBLHGGHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5E19870", Offset = "0x5E18070", VA = "0x185E19870", Slot = "4")]
	public void JKCLJMACCFA(Type BJKOKHNAAID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public abstract class EDDPFMCPOFO : JLOICNANNKH
{
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	private enum ACHDDPMMEDL
	{

	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5E11840", Offset = "0x5E10040", VA = "0x185E11840", Slot = "5")]
	public override Action FEGJNJOOFFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void NKCPJHIGKNK<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5E117B0", Offset = "0x5E0FFB0", VA = "0x185E117B0")]
	[UnityEngine.Scripting.Preserve]
	public void BGCMNJFNOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x5E09830", Offset = "0x5E08030", VA = "0x185E09830")]
	protected EDDPFMCPOFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public abstract class HPBNEEOPIPC : JLOICNANNKH
{
	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x5E14E60", Offset = "0x5E13660", VA = "0x185E14E60", Slot = "5")]
	public override Action FEGJNJOOFFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void PDEJMKOIBEA<T>() where T : MPANBJGAAIE;

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x5E14DD0", Offset = "0x5E135D0", VA = "0x185E14DD0")]
	[UnityEngine.Scripting.Preserve]
	public void BGCMNJFNOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x5E09830", Offset = "0x5E08030", VA = "0x185E09830")]
	protected HPBNEEOPIPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class AEHCFBFBPHA : JLOICNANNKH
{
	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5E09790", Offset = "0x5E07F90", VA = "0x185E09790", Slot = "5")]
	public override Action FEGJNJOOFFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void NPAHDAFODKG<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5E09700", Offset = "0x5E07F00", VA = "0x185E09700")]
	[UnityEngine.Scripting.Preserve]
	public void BGCMNJFNOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5E09830", Offset = "0x5E08030", VA = "0x185E09830")]
	protected AEHCFBFBPHA()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000091")]
public struct CAAIEOEKGJL : ISystem
{
	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "4")]
	public void OnCreate(SystemState KAFJGNMGLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
	public void OnDestroy(SystemState KAFJGNMGLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5E0AE20", Offset = "0x5E09620", VA = "0x185E0AE20", Slot = "6")]
	public void OnUpdate(SystemState KAFJGNMGLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void LDEGOKHPEPK(IntPtr CLEGCKJMIEA, IntPtr KAFJGNMGLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5E0AE20", Offset = "0x5E09620", VA = "0x185E0AE20")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void FBHLBHJEHNM(IntPtr CLEGCKJMIEA, IntPtr KAFJGNMGLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void EJEICICBLGH(IntPtr CLEGCKJMIEA, IntPtr KAFJGNMGLLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class PEJDEPBMMLB
{
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public static readonly ComponentType[] BBFMBEOEEHB;

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5E22B10", Offset = "0x5E21310", VA = "0x185E22B10")]
	public static Entity PONJHDDCIMN(this EntityManager DHDOKMIFNAD)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class CLNALCKCJCB
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class FKLLMOHANIM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class CFJANBGHLLK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class OHJLJKBAPAN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5E0BD50", Offset = "0x5E0A550", VA = "0x185E0BD50")]
	public static Entity EFGDKOGLFBM(this EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5E0C680", Offset = "0x5E0AE80", VA = "0x185E0C680")]
	public static DynamicBuffer<ChildrenData> LNBEIJJBBFN(this EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(DynamicBuffer<ChildrenData>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5E0CAD0", Offset = "0x5E0B2D0", VA = "0x185E0CAD0")]
	public static bool OGJGKOBEDLH(this EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, Allocator OPPHPFNHPMG, [Out] NativeArray<Entity> ADGHMHGNAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5E0CBA0", Offset = "0x5E0B3A0", VA = "0x185E0CBA0")]
	public static NativeArray<Entity> PEGPKJEBCHH(this EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x5E0C390", Offset = "0x5E0AB90", VA = "0x185E0C390")]
	public static int FAGDHMFPDCE(this EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x5E0C840", Offset = "0x5E0B040", VA = "0x185E0C840")]
	public static void OFPKDFPPDDA(NativeArray<Entity> LOGFLNHGEOO, NativeArray<Entity> PGJEDFCLFOB, EntityManager DHDOKMIFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5E0BDC0", Offset = "0x5E0A5C0", VA = "0x185E0BDC0")]
	public static bool EHHMCMCJOLD(this EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, Entity INIMKGAHAEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5E0BB50", Offset = "0x5E0A350", VA = "0x185E0BB50")]
	public static bool DGPBLLKPAEP(this EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, Entity HBIJIKOLFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5E0C4C0", Offset = "0x5E0ACC0", VA = "0x185E0C4C0")]
	public static NativeList<Entity> IMAIOIELIAG(this EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, bool HHILKMOKANP = false, Allocator OPPHPFNHPMG = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5E0C710", Offset = "0x5E0AF10", VA = "0x185E0C710")]
	public static Entity OEBJBPNCIBI(this EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5E0C0C0", Offset = "0x5E0A8C0", VA = "0x185E0C0C0")]
	public static bool EPHMNKOPEON(this EntityManager DHDOKMIFNAD, Entity HBMBMELELPF, Entity OPFJANEEJKH, [Out] Entity MGIAOAAKLDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x5E0BA30", Offset = "0x5E0A230", VA = "0x185E0BA30")]
	internal static void CHHMKFFKKJA(EntityManager DHDOKMIFNAD, Entity KLGMOMIJPLM, Entity JDEFHCADEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x5E0BF90", Offset = "0x5E0A790", VA = "0x185E0BF90")]
	private static bool EJHGCKEPAGG(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, Entity INIMKGAHAEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[GJLJLBIABKM(typeof(MBOIFNFCOGB), new string[] { })]
internal sealed class FNLPINHAEND : MBOIFNFCOGB, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	[MCMLPKDBFJE]
	private JDCOPOKIPOM DGNNPKKKLJE;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public JNCNGCABODE.FEFLKMCDLAL.EPCEIPKIDEH GPFBPKGGONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x5E12220", Offset = "0x5E10A20", VA = "0x185E12220", Slot = "4")]
		get
		{
			return default(JNCNGCABODE.FEFLKMCDLAL.EPCEIPKIDEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5E121D0", Offset = "0x5E109D0", VA = "0x185E121D0", Slot = "5")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public FNLPINHAEND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
internal class IAFGNLCLOFA
{
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private static readonly PFECAMNMOCE IMBFNBKHLGB;

	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private static readonly PFECAMNMOCE HKBPABOKHNF;

	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private static readonly ProfilerMarker FBGPJIBOMOH;

	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private static readonly ProfilerMarker LLGKNKFFMGH;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly ProfilerMarker OAPIGIJKJAH;

	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private static readonly ProfilerMarker ALCMPGDJLLA;

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private static readonly ProfilerMarker NODPGPOPPMP;

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly ProfilerMarker IAHJOPENNKC;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly ProfilerMarker GMNEHLMOPMG;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static readonly ProfilerMarker MJCMENBHEBA;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static readonly ProfilerMarker NHDAOIFOBKP;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly ProfilerMarker GJLCDJCGDOD;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static readonly ProfilerMarker HINIHKODPAD;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly ProfilerMarker KOMKFCMJENK;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static readonly ProfilerMarker ILGHHOMIBEM;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly ProfilerMarker NNNMAONIPHP;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly ProfilerMarker ANKKHNLMEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly DLJGPKOGIBM LADDBIDHFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly ByteString BGGDIKOMABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly MDHODIMGPDH CNFBLEFPNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly DIFCPOBJEFP KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly AOLNGGEIGHK EEIGOHKCHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private readonly FLFJGEGKAJH CDJEKMIHKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly HLLHFLMFLOO CGOLOAHFGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly TaskCompletionSource<bool> NAACIMLIADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly ENCCPCLKFPE HIKDFDIFDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly NCBEKHAIOIH.DNOOCHLIDFN BHBKCMNGDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private GABKHNGOBOD JALIBIALMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private PHLKAMANPNI BBCPMDMMDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private JNCNGCABODE MGFHBGDBPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private HLHILOHMCCK AKGMOHLFIAD;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public Action JEJIDCEALNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x816EB0", Offset = "0x8156B0", VA = "0x180816EB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6970", Offset = "0x8B5170", VA = "0x1808B6970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Action GEGHAHCAGFB
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x8B66A0", Offset = "0x8B4EA0", VA = "0x1808B66A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6910", Offset = "0x8B5110", VA = "0x1808B6910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Action HDFMAFGHGBD
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x76EA10", Offset = "0x76D210", VA = "0x18076EA10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x76E990", Offset = "0x76D190", VA = "0x18076E990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public IEnumerable<NDNCPECEFHH> HKEMKPJOFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8B0", Offset = "0x7D90B0", VA = "0x1807DA8B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8C0", Offset = "0x7D90C0", VA = "0x1807DA8C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public EMCHIFDMDCK CHEBIDIFNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x5E16910", Offset = "0x5E15110", VA = "0x185E16910")]
		[CompilerGenerated]
		get
		{
			return default(EMCHIFDMDCK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x5E15C60", Offset = "0x5E14460", VA = "0x185E15C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public HLHILOHMCCK LOPFPNGGAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8B6690", Offset = "0x8B4E90", VA = "0x1808B6690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public FIEDEPEHHFE CIMLGFHINGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E640", Offset = "0x1A0CE40", VA = "0x181A0E640")]
		get
		{
			return default(FIEDEPEHHFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public LocalId BPJPJIKDALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x5E15DC0", Offset = "0x5E145C0", VA = "0x185E15DC0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public Task LJEJHLGKKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x5E174D0", Offset = "0x5E15CD0", VA = "0x185E174D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5E17A90", Offset = "0x5E16290", VA = "0x185E17A90")]
	public IAFGNLCLOFA(ByteString BGGDIKOMABC, FIEDEPEHHFE DJGHBNLCJGN, [In] ENCCPCLKFPE HIKDFDIFDNM, MDHODIMGPDH CNFBLEFPNKP, CGIIEKIPGLL LBDPDIKKCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5E15F00", Offset = "0x5E14700", VA = "0x185E15F00")]
	public void FFAMFELMPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5E16E40", Offset = "0x5E15640", VA = "0x185E16E40")]
	public bool KDJJLACMJLH(FIEDEPEHHFE HBMBMELELPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5E15650", Offset = "0x5E13E50", VA = "0x185E15650")]
	private bool BGCCEIMFICM(FIEDEPEHHFE KCBHFKGPFEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5E170E0", Offset = "0x5E158E0", VA = "0x185E170E0")]
	private void NFANOGPFJEC(FIEDEPEHHFE HLKIGOIJMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5E160F0", Offset = "0x5E148F0", VA = "0x185E160F0")]
	private bool GPLDOOIELBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x5E15B00", Offset = "0x5E14300", VA = "0x185E15B00")]
	public bool CIFMILHAJKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5E16970", Offset = "0x5E15170", VA = "0x185E16970")]
	private bool JFDEAHGELHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x5E15380", Offset = "0x5E13B80", VA = "0x185E15380")]
	private bool BECABJPPNBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x5E15FE0", Offset = "0x5E147E0", VA = "0x185E15FE0")]
	private bool FMBDDKEFEHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x5E16940", Offset = "0x5E15140", VA = "0x185E16940")]
	private bool HLDMHJGJOEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5E17510", Offset = "0x5E15D10", VA = "0x185E17510")]
	private bool PLDIEFLMJBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x5E16310", Offset = "0x5E14B10", VA = "0x185E16310")]
	public void HFPOPCKJKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x5E15D90", Offset = "0x5E14590", VA = "0x185E15D90")]
	[CompilerGenerated]
	private void DMKNBFLFLLP(FIEDEPEHHFE KCBHFKGPFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5E16E60", Offset = "0x5E15660", VA = "0x185E16E60")]
	[CompilerGenerated]
	private bool LHFBNCPBCLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x5E14F20", Offset = "0x5E13720", VA = "0x185E14F20")]
	[CompilerGenerated]
	private void AMBNLLCGLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5E15DD0", Offset = "0x5E145D0", VA = "0x185E15DD0")]
	[CompilerGenerated]
	private World EHAGKBEBKLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5E16FB0", Offset = "0x5E157B0", VA = "0x185E16FB0")]
	[CompilerGenerated]
	private void NAAEGKAFCOJ(World APNHPENNNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5E17370", Offset = "0x5E15B70", VA = "0x185E17370")]
	[CompilerGenerated]
	private int OICOGBJCIOL(World APNHPENNNJP, ByteString BGGDIKOMABC, JNCNGCABODE.FEFLKMCDLAL.EPCEIPKIDEH OJAHFIICKFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x5E17190", Offset = "0x5E15990", VA = "0x185E17190")]
	[CompilerGenerated]
	private void NNCGPKBJACN(World LPBOBKJPICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5E16760", Offset = "0x5E14F60", VA = "0x185E16760")]
	[CompilerGenerated]
	internal static HAIJJGGOANE HGKFKEBGOBC(EntityManager MEBDBDKNPDE, EntityManager PPPCGBILMPI, int CPOINCHGJNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5E16CC0", Offset = "0x5E154C0", VA = "0x185E16CC0")]
	[CompilerGenerated]
	private void JKHBNPBCOIK(HLHILOHMCCK AKGMOHLFIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5E15940", Offset = "0x5E14140", VA = "0x185E15940")]
	[CompilerGenerated]
	private void BLOBNHKGEOH(EntityManager DHDOKMIFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5E15C90", Offset = "0x5E14490", VA = "0x185E15C90")]
	[CompilerGenerated]
	private void DMBKDCKMLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5E15920", Offset = "0x5E14120", VA = "0x185E15920")]
	[CompilerGenerated]
	private void BKOBHBPPCDA(string BOBHOMKFHJB, EntityManager DHDOKMIFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5E16DD0", Offset = "0x5E155D0", VA = "0x185E16DD0")]
	[CompilerGenerated]
	private HMNBGIAKLDO<ENCCPCLKFPE> JNKOPGIIHDA(EntityManager DHDOKMIFNAD)
	{
		return default(HMNBGIAKLDO<ENCCPCLKFPE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal class DLJGPKOGIBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private enum NNLHKIIINNJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		Running,
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		Completed,
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		Disposed
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class LADHOFIBAPL : IEnumerable<FIEDEPEHHFE>, IEnumerable, IEnumerator<FIEDEPEHHFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private FIEDEPEHHFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public DLJGPKOGIBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private FIEDEPEHHFE target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public FIEDEPEHHFE <>3__target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private int <allowedTarget>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private FIEDEPEHHFE System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Serialization.DeserializePhases>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x8C3140", Offset = "0x8C1940", VA = "0x1808C3140", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(FIEDEPEHHFE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x5E20A20", Offset = "0x5E1F220", VA = "0x185E20A20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0xCA8A50", Offset = "0xCA7250", VA = "0x180CA8A50")]
		[DebuggerHidden]
		public LADHOFIBAPL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x5E208A0", Offset = "0x5E1F0A0", VA = "0x185E208A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x5E209D0", Offset = "0x5E1F1D0", VA = "0x185E209D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x5E20920", Offset = "0x5E1F120", VA = "0x185E20920", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FIEDEPEHHFE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Serialization.DeserializePhases>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x5E20920", Offset = "0x5E1F120", VA = "0x185E20920", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class JHFLCAMHGPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public FIEDEPEHHFE phase;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public JHFLCAMHGPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x5E19330", Offset = "0x5E17B30", VA = "0x185E19330")]
		internal object AAIIGEEIDOK(FIEDEPEHHFE a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly PFECAMNMOCE HKBPABOKHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly FIEDEPEHHFE DJGHBNLCJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly Func<FIEDEPEHHFE, bool> DHFIGPMGMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Action<FIEDEPEHHFE> GNPAGMLHCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private int DBBKPINDNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private NNLHKIIINNJ KAFJGNMGLLD;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public FIEDEPEHHFE CIMLGFHINGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x760180", Offset = "0x75E980", VA = "0x180760180")]
		get
		{
			return default(FIEDEPEHHFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool PLFIBBCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x5E11500", Offset = "0x5E0FD00", VA = "0x185E11500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x5E11660", Offset = "0x5E0FE60", VA = "0x185E11660")]
	public DLJGPKOGIBM(FIEDEPEHHFE DJGHBNLCJGN, Func<FIEDEPEHHFE, bool> DHFIGPMGMCE, Action<FIEDEPEHHFE> GNPAGMLHCIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x5E11510", Offset = "0x5E0FD10", VA = "0x185E11510")]
	[IteratorStateMachine(typeof(LADHOFIBAPL))]
	private IEnumerable<FIEDEPEHHFE> PJOODIOEGGF(FIEDEPEHHFE HBMBMELELPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5E11170", Offset = "0x5E0F970", VA = "0x185E11170")]
	public bool KDJJLACMJLH(FIEDEPEHHFE HBMBMELELPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x5E11130", Offset = "0x5E0F930", VA = "0x185E11130")]
	private void FELDDOHAJBK(FIEDEPEHHFE KCBHFKGPFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAA50", Offset = "0x5DE9250", VA = "0x185DEAA50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
internal class HMCENKJEOEN : AKFDJCNPOFK, CGIIEKIPGLL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly IAFGNLCLOFA GOOGNEMPJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private readonly AIDABNJGIKJ IEHPDNNDJHE;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public DKFKBKKOBGP BOPBILOGGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public LocalId DBLKKOICMLC
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x5E14C40", Offset = "0x5E13440", VA = "0x185E14C40", Slot = "9")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public Task LJEJHLGKKMP
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x5E11DC0", Offset = "0x5E105C0", VA = "0x185E11DC0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public IEnumerable<NDNCPECEFHH> HKEMKPJOFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x5E11CD0", Offset = "0x5E104D0", VA = "0x185E11CD0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public EMCHIFDMDCK CHEBIDIFNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x5E11D30", Offset = "0x5E10530", VA = "0x185E11D30", Slot = "8")]
		get
		{
			return default(EMCHIFDMDCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public HLHILOHMCCK JKBKPBPMOKI
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x5E11DA0", Offset = "0x5E105A0", VA = "0x185E11DA0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5E14CC0", Offset = "0x5E134C0", VA = "0x185E14CC0")]
	public HMCENKJEOEN(ByteString BGGDIKOMABC, DKFKBKKOBGP PEAGGPNNNJH, [In] ENCCPCLKFPE HIKDFDIFDNM, MDHODIMGPDH CNFBLEFPNKP, Action PMNGKOBCMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5E14C70", Offset = "0x5E13470", VA = "0x185E14C70", Slot = "5")]
	public void GFKLAMKNNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5E11D70", Offset = "0x5E10570", VA = "0x185E11D70", Slot = "12")]
	public bool KDJJLACMJLH(FIEDEPEHHFE KCBHFKGPFEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5E14CA0", Offset = "0x5E134A0", VA = "0x185E14CA0", Slot = "6")]
	public void HFPOPCKJKOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5E11D00", Offset = "0x5E10500", VA = "0x185E11D00", Slot = "13")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class FHDCEHCHPKL : GCBHCOCLCNM, CGIIEKIPGLL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private readonly IAFGNLCLOFA GOOGNEMPJCK;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public LocalId DBLKKOICMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x5E11D20", Offset = "0x5E10520", VA = "0x185E11D20", Slot = "6")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public IEnumerable<NDNCPECEFHH> HKEMKPJOFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x5E11CD0", Offset = "0x5E104D0", VA = "0x185E11CD0", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public EMCHIFDMDCK CHEBIDIFNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x5E11D30", Offset = "0x5E10530", VA = "0x185E11D30", Slot = "5")]
		get
		{
			return default(EMCHIFDMDCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Task LJEJHLGKKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x5E11DC0", Offset = "0x5E105C0", VA = "0x185E11DC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public HLHILOHMCCK JKBKPBPMOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x5E11DA0", Offset = "0x5E105A0", VA = "0x185E11DA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5E11E10", Offset = "0x5E10610", VA = "0x185E11E10")]
	public FHDCEHCHPKL(ByteString BGGDIKOMABC, MDHODIMGPDH CNFBLEFPNKP, Action JFDNFLMONCD, Action MFABEFIOPLC, Action PMNGKOBCMDF, bool CMBCEPOACOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5E11D70", Offset = "0x5E10570", VA = "0x185E11D70", Slot = "9")]
	public bool KDJJLACMJLH(FIEDEPEHHFE KCBHFKGPFEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5E11D00", Offset = "0x5E10500", VA = "0x185E11D00", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal struct ENCCPCLKFPE : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public PKIFHEFFKDB GGJIEMCKGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public Entity KLGMOMIJPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public JKBEFCOKGIC PHIFKJALFPB;

	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public static readonly NDKLJGAGIKF<ENCCPCLKFPE> LMLHJGLFPJN;
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal class NFOGPPPDHLD : EJKJGDNPOAM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public HLHILOHMCCK LOPFPNGGAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x761FD0", Offset = "0x7607D0", VA = "0x180761FD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5E21A40", Offset = "0x5E20240", VA = "0x185E21A40", Slot = "5")]
	public ByteString CGIMOENKJPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public NFOGPPPDHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[MMAONKDBHAB(EOGANNGNDMH.Application)]
public interface MBOIFNFCOGB
{
	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	JNCNGCABODE.FEFLKMCDLAL.EPCEIPKIDEH GPFBPKGGONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal abstract class BACAFICBOIG : EJKJGDNPOAM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private static readonly ProfilerMarker OAPIGIJKJAH;

	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private static readonly ProfilerMarker OHLIBBLLOIA;

	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly ProfilerMarker ALCMPGDJLLA;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly ProfilerMarker KGJLHAHPMHO;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly ProfilerMarker IAHJOPENNKC;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly ProfilerMarker AMDKJFIOLFE;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ProfilerMarker DGMKCPAAJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly MDHODIMGPDH CNFBLEFPNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private readonly HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly GABKHNGOBOD JALIBIALMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly HLLHFLMFLOO CGOLOAHFGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly FLFJGEGKAJH CDJEKMIHKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly PFECAMNMOCE HKBPABOKHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly NCBEKHAIOIH.DNOOCHLIDFN BHBKCMNGDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private World JGFLBOGBMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private HLHILOHMCCK AKGMOHLFIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private IDisposable IDEAOFBEEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private ByteString BKNCNJJIKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private JNCNGCABODE.FEFLKMCDLAL.EPCEIPKIDEH LOBHDFHAPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private bool DIGLNKFFLBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private DKDHCMJLDBA JHIGIODAGKG;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	protected World JCBDKCAAOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x763DB0", Offset = "0x7625B0", VA = "0x180763DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	protected World CPJGAENFGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A410", Offset = "0x5E08C10", VA = "0x185E0A410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public HLHILOHMCCK LOPFPNGGAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x762B30", Offset = "0x761330", VA = "0x180762B30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A6E0", Offset = "0x5E08EE0", VA = "0x185E0A6E0")]
	public BACAFICBOIG(MDHODIMGPDH CNFBLEFPNKP, PFECAMNMOCE ANEILBIOBIP, PFECAMNMOCE HKBPABOKHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x5E09840", Offset = "0x5E08040", VA = "0x185E09840", Slot = "5")]
	public ByteString CGIMOENKJPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x5E09920", Offset = "0x5E08120", VA = "0x185E09920", Slot = "7")]
	public void GFKLAMKNNLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x5E098C0", Offset = "0x5E080C0", VA = "0x185E098C0", Slot = "8")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A460", Offset = "0x5E08C60", VA = "0x185E0A460", Slot = "9")]
	protected virtual FBOOIBLOHEP PKICGDOOCHG()
	{
		return default(FBOOIBLOHEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void LGKIDJGGGCG();

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract NativeArray<EntityRemapUtility.EntityRemapInfo> BPLNIDJIMDK(NativeArray<EntityRemapUtility.EntityRemapInfo> KIDEIPCIOGI);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[GHHCNNKBLLC]
internal struct FBOOIBLOHEP : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public PKIFHEFFKDB OBKIDCLEHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public PGFGMDLLDHI PHIFKJALFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public JNCNGCABODE.FEFLKMCDLAL.EPCEIPKIDEH OJAHFIICKFC;

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public static readonly NDKLJGAGIKF<FBOOIBLOHEP> LMLHJGLFPJN;

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x5E11C00", Offset = "0x5E10400", VA = "0x185E11C00")]
	public static FBOOIBLOHEP FBGIECNMNKI([In] PKIFHEFFKDB OBKIDCLEHOP)
	{
		return default(FBOOIBLOHEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class AEANIPLGOFI : BACAFICBOIG
{
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private static readonly PFECAMNMOCE HKBPABOKHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly FBOOIBLOHEP HIKDFDIFDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private NativeList<Entity> OCDNLIKFEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private NativeArray<Entity> LDBPEJLDCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> AKDMEFJPJAN;

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E09540", Offset = "0x5E07D40", VA = "0x185E09540")]
	public AEANIPLGOFI(IEnumerable<JEDJBKOCEME> MGOMOGOCFIB, [In] FBOOIBLOHEP HIKDFDIFDNM, MDHODIMGPDH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E09450", Offset = "0x5E07C50", VA = "0x185E09450", Slot = "9")]
	protected override FBOOIBLOHEP PKICGDOOCHG()
	{
		return default(FBOOIBLOHEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E092C0", Offset = "0x5E07AC0", VA = "0x185E092C0", Slot = "10")]
	protected override void LGKIDJGGGCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E090C0", Offset = "0x5E078C0", VA = "0x185E090C0", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> BPLNIDJIMDK(NativeArray<EntityRemapUtility.EntityRemapInfo> KIDEIPCIOGI)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E09210", Offset = "0x5E07A10", VA = "0x185E09210", Slot = "8")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
internal class HBPJACFPOPK : BACAFICBOIG
{
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private static readonly PFECAMNMOCE HKBPABOKHNF;

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E148F0", Offset = "0x5E130F0", VA = "0x185E148F0")]
	public HBPJACFPOPK(MDHODIMGPDH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E14780", Offset = "0x5E12F80", VA = "0x185E14780", Slot = "10")]
	protected override void LGKIDJGGGCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0xD47F00", Offset = "0xD46700", VA = "0x180D47F00", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> BPLNIDJIMDK(NativeArray<EntityRemapUtility.EntityRemapInfo> KIDEIPCIOGI)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal static class KAELHLPEBLI
{
	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E130", Offset = "0x5E1C930", VA = "0x185E1E130")]
	public static NCBEKHAIOIH.DNOOCHLIDFN MKPJOOFDNEM(MDHODIMGPDH CNFBLEFPNKP)
	{
		return default(NCBEKHAIOIH.DNOOCHLIDFN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DE30", Offset = "0x5E1C630", VA = "0x185E1DE30")]
	public static NativeList<Entity> FMPGNGEJHNK(EntityManager DHDOKMIFNAD, IEnumerable<JEDJBKOCEME> MGOMOGOCFIB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DD80", Offset = "0x5E1C580", VA = "0x185E1DD80")]
	public static void BPLNIDJIMDK(NativeArray<Entity> LDBPEJLDCIM, NativeList<Entity> OCDNLIKFEJL, NativeArray<EntityRemapUtility.EntityRemapInfo> KIDEIPCIOGI, NativeArray<EntityRemapUtility.EntityRemapInfo> AKDMEFJPJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x243ED60", Offset = "0x243D560", VA = "0x18243ED60")]
	public static Entity EDIHCLHPEOP<T>(EntityManager DHDOKMIFNAD, [In] T IFKKLLBODIE) where T : struct, IComponentData
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class ENKBKAKGOBN
{
	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E11B50", Offset = "0x5E10350", VA = "0x185E11B50")]
	public static PKIFHEFFKDB EAMDBOCBJEH(EEKEIMNDBGI KLGMOMIJPLM)
	{
		return default(PKIFHEFFKDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public struct HMNBGIAKLDO<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private EntityManager DHDOKMIFNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly Entity JAGECNMFPEI;

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x353F940", Offset = "0x353E140", VA = "0x18353F940")]
	public HMNBGIAKLDO(EntityManager DHDOKMIFNAD, [In] T HIKDFDIFDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x353F8E0", Offset = "0x353E0E0", VA = "0x18353F8E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[GJLJLBIABKM(typeof(KOALBKCLEGM), new string[] { })]
public class IEDMGDKEIFM : KOALBKCLEGM, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public GPHJLMFLCDC ECHANCJFMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x762B90", Offset = "0x761390", VA = "0x180762B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private BODCEDFCLFN NKHLEOEHKNM
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x762B00", Offset = "0x761300", VA = "0x180762B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private LBNHEJPIPLE PKEGEDLOFPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x764CB0", Offset = "0x7634B0", VA = "0x180764CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private JCIAOBDAFHE NDCFHPNEJBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7640E0", VA = "0x1807658E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public GIBCPELIMEL IJJFGODKJIN
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x76B2A0", Offset = "0x769AA0", VA = "0x18076B2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public BKAHPKLHPCE LKNJHBFLKOA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x762D40", Offset = "0x761540", VA = "0x180762D40", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x762AF0", Offset = "0x7612F0", VA = "0x180762AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public FECOAHBOMEJ PEMJIEHFMGI
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761340", VA = "0x180762B40", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x762B70", Offset = "0x761370", VA = "0x180762B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public GANMDIKNMFL MMNIHLBJIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x762B10", Offset = "0x761310", VA = "0x180762B10", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x762D80", Offset = "0x761580", VA = "0x180762D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private DIFCPOBJEFP BGIOAICKFDA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x762A30", Offset = "0x761230", VA = "0x180762A30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public FGIBAMAPNKP IJFOHPLHFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x762BA0", Offset = "0x7613A0", VA = "0x180762BA0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x762AA0", Offset = "0x7612A0", VA = "0x180762AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public JGCGHOOJAFE NIGJOADKDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x763DB0", Offset = "0x7625B0", VA = "0x180763DB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x763DC0", Offset = "0x7625C0", VA = "0x180763DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private DELEEKPOPNO ANDNBDDJCPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x762B80", Offset = "0x761380", VA = "0x180762B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public CLKHJAFEIDJ CKCNJFHNAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x762AB0", Offset = "0x7612B0", VA = "0x180762AB0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x762A70", Offset = "0x761270", VA = "0x180762A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private NMGHNJPMHGE EMECCKDFMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x76F2B0", Offset = "0x76DAB0", VA = "0x18076F2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private KAPOAGACOPL NIDCMOCCGHG
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x76F3D0", Offset = "0x76DBD0", VA = "0x18076F3D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E186F0", Offset = "0x5E16EF0", VA = "0x185E186F0", Slot = "12")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public IEDMGDKEIFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[GJLJLBIABKM(typeof(GIMAKLLKNAL), new string[] { })]
public class BGKKLAJAIIN : GIMAKLLKNAL, GIFDCKIGEDL, HLEOPNBKPID, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private FHMIKLMEDIH CNFBLEFPNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private KOALBKCLEGM KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private PHLKAMANPNI BBCPMDMMDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private EMFAHBILPMG IBCFJAAICJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private GKGBAHAPFBD IGBOANLHLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private CECLHBPNMGM NBODHKFBPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private FBKLHLEKBGM DCDGDLJLGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private ANGAFLNDJOG PBFNCDEJLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private PMIAAANLCEE AKDDGLPGIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private FICELHLOKNG EAABDMCBPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private AAKMNAOGINP JDGIIKACPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private ALHOKAPBJCK PDEHEGCALFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private GCMHDFHOGLD GNOLOOOHCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private OELIOIGNFBB GKOOPAFPFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private DIIBKKJDGKE IPGHEOGMPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private ALLPNMMCFOG FFDDAINFBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private FLFBKAFPGOO MLGNGIFDKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private ENDHILGPLNG DGNIOJIBKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private JDCOPOKIPOM FNKPGAPKDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private EIGPEOIKDPK HOKINAOAABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public FHMIKLMEDIH EFBOCBBNCAC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public KOALBKCLEGM AAHFJAMBBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public HLLCKCNCCJD HIGJMHAGADA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public EMFAHBILPMG PGDDJJAGELC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public HOKKMAFBPHI HMDFIBLPPLC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x762D40", Offset = "0x761540", VA = "0x180762D40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public GKGBAHAPFBD IABBJBIJJPH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761340", VA = "0x180762B40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public CECLHBPNMGM MCMPNLKGJLG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x762B10", Offset = "0x761310", VA = "0x180762B10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public FBKLHLEKBGM ALADFHAJFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x762B50", Offset = "0x761350", VA = "0x180762B50", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public PMIAAANLCEE PBKEOGNNMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x763DB0", Offset = "0x7625B0", VA = "0x180763DB0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public FICELHLOKNG HLIFDNJKFDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x762B30", Offset = "0x761330", VA = "0x180762B30", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public AAKMNAOGINP EPHCILPJDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x762AB0", Offset = "0x7612B0", VA = "0x180762AB0", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public ALHOKAPBJCK EMECCKDFMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x76F3A0", Offset = "0x76DBA0", VA = "0x18076F3A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public GCMHDFHOGLD DMOAKNOPDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x76F3E0", Offset = "0x76DBE0", VA = "0x18076F3E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public OELIOIGNFBB GPKLFGNLOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x76F310", Offset = "0x76DB10", VA = "0x18076F310", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public DIIBKKJDGKE CCNBEKFDMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x810850", Offset = "0x80F050", VA = "0x180810850", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public ALLPNMMCFOG BPKFHANFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x76F350", Offset = "0x76DB50", VA = "0x18076F350", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public FLFBKAFPGOO PLBMDFFGFFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x89E0A0", Offset = "0x89C8A0", VA = "0x18089E0A0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public ENDHILGPLNG EMABDOFCGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x76EA20", Offset = "0x76D220", VA = "0x18076EA20", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public JDCOPOKIPOM IDKAMGHJFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B6640", Offset = "0x8B4E40", VA = "0x1808B6640", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public EIGPEOIKDPK CDPDDDCBCIF
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x83D750", Offset = "0x83BF50", VA = "0x18083D750", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public DMCLIOLBKII LMEMNHLLCGK
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB70", Offset = "0x7DC370", VA = "0x1807DDB70", Slot = "24")]
		get
		{
			return default(DMCLIOLBKII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E0AB00", Offset = "0x5E09300", VA = "0x185E0AB00", Slot = "25")]
	public void EAPAJNCJCIO(FHMIKLMEDIH CJDFCLLNGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E0AAF0", Offset = "0x5E092F0", VA = "0x185E0AAF0", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E0AE00", Offset = "0x5E09600", VA = "0x185E0AE00", Slot = "26")]
	public void MKOHONAJGCK(FHMIKLMEDIH CJDFCLLNGNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public BGKKLAJAIIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[DefaultMember("Item")]
public class CKNHGJNGPFA : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class KEONEENILIN : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		public CKNHGJNGPFA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0x8C3140", Offset = "0x8C1940", VA = "0x1808C3140", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004ED")]
			[Cpp2IlInjected.Address(RVA = "0x5E1E3B0", Offset = "0x5E1CBB0", VA = "0x185E1E3B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
		[DebuggerHidden]
		public KEONEENILIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E1F0", Offset = "0x5E1C9F0", VA = "0x185E1E1F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E360", Offset = "0x5E1CB60", VA = "0x185E1E360", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private readonly List<ulong> HAKKCNPCLFI;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x76CBA0", Offset = "0x76B3A0", VA = "0x18076CBA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B9A0", Offset = "0x5E0A1A0", VA = "0x185E0B9A0")]
	public CKNHGJNGPFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B920", Offset = "0x5E0A120", VA = "0x185E0B920", Slot = "4")]
	[IteratorStateMachine(typeof(KEONEENILIN))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B920", Offset = "0x5E0A120", VA = "0x185E0B920", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[DDDINGLCBBH(typeof(OBKNLCGGCNM))]
[GJLJLBIABKM(typeof(ECJAJDGHKCC), new string[] { })]
public class NBHNNDHAOMN : ECJAJDGHKCC, GAJGABMNKBI, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private readonly Dictionary<int, KIBODBGDLMG> PAPPPIMBBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private readonly Dictionary<KIBODBGDLMG, int> LCKDPNDOKNF;

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E21670", Offset = "0x5E1FE70", VA = "0x185E21670", Slot = "6")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E21570", Offset = "0x5E1FD70", VA = "0x185E21570", Slot = "7")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E211A0", Offset = "0x5E1F9A0", VA = "0x185E211A0")]
	private void CEELIMENJDJ(List<(KIBODBGDLMG nameHash, BKGNILJGMHF stableTypeHash, Type type)> KAEOEAACCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E21420", Offset = "0x5E1FC20", VA = "0x185E21420", Slot = "4")]
	public KIBODBGDLMG IBFOAOJHAJB(int GIBOEKFJFBH)
	{
		return default(KIBODBGDLMG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E213B0", Offset = "0x5E1FBB0", VA = "0x185E213B0", Slot = "5")]
	public int FEEGMBIGLHB(KIBODBGDLMG CACPLMILIMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E21730", Offset = "0x5E1FF30", VA = "0x185E21730")]
	public NBHNNDHAOMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[GJLJLBIABKM(typeof(KKDHBJBFPOF), new string[] { })]
public class HFHKLFEAMMC : KKDHBJBFPOF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	[MCMLPKDBFJE]
	private FGIBAMAPNKP KBCHPJJCKNB;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private uint PCBDFBADBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E149B0", Offset = "0x5E131B0", VA = "0x185E149B0", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E14A00", Offset = "0x5E13200", VA = "0x185E14A00", Slot = "5")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public HFHKLFEAMMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[GJLJLBIABKM(typeof(ADNGMPCLMLO), new string[] { })]
public class GJFPHLOJCDP : ADNGMPCLMLO, GAJGABMNKBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private OOMGJHEGCMJ FBOLEEKODOO;

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E13A70", Offset = "0x5E12270", VA = "0x185E13A70", Slot = "8")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E13380", Offset = "0x5E11B80", VA = "0x185E13380", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E133D0", Offset = "0x5E11BD0", VA = "0x185E133D0", Slot = "4")]
	public void EPNMOIJNKPL(KLEIPEFFJCP ADMPFLAIEKN, BCJCKPDGHHM BFLLNKNNDBB, ReadOnlySpan<byte> CKEMPKBOFPJ, ReadOnlySpan<byte> IMFCBNHMGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E136C0", Offset = "0x5E11EC0", VA = "0x185E136C0", Slot = "7")]
	public bool IAGAGAIFGOK(KLEIPEFFJCP ADMPFLAIEKN, BCJCKPDGHHM BFLLNKNNDBB, Span<byte> CKEMPKBOFPJ, Span<byte> IMFCBNHMGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E13630", Offset = "0x5E11E30", VA = "0x185E13630", Slot = "5")]
	public bool HEPDOENIAOL(KLEIPEFFJCP ADMPFLAIEKN, BCJCKPDGHHM BFLLNKNNDBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E13EE0", Offset = "0x5E126E0", VA = "0x185E13EE0", Slot = "6")]
	public bool PHFEJGBGEEF(KLEIPEFFJCP ADMPFLAIEKN, BCJCKPDGHHM BFLLNKNNDBB, ReadOnlySpan<byte> IMFCBNHMGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E13B40", Offset = "0x5E12340", VA = "0x185E13B40")]
	private bool OMEBNCKDPEO(KLEIPEFFJCP ADMPFLAIEKN, BCJCKPDGHHM BFLLNKNNDBB, ReadOnlySpan<byte> IMFCBNHMGHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public GJFPHLOJCDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class FLGMFBDNCPI<T> : JIECKBLJKIH<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	protected NPGGOFKDJJF<T> BOJBDFKLPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	protected AKBCJFFLPMA<T> GKFKMELBAAA;

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x30121B0", Offset = "0x30109B0", VA = "0x1830121B0")]
	public FLGMFBDNCPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x33B1240", Offset = "0x33AFA40", VA = "0x1833B1240")]
	public FLGMFBDNCPI(NPGGOFKDJJF<T> BOJBDFKLPGD, AKBCJFFLPMA<T> GKFKMELBAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x33B0AD0", Offset = "0x33AF2D0", VA = "0x1833B0AD0", Slot = "10")]
	protected override T GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x33B0F50", Offset = "0x33AF750", VA = "0x1833B0F50", Slot = "11")]
	protected override void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA, T IFKKLLBODIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public static class FMPFJKJNKPE
{
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class IDEFCCNEOBH<T> : FLGMFBDNCPI<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x3658B90", Offset = "0x3657390", VA = "0x183658B90")]
	public IDEFCCNEOBH(T OIBFHHMDNOK, T PFCKGDLJEGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public sealed class EKKNIDKIFCB<T> : JIECKBLJKIH<T> where T : struct, MPANBJGAAIE
{
	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x3015CE0", Offset = "0x30144E0", VA = "0x183015CE0", Slot = "10")]
	protected override T GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x3015EB0", Offset = "0x30146B0", VA = "0x183015EB0", Slot = "11")]
	protected override void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA, T IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2FD5D40", Offset = "0x2FD4540", VA = "0x182FD5D40")]
	public EKKNIDKIFCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
internal static class JPBPOGEIIOI
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private class BFAOEGGDPDA
	{
		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[CompilerGenerated]
		private sealed class OMKAEPIAIMH<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public OMKAEPIAIMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x3DCF340", Offset = "0x3DCDB40", VA = "0x183DCF340")]
			internal void MPEIJHPJKKE(KMMIKOANJPK writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0x3DCF0C0", Offset = "0x3DCD8C0", VA = "0x183DCF0C0")]
			internal T FDIHLFODEPG(BJGJBDHKABD reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A880", Offset = "0x5E09080", VA = "0x185E0A880")]
		public static void FCIDDCJKGEI(CNKBLHGAOGE BPAFLNLLCML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x2962C20", Offset = "0x2961420", VA = "0x182962C20")]
		private static void POHMMMNLPCG<T>(CNKBLHGAOGE BPAFLNLLCML, int PFCKGDLJEGO) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x2962B90", Offset = "0x2961390", VA = "0x182962B90")]
		private static void GMNCHFNAOJH<T>(KMMIKOANJPK OPKLFJAIALA, T LONCAANPFDA, int PFCKGDLJEGO) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x29625D0", Offset = "0x2960DD0", VA = "0x1829625D0")]
		private static T FMLCEFFFDMC<T>(BJGJBDHKABD PBFIJMOIIIO, int PFCKGDLJEGO) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public BFAOEGGDPDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private class CPFCIGCGPPL : EDDPFMCPOFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private CNKBLHGAOGE BPAFLNLLCML;

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x2962D50", Offset = "0x2961550", VA = "0x182962D50", Slot = "6")]
		public override void NKCPJHIGKNK<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x5E0E110", Offset = "0x5E0C910", VA = "0x185E0E110")]
		public static void IHONIGIMFJC(CNKBLHGAOGE BPAFLNLLCML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x5E09830", Offset = "0x5E08030", VA = "0x185E09830")]
		public CPFCIGCGPPL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C1F0", Offset = "0x5E1A9F0", VA = "0x185E1C1F0")]
	public static void GKGDJJGGIPA(CNKBLHGAOGE BPAFLNLLCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DC80", Offset = "0x5E1C480", VA = "0x185E1DC80")]
	private static void PIMCHHLMICH(KMMIKOANJPK ELBAMOGBINL, quaternion LONCAANPFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C110", Offset = "0x5E1A910", VA = "0x185E1C110")]
	private static quaternion FHLFBDKIOAG(BJGJBDHKABD LLIOFJLHJFC)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x242D070", Offset = "0x242B870", VA = "0x18242D070")]
	public static void EHLBCKGMJHD<T>(CNKBLHGAOGE BPAFLNLLCML, NPGGOFKDJJF<T> BOJBDFKLPGD, AKBCJFFLPMA<T> GKFKMELBAAA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x242CFF0", Offset = "0x242B7F0", VA = "0x18242CFF0")]
	public static void ECGPPGJIIJG<T>(CNKBLHGAOGE DKBOLDMDFGM) where T : struct, MPANBJGAAIE
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public abstract class LADEBHJLGNC : FDINMBBOPJN
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public abstract Type HAJHMPBBGDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO, Span<byte> IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA, ReadOnlySpan<byte> IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected LADEBHJLGNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public abstract class JIECKBLJKIH<T> : LADEBHJLGNC where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public override Type HAJHMPBBGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x3854E00", Offset = "0x3853600", VA = "0x183854E00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract T GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO);

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA, T IFKKLLBODIE);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x3855340", Offset = "0x3853B40", VA = "0x183855340", Slot = "8")]
	public override void GHFHHMFPNJI(BJGJBDHKABD PBFIJMOIIIO, Span<byte> HBMBMELELPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x3855670", Offset = "0x3853E70", VA = "0x183855670", Slot = "9")]
	public override void NDMEHJLGNHG(KMMIKOANJPK OPKLFJAIALA, ReadOnlySpan<byte> MOHHJLIGFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
	protected JIECKBLJKIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
internal static class KGGAOLKFGIL
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public struct PMNJKKKOJBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public HOKKMAFBPHI BAKIPPCJAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public HCANMCICAMH OIDNJHENKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public AACGNIFANPK OMGNBKKNENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public MOJADNJPIHP PCANEKAMGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public ADNGMPCLMLO HPNONEELFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public OPHKKINCMBH BPAFLNLLCML;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x5E22F30", Offset = "0x5E21730", VA = "0x185E22F30")]
		public void LIDOAMKDODG(FHMIKLMEDIH CNFBLEFPNKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public struct IHDILCBFKKN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public NativeList<KLEIPEFFJCP> BCJPFHDLPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public NativeList<ALDBGJKBJJO> PJDHECENIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public NativeList<KLEIPEFFJCP> FKAANOOIPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public NativeParallelMultiHashMap<KLEIPEFFJCP, HLANCHOOJIM> PBFNCDEJLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public NativeList<byte> COEAOGHPKPH;

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public bool OKPJJAKBJNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x5E18A90", Offset = "0x5E17290", VA = "0x185E18A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x5E189F0", Offset = "0x5E171F0", VA = "0x185E189F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	private struct NOBBGACOOPJ : IComparer<HLANCHOOJIM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x5E21B10", Offset = "0x5E20310", VA = "0x185E21B10", Slot = "4")]
		public int Compare(HLANCHOOJIM GEKAGOANEHP, HLANCHOOJIM KFCLHHAJEPI)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private static readonly PFECAMNMOCE PJFHDFHOCHN;

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FAE0", Offset = "0x5E1E2E0", VA = "0x185E1FAE0")]
	public static void KGDHNNBFPCL(KMMIKOANJPK OPKLFJAIALA, IHDILCBFKKN KOIMDAJNDOD, PMNJKKKOJBE CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x5E20010", Offset = "0x5E1E810", VA = "0x185E20010")]
	public static IHDILCBFKKN OMMEGGCJANH(BJGJBDHKABD PBFIJMOIIIO, Allocator OPPHPFNHPMG, PMNJKKKOJBE CNFBLEFPNKP)
	{
		return default(IHDILCBFKKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F5D0", Offset = "0x5E1DDD0", VA = "0x185E1F5D0")]
	public static void EPNMOIJNKPL(IHDILCBFKKN KOIMDAJNDOD, PMNJKKKOJBE CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x5E20320", Offset = "0x5E1EB20", VA = "0x185E20320")]
	public static void PHFEJGBGEEF(IHDILCBFKKN KOIMDAJNDOD, PMNJKKKOJBE CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EDA0", Offset = "0x5E1D5A0", VA = "0x185E1EDA0")]
	public static int CDCHPAEEJJP(IHDILCBFKKN KOIMDAJNDOD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F9D0", Offset = "0x5E1E1D0", VA = "0x185E1F9D0")]
	private static void HAEKNPGPEGK(KMMIKOANJPK OPKLFJAIALA, NativeArray<KLEIPEFFJCP> BCJPFHDLPBM, NativeArray<ALDBGJKBJJO> PJDHECENIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FE80", Offset = "0x5E1E680", VA = "0x185E1FE80")]
	private static void OIIBOHECODD(BJGJBDHKABD PBFIJMOIIIO, Allocator OPPHPFNHPMG, [Out] NativeList<KLEIPEFFJCP> BCJPFHDLPBM, [Out] NativeList<ALDBGJKBJJO> DCAJMDINBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F540", Offset = "0x5E1DD40", VA = "0x185E1F540")]
	private static void EHCGFCJNAGC(KMMIKOANJPK OPKLFJAIALA, NativeArray<KLEIPEFFJCP> FKAANOOIPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FD80", Offset = "0x5E1E580", VA = "0x185E1FD80")]
	private static void OBCNJDLBLLF(BJGJBDHKABD PBFIJMOIIIO, Allocator OPPHPFNHPMG, [Out] NativeList<KLEIPEFFJCP> FKAANOOIPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E400", Offset = "0x5E1CC00", VA = "0x185E1E400")]
	private static void BGGAFANLCIO(KMMIKOANJPK OPKLFJAIALA, NativeParallelMultiHashMap<KLEIPEFFJCP, HLANCHOOJIM> PBFNCDEJLIJ, NativeList<byte> COEAOGHPKPH, PMNJKKKOJBE CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EEF0", Offset = "0x5E1D6F0", VA = "0x185E1EEF0")]
	private static void CPFFFIJOJPL(BJGJBDHKABD PBFIJMOIIIO, Allocator OPPHPFNHPMG, [Out] NativeParallelMultiHashMap<KLEIPEFFJCP, HLANCHOOJIM> PBFNCDEJLIJ, [Out] NativeList<byte> COEAOGHPKPH, PMNJKKKOJBE CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FAC0", Offset = "0x5E1E2C0", VA = "0x185E1FAC0")]
	private static void JHCFGIPELIN(int BDDMEFAEDON, int DENPDIDGDEF, KMMIKOANJPK OPKLFJAIALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FAA0", Offset = "0x5E1E2A0", VA = "0x185E1FAA0")]
	private static int HNPPPINJNHF(int DENPDIDGDEF, BJGJBDHKABD PBFIJMOIIIO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
[GJLJLBIABKM(typeof(FKPECEFBIMH), new string[] { })]
internal sealed class FMKHMPANGHM : FKPECEFBIMH, GAJGABMNKBI, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private readonly Dictionary<BCJCKPDGHHM, KHEJHCOLHBJ> JGDGGOIFHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private HCANMCICAMH PBFNCDEJLIJ;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5E120F0", Offset = "0x5E108F0", VA = "0x185E120F0", Slot = "6")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5E12020", Offset = "0x5E10820", VA = "0x185E12020", Slot = "7")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5E12080", Offset = "0x5E10880", VA = "0x185E12080", Slot = "4")]
	public void JKCLJMACCFA(BCJCKPDGHHM BFLLNKNNDBB, Type JGBDEOEIAJA, KHEJHCOLHBJ IFGLBNBGECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x5E11FB0", Offset = "0x5E107B0", VA = "0x185E11FB0", Slot = "5")]
	public bool HIEENLAACHG(BCJCKPDGHHM BFLLNKNNDBB, [Out] KHEJHCOLHBJ IFGLBNBGECN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5E12140", Offset = "0x5E10940", VA = "0x185E12140")]
	public FMKHMPANGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[GJLJLBIABKM(typeof(HOAMBCOIHOO), new string[] { })]
internal class BGCFGOOMHIJ : OILIFCGGAMK, HOAMBCOIHOO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	[MCMLPKDBFJE]
	private KKDHBJBFPOF GKDFLIHPFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private MEABKCDHNCD ALOEAOEDOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private int HILENGHIPHK;

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A950", Offset = "0x5E09150", VA = "0x185E0A950", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A9C0", Offset = "0x5E091C0", VA = "0x185E0A9C0", Slot = "5")]
	public MMNLNLKKOGE PDAJPLMOMFK(ReadOnlySpan<byte> AJPCNFDACDH)
	{
		return default(MMNLNLKKOGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A940", Offset = "0x5E09140", VA = "0x185E0A940", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public BGCFGOOMHIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[GJLJLBIABKM(typeof(MOJADNJPIHP), new string[] { })]
internal sealed class JOIHMLEHNJH : MOJADNJPIHP, OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	[MCMLPKDBFJE]
	private HCANMCICAMH PBFNCDEJLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private NativeBitArray FDKJHGILMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private NativeParallelHashMap<KLEIPEFFJCP, int> GAMLEOPMCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private NativeList<int> ENAMAEMJPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private int IEJCLOPKBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private int ECKHMGKBPEM;

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool HAOKFJJANAB
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C0F0", Offset = "0x5E1A8F0", VA = "0x185E1C0F0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public JNDAOLABELB NGBGNFOOION
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1BC40", Offset = "0x5E1A440", VA = "0x185E1BC40", Slot = "7")]
		get
		{
			return default(JNDAOLABELB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C070", Offset = "0x5E1A870", VA = "0x185E1C070", Slot = "4")]
	public bool KGFOKHJBJIO(KLEIPEFFJCP LFHNIGHPLBN, BCJCKPDGHHM OLJMCOBAMDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BC90", Offset = "0x5E1A490", VA = "0x185E1BC90", Slot = "8")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BA20", Offset = "0x5E1A220", VA = "0x185E1BA20", Slot = "6")]
	public void ABMJGICBDEI(NativeArray<KLEIPEFFJCP> BMJMOJMCGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BDF0", Offset = "0x5E1A5F0", VA = "0x185E1BDF0", Slot = "5")]
	public void JKFJKJELKDO(KLEIPEFFJCP LFHNIGHPLBN, Span<BCJCKPDGHHM> PBFNCDEJLIJ, bool HHNLEOOPNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BBB0", Offset = "0x5E1A3B0", VA = "0x185E1BBB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public JOIHMLEHNJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[GJLJLBIABKM(typeof(OPHKKINCMBH), new string[] { })]
public sealed class CAKPBNJFIPN : OPHKKINCMBH, KPJBNKFBBOP<OPHKKINCMBH>, GAJGABMNKBI, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private readonly Dictionary<BCJCKPDGHHM, FDINMBBOPJN> BPAFLNLLCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private CNKBLHGAOGE BGIMHHOEBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private HCANMCICAMH PBFNCDEJLIJ;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool OBLNNOGOAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7FD4F0", Offset = "0x7FBCF0", VA = "0x1807FD4F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B200", Offset = "0x5E09A00", VA = "0x185E0B200")]
	public CAKPBNJFIPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B110", Offset = "0x5E09910", VA = "0x185E0B110", Slot = "5")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B090", Offset = "0x5E09890", VA = "0x185E0B090", Slot = "6")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x5E0AE70", Offset = "0x5E09670", VA = "0x185E0AE70", Slot = "4")]
	public bool GBJDFDNKBJP(BCJCKPDGHHM LJHGKCLAIHG, [Out] FDINMBBOPJN DKBOLDMDFGM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(CNKBLHGAOGE), new string[] { })]
internal sealed class CNKBLHGAOGE : GAJGABMNKBI
{
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private readonly Dictionary<Type, FDINMBBOPJN> BPAFLNLLCML;

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D280", Offset = "0x5E0BA80", VA = "0x185E0D280", Slot = "4")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D160", Offset = "0x5E0B960", VA = "0x185E0D160")]
	public void JKCLJMACCFA(Type BJKOKHNAAID, FDINMBBOPJN DKBOLDMDFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D090", Offset = "0x5E0B890", VA = "0x185E0D090")]
	public bool GBJDFDNKBJP(Type BJKOKHNAAID, [Out] FDINMBBOPJN DKBOLDMDFGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D360", Offset = "0x5E0BB60", VA = "0x185E0D360")]
	public CNKBLHGAOGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
internal static class GIPEIMGILNG
{
	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x5E13220", Offset = "0x5E11A20", VA = "0x185E13220")]
	public static void JKCLJMACCFA(this CNKBLHGAOGE CMJAHIOHOCL, FDINMBBOPJN DKBOLDMDFGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[AlwaysUpdateSystem]
internal class BDGPOJCMEPD : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public BDGPOJCMEPD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public class UpdateAuthoredChildrenFromParent : ParentSystemBase<AuthoredParentData, AuthoredPreviousParentData, AuthoredChildrenData>
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x5E23CB0", Offset = "0x5E224B0", VA = "0x185E23CB0", Slot = "14")]
		protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x8989C0", Offset = "0x8971C0", VA = "0x1808989C0", Slot = "15")]
		protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x5E23C70", Offset = "0x5E22470", VA = "0x185E23C70", Slot = "16")]
		protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x5E23C30", Offset = "0x5E22430", VA = "0x185E23C30", Slot = "17")]
		protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x5E23CF0", Offset = "0x5E224F0", VA = "0x185E23CF0")]
		public UpdateAuthoredChildrenFromParent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
internal class JBAIEGGLJPA : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private object JGIEELBOOFO;

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x5E18B20", Offset = "0x5E17320", VA = "0x185E18B20", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x5E18BA0", Offset = "0x5E173A0", VA = "0x185E18BA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5E18C50", Offset = "0x5E17450", VA = "0x185E18C50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public JBAIEGGLJPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
internal class CIHLLIOMFOK : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private object JGIEELBOOFO;

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B550", Offset = "0x5E09D50", VA = "0x185E0B550", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B5D0", Offset = "0x5E09DD0", VA = "0x185E0B5D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B680", Offset = "0x5E09E80", VA = "0x185E0B680", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public CIHLLIOMFOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[InternalBufferCapacity(1)]
internal struct OLDIICBHGKB : ISystemStateBufferElementData, IBufferElementData, IEquatable<OLDIICBHGKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public CGOBFEENIAL FJFHMLGEMLM;

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B4B0", Offset = "0x5E09CB0", VA = "0x185E0B4B0", Slot = "4")]
	public bool Equals(OLDIICBHGKB GHNNCJBDHKF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0xA207E0", Offset = "0xA1EFE0", VA = "0x180A207E0")]
	public static OLDIICBHGKB DAOGIJOJDNF(CGOBFEENIAL FJFHMLGEMLM)
	{
		return default(OLDIICBHGKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[InternalBufferCapacity(4)]
internal struct DKJJILFAGAA : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public CGOBFEENIAL FJFHMLGEMLM;
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal abstract class JFICNLOBPCG : LNICJKHNPEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5E18EF0", Offset = "0x5E176F0", VA = "0x185E18EF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5E191D0", Offset = "0x5E179D0", VA = "0x185E191D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5E11950", Offset = "0x5E10150", VA = "0x185E11950")]
	protected JFICNLOBPCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[CPEPPNMEKPA]
internal abstract class LNICJKHNPEF : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	protected HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	protected ENDHILGPLNG DGNIOJIBKPJ;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	protected abstract IEGPFJKPLOA MEHKFOPKLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x5E20F70", Offset = "0x5E1F770", VA = "0x185E20F70", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5E20A70", Offset = "0x5E1F270", VA = "0x185E20A70")]
	protected void FLOJMOCDFNN(EntityQuery PMIADPKJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5E20CF0", Offset = "0x5E1F4F0", VA = "0x185E20CF0")]
	protected void HHHAFIJJPDD(EntityQuery PMIADPKJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5E20FE0", Offset = "0x5E1F7E0", VA = "0x185E20FE0")]
	protected LKEHPHAMPJC MBPLDLCCEGA(EntityQuery PMIADPKJDNK)
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	protected LNICJKHNPEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal abstract class GOKJOLAFLNI : LNICJKHNPEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private EntityQuery COOINHFOOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private EntityQuery JGHGHGENDHE;

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5E14370", Offset = "0x5E12B70", VA = "0x185E14370", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5E146D0", Offset = "0x5E12ED0", VA = "0x185E146D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5E14280", Offset = "0x5E12A80", VA = "0x185E14280")]
	private void FGDPJDKCAPH(EntityQuery PMIADPKJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x5E11A10", Offset = "0x5E10210", VA = "0x185E11A10")]
	protected GOKJOLAFLNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal class JJOAGBJEJIP : JFICNLOBPCG
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	protected override IEGPFJKPLOA MEHKFOPKLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x5E193A0", Offset = "0x5E17BA0", VA = "0x185E193A0", Slot = "15")]
		get
		{
			return default(IEGPFJKPLOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x5E11950", Offset = "0x5E10150", VA = "0x185E11950")]
	public JJOAGBJEJIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal class JFKGLLJCFDP : GOKJOLAFLNI
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	protected override IEGPFJKPLOA MEHKFOPKLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x5E192C0", Offset = "0x5E17AC0", VA = "0x185E192C0", Slot = "15")]
		get
		{
			return default(IEGPFJKPLOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x5E11A10", Offset = "0x5E10210", VA = "0x185E11A10")]
	public JFKGLLJCFDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class HIOFKAFKGCF : JFICNLOBPCG
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	protected override IEGPFJKPLOA MEHKFOPKLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x5E14A50", Offset = "0x5E13250", VA = "0x185E14A50", Slot = "15")]
		get
		{
			return default(IEGPFJKPLOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x5E11950", Offset = "0x5E10150", VA = "0x185E11950")]
	public HIOFKAFKGCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class EIPHKNBAKIE : GOKJOLAFLNI
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	protected override IEGPFJKPLOA MEHKFOPKLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x5E119A0", Offset = "0x5E101A0", VA = "0x185E119A0", Slot = "15")]
		get
		{
			return default(IEGPFJKPLOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x5E11A10", Offset = "0x5E10210", VA = "0x185E11A10")]
	public EIPHKNBAKIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class EGCLFGKANLE : JFICNLOBPCG
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	protected override IEGPFJKPLOA MEHKFOPKLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x5E118E0", Offset = "0x5E100E0", VA = "0x185E118E0", Slot = "15")]
		get
		{
			return default(IEGPFJKPLOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x5E11950", Offset = "0x5E10150", VA = "0x185E11950")]
	public EGCLFGKANLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class PLEIHLBBIOK : GOKJOLAFLNI
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	protected override IEGPFJKPLOA MEHKFOPKLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x5E22EC0", Offset = "0x5E216C0", VA = "0x185E22EC0", Slot = "15")]
		get
		{
			return default(IEGPFJKPLOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x5E11A10", Offset = "0x5E10210", VA = "0x185E11A10")]
	public PLEIHLBBIOK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal struct MHKBBLLCAGN : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal struct ALEIGHDAHCP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct PBMKPPOMJLA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public readonly struct IEGPFJKPLOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly ComponentType? IENHMPFBAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly ComponentType? AOJODBBAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly ComponentType FIIHJAHELBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly object PIPCHJCEPPJ;

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x5E189B0", Offset = "0x5E171B0", VA = "0x185E189B0")]
	public IEGPFJKPLOA(ComponentType? IENHMPFBAFD, ComponentType? AOJODBBAKIB, ComponentType FIIHJAHELBB, object PIPCHJCEPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x23FA980", Offset = "0x23F9180", VA = "0x1823FA980")]
	public static IEGPFJKPLOA PMNBIHHLOAP<TReq, TTag>(object PIPCHJCEPPJ)
	{
		return default(IEGPFJKPLOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x23FA760", Offset = "0x23F8F60", VA = "0x1823FA760")]
	public static IEGPFJKPLOA GJHCKPELDPO<TReq, TMissing, TTag>(object PIPCHJCEPPJ)
	{
		return default(IEGPFJKPLOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public static class HJMEPGLENOG
{
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public static readonly IEGPFJKPLOA CCNBEKFDMFO;

	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public static readonly IEGPFJKPLOA FHHCCHOEIFM;

	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly IEGPFJKPLOA BAILDPAAIDD;
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal struct CGOBFEENIAL : GDENHPGEPFJ, IEquatable<CGOBFEENIAL>
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public int DIEGBKIOLGK
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x7ECFB0", Offset = "0x7EB7B0", VA = "0x1807ECFB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public int PEONAEBENMC
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDFF0", Offset = "0x1FBC7F0", VA = "0x181FBDFF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x51E9800", Offset = "0x51E8000", VA = "0x1851E9800", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B4B0", Offset = "0x5E09CB0", VA = "0x185E0B4B0", Slot = "8")]
	public bool Equals(CGOBFEENIAL GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B500", Offset = "0x5E09D00", VA = "0x185E0B500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CPEPPNMEKPA]
	[CompilerGenerated]
	[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
	public class UpdateConnectableVisualsSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x20000DE")]
		private struct HandlePosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			public CGOBFEENIAL handle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			public float3 position;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x42A3850", Offset = "0x42A2050", VA = "0x1842A3850")]
			public HandlePosition(CGOBFEENIAL handle, float3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x5E14F00", Offset = "0x5E13700", VA = "0x185E14F00")]
			public void IDOGKACACAK([Out] CGOBFEENIAL handle, [Out] float3 position)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DF")]
		private struct UpdateVisualPositions_ParentWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public UpdateConnectableVisualsSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B1")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40002B2")]
			[ReadOnly]
			public ComponentTypeHandle<HDHEDGENDAL> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			public BufferTypeHandle<DKJJILFAGAA> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x5E28C20", Offset = "0x5E27420", VA = "0x185E28C20")]
			private void LNNGHEHIOHC(Entity entity, [In] HDHEDGENDAL pose, DynamicBuffer<DKJJILFAGAA> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x5E28A60", Offset = "0x5E27260", VA = "0x185E28A60", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct UpdateVisualPositions_ChildWoutCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			[ReadOnly]
			public ComponentTypeHandle<HDHEDGENDAL> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public BufferTypeHandle<OLDIICBHGKB> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x5E28970", Offset = "0x5E27170", VA = "0x185E28970")]
			private void LNNGHEHIOHC([In][NoAlias] HDHEDGENDAL pose, DynamicBuffer<OLDIICBHGKB> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x5E28800", Offset = "0x5E27000", VA = "0x185E28800", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct UpdateVisualPositions_ChildWithCoM_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public NativeList<HandlePosition> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			[ReadOnly]
			public ComponentTypeHandle<HDHEDGENDAL> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[ReadOnly]
			public ComponentTypeHandle<PIAMOIBOFOK> __comTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			public BufferTypeHandle<OLDIICBHGKB> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x5E28690", Offset = "0x5E26E90", VA = "0x185E28690")]
			private void LNNGHEHIOHC([In][NoAlias] HDHEDGENDAL pose, [In][NoAlias] PIAMOIBOFOK com, DynamicBuffer<OLDIICBHGKB> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x5E284B0", Offset = "0x5E26CB0", VA = "0x185E284B0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private EntityQuery addGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private EntityQuery addGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery updateGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery updateGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery removeExpiredGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private EntityQuery removeExpiredGizmosInScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private EntityQuery removeAllGizmos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private EntityQuery queryLegacyGizmoParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private EntityQuery queryChildrenWoutCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private EntityQuery queryChildrenWithCom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private DNHFEFFOCGA<CGOBFEENIAL, FAFPMDAFMJH> linkVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private FLFBKAFPGOO connectables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private HOKKMAFBPHI objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private ALHOKAPBJCK scope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private HDJPIOFEPJJ makerPen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private EntityQuery UpdateVisualPositions_ParentWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private EntityQuery UpdateVisualPositions_ChildWoutCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private EntityQuery UpdateVisualPositions_ChildWithCoM_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private ComponentTypeHandle<HDHEDGENDAL> __RecRoom_Components_WorldPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private ComponentTypeHandle<PIAMOIBOFOK> __RecRoom_Rbex_RbexLocalCenterOfMassOfSelfData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x5E248E0", Offset = "0x5E230E0", VA = "0x185E248E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E243B0", Offset = "0x5E22BB0", VA = "0x185E243B0")]
		internal FAFPMDAFMJH CACBBCBEDCO(CGOBFEENIAL handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E25AE0", Offset = "0x5E242E0", VA = "0x185E25AE0", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E27C10", Offset = "0x5E26410", VA = "0x185E27C10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E27EA0", Offset = "0x5E266A0", VA = "0x185E27EA0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E28030", Offset = "0x5E26830", VA = "0x185E28030", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E27E60", Offset = "0x5E26660", VA = "0x185E27E60", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E281A0", Offset = "0x5E269A0", VA = "0x185E281A0")]
		private void PALHJNDJPHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E23D30", Offset = "0x5E22530", VA = "0x185E23D30")]
		private void AHLHFHMJMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E25690", Offset = "0x5E23E90", VA = "0x185E25690")]
		private void IFHGINPHCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E28070", Offset = "0x5E26870", VA = "0x185E28070", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E25040", Offset = "0x5E23840", VA = "0x185E25040")]
		private void HFBGFFHILGI(EntityQuery add, EntityQuery update, EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E27140", Offset = "0x5E25940", VA = "0x185E27140")]
		private void OICBJJIPNIH(EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x5E24140", Offset = "0x5E22940", VA = "0x185E24140")]
		private void BPGOGLCOONB(NativeArrayAsync<Entity> oldEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E26150", Offset = "0x5E24950", VA = "0x185E26150")]
		private void JLFBOMFACAH(NativeArrayAsync<Entity> newEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E23E80", Offset = "0x5E22680", VA = "0x185E23E80")]
		private void AIHJJDHOBFM(NativeArrayAsync<Entity> updateEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E26280", Offset = "0x5E24A80", VA = "0x185E26280")]
		private void MLMMHOECLJG(NativeList<CGOBFEENIAL> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E25BA0", Offset = "0x5E243A0", VA = "0x185E25BA0")]
		private NativeList<CGOBFEENIAL> JFBNANEHCAM(NativeArray<Entity> entities)
		{
			return default(NativeList<CGOBFEENIAL>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E26400", Offset = "0x5E24C00", VA = "0x185E26400")]
		private void NIFOJOANBNN(NativeArray<Entity> entities, NativeList<CGOBFEENIAL> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E26BB0", Offset = "0x5E253B0", VA = "0x185E26BB0")]
		private void OAAEMEIDHMF(NativeArray<Entity> addParents, NativeArray<Entity> addChildren, NativeList<CGOBFEENIAL> freeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E24400", Offset = "0x5E22C00", VA = "0x185E24400")]
		private void CFOGPGJCFEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E24E70", Offset = "0x5E23670", VA = "0x185E24E70")]
		private NativeListAsync<HandlePosition> FPKJJJBMHPA(EntityQuery query, Func<NativeList<HandlePosition>, JobHandle> populateHandles)
		{
			return default(NativeListAsync<HandlePosition>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E282C0", Offset = "0x5E26AC0", VA = "0x185E282C0")]
		private JobHandle PGAJNDICNME(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E23FD0", Offset = "0x5E227D0", VA = "0x185E23FD0")]
		private JobHandle BJHKOGPPHLC(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E25500", Offset = "0x5E23D00", VA = "0x185E25500")]
		private JobHandle IFCFCNNAEKE(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x5E27230", Offset = "0x5E25A30", VA = "0x185E27230")]
		private void ONKLFIBDKBJ(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x5E24AB0", Offset = "0x5E232B0", VA = "0x185E24AB0")]
		private void EGJKGCKHOOL(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E26200", Offset = "0x5E24A00", VA = "0x185E26200")]
		private bool MIBHGBGHFFG(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E25A10", Offset = "0x5E24210", VA = "0x185E25A10")]
		private NativeArray<Entity> IGCHJHABKHP(Entity entity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E269F0", Offset = "0x5E251F0", VA = "0x185E269F0")]
		private CGOBFEENIAL NLAFEJACFBC(NativeList<CGOBFEENIAL> freeList)
		{
			return default(CGOBFEENIAL);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E24FB0", Offset = "0x5E237B0", VA = "0x185E24FB0")]
		private void HEMAFILBLGB(CGOBFEENIAL handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E27490", Offset = "0x5E25C90", VA = "0x185E27490")]
		private void OOCODAGEMNJ(NativeList<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E24D10", Offset = "0x5E23510", VA = "0x185E24D10")]
		private JobHandle FDBPCGNAPED(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E24920", Offset = "0x5E23120", VA = "0x185E24920")]
		private JobHandle EFHKIIOPDEB(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x5E275D0", Offset = "0x5E25DD0", VA = "0x185E275D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public UpdateConnectableVisualsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	public class CalculateCollisionIslandUpdatesSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct CalculateCollisionIslandUpdatesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			public NativeList<Entity> rootsWithForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002C4")]
			public NativeList<Entity> rootsWithoutForcedCollisionUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			[ReadOnly]
			public ComponentTypeHandle<BDPMFBNFKFL> collisionIslandRootDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			[ReadOnly]
			public ComponentDataFromEntity<BDPMFBNFKFL> collisionIslandRootDataFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002C7")]
			[ReadOnly]
			public ComponentTypeHandle<KFEMMDMNKPE> splineParentHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			public EntityQueryInJob changedLocalPoseQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			public EntityQueryInJob changedSplinePointsQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40002CA")]
			public EntityQueryInJob splinesWithChangedChildrenQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40002CB")]
			public EntityQueryInJob changedCollisionModeQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40002CC")]
			public EntityQueryInJob changedScopeRootQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40002CD")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0x5E0E3C0", Offset = "0x5E0CBC0", VA = "0x185E0E3C0")]
			private void LNNGHEHIOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005DF")]
			[Cpp2IlInjected.Address(RVA = "0x5E0E3B0", Offset = "0x5E0CBB0", VA = "0x185E0E3B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private EntityQuery changedLocalPoseQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private EntityQuery changedSplinePointsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private EntityQuery splinesWithChangedChildrenQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private EntityQuery changedCollisionModeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private EntityQuery scopeRootChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private ECPCCCMKFNI collisionIslandService;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E0E360", Offset = "0x5E0CB60", VA = "0x185E0E360", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E0EBC0", Offset = "0x5E0D3C0", VA = "0x185E0EBC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E0EF50", Offset = "0x5E0D750", VA = "0x185E0EF50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E0E1C0", Offset = "0x5E0C9C0", VA = "0x185E0E1C0")]
		private JobHandle DPAKEJLMBJI(NativeList<Entity> rootsWithForcedCollisionUpdate, NativeList<Entity> rootsWithoutForcedCollisionUpdate, ComponentTypeHandle<BDPMFBNFKFL> collisionIslandRootDataHandleRO, ComponentDataFromEntity<BDPMFBNFKFL> collisionIslandRootDataFromEntityRO, ComponentTypeHandle<KFEMMDMNKPE> splineParentHandleRO, EntityQueryInJob changedLocalPoseQueryInJob, EntityQueryInJob changedSplinePointsQueryInJob, EntityQueryInJob splinesWithChangedChildrenQueryInJob, EntityQueryInJob changedCollisionModeQueryInJob, EntityQueryInJob changedScopeRootQueryInJob, Allocator allocator, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public CalculateCollisionIslandUpdatesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
[BurstCompatible]
internal readonly struct CDIKCLNBENB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private readonly KALGBBEFMCC ICDEBAKBONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private readonly LACAENCLGLJ NDPFDICGPIF;

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x978550", Offset = "0x976D50", VA = "0x180978550")]
	public CDIKCLNBENB(KALGBBEFMCC ICDEBAKBONF, LACAENCLGLJ NDPFDICGPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x1B5D1B0", Offset = "0x1B5B9B0", VA = "0x181B5D1B0")]
	public bool PGNCGINAGCF(CDIKCLNBENB KLGMOMIJPLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x1B5D1B0", Offset = "0x1B5B9B0", VA = "0x181B5D1B0")]
	public bool HDABOJHMOHH(CDIKCLNBENB JDEFHCADEPK)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
	[CompilerGenerated]
	public class CalculateContainerCollisionIslandGraphChangesSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[BurstCompile]
		private struct FindChangedIslandsJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			[ReadOnly]
			public EntityQueryInJob deletedConnectablesQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			[ReadOnly]
			public EntityQueryInJob changedIslandQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			[ReadOnly]
			public EntityQueryInJob hierarchyChangeQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			[ReadOnly]
			public EntityQueryInJob newRootsQueryRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			[ReadOnly]
			public ChunkFilterAnyOf2ComponentsChanged islandSplitChangeFilterRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			[ReadOnly]
			public ComponentTypeHandle<ACIMGEPDKEI> islandRootSystemDataTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			[ReadOnly]
			public ComponentDataFromEntity<INIKAIBJCLM> dontPropagatePhysicsPropertiesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002E1")]
			[ReadOnly]
			public ComponentDataFromEntity<KALGBBEFMCC> containerCollisionModeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			[ReadOnly]
			public ComponentDataFromEntity<LACAENCLGLJ> containerCollisionLayerRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			[ReadOnly]
			public ComponentDataFromEntity<GHOJGMELLCB> containerCollisionIslandRootTagRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			[ReadOnly]
			public ComponentDataFromEntity<ParentData> parentRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> childrenRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			[WriteOnly]
			public NativeList<Entity> changedIslandComponentsBufferWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			[WriteOnly]
			public NativeList<DJFIOIPLCGP> changedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			[WriteOnly]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			[WriteOnly]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			public ComponentDataFromEntity<BDPMFBNFKFL> collisionIslandRootDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			public NativeParallelHashSet<Entity> visitedRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			private int bufferHead;

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x5E33790", Offset = "0x5E31F90", VA = "0x185E33790", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0x5E33540", Offset = "0x5E31D40", VA = "0x185E33540")]
			private void AJFCLJODHDK(Entity startEntity, bool checkForUnchanged)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x5E33E40", Offset = "0x5E32640", VA = "0x185E33E40")]
			private Entity FCPDKGJLAON(Entity curEntity, CDIKCLNBENB classifier)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x5E34060", Offset = "0x5E32860", VA = "0x185E34060")]
			private bool JIKBGCBJJGC(Entity curEntity, CDIKCLNBENB classifier, [Out] Entity parentEntity, [Out] CDIKCLNBENB parentClassifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x5E33F50", Offset = "0x5E32750", VA = "0x185E33F50")]
			private void JGNJJBBAPIH(Entity islandRoot, CDIKCLNBENB classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x5E34120", Offset = "0x5E32920", VA = "0x185E34120")]
			private void NEDMKGNCHGH(Entity islandRoot, Entity entity, CDIKCLNBENB classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x5E33430", Offset = "0x5E31C30", VA = "0x185E33430")]
			private void AFNPKIJPGIE(Entity islandRoot, Entity component)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x5E33EC0", Offset = "0x5E326C0", VA = "0x185E33EC0")]
			private bool GGJJMNPGGKB(Entity entity, [Out] CDIKCLNBENB classifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x5E336F0", Offset = "0x5E31EF0", VA = "0x185E336F0")]
			private CDIKCLNBENB DPELKDGOEGF(Entity entity)
			{
				return default(CDIKCLNBENB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E8")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct CalculateContainerCollisionIslandGraphChangesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public NativeList<Entity> removedIslandRootsWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			[ReadOnly]
			public EntityTypeHandle entityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			public EntityQueryInJob queryInJob;

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x5E2EDF0", Offset = "0x5E2D5F0", VA = "0x185E2EDF0")]
			private void LNNGHEHIOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E2EDE0", Offset = "0x5E2D5E0", VA = "0x185E2EDE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[MCMLPKDBFJE]
		private ECPCCCMKFNI collisionIslandService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private EntityQuery changedIslandStructureQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EntityQuery hierarchyChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private EntityQuery newRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private EntityQuery deletedConnectablesQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private EntityQuery deletedRootsQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private EntityQuery islandRootDataQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private EntityQuery islandRootTagQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private HBMKPOBNCFN ecbs;

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E10090", Offset = "0x5E0E890", VA = "0x185E10090", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E100E0", Offset = "0x5E0E8E0", VA = "0x185E100E0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E10530", Offset = "0x5E0ED30", VA = "0x185E10530", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E0F930", Offset = "0x5E0E130", VA = "0x185E0F930")]
		private JobHandle GJOPOLJHBON(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E0F570", Offset = "0x5E0DD70", VA = "0x185E0F570")]
		private JobHandle ABCPNOJIANE(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E0F830", Offset = "0x5E0E030", VA = "0x185E0F830")]
		private JobHandle DNJLCMGHHGO(EntityCommandBuffer ecb, NativeList<Entity> removedIslandRootsWO, EntityTypeHandle entityType, EntityQueryInJob queryInJob, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public CalculateContainerCollisionIslandGraphChangesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
[AlwaysUpdateSystem]
public class KIGNHIMPBNL : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	[MCMLPKDBFJE]
	private ECPCCCMKFNI CFMOGPPMCLI;

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E39A40", Offset = "0x5E38240", VA = "0x185E39A40", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E39A90", Offset = "0x5E38290", VA = "0x185E39A90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public KIGNHIMPBNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
public sealed class FFOOFKCPOHJ : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private GKGBAHAPFBD IGBOANLHLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private GGDHIKOIDJD HNPBCBINIHB;

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E31910", Offset = "0x5E30110", VA = "0x185E31910", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E31880", Offset = "0x5E30080", VA = "0x185E31880", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E31A20", Offset = "0x5E30220", VA = "0x185E31A20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public FFOOFKCPOHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class JMDAIJBHIFE : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	public HFBIDPNKJHF IBCBDBLGJKJ;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public JMDAIJBHIFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x76DD40", Offset = "0x76C540", VA = "0x18076DD40")]
	public JMDAIJBHIFE(HFBIDPNKJHF IBCBDBLGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x5E38BD0", Offset = "0x5E373D0", VA = "0x185E38BD0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public abstract class FEJEMDFCMPH : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private PGHBFFANNIO JPACBGFEFHP;

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x5E317D0", Offset = "0x5E2FFD0", VA = "0x185E317D0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x5E31830", Offset = "0x5E30030", VA = "0x185E31830", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x5E31860", Offset = "0x5E30060", VA = "0x185E31860", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	protected FEJEMDFCMPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class PELMMDDIDAJ : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private EntityQuery OEDFGKIHDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery PHPKCGKGAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private EntityQuery EALEDJDGDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery LLLMDNPJBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private PGHBFFANNIO PAABNHOJFGO;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public int MEKFBLBDBEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x5E40C90", Offset = "0x5E3F490", VA = "0x185E40C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x5E40A60", Offset = "0x5E3F260", VA = "0x185E40A60", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x5E40CA0", Offset = "0x5E3F4A0", VA = "0x185E40CA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x5E40ED0", Offset = "0x5E3F6D0", VA = "0x185E40ED0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x5E409C0", Offset = "0x5E3F1C0", VA = "0x185E409C0")]
	public int DDNEMJOBBMI(SceneTag NJBFIEAFGFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x5E40730", Offset = "0x5E3EF30", VA = "0x185E40730")]
	protected void DAPOGPNGKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x5E40EF0", Offset = "0x5E3F6F0", VA = "0x185E40EF0")]
	protected void PLHAFJPOAGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x5E40AC0", Offset = "0x5E3F2C0", VA = "0x185E40AC0")]
	public NativeArrayAsync<Entity> KGDMPPDHDKJ(SceneTag NJBFIEAFGFF, Allocator OPPHPFNHPMG = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x5E40970", Offset = "0x5E3F170", VA = "0x185E40970")]
	public NativeArrayAsync<Entity> DBNHMHPJHAB(SceneTag NJBFIEAFGFF, Allocator OPPHPFNHPMG = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x5E40C00", Offset = "0x5E3F400", VA = "0x185E40C00")]
	public bool MCFNNJLFPEG(SceneTag NJBFIEAFGFF, [Out] NativeArrayAsync<Entity> IBCBDBLGJKJ, Allocator OPPHPFNHPMG = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x5E40B80", Offset = "0x5E3F380", VA = "0x185E40B80")]
	public bool LNCBCICGOEB(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x5E40B10", Offset = "0x5E3F310", VA = "0x185E40B10")]
	public bool LGFAPDODONP(Entity MFFDEAINOPL, [Out] JMDAIJBHIFE IBCBDBLGJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x5E409E0", Offset = "0x5E3F1E0", VA = "0x185E409E0")]
	public void FBIMNALHEAL(Entity MFFDEAINOPL, JMDAIJBHIFE IBCBDBLGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x5E408F0", Offset = "0x5E3F0F0", VA = "0x185E408F0")]
	public bool DBAMLDCKHIG(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public PELMMDDIDAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
internal class DAOJBCOGIOG : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private EntityQuery NOFNCCIIJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private KAPOAGACOPL KBCHPJJCKNB;

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x5E30730", Offset = "0x5E2EF30", VA = "0x185E30730", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x5E30780", Offset = "0x5E2EF80", VA = "0x185E30780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x5E30840", Offset = "0x5E2F040", VA = "0x185E30840", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x2228680", Offset = "0x2226E80", VA = "0x182228680")]
	private bool CMCLGIBFDPG<TComponentData>(EntityQuery PMIADPKJDNK, [Out] NativeArray<Entity> EFLDIIILPLM, [Out] NativeArray<TComponentData> DGNAIPANHEG) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x5E306A0", Offset = "0x5E2EEA0", VA = "0x185E306A0")]
	public HFBIDPNKJHF IKLPJMMNPGI(Entity MFFDEAINOPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public DAOJBCOGIOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class OPGJFMGHPCL : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private EntityQuery MKEJEHKDDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private EntityQuery HDKBPEOLFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private EntityQuery HJGEIBAPNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private EntityQuery KDIDAHNJFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private GIBCPELIMEL KBCHPJJCKNB;

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x5E401A0", Offset = "0x5E3E9A0", VA = "0x185E401A0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x5E40280", Offset = "0x5E3EA80", VA = "0x185E40280", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x5E40500", Offset = "0x5E3ED00", VA = "0x185E40500", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FD90", Offset = "0x5E3E590", VA = "0x185E3FD90")]
	private void EIGFNHEIDIC(EntityQuery PMIADPKJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x5E401F0", Offset = "0x5E3E9F0", VA = "0x185E401F0")]
	private void OICBJJIPNIH(EntityQuery PMIADPKJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x5E40470", Offset = "0x5E3EC70", VA = "0x185E40470", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FE20", Offset = "0x5E3E620", VA = "0x185E3FE20")]
	private void EJDKNJPJIMN(EntityQuery PMIADPKJDNK, bool MGALCAEGIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public OPGJFMGHPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public sealed class GEOCJNMPMIF : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private BJLOGACOAIO IIEAMEFDFMA;

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x5E34360", Offset = "0x5E32B60", VA = "0x185E34360", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x5E343C0", Offset = "0x5E32BC0", VA = "0x185E343C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public GEOCJNMPMIF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	public class GatherModifiedParentsSystem : JMMMDIBDAGF, OLNFMJBKLAF
	{
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherModifiedParents_AddNewParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public NativeList<KPDILCFCHEL> newParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __currentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x5E35850", Offset = "0x5E34050", VA = "0x185E35850")]
			private void LNNGHEHIOHC(Entity entity, [In][NoAlias] ParentData current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0x5E35730", Offset = "0x5E33F30", VA = "0x185E35730", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherModifiedParents_AddChangedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			public NativeList<MACOEFMOGFA> changedParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __currentTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			[ReadOnly]
			public ComponentTypeHandle<PreviousParentData> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0x5E35670", Offset = "0x5E33E70", VA = "0x185E35670")]
			private void LNNGHEHIOHC(Entity entity, [In][NoAlias] ParentData current, [In][NoAlias] PreviousParentData previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x5E354D0", Offset = "0x5E33CD0", VA = "0x185E354D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherModifiedParents_AddRemovedParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public NativeList<KPDILCFCHEL> oldParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000316")]
			[ReadOnly]
			public ComponentTypeHandle<PreviousParentData> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000631")]
			[Cpp2IlInjected.Address(RVA = "0x5E359F0", Offset = "0x5E341F0", VA = "0x185E359F0")]
			private void LNNGHEHIOHC(Entity entity, [In][NoAlias] PreviousParentData previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x5E358D0", Offset = "0x5E340D0", VA = "0x185E358D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private LIEABLACGCP parentEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private EntityQuery GatherModifiedParents_AddNewParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private EntityQuery GatherModifiedParents_AddChangedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private EntityQuery GatherModifiedParents_AddRemovedParents_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private ComponentTypeHandle<PreviousParentData> __RecRoom_Components_PreviousParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x5E34AB0", Offset = "0x5E332B0", VA = "0x185E34AB0", Slot = "14")]
		public void OEMGKMCKIOP(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x5E35160", Offset = "0x5E33960", VA = "0x185E35160", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x5E34830", Offset = "0x5E33030", VA = "0x185E34830")]
		private JobHandle HFPFEFFKPHL(NativeList<KPDILCFCHEL> newParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x5E34950", Offset = "0x5E33150", VA = "0x185E34950")]
		private JobHandle MNCBALNGDOB(NativeList<MACOEFMOGFA> changedParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x5E34710", Offset = "0x5E32F10", VA = "0x185E34710")]
		private JobHandle AIOEDNNMANF(NativeList<KPDILCFCHEL> oldParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x5E34B90", Offset = "0x5E33390", VA = "0x185E34B90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public GatherModifiedParentsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public class KIOBAMLAFEP : ParentSystemBase<ParentData, PreviousParentData, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x5E39B60", Offset = "0x5E38360", VA = "0x185E39B60", Slot = "14")]
	protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc PMIADPKJDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x8989C0", Offset = "0x8971C0", VA = "0x1808989C0", Slot = "15")]
	protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc PMIADPKJDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x5E39B20", Offset = "0x5E38320", VA = "0x185E39B20", Slot = "16")]
	protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc PMIADPKJDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0x5E39AE0", Offset = "0x5E382E0", VA = "0x185E39AE0", Slot = "17")]
	protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc PMIADPKJDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0x5E39BA0", Offset = "0x5E383A0", VA = "0x185E39BA0")]
	public KIOBAMLAFEP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public abstract class ParentSystemBase<TParentData, TPreviousParentData, TChildrenData> : JMMMDIBDAGF where TParentData : struct, IComponentData, AIOGGNIJOCI where TPreviousParentData : struct, IComponentData, AIOGGNIJOCI where TChildrenData : struct, ISystemStateBufferElementData, IEquatable<TChildrenData>, AIOGGNIJOCI
	{
		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		[BurstCompile]
		internal struct GatherChangedParents : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter ParentChildrenToAdd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public NativeParallelMultiHashMap<Entity, Entity>.ParallelWriter ParentChildrenToRemove;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public NativeParallelHashMap<Entity, int>.ParallelWriter UniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			public ComponentTypeHandle<TPreviousParentData> PreviousParentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			[ReadOnly]
			public ComponentTypeHandle<TParentData> ParentType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			[ReadOnly]
			public EntityTypeHandle EntityType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public uint LastSystemVersion;

			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x34E2650", Offset = "0x34E0E50", VA = "0x1834E2650", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		[BurstCompile]
		internal struct FindMissingChild : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> UniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> ChildFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000328")]
			public NativeList<Entity> ParentsMissingChild;

			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0x33E1A70", Offset = "0x33E0270", VA = "0x1833E1A70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		[BurstCompile]
		internal struct FixupChangedChildren : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> ParentChildrenToAdd;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			[ReadOnly]
			public NativeParallelMultiHashMap<Entity, Entity> ParentChildrenToRemove;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			[ReadOnly]
			public NativeParallelHashMap<Entity, int> UniqueParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public BufferFromEntity<TChildrenData> ChildFromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x33EA0A0", Offset = "0x33E88A0", VA = "0x1833EA0A0")]
			private int FindChildIndex(DynamicBuffer<TChildrenData> children, Entity entity)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x33EA180", Offset = "0x33E8980", VA = "0x1833EA180")]
			private void RemoveChildrenFromParent(Entity parent, DynamicBuffer<TChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x33E9BC0", Offset = "0x33E83C0", VA = "0x1833E9BC0")]
			private void AddChildrenToParent(Entity parent, DynamicBuffer<TChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x33E9D00", Offset = "0x33E8500", VA = "0x1833E9D00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		[BurstCompile]
		private struct GatherChildEntities : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public NativeArray<Entity> Parents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public NativeList<Entity> Children;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			[ReadOnly]
			public BufferFromEntity<TChildrenData> ChildFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			[ReadOnly]
			public ComponentDataFromEntity<TParentData> ParentFromEntity;

			[Cpp2IlInjected.Token(Token = "0x600064C")]
			[Cpp2IlInjected.Address(RVA = "0x34E2D70", Offset = "0x34E1570", VA = "0x1834E2D70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected EntityQuery m_NewParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected EntityQuery m_RemovedParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected EntityQuery m_ExistingParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected EntityQuery m_DeletedParentsGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected ProfilerMarker m_ProfileDeletedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected ProfilerMarker m_ProfileRemoveParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected ProfilerMarker m_ProfileChangeParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected ProfilerMarker m_ProfileNewParents;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x3EA3AC0", Offset = "0x3EA22C0", VA = "0x183EA3AC0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1370", Offset = "0x3E9FB70", VA = "0x183EA1370")]
		private int FindChildIndex(DynamicBuffer<TChildrenData> children, Entity entity)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1E60", Offset = "0x3EA0660", VA = "0x183EA1E60")]
		private void RemoveChildFromParent(Entity childEntity, Entity parentEntity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x8989C0", Offset = "0x8971C0", VA = "0x1808989C0", Slot = "14")]
		protected virtual EntityQueryDesc FilterNewParentQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x8989C0", Offset = "0x8971C0", VA = "0x1808989C0", Slot = "15")]
		protected virtual EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x8989C0", Offset = "0x8971C0", VA = "0x1808989C0", Slot = "16")]
		protected virtual EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc query);

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1470", Offset = "0x3E9FC70", VA = "0x183EA1470", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x3EA35F0", Offset = "0x3EA1DF0", VA = "0x183EA35F0")]
		private void UpdateNewParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x3EA38D0", Offset = "0x3EA20D0", VA = "0x183EA38D0")]
		private void UpdateRemoveParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x3EA2660", Offset = "0x3EA0E60", VA = "0x183EA2660")]
		private JobHandle UpdateChangeParents(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x3EA30E0", Offset = "0x3EA18E0", VA = "0x183EA30E0")]
		private void UpdateDeletedParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1BE0", Offset = "0x3EA03E0", VA = "0x183EA1BE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1BB0", Offset = "0x3EA03B0", VA = "0x183EA1BB0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
[AlwaysUpdateSystem]
public abstract class JBGPKHEAAKH : JMMMDIBDAGF, OLNFMJBKLAF
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private struct IANOAJCEGED : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public NativeListAsync<Entity> NCJHMEOOAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public NativeListAsync<Entity> LOCLNMEBGIL;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x5E36510", Offset = "0x5E34D10", VA = "0x185E36510")]
		public IANOAJCEGED(NativeList<Entity> NCJHMEOOAPN, NativeList<Entity> LOCLNMEBGIL, JobHandle LOGMOOGMKPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x5E36400", Offset = "0x5E34C00", VA = "0x185E36400")]
		public JobHandle DKKNGMGAKCN(JobHandle AGGDNOGFFOD)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x5E36480", Offset = "0x5E34C80", VA = "0x185E36480", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[BurstCompile]
	private struct HCMAKPFEGKP : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		[Flags]
		public enum LFGELMKFLGI
		{
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			ReadParentFromArray = 1,
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			FetchParentFromEntity = 2,
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			AncestorTagValue = 4,
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			ConstNoAncestorTag = 0,
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			ConstHasAncestorTag = 4
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		[WriteOnly]
		public NativeList<Entity> DNDNFOAGAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		[WriteOnly]
		public NativeList<Entity> EFJIPMKODAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		[ReadOnly]
		public NativeArray<Entity> EPHJEIIOCPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> ONIELLMIKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		[ReadOnly]
		public ComponentDataFromEntity FNJOBEMNLAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[ReadOnly]
		public ComponentDataFromEntity ABDNFAOBBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> IAEOPCKEKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public int LLNHGHFGBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public int BENLEIFJJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private LFGELMKFLGI GEEPOHICBKF;

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x5E35EB0", Offset = "0x5E346B0", VA = "0x185E35EB0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x5E360E0", Offset = "0x5E348E0", VA = "0x185E360E0")]
		private bool FMKNKDGMIED(Entity MFFDEAINOPL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x5E36270", Offset = "0x5E34A70", VA = "0x185E36270")]
		private void ILMGAKFDCGH(Entity MFFDEAINOPL, bool IJAPPGELLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x5E35FE0", Offset = "0x5E347E0", VA = "0x185E35FE0")]
		private void FDBMKMOIIIB(Entity MFFDEAINOPL, bool IJAPPGELLFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x5E36300", Offset = "0x5E34B00", VA = "0x185E36300")]
		public IANOAJCEGED OKFGNNPBKOA(NativeArray<Entity> BELHJIJANEK, JobHandle AGGDNOGFFOD)
		{
			return default(IANOAJCEGED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x5E36380", Offset = "0x5E34B80", VA = "0x185E36380")]
		public IANOAJCEGED OMBLLELJOCF(NativeArray<Entity> BELHJIJANEK, JobHandle AGGDNOGFFOD)
		{
			return default(IANOAJCEGED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x5E36190", Offset = "0x5E34990", VA = "0x185E36190")]
		public IANOAJCEGED GHEFJOCNABE(NativeList<KPDILCFCHEL> KAEOEAACCCG, JobHandle AGGDNOGFFOD)
		{
			return default(IANOAJCEGED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x5E35A70", Offset = "0x5E34270", VA = "0x185E35A70")]
		public IANOAJCEGED BAHHBIJMBBB(NativeList<KPDILCFCHEL> KAEOEAACCCG, JobHandle AGGDNOGFFOD)
		{
			return default(IANOAJCEGED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x5E35B50", Offset = "0x5E34350", VA = "0x185E35B50")]
		public IANOAJCEGED CHDMGBDFDNA(NativeList<MACOEFMOGFA> KAEOEAACCCG, JobHandle AGGDNOGFFOD)
		{
			return default(IANOAJCEGED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x2964130", Offset = "0x2962930", VA = "0x182964130")]
		private IANOAJCEGED DPPGCPEFEIB<T>(NativeList<T> KAEOEAACCCG, int AKNNFIMPFHO, int HDKPJHLPOCC, LFGELMKFLGI CHDCFCNHAFI, JobHandle AGGDNOGFFOD) where T : struct
		{
			return default(IANOAJCEGED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x5E35C30", Offset = "0x5E34430", VA = "0x185E35C30")]
		private IANOAJCEGED DPPGCPEFEIB(NativeArray<Entity> EFLDIIILPLM, int AKNNFIMPFHO, int HDKPJHLPOCC, LFGELMKFLGI CHDCFCNHAFI, JobHandle AGGDNOGFFOD)
		{
			return default(IANOAJCEGED);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	private readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	private EntityQuery IPILPDMDDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private EntityQuery ABEINLGPPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private LIEABLACGCP APCLEBMACGJ;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	protected abstract ComponentType CAAEKKGEAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	protected abstract ComponentType DPCLDJNJOGC
	{
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	protected abstract ComponentType JOPJHFKNOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x5E38BA0", Offset = "0x5E373A0", VA = "0x185E38BA0")]
	protected JBGPKHEAAKH(PFECAMNMOCE ANEILBIOBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x5E37520", Offset = "0x5E35D20", VA = "0x185E37520", Slot = "14")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x5E37600", Offset = "0x5E35E00", VA = "0x185E37600", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x5E37810", Offset = "0x5E36010", VA = "0x185E37810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x7E5F60", Offset = "0x7E4760", VA = "0x1807E5F60", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x5E38B00", Offset = "0x5E37300", VA = "0x185E38B00")]
	private void PIFJLKFBEOB(NativeArray<Entity> KAEOEAACCCG, EntityCommandBuffer KGGEMAPLOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x5E36F10", Offset = "0x5E35710", VA = "0x185E36F10")]
	private void ALJOINPNNPJ(NativeArray<Entity> KAEOEAACCCG, EntityCommandBuffer KGGEMAPLOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x5E370E0", Offset = "0x5E358E0", VA = "0x185E370E0")]
	private void EFNJJNDBEKJ(IANOAJCEGED EIBAGFHOMHA, string CDONPALIHJC, EntityCommandBuffer KGGEMAPLOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x5E36FB0", Offset = "0x5E357B0", VA = "0x185E36FB0")]
	private void EFNJJNDBEKJ(NativeListAsync<Entity> KIJDHLOGIAJ, string CDONPALIHJC, EntityCommandBuffer KGGEMAPLOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x5E37360", Offset = "0x5E35B60", VA = "0x185E37360")]
	private void FICLKFDIDOB(IANOAJCEGED EIBAGFHOMHA, string CDONPALIHJC, EntityCommandBuffer KGGEMAPLOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x5E37230", Offset = "0x5E35A30", VA = "0x185E37230")]
	private void FICLKFDIDOB(NativeListAsync<Entity> KIJDHLOGIAJ, string CDONPALIHJC, EntityCommandBuffer KGGEMAPLOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x5E374B0", Offset = "0x5E35CB0", VA = "0x185E374B0")]
	private bool LENHMDDLDHP()
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
	[CompilerGenerated]
	public class PhysicsSceneAddCollidersSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		private struct PhysicsSceneAddCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public PhysicsSceneAddCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x5E41A30", Offset = "0x5E40230", VA = "0x185E41A30")]
			private void LNNGHEHIOHC(Entity e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x5E41980", Offset = "0x5E40180", VA = "0x185E41980", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private DNIBMMAPIAI ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private IJGBKLONMFB colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private EntityQuery PhysicsSceneAddCollidersSystem_Query;

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x5E41E10", Offset = "0x5E40610", VA = "0x185E41E10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x5E41920", Offset = "0x5E40120", VA = "0x185E41920", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x5E41E70", Offset = "0x5E40670", VA = "0x185E41E70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x5E41B50", Offset = "0x5E40350", VA = "0x185E41B50")]
		private void KGEAPCDAOKF(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C40", Offset = "0x5E40440", VA = "0x185E41C40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PhysicsSceneAddCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
[PDJDECBPOKH(EOGANNGNDMH.OMRoom)]
[CPEPPNMEKPA]
public class NGGMFLJBBBJ : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private IJGBKLONMFB AHKNCPFBOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private MKHOKPNBAOG EFAAPEICBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C150", Offset = "0x5E3A950", VA = "0x185E3C150", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C1C0", Offset = "0x5E3A9C0", VA = "0x185E3C1C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C270", Offset = "0x5E3AA70", VA = "0x185E3C270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public NGGMFLJBBBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public struct KBLFMMBKNBL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	public KJPNOOMBEMH FJFHMLGEMLM;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000676")]
	[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
	public static KBLFMMBKNBL DAOGIJOJDNF([In] KJPNOOMBEMH MDLKPIGINHC)
	{
		return default(KBLFMMBKNBL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0xAAD710", Offset = "0xAABF10", VA = "0x180AAD710")]
	public static KJPNOOMBEMH DAOGIJOJDNF([In] KBLFMMBKNBL IICNPFJDJEB)
	{
		return default(KJPNOOMBEMH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[AlwaysUpdateSystem]
public class DNIBMMAPIAI : BLKAEPMAHDD
{
	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x5E30B30", Offset = "0x5E2F330", VA = "0x185E30B30", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public DNIBMMAPIAI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	[AlwaysUpdateSystem]
	[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
	[CompilerGenerated]
	public class PhysicsSceneRemoveCollidersSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000105")]
		private struct PhysicsSceneRemoveCollidersSystem_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public PhysicsSceneRemoveCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			[ReadOnly]
			public EntityTypeHandle __eTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			[ReadOnly]
			public ComponentTypeHandle<KBLFMMBKNBL> __chTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x5E420F0", Offset = "0x5E408F0", VA = "0x185E420F0")]
			private void LNNGHEHIOHC(Entity e, [In] KBLFMMBKNBL ch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0x5E41FD0", Offset = "0x5E407D0", VA = "0x185E41FD0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private DNIBMMAPIAI ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private IJGBKLONMFB colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private EntityQuery PhysicsSceneRemoveCollidersSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private ComponentTypeHandle<KBLFMMBKNBL> __RecRoom_ObjectModel_Systems_PhysicsSceneColliderHandleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x5E423B0", Offset = "0x5E40BB0", VA = "0x185E423B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x5E41F70", Offset = "0x5E40770", VA = "0x185E41F70", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x5E42410", Offset = "0x5E40C10", VA = "0x185E42410", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x5E42560", Offset = "0x5E40D60", VA = "0x185E42560")]
		private void PFNNBJECMIC(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x5E421A0", Offset = "0x5E409A0", VA = "0x185E421A0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PhysicsSceneRemoveCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public class ODFNEOKKCEK : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	private struct PFKHJGNLCNL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public HALHEDPAIEJ NBODHKFBPEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public NativeParallelHashSet<Entity> EFLDIIILPLM;

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x5E41090", Offset = "0x5E3F890", VA = "0x185E41090")]
		public PFKHJGNLCNL(int OLEHEDGFINF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x5E41020", Offset = "0x5E3F820", VA = "0x185E41020", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[BurstCompile]
	private struct KHLFPOKKBOM : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		[ReadOnly]
		public NativeArray<Entity> EFLDIIILPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		[ReadOnly]
		public ComponentDataFromEntity<HDHEDGENDAL> NDOJEOAFALI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[ReadOnly]
		public ComponentDataFromEntity<ILDJIOANNPB> HFMONHPMNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[ReadOnly]
		public ComponentDataFromEntity<NJFKOEEMFDB> NIBNFLKNHKP;

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x5E39890", Offset = "0x5E38090", VA = "0x185E39890", Slot = "4")]
		public void Execute(int ADMJKDLHPCI, TransformAccess KHFCFAPNPDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[BurstCompile]
	private struct PFOAIDCKIFM : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		[ReadOnly]
		public NativeArray<Entity> EFLDIIILPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		[ReadOnly]
		public ComponentDataFromEntity<HDHEDGENDAL> NDOJEOAFALI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		[ReadOnly]
		public ComponentDataFromEntity<NJFKOEEMFDB> NIBNFLKNHKP;

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x5E41130", Offset = "0x5E3F930", VA = "0x185E41130", Slot = "4")]
		public void Execute(int ADMJKDLHPCI, TransformAccess KHFCFAPNPDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private IJGBKLONMFB AHKNCPFBOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private EntityQuery JKAJFCPKEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private EntityQuery ALELPLNHDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private EntityQuery NBKJPNFODID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private EntityQuery KHAPKIDMNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery KHNBFKIPJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private JobHandle LKNLOFEHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private PFKHJGNLCNL AIDEKOELANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private PFKHJGNLCNL AOOFCKODIHD;

	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E8A0", Offset = "0x5E3D0A0", VA = "0x185E3E8A0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F1F0", Offset = "0x5E3D9F0", VA = "0x185E3F1F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000684")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F4D0", Offset = "0x5E3DCD0", VA = "0x185E3F4D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000685")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F4E0", Offset = "0x5E3DCE0", VA = "0x185E3F4E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F0B0", Offset = "0x5E3D8B0", VA = "0x185E3F0B0")]
	private void OJLJBADLNCG(EntityQuery PMIADPKJDNK, [Out] (NativeArrayAsync<KBLFMMBKNBL> handles, NativeArrayAsync<BIJOGOIADPC> bounds) KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x5E3ED20", Offset = "0x5E3D520", VA = "0x185E3ED20")]
	private void NFKHEAJLFPE((NativeArrayAsync<KBLFMMBKNBL> handles, NativeArrayAsync<BIJOGOIADPC> bounds) KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E640", Offset = "0x5E3CE40", VA = "0x185E3E640")]
	private void AEIBDBMHJCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EF70", Offset = "0x5E3D770", VA = "0x185E3EF70")]
	private void NHAECCFJJHL(EntityQuery PMIADPKJDNK, [Out] (NativeArrayAsync<Entity> entities, NativeArrayAsync<KBLFMMBKNBL> handles) KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E900", Offset = "0x5E3D100", VA = "0x185E3E900")]
	private void KHCCPMBPDIC((NativeArrayAsync<Entity> entities, NativeArrayAsync<KBLFMMBKNBL> handles) KOIMDAJNDOD, PFKHJGNLCNL GAAKFFCHNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E740", Offset = "0x5E3CF40", VA = "0x185E3E740")]
	private JobHandle HLNONCEKPBO(PFKHJGNLCNL GAAKFFCHNLB, ComponentDataFromEntity<HDHEDGENDAL> NDOJEOAFALI, ComponentDataFromEntity<NJFKOEEMFDB> NIBNFLKNHKP, ComponentDataFromEntity<ILDJIOANNPB> HFMONHPMNNI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EBC0", Offset = "0x5E3D3C0", VA = "0x185E3EBC0")]
	private JobHandle LGGKALJHKMP(PFKHJGNLCNL GAAKFFCHNLB, ComponentDataFromEntity<HDHEDGENDAL> NDOJEOAFALI, ComponentDataFromEntity<NJFKOEEMFDB> NIBNFLKNHKP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public ODFNEOKKCEK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010A")]
public struct AIKIPBAOMKL : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
[CPEPPNMEKPA]
public class CLCGDLODFPM : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[BurstCompile]
	private struct AMNIDNMFLMO : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		[ReadOnly]
		public NativeArray<Entity> ANLPOJKFEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		[ReadOnly]
		public ComponentDataFromEntity<KFEMMDMNKPE> JLBDINDPLKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		[ReadOnly]
		public ComponentDataFromEntity<BIJOGOIADPC> NBHDEDFNCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		[WriteOnly]
		public NativeParallelHashSet<Entity>.ParallelWriter LBBAGBJJEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter GPOCJJDBKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter CABOIJPGJHM;

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AD40", Offset = "0x5E29540", VA = "0x185E2AD40", Slot = "4")]
		public void Execute(int ADMJKDLHPCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[BurstCompile]
	private struct FKIEGIMNBHK : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		[ReadOnly]
		public NativeArray<Entity> DMLMCOGPAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> JCEDGIJIFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[ReadOnly]
		public ComponentDataFromEntity<HHICHINIONL> ABPMKEMGEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		[ReadOnly]
		public ComponentDataFromEntity<LNBJNLHDKEI> BCMPDACODFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<BIJOGOIADPC> NJPBGCABKHB;

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E32830", Offset = "0x5E31030", VA = "0x185E32830", Slot = "4")]
		public void Execute(int ADMJKDLHPCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400036C")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	private EntityQuery MJEOEKGFBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private EntityQuery DAMIPOBHPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private EntityQuery EFCGLOOLKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private EntityQuery NOOLPEPGAOL;

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E000", Offset = "0x5E2C800", VA = "0x185E2E000", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E230", Offset = "0x5E2CA30", VA = "0x185E2E230", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E850", Offset = "0x5E2D050", VA = "0x185E2E850")]
	private JobHandle PNJNMNEHFCN(NativeArrayAsync<Entity> JMHHCKCLFBI, int OOHKMCMOCLB, JobHandle AGGDNOGFFOD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E930", Offset = "0x5E2D130", VA = "0x185E2E930")]
	private JobHandle PNJNMNEHFCN(NativeArray<Entity> JFELNECCHFJ, int OOHKMCMOCLB, [Optional] JobHandle AGGDNOGFFOD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D580", Offset = "0x5E2BD80", VA = "0x185E2D580")]
	private (NativeListAsync<Entity>, NativeListAsync<Entity>) AJOAOAHBGHG(NativeArrayAsync<Entity> AKBBKOFMKNN)
	{
		return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DE10", Offset = "0x5E2C610", VA = "0x185E2DE10")]
	private void EHKMDNAALLP([Out] NativeArray<Entity> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DAA0", Offset = "0x5E2C2A0", VA = "0x185E2DAA0")]
	private void CONJIEFOHDF(NativeList<Entity> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D9C0", Offset = "0x5E2C1C0", VA = "0x185E2D9C0")]
	private void CONJIEFOHDF(NativeArray<Entity> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DE90", Offset = "0x5E2C690", VA = "0x185E2DE90")]
	private void MBFIGPCILEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void KPKNHAIKBHM(int GDGABBFONPE, int PHPNKJGABMN, int OMHEOGAHCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DB30", Offset = "0x5E2C330", VA = "0x185E2DB30")]
	private static BIJOGOIADPC DPHNFKDNDCN(NativeArray<Entity> IGDGCGKIDHG, ComponentDataFromEntity<HHICHINIONL> ABPMKEMGEFG, ComponentDataFromEntity<LNBJNLHDKEI> BCMPDACODFM)
	{
		return default(BIJOGOIADPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public CLCGDLODFPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
[CPEPPNMEKPA]
public class EDMINOMKBEE : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private static readonly PFECAMNMOCE JIEMACICKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	[MCMLPKDBFJE]
	private CHHCBHMKOGM PGPBOKMMIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private EntityQuery AAGIFGNHIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	private EntityQuery KDIDAHNJFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E30E20", Offset = "0x5E2F620", VA = "0x185E30E20", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E30E70", Offset = "0x5E2F670", VA = "0x185E30E70")]
	public bool KECNDAIKMOI(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E310A0", Offset = "0x5E2F8A0", VA = "0x185E310A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E30B60", Offset = "0x5E2F360", VA = "0x185E30B60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x8195D0", Offset = "0x817DD0", VA = "0x1808195D0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E31190", Offset = "0x5E2F990", VA = "0x185E31190", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E30B60", Offset = "0x5E2F360", VA = "0x185E30B60")]
	private void AEIAJFPLJFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E30B80", Offset = "0x5E2F380", VA = "0x185E30B80")]
	private void ECOBJEPKENH(EntityQuery PMIADPKJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E30F50", Offset = "0x5E2F750", VA = "0x185E30F50")]
	private void NIBGIKGJCBK(NativeArray<Entity> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public EDMINOMKBEE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010F")]
internal struct KFHMDEIKIMA : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[CompilerGenerated]
	[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
	internal class CopyOwnerToEntitySystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		private struct CopyOwnerToEntitySystem_RemoveDisembodied_Job
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public CopyOwnerToEntitySystem __this;

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x5E30370", Offset = "0x5E2EB70", VA = "0x185E30370")]
			public void FBIIIOJKMFJ(EntityQuery query)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000112")]
		private struct CopyOwnerToEntitySystem_Clear_Job
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public CopyOwnerToEntitySystem __this;

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x5E2EFF0", Offset = "0x5E2D7F0", VA = "0x185E2EFF0")]
			public void FBIIIOJKMFJ(EntityQuery query)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private HOKKMAFBPHI objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private BODCEDFCLFN dependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private EntityQuery add;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private EntityQuery remove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private EntityQuery clear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private EntityQuery CopyOwnerToEntitySystem_RemoveDisembodied_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private EntityQuery CopyOwnerToEntitySystem_Clear_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private ComponentTypeHandle<DBNNJCPEJLD> __RecRoom_Components_PhotonOwnerData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private ComponentTypeHandle<MFPKLNCMNOE> __RecRoom_Components_PhotonOwnerWatcherData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F4D0", Offset = "0x5E2DCD0", VA = "0x185E2F4D0", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FC20", Offset = "0x5E2E420", VA = "0x185E2FC20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FDC0", Offset = "0x5E2E5C0", VA = "0x185E2FDC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FCF0", Offset = "0x5E2E4F0", VA = "0x185E2FCF0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FE90", Offset = "0x5E2E690", VA = "0x185E2FE90")]
		private void PAJGGMPJCDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EF20", Offset = "0x5E2D720", VA = "0x185E2EF20")]
		private void AKEPCONIBAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F410", Offset = "0x5E2DC10", VA = "0x185E2F410")]
		private void GKBCBCOIJDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F5F0", Offset = "0x5E2DDF0", VA = "0x185E2F5F0")]
		private void NKMOEIBGLOB(Entity e, [In] MFPKLNCMNOE watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F290", Offset = "0x5E2DA90", VA = "0x185E2F290")]
		private void FLEJPBPLGNF(JEDJBKOCEME localId, int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EFE0", Offset = "0x5E2D7E0", VA = "0x185E2EFE0")]
		private void CFHGDMLECOF(Entity e, [In] DBNNJCPEJLD _, [In] MFPKLNCMNOE watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F540", Offset = "0x5E2DD40", VA = "0x185E2F540")]
		private void LKGDFFJCOJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EFE0", Offset = "0x5E2D7E0", VA = "0x185E2EFE0")]
		private void MOACLHOKLEB(Entity e, [In] DBNNJCPEJLD _, [In] MFPKLNCMNOE watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F360", Offset = "0x5E2DB60", VA = "0x185E2F360")]
		private void GBGEPGNOKPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F860", Offset = "0x5E2E060", VA = "0x185E2F860", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public CopyOwnerToEntitySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EFE0", Offset = "0x5E2D7E0", VA = "0x185E2EFE0")]
		[CompilerGenerated]
		private void FNKAAKOBJAL(Entity e, [In] DBNNJCPEJLD _, [In] MFPKLNCMNOE watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EFE0", Offset = "0x5E2D7E0", VA = "0x185E2EFE0")]
		[CompilerGenerated]
		private void FBPNJNOLEOP(Entity e, [In] DBNNJCPEJLD _, [In] MFPKLNCMNOE watcherData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal class AADIGACHPBI : JMMMDIBDAGF, OILIFCGGAMK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private struct BCBEHCAOEDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public NativeParallelHashMap<Entity, int> modifiedOwners;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public ComponentDataFromEntity<DBNNJCPEJLD> ownershipDataRO;
	}

	[Cpp2IlInjected.Token(Token = "0x400038E")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038F")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private BODCEDFCLFN NHCNDCONNLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private FGIBAMAPNKP FIGKGJJCBAE;

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E29D20", Offset = "0x5E28520", VA = "0x185E29D20", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A3D0", Offset = "0x5E28BD0", VA = "0x185E2A3D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A4B0", Offset = "0x5E28CB0", VA = "0x185E2A4B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E29D90", Offset = "0x5E28590", VA = "0x185E29D90")]
	private void KCFKIENMAIP(NativeArray<Entity> EFLDIIILPLM, NativeParallelHashMap<Entity, int> DDCJKNNJGCK, ComponentDataFromEntity<DBNNJCPEJLD> KCCPCIEGGJL, BufferFromEntity<ChildrenData> AJOAIFHIBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public AADIGACHPBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E29C90", Offset = "0x5E28490", VA = "0x185E29C90")]
	[CompilerGenerated]
	internal static int HJNDOIDNBFP(Entity MFFDEAINOPL, BCBEHCAOEDJ P_1)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
[AlwaysUpdateSystem]
public class CAFCBMHJHLK : JMMMDIBDAGF, OILIFCGGAMK, GAJGABMNKBI
{
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class GJBGMEPGDAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		public JEDJBKOCEME localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public IDGPFAGGINB collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public bool collidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public DGGKHCFPFHF containerFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public bool physicsEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public bool gravityEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public bool hasUnityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public CAFCBMHJHLK <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GJBGMEPGDAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E34500", Offset = "0x5E32D00", VA = "0x185E34500")]
		internal void DLBDAMKHOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E34600", Offset = "0x5E32E00", VA = "0x185E34600")]
		internal void OJPBPMPFMON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x5E343E0", Offset = "0x5E32BE0", VA = "0x185E343E0")]
		internal void BBFHOKAKHHC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000395")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	[MCMLPKDBFJE]
	private LANFDNHMLHI FAPKOIKLPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	[MCMLPKDBFJE]
	private DGCDFIAGJDB HCAPGGFCBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	[MCMLPKDBFJE]
	private JDCOPOKIPOM FNKPGAPKDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public ComponentTypeHandle<DGGKHCFPFHF> DLHNPMDKONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public ComponentTypeHandle<KALGBBEFMCC> INPCCELGNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public ComponentTypeHandle<LACAENCLGLJ> BJCCMFNLOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public ComponentTypeHandle<MIOJLMEFCJI> IJAOOAOCNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public ComponentTypeHandle<EJMDHGCCAIO> HBPCODGPOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public DynamicComponentTypeHandle OLMJDALFOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public EntityTypeHandle KCNFILFCEFP;

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C1C0", Offset = "0x5E2A9C0", VA = "0x185E2C1C0", Slot = "15")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BE10", Offset = "0x5E2A610", VA = "0x185E2BE10", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C290", Offset = "0x5E2AA90", VA = "0x185E2C290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D330", Offset = "0x5E2BB30", VA = "0x185E2D330")]
	private void PFAGHEGJBIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BEC0", Offset = "0x5E2A6C0", VA = "0x185E2BEC0")]
	private bool LENHMDDLDHP([Out] int PDFOLNFGLOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public CAFCBMHJHLK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
	[AlwaysUpdateSystem]
	public class UpdateSplineGameCollidersSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000118")]
		public struct SplineGameCollisionSystemTag : ISystemStateComponentData, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000119")]
		private struct ProcessCollisionModeChangesForSplineGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			[ReadOnly]
			public ComponentDataFromEntity<EMEKAFKHOIN> splineComponentAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			[ReadOnly]
			public ComponentTypeHandle<KALGBBEFMCC> __collisionModeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public BufferTypeHandle<ChildrenData> __childrenTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(RVA = "0x5E42A00", Offset = "0x5E41200", VA = "0x185E42A00")]
			private void LNNGHEHIOHC([In] KALGBBEFMCC collisionMode, DynamicBuffer<ChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(RVA = "0x5E42890", Offset = "0x5E41090", VA = "0x185E42890", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011A")]
		private struct ProcessActiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			[ReadOnly]
			public ComponentDataFromEntity<KALGBBEFMCC> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(RVA = "0x5E427B0", Offset = "0x5E40FB0", VA = "0x185E427B0")]
			private void LNNGHEHIOHC(Entity entity, [In] ParentData parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0x5E42690", Offset = "0x5E40E90", VA = "0x185E42690", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011B")]
		private struct ProcessInactiveSplineReparentsForGameCollision_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			[ReadOnly]
			public ComponentDataFromEntity<KALGBBEFMCC> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x5E42EA0", Offset = "0x5E416A0", VA = "0x185E42EA0")]
			private void LNNGHEHIOHC(Entity entity, [In] ParentData parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x5E42D80", Offset = "0x5E41580", VA = "0x185E42D80", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011C")]
		private struct UpdateSplineGameCollidersSystem_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x5E47300", Offset = "0x5E45B00", VA = "0x185E47300")]
			private void LNNGHEHIOHC(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x5E47250", Offset = "0x5E45A50", VA = "0x185E47250", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200011D")]
		private struct ProcessSplineEditsForGameCollision_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public UpdateSplineGameCollidersSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			[ReadOnly]
			public ComponentTypeHandle<KFEMMDMNKPE> splinePointParentHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			[ReadOnly]
			public EntityTypeHandle entityHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public EntityQueryInJob splinePointEditedQueryInJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public EntityQueryInJob splineStructureChangedQueryInJob;

			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0x5E42FD0", Offset = "0x5E417D0", VA = "0x185E42FD0")]
			private void LNNGHEHIOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x5E42FC0", Offset = "0x5E417C0", VA = "0x185E42FC0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x5E42F70", Offset = "0x5E41770", VA = "0x185E42F70")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void DEHIKMNDBAI(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private ONKAIGMIMMN splineCollisionService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private EntityQuery collisionModeChangeQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private EntityQuery activeSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private EntityQuery inactiveSplineReparentedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private EntityQuery splinePointEditedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private EntityQuery splineStructureChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private EntityQuery splinesDeletedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private EntityQuery ProcessCollisionModeChangesForSplineGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private EntityQuery ProcessActiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private EntityQuery ProcessInactiveSplineReparentsForGameCollision_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		private EntityQuery UpdateSplineGameCollidersSystem_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private ComponentTypeHandle<KALGBBEFMCC> __RecRoom_Components_ContainerCollisionModeData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x5E46ED0", Offset = "0x5E456D0", VA = "0x185E46ED0", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E47CD0", Offset = "0x5E464D0", VA = "0x185E47CD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E47EB0", Offset = "0x5E466B0", VA = "0x185E47EB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E46A70", Offset = "0x5E45270", VA = "0x185E46A70")]
		private void GLHJKFPIDPN(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E46600", Offset = "0x5E44E00", VA = "0x185E46600")]
		private void CCLEGIFOEAN(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E468C0", Offset = "0x5E450C0", VA = "0x185E468C0")]
		private void GBEPCODPCBB(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E46510", Offset = "0x5E44D10", VA = "0x185E46510")]
		private void BAGDCMMHJAD(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E46F20", Offset = "0x5E45720", VA = "0x185E46F20")]
		private void JJBNIGHANDH(EntityCommandBuffer ecb, ComponentDataFromEntity<EMEKAFKHOIN> splineComponentAccess, ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E46C80", Offset = "0x5E45480", VA = "0x185E46C80")]
		private void GMOCGJNLMEH(EntityCommandBuffer ecb, ComponentDataFromEntity<KALGBBEFMCC> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E473B0", Offset = "0x5E45BB0", VA = "0x185E473B0")]
		private void OLKMJLIBABB(EntityCommandBuffer ecb, ComponentDataFromEntity<KALGBBEFMCC> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E46DE0", Offset = "0x5E455E0", VA = "0x185E46DE0")]
		private void HJGCKOODOPN(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E47110", Offset = "0x5E45910", VA = "0x185E47110")]
		private void JMJHBKLFDEB(ComponentTypeHandle<KFEMMDMNKPE> splinePointParentHandle, EntityTypeHandle entityHandle, ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess, EntityQueryInJob splinePointEditedQueryInJob, EntityQueryInJob splineStructureChangedQueryInJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E47510", Offset = "0x5E45D10", VA = "0x185E47510", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public UpdateSplineGameCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[CPEPPNMEKPA]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public class FGHOPKGECPN : JMMMDIBDAGF, GAJGABMNKBI, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[BurstCompile]
	private struct NHECLLMGIEH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		[ReadOnly]
		public EntityTypeHandle PIAAJHGBOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		[ReadOnly]
		public ComponentTypeHandle<HDHEDGENDAL> JKHPLONLOLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		[WriteOnly]
		public NativeList<BNHBLFIGPPL>.ParallelWriter OHPFMPKOMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public ComponentTypeHandle<BNDFFDNBBCD> BNDOCHMPGEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public float3 HBMBMELELPF;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private static readonly float4x2 PEDBKGLCMIL;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private static readonly float4x2 LGAIOOEEBBI;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly int4x2 ALKFPGFOKKD;

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E3C670", Offset = "0x5E3AE70", VA = "0x185E3C670", Slot = "4")]
		public void Execute(ArchetypeChunk KIJHCPOKLEK, int AJONNGIJKEF, int LACIPLGAFDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private static PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private EntityQuery MCNBPGLPHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private EntityQuery NBDMHLIPMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private double FKENOMEKPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private FGIBAMAPNKP KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private CGEKBNLHEMJ IBHMGJNOHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private FCENJDFCEED DGICCKHKNOD;

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E32390", Offset = "0x5E30B90", VA = "0x185E32390", Slot = "14")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E32060", Offset = "0x5E30860", VA = "0x185E32060", Slot = "15")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E323A0", Offset = "0x5E30BA0", VA = "0x185E323A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E32510", Offset = "0x5E30D10", VA = "0x185E32510", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E31FF0", Offset = "0x5E307F0", VA = "0x185E31FF0")]
	private bool INHMOANCFKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E320F0", Offset = "0x5E308F0", VA = "0x185E320F0")]
	private void KLCEJDHBPCA(EntityQuery PMIADPKJDNK, float3 ENDPMLKLOGM, string BOBHOMKFHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public FGHOPKGECPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public struct BNHBLFIGPPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	public Entity MFFDEAINOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	public DFNOPHHBCLE HCFJKNGNHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public DFNOPHHBCLE NIGNLJEOLLK;
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public class FIBIGJEHNOL : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private CGEKBNLHEMJ IBHMGJNOHKN;

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E327C0", Offset = "0x5E30FC0", VA = "0x185E327C0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E32810", Offset = "0x5E31010", VA = "0x185E32810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public FIBIGJEHNOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public class IHEOEDMLCLN : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E36BE0", Offset = "0x5E353E0", VA = "0x185E36BE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E36CA0", Offset = "0x5E354A0", VA = "0x185E36CA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public IHEOEDMLCLN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
	public class UpdateInertialPropertiesSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000124")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct UpdateInertialPropertiesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x2000125")]
			public delegate void RunWithoutJobSystem_00000895$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x2000126")]
			internal static class RunWithoutJobSystem_00000895$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x40003FA")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x40003FB")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x600070D")]
				[Cpp2IlInjected.Address(RVA = "0x5E436F0", Offset = "0x5E41EF0", VA = "0x185E436F0")]
				[BurstDiscard]
				private static void FJILHCAMCOC(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600070E")]
				[Cpp2IlInjected.Address(RVA = "0x5E43820", Offset = "0x5E42020", VA = "0x185E43820")]
				private static IntPtr LELDEMJJKOF()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x600070F")]
				[Cpp2IlInjected.Address(RVA = "0x5E43980", Offset = "0x5E42180", VA = "0x185E43980")]
				public static void MGABIKEDEHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000710")]
				[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
				public static void MJKJMKCCJMD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000712")]
				[Cpp2IlInjected.Address(RVA = "0x5E43520", Offset = "0x5E41D20", VA = "0x185E43520")]
				public static void AOLJJLOPFJO(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public EntityQueryInJob isTaggedForUpdate;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public EntityQueryInJob rootRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public EntityQueryInJob deformationScaleChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			public EntityQueryInJob generalRbexChangedQuery;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			public ChunkFilterAnyOf5ComponentsChanged changeFilter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public int maxEntityCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public NativeList<Entity> changedRoots;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			[ReadOnly]
			public EntityExistenceLookupByEntity entityExists;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			[ReadOnly]
			public EntityTypeHandle entityTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			[ReadOnly]
			public ComponentTypeHandle<OOBFKGFEPMA> rbexRootTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			[ReadOnly]
			public ComponentDataFromEntity<PAFKAIMPJON> rbexIsKinematicRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0x5E44520", Offset = "0x5E42D20", VA = "0x185E44520")]
			private void LNNGHEHIOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0x5E444C0", Offset = "0x5E42CC0", VA = "0x185E444C0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0x5E442B0", Offset = "0x5E42AB0", VA = "0x185E442B0")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void DEHIKMNDBAI(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0x5E444D0", Offset = "0x5E42CD0", VA = "0x185E444D0")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void JGJLKPPMPLB(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private EntityQuery isTaggedForUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private EntityQuery generalRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private EntityQuery rootRbexChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private EntityQuery deformationScaleChangedQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private EntityQuery removeMassOfHierarchyQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private LANFDNHMLHI rbexServiceCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private HOKKMAFBPHI objects;

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E43A30", Offset = "0x5E42230", VA = "0x185E43A30", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E44F40", Offset = "0x5E43740", VA = "0x185E44F40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E452E0", Offset = "0x5E43AE0", VA = "0x185E452E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0x5E43AA0", Offset = "0x5E422A0", VA = "0x185E43AA0")]
		protected void KDGLLOALCLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0x5E44210", Offset = "0x5E42A10", VA = "0x185E44210")]
		protected void LBEBDGGGPOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x5E43DE0", Offset = "0x5E425E0", VA = "0x185E43DE0")]
		private bool KKPJGNNFFCC(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, [Out] NativeList<Entity> results)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x5E44B70", Offset = "0x5E43370", VA = "0x185E44B70")]
		private void MFKDFDHMCEE(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, ChunkFilterAnyOf5ComponentsChanged changeFilter, int maxEntityCount, NativeList<Entity> changedRoots, EntityExistenceLookupByEntity entityExists, EntityTypeHandle entityTypeRO, ComponentTypeHandle<OOBFKGFEPMA> rbexRootTypeRO, ComponentDataFromEntity<PAFKAIMPJON> rbexIsKinematicRO, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x5E44E50", Offset = "0x5E43650", VA = "0x185E44E50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public UpdateInertialPropertiesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x5E45390", Offset = "0x5E43B90", VA = "0x185E45390")]
		public static void PHIAODHDJLP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	public class UpdateMassOfShapesSystem : JMMMDIBDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000128")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct UpdateMassOfShapesSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			[ReadOnly]
			public ComponentDataFromEntity<NGEJJJHGHFP> worldDeformableScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			[ReadOnly]
			public ComponentDataFromEntity<NJFKOEEMFDB> worldUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			[ReadOnly]
			public ComponentDataFromEntity<BJCLJCIABOJ> physicsMaterialsRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			[ReadOnly]
			public ComponentDataFromEntity<HFHNHKEAOML> primitiveShapesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			[ReadOnly]
			public ComponentDataFromEntity<GJGBGBOCFHG> localUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			public ComponentDataFromEntity<LPIJHFCLHDO> massesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			public ComponentDataFromEntity<PIAMOIBOFOK> centerOfMassesRW;

			[Cpp2IlInjected.Token(Token = "0x600071A")]
			[Cpp2IlInjected.Address(RVA = "0x5E458C0", Offset = "0x5E440C0", VA = "0x185E458C0")]
			private void LNNGHEHIOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600071B")]
			[Cpp2IlInjected.Address(RVA = "0x5E458B0", Offset = "0x5E440B0", VA = "0x185E458B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private EntityQuery query;

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x5E45D10", Offset = "0x5E44510", VA = "0x185E45D10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x5E45E50", Offset = "0x5E44650", VA = "0x185E45E50", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x5E455A0", Offset = "0x5E43DA0", VA = "0x185E455A0")]
		private void IOGLJGGEDJL(NativeList<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x5E453D0", Offset = "0x5E43BD0", VA = "0x185E453D0")]
		private JobHandle DIINHILBKHD(NativeList<Entity> entities, ComponentDataFromEntity<NGEJJJHGHFP> worldDeformableScalesRO, ComponentDataFromEntity<NJFKOEEMFDB> worldUniformScalesRO, ComponentDataFromEntity<BJCLJCIABOJ> physicsMaterialsRO, ComponentDataFromEntity<HFHNHKEAOML> primitiveShapesRO, ComponentDataFromEntity<GJGBGBOCFHG> localUniformScalesRO, ComponentDataFromEntity<LPIJHFCLHDO> massesRW, ComponentDataFromEntity<PIAMOIBOFOK> centerOfMassesRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public UpdateMassOfShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public class IGLFJKNDGEE : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[BurstCompile]
	private struct JNKLMGCOEOF : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[ReadOnly]
		public int NDJKKAMDFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		[ReadOnly]
		public EntityQueryInJob OILOCHCINPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		[ReadOnly]
		public EntityQueryInJob AGHNLIAGNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[ReadOnly]
		public ChunkFilterAnyOf3ComponentsChanged NLIPKHHANAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		[ReadOnly]
		public EntityTypeHandle KCNFILFCEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		[ReadOnly]
		public ComponentDataFromEntity<BJCLJCIABOJ> NCPPPFBECKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		[ReadOnly]
		public ComponentDataFromEntity<NJFKOEEMFDB> MJOAOPPCPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> AFNAMPOKNKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		[ReadOnly]
		public ComponentTypeHandle<KFEMMDMNKPE> JLFBKBLIEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		[ReadOnly]
		public ComponentDataFromEntity<HHICHINIONL> INJDFDEHCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		[ReadOnly]
		public ComponentDataFromEntity<LNBJNLHDKEI> BCMPDACODFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		[WriteOnly]
		public ComponentDataFromEntity<LPIJHFCLHDO> JDDGEGHFBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		[WriteOnly]
		public ComponentDataFromEntity<PIAMOIBOFOK> ANAHEKHCDOE;

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x5E39210", Offset = "0x5E37A10", VA = "0x185E39210", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x5E38C40", Offset = "0x5E37440", VA = "0x185E38C40")]
		private void CFPMPEJAACC(NativeList<Entity> EAABDMCBPNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x5E393D0", Offset = "0x5E37BD0", VA = "0x185E393D0")]
		private void KHGFHNHBBIL(Entity CPJMAEMAJBC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private EntityQuery BLMCKOEGFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private EntityQuery IPDICBOFDJK;

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(RVA = "0x5E36600", Offset = "0x5E34E00", VA = "0x185E36600", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(RVA = "0x5E367C0", Offset = "0x5E34FC0", VA = "0x185E367C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0x23FC480", Offset = "0x23FAC80", VA = "0x1823FC480")]
	private bool LGKDCANGALE<T>(T DJPALJCFLNO, [Out] int IICODOIGKPN) where T : struct, IChunkChangeFilter
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public IGLFJKNDGEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
[CPEPPNMEKPA]
public class NLOPHGNCKAN : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MOAGJJJLEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> DPJMKKLJLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> KAENEOOKONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private FNNHLGFMHNI IELFPGPEOGH;

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D5E0", Offset = "0x5E3BDE0", VA = "0x185E3D5E0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DD00", Offset = "0x5E3C500", VA = "0x185E3DD00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D2E0", Offset = "0x5E3BAE0", VA = "0x185E3D2E0")]
	private void GNHKFPEKEFG(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> KAEOEAACCCG, EntityQueryDesc DKDJBLOPGBD, bool BCBKDKMIJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D450", Offset = "0x5E3BC50", VA = "0x185E3D450")]
	private void GNHKFPEKEFG(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> KAEOEAACCCG, EntityQueryDesc DKDJBLOPGBD, bool BCBKDKMIJHH, bool NKFCPJHMPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DF70", Offset = "0x5E3C770", VA = "0x185E3DF70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D670", Offset = "0x5E3BE70", VA = "0x185E3D670")]
	private void MDFAKDOKJAG(EntityQuery PMIADPKJDNK, bool BLIGMACBCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D0C0", Offset = "0x5E3B8C0", VA = "0x185E3D0C0")]
	private void GIANFGKMHDI(EntityQuery PMIADPKJDNK, bool GALOGOCDHCK, bool BLIGMACBCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D880", Offset = "0x5E3C080", VA = "0x185E3D880")]
	private void NAIEPIPHAII(NativeArray<Entity> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CBD0", Offset = "0x5E3B3D0", VA = "0x185E3CBD0")]
	private void BLDGLINBHPE(NativeList<Entity> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CD60", Offset = "0x5E3B560", VA = "0x185E3CD60")]
	private void DIKGBPEDJBE(NativeArray<Entity> EFLDIIILPLM, bool GALOGOCDHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DAF0", Offset = "0x5E3C2F0", VA = "0x185E3DAF0")]
	private NativeList<Entity> OMPHACEGEFC(NativeArray<Entity> EFLDIIILPLM)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D630", Offset = "0x5E3BE30", VA = "0x185E3D630")]
	private NativeList<Entity> JNIAKDCGMHO(NativeArray<Entity> EFLDIIILPLM)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CEA0", Offset = "0x5E3B6A0", VA = "0x185E3CEA0")]
	private NativeList<Entity> FBDDIOGOKPK(NativeArray<Entity> EFLDIIILPLM)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CEE0", Offset = "0x5E3B6E0", VA = "0x185E3CEE0")]
	private NativeList<Entity> FBIJAFMEEJD(NativeArray<Entity> EFLDIIILPLM, bool KLHNEPHPBCP)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E300", Offset = "0x5E3CB00", VA = "0x185E3E300")]
	public NLOPHGNCKAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public class OAINGMFDNFM : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private FNNHLGFMHNI IELFPGPEOGH;

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E3F0", Offset = "0x5E3CBF0", VA = "0x185E3E3F0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E440", Offset = "0x5E3CC40", VA = "0x185E3E440", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public OAINGMFDNFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public class PMPCGFJJKGE : LDPLANFOAAB
{
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private static PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private EntityQuery DEHGPLCIPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private EntityQuery OADPACPFNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private EntityQuery KKNLKGPGEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private EntityQuery HCJNEBEPGBC;

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x5E41630", Offset = "0x5E3FE30", VA = "0x185E41630", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x5E41810", Offset = "0x5E40010", VA = "0x185E41810", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x5E41290", Offset = "0x5E3FA90", VA = "0x185E41290")]
	private void NCPDJNFGIFD(EntityQuery PMIADPKJDNK, bool MJLEEPFNLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x5E41460", Offset = "0x5E3FC60", VA = "0x185E41460")]
	private void OIIHFLHMELJ(EntityQuery PMIADPKJDNK, bool MJLEEPFNLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public PMPCGFJJKGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
[AlwaysUpdateSystem]
public class FDDCBNIEPOL : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	[MCMLPKDBFJE]
	private JFFIINNEBJC OHLFIPLFDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	[MCMLPKDBFJE]
	private LANFDNHMLHI FAPKOIKLPPN;

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x5E31300", Offset = "0x5E2FB00", VA = "0x185E31300", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x5E31390", Offset = "0x5E2FB90", VA = "0x185E31390")]
	protected void OFNBOHGOOBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x5E31410", Offset = "0x5E2FC10", VA = "0x185E31410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public FDDCBNIEPOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
internal class AOFCKGMEOFI : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private FGIBAMAPNKP KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private EntityQuery PJEDNDGLEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private EntityQuery BFKHKENEDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private MKHOKPNBAOG EMCGPGCLFIM;

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B1F0", Offset = "0x5E299F0", VA = "0x185E2B1F0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B830", Offset = "0x5E2A030", VA = "0x185E2B830", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B950", Offset = "0x5E2A150", VA = "0x185E2B950", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B6E0", Offset = "0x5E29EE0", VA = "0x185E2B6E0")]
	private void OMOACMKEAKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AE20", Offset = "0x5E29620", VA = "0x185E2AE20")]
	private void BDLLFDOCHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B370", Offset = "0x5E29B70", VA = "0x185E2B370")]
	private void MPFHENPMEJD(NativeArray<Entity> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B060", Offset = "0x5E29860", VA = "0x185E2B060")]
	private void IJIOBHHLJNP(NativeArray<Entity> EFLDIIILPLM, int NDNBLDBIDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B260", Offset = "0x5E29A60", VA = "0x185E2B260")]
	private void MHIFAJCMOOJ(NativeArray<Entity> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AFE0", Offset = "0x5E297E0", VA = "0x185E2AFE0")]
	private void CLPNHGABPFA(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void OCKHNGLHALA(int AJEJCPPFLLB, Transform KHFCFAPNPDN, Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public AOFCKGMEOFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal static class EOHOMBOFLIH
{
	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x5E31270", Offset = "0x5E2FA70", VA = "0x185E31270")]
	public static bool NLOBIDKAMLH(this SystemBase HKHKOFLAFNB, [Out] Entity MFFDEAINOPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal class CMMLAJLAPPF : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private EntityQuery IFLAHAKKFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private ALHOKAPBJCK BCLINPCBGGJ;

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EBD0", Offset = "0x5E2D3D0", VA = "0x185E2EBD0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EC20", Offset = "0x5E2D420", VA = "0x185E2EC20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2ECE0", Offset = "0x5E2D4E0", VA = "0x185E2ECE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public CMMLAJLAPPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal class FKIKNFLFAMI : BCOOFFPOKNI<MAENMMCDCDI>, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private OELIOIGNFBB GKOOPAFPFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	private EntityQuery OAMILIMJCGD;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private Entity JALODFNGKMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x5E32B10", Offset = "0x5E31310", VA = "0x185E32B10")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x5E32E00", Offset = "0x5E31600", VA = "0x185E32E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public JEDJBKOCEME NAJJHPBJGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x5E33030", Offset = "0x5E31830", VA = "0x185E33030")]
		get
		{
			return default(JEDJBKOCEME);
		}
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x5E32AB0", Offset = "0x5E312B0", VA = "0x185E32AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x5E33210", Offset = "0x5E31A10", VA = "0x185E33210", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x5E32E60", Offset = "0x5E31660", VA = "0x185E32E60", Slot = "15")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(RVA = "0x5E332C0", Offset = "0x5E31AC0", VA = "0x185E332C0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000759")]
	[Cpp2IlInjected.Address(RVA = "0x5E330B0", Offset = "0x5E318B0", VA = "0x185E330B0", Slot = "14")]
	protected override void LJBKLCIPLME(NativeArray<Entity> EFLDIIILPLM, NativeArray<Entity> CAJIJNEMDPK, NativeArray<Entity> INEKPKDGBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075A")]
	[Cpp2IlInjected.Address(RVA = "0x5E32F50", Offset = "0x5E31750", VA = "0x185E32F50")]
	private void JCGOFKBGNCO(NativeArray<Entity> EFLDIIILPLM, NativeArray<Entity> INEKPKDGBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x5E32B70", Offset = "0x5E31370", VA = "0x185E32B70")]
	private void HHJBENLNHDL(Entity MFFDEAINOPL, Entity KBAHLHKKHNA, Entity HFKIDPOPMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075C")]
	[Cpp2IlInjected.Address(RVA = "0x2374100", Offset = "0x2372900", VA = "0x182374100")]
	private bool GBJDFDNKBJP<T>([Out] T IFKKLLBODIE) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x2374190", Offset = "0x2372990", VA = "0x182374190")]
	private void ODFDPMOEIDB<T>(T IFKKLLBODIE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x5E32ED0", Offset = "0x5E316D0", VA = "0x185E32ED0")]
	public bool JALFLLGJIPJ(JEDJBKOCEME LMCDHKKDHBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600075F")]
	[Cpp2IlInjected.Address(RVA = "0x5E331F0", Offset = "0x5E319F0", VA = "0x185E331F0")]
	private static bool NJIIBLNOMOG(JEDJBKOCEME BJOGNNOFADA, JEDJBKOCEME CNJFFPHEPNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000760")]
	[Cpp2IlInjected.Address(RVA = "0x5E333F0", Offset = "0x5E31BF0", VA = "0x185E333F0")]
	public FKIKNFLFAMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal class LDCBJBDJALE : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.Token(Token = "0x6000762")]
	[Cpp2IlInjected.Address(RVA = "0x5E39D20", Offset = "0x5E38520", VA = "0x185E39D20", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000763")]
	[Cpp2IlInjected.Address(RVA = "0x5E39EA0", Offset = "0x5E386A0", VA = "0x185E39EA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000764")]
	[Cpp2IlInjected.Address(RVA = "0x5E39F70", Offset = "0x5E38770", VA = "0x185E39F70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000765")]
	[Cpp2IlInjected.Address(RVA = "0x5E39BE0", Offset = "0x5E383E0", VA = "0x185E39BE0")]
	private NativeArray<Entity> IOFDDGIDGDI(int JEDNJDDHFHB)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000766")]
	[Cpp2IlInjected.Address(RVA = "0x5E39D70", Offset = "0x5E38570", VA = "0x185E39D70")]
	private void MICFLCOLEGC(NativeArray<Entity> CNCFAKBGDJO, NativeArray<Entity> JIGLJFOJFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public LDCBJBDJALE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal class MBINBONCEOM : JMMMDIBDAGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private EntityQuery AMOPJGCFPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private EntityQuery OOFHDFDNLLE;

	[Cpp2IlInjected.Token(Token = "0x6000769")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A480", Offset = "0x5E38C80", VA = "0x185E3A480", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A580", Offset = "0x5E38D80", VA = "0x185E3A580", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public MBINBONCEOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal static class BOPKEOECIJJ
{
	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x21984F0", Offset = "0x2196CF0", VA = "0x1821984F0")]
	public static NativeArray<T> DPPGCPEFEIB<T>(NativeArray<Entity> EFLDIIILPLM, EntityManager DHDOKMIFNAD) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600076D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BA00", Offset = "0x5E2A200", VA = "0x185E2BA00")]
	public static void BHPNKNACINP(EntityQuery PMIADPKJDNK, EntityManager DHDOKMIFNAD, HOKKMAFBPHI BAKIPPCJAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BB90", Offset = "0x5E2A390", VA = "0x185E2BB90")]
	public static void OCPOOEEJIGL(NativeArray<Entity> CNCFAKBGDJO, HOKKMAFBPHI BAKIPPCJAEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BCD0", Offset = "0x5E2A4D0", VA = "0x185E2BCD0")]
	public static void OKLJDGFHAEG(NativeArray<Entity> CNCFAKBGDJO, HOKKMAFBPHI BAKIPPCJAEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal class NFPABIMNCGA : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private JNLNOBGHOEK NBODHKFBPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private ELALIKIJOON PHCBDJMCOIH;

	[Cpp2IlInjected.Token(Token = "0x6000770")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B3C0", Offset = "0x5E39BC0", VA = "0x185E3B3C0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000771")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C000", Offset = "0x5E3A800", VA = "0x185E3C000", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000772")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C0B0", Offset = "0x5E3A8B0", VA = "0x185E3C0B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B560", Offset = "0x5E39D60", VA = "0x185E3B560")]
	private void OBDPKILJGGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B450", Offset = "0x5E39C50", VA = "0x185E3B450")]
	private void LOKJLKHHHNM(NativeArray<Entity> CNCFAKBGDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AAE0", Offset = "0x5E392E0", VA = "0x185E3AAE0")]
	private void GPMNGLKFOFN(NativeArray<Entity> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A640", Offset = "0x5E38E40", VA = "0x185E3A640")]
	private void CPAGEOHLCDL(NativeArray<Entity> JIGLJFOJFHM, NativeArray<RigidTransform> PBGKMOPJJEL, NativeArray<RigidTransform> NABPAJDNAGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BB70", Offset = "0x5E3A370", VA = "0x185E3BB70")]
	private void OGJDDMPCJMI(NativeArray<RigidTransform> NABPAJDNAGP, NativeArray<Entity> JIGLJFOJFHM, NativeList<Entity> BHFNPCKKHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public NFPABIMNCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal class AJHNJEJLFFP : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private EntityQuery IFLAHAKKFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private EntityQuery AAALJKGOHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private NMGHNJPMHGE KBCHPJJCKNB;

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AA40", Offset = "0x5E29240", VA = "0x185E2AA40", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AA90", Offset = "0x5E29290", VA = "0x185E2AA90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2ABF0", Offset = "0x5E293F0", VA = "0x185E2ABF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A9D0", Offset = "0x5E291D0", VA = "0x185E2A9D0")]
	private void FGDPJDKCAPH(EntityQuery PMIADPKJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public AJHNJEJLFFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal class OALEHIHPOGC : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private EntityQuery JEDKENFMCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private IJIBKLNEOBB PELAJIMMKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private ALHOKAPBJCK BCLINPCBGGJ;

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E460", Offset = "0x5E3CC60", VA = "0x185E3E460", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E4F0", Offset = "0x5E3CCF0", VA = "0x185E3E4F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E5A0", Offset = "0x5E3CDA0", VA = "0x185E3E5A0", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000784")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public OALEHIHPOGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal class GPPMPAEHOKI : BCOOFFPOKNI<GJNPBLECJMD>
{
	[Cpp2IlInjected.Token(Token = "0x6000786")]
	[Cpp2IlInjected.Address(RVA = "0x5E54B30", Offset = "0x5E53330", VA = "0x185E54B30", Slot = "14")]
	protected override void LJBKLCIPLME(NativeArray<Entity> EFLDIIILPLM, NativeArray<Entity> CAJIJNEMDPK, NativeArray<Entity> INEKPKDGBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000787")]
	[Cpp2IlInjected.Address(RVA = "0x5E54A60", Offset = "0x5E53260", VA = "0x185E54A60")]
	private static void LJBKLCIPLME(NativeArray<Entity> EFLDIIILPLM, NativeArray<Entity> INEKPKDGBBO, ComponentDataFromEntity<global::KDJGMGHCCEG> FAMLCHCGNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000788")]
	[Cpp2IlInjected.Address(RVA = "0x5E54C90", Offset = "0x5E53490", VA = "0x185E54C90")]
	public GPPMPAEHOKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal abstract class BCOOFFPOKNI<TPlayerTag> : JMMMDIBDAGF where TPlayerTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private EntityQuery AECEHMHBMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private EntityQuery LPGNDGAIMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery MOIEHNGIABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private EntityQuery FOKNHPJIAFB;

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0x45B54D0", Offset = "0x45B3CD0", VA = "0x1845B54D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x45B5710", Offset = "0x45B3F10", VA = "0x1845B5710", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x45B56E0", Offset = "0x45B3EE0", VA = "0x1845B56E0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x45B4F90", Offset = "0x45B3790", VA = "0x1845B4F90")]
	private void MBIJDHFJAOO(EntityQuery PMIADPKJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x45B4700", Offset = "0x45B2F00", VA = "0x1845B4700")]
	private void LAJBDMNBHED(EntityQuery PMIADPKJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x45B43C0", Offset = "0x45B2BC0", VA = "0x1845B43C0")]
	private void ILKCBEBMPCB(EntityQuery PMIADPKJDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract void LJBKLCIPLME(NativeArray<Entity> EFLDIIILPLM, NativeArray<Entity> CAJIJNEMDPK, NativeArray<Entity> INEKPKDGBBO);

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	protected BCOOFFPOKNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct MEPLLMDLCLL : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	public int DIEGBKIOLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	public int PEONAEBENMC;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct BBFIPEEDOGM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public static class DNMEHFGOOND
{
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public static readonly (ComponentType userTag, ComponentType stateTag, ComponentType componentTag)[] EFHGCOACCOO;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal struct LGNDCOENHHH : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct HFLAKNAFJGJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
public class LFAGPDHDJJD : JMMMDIBDAGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	private EntityQuery AMJNELNEKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private ComponentTypes JNIFHPHKEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private NativeParallelHashSet<int> MDDGDDCGLPP;

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x5E58950", Offset = "0x5E57150", VA = "0x185E58950", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x5E58CE0", Offset = "0x5E574E0", VA = "0x185E58CE0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x5E58D60", Offset = "0x5E57560", VA = "0x185E58D60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x5E588B0", Offset = "0x5E570B0", VA = "0x185E588B0")]
	public JobHandle FAMKPJHLIAE(JobHandle AGGDNOGFFOD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public LFAGPDHDJJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public struct NGGKGDENIAN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private NativeArray<KIJOINBMBOF> JOFDCHGDEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private NativeArray<int> CHIAFPKDIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private NativeParallelHashMap<int, KIJOINBMBOF> LDEDPLMHDDD;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public readonly int KLNOILGPFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x7658D0", Offset = "0x7640D0", VA = "0x1807658D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public readonly int BIJONGLKIAM
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0xAE7DE0", Offset = "0xAE65E0", VA = "0x180AE7DE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A810", Offset = "0x5E59010", VA = "0x185E5A810")]
	public NGGKGDENIAN(IReadOnlyCollection<NGLBPOGABCB> DGNAIPANHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A720", Offset = "0x5E58F20", VA = "0x185E5A720")]
	public readonly NBKLCOBNFDK JIDCLJEKFID(int GIBOEKFJFBH)
	{
		return default(NBKLCOBNFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A6A0", Offset = "0x5E58EA0", VA = "0x185E5A6A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
[DefaultMember("Item")]
public readonly struct NBKLCOBNFDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000457")]
	private readonly int GIBOEKFJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000458")]
	private readonly int NOOAFIPHGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private readonly NativeArray<KIJOINBMBOF>.ReadOnly PBFNCDEJLIJ;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public int FPGKKKADJDC
	{
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E59FD0", Offset = "0x5E587D0", VA = "0x185E59FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public BKEMMKOIJJD NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E59F00", Offset = "0x5E58700", VA = "0x185E59F00")]
		get
		{
			return default(BKEMMKOIJJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int LCFILDCKAAF
	{
		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDFF0", Offset = "0x1FBC7F0", VA = "0x181FBDFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public NativeArray<KIJOINBMBOF>.ReadOnly ADBFINOMKPP
	{
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x396EF40", Offset = "0x396D740", VA = "0x18396EF40")]
		get
		{
			return default(NativeArray<KIJOINBMBOF>.ReadOnly);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A000", Offset = "0x5E58800", VA = "0x185E5A000")]
	public NBKLCOBNFDK(int GIBOEKFJFBH, int NOOAFIPHGJN, NativeArray<KIJOINBMBOF>.ReadOnly PBFNCDEJLIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public readonly struct BADIEPHIKLF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public NativeList<Entity> BEAKBDKOLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public NativeList<Entity> HOJJAKIFIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xA70070", Offset = "0xA6E870", VA = "0x180A70070")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public NativeList<byte> AIFMMIMOFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0xD62CB0", Offset = "0xD614B0", VA = "0x180D62CB0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public NativeList<byte> HJMACGNIHPN
	{
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0xD3C790", Offset = "0xD3AF90", VA = "0x180D3C790")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public NativeList<byte> KBJMCNDHECF
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x89E5C0", Offset = "0x89CDC0", VA = "0x18089E5C0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public ComponentType HNBFDMMNEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x762B50", Offset = "0x761350", VA = "0x180762B50")]
		[CompilerGenerated]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public JobHandle EFMELCOCEHF
	{
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x954C40", Offset = "0x953440", VA = "0x180954C40")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public int LCFILDCKAAF
	{
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x954C50", Offset = "0x953450", VA = "0x180954C50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int IHCFANKALND
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x798030", Offset = "0x796830", VA = "0x180798030")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public bool AGHKKDNMMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E4ACC0", Offset = "0x5E494C0", VA = "0x185E4ACC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AD40", Offset = "0x5E49540", VA = "0x185E4AD40")]
	public BADIEPHIKLF(ComponentType ANDCEPJBFFM, JobHandle FJFHMLGEMLM, NativeList<Entity> EFLDIIILPLM, NativeList<Entity> ONHKMEMEABE, NativeList<byte> DFEFIHCOOLD, NativeList<byte> CBFBKLKDEPI, NativeList<byte> PNEGIFOIOOL, int NOOAFIPHGJN, int MPIMAFLNDEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ABA0", Offset = "0x5E493A0", VA = "0x185E4ABA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
internal interface DEJBALFFPBL
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	bool AGHKKDNMMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	NativeArray<KLEIPEFFJCP> AIIFJFMNHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	NativeArray<ALDBGJKBJJO> BKLIBAIDIED
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	NativeArray<KLEIPEFFJCP> FKLENLNOPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ANEHHLOKGCA([Out] NativeArray<int> DHJJNOGPMFH, Allocator OPPHPFNHPMG);

	[Cpp2IlInjected.Token(Token = "0x60007B9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MDLEBHAGIGA(ComponentType ANDCEPJBFFM, [Out] BADIEPHIKLF NFEGOEAFJOL, [Out] NBKLCOBNFDK POCHBOIHANL);

	[Cpp2IlInjected.Token(Token = "0x60007BA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeMultiHashMapAsync<Entity, GKNKBFHFEDD> NGIHMDMEMLC();
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal static class JHKGKMNAAFP
{
	[Cpp2IlInjected.Token(Token = "0x60007BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E561F0", Offset = "0x5E549F0", VA = "0x185E561F0")]
	public static bool OKPJJAKBJNA(this DEJBALFFPBL KAFJGNMGLLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
internal interface POABLKAKLOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	NativeParallelMultiHashMap<Entity, GKNKBFHFEDD> FOFBLLDOGCP
	{
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	uint PNBOCDENAKE
	{
		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GPNKJLPGDJH(NativeArray<KLEIPEFFJCP> BCJPFHDLPBM, NativeArray<ALDBGJKBJJO> PJDHECENIOE, NativeArray<KLEIPEFFJCP> FKAANOOIPEH, int NPHAPNGNOPM);

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NJNEAKIIKHC([In] BADIEPHIKLF HEFBBAAFACO);

	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CDCOIBAMDHM(JobHandle FJFHMLGEMLM);
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
public readonly struct HLANCHOOJIM : IEquatable<HLANCHOOJIM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	private readonly BCJCKPDGHHM LJHGKCLAIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	private readonly int MPIMAFLNDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly int EAMAMACKKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private readonly int JLJAHGBOJGO;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public BCJCKPDGHHM IDAENCJFMOE
	{
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60")]
		get
		{
			return default(BCJCKPDGHHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E55550", Offset = "0x5E53D50", VA = "0x185E55550")]
	public unsafe ReadOnlySpan<byte> GFGEKHLEEFN(void* AOCFEPJENON)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E55320", Offset = "0x5E53B20", VA = "0x185E55320")]
	public unsafe ReadOnlySpan<byte> DIGLDFIHOPM(void* AOCFEPJENON)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(RVA = "0x5CEDA30", Offset = "0x5CEC230", VA = "0x185CEDA30")]
	public HLANCHOOJIM(BCJCKPDGHHM LJHGKCLAIHG, int NBNELMONDLK, int EAMAMACKKPM, int JLJAHGBOJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E554C0", Offset = "0x5E53CC0", VA = "0x185E554C0", Slot = "4")]
	public bool Equals(HLANCHOOJIM GHNNCJBDHKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E553B0", Offset = "0x5E53BB0", VA = "0x185E553B0", Slot = "0")]
	public override bool Equals(object ELOCHLKHPBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E555E0", Offset = "0x5E53DE0", VA = "0x185E555E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public readonly struct GKNKBFHFEDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private readonly BCJCKPDGHHM LJHGKCLAIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private readonly int MPIMAFLNDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private unsafe readonly byte* EAMAMACKKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private unsafe readonly byte* JLJAHGBOJGO;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public BCJCKPDGHHM IDAENCJFMOE
	{
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x98EA60", Offset = "0x98D260", VA = "0x18098EA60")]
		get
		{
			return default(BCJCKPDGHHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public int PHCALFNEHHF
	{
		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x1FBDFF0", Offset = "0x1FBC7F0", VA = "0x181FBDFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public unsafe byte* HIOLIKOOIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x98EAD0", Offset = "0x98D2D0", VA = "0x18098EAD0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public unsafe byte* CNABPFGOAFF
	{
		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E544C0", Offset = "0x5E52CC0", VA = "0x185E544C0")]
	public LELJJGNMHGH DIGLDFIHOPM(Type BJKOKHNAAID)
	{
		return default(LELJJGNMHGH);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x23829C0", Offset = "0x23811C0", VA = "0x1823829C0")]
	public T GFGEKHLEEFN<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x23829A0", Offset = "0x23811A0", VA = "0x1823829A0")]
	public T DIGLDFIHOPM<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E545B0", Offset = "0x5E52DB0", VA = "0x185E545B0")]
	public unsafe GKNKBFHFEDD(BCJCKPDGHHM LJHGKCLAIHG, int NBNELMONDLK, byte* EAMAMACKKPM, byte* JLJAHGBOJGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
public readonly struct BKEMMKOIJJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private readonly int GIBOEKFJFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private readonly int LJHGKCLAIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private readonly KIJOINBMBOF FCJNLPFLEOK;

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public KIJOINBMBOF ECPGDJIPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x98EAD0", Offset = "0x98D2D0", VA = "0x18098EAD0")]
		get
		{
			return default(KIJOINBMBOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AE10", Offset = "0x5E49610", VA = "0x185E4AE10")]
	public BKEMMKOIJJD(int GIBOEKFJFBH, int LJHGKCLAIHG, KIJOINBMBOF FCJNLPFLEOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal abstract class MHKLBPFNJCC : MGKMOGBIDJL, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private AIDABNJGIKJ IEHPDNNDJHE;

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	protected abstract LOJLFKPHDDJ EHLJIPBNICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E595C0", Offset = "0x5E57DC0", VA = "0x185E595C0", Slot = "16")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E59610", Offset = "0x5E57E10", VA = "0x185E59610", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E59220", Offset = "0x5E57A20", VA = "0x185E59220", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	protected MHKLBPFNJCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal class KPKHGGKGIEF : MHKLBPFNJCC
{
	[Cpp2IlInjected.Token(Token = "0x17000105")]
	protected override LOJLFKPHDDJ EHLJIPBNICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x761FD0", Offset = "0x7607D0", VA = "0x180761FD0", Slot = "17")]
		get
		{
			return default(LOJLFKPHDDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E58860", Offset = "0x5E57060", VA = "0x185E58860")]
	public KPKHGGKGIEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal class HEMFLJPAIID : MHKLBPFNJCC
{
	[Cpp2IlInjected.Token(Token = "0x17000106")]
	protected override LOJLFKPHDDJ EHLJIPBNICJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB70", Offset = "0x7DC370", VA = "0x1807DDB70", Slot = "17")]
		get
		{
			return default(LOJLFKPHDDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E54D50", Offset = "0x5E53550", VA = "0x185E54D50")]
	public HEMFLJPAIID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
public class BFFPHDNIJHF : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	[MCMLPKDBFJE]
	private AIDABNJGIKJ DDKPNHBBGNN;

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ADA0", Offset = "0x5E495A0", VA = "0x185E4ADA0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ADF0", Offset = "0x5E495F0", VA = "0x185E4ADF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public BFFPHDNIJHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
[AlwaysUpdateSystem]
public class EOICJCMLAOG : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	public enum BBOFBKFKODJ
	{
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		Create,
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		Remove
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	[MCMLPKDBFJE]
	private AIDABNJGIKJ IEHPDNNDJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	private NBMBHGCGAKF GIMGEGANHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	private JGBJEKFCOPC COLNOFOEICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private CINOCDKFPEM NPHBGDGBDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private CGPAJADOPGL BHJIPDFOMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private CHKFECHCKGI IMHONOAHPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private DBDENFGEPOF CNNCELBIMMG;

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E52220", Offset = "0x5E50A20", VA = "0x185E52220", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E525B0", Offset = "0x5E50DB0", VA = "0x185E525B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E52720", Offset = "0x5E50F20", VA = "0x185E52720", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E520A0", Offset = "0x5E508A0", VA = "0x185E520A0")]
	private void BAGIPCBAOPO([Out] NativeArray<KLEIPEFFJCP> BCJPFHDLPBM, [Out] NativeArray<ALDBGJKBJJO> PJDHECENIOE, [Out] NativeArray<KLEIPEFFJCP> FKAANOOIPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E526D0", Offset = "0x5E50ED0", VA = "0x185E526D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E52630", Offset = "0x5E50E30", VA = "0x185E52630", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public EOICJCMLAOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal readonly struct NBMBHGCGAKF
{
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x400047E")]
	private static readonly ProfilerMarker IMGDALPLKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private readonly JMMMDIBDAGF HKHKOFLAFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private readonly World KLEBCFIAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private readonly EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private readonly EntityQuery GLOIELKHIDH;

	[Cpp2IlInjected.Token(Token = "0x60007E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A570", Offset = "0x5E58D70", VA = "0x185E5A570")]
	public NBMBHGCGAKF(JMMMDIBDAGF HKHKOFLAFNB, World KLEBCFIAAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A010", Offset = "0x5E58810", VA = "0x185E5A010")]
	public (NativeArray<KLEIPEFFJCP>, NativeArray<ALDBGJKBJJO>) HFBGFFHILGI()
	{
		return default((NativeArray<KLEIPEFFJCP>, NativeArray<ALDBGJKBJJO>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct DBDENFGEPOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private static readonly ProfilerMarker IMGDALPLKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private readonly JMMMDIBDAGF HKHKOFLAFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private NativeList<(EntityQuery query, int componentIndex)> ENKAKGBKIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private NativeList<(EntityQuery query, int componentIndex)> ABBDOBMIDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private NativeList<(EntityQuery query, int componentIndex)> GBGMEIFNHKB;

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F970", Offset = "0x5E4E170", VA = "0x185E4F970")]
	public DBDENFGEPOF(JMMMDIBDAGF HKHKOFLAFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EE90", Offset = "0x5E4D690", VA = "0x185E4EE90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EEF0", Offset = "0x5E4D6F0", VA = "0x185E4EEF0")]
	public NativeList<(EntityQuery, int, int, EOICJCMLAOG.BBOFBKFKODJ)> FCDFKJDCMIG(uint FJMGONKDHCM, [Out] int BJMIBEFOMBB)
	{
		return default(NativeList<(EntityQuery, int, int, EOICJCMLAOG.BBOFBKFKODJ)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F670", Offset = "0x5E4DE70", VA = "0x185E4F670")]
	private int LPIHKIKFLHL(EOICJCMLAOG.BBOFBKFKODJ CHDCFCNHAFI, NativeList<(EntityQuery query, int typeIndex)> EJAHENBAJFL, NativeList<(EntityQuery query, int typeIndex, int count, EOICJCMLAOG.BBOFBKFKODJ mode)> FFMHOHOIJJO, uint FJMGONKDHCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F820", Offset = "0x5E4E020", VA = "0x185E4F820")]
	private NativeList<(EntityQuery, int)> MNIDEFPLNLO(NativeParallelHashSet<int> DGNAIPANHEG, int MLNKPBGJFBG)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EDF0", Offset = "0x5E4D5F0", VA = "0x185E4EDF0")]
	private NativeList<(EntityQuery, int)> CEPPOANHMLM(NativeParallelHashSet<int> DGNAIPANHEG, int MLNKPBGJFBG)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F2C0", Offset = "0x5E4DAC0", VA = "0x185E4F2C0")]
	private NativeList<(EntityQuery, int)> KCDIBPCGBNL(NativeParallelHashSet<int> DGNAIPANHEG, int MLNKPBGJFBG, EOICJCMLAOG.BBOFBKFKODJ CHDCFCNHAFI)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EB00", Offset = "0x5E4D300", VA = "0x185E4EB00")]
	private NativeList<(EntityQuery, int)> BAJGHOFBGOC()
	{
		return default(NativeList<(EntityQuery, int)>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal readonly struct CHKFECHCKGI
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[BurstCompile]
	private struct CLNHOKKENMD : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		[ReadOnly]
		public EntityTypeHandle CIDMIKPAGAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		[ReadOnly]
		public ComponentDataFromEntity<MEPLLMDLCLL> DDNACFDBBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		[ReadOnly]
		public DynamicComponentTypeHandle BFBFMIGBIND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> KNAOJFIJNIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> JFJKMHPCADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		[ReadOnly]
		public ComponentDataFromEntity PBDEJDCKEHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		[ReadOnly]
		public NativeArray<byte>.ReadOnly NMJFOHNKPPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		[ReadOnly]
		public NativeArray<KIJOINBMBOF>.ReadOnly MIIACCPIANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public ComponentDataFromEntity NEOGEKPCMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public NativeList<Entity> AOBBFEOHPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public NativeList<Entity> KAJOJCCEAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public NativeList<byte> HOMJIDNLLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public NativeList<byte> OPDHLHIGBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public NativeList<byte> DIJAEEFJLFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public int MPIMAFLNDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int NOOAFIPHGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public bool CMNMNKDFDPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public EOICJCMLAOG.BBOFBKFKODJ CHDCFCNHAFI;

		[Cpp2IlInjected.Token(Token = "0x60007F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E4D420", Offset = "0x5E4BC20", VA = "0x185E4D420", Slot = "4")]
		public void Execute(ArchetypeChunk KIJHCPOKLEK, int AJONNGIJKEF, int LACIPLGAFDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E4D200", Offset = "0x5E4BA00", VA = "0x185E4D200")]
		private unsafe bool BEPKLKBBDFD(Entity KGOCNDELAEH, Entity EDFFKNAJHCL, byte* DGLJHLCNGEP, byte* OGPBKJIDPCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E4D840", Offset = "0x5E4C040", VA = "0x185E4D840")]
		private unsafe void FGACGACICLO(byte* DGLJHLCNGEP, byte* OGPBKJIDPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E4D860", Offset = "0x5E4C060", VA = "0x185E4D860")]
		private unsafe byte* FKDLAGEIAKD(NativeArray<byte> GFGIEECBGJG, int PBGHCEIGALN)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E4D7D0", Offset = "0x5E4BFD0", VA = "0x185E4D7D0")]
		private unsafe byte* FCMKKICDCFN(Entity EDFFKNAJHCL)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E4D930", Offset = "0x5E4C130", VA = "0x185E4D930")]
		private unsafe byte* OKADOHHJEGE(ArchetypeChunk KIJHCPOKLEK)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E4D900", Offset = "0x5E4C100", VA = "0x185E4D900")]
		private static Entity KGPKFHIIKBI([In] MEPLLMDLCLL KOIMDAJNDOD)
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[BurstCompile]
	private struct APFNPHELGDE : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		[ReadOnly]
		public NativeList<Entity> IMEPOEIPKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		[ReadOnly]
		public NativeList<byte> OEBDGKNAJFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		[ReadOnly]
		public NativeList<byte> AMEGCKCNLDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		[ReadOnly]
		public NativeList<byte> HPACMBHCJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		[ReadOnly]
		public NativeArray<KIJOINBMBOF>.ReadOnly MIIACCPIANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public NativeParallelMultiHashMap<Entity, GKNKBFHFEDD> DLLLHMAANLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public int MPIMAFLNDEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int NOOAFIPHGJN;

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A960", Offset = "0x5E49160", VA = "0x185E4A960", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private static readonly ProfilerMarker IMGDALPLKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private readonly JMMMDIBDAGF HKHKOFLAFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private readonly World KLEBCFIAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly NGGKGDENIAN ONIPNDNDBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private readonly NativeParallelHashMap<int, Entity> LGCGEHGHGDI;

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C3A0", Offset = "0x5E4ABA0", VA = "0x185E4C3A0")]
	public CHKFECHCKGI(JMMMDIBDAGF HKHKOFLAFNB, World KLEBCFIAAMH, AIDABNJGIKJ IEHPDNNDJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B590", Offset = "0x5E49D90", VA = "0x185E4B590")]
	public JobHandle HFBGFFHILGI(POABLKAKLOJ KAFJGNMGLLD, NativeList<(EntityQuery query, int typeIndex, int count, EOICJCMLAOG.BBOFBKFKODJ mode)> KOJGLBGNEBF, JobHandle AGGDNOGFFOD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BED0", Offset = "0x5E4A6D0", VA = "0x185E4BED0")]
	private APFNPHELGDE MHCFHDOBMDL([In] CLNHOKKENMD KCGKGEEFAPF, NativeParallelMultiHashMap<Entity, GKNKBFHFEDD> PMAJJLAMDNB)
	{
		return default(APFNPHELGDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BF30", Offset = "0x5E4A730", VA = "0x185E4BF30")]
	private CLNHOKKENMD ODFFMGDCHJI(ComponentType ANDCEPJBFFM, EntityManager IPIIJDFJMMM, int FDPEKLDPLAK, EOICJCMLAOG.BBOFBKFKODJ CHDCFCNHAFI)
	{
		return default(CLNHOKKENMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BD70", Offset = "0x5E4A570", VA = "0x185E4BD70")]
	private static void IAICKNGDPIN(POABLKAKLOJ KAFJGNMGLLD, ComponentType ANDCEPJBFFM, JobHandle LOGMOOGMKPB, [In] CLNHOKKENMD KCGKGEEFAPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal readonly struct CGPAJADOPGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private readonly LFAGPDHDJJD KNLKNCILMBG;

	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private static readonly ProfilerMarker IMGDALPLKBP;

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B050", Offset = "0x5E49850", VA = "0x185E4B050")]
	public CGPAJADOPGL(World KLEBCFIAAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AE20", Offset = "0x5E49620", VA = "0x185E4AE20")]
	public JobHandle HFBGFFHILGI(JobHandle PLEDODNMBPF)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal readonly struct JGBJEKFCOPC
{
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private static readonly ProfilerMarker IMGDALPLKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private readonly JMMMDIBDAGF HKHKOFLAFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private readonly World KLEBCFIAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private readonly EntityQuery OKGPEMCHJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private readonly EntityQuery OJIHHIEAFIH;

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x5E560C0", Offset = "0x5E548C0", VA = "0x185E560C0")]
	public JGBJEKFCOPC(JMMMDIBDAGF HKHKOFLAFNB, World KLEBCFIAAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x5E55AB0", Offset = "0x5E542B0", VA = "0x185E55AB0")]
	public NativeArray<KLEIPEFFJCP> HFBGFFHILGI()
	{
		return default(NativeArray<KLEIPEFFJCP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x5E55C30", Offset = "0x5E54430", VA = "0x185E55C30")]
	public void IOPLOPOFCEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x5E55CD0", Offset = "0x5E544D0", VA = "0x185E55CD0")]
	private NativeArray<KLEIPEFFJCP> KDJJLACMJLH(EntityQuery PMIADPKJDNK)
	{
		return default(NativeArray<KLEIPEFFJCP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal readonly struct CINOCDKFPEM
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[CompilerGenerated]
	private sealed class GPDFMOPDABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public JMMMDIBDAGF system;

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GPDFMOPDABC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x5E54970", Offset = "0x5E53170", VA = "0x185E54970")]
		internal (EntityQuery, ComponentType) GMFLBINIJLC((ComponentType userTag, ComponentType stateTag, ComponentType componentTag) t)
		{
			return default((EntityQuery, ComponentType));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private static readonly ProfilerMarker IMGDALPLKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private readonly JMMMDIBDAGF HKHKOFLAFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private readonly (EntityQuery userTagQuery, ComponentType stateTag)[] CNDMGEKNIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private readonly EntityQuery KHCJBDMALOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private readonly EntityQuery JKKBNLNADHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private readonly ComponentTypes BPIGBGIOLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private readonly ComponentTypes CNCAKMOPFOP;

	[Cpp2IlInjected.Token(Token = "0x6000808")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C7A0", Offset = "0x5E4AFA0", VA = "0x185E4C7A0")]
	public CINOCDKFPEM(JMMMDIBDAGF HKHKOFLAFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000809")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C420", Offset = "0x5E4AC20", VA = "0x185E4C420")]
	public void HFBGFFHILGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal class NMGGFKHPMDJ : JBGPKHEAAKH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	public struct AGAOLMPKEON : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	protected override ComponentType CAAEKKGEAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x5E5AE60", Offset = "0x5E59660", VA = "0x185E5AE60", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	protected override ComponentType DPCLDJNJOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x5E5AE30", Offset = "0x5E59630", VA = "0x185E5AE30", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	protected override ComponentType JOPJHFKNOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x5E5AE00", Offset = "0x5E59600", VA = "0x185E5AE00", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AF20", Offset = "0x5E59720", VA = "0x185E5AF20")]
	public NMGGFKHPMDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal class GLEJAAACLNG : JBGPKHEAAKH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct AIGCJIODPNK : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected override ComponentType CAAEKKGEAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x5E54630", Offset = "0x5E52E30", VA = "0x185E54630", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	protected override ComponentType DPCLDJNJOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x5E54600", Offset = "0x5E52E00", VA = "0x185E54600", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	protected override ComponentType JOPJHFKNOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x5E545D0", Offset = "0x5E52DD0", VA = "0x185E545D0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x5E546F0", Offset = "0x5E52EF0", VA = "0x185E546F0")]
	public GLEJAAACLNG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
public struct PNMIPCPDJFM : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
[CPEPPNMEKPA]
public class COMFJKNHAAL : LDPLANFOAAB
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	private struct JNDABGOBCBB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		[ReadOnly]
		public NativeParallelHashSet<int> KEEHLMBMCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		[ReadOnly]
		public EntityTypeHandle KCNFILFCEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> HOBPCMBEHCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public NativeList<Entity>.ParallelWriter FGHKKMKOHBD;

		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0x5E56660", Offset = "0x5E54E60", VA = "0x185E56660", Slot = "4")]
		public void Execute(ArchetypeChunk KIJHCPOKLEK, int AJONNGIJKEF, int LACIPLGAFDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E590", Offset = "0x5E4CD90", VA = "0x185E4E590", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E620", Offset = "0x5E4CE20", VA = "0x185E4E620", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E540", Offset = "0x5E4CD40", VA = "0x185E4E540")]
	private EntityCommandBufferSystem OBMCFEKMAFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600081E")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public COMFJKNHAAL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	[CPEPPNMEKPA]
	public class DebugPostDeserializeRemoveOrphanedSplinePointsSystem : LDPLANFOAAB
	{
		[Cpp2IlInjected.Token(Token = "0x2000164")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct DebugPostDeserializeRemoveOrphanedSplinePointsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			[ReadOnly]
			public ComponentDataFromEntity<EMEKAFKHOIN> splineDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40004C9")]
			[ReadOnly]
			public ComponentTypeHandle<KFEMMDMNKPE> __pointTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000827")]
			[Cpp2IlInjected.Address(RVA = "0x5E50620", Offset = "0x5E4EE20", VA = "0x185E50620")]
			private void LNNGHEHIOHC(Entity entity, [In][NoAlias] KFEMMDMNKPE point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0x5E50500", Offset = "0x5E4ED00", VA = "0x185E50500", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private EntityQuery DebugPostDeserializeRemoveOrphanedSplinePointsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private ComponentTypeHandle<KFEMMDMNKPE> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x5E508E0", Offset = "0x5E4F0E0", VA = "0x185E508E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x5E50470", Offset = "0x5E4EC70", VA = "0x185E50470")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void LOAKCNBAKGD(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x5E506B0", Offset = "0x5E4EEB0", VA = "0x185E506B0")]
		private EntityCommandBufferSystem OBMCFEKMAFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x5E50330", Offset = "0x5E4EB30", VA = "0x185E50330")]
		private JobHandle KFMKOJDFPIN(EntityCommandBuffer ecb, ComponentDataFromEntity<EMEKAFKHOIN> splineDataRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x5E50700", Offset = "0x5E4EF00", VA = "0x185E50700", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public DebugPostDeserializeRemoveOrphanedSplinePointsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
[CPEPPNMEKPA]
public class JINLHMMMNMO : LDPLANFOAAB
{
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x6000829")]
	[Cpp2IlInjected.Address(RVA = "0x5E56350", Offset = "0x5E54B50", VA = "0x185E56350", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x5E563F0", Offset = "0x5E54BF0", VA = "0x185E563F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x5E56300", Offset = "0x5E54B00", VA = "0x185E56300")]
	private EntityCommandBufferSystem OBMCFEKMAFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public JINLHMMMNMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
[CPEPPNMEKPA]
public class KLBNNOCMEIG : LDPLANFOAAB
{
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x600082E")]
	[Cpp2IlInjected.Address(RVA = "0x5E57DB0", Offset = "0x5E565B0", VA = "0x185E57DB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(RVA = "0x5E57E70", Offset = "0x5E56670", VA = "0x185E57E70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(RVA = "0x5E57D60", Offset = "0x5E56560", VA = "0x185E57D60")]
	private EntityCommandBufferSystem OBMCFEKMAFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000831")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public KLBNNOCMEIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
[UpdateAfter(typeof(COMFJKNHAAL))]
public class NAIFOHOIKHJ : JMMMDIBDAGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private EntityArchetype JNLHIEJAGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x6000833")]
	[Cpp2IlInjected.Address(RVA = "0x5E59C60", Offset = "0x5E58460", VA = "0x185E59C60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(RVA = "0x5E59D80", Offset = "0x5E58580", VA = "0x185E59D80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0x5E59C10", Offset = "0x5E58410", VA = "0x185E59C10")]
	private EntityCommandBufferSystem OBMCFEKMAFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public NAIFOHOIKHJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	internal class PostDeserializeAddSplinePointsToSplinesSystem : JMMMDIBDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000169")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeAddSplinePointsToSplinesSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D4")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D5")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600083E")]
			[Cpp2IlInjected.Address(RVA = "0x5E5B4C0", Offset = "0x5E59CC0", VA = "0x185E5B4C0")]
			private void LNNGHEHIOHC(Entity spline)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0x5E5B410", Offset = "0x5E59C10", VA = "0x185E5B410", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200016A")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeAddSplinePointsToSplinesSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			public EntityCommandBuffer cb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D7")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			[ReadOnly]
			public ComponentTypeHandle<KFEMMDMNKPE> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0x5E5B690", Offset = "0x5E59E90", VA = "0x185E5B690")]
			private void LNNGHEHIOHC(Entity splinePoint, [In][NoAlias] KFEMMDMNKPE splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0x5E5B570", Offset = "0x5E59D70", VA = "0x185E5B570", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private EntityQuery PostDeserializeAddSplinePointsToSplinesSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private EntityQuery PostDeserializeAddSplinePointsToSplinesSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private ComponentTypeHandle<KFEMMDMNKPE> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x5E5BCF0", Offset = "0x5E5A4F0", VA = "0x185E5BCF0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x5E5BDB0", Offset = "0x5E5A5B0", VA = "0x185E5BDB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B990", Offset = "0x5E5A190", VA = "0x185E5B990")]
		private EntityCommandBufferSystem OBMCFEKMAFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B740", Offset = "0x5E59F40", VA = "0x185E5B740")]
		private void NLBKMKOAHPF(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B840", Offset = "0x5E5A040", VA = "0x185E5B840")]
		private void NNONKCJGBAI(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B9E0", Offset = "0x5E5A1E0", VA = "0x185E5B9E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PostDeserializeAddSplinePointsToSplinesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
public class CKFOENINEHG : JMMMDIBDAGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D9")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CEC0", Offset = "0x5E4B6C0", VA = "0x185E4CEC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CF90", Offset = "0x5E4B790", VA = "0x185E4CF90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public CKFOENINEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
internal sealed class HELKKANBGLH : ParentSystemBase<ParentData, PreviousParentData, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x8989C0", Offset = "0x8971C0", VA = "0x1808989C0", Slot = "14")]
	protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc PMIADPKJDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000846")]
	[Cpp2IlInjected.Address(RVA = "0x8989C0", Offset = "0x8971C0", VA = "0x1808989C0", Slot = "15")]
	protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc PMIADPKJDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0x8989C0", Offset = "0x8971C0", VA = "0x1808989C0", Slot = "16")]
	protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc PMIADPKJDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x5E54CD0", Offset = "0x5E534D0", VA = "0x185E54CD0", Slot = "17")]
	protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc PMIADPKJDNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0x5E54D10", Offset = "0x5E53510", VA = "0x185E54D10")]
	public HELKKANBGLH()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	[CPEPPNMEKPA]
	public class PostDeserializeRemoveComponentSerializedVersionDataSystem : JMMMDIBDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C2C0", Offset = "0x5E5AAC0", VA = "0x185E5C2C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C360", Offset = "0x5E5AB60", VA = "0x185E5C360", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C0D0", Offset = "0x5E5A8D0", VA = "0x185E5C0D0")]
		private EntityCommandBufferSystem OBMCFEKMAFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C120", Offset = "0x5E5A920", VA = "0x185E5C120", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PostDeserializeRemoveComponentSerializedVersionDataSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
public class GFPJEFPBCLD : CHDKINHMLOK
{
	[Cpp2IlInjected.Token(Token = "0x6000850")]
	[Cpp2IlInjected.Address(RVA = "0x5E52CC0", Offset = "0x5E514C0", VA = "0x185E52CC0", Slot = "14")]
	protected override EntityCommandBufferSystem OBMCFEKMAFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public GFPJEFPBCLD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	internal class PostDeserializeSortSplinePointsSystem : JMMMDIBDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000170")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			[ReadOnly]
			public ComponentDataFromEntity<GFMNKPOPEDJ> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0x5E5B310", Offset = "0x5E59B10", VA = "0x185E5B310", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000171")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeSortSplinePointsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0x5E5C840", Offset = "0x5E5B040", VA = "0x185E5C840")]
			private void LNNGHEHIOHC(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0x5E5C710", Offset = "0x5E5AF10", VA = "0x185E5C710", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private EntityQuery PostDeserializeSortSplinePointsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CBD0", Offset = "0x5E5B3D0", VA = "0x185E5CBD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C5E0", Offset = "0x5E5ADE0", VA = "0x185E5C5E0")]
		private void IGAGOFPOIJM(OrderComparer comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C8D0", Offset = "0x5E5B0D0", VA = "0x185E5C8D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PostDeserializeSortSplinePointsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	public class PostDeserializeTransformRootsSystem : JMMMDIBDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000173")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeTransformRootsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public ComponentTypeHandle<EBOGGEGJLCM> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000862")]
			[Cpp2IlInjected.Address(RVA = "0x5E488D0", Offset = "0x5E470D0", VA = "0x185E488D0")]
			private void LNNGHEHIOHC([NoAlias] EBOGGEGJLCM data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000863")]
			[Cpp2IlInjected.Address(RVA = "0x5E5D420", Offset = "0x5E5BC20", VA = "0x185E5D420", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000174")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeTransformRootsSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public ComponentTypeHandle<GJGBGBOCFHG> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000864")]
			[Cpp2IlInjected.Address(RVA = "0x5E48B00", Offset = "0x5E47300", VA = "0x185E48B00")]
			private void LNNGHEHIOHC([NoAlias] GJGBGBOCFHG data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0x5E5D4F0", Offset = "0x5E5BCF0", VA = "0x185E5D4F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000175")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeTransformRootsSystem_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public ComponentTypeHandle<JOPODPIMFPC> __authoredPoseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			[ReadOnly]
			public ComponentTypeHandle<EBOGGEGJLCM> __poseTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0x5E48B10", Offset = "0x5E47310", VA = "0x185E48B10")]
			private void LNNGHEHIOHC([NoAlias] JOPODPIMFPC authoredPose, [In][NoAlias] EBOGGEGJLCM pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0x5E5D5C0", Offset = "0x5E5BDC0", VA = "0x185E5D5C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000176")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeTransformRootsSystem_LambdaJob_3_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public ComponentTypeHandle<MNPDEFCLMAK> __authoredScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			[ReadOnly]
			public ComponentTypeHandle<GJGBGBOCFHG> __scaleTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0x5E48B30", Offset = "0x5E47330", VA = "0x185E48B30")]
			private void LNNGHEHIOHC([NoAlias] MNPDEFCLMAK authoredScale, [In][NoAlias] GJGBGBOCFHG scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000869")]
			[Cpp2IlInjected.Address(RVA = "0x5E5D710", Offset = "0x5E5BF10", VA = "0x185E5D710", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private EntityQuery PostDeserializeTransformRootsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private EntityQuery PostDeserializeTransformRootsSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private EntityQuery PostDeserializeTransformRootsSystem_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private EntityQuery PostDeserializeTransformRootsSystem_LambdaJob_3_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private EntityQuery __query_4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private ComponentTypeHandle<EBOGGEGJLCM> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private ComponentTypeHandle<GJGBGBOCFHG> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private ComponentTypeHandle<JOPODPIMFPC> __RecRoom_Components_AuthoredLocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private ComponentTypeHandle<EBOGGEGJLCM> __RecRoom_Components_LocalPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private ComponentTypeHandle<MNPDEFCLMAK> __RecRoom_Components_AuthoredLocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private ComponentTypeHandle<GJGBGBOCFHG> __RecRoom_Components_LocalUniformScaleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E360", Offset = "0x5E5CB60", VA = "0x185E5E360", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CFC0", Offset = "0x5E5B7C0", VA = "0x185E5CFC0")]
		private void DLLCDCJNMEI([In] PKIFHEFFKDB transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CD80", Offset = "0x5E5B580", VA = "0x185E5CD80")]
		private void AOJEBECDKOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D860", Offset = "0x5E5C060", VA = "0x185E5D860")]
		private JobHandle OANHANBCIAL(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D320", Offset = "0x5E5BB20", VA = "0x185E5D320")]
		private JobHandle LGEKCPMODGJ(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D990", Offset = "0x5E5C190", VA = "0x185E5D990")]
		private JobHandle OHCHOCBKLMP(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D1E0", Offset = "0x5E5B9E0", VA = "0x185E5D1E0")]
		private JobHandle GPBINOJFOJF(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DAD0", Offset = "0x5E5C2D0", VA = "0x185E5DAD0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PostDeserializeTransformRootsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
public static class PKLIJBLIGPK
{
	[Cpp2IlInjected.Token(Token = "0x2000179")]
	public interface MFMAALADBKA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017A")]
	public interface PMBPPDBALOB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017B")]
	public class FFJCOHEGMKC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	public class HFJFMHPILOP : PMBPPDBALOB
	{
		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x5E54DA0", Offset = "0x5E535A0", VA = "0x185E54DA0")]
		public HFJFMHPILOP(ComponentType MOHHJLIGFPM, ComponentType EPANKEKMJIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	public class HFLIFBCEGIA : PMBPPDBALOB
	{
		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x301E7C0", Offset = "0x301CFC0", VA = "0x18301E7C0")]
		public HFLIFBCEGIA(ComponentType MOHHJLIGFPM, ComponentType[] EPANKEKMJIG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017E")]
	public class JJFDBHBGNFH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x2504280", Offset = "0x2502A80", VA = "0x182504280")]
	public static PMBPPDBALOB LNNHONMKPFF<TFrom, TTo>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x2504820", Offset = "0x2503020", VA = "0x182504820")]
	public static PMBPPDBALOB PHFBOKJIJKC<TFrom>(params ComponentType[] DNJMIEEELNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
public class FGKOLCKAOLM : KPKFEINJGIH
{
	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	public FGKOLCKAOLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
public class HIHJDIHFINE : LDPLANFOAAB
{
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x5E54E30", Offset = "0x5E53630", VA = "0x185E54E30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x5E54DE0", Offset = "0x5E535E0", VA = "0x185E54DE0")]
	private EntityCommandBufferSystem OBMCFEKMAFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public HIHJDIHFINE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000182")]
	[CompilerGenerated]
	[FGKOLCKAOLM]
	public class PostDeserializeUpgrade_Convert_ObjectPolicyData : EFGOCNDHIGP
	{
		[Cpp2IlInjected.Token(Token = "0x2000183")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeUpgrade_Convert_ObjectPolicyData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			public PBDIHFLGNCO<FCLEDNNGGHE> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			public PBDIHFLGNCO<BNEAPCHKGLI> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			public PBDIHFLGNCO<KDKBMODOHMM> v2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			public PBDIHFLGNCO<PDIICNMBAPL> v3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			public NHHDDGHFHKE<OCPFLEPNLDH> v4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000505")]
			public KDKBMODOHMM v2Default;

			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x5E5FAD0", Offset = "0x5E5E2D0", VA = "0x185E5FAD0")]
			private void LNNGHEHIOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0x5E5FAC0", Offset = "0x5E5E2C0", VA = "0x185E5FAC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		protected override PFECAMNMOCE Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x5E602C0", Offset = "0x5E5EAC0", VA = "0x185E602C0", Slot = "14")]
			get
			{
				return default(PFECAMNMOCE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F8E0", Offset = "0x5E5E0E0", VA = "0x185E5F8E0", Slot = "15")]
		public override IEnumerable<PKLIJBLIGPK.PMBPPDBALOB> KNANINNENCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F220", Offset = "0x5E5DA20", VA = "0x185E5F220", Slot = "16")]
		protected override void DOGCKDDJLED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F080", Offset = "0x5E5D880", VA = "0x185E5F080")]
		private static void DIHJNCILCAE(LAHMBKLGLKC<BNEAPCHKGLI> srcVersion, LAHMBKLGLKC<KDKBMODOHMM> dstVersion, KDKBMODOHMM dstDefault)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F7C0", Offset = "0x5E5DFC0", VA = "0x185E5F7C0")]
		private static void FNLPJCHJENM(LAHMBKLGLKC<KDKBMODOHMM> srcVersion, LAHMBKLGLKC<PDIICNMBAPL> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x5E60190", Offset = "0x5E5E990", VA = "0x185E60190")]
		private static void NAJIFOJHELG(LAHMBKLGLKC<PDIICNMBAPL> srcVersion, LAHMBKLGLKC<OCPFLEPNLDH> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F5A0", Offset = "0x5E5DDA0", VA = "0x185E5F5A0")]
		private JobHandle FFHPDBANNLM(PBDIHFLGNCO<FCLEDNNGGHE> v0, PBDIHFLGNCO<BNEAPCHKGLI> v1, PBDIHFLGNCO<KDKBMODOHMM> v2, PBDIHFLGNCO<PDIICNMBAPL> v3, NHHDDGHFHKE<OCPFLEPNLDH> v4, KDKBMODOHMM v2Default, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PostDeserializeUpgrade_Convert_ObjectPolicyData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[FGKOLCKAOLM]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_OMShapeContainerData : EFGOCNDHIGP
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_OMShapeContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000507")]
			public PBDIHFLGNCO<HBFFLHDCODL> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000508")]
			public NHHDDGHFHKE<MIOJLMEFCJI> v2;

			[Cpp2IlInjected.Token(Token = "0x600088C")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EB60", Offset = "0x5E5D360", VA = "0x185E5EB60")]
			private void LNNGHEHIOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EB50", Offset = "0x5E5D350", VA = "0x185E5EB50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		protected override PFECAMNMOCE Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000884")]
			[Cpp2IlInjected.Address(RVA = "0x5E5EFA0", Offset = "0x5E5D7A0", VA = "0x185E5EFA0", Slot = "14")]
			get
			{
				return default(PFECAMNMOCE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EA90", Offset = "0x5E5D290", VA = "0x185E5EA90", Slot = "15")]
		public override IEnumerable<PKLIJBLIGPK.PMBPPDBALOB> KNANINNENCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E920", Offset = "0x5E5D120", VA = "0x185E5E920", Slot = "16")]
		protected override void DOGCKDDJLED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E850", Offset = "0x5E5D050", VA = "0x185E5E850")]
		private static void DIHJNCILCAE(LAHMBKLGLKC<HBFFLHDCODL> srcVersion, LAHMBKLGLKC<MIOJLMEFCJI> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EE70", Offset = "0x5E5D670", VA = "0x185E5EE70")]
		private JobHandle NMBJNBMKFEL(PBDIHFLGNCO<HBFFLHDCODL> v1, NHHDDGHFHKE<MIOJLMEFCJI> v2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PostDeserializeUpgrade_Convert_OMShapeContainerData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[CPEPPNMEKPA]
	[FGKOLCKAOLM]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data : EFGOCNDHIGP, PKLIJBLIGPK.MFMAALADBKA
	{
		[Cpp2IlInjected.Token(Token = "0x2000187")]
		private struct PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public PBDIHFLGNCO<IFENFPOMENO> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050B")]
			public PBDIHFLGNCO<DKDOAGNPCEP> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.Token(Token = "0x6000896")]
			[Cpp2IlInjected.Address(RVA = "0x5E609E0", Offset = "0x5E5F1E0", VA = "0x185E609E0")]
			private void LNNGHEHIOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000897")]
			[Cpp2IlInjected.Address(RVA = "0x5E609D0", Offset = "0x5E5F1D0", VA = "0x185E609D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		protected override PFECAMNMOCE Log
		{
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0x5E60E00", Offset = "0x5E5F600", VA = "0x185E60E00", Slot = "14")]
			get
			{
				return default(PFECAMNMOCE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x5E608B0", Offset = "0x5E5F0B0", VA = "0x185E608B0", Slot = "15")]
		public override IEnumerable<PKLIJBLIGPK.PMBPPDBALOB> KNANINNENCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x5E603A0", Offset = "0x5E5EBA0", VA = "0x185E603A0", Slot = "16")]
		protected override void DOGCKDDJLED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x5E60720", Offset = "0x5E5EF20", VA = "0x185E60720")]
		private static void HIEMGACPMGO(EJPKIEOECMH<DKDOAGNPCEP> d1, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x5E605D0", Offset = "0x5E5EDD0", VA = "0x185E605D0")]
		private JobHandle EFILBCNEENG(PBDIHFLGNCO<IFENFPOMENO> v0, PBDIHFLGNCO<DKDOAGNPCEP> v1, EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	[FGKOLCKAOLM]
	public class PostDeserializeUpgrade_Convert_SerializeEmbodiedData : EFGOCNDHIGP
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeUpgrade_Convert_SerializeEmbodiedData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public PBDIHFLGNCO<BBFNDHODNEC> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050F")]
			public NHHDDGHFHKE<CAECOJCHBDA> v1;

			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0x5E61250", Offset = "0x5E5FA50", VA = "0x185E61250")]
			private void LNNGHEHIOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0x5E61240", Offset = "0x5E5FA40", VA = "0x185E61240", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		protected override PFECAMNMOCE Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000898")]
			[Cpp2IlInjected.Address(RVA = "0x5E614A0", Offset = "0x5E5FCA0", VA = "0x185E614A0", Slot = "14")]
			get
			{
				return default(PFECAMNMOCE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x5E61180", Offset = "0x5E5F980", VA = "0x185E61180", Slot = "15")]
		public override IEnumerable<PKLIJBLIGPK.PMBPPDBALOB> KNANINNENCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600089A")]
		[Cpp2IlInjected.Address(RVA = "0x5E61010", Offset = "0x5E5F810", VA = "0x185E61010", Slot = "16")]
		protected override void DOGCKDDJLED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089B")]
		[Cpp2IlInjected.Address(RVA = "0x5E60EE0", Offset = "0x5E5F6E0", VA = "0x185E60EE0")]
		private JobHandle BMLBGPBBJPB(PBDIHFLGNCO<BBFNDHODNEC> v0, NHHDDGHFHKE<CAECOJCHBDA> v1, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600089C")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PostDeserializeUpgrade_Convert_SerializeEmbodiedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
[FGKOLCKAOLM]
public class DEEKFEPEJJH : JMMMDIBDAGF, PKLIJBLIGPK.MFMAALADBKA
{
	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public IEnumerable<Type> KPGJJFPFKLF
	{
		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FB70", Offset = "0x5E4E370", VA = "0x185E4FB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FE30", Offset = "0x5E4E630", VA = "0x185E4FE30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FDE0", Offset = "0x5E4E5E0", VA = "0x185E4FDE0")]
	private EntityCommandBufferSystem OBMCFEKMAFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008A4")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public DEEKFEPEJJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
public class AADPOEGLBJP : AHIJAGEHKHI
{
	[Cpp2IlInjected.Token(Token = "0x4000510")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	protected override PFHIKJINKDG ENGEDGKOGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x761FD0", Offset = "0x7607D0", VA = "0x180761FD0", Slot = "15")]
		get
		{
			return default(PFHIKJINKDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A1B0", Offset = "0x5E489B0", VA = "0x185E4A1B0", Slot = "16")]
	protected override void KPMIEGGJELJ(PFHIKJINKDG OJAHFIICKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A420", Offset = "0x5E48C20", VA = "0x185E4A420")]
	private EntityCommandBufferSystem OBMCFEKMAFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A500", Offset = "0x5E48D00", VA = "0x185E4A500")]
	public AADPOEGLBJP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[FGKOLCKAOLM]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Split_ContainerData : JMMMDIBDAGF, PKLIJBLIGPK.MFMAALADBKA
	{
		[Cpp2IlInjected.Token(Token = "0x200018D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeUpgrade_Split_ContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			public NativeArray<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			public NativeArray<NCAJKPBGCJM> v1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			public ComponentTypes newComponents;

			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x5E61790", Offset = "0x5E5FF90", VA = "0x185E61790")]
			private void LNNGHEHIOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0x5E61780", Offset = "0x5E5FF80", VA = "0x185E61780", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private ComponentType[] newComponentTypes;

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E616C0", Offset = "0x5E5FEC0", VA = "0x185E616C0", Slot = "14")]
		public IEnumerable<PKLIJBLIGPK.PMBPPDBALOB> KNANINNENCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E61AC0", Offset = "0x5E602C0", VA = "0x185E61AC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E61A70", Offset = "0x5E60270", VA = "0x185E61A70")]
		private EntityCommandBufferSystem OBMCFEKMAFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E61580", Offset = "0x5E5FD80", VA = "0x185E61580")]
		private JobHandle IEPPAHAPHID(EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<NCAJKPBGCJM> v1Data, ComponentTypes newComponents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E61FA0", Offset = "0x5E607A0", VA = "0x185E61FA0")]
		public PostDeserializeUpgrade_Split_ContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[AlwaysUpdateSystem]
public abstract class EFGOCNDHIGP : JMMMDIBDAGF, PKLIJBLIGPK.MFMAALADBKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private NativeList<EntityQuery> KOJGLBGNEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private bool COPIBMMNIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private EntityCommandBufferSystem EMPKENPAECO;

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	protected bool LGKDCANGALE
	{
		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x55B38F0", Offset = "0x55B20F0", VA = "0x1855B38F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	protected abstract PFECAMNMOCE OPCGADAFALC
	{
		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60008B5")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract IEnumerable<PKLIJBLIGPK.PMBPPDBALOB> KNANINNENCI();

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E51F20", Offset = "0x5E50720", VA = "0x185E51F20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E52040", Offset = "0x5E50840", VA = "0x185E52040", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E51FF0", Offset = "0x5E507F0", VA = "0x185E51FF0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void DOGCKDDJLED();

	[Cpp2IlInjected.Token(Token = "0x60008BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E51ED0", Offset = "0x5E506D0", VA = "0x185E51ED0")]
	protected EntityCommandBufferSystem OBMCFEKMAFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0x224B490", Offset = "0x2249C90", VA = "0x18224B490")]
	protected EntityQuery NIKGMICGCFH<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0x224A790", Offset = "0x2248F90", VA = "0x18224A790")]
	protected PBDIHFLGNCO<T> LDLOFCIEDHL<T>() where T : struct, IComponentData
	{
		return default(PBDIHFLGNCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0x224A680", Offset = "0x2248E80", VA = "0x18224A680")]
	protected NHHDDGHFHKE<T> KJPJJCBDAAE<T>() where T : struct, IComponentData
	{
		return default(NHHDDGHFHKE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BE")]
	[Cpp2IlInjected.Address(RVA = "0x224A400", Offset = "0x2248C00", VA = "0x18224A400")]
	protected static void AHKIIDKOOAE<T1, T2>(EJPKIEOECMH<T1> AEFENLKHOED, EJPKIEOECMH<T2> PGEGKOIBBIJ) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BF")]
	[Cpp2IlInjected.Address(RVA = "0x224A400", Offset = "0x2248C00", VA = "0x18224A400")]
	protected static void AHKIIDKOOAE<T1, T2>(EJPKIEOECMH<T1> AEFENLKHOED, EDILAJGBDIJ<T2> PGEGKOIBBIJ) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C0")]
	[Cpp2IlInjected.Address(RVA = "0x224A340", Offset = "0x2248B40", VA = "0x18224A340")]
	private static void AHKIIDKOOAE<T1, T2>(LAHMBKLGLKC<T1> AEFENLKHOED, LAHMBKLGLKC<T2> PGEGKOIBBIJ) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C1")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	protected EFGOCNDHIGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public abstract class AHIJAGEHKHI : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	protected virtual PFHIKJINKDG ABMFMLGNHHK
	{
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x761FD0", Offset = "0x7607D0", VA = "0x180761FD0", Slot = "14")]
		get
		{
			return default(PFHIKJINKDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	protected virtual PFHIKJINKDG ENGEDGKOGCH
	{
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DDB70", Offset = "0x7DC370", VA = "0x1807DDB70", Slot = "15")]
		get
		{
			return default(PFHIKJINKDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void KPMIEGGJELJ(PFHIKJINKDG OJAHFIICKFC);

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A550", Offset = "0x5E48D50", VA = "0x185E4A550", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A600", Offset = "0x5E48E00", VA = "0x185E4A600")]
	private PFHIKJINKDG PKKKKLICPFG()
	{
		return default(PFHIKJINKDG);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	protected AHIJAGEHKHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class GLJMFIDPFBA : JMMMDIBDAGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private HENEBFIJKAJ EMPKENPAECO;

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E54750", Offset = "0x5E52F50", VA = "0x185E54750", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E54820", Offset = "0x5E53020", VA = "0x185E54820", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CB")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public GLJMFIDPFBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public class CJKJCCHIGIO : JMMMDIBDAGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private HENEBFIJKAJ EMPKENPAECO;

	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CCA0", Offset = "0x5E4B4A0", VA = "0x185E4CCA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CD70", Offset = "0x5E4B570", VA = "0x185E4CD70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public CJKJCCHIGIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
public class LFCFKAGFDAJ : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private HDMGEIDHKCL PEPBPPBDPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E58F10", Offset = "0x5E57710", VA = "0x185E58F10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E58EA0", Offset = "0x5E576A0", VA = "0x185E58EA0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E58FE0", Offset = "0x5E577E0", VA = "0x185E58FE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D2")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public LFCFKAGFDAJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	public class DebugPostLoadValidateNetworkIdSystem : LDPLANFOAAB, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000194")]
		private struct DebugPostLoadValidateNetworkIdSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000526")]
			public NativeParallelHashMap<KLEIPEFFJCP, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000527")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			[ReadOnly]
			public ComponentTypeHandle<PDCKJJIIJLK> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60008D9")]
			[Cpp2IlInjected.Address(RVA = "0x5E50D90", Offset = "0x5E4F590", VA = "0x185E50D90")]
			private void LNNGHEHIOHC(Entity entity, [In] PDCKJJIIJLK networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008DA")]
			[Cpp2IlInjected.Address(RVA = "0x5E50C70", Offset = "0x5E4F470", VA = "0x185E50C70", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private CHHCBHMKOGM networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private EntityQuery DebugPostLoadValidateNetworkIdSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private ComponentTypeHandle<PDCKJJIIJLK> __RecRoom_Components_ObjectNetworkIdComponentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E50C10", Offset = "0x5E4F410", VA = "0x185E50C10", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E51010", Offset = "0x5E4F810", VA = "0x185E51010", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E50B20", Offset = "0x5E4F320", VA = "0x185E50B20")]
		private void ENDEDGFGBCK(NativeParallelHashMap<KLEIPEFFJCP, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E50E10", Offset = "0x5E4F610", VA = "0x185E50E10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public DebugPostLoadValidateNetworkIdSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	public class DebugPostLoadValidateParentDataSystem : LDPLANFOAAB, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		private struct DebugPostLoadValidateParentDataSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400052C")]
			public DebugPostLoadValidateParentDataSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400052D")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400052E")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60008E1")]
			[Cpp2IlInjected.Address(RVA = "0x5E514D0", Offset = "0x5E4FCD0", VA = "0x185E514D0")]
			private void LNNGHEHIOHC(Entity entity, [In] ParentData parentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E2")]
			[Cpp2IlInjected.Address(RVA = "0x5E513B0", Offset = "0x5E4FBB0", VA = "0x185E513B0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private HOKKMAFBPHI objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private EntityQuery DebugPostLoadValidateParentDataSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E51350", Offset = "0x5E4FB50", VA = "0x185E51350", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E51100", Offset = "0x5E4F900", VA = "0x185E51100", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E51100", Offset = "0x5E4F900", VA = "0x185E51100")]
		private void FNMEKHFIMJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E516A0", Offset = "0x5E4FEA0", VA = "0x185E516A0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public DebugPostLoadValidateParentDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E511D0", Offset = "0x5E4F9D0", VA = "0x185E511D0")]
		[CompilerGenerated]
		private void IHDMGNFLACI(Entity entity, [In] ParentData parentData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
public class MIHIOBDEMAE : LDPLANFOAAB, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	private MKHOKPNBAOG EMCGPGCLFIM;

	[Cpp2IlInjected.Token(Token = "0x60008E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E59920", Offset = "0x5E58120", VA = "0x185E59920", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E4")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E5")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public MIHIOBDEMAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
[UpdateBefore(typeof(MNMAOAFFGNF))]
public class MHPEJMGMNNK : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x60008E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E59750", Offset = "0x5E57F50", VA = "0x185E59750", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E59800", Offset = "0x5E58000", VA = "0x185E59800", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public MHPEJMGMNNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class KCGABGMIJIP : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[BurstCompile]
	private struct EBAAMNKOENA : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		[ReadOnly]
		public NativeArray<MAIPOJDJBOO> COAKKBKKDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		[ReadOnly]
		public NativeArray<Entity> EFLDIIILPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public ComponentDataFromEntity HOFNIBIGMBO;

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E518A0", Offset = "0x5E500A0", VA = "0x185E518A0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[BurstCompile]
	private struct CODEFKMKDOP : IJob, INativeDisposable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> JLHCPMOLLHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		[ReadOnly]
		public NativeParallelHashMap<int, EntityArchetype> APJLHEBKMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		[ReadOnly]
		public NativeParallelHashMap<int, int> GGPHAPCIOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> LNOIACGEHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> EBNBOOGJEJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public NativeList<EntityArchetype> OEFOKAAMOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public NativeList<EntityArchetype> NCMKLBAKKBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public NativeList<KIJOINBMBOF> FKLJLDBJLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public NativeList<KIJOINBMBOF> PGBKGIMMDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public NativeList<MAIPOJDJBOO> CGMODEKOOGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public NativeList<ComponentType> APDLHEGDKMF;

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E500", Offset = "0x5E4CD00", VA = "0x185E4E500", Slot = "6")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DB60", Offset = "0x5E4C360", VA = "0x185E4DB60", Slot = "5")]
		public JobHandle Dispose(JobHandle FJFHMLGEMLM)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DD70", Offset = "0x5E4C570", VA = "0x185E4DD70", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E460", Offset = "0x5E4CC60", VA = "0x185E4E460")]
		private int MGDBPDINPIH(KIJOINBMBOF HGAACOGKGJN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E270", Offset = "0x5E4CA70", VA = "0x185E4E270")]
		private bool GMACHCFGJKP(int HKOOPEDJBID, EntityArchetype NFEGHCFMFMB, [Out] EntityArchetype AFNHCDIPKHF, [Out] Entity OJLGDOIOJPJ)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct JFNDFKLEGOH : IComparer<MAIPOJDJBOO>
	{
		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x951350", Offset = "0x94FB50", VA = "0x180951350", Slot = "4")]
		public int Compare(MAIPOJDJBOO GEKAGOANEHP, MAIPOJDJBOO KFCLHHAJEPI)
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[BurstCompile]
	private struct OEOHNLKJCGA : HBKLCMOMIFB<MAIPOJDJBOO, int>
	{
		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xDEA190", Offset = "0xDE8990", VA = "0x180DEA190")]
		public int FKHKJNCPLEN([In] MAIPOJDJBOO PMFLLGPMIME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0xDEA190", Offset = "0xDE8990", VA = "0x180DEA190", Slot = "4")]
		private int EOFEBFKJLCF([In] MAIPOJDJBOO IFKKLLBODIE)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019E")]
	private struct MAIPOJDJBOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public Entity OJLGDOIOJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public KIJOINBMBOF EFLDIIILPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public int IOMABBAOIGO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	private ADDMHAJKGOD KGFLJMCCNLD;

	[Cpp2IlInjected.Token(Token = "0x60008EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E56CD0", Offset = "0x5E554D0", VA = "0x185E56CD0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E575B0", Offset = "0x5E55DB0", VA = "0x185E575B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E57670", Offset = "0x5E55E70", VA = "0x185E57670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E568C0", Offset = "0x5E550C0", VA = "0x185E568C0")]
	private CODEFKMKDOP DCIHHBBBAOK(NativeArray<ArchetypeChunk> NFPPPEBBHPE)
	{
		return default(CODEFKMKDOP);
	}

	[Cpp2IlInjected.Token(Token = "0x60008EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E56740", Offset = "0x5E54F40", VA = "0x185E56740")]
	private void BFLFLIMNPLE(NativeArray<EntityArchetype> NCMKLBAKKBB, NativeArray<KIJOINBMBOF> FKLJLDBJLNC, NativeArray<KIJOINBMBOF> PGBKGIMMDHL, NativeArray<ComponentType> APDLHEGDKMF, NativeArray<ArchetypeChunk> NFPPPEBBHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E56D30", Offset = "0x5E55530", VA = "0x185E56D30")]
	private EntityArchetype LIKPIHCAPLP(EntityArchetype CHFANJFPCAP, NativeArray<ComponentType> APDLHEGDKMF, KIJOINBMBOF FCJNLPFLEOK)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E56FD0", Offset = "0x5E557D0", VA = "0x185E56FD0")]
	private JobHandle NDPCOCEGMKB(NativeList<MAIPOJDJBOO> COAKKBKKDOP, NativeArray<Entity> EFLDIIILPLM, JobHandle AGGDNOGFFOD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E56B00", Offset = "0x5E55300", VA = "0x185E56B00")]
	private JobHandle GDGFGLEMMFK(NativeArray<Entity> EFLDIIILPLM, NativeArray<MAIPOJDJBOO> COAKKBKKDOP, int GIBOEKFJFBH, KIJOINBMBOF FCJNLPFLEOK, JobHandle AGGDNOGFFOD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E56D20", Offset = "0x5E55520", VA = "0x185E56D20")]
	public static bool KFPINEECKMJ(ComponentType ANDCEPJBFFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F3")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public KCGABGMIJIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[UpdateBefore(typeof(KCGABGMIJIP))]
public class MNMAOAFFGNF : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000546")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000547")]
	private MKHOKPNBAOG EMCGPGCLFIM;

	[Cpp2IlInjected.Token(Token = "0x60008FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E59980", Offset = "0x5E58180", VA = "0x185E59980", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E599D0", Offset = "0x5E581D0", VA = "0x185E599D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000900")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public MNMAOAFFGNF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	[PDJDECBPOKH(EOGANNGNDMH.OMRoom)]
	public class PostLoadInitializeNetworkIdSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x20001A1")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostLoadInitializeNetworkIdSystem_LambdaJob_0_Job : IJobEntityBatchWithIndex
		{
			[Cpp2IlInjected.Token(Token = "0x20001A2")]
			public delegate void RunWithoutJobSystem_00000AC1$PostfixBurstDelegate(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20001A3")]
			internal static class RunWithoutJobSystem_00000AC1$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x400055B")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x400055C")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x600091A")]
				[Cpp2IlInjected.Address(RVA = "0x5E681A0", Offset = "0x5E669A0", VA = "0x185E681A0")]
				[BurstDiscard]
				private static void FJILHCAMCOC(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600091B")]
				[Cpp2IlInjected.Address(RVA = "0x5E682D0", Offset = "0x5E66AD0", VA = "0x185E682D0")]
				private static IntPtr LELDEMJJKOF()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x600091C")]
				[Cpp2IlInjected.Address(RVA = "0x5E68430", Offset = "0x5E66C30", VA = "0x185E68430")]
				public static void MGABIKEDEHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600091D")]
				[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
				public static void MJKJMKCCJMD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600091F")]
				[Cpp2IlInjected.Address(RVA = "0x5E67FB0", Offset = "0x5E667B0", VA = "0x185E67FB0")]
				public static void AOLJJLOPFJO(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000554")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000555")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			public NativeParallelHashMap<KLEIPEFFJCP, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public uint playerId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public uint offset;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			public ComponentTypeHandle<PDCKJJIIJLK> __dstValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000914")]
			[Cpp2IlInjected.Address(RVA = "0x5E63360", Offset = "0x5E61B60", VA = "0x185E63360")]
			private void LNNGHEHIOHC(Entity entity, int entityInQueryIndex, [NoAlias] PDCKJJIIJLK dstValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000915")]
			[Cpp2IlInjected.Address(RVA = "0x5E631B0", Offset = "0x5E619B0", VA = "0x185E631B0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000916")]
			[Cpp2IlInjected.Address(RVA = "0x5E62F90", Offset = "0x5E61790", VA = "0x185E62F90")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void DEHIKMNDBAI(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0x5E632F0", Offset = "0x5E61AF0", VA = "0x185E632F0")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void JGJLKPPMPLB(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001A4")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostLoadInitializeNetworkIdSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.Token(Token = "0x20001A5")]
			public delegate void RunWithoutJobSystem_00000AC4$PostfixBurstDelegate(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20001A6")]
			internal static class RunWithoutJobSystem_00000AC4$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000563")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000564")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000926")]
				[Cpp2IlInjected.Address(RVA = "0x5E686D0", Offset = "0x5E66ED0", VA = "0x185E686D0")]
				[BurstDiscard]
				private static void FJILHCAMCOC(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000927")]
				[Cpp2IlInjected.Address(RVA = "0x5E68800", Offset = "0x5E67000", VA = "0x185E68800")]
				private static IntPtr LELDEMJJKOF()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000928")]
				[Cpp2IlInjected.Address(RVA = "0x5E68960", Offset = "0x5E67160", VA = "0x185E68960")]
				public static void MGABIKEDEHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000929")]
				[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
				public static void MJKJMKCCJMD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092B")]
				[Cpp2IlInjected.Address(RVA = "0x5E684E0", Offset = "0x5E66CE0", VA = "0x185E684E0")]
				public static void AOLJJLOPFJO(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400055D")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x400055E")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			public NativeParallelHashMap<KLEIPEFFJCP, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public ComponentTypeHandle<PDCKJJIIJLK> __dstValueTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0x5E63820", Offset = "0x5E62020", VA = "0x185E63820")]
			private void LNNGHEHIOHC(Entity entity, [NoAlias] PDCKJJIIJLK dstValue, [In][NoAlias] OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000921")]
			[Cpp2IlInjected.Address(RVA = "0x5E63610", Offset = "0x5E61E10", VA = "0x185E63610", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000922")]
			[Cpp2IlInjected.Address(RVA = "0x5E633F0", Offset = "0x5E61BF0", VA = "0x185E633F0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void DEHIKMNDBAI(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0x5E637B0", Offset = "0x5E61FB0", VA = "0x185E637B0")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void JGJLKPPMPLB(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001A7")]
		private struct PostLoadInitializeNetworkIdSystem_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			public NativeParallelHashMap<KLEIPEFFJCP, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600092C")]
			[Cpp2IlInjected.Address(RVA = "0x5E639B0", Offset = "0x5E621B0", VA = "0x185E639B0")]
			private void LNNGHEHIOHC(Entity entity, [In] OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600092D")]
			[Cpp2IlInjected.Address(RVA = "0x5E63890", Offset = "0x5E62090", VA = "0x185E63890", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		[MCMLPKDBFJE]
		private CHHCBHMKOGM networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		[MCMLPKDBFJE]
		private MKHOKPNBAOG scenes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private EntityQuery queryAllInScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private EntityQuery queryAllInActiveRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private EntityQuery additiveQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private EntityQuery PostLoadInitializeNetworkIdSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private EntityQuery PostLoadInitializeNetworkIdSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private EntityQuery PostLoadInitializeNetworkIdSystem_LambdaJob_2_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private EntityQuery __query_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private ComponentTypeHandle<PDCKJJIIJLK> __RecRoom_Components_ObjectNetworkIdComponentData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private ComponentTypeHandle<OverrideObjectNetworkIdData> __RecRoom_Components_OverrideObjectNetworkIdData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0x5E629A0", Offset = "0x5E611A0", VA = "0x185E629A0", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x5E64620", Offset = "0x5E62E20", VA = "0x185E64620", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x5E64760", Offset = "0x5E62F60", VA = "0x185E64760", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x5E62170", Offset = "0x5E60970", VA = "0x185E62170")]
		public void BMMMLPHIJOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x5E62220", Offset = "0x5E60A20", VA = "0x185E62220")]
		private void EEIGOFEOIGJ(NativeParallelHashMap<KLEIPEFFJCP, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x5E62B60", Offset = "0x5E61360", VA = "0x185E62B60")]
		private void KNBLDOKGMDK(NativeParallelHashMap<KLEIPEFFJCP, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x5E627F0", Offset = "0x5E60FF0", VA = "0x185E627F0")]
		private void ICGMOHFDCAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x5E63D20", Offset = "0x5E62520", VA = "0x185E63D20")]
		private void OACLODCNJPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x5E62E90", Offset = "0x5E61690", VA = "0x185E62E90")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void LHHCFLEJILJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x5E62EB0", Offset = "0x5E616B0", VA = "0x185E62EB0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void LJDOFNILBBB(NativeParallelHashMap<KLEIPEFFJCP, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x5E62A10", Offset = "0x5E61210", VA = "0x185E62A10")]
		private void JEDFEALEJJH(NativeParallelHashMap<KLEIPEFFJCP, Entity> map, uint playerId, uint offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x5E63AC0", Offset = "0x5E622C0", VA = "0x185E63AC0")]
		private void NHMIANLDNAG(NativeParallelHashMap<KLEIPEFFJCP, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x5E63C30", Offset = "0x5E62430", VA = "0x185E63C30")]
		private void NKMLKCDBKJO(NativeParallelHashMap<KLEIPEFFJCP, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x5E63ED0", Offset = "0x5E626D0", VA = "0x185E63ED0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PostLoadInitializeNetworkIdSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x5E621E0", Offset = "0x5E609E0", VA = "0x185E621E0")]
		public static void CKGJMNGEOFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x5E63E90", Offset = "0x5E62690", VA = "0x185E63E90")]
		public static void OBFFDFFHIPK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	[CompilerGenerated]
	public class PostLoadMoveRootsUnderParentSystem : JMMMDIBDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x5E64D30", Offset = "0x5E63530", VA = "0x185E64D30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x5E64E10", Offset = "0x5E63610", VA = "0x185E64E10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x5E64B90", Offset = "0x5E63390", VA = "0x185E64B90", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PostLoadMoveRootsUnderParentSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	[PDJDECBPOKH(EOGANNGNDMH.OMRoom)]
	public class PostLoadRemapCircuitIdsSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x20001AA")]
		private struct PostLoadRemapCircuitIdsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			public DKFKBKKOBGP remap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			public ComponentTypeHandle<AHDHIINBLLF> __nodeTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0x5E65350", Offset = "0x5E63B50", VA = "0x185E65350")]
			private void LNNGHEHIOHC(AHDHIINBLLF node)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600093A")]
			[Cpp2IlInjected.Address(RVA = "0x5E65280", Offset = "0x5E63A80", VA = "0x185E65280", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		[MCMLPKDBFJE]
		private FBKLHLEKBGM serialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private EntityQuery PostLoadRemapCircuitIdsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private ComponentTypeHandle<AHDHIINBLLF> __RecRoom_Components_ObjectBoardNodeData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x5E65230", Offset = "0x5E63A30", VA = "0x185E65230", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x5E65920", Offset = "0x5E64120", VA = "0x185E65920", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x5E65560", Offset = "0x5E63D60", VA = "0x185E65560")]
		private void NJPIIJPEIGJ(DKFKBKKOBGP remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x5E65640", Offset = "0x5E63E40", VA = "0x185E65640")]
		private void OBLKEIDMNPI(DKFKBKKOBGP remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x5E65720", Offset = "0x5E63F20", VA = "0x185E65720", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PostLoadRemapCircuitIdsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AB")]
public class ILKAAPCBHHG : JMMMDIBDAGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x600093B")]
	[Cpp2IlInjected.Address(RVA = "0x5E55990", Offset = "0x5E54190", VA = "0x185E55990", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093C")]
	[Cpp2IlInjected.Address(RVA = "0x5E55A20", Offset = "0x5E54220", VA = "0x185E55A20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600093D")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public ILKAAPCBHHG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	public class PreSerializeDowngrade_RRObjectPrefabTypeData : JMMMDIBDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x20001AD")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PreSerializeDowngrade_RRObjectPrefabTypeData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			[ReadOnly]
			public SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000575")]
			[ReadOnly]
			public EntityTypeHandle entityTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000576")]
			[ReadOnly]
			public NativeArray<ArchetypeChunk> chunksRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			[ReadOnly]
			public NativeParallelHashMap<int, int> prefabTypeFromIndexRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000578")]
			public GBJOFCHFIAM.DLGBDFJAFMF<ArchetypeChunk, CDJLLOPMEOG<RRObjectPrefabV2Data>> it;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400057A")]
			public NativeList<DKDOAGNPCEP> prefabTypeData;

			[Cpp2IlInjected.Token(Token = "0x6000945")]
			[Cpp2IlInjected.Address(RVA = "0x5E65A90", Offset = "0x5E64290", VA = "0x185E65A90")]
			private void LNNGHEHIOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000946")]
			[Cpp2IlInjected.Address(RVA = "0x5E65A80", Offset = "0x5E64280", VA = "0x185E65A80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private EntityQuery queryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x5E65F40", Offset = "0x5E64740", VA = "0x185E65F40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x5E65FE0", Offset = "0x5E647E0", VA = "0x185E65FE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x5E65D50", Offset = "0x5E64550", VA = "0x185E65D50")]
		private EntityCommandBufferSystem OBMCFEKMAFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x5E669D0", Offset = "0x5E651D0", VA = "0x185E669D0")]
		private JobHandle PCPLBHOJGCN(SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO, EntityTypeHandle entityTypeHandleRO, NativeArray<ArchetypeChunk> chunksRO, NativeParallelHashMap<int, int> prefabTypeFromIndexRO, GBJOFCHFIAM.DLGBDFJAFMF<ArchetypeChunk, CDJLLOPMEOG<RRObjectPrefabV2Data>> it, NativeList<Entity> entities, NativeList<DKDOAGNPCEP> prefabTypeData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x5E65DA0", Offset = "0x5E645A0", VA = "0x185E65DA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PreSerializeDowngrade_RRObjectPrefabTypeData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AE")]
public class AHKAOEJJNJL : JMMMDIBDAGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057B")]
	private EntityQuery OEDFGKIHDDE;

	[Cpp2IlInjected.Token(Token = "0x6000947")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A740", Offset = "0x5E48F40", VA = "0x185E4A740", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000948")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A7D0", Offset = "0x5E48FD0", VA = "0x185E4A7D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000949")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A6F0", Offset = "0x5E48EF0", VA = "0x185E4A6F0")]
	private EntityCommandBufferSystem BELIOBKGBID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094A")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public AHKAOEJJNJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AF")]
[AlwaysUpdateSystem]
public class CMLCMFNBBFK : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x600094B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DA20", Offset = "0x5E4C220", VA = "0x185E4DA20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public CMLCMFNBBFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class ODIHLENJBPH : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x400057C")]
	private static PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private EntityQuery HKBCPKEPJMF;

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AF80", Offset = "0x5E59780", VA = "0x185E5AF80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B200", Offset = "0x5E59A00", VA = "0x185E5B200", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public ODIHLENJBPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public class FNFNHGBFHFG : CHDKINHMLOK
{
	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x5E52C70", Offset = "0x5E51470", VA = "0x185E52C70", Slot = "14")]
	protected override EntityCommandBufferSystem OBMCFEKMAFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public FNFNHGBFHFG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B2")]
	[CompilerGenerated]
	public class PreSerializeSaveNetworkIdsSystem : JMMMDIBDAGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x5E66E00", Offset = "0x5E65600", VA = "0x185E66E00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x5E66E90", Offset = "0x5E65690", VA = "0x185E66E90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x5E66C10", Offset = "0x5E65410", VA = "0x185E66C10")]
		private EntityCommandBufferSystem BELIOBKGBID()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x5E66C60", Offset = "0x5E65460", VA = "0x185E66C60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PreSerializeSaveNetworkIdsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	[CompilerGenerated]
	public class PreSerializeTransformRootsSystem : JMMMDIBDAGF
	{
		[Cpp2IlInjected.Token(Token = "0x20001B4")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PreSerializeTransformRootsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000585")]
			public RigidTransform pose;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000586")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000587")]
			public ComponentTypeHandle<EBOGGEGJLCM> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600095E")]
			[Cpp2IlInjected.Address(RVA = "0x5E49EE0", Offset = "0x5E486E0", VA = "0x185E49EE0")]
			private void LNNGHEHIOHC([NoAlias] EBOGGEGJLCM data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095F")]
			[Cpp2IlInjected.Address(RVA = "0x5E67660", Offset = "0x5E65E60", VA = "0x185E67660", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001B5")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PreSerializeTransformRootsSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000588")]
			public float scale;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000589")]
			public ComponentTypeHandle<GJGBGBOCFHG> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000960")]
			[Cpp2IlInjected.Address(RVA = "0x5E48B00", Offset = "0x5E47300", VA = "0x185E48B00")]
			private void LNNGHEHIOHC([NoAlias] GJGBGBOCFHG data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000961")]
			[Cpp2IlInjected.Address(RVA = "0x5E67730", Offset = "0x5E65F30", VA = "0x185E67730", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private EntityQuery PreSerializeTransformRootsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private EntityQuery PreSerializeTransformRootsSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private EntityQuery __query_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private ComponentTypeHandle<EBOGGEGJLCM> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private ComponentTypeHandle<GJGBGBOCFHG> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x5E67CD0", Offset = "0x5E664D0", VA = "0x185E67CD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x5E67440", Offset = "0x5E65C40", VA = "0x185E67440")]
		private void DLLCDCJNMEI([In] PKIFHEFFKDB transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x5E67210", Offset = "0x5E65A10", VA = "0x185E67210")]
		private JobHandle BLJPJPMCFGO(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x5E67340", Offset = "0x5E65B40", VA = "0x185E67340")]
		private JobHandle CMJGAEJOGCD(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x5E67800", Offset = "0x5E66000", VA = "0x185E67800", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public PreSerializeTransformRootsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
[AlwaysUpdateSystem]
public class KOLJCFGCCAJ : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x400058A")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x5E580D0", Offset = "0x5E568D0", VA = "0x185E580D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000963")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public KOLJCFGCCAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public static class GKDJIBFACBJ
{
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	[BurstCompile]
	private struct IGBMNBNMKFK : IJob, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[ReadOnly]
		public NativeParallelHashSet<int> BEICPOHMCNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> LNOIACGEHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public NativeList<EntityArchetype> FJNNPDDPKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public NativeList<KIJOINBMBOF> FKLJLDBJLNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public NativeList<KIJOINBMBOF> PGBKGIMMDHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public NativeList<ComponentType> CLIKCMDOJBL;

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x5E556E0", Offset = "0x5E53EE0", VA = "0x185E556E0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x5E55650", Offset = "0x5E53E50", VA = "0x185E55650", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x5E52F50", Offset = "0x5E51750", VA = "0x185E52F50")]
	public static NativeParallelHashSet<int> GCCIOAPIEFD(Allocator OPPHPFNHPMG)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x5E54140", Offset = "0x5E52940", VA = "0x185E54140")]
	public static NativeParallelHashSet<int> OCOJDOCPOHM(Allocator OPPHPFNHPMG)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x5E534D0", Offset = "0x5E51CD0", VA = "0x185E534D0")]
	private static void LMFCHALLOFC(NativeParallelHashSet<int> GAAKFFCHNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x5E533F0", Offset = "0x5E51BF0", VA = "0x185E533F0")]
	private static bool IPAJLAKAEHC(Type BJKOKHNAAID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x5E54280", Offset = "0x5E52A80", VA = "0x185E54280")]
	private static void PHNIKHIBFIF(NativeParallelHashSet<int> GAAKFFCHNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096A")]
	[Cpp2IlInjected.Address(RVA = "0x5E53010", Offset = "0x5E51810", VA = "0x185E53010")]
	private static void GFDCBHFJBBB(NativeParallelHashSet<int> GAAKFFCHNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x5E52D10", Offset = "0x5E51510", VA = "0x185E52D10")]
	private static void DOHFGOJEFEO(NativeParallelHashSet<int> GAAKFFCHNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x5E53840", Offset = "0x5E52040", VA = "0x185E53840")]
	public static void NACBJEDGGAA(EntityManager DHDOKMIFNAD, EntityQuery PMIADPKJDNK, NativeParallelHashSet<int> MDDGDDCGLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x5E53250", Offset = "0x5E51A50", VA = "0x185E53250")]
	public static void HMHOGJINCBF(EntityManager DHDOKMIFNAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public static class ECCNBMCHIHB
{
	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x5E51B70", Offset = "0x5E50370", VA = "0x185E51B70")]
	public static NativeParallelHashSet<int> NPLDAHFDKMH(EntityManager DHDOKMIFNAD, Allocator OPPHPFNHPMG)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(RVA = "0x5E519B0", Offset = "0x5E501B0", VA = "0x185E519B0")]
	public static NativeParallelHashMap<int, int> HGICPMOPFNO(EntityManager DHDOKMIFNAD, Allocator OPPHPFNHPMG)
	{
		return default(NativeParallelHashMap<int, int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BA")]
public abstract class CHDKINHMLOK : JMMMDIBDAGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000591")]
	private EntityQuery PMIADPKJDNK;

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract EntityCommandBufferSystem OBMCFEKMAFA();

	[Cpp2IlInjected.Token(Token = "0x6000973")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B0B0", Offset = "0x5E498B0", VA = "0x185E4B0B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000974")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B140", Offset = "0x5E49940", VA = "0x185E4B140", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000975")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	protected CHDKINHMLOK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public struct FKJPGKOAOKP : GJHKKGKBNAO<ParentData>
{
	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x5E52C40", Offset = "0x5E51440", VA = "0x185E52C40", Slot = "4")]
	public bool HJPENCIBILD(ParentData IFKKLLBODIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
[BurstCompile]
public struct CDJLLOPMEOG<T> : IEqualityComparer<ArchetypeChunk> where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000592")]
	[ReadOnly]
	public SharedComponentTypeHandle<T> EBNBOOGJEJD;

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(RVA = "0x1614A00", Offset = "0x1613200", VA = "0x181614A00")]
	public CDJLLOPMEOG(SharedComponentTypeHandle<T> EBNBOOGJEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A0A0", Offset = "0x4A488A0", VA = "0x184A4A0A0", Slot = "4")]
	public bool Equals(ArchetypeChunk GEKAGOANEHP, ArchetypeChunk KFCLHHAJEPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x4A4A1A0", Offset = "0x4A489A0", VA = "0x184A4A1A0", Slot = "5")]
	public int GetHashCode(ArchetypeChunk KIJHCPOKLEK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public struct EDILAJGBDIJ<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private LAHMBKLGLKC<T> OJAHFIICKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	private EntityCommandBuffer KGGEMAPLOML;

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF620", Offset = "0x2FDDE20", VA = "0x182FDF620")]
	public EDILAJGBDIJ(LAHMBKLGLKC<T> OJAHFIICKFC, EntityCommandBuffer KGGEMAPLOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x2FDEF50", Offset = "0x2FDD750", VA = "0x182FDEF50", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x2FDEF30", Offset = "0x2FDD730", VA = "0x182FDEF30")]
	public static LAHMBKLGLKC<T> DAOGIJOJDNF(EDILAJGBDIJ<T> LONCAANPFDA)
	{
		return default(LAHMBKLGLKC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public struct NHHDDGHFHKE<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private LCJPMHGEFPB<T> OJAHFIICKFC;

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x3CA21C0", Offset = "0x3CA09C0", VA = "0x183CA21C0")]
	public NHHDDGHFHKE(LCJPMHGEFPB<T> OJAHFIICKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x3CA20D0", Offset = "0x3CA08D0", VA = "0x183CA20D0")]
	public EDILAJGBDIJ<T> GANMBGKAJHN()
	{
		return default(EDILAJGBDIJ<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public struct EJPKIEOECMH<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private LAHMBKLGLKC<T> OJAHFIICKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private EntityCommandBuffer KGGEMAPLOML;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public LAHMBKLGLKC<T> KDKFABGCEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600097F")]
		[Cpp2IlInjected.Address(RVA = "0x2FDEF30", Offset = "0x2FDD730", VA = "0x182FDEF30")]
		get
		{
			return default(LAHMBKLGLKC<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x2FDF620", Offset = "0x2FDDE20", VA = "0x182FDF620")]
	public EJPKIEOECMH(LAHMBKLGLKC<T> OJAHFIICKFC, EntityCommandBuffer KGGEMAPLOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x30105A0", Offset = "0x300EDA0", VA = "0x1830105A0")]
	public void MPOELINPGAA(LCJPMHGEFPB<T> ANIEIGALBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x30104A0", Offset = "0x300ECA0", VA = "0x1830104A0", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x2FDEF30", Offset = "0x2FDD730", VA = "0x182FDEF30")]
	public static LAHMBKLGLKC<T> DAOGIJOJDNF(EJPKIEOECMH<T> LONCAANPFDA)
	{
		return default(LAHMBKLGLKC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public struct PBDIHFLGNCO<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private LCJPMHGEFPB<T> OJAHFIICKFC;

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0x3CA21C0", Offset = "0x3CA09C0", VA = "0x183CA21C0")]
	public PBDIHFLGNCO(LCJPMHGEFPB<T> OJAHFIICKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0x3E5DD70", Offset = "0x3E5C570", VA = "0x183E5DD70")]
	public EJPKIEOECMH<T> GCOFJJNLALH()
	{
		return default(EJPKIEOECMH<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
[DefaultMember("Item")]
public struct LAHMBKLGLKC<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	public NativeList<Entity> EFLDIIILPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059A")]
	public NativeList<T> KOIMDAJNDOD;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public int FPGKKKADJDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(RVA = "0x39787D0", Offset = "0x3976FD0", VA = "0x1839787D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public (Entity entity, T value) NNPCILAHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000987")]
		[Cpp2IlInjected.Address(RVA = "0x3978610", Offset = "0x3976E10", VA = "0x183978610")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x39789E0", Offset = "0x39771E0", VA = "0x1839789E0")]
	public void EIGFNHEIDIC(Entity MFFDEAINOPL, T IFKKLLBODIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x3978EC0", Offset = "0x39776C0", VA = "0x183978EC0")]
	public void JMFGBJLLADB(NativeArray<Entity> MFFDEAINOPL, NativeArray<T> IFKKLLBODIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
public struct LCJPMHGEFPB<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	[ReadOnly]
	public EntityQueryInJob PMIADPKJDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	[ReadOnly]
	public EntityTypeHandle BMJAHCEGCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	[ReadOnly]
	public ComponentTypeHandle<T> OCGIMADNLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	[WriteOnly]
	public EntityCommandBuffer KGGEMAPLOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	public AllocatorManager.AllocatorHandle OPPHPFNHPMG;

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x397BC70", Offset = "0x397A470", VA = "0x18397BC70")]
	public LAHMBKLGLKC<T> GANMBGKAJHN()
	{
		return default(LAHMBKLGLKC<T>);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
	internal class SplinePointOrderingUpdateSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x20001C4")]
		[BurstCompile]
		private struct UpdateSplineIndexJob : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A3")]
			[ReadOnly]
			public NativeArray<global::BCBKIBEKOLB> indexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A4")]
			[ReadOnly]
			public ComponentDataFromEntity<KFEMMDMNKPE> splinePointParentDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A5")]
			public ComponentDataFromEntity<GFMNKPOPEDJ> splinePointOrderDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0x5E6A8B0", Offset = "0x5E690B0", VA = "0x185E6A8B0", Slot = "4")]
			public void Execute(int i)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C5")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			[ReadOnly]
			public ComponentDataFromEntity<GFMNKPOPEDJ> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0x5E5B390", Offset = "0x5E59B90", VA = "0x185E5B390", Slot = "4")]
			public int Compare(Entity x, Entity y)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C6")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SplinePointOrderingUpdateSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public OrderComparer comparer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005A9")]
			[ReadOnly]
			public EntityTypeHandle __splineTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40005AA")]
			public BufferTypeHandle<LinkedEntityGroup> __bufferTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000995")]
			[Cpp2IlInjected.Address(RVA = "0x5E69190", Offset = "0x5E67990", VA = "0x185E69190")]
			private void LNNGHEHIOHC(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000996")]
			[Cpp2IlInjected.Address(RVA = "0x5E69060", Offset = "0x5E67860", VA = "0x185E69060", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private EntityQuery needsUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		[MCMLPKDBFJE]
		private JFFIINNEBJC singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private EntityQuery SplinePointOrderingUpdateSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x5E68ED0", Offset = "0x5E676D0", VA = "0x185E68ED0", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x5E69590", Offset = "0x5E67D90", VA = "0x185E69590", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098D")]
		[Cpp2IlInjected.Address(RVA = "0x5E68B40", Offset = "0x5E67340", VA = "0x185E68B40")]
		private void EHGFKJNEADE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0x5E69220", Offset = "0x5E67A20", VA = "0x185E69220")]
		private void MJFHBAJJFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098F")]
		[Cpp2IlInjected.Address(RVA = "0x5E68F20", Offset = "0x5E67720", VA = "0x185E68F20")]
		private static OBANPEKKDOK JEIHFJLNIDK(int insertionIndex, ComponentDataFromEntity<GFMNKPOPEDJ> splinePointOrderDataRO, NativeArray<Entity> children)
		{
			return default(OBANPEKKDOK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x5E68A10", Offset = "0x5E67210", VA = "0x185E68A10")]
		private JobHandle ANCKEIAEFFC(OrderComparer comparer, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x5E69380", Offset = "0x5E67B80", VA = "0x185E69380", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public SplinePointOrderingUpdateSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
	internal class SplinePointParentChangedSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x20001C8")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SplinePointParentChangedSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			public DynamicBuffer<global::BCBKIBEKOLB> splineIndexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			[ReadOnly]
			public ComponentTypeHandle<KFEMMDMNKPE> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009A1")]
			[Cpp2IlInjected.Address(RVA = "0x5E8B580", Offset = "0x5E89D80", VA = "0x185E8B580")]
			private void LNNGHEHIOHC(Entity splinePoint, [In][NoAlias] KFEMMDMNKPE splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A2")]
			[Cpp2IlInjected.Address(RVA = "0x5E8B460", Offset = "0x5E89C60", VA = "0x185E8B460", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001C9")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SplinePointParentChangedSystem_LambdaJob_1_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			[ReadOnly]
			public ComponentTypeHandle<global::OFNMDFMFFDD> __splinePointParentSystemDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009A3")]
			[Cpp2IlInjected.Address(RVA = "0x5E8B7F0", Offset = "0x5E89FF0", VA = "0x185E8B7F0")]
			private void LNNGHEHIOHC(Entity splinePoint, [In][NoAlias] global::OFNMDFMFFDD splinePointParentSystemData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E8B6D0", Offset = "0x5E89ED0", VA = "0x185E8B6D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private EntityQuery needsAdd;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private EntityQuery needsRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		[MCMLPKDBFJE]
		private JFFIINNEBJC singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private ComponentTypeHandle<KFEMMDMNKPE> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private ComponentTypeHandle<global::OFNMDFMFFDD> __RecRoom_Components_SplinePointParentSystemData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x5E69D30", Offset = "0x5E68530", VA = "0x185E69D30", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A2B0", Offset = "0x5E68AB0", VA = "0x185E6A2B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A2A0", Offset = "0x5E68AA0", VA = "0x185E6A2A0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x5E69AF0", Offset = "0x5E682F0", VA = "0x185E69AF0")]
		private void DENPMDFEAFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x5E696F0", Offset = "0x5E67EF0", VA = "0x185E696F0")]
		private void CPHGLMKKKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x5E69EB0", Offset = "0x5E686B0", VA = "0x185E69EB0")]
		private EntityCommandBufferSystem OBMCFEKMAFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x5E699A0", Offset = "0x5E681A0", VA = "0x185E699A0")]
		private JobHandle DCHMNCJJDJN(EntityCommandBuffer ecb, DynamicBuffer<global::BCBKIBEKOLB> splineIndexUpdatesRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x5E69D80", Offset = "0x5E68580", VA = "0x185E69D80")]
		private JobHandle LPEJCEDCGOO(BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x5E69F00", Offset = "0x5E68700", VA = "0x185E69F00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public SplinePointParentChangedSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal sealed class CGKPBDEGFLP : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E70200", Offset = "0x5E6EA00", VA = "0x185E70200", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public CGKPBDEGFLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal sealed class LEHHIOPGFND : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C900", Offset = "0x5E7B100", VA = "0x185E7C900", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public LEHHIOPGFND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal sealed class GEKLICILHGD : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E758F0", Offset = "0x5E740F0", VA = "0x185E758F0", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public GEKLICILHGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal sealed class DKFFDMFCOMD : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E72C00", Offset = "0x5E71400", VA = "0x185E72C00", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public DKFFDMFCOMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal sealed class JKEOEIKECII : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AB20", Offset = "0x5E79320", VA = "0x185E7AB20", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public JKEOEIKECII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal sealed class NPLJLNEPAGH : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x60009AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E83C80", Offset = "0x5E82480", VA = "0x185E83C80", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public NPLJLNEPAGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[ExecuteAlways]
public class HBMKPOBNCFN : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009B1")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	public HBMKPOBNCFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal sealed class LECKJIDEJOJ : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x60009B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E7BDC0", Offset = "0x5E7A5C0", VA = "0x185E7BDC0", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public LECKJIDEJOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
internal class DEIJHMCOCCG : MNKKMIDHEPO
{
	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public DEIJHMCOCCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal sealed class NHADIFOFNED : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E80480", Offset = "0x5E7EC80", VA = "0x185E80480", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public NHADIFOFNED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
internal class LDCPDJAFBPB : MNKKMIDHEPO
{
	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public LDCPDJAFBPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
internal class HICBMGOOAIN : MNKKMIDHEPO
{
	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public HICBMGOOAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
public sealed class BAFALPCGAFM : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x60009B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F3B0", Offset = "0x5E6DBB0", VA = "0x185E6F3B0", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public BAFALPCGAFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
[ExecuteAlways]
public class HENEBFIJKAJ : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	public HENEBFIJKAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public class FOCLPKBABAF : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BD")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public FOCLPKBABAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
[CPEPPNMEKPA]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public class EKDHNFNIDCJ : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private FCENJDFCEED DGICCKHKNOD;

	[Cpp2IlInjected.Token(Token = "0x60009BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E73020", Offset = "0x5E71820", VA = "0x185E73020", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E73070", Offset = "0x5E71870", VA = "0x185E73070", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C0")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public EKDHNFNIDCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public class MDGEFMNNOJC : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x20001DB")]
	[BurstCompile]
	private struct FIONOKHKNGO : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		[ReadOnly]
		public NativeArray<Entity> EFLDIIILPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<EBOGGEGJLCM> AECGBIELJCP;

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E74B20", Offset = "0x5E73320", VA = "0x185E74B20", Slot = "4")]
		public void Execute(int ADMJKDLHPCI, TransformAccess KHFCFAPNPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E74CF0", Offset = "0x5E734F0", VA = "0x185E74CF0")]
		private bool IDFFEDKFLHB(float3 NIGNLJEOLLK, float3 HCFJKNGNHKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E74D20", Offset = "0x5E73520", VA = "0x185E74D20")]
		private bool JBFIJDLAGFA(quaternion NIGNLJEOLLK, quaternion HCFJKNGNHKA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001DC")]
	[BurstCompile]
	private struct OMLMMJLMOMI : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		[ReadOnly]
		public NativeArray<Entity> EFLDIIILPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<GJGBGBOCFHG> CHPEBFHNCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<NGEJJJHGHFP> LKCKJEKAHEO;

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E84830", Offset = "0x5E83030", VA = "0x185E84830", Slot = "4")]
		public void Execute(int ADMJKDLHPCI, TransformAccess KHFCFAPNPDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005BA")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private static readonly PFECAMNMOCE BNIKBCKKFMH;

	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private static readonly PFECAMNMOCE MNLEJEELKFH;

	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private static readonly PFECAMNMOCE DDBEAIOPLLD;

	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private static readonly ProfilerMarker DBEPMCDIOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private GMOCDIHCHDI FFAIKFNPLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.Token(Token = "0x60009C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DB20", Offset = "0x5E7C320", VA = "0x185E7DB20", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DB90", Offset = "0x5E7C390", VA = "0x185E7DB90", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DBD0", Offset = "0x5E7C3D0", VA = "0x185E7DBD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public MDGEFMNNOJC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001DD")]
	[CompilerGenerated]
	[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
	public class RegisterTransformsSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x20001DE")]
		private struct RegisterTransformsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005CE")]
			public RegisterTransformsSystem __this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005CF")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40005D0")]
			[ReadOnly]
			public ComponentTypeHandle<GNDAAOKLOHL> __arrayIndexTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D1")]
			public ComponentTypeHandle<Transform> __transformTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x5E8A350", Offset = "0x5E88B50", VA = "0x185E8A350")]
			private void OriginalLambdaBody(Entity entity, [In] GNDAAOKLOHL arrayIndex, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009D9")]
			[Cpp2IlInjected.Address(RVA = "0x5E8A160", Offset = "0x5E88960", VA = "0x185E8A160", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private GMOCDIHCHDI embodiedTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private EntityQuery allTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private EntityQuery addNewTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private EntityQuery removeOldTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private EntityQuery clearTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private EntityQuery RegisterTransformsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private ComponentTypeHandle<GNDAAOKLOHL> __RecRoom_Components_TransformAccessArrayIndexData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A110", Offset = "0x5E88910", VA = "0x185E8A110", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A660", Offset = "0x5E88E60", VA = "0x185E8A660", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A930", Offset = "0x5E89130", VA = "0x185E8A930", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E89D20", Offset = "0x5E88520", VA = "0x185E89D20")]
		private void AddTransforms(EntityQuery query, HALHEDPAIEJ accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E8AC40", Offset = "0x5E89440", VA = "0x185E8AC40")]
		private void RemoveTransforms(EntityQuery query, HALHEDPAIEJ accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A8A0", Offset = "0x5E890A0", VA = "0x185E8A8A0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x5E89BC0", Offset = "0x5E883C0", VA = "0x185E89BC0")]
		private void AddNewTransforms(NativeArray<Entity> entities, HALHEDPAIEJ accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x5E8AA20", Offset = "0x5E89220", VA = "0x185E8AA20")]
		internal static void RemoveOldTransforms(NativeArray<GNDAAOKLOHL> arrayIndices, ComponentDataFromEntity<GNDAAOKLOHL> transformAccess, HALHEDPAIEJ accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
		private static void DebugLogRemove(int index, HALHEDPAIEJ accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x5E89FC0", Offset = "0x5E887C0", VA = "0x185E89FC0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DebugLogUninitializedTransformAccessArrayIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x5E89FC0", Offset = "0x5E887C0", VA = "0x185E89FC0")]
		private void RegisterTransformsSystem_LambdaJob_0_Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A460", Offset = "0x5E88C60", VA = "0x185E8A460", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public RegisterTransformsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public class ABCALKPFOFC : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x20001E1")]
	[BurstCompile]
	private struct FMFFOEHGFDH : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		[ReadOnly]
		public ComponentDataFromEntity<EBOGGEGJLCM> AECGBIELJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		[ReadOnly]
		public NativeArray<Entity> EFLDIIILPLM;

		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E74F30", Offset = "0x5E73730", VA = "0x185E74F30", Slot = "4")]
		public void Execute(int ADMJKDLHPCI, TransformAccess KHFCFAPNPDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001E2")]
	[BurstCompile]
	private struct OMEPLCAPDCP : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		[ReadOnly]
		public ComponentDataFromEntity<GJGBGBOCFHG> CHPEBFHNCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		[ReadOnly]
		public NativeArray<Entity> EFLDIIILPLM;

		[Cpp2IlInjected.Token(Token = "0x60009E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E84600", Offset = "0x5E82E00", VA = "0x185E84600", Slot = "4")]
		public void Execute(int ADMJKDLHPCI, TransformAccess KHFCFAPNPDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001E3")]
	[BurstCompile]
	private struct GCAEDKOHEBN : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		[ReadOnly]
		public ComponentDataFromEntity<GJGBGBOCFHG> CHPEBFHNCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		[ReadOnly]
		public ComponentDataFromEntity<NGEJJJHGHFP> LKCKJEKAHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		[ReadOnly]
		public NativeArray<Entity> EFLDIIILPLM;

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E75010", Offset = "0x5E73810", VA = "0x185E75010", Slot = "4")]
		public void Execute(int ADMJKDLHPCI, TransformAccess KHFCFAPNPDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005D3")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x40005D4")]
	private static readonly PFECAMNMOCE BNIKBCKKFMH;

	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private static readonly PFECAMNMOCE MNLEJEELKFH;

	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private static readonly PFECAMNMOCE DDBEAIOPLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	private GMOCDIHCHDI FFAIKFNPLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	private EntityQuery CBLFCLKAAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	private EntityQuery KOPNDCDMBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private EntityQuery FNJHBCEPNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private TransformAccessArray MKJNELCNBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private TransformAccessArray LKDAGPNKCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private TransformAccessArray JAHONLPFABJ;

	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B680", Offset = "0x5E69E80", VA = "0x185E6B680", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B850", Offset = "0x5E6A050", VA = "0x185E6B850", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BA60", Offset = "0x5E6A260", VA = "0x185E6BA60", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BAF0", Offset = "0x5E6A2F0", VA = "0x185E6BAF0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BB20", Offset = "0x5E6A320", VA = "0x185E6BB20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B6D0", Offset = "0x5E69ED0", VA = "0x185E6B6D0")]
	private NativeArray<Entity> LOCDJKKKEEA(NativeArray<GNDAAOKLOHL> MBBDMHFOIDN, NativeList<Entity> CHHLCPHPEKC, TransformAccessArray NHIGAAJKMFC, TransformAccessArray KKCOFDDFFGO)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public ABCALKPFOFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public class NNNJGEIFBNJ : JMMMDIBDAGF, OLNFMJBKLAF
{
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private BJLOGACOAIO IIEAMEFDFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private LIEABLACGCP BPOHGAPJJAB;

	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E5A0", Offset = "0x5E3CDA0", VA = "0x185E3E5A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E82C50", Offset = "0x5E81450", VA = "0x185E82C50", Slot = "14")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E82D50", Offset = "0x5E81550", VA = "0x185E82D50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E82A40", Offset = "0x5E81240", VA = "0x185E82A40")]
	private static void HLPKFGOCGGI(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, Entity KLGMOMIJPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E82BB0", Offset = "0x5E813B0", VA = "0x185E82BB0")]
	private static bool INAPGCCILNA(EntityManager DHDOKMIFNAD, Entity MFFDEAINOPL, [Out] Transform KHFCFAPNPDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public NNNJGEIFBNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E5")]
public class JLBGMNAMPGC : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x20001E6")]
	[BurstCompile]
	private struct NONBPJNLMJO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		[ReadOnly]
		public ComponentTypeHandle<NKDFIDPGKJD> OPEGHOIIOOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		[ReadOnly]
		public BufferTypeHandle<ChildrenData> MJEJJKLGFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> ONIELLMIKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		[ReadOnly]
		public ComponentDataFromEntity<NKDFIDPGKJD> PKJNBMBJJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public ComponentTypeHandle<LMGGABKGAOO> FHCOOAFNADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<LMGGABKGAOO> DEEPGMEMDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public uint PNBOCDENAKE;

		[Cpp2IlInjected.Token(Token = "0x60009F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E835A0", Offset = "0x5E81DA0", VA = "0x185E835A0", Slot = "4")]
		public void Execute(ArchetypeChunk KIJHCPOKLEK, int ADMJKDLHPCI, int DIEKMFFJECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E838A0", Offset = "0x5E820A0", VA = "0x185E838A0")]
		private void HJINPBJLHIL(float4x4 KFGFODMFJEE, Entity MFFDEAINOPL, bool BIJGDGBNBLD, int AODOAAEJFFK = 1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	private EntityQuery MJEIHDMKDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	private EntityQuery BHGIAIDDDNO;

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AD70", Offset = "0x5E79570", VA = "0x185E7AD70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AEA0", Offset = "0x5E796A0", VA = "0x185E7AEA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public JLBGMNAMPGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
public class BMBOHFAEEMN : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x20001E8")]
	[BurstCompile]
	private struct IFFLDMMAEFO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		[ReadOnly]
		public ComponentTypeHandle<NKDFIDPGKJD> OPEGHOIIOOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public ComponentTypeHandle<LMGGABKGAOO> FHCOOAFNADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public uint PNBOCDENAKE;

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E77A80", Offset = "0x5E76280", VA = "0x185E77A80", Slot = "4")]
		public void Execute(ArchetypeChunk KIJHCPOKLEK, int ADMJKDLHPCI, int DIEKMFFJECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E77B90", Offset = "0x5E76390", VA = "0x185E77B90")]
		public bool LJFAOGEEFGJ(ArchetypeChunk KIJHCPOKLEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private EntityQuery MJEIHDMKDIA;

	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F830", Offset = "0x5E6E030", VA = "0x185E6F830", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F960", Offset = "0x5E6E160", VA = "0x185E6F960", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public BMBOHFAEEMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
public class KGNLLDDEDGI : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[BurstCompile]
	private struct HGDEJBNMKCN : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		[ReadOnly]
		public ComponentTypeHandle<LMGGABKGAOO> GBBKDOIFICF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public ComponentTypeHandle<HDHEDGENDAL> JKMJHAMPMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public ComponentTypeHandle<NJFKOEEMFDB> MOPLFJGLLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public ComponentTypeHandle<ILDJIOANNPB> MOOKHIOJHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public uint PNBOCDENAKE;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E76E20", Offset = "0x5E75620", VA = "0x185E76E20", Slot = "4")]
		public void Execute(ArchetypeChunk KIJHCPOKLEK, int ADMJKDLHPCI, int DIEKMFFJECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E77210", Offset = "0x5E75A10", VA = "0x185E77210")]
		public bool LJFAOGEEFGJ(ArchetypeChunk KIJHCPOKLEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private EntityQuery NBODHKFBPEC;

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B1D0", Offset = "0x5E799D0", VA = "0x185E7B1D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B2E0", Offset = "0x5E79AE0", VA = "0x185E7B2E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public KGNLLDDEDGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class BADDKABBFIM : JMMMDIBDAGF
{
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	[BurstCompile]
	private struct FDKLHCCMJKG : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		[ReadOnly]
		public ComponentTypeHandle<EBOGGEGJLCM> BNKHJIODMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		[ReadOnly]
		public ComponentTypeHandle<NGEJJJHGHFP> PIONPLKPICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		[ReadOnly]
		public ComponentTypeHandle<GJGBGBOCFHG> EMNJEHFLCKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public ComponentTypeHandle<NKDFIDPGKJD> MHJILKLLENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public uint PNBOCDENAKE;

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x5E742B0", Offset = "0x5E72AB0", VA = "0x185E742B0", Slot = "4")]
		public void Execute(ArchetypeChunk KIJHCPOKLEK, int ADMJKDLHPCI, int DIEKMFFJECA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x5E74A20", Offset = "0x5E73220", VA = "0x185E74A20")]
		public bool LJFAOGEEFGJ(ArchetypeChunk KIJHCPOKLEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005FC")]
	private EntityQuery NBODHKFBPEC;

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F0C0", Offset = "0x5E6D8C0", VA = "0x185E6F0C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F1F0", Offset = "0x5E6D9F0", VA = "0x185E6F1F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public BADDKABBFIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001ED")]
public class HHCAMFHOFKM : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	[MCMLPKDBFJE]
	private AIDABNJGIKJ DDKPNHBBGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	[MCMLPKDBFJE]
	private CHHCBHMKOGM LFMJEGJNMJK;

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x5E776E0", Offset = "0x5E75EE0", VA = "0x185E776E0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x5E77750", Offset = "0x5E75F50", VA = "0x185E77750", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x5E772A0", Offset = "0x5E75AA0", VA = "0x185E772A0")]
	private void ANNOKGHCJOL(NativeArray<KLEIPEFFJCP> PIDFNCJINMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public HHCAMFHOFKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EE")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal class GDEJNMJMEAH : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private AIDABNJGIKJ CKBNHIJBOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private ELALIKIJOON PHCBDJMCOIH;

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x5E75110", Offset = "0x5E73910", VA = "0x185E75110", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x5E751A0", Offset = "0x5E739A0", VA = "0x185E751A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public GDEJNMJMEAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EF")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public sealed class FKPDMGBFKDK : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private LAGDCPPJAAI FMEPDACEHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private AIDABNJGIKJ IEHPDNNDJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private LIGCKOLLPCB COPOPHGGJBC;

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x5E74D90", Offset = "0x5E73590", VA = "0x185E74D90", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0x5E74E20", Offset = "0x5E73620", VA = "0x185E74E20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public FKPDMGBFKDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F0")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal class JAJFEHMNCLO : JMMMDIBDAGF, OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private static readonly PFECAMNMOCE JOKJNINLGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	[MCMLPKDBFJE]
	private KKDHBJBFPOF GKDFLIHPFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	[MCMLPKDBFJE]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	[MCMLPKDBFJE]
	private ADNGMPCLMLO HPNONEELFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	[MCMLPKDBFJE]
	private FKPECEFBIMH IFGLBNBGECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	[MCMLPKDBFJE]
	private HCPGNAKLJFD AMLLGNDFPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	[MCMLPKDBFJE]
	private PFEKJOPEDBB JHIGIODAGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private KGGAOLKFGIL.PMNJKKKOJBE HKHOPFIPDCI;

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x5E792C0", Offset = "0x5E77AC0", VA = "0x185E792C0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x5E78D30", Offset = "0x5E77530", VA = "0x185E78D30", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x5E79750", Offset = "0x5E77F50", VA = "0x185E79750", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x5E78550", Offset = "0x5E76D50", VA = "0x185E78550")]
	private void CPPHLNIMJIF(MMNLNLKKOGE EBICOEDOGKC, NativeArray<byte> OJOEOPGFJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0x5E79500", Offset = "0x5E77D00", VA = "0x185E79500")]
	private bool LJPPFHLEEAP(MMNLNLKKOGE EBICOEDOGKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x5E79600", Offset = "0x5E77E00", VA = "0x185E79600")]
	private KGGAOLKFGIL.IHDILCBFKKN OMMEGGCJANH(NativeArray<byte> OJOEOPGFJIH, Allocator OPPHPFNHPMG)
	{
		return default(KGGAOLKFGIL.IHDILCBFKKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x5E79DA0", Offset = "0x5E785A0", VA = "0x185E79DA0")]
	private void PHFEJGBGEEF(KGGAOLKFGIL.IHDILCBFKKN FBOLEEKODOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x5E781B0", Offset = "0x5E769B0", VA = "0x185E781B0")]
	private void AGOEDPIFHKH(NativeList<KLEIPEFFJCP> BCJPFHDLPBM, NativeList<ALDBGJKBJJO> PJDHECENIOE, Allocator OPPHPFNHPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x5E78DD0", Offset = "0x5E775D0", VA = "0x185E78DD0")]
	private void INFPKJPNDPF(NativeParallelMultiHashMap<KLEIPEFFJCP, HLANCHOOJIM> INENAHCLJEC, NativeList<byte> EDKIDCADEMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x5E78AA0", Offset = "0x5E772A0", VA = "0x185E78AA0")]
	private void DALNJBIOCGK(NativeList<KLEIPEFFJCP> FKAANOOIPEH, Allocator OPPHPFNHPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x5E783B0", Offset = "0x5E76BB0", VA = "0x185E783B0")]
	private void AKCKGDLGMMH(KGGAOLKFGIL.IHDILCBFKKN KOIMDAJNDOD, bool FGEAIKDBADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x5E79560", Offset = "0x5E77D60", VA = "0x185E79560")]
	private void NGNANACAJCP(NativeList<KLEIPEFFJCP> BCJPFHDLPBM, NativeList<ALDBGJKBJJO> PJDHECENIOE, bool FGEAIKDBADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x5E79770", Offset = "0x5E77F70", VA = "0x185E79770")]
	private void PDDCEKFILOO(NativeParallelMultiHashMap<KLEIPEFFJCP, HLANCHOOJIM> INENAHCLJEC, NativeList<byte> EDKIDCADEMM, bool FGEAIKDBADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x5E79460", Offset = "0x5E77C60", VA = "0x185E79460")]
	private void LAPOKPEFLHN(NativeList<KLEIPEFFJCP> FKAANOOIPEH, bool FGEAIKDBADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void IHKEJJKIJAD(MMNLNLKKOGE EBICOEDOGKC, bool FGEAIKDBADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public JAJFEHMNCLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F1")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal class NNIPJPKCBMC : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private PGHBFFANNIO JPACBGFEFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private AIDABNJGIKJ CKBNHIJBOEP;

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x5E82600", Offset = "0x5E80E00", VA = "0x185E82600", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x5E82670", Offset = "0x5E80E70", VA = "0x185E82670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public NNIPJPKCBMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F2")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal class PGIDHCDCDOP : JMMMDIBDAGF, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private MOJADNJPIHP PCANEKAMGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private AIDABNJGIKJ CKBNHIJBOEP;

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x5E897C0", Offset = "0x5E87FC0", VA = "0x185E897C0", Slot = "14")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x5E89830", Offset = "0x5E88030", VA = "0x185E89830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public PGIDHCDCDOP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001F3")]
	[AlwaysUpdateSystem]
	[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
	[CompilerGenerated]
	internal sealed class WriteDiffChangePacketToNetworkSystem : JMMMDIBDAGF, OILIFCGGAMK
	{
		[Cpp2IlInjected.Token(Token = "0x20001F4")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct WriteDiffChangePacketToNetworkSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20001F5")]
			public delegate void RunWithoutJobSystem_00000BDB$PostfixBurstDelegate(IntPtr jobPtr);

			[Cpp2IlInjected.Token(Token = "0x20001F6")]
			internal static class RunWithoutJobSystem_00000BDB$BurstDirectCall
			{
				[Cpp2IlInjected.Token(Token = "0x4000630")]
				private static IntPtr Pointer;

				[Cpp2IlInjected.Token(Token = "0x4000631")]
				private static IntPtr DeferredCompilation;

				[Cpp2IlInjected.Token(Token = "0x6000A41")]
				[Cpp2IlInjected.Address(RVA = "0x5E8B120", Offset = "0x5E89920", VA = "0x185E8B120")]
				[BurstDiscard]
				private static void FJILHCAMCOC(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A42")]
				[Cpp2IlInjected.Address(RVA = "0x5E8B250", Offset = "0x5E89A50", VA = "0x185E8B250")]
				private static IntPtr LELDEMJJKOF()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A43")]
				[Cpp2IlInjected.Address(RVA = "0x5E8B3B0", Offset = "0x5E89BB0", VA = "0x185E8B3B0")]
				public static void MGABIKEDEHA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A44")]
				[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
				public static void MJKJMKCCJMD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A46")]
				[Cpp2IlInjected.Address(RVA = "0x5E8AF50", Offset = "0x5E89750", VA = "0x185E8AF50")]
				public static void AOLJJLOPFJO(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000622")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000623")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000624")]
			public JNDAOLABELB replication;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000625")]
			public NativeBitArray entityByProperty;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000626")]
			[ReadOnly]
			public NativeArray<KLEIPEFFJCP> srcCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000627")]
			[ReadOnly]
			public NativeArray<ALDBGJKBJJO> srcCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000628")]
			[ReadOnly]
			public NativeArray<KLEIPEFFJCP> srcDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000629")]
			[ReadOnly]
			public NativeKeyValueArrays<Entity, GKNKBFHFEDD> srcPropertyKeyValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			public NativeList<KLEIPEFFJCP> dstCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			public NativeList<ALDBGJKBJJO> dstCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			public NativeList<KLEIPEFFJCP> dstDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400062D")]
			public NativeParallelMultiHashMap<KLEIPEFFJCP, HLANCHOOJIM> dstProperties;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400062E")]
			public NativeList<byte> dstPropertyData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400062F")]
			public ComponentDataFromEntity<PDCKJJIIJLK> __RecRoom_Components_ObjectNetworkIdComponentData_FromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0x5E8D290", Offset = "0x5E8BA90", VA = "0x185E8D290")]
			private void LNNGHEHIOHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0x5E8D230", Offset = "0x5E8BA30", VA = "0x185E8D230", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x5E8D020", Offset = "0x5E8B820", VA = "0x185E8D020")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void DEHIKMNDBAI(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3E")]
			[Cpp2IlInjected.Address(RVA = "0x5E8D240", Offset = "0x5E8BA40", VA = "0x185E8D240")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void JGJLKPPMPLB(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private static readonly PFECAMNMOCE log;

		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private static readonly PFECAMNMOCE logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		[MCMLPKDBFJE]
		private HOAMBCOIHOO packetService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		[MCMLPKDBFJE]
		private AIDABNJGIKJ diffService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		[MCMLPKDBFJE]
		private DKDHCMJLDBA editorEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		[MCMLPKDBFJE]
		private JCPLFOIFHBP transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private KGGAOLKFGIL.PMNJKKKOJBE utilServices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		private bool HasEditorListeners
		{
			[Cpp2IlInjected.Token(Token = "0x6000A29")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		private MACHANMKFIF EventFlagsForPhase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x5E8BA80", Offset = "0x5E8A280", VA = "0x185E8BA80")]
			get
			{
				return default(MACHANMKFIF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C510", Offset = "0x5E8AD10", VA = "0x185E8C510", Slot = "14")]
		public void InitReferences(FHMIKLMEDIH services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DCD0", Offset = "0x5E8C4D0", VA = "0x185E8DCD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C170", Offset = "0x5E8A970", VA = "0x185E8C170")]
		private bool GIBFHMBMMFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C650", Offset = "0x5E8AE50", VA = "0x185E8C650")]
		private bool LCHPPNLGKIL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C5D0", Offset = "0x5E8ADD0", VA = "0x185E8C5D0")]
		private bool LAOCKBCMKPD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C770", Offset = "0x5E8AF70", VA = "0x185E8C770")]
		private KGGAOLKFGIL.IHDILCBFKKN LMONMABNBJA(DEJBALFFPBL state)
		{
			return default(KGGAOLKFGIL.IHDILCBFKKN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D6F0", Offset = "0x5E8BEF0", VA = "0x185E8D6F0")]
		private NativeKeyValueArrays<Entity, GKNKBFHFEDD> MEBLPPMDBAI(DEJBALFFPBL state, [Out] int capacity)
		{
			return default(NativeKeyValueArrays<Entity, GKNKBFHFEDD>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x5E8BD60", Offset = "0x5E8A560", VA = "0x185E8BD60")]
		private void ALNNONKHCDN(KGGAOLKFGIL.IHDILCBFKKN data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A31")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C090", Offset = "0x5E8A890", VA = "0x185E8C090")]
		private void EPNMOIJNKPL(KGGAOLKFGIL.IHDILCBFKKN data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x5E8BB20", Offset = "0x5E8A320", VA = "0x185E8BB20")]
		private void AKCKGDLGMMH(KGGAOLKFGIL.IHDILCBFKKN data, DEJBALFFPBL state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x5E8D9F0", Offset = "0x5E8C1F0", VA = "0x185E8D9F0")]
		private void NGNANACAJCP(NativeArray<KLEIPEFFJCP> createdIds, NativeArray<ALDBGJKBJJO> creationData, MACHANMKFIF flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E170", Offset = "0x5E8C970", VA = "0x185E8E170")]
		private void PDDCEKFILOO(NativeMultiHashMapAsync<Entity, GKNKBFHFEDD> differences, MACHANMKFIF flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C620", Offset = "0x5E8AE20", VA = "0x185E8C620")]
		private void LAPOKPEFLHN(NativeArray<KLEIPEFFJCP> destroyedIds, MACHANMKFIF flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C240", Offset = "0x5E8AA40", VA = "0x185E8C240")]
		private void GICPFFBAFIM(JNDAOLABELB replication, NativeBitArray entityByProperty, NativeArray<KLEIPEFFJCP> srcCreatedIds, NativeArray<ALDBGJKBJJO> srcCreationData, NativeArray<KLEIPEFFJCP> srcDestroyedIds, NativeKeyValueArrays<Entity, GKNKBFHFEDD> srcPropertyKeyValues, NativeList<KLEIPEFFJCP> dstCreatedIds, NativeList<ALDBGJKBJJO> dstCreationData, NativeList<KLEIPEFFJCP> dstDestroyedIds, NativeParallelMultiHashMap<KLEIPEFFJCP, HLANCHOOJIM> dstProperties, NativeList<byte> dstPropertyData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DA60", Offset = "0x5E8C260", VA = "0x185E8DA60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
		public WriteDiffChangePacketToNetworkSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DA20", Offset = "0x5E8C220", VA = "0x185E8DA20")]
		public static void OLOFEHJAMJG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F7")]
internal class OMFPDCDCFMK : JBGPKHEAAKH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001F8")]
	public struct IFMPHODFIJN : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	protected override ComponentType CAAEKKGEAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x5E84710", Offset = "0x5E82F10", VA = "0x185E84710", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	protected override ComponentType DPCLDJNJOGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A49")]
		[Cpp2IlInjected.Address(RVA = "0x5E846E0", Offset = "0x5E82EE0", VA = "0x185E846E0", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	protected override ComponentType JOPJHFKNOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(RVA = "0x5E846B0", Offset = "0x5E82EB0", VA = "0x185E846B0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x5E847D0", Offset = "0x5E82FD0", VA = "0x185E847D0")]
	public OMFPDCDCFMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F9")]
public sealed class DHCHMFKBHMN : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x5E723B0", Offset = "0x5E70BB0", VA = "0x185E723B0", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public DHCHMFKBHMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FA")]
[ExecuteAlways]
public class KLIEOBOKLBG : BLKAEPMAHDD
{
	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public KLIEOBOKLBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FB")]
public sealed class BMOOJMDMOMC : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6FAA0", Offset = "0x5E6E2A0", VA = "0x185E6FAA0", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public BMOOJMDMOMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FC")]
public sealed class NCCCPPGEBON : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F870", Offset = "0x5E7E070", VA = "0x185E7F870", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public NCCCPPGEBON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FD")]
[ExecuteAlways]
public class LCBODCAGLBD : BLKAEPMAHDD
{
	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x45B57A0", Offset = "0x45B3FA0", VA = "0x1845B57A0")]
	public LCBODCAGLBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FE")]
public sealed class PICOGGAFLGN : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x5E89A80", Offset = "0x5E88280", VA = "0x185E89A80", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public PICOGGAFLGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FF")]
[GJLJLBIABKM(typeof(EIGPEOIKDPK), new string[] { })]
[DDDINGLCBBH(typeof(OBKNLCGGCNM))]
public class DGJJGMEHKKC : EIGPEOIKDPK, GAJGABMNKBI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private readonly Dictionary<int, NGLBPOGABCB> MDPFFPOKGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private readonly Dictionary<Type, NGLBPOGABCB> PFJKDDGPEAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private readonly Dictionary<Type, NGLBPOGABCB> EIBDLFAOMGF;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public IReadOnlyCollection<NGLBPOGABCB> ALPOIMOAEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x5E71E20", Offset = "0x5E70620", VA = "0x185E71E20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x5E71F60", Offset = "0x5E70760", VA = "0x185E71F60", Slot = "7")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x5E71EE0", Offset = "0x5E706E0", VA = "0x185E71EE0", Slot = "6")]
	public NGLBPOGABCB HKJDFBCMHMP(Type BJKOKHNAAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x5E71E70", Offset = "0x5E70670", VA = "0x185E71E70", Slot = "5")]
	public bool GAALDGDBBOE(int GIBOEKFJFBH, [Out] NGLBPOGABCB PBFNCDEJLIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x5E71DD0", Offset = "0x5E705D0", VA = "0x185E71DD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5B")]
	[Cpp2IlInjected.Address(RVA = "0x5E722A0", Offset = "0x5E70AA0", VA = "0x185E722A0")]
	public DGJJGMEHKKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000200")]
[GJLJLBIABKM(typeof(KJLCCDCFOPB), new string[] { })]
[DDDINGLCBBH(typeof(OBKNLCGGCNM))]
public class OPFIMHGKIPL : KJLCCDCFOPB, GAJGABMNKBI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private readonly Dictionary<int, EEIEPFPEPFC> JEPLHAJCCMG;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public IEnumerable<EEIEPFPEPFC> ABLGOEFHFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0x5E84B50", Offset = "0x5E83350", VA = "0x185E84B50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x5E84BA0", Offset = "0x5E833A0", VA = "0x185E84BA0", Slot = "6")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x5E84A90", Offset = "0x5E83290", VA = "0x185E84A90", Slot = "5")]
	public bool AMBPMIOKMJD(int GIBOEKFJFBH, [Out] EEIEPFPEPFC DKBOLDMDFGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x5E84B00", Offset = "0x5E83300", VA = "0x185E84B00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x5E84F90", Offset = "0x5E83790", VA = "0x185E84F90")]
	public OPFIMHGKIPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000201")]
[DDDINGLCBBH(typeof(OBKNLCGGCNM))]
[GJLJLBIABKM(typeof(BDLBABFAOCA), new string[] { })]
public class PBJFJFMNEMJ : BDLBABFAOCA, GAJGABMNKBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	private static readonly Dictionary<int, int> FDDDGCEGADH;

	[Cpp2IlInjected.Token(Token = "0x6000A61")]
	[Cpp2IlInjected.Address(RVA = "0x5E85090", Offset = "0x5E83890", VA = "0x185E85090", Slot = "5")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x5E85380", Offset = "0x5E83B80", VA = "0x185E85380", Slot = "4")]
	public int PKKKKLICPFG(int GIBOEKFJFBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x5E85020", Offset = "0x5E83820", VA = "0x185E85020", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public PBJFJFMNEMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000202")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(IBDKHKBANIP), new string[] { })]
internal class IBDKHKBANIP : OLNFMJBKLAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000638")]
	private MLFKJFIGKKH<AuthoredParentData, AuthoredPreviousParentData, GFKCCIGOOEN, AuthoredChildrenData> BNBELDBBJJA;

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x5E779C0", Offset = "0x5E761C0", VA = "0x185E779C0", Slot = "4")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public IBDKHKBANIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000203")]
[GJLJLBIABKM(typeof(IJIBKLNEOBB), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
internal sealed class IJIBKLNEOBB : OILIFCGGAMK, OLNFMJBKLAF
{
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	[MCMLPKDBFJE]
	private CECLHBPNMGM NBODHKFBPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private DDMJLFGLNGL<Entity> OLJMCOBAMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	private MLFKJFIGKKH<ParentData, PreviousParentData, PAOOJBEFDMI, ChildrenData> BNBELDBBJJA;

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x5E77C20", Offset = "0x5E76420", VA = "0x185E77C20", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x5E78000", Offset = "0x5E76800", VA = "0x185E78000", Slot = "5")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6A")]
	[Cpp2IlInjected.Address(RVA = "0x5E77C70", Offset = "0x5E76470", VA = "0x185E77C70")]
	public Entity KAHCMOIEBOO(Entity MFFDEAINOPL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x5E77CC0", Offset = "0x5E764C0", VA = "0x185E77CC0")]
	public bool LKMEJDMDFEJ(Entity MFFDEAINOPL, Entity IKMOPDEAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x5E77F60", Offset = "0x5E76760", VA = "0x185E77F60")]
	public bool OABOCDMKFCC(Entity MFFDEAINOPL, Entity IKMOPDEAPOG, bool PMNMIAAPPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x5E77D20", Offset = "0x5E76520", VA = "0x185E77D20")]
	private bool NFFHELKIJNJ(Entity MFFDEAINOPL, Entity IKMOPDEAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public IJIBKLNEOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000204")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(KJJICNHEKJM), new string[] { })]
internal sealed class KJJICNHEKJM : OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	private EntityQuery DEEIPLCCDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A70")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B8D0", Offset = "0x5E7A0D0", VA = "0x185E7B8D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B730", Offset = "0x5E79F30", VA = "0x185E7B730", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B5A0", Offset = "0x5E79DA0", VA = "0x185E7B5A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B5C0", Offset = "0x5E79DC0", VA = "0x185E7B5C0")]
	public bool EHHMCMCJOLD(Entity MFFDEAINOPL, Entity INIMKGAHAEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B4F0", Offset = "0x5E79CF0", VA = "0x185E7B4F0")]
	public bool DGPBLLKPAEP(Entity MFFDEAINOPL, Entity HBIJIKOLFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B830", Offset = "0x5E7A030", VA = "0x185E7B830")]
	public Entity OEBJBPNCIBI(Entity MFFDEAINOPL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B4A0", Offset = "0x5E79CA0", VA = "0x185E7B4A0")]
	public NativeArray<Entity> AIEGMIMLKAE()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B670", Offset = "0x5E79E70", VA = "0x185E7B670")]
	public bool EPHMNKOPEON(Entity HBMBMELELPF, Entity OPFJANEEJKH, [Out] Entity NIPMIADLFPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public KJJICNHEKJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000205")]
public static class HOOEGDINNAK
{
	[Cpp2IlInjected.Token(Token = "0x4000640")]
	internal static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x23B6780", Offset = "0x23B4F80", VA = "0x1823B6780")]
	public static void LIDOAMKDODG<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(FHMIKLMEDIH CNFBLEFPNKP, GOOBEKCPDHA<Entity> JHFJPGOBMLL, [Out] MLFKJFIGKKH<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> DLAJDDBMLLH) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, AIOGGNIJOCI where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, AIOGGNIJOCI, IEquatable<TChildrenData>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x5E77900", Offset = "0x5E76100", VA = "0x185E77900")]
	public static bool JBLPHFCFGIG(EEKEIMNDBGI ICAGFLPKAGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000206")]
public class MLFKJFIGKKH<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, AIOGGNIJOCI where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, AIOGGNIJOCI, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	private readonly HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private readonly DDMJLFGLNGL<Entity> OLJMCOBAMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private readonly AANOMIFDJAK CPCPGNLGNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	private readonly MNOPJOLALGH KLGMOMIJPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000646")]
	private readonly EntityManager DHDOKMIFNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000647")]
	private readonly LIEABLACGCP BPOHGAPJJAB;

	[Cpp2IlInjected.Token(Token = "0x6000A7C")]
	[Cpp2IlInjected.Address(RVA = "0x3BCB460", Offset = "0x3BC9C60", VA = "0x183BCB460")]
	public MLFKJFIGKKH(FHMIKLMEDIH CNFBLEFPNKP, GOOBEKCPDHA<Entity> JHFJPGOBMLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7D")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA230", Offset = "0x3BC8A30", VA = "0x183BCA230")]
	private bool MEGJEFOHOHI(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x3BC92F0", Offset = "0x3BC7AF0", VA = "0x183BC92F0")]
	private bool APGCPENJIKE(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9A50", Offset = "0x3BC8250", VA = "0x183BC9A50")]
	private bool HPLNMOFDDHA(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A80")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA1F0", Offset = "0x3BC89F0", VA = "0x183BCA1F0")]
	public bool LKMEJDMDFEJ(Entity MFFDEAINOPL, [In] Entity IKMOPDEAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9AD0", Offset = "0x3BC82D0", VA = "0x183BC9AD0")]
	public bool JNFKAMMCPJH(Entity MFFDEAINOPL, [In] Entity IKMOPDEAPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x3BC9B10", Offset = "0x3BC8310", VA = "0x183BC9B10")]
	private bool JNFKAMMCPJH(Entity MFFDEAINOPL, [In] Entity IKMOPDEAPOG, bool CLBAHFJDNIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A83")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void PFNGLPAEKKE(Entity MFFDEAINOPL, [In] Entity IKMOPDEAPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void NAPIGOCEONO(Entity MFFDEAINOPL, [In] Entity IKMOPDEAPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A85")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void JGAKIPPGFJD(Entity MFFDEAINOPL, [In] Entity IKMOPDEAPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void BFCKJDILNPO(Entity MFFDEAINOPL, [In] Entity IKMOPDEAPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void GAIBKCEBDNF(Entity MFFDEAINOPL, [In] Entity IKMOPDEAPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x3BC98E0", Offset = "0x3BC80E0", VA = "0x183BC98E0")]
	private bool EHHMCMCJOLD(Entity MFFDEAINOPL, Entity INIMKGAHAEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x3BC96D0", Offset = "0x3BC7ED0", VA = "0x183BC96D0")]
	private void BIOGDGPHJEC(Entity MFFDEAINOPL, [In] Entity HPAAJPNIILF, [In] Entity IKMOPDEAPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAC30", Offset = "0x3BC9430", VA = "0x183BCAC30")]
	private void PNNMDLGAMON(Entity MFFDEAINOPL, [In] Entity HPAAJPNIILF, [In] Entity IKMOPDEAPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA330", Offset = "0x3BC8B30", VA = "0x183BCA330")]
	private bool MEIKNPPJBPA(ADNGMPCLMLO EDDCAIAHGKK, [In] KLEIPEFFJCP KCGICAPGIPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x3BCA710", Offset = "0x3BC8F10", VA = "0x183BCA710")]
	private void NMIJLKFFGOC(Entity KLGMOMIJPLM, Entity JDEFHCADEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0x3BC93F0", Offset = "0x3BC7BF0", VA = "0x183BC93F0")]
	private void BIJCLJDBJFN(Entity KLGMOMIJPLM, Entity JDEFHCADEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private void DGNMFAMFAAK(Entity MFFDEAINOPL, Entity HPAAJPNIILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private void NGFFHAFGCKJ(Entity MFFDEAINOPL, Entity IKMOPDEAPOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000207")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(PGHBFFANNIO), new string[] { })]
internal sealed class PGHBFFANNIO : CCGJODBGILF, GAJGABMNKBI, OILIFCGGAMK, OLNFMJBKLAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000648")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000649")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400064A")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	[MCMLPKDBFJE]
	private CECLHBPNMGM NBODHKFBPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	[MCMLPKDBFJE]
	private KOALBKCLEGM KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	[MCMLPKDBFJE]
	private KHMIANHLIDA DCDGDLJLGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	[MCMLPKDBFJE]
	private DHNGLBNANFJ EFGAHFELMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	[MCMLPKDBFJE]
	private CNMOLKDLNOJ GFNBCDKOLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	[MCMLPKDBFJE]
	private LIGCKOLLPCB COPOPHGGJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private readonly Dictionary<KLEIPEFFJCP, HFBIDPNKJHF> HEFLIHFDCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private PELMMDDIDAJ KCDAFEDKPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x5E89570", Offset = "0x5E87D70", VA = "0x185E89570")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0xB309E0", Offset = "0xB2F1E0", VA = "0x180B309E0", Slot = "4")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0x5E87840", Offset = "0x5E86040", VA = "0x185E87840", Slot = "5")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x5E880F0", Offset = "0x5E868F0", VA = "0x185E880F0")]
	public void LBLPCPDMCED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A95")]
	[Cpp2IlInjected.Address(RVA = "0x5E895C0", Offset = "0x5E87DC0", VA = "0x185E895C0", Slot = "6")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x5E86970", Offset = "0x5E85170", VA = "0x185E86970", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A97")]
	[Cpp2IlInjected.Address(RVA = "0x5E86950", Offset = "0x5E85150", VA = "0x185E86950")]
	public int DDNEMJOBBMI(SceneTag NJBFIEAFGFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x5E86FC0", Offset = "0x5E857C0", VA = "0x185E86FC0")]
	public bool GAFMDALHIFE(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0x5E88250", Offset = "0x5E86A50", VA = "0x185E88250")]
	public bool LNCBCICGOEB(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x5E881E0", Offset = "0x5E869E0", VA = "0x185E881E0")]
	public bool LGFAPDODONP(Entity MFFDEAINOPL, [Out] HFBIDPNKJHF IBCBDBLGJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9B")]
	[Cpp2IlInjected.Address(RVA = "0x5E88140", Offset = "0x5E86940", VA = "0x185E88140")]
	private bool LGFAPDODONP(Transform KHFCFAPNPDN, [Out] HFBIDPNKJHF IBCBDBLGJKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x5E86F30", Offset = "0x5E85730", VA = "0x185E86F30")]
	private void FBIMNALHEAL(Entity MFFDEAINOPL, HFBIDPNKJHF IBCBDBLGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0x5E86930", Offset = "0x5E85130", VA = "0x185E86930")]
	private bool DBAMLDCKHIG(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x5E879F0", Offset = "0x5E861F0", VA = "0x185E879F0")]
	public void JKCLJMACCFA(KLEIPEFFJCP LFHNIGHPLBN, HFBIDPNKJHF CILANNDFKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x5E86320", Offset = "0x5E84B20", VA = "0x185E86320")]
	public bool CNMNENGNNPO(JEDJBKOCEME JBPJNGFGLPC, object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA0")]
	[Cpp2IlInjected.Address(RVA = "0x5E86290", Offset = "0x5E84A90", VA = "0x185E86290")]
	public bool CNMNENGNNPO(Entity MFFDEAINOPL, [Optional] object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA1")]
	[Cpp2IlInjected.Address(RVA = "0x5E862F0", Offset = "0x5E84AF0", VA = "0x185E862F0")]
	public bool CNMNENGNNPO(HFBIDPNKJHF ICAGFLPKAGF, object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA2")]
	[Cpp2IlInjected.Address(RVA = "0x5E859F0", Offset = "0x5E841F0", VA = "0x185E859F0")]
	public bool AGLJDNIIPBG(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0x5E86900", Offset = "0x5E85100", VA = "0x185E86900")]
	public bool CNMNENGNNPO(HFBIDPNKJHF IBCBDBLGJKJ, bool HCOFOGEFGHL, [Optional] object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x5E88270", Offset = "0x5E86A70", VA = "0x185E88270")]
	private bool NEIIGOKPNOJ(HFBIDPNKJHF IBCBDBLGJKJ, object PIPCHJCEPPJ, bool HCOFOGEFGHL, bool LKOCDFMKJJF, bool ILPLKNGNLOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0x5E85FB0", Offset = "0x5E847B0", VA = "0x185E85FB0")]
	public Transform BKFHOEMOILA(Entity MFFDEAINOPL, [Optional] object PIPCHJCEPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x5E87770", Offset = "0x5E85F70", VA = "0x185E87770")]
	public bool INAPGCCILNA(Entity MFFDEAINOPL, [Out] Transform KHFCFAPNPDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0x5E861A0", Offset = "0x5E849A0", VA = "0x185E861A0")]
	public HFBIDPNKJHF CKHHEFMHFCG(Entity MFFDEAINOPL, [Optional] object PIPCHJCEPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x5E87DC0", Offset = "0x5E865C0", VA = "0x185E87DC0")]
	public void KPDBPKCDCOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x5E86A30", Offset = "0x5E85230", VA = "0x185E86A30")]
	public void EBGBEPONOFB(SceneTag NJBFIEAFGFF, bool LKOCDFMKJJF, NativeParallelHashSet<int> EDOLBHFAIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x5E887D0", Offset = "0x5E86FD0", VA = "0x185E887D0")]
	private void NFOBKMMBEIC(Entity MFFDEAINOPL, bool LKOCDFMKJJF, bool ILPLKNGNLOE, NativeParallelHashSet<int> EDOLBHFAIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x5E87970", Offset = "0x5E86170", VA = "0x185E87970")]
	public bool JEDDAFCMBOC(Entity MFFDEAINOPL, object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAC")]
	[Cpp2IlInjected.Address(RVA = "0x5E87D40", Offset = "0x5E86540", VA = "0x185E87D40")]
	public bool KJPIJIECLLM(Entity MFFDEAINOPL, object PIPCHJCEPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x5E87B90", Offset = "0x5E86390", VA = "0x185E87B90")]
	public bool KDIJMJANLMH(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x5E87690", Offset = "0x5E85E90", VA = "0x185E87690")]
	private void IIMIBONNEGB(bool LHJIANPECCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x5E87480", Offset = "0x5E85C80", VA = "0x185E87480")]
	private bool HCNECBCDGAL(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x5E86EE0", Offset = "0x5E856E0", VA = "0x185E86EE0")]
	public HFBIDPNKJHF EMEFJNGCOFM(Entity MFFDEAINOPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x5E89270", Offset = "0x5E87A70", VA = "0x185E89270")]
	private HFBIDPNKJHF OBCAHGMOOCK(Entity MFFDEAINOPL, object PIPCHJCEPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0x5E89310", Offset = "0x5E87B10", VA = "0x185E89310")]
	private HFBIDPNKJHF OCOMKOIBLOD(Entity MFFDEAINOPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x5E87540", Offset = "0x5E85D40", VA = "0x185E87540")]
	public void IFNPMFLNKFD(NativeArray<KLEIPEFFJCP> BMJMOJMCGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x5E85910", Offset = "0x5E84110", VA = "0x185E85910")]
	private void AFOIEHKDMMO(JEDJBKOCEME JBPJNGFGLPC, HFBIDPNKJHF CILANNDFKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x5E86E10", Offset = "0x5E85610", VA = "0x185E86E10")]
	private void EGPDDFAOJAH(HFBIDPNKJHF CILANNDFKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x5E87190", Offset = "0x5E85990", VA = "0x185E87190")]
	private void GLAAIONNNKM(HFBIDPNKJHF IBCBDBLGJKJ, Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x5E854B0", Offset = "0x5E83CB0", VA = "0x185E854B0")]
	private void AEAONEGJEKF(Entity MFFDEAINOPL, HFBIDPNKJHF IBCBDBLGJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x5E89190", Offset = "0x5E87990", VA = "0x185E89190")]
	private void NMJIENNDEPL(Entity MFFDEAINOPL, Transform KHFCFAPNPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0x5E07610", Offset = "0x5E05E10", VA = "0x185E07610")]
	private JEDJBKOCEME EKFEDJBABPC(Entity MFFDEAINOPL)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x5E89730", Offset = "0x5E87F30", VA = "0x185E89730")]
	public PGHBFFANNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x5E87C70", Offset = "0x5E86470", VA = "0x185E87C70")]
	[CompilerGenerated]
	private void KHAFBDFGNHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000208")]
[GJLJLBIABKM(typeof(ELALIKIJOON), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
internal sealed class ELALIKIJOON : OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private PGHBFFANNIO IBCBDBLGJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	private EDMINOMKBEE CIFGGHHAFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000658")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC1")]
		[Cpp2IlInjected.Address(RVA = "0x5E73DE0", Offset = "0x5E725E0", VA = "0x185E73DE0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<LKEHPHAMPJC, NativeArray<KNBFLDNEILM>> HKHPNKEMEME
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABD")]
		[Cpp2IlInjected.Address(RVA = "0x5E73090", Offset = "0x5E71890", VA = "0x185E73090")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000ABE")]
		[Cpp2IlInjected.Address(RVA = "0x5E73480", Offset = "0x5E71C80", VA = "0x185E73480")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<LKEHPHAMPJC> MBKONJONAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000ABF")]
		[Cpp2IlInjected.Address(RVA = "0x5E73CC0", Offset = "0x5E724C0", VA = "0x185E73CC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000AC0")]
		[Cpp2IlInjected.Address(RVA = "0x5E73AE0", Offset = "0x5E722E0", VA = "0x185E73AE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x5E73C20", Offset = "0x5E72420", VA = "0x185E73C20", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x19A3330", Offset = "0x19A1B30", VA = "0x1819A3330", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x5E73B90", Offset = "0x5E72390", VA = "0x185E73B90")]
	public void IDBPEFCBIMG(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x5E73BD0", Offset = "0x5E723D0", VA = "0x185E73BD0")]
	public void IPHJPKDODGM(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x5E73680", Offset = "0x5E71E80", VA = "0x185E73680")]
	private bool HBLIKCCBOEP(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x5E73D70", Offset = "0x5E72570", VA = "0x185E73D70")]
	public void LJGAFCKKELL(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x5E73E30", Offset = "0x5E72630", VA = "0x185E73E30")]
	private bool OHDCKCINFNE(Entity MFFDEAINOPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x5E73530", Offset = "0x5E71D30", VA = "0x185E73530")]
	public void GFLGNEDPNAG(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x5E73420", Offset = "0x5E71C20", VA = "0x185E73420")]
	private void FHHBADPMBJP(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x5E731F0", Offset = "0x5E719F0", VA = "0x185E731F0")]
	private void CKCLJDJCLKP(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x5E73190", Offset = "0x5E71990", VA = "0x185E73190")]
	private void CHLOCHIBFPM(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x5E73810", Offset = "0x5E72010", VA = "0x185E73810")]
	private void HPCAHKAFGBK(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x5E73140", Offset = "0x5E71940", VA = "0x185E73140")]
	public void BLACPIGKJJL(LKEHPHAMPJC BKPJJLPFOIL, NativeArray<KNBFLDNEILM> PEFPFEIKKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x5E737D0", Offset = "0x5E71FD0", VA = "0x185E737D0")]
	public void HEENOGHDGCJ(LKEHPHAMPJC BKPJJLPFOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private void DLDOPOJKHCH(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x5E74010", Offset = "0x5E72810", VA = "0x185E74010")]
	private void PPANPFNNMNH(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public ELALIKIJOON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000209")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(ADDMHAJKGOD), new string[] { })]
internal class ADDMHAJKGOD : OJKNCGAFDBJ, OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200020B")]
	[CompilerGenerated]
	private sealed class AABOAGGGDPO : IEnumerable<(DFMGIJCAPCL, KNBFLDNEILM)>, IEnumerable, IEnumerator<(DFMGIJCAPCL, KNBFLDNEILM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private (DFMGIJCAPCL primitiveType, KNBFLDNEILM prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		public ADDMHAJKGOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		private (DFMGIJCAPCL, KNBFLDNEILM) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF1")]
			[Cpp2IlInjected.Address(RVA = "0x3091560", Offset = "0x308FD60", VA = "0x183091560", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((DFMGIJCAPCL, KNBFLDNEILM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF3")]
			[Cpp2IlInjected.Address(RVA = "0x5E6B630", Offset = "0x5E69E30", VA = "0x185E6B630", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x32AECA0", Offset = "0x32AD4A0", VA = "0x1832AECA0")]
		[DebuggerHidden]
		public AABOAGGGDPO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B430", Offset = "0x5E69C30", VA = "0x185E6B430", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B5E0", Offset = "0x5E69DE0", VA = "0x185E6B5E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B530", Offset = "0x5E69D30", VA = "0x185E6B530", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(DFMGIJCAPCL, KNBFLDNEILM)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF5")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B530", Offset = "0x5E69D30", VA = "0x185E6B530", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400065B")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400065C")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400065D")]
	private World LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private NativeParallelHashMap<int, Entity> FNJHIEAKNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private NativeParallelHashMap<int, EntityArchetype> FJNNPDDPKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private NativeParallelHashMap<int, int> GGPHAPCIOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private KNBFLDNEILM[] PEFPFEIKKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	private readonly Dictionary<DFMGIJCAPCL, KNBFLDNEILM> FPMGAPFBAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private readonly Dictionary<IGNLKLNFGNN, KNBFLDNEILM> HBJFNGOBILF;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD4")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C390", Offset = "0x5E6AB90", VA = "0x185E6C390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000AD5")]
		[Cpp2IlInjected.Address(RVA = "0x762B30", Offset = "0x761330", VA = "0x180762B30")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000AD6")]
		[Cpp2IlInjected.Address(RVA = "0x186FF90", Offset = "0x186E790", VA = "0x18186FF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CD90", Offset = "0x5E6B590", VA = "0x185E6CD90", Slot = "5")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C4F0", Offset = "0x5E6ACF0", VA = "0x185E6C4F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0xD62CB0", Offset = "0xD614B0", VA = "0x180D62CB0")]
	internal NativeParallelHashMap<int, Entity> OFHCCDGABPD()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0xD3C790", Offset = "0xD3AF90", VA = "0x180D3C790")]
	internal NativeParallelHashMap<int, EntityArchetype> BEBJALPGJPD()
	{
		return default(NativeParallelHashMap<int, EntityArchetype>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0x89E5C0", Offset = "0x89CDC0", VA = "0x18089E5C0")]
	internal NativeParallelHashMap<int, int> BMMHCMDIDFL()
	{
		return default(NativeParallelHashMap<int, int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C8A0", Offset = "0x5E6B0A0", VA = "0x185E6C8A0")]
	internal IEnumerable<Type> ECBCEDIDKFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CB70", Offset = "0x5E6B370", VA = "0x185E6CB70")]
	internal NHDKNOCJODI HHENJAILAOC(Type BJKOKHNAAID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DFC0", Offset = "0x5E6C7C0", VA = "0x185E6DFC0")]
	public EntityArchetype LGCPFGCBEHB(KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E030", Offset = "0x5E6C830", VA = "0x185E6E030", Slot = "4")]
	[IteratorStateMachine(typeof(AABOAGGGDPO))]
	public IEnumerable<(DFMGIJCAPCL, KNBFLDNEILM)> NGGKKKEHDBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C3D0", Offset = "0x5E6ABD0", VA = "0x185E6C3D0")]
	public Entity DNOIDEGKJNI(KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CBE0", Offset = "0x5E6B3E0", VA = "0x185E6CBE0")]
	public void HMMALOFEAOL(NativeArray<KNBFLDNEILM> PEFPFEIKKIF, NativeArray<Entity> JPMLDNAJPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DF30", Offset = "0x5E6C730", VA = "0x185E6DF30")]
	public void KPHBABPHNIE(KNBFLDNEILM FGDLEJGCDOG, NativeArray<Entity> EFLDIIILPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E0B0", Offset = "0x5E6C8B0", VA = "0x185E6E0B0")]
	public KNBFLDNEILM NPLADJFCMGH(DFMGIJCAPCL BJKOKHNAAID)
	{
		return default(KNBFLDNEILM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C900", Offset = "0x5E6B100", VA = "0x185E6C900")]
	public Entity EHGLPDJKBAH(KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D920", Offset = "0x5E6C120", VA = "0x185E6D920")]
	private void JKOKAOKOBCJ(NHDKNOCJODI KBHEKHALEPG, NativeList<int> PEFPFEIKKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DC20", Offset = "0x5E6C420", VA = "0x185E6DC20")]
	internal void KCGIODAKADD(KNBFLDNEILM FGDLEJGCDOG, ComponentTypeList APDLHEGDKMF, CNFDOFPMGKL GCEAJEAOFHD, NHDKNOCJODI KBHEKHALEPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C9E0", Offset = "0x5E6B1E0", VA = "0x185E6C9E0")]
	private EntityArchetype FJMFGMGJNLP(KNBFLDNEILM FGDLEJGCDOG, ComponentTypeList DGNAIPANHEG)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E1A0", Offset = "0x5E6C9A0", VA = "0x185E6E1A0")]
	public ADDMHAJKGOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020C")]
public enum LOJLFKPHDDJ
{
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	Main,
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	NetworkReceive,
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x200020D")]
internal interface PIIFGJMEOCG
{
	[Cpp2IlInjected.Token(Token = "0x17000128")]
	World CPJGAENFGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	World OENOGIIIABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	NGGKGDENIAN BHAILFIIFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	uint PNBOCDENAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000AF9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000AFA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	bool PLFIBBCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200020E")]
internal class LFFIKPIJHFL : POABLKAKLOJ, DEJBALFFPBL
{
	[Cpp2IlInjected.Token(Token = "0x4000672")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000673")]
	private readonly PIIFGJMEOCG LFMLECMDDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private readonly LOJLFKPHDDJ KCBHFKGPFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private readonly World KLEBCFIAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private readonly List<BADIEPHIKLF> BPEOPIOJNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	private NativeParallelMultiHashMap<Entity, GKNKBFHFEDD> GJAPBFDPAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private NativeParallelHashMap<int, int> CGNBJMFPJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000679")]
	private NativeArray<KLEIPEFFJCP> BCJPFHDLPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private NativeArray<ALDBGJKBJJO> PJDHECENIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400067B")]
	private NativeArray<KLEIPEFFJCP> FKAANOOIPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400067C")]
	private JobHandle AOPAKEBFIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	private JobHandle EMFIFMPEPBK;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private NativeParallelMultiHashMap<Entity, GKNKBFHFEDD> HIHAEBOLLIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFD")]
		[Cpp2IlInjected.Address(RVA = "0xD3C790", Offset = "0xD3AF90", VA = "0x180D3C790", Slot = "4")]
		get
		{
			return default(NativeParallelMultiHashMap<Entity, GKNKBFHFEDD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private uint FDEIGNDHKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFE")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CF80", Offset = "0x5E7B780", VA = "0x185E7CF80", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private bool CLAIPMLPPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B02")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D860", Offset = "0x5E7C060", VA = "0x185E7D860", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private NativeArray<KLEIPEFFJCP> JJJIFFJAIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x19F42C0", Offset = "0x19F2AC0", VA = "0x1819F42C0", Slot = "10")]
		get
		{
			return default(NativeArray<KLEIPEFFJCP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private NativeArray<ALDBGJKBJJO> OJOEBFCIKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0xED6530", Offset = "0xED4D30", VA = "0x180ED6530", Slot = "11")]
		get
		{
			return default(NativeArray<ALDBGJKBJJO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private NativeArray<KLEIPEFFJCP> CABNEJHHPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x45C5350", Offset = "0x45C3B50", VA = "0x1845C5350", Slot = "12")]
		get
		{
			return default(NativeArray<KLEIPEFFJCP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D900", Offset = "0x5E7C100", VA = "0x185E7D900")]
	public LFFIKPIJHFL(PIIFGJMEOCG LFMLECMDDPI, LOJLFKPHDDJ KCBHFKGPFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFF")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CC10", Offset = "0x5E7B410", VA = "0x185E7CC10", Slot = "6")]
	private bool CINPHMMABLP(NativeArray<KLEIPEFFJCP> BCJPFHDLPBM, NativeArray<ALDBGJKBJJO> PJDHECENIOE, NativeArray<KLEIPEFFJCP> FKAANOOIPEH, int NPHAPNGNOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B00")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CAA0", Offset = "0x5E7B2A0", VA = "0x185E7CAA0", Slot = "7")]
	private void ALNAOENAOLP([In] BADIEPHIKLF HEFBBAAFACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B01")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CE00", Offset = "0x5E7B600", VA = "0x185E7CE00", Slot = "8")]
	private void EKNPKDEMMHD(JobHandle FJFHMLGEMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D200", Offset = "0x5E7BA00", VA = "0x185E7D200", Slot = "13")]
	private bool KJODAOEBFJA([Out] NativeArray<int> DHJJNOGPMFH, Allocator OPPHPFNHPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D2B0", Offset = "0x5E7BAB0", VA = "0x185E7D2B0", Slot = "14")]
	private bool MPIMJFPCENM(ComponentType ANDCEPJBFFM, [Out] BADIEPHIKLF NFEGOEAFJOL, [Out] NBKLCOBNFDK POCHBOIHANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D490", Offset = "0x5E7BC90", VA = "0x185E7D490", Slot = "15")]
	private NativeMultiHashMapAsync<Entity, GKNKBFHFEDD> ODLGBFHKIAI()
	{
		return default(NativeMultiHashMapAsync<Entity, GKNKBFHFEDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D510", Offset = "0x5E7BD10", VA = "0x185E7D510")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CFD0", Offset = "0x5E7B7D0", VA = "0x185E7CFD0")]
	private bool JDLJCIKFMJA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200020F")]
[GJLJLBIABKM(typeof(AIDABNJGIKJ), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
internal class AIDABNJGIKJ : OILIFCGGAMK, OLNFMJBKLAF, PIIFGJMEOCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000210")]
	internal readonly struct PJBFLHLIABB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private readonly LOJLFKPHDDJ HKEBDNOGIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private readonly AIDABNJGIKJ CMJAHIOHOCL;

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x5E89B70", Offset = "0x5E88370", VA = "0x185E89B70")]
		public PJBFLHLIABB(AIDABNJGIKJ CMJAHIOHOCL, LOJLFKPHDDJ ABKONBLDMGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(RVA = "0x5E89B50", Offset = "0x5E88350", VA = "0x185E89B50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x400067F")]
	private static readonly PFECAMNMOCE FKKMEAAPDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	[MCMLPKDBFJE]
	private EIGPEOIKDPK HOKINAOAABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	[MCMLPKDBFJE]
	private ADDMHAJKGOD KGFLJMCCNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private readonly LFFIKPIJHFL[] DDGNJMDLILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private NGGKGDENIAN ONIPNDNDBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private NativeParallelHashMap<int, Entity> LGCGEHGHGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private LOJLFKPHDDJ BAJNFLBDABF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public World CPJGAENFGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6EBB0", Offset = "0x5E6D3B0", VA = "0x185E6EBB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public World OENOGIIIABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0D")]
		[Cpp2IlInjected.Address(RVA = "0x76F3E0", Offset = "0x76DBE0", VA = "0x18076F3E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000B0E")]
		[Cpp2IlInjected.Address(RVA = "0x76F3D0", Offset = "0x76DBD0", VA = "0x18076F3D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public NGGKGDENIAN BHAILFIIFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0F")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE170", Offset = "0x1FDC970", VA = "0x181FDE170", Slot = "8")]
		get
		{
			return default(NGGKGDENIAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public uint PNBOCDENAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B10")]
		[Cpp2IlInjected.Address(RVA = "0xCE2A90", Offset = "0xCE1290", VA = "0x180CE2A90", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B11")]
		[Cpp2IlInjected.Address(RVA = "0xCE2EE0", Offset = "0xCE16E0", VA = "0x180CE2EE0", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private bool BKEJEBILFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x9A90E0", Offset = "0x9A78E0", VA = "0x1809A90E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool PLFIBBCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0xCCAD50", Offset = "0xCC9550", VA = "0x180CCAD50", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public NativeParallelHashMap<int, Entity> HFPEAIGBMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x3CA8EF0", Offset = "0x3CA76F0", VA = "0x183CA8EF0")]
		get
		{
			return default(NativeParallelHashMap<int, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public DEJBALFFPBL JJHLCKANKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E720", Offset = "0x5E6CF20", VA = "0x185E6E720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public POABLKAKLOJ BKLHCEHKLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E720", Offset = "0x5E6CF20", VA = "0x185E6E720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public LOJLFKPHDDJ MJCOBOIJIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0x954C30", Offset = "0x953430", VA = "0x180954C30")]
		get
		{
			return default(LOJLFKPHDDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x1B64740", Offset = "0x1B62F40", VA = "0x181B64740")]
	public DEJBALFFPBL JBFOELJFADK(LOJLFKPHDDJ KCBHFKGPFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x1B64740", Offset = "0x1B62F40", VA = "0x181B64740")]
	public POABLKAKLOJ MECJCHGPCNG(LOJLFKPHDDJ KCBHFKGPFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EAE0", Offset = "0x5E6D2E0", VA = "0x185E6EAE0", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EC50", Offset = "0x5E6D450", VA = "0x185E6EC50", Slot = "5")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E860", Offset = "0x5E6D060", VA = "0x185E6E860")]
	private NativeParallelHashMap<int, Entity> GJDEDJMDLKD()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EC00", Offset = "0x5E6D400", VA = "0x185E6EC00")]
	public void LNODHPCFMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EF60", Offset = "0x5E6D760", VA = "0x185E6EF60")]
	public void PAMPKEGOCOB(LOJLFKPHDDJ KCBHFKGPFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EEA0", Offset = "0x5E6D6A0", VA = "0x185E6EEA0")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B20")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E750", Offset = "0x5E6CF50", VA = "0x185E6E750", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B21")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E6C0", Offset = "0x5E6CEC0", VA = "0x185E6E6C0")]
	public PJBFLHLIABB CDAONKLDFEH(LOJLFKPHDDJ KCBHFKGPFEE)
	{
		return default(PJBFLHLIABB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B22")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F060", Offset = "0x5E6D860", VA = "0x185E6F060")]
	public AIDABNJGIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000211")]
[GJLJLBIABKM(typeof(MKHOKPNBAOG), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
internal class MKHOKPNBAOG : OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x400068E")]
	public static readonly SceneTag HLKLDDJCGKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000690")]
	[MCMLPKDBFJE]
	private PHLKAMANPNI BBCPMDMMDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	[MCMLPKDBFJE]
	private PGHBFFANNIO IBCBDBLGJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	[MCMLPKDBFJE]
	private AANOMIFDJAK KOJGLBGNEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	[MCMLPKDBFJE]
	private JFFIINNEBJC AGANAIOLBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	[MCMLPKDBFJE]
	private FAHLHGMLHBM KJIEGIBJKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	private EntityQuery DHOKEIDLMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	private EntityQuery EAFMJOJFECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private EntityQuery PLBMKDLGFJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private Entity PMLJJKIIGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public NativeArray<Entity> OKPKLOJONJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(RVA = "0xBE78B0", Offset = "0xBE60B0", VA = "0x180BE78B0")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(RVA = "0xBE6060", Offset = "0xBE4860", VA = "0x180BE6060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Entity DDGPKOOGICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E570", Offset = "0x5E7CD70", VA = "0x185E7E570")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public SceneTag NCCDFMCFGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E9B0", Offset = "0x5E7D1B0", VA = "0x185E7E9B0")]
		get
		{
			return default(SceneTag);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public Entity EGBFDFKIFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E9B0", Offset = "0x5E7D1B0", VA = "0x185E7E9B0")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F180", Offset = "0x5E7D980", VA = "0x185E7F180")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F630", Offset = "0x5E7DE30", VA = "0x185E7F630")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F1F0", Offset = "0x5E7D9F0", VA = "0x185E7F1F0", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E970", Offset = "0x5E7D170", VA = "0x185E7E970", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F2F0", Offset = "0x5E7DAF0", VA = "0x185E7F2F0")]
	public void JLLNHFGFEEH(Entity MFFDEAINOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B30")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F600", Offset = "0x5E7DE00", VA = "0x185E7F600")]
	public NativeArray<Entity> NKFCOKOFGOK(Allocator OPPHPFNHPMG = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B31")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E800", Offset = "0x5E7D000", VA = "0x185E7E800")]
	public void DHGKHABNLKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B32")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E850", Offset = "0x5E7D050", VA = "0x185E7E850")]
	public void DJLDNOHHPJL(Entity NJBFIEAFGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B33")]
	[Cpp2IlInjected.Address(RVA = "0x5E7EF10", Offset = "0x5E7D710", VA = "0x185E7EF10")]
	public Entity HJLFPJBJHPM(string BOBHOMKFHJB = "")
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B34")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E550", Offset = "0x5E7CD50", VA = "0x185E7E550")]
	public void BHIFNHFADGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B35")]
	[Cpp2IlInjected.Address(RVA = "0x5E7EE20", Offset = "0x5E7D620", VA = "0x185E7EE20")]
	public void FOIHKNMKCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B36")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	public void GPGIHDKPGAO(Entity NJBFIEAFGFF, string BOBHOMKFHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F680", Offset = "0x5E7DE80", VA = "0x185E7F680")]
	public void OHMOMOHMJGD(Entity NJBFIEAFGFF, bool CJLFHLPHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B38")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E320", Offset = "0x5E7CB20", VA = "0x185E7E320")]
	public void APBCIHENHKD(Entity MFFDEAINOPL, Entity NJBFIEAFGFF, bool CLNOCDMOPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B39")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E0F0", Offset = "0x5E7C8F0", VA = "0x185E7E0F0")]
	public void APBCIHENHKD(NativeArray<Entity> EFLDIIILPLM, Entity NJBFIEAFGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7EFC0", Offset = "0x5E7D7C0", VA = "0x185E7EFC0")]
	private void INGAMEFDFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7EA00", Offset = "0x5E7D200", VA = "0x185E7EA00")]
	private void EDGBKBLKFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E570", Offset = "0x5E7CD70", VA = "0x185E7E570")]
	private Entity CBBIIGHNFLC()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7ED40", Offset = "0x5E7D540", VA = "0x185E7ED40")]
	private void EJODIGNDLGN(EntityQuery OFNMAAAOMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7EA70", Offset = "0x5E7D270", VA = "0x185E7EA70")]
	private void EJODIGNDLGN(NativeArray<Entity> EFAAPEICBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F330", Offset = "0x5E7DB30", VA = "0x185E7F330")]
	private void KDINBAJFNMC(Entity NJBFIEAFGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B40")]
	[Cpp2IlInjected.Address(RVA = "0x5E7EE40", Offset = "0x5E7D640", VA = "0x185E7EE40")]
	private void GFFPPBIEEGE(Entity NJBFIEAFGFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B41")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E680", Offset = "0x5E7CE80", VA = "0x185E7E680")]
	private void CLHAEOMJFBD(SceneTag FECMFMGPNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B42")]
	[Cpp2IlInjected.Address(RVA = "0x5E7EA30", Offset = "0x5E7D230", VA = "0x185E7EA30")]
	private void EFKOCJCFCNM(SceneTag FECMFMGPNMP, NativeParallelHashSet<int> EDOLBHFAIMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B43")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F4C0", Offset = "0x5E7DCC0", VA = "0x185E7F4C0")]
	private void MIMIIBBDOLN(SceneTag FECMFMGPNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B44")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F420", Offset = "0x5E7DC20", VA = "0x185E7F420")]
	private void LEFAHHPHPAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B45")]
	[Cpp2IlInjected.Address(RVA = "0x2471080", Offset = "0x246F880", VA = "0x182471080")]
	private void MLBBGLPNCPO<T>() where T : ComponentSystemBase
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B46")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public MKHOKPNBAOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000212")]
[MMAONKDBHAB(EOGANNGNDMH.PhotonRoom)]
[GJLJLBIABKM(typeof(ABILNOGAPGJ), new string[] { })]
internal class OLHBIEJPDIA : OILIFCGGAMK, ABILNOGAPGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	[MCMLPKDBFJE]
	private MKHOKPNBAOG EFAAPEICBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private readonly Dictionary<int, Entity> CFJPHNPPKNC;

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x5E844B0", Offset = "0x5E82CB0", VA = "0x185E844B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B49")]
	[Cpp2IlInjected.Address(RVA = "0x5E842D0", Offset = "0x5E82AD0", VA = "0x185E842D0", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4A")]
	[Cpp2IlInjected.Address(RVA = "0x5E84360", Offset = "0x5E82B60", VA = "0x185E84360", Slot = "5")]
	public void JLLNHFGFEEH(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4B")]
	[Cpp2IlInjected.Address(RVA = "0x5E84100", Offset = "0x5E82900", VA = "0x185E84100", Slot = "6")]
	public bool HKOIKNLODAH(JEDJBKOCEME JBPJNGFGLPC, Transform KHFCFAPNPDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4C")]
	[Cpp2IlInjected.Address(RVA = "0x5E84500", Offset = "0x5E82D00", VA = "0x185E84500")]
	private bool OJBJJOGNAFA(Scene NJBFIEAFGFF, [Out] Entity FNKMIDANMPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4D")]
	[Cpp2IlInjected.Address(RVA = "0x5E84570", Offset = "0x5E82D70", VA = "0x185E84570")]
	public OLHBIEJPDIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000213")]
[GJLJLBIABKM(typeof(JFFIINNEBJC), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
internal sealed class JFFIINNEBJC : OILIFCGGAMK, OLNFMJBKLAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	[MCMLPKDBFJE]
	private AANOMIFDJAK KOJGLBGNEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private Entity MFFDEAINOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private ComponentTypeList DGNAIPANHEG;

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B4E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AA40", Offset = "0x5E79240", VA = "0x185E7AA40")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4F")]
	[Cpp2IlInjected.Address(RVA = "0x2422F90", Offset = "0x2421790", VA = "0x182422F90")]
	public T BCFBOGKIONB<T>() where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x2422D00", Offset = "0x2421500", VA = "0x182422D00")]
	public void ABNCEPDOIJI<T>(T IFKKLLBODIE) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B51")]
	[Cpp2IlInjected.Address(RVA = "0x24230A0", Offset = "0x24218A0", VA = "0x1824230A0")]
	public DynamicBuffer<T> OKIBOEAEPLE<T>(bool IDKHBHOLPCG = false) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B52")]
	[Cpp2IlInjected.Address(RVA = "0x2422E20", Offset = "0x2421620", VA = "0x182422E20")]
	public void AJDJBNIHIIA<T>(T IFKKLLBODIE) where T : struct, IBufferElementData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B53")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A9D0", Offset = "0x5E791D0", VA = "0x185E7A9D0", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B54")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A7E0", Offset = "0x5E78FE0", VA = "0x185E7A7E0", Slot = "5")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B55")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A7E0", Offset = "0x5E78FE0", VA = "0x185E7A7E0")]
	private void HGNNJEKBCIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B56")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A480", Offset = "0x5E78C80", VA = "0x185E7A480", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B57")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A040", Offset = "0x5E78840", VA = "0x185E7A040")]
	private ComponentTypeList DLJBIHHGMIK()
	{
		return default(ComponentTypeList);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B58")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void OOMILENFKHF(int JEDNJDDHFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B59")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
	private static void JOHMJJEAMNO(Type BJKOKHNAAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5A")]
	[Cpp2IlInjected.Address(RVA = "0x5E79F40", Offset = "0x5E78740", VA = "0x185E79F40")]
	private static void BMCJOMAOPBB(Type BJKOKHNAAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5B")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public JFFIINNEBJC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000214")]
[HNDKOFBMDMB]
internal struct EHLCBEKLAJO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000215")]
[GJLJLBIABKM(typeof(CNMOLKDLNOJ), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
internal sealed class CNMOLKDLNOJ : OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private static readonly PFECAMNMOCE LPFMBEGNMEG;

	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private static readonly PFECAMNMOCE EGCPNGNHFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private IIHIDPNJCHF<IDIPJOFPLOJ, Entity> KMOPCBCCAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	private OINIEIKILEF<PMHIENEJHJB> CKJGNIEKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private OINIEIKILEF<PAFKAIMPJON> FIFMAEJOEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private OINIEIKILEF<MKPNNKAPGAG> OAOOPMLFJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private OINIEIKILEF<HHNKPPBMOAO> GICOKBJMKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private OINIEIKILEF<HAGABGDODAE> JPACBGFEFHP;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public EMBGDJPJLFI<Entity> CNLHECDGFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5D")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public FHCJIGIFBJK CDGDDHDHPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5E")]
		[Cpp2IlInjected.Address(RVA = "0x765E50", Offset = "0x764650", VA = "0x180765E50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public FHCJIGIFBJK DDHELNDOKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5F")]
		[Cpp2IlInjected.Address(RVA = "0x762AE0", Offset = "0x7612E0", VA = "0x180762AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public FHCJIGIFBJK BLIBOMEJCHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B60")]
		[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public FHCJIGIFBJK AJNJHIKKMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B61")]
		[Cpp2IlInjected.Address(RVA = "0x762D40", Offset = "0x761540", VA = "0x180762D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public FHCJIGIFBJK LHBOHCHFOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B62")]
		[Cpp2IlInjected.Address(RVA = "0x762B40", Offset = "0x761340", VA = "0x180762B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x5E71CC0", Offset = "0x5E704C0", VA = "0x185E71CC0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B64")]
	[Cpp2IlInjected.Address(RVA = "0x5E71A80", Offset = "0x5E70280", VA = "0x185E71A80", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B65")]
	[Cpp2IlInjected.Address(RVA = "0x5E71990", Offset = "0x5E70190", VA = "0x185E71990", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B66")]
	[Cpp2IlInjected.Address(RVA = "0x2205EF0", Offset = "0x22046F0", VA = "0x182205EF0")]
	private void LIDOAMKDODG<T>(OINIEIKILEF<T> KBHMBCGILAG, EntityCommandBufferSystem EMPKENPAECO, PFECAMNMOCE ANEILBIOBIP) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B67")]
	[Cpp2IlInjected.Address(RVA = "0x2205FA0", Offset = "0x22047A0", VA = "0x182205FA0")]
	private void LIDOAMKDODG<TC, TV>(IIHIDPNJCHF<TC, TV> KBHMBCGILAG) where TC : struct, AGEJPMDBIMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B68")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public CNMOLKDLNOJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000216")]
public struct PAFKAIMPJON : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000217")]
public struct PMHIENEJHJB : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000218")]
public struct MKPNNKAPGAG : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000219")]
public struct HHNKPPBMOAO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200021A")]
public struct HAGABGDODAE : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200021B")]
[ExecuteAlways]
public class GOJJDABPAIB : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000B6A")]
	[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76F900", VA = "0x180771100")]
	public GOJJDABPAIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021C")]
[GJLJLBIABKM(typeof(GMOCDIHCHDI), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
internal sealed class GMOCDIHCHDI : GAJGABMNKBI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private HALHEDPAIEJ KKKDFMBHPCI;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public HALHEDPAIEJ HBGGFJELBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x1BD9110", Offset = "0x1BD7910", VA = "0x181BD9110")]
		get
		{
			return default(HALHEDPAIEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6C")]
	[Cpp2IlInjected.Address(RVA = "0x5E75AA0", Offset = "0x5E742A0", VA = "0x185E75AA0", Slot = "4")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6D")]
	[Cpp2IlInjected.Address(RVA = "0x5E75A90", Offset = "0x5E74290", VA = "0x185E75A90", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6E")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public GMOCDIHCHDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021D")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(LIGCKOLLPCB), new string[] { })]
internal sealed class LIGCKOLLPCB
{
	[Cpp2IlInjected.Token(Token = "0x200021E")]
	public enum KOHANAOIBID
	{
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		Gameplay,
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		ObjectModel
	}

	[Cpp2IlInjected.Token(Token = "0x200021F")]
	public struct BKOCDKLOFNK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private KOHANAOIBID FFKPDIDAKPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private readonly LIGCKOLLPCB KLGMOMIJPLM;

		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F7E0", Offset = "0x5E6DFE0", VA = "0x185E6F7E0")]
		public BKOCDKLOFNK(LIGCKOLLPCB KLGMOMIJPLM, KOHANAOIBID KCBHFKGPFEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F7C0", Offset = "0x5E6DFC0", VA = "0x185E6F7C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	public KOHANAOIBID KCBHFKGPFEE;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public KOHANAOIBID MJCOBOIJIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x760180", Offset = "0x75E980", VA = "0x180760180")]
		get
		{
			return default(KOHANAOIBID);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B70")]
		[Cpp2IlInjected.Address(RVA = "0x76A380", Offset = "0x768B80", VA = "0x18076A380")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public bool NJKKKDENODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x4FA4970", Offset = "0x4FA3170", VA = "0x184FA4970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B72")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D9F0", Offset = "0x5E7C1F0", VA = "0x185E7D9F0")]
	public BKOCDKLOFNK BLDECBPKGBD()
	{
		return default(BKOCDKLOFNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DA40", Offset = "0x5E7C240", VA = "0x185E7DA40")]
	public BKOCDKLOFNK LCPLIOPNNAH()
	{
		return default(BKOCDKLOFNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B74")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public LIGCKOLLPCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000220")]
[GJLJLBIABKM(typeof(GABKHNGOBOD), new string[] { })]
internal class DMOAKKJPBLH : GABKHNGOBOD, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	[MCMLPKDBFJE]
	private BNPBAMGOGIA FCOGNFMHJDO;

	[Cpp2IlInjected.Token(Token = "0x6000B78")]
	[Cpp2IlInjected.Address(RVA = "0x5E72E00", Offset = "0x5E71600", VA = "0x185E72E00", Slot = "8")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B79")]
	[Cpp2IlInjected.Address(RVA = "0x5E72CF0", Offset = "0x5E714F0", VA = "0x185E72CF0", Slot = "4")]
	public World IMOGAMJLLMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x5E72C50", Offset = "0x5E71450", VA = "0x185E72C50", Slot = "5")]
	public World HPLEAIHCPCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x5E72F80", Offset = "0x5E71780", VA = "0x185E72F80", Slot = "6")]
	public World NENKLEKOHPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x5E72E50", Offset = "0x5E71650", VA = "0x185E72E50", Slot = "7")]
	public World LDOMJPCBOFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7D")]
	[Cpp2IlInjected.Address(RVA = "0x5E72EF0", Offset = "0x5E716F0", VA = "0x185E72EF0")]
	private World MHEDFHHBONA(string BOBHOMKFHJB, IAANKBJLGOO PPFELFEMNEO, Type ICMEIJJPKPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7E")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public DMOAKKJPBLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000221")]
[GJLJLBIABKM(typeof(ALLPNMMCFOG), new string[] { })]
public class NJHPAFEOCNP : OILIFCGGAMK, ALLPNMMCFOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000222")]
	[CompilerGenerated]
	private struct NFKGLKNJBPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public JEDJBKOCEME parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public NJHPAFEOCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public OBODBJKNAJN objBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private EEKEIMNDBGI <parentObject>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private Vector3 <pos>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private Quaternion <rot>5__4;

		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x5E7FEE0", Offset = "0x5E7E6E0", VA = "0x185E7FEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x5E80420", Offset = "0x5E7EC20", VA = "0x185E80420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000223")]
	[CompilerGenerated]
	private struct LDHKMGGIOFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public NJHPAFEOCNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public EEKEIMNDBGI obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B920", Offset = "0x5E7A120", VA = "0x185E7B920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B93")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BD60", Offset = "0x5E7A560", VA = "0x185E7BD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	[MCMLPKDBFJE]
	private NOFHMIDEIDD PEPBPPBDPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private EntityManager DHDOKMIFNAD;

	[Cpp2IlInjected.Token(Token = "0x6000B7F")]
	[Cpp2IlInjected.Address(RVA = "0x5E81E20", Offset = "0x5E80620", VA = "0x185E81E20", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x5E81EC0", Offset = "0x5E806C0", VA = "0x185E81EC0", Slot = "5")]
	public bool JIJMCBPOPLD(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x5E81B90", Offset = "0x5E80390", VA = "0x185E81B90", Slot = "7")]
	public bool EIOBLOPDBJG(JEDJBKOCEME JBPJNGFGLPC, [Out] Guid GHAIFMOEMBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x5E824B0", Offset = "0x5E80CB0", VA = "0x185E824B0", Slot = "8")]
	public Guid OPLDHECNLON(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x5E822D0", Offset = "0x5E80AD0", VA = "0x185E822D0", Slot = "9")]
	public void ODKAAPPFPBO(JEDJBKOCEME JBPJNGFGLPC, Guid GHAIFMOEMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x5E81440", Offset = "0x5E7FC40", VA = "0x185E81440", Slot = "10")]
	public bool AIOGPADGMDO(JEDJBKOCEME JBPJNGFGLPC, [Out] Guid PCPOCGCMPJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x5E81C50", Offset = "0x5E80450", VA = "0x185E81C50", Slot = "11")]
	public Guid HOCFDAIAFLL(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x5E820F0", Offset = "0x5E808F0", VA = "0x185E820F0", Slot = "12")]
	public void NCIKPNOMIED(JEDJBKOCEME JBPJNGFGLPC, Guid PCPOCGCMPJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x5E81F80", Offset = "0x5E80780", VA = "0x185E81F80", Slot = "13")]
	public void KAMCNLOJOMB(JEDJBKOCEME JBPJNGFGLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x5E81600", Offset = "0x5E7FE00", VA = "0x185E81600", Slot = "14")]
	public void DEIMECNJIGL(JEDJBKOCEME HBMBMELELPF, JEDJBKOCEME KLGMOMIJPLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B89")]
	[Cpp2IlInjected.Address(RVA = "0x5E81D10", Offset = "0x5E80510", VA = "0x185E81D10")]
	[AsyncStateMachine(typeof(NFKGLKNJBPN))]
	private Task INKDINOAHKD(OBODBJKNAJN ELGCMCOOFCK, JEDJBKOCEME KLGMOMIJPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8A")]
	[Cpp2IlInjected.Address(RVA = "0x5E81970", Offset = "0x5E80170", VA = "0x185E81970")]
	private void EBOGBHOHCCD(OBODBJKNAJN ELGCMCOOFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x5E82010", Offset = "0x5E80810", VA = "0x185E82010")]
	[AsyncStateMachine(typeof(LDHKMGGIOFK))]
	private Task MBACPNOPKME(EEKEIMNDBGI ELOCHLKHPBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x5E81500", Offset = "0x5E7FD00", VA = "0x185E81500")]
	private Task BECGDKEBGDA(EEKEIMNDBGI ELOCHLKHPBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8D")]
	[Cpp2IlInjected.Address(RVA = "0x5E81B10", Offset = "0x5E80310", VA = "0x185E81B10", Slot = "6")]
	public bool EEIIPDLDMJM(JEDJBKOCEME ADMPFLAIEKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8E")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public NJHPAFEOCNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000224")]
[GJLJLBIABKM(typeof(OBKLJFOEAMA), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
public class OBKLJFOEAMA : OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	[MCMLPKDBFJE]
	private EIGPEOIKDPK HOKINAOAABH;

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x5E83EA0", Offset = "0x5E826A0", VA = "0x185E83EA0", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public OBKLJFOEAMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000225")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(CMMOHNBNCFL), new string[] { })]
internal sealed class CMMOHNBNCFL : OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	[MCMLPKDBFJE]
	private EKGODBBOPGM PPFLBNPCAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	[MCMLPKDBFJE]
	private BCJEDJDJLLI NOLDGDMHJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	[MCMLPKDBFJE]
	private CHHCBHMKOGM PGPBOKMMIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	[MCMLPKDBFJE]
	private ADDMHAJKGOD KGFLJMCCNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	[MCMLPKDBFJE]
	private NFEHBALEDIH EMKFGEMOBLC;

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x5E71590", Offset = "0x5E6FD90", VA = "0x185E71590", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B97")]
	[Cpp2IlInjected.Address(RVA = "0x5E717A0", Offset = "0x5E6FFA0", VA = "0x185E717A0")]
	public void LBMAOBBLIAO(NativeArray<KNBFLDNEILM> PEFPFEIKKIF, NativeArray<KLEIPEFFJCP> BMJMOJMCGHB, NativeArray<Entity> JPMLDNAJPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B98")]
	[Cpp2IlInjected.Address(RVA = "0x5E717E0", Offset = "0x5E6FFE0", VA = "0x185E717E0")]
	public Entity LBMAOBBLIAO(KNBFLDNEILM FGDLEJGCDOG, KLEIPEFFJCP LFHNIGHPLBN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x5E71410", Offset = "0x5E6FC10", VA = "0x185E71410")]
	public Entity ICDNAHMBOHK(KNBFLDNEILM FGDLEJGCDOG, bool JCAFFHKHKGP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x5E713D0", Offset = "0x5E6FBD0", VA = "0x185E713D0")]
	public Entity ICDNAHMBOHK(KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x5E70EF0", Offset = "0x5E6F6F0", VA = "0x185E70EF0")]
	public Entity DNMJJDELJGL()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x5E717F0", Offset = "0x5E6FFF0", VA = "0x185E717F0")]
	public Entity LEGEKJGKEJG(DFMGIJCAPCL BJKOKHNAAID)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x5E70F30", Offset = "0x5E6F730", VA = "0x185E70F30")]
	public LKEHPHAMPJC DNOIDEGKJNI(LKEHPHAMPJC EPMKOOAIFAO, Allocator OPPHPFNHPMG)
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x5E71880", Offset = "0x5E70080", VA = "0x185E71880")]
	public EntityArchetype LGCPFGCBEHB(KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x5E71460", Offset = "0x5E6FC60", VA = "0x185E71460")]
	public Entity HOOEEMONOLC(KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x5E71410", Offset = "0x5E6FC10", VA = "0x185E71410")]
	private Entity HOHMJGDIHDA(KNBFLDNEILM FGDLEJGCDOG, bool JCAFFHKHKGP)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x5E713D0", Offset = "0x5E6FBD0", VA = "0x185E713D0")]
	private Entity HOHMJGDIHDA(KNBFLDNEILM FGDLEJGCDOG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA2")]
	[Cpp2IlInjected.Address(RVA = "0x5E71240", Offset = "0x5E6FA40", VA = "0x185E71240")]
	private Entity HOHMJGDIHDA(KNBFLDNEILM FGDLEJGCDOG, KLEIPEFFJCP LFHNIGHPLBN)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA3")]
	[Cpp2IlInjected.Address(RVA = "0x5E71680", Offset = "0x5E6FE80", VA = "0x185E71680")]
	private void KPHBABPHNIE(KNBFLDNEILM FGDLEJGCDOG, NativeArray<KLEIPEFFJCP> BMJMOJMCGHB, NativeArray<Entity> JPMLDNAJPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x5E70F90", Offset = "0x5E6F790", VA = "0x185E70F90")]
	private void HMMALOFEAOL(NativeArray<KNBFLDNEILM> PEFPFEIKKIF, NativeArray<KLEIPEFFJCP> BMJMOJMCGHB, NativeArray<Entity> JPMLDNAJPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA5")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public CMMOHNBNCFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000226")]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[GJLJLBIABKM(typeof(CHHCBHMKOGM), new string[] { })]
internal sealed class CHHCBHMKOGM : OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	public static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	[MCMLPKDBFJE]
	private HLLCKCNCCJD OHICNBEMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	[MCMLPKDBFJE]
	private EKGODBBOPGM NCFDINLLOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	[MCMLPKDBFJE]
	private BCJEDJDJLLI PGAEIHLHNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	private NativeParallelHashMap<KLEIPEFFJCP, Entity> MAACPLJCKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private EntityManager DHDOKMIFNAD;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	internal NativeParallelHashMap<KLEIPEFFJCP, Entity> APKADANGPOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA7")]
		[Cpp2IlInjected.Address(RVA = "0xD3C790", Offset = "0xD3AF90", VA = "0x180D3C790")]
		get
		{
			return default(NativeParallelHashMap<KLEIPEFFJCP, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	internal uint EMPGLLMOPND
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA8")]
		[Cpp2IlInjected.Address(RVA = "0x5E70340", Offset = "0x5E6EB40", VA = "0x185E70340")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	private bool PLFIBBCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA9")]
		[Cpp2IlInjected.Address(RVA = "0x8485C0", Offset = "0x846DC0", VA = "0x1808485C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAA")]
	[Cpp2IlInjected.Address(RVA = "0x5E70A00", Offset = "0x5E6F200", VA = "0x185E70A00", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAB")]
	[Cpp2IlInjected.Address(RVA = "0x5E70610", Offset = "0x5E6EE10", VA = "0x185E70610", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAC")]
	[Cpp2IlInjected.Address(RVA = "0x5E70DE0", Offset = "0x5E6F5E0", VA = "0x185E70DE0")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAD")]
	[Cpp2IlInjected.Address(RVA = "0x5E70930", Offset = "0x5E6F130", VA = "0x185E70930")]
	public KLEIPEFFJCP IHLBFMCLMOD(int JEDNJDDHFHB)
	{
		return default(KLEIPEFFJCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAE")]
	[Cpp2IlInjected.Address(RVA = "0x5E70B20", Offset = "0x5E6F320", VA = "0x185E70B20")]
	public void JHMFAPBNGCK(KLEIPEFFJCP LFHNIGHPLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAF")]
	[Cpp2IlInjected.Address(RVA = "0x5E707F0", Offset = "0x5E6EFF0", VA = "0x185E707F0")]
	public JEDJBKOCEME FMGHHHBPNNI(KLEIPEFFJCP LFHNIGHPLBN)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB0")]
	[Cpp2IlInjected.Address(RVA = "0x5E70CE0", Offset = "0x5E6F4E0", VA = "0x185E70CE0")]
	public bool ODENBBBJBHB(KLEIPEFFJCP LFHNIGHPLBN, [Out] JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB1")]
	[Cpp2IlInjected.Address(RVA = "0x5E706C0", Offset = "0x5E6EEC0", VA = "0x185E706C0")]
	public LKEHPHAMPJC FMGHHHBPNNI(NativeArray<KLEIPEFFJCP> LFHNIGHPLBN, Allocator OPPHPFNHPMG)
	{
		return default(LKEHPHAMPJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB2")]
	[Cpp2IlInjected.Address(RVA = "0x5E70400", Offset = "0x5E6EC00", VA = "0x185E70400")]
	public KLEIPEFFJCP DFKMDGDCJGD(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(KLEIPEFFJCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB3")]
	[Cpp2IlInjected.Address(RVA = "0x5E70370", Offset = "0x5E6EB70", VA = "0x185E70370")]
	public KLEIPEFFJCP DFKMDGDCJGD(Entity MFFDEAINOPL)
	{
		return default(KLEIPEFFJCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB4")]
	[Cpp2IlInjected.Address(RVA = "0x5E704B0", Offset = "0x5E6ECB0", VA = "0x185E704B0")]
	public void DOOBJONIIIH(NativeArray<Entity> EFLDIIILPLM, NativeArray<KLEIPEFFJCP> BMJMOJMCGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB5")]
	[Cpp2IlInjected.Address(RVA = "0x5E70680", Offset = "0x5E6EE80", VA = "0x185E70680")]
	private JEDJBKOCEME EKFEDJBABPC(Entity MFFDEAINOPL)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB6")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public CHHCBHMKOGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000227")]
[GJLJLBIABKM(typeof(IJGBKLONMFB), new string[] { })]
public sealed class HBDPKEHPKOC : IJGBKLONMFB, ICIOAGALKFA, GAJGABMNKBI, OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D8")]
	[MCMLPKDBFJE]
	private KHMIANHLIDA DCDGDLJLGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private Collider[] POOACGODCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private RaycastHit[] PMDMEBFECIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private DNHFEFFOCGA<KJPNOOMBEMH, BoxCollider> JDAMHDBBOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private Scene NJBFIEAFGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private PhysicsScene JAIAJNFEFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private GameObject NDAADLGGBHN;

	[Cpp2IlInjected.Token(Token = "0x6000BB8")]
	[Cpp2IlInjected.Address(RVA = "0x5E767C0", Offset = "0x5E74FC0", VA = "0x185E767C0", Slot = "9")]
	public void MODHJEAADIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB9")]
	[Cpp2IlInjected.Address(RVA = "0x5E76610", Offset = "0x5E74E10", VA = "0x185E76610", Slot = "10")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBA")]
	[Cpp2IlInjected.Address(RVA = "0x5E75B70", Offset = "0x5E74370", VA = "0x185E75B70", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBB")]
	[Cpp2IlInjected.Address(RVA = "0x5E75EE0", Offset = "0x5E746E0", VA = "0x185E75EE0", Slot = "4")]
	public KJPNOOMBEMH FBGDFKDPALJ(Entity MFFDEAINOPL)
	{
		return default(KJPNOOMBEMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBC")]
	[Cpp2IlInjected.Address(RVA = "0x5E75C80", Offset = "0x5E74480", VA = "0x185E75C80", Slot = "5")]
	public void EGKIELIANDK(NativeArray<KJPNOOMBEMH> FOJKHBGCMEP, NativeArray<BIJOGOIADPC> DPMIOBOIGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBD")]
	[Cpp2IlInjected.Address(RVA = "0x5E76BD0", Offset = "0x5E753D0", VA = "0x185E76BD0", Slot = "6")]
	public void OKIABKAIMMK(KJPNOOMBEMH FJFHMLGEMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBE")]
	[Cpp2IlInjected.Address(RVA = "0x5E76B30", Offset = "0x5E75330", VA = "0x185E76B30", Slot = "7")]
	public bool NIOIIDPGMGC(KJPNOOMBEMH FJFHMLGEMLM, [Out] Collider AFMGELLDLJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBF")]
	[Cpp2IlInjected.Address(RVA = "0x5E761D0", Offset = "0x5E749D0", VA = "0x185E761D0")]
	public bool GAKHGBNKMAO([In] float3 JAKDKBMGPIO, [In] float3 CFFFGOJOPLK, float NCCGMAJNKDF, Allocator OPPHPFNHPMG, [Out] NativeArray<Entity> EFLDIIILPLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC0")]
	[Cpp2IlInjected.Address(RVA = "0x5E75AF0", Offset = "0x5E742F0", VA = "0x185E75AF0")]
	private void BDBPNNDGENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC1")]
	[Cpp2IlInjected.Address(RVA = "0xD354F0", Offset = "0xD33CF0", VA = "0x180D354F0")]
	private void MMMLBDKCHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC2")]
	[Cpp2IlInjected.Address(RVA = "0x5E765C0", Offset = "0x5E74DC0", VA = "0x185E765C0")]
	private void IHLHIINPMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC3")]
	[Cpp2IlInjected.Address(RVA = "0x8438E0", Offset = "0x8420E0", VA = "0x1808438E0")]
	private void MDKHCMPJBGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC4")]
	[Cpp2IlInjected.Address(RVA = "0x5E764B0", Offset = "0x5E74CB0", VA = "0x185E764B0")]
	private BoxCollider HDDMJICHBME(Entity MFFDEAINOPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC5")]
	[Cpp2IlInjected.Address(RVA = "0x5E76720", Offset = "0x5E74F20", VA = "0x185E76720")]
	private void KFEJALDOMDF(BoxCollider IOPKHLOPIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC6")]
	[Cpp2IlInjected.Address(RVA = "0x5E76020", Offset = "0x5E74820", VA = "0x185E76020")]
	private void FKHOFIEHCFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC7")]
	[Cpp2IlInjected.Address(RVA = "0x5E76C90", Offset = "0x5E75490", VA = "0x185E76C90")]
	private void PANPCCBKJJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC8")]
	[Cpp2IlInjected.Address(RVA = "0x5E76920", Offset = "0x5E75120", VA = "0x185E76920")]
	private void NGEBJBCHDNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC9")]
	[Cpp2IlInjected.Address(RVA = "0x5E75B40", Offset = "0x5E74340", VA = "0x185E75B40")]
	private void CMCAFJEJAOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCA")]
	[Cpp2IlInjected.Address(RVA = "0x5E767A0", Offset = "0x5E74FA0", VA = "0x185E767A0")]
	private void LCAGMFIDOAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCB")]
	[Cpp2IlInjected.Address(RVA = "0x5E766E0", Offset = "0x5E74EE0", VA = "0x185E766E0")]
	private void JACHIDBCBLB(Scene MLCHGCANDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCC")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public HBDPKEHPKOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCE")]
	[Cpp2IlInjected.Address(RVA = "0x5E767B0", Offset = "0x5E74FB0", VA = "0x185E767B0", Slot = "8")]
	private bool MLNCMJPOKNE([In] float3 JAKDKBMGPIO, [In] float3 CFFFGOJOPLK, float NCCGMAJNKDF, Allocator OPPHPFNHPMG, [Out] NativeArray<Entity> EFLDIIILPLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000228")]
[GJLJLBIABKM(typeof(HCPGNAKLJFD), new string[] { })]
[MMAONKDBHAB(EOGANNGNDMH.OMRoom)]
[EJJPDJHBEFJ(typeof(HHCNHIPPGNG))]
internal class HCPGNAKLJFD : OILIFCGGAMK, HHCNHIPPGNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	[MCMLPKDBFJE]
	private JCPLFOIFHBP DHNGEFLBADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006E2")]
	private DKDHCMJLDBA JOAJNMMKEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	private NativeList<byte> KOIMDAJNDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E4")]
	private NativeList<MMNLNLKKOGE> BJKLKFHGJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006E5")]
	private NativeList<KIJOINBMBOF> CADHFANFBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006E6")]
	private int HLFOIOOOFDG;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<MMNLNLKKOGE, NativeArray<byte>> IGJKLPGENBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BCF")]
		[Cpp2IlInjected.Address(RVA = "0x5E91D80", Offset = "0x5E90580", VA = "0x185E91D80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BD0")]
		[Cpp2IlInjected.Address(RVA = "0x5E91A00", Offset = "0x5E90200", VA = "0x185E91A00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD1")]
	[Cpp2IlInjected.Address(RVA = "0x5E91C50", Offset = "0x5E90450", VA = "0x185E91C50", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD2")]
	[Cpp2IlInjected.Address(RVA = "0x5E91980", Offset = "0x5E90180", VA = "0x185E91980", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD3")]
	[Cpp2IlInjected.Address(RVA = "0x5E91AB0", Offset = "0x5E902B0", VA = "0x185E91AB0", Slot = "5")]
	public void HKLFJAOHIIH(MMNLNLKKOGE MOHHJLIGFPM, ReadOnlySpan<byte> AJPCNFDACDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD4")]
	[Cpp2IlInjected.Address(RVA = "0x5E91E30", Offset = "0x5E90630", VA = "0x185E91E30")]
	public void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD5")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public HCPGNAKLJFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000229")]
[GJLJLBIABKM(typeof(FLFBKAFPGOO), new string[] { })]
internal class HFJKBBCEGPJ : FLFBKAFPGOO, OILIFCGGAMK, OLNFMJBKLAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200022A")]
	[CompilerGenerated]
	private sealed class JCNECJCDAGK : IEnumerable<JEDJBKOCEME>, IEnumerable, IEnumerator<JEDJBKOCEME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private JEDJBKOCEME <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public HFJKBBCEGPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private JEDJBKOCEME localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public JEDJBKOCEME <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private NativeArray<Entity> <childEntitiesCopy>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private NativeArray<Entity>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		private JEDJBKOCEME System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFC")]
			[Cpp2IlInjected.Address(RVA = "0x3091560", Offset = "0x308FD60", VA = "0x183091560", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JEDJBKOCEME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFE")]
			[Cpp2IlInjected.Address(RVA = "0x5E94D40", Offset = "0x5E93540", VA = "0x185E94D40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x32AECA0", Offset = "0x32AD4A0", VA = "0x1832AECA0")]
		[DebuggerHidden]
		public JCNECJCDAGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0x5E94D90", Offset = "0x5E93590", VA = "0x185E94D90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF9")]
		[Cpp2IlInjected.Address(RVA = "0x5E948B0", Offset = "0x5E930B0", VA = "0x185E948B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFA")]
		[Cpp2IlInjected.Address(RVA = "0x5E94860", Offset = "0x5E93060", VA = "0x185E94860")]
		private void JBGPAKAJJJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x5E94810", Offset = "0x5E93010", VA = "0x185E94810")]
		private void ADBDFKNJMEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x5E94CF0", Offset = "0x5E934F0", VA = "0x185E94CF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x5E94C40", Offset = "0x5E93440", VA = "0x185E94C40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JEDJBKOCEME> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x5E94C40", Offset = "0x5E93440", VA = "0x185E94C40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006E7")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.Token(Token = "0x40006E8")]
	private static readonly PFECAMNMOCE PGPGGIMOMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006ED")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006EE")]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	private LBNHEJPIPLE KBCHPJJCKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006F0")]
	private LAGDCPPJAAI OAEPCFLENGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private DDMJLFGLNGL<Entity> CMHIHEDACFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private DDMJLFGLNGL<float3> DJHKKKGOMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	private DDMJLFGLNGL<quaternion> KKKHONDNJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private DDMJLFGLNGL<float> ELEDKMCCCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private HashSet<Entity> HMPLKDPLAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	private HashSet<Entity> KCPAOGGHNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	private EntityQuery DEEIPLCCDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public Func<FAFPMDAFMJH> PDDCFGOIPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x76F350", Offset = "0x76DB50", VA = "0x18076F350", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x76F2C0", Offset = "0x76DAC0", VA = "0x18076F2C0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<JEDJBKOCEME, JEDJBKOCEME> EMMFDAGNMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0x5E92370", Offset = "0x5E90B70", VA = "0x185E92370", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x5E91F90", Offset = "0x5E90790", VA = "0x185E91F90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<JEDJBKOCEME, JEDJBKOCEME> CCACHDHBGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x5E92D60", Offset = "0x5E91560", VA = "0x185E92D60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BDA")]
		[Cpp2IlInjected.Address(RVA = "0x5E922C0", Offset = "0x5E90AC0", VA = "0x185E922C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JEDJBKOCEME, JEDJBKOCEME, JEDJBKOCEME> DCNKJJMPIND
	{
		[Cpp2IlInjected.Token(Token = "0x6000BDB")]
		[Cpp2IlInjected.Address(RVA = "0x5E92570", Offset = "0x5E90D70", VA = "0x185E92570", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BDC")]
		[Cpp2IlInjected.Address(RVA = "0x5E92A20", Offset = "0x5E91220", VA = "0x185E92A20", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JEDJBKOCEME> FLNBKIJCEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x5E93300", Offset = "0x5E91B00", VA = "0x185E93300", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x5E92620", Offset = "0x5E90E20", VA = "0x185E92620", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE1")]
	[Cpp2IlInjected.Address(RVA = "0x5E93100", Offset = "0x5E91900", VA = "0x185E93100", Slot = "26")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE2")]
	[Cpp2IlInjected.Address(RVA = "0x5E93A60", Offset = "0x5E92260", VA = "0x185E93A60", Slot = "27")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE3")]
	[Cpp2IlInjected.Address(RVA = "0x5E926D0", Offset = "0x5E90ED0", VA = "0x185E926D0", Slot = "28")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE4")]
	[Cpp2IlInjected.Address(RVA = "0x5E92E10", Offset = "0x5E91610", VA = "0x185E92E10")]
	private void HPEAOLNBLGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE5")]
	[Cpp2IlInjected.Address(RVA = "0x5E933B0", Offset = "0x5E91BB0", VA = "0x185E933B0")]
	private void MIACLNFNAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE6")]
	[Cpp2IlInjected.Address(RVA = "0x5E93530", Offset = "0x5E91D30", VA = "0x185E93530")]
	private void MMKKJPGDLDL(ECFICEJMGLN KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x5E93910", Offset = "0x5E92110", VA = "0x185E93910")]
	private void NGCEMGNLGEI(ECFICEJMGLN KOIMDAJNDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x818CE0", Offset = "0x8174E0", VA = "0x180818CE0", Slot = "14")]
	public Color GLBIBCAPKCD(JEDJBKOCEME JBPJNGFGLPC, int ADCGCEAHPOG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x5E92E70", Offset = "0x5E91670", VA = "0x185E92E70", Slot = "15")]
	public float3 IKHFCADGODI(JEDJBKOCEME JBPJNGFGLPC, int ADCGCEAHPOG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x5E93260", Offset = "0x5E91A60", VA = "0x185E93260", Slot = "16")]
	public bool KPICGGKADCC(JEDJBKOCEME JBPJNGFGLPC, JEDJBKOCEME PFHLHDBEOOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x5E92AD0", Offset = "0x5E912D0", VA = "0x185E92AD0", Slot = "17")]
	public JEDJBKOCEME ENBJCEJNJMC(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEC")]
	[Cpp2IlInjected.Address(RVA = "0x5E92420", Offset = "0x5E90C20", VA = "0x185E92420", Slot = "20")]
	public void DFLMEMMFCBP(JEDJBKOCEME JBPJNGFGLPC, Vector3 FPDDPNFNLKP, Quaternion LIKNMKOHLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x5E93F40", Offset = "0x5E92740", VA = "0x185E93F40", Slot = "21")]
	public void OOIOJBCOOGF(JEDJBKOCEME JBPJNGFGLPC, float MAJLENJGEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x5E93070", Offset = "0x5E91870", VA = "0x185E93070", Slot = "24")]
	public float3 IPFBPJDBNDF(KJNJJDIGKBN FEFPHEAOMGP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x5E92CE0", Offset = "0x5E914E0", VA = "0x185E92CE0", Slot = "25")]
	public quaternion GNMKCONEBLP(KJNJJDIGKBN FEFPHEAOMGP)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF0")]
	[Cpp2IlInjected.Address(RVA = "0x5E93730", Offset = "0x5E91F30", VA = "0x185E93730", Slot = "22")]
	public bool NEBPLLMDODA(JEDJBKOCEME JBPJNGFGLPC, [Out] RigidTransform FONOJOLCEDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF1")]
	[Cpp2IlInjected.Address(RVA = "0x5E92B70", Offset = "0x5E91370", VA = "0x185E92B70", Slot = "23")]
	public bool GGDFEGBNEPC(JEDJBKOCEME JBPJNGFGLPC, [Out] float MAJLENJGEMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF2")]
	[Cpp2IlInjected.Address(RVA = "0x5E939D0", Offset = "0x5E921D0", VA = "0x185E939D0", Slot = "18")]
	[IteratorStateMachine(typeof(JCNECJCDAGK))]
	public IEnumerable<JEDJBKOCEME> NHIKPKIKCHH(JEDJBKOCEME JBPJNGFGLPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF3")]
	[Cpp2IlInjected.Address(RVA = "0x5E92160", Offset = "0x5E90960", VA = "0x185E92160", Slot = "19")]
	public JEDJBKOCEME ANFFDKGHAPF(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF4")]
	[Cpp2IlInjected.Address(RVA = "0x5E92040", Offset = "0x5E90840", VA = "0x185E92040")]
	private Entity ANFFDKGHAPF(Entity MFFDEAINOPL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF5")]
	[Cpp2IlInjected.Address(RVA = "0x5E94080", Offset = "0x5E92880", VA = "0x185E94080")]
	public HFJKBBCEGPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022B")]
[GJLJLBIABKM(typeof(AAKMNAOGINP), new string[] { })]
public sealed class DJGDAPFFMJI : AAKMNAOGINP, OILIFCGGAMK
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200022C")]
	private struct KGCKHKCMPIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public float HNGOCCCOBEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public uint KBDNNIDFEPH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	[MCMLPKDBFJE]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	[MCMLPKDBFJE]
	private ICIOAGALKFA CDKMEOJADOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000704")]
	[MCMLPKDBFJE]
	private JPEDMCPMCEO LMJGPIAJFMN;

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x5E906E0", Offset = "0x5E8EEE0", VA = "0x185E906E0", Slot = "5")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x5E90230", Offset = "0x5E8EA30", VA = "0x185E90230")]
	public bool GAKHGBNKMAO([In] float3 JAKDKBMGPIO, [In] float3 CFFFGOJOPLK, float NCCGMAJNKDF, [Out] EJJHCOFCEKO HCELIOKKCLG, [Out] JEDJBKOCEME CPJMAEMAJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x5E90770", Offset = "0x5E8EF70", VA = "0x185E90770")]
	public static bool OLDOLAGPOHH([In] Span<EJJHCOFCEKO> PAONJHAILHH, float NCCGMAJNKDF, [Out] int ADMJKDLHPCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x5E901F0", Offset = "0x5E8E9F0", VA = "0x185E901F0")]
	public static float DFBOPHOGABM(float HNGOCCCOBEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C05")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public DJGDAPFFMJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C06")]
	[Cpp2IlInjected.Address(RVA = "0x5E90220", Offset = "0x5E8EA20", VA = "0x185E90220", Slot = "4")]
	private bool DFHKDGLCFLD([In] float3 JAKDKBMGPIO, [In] float3 CFFFGOJOPLK, float NCCGMAJNKDF, [Out] EJJHCOFCEKO HCELIOKKCLG, [Out] JEDJBKOCEME CPJMAEMAJBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200022D")]
[GJLJLBIABKM(typeof(JPEDMCPMCEO), new string[] { })]
public sealed class HLENGFDIICG : JPEDMCPMCEO, OILIFCGGAMK
{
	[Cpp2IlInjected.Token(Token = "0x200022E")]
	[BurstCompile]
	private struct BMPIPBIBCPO : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		[ReadOnly]
		public NativeArray<Entity> EFLDIIILPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		[ReadOnly]
		public float3 PKCNIDDHCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		[ReadOnly]
		public float3 AHJHOKGHNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> JICPNCIJDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		[ReadOnly]
		public ComponentDataFromEntity<LMGGABKGAOO> BBCLNMBGBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> JCEDGIJIFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		[ReadOnly]
		public ComponentDataFromEntity<HHICHINIONL> INJDFDEHCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		[ReadOnly]
		public ComponentDataFromEntity<LNBJNLHDKEI> BCMPDACODFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		[WriteOnly]
		public NativeArray<EJJHCOFCEKO> DCKAGHMFJED;

		[Cpp2IlInjected.Token(Token = "0x4000711")]
		private static readonly EJJHCOFCEKO PMILBAHLCKH;

		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F430", Offset = "0x5E8DC30", VA = "0x185E8F430", Slot = "4")]
		public void Execute(int ADMJKDLHPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0C")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F380", Offset = "0x5E8DB80", VA = "0x185E8F380")]
		private static float3 DJIHKBNILGE([In] float4x4 INBLDNFNMGD, [In] float3 BGAAPDHNPOH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F7D0", Offset = "0x5E8DFD0", VA = "0x185E8F7D0")]
		private static float3 MEBGCIPFCOK([In] float4x4 INBLDNFNMGD, [In] float3 JOBNHAOLCJM)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F6D0", Offset = "0x5E8DED0", VA = "0x185E8F6D0")]
		private static float3 FFMMJFAHADE([In] float4x4 INBLDNFNMGD, [In] float3 BGAAPDHNPOH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0F")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F1A0", Offset = "0x5E8D9A0", VA = "0x185E8F1A0")]
		private static float3 CIHDLKJKEDE([In] float4x4 INBLDNFNMGD, [In] float3 JOBNHAOLCJM)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C10")]
		[Cpp2IlInjected.Address(RVA = "0x5E8F950", Offset = "0x5E8E150", VA = "0x185E8F950")]
		private bool PLDKPEKABEB([In] float3 JAKDKBMGPIO, [In] float3 CFFFGOJOPLK, [In] NativeArray<Entity> BHEKBHLGFPI, [Out] float3 HCELIOKKCLG, [Out] float3 HOBKDEMPIOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C11")]
		[Cpp2IlInjected.Address(RVA = "0x5E8EB50", Offset = "0x5E8D350", VA = "0x185E8EB50")]
		public static bool ADDNDHMOBJL([In] float3 CGCKKNGJCBN, [In] float3 MGJLCACMFHM, [In] float3 FPJJJCDGKGF, [In] float3 OPNHGONDNPF, float LHEAHINMPGK, float NIKAJNMPIOL, [Out] float KIDCMEILBJC, [Out] float3 DHFKEHJDHFB)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000707")]
	private EntityManager DHDOKMIFNAD;

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x5E94580", Offset = "0x5E92D80", VA = "0x185E94580", Slot = "5")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x5E94140", Offset = "0x5E92940", VA = "0x185E94140")]
	public void GAKHGBNKMAO([In] NativeArray<Entity> EFLDIIILPLM, [In] float3 JAKDKBMGPIO, [In] float3 CFFFGOJOPLK, [In] NativeArray<EJJHCOFCEKO> NIKNKKEHNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C09")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public HLENGFDIICG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0A")]
	[Cpp2IlInjected.Address(RVA = "0x5E94600", Offset = "0x5E92E00", VA = "0x185E94600", Slot = "4")]
	private void PLKADLEGBHA([In] NativeArray<Entity> EFLDIIILPLM, [In] float3 JAKDKBMGPIO, [In] float3 CFFFGOJOPLK, [In] NativeArray<EJJHCOFCEKO> NIKNKKEHNEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022F")]
[GJLJLBIABKM(typeof(LAGDCPPJAAI), new string[] { })]
[EJJPDJHBEFJ(typeof(PMIAAANLCEE))]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
public class LAGDCPPJAAI : PMIAAANLCEE, OILIFCGGAMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000230")]
	private struct OFKAPMDNGIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public IEMADMGHMDI JEFJPALMBKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public Type BJKOKHNAAID;
	}

	[Cpp2IlInjected.Token(Token = "0x2000231")]
	private struct OKLHNFCBGGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public OFKAPMDNGIO[] PBFNCDEJLIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000232")]
	[BurstCompile]
	private struct LCMOKPELGHD : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		[ReadOnly]
		public NativeArray<byte> OBPPEFPPOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		[ReadOnly]
		public NativeArray<Entity> PIAAJHGBOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		[ReadOnly]
		public NativeArray<byte> LGFMBMOPHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		[ReadOnly]
		public NativeArray<byte> JFNHBHAKJIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		[WriteOnly]
		public NativeList<Entity> MDKDEEKMOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		[WriteOnly]
		public NativeList<byte> HNNFCOCKLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		[WriteOnly]
		public NativeList<byte> IFCFPKAFONK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		public int ECKHMGKBPEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public int HGFLBCIKIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public int KFPKNLGONNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public int KLKOABBDJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public int CDOMALEPJHD;

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x5E97880", Offset = "0x5E96080", VA = "0x185E97880", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000712")]
	private static readonly PFECAMNMOCE ANEILBIOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	private readonly Dictionary<BCJCKPDGHHM, IEMADMGHMDI> BKOOIJDDLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private readonly Dictionary<int, OKLHNFCBGGD> KEIKLAGGIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private AACGNIFANPK PBFNCDEJLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action KIFOFCLFMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x5E96830", Offset = "0x5E95030", VA = "0x185E96830")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x5E968D0", Offset = "0x5E950D0", VA = "0x185E968D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action OKOJFIEEBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x5E96010", Offset = "0x5E94810", VA = "0x185E96010")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x5E964E0", Offset = "0x5E94CE0", VA = "0x185E964E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C17")]
	[Cpp2IlInjected.Address(RVA = "0x5E96580", Offset = "0x5E94D80", VA = "0x185E96580", Slot = "6")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C18")]
	[Cpp2IlInjected.Address(RVA = "0x5E95C60", Offset = "0x5E94460", VA = "0x185E95C60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C19")]
	[Cpp2IlInjected.Address(RVA = "0x5E966E0", Offset = "0x5E94EE0", VA = "0x185E966E0", Slot = "4")]
	public void JKCLJMACCFA(CBPEEJLPJDB OLJMCOBAMDO, IEMADMGHMDI LBLABPJPMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1A")]
	[Cpp2IlInjected.Address(RVA = "0x5E96270", Offset = "0x5E94A70", VA = "0x185E96270", Slot = "5")]
	public void HOLDKHPGNLM(CBPEEJLPJDB OLJMCOBAMDO, IEMADMGHMDI LBLABPJPMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1B")]
	[Cpp2IlInjected.Address(RVA = "0x5E965F0", Offset = "0x5E94DF0", VA = "0x185E965F0", Slot = "8")]
	public void JKCLJMACCFA(BCJCKPDGHHM BFLLNKNNDBB, IEMADMGHMDI ELLFKJCIDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1C")]
	[Cpp2IlInjected.Address(RVA = "0x5E963C0", Offset = "0x5E94BC0", VA = "0x185E963C0", Slot = "9")]
	public void HOLDKHPGNLM(BCJCKPDGHHM BFLLNKNNDBB, IEMADMGHMDI ELLFKJCIDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1D")]
	[Cpp2IlInjected.Address(RVA = "0x5E960B0", Offset = "0x5E948B0", VA = "0x185E960B0")]
	private void HAGCAOKKLPK(BCJCKPDGHHM BFLLNKNNDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1E")]
	[Cpp2IlInjected.Address(RVA = "0x5E96970", Offset = "0x5E95170", VA = "0x185E96970")]
	internal void OLDMECCJLCB(DEJBALFFPBL KAFJGNMGLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1F")]
	[Cpp2IlInjected.Address(RVA = "0x5E96C60", Offset = "0x5E95460", VA = "0x185E96C60")]
	private void PDNIFJENCEK(DEJBALFFPBL KAFJGNMGLLD, int GIBOEKFJFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C20")]
	[Cpp2IlInjected.Address(RVA = "0x5E95DC0", Offset = "0x5E945C0", VA = "0x185E95DC0")]
	private void EOMFFDBKHPP(ACMAOFLJBJE ECCHICFFMNK, BEMIKKNENEH MODKBMLJHDK, OFKAPMDNGIO JADKHJLOINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C21")]
	[Cpp2IlInjected.Address(RVA = "0x5E975A0", Offset = "0x5E95DA0", VA = "0x185E975A0")]
	private OKLHNFCBGGD PJPKOGIPEHC(ACMAOFLJBJE ECCHICFFMNK, BEMIKKNENEH MODKBMLJHDK)
	{
		return default(OKLHNFCBGGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C22")]
	[Cpp2IlInjected.Address(RVA = "0x5E95CF0", Offset = "0x5E944F0", VA = "0x185E95CF0")]
	private OFKAPMDNGIO ELJILCKFHJA(OKLHNFCBGGD POCHBOIHANL, ACMAOFLJBJE ECCHICFFMNK, BEMIKKNENEH MODKBMLJHDK)
	{
		return default(OFKAPMDNGIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C23")]
	[Cpp2IlInjected.Address(RVA = "0x5E977B0", Offset = "0x5E95FB0", VA = "0x185E977B0")]
	public LAGDCPPJAAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000233")]
[GJLJLBIABKM(typeof(FICELHLOKNG), new string[] { })]
public class JFJGPPJBMDC : OILIFCGGAMK, OLNFMJBKLAF, FICELHLOKNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000234")]
	[CompilerGenerated]
	private sealed class GNEAGFHFEIE : IEnumerable<JEDJBKOCEME>, IEnumerable, IEnumerator<JEDJBKOCEME>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		private JEDJBKOCEME <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public JFJGPPJBMDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private JEDJBKOCEME splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public JEDJBKOCEME <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		private JEDJBKOCEME System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C3B")]
			[Cpp2IlInjected.Address(RVA = "0x3091560", Offset = "0x308FD60", VA = "0x183091560", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JEDJBKOCEME);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C3D")]
			[Cpp2IlInjected.Address(RVA = "0x5E90C30", Offset = "0x5E8F430", VA = "0x185E90C30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x32AECA0", Offset = "0x32AD4A0", VA = "0x1832AECA0")]
		[DebuggerHidden]
		public GNEAGFHFEIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x5E90A70", Offset = "0x5E8F270", VA = "0x185E90A70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x5E90BE0", Offset = "0x5E8F3E0", VA = "0x185E90BE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x5E90B30", Offset = "0x5E8F330", VA = "0x185E90B30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JEDJBKOCEME> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x5E90B30", Offset = "0x5E8F330", VA = "0x185E90B30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	private HOKKMAFBPHI BAKIPPCJAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private EIGPEOIKDPK HOKINAOAABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private CMMOHNBNCFL FNJHIEAKNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400072C")]
	private ELALIKIJOON PHCBDJMCOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400072D")]
	private JFFIINNEBJC OHLFIPLFDME;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private EntityManager NHMANGHHOMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x5E95760", Offset = "0x5E93F60", VA = "0x185E95760")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C27")]
	[Cpp2IlInjected.Address(RVA = "0x5E951E0", Offset = "0x5E939E0", VA = "0x185E951E0", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C28")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
	public void OEMGKMCKIOP(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C29")]
	[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2A")]
	[Cpp2IlInjected.Address(RVA = "0x5E95680", Offset = "0x5E93E80", VA = "0x185E95680")]
	private void LPNBINHOMFA(Entity BNFENHFMJMI, int ADMJKDLHPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2B")]
	[Cpp2IlInjected.Address(RVA = "0x5E94F60", Offset = "0x5E93760", VA = "0x185E94F60", Slot = "10")]
	public void BHFPONILALJ(JEDJBKOCEME JBPJNGFGLPC, BHBLOOFPBII HIKDFDIFDNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2C")]
	[Cpp2IlInjected.Address(RVA = "0x5E95A90", Offset = "0x5E94290", VA = "0x185E95A90", Slot = "9")]
	public BHBLOOFPBII PKICGDOOCHG(JEDJBKOCEME JBPJNGFGLPC)
	{
		return default(BHBLOOFPBII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2D")]
	[Cpp2IlInjected.Address(RVA = "0x5E95170", Offset = "0x5E93970", VA = "0x185E95170", Slot = "11")]
	public JEDJBKOCEME EPKAANPGFPP(JEDJBKOCEME KCJHMICPJMI, [Optional] float3? OBAACBLACLC, [Optional] quaternion? AHLHKGGFBGH, [Optional] float3? CDLIHEJMBGO)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2E")]
	[Cpp2IlInjected.Address(RVA = "0x5E957B0", Offset = "0x5E93FB0", VA = "0x185E957B0", Slot = "12")]
	public JEDJBKOCEME OJAECIPOLAJ(JEDJBKOCEME KCJHMICPJMI, int ADMJKDLHPCI, [Optional] float3? OBAACBLACLC, [Optional] quaternion? AHLHKGGFBGH, [Optional] float3? CDLIHEJMBGO)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2F")]
	[Cpp2IlInjected.Address(RVA = "0x5E95820", Offset = "0x5E94020", VA = "0x185E95820")]
	private JEDJBKOCEME PEOIOMFCLBF(JEDJBKOCEME KCJHMICPJMI, int ADMJKDLHPCI, [Optional] float3? OBAACBLACLC, [Optional] quaternion? AHLHKGGFBGH, [Optional] float3? CDLIHEJMBGO)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C30")]
	[Cpp2IlInjected.Address(RVA = "0x5E95000", Offset = "0x5E93800", VA = "0x185E95000", Slot = "7")]
	public JEDJBKOCEME CAEMJNGCCEJ(JEDJBKOCEME KCJHMICPJMI, int ADMJKDLHPCI)
	{
		return default(JEDJBKOCEME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C31")]
	[Cpp2IlInjected.Address(RVA = "0x5E95700", Offset = "0x5E93F00", VA = "0x185E95700", Slot = "16")]
	public void MCFIMJKCMDO(JEDJBKOCEME KCJHMICPJMI, JEDJBKOCEME BNFENHFMJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C32")]
	[Cpp2IlInjected.Address(RVA = "0x5E95560", Offset = "0x5E93D60", VA = "0x185E95560", Slot = "13")]
	public void LLCEFGLJOCI(JEDJBKOCEME KCJHMICPJMI, int ADMJKDLHPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C33")]
	[Cpp2IlInjected.Address(RVA = "0x5E952D0", Offset = "0x5E93AD0", VA = "0x185E952D0", Slot = "14")]
	public void KJLDKFCGMLK(JEDJBKOCEME KCJHMICPJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C34")]
	[Cpp2IlInjected.Address(RVA = "0x5E95B30", Offset = "0x5E94330", VA = "0x185E95B30", Slot = "8")]
	public int PPFDBIGIDOE(JEDJBKOCEME KCJHMICPJMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C35")]
	[Cpp2IlInjected.Address(RVA = "0x5E950E0", Offset = "0x5E938E0", VA = "0x185E950E0", Slot = "6")]
	[IteratorStateMachine(typeof(GNEAGFHFEIE))]
	public IEnumerable<JEDJBKOCEME> CGGFHGGMLOG(JEDJBKOCEME KCJHMICPJMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C36")]
	[Cpp2IlInjected.Address(RVA = "0x5E94ED0", Offset = "0x5E936D0", VA = "0x185E94ED0")]
	private bool ABKHFCECJBC(JEDJBKOCEME KCJHMICPJMI, [Out] NativeArray<Entity> PGJEDFCLFOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C37")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public JFJGPPJBMDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000235")]
[MMAONKDBHAB(EOGANNGNDMH.LoadInstance)]
[GJLJLBIABKM(typeof(LFOCKLFEMOE), new string[] { })]
internal sealed class LFOCKLFEMOE : OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000736")]
	private HLLCKCNCCJD LPBOBKJPICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000737")]
	private LIGCKOLLPCB BCBHEKMMHLN;

	[Cpp2IlInjected.Token(Token = "0x6000C40")]
	[Cpp2IlInjected.Address(RVA = "0x5E97A40", Offset = "0x5E96240", VA = "0x185E97A40", Slot = "4")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C41")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public LFOCKLFEMOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000236")]
[DefaultMember("Item")]
public struct HPLKHOFPJBF<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private T[] KOIMDAJNDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000739")]
	private int OOHKMCMOCLB;

	[Cpp2IlInjected.Token(Token = "0x6000C42")]
	[Cpp2IlInjected.Address(RVA = "0x35B9480", Offset = "0x35B7C80", VA = "0x1835B9480", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000237")]
[DefaultMember("Item")]
public struct FFCHFLGDMFL<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073A")]
	private HPLKHOFPJBF<T> KOIMDAJNDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	private int OOHKMCMOCLB;

	[Cpp2IlInjected.Token(Token = "0x6000C43")]
	[Cpp2IlInjected.Address(RVA = "0x3381E80", Offset = "0x3380680", VA = "0x183381E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C44")]
	[Cpp2IlInjected.Address(RVA = "0x3381EC0", Offset = "0x33806C0", VA = "0x183381EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000238")]
public struct HALHEDPAIEJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	private NativeList<Entity> EFLDIIILPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	private TransformAccessArray NBODHKFBPEC;

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public int EAAIJEAHMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000C46")]
		[Cpp2IlInjected.Address(RVA = "0x5E90CC0", Offset = "0x5E8F4C0", VA = "0x185E90CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public NativeList<Entity> BEAKBDKOLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0xA70080", Offset = "0xA6E880", VA = "0x180A70080")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public TransformAccessArray PGFAIMAGJAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x761490", VA = "0x180762C90")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public bool PLFIBBCFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x5E90F20", Offset = "0x5E8F720", VA = "0x185E90F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C45")]
	[Cpp2IlInjected.Address(RVA = "0x5E90F40", Offset = "0x5E8F740", VA = "0x185E90F40")]
	public HALHEDPAIEJ(int OLEHEDGFINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4A")]
	[Cpp2IlInjected.Address(RVA = "0x5E90E80", Offset = "0x5E8F680", VA = "0x185E90E80")]
	public Entity GHAFPDMIIGN(int ADMJKDLHPCI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4B")]
	[Cpp2IlInjected.Address(RVA = "0x5E90ED0", Offset = "0x5E8F6D0", VA = "0x185E90ED0")]
	public void HODMLIODGGJ(int OLEHEDGFINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4C")]
	[Cpp2IlInjected.Address(RVA = "0x5E90D50", Offset = "0x5E8F550", VA = "0x185E90D50")]
	public int EIGFNHEIDIC(Transform KHFCFAPNPDN, Entity MFFDEAINOPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4D")]
	[Cpp2IlInjected.Address(RVA = "0x5E90E10", Offset = "0x5E8F610", VA = "0x185E90E10")]
	public int EOHNHBLINCA(int ADMJKDLHPCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4E")]
	[Cpp2IlInjected.Address(RVA = "0x5E90CD0", Offset = "0x5E8F4D0", VA = "0x185E90CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4F")]
	[Cpp2IlInjected.Address(RVA = "0x5E90C80", Offset = "0x5E8F480", VA = "0x185E90C80")]
	private void BLLEJAJGEGJ(int GIKENKNJOHO = 0)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000239")]
public struct NHBACKKIHKF : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x400073E")]
	public static readonly NHBACKKIHKF LMLHJGLFPJN;

	[Cpp2IlInjected.Token(Token = "0x6000C50")]
	[Cpp2IlInjected.Address(RVA = "0x5E97B00", Offset = "0x5E96300", VA = "0x185E97B00", Slot = "4")]
	public bool Equals(LinkedEntityGroup GEKAGOANEHP, LinkedEntityGroup KFCLHHAJEPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C51")]
	[Cpp2IlInjected.Address(RVA = "0x5E97B20", Offset = "0x5E96320", VA = "0x185E97B20", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup ELOCHLKHPBP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200023A")]
internal class KBHKGDIKJNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000C52")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public KBHKGDIKJNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023B")]
public struct MACOEFMOGFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073F")]
	public Entity MFFDEAINOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	public Entity HPAAJPNIILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000741")]
	public Entity IKMOPDEAPOG;

	[Cpp2IlInjected.Token(Token = "0x6000C53")]
	[Cpp2IlInjected.Address(RVA = "0x4316E50", Offset = "0x4315650", VA = "0x184316E50")]
	public MACOEFMOGFA(Entity MFFDEAINOPL, Entity HPAAJPNIILF, Entity IKMOPDEAPOG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C54")]
	[Cpp2IlInjected.Address(RVA = "0x5E97AC0", Offset = "0x5E962C0", VA = "0x185E97AC0")]
	public static MACOEFMOGFA DAOGIJOJDNF((Entity entity, Entity oldParent, Entity newParent) CFEHLAIPKBD)
	{
		return default(MACOEFMOGFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C55")]
	[Cpp2IlInjected.Address(RVA = "0x5E97AE0", Offset = "0x5E962E0", VA = "0x185E97AE0")]
	public void IDOGKACACAK([Out] Entity MFFDEAINOPL, [Out] Entity HPAAJPNIILF, [Out] Entity IKMOPDEAPOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023C")]
public struct KPDILCFCHEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000742")]
	public Entity MFFDEAINOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	public Entity KLGMOMIJPLM;

	[Cpp2IlInjected.Token(Token = "0x6000C56")]
	[Cpp2IlInjected.Address(RVA = "0x1FD8570", Offset = "0x1FD6D70", VA = "0x181FD8570")]
	public KPDILCFCHEL(Entity MFFDEAINOPL, Entity KLGMOMIJPLM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C57")]
	[Cpp2IlInjected.Address(RVA = "0x5E95C30", Offset = "0x5E94430", VA = "0x185E95C30")]
	public static KPDILCFCHEL DAOGIJOJDNF((Entity entity, Entity parent) CFEHLAIPKBD)
	{
		return default(KPDILCFCHEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C58")]
	[Cpp2IlInjected.Address(RVA = "0x5E95C50", Offset = "0x5E94450", VA = "0x185E95C50")]
	public void IDOGKACACAK([Out] Entity MFFDEAINOPL, [Out] Entity KLGMOMIJPLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023D")]
public struct CNIBCGMKPDG<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000744")]
	private GCHandle FJFHMLGEMLM;

	[Cpp2IlInjected.Token(Token = "0x6000C59")]
	[Cpp2IlInjected.Address(RVA = "0x4AFF0E0", Offset = "0x4AFD8E0", VA = "0x184AFF0E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023E")]
public enum MFGFPBHKJCF
{
	[Cpp2IlInjected.Token(Token = "0x4000746")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x4000747")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x200023F")]
public struct GMAONOHMLPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000749")]
	public MFGFPBHKJCF CEIJCNCAKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	public int BDHAGEEEGGE;

	[Cpp2IlInjected.Token(Token = "0x6000C5A")]
	[Cpp2IlInjected.Address(RVA = "0x978550", Offset = "0x976D50", VA = "0x180978550")]
	public GMAONOHMLPJ(MFGFPBHKJCF CEIJCNCAKII, int BDHAGEEEGGE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C5B")]
	[Cpp2IlInjected.Address(RVA = "0x5D80B70", Offset = "0x5D7F370", VA = "0x185D80B70")]
	public static GMAONOHMLPJ DAOGIJOJDNF((MFGFPBHKJCF eventType, int eventIndex) GEKAGOANEHP)
	{
		return default(GMAONOHMLPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5C")]
	[Cpp2IlInjected.Address(RVA = "0x5E90A60", Offset = "0x5E8F260", VA = "0x185E90A60")]
	public void IDOGKACACAK([Out] MFGFPBHKJCF CEIJCNCAKII, [Out] int BDHAGEEEGGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000240")]
[GJLJLBIABKM(typeof(ICIOAGALKFA), new string[] { })]
public sealed class HBNOLAPOOFE : ICIOAGALKFA, OILIFCGGAMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	private IJGBKLONMFB AHKNCPFBOMH;

	[Cpp2IlInjected.Token(Token = "0x6000C5D")]
	[Cpp2IlInjected.Address(RVA = "0x5E91930", Offset = "0x5E90130", VA = "0x185E91930", Slot = "5")]
	public void InitReferences(FHMIKLMEDIH CNFBLEFPNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5E")]
	[Cpp2IlInjected.Address(RVA = "0x5E91890", Offset = "0x5E90090", VA = "0x185E91890")]
	public bool GAKHGBNKMAO([In] float3 JAKDKBMGPIO, [In] float3 CFFFGOJOPLK, float NCCGMAJNKDF, Allocator OPPHPFNHPMG, [Out] NativeArray<Entity> EFLDIIILPLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5F")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public HBNOLAPOOFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x5E91890", Offset = "0x5E90090", VA = "0x185E91890", Slot = "4")]
	private bool MLNCMJPOKNE([In] float3 JAKDKBMGPIO, [In] float3 CFFFGOJOPLK, float NCCGMAJNKDF, Allocator OPPHPFNHPMG, [Out] NativeArray<Entity> EFLDIIILPLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000241")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
public sealed class HOKFLKLGDJE : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x5E94610", Offset = "0x5E92E10", VA = "0x185E94610", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public HOKFLKLGDJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000242")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal sealed class HBFOLNAMIPE : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x5E90FD0", Offset = "0x5E8F7D0", VA = "0x185E90FD0", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public HBFOLNAMIPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000243")]
internal class AIBKMMDEEII : MNKKMIDHEPO
{
	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public AIBKMMDEEII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000244")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal sealed class AOHAOKMIAAJ : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EA80", Offset = "0x5E8D280", VA = "0x185E8EA80", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public AOHAOKMIAAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000245")]
internal class HEOEMILPECP : MHKLBPFNJCC
{
	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	protected override LOJLFKPHDDJ EHLJIPBNICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x7E11F0", Offset = "0x7DF9F0", VA = "0x1807E11F0", Slot = "17")]
		get
		{
			return default(LOJLFKPHDDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x5E91F40", Offset = "0x5E90740", VA = "0x185E91F40")]
	public HEOEMILPECP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000246")]
[PDJDECBPOKH(EOGANNGNDMH.LoadInstance)]
internal sealed class CAANKOFHBPB : MGKMOGBIDJL
{
	[Cpp2IlInjected.Token(Token = "0x6000C6A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FCA0", Offset = "0x5E8E4A0", VA = "0x185E8FCA0", Slot = "15")]
	protected override ComponentSystemBase AEELHFJDNIO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD06F0", Offset = "0x5DCEEF0", VA = "0x185DD06F0")]
	public CAANKOFHBPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000247")]
[NJDDBDEFGHJ(typeof(JOPODPIMFPC))]
public sealed class EHPLCBOMBGH : JKEPIIOOLIB
{
	[Cpp2IlInjected.Token(Token = "0x6000C6C")]
	[Cpp2IlInjected.Address(RVA = "0x5E90850", Offset = "0x5E8F050", VA = "0x185E90850", Slot = "8")]
	protected override bool BPCMDPCPAMD(ReadOnlySpan<JOPODPIMFPC> KBLIOPDOHJK, NMKCGFFAGNA MDDDOHLBGMH, [Out] ReadOnlySpan<byte> BGGDIKOMABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6D")]
	[Cpp2IlInjected.Address(RVA = "0x5E90950", Offset = "0x5E8F150", VA = "0x185E90950", Slot = "9")]
	protected override bool NKHIEONAJFJ(int OJAHFIICKFC, Span<JOPODPIMFPC> KBLIOPDOHJK, [In] ReadOnlySpan<byte> BGGDIKOMABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6E")]
	[Cpp2IlInjected.Address(RVA = "0x5E90A50", Offset = "0x5E8F250", VA = "0x185E90A50")]
	public EHPLCBOMBGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000248")]
[NJDDBDEFGHJ(typeof(EBOGGEGJLCM))]
public sealed class OEBCBBJOJLM : PLAGGKEBGAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000C6F")]
	[Cpp2IlInjected.Address(RVA = "0x5E97B80", Offset = "0x5E96380", VA = "0x185E97B80", Slot = "8")]
	protected override bool BPCMDPCPAMD(ReadOnlySpan<EBOGGEGJLCM> KBLIOPDOHJK, NMKCGFFAGNA MDDDOHLBGMH, [Out] ReadOnlySpan<byte> BGGDIKOMABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C70")]
	[Cpp2IlInjected.Address(RVA = "0x5E97C80", Offset = "0x5E96480", VA = "0x185E97C80", Slot = "9")]
	protected override bool NKHIEONAJFJ(int OJAHFIICKFC, Span<EBOGGEGJLCM> KBLIOPDOHJK, [In] ReadOnlySpan<byte> BGGDIKOMABC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C71")]
	[Cpp2IlInjected.Address(RVA = "0x5E97D80", Offset = "0x5E96580", VA = "0x185E97D80")]
	public OEBCBBJOJLM()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000249")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : FNNEAFKGECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000C72")]
		[Cpp2IlInjected.Address(RVA = "0x78B4D0", Offset = "0x789CD0", VA = "0x18078B4D0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C73")]
		[Cpp2IlInjected.Address(RVA = "0x5E981D0", Offset = "0x5E969D0", VA = "0x185E981D0", Slot = "6")]
		public sealed override void ONAHLMMGDBM(FHBMMBMHFBC ELLFKJCIDIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C74")]
		[Cpp2IlInjected.Address(RVA = "0x5E98010", Offset = "0x5E96810", VA = "0x185E98010", Slot = "4")]
		public sealed override void MGHEMDEKAOB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200024A")]
internal class __UnmanagedPostProcessorOutput__2569481698
{
	[Cpp2IlInjected.Token(Token = "0x6000C75")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A360", Offset = "0x5E98B60", VA = "0x185E9A360")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024B")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2569481698
{
	[Cpp2IlInjected.Token(Token = "0x6000C76")]
	[Cpp2IlInjected.Address(RVA = "0x5E99300", Offset = "0x5E97B00", VA = "0x185E99300")]
	public static void JDIEILCBNPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C77")]
	[Cpp2IlInjected.Address(RVA = "0x5E992F0", Offset = "0x5E97AF0", VA = "0x185E992F0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024C")]
internal class OMLBMPDDFEI : ContainerPropertyBag<JMDAIJBHIFE>
{
	[Cpp2IlInjected.Token(Token = "0x200024D")]
	private class JIGBHJJMMGA : Property<JMDAIJBHIFE, HFBIDPNKJHF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		public override string MJLCABAKOPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C79")]
			[Cpp2IlInjected.Address(RVA = "0x5E95C00", Offset = "0x5E94400", VA = "0x185E95C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		public override bool FCEGNANDKHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000C7A")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7B")]
		[Cpp2IlInjected.Address(RVA = "0x5E95BC0", Offset = "0x5E943C0", VA = "0x185E95BC0")]
		public JIGBHJJMMGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7C")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7C0", Offset = "0x5D4CFC0", VA = "0x185D4E7C0", Slot = "14")]
		public override HFBIDPNKJHF GetValue(JMDAIJBHIFE DJDFFLPPHHA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7D")]
		[Cpp2IlInjected.Address(RVA = "0x5D4E7E0", Offset = "0x5D4CFE0", VA = "0x185D4E7E0", Slot = "15")]
		public override void SetValue(JMDAIJBHIFE DJDFFLPPHHA, HFBIDPNKJHF IFKKLLBODIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C78")]
	[Cpp2IlInjected.Address(RVA = "0x5E97D90", Offset = "0x5E96590", VA = "0x185E97D90")]
	public OMLBMPDDFEI()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200024E")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000C7E")]
		[Cpp2IlInjected.Address(RVA = "0x5E97E70", Offset = "0x5E96670", VA = "0x185E97E70")]
		[UnityEngine.Scripting.Preserve]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
		public static void Initialize()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200024F")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x5E97F90", Offset = "0x5E96790", VA = "0x185E97F90")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000250")]
public class OBJMCPPPHHO
{
	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	public OBJMCPPPHHO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000251")]
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
