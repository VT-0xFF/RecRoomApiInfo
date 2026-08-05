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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x2267DD0", Offset = "0x2266BD0", VA = "0x182267DD0")]
		public static KEFPGANLAHK<T> CreateTemporarySingleton<T>(this EntityManager entityManager, T componentData) where T : struct, IComponentData
		{
			return default(KEFPGANLAHK<T>);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct NBFJMIIBBPO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PBAOBINEJJG]
public static class NDJCBCMHAHA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DE66C0", Offset = "0x5DE54C0", VA = "0x185DE66C0")]
	static NDJCBCMHAHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24DCEF0", Offset = "0x24DBCF0", VA = "0x1824DCEF0")]
	public static void BOBJGBBPJMA<T>(T ECAFGEFAJGI, T HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6690", Offset = "0x5DE5490", VA = "0x185DE6690")]
	public static void BOBJGBBPJMA(FixedString32Bytes ECAFGEFAJGI, string HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6420", Offset = "0x5DE5220", VA = "0x185DE6420")]
	public static void BOBJGBBPJMA(string ECAFGEFAJGI, FixedString32Bytes HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DE64C0", Offset = "0x5DE52C0", VA = "0x185DE64C0")]
	public static void BOBJGBBPJMA(FixedString64Bytes ECAFGEFAJGI, string HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6520", Offset = "0x5DE5320", VA = "0x185DE6520")]
	public static void BOBJGBBPJMA(string ECAFGEFAJGI, FixedString64Bytes HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE65B0", Offset = "0x5DE53B0", VA = "0x185DE65B0")]
	public static void BOBJGBBPJMA(FixedList32Bytes<int> ECAFGEFAJGI, AIBCHGBGFOP HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE61E0", Offset = "0x5DE4FE0", VA = "0x185DE61E0")]
	public static void BOBJGBBPJMA(AIBCHGBGFOP ECAFGEFAJGI, FixedList32Bytes<int> HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE61B0", Offset = "0x5DE4FB0", VA = "0x185DE61B0")]
	public static void BOBJGBBPJMA(CLIKANANOBK ECAFGEFAJGI, Vector3 HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D18120", Offset = "0x5D16F20", VA = "0x185D18120")]
	public static void BOBJGBBPJMA(Vector3 ECAFGEFAJGI, CLIKANANOBK HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6660", Offset = "0x5DE5460", VA = "0x185DE6660")]
	public static void BOBJGBBPJMA(DJFDPAFHJOM ECAFGEFAJGI, Vector4 HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D18B30", Offset = "0x5D17930", VA = "0x185D18B30")]
	public static void BOBJGBBPJMA(Vector4 ECAFGEFAJGI, DJFDPAFHJOM HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6660", Offset = "0x5DE5460", VA = "0x185DE6660")]
	public static void BOBJGBBPJMA(DJFDPAFHJOM ECAFGEFAJGI, Quaternion HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D18B30", Offset = "0x5D17930", VA = "0x185D18B30")]
	public static void BOBJGBBPJMA(Quaternion ECAFGEFAJGI, DJFDPAFHJOM HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6580", Offset = "0x5DE5380", VA = "0x185DE6580")]
	public static void BOBJGBBPJMA(CLIKANANOBK ECAFGEFAJGI, float3 HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D18120", Offset = "0x5D16F20", VA = "0x185D18120")]
	public static void BOBJGBBPJMA(float3 ECAFGEFAJGI, CLIKANANOBK HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5DE63C0", Offset = "0x5DE51C0", VA = "0x185DE63C0")]
	public static void BOBJGBBPJMA(DJFDPAFHJOM ECAFGEFAJGI, float4 HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D18B30", Offset = "0x5D17930", VA = "0x185D18B30")]
	public static void BOBJGBBPJMA(float4 ECAFGEFAJGI, DJFDPAFHJOM HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5DE63C0", Offset = "0x5DE51C0", VA = "0x185DE63C0")]
	public static void BOBJGBBPJMA(DJFDPAFHJOM ECAFGEFAJGI, quaternion HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6460", Offset = "0x5DE5260", VA = "0x185DE6460")]
	public static void BOBJGBBPJMA(quaternion ECAFGEFAJGI, DJFDPAFHJOM HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DE63E0", Offset = "0x5DE51E0", VA = "0x185DE63E0")]
	public static void BOBJGBBPJMA(Entity ECAFGEFAJGI, NFFPNACNLLK HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DE64F0", Offset = "0x5DE52F0", VA = "0x185DE64F0")]
	public static void BOBJGBBPJMA(NFFPNACNLLK ECAFGEFAJGI, Entity HPMEJLCHJFA, KGPPHNCOAFD DPJAFHOCHKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal class APJCIJOKBLP : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAF60", Offset = "0x5DC9D60", VA = "0x185DCAF60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB010", Offset = "0x5DC9E10", VA = "0x185DCB010", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public APJCIJOKBLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[MDNKGKCJEFA(LJHGMNIEOPD.OMRoom)]
internal class BCEGKLOMJKG : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GCIHPKBFCDJ FFJHPLHPBBD;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB3D0", Offset = "0x5DCA1D0", VA = "0x185DCB3D0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB420", Offset = "0x5DCA220", VA = "0x185DCB420", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public BCEGKLOMJKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[UnityEngine.Scripting.Preserve]
internal class AIAKAMLLNHF : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private EntityQuery NAMACGEHCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAE40", Offset = "0x5DC9C40", VA = "0x185DCAE40", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAE90", Offset = "0x5DC9C90", VA = "0x185DCAE90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAF20", Offset = "0x5DC9D20", VA = "0x185DCAF20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public AIAKAMLLNHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[MDNKGKCJEFA(LJHGMNIEOPD.OMRoom)]
internal class OIAFAEPBOHB : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private GCIHPKBFCDJ FFJHPLHPBBD;

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAA10", Offset = "0x5DE9810", VA = "0x185DEAA10", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAA60", Offset = "0x5DE9860", VA = "0x185DEAA60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public OIAFAEPBOHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[MDNKGKCJEFA(LJHGMNIEOPD.OMRoom)]
internal class FHAGJNJMMDG : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private PAPIHHEIJJK GAKKCIMPKEC;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8220", Offset = "0x5DD7020", VA = "0x185DD8220", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8270", Offset = "0x5DD7070", VA = "0x185DD8270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public FHAGJNJMMDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[UnityEngine.Scripting.Preserve]
internal sealed class KJNOBBNNBFM<T> : DBMABBOGEPD where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x38C3140", Offset = "0x38C1F40", VA = "0x1838C3140", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x38C32A0", Offset = "0x38C20A0", VA = "0x1838C32A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public KJNOBBNNBFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[FKLDPMHNDNC]
public class HEAHEPJCPGN : ComponentSystem, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private NFHEEPPLDKB MJEEFGLGOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x765480", Offset = "0x764280", VA = "0x180765480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private JKLFCEOIENH NAADNBFJFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x765490", Offset = "0x764290", VA = "0x180765490")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB1C0", Offset = "0x5DD9FC0", VA = "0x185DDB1C0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
	public HEAHEPJCPGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class DKGDJFIKFKL : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5330", Offset = "0x5DD4130", VA = "0x185DD5330", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5DD52A0", Offset = "0x5DD40A0", VA = "0x185DD52A0")]
	[UnityEngine.Scripting.Preserve]
	private void IOLIDGILAEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public DKGDJFIKFKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class GJHPPEGAKEM : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9590", Offset = "0x5DD8390", VA = "0x185DD9590", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public GJHPPEGAKEM()
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5DEAB90", Offset = "0x5DE9990", VA = "0x185DEAB90")]
		public static ObjectModelConfigAsset LKLDDMEKEJO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84A0A0", Offset = "0x848EA0", VA = "0x18084A0A0")]
		public ObjectModelConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AHNOJCGKPNA
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCABC0", Offset = "0x5DC99C0", VA = "0x185DCABC0")]
	public static void DHCJKJBKCBD(HICMFDICNOL DFCBIKLJFPD, string KEFCEHIDKHM, EPCANLGBBON BJFBENEOJHB, Action NPGBADJBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA980", Offset = "0x5DC9780", VA = "0x185DCA980")]
	public static void DHCJKJBKCBD(HICMFDICNOL DFCBIKLJFPD, string KEFCEHIDKHM, LLKJHKLONBK DANLCHGFNNC, Action NPGBADJBLCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCAC20", Offset = "0x5DC9A20", VA = "0x185DCAC20")]
	public static void LCPJDMFAJLG(HICMFDICNOL DFCBIKLJFPD, string KEFCEHIDKHM, EPCANLGBBON GOOJPBOEHHC, Exception KHAMCNNBIHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class DCJLMGADKMP
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ODFEODAGBJP
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class JGDOMLCNPPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly HICMFDICNOL DFCBIKLJFPD;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEB90", Offset = "0x5DDD990", VA = "0x185DDEB90")]
		public static GFPOPKJOMLL FKNEIIFEJAE(int EOJOAPBJJCD, AHOAFPGEKED BJKAIBLEACD)
		{
			return default(GFPOPKJOMLL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEB00", Offset = "0x5DDD900", VA = "0x185DDEB00")]
		private static EPCANLGBBON FFJNLAANGLO(AHOAFPGEKED KCLAIPDEGPB, EPCANLGBBON NEDBIKAEHEB)
		{
			return default(EPCANLGBBON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5DDEEF0", Offset = "0x5DDDCF0", VA = "0x185DDEEF0")]
		private static void HIICIEEGDEN(EPCANLGBBON EDLJDDOJBDP, EPCANLGBBON AIGGHJPEENF, GFPOPKJOMLL OEAOJAGKHME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF070", Offset = "0x5DDDE70", VA = "0x185DDF070")]
		public static int LAHHCDJJMBF(GameObject LEMKPNELLPI, AGOGLMPMEDI FDJBFGKCDJB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static GOKBGBKDEJH ILMLJDANMJI;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static FOANHFHLHAH EDBIBDGOGHN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static FOANHFHLHAH GGJEBBNJCFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8AC0", Offset = "0x5DE78C0", VA = "0x185DE8AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool JDPBAHFKJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8600", Offset = "0x5DE7400", VA = "0x185DE8600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NFHEEPPLDKB MJEEFGLGOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8F40", Offset = "0x5DE7D40", VA = "0x185DE8F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static JKLFCEOIENH NAADNBFJFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8FC0", Offset = "0x5DE7DC0", VA = "0x185DE8FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static BHGAALGADLM BGGHAGKBMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8BF0", Offset = "0x5DE79F0", VA = "0x185DE8BF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static CCAABBKKMFL OJLCFMEIOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9720", Offset = "0x5DE8520", VA = "0x185DE9720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static LEALPNGCHEO FNJKBCLLLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5DE91C0", Offset = "0x5DE7FC0", VA = "0x185DE91C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static KDAEPEHHCFM AIFMONOEKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5DE88B0", Offset = "0x5DE76B0", VA = "0x185DE88B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool MGMFGMPEEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5DE93C0", Offset = "0x5DE81C0", VA = "0x185DE93C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool NGJDNMOOFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8920", Offset = "0x5DE7720", VA = "0x185DE8920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static ELJLMFEGKCH CBDKNGHJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9120", Offset = "0x5DE7F20", VA = "0x185DE9120")]
		get
		{
			return default(ELJLMFEGKCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool PAONHNELJKN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9530", Offset = "0x5DE8330", VA = "0x185DE9530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static byte OJKNIDCOGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9430", Offset = "0x5DE8230", VA = "0x185DE9430")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static byte JGMKHECOIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool KKHGGKHBEHB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE9370", Offset = "0x5DE8170", VA = "0x185DE9370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool OCCIFGHDDHA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8C60", Offset = "0x5DE7A60", VA = "0x185DE8C60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8970", Offset = "0x5DE7770", VA = "0x185DE8970")]
	public static void CGIEFENFGHC(GOKBGBKDEJH POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8E00", Offset = "0x5DE7C00", VA = "0x185DE8E00")]
	public static EPCANLGBBON JBAAODIOIGA(GameObject LEMKPNELLPI)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8EC0", Offset = "0x5DE7CC0", VA = "0x185DE8EC0")]
	public static ELJLMFEGKCH JPEHJDCIAJC(GFPOPKJOMLL OEAOJAGKHME)
	{
		return default(ELJLMFEGKCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8CB0", Offset = "0x5DE7AB0", VA = "0x185DE8CB0")]
	public static bool IPHDOHKMBPG(GameObject LEMKPNELLPI, [Out] GFPOPKJOMLL[] OEAOJAGKHME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5DE8770", Offset = "0x5DE7570", VA = "0x185DE8770")]
	public static GPDAEJBFDHN BCCOJOLEJIH(IEnumerable<KOGCMBOFOEG> FMNLMEECNNN)
	{
		return default(GPDAEJBFDHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9030", Offset = "0x5DE7E30", VA = "0x185DE9030")]
	private static FOANHFHLHAH MPABHNJOFEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9230", Offset = "0x5DE8030", VA = "0x185DE9230")]
	private static bool NIFGNDMKBEG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GMFABBCIBCM
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9DA0", Offset = "0x5DD8BA0", VA = "0x185DD9DA0")]
	public static bool PBKPEHDBHFJ(KJKIANDJMFH IPPBJAEILAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD98F0", Offset = "0x5DD86F0", VA = "0x185DD98F0")]
	public static KJKIANDJMFH LAPCBGMBHPD(GameObject LEMKPNELLPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9BF0", Offset = "0x5DD89F0", VA = "0x185DD9BF0")]
	public static KJKIANDJMFH LAPCBGMBHPD(GameObject LEMKPNELLPI, GFPOPKJOMLL OEAOJAGKHME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD96D0", Offset = "0x5DD84D0", VA = "0x185DD96D0")]
	public static bool ICENKJKMGCG(GameObject MFFJMLLGCCG, string DAFCOOMAPBP, bool LHKIAGLLLCI)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DisembodiedObjectView : MonoBehaviour, DLPHNCJCCDD
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool NCHMLMBHEAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public EPCANLGBBON IMNDOBAMGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(EPCANLGBBON);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xD2B2B0", Offset = "0xD2A0B0", VA = "0x180D2B2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5DD5530", Offset = "0x5DD4330", VA = "0x185DD5530")]
		public void SetName(string MEBBBIMBIJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public sealed class EmbodiedObject : MonoBehaviour, KJKIANDJMFH, DLPHNCJCCDD
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly HICMFDICNOL DFCBIKLJFPD;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const string IKPNKFCOIIB = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private NNCNKLLKFFO KIGOLAOAAMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private EPCANLGBBON ALPEICGOMCK;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public EPCANLGBBON IMNDOBAMGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x5DD7C60", Offset = "0x5DD6A60", VA = "0x185DD7C60", Slot = "15")]
			get
			{
				return default(EPCANLGBBON);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ELJLMFEGKCH KPDACFOBKOG
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x5DD7D10", Offset = "0x5DD6B10", VA = "0x185DD7D10", Slot = "6")]
			get
			{
				return default(ELJLMFEGKCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool NCHMLMBHEAA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x5DD7C50", Offset = "0x5DD6A50", VA = "0x185DD7C50", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public NNCNKLLKFFO JIODAKODOJO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x88D390", Offset = "0x88C190", VA = "0x18088D390", Slot = "7")]
			get
			{
				return default(NNCNKLLKFFO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private JKLFCEOIENH NAADNBFJFKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x5DD7320", Offset = "0x5DD6120", VA = "0x185DD7320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool NFBFDPBKIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x7CDAC0", Offset = "0x7CC8C0", VA = "0x1807CDAC0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x885DF0", Offset = "0x884BF0", VA = "0x180885DF0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action<EmbodiedObject, bool> MCDFEAACBNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5DD7B40", Offset = "0x5DD6940", VA = "0x185DD7B40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5DD7E80", Offset = "0x5DD6C80", VA = "0x185DD7E80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> AJLMNHAEBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5DD79E0", Offset = "0x5DD67E0", VA = "0x185DD79E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5DD7D20", Offset = "0x5DD6B20", VA = "0x185DD7D20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<KJKIANDJMFH> NFPMIBCFJKB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x5DD7A90", Offset = "0x5DD6890", VA = "0x185DD7A90", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5DD7DD0", Offset = "0x5DD6BD0", VA = "0x185DD7DD0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7140", Offset = "0x5DD5F40", VA = "0x185DD7140")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7820", Offset = "0x5DD6620", VA = "0x185DD7820", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5DD73D0", Offset = "0x5DD61D0", VA = "0x185DD73D0", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7770", Offset = "0x5DD6570", VA = "0x185DD7770", Slot = "10")]
		public void OnEmbody(BPHHNANPLNM JDDIMGOGDBE, EPCANLGBBON ALPEICGOMCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7810", Offset = "0x5DD6610", VA = "0x185DD7810", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7610", Offset = "0x5DD6410", VA = "0x185DD7610", Slot = "12")]
		public void OnDisembody(bool KOECMFEHKPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7060", Offset = "0x5DD5E60", VA = "0x185DD7060")]
		private void AIFNOKBIIPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7390", Offset = "0x5DD6190", VA = "0x185DD7390", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA2C920", Offset = "0xA2B720", VA = "0x180A2C920", Slot = "9")]
		private GameObject CEBPFIGNPCI()
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
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleComponent]
	public class NetworkedTransformEntity : MonoBehaviour, DLPHNCJCCDD
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly HICMFDICNOL DFCBIKLJFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private GPKGCNFDJCC prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private EntityBundlePartId entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private EPCANLGBBON GOOJPBOEHHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool KFMFIGLCIAM;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public GPKGCNFDJCC NIFNBNEOCMP
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7638A0", Offset = "0x7626A0", VA = "0x1807638A0")]
			get
			{
				return default(GPKGCNFDJCC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public EntityBundlePartId DLHDDMHFIJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x786F50", Offset = "0x785D50", VA = "0x180786F50")]
			get
			{
				return default(EntityBundlePartId);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool NCHMLMBHEAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7CDAC0", Offset = "0x7CC8C0", VA = "0x1807CDAC0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public EPCANLGBBON IMNDOBAMGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "5")]
			get
			{
				return default(EPCANLGBBON);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private CCAABBKKMFL OJLCFMEIOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5DE8320", Offset = "0x5DE7120", VA = "0x185DE8320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private CJJPMIMHLNN ELOGKPPDLMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x5DE81B0", Offset = "0x5DE6FB0", VA = "0x185DE81B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8230", Offset = "0x5DE7030", VA = "0x185DE8230")]
		public void OnEmbody(EPCANLGBBON GOOJPBOEHHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8240", Offset = "0x5DE7040", VA = "0x185DE8240")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5DE83C0", Offset = "0x5DE71C0", VA = "0x185DE83C0")]
		public NetworkedTransformEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DisallowMultipleComponent]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public override GPKGCNFDJCC NIFNBNEOCMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x5DEBBF0", Offset = "0x5DEA9F0", VA = "0x185DEBBF0", Slot = "6")]
			get
			{
				return default(GPKGCNFDJCC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBBA0", Offset = "0x5DEA9A0", VA = "0x185DEBBA0")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[DisallowMultipleComponent]
	public class TransformEntity : MonoBehaviour, DLPHNCJCCDD
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly HICMFDICNOL DFCBIKLJFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private GPKGCNFDJCC prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private EPCANLGBBON GOOJPBOEHHC;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual GPKGCNFDJCC NIFNBNEOCMP
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x7638A0", Offset = "0x7626A0", VA = "0x1807638A0", Slot = "6")]
			get
			{
				return default(GPKGCNFDJCC);
			}
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x763860", Offset = "0x762660", VA = "0x180763860", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EPCANLGBBON IMNDOBAMGHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x30D77B0", Offset = "0x30D65B0", VA = "0x1830D77B0", Slot = "5")]
			get
			{
				return default(EPCANLGBBON);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool NCHMLMBHEAA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1027DB0", Offset = "0x1026BB0", VA = "0x181027DB0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1027DC0", Offset = "0x1026BC0", VA = "0x181027DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		internal Entity KHNJMAEDDIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5DEC160", Offset = "0x5DEAF60", VA = "0x185DEC160")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		internal CCAABBKKMFL OJLCFMEIOFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x5DEC200", Offset = "0x5DEB000", VA = "0x185DEC200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		internal CJJPMIMHLNN ELOGKPPDLMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5DEC0E0", Offset = "0x5DEAEE0", VA = "0x185DEC0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBC30", Offset = "0x5DEAA30", VA = "0x185DEBC30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBFF0", Offset = "0x5DEADF0", VA = "0x185DEBFF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBCE0", Offset = "0x5DEAAE0", VA = "0x185DEBCE0")]
		internal void HCKCHEHGBKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBC40", Offset = "0x5DEAA40", VA = "0x185DEBC40")]
		private bool DAKGBHHEDDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBC00", Offset = "0x5DEAA00", VA = "0x185DEBC00")]
		private void AKHPJCCBMBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBFF0", Offset = "0x5DEADF0", VA = "0x185DEBFF0")]
		internal void NDCOKDMKIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC180", Offset = "0x5DEAF80", VA = "0x185DEC180")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5DEC2A0", Offset = "0x5DEB0A0", VA = "0x185DEC2A0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[MOIMDPIFMGK(typeof(FAHGABBIGAL))]
[PMDCDBMECJP(typeof(FOANHFHLHAH), new string[] { })]
[MOIMDPIFMGK(typeof(LLDCKPPKNLB))]
public class NDKIDGAFCGE : FOANHFHLHAH, OFAFBMCCKFB, LLDCKPPKNLB, IDisposable, FAHGABBIGAL
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private static readonly ProfilerMarker FGLGKOPKJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private GOKBGBKDEJH MBMNNOGNPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private JKLFCEOIENH LJGJEFKLGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private GDDGINCANAF IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private JOHIHHGMLLC CICPENBHOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public GOKBGBKDEJH MJEEFGLGOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public GDDGINCANAF JHALPIJCAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public JKLFCEOIENH NAADNBFJFKD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public JOHIHHGMLLC AIMGFIPADHL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool LIODFMEFOFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B2CF0", Offset = "0x7B1AF0", VA = "0x1807B2CF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public CFLDCHEJOEJ LPNGOAIBOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x806B20", Offset = "0x805920", VA = "0x180806B20", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(CFLDCHEJOEJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x806B10", Offset = "0x805910", VA = "0x180806B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool ENEODBALKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xDD8000", Offset = "0xDD6E00", VA = "0x180DD8000", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1C58FE0", Offset = "0x1C57DE0", VA = "0x181C58FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public KDMEBEDNNJH FGBLHLKNCNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7DCCC0", Offset = "0x7DBAC0", VA = "0x1807DCCC0", Slot = "10")]
		get
		{
			return default(KDMEBEDNNJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7570", Offset = "0x5DE6370", VA = "0x185DE7570", Slot = "14")]
	private void KJBDEDKCPMF(bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE73C0", Offset = "0x5DE61C0", VA = "0x185DE73C0")]
	public static NDKIDGAFCGE FLMMCOJOBIA(GOKBGBKDEJH MBMNNOGNPON, LKLLDOONANH INEMIPHENMH = LKLLDOONANH.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void JIGLKFJKLMP(GOKBGBKDEJH MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void FMLAFGOIFHK(GOKBGBKDEJH MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE71B0", Offset = "0x5DE5FB0", VA = "0x185DE71B0", Slot = "11")]
	public void DOBAGIMKMLE(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0xBFF1A0", Offset = "0xBFDFA0", VA = "0x180BFF1A0")]
	private void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7080", Offset = "0x5DE5E80", VA = "0x185DE7080")]
	private void DMNALEKFFBE(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7330", Offset = "0x5DE6130", VA = "0x185DE7330", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public NDKIDGAFCGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class ACPJLMKNMEK
{
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[Flags]
public enum LKLLDOONANH
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
[PMDCDBMECJP(typeof(JOHIHHGMLLC), new string[] { })]
public class DDAMPPIFLHI : JOHIHHGMLLC, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly HICMFDICNOL NDJFCNPIEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private GOKBGBKDEJH MBMNNOGNPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private FAHGABBIGAL LFEGLOHBIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private GDDGINCANAF IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private FOANHFHLHAH EDBIBDGOGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private OLMMANKNKNE AENJCIFEOLN;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool KNGAEHKAAPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3940", Offset = "0x5DD2740", VA = "0x185DD3940", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GPANGHLDALB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3760", Offset = "0x5DD2560", VA = "0x185DD3760", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5DD35F0", Offset = "0x5DD23F0", VA = "0x185DD35F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3690", Offset = "0x5DD2490", VA = "0x185DD3690", Slot = "12")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3400", Offset = "0x5DD2200", VA = "0x185DD3400", Slot = "6")]
	public void FNOBAOFLOGH(bool OEMJACOGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD33B0", Offset = "0x5DD21B0", VA = "0x185DD33B0", Slot = "7")]
	public bool FEDGKHCPMAD(ByteString HGPPIPGOKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DD33A0", Offset = "0x5DD21A0", VA = "0x185DD33A0", Slot = "11")]
	public void DIIIJAPCPOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x166A7A0", Offset = "0x16695A0", VA = "0x18166A7A0", Slot = "9")]
	public void LMEFALOJHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3800", Offset = "0x5DD2600", VA = "0x185DD3800", Slot = "10")]
	public void MEKKINLGNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public DDAMPPIFLHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class LBOAHEDOAAP<T> : LJNGOFNIEKL<T>, KFKPFKCNHBF<GFPOPKJOMLL, T>, ANKBAFKPECB<GFPOPKJOMLL>, FDDOPIPPAOG, IDisposable, IPEMFFHKPFK where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ANKBAFKPECB<Entity> GHOAJKHDDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private Delegate MPKNBHLJFMJ;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x3965030", Offset = "0x3963E30", VA = "0x183965030", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Type HHINMKNAKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3952100", Offset = "0x3950F00", VA = "0x183952100", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NPIECMPEGKH EHCLIDINJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3952480", Offset = "0x3951280", VA = "0x183952480", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int NBKBAIOJEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x39533E0", Offset = "0x39521E0", VA = "0x1839533E0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NBNGLPEEKLA PFAEHLPMBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3953520", Offset = "0x3952320", VA = "0x183953520", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event PFNNBOJEDBM<GFPOPKJOMLL> MMLHNLNPEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x395C7F0", Offset = "0x395B5F0", VA = "0x18395C7F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3959080", Offset = "0x3957E80", VA = "0x183959080", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x34C1BF0", Offset = "0x34C09F0", VA = "0x1834C1BF0")]
	public LBOAHEDOAAP(ANKBAFKPECB<Entity> GHOAJKHDDHN, CCAABBKKMFL ACIEHBFKONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3959CE0", Offset = "0x3958AE0", VA = "0x183959CE0")]
	private Entity HOBCKCOLEEF(GFPOPKJOMLL OEAOJAGKHME)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3959C30", Offset = "0x3958A30", VA = "0x183959C30")]
	private GFPOPKJOMLL HOBCKCOLEEF(Entity HHHGBIJCKBC)
	{
		return default(GFPOPKJOMLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3958D80", Offset = "0x3957B80", VA = "0x183958D80", Slot = "4")]
	public T HAMDPAFEPLN(GFPOPKJOMLL OEAOJAGKHME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x39645B0", Offset = "0x39633B0", VA = "0x1839645B0")]
	public bool MFACMGCFCOL(GFPOPKJOMLL OEAOJAGKHME, [In] T OEMJACOGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3962290", Offset = "0x3961090", VA = "0x183962290", Slot = "7")]
	public bool MDCAPFCGBJE(GFPOPKJOMLL OEAOJAGKHME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3957150", Offset = "0x3955F50", VA = "0x183957150", Slot = "8")]
	public void HAMDPAFEPLN(GFPOPKJOMLL OEAOJAGKHME, FHNHJBJNGAK POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3962A90", Offset = "0x3961890", VA = "0x183962A90", Slot = "9")]
	public bool MFACMGCFCOL(GFPOPKJOMLL OEAOJAGKHME, EBLDEHNKIAL OEMJACOGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x35B5BD0", Offset = "0x35B49D0", VA = "0x1835B5BD0", Slot = "16")]
	public void FHMOENGGDFN(FPDFFDEKJBE OEBLNDDIIDP, [Optional] object DDMHMHFODEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3952DB0", Offset = "0x3951BB0", VA = "0x183952DB0", Slot = "10")]
	public bool DPPGELLEEGP(GFPOPKJOMLL HPMEJLCHJFA, GFPOPKJOMLL ECAFGEFAJGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3952EC0", Offset = "0x3951CC0", VA = "0x183952EC0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x39654F0", Offset = "0x39642F0", VA = "0x1839654F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x395BB90", Offset = "0x395A990", VA = "0x18395BB90")]
	private void JDPLANOEIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3954B80", Offset = "0x3953980", VA = "0x183954B80")]
	private void GJIBFABGLPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3960EE0", Offset = "0x395FCE0", VA = "0x183960EE0")]
	private void KOLOABDHKOE(Entity HHHGBIJCKBC, [In] EBLDEHNKIAL NKIGLDDAMAM, [In] EBLDEHNKIAL OEMJACOGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3955B80", Offset = "0x3954980", VA = "0x183955B80")]
	private void GOLHFFMHOAG(Entity HHHGBIJCKBC, [In] EBLDEHNKIAL NKIGLDDAMAM, [In] EBLDEHNKIAL OEMJACOGEGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class ANFKAILOKHJ<T> : PNFKANAGIKE<T>, KFKPFKCNHBF<EPCANLGBBON, T>, ANKBAFKPECB<EPCANLGBBON>, FDDOPIPPAOG, IDisposable, KHCEBOOKNAG where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly ANKBAFKPECB<Entity> GHOAJKHDDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private Delegate MPKNBHLJFMJ;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x34C1A70", Offset = "0x34C0870", VA = "0x1834C1A70", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public Type HHINMKNAKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x34C04B0", Offset = "0x34BF2B0", VA = "0x1834C04B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public NPIECMPEGKH EHCLIDINJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x34C0510", Offset = "0x34BF310", VA = "0x1834C0510", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int NBKBAIOJEOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x34C0690", Offset = "0x34BF490", VA = "0x1834C0690", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NBNGLPEEKLA PFAEHLPMBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x34C0830", Offset = "0x34BF630", VA = "0x1834C0830", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event PFNNBOJEDBM<EPCANLGBBON> MMLHNLNPEIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x34C1190", Offset = "0x34BFF90", VA = "0x1834C1190", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x34C0E80", Offset = "0x34BFC80", VA = "0x1834C0E80", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x34C1BF0", Offset = "0x34C09F0", VA = "0x1834C1BF0")]
	public ANFKAILOKHJ(ANKBAFKPECB<Entity> GHOAJKHDDHN, CCAABBKKMFL ACIEHBFKONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x34C0F30", Offset = "0x34BFD30", VA = "0x1834C0F30")]
	private Entity HOBCKCOLEEF(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x34C0F60", Offset = "0x34BFD60", VA = "0x1834C0F60")]
	private EPCANLGBBON HOBCKCOLEEF(Entity HHHGBIJCKBC)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x34C0AF0", Offset = "0x34BF8F0", VA = "0x1834C0AF0", Slot = "4")]
	public T HAMDPAFEPLN(EPCANLGBBON GOOJPBOEHHC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x34C17D0", Offset = "0x34C05D0", VA = "0x1834C17D0")]
	public bool MFACMGCFCOL(EPCANLGBBON GOOJPBOEHHC, [In] T OEMJACOGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x34C16C0", Offset = "0x34C04C0", VA = "0x1834C16C0", Slot = "7")]
	public bool MDCAPFCGBJE(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x34C0DF0", Offset = "0x34BFBF0", VA = "0x1834C0DF0", Slot = "8")]
	public void HAMDPAFEPLN(EPCANLGBBON GOOJPBOEHHC, FHNHJBJNGAK POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x34C19E0", Offset = "0x34C07E0", VA = "0x1834C19E0", Slot = "9")]
	public bool MFACMGCFCOL(EPCANLGBBON GOOJPBOEHHC, EBLDEHNKIAL OEMJACOGEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x34C0750", Offset = "0x34BF550", VA = "0x1834C0750", Slot = "16")]
	public void FHMOENGGDFN(FPDFFDEKJBE OEBLNDDIIDP, [Optional] object DDMHMHFODEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x34C0560", Offset = "0x34BF360", VA = "0x1834C0560", Slot = "10")]
	public bool DPPGELLEEGP(EPCANLGBBON HPMEJLCHJFA, EPCANLGBBON ECAFGEFAJGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x34C0F90", Offset = "0x34BFD90", VA = "0x1834C0F90")]
	private void JDPLANOEIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x34C0880", Offset = "0x34BF680", VA = "0x1834C0880")]
	private void GJIBFABGLPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x34C1240", Offset = "0x34C0040", VA = "0x1834C1240")]
	private void KOLOABDHKOE(Entity HHHGBIJCKBC, [In] EBLDEHNKIAL NKIGLDDAMAM, [In] EBLDEHNKIAL OEMJACOGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x34C0A80", Offset = "0x34BF880", VA = "0x1834C0A80")]
	private void GOLHFFMHOAG(Entity HHHGBIJCKBC, [In] EBLDEHNKIAL NKIGLDDAMAM, [In] EBLDEHNKIAL OEMJACOGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x34C0670", Offset = "0x34BF470", VA = "0x1834C0670", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x34C1B30", Offset = "0x34C0930", VA = "0x1834C1B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class HFLJAIPNPON : NPCLNJINPCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class GPJFLAHGGMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int EIKHBOJHAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CD230", Offset = "0x7CC030", VA = "0x1807CD230", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> LPCOJAMFFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99990", VA = "0x180A9AB90", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB230", Offset = "0x5DDA030", VA = "0x185DDB230", Slot = "6")]
	public EPCANLGBBON HGLHAMPADHI(EPCANLGBBON GBNDDJIHFHG)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HFLJAIPNPON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class CNCGBAPIBAA : NPCLNJINPCG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> ACJACCGEAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int NGLEGICFLAC;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> LPCOJAMFFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99990", VA = "0x180A9AB90", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int EIKHBOJHAOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x806B40", Offset = "0x805940", VA = "0x180806B40", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x35ED3D0", Offset = "0x35EC1D0", VA = "0x1835ED3D0")]
	public CNCGBAPIBAA(NativeArray<EntityRemapUtility.EntityRemapInfo> ACJACCGEAEM, int NGLEGICFLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3320", Offset = "0x5DD2120", VA = "0x185DD3320", Slot = "6")]
	public EPCANLGBBON HGLHAMPADHI(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DD32E0", Offset = "0x5DD20E0", VA = "0x185DD32E0", Slot = "8")]
	public LocalId HGLHAMPADHI(LocalId HHHGBIJCKBC)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3280", Offset = "0x5DD2080", VA = "0x185DD3280", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[OCEGCBKNAGD(LJHGMNIEOPD.Application)]
[PMDCDBMECJP(typeof(HCELPLBJMPB), new string[] { "Editor" })]
public sealed class HCELPLBJMPB
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate void ILJNAFNJHIJ(GFPOPKJOMLL JHEHPDOBHDF, JJPHEIKOGBI LMCJHCIOIIP, bool OBAIOBIHKJL);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate void NGPDOLGMAHO(GFPOPKJOMLL JHEHPDOBHDF, bool OBAIOBIHKJL);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate void EJILHMBLLIO(GFPOPKJOMLL JHEHPDOBHDF, FGBENGKJFDK GHOAJKHDDHN, [In] EBLDEHNKIAL POACLGOFKAJ, bool OBAIOBIHKJL);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HCELPLBJMPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[Flags]
public enum MCKFKIDJMKM
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
[OCEGCBKNAGD(LJHGMNIEOPD.Application)]
[PMDCDBMECJP(typeof(CFKGEIBPPPD), new string[] { "Editor" })]
public sealed class CFKGEIBPPPD
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void JGNBEMKDOOF(GFPOPKJOMLL OEAOJAGKHME, JJPHEIKOGBI LMCJHCIOIIP, MCKFKIDJMKM INEMIPHENMH);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate void KGOCBKPDBKL(GFPOPKJOMLL OEAOJAGKHME, MCKFKIDJMKM INEMIPHENMH);

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate void KNNICEOCEOH(GFPOPKJOMLL OEAOJAGKHME, FGBENGKJFDK GHOAJKHDDHN, EBLDEHNKIAL ICMOHCKEJOO, EBLDEHNKIAL LMBCAMGCODH, MCKFKIDJMKM INEMIPHENMH);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public delegate void NBHEAIBJFAH(LNIKGFKEIBE GMOPMNAPKBE, ReadOnlySpan<byte> JOPBACODGFL);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public CFKGEIBPPPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[PMDCDBMECJP(typeof(KDAEPEHHCFM), new string[] { })]
internal class HDOENBIBODD : KDAEPEHHCFM, ENEHADLKBBF, IDisposable
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
	private sealed class AFKEJHANODC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public AFKEJHANODC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9A80", Offset = "0x5DC8880", VA = "0x185DC9A80")]
		internal object NAOEIFJIGFB((string name, bool value) a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[PDOCKCLGMBB]
	private LKGAMLNINAJ IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[PDOCKCLGMBB]
	private LLDCKPPKNLB FCMINLNDGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeBitArray BHBIEDCNBEE;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public NILLPHGPOMI NAOHPMHGGHH
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5DDABD0", Offset = "0x5DD99D0", VA = "0x185DDABD0", Slot = "4")]
		get
		{
			return default(NILLPHGPOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public NILLPHGPOMI MFBKFNNACAH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAE10", Offset = "0x5DD9C10", VA = "0x185DDAE10", Slot = "5")]
		get
		{
			return default(NILLPHGPOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NILLPHGPOMI DEHIBOGBMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAE00", Offset = "0x5DD9C00", VA = "0x185DDAE00", Slot = "6")]
		get
		{
			return default(NILLPHGPOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public NILLPHGPOMI DPPGELLEEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5DDADF0", Offset = "0x5DD9BF0", VA = "0x185DDADF0", Slot = "7")]
		get
		{
			return default(NILLPHGPOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public NILLPHGPOMI MCKHBKKFFKG
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAAE0", Offset = "0x5DD98E0", VA = "0x185DDAAE0", Slot = "8")]
		get
		{
			return default(NILLPHGPOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public NILLPHGPOMI IHIFCHLOOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5DDABA0", Offset = "0x5DD99A0", VA = "0x185DDABA0", Slot = "9")]
		get
		{
			return default(NILLPHGPOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NILLPHGPOMI OIIGFBDMJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB090", Offset = "0x5DD9E90", VA = "0x185DDB090", Slot = "10")]
		get
		{
			return default(NILLPHGPOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public NILLPHGPOMI IOKNMBDNKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB120", Offset = "0x5DD9F20", VA = "0x185DDB120", Slot = "11")]
		get
		{
			return default(NILLPHGPOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public NILLPHGPOMI JKCFCMLFDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAA80", Offset = "0x5DD9880", VA = "0x185DDAA80", Slot = "12")]
		get
		{
			return default(NILLPHGPOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public NILLPHGPOMI DAFHPLHBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5DDABB0", Offset = "0x5DD99B0", VA = "0x185DDABB0", Slot = "13")]
		get
		{
			return default(NILLPHGPOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public NILLPHGPOMI MBFAFKNMLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAE30", Offset = "0x5DD9C30", VA = "0x185DDAE30", Slot = "14")]
		get
		{
			return default(NILLPHGPOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public NILLPHGPOMI CJJPIJKODMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5DDABC0", Offset = "0x5DD99C0", VA = "0x185DDABC0", Slot = "15")]
		get
		{
			return default(NILLPHGPOMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private int JGCALOKNMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAD50", Offset = "0x5DD9B50", VA = "0x185DDAD50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5DDABF0", Offset = "0x5DD99F0", VA = "0x185DDABF0", Slot = "16")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAAF0", Offset = "0x5DD98F0", VA = "0x185DDAAF0", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAA90", Offset = "0x5DD9890", VA = "0x185DDAA90")]
	private void CFPAKKGKPLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAE40", Offset = "0x5DD9C40", VA = "0x185DDAE40")]
	private void NBOIEIGLJEO(Flag OIPHPKKDAIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB0A0", Offset = "0x5DD9EA0", VA = "0x185DDB0A0")]
	private NILLPHGPOMI NIFCCGDEGPN(Flag OIPHPKKDAIF)
	{
		return default(NILLPHGPOMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB130", Offset = "0x5DD9F30", VA = "0x185DDB130")]
	private NILLPHGPOMI OLCCFMILDPI(Flag OIPHPKKDAIF)
	{
		return default(NILLPHGPOMI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HDOENBIBODD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[OCEGCBKNAGD(LJHGMNIEOPD.Application)]
[PMDCDBMECJP(typeof(LNONMHFEMMB), new string[] { })]
internal class LNONMHFEMMB : EPBKMCPBINK
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DE51C0", Offset = "0x5DE3FC0", VA = "0x185DE51C0", Slot = "4")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LNONMHFEMMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(CLHNEJICAGH), new string[] { })]
internal class CLHNEJICAGH : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly HICMFDICNOL HACNKNKGGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[PDOCKCLGMBB]
	private ABOCLKIIMFN IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[PDOCKCLGMBB]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[PDOCKCLGMBB]
	private CJJPMIMHLNN FGGAOAAIACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private OLMMANKNKNE AENJCIFEOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private EntityQuery DLGEFLAODOK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5DD0D10", Offset = "0x5DCFB10", VA = "0x185DD0D10")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1A40", Offset = "0x5DD0840", VA = "0x185DD1A40", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0F50", Offset = "0x5DCFD50", VA = "0x185DD0F50", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0700", Offset = "0x5DCF500", VA = "0x185DD0700")]
	public GPDAEJBFDHN BCCOJOLEJIH(IEnumerable<KOGCMBOFOEG> NGENFAGKIHK)
	{
		return default(GPDAEJBFDHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5DD18E0", Offset = "0x5DD06E0", VA = "0x185DD18E0")]
	private static bool IOKPDFFOKEC(KOGCMBOFOEG BHMKONDNBED, [Out] GFPOPKJOMLL[] AINFNEHLDGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1CA0", Offset = "0x5DD0AA0", VA = "0x185DD1CA0")]
	private GPDAEJBFDHN JALPLHAJPGE(IEnumerable<KOGCMBOFOEG> NGENFAGKIHK)
	{
		return default(GPDAEJBFDHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1620", Offset = "0x5DD0420", VA = "0x185DD1620")]
	private (List<KOGCMBOFOEG>, int[], int) FOIMJBFKLJH(IEnumerable<KOGCMBOFOEG> NGENFAGKIHK)
	{
		return default((List<KOGCMBOFOEG>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1820", Offset = "0x5DD0620", VA = "0x185DD1820")]
	private Dictionary<GFPOPKJOMLL, (KOGCMBOFOEG, int)> HDHHJEMJBMM(IEnumerable<KOGCMBOFOEG> NGENFAGKIHK, Entity CAECHIIICIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2190", Offset = "0x5DD0F90", VA = "0x185DD2190")]
	private void KGHIMOBMHIB(Dictionary<GFPOPKJOMLL, (KOGCMBOFOEG request, int srcIndex)> OEHHENOKKFM, IEnumerable<KOGCMBOFOEG> NGENFAGKIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD03D0", Offset = "0x5DCF1D0", VA = "0x185DD03D0")]
	private void AOHGDMNBDJE(Dictionary<GFPOPKJOMLL, (KOGCMBOFOEG request, int srcIndex)> OEHHENOKKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD1130", Offset = "0x5DCFF30", VA = "0x185DD1130")]
	private void FKAPMEIIFBH(Dictionary<GFPOPKJOMLL, (KOGCMBOFOEG request, int srcIndex)> OEHHENOKKFM, GFPOPKJOMLL OEAOJAGKHME, string MEBBBIMBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2680", Offset = "0x5DD1480", VA = "0x185DD2680")]
	private void NOGPJJMIDLM(Dictionary<GFPOPKJOMLL, (KOGCMBOFOEG request, int srcIndex)> OEHHENOKKFM, Entity CAECHIIICIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2A70", Offset = "0x5DD1870", VA = "0x185DD2A70")]
	private (List<KOGCMBOFOEG>, int[], int) OONMPEAJHOC(Dictionary<GFPOPKJOMLL, (KOGCMBOFOEG request, int srcIndex)> OEHHENOKKFM, Entity CAECHIIICIF)
	{
		return default((List<KOGCMBOFOEG>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0A20", Offset = "0x5DCF820", VA = "0x185DD0A20")]
	private void BMJOCNOMOEG(Dictionary<GFPOPKJOMLL, (KOGCMBOFOEG request, int srcIndex)> OEHHENOKKFM, List<KOGCMBOFOEG> JFKMOEADDDC, int[] EOMKCMPGIGD, NativeArray<Entity> DDIFFODKOKJ, NativeList<GFPOPKJOMLL> AINFNEHLDGJ, NativeList<Entity> FJOLMAGIGMI, Entity CAECHIIICIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0D60", Offset = "0x5DCFB60", VA = "0x185DD0D60")]
	private static bool DEAHDJMNEKO(Entity HHHGBIJCKBC, ComponentDataFromEntity<ParentData> BJDJLOOENNB, Entity CAECHIIICIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5DD2E50", Offset = "0x5DD1C50", VA = "0x185DD2E50")]
	private void PBCEJJMKJLO(Dictionary<GFPOPKJOMLL, (KOGCMBOFOEG request, int srcIndex)> OEHHENOKKFM, List<KOGCMBOFOEG> JFKMOEADDDC, int[] EOMKCMPGIGD, NativeList<Entity> FJOLMAGIGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0800", Offset = "0x5DCF600", VA = "0x185DD0800")]
	private NativeList<GFPOPKJOMLL> BJCFLKHGLFH(Dictionary<GFPOPKJOMLL, (KOGCMBOFOEG request, int srcIndex)> OEHHENOKKFM)
	{
		return default(NativeList<GFPOPKJOMLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0F60", Offset = "0x5DCFD60", VA = "0x185DD0F60")]
	private NativeArray<Entity> EDCEDJCHLPF(NativeList<GFPOPKJOMLL> AINFNEHLDGJ)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0E30", Offset = "0x5DCFC30", VA = "0x185DD0E30")]
	private static void DODKGANKGKA(Dictionary<GFPOPKJOMLL, (KOGCMBOFOEG request, int srcIndex)> OEHHENOKKFM, GFPOPKJOMLL OEAOJAGKHME, KOGCMBOFOEG BHMKONDNBED, string MEBBBIMBIJO, int JAJGOBEMIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5DD0640", Offset = "0x5DCF440", VA = "0x185DD0640")]
	private void APJIBODMEHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public CLHNEJICAGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[PMDCDBMECJP(typeof(KBJJJNBBBFB), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.Application)]
internal class KBJJJNBBBFB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	public void EBHDABHOKDP(string MEBBBIMBIJO, EntityManager GMDAKDJOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public KBJJJNBBBFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[PMDCDBMECJP(typeof(OLMMANKNKNE), new string[] { })]
[MOIMDPIFMGK(typeof(OFGBGGBNNCN))]
internal class OFGBGGBNNCN : OLMMANKNKNE, IDisposable, ENEHADLKBBF, GNDDGAACBGF
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly HICMFDICNOL NDJFCNPIEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[PDOCKCLGMBB]
	private GDDGINCANAF IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[PDOCKCLGMBB]
	private JOHIHHGMLLC CICPENBHOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[PDOCKCLGMBB]
	private NPAOJNBHCEC IHKLGGEBFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private FOANHFHLHAH EDBIBDGOGHN;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool LGKEBMNINLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7B2CF0", Offset = "0x7B1AF0", VA = "0x1807B2CF0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D00", Offset = "0x7B1B00", VA = "0x1807B2D00", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool EBFNOJFKBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x10D9770", Offset = "0x10D8570", VA = "0x1810D9770", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool KHGMBIELCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x806B20", Offset = "0x805920", VA = "0x180806B20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x806B10", Offset = "0x805910", VA = "0x180806B10", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public AHOAFPGEKED MBEAFCAKGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x765480", Offset = "0x764280", VA = "0x180765480")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9F30", Offset = "0x5DE8D30", VA = "0x185DE9F30", Slot = "15")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9A80", Offset = "0x5DE8880", VA = "0x185DE9A80", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA090", Offset = "0x5DE8E90", VA = "0x185DEA090", Slot = "8")]
	public AGOGLMPMEDI MFEMBIEHIEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA510", Offset = "0x5DE9310", VA = "0x185DEA510")]
	public AGOGLMPMEDI NNLGIAAOAMA(IEnumerable<EPCANLGBBON> GBNDDJIHFHG, [In] AGHGNCPPGHC AFLBLHPNDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9BE0", Offset = "0x5DE89E0", VA = "0x185DE9BE0", Slot = "10")]
	public JEJAAOHAHBL FELJOFCIMFB(ByteString HGPPIPGOKCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA1A0", Offset = "0x5DE8FA0", VA = "0x185DEA1A0")]
	public IMNONFIMKCE NBDLDHNHPGF(ByteString HGPPIPGOKCB, EPCANLGBBON LPDGANJNOMK, [In] AGHGNCPPGHC OJCGNPHJCHL, LGELJLLCKKD EPEDLHIICME, bool PIDGNEFGGFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA770", Offset = "0x5DE9570", VA = "0x185DEA770", Slot = "12")]
	public void OAKLMILPDKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE98B0", Offset = "0x5DE86B0", VA = "0x185DE98B0", Slot = "13")]
	public GPDAEJBFDHN BCCOJOLEJIH(IEnumerable<KOGCMBOFOEG> FMNLMEECNNN)
	{
		return default(GPDAEJBFDHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9AE0", Offset = "0x5DE88E0", VA = "0x185DE9AE0")]
	public static bool FEDGKHCPMAD(ByteString HGPPIPGOKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9A80", Offset = "0x5DE8880", VA = "0x185DE9A80")]
	private void HFNJNBILJFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9890", Offset = "0x5DE8690", VA = "0x185DE9890")]
	private void AEFCBBOIIAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA6A0", Offset = "0x5DE94A0", VA = "0x185DEA6A0")]
	private void NPDBAGCDFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9FE0", Offset = "0x5DE8DE0", VA = "0x185DE9FE0", Slot = "16")]
	public void LOPEMMLICGF(NFHEEPPLDKB IANOLOKAJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public OFGBGGBNNCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x5DE9DA0", Offset = "0x5DE8BA0", VA = "0x185DE9DA0", Slot = "9")]
	private AGOGLMPMEDI HHLJAECOBDK(IEnumerable<EPCANLGBBON> GBNDDJIHFHG, [In] AGHGNCPPGHC AFLBLHPNDKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x5DEA350", Offset = "0x5DE9150", VA = "0x185DEA350", Slot = "11")]
	private IMNONFIMKCE NDCEHBIDNEE(ByteString HGPPIPGOKCB, EPCANLGBBON LPDGANJNOMK, [In] AGHGNCPPGHC OJCGNPHJCHL, LGELJLLCKKD EPEDLHIICME, bool PIDGNEFGGFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[MOIMDPIFMGK(typeof(NPAOJNBHCEC))]
[PMDCDBMECJP(typeof(CNBPFEEKBEF), new string[] { })]
internal class NPAOJNBHCEC : CNBPFEEKBEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	[CompilerGenerated]
	private Action<NPCLNJINPCG> CPOPKJLAJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	[CompilerGenerated]
	private Action MJNLNBLDGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	[CompilerGenerated]
	private Action<NPCLNJINPCG> NNNIBBCEMKC;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action MEKKINLGNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7FD0", Offset = "0x5DE6DD0", VA = "0x185DE7FD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8110", Offset = "0x5DE6F10", VA = "0x185DE8110", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action DNMDMBGKIPH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7F30", Offset = "0x5DE6D30", VA = "0x185DE7F30", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8070", Offset = "0x5DE6E70", VA = "0x185DE8070", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0xADE100", Offset = "0xADCF00", VA = "0x180ADE100")]
	public void OAKLMILPDKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0xADE750", Offset = "0xADD550", VA = "0x180ADE750")]
	public void KKDOEPAJFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0xADE210", Offset = "0xADD010", VA = "0x180ADE210")]
	public void ENAICADLFFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x11ED950", Offset = "0x11EC750", VA = "0x1811ED950")]
	public void PDECFHDCEPO(NPCLNJINPCG OJEIFPMLHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x1764C20", Offset = "0x1763A20", VA = "0x181764C20")]
	public void EGFIJDNIHFO(NPCLNJINPCG OJEIFPMLHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public NPAOJNBHCEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
internal interface GGFHNIDOMCL
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNCBBGDJBOH(global::EKFJFCJFJAH EJMCGJIGPMG);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[MOIMDPIFMGK(typeof(GGFHNIDOMCL))]
[PMDCDBMECJP(typeof(LEALPNGCHEO), new string[] { })]
public class HHGBIHIINGA : LEALPNGCHEO, MPCGKLABPGO, EPBKMCPBINK, ENEHADLKBBF, GOMKIFEKCFK, IDisposable, GGFHNIDOMCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private LOCNOIPHBCK JMDECJAJJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private CHBMOFLCNPL DFMEDFMCOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private OJJJKLOBGFC JHNFBPKNCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private global::EKFJFCJFJAH AMCFMACOENJ;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	private PNFKANAGIKE<EPCANLGBBON> KFKCBBALAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x765450", Offset = "0x764250", VA = "0x180765450")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB380", Offset = "0x5DDA180", VA = "0x185DDB380")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<NIAMBHMBMDP> IKIMBMPPPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5DDB640", Offset = "0x5DDA440", VA = "0x185DDB640", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBD00", Offset = "0x5DDAB00", VA = "0x185DDBD00", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x15BFDC0", Offset = "0x15BEBC0", VA = "0x1815BFDC0", Slot = "17")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB8A0", Offset = "0x5DDA6A0", VA = "0x185DDB8A0", Slot = "18")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB490", Offset = "0x5DDA290", VA = "0x185DDB490", Slot = "19")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x765490", Offset = "0x764290", VA = "0x180765490", Slot = "21")]
	private void FEKNDKJLHHO(global::EKFJFCJFJAH EJMCGJIGPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x15BFD10", Offset = "0x15BEB10", VA = "0x1815BFD10", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBC50", Offset = "0x5DDAA50", VA = "0x185DDBC50")]
	private EPCANLGBBON MMHAAOGFHDC(Entity HHHGBIJCKBC)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB300", Offset = "0x5DDA100", VA = "0x185DDB300", Slot = "6")]
	public EPCANLGBBON BGLIKGBFACL(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB970", Offset = "0x5DDA770", VA = "0x185DDB970", Slot = "7")]
	public void KBHKCHGHILL(List<EPCANLGBBON> FDDNGNHADLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBB90", Offset = "0x5DDA990", VA = "0x185DDBB90", Slot = "11")]
	public int LBPEHGFNEKK(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB790", Offset = "0x5DDA590", VA = "0x185DDB790", Slot = "12")]
	public LLKJHKLONBK IJGLKJCLNDD(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(LLKJHKLONBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB580", Offset = "0x5DDA380", VA = "0x185DDB580", Slot = "15")]
	public EPCANLGBBON FKEEIEILNIM(EPCANLGBBON PABBJIBBIGE, EPCANLGBBON GICCMHHJDGA)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB3D0", Offset = "0x5DDA1D0", VA = "0x185DDB3D0", Slot = "16")]
	public bool ECOIFBFLNNA(EPCANLGBBON PABBJIBBIGE, EPCANLGBBON GICCMHHJDGA, [Out] EPCANLGBBON BDEDPDJICOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB710", Offset = "0x5DDA510", VA = "0x185DDB710", Slot = "8")]
	public EPCANLGBBON IJFJAGHBHFC(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB6A0", Offset = "0x5DDA4A0", VA = "0x185DDB6A0", Slot = "14")]
	public bool HLEKOIFPNCB(EPCANLGBBON GOOJPBOEHHC, EPCANLGBBON PJMEKLHJGLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBD60", Offset = "0x5DDAB60", VA = "0x185DDBD60", Slot = "13")]
	public bool PKJACENFGMC(EPCANLGBBON GOOJPBOEHHC, EPCANLGBBON NINKJFKPIPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB270", Offset = "0x5DDA070", VA = "0x185DDB270", Slot = "9")]
	public bool AIEIBGACDCB(EPCANLGBBON GOOJPBOEHHC, EPCANLGBBON LPDGANJNOMK, bool OLCOCKBEOFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBC90", Offset = "0x5DDAA90", VA = "0x185DDBC90", Slot = "10")]
	public bool NBCOHGLKHJP(EPCANLGBBON GOOJPBOEHHC, EPCANLGBBON LPDGANJNOMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HHGBIHIINGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(JDGDANEDDKA), new string[] { })]
internal class JDGDANEDDKA : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[PDOCKCLGMBB]
	private PCGDABHJAAB NAFNNIMKNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly Dictionary<int, JNOBPLOAHCA> MEJEBKHGNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE540", Offset = "0x5DDD340", VA = "0x185DDE540", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE2B0", Offset = "0x5DDD0B0", VA = "0x185DDE2B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE7C0", Offset = "0x5DDD5C0", VA = "0x185DDE7C0")]
	public JNOBPLOAHCA LDEGBDKHDOE(BKOKDGLHFLO CJKMAIBCGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE590", Offset = "0x5DDD390", VA = "0x185DDE590")]
	public JNOBPLOAHCA LDEGBDKHDOE(FGBENGKJFDK OGIJMJFMMHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE8C0", Offset = "0x5DDD6C0", VA = "0x185DDE8C0")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDEA70", Offset = "0x5DDD870", VA = "0x185DDEA70")]
	public JDGDANEDDKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class JNOBPLOAHCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NativeList<KHDCIJCBGLA> IHGGKMNHFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private NativeList<PPNLIJLNAOJ> ACKMFDOIFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private NativeList<CFACDODIOOC> FIHCAHNDJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private NativeList<PPNLIJLNAOJ> DBFFOEMOFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public NativeList<KHDCIJCBGLA> ABKDDEKOAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99990", VA = "0x180A9AB90")]
		get
		{
			return default(NativeList<KHDCIJCBGLA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public NativeList<PPNLIJLNAOJ> PIOKDKHMLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xD63290", Offset = "0xD62090", VA = "0x180D63290")]
		get
		{
			return default(NativeList<PPNLIJLNAOJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public NativeList<CFACDODIOOC> GKFDAPIFGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xD77A70", Offset = "0xD76870", VA = "0x180D77A70")]
		get
		{
			return default(NativeList<CFACDODIOOC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public NativeList<PPNLIJLNAOJ> CCNMDGGEOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x89D980", Offset = "0x89C780", VA = "0x18089D980")]
		get
		{
			return default(NativeList<PPNLIJLNAOJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public JobHandle HNHDOGNHECF
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x95F260", Offset = "0x95E060", VA = "0x18095F260")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x100AD90", Offset = "0x1009B90", VA = "0x18100AD90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool PEFHIFCIPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5DDF3F0", Offset = "0x5DDE1F0", VA = "0x185DDF3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF990", Offset = "0x5DDE790", VA = "0x185DDF990")]
	public JNOBPLOAHCA(Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF7D0", Offset = "0x5DDE5D0", VA = "0x185DDF7D0")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF860", Offset = "0x5DDE660", VA = "0x185DDF860")]
	public void OGJJNAJKDPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5DDF490", Offset = "0x5DDE290", VA = "0x185DDF490")]
	public void EJEJBLJEAIN(Entity HHHGBIJCKBC, Entity EDMIEMPCIAB, Entity CEBKCILOOLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(NAPENNDAEDI), new string[] { })]
public class NAPENNDAEDI : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[PDOCKCLGMBB]
	private PAPIHHEIJJK BEEHCIODHCL;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6160", Offset = "0x5DE4F60", VA = "0x185DE6160", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6140", Offset = "0x5DE4F40", VA = "0x185DE6140", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public NAPENNDAEDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[OCEGCBKNAGD(LJHGMNIEOPD.PhotonRoom)]
[PMDCDBMECJP(typeof(HNIIJBEOOFD), new string[] { })]
public class HNIIJBEOOFD : MPCGKLABPGO, EPBKMCPBINK, ENEHADLKBBF, GOMKIFEKCFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private FHPHFJJONKB IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private JOHIHHGMLLC NNNJGNEHPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeList<int> ONAHLMANLBK;

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBF80", Offset = "0x5DDAD80", VA = "0x185DDBF80", Slot = "4")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBFE0", Offset = "0x5DDADE0", VA = "0x185DDBFE0", Slot = "5")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBE90", Offset = "0x5DDAC90", VA = "0x185DDBE90", Slot = "6")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBDD0", Offset = "0x5DDABD0", VA = "0x185DDBDD0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC050", Offset = "0x5DDAE50", VA = "0x185DDC050")]
	public void PAGDJHKDFDH(NativeParallelHashSet<int> KONOICKEPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBF40", Offset = "0x5DDAD40", VA = "0x185DDBF40")]
	public void IGEDAKPKDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HNIIJBEOOFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal abstract class MHODIENOCGF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private uint OGPOBPNLCCL;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public abstract uint GJAGNKJCDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3B42480", Offset = "0x3B41280", VA = "0x183B42480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5F80", Offset = "0x5DE4D80", VA = "0x185DE5F80")]
	public GFPOPKJOMLL GBCFKICCBOH()
	{
		return default(GFPOPKJOMLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5DE60B0", Offset = "0x5DE4EB0", VA = "0x185DE60B0")]
	public void IKBPCLHAHCP(NativeArray<GFPOPKJOMLL> AINFNEHLDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5DE6120", Offset = "0x5DE4F20", VA = "0x185DE6120")]
	public void IKBPCLHAHCP(GFPOPKJOMLL OEAOJAGKHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0xA92560", Offset = "0xA91360", VA = "0x180A92560", Slot = "6")]
	public virtual void LJDFGIJMKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5EE0", Offset = "0x5DE4CE0", VA = "0x185DE5EE0")]
	private unsafe void CBNHFIJDNBC(GFPOPKJOMLL* AEJFLAGJCDH, int NENAAIFMEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5FD0", Offset = "0x5DE4DD0", VA = "0x185DE5FD0")]
	private unsafe void IKBPCLHAHCP(GFPOPKJOMLL* AEJFLAGJCDH, int NENAAIFMEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected MHODIENOCGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(PEBNOEHGCDD), new string[] { })]
internal sealed class PEBNOEHGCDD : MHODIENOCGF, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[PDOCKCLGMBB]
	private GCMLJOOJHLC IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private uint IOPJNMNEAKH;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public override uint GJAGNKJCDEG
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x806B40", Offset = "0x805940", VA = "0x180806B40", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAC90", Offset = "0x5DE9A90", VA = "0x185DEAC90", Slot = "7")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAC40", Offset = "0x5DE9A40", VA = "0x185DEAC40")]
	private void GNCBFHCMMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAD20", Offset = "0x5DE9B20", VA = "0x185DEAD20", Slot = "6")]
	public override void LJDFGIJMKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public PEBNOEHGCDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[PMDCDBMECJP(typeof(OCBCABNBPGK), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
internal sealed class OCBCABNBPGK : MHODIENOCGF
{
	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public override uint GJAGNKJCDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public OCBCABNBPGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(PIFEBGBCHME), new string[] { })]
internal sealed class PIFEBGBCHME : MPCGKLABPGO, EPBKMCPBINK, ENEHADLKBBF, GOMKIFEKCFK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private EntityQuery GJPIGFKMGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private EntityQuery HFPNPKFDPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private EntityQuery KHEDJHJNECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private EntityQuery HMNKOFCMNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private EntityQuery NBHFDPGCMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private EntityQuery EBFCCNOBKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private EntityQuery OBOKHOMEOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	private EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5DEAE30", Offset = "0x5DE9C30", VA = "0x185DEAE30")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public EntityQuery HNHDLPBLNNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x95F280", Offset = "0x95E080", VA = "0x18095F280")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "4")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB450", Offset = "0x5DEA250", VA = "0x185DEB450", Slot = "5")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAEF0", Offset = "0x5DE9CF0", VA = "0x185DEAEF0", Slot = "6")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB4A0", Offset = "0x5DEA2A0", VA = "0x185DEB4A0")]
	private EntityQueryDesc LCBMEBJMCMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAE80", Offset = "0x5DE9C80", VA = "0x185DEAE80", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB510", Offset = "0x5DEA310", VA = "0x185DEB510")]
	public NLAGBABKJIG MONPKLCDBGM(EPCANLGBBON ALPEICGOMCK)
	{
		return default(NLAGBABKJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAD80", Offset = "0x5DE9B80", VA = "0x185DEAD80")]
	public GPKGCNFDJCC AKPDNKCPINE(Entity HHHGBIJCKBC)
	{
		return default(GPKGCNFDJCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB5E0", Offset = "0x5DEA3E0", VA = "0x185DEB5E0")]
	public PIFEBGBCHME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[PMDCDBMECJP(typeof(CCAABBKKMFL), new string[] { })]
public class DILFANENGHI : ENEHADLKBBF, CCAABBKKMFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static readonly HICMFDICNOL AKHDJBCPKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[PDOCKCLGMBB]
	private JKLFCEOIENH LJGJEFKLGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[PDOCKCLGMBB]
	private ANNAAAPLMJK NAMNFILNEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[PDOCKCLGMBB]
	private OJJJKLOBGFC GGFBOHOPFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[PDOCKCLGMBB]
	private CDHIAMFLODP LLOAICEJOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[PDOCKCLGMBB]
	private PIFEBGBCHME FKKFOAHHICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[PDOCKCLGMBB]
	private JBHIMPOFJPJ OPANPKMKHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private COAMDDAKEMC HAHKEFILEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private GNIFDDKOOBH DLKOKMHJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public JKLFCEOIENH NAADNBFJFKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public CFLDCHEJOEJ LPNGOAIBOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x873990", Offset = "0x872790", VA = "0x180873990", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(CFLDCHEJOEJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8739A0", Offset = "0x8727A0", VA = "0x1808739A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<LLKJHKLONBK, NativeArray<GPKGCNFDJCC>> EFDONKBBFOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5DD4E50", Offset = "0x5DD3C50", VA = "0x185DD4E50", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DD4CB0", Offset = "0x5DD3AB0", VA = "0x185DD4CB0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<LLKJHKLONBK> BFALLJPPKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DD5170", Offset = "0x5DD3F70", VA = "0x185DD5170", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3EC0", Offset = "0x5DD2CC0", VA = "0x185DD3EC0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD48D0", Offset = "0x5DD36D0", VA = "0x185DD48D0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4000", Offset = "0x5DD2E00", VA = "0x185DD4000", Slot = "43")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4410", Offset = "0x5DD3210", VA = "0x185DD4410")]
	private void FJCPEKKMMEM(NativeArray<GFPOPKJOMLL> AINFNEHLDGJ, NativeArray<GPKGCNFDJCC> JHHBEFKAAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5080", Offset = "0x5DD3E80", VA = "0x185DD5080")]
	private void OGHFINHKABB(LLKJHKLONBK HJJLFLCDILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4F40", Offset = "0x5DD3D40", VA = "0x185DD4F40")]
	internal EPCANLGBBON MMHAAOGFHDC(Entity HHHGBIJCKBC)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4F80", Offset = "0x5DD3D80", VA = "0x185DD4F80", Slot = "11")]
	public NLAGBABKJIG MONPKLCDBGM(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(NLAGBABKJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3B60", Offset = "0x5DD2960", VA = "0x185DD3B60", Slot = "12")]
	public GPKGCNFDJCC AKPDNKCPINE(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(GPKGCNFDJCC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4D60", Offset = "0x5DD3B60", VA = "0x185DD4D60", Slot = "42")]
	public bool MDCAPFCGBJE(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3BF0", Offset = "0x5DD29F0", VA = "0x185DD3BF0", Slot = "37")]
	public void BOBMPBDLCLM(LLKJHKLONBK GBNDDJIHFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4680", Offset = "0x5DD3480", VA = "0x185DD4680", Slot = "38")]
	public void GJFIGHFIJPA(EPCANLGBBON GOOJPBOEHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3B00", Offset = "0x5DD2900", VA = "0x185DD3B00", Slot = "39")]
	public void AILOKOPBEFH(EPCANLGBBON GOOJPBOEHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3BA0", Offset = "0x5DD29A0", VA = "0x185DD3BA0", Slot = "40")]
	public void BOBMPBDLCLM(EPCANLGBBON GOOJPBOEHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4B90", Offset = "0x5DD3990", VA = "0x185DD4B90", Slot = "25")]
	public LLKJHKLONBK JBAAODIOIGA(NativeArray<GFPOPKJOMLL> OEAOJAGKHME, Allocator MBGJLDPPIJN)
	{
		return default(LLKJHKLONBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4220", Offset = "0x5DD3020", VA = "0x185DD4220", Slot = "26")]
	public LLKJHKLONBK FEMICPIABAA(NativeArray<GFPOPKJOMLL> OEAOJAGKHME, NativeArray<JJPHEIKOGBI> BLKDAKGGOEB, Allocator MBGJLDPPIJN)
	{
		return default(LLKJHKLONBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3DD0", Offset = "0x5DD2BD0", VA = "0x185DD3DD0", Slot = "27")]
	public GFPOPKJOMLL[] DBOPAKPPPEO(string DAFCOOMAPBP, ELJLMFEGKCH ENPAPEKLELL, bool DHACGGJFMGN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4860", Offset = "0x5DD3660", VA = "0x185DD4860", Slot = "28")]
	public void IGHJFDEIBPO(string DAFCOOMAPBP, GFPOPKJOMLL[] AINFNEHLDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD45D0", Offset = "0x5DD33D0", VA = "0x185DD45D0", Slot = "29")]
	public ELJLMFEGKCH FLLGFEEDHEM(GPKGCNFDJCC LEGGGLNIAOM, bool JIDJICCOGJB)
	{
		return default(ELJLMFEGKCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4570", Offset = "0x5DD3370", VA = "0x185DD4570", Slot = "30")]
	public ELJLMFEGKCH FLLGFEEDHEM(GPKGCNFDJCC LEGGGLNIAOM)
	{
		return default(ELJLMFEGKCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4C10", Offset = "0x5DD3A10", VA = "0x185DD4C10", Slot = "31")]
	public ELJLMFEGKCH KNKDPFLNNOD(GPKGCNFDJCC LEGGGLNIAOM)
	{
		return default(ELJLMFEGKCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DD46E0", Offset = "0x5DD34E0", VA = "0x185DD46E0", Slot = "32")]
	public ELJLMFEGKCH GLAAAIIHHMF(GPKGCNFDJCC LEGGGLNIAOM)
	{
		return default(ELJLMFEGKCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4340", Offset = "0x5DD3140", VA = "0x185DD4340", Slot = "33")]
	public ELJLMFEGKCH FEMICPIABAA(GFPOPKJOMLL OEAOJAGKHME, GPKGCNFDJCC LEGGGLNIAOM)
	{
		return default(ELJLMFEGKCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DD47F0", Offset = "0x5DD35F0", VA = "0x185DD47F0", Slot = "34")]
	public CBKDFCHICBK HLKJLBKJMHH()
	{
		return default(CBKDFCHICBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4100", Offset = "0x5DD2F00", VA = "0x185DD4100", Slot = "35")]
	public HEGOHGFLPKD FACHJNNMDGJ()
	{
		return default(HEGOHGFLPKD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4190", Offset = "0x5DD2F90", VA = "0x185DD4190", Slot = "36")]
	public EJLNBGGOLLC FCOBDHJJCKJ(JFBOGCJIFLL FLHOFPAHPKL)
	{
		return default(EJLNBGGOLLC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4C70", Offset = "0x5DD3A70", VA = "0x185DD4C70", Slot = "13")]
	public void LAPCBGMBHPD(GFPOPKJOMLL OEAOJAGKHME, KJKIANDJMFH KPGCDKGOCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4C90", Offset = "0x5DD3A90", VA = "0x185DD4C90", Slot = "14")]
	public void LCDIPEIONIJ(GFPOPKJOMLL[] AINFNEHLDGJ, GameObject LEMKPNELLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3D00", Offset = "0x5DD2B00", VA = "0x185DD3D00", Slot = "15")]
	public ELJLMFEGKCH CGBHEPDCDGI(EPCANLGBBON GOOJPBOEHHC, [Optional] object EKDHBKMFLGI)
	{
		return default(ELJLMFEGKCH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3F70", Offset = "0x5DD2D70", VA = "0x185DD3F70", Slot = "16")]
	public bool DGOPEJKDEPE(EPCANLGBBON GOOJPBOEHHC, [Out] KJKIANDJMFH CGIMAKAECOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DD50C0", Offset = "0x5DD3EC0", VA = "0x185DD50C0", Slot = "17")]
	public bool OMALGOFDFEG(EPCANLGBBON GOOJPBOEHHC, [Out] Transform ILMBKONFEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3D90", Offset = "0x5DD2B90", VA = "0x185DD3D90", Slot = "18")]
	public bool CHIIPFDEOAP(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4F00", Offset = "0x5DD3D00", VA = "0x185DD4F00", Slot = "19")]
	public void MLBLDAGPMKH(EPCANLGBBON GOOJPBOEHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4630", Offset = "0x5DD3430", VA = "0x185DD4630", Slot = "20")]
	public bool FLOIJGBPJPG(LocalId GOOJPBOEHHC, object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4520", Offset = "0x5DD3320", VA = "0x185DD4520", Slot = "21")]
	public bool FLIIGKPHFHP(LocalId GOOJPBOEHHC, object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5110", Offset = "0x5DD3F10", VA = "0x185DD5110", Slot = "41")]
	public LLKJHKLONBK OPCJGNACCBJ(LLKJHKLONBK PJFCFEHPPLM, Allocator MBGJLDPPIJN)
	{
		return default(LLKJHKLONBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD47D0", Offset = "0x5DD35D0", VA = "0x185DD47D0", Slot = "24")]
	public GFPOPKJOMLL GONHBLIMNHN(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(GFPOPKJOMLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DD4BF0", Offset = "0x5DD39F0", VA = "0x185DD4BF0", Slot = "22")]
	public EPCANLGBBON JBAAODIOIGA(GFPOPKJOMLL OEAOJAGKHME)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5060", Offset = "0x5DD3E60", VA = "0x185DD5060", Slot = "23")]
	public bool NLAJJAMPGCF(GFPOPKJOMLL OEAOJAGKHME, [Out] EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DD3FC0", Offset = "0x5DD2DC0", VA = "0x185DD3FC0")]
	private void DOAJIFGBJDP(GPKGCNFDJCC KGNHAOBOCKA, EPCANLGBBON GOOJPBOEHHC, GFPOPKJOMLL OEAOJAGKHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5290", Offset = "0x5DD4090", VA = "0x185DD5290")]
	public DILFANENGHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(GHPEHOJGHEO), new string[] { })]
internal sealed class GHPEHOJGHEO : ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private CDHIAMFLODP LLOAICEJOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[PDOCKCLGMBB]
	private PIFEBGBCHME FKKFOAHHICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[PDOCKCLGMBB]
	private NKBJOPBBMIN LDGLDOIMGKA;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8CE0", Offset = "0x5DD7AE0", VA = "0x185DD8CE0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9440", Offset = "0x5DD8240", VA = "0x185DD9440")]
	public LLKJHKLONBK OPCJGNACCBJ(LLKJHKLONBK PJFCFEHPPLM, Allocator MBGJLDPPIJN)
	{
		return default(LLKJHKLONBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8D90", Offset = "0x5DD7B90", VA = "0x185DD8D90")]
	private void JLMKNFAPLMO(NativeParallelMultiHashMap<int, (EPCANLGBBON src, EPCANLGBBON dst)> KPBNLFIPCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8FC0", Offset = "0x5DD7DC0", VA = "0x185DD8FC0")]
	private void LKPFOJKPCJE(NativeParallelMultiHashMap<int, (EPCANLGBBON src, EPCANLGBBON dst)> KPBNLFIPCFG, int LEGGGLNIAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8900", Offset = "0x5DD7700", VA = "0x185DD8900")]
	private void HBHAPAPAOIF(NativeParallelMultiHashMap<int, (EPCANLGBBON src, EPCANLGBBON dst)> KPBNLFIPCFG, int LEGGGLNIAOM, KHNKJBOEAPI NAFNNIMKNLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8A70", Offset = "0x5DD7870", VA = "0x185DD8A70")]
	private NativeParallelMultiHashMap<int, (EPCANLGBBON, EPCANLGBBON)> HNMJABJBDNK(Allocator MBGJLDPPIJN, LLKJHKLONBK PJFCFEHPPLM, [Out] LLKJHKLONBK IDHFLLIMBKB)
	{
		return default(NativeParallelMultiHashMap<int, (EPCANLGBBON, EPCANLGBBON)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public GHPEHOJGHEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[MOIMDPIFMGK(typeof(LNMNHIICBIB))]
[PMDCDBMECJP(typeof(CJJPMIMHLNN), new string[] { })]
public class LNMNHIICBIB : CJJPMIMHLNN, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly HICMFDICNOL DJCGFEJPEBE;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly HICMFDICNOL PIMBJALLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private JNDGIDLEBEK IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private MDOHJIEGLJN GAKKCIMPKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private LEALPNGCHEO MPANOGNBHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private PEIDJIEIOHO AMDLAGAEHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private OJJJKLOBGFC GGFBOHOPFHI;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private EntityManager GMDAKDJOHKE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE1CC0", Offset = "0x5DE0AC0", VA = "0x185DE1CC0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3DB0", Offset = "0x5DE2BB0", VA = "0x185DE3DB0", Slot = "34")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE47E0", Offset = "0x5DE35E0", VA = "0x185DE47E0", Slot = "35")]
	public bool NLAJJAMPGCF(Transform ILMBKONFEEP, [Out] EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3450", Offset = "0x5DE2250", VA = "0x185DE3450", Slot = "36")]
	public Transform GNKLEJNLFLJ(Entity HHHGBIJCKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4970", Offset = "0x5DE3770", VA = "0x185DE4970", Slot = "31")]
	public bool OMALGOFDFEG(Entity HHHGBIJCKBC, [Out] Transform ILMBKONFEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3640", Offset = "0x5DE2440", VA = "0x185DE3640")]
	private void HCDFNLEKFOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1210", Offset = "0x5DE0010", VA = "0x185DE1210", Slot = "30")]
	public void AJJFBPPCDFH(Entity HHHGBIJCKBC, [Out] float4x4 JJPHFNJHJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE31D0", Offset = "0x5DE1FD0", VA = "0x185DE31D0", Slot = "4")]
	public void GJEOCDOONHD(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2E50", Offset = "0x5DE1C50", VA = "0x185DE2E50", Slot = "28")]
	public void FPGBNJOAOEM(Entity HHHGBIJCKBC, [Out] float4x4 JJPHFNJHJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4B80", Offset = "0x5DE3980", VA = "0x185DE4B80")]
	public void OPMIGJAFIDG(Entity HHHGBIJCKBC, [In] float4x4 JJPHFNJHJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2FC0", Offset = "0x5DE1DC0", VA = "0x185DE2FC0")]
	public void NAGCDNBCJMP(Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3520", Offset = "0x5DE2320", VA = "0x185DE3520", Slot = "6")]
	public float3 HBIMIOBLBCB(Entity HHHGBIJCKBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2B20", Offset = "0x5DE1920", VA = "0x185DE2B20")]
	public void FMMPDOCDAJC(Entity HHHGBIJCKBC, [In] quaternion POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1840", Offset = "0x5DE0640", VA = "0x185DE1840", Slot = "8")]
	public quaternion CPDFCGAPAPH(Entity HHHGBIJCKBC)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE38E0", Offset = "0x5DE26E0", VA = "0x185DE38E0")]
	public void PCHAAHNBHEP(Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4A60", Offset = "0x5DE3860", VA = "0x185DE4A60", Slot = "12")]
	public float3 ONOLOGGIEOH(Entity HHHGBIJCKBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE30F0", Offset = "0x5DE1EF0", VA = "0x185DE30F0", Slot = "15")]
	public float GFENOIDFELG(Entity HHHGBIJCKBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3BD0", Offset = "0x5DE29D0", VA = "0x185DE3BD0", Slot = "14")]
	public void IHAIJGPDDGF(Entity HHHGBIJCKBC, float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3A10", Offset = "0x5DE2810", VA = "0x185DE3A10", Slot = "17")]
	public float3 IENBMPFEBGN(Entity HHHGBIJCKBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE29A0", Offset = "0x5DE17A0", VA = "0x185DE29A0")]
	public void FFADGGFFFEJ(Entity HHHGBIJCKBC, [In] float3 HOMIMNIJOII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1950", Offset = "0x5DE0750", VA = "0x185DE1950", Slot = "9")]
	public void DCIFFGDIAAC(Entity HHHGBIJCKBC, [Out] float3 CMKBDFOJBFE, [Out] quaternion ALADLBOMNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1AC0", Offset = "0x5DE08C0", VA = "0x185DE1AC0", Slot = "10")]
	public void DCIFFGDIAAC(Entity HHHGBIJCKBC, [Out] RigidTransform AMPHGEMEFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4130", Offset = "0x5DE2F30", VA = "0x185DE4130", Slot = "37")]
	public void KFBEEEDMDGC(Entity HHHGBIJCKBC, [Out] float3 CMKBDFOJBFE, [Out] quaternion ALADLBOMNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4110", Offset = "0x5DE2F10", VA = "0x185DE4110", Slot = "11")]
	public void KFBEEEDMDGC(Entity HHHGBIJCKBC, [Out] RigidTransform AMPHGEMEFBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1710", Offset = "0x5DE0510", VA = "0x185DE1710")]
	public void FGEHDMNEEIL(Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DE4E50", Offset = "0x5DE3C50", VA = "0x185DE4E50", Slot = "19")]
	public float3 PKJHFJLMICD(Entity HHHGBIJCKBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DE12C0", Offset = "0x5DE00C0", VA = "0x185DE12C0")]
	public void BFHDCAFCHFD(Entity HHHGBIJCKBC, [In] quaternion POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3ED0", Offset = "0x5DE2CD0", VA = "0x185DE3ED0", Slot = "21")]
	public quaternion JOPIJHHBPDD(Entity HHHGBIJCKBC)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2C40", Offset = "0x5DE1A40", VA = "0x185DE2C40")]
	public void FOBPEANIAGK(Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5DE43C0", Offset = "0x5DE31C0", VA = "0x185DE43C0", Slot = "22")]
	public float3 KNHFCGGKPEP(Entity HHHGBIJCKBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5DE13E0", Offset = "0x5DE01E0", VA = "0x185DE13E0", Slot = "24")]
	public void CICLGNGBOBE(Entity HHHGBIJCKBC, float LCPOAECAOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5DE37F0", Offset = "0x5DE25F0", VA = "0x185DE37F0", Slot = "25")]
	public float IABLNDDCDCD(Entity HHHGBIJCKBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1F50", Offset = "0x5DE0D50", VA = "0x185DE1F50")]
	public void EOHFJJAOJLM(Entity HHHGBIJCKBC, [In] float3 NLFPLEECKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3660", Offset = "0x5DE2460", VA = "0x185DE3660", Slot = "27")]
	public float3 HJGEDJHOMPE(Entity HHHGBIJCKBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5DE23C0", Offset = "0x5DE11C0", VA = "0x185DE23C0", Slot = "32")]
	public void FACGDLGPACB(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1D10", Offset = "0x5DE0B10", VA = "0x185DE1D10")]
	private EPCANLGBBON ECKFABKMMLA(Transform ILMBKONFEEP)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5DE44E0", Offset = "0x5DE32E0", VA = "0x185DE44E0")]
	private static TransformEntity LKAJINHANPB(GPKGCNFDJCC FLHOFPAHPKL, GameObject MFFJMLLGCCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x245DCF0", Offset = "0x245CAF0", VA = "0x18245DCF0")]
	private static T NGKJKFDFIJK<T>(GameObject MFFJMLLGCCG) where T : MonoBehaviour
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1E30", Offset = "0x5DE0C30", VA = "0x185DE1E30", Slot = "33")]
	public void EMPACHICHBP(Entity HHHGBIJCKBC, Entity EDMIEMPCIAB, Entity CEBKCILOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LNMNHIICBIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2FC0", Offset = "0x5DE1DC0", VA = "0x185DE2FC0", Slot = "5")]
	private void GCNFCHBINMN(Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE2B20", Offset = "0x5DE1920", VA = "0x185DE2B20", Slot = "7")]
	private void KPEJCCOIJLF(Entity HHHGBIJCKBC, [In] quaternion POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5DE38E0", Offset = "0x5DE26E0", VA = "0x185DE38E0", Slot = "13")]
	private void IEIEMLGOMCK(Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5DE29A0", Offset = "0x5DE17A0", VA = "0x185DE29A0", Slot = "16")]
	private void POLCGIDOHHA(Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5DE1710", Offset = "0x5DE0510", VA = "0x185DE1710", Slot = "18")]
	private void CODHEMGGOOH(Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5DE12C0", Offset = "0x5DE00C0", VA = "0x185DE12C0", Slot = "20")]
	private void IMOIBJHGNMO(Entity HHHGBIJCKBC, [In] quaternion POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3EC0", Offset = "0x5DE2CC0", VA = "0x185DE3EC0", Slot = "23")]
	private void JAAKLFKHCGC(Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5DE38D0", Offset = "0x5DE26D0", VA = "0x185DE38D0", Slot = "26")]
	private void IALMOECDCOC(Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5DE3510", Offset = "0x5DE2310", VA = "0x185DE3510", Slot = "29")]
	private void GPHCLOLAOCM(Entity HHHGBIJCKBC, [In] float4x4 PENILBCOAKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class CFMKINDKPMJ
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFB00", Offset = "0x5DCE900", VA = "0x185DCFB00")]
	public static void MPGNGMENOJF(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [In] float3 BBEJKAIJGPI, [In] quaternion IOMLNAOLLNL, [In] float3 PIIOFNMPMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD5E0", Offset = "0x5DCC3E0", VA = "0x185DCD5E0")]
	public static void AJJFBPPCDFH(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [Out] float4x4 JJPHFNJHJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD700", Offset = "0x5DCC500", VA = "0x185DCD700")]
	private static void AJJFBPPCDFH(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, Entity LPDGANJNOMK, [Out] float4x4 JJPHFNJHJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFD40", Offset = "0x5DCEB40", VA = "0x185DCFD40")]
	public static void OPMIGJAFIDG(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [In] float4x4 JJPHFNJHJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF230", Offset = "0x5DCE030", VA = "0x185DCF230")]
	public static void JFAFBBEMDJN(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [Out] float4x4 LLICNFKAPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF160", Offset = "0x5DCDF60", VA = "0x185DCF160")]
	public static void IKPLHNLAFOA(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [In] float4x4 LLICNFKAPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEAA0", Offset = "0x5DCD8A0", VA = "0x185DCEAA0")]
	public static float3 HBIMIOBLBCB(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFBA0", Offset = "0x5DCE9A0", VA = "0x185DCFBA0")]
	public static void NAGCDNBCJMP(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDEB0", Offset = "0x5DCCCB0", VA = "0x185DCDEB0")]
	public static quaternion CPDFCGAPAPH(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE690", Offset = "0x5DCD490", VA = "0x185DCE690")]
	public static void FMMPDOCDAJC(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [In] quaternion POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5DCFC90", Offset = "0x5DCEA90", VA = "0x185DCFC90")]
	public static float3 ONOLOGGIEOH(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5DD00D0", Offset = "0x5DCEED0", VA = "0x185DD00D0")]
	public static void PCHAAHNBHEP(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE9D0", Offset = "0x5DCD7D0", VA = "0x185DCE9D0")]
	public static float GFENOIDFELG(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF0B0", Offset = "0x5DCDEB0", VA = "0x185DCF0B0")]
	public static void IHAIJGPDDGF(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEFD0", Offset = "0x5DCDDD0", VA = "0x185DCEFD0")]
	public static float3 IENBMPFEBGN(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE370", Offset = "0x5DCD170", VA = "0x185DCE370")]
	public static void FFADGGFFFEJ(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE0A0", Offset = "0x5DCCEA0", VA = "0x185DCE0A0")]
	public static void DCIFFGDIAAC(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [Out] RigidTransform LLICNFKAPGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDF90", Offset = "0x5DCCD90", VA = "0x185DCDF90")]
	public static void DCIFFGDIAAC(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [Out] float3 CMKBDFOJBFE, [Out] quaternion ALADLBOMNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDC70", Offset = "0x5DCCA70", VA = "0x185DCDC70")]
	public static void CGGFLMKGIPF(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [In] float3 BBEJKAIJGPI, [In] quaternion IOMLNAOLLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF750", Offset = "0x5DCE550", VA = "0x185DCF750")]
	public static void KFBEEEDMDGC(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [Out] float3 CMKBDFOJBFE, [Out] quaternion ALADLBOMNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD01C0", Offset = "0x5DCEFC0", VA = "0x185DD01C0")]
	public static float3 PKJHFJLMICD(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE440", Offset = "0x5DCD240", VA = "0x185DCE440")]
	public static void FGEHDMNEEIL(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD840", Offset = "0x5DCC640", VA = "0x185DCD840")]
	public static void BFHDCAFCHFD(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [In] quaternion POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF5E0", Offset = "0x5DCE3E0", VA = "0x185DCF5E0")]
	public static quaternion JOPIJHHBPDD(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCF8E0", Offset = "0x5DCE6E0", VA = "0x185DCF8E0")]
	public static float3 KNHFCGGKPEP(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE780", Offset = "0x5DCD580", VA = "0x185DCE780")]
	public static void FOBPEANIAGK(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [In] float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEDF0", Offset = "0x5DCDBF0", VA = "0x185DCEDF0")]
	public static float IABLNDDCDCD(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDD70", Offset = "0x5DCCB70", VA = "0x185DCDD70")]
	public static void CICLGNGBOBE(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, float LCPOAECAOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x5DCEB90", Offset = "0x5DCD990", VA = "0x185DCEB90")]
	public static float3 HJGEDJHOMPE(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5DCE180", Offset = "0x5DCCF80", VA = "0x185DCE180")]
	public static void EOHFJJAOJLM(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [In] float3 NLFPLEECKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5DCDBD0", Offset = "0x5DCC9D0", VA = "0x185DCDBD0")]
	public static bool CEBJEEGPKJB(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [Out] Entity LPDGANJNOMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[OCEGCBKNAGD(LJHGMNIEOPD.LoadInstance)]
[PMDCDBMECJP(typeof(OPBCPDOIAFF), new string[] { })]
internal sealed class OPBCPDOIAFF : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[PDOCKCLGMBB]
	private GNDBCEIPANN IFKIGJDABJA;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAAE0", Offset = "0x5DE98E0", VA = "0x185DEAAE0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x5DEAA90", Offset = "0x5DE9890", VA = "0x185DEAA90", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public OPBCPDOIAFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(JPMHOPGBPDP), new string[] { })]
public class JPMHOPGBPDP
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct EOEABDJIKCJ : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly JPMHOPGBPDP LPDGANJNOMK;

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7020", Offset = "0x5DD5E20", VA = "0x185DD7020", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private int ECNKAEJIFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[CompilerGenerated]
	private Action NINFIMBKLFL;

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFAA0", Offset = "0x5DDE8A0", VA = "0x185DDFAA0")]
	public void NJOMEIAAJMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public JPMHOPGBPDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(DICMBGCFOEP), new string[] { })]
public class DICMBGCFOEP
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private bool FCMINLNDGAI;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool ENEODBALKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7B03C0", Offset = "0x7AF1C0", VA = "0x1807B03C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5DD3A60", Offset = "0x5DD2860", VA = "0x185DD3A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public DICMBGCFOEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(KKAFIEKFBPH), new string[] { })]
public class KKAFIEKFBPH : ENEHADLKBBF, GNDDGAACBGF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private struct HOGFBBPJPHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private NativeArray<int> NACNIILFGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private NativeArray<int> FEIMIFBBIKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private Dictionary<ComponentSystemBase, int> IFCEFLINPOL;

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC6F0", Offset = "0x5DDB4F0", VA = "0x185DDC6F0")]
		public HOGFBBPJPHA(NativeArray<int> NACNIILFGKB, NativeArray<int> FEIMIFBBIKL, Dictionary<ComponentSystemBase, int> IFCEFLINPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC5C0", Offset = "0x5DDB3C0", VA = "0x185DDC5C0")]
		public static void IPNKGJGLIGG(World JDDIMGOGDBE, LJHGMNIEOPD BIHEBOKLDKF, NativeArray<int> NACNIILFGKB, NativeArray<int> FEIMIFBBIKL, Dictionary<ComponentSystemBase, int> IFCEFLINPOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC2D0", Offset = "0x5DDB0D0", VA = "0x185DDC2D0")]
		public void EAKFHGCLFFF(IEnumerable<ComponentSystemBase> LJGJEFKLGIF, LJHGMNIEOPD BIHEBOKLDKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OAMEHPBANDN : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
		public KKAFIEKFBPH <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x86F050", Offset = "0x86DE50", VA = "0x18086F050")]
		[DebuggerHidden]
		public OAMEHPBANDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5DE83D0", Offset = "0x5DE71D0", VA = "0x185DE83D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5DE85B0", Offset = "0x5DE73B0", VA = "0x185DE85B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8500", Offset = "0x5DE7300", VA = "0x185DE8500", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5DE8500", Offset = "0x5DE7300", VA = "0x185DE8500", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly HICMFDICNOL IPDEMDGNFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private World JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private NFHEEPPLDKB MBMNNOGNPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private NativeArray<int> GGMICCNPJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private NativeArray<int> FLBAPPEMKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private int FBJEHMGCPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private LJHGMNIEOPD IOOJLPJLBPO;

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0330", Offset = "0x5DDF130", VA = "0x185DE0330", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFCC0", Offset = "0x5DDEAC0", VA = "0x185DDFCC0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5DE04D0", Offset = "0x5DDF2D0", VA = "0x185DE04D0")]
	[IteratorStateMachine(typeof(OAMEHPBANDN))]
	private IEnumerable<ComponentSystemBase> JIMLKNFKFBH(int IHNKLCGMFDI, int MBGJPMIDMIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFE40", Offset = "0x5DDEC40", VA = "0x185DDFE40", Slot = "5")]
	public void LOPEMMLICGF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFE40", Offset = "0x5DDEC40", VA = "0x185DDFE40")]
	private void HNEMCNFJNNP(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFEC0", Offset = "0x5DDECC0", VA = "0x185DDFEC0")]
	public void HNEMCNFJNNP(LJHGMNIEOPD EFGOLDFEKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0010", Offset = "0x5DDEE10", VA = "0x185DE0010")]
	private void IEENGABKIKN(LJHGMNIEOPD EFGOLDFEKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0410", Offset = "0x5DDF210", VA = "0x185DE0410")]
	private void JFPPBDLFJLN(LJHGMNIEOPD EFGOLDFEKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0B50", Offset = "0x5DDF950", VA = "0x185DE0B50")]
	private void ONOACJMDAIE(LJHGMNIEOPD EFGOLDFEKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFB80", Offset = "0x5DDE980", VA = "0x185DDFB80")]
	private void DEANLCCDODN(int IHNKLCGMFDI, int MBGJPMIDMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFAC0", Offset = "0x5DDE8C0", VA = "0x185DDFAC0")]
	private void CCHNNAIJMOL(int IHNKLCGMFDI, int MBGJPMIDMIA, bool FCMINLNDGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0B30", Offset = "0x5DDF930", VA = "0x185DE0B30")]
	private int OMADMBLFJOD(LJHGMNIEOPD EFGOLDFEKFB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0570", Offset = "0x5DDF370", VA = "0x185DE0570")]
	private bool NBLNKGNIBHA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFBD0", Offset = "0x5DDE9D0", VA = "0x185DDFBD0")]
	private Dictionary<ComponentSystemBase, int> DHKEKNDBCCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0290", Offset = "0x5DDF090", VA = "0x185DE0290")]
	private void IIJKEKOEMDJ(NativeArray<int> NACNIILFGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFD30", Offset = "0x5DDEB30", VA = "0x185DDFD30")]
	private void ELAGHBMGDCF(NativeArray<int> FEIMIFBBIKL, NativeArray<int> NACNIILFGKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0BE0", Offset = "0x5DDF9E0", VA = "0x185DE0BE0")]
	private static LJHGMNIEOPD POMDEJBDNLA(Type FLHOFPAHPKL, LJHGMNIEOPD PPFOBEPKLDB)
	{
		return default(LJHGMNIEOPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5DE0D00", Offset = "0x5DDFB00", VA = "0x185DE0D00")]
	public KKAFIEKFBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5DDFDE0", Offset = "0x5DDEBE0", VA = "0x185DDFDE0")]
	[CompilerGenerated]
	private void HMLMFKBJCNG(ENEHADLKBBF FPOEPHMJOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5DE02D0", Offset = "0x5DDF0D0", VA = "0x185DE02D0")]
	[CompilerGenerated]
	private void IMAHLAIDBMF(GOMKIFEKCFK FPOEPHMJOKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[PMDCDBMECJP(typeof(PJCKAEPBFOA), new string[] { })]
public class AFLJMPBCAFM : ENEHADLKBBF, PJCKAEPBFOA
{
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[PDOCKCLGMBB]
	private OLMMANKNKNE AENJCIFEOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[PDOCKCLGMBB]
	private NMGOMOEFNEJ FFEDJHJFICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[PDOCKCLGMBB]
	private LLDCKPPKNLB BKFCDOAFKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[PDOCKCLGMBB]
	private PEIDJIEIOHO OHIJLKGECAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	[PDOCKCLGMBB]
	private FNOCCIFKHLE MJDGLHMPNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private World FJNAEGAHMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private FFLNJFBDGCL FCJBEDLGOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private FFLNJFBDGCL FBFFCMDMBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private FFLNJFBDGCL HIFIAADBNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private FFLNJFBDGCL CMBILAFODEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private FFLNJFBDGCL CCFLJFIMANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private FFLNJFBDGCL JCHOFNAEJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private FFLNJFBDGCL JJHBIIMLBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private FFLNJFBDGCL KAEKHJNOHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private FFLNJFBDGCL HKEMGEDEMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private FFLNJFBDGCL HCKDNCAEPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private FFLNJFBDGCL JAMIHMDCAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private FFLNJFBDGCL FAOBKHFHFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private FFLNJFBDGCL LPFJBFGBOEO;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private bool IFMAIBBLFEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x5DC9F70", Offset = "0x5DC8D70", VA = "0x185DC9F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private bool DAPOLANIKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA610", Offset = "0x5DC9410", VA = "0x185DCA610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	private bool HGCCFFJDKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA080", Offset = "0x5DC8E80", VA = "0x185DCA080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private bool DKLDMMKLKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5DCA080", Offset = "0x5DC8E80", VA = "0x185DCA080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA090", Offset = "0x5DC8E90", VA = "0x185DCA090", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x29BD320", Offset = "0x29BC120", VA = "0x1829BD320")]
	private FFLNJFBDGCL NBEKLBOBFAA<T>() where T : BAABILOAFLF
	{
		return default(FFLNJFBDGCL);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA5C0", Offset = "0x5DC93C0", VA = "0x185DCA5C0")]
	private FFLNJFBDGCL NBEKLBOBFAA(Type FLHOFPAHPKL)
	{
		return default(FFLNJFBDGCL);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA4E0", Offset = "0x5DC92E0", VA = "0x185DCA4E0", Slot = "14")]
	public void KDEDDBHGBPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA510", Offset = "0x5DC9310", VA = "0x185DCA510", Slot = "15")]
	public void KKKANJEHFFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA5F0", Offset = "0x5DC93F0", VA = "0x185DCA5F0", Slot = "5")]
	public void NELLNBHPBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA7F0", Offset = "0x5DC95F0", VA = "0x185DCA7F0", Slot = "6")]
	public void OIALEIGEBPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA870", Offset = "0x5DC9670", VA = "0x185DCA870", Slot = "7")]
	public void OLDGACNCLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA540", Offset = "0x5DC9340", VA = "0x185DCA540", Slot = "8")]
	public void NAEDLEJCMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9B00", Offset = "0x5DC8900", VA = "0x185DC9B00", Slot = "9")]
	public void ALPJFPFDNAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA680", Offset = "0x5DC9480", VA = "0x185DCA680", Slot = "10")]
	public void OCGKIGEANEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9BA0", Offset = "0x5DC89A0", VA = "0x185DC9BA0", Slot = "11")]
	public void GBHHIBOOFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA4A0", Offset = "0x5DC92A0", VA = "0x185DCA4A0", Slot = "12")]
	public void KAIOMMMAPDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9C20", Offset = "0x5DC8A20", VA = "0x185DC9C20", Slot = "13")]
	public void GGPJHMJFOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9FF0", Offset = "0x5DC8DF0", VA = "0x185DC9FF0")]
	private void ILAIIKMLHKC(FFLNJFBDGCL BBNGNPEAOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5DCA760", Offset = "0x5DC9560", VA = "0x185DCA760")]
	private void OEMJEADCOOP(FFLNJFBDGCL BBNGNPEAOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5DC9B80", Offset = "0x5DC8980", VA = "0x185DC9B80")]
	private void FHGBPPDBCGA(FFLNJFBDGCL BBNGNPEAOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public AFLJMPBCAFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal readonly struct FFLNJFBDGCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly ComponentSystemBase BBNGNPEAOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly ProfilerMarker DDALCKBENBK;

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8060", Offset = "0x5DD6E60", VA = "0x185DD8060")]
	public FFLNJFBDGCL(World JDDIMGOGDBE, Type FLHOFPAHPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7F90", Offset = "0x5DD6D90", VA = "0x185DD7F90")]
	public void FHGBPPDBCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[PMDCDBMECJP(typeof(BPHHNANPLNM), new string[] { })]
public class NFALPNMPKGA : BPHHNANPLNM, IDisposable, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[PDOCKCLGMBB]
	private KOHKCDKIBEL ACKGPLDJLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[PDOCKCLGMBB]
	private CFKGEIBPPPD NCJBOOFHFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private World FJNAEGAHMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private World HDEJEAONPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private bool KFMFIGLCIAM;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public World IKHONICOMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public World NGPIPCJIPNE
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7860", Offset = "0x5DE6660", VA = "0x185DE7860", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool LIODFMEFOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x366E660", Offset = "0x366D460", VA = "0x18366E660", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7C80", Offset = "0x5DE6A80", VA = "0x185DE7C80", Slot = "10")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7B50", Offset = "0x5DE6950", VA = "0x185DE7B50")]
	private void FLMMCOJOBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7880", Offset = "0x5DE6680", VA = "0x185DE7880", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5DE7E20", Offset = "0x5DE6C20", VA = "0x185DE7E20", Slot = "8")]
	public ComponentSystemBase NBEKLBOBFAA(Type FLHOFPAHPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public NFALPNMPKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[PMDCDBMECJP(typeof(JBHIMPOFJPJ), new string[] { })]
public class BMOHILGIEJE : JBHIMPOFJPJ, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[PDOCKCLGMBB]
	private CDHIAMFLODP IPGLBAAKHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	[PDOCKCLGMBB]
	private EGCGLNEJKFD OALCBHMMEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	[PDOCKCLGMBB]
	private GNIFDDKOOBH DLKOKMHJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private COAMDDAKEMC MADNNKEJNPL;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5DCC940", Offset = "0x5DCB740", VA = "0x185DCC940")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD390", Offset = "0x5DCC190", VA = "0x185DCD390", Slot = "6")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCF50", Offset = "0x5DCBD50", VA = "0x185DCCF50", Slot = "5")]
	public void IGHJFDEIBPO(string DAFCOOMAPBP, GFPOPKJOMLL[] AINFNEHLDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC990", Offset = "0x5DCB790", VA = "0x185DCC990", Slot = "4")]
	public GFPOPKJOMLL[] DBOPAKPPPEO(string DAFCOOMAPBP, ELJLMFEGKCH ENPAPEKLELL, bool DHACGGJFMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCD460", Offset = "0x5DCC260", VA = "0x185DCD460")]
	private bool KCIFGJIOLMI(EPCANLGBBON PHNFANHCONA, [Out] NativeArray<Entity> PCDLMMAENEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC720", Offset = "0x5DCB520", VA = "0x185DCC720")]
	private bool CHHMELLMEAJ(NativeArray<Entity> OLJNEGFOGLL, GOBFDDPFJKP LKPBDEABOBE, GFPOPKJOMLL[] AINFNEHLDGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCDC0", Offset = "0x5DCBBC0", VA = "0x185DCCDC0")]
	private bool FCBKCEGDDGD([In] EntityBundlePartId GHNGKOMPLDM, [In] GOBFDDPFJKP LKPBDEABOBE, [Out] int OCMJNDDMDAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5DCCE40", Offset = "0x5DCBC40", VA = "0x185DCCE40")]
	private void FLCGBDFFINP(Entity HHHGBIJCKBC, Entity PHNFANHCONA, EntityBundlePartId DCJAGKIKDGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BMOHILGIEJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct GOBFDDPFJKP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly NativeArray<EntityBundlePartId> JBCBEFAMFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly NativeArray<GPKGCNFDJCC> JHHBEFKAAPJ;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int GFHGMKIJCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1C77C70", Offset = "0x1C76A70", VA = "0x181C77C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9FC0", Offset = "0x5DD8DC0", VA = "0x185DD9FC0")]
	public GOBFDDPFJKP(IReadOnlyList<NetworkedTransformEntity> OPCHNAJGPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9F40", Offset = "0x5DD8D40", VA = "0x185DD9F40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(EGCGLNEJKFD), new string[] { })]
public class EGCGLNEJKFD : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[PDOCKCLGMBB]
	private ABOCLKIIMFN IILAJDMEJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<string, GOBFDDPFJKP> CDADGDHFCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly List<NetworkedTransformEntity> JNPLOAOMLAC;

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6E10", Offset = "0x5DD5C10", VA = "0x185DD6E10", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD69D0", Offset = "0x5DD57D0", VA = "0x185DD69D0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6C60", Offset = "0x5DD5A60", VA = "0x185DD6C60")]
	public GOBFDDPFJKP IFHEBNIPFGI(string DAFCOOMAPBP)
	{
		return default(GOBFDDPFJKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6C00", Offset = "0x5DD5A00", VA = "0x185DD6C00")]
	private List<NetworkedTransformEntity> FAAODJPCGMD(GameObject LEMKPNELLPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6E60", Offset = "0x5DD5C60", VA = "0x185DD6E60")]
	public EGCGLNEJKFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(MBGHLAHGAKN), new string[] { })]
public class MBGHLAHGAKN : OFAFBMCCKFB, MPCGKLABPGO, EPBKMCPBINK, ENEHADLKBBF, GOMKIFEKCFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class LDALOKIDOHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public NFHEEPPLDKB services;

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LDALOKIDOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5DE11B0", Offset = "0x5DDFFB0", VA = "0x185DE11B0")]
		internal void MCPOJINMEJD(ENEHADLKBBF svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class NJBGAMOCPPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public NFHEEPPLDKB services;

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public NJBGAMOCPPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x5DE7ED0", Offset = "0x5DE6CD0", VA = "0x185DE7ED0")]
		internal void GIMOMJECKLK(GOMKIFEKCFK svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[PDOCKCLGMBB]
	private GPLPDCIMGEL MAKJPAFBEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[PDOCKCLGMBB]
	private NKBJOPBBMIN MFNODIMGLDN;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public KDMEBEDNNJH FGBLHLKNCNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7DCCC0", Offset = "0x7DBAC0", VA = "0x1807DCCC0", Slot = "4")]
		get
		{
			return default(KDMEBEDNNJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5210", Offset = "0x5DE4010", VA = "0x185DE5210", Slot = "5")]
	public void DOBAGIMKMLE(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE54A0", Offset = "0x5DE42A0", VA = "0x185DE54A0", Slot = "6")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5DE55C0", Offset = "0x5DE43C0", VA = "0x185DE55C0", Slot = "7")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5DE53C0", Offset = "0x5DE41C0", VA = "0x185DE53C0", Slot = "8")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5DE52A0", Offset = "0x5DE40A0", VA = "0x185DE52A0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x246C670", Offset = "0x246B470", VA = "0x18246C670")]
	private void NOOMOAPBIFD<T>(Action<T> NABEMHHAOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MBGHLAHGAKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[PMDCDBMECJP(typeof(PCGDABHJAAB), new string[] { })]
[DefaultMember("Item")]
public class BIDFIELKNPA : PCGDABHJAAB, IEnumerable<JAPFLFMMLAJ>, IEnumerable, MPCGKLABPGO, EPBKMCPBINK, ENEHADLKBBF, GOMKIFEKCFK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[PDOCKCLGMBB]
	private JADOLMLILGI NAFNNIMKNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly Dictionary<(Type, string), int> NINPIKNDBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private NativeBitArray AJMJIHNEJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private NativeArray<int> LCBGDEEANCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private LPIMHMEFHIL AJGEPCDOJNL;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public NativeBitArray LDCMJBHLIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xD63290", Offset = "0xD62090", VA = "0x180D63290", Slot = "4")]
		get
		{
			return default(NativeBitArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public NativeArray<int> CJEAKMJHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xD77A70", Offset = "0xD76870", VA = "0x180D77A70", Slot = "5")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private int FAIOICDNEML
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x842D70", Offset = "0x841B70", VA = "0x180842D70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x5DCBD40", Offset = "0x5DCAB40", VA = "0x185DCBD40", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public JAPFLFMMLAJ CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB700", Offset = "0x5DCA500", VA = "0x185DCB700", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public JAPFLFMMLAJ CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x5DCB700", Offset = "0x5DCA500", VA = "0x185DCB700", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB890", Offset = "0x5DCA690", VA = "0x185DCB890", Slot = "13")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB8E0", Offset = "0x5DCA6E0", VA = "0x185DCB8E0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "15")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBD60", Offset = "0x5DCAB60", VA = "0x185DCBD60")]
	private void NMENINDIELI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DCBB90", Offset = "0x5DCA990", VA = "0x185DCBB90", Slot = "9")]
	public JAPFLFMMLAJ NJHIOEAHJLK(BKOKDGLHFLO CJKMAIBCGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB740", Offset = "0x5DCA540", VA = "0x185DCB740")]
	private bool IFEDKAHHJLO(Type KAHCFCDLONP, string MEBBBIMBIJO, [Out] JAPFLFMMLAJ CONHAFAMJMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB960", Offset = "0x5DCA760", VA = "0x185DCB960", Slot = "10")]
	public FGBENGKJFDK LADFCBCEIOA(BKOKDGLHFLO CJKMAIBCGPM)
	{
		return default(FGBENGKJFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB720", Offset = "0x5DCA520", VA = "0x185DCB720", Slot = "11")]
	public IEnumerator<JAPFLFMMLAJ> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB720", Offset = "0x5DCA520", VA = "0x185DCB720", Slot = "12")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB6B0", Offset = "0x5DCA4B0", VA = "0x185DCB6B0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DCC690", Offset = "0x5DCB490", VA = "0x185DCC690")]
	public BIDFIELKNPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[PMDCDBMECJP(typeof(GAEECOGBKLC), new string[] { })]
[DefaultMember("Item")]
public class MBKJPPABLGG : GAEECOGBKLC, IEnumerable<IPEMFFHKPFK>, IEnumerable, MPCGKLABPGO, EPBKMCPBINK, ENEHADLKBBF, GOMKIFEKCFK, FPDFFDEKJBE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[PDOCKCLGMBB]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[PDOCKCLGMBB]
	private PCGDABHJAAB BKAIMIHKGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private IPEMFFHKPFK[] DJHNOOGGGEM;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x52A4190", Offset = "0x52A2F90", VA = "0x1852A4190", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public IPEMFFHKPFK CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x5DE56A0", Offset = "0x5DE44A0", VA = "0x185DE56A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "10")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DE58E0", Offset = "0x5DE46E0", VA = "0x185DE58E0", Slot = "11")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "12")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5C90", Offset = "0x5DE4A90", VA = "0x185DE5C90", Slot = "6")]
	public IPEMFFHKPFK NJHIOEAHJLK(BKOKDGLHFLO CJKMAIBCGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5BC0", Offset = "0x5DE49C0", VA = "0x185DE5BC0", Slot = "7")]
	public FGBENGKJFDK LADFCBCEIOA(BKOKDGLHFLO CJKMAIBCGPM)
	{
		return default(FGBENGKJFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5800", Offset = "0x5DE4600", VA = "0x185DE5800", Slot = "8")]
	public IEnumerator<IPEMFFHKPFK> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5DB0", Offset = "0x5DE4BB0", VA = "0x185DE5DB0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x246D9C0", Offset = "0x246C7C0", VA = "0x18246D9C0", Slot = "13")]
	public void CFEDMPPIKFO<TKey, T>(KFKPFKCNHBF<TKey, T> GHOAJKHDDHN, [Optional] object DDMHMHFODEB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DE56D0", Offset = "0x5DE44D0", VA = "0x185DE56D0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MBKJPPABLGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DE56A0", Offset = "0x5DE44A0", VA = "0x185DE56A0")]
	[CompilerGenerated]
	private IPEMFFHKPFK CEFFPAEEOHM(int NAKKFLBPDCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
[PMDCDBMECJP(typeof(KABMHKLOPCI), new string[] { })]
public class HDFEPKMBJLI : KABMHKLOPCI, IEnumerable<KHCEBOOKNAG>, IEnumerable, ENEHADLKBBF, GOMKIFEKCFK, FPDFFDEKJBE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	[PDOCKCLGMBB]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	[PDOCKCLGMBB]
	private PCGDABHJAAB BKAIMIHKGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private KHCEBOOKNAG[] DJHNOOGGGEM;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DDAA30", Offset = "0x5DD9830", VA = "0x185DDAA30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public KHCEBOOKNAG CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA2B0", Offset = "0x5DD90B0", VA = "0x185DDA2B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA7D0", Offset = "0x5DD95D0", VA = "0x185DDA7D0", Slot = "10")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA360", Offset = "0x5DD9160", VA = "0x185DDA360", Slot = "11")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA710", Offset = "0x5DD9510", VA = "0x185DDA710")]
	private KHCEBOOKNAG HBDOCKOJLLC(int OCMJNDDMDAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA910", Offset = "0x5DD9710", VA = "0x185DDA910", Slot = "6")]
	public KHCEBOOKNAG NJHIOEAHJLK(BKOKDGLHFLO CJKMAIBCGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA840", Offset = "0x5DD9640", VA = "0x185DDA840", Slot = "7")]
	public FGBENGKJFDK LADFCBCEIOA(BKOKDGLHFLO CJKMAIBCGPM)
	{
		return default(FGBENGKJFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA600", Offset = "0x5DD9400", VA = "0x185DDA600", Slot = "8")]
	public IEnumerator<KHCEBOOKNAG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA600", Offset = "0x5DD9400", VA = "0x185DDA600", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x23B04D0", Offset = "0x23AF2D0", VA = "0x1823B04D0", Slot = "12")]
	public void CFEDMPPIKFO<TKey, T>(KFKPFKCNHBF<TKey, T> GHOAJKHDDHN, [Optional] object DDMHMHFODEB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA2C0", Offset = "0x5DD90C0", VA = "0x185DDA2C0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HDFEPKMBJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA2B0", Offset = "0x5DD90B0", VA = "0x185DDA2B0")]
	[CompilerGenerated]
	private KHCEBOOKNAG CEFFPAEEOHM(int NAKKFLBPDCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[PMDCDBMECJP(typeof(JADOLMLILGI), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
internal class JADOLMLILGI : ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private PCGDABHJAAB BKAIMIHKGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private KABMHKLOPCI EAOLIKAIAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private GAEECOGBKLC PENBKDMPBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	[PDOCKCLGMBB]
	private NKBJOPBBMIN MFNODIMGLDN;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public LPIMHMEFHIL NNJBPHJPJBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x765480", Offset = "0x764280", VA = "0x180765480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCC90", Offset = "0x5DDBA90", VA = "0x185DDCC90", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCBF0", Offset = "0x5DDB9F0", VA = "0x185DDCBF0")]
	private void IMEKGBGGGDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCDE0", Offset = "0x5DDBBE0", VA = "0x185DDCDE0")]
	public JAPFLFMMLAJ NMPJIIMMDHD(BKOKDGLHFLO MEBBBIMBIJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x23F9340", Offset = "0x23F8140", VA = "0x1823F9340")]
	public ANFKAILOKHJ<T> LKENKGKJOEJ<T>(BKOKDGLHFLO MEBBBIMBIJO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public JADOLMLILGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal static class IDNOICPKEBK
{
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x23DFF60", Offset = "0x23DED60", VA = "0x1823DFF60")]
	public static KPOPJMLJIEE<T> NMPJIIMMDHD<T>(this JADOLMLILGI HDAFIMCPAMI, HPFFBCFNPLK<T> MEBBBIMBIJO) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(FNOCCIFKHLE), new string[] { })]
public class FNOCCIFKHLE : EPBKMCPBINK, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	[PDOCKCLGMBB]
	private KAFALIKLKOG KIGOEGBOPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool JHDLPAHMJFF;

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public TimeData HEMKPPNPGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DD8750", Offset = "0x5DD7550", VA = "0x185DD8750")]
		get
		{
			return default(TimeData);
		}
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x5DD87C0", Offset = "0x5DD75C0", VA = "0x185DD87C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool PBLEFAOIIKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7D58B0", Offset = "0x7D46B0", VA = "0x1807D58B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0xB922F0", Offset = "0xB910F0", VA = "0x180B922F0", Slot = "4")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8820", Offset = "0x5DD7620", VA = "0x185DD8820", Slot = "5")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DD86B0", Offset = "0x5DD74B0", VA = "0x185DD86B0")]
	public void FFBNIFCKGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	[Conditional("UNITY_DOTS_DEBUG")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	public void PLBCFHOOIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FNOCCIFKHLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[PMDCDBMECJP(typeof(INNJFFIHMKD), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
public class INNJFFIHMKD : ENEHADLKBBF, GOMKIFEKCFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private COAMDDAKEMC HAHKEFILEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private GAEECOGBKLC NAFNNIMKNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private FGBENGKJFDK[] LDPANJEIDPG;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCB80", Offset = "0x5DDB980", VA = "0x185DDCB80", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC920", Offset = "0x5DDB720", VA = "0x185DDC920", Slot = "5")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDC800", Offset = "0x5DDB600", VA = "0x185DDC800")]
	public void CPJCIPAIIIF(GFPOPKJOMLL OEAOJAGKHME, bool FMEAPDJNDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public INNJFFIHMKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[PMDCDBMECJP(typeof(BGBPCFADNPE), new string[] { })]
public sealed class JBKDDGJLKFN : BGBPCFADNPE, MPCGKLABPGO, EPBKMCPBINK, ENEHADLKBBF, GOMKIFEKCFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class KKBBEJNFHAA : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x95F230", Offset = "0x95E030", VA = "0x18095F230", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5DE1000", Offset = "0x5DDFE00", VA = "0x185DE1000", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1B673D0", Offset = "0x1B661D0", VA = "0x181B673D0")]
		[DebuggerHidden]
		public KKBBEJNFHAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0D10", Offset = "0x5DDFB10", VA = "0x185DE0D10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0FB0", Offset = "0x5DDFDB0", VA = "0x185DE0FB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0F00", Offset = "0x5DDFD00", VA = "0x185DE0F00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x5DE0F00", Offset = "0x5DDFD00", VA = "0x185DE0F00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	[PDOCKCLGMBB]
	private KABMHKLOPCI NAFNNIMKNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly EEHCBAKIPNJ DDGJLJIMEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<string, MGAKEBPNANJ> GCKDMIKFOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly Dictionary<int, PEDMLKJJBDF> AFBEBGELDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly List<KHCEBOOKNAG> ODAAKGHHHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private GIBPJGGCEHP KKMEMAJNNDL;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public PEDMLKJJBDF EHHHMPGAMLI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DDDCE0", Offset = "0x5DDCAE0", VA = "0x185DDDCE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public List<KHCEBOOKNAG> ONKBNBABHCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "9")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD890", Offset = "0x5DDC690", VA = "0x185DDD890", Slot = "10")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD720", Offset = "0x5DDC520", VA = "0x185DDD720", Slot = "11")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD620", Offset = "0x5DDC420", VA = "0x185DDD620", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE090", Offset = "0x5DDCE90", VA = "0x185DDE090", Slot = "6")]
	public bool NMJDECJKHMC(KHCEBOOKNAG GHOAJKHDDHN, [Out] PEDMLKJJBDF MIOHKBOBNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DDCEB0", Offset = "0x5DDBCB0", VA = "0x185DDCEB0")]
	private void ACPPLIBJIGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD3C0", Offset = "0x5DDC1C0", VA = "0x185DDD3C0")]
	private void CCFDOPEKOKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDA90", Offset = "0x5DDC890", VA = "0x185DDDA90")]
	private MGAKEBPNANJ LBOMJILCLGF(string FOMCEKAGNAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDCE0", Offset = "0x5DDCAE0", VA = "0x185DDDCE0")]
	private MGAKEBPNANJ PGGFDOCFMCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDDD0", Offset = "0x5DDCBD0", VA = "0x185DDDDD0")]
	private MGAKEBPNANJ MJPDCFMKJGH(string FOMCEKAGNAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDAF0", Offset = "0x5DDC8F0", VA = "0x185DDDAF0")]
	private MGAKEBPNANJ LEDCGKBBEKO(string MCGLDNPFLND, string EKDHBKMFLGI, [Optional] MGAKEBPNANJ GDIDNBODHLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD810", Offset = "0x5DDC610", VA = "0x185DDD810")]
	[IteratorStateMachine(typeof(KKBBEJNFHAA))]
	private IEnumerable<(string, string)> HLNLJFPBEIH(string FOMCEKAGNAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD6D0", Offset = "0x5DDC4D0", VA = "0x185DDD6D0")]
	private bool EFBHPAFOHAB(KHCEBOOKNAG GHOAJKHDDHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD2E0", Offset = "0x5DDC0E0", VA = "0x185DDD2E0")]
	private EEHCBAKIPNJ APLMLIEIJAM(KHCEBOOKNAG GHOAJKHDDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD290", Offset = "0x5DDC090", VA = "0x185DDD290")]
	private EEHCBAKIPNJ ANDLEEFOMCM(KHCEBOOKNAG GHOAJKHDDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD780", Offset = "0x5DDC580", VA = "0x185DDD780")]
	private EEHCBAKIPNJ HEEIHBCLKGH(KHCEBOOKNAG GHOAJKHDDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x23F9840", Offset = "0x23F8640", VA = "0x1823F9840")]
	private T JNCNPGGBALC<T>(KHCEBOOKNAG GHOAJKHDDHN) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD8F0", Offset = "0x5DDC6F0", VA = "0x185DDD8F0")]
	private FieldInfo JOGCFLIDINB(KHCEBOOKNAG GHOAJKHDDHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD9E0", Offset = "0x5DDC7E0", VA = "0x185DDD9E0", Slot = "7")]
	public void LAPCBGMBHPD(KHCEBOOKNAG GHOAJKHDDHN, AJFPEFELLGP ONPHIIHFHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5DDD570", Offset = "0x5DDC370", VA = "0x185DDD570", Slot = "8")]
	public void CGLEMEJEKGC(KHCEBOOKNAG GHOAJKHDDHN, AJFPEFELLGP ONPHIIHFHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5DDE120", Offset = "0x5DDCF20", VA = "0x185DDE120")]
	public JBKDDGJLKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5DDDD40", Offset = "0x5DDCB40", VA = "0x185DDDD40")]
	[CompilerGenerated]
	private int MJHGNEDOFKF(KHCEBOOKNAG APOJANFJHJO, KHCEBOOKNAG DFBIFCHBAHF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public sealed class MGAKEBPNANJ : PEDMLKJJBDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public readonly string KOOEJCNEEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public readonly MGAKEBPNANJ GDIDNBODHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public readonly List<MGAKEBPNANJ> BDJHADLCLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public readonly List<KHCEBOOKNAG> NAFNNIMKNLM;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public string KHPAMEMHAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public PEDMLKJJBDF GDIFENAMONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public IEnumerable<PEDMLKJJBDF> CPDOBFJIMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5DE5DD0", Offset = "0x5DE4BD0", VA = "0x185DE5DD0")]
	public MGAKEBPNANJ(string MEBBBIMBIJO, MGAKEBPNANJ LPDGANJNOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[PMDCDBMECJP(typeof(global::EKFJFCJFJAH), new string[] { })]
internal class PIIDAHMBLCJ : global::EKFJFCJFJAH, ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[PDOCKCLGMBB]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	[PDOCKCLGMBB]
	private GGFHNIDOMCL MPANOGNBHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	[PDOCKCLGMBB]
	private JADOLMLILGI NAFNNIMKNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	[PDOCKCLGMBB]
	private GIBPJGGCEHP JOJOJMCMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Action<NIAMBHMBMDP> PMOMGAGBHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private KPOPJMLJIEE<Entity> LPDGANJNOMK;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<NIAMBHMBMDP> IKIMBMPPPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x5DEB770", Offset = "0x5DEA570", VA = "0x185DEB770", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x5DEBA30", Offset = "0x5DEA830", VA = "0x185DEBA30", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB8F0", Offset = "0x5DEA6F0", VA = "0x185DEB8F0", Slot = "6")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB5F0", Offset = "0x5DEA3F0", VA = "0x185DEB5F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB770", Offset = "0x5DEA570", VA = "0x185DEB770")]
	private void KCKHJHILAAM(Action<NIAMBHMBMDP> POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5DEBA30", Offset = "0x5DEA830", VA = "0x185DEBA30")]
	private void KOJHJHNEDHB(Action<NIAMBHMBMDP> POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x5DEB700", Offset = "0x5DEA500", VA = "0x185DEB700")]
	private void GGKALDLBNOO(NGPHMHKDGKO LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public PIIDAHMBLCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[OCEGCBKNAGD(LJHGMNIEOPD.LoadInstance)]
[PMDCDBMECJP(typeof(BFBNMGKGEOE), new string[] { })]
public class BFBNMGKGEOE : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	[PDOCKCLGMBB]
	private DICMBGCFOEP AANIPHFOBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	[PDOCKCLGMBB]
	private KKAFIEKFBPH FAKOALIJNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	[PDOCKCLGMBB]
	private PAPIHHEIJJK BEEHCIODHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	[PDOCKCLGMBB]
	private OJJJKLOBGFC JHNFBPKNCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB520", Offset = "0x5DCA320", VA = "0x185DCB520", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB440", Offset = "0x5DCA240", VA = "0x185DCB440", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB490", Offset = "0x5DCA290", VA = "0x185DCB490")]
	private void HBIIDOIFEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB440", Offset = "0x5DCA240", VA = "0x185DCB440")]
	private void IFAMHJPNHHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5DCB660", Offset = "0x5DCA460", VA = "0x185DCB660")]
	private void NBDLGHFJBAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BFBNMGKGEOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[PMDCDBMECJP(typeof(BIOMOMPOMEM), new string[] { })]
public class EAHHFIGBLNB : BIOMOMPOMEM, ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[PDOCKCLGMBB]
	private CCAABBKKMFL MIFGFMNKAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[PDOCKCLGMBB]
	private CIBALBEFCIK ENAGKCDJIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private readonly List<NativeListAsync<Entity>> POBNCLDBMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private readonly List<(NativeListAsync<Entity>, bool)> LGEPOLMEBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private NJHLOPMHPJF NBIJLFHGPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private Dictionary<Entity, MBFKJGGINKF> IENIBFNJHOE;

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x5DD61F0", Offset = "0x5DD4FF0", VA = "0x185DD61F0", Slot = "8")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5DD60D0", Offset = "0x5DD4ED0", VA = "0x185DD60D0", Slot = "4")]
	public void ELPIKEEOAHH(NativeListAsync<Entity> DDIFFODKOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5DD61A0", Offset = "0x5DD4FA0", VA = "0x185DD61A0", Slot = "5")]
	public void HJPMCPFJFJP(NJHLOPMHPJF NBIJLFHGPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6260", Offset = "0x5DD5060", VA = "0x185DD6260", Slot = "6")]
	public void JILJJANGFJE(NativeListAsync<Entity> DDIFFODKOKJ, bool JIEFCKEOLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5DD58C0", Offset = "0x5DD46C0", VA = "0x185DD58C0", Slot = "7")]
	public void CJCJCIFGJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5C40", Offset = "0x5DD4A40", VA = "0x185DD5C40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5DD65E0", Offset = "0x5DD53E0", VA = "0x185DD65E0")]
	private int OAECOCPPDCC(NativeListAsync<Entity> POBNCLDBMMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5650", Offset = "0x5DD4450", VA = "0x185DD5650")]
	private int CGDNHAOFPNO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6390", Offset = "0x5DD5190", VA = "0x185DD6390")]
	private int LALBHIIFOFI(NativeListAsync<Entity> LGEPOLMEBJB, bool LIMBOJHOFMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD68B0", Offset = "0x5DD56B0", VA = "0x185DD68B0")]
	public EAHHFIGBLNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD65B0", Offset = "0x5DD53B0", VA = "0x185DD65B0")]
	[CompilerGenerated]
	private EPCANLGBBON LCHGEKNCMIM(Entity HHHGBIJCKBC)
	{
		return default(EPCANLGBBON);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[PMDCDBMECJP(typeof(LEDNNBIOKKJ), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.LoadInstance)]
public class LEDNNBIOKKJ : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private readonly List<NativeListAsync<FCFCCPMBGOI>> JMPOKMOFALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5E01320", Offset = "0x5E00120", VA = "0x185E01320", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x5E00CD0", Offset = "0x5DFFAD0", VA = "0x185E00CD0")]
	public void CIKPJKCGIJG(NativeListAsync<FCFCCPMBGOI> DDIFFODKOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x5E00DA0", Offset = "0x5DFFBA0", VA = "0x185E00DA0")]
	public void DMELDEFIIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5E011A0", Offset = "0x5DFFFA0", VA = "0x185E011A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x5E01400", Offset = "0x5E00200", VA = "0x185E01400")]
	public LEDNNBIOKKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[PMDCDBMECJP(typeof(HHMMFDFOECD), new string[] { })]
public class GPOAJDFMJLN : ENEHADLKBBF, HHMMFDFOECD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private EntityManager GMDAKDJOHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private AEPPNFHDEIC AOFIBMEJBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private CIBALBEFCIK ENAGKCDJIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5DFACA0", Offset = "0x5DF9AA0", VA = "0x185DFACA0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5DFABF0", Offset = "0x5DF99F0", VA = "0x185DFABF0", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAAB0", Offset = "0x5DF98B0", VA = "0x185DFAAB0", Slot = "5")]
	public bool BOFJNFLNFAP(EPCANLGBBON GOOJPBOEHHC, [Out] Collider DOMPEOMIALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA8F0", Offset = "0x5DF96F0", VA = "0x185DFA8F0", Slot = "6")]
	public GameObject BNPAOMKJJNO(EPCANLGBBON IIKFLBDOFKK, GameObject HLHCBBFMOMC, Vector3 BBEJKAIJGPI, Quaternion IOMLNAOLLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAC00", Offset = "0x5DF9A00", VA = "0x185DFAC00", Slot = "7")]
	public void EELMLFALDBF(GameObject DOMPEOMIALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x23A8060", Offset = "0x23A6E60", VA = "0x1823A8060", Slot = "8")]
	public TCollider OGPMGBONNIO<TCollider>(GameObject MJFCJHECNAC) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAD70", Offset = "0x5DF9B70", VA = "0x185DFAD70", Slot = "9")]
	public void KMJHFHADPHB(Collider DOMPEOMIALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x23A8060", Offset = "0x23A6E60", VA = "0x1823A8060", Slot = "10")]
	public GameObject LIHGLPLBGJF<TCollider>(string MEBBBIMBIJO) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public GPOAJDFMJLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[PMDCDBMECJP(typeof(HCCIMPJEHHN), new string[] { })]
public class NBGHPCAJNCN : ENEHADLKBBF, HCCIMPJEHHN
{
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private CJJPMIMHLNN FGGAOAAIACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private World JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private BEJFNELDFAM APLNAIACLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	[PDOCKCLGMBB]
	private KAFALIKLKOG KIGOEGBOPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private EntityManager LEMJLPIMHJB;

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5E06190", Offset = "0x5E04F90", VA = "0x185E06190", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5E06810", Offset = "0x5E05610", VA = "0x185E06810", Slot = "6")]
	public IBIAPBPMOCH KEOBBHHCCHC(EPCANLGBBON GOOJPBOEHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5E03FE0", Offset = "0x5E02DE0", VA = "0x185E03FE0", Slot = "5")]
	public void BACGDLFNMFK(EPCANLGBBON GOOJPBOEHHC, IBIAPBPMOCH POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x5E04B40", Offset = "0x5E03940", VA = "0x185E04B40", Slot = "31")]
	public CollisionDetectionMode EHFALNALNAG(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(CollisionDetectionMode);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5E04C60", Offset = "0x5E03A60", VA = "0x185E04C60", Slot = "32")]
	public void EMCOIKGPOIO(EPCANLGBBON GOOJPBOEHHC, CollisionDetectionMode POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5E04CF0", Offset = "0x5E03AF0", VA = "0x185E04CF0", Slot = "33")]
	public NJDNLEIDKBA EPMHIMDJPPF(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(NJDNLEIDKBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x5E04F40", Offset = "0x5E03D40", VA = "0x185E04F40", Slot = "34")]
	public void FEOPGJKDCKB(EPCANLGBBON GOOJPBOEHHC, NJDNLEIDKBA POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x5E05700", Offset = "0x5E04500", VA = "0x185E05700", Slot = "35")]
	public bool GIGGMNMCCDK(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x5E07400", Offset = "0x5E06200", VA = "0x185E07400", Slot = "36")]
	public void NFBANLJEIOO(EPCANLGBBON GOOJPBOEHHC, bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x5E041D0", Offset = "0x5E02FD0", VA = "0x185E041D0", Slot = "37")]
	public EPCANLGBBON BGLIKGBFACL(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x5E05360", Offset = "0x5E04160", VA = "0x185E05360", Slot = "38")]
	public void FOEMEFHAPHB(EPCANLGBBON GOOJPBOEHHC, EPCANLGBBON POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5E05E10", Offset = "0x5E04C10", VA = "0x185E05E10", Slot = "39")]
	public EPCANLGBBON IJFJAGHBHFC(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5E03D60", Offset = "0x5E02B60", VA = "0x185E03D60", Slot = "40")]
	public void AIEIBGACDCB(EPCANLGBBON GOOJPBOEHHC, EPCANLGBBON POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5E04690", Offset = "0x5E03490", VA = "0x185E04690", Slot = "7")]
	public void CLPCBEDDCDJ(EPCANLGBBON GOOJPBOEHHC, EPCANLGBBON POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x5E04DD0", Offset = "0x5E03BD0", VA = "0x185E04DD0", Slot = "8")]
	public void FAGKNOIOPHJ(EPCANLGBBON GOOJPBOEHHC, EPCANLGBBON POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5E06B00", Offset = "0x5E05900", VA = "0x185E06B00", Slot = "9")]
	public int LBPEHGFNEKK(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5E042E0", Offset = "0x5E030E0", VA = "0x185E042E0", Slot = "10")]
	public EPCANLGBBON BIBMCMPJPFO(EPCANLGBBON GOOJPBOEHHC, int OCMJNDDMDAL)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5E05200", Offset = "0x5E04000", VA = "0x185E05200", Slot = "11")]
	public void FJJKKPJEINO(EPCANLGBBON GOOJPBOEHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x5E05100", Offset = "0x5E03F00", VA = "0x185E05100", Slot = "12")]
	public void FGLKJEALAGA(EPCANLGBBON GOOJPBOEHHC, object EKDHBKMFLGI, EPCANLGBBON POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5E04FF0", Offset = "0x5E03DF0", VA = "0x185E04FF0", Slot = "13")]
	public void FFJOHCGOLID(EPCANLGBBON GOOJPBOEHHC, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x5E06400", Offset = "0x5E05200", VA = "0x185E06400", Slot = "14")]
	public bool JENMAKOGJPH(EPCANLGBBON GOOJPBOEHHC, [Out] EPCANLGBBON POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x5E06CE0", Offset = "0x5E05AE0", VA = "0x185E06CE0", Slot = "15")]
	public void LILPGFMFLAG(EPCANLGBBON GOOJPBOEHHC, float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5E05780", Offset = "0x5E04580", VA = "0x185E05780", Slot = "16")]
	public bool GMOJAJFBCCC(EPCANLGBBON GOOJPBOEHHC, [Out] float3 POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5E04130", Offset = "0x5E02F30", VA = "0x185E04130", Slot = "17")]
	public void BEILOJKDCEF(EPCANLGBBON GOOJPBOEHHC, float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5E07470", Offset = "0x5E06270", VA = "0x185E07470", Slot = "18")]
	public bool NJLHDCCFANA(EPCANLGBBON GOOJPBOEHHC, [Out] float3 POACLGOFKAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x5E06BD0", Offset = "0x5E059D0", VA = "0x185E06BD0", Slot = "23")]
	[Obsolete("Use SetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	public float3 LIKGANGEMDE(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5E04BC0", Offset = "0x5E039C0", VA = "0x185E04BC0", Slot = "24")]
	public float3 ELNMPMPNAHH(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5E05B80", Offset = "0x5E04980", VA = "0x185E05B80", Slot = "25")]
	public void IAELNJKECHF(EPCANLGBBON GOOJPBOEHHC, float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5E077C0", Offset = "0x5E065C0", VA = "0x185E077C0", Slot = "26")]
	public void PMPCKIDHIFM(EPCANLGBBON GOOJPBOEHHC, float3 POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x5E05D20", Offset = "0x5E04B20", VA = "0x185E05D20", Slot = "27")]
	[Obsolete("Use GetMassOfSelf or TryGetMassOfHierarchy")]
	public float IINFPMOOAEF(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x5E05B00", Offset = "0x5E04900", VA = "0x185E05B00", Slot = "28")]
	public float IAEGPFGAFFB(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x5E040A0", Offset = "0x5E02EA0", VA = "0x185E040A0", Slot = "29")]
	public void BEIIHKJAGPJ(EPCANLGBBON GOOJPBOEHHC, float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x5E03F50", Offset = "0x5E02D50", VA = "0x185E03F50", Slot = "30")]
	public void APDOLONMFKA(EPCANLGBBON GOOJPBOEHHC, float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x5E043E0", Offset = "0x5E031E0", VA = "0x185E043E0", Slot = "19")]
	public void BOCHFLMPOAD(EPCANLGBBON GOOJPBOEHHC, (Quaternion rot, Vector3 moments) LHFNLIJPCKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x5E05400", Offset = "0x5E04200", VA = "0x185E05400", Slot = "20")]
	public bool FOHGNPGAAIC(EPCANLGBBON GOOJPBOEHHC, [Out] quaternion IGIKFKIIFKN, [Out] float3 NHOJAOKJBIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x5E06930", Offset = "0x5E05730", VA = "0x185E06930", Slot = "41")]
	public KLJHGLPFOPI KJNKGLPOFCI(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(KLJHGLPFOPI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x5E03C60", Offset = "0x5E02A60", VA = "0x185E03C60", Slot = "42")]
	public void ABDEKGBCPAB(EPCANLGBBON GOOJPBOEHHC, KLJHGLPFOPI POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5E05980", Offset = "0x5E04780", VA = "0x185E05980", Slot = "66")]
	public void HHOKMGAAFGL(EPCANLGBBON GOOJPBOEHHC, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5E04600", Offset = "0x5E03400", VA = "0x185E04600", Slot = "67")]
	public void CJJFGJMPNPH(EPCANLGBBON GOOJPBOEHHC, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5E066A0", Offset = "0x5E054A0", VA = "0x185E066A0", Slot = "68")]
	public bool JOBMPFAFDFA(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5E05C20", Offset = "0x5E04A20", VA = "0x185E05C20", Slot = "82")]
	public bool ICLHEFBBDGN(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x5E05EB0", Offset = "0x5E04CB0", VA = "0x185E05EB0", Slot = "83")]
	public void IJIOPHGGAIN(EPCANLGBBON GOOJPBOEHHC, object EKDHBKMFLGI, bool PACNNAFJCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x5E06FE0", Offset = "0x5E05DE0", VA = "0x185E06FE0", Slot = "84")]
	public void LPOOGHGNKPD(EPCANLGBBON GOOJPBOEHHC, bool EDFIDMACHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x5E047D0", Offset = "0x5E035D0", VA = "0x185E047D0", Slot = "86")]
	public bool COBMPCFNOBG(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x5E05A90", Offset = "0x5E04890", VA = "0x185E05A90", Slot = "85")]
	public void HLLPANGEAJD(EPCANLGBBON GOOJPBOEHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x5E06EE0", Offset = "0x5E05CE0", VA = "0x185E06EE0", Slot = "43")]
	public bool LLMEBBNGFKC(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5E07200", Offset = "0x5E06000", VA = "0x185E07200", Slot = "44")]
	public void MHELDKHGKIL(EPCANLGBBON GOOJPBOEHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x5E07640", Offset = "0x5E06440", VA = "0x185E07640", Slot = "45")]
	public bool OKHKGJFFHGC(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5E067A0", Offset = "0x5E055A0", VA = "0x185E067A0", Slot = "46")]
	public void KALBFMAEFCJ(EPCANLGBBON GOOJPBOEHHC, bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x5E05080", Offset = "0x5E03E80", VA = "0x185E05080", Slot = "47")]
	public bool FFLNOKPMNNP(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x5E04A40", Offset = "0x5E03840", VA = "0x185E04A40", Slot = "48")]
	public void DLFMIGBNIIB(EPCANLGBBON GOOJPBOEHHC, bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x5E04920", Offset = "0x5E03720", VA = "0x185E04920", Slot = "49")]
	public RigidbodyConstraints DIGJFODLLFC(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(RigidbodyConstraints);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x5E05A00", Offset = "0x5E04800", VA = "0x185E05A00", Slot = "50")]
	public void HJCNJCPLNLI(EPCANLGBBON GOOJPBOEHHC, RigidbodyConstraints POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x5E05680", Offset = "0x5E04480", VA = "0x185E05680", Slot = "51")]
	public float GFPNLBFKDBP(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x5E07260", Offset = "0x5E06060", VA = "0x185E07260", Slot = "52")]
	public void MLKCEFCDGEA(EPCANLGBBON GOOJPBOEHHC, float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x5E076C0", Offset = "0x5E064C0", VA = "0x185E076C0", Slot = "53")]
	public float PCJKCNMAMOK(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x5E052D0", Offset = "0x5E040D0", VA = "0x185E052D0", Slot = "54")]
	public void FJPFOLONMII(EPCANLGBBON GOOJPBOEHHC, float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x5E05600", Offset = "0x5E04400", VA = "0x185E05600", Slot = "55")]
	public bool GBHBGHDJDNH(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x5E04270", Offset = "0x5E03070", VA = "0x185E04270", Slot = "56")]
	public void BGOOAELNHIE(EPCANLGBBON GOOJPBOEHHC, bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x5E06110", Offset = "0x5E04F10", VA = "0x185E06110", Slot = "57")]
	public bool IMNKCICOAAA(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x5E07050", Offset = "0x5E05E50", VA = "0x185E07050", Slot = "58")]
	public void MBLHJNAMHNH(EPCANLGBBON GOOJPBOEHHC, bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x5E070C0", Offset = "0x5E05EC0", VA = "0x185E070C0", Slot = "59")]
	public void MEINMFCFJPG(EPCANLGBBON GOOJPBOEHHC, int POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x5E04AB0", Offset = "0x5E038B0", VA = "0x185E04AB0", Slot = "73")]
	public Rigidbody DPKKAHLBLOD(EPCANLGBBON GOOJPBOEHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x5E062B0", Offset = "0x5E050B0", VA = "0x185E062B0", Slot = "74")]
	public void JBIPDKKJCAJ(EPCANLGBBON GOOJPBOEHHC, Rigidbody POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5E07380", Offset = "0x5E06180", VA = "0x185E07380", Slot = "75")]
	public void MPBJBLDHMLC(EPCANLGBBON GOOJPBOEHHC, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x5E06710", Offset = "0x5E05510", VA = "0x185E06710", Slot = "76")]
	public void JOMCGDIDDGE(EPCANLGBBON GOOJPBOEHHC, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x5E03CF0", Offset = "0x5E02AF0", VA = "0x185E03CF0", Slot = "77")]
	public bool ADHANGKDIJB(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x5E072F0", Offset = "0x5E060F0", VA = "0x185E072F0", Slot = "60")]
	public object MMGBBBOFNGG(EPCANLGBBON GOOJPBOEHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x5E069B0", Offset = "0x5E057B0", VA = "0x185E069B0", Slot = "61")]
	public void KLOIPKOBKJK(EPCANLGBBON GOOJPBOEHHC, object POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x5E04EB0", Offset = "0x5E03CB0", VA = "0x185E04EB0", Slot = "62")]
	public object FBBAEPOMGBG(EPCANLGBBON GOOJPBOEHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x5E03E00", Offset = "0x5E02C00", VA = "0x185E03E00", Slot = "63")]
	public void ALIMOOCGCGI(EPCANLGBBON GOOJPBOEHHC, object POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x5E06F60", Offset = "0x5E05D60", VA = "0x185E06F60", Slot = "64")]
	public float LPCOGJIMOON(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x5E068A0", Offset = "0x5E056A0", VA = "0x185E068A0", Slot = "65")]
	public void KJANEGBMKKK(EPCANLGBBON GOOJPBOEHHC, float POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x5E04840", Offset = "0x5E03640", VA = "0x185E04840", Slot = "69")]
	public void COEMIDMKFCI(EPCANLGBBON GOOJPBOEHHC, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5E04570", Offset = "0x5E03370", VA = "0x185E04570", Slot = "70")]
	public void CEFPPMHFMEJ(EPCANLGBBON GOOJPBOEHHC, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5E075D0", Offset = "0x5E063D0", VA = "0x185E075D0", Slot = "71")]
	public bool ODFDINAFDDJ(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5E04770", Offset = "0x5E03570", VA = "0x185E04770", Slot = "21")]
	public void CNEDMOAOEKL(EPCANLGBBON GOOJPBOEHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x5E048C0", Offset = "0x5E036C0", VA = "0x185E048C0", Slot = "22")]
	public void DFAKMFPPJBG(EPCANLGBBON GOOJPBOEHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x5E07740", Offset = "0x5E06540", VA = "0x185E07740", Slot = "72")]
	public bool PLBBJIAMJEM(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5E058E0", Offset = "0x5E046E0", VA = "0x185E058E0", Slot = "78")]
	public void HEHBOOKOADE(EPCANLGBBON GOOJPBOEHHC, float3 JIJAOBLIPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5E049A0", Offset = "0x5E037A0", VA = "0x185E049A0", Slot = "79")]
	public void DJKIDBOJIHL(EPCANLGBBON GOOJPBOEHHC, float3 PCFFHDKFCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5E06540", Offset = "0x5E05340", VA = "0x185E06540", Slot = "80")]
	public bool JIHIHJBNFJH(EPCANLGBBON GOOJPBOEHHC, [Out] float3 JIJAOBLIPMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5E06D80", Offset = "0x5E05B80", VA = "0x185E06D80", Slot = "81")]
	public bool LJJLHPHBECO(EPCANLGBBON GOOJPBOEHHC, [Out] float3 PCFFHDKFCBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x5E06060", Offset = "0x5E04E60", VA = "0x185E06060")]
	private DynamicBuffer<Entity> IKEBABFGJPB(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x5E07150", Offset = "0x5E05F50", VA = "0x185E07150")]
	private DynamicBuffer<Entity> MHAPCIOLKLM(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x24DC770", Offset = "0x24DB570", VA = "0x1824DC770")]
	private void IDBENEHGBFH<T>(EPCANLGBBON GOOJPBOEHHC, object POACLGOFKAJ, Func<object, T> NPGBADJBLCI) where T : class, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public NBGHPCAJNCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[OCEGCBKNAGD(LJHGMNIEOPD.LoadInstance)]
[PMDCDBMECJP(typeof(IEOGICFOKCI), new string[] { })]
public class IEOGICFOKCI : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class MGMNEICDIKN : IEnumerable<IBIAPBPMOCH>, IEnumerable, IEnumerator<IBIAPBPMOCH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private IBIAPBPMOCH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public IEOGICFOKCI <>4__this;

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
		private IBIAPBPMOCH System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x86F050", Offset = "0x86DE50", VA = "0x18086F050")]
		[DebuggerHidden]
		public MGMNEICDIKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E02620", Offset = "0x5E01420", VA = "0x185E02620", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E022F0", Offset = "0x5E010F0", VA = "0x185E022F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E022A0", Offset = "0x5E010A0", VA = "0x185E022A0")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E025D0", Offset = "0x5E013D0", VA = "0x185E025D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E02520", Offset = "0x5E01320", VA = "0x185E02520", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IBIAPBPMOCH> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E02520", Offset = "0x5E01320", VA = "0x185E02520", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> LHDFDDJDHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD930", Offset = "0x5DFC730", VA = "0x185DFD930", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD420", Offset = "0x5DFC220", VA = "0x185DFD420")]
	public void CIKPJKCGIJG(NativeArray<Entity> DDIFFODKOKJ, bool AFOALFGFIOP, bool NPPKPKGNBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD580", Offset = "0x5DFC380", VA = "0x185DFD580")]
	public void DMELDEFIIBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x5DFDA10", Offset = "0x5DFC810", VA = "0x185DFDA10")]
	private void OBKFDBAECIH(NativeArray<Entity> DDIFFODKOKJ, bool AFOALFGFIOP, bool NPPKPKGNBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD980", Offset = "0x5DFC780", VA = "0x185DFD980")]
	[IteratorStateMachine(typeof(MGMNEICDIKN))]
	private IEnumerable<IBIAPBPMOCH> LDGHLPIGHCP(NativeArray<Entity> DDIFFODKOKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD7C0", Offset = "0x5DFC5C0", VA = "0x185DFD7C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE2B0", Offset = "0x5DFD0B0", VA = "0x185DFE2B0")]
	public IEOGICFOKCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[PMDCDBMECJP(typeof(IHIHFIGNGCB), new string[] { })]
public class EALBNOCILEE : IHIHFIGNGCB, ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private class ALFLFNJJGHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public List<CapsuleCollider> CEEAOGOABKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public List<SphereCollider> GDLAIGFMABP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public GameObject JEPMDCBPEBC;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5DEDFA0", Offset = "0x5DECDA0", VA = "0x185DEDFA0")]
		public ALFLFNJJGHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	[PDOCKCLGMBB]
	private CCAABBKKMFL MIFGFMNKAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	[PDOCKCLGMBB]
	private HHMMFDFOECD BGFMCJKBNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly Dictionary<Entity, ALFLFNJJGHJ> LLBOHMJMJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private GameObject DIJJPNIHEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private GameObject JCJLIGEKLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private GameObject ENPAPEKLELL;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private GameObject KJLKJNAGDOC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DF6AC0", Offset = "0x5DF58C0", VA = "0x185DF6AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6B80", Offset = "0x5DF5980", VA = "0x185DF6B80", Slot = "6")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7C90", Offset = "0x5DF6A90", VA = "0x185DF7C90", Slot = "4")]
	public void OHKMLNMCIBG(Entity MPPNLJDALNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7740", Offset = "0x5DF6540", VA = "0x185DF7740", Slot = "5")]
	public void NGMMMHEMBHJ(Entity MPPNLJDALNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5DF69A0", Offset = "0x5DF57A0", VA = "0x185DF69A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5DF7ED0", Offset = "0x5DF6CD0", VA = "0x185DF7ED0")]
	private ALFLFNJJGHJ PJMEPFGAGGL(Entity MPPNLJDALNO, HEGOHGFLPKD DNGAALMGOEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6BF0", Offset = "0x5DF59F0", VA = "0x185DF6BF0")]
	private void LECAOCHNHIJ(HEGOHGFLPKD DNGAALMGOEC, ALFLFNJJGHJ IDELLKNMHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6320", Offset = "0x5DF5120", VA = "0x185DF6320")]
	private void ADONPKLJHHH(HEGOHGFLPKD DNGAALMGOEC, ALFLFNJJGHJ IDELLKNMHJN, int BPIICAKOONH, Vector3 CMKBDFOJBFE, Quaternion ALADLBOMNEP, float HMBCCKMGEBH, float EBEJFDNBBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF67E0", Offset = "0x5DF55E0", VA = "0x185DF67E0")]
	private void DCMGEOJMGDB(ALFLFNJJGHJ IDELLKNMHJN, int KOMONLGPFHM, Vector3 CMKBDFOJBFE, float HMBCCKMGEBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DF6500", Offset = "0x5DF5300", VA = "0x185DF6500")]
	private void CFAAKKPBMMF(HEGOHGFLPKD DNGAALMGOEC, ALFLFNJJGHJ IDELLKNMHJN, int HOCHNHLGIGF, int KDKBKEGKAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2242870", Offset = "0x2241670", VA = "0x182242870")]
	private T OFFPEHLICAH<T>(HEGOHGFLPKD DNGAALMGOEC, GameObject LHMPGCOFOMN, Vector3 BBEJKAIJGPI, Quaternion IOMLNAOLLNL) where T : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DF81C0", Offset = "0x5DF6FC0", VA = "0x185DF81C0")]
	public EALBNOCILEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[PMDCDBMECJP(typeof(BHGAALGADLM), new string[] { })]
public class MOOIIJEEAMA : ENEHADLKBBF, GOMKIFEKCFK, BHGAALGADLM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private LEALPNGCHEO MPANOGNBHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private EHGJMOLBODP KOPAGBBKACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private GIBPJGGCEHP KKMEMAJNNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private EJEHNKDAAFL MIDOOAJNOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private int HNLAEEIIAEP;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public bool MGMFGMPEEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E03740", Offset = "0x5E02540", VA = "0x185E03740", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public EPCANLGBBON PHGBOKPNOPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E036F0", Offset = "0x5E024F0", VA = "0x185E036F0", Slot = "9")]
		get
		{
			return default(EPCANLGBBON);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E02B60", Offset = "0x5E01960", VA = "0x185E02B60", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public ELJLMFEGKCH CBDKNGHJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E03710", Offset = "0x5E02510", VA = "0x185E03710", Slot = "11")]
		get
		{
			return default(ELJLMFEGKCH);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E02B60", Offset = "0x5E01960", VA = "0x185E02B60", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	private uint KEDIDCGOCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5E03360", Offset = "0x5E02160", VA = "0x185E03360")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event KHKIEFOOIGB LOPEMMLICGF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E03480", Offset = "0x5E02280", VA = "0x185E03480", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E037E0", Offset = "0x5E025E0", VA = "0x185E037E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E033B0", Offset = "0x5E021B0", VA = "0x185E033B0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E02FA0", Offset = "0x5E01DA0", VA = "0x185E02FA0", Slot = "5")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E02DC0", Offset = "0x5E01BC0", VA = "0x185E02DC0", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E02BD0", Offset = "0x5E019D0", VA = "0x185E02BD0")]
	private void CHCBHBDOGMJ(NGPHMHKDGKO LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E03130", Offset = "0x5E01F30", VA = "0x185E03130", Slot = "13")]
	public EPCANLGBBON FKEEIEILNIM(EPCANLGBBON PABBJIBBIGE, EPCANLGBBON GICCMHHJDGA)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E02EB0", Offset = "0x5E01CB0", VA = "0x185E02EB0", Slot = "14")]
	public bool ECOIFBFLNNA(EPCANLGBBON PABBJIBBIGE, EPCANLGBBON GICCMHHJDGA, [Out] EPCANLGBBON BDEDPDJICOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E03200", Offset = "0x5E02000", VA = "0x185E03200", Slot = "15")]
	public void GKLOGLKBKIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E03770", Offset = "0x5E02570", VA = "0x185E03770", Slot = "16")]
	public void PKIKEMAABJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E03520", Offset = "0x5E02320", VA = "0x185E03520", Slot = "17")]
	public bool JJBAJIJEJHM(EPCANLGBBON PABBJIBBIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E03640", Offset = "0x5E02440", VA = "0x185E03640", Slot = "18")]
	public bool JNMAHGLGILA(EPCANLGBBON PABBJIBBIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E02B60", Offset = "0x5E01960", VA = "0x185E02B60")]
	private void BIDEJMENFAC(EPCANLGBBON BGOFFGAHHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MOOIIJEEAMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[PMDCDBMECJP(typeof(BEFNJLBOONF), new string[] { })]
public class PKCDAAMBAME : ENEHADLKBBF, BEFNJLBOONF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private EntityManager GMDAKDJOHKE;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B6F0", Offset = "0x5E0A4F0", VA = "0x185E0B6F0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B690", Offset = "0x5E0A490", VA = "0x185E0B690", Slot = "5")]
	public void DDLFEEPINBM(EPCANLGBBON ALPEICGOMCK, bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x251AFF0", Offset = "0x2519DF0", VA = "0x18251AFF0")]
	private void MFACMGCFCOL<T>(EPCANLGBBON ALPEICGOMCK, bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public PKCDAAMBAME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[PMDCDBMECJP(typeof(KFONPPHLLPM), new string[] { })]
public class JGFFEKLGKBD : ENEHADLKBBF, KFONPPHLLPM
{
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private EntityManager GMDAKDJOHKE;

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEAB0", Offset = "0x5DFD8B0", VA = "0x185DFEAB0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEB30", Offset = "0x5DFD930", VA = "0x185DFEB30", Slot = "5")]
	public void KLOMHFEEJPK(EPCANLGBBON ALPEICGOMCK, bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE970", Offset = "0x5DFD770", VA = "0x185DFE970", Slot = "6")]
	public void ENIOKMDFANC(EPCANLGBBON ALPEICGOMCK, bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE9D0", Offset = "0x5DFD7D0", VA = "0x185DFE9D0", Slot = "7")]
	public void IKDILPJFIMI(EPCANLGBBON ALPEICGOMCK, int POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x2411510", Offset = "0x2410310", VA = "0x182411510")]
	private void MFACMGCFCOL<T>(EPCANLGBBON ALPEICGOMCK, bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x2411720", Offset = "0x2410520", VA = "0x182411720")]
	private void MFACMGCFCOL<T>(EPCANLGBBON ALPEICGOMCK, T LMCJHCIOIIP) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public JGFFEKLGKBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[PMDCDBMECJP(typeof(LDCMJDKHCPP), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.LoadInstance)]
public class LDCMJDKHCPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly Dictionary<JFBOGCJIFLL, string> NKHDLOFPMCD;

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E00560", Offset = "0x5DFF360", VA = "0x185E00560")]
	public GameObject GKBKDAJFCPD(JFBOGCJIFLL PDMBCHLIAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E00630", Offset = "0x5DFF430", VA = "0x185E00630")]
	public LDCMJDKHCPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[OCEGCBKNAGD(LJHGMNIEOPD.LoadInstance)]
[PMDCDBMECJP(typeof(IADHHMNCPEI), new string[] { })]
internal class IADHHMNCPEI : ENEHADLKBBF, GOMKIFEKCFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private CJJPMIMHLNN FGGAOAAIACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private KPOPJMLJIEE<Entity> LPDGANJNOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private OJJJKLOBGFC GGFBOHOPFHI;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD320", Offset = "0x5DFC120", VA = "0x185DFD320", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD0C0", Offset = "0x5DFBEC0", VA = "0x185DFD0C0", Slot = "5")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD020", Offset = "0x5DFBE20", VA = "0x185DFD020", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD1E0", Offset = "0x5DFBFE0", VA = "0x185DFD1E0")]
	private void GLHGBFMJFCE(Entity HHHGBIJCKBC, [In] EBLDEHNKIAL NKIGLDDAMAM, [In] EBLDEHNKIAL OEMJACOGEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public IADHHMNCPEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[DefaultMember("Item")]
public class OKLJDDIJFAK<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DefaultMember("Item")]
public class GJKMHGLFOAJ<From, To>
{
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[DefaultMember("Item")]
public class BOKDJPAGCGO<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly Func<From, To> DBKIMCIFFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly Func<To, From> PNDDJFHFIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public NativeArray<From> OBEMKDLNKLE;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public To CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x44A29B0", Offset = "0x44A17B0", VA = "0x1844A29B0", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x44A2A10", Offset = "0x44A1810", VA = "0x1844A2A10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x44A29A0", Offset = "0x44A17A0", VA = "0x1844A29A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool LOLLACKIPEN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x7604C0", Offset = "0x75F2C0", VA = "0x1807604C0")]
	public BOKDJPAGCGO(Func<From, To> DBKIMCIFFGB, Func<To, From> PNDDJFHFIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x44A2510", Offset = "0x44A1310", VA = "0x1844A2510", Slot = "11")]
	public void Add(To LCDPCJGMPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x44A2560", Offset = "0x44A1360", VA = "0x1844A2560", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x44A25B0", Offset = "0x44A13B0", VA = "0x1844A25B0", Slot = "13")]
	public bool Contains(To LCDPCJGMPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x44A2690", Offset = "0x44A1490", VA = "0x1844A2690", Slot = "14")]
	public void CopyTo(To[] OBEMKDLNKLE, int EMKJLDKBBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x44A2750", Offset = "0x44A1550", VA = "0x1844A2750", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x44A2810", Offset = "0x44A1610", VA = "0x1844A2810", Slot = "6")]
	public int IndexOf(To LCDPCJGMPFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x44A28B0", Offset = "0x44A16B0", VA = "0x1844A28B0", Slot = "7")]
	public void Insert(int OCMJNDDMDAL, To LCDPCJGMPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x44A2950", Offset = "0x44A1750", VA = "0x1844A2950", Slot = "15")]
	public bool Remove(To LCDPCJGMPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x44A2900", Offset = "0x44A1700", VA = "0x1844A2900", Slot = "8")]
	public void RemoveAt(int OCMJNDDMDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x3305290", Offset = "0x3304090", VA = "0x183305290", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct OHIEECIMGJB : IComparable<OHIEECIMGJB>, IEquatable<OHIEECIMGJB>
{
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public static readonly OHIEECIMGJB GNIJDJEELLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public GFPOPKJOMLL ALPEICGOMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public FGBENGKJFDK OGIJMJFMMHK;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool ELICBKNLKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E09A00", Offset = "0x5E08800", VA = "0x185E09A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x97A610", Offset = "0x979410", VA = "0x18097A610")]
	public OHIEECIMGJB(GFPOPKJOMLL ALPEICGOMCK, FGBENGKJFDK OGIJMJFMMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E09A10", Offset = "0x5E08810", VA = "0x185E09A10", Slot = "4")]
	public int CompareTo(OHIEECIMGJB LKMMHIOOCMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E09C20", Offset = "0x5E08A20", VA = "0x185E09C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E09B20", Offset = "0x5E08920", VA = "0x185E09B20", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E09A90", Offset = "0x5E08890", VA = "0x185E09A90", Slot = "5")]
	public bool Equals(OHIEECIMGJB LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5E09BB0", Offset = "0x5E089B0", VA = "0x185E09BB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct NLAOLBMEEMA : IEnumerable<OHIEECIMGJB>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public enum FALKOLFIDEO
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public struct KFDNGAFAPKM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private NativeList<byte> LMCJHCIOIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private NLAOLBMEEMA MJLHCFFNENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private readonly OHIEECIMGJB PGGBKFCMLMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private readonly int IHNKLCGMFDI;

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x5E001F0", Offset = "0x5DFEFF0", VA = "0x185E001F0")]
		internal KFDNGAFAPKM(NLAOLBMEEMA MJLHCFFNENL, OHIEECIMGJB PGGBKFCMLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x5DFFFC0", Offset = "0x5DFEDC0", VA = "0x185DFFFC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5E00050", Offset = "0x5DFEE50", VA = "0x185E00050")]
		public void ELCPLKFCIIP(ReadOnlySpan<byte> POACLGOFKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x5E00150", Offset = "0x5DFEF50", VA = "0x185E00150")]
		private void PAHJLAEOIEH(ReadOnlySpan<byte> POACLGOFKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5E000F0", Offset = "0x5DFEEF0", VA = "0x185E000F0")]
		private unsafe void PAHJLAEOIEH(void* AEJFLAGJCDH, int JGMNJBPPKGP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public struct GKKAODPABBM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private NLAOLBMEEMA MJLHCFFNENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private NativeArray<byte> LMCJHCIOIIP;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA340", Offset = "0x5DF9140", VA = "0x185DFA340")]
		internal GKKAODPABBM(NLAOLBMEEMA MJLHCFFNENL, NativeArray<byte> LMCJHCIOIIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA290", Offset = "0x5DF9090", VA = "0x185DFA290", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA1D0", Offset = "0x5DF8FD0", VA = "0x185DFA1D0")]
		public NativeArray<byte> DFAJAPPENGJ(int JGMNJBPPKGP)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA2A0", Offset = "0x5DF90A0", VA = "0x185DFA2A0")]
		public void FBAEIIIJDBC(Span<byte> POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public struct HNEJLANKKBA : IEnumerator<OHIEECIMGJB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly NativeList<OHIEECIMGJB> OBEMKDLNKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private int OCMJNDDMDAL;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public OHIEECIMGJB CPKIHOLEKMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x5DFB330", Offset = "0x5DFA130", VA = "0x185DFB330", Slot = "4")]
			get
			{
				return default(OHIEECIMGJB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x5DFB2E0", Offset = "0x5DFA0E0", VA = "0x185DFB2E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB190", Offset = "0x5DF9F90", VA = "0x185DFB190", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB290", Offset = "0x5DFA090", VA = "0x185DFB290", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private struct FDJOLFLNCMA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private NativeArray<int> LMCJHCIOIIP;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public bool NKLAIHGEKJM
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x5DF9660", Offset = "0x5DF8460", VA = "0x185DF9660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public int EMCMMGIGFMO
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x5DF9650", Offset = "0x5DF8450", VA = "0x185DF9650")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x5DF96A0", Offset = "0x5DF84A0", VA = "0x185DF96A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public FALKOLFIDEO FNPKEFMBFJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x5DF9520", Offset = "0x5DF8320", VA = "0x185DF9520")]
			get
			{
				return default(FALKOLFIDEO);
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x5DF9550", Offset = "0x5DF8350", VA = "0x185DF9550")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public bool NIJNIKNGAPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x5DF9530", Offset = "0x5DF8330", VA = "0x185DF9530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool DIMAAOBDONA
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x5DF95E0", Offset = "0x5DF83E0", VA = "0x185DF95E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x5DF96B0", Offset = "0x5DF84B0", VA = "0x185DF96B0")]
		public FDJOLFLNCMA(FALKOLFIDEO NLAJBMEAFLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x5DF95B0", Offset = "0x5DF83B0", VA = "0x185DF95B0")]
		private int HAMDPAFEPLN(int NNACFOFLCKF, int ICBIFIPOOGO = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9600", Offset = "0x5DF8400", VA = "0x185DF9600")]
		private void MFACMGCFCOL(int NNACFOFLCKF, int POACLGOFKAJ, int ICBIFIPOOGO = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9570", Offset = "0x5DF8370", VA = "0x185DF9570", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static readonly OHIEECIMGJB GLEJENOAHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private NativeParallelHashMap<OHIEECIMGJB, int> LMPMFCDDMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private NativeList<OHIEECIMGJB> IHKLGGEBFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private NativeList<int> FLBAPPEMKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private NativeList<byte> FOEHILCOFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private NativeList<byte> LMCJHCIOIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private FDJOLFLNCMA APKDPMMLKGB;

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x5E090F0", Offset = "0x5E07EF0", VA = "0x185E090F0")]
	public static NLAOLBMEEMA FLMMCOJOBIA(FALKOLFIDEO NLAJBMEAFLB = FALKOLFIDEO.Last, int IFFHAFBPODF = 16, int IDGHHEMGOOE = 256)
	{
		return default(NLAOLBMEEMA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5E097A0", Offset = "0x5E085A0", VA = "0x185E097A0")]
	private NLAOLBMEEMA(FALKOLFIDEO NLAJBMEAFLB, int IFFHAFBPODF, int IDGHHEMGOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5E08EF0", Offset = "0x5E07CF0", VA = "0x185E08EF0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5E09180", Offset = "0x5E07F80", VA = "0x185E09180")]
	public KFDNGAFAPKM KEFNIDJMPJP(OHIEECIMGJB PGGBKFCMLMO)
	{
		return default(KFDNGAFAPKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5E08C70", Offset = "0x5E07A70", VA = "0x185E08C70")]
	public bool ABBGOLONOOL(OHIEECIMGJB PGGBKFCMLMO, [Out] GKKAODPABBM CNJJEAPJAPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5E09130", Offset = "0x5E07F30", VA = "0x185E09130")]
	public bool JFJDLBGJIJC(OHIEECIMGJB PGGBKFCMLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5E08FF0", Offset = "0x5E07DF0", VA = "0x185E08FF0")]
	public bool EGJHCGBNMGO(OHIEECIMGJB PGGBKFCMLMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5E09350", Offset = "0x5E08150", VA = "0x185E09350")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5E09430", Offset = "0x5E08230", VA = "0x185E09430")]
	private void NELCNBCLOKB(OHIEECIMGJB PGGBKFCMLMO, int IHNKLCGMFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5E09270", Offset = "0x5E08070", VA = "0x185E09270")]
	private void KLGCFMOPDNF(int PPABMNCHLOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x5E08E10", Offset = "0x5E07C10", VA = "0x185E08E10")]
	private void APOBBGMNLHK(OHIEECIMGJB PGGBKFCMLMO, int IHNKLCGMFDI, int JGMNJBPPKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5E096F0", Offset = "0x5E084F0", VA = "0x185E096F0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5E096A0", Offset = "0x5E084A0", VA = "0x185E096A0", Slot = "4")]
	private IEnumerator<OHIEECIMGJB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[DefaultMember("Item")]
public class KPFOAJFHNHD<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class NBAFLGIBDEC
{
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class CFNOMAABJGM
{
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class MPGMJFHHGOF
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class HCAOMBLDABH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public NFHEEPPLDKB services;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public HCAOMBLDABH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAE60", Offset = "0x5DF9C60", VA = "0x185DFAE60")]
		internal void BPLMDACOLJF(ENEHADLKBBF svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x5DFAEC0", Offset = "0x5DF9CC0", VA = "0x185DFAEC0")]
		internal void MIGKLJBLODL(GOMKIFEKCFK svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x5E03A30", Offset = "0x5E02830", VA = "0x185E03A30")]
	public static void FLOEOCPOLEL(this World JDDIMGOGDBE, NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x224A0A0", Offset = "0x2248EA0", VA = "0x18224A0A0")]
	public static void JGLAGOOGBEJ<T>(this World JDDIMGOGDBE, Action<T> NABEMHHAOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x2486D00", Offset = "0x2485B00", VA = "0x182486D00")]
	public static void OFENOEFHPJJ<T>(this World JDDIMGOGDBE, Action<T> NABEMHHAOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x2486EE0", Offset = "0x2485CE0", VA = "0x182486EE0")]
	public static void OFENOEFHPJJ<T>(IEnumerable<ComponentSystemBase> LJGJEFKLGIF, Action<T> NABEMHHAOCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class GOLPMGFLKDP
{
	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA890", Offset = "0x5DF9690", VA = "0x185DFA890")]
	public static void PMKKJFLLEOI(ComponentSystemBase BBNGNPEAOHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class DBFPADFEGHD
{
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class DANPAPOKCKJ
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class EGHGPLLNODO
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		private sealed class <<CalculateTransformPath>g__getNames|0>d
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public EGHGPLLNODO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class MAGAPIPCBPG
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class GBELIFHNHBI
{
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class KDGJPLNKFKF
{
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class INIPDAADMLD
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
internal static class KCLMFHIALLK
{
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static readonly ProfilerMarker IJLMBJOOBJL;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly ProfilerMarker IAJDEACCLAH;

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF630", Offset = "0x5DFE430", VA = "0x185DFF630")]
	public static void DEIBGDDLADL(this GOKBGBKDEJH MBMNNOGNPON, LKLLDOONANH INEMIPHENMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFBD0", Offset = "0x5DFE9D0", VA = "0x185DFFBD0")]
	public static void MHCMLIFNLFO(this GOKBGBKDEJH MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFDB0", Offset = "0x5DFEBB0", VA = "0x185DFFDB0")]
	private static string[] OLBKHMPGGEE(LKLLDOONANH INEMIPHENMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFA70", Offset = "0x5DFE870", VA = "0x185DFFA70")]
	private static bool JEJNBMDBMDA(LKLLDOONANH INEMIPHENMH, [Out] string[] NIOAMDGAFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300")]
	private static bool GGHEFBHOJFC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public abstract class LJJPPNBGDOI : KCDJHADIKPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly MethodInfo MOEMDJENCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly Type[] MEALCFKPKME;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5E01660", Offset = "0x5E00460", VA = "0x185E01660")]
	public LJJPPNBGDOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action LHMPADMFONP();

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5E01490", Offset = "0x5E00290", VA = "0x185E01490")]
	public MethodInfo GPJMGEPHPNF(Action IPGJPNDBCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5E014D0", Offset = "0x5E002D0", VA = "0x185E014D0", Slot = "4")]
	public void LAPCBGMBHPD(Type FLHOFPAHPKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public abstract class IMDMMKACNEH : LJJPPNBGDOI
{
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	private enum BEFNIEOAODN
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE5F0", Offset = "0x5DFD3F0", VA = "0x185DFE5F0", Slot = "5")]
	public override Action LHMPADMFONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void EGBNHNMONMO<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE560", Offset = "0x5DFD360", VA = "0x185DFE560")]
	[UnityEngine.Scripting.Preserve]
	public void LEJLGDPPHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB050", Offset = "0x5DF9E50", VA = "0x185DFB050")]
	protected IMDMMKACNEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public abstract class HFHKJJADEEA : LJJPPNBGDOI
{
	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB0F0", Offset = "0x5DF9EF0", VA = "0x185DFB0F0", Slot = "5")]
	public override Action LHMPADMFONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void IHMCNHPHEMK<T>() where T : EGKFDGGDBHJ;

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB060", Offset = "0x5DF9E60", VA = "0x185DFB060")]
	[UnityEngine.Scripting.Preserve]
	public void LEJLGDPPHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB050", Offset = "0x5DF9E50", VA = "0x185DFB050")]
	protected HFHKJJADEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public abstract class HCNOBJAIMIP : LJJPPNBGDOI
{
	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAFB0", Offset = "0x5DF9DB0", VA = "0x185DFAFB0", Slot = "5")]
	public override Action LHMPADMFONP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void AOCDEJJMCAA<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5DFAF20", Offset = "0x5DF9D20", VA = "0x185DFAF20")]
	[UnityEngine.Scripting.Preserve]
	public void LEJLGDPPHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB050", Offset = "0x5DF9E50", VA = "0x185DFB050")]
	protected HCNOBJAIMIP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct ANJJDMOENMN : ISystem
{
	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "4")]
	public void OnCreate(SystemState KIGOLAOAAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
	public void OnDestroy(SystemState KIGOLAOAAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE360", Offset = "0x5DED160", VA = "0x185DEE360", Slot = "6")]
	public void OnUpdate(SystemState KIGOLAOAAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void NJGLPPKFPMO(IntPtr PECKHAMCEFO, IntPtr KIGOLAOAAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE360", Offset = "0x5DED160", VA = "0x185DEE360")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void NOGALPOFKLG(IntPtr PECKHAMCEFO, IntPtr KIGOLAOAAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void ENHCJHODPAH(IntPtr PECKHAMCEFO, IntPtr KIGOLAOAAMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class EFIBPKOADPC
{
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public static readonly ComponentType[] OEACJMCELKO;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8250", Offset = "0x5DF7050", VA = "0x185DF8250")]
	public static Entity NJEDFFEEPMF(this EntityManager GMDAKDJOHKE)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class NDINLBFJDOF
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class AFKHPKDHCHA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class KGNNCOAEIGF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class GHIIKKMBMKN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5E08500", Offset = "0x5E07300", VA = "0x185E08500")]
	public static Entity KDJJJOCLJJL(this EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x5E087D0", Offset = "0x5E075D0", VA = "0x185E087D0")]
	public static DynamicBuffer<ChildrenData> MHAPCIOLKLM(this EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(DynamicBuffer<ChildrenData>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5E07CB0", Offset = "0x5E06AB0", VA = "0x185E07CB0")]
	public static bool CLOINBBPMCK(this EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, Allocator MBGJLDPPIJN, [Out] NativeArray<Entity> EBFLJCNJFBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x5E08860", Offset = "0x5E07660", VA = "0x185E08860")]
	public static NativeArray<Entity> PDFHNJGJBJP(this EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5E086A0", Offset = "0x5E074A0", VA = "0x185E086A0")]
	public static int LBPEHGFNEKK(this EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x5E078F0", Offset = "0x5E066F0", VA = "0x185E078F0")]
	public static void AOFIIGFNLBF(NativeArray<Entity> LJACAIFCOEH, NativeArray<Entity> JNHIBBPLDLG, EntityManager GMDAKDJOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5E08210", Offset = "0x5E07010", VA = "0x185E08210")]
	public static bool HLEKOIFPNCB(this EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, Entity PJMEKLHJGLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5E089E0", Offset = "0x5E077E0", VA = "0x185E089E0")]
	public static bool PKJACENFGMC(this EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, Entity NINKJFKPIPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5E08050", Offset = "0x5E06E50", VA = "0x185E08050")]
	public static NativeList<Entity> GLDPBHKPFJK(this EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, bool MHBIDLJLLHK = false, Allocator MBGJLDPPIJN = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x5E07B80", Offset = "0x5E06980", VA = "0x185E07B80")]
	public static Entity BGLIKGBFACL(this EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5E07D80", Offset = "0x5E06B80", VA = "0x185E07D80")]
	public static bool ECOIFBFLNNA(this EntityManager GMDAKDJOHKE, Entity PABBJIBBIGE, Entity GICCMHHJDGA, [Out] Entity FHIDPNHFCCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5E083E0", Offset = "0x5E071E0", VA = "0x185E083E0")]
	internal static void IIDLPJHMBGI(EntityManager GMDAKDJOHKE, Entity LPDGANJNOMK, Entity KGAHDFAFPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5E08570", Offset = "0x5E07370", VA = "0x185E08570")]
	private static bool KDKMNPICPJL(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, Entity PJMEKLHJGLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[PMDCDBMECJP(typeof(DDOCENCJLOC), new string[] { })]
internal sealed class JBFLPCBKGBD : DDOCENCJLOC, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	[PDOCKCLGMBB]
	private KDAEPEHHCFM HJNANGFHPJB;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public EPFMFKDKPFM.AKJCMIACBJM.AFJAAMFAFLL MNLFLPACJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x5DFE690", Offset = "0x5DFD490", VA = "0x185DFE690", Slot = "4")]
		get
		{
			return default(EPFMFKDKPFM.AKJCMIACBJM.AFJAAMFAFLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE700", Offset = "0x5DFD500", VA = "0x185DFE700", Slot = "5")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public JBFLPCBKGBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
internal class DLBLCFKDLOI
{
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private static readonly HICMFDICNOL FACCALAHMDM;

	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private static readonly HICMFDICNOL NDJFCNPIEJD;

	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private static readonly ProfilerMarker KGNJNINJCKM;

	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private static readonly ProfilerMarker HBHDAJBBNDG;

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private static readonly ProfilerMarker GFJOJGAAJKF;

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly ProfilerMarker IAMKMLJDFCE;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly ProfilerMarker DPPAPAEDIKG;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly ProfilerMarker CEKHBABOCCE;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly ProfilerMarker IEAGECIOICA;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static readonly ProfilerMarker JFDBLBCKFJP;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly ProfilerMarker HGBDIGDCDKM;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly ProfilerMarker AOBILPMPCEO;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static readonly ProfilerMarker NOBGAPIFINI;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static readonly ProfilerMarker NPLCIHEHHFC;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static readonly ProfilerMarker LKKHMHMMOMP;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static readonly ProfilerMarker EFFCAEEBGFA;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly ProfilerMarker DLOJKHLDBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly JKKBODKFGDI NPDKHHCMJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly ByteString HGPPIPGOKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly GOKBGBKDEJH MBMNNOGNPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly HFEJGOMANPJ IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly OFGBGGBNNCN CNLPAHFIJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly NPAOJNBHCEC IHKLGGEBFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly KBJJJNBBBFB HHIDGCGBBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private readonly TaskCompletionSource<bool> AIJCFMOLNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private readonly GIBBCIJFCEO APKDPMMLKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private readonly FDHLEAEGGND.GBLNPIJFIPA EJENGHIFHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private KOHKCDKIBEL BJFLEGOEFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private PJCKAEPBFOA ADOHNLJAIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private EPFMFKDKPFM CHECAAIJBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NPCLNJINPCG OJEIFPMLHED;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Action NJNJDFEADPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8111D0", Offset = "0x80FFD0", VA = "0x1808111D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x8B9330", Offset = "0x8B8130", VA = "0x1808B9330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public Action NGLIPGBBALE
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x8B90F0", Offset = "0x8B7EF0", VA = "0x1808B90F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x8B93B0", Offset = "0x8B81B0", VA = "0x1808B93B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public Action NLLKKMGCKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x762AC0", Offset = "0x7618C0", VA = "0x180762AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x762AF0", Offset = "0x7618F0", VA = "0x180762AF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public IEnumerable<KOGCMBOFOEG> KPMCFKEIHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x7DA850", Offset = "0x7D9650", VA = "0x1807DA850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7DA860", Offset = "0x7D9660", VA = "0x1807DA860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public GPDAEJBFDHN PLLNLAFJGLO
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x5DF34D0", Offset = "0x5DF22D0", VA = "0x185DF34D0")]
		[CompilerGenerated]
		get
		{
			return default(GPDAEJBFDHN);
		}
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x5DF4D30", Offset = "0x5DF3B30", VA = "0x185DF4D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public NPCLNJINPCG FDODLKENGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x8B90E0", Offset = "0x8B7EE0", VA = "0x1808B90E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public PPHNPGCGGHL FEFPLCMPEEN
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x1A31A50", Offset = "0x1A30850", VA = "0x181A31A50")]
		get
		{
			return default(PPHNPGCGGHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public LocalId KFKCBBALAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x5DF3A90", Offset = "0x5DF2890", VA = "0x185DF3A90")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public Task BALJENJCDOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x5DF31C0", Offset = "0x5DF1FC0", VA = "0x185DF31C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5C30", Offset = "0x5DF4A30", VA = "0x185DF5C30")]
	public DLBLCFKDLOI(ByteString HGPPIPGOKCB, PPHNPGCGGHL CBCNKDEMEOC, [In] GIBBCIJFCEO APKDPMMLKGB, GOKBGBKDEJH MBMNNOGNPON, AHOAFPGEKED ADEEDBOHLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x5DF54D0", Offset = "0x5DF42D0", VA = "0x185DF54D0")]
	public void OGJJNAJKDPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x5DF57D0", Offset = "0x5DF45D0", VA = "0x185DF57D0")]
	public bool PKCLAOPMEIK(PPHNPGCGGHL PABBJIBBIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3C00", Offset = "0x5DF2A00", VA = "0x185DF3C00")]
	private bool EECDBAPLMKJ(PPHNPGCGGHL HMFMKKPCCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x5DF51E0", Offset = "0x5DF3FE0", VA = "0x185DF51E0")]
	private void LMGNJIBJEJJ(PPHNPGCGGHL HNFFLMOMEGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5DF55B0", Offset = "0x5DF43B0", VA = "0x185DF55B0")]
	private bool PHGLAMLIPCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5DF45B0", Offset = "0x5DF33B0", VA = "0x185DF45B0")]
	public bool INJKFCFHBGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4D60", Offset = "0x5DF3B60", VA = "0x185DF4D60")]
	private bool LFKEMMEJNDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3200", Offset = "0x5DF2000", VA = "0x185DF3200")]
	private bool BOJOCCDKAOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3980", Offset = "0x5DF2780", VA = "0x185DF3980")]
	private bool CNOCCKOKFLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3950", Offset = "0x5DF2750", VA = "0x185DF3950")]
	private bool CIJINMNODAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3AA0", Offset = "0x5DF28A0", VA = "0x185DF3AA0")]
	private bool DFCOEMAEMPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3500", Offset = "0x5DF2300", VA = "0x185DF3500")]
	public void CCHCNNABNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3ED0", Offset = "0x5DF2CD0", VA = "0x185DF3ED0")]
	[CompilerGenerated]
	private void EMABMGKHJJL(PPHNPGCGGHL HMFMKKPCCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4780", Offset = "0x5DF3580", VA = "0x185DF4780")]
	[CompilerGenerated]
	private bool JEGAOPPGFKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5DF48D0", Offset = "0x5DF36D0", VA = "0x185DF48D0")]
	[CompilerGenerated]
	private void JMLGJAOFCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5290", Offset = "0x5DF4090", VA = "0x185DF5290")]
	[CompilerGenerated]
	private World MKBDNHDEDNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x5DF50B0", Offset = "0x5DF3EB0", VA = "0x185DF50B0")]
	[CompilerGenerated]
	private void LKLPIIPOBEO(World GPMCHGLMEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4450", Offset = "0x5DF3250", VA = "0x185DF4450")]
	[CompilerGenerated]
	private int HPOEBMCKBLP(World GPMCHGLMEKK, ByteString HGPPIPGOKCB, EPFMFKDKPFM.AKJCMIACBJM.AFJAAMFAFLL FBJEHMGCPKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4270", Offset = "0x5DF3070", VA = "0x185DF4270")]
	[CompilerGenerated]
	private void HBOLCHAAPOK(World JDDIMGOGDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3F00", Offset = "0x5DF2D00", VA = "0x185DF3F00")]
	[CompilerGenerated]
	internal static CNCGBAPIBAA FGNBIONNKIP(EntityManager HHNAIKLIKFH, EntityManager NHAIEICJIDO, int NGLEGICFLAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5DF53C0", Offset = "0x5DF41C0", VA = "0x185DF53C0")]
	[CompilerGenerated]
	private void NMPNJMECJAA(NPCLNJINPCG OJEIFPMLHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5DF40B0", Offset = "0x5DF2EB0", VA = "0x185DF40B0")]
	[CompilerGenerated]
	private void GPEFEPPGOIA(EntityManager GMDAKDJOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5DF30C0", Offset = "0x5DF1EC0", VA = "0x185DF30C0")]
	[CompilerGenerated]
	private void AALCAGNMCGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3BE0", Offset = "0x5DF29E0", VA = "0x185DF3BE0")]
	[CompilerGenerated]
	private void EAAPEBOKIHG(string MEBBBIMBIJO, EntityManager GMDAKDJOHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF4710", Offset = "0x5DF3510", VA = "0x185DF4710")]
	[CompilerGenerated]
	private KEFPGANLAHK<GIBBCIJFCEO> JDPHBCKGGHE(EntityManager GMDAKDJOHKE)
	{
		return default(KEFPGANLAHK<GIBBCIJFCEO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
internal class JKKBODKFGDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private enum KFMKAGNNNGL
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
	private sealed class MABIIOOALMN : IEnumerable<PPHNPGCGGHL>, IEnumerable, IEnumerator<PPHNPGCGGHL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private PPHNPGCGGHL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public JKKBODKFGDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private PPHNPGCGGHL target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public PPHNPGCGGHL <>3__target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private int <allowedTarget>5__2;

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		private PPHNPGCGGHL System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Serialization.DeserializePhases>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x8C0580", Offset = "0x8BF380", VA = "0x1808C0580", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(PPHNPGCGGHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x5E01D10", Offset = "0x5E00B10", VA = "0x185E01D10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xCC43B0", Offset = "0xCC31B0", VA = "0x180CC43B0")]
		[DebuggerHidden]
		public MABIIOOALMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x5E01B90", Offset = "0x5E00990", VA = "0x185E01B90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5E01CC0", Offset = "0x5E00AC0", VA = "0x185E01CC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5E01C10", Offset = "0x5E00A10", VA = "0x185E01C10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<PPHNPGCGGHL> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Serialization.DeserializePhases>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x5E01C10", Offset = "0x5E00A10", VA = "0x185E01C10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class LDIHAPAIGCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public PPHNPGCGGHL phase;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LDIHAPAIGCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E00C60", Offset = "0x5DFFA60", VA = "0x185E00C60")]
		internal object HKBBLOGOLDP(PPHNPGCGGHL a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private static readonly HICMFDICNOL NDJFCNPIEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private readonly PPHNPGCGGHL CBCNKDEMEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly Func<PPHNPGCGGHL, bool> BDHHIOEIJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly Action<PPHNPGCGGHL> OJBIMDDBKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private int OGECBPAEFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private KFMKAGNNNGL KIGOLAOAAMI;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public PPHNPGCGGHL FEFPLCMPEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x75D180", Offset = "0x75BF80", VA = "0x18075D180")]
		get
		{
			return default(PPHNPGCGGHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool LIODFMEFOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x5DFF090", Offset = "0x5DFDE90", VA = "0x185DFF090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF5C0", Offset = "0x5DFE3C0", VA = "0x185DFF5C0")]
	public JKKBODKFGDI(PPHNPGCGGHL CBCNKDEMEOC, Func<PPHNPGCGGHL, bool> BDHHIOEIJJD, Action<PPHNPGCGGHL> OJBIMDDBKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF0A0", Offset = "0x5DFDEA0", VA = "0x185DFF0A0")]
	[IteratorStateMachine(typeof(MABIIOOALMN))]
	private IEnumerable<PPHNPGCGGHL> LJLLILAAEKK(PPHNPGCGGHL PABBJIBBIGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF170", Offset = "0x5DFDF70", VA = "0x185DFF170")]
	public bool PKCLAOPMEIK(PPHNPGCGGHL PABBJIBBIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF130", Offset = "0x5DFDF30", VA = "0x185DFF130")]
	private void NFNENOCCILA(PPHNPGCGGHL HMFMKKPCCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7810", Offset = "0x5DD6610", VA = "0x185DD7810", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal class AGDLGIEJDDO : IMNONFIMKCE, AHOAFPGEKED, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly DLBLCFKDLOI BJKAIBLEACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly GCIHPKBFCDJ NBCMBPJPEOA;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public LGELJLLCKKD ILJPKGGOMAN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public LocalId OGKLBLDJAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x5DED340", Offset = "0x5DEC140", VA = "0x185DED340", Slot = "9")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public Task BALJENJCDOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x5DED290", Offset = "0x5DEC090", VA = "0x185DED290", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IEnumerable<KOGCMBOFOEG> KPMCFKEIHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5DED390", Offset = "0x5DEC190", VA = "0x185DED390", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public GPDAEJBFDHN PLLNLAFJGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5DED2E0", Offset = "0x5DEC0E0", VA = "0x185DED2E0", Slot = "8")]
		get
		{
			return default(GPDAEJBFDHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public NPCLNJINPCG JCNKALEPJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5DED3F0", Offset = "0x5DEC1F0", VA = "0x185DED3F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DED440", Offset = "0x5DEC240", VA = "0x185DED440")]
	public AGDLGIEJDDO(ByteString HGPPIPGOKCB, LGELJLLCKKD FOKHMLJOJGD, [In] GIBBCIJFCEO APKDPMMLKGB, GOKBGBKDEJH MBMNNOGNPON, Action ICPHJFMOKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x5DED3C0", Offset = "0x5DEC1C0", VA = "0x185DED3C0", Slot = "5")]
	public void INEHGKEHGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x5DED410", Offset = "0x5DEC210", VA = "0x185DED410", Slot = "12")]
	public bool PKCLAOPMEIK(PPHNPGCGGHL HMFMKKPCCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DED320", Offset = "0x5DEC120", VA = "0x185DED320", Slot = "6")]
	public void CCHCNNABNBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5DED370", Offset = "0x5DEC170", VA = "0x185DED370", Slot = "13")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class PIOKBABMMFK : JEJAAOHAHBL, AHOAFPGEKED, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly DLBLCFKDLOI BJKAIBLEACD;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public LocalId OGKLBLDJAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E0B4E0", Offset = "0x5E0A2E0", VA = "0x185E0B4E0", Slot = "6")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public IEnumerable<KOGCMBOFOEG> KPMCFKEIHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5DED390", Offset = "0x5DEC190", VA = "0x185DED390", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public GPDAEJBFDHN PLLNLAFJGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DED2E0", Offset = "0x5DEC0E0", VA = "0x185DED2E0", Slot = "5")]
		get
		{
			return default(GPDAEJBFDHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public Task BALJENJCDOH
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DED290", Offset = "0x5DEC090", VA = "0x185DED290", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public NPCLNJINPCG JCNKALEPJEK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x5DED3F0", Offset = "0x5DEC1F0", VA = "0x185DED3F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B4F0", Offset = "0x5E0A2F0", VA = "0x185E0B4F0")]
	public PIOKBABMMFK(ByteString HGPPIPGOKCB, GOKBGBKDEJH MBMNNOGNPON, Action GNJBJLBMMKH, Action HHOCAHIMLHH, Action ICPHJFMOKBC, bool MHBNOKKPOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5DED410", Offset = "0x5DEC210", VA = "0x185DED410", Slot = "9")]
	public bool PKCLAOPMEIK(PPHNPGCGGHL HMFMKKPCCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x5DED370", Offset = "0x5DEC170", VA = "0x185DED370", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal struct GIBBCIJFCEO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public AGHGNCPPGHC OJCGNPHJCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public Entity LPDGANJNOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public FOOPDCAEKLE AEGJDAAKNIJ;

	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public static readonly EHINJJAKHPP<GIBBCIJFCEO> IKMLLOOIGKE;
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
internal class DBMPJALHPDL : AGOGLMPMEDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public NPCLNJINPCG FDODLKENGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF2FE0", Offset = "0x5DF1DE0", VA = "0x185DF2FE0", Slot = "5")]
	public ByteString JCPPJPIDNDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF3040", Offset = "0x5DF1E40", VA = "0x185DF3040")]
	public DBMPJALHPDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[OCEGCBKNAGD(LJHGMNIEOPD.Application)]
public interface DDOCENCJLOC
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	EPFMFKDKPFM.AKJCMIACBJM.AFJAAMFAFLL MNLFLPACJMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal abstract class FDGBIHFFBNB : AGOGLMPMEDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private static readonly ProfilerMarker GFJOJGAAJKF;

	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private static readonly ProfilerMarker AOEKDBAADAI;

	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private static readonly ProfilerMarker IAMKMLJDFCE;

	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private static readonly ProfilerMarker JAPDFKAINNA;

	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private static readonly ProfilerMarker CEKHBABOCCE;

	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private static readonly ProfilerMarker KGOENIAHAMA;

	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private static readonly ProfilerMarker DJIEAEFNPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly GOKBGBKDEJH MBMNNOGNPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly KOHKCDKIBEL BJFLEGOEFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly KBJJJNBBBFB HHIDGCGBBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly NPAOJNBHCEC IHKLGGEBFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private readonly HICMFDICNOL NDJFCNPIEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private readonly FDHLEAEGGND.GBLNPIJFIPA EJENGHIFHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private World LMILLDFIFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private NPCLNJINPCG OJEIFPMLHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private IDisposable LLBNALIOJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private ByteString HCNMGLNGMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private EPFMFKDKPFM.AKJCMIACBJM.AFJAAMFAFLL CPEALNHMONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private bool EFJHGOGEGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private CFKGEIBPPPD NCJBOOFHFPH;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	protected World EPECCMHNPPN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x760F60", Offset = "0x75FD60", VA = "0x180760F60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	protected World IKHONICOMFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x5DF9170", Offset = "0x5DF7F70", VA = "0x185DF9170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public NPCLNJINPCG FDODLKENGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x760F30", Offset = "0x75FD30", VA = "0x180760F30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9380", Offset = "0x5DF8180", VA = "0x185DF9380")]
	public FDGBIHFFBNB(GOKBGBKDEJH MBMNNOGNPON, HICMFDICNOL DFCBIKLJFPD, HICMFDICNOL NDJFCNPIEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DF90F0", Offset = "0x5DF7EF0", VA = "0x185DF90F0", Slot = "5")]
	public ByteString JCPPJPIDNDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8600", Offset = "0x5DF7400", VA = "0x185DF8600", Slot = "7")]
	public void INEHGKEHGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DF85A0", Offset = "0x5DF73A0", VA = "0x185DF85A0", Slot = "8")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF84E0", Offset = "0x5DF72E0", VA = "0x185DF84E0", Slot = "9")]
	protected virtual KGHDIJIHGJH CJFLOPDCIDH()
	{
		return default(KGHDIJIHGJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void ACBBOIFFEAN();

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract NativeArray<EntityRemapUtility.EntityRemapInfo> EMKKMCKLFJO(NativeArray<EntityRemapUtility.EntityRemapInfo> LGMMPKHGJDF);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[MGADLGKGNOP]
internal struct KGHDIJIHGJH : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public AGHGNCPPGHC AFLBLHPNDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public CFJDFJJKCEM AEGJDAAKNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public EPFMFKDKPFM.AKJCMIACBJM.AFJAAMFAFLL FBJEHMGCPKI;

	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public static readonly EHINJJAKHPP<KGHDIJIHGJH> IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E003D0", Offset = "0x5DFF1D0", VA = "0x185E003D0")]
	public static KGHDIJIHGJH LOLKICPECIJ([In] AGHGNCPPGHC AFLBLHPNDKH)
	{
		return default(KGHDIJIHGJH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
internal class AIKKPJPFMCM : FDGBIHFFBNB
{
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private static readonly HICMFDICNOL NDJFCNPIEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private readonly KGHDIJIHGJH APKDPMMLKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private NativeList<Entity> MBNJKMIAAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private NativeArray<Entity> LFMPDIIHBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> OGLGDHKIBBC;

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDA80", Offset = "0x5DEC880", VA = "0x185DEDA80")]
	public AIKKPJPFMCM(IEnumerable<EPCANLGBBON> GBNDDJIHFHG, [In] KGHDIJIHGJH APKDPMMLKGB, GOKBGBKDEJH MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DED790", Offset = "0x5DEC590", VA = "0x185DED790", Slot = "9")]
	protected override KGHDIJIHGJH CJFLOPDCIDH()
	{
		return default(KGHDIJIHGJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DED600", Offset = "0x5DEC400", VA = "0x185DED600", Slot = "10")]
	protected override void ACBBOIFFEAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DED870", Offset = "0x5DEC670", VA = "0x185DED870", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> EMKKMCKLFJO(NativeArray<EntityRemapUtility.EntityRemapInfo> LGMMPKHGJDF)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DED7C0", Offset = "0x5DEC5C0", VA = "0x185DED7C0", Slot = "8")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
internal class ALMEFECEGAE : FDGBIHFFBNB
{
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private static readonly HICMFDICNOL NDJFCNPIEJD;

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE2A0", Offset = "0x5DED0A0", VA = "0x185DEE2A0")]
	public ALMEFECEGAE(GOKBGBKDEJH MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE130", Offset = "0x5DECF30", VA = "0x185DEE130", Slot = "10")]
	protected override void ACBBOIFFEAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0xD830E0", Offset = "0xD81EE0", VA = "0x180D830E0", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> EMKKMCKLFJO(NativeArray<EntityRemapUtility.EntityRemapInfo> LGMMPKHGJDF)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
internal static class JKDLMNIEBEN
{
	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEFD0", Offset = "0x5DFDDD0", VA = "0x185DFEFD0")]
	public static FDHLEAEGGND.GBLNPIJFIPA EOOLMAKNLOJ(GOKBGBKDEJH MBMNNOGNPON)
	{
		return default(FDHLEAEGGND.GBLNPIJFIPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEC20", Offset = "0x5DFDA20", VA = "0x185DFEC20")]
	public static NativeList<Entity> DFLGEHAKHKB(EntityManager GMDAKDJOHKE, IEnumerable<EPCANLGBBON> GBNDDJIHFHG)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEF20", Offset = "0x5DFDD20", VA = "0x185DFEF20")]
	public static void EMKKMCKLFJO(NativeArray<Entity> LFMPDIIHBCB, NativeList<Entity> MBNJKMIAAGD, NativeArray<EntityRemapUtility.EntityRemapInfo> LGMMPKHGJDF, NativeArray<EntityRemapUtility.EntityRemapInfo> OGLGDHKIBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2412B10", Offset = "0x2411910", VA = "0x182412B10")]
	public static Entity NEPPJNDFACE<T>(EntityManager GMDAKDJOHKE, [In] T POACLGOFKAJ) where T : struct, IComponentData
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class AIAINLNCNKC
{
	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DED550", Offset = "0x5DEC350", VA = "0x185DED550")]
	public static AGHGNCPPGHC ANECJKGPAPC(ELJLMFEGKCH LPDGANJNOMK)
	{
		return default(AGHGNCPPGHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public struct KEFPGANLAHK<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private EntityManager GMDAKDJOHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private readonly Entity FOPNCBMDNOC;

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x389A770", Offset = "0x3899570", VA = "0x18389A770")]
	public KEFPGANLAHK(EntityManager GMDAKDJOHKE, [In] T APKDPMMLKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x389A6B0", Offset = "0x38994B0", VA = "0x18389A6B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[PMDCDBMECJP(typeof(GDDGINCANAF), new string[] { })]
public class FHLCJODAOCN : GDDGINCANAF, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public GNDBCEIPANN OOHGAMJDNEN
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x7619C0", Offset = "0x7607C0", VA = "0x1807619C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private IAOACMBPLEE JFADBIDJKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x760C60", Offset = "0x75FA60", VA = "0x180760C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private JIPIIDIJFIE OLLLHNMKAOM
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private LKGAMLNINAJ BAOMIAGIGLL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x766E40", Offset = "0x765C40", VA = "0x180766E40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public ABOCLKIIMFN CLEBMHLDNKH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public EJCGJPICKJD JGPGKIAMDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x765480", Offset = "0x764280", VA = "0x180765480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public FHPHFJJONKB DHBHLCPPEEH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x769880", Offset = "0x768680", VA = "0x180769880", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x765490", Offset = "0x764290", VA = "0x180765490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public LEBCBKOCPJG JONGPILBHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x7656B0", Offset = "0x7644B0", VA = "0x1807656B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x765450", Offset = "0x764250", VA = "0x180765450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	private HFEJGOMANPJ OBPMOAKPPIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x760F50", Offset = "0x75FD50", VA = "0x180760F50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public GCMLJOOJHLC DPKKGPAPKCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x760EF0", Offset = "0x75FCF0", VA = "0x180760EF0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x760F00", Offset = "0x75FD00", VA = "0x180760F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public GADEOHPHKDA MMDHFFPGOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x760F60", Offset = "0x75FD60", VA = "0x180760F60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x760F20", Offset = "0x75FD20", VA = "0x180760F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private OGEDEIHKMDO HFDMDOJFNDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x760F40", Offset = "0x75FD40", VA = "0x180760F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public IFOCAIFGDLD MNBONIGNALK
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x768A70", Offset = "0x767870", VA = "0x180768A70", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x768A80", Offset = "0x767880", VA = "0x180768A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private HOEKJKFPHNL BGGHAGKBMDH
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x767910", Offset = "0x766710", VA = "0x180767910")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private JNDGIDLEBEK OBOMDHCOFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x7678D0", Offset = "0x7666D0", VA = "0x1807678D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9DB0", Offset = "0x5DF8BB0", VA = "0x185DF9DB0", Slot = "13")]
	public virtual void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FHLCJODAOCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[PMDCDBMECJP(typeof(JKLFCEOIENH), new string[] { })]
public class MEMCGLIKIBA : JKLFCEOIENH, OFAFBMCCKFB, GNDDGAACBGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private NFHEEPPLDKB MBMNNOGNPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private GDDGINCANAF IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private PJCKAEPBFOA ADOHNLJAIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private FOANHFHLHAH EDBIBDGOGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private LEALPNGCHEO MPANOGNBHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private CJJPMIMHLNN FGGAOAAIACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private OLMMANKNKNE AENJCIFEOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private KABMHKLOPCI NAFNNIMKNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private AOCFLNALOKJ MAAOCGPPNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private EOJHDACEBHO MJJCNMCHEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private ODAIDNHAJCE HKJFMKPBAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private BHGAALGADLM CNJJEAPJAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private HHMMFDFOECD BOPFCMBAHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private BEFNJLBOONF GCPBHOAHJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private KFONPPHLLPM LADFFCDMEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private MMKPBHDHKLP HHMONIPLLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private GFJMBCLPNDO OFEDPPHMPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private HCCIMPJEHHN EBCLIMEMCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private KDAEPEHHCFM PPDBKHFGBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private NKBJOPBBMIN MFNODIMGLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public NFHEEPPLDKB MJEEFGLGOAA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public GDDGINCANAF JHALPIJCAEL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public BPHHNANPLNM GECDCLMMDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public FOANHFHLHAH GGJEBBNJCFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public CCAABBKKMFL OJLCFMEIOFB
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public LEALPNGCHEO FNJKBCLLLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x769880", Offset = "0x768680", VA = "0x180769880", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public CJJPMIMHLNN ELOGKPPDLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7656B0", Offset = "0x7644B0", VA = "0x1807656B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public OLMMANKNKNE DBAGPNKGNLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x760F10", Offset = "0x75FD10", VA = "0x180760F10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public AOCFLNALOKJ DNEFBKKNHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x760F60", Offset = "0x75FD60", VA = "0x180760F60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public EOJHDACEBHO PHHNJEMMLHC
	{
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x760F30", Offset = "0x75FD30", VA = "0x180760F30", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public ODAIDNHAJCE GFGGJHKBBOD
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x768A70", Offset = "0x767870", VA = "0x180768A70", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public BHGAALGADLM BGGHAGKBMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x767970", Offset = "0x766770", VA = "0x180767970", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public HHMMFDFOECD OIIGFBDMJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x7678E0", Offset = "0x7666E0", VA = "0x1807678E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public BEFNJLBOONF OHHKPIENCIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x7679F0", Offset = "0x7667F0", VA = "0x1807679F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public KFONPPHLLPM PAPNFFCBGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x827700", Offset = "0x826500", VA = "0x180827700", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public MMKPBHDHKLP LBBDMPGAIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x767990", Offset = "0x766790", VA = "0x180767990", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public GFJMBCLPNDO BLNFBIIFAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x89EB10", Offset = "0x89D910", VA = "0x18089EB10", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public HCCIMPJEHHN PEPKGNMFINC
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x762AB0", Offset = "0x7618B0", VA = "0x180762AB0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public KDAEPEHHCFM AIFMONOEKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B7ED0", VA = "0x1808B90D0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public NKBJOPBBMIN IFCFDIGDGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x83B840", Offset = "0x83A640", VA = "0x18083B840", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public KDMEBEDNNJH FGBLHLKNCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x7DD200", Offset = "0x7DC000", VA = "0x1807DD200", Slot = "24")]
		get
		{
			return default(KDMEBEDNNJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x5E01F70", Offset = "0x5E00D70", VA = "0x185E01F70", Slot = "25")]
	public void DOBAGIMKMLE(NFHEEPPLDKB IANOLOKAJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x5E02270", Offset = "0x5E01070", VA = "0x185E02270", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x5E02280", Offset = "0x5E01080", VA = "0x185E02280", Slot = "26")]
	public void LOPEMMLICGF(NFHEEPPLDKB IANOLOKAJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MEMCGLIKIBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[DefaultMember("Item")]
public class FBFFGJDPBFF : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class MCDNPIFJOGP : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public FBFFGJDPBFF <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8C0580", Offset = "0x8BF380", VA = "0x1808C0580", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E01F20", Offset = "0x5E00D20", VA = "0x185E01F20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
		[DebuggerHidden]
		public MCDNPIFJOGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x5E01D60", Offset = "0x5E00B60", VA = "0x185E01D60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x5E01ED0", Offset = "0x5E00CD0", VA = "0x185E01ED0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private readonly List<ulong> HEBBDLMGCFG;

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x7638A0", Offset = "0x7626A0", VA = "0x1807638A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF8450", Offset = "0x5DF7250", VA = "0x185DF8450")]
	public FBFFGJDPBFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x5DF83D0", Offset = "0x5DF71D0", VA = "0x185DF83D0", Slot = "4")]
	[IteratorStateMachine(typeof(MCDNPIFJOGP))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x5DF83D0", Offset = "0x5DF71D0", VA = "0x185DF83D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[PMDCDBMECJP(typeof(EILLDLEJNAB), new string[] { })]
[BNEEAEKLIEP(typeof(LNONMHFEMMB))]
public class OICEDKFDHKK : EILLDLEJNAB, EPBKMCPBINK, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private readonly Dictionary<int, BBDHFKCDKMF> GBCJOKHAECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private readonly Dictionary<BBDHFKCDKMF, int> PBNOMNIIAFN;

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x5E09EA0", Offset = "0x5E08CA0", VA = "0x185E09EA0", Slot = "6")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x5E09F60", Offset = "0x5E08D60", VA = "0x185E09F60", Slot = "7")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A060", Offset = "0x5E08E60", VA = "0x185E0A060")]
	private void LEIPOHKEIFJ(List<(BBDHFKCDKMF nameHash, CLMBKIMNLOD stableTypeHash, Type type)> MJLHCFFNENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x5E09CE0", Offset = "0x5E08AE0", VA = "0x185E09CE0", Slot = "4")]
	public BBDHFKCDKMF FLPDIIFAPOH(int NGICFBMMBFC)
	{
		return default(BBDHFKCDKMF);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x5E09E30", Offset = "0x5E08C30", VA = "0x185E09E30", Slot = "5")]
	public int IFOMIBHFPMB(BBDHFKCDKMF MDEJOIBGFEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A270", Offset = "0x5E09070", VA = "0x185E0A270")]
	public OICEDKFDHKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[PMDCDBMECJP(typeof(EHGJMOLBODP), new string[] { })]
public class JFCPHJBMGCN : EHGJMOLBODP, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	[PDOCKCLGMBB]
	private GCMLJOOJHLC IFKIGJDABJA;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private uint EBOLNDNIGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x5DFE8D0", Offset = "0x5DFD6D0", VA = "0x185DFE8D0", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE920", Offset = "0x5DFD720", VA = "0x185DFE920", Slot = "5")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public JFCPHJBMGCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[PMDCDBMECJP(typeof(FLHIJLBPMGI), new string[] { })]
public class PIJDAEJMMMO : FLHIJLBPMGI, EPBKMCPBINK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private NLAOLBMEEMA GHGGDHPIPFK;

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B060", Offset = "0x5E09E60", VA = "0x185E0B060", Slot = "8")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x5E0AC60", Offset = "0x5E09A60", VA = "0x185E0AC60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B160", Offset = "0x5E09F60", VA = "0x185E0B160", Slot = "4")]
	public void KFKEPNNIBIJ(GFPOPKJOMLL ALPEICGOMCK, FGBENGKJFDK OGIJMJFMMHK, ReadOnlySpan<byte> HAFIPCLBGLE, ReadOnlySpan<byte> LHFEOECNFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x5E0ACB0", Offset = "0x5E09AB0", VA = "0x185E0ACB0", Slot = "7")]
	public bool FAELCKJOGCO(GFPOPKJOMLL ALPEICGOMCK, FGBENGKJFDK OGIJMJFMMHK, Span<byte> HAFIPCLBGLE, Span<byte> LHFEOECNFKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B3C0", Offset = "0x5E0A1C0", VA = "0x185E0B3C0", Slot = "5")]
	public bool KPCLGJCFNBJ(GFPOPKJOMLL ALPEICGOMCK, FGBENGKJFDK OGIJMJFMMHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x5E0B130", Offset = "0x5E09F30", VA = "0x185E0B130", Slot = "6")]
	public bool KANMLNEBMAJ(GFPOPKJOMLL ALPEICGOMCK, FGBENGKJFDK OGIJMJFMMHK, ReadOnlySpan<byte> LHFEOECNFKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A8C0", Offset = "0x5E096C0", VA = "0x185E0A8C0")]
	private bool BEIOCCHNLMC(GFPOPKJOMLL ALPEICGOMCK, FGBENGKJFDK OGIJMJFMMHK, ReadOnlySpan<byte> LHFEOECNFKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public PIJDAEJMMMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class PNJGMOKOGFF<T> : ADIPFCADPAL<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	protected BABILNDFMBA<T> HEICDHHOEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	protected DIIGJENGIHH<T> NKCMIGKKOOM;

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x3479150", Offset = "0x3477F50", VA = "0x183479150")]
	public PNJGMOKOGFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE19A0", Offset = "0x3DE07A0", VA = "0x183DE19A0")]
	public PNJGMOKOGFF(BABILNDFMBA<T> HEICDHHOEOE, DIIGJENGIHH<T> NKCMIGKKOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1740", Offset = "0x3DE0540", VA = "0x183DE1740", Slot = "10")]
	protected override T NLOFGFEMKNI(FHPDONHLANK GFNJLJABMCF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1230", Offset = "0x3DE0030", VA = "0x183DE1230", Slot = "11")]
	protected override void LJOKGFFEJKK(HMCHACCMPLE FNEJOGEIEJN, T POACLGOFKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class LAKNBEDAILN
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class CAOPLEJINFH<T> : PNJGMOKOGFF<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x477BF60", Offset = "0x477AD60", VA = "0x18477BF60")]
	public CAOPLEJINFH(T OAPEGBFADLJ, T PDNOBEJABKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public sealed class PIPJEFODMPE<T> : ADIPFCADPAL<T> where T : struct, EGKFDGGDBHJ
{
	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x3DC62C0", Offset = "0x3DC50C0", VA = "0x183DC62C0", Slot = "10")]
	protected override T NLOFGFEMKNI(FHPDONHLANK GFNJLJABMCF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x3DC6130", Offset = "0x3DC4F30", VA = "0x183DC6130", Slot = "11")]
	protected override void LJOKGFFEJKK(HMCHACCMPLE FNEJOGEIEJN, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x3000FA0", Offset = "0x2FFFDA0", VA = "0x183000FA0")]
	public PIPJEFODMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
internal static class HOFNGGLPBHJ
{
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	private class KIGGOHDGGHI
	{
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private sealed class EFNALENBMLB<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public EFNALENBMLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0x30264B0", Offset = "0x30252B0", VA = "0x1830264B0")]
			internal void PKBCJLCBDJK(HMCHACCMPLE writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053E")]
			[Cpp2IlInjected.Address(RVA = "0x3026270", Offset = "0x3025070", VA = "0x183026270")]
			internal T EBIPKKJHDHN(FHPDONHLANK reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x5E004A0", Offset = "0x5DFF2A0", VA = "0x185E004A0")]
		public static void NMEABKADKFL(ALBIPAACMIH GBGFPCMIGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x2985700", Offset = "0x2984500", VA = "0x182985700")]
		private static void CNHDBGBDEJF<T>(ALBIPAACMIH GBGFPCMIGKL, int PDNOBEJABKG) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x2985670", Offset = "0x2984470", VA = "0x182985670")]
		private static void ANNAHKGIEMN<T>(HMCHACCMPLE FNEJOGEIEJN, T ABBNPGBNHJD, int PDNOBEJABKG) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x2985830", Offset = "0x2984630", VA = "0x182985830")]
		private static T OFEIOFINLFC<T>(FHPDONHLANK GFNJLJABMCF, int PDNOBEJABKG) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KIGGOHDGGHI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	private class PCOHHJCCGMM : IMDMMKACNEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private ALBIPAACMIH GBGFPCMIGKL;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2986720", Offset = "0x2985520", VA = "0x182986720", Slot = "6")]
		public override void EGBNHNMONMO<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x5E0A3F0", Offset = "0x5E091F0", VA = "0x185E0A3F0")]
		public static void IGCJPOGIHIN(ALBIPAACMIH GBGFPCMIGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x5DFB050", Offset = "0x5DF9E50", VA = "0x185DFB050")]
		public PCOHHJCCGMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	private class LKDONDHCJFG
	{
		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		[CompilerGenerated]
		private sealed class EIEGHPBENBK<T> where T : struct, INativeList<int>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public EIEGHPBENBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0x3026470", Offset = "0x3025270", VA = "0x183026470")]
			internal void HKIHHIHFIMN(HMCHACCMPLE writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x3026410", Offset = "0x3025210", VA = "0x183026410")]
			internal T NPFEMDFLGFJ(FHPDONHLANK reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x5E01780", Offset = "0x5E00580", VA = "0x185E01780")]
		public static void AJDDCHMJENK(ALBIPAACMIH GBGFPCMIGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2985700", Offset = "0x2984500", VA = "0x182985700")]
		private static void CAAIHFCPGCP<T>(ALBIPAACMIH GBGFPCMIGKL, int PDNOBEJABKG) where T : struct, INativeList<int>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2985EC0", Offset = "0x2984CC0", VA = "0x182985EC0")]
		private static void PCAAOAHLIDN<T>(HMCHACCMPLE FNEJOGEIEJN, T ABBNPGBNHJD, int PDNOBEJABKG) where T : struct, INativeList<int>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x2985DF0", Offset = "0x2984BF0", VA = "0x182985DF0")]
		private static T HFONPJBOOIP<T>(FHPDONHLANK GFNJLJABMCF, int PDNOBEJABKG) where T : struct, INativeList<int>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LKDONDHCJFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB460", Offset = "0x5DFA260", VA = "0x185DFB460")]
	public static void IKHGJJEEBCA(ALBIPAACMIH GBGFPCMIGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCF20", Offset = "0x5DFBD20", VA = "0x185DFCF20")]
	private static void OCPIACFPIJD(HMCHACCMPLE NHNDDOIAEPK, quaternion ABBNPGBNHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x5DFB380", Offset = "0x5DFA180", VA = "0x185DFB380")]
	private static quaternion FIJNIINAEME(FHPDONHLANK CAAEKLGIBGJ)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x23D6740", Offset = "0x23D5540", VA = "0x1823D6740")]
	public static void JNIKIMMAPNE<T>(ALBIPAACMIH GBGFPCMIGKL, BABILNDFMBA<T> HEICDHHOEOE, DIIGJENGIHH<T> NKCMIGKKOOM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x23D67E0", Offset = "0x23D55E0", VA = "0x1823D67E0")]
	public static void KKEGEJANKKL<T>(ALBIPAACMIH GFNIJJJMCDK) where T : struct, EGKFDGGDBHJ
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public abstract class MGIAKCBJEPH : JKJHPNOJKLP
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public abstract Type EJAEBICHCCH
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void NLOFGFEMKNI(FHPDONHLANK GFNJLJABMCF, Span<byte> POACLGOFKAJ);

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void LJOKGFFEJKK(HMCHACCMPLE FNEJOGEIEJN, ReadOnlySpan<byte> POACLGOFKAJ);

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected MGIAKCBJEPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public abstract class ADIPFCADPAL<T> : MGIAKCBJEPH where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public override Type EJAEBICHCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x3447920", Offset = "0x3446720", VA = "0x183447920", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract T NLOFGFEMKNI(FHPDONHLANK GFNJLJABMCF);

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void LJOKGFFEJKK(HMCHACCMPLE FNEJOGEIEJN, T POACLGOFKAJ);

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x3448560", Offset = "0x3447360", VA = "0x183448560", Slot = "8")]
	public override void NLOFGFEMKNI(FHPDONHLANK GFNJLJABMCF, Span<byte> PABBJIBBIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x34473F0", Offset = "0x34461F0", VA = "0x1834473F0", Slot = "9")]
	public override void LJOKGFFEJKK(HMCHACCMPLE FNEJOGEIEJN, ReadOnlySpan<byte> PGGBKFCMLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
	protected ADIPFCADPAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
internal static class CMOPEOPPFKC
{
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public struct BHMAHCDKPCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public CCAABBKKMFL ACIEHBFKONJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public GAEECOGBKLC CMPPKJDILMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public PCGDABHJAAB BKAIMIHKGOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public COAMDDAKEMC HAHKEFILEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public FLHIJLBPMGI PNHOMDGKKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public DPOOHLIEHCA GBGFPCMIGKL;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF610", Offset = "0x5DEE410", VA = "0x185DEF610")]
		public void LKOIJBFKMJL(NFHEEPPLDKB MBMNNOGNPON)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public struct KFDPEDPLGJG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public NativeList<GFPOPKJOMLL> LNKIEKGIJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public NativeList<JJPHEIKOGBI> BLKDAKGGOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public NativeList<GFPOPKJOMLL> BPMLECOAJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public NativeParallelMultiHashMap<GFPOPKJOMLL, LMFJFLHHBOG> NAFNNIMKNLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public NativeList<byte> CLPPLAEKEHL;

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public bool CJGICLGHAMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x5E00340", Offset = "0x5DFF140", VA = "0x185E00340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x5E002A0", Offset = "0x5DFF0A0", VA = "0x185E002A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	private struct CGNOGHCFBKK : IComparer<LMFJFLHHBOG>
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF8C0", Offset = "0x5DEE6C0", VA = "0x185DEF8C0", Slot = "4")]
		public int Compare(LMFJFLHHBOG NPDPLEIHBMM, LMFJFLHHBOG CINKHPOEGPD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private static readonly HICMFDICNOL LAJEFIFMILN;

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0B20", Offset = "0x5DEF920", VA = "0x185DF0B20")]
	public static void FKAODNPGOCK(HMCHACCMPLE FNEJOGEIEJN, KFDPEDPLGJG LMCJHCIOIIP, BHMAHCDKPCC MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1760", Offset = "0x5DF0560", VA = "0x185DF1760")]
	public static KFDPEDPLGJG NCPLIIMEGBN(FHPDONHLANK GFNJLJABMCF, Allocator MBGJLDPPIJN, BHMAHCDKPCC MBMNNOGNPON)
	{
		return default(KFDPEDPLGJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1360", Offset = "0x5DF0160", VA = "0x185DF1360")]
	public static void KFKEPNNIBIJ(KFDPEDPLGJG LMCJHCIOIIP, BHMAHCDKPCC MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1070", Offset = "0x5DEFE70", VA = "0x185DF1070")]
	public static void KANMLNEBMAJ(KFDPEDPLGJG LMCJHCIOIIP, BHMAHCDKPCC MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF8F0", Offset = "0x5DEE6F0", VA = "0x185DEF8F0")]
	public static int CILJJKMPCMH(KFDPEDPLGJG LMCJHCIOIIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0A30", Offset = "0x5DEF830", VA = "0x185DF0A30")]
	private static void DODLPMOGBKN(HMCHACCMPLE FNEJOGEIEJN, NativeArray<GFPOPKJOMLL> LNKIEKGIJPO, NativeArray<JJPHEIKOGBI> BLKDAKGGOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0DE0", Offset = "0x5DEFBE0", VA = "0x185DF0DE0")]
	private static void HMJLJHJAKAD(FHPDONHLANK GFNJLJABMCF, Allocator MBGJLDPPIJN, [Out] NativeList<GFPOPKJOMLL> LNKIEKGIJPO, [Out] NativeList<JJPHEIKOGBI> BOIAAKLLGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1A70", Offset = "0x5DF0870", VA = "0x185DF1A70")]
	private static void NNBDNEGLEPB(HMCHACCMPLE FNEJOGEIEJN, NativeArray<GFPOPKJOMLL> BPMLECOAJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0F70", Offset = "0x5DEFD70", VA = "0x185DF0F70")]
	private static void JOFAAGGEGHA(FHPDONHLANK GFNJLJABMCF, Allocator MBGJLDPPIJN, [Out] NativeList<GFPOPKJOMLL> BPMLECOAJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0090", Offset = "0x5DEEE90", VA = "0x185DF0090")]
	private static void DCDOFDFGAII(HMCHACCMPLE FNEJOGEIEJN, NativeParallelMultiHashMap<GFPOPKJOMLL, LMFJFLHHBOG> NAFNNIMKNLM, NativeList<byte> CLPPLAEKEHL, BHMAHCDKPCC MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFA40", Offset = "0x5DEE840", VA = "0x185DEFA40")]
	private static void CNPOBIEGEML(FHPDONHLANK GFNJLJABMCF, Allocator MBGJLDPPIJN, [Out] NativeParallelMultiHashMap<GFPOPKJOMLL, LMFJFLHHBOG> NAFNNIMKNLM, [Out] NativeList<byte> CLPPLAEKEHL, BHMAHCDKPCC MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0DC0", Offset = "0x5DEFBC0", VA = "0x185DF0DC0")]
	private static void GFHIKBHFBMP(int OIBBPNKGBKE, int JDFDFNAHIGH, HMCHACCMPLE FNEJOGEIEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5DF0B00", Offset = "0x5DEF900", VA = "0x185DF0B00")]
	private static int EGBBMELHABH(int JDFDFNAHIGH, FHPDONHLANK GFNJLJABMCF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[PMDCDBMECJP(typeof(MFLLDFGILPC), new string[] { })]
internal sealed class IFIMIFJPPFN : MFLLDFGILPC, EPBKMCPBINK, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly Dictionary<FGBENGKJFDK, DLBNNPENODL> ENFFIAPBLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private GAEECOGBKLC NAFNNIMKNLM;

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE340", Offset = "0x5DFD140", VA = "0x185DFE340", Slot = "6")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE390", Offset = "0x5DFD190", VA = "0x185DFE390", Slot = "7")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE460", Offset = "0x5DFD260", VA = "0x185DFE460", Slot = "4")]
	public void LAPCBGMBHPD(FGBENGKJFDK OGIJMJFMMHK, Type IDNCFEEPPPD, DLBNNPENODL GIOMBIPFKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE3F0", Offset = "0x5DFD1F0", VA = "0x185DFE3F0", Slot = "5")]
	public bool KDDEKLCOANN(FGBENGKJFDK OGIJMJFMMHK, [Out] DLBNNPENODL GIOMBIPFKBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE4D0", Offset = "0x5DFD2D0", VA = "0x185DFE4D0")]
	public IFIMIFJPPFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[PMDCDBMECJP(typeof(BHGJIPLOBOI), new string[] { })]
internal class MPFEMKMAKNP : ENEHADLKBBF, BHGJIPLOBOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	[PDOCKCLGMBB]
	private EHGJMOLBODP KOPAGBBKACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private OJGDGHMIIEH KFBLNPEOHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private int LALJHEAHJJB;

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5E03890", Offset = "0x5E02690", VA = "0x185E03890", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5E03900", Offset = "0x5E02700", VA = "0x185E03900", Slot = "5")]
	public LNIKGFKEIBE ONEHDAFPMCD(ReadOnlySpan<byte> JOPBACODGFL)
	{
		return default(LNIKGFKEIBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5E03880", Offset = "0x5E02680", VA = "0x185E03880", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MPFEMKMAKNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[PMDCDBMECJP(typeof(COAMDDAKEMC), new string[] { })]
internal sealed class BFOBNGBFHLH : COAMDDAKEMC, ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	[PDOCKCLGMBB]
	private GAEECOGBKLC NAFNNIMKNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private NativeBitArray BHBIEDCNBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private NativeParallelHashMap<GFPOPKJOMLL, int> BPDMONFAFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private NativeList<int> AEIFIIJDOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private int BGFHJHBJFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private int HDBOLFEMKOK;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool ENEODBALKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x5DEEF20", Offset = "0x5DEDD20", VA = "0x185DEEF20", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public PCBHLHDFJKC KANEHFBNLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x5DEF5C0", Offset = "0x5DEE3C0", VA = "0x185DEF5C0", Slot = "7")]
		get
		{
			return default(PCBHLHDFJKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF540", Offset = "0x5DEE340", VA = "0x185DEF540", Slot = "4")]
	public bool JNNMBFKKLLG(GFPOPKJOMLL OEAOJAGKHME, FGBENGKJFDK GHOAJKHDDHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF3E0", Offset = "0x5DEE1E0", VA = "0x185DEF3E0", Slot = "8")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEFD0", Offset = "0x5DEDDD0", VA = "0x185DEEFD0", Slot = "6")]
	public void GHDKNAPEMKI(NativeArray<GFPOPKJOMLL> AINFNEHLDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF160", Offset = "0x5DEDF60", VA = "0x185DEF160", Slot = "5")]
	public void IGMHADGLMKD(GFPOPKJOMLL OEAOJAGKHME, Span<FGBENGKJFDK> NAFNNIMKNLM, bool BBCGKHFPMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x5DEEF40", Offset = "0x5DEDD40", VA = "0x185DEEF40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BFOBNGBFHLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[PMDCDBMECJP(typeof(DPOOHLIEHCA), new string[] { })]
public sealed class PHNMJGFHKMK : DPOOHLIEHCA, ENDMGLHKIDK<DPOOHLIEHCA>, EPBKMCPBINK, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly Dictionary<FGBENGKJFDK, JKJHPNOJKLP> GBGFPCMIGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private ALBIPAACMIH MFOHGECAKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private GAEECOGBKLC NAFNNIMKNLM;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public bool MDEOCPONNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7CDAC0", Offset = "0x7CC8C0", VA = "0x1807CDAC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A830", Offset = "0x5E09630", VA = "0x185E0A830")]
	public PHNMJGFHKMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A6C0", Offset = "0x5E094C0", VA = "0x185E0A6C0", Slot = "5")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A720", Offset = "0x5E09520", VA = "0x185E0A720", Slot = "6")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A4A0", Offset = "0x5E092A0", VA = "0x185E0A4A0", Slot = "4")]
	public bool HBHBLNKJFLH(FGBENGKJFDK KKIIDNMAMKF, [Out] JKJHPNOJKLP GFNIJJJMCDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(ALBIPAACMIH), new string[] { })]
internal sealed class ALBIPAACMIH : EPBKMCPBINK
{
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private readonly Dictionary<Type, JKJHPNOJKLP> GBGFPCMIGKL;

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDD10", Offset = "0x5DECB10", VA = "0x185DEDD10", Slot = "4")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDD60", Offset = "0x5DECB60", VA = "0x185DEDD60")]
	public void LAPCBGMBHPD(Type FLHOFPAHPKL, JKJHPNOJKLP GFNIJJJMCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDC40", Offset = "0x5DECA40", VA = "0x185DEDC40")]
	public bool HBHBLNKJFLH(Type FLHOFPAHPKL, [Out] JKJHPNOJKLP GFNIJJJMCDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x5DEDF10", Offset = "0x5DECD10", VA = "0x185DEDF10")]
	public ALBIPAACMIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
internal static class BPAKFCIILEL
{
	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF700", Offset = "0x5DEE500", VA = "0x185DEF700")]
	public static void LAPCBGMBHPD(this ALBIPAACMIH PLJNIEKIKFG, JKJHPNOJKLP GFNIJJJMCDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[AlwaysUpdateSystem]
internal class DJPAKLPDFJB : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public DJPAKLPDFJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public class CBABBFDAOAP : AddEntityBundlePartsToLinkedEntityGroupSystemBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private EntityCommandBufferSystem NFGGBBOFGOH;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	protected override EntityCommandBufferSystem PGDOFAKHCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x760F60", Offset = "0x75FD60", VA = "0x180760F60", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x5DEF860", Offset = "0x5DEE660", VA = "0x185DEF860", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public CBABBFDAOAP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	public abstract class AddEntityBundlePartsToLinkedEntityGroupSystemBase : DBMABBOGEPD
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
			[Cpp2IlInjected.Address(RVA = "0x5DEE660", Offset = "0x5DED460", VA = "0x185DEE660")]
			private void IOJGJCNCGIC(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x5DEE5B0", Offset = "0x5DED3B0", VA = "0x185DEE5B0", Slot = "4")]
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
			public ComponentTypeHandle<JPNNJNAPAML> __prefabPartDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x5DEE810", Offset = "0x5DED610", VA = "0x185DEE810")]
			private void IOJGJCNCGIC(Entity entity, [NoAlias] JPNNJNAPAML prefabPartData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x5DEE6D0", Offset = "0x5DED4D0", VA = "0x185DEE6D0", Slot = "4")]
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
		private ComponentTypeHandle<JPNNJNAPAML> __RecRoom_Components_EntityBundlePartData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		protected abstract EntityCommandBufferSystem Ecbs
		{
			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x5DEEC30", Offset = "0x5DEDA30", VA = "0x185DEEC30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE4D0", Offset = "0x5DED2D0", VA = "0x185DEE4D0")]
		private JobHandle JOIAIDKNBDI(EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE3B0", Offset = "0x5DED1B0", VA = "0x185DEE3B0")]
		private JobHandle INJIMNJJFOJ(EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE8B0", Offset = "0x5DED6B0", VA = "0x185DEE8B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		protected AddEntityBundlePartsToLinkedEntityGroupSystemBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public class OMLCAMDGCAJ : AddEntityBundlePartsToLinkedEntityGroupSystemBase
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private EntityCommandBufferSystem NFGGBBOFGOH;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	protected override EntityCommandBufferSystem PGDOFAKHCJP
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x760F60", Offset = "0x75FD60", VA = "0x180760F60", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E0A390", Offset = "0x5E09190", VA = "0x185E0A390", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public OMLCAMDGCAJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class UpdateAuthoredChildrenFromParent : ParentSystemBase<AuthoredParentData, AuthoredPreviousParentData, AuthoredChildrenData>
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x5E0C330", Offset = "0x5E0B130", VA = "0x185E0C330", Slot = "14")]
		protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C30", Offset = "0x7E3A30", VA = "0x1807E4C30", Slot = "15")]
		protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E0C2F0", Offset = "0x5E0B0F0", VA = "0x185E0C2F0", Slot = "16")]
		protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E0C2B0", Offset = "0x5E0B0B0", VA = "0x185E0C2B0", Slot = "17")]
		protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E0C370", Offset = "0x5E0B170", VA = "0x185E0C370")]
		public UpdateAuthoredChildrenFromParent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class MNABDJAHNCH : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private object HPAHEELMJNG;

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E02720", Offset = "0x5E01520", VA = "0x185E02720", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E027A0", Offset = "0x5E015A0", VA = "0x185E027A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E02850", Offset = "0x5E01650", VA = "0x185E02850", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public MNABDJAHNCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class LMMLEBEMOIF : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private object HPAHEELMJNG;

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E017C0", Offset = "0x5E005C0", VA = "0x185E017C0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E01840", Offset = "0x5E00640", VA = "0x185E01840", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E018F0", Offset = "0x5E006F0", VA = "0x185E018F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public LMMLEBEMOIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal abstract class EACJNDLINEN : FFKDGCPKFBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DF5F00", Offset = "0x5DF4D00", VA = "0x185DF5F00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x5DF61E0", Offset = "0x5DF4FE0", VA = "0x185DF61E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x5DF62D0", Offset = "0x5DF50D0", VA = "0x185DF62D0")]
	protected EACJNDLINEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[MPJBDEDKJDC]
internal abstract class FFKDGCPKFBI : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	protected CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	protected HCCIMPJEHHN EBCLIMEMCGJ;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	protected abstract CODBFNJONGN JOLENJMDMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9CB0", Offset = "0x5DF8AB0", VA = "0x185DF9CB0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF97B0", Offset = "0x5DF85B0", VA = "0x185DF97B0")]
	protected void CPIPKCMJFGM(EntityQuery GJGJMLNNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9A30", Offset = "0x5DF8830", VA = "0x185DF9A30")]
	protected void GAEBKKEKIMC(EntityQuery GJGJMLNNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DF9740", Offset = "0x5DF8540", VA = "0x185DF9740")]
	protected LLKJHKLONBK CFEPDLNFMLP(EntityQuery GJGJMLNNIOK)
	{
		return default(LLKJHKLONBK);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	protected FFKDGCPKFBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal abstract class GOANHBEKPHC : FFKDGCPKFBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private EntityQuery EMFAALOLNOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private EntityQuery MNFGABKEKFJ;

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA480", Offset = "0x5DF9280", VA = "0x185DFA480", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA7E0", Offset = "0x5DF95E0", VA = "0x185DFA7E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DFA390", Offset = "0x5DF9190", VA = "0x185DFA390")]
	private void ACIHCMFPLEN(EntityQuery GJGJMLNNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE0E0", Offset = "0x5DECEE0", VA = "0x185DEE0E0")]
	protected GOANHBEKPHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
internal class ODPJLPNHOCP : EACJNDLINEN
{
	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected override CODBFNJONGN JOLENJMDMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x5E09990", Offset = "0x5E08790", VA = "0x185E09990", Slot = "15")]
		get
		{
			return default(CODBFNJONGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DF62D0", Offset = "0x5DF50D0", VA = "0x185DF62D0")]
	public ODPJLPNHOCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
internal class ALJHLGGNILA : GOANHBEKPHC
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	protected override CODBFNJONGN JOLENJMDMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x5DEE070", Offset = "0x5DECE70", VA = "0x185DEE070", Slot = "15")]
		get
		{
			return default(CODBFNJONGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE0E0", Offset = "0x5DECEE0", VA = "0x185DEE0E0")]
	public ALJHLGGNILA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class GIFAJOBDKGP : EACJNDLINEN
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	protected override CODBFNJONGN JOLENJMDMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DFA160", Offset = "0x5DF8F60", VA = "0x185DFA160", Slot = "15")]
		get
		{
			return default(CODBFNJONGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DF62D0", Offset = "0x5DF50D0", VA = "0x185DF62D0")]
	public GIFAJOBDKGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal class LJPOHHIAGNL : GOANHBEKPHC
{
	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	protected override CODBFNJONGN JOLENJMDMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E01710", Offset = "0x5E00510", VA = "0x185E01710", Slot = "15")]
		get
		{
			return default(CODBFNJONGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE0E0", Offset = "0x5DECEE0", VA = "0x185DEE0E0")]
	public LJPOHHIAGNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
internal class MNFGJAENLFB : EACJNDLINEN
{
	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	protected override CODBFNJONGN JOLENJMDMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E02AF0", Offset = "0x5E018F0", VA = "0x185E02AF0", Slot = "15")]
		get
		{
			return default(CODBFNJONGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x5DF62D0", Offset = "0x5DF50D0", VA = "0x185DF62D0")]
	public MNFGJAENLFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class MMBIIALKMMB : GOANHBEKPHC
{
	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	protected override CODBFNJONGN JOLENJMDMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E026B0", Offset = "0x5E014B0", VA = "0x185E026B0", Slot = "15")]
		get
		{
			return default(CODBFNJONGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x5DEE0E0", Offset = "0x5DECEE0", VA = "0x185DEE0E0")]
	public MMBIIALKMMB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal struct BFHOKCGBMJH : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E3")]
internal struct AJDKABFBEJN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E4")]
internal struct GCDCCNBOFAA : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public readonly struct CODBFNJONGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	public readonly ComponentType? FFNJKBGCPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	public readonly ComponentType? NLKKPAFGLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	public readonly ComponentType MJKABCAIEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	public readonly object EKDHBKMFLGI;

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x5DF1BD0", Offset = "0x5DF09D0", VA = "0x185DF1BD0")]
	public CODBFNJONGN(ComponentType? FFNJKBGCPIH, ComponentType? NLKKPAFGLMJ, ComponentType MJKABCAIEKE, object EKDHBKMFLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x21F27A0", Offset = "0x21F15A0", VA = "0x1821F27A0")]
	public static CODBFNJONGN IGJDNLMFEKN<TReq, TTag>(object EKDHBKMFLGI)
	{
		return default(CODBFNJONGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x21F2580", Offset = "0x21F1380", VA = "0x1821F2580")]
	public static CODBFNJONGN DJPEAFIJKIN<TReq, TMissing, TTag>(object EKDHBKMFLGI)
	{
		return default(CODBFNJONGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
public static class JCLAPIJBPHB
{
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	public static readonly CODBFNJONGN PAPNFFCBGEJ;

	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	public static readonly CODBFNJONGN PPMEHNAOOKM;

	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public static readonly CODBFNJONGN IFMLNCHLEAB;
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[AlwaysUpdateSystem]
	[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
	[CompilerGenerated]
	public class CalculateCollisionIslandUpdatesSystem : DBMABBOGEPD, ENEHADLKBBF
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
			public ComponentTypeHandle<FPBIOJEEIND> collisionIslandRootDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002BF")]
			[ReadOnly]
			public ComponentDataFromEntity<FPBIOJEEIND> collisionIslandRootDataFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002C0")]
			[ReadOnly]
			public ComponentTypeHandle<MDLBCMGPBBP> splineParentHandleRO;

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
			[Cpp2IlInjected.Address(RVA = "0x5DF1C70", Offset = "0x5DF0A70", VA = "0x185DF1C70")]
			private void IOJGJCNCGIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x5DF1C60", Offset = "0x5DF0A60", VA = "0x185DF1C60", Slot = "4")]
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
		private BIOMOMPOMEM collisionIslandService;

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x5DF1C10", Offset = "0x5DF0A10", VA = "0x185DF1C10", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2630", Offset = "0x5DF1430", VA = "0x185DF2630", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x5DF29C0", Offset = "0x5DF17C0", VA = "0x185DF29C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x5DF2490", Offset = "0x5DF1290", VA = "0x185DF2490")]
		private JobHandle OEALAKGKKNK(NativeList<Entity> rootsWithForcedCollisionUpdate, NativeList<Entity> rootsWithoutForcedCollisionUpdate, ComponentTypeHandle<FPBIOJEEIND> collisionIslandRootDataHandleRO, ComponentDataFromEntity<FPBIOJEEIND> collisionIslandRootDataFromEntityRO, ComponentTypeHandle<MDLBCMGPBBP> splineParentHandleRO, EntityQueryInJob changedLocalPoseQueryInJob, EntityQueryInJob changedSplinePointsQueryInJob, EntityQueryInJob splinesWithChangedChildrenQueryInJob, EntityQueryInJob changedCollisionModeQueryInJob, EntityQueryInJob changedScopeRootQueryInJob, Allocator allocator, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public CalculateCollisionIslandUpdatesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[BurstCompatible]
internal readonly struct PNJHEEPDNPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	private readonly DKEIMJFADKA NGKIJLGBEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	private readonly MOMDAFKMLNP EDLEEIHJKHO;

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x97A610", Offset = "0x979410", VA = "0x18097A610")]
	public PNJHEEPDNPF(DKEIMJFADKA NGKIJLGBEBC, MOMDAFKMLNP EDLEEIHJKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x1B88DD0", Offset = "0x1B87BD0", VA = "0x181B88DD0")]
	public bool DJAFOFMIBEC(PNJHEEPDNPF LPDGANJNOMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x1B88DD0", Offset = "0x1B87BD0", VA = "0x181B88DD0")]
	public bool OFNCPKIGFMB(PNJHEEPDNPF KGAHDFAFPLE)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
	[CompilerGenerated]
	public class CalculateContainerCollisionIslandGraphChangesSystem : DBMABBOGEPD, ENEHADLKBBF
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
			public ComponentTypeHandle<MBDFIJPBELP> islandRootSystemDataTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			[ReadOnly]
			public ComponentDataFromEntity<CFAIBJGEMEN> dontPropagatePhysicsPropertiesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			[ReadOnly]
			public ComponentDataFromEntity<DKEIMJFADKA> containerCollisionModeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			[ReadOnly]
			public ComponentDataFromEntity<MOMDAFKMLNP> containerCollisionLayerRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			[ReadOnly]
			public ComponentDataFromEntity<MHMHLPOCOJN> containerCollisionIslandRootTagRO;

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
			public NativeList<JOPOMJOPFBA> changedIslandRootsWO;

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
			public ComponentDataFromEntity<FPBIOJEEIND> collisionIslandRootDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			public NativeParallelHashSet<Entity> visitedRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			private int bufferHead;

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E14790", Offset = "0x5E13590", VA = "0x185E14790", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x5E151C0", Offset = "0x5E13FC0", VA = "0x185E151C0")]
			private void IPNDFNPDJDC(Entity startEntity, bool checkForUnchanged)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x5E153F0", Offset = "0x5E141F0", VA = "0x185E153F0")]
			private Entity NAGNEIADAKB(Entity curEntity, PNJHEEPDNPF classifier)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x5E14640", Offset = "0x5E13440", VA = "0x185E14640")]
			private bool CIDANKJOBLB(Entity curEntity, PNJHEEPDNPF classifier, [Out] Entity parentEntity, [Out] PNJHEEPDNPF parentClassifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x5E14E40", Offset = "0x5E13C40", VA = "0x185E14E40")]
			private void GJMIDKHCFAC(Entity islandRoot, PNJHEEPDNPF classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x5E14F50", Offset = "0x5E13D50", VA = "0x185E14F50")]
			private void IJIGDFJCMBM(Entity islandRoot, Entity entity, PNJHEEPDNPF classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x5E14530", Offset = "0x5E13330", VA = "0x185E14530")]
			private void BIFBEJNLFKL(Entity islandRoot, Entity component)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x5E14700", Offset = "0x5E13500", VA = "0x185E14700")]
			private bool DNLBLHKPNOE(Entity entity, [Out] PNJHEEPDNPF classifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x5E15370", Offset = "0x5E14170", VA = "0x185E15370")]
			private PNJHEEPDNPF KFDHPDIDEGP(Entity entity)
			{
				return default(PNJHEEPDNPF);
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
			[Cpp2IlInjected.Address(RVA = "0x5E0F3B0", Offset = "0x5E0E1B0", VA = "0x185E0F3B0")]
			private void IOJGJCNCGIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x5E0F3A0", Offset = "0x5E0E1A0", VA = "0x185E0F3A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		[PDOCKCLGMBB]
		private BIOMOMPOMEM collisionIslandService;

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
		private BMHCKKNLGMA ecbs;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E0F350", Offset = "0x5E0E150", VA = "0x185E0F350", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E0F7A0", Offset = "0x5E0E5A0", VA = "0x185E0F7A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E0FBF0", Offset = "0x5E0E9F0", VA = "0x185E0FBF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E0EBF0", Offset = "0x5E0D9F0", VA = "0x185E0EBF0")]
		private JobHandle FKEBIPJEINA(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E0F4E0", Offset = "0x5E0E2E0", VA = "0x185E0F4E0")]
		private JobHandle OMHEJFFHCMI(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E0EAF0", Offset = "0x5E0D8F0", VA = "0x185E0EAF0")]
		private JobHandle DOJNBDPDALN(EntityCommandBuffer ecb, NativeList<Entity> removedIslandRootsWO, EntityTypeHandle entityType, EntityQueryInJob queryInJob, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public CalculateContainerCollisionIslandGraphChangesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
[AlwaysUpdateSystem]
public class FCBALHIBMJM : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	[PDOCKCLGMBB]
	private BIOMOMPOMEM HELFMKLAJFJ;

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x5E13A50", Offset = "0x5E12850", VA = "0x185E13A50", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x5E13AA0", Offset = "0x5E128A0", VA = "0x185E13AA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public FCBALHIBMJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public sealed class JIKAIILFEFG : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	private LEALPNGCHEO MPANOGNBHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private JNCMBIAIKIB IANFNPKFCFA;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AEB0", Offset = "0x5E19CB0", VA = "0x185E1AEB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AE20", Offset = "0x5E19C20", VA = "0x185E1AE20", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AFC0", Offset = "0x5E19DC0", VA = "0x185E1AFC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public JIKAIILFEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class HCNMEMGOJBN : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	public KJKIANDJMFH JHNFBPKNCCI;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HCNMEMGOJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public HCNMEMGOJBN(KJKIANDJMFH JHNFBPKNCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x5E17FC0", Offset = "0x5E16DC0", VA = "0x185E17FC0", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public abstract class KFDGAGBGPLG : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private OJJJKLOBGFC GGFBOHOPFHI;

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C210", Offset = "0x5E1B010", VA = "0x185E1C210", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C270", Offset = "0x5E1B070", VA = "0x185E1C270", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C2A0", Offset = "0x5E1B0A0", VA = "0x185E1C2A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	protected KFDGAGBGPLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public class HGOHMLDHGIP : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private EntityQuery DKFKPAJGAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	private EntityQuery BPIAGKOJOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private EntityQuery PMOGHFHPGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private EntityQuery BOPKJEBBKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private OJJJKLOBGFC FBCNECCBMEK;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int MCKAAEKOIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x5E18200", Offset = "0x5E17000", VA = "0x185E18200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x5E18510", Offset = "0x5E17310", VA = "0x185E18510", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x5E18640", Offset = "0x5E17440", VA = "0x185E18640", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x5E18870", Offset = "0x5E17670", VA = "0x185E18870", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x5E18160", Offset = "0x5E16F60", VA = "0x185E18160")]
	public int AFJDLADJANC(SceneTag GJBLGBOBAMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x5E18260", Offset = "0x5E17060", VA = "0x185E18260")]
	protected void BPDCNIMHEMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x5E18030", Offset = "0x5E16E30", VA = "0x185E18030")]
	protected void ABBMMPDPOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x5E185F0", Offset = "0x5E173F0", VA = "0x185E185F0")]
	public NativeArrayAsync<Entity> MEPICCAPMKJ(SceneTag GJBLGBOBAMI, Allocator MBGJLDPPIJN = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x5E18210", Offset = "0x5E17010", VA = "0x185E18210")]
	public NativeArrayAsync<Entity> AJKAJILEHID(SceneTag GJBLGBOBAMI, Allocator MBGJLDPPIJN = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x5E18890", Offset = "0x5E17690", VA = "0x185E18890")]
	public bool PEIGMFNEDJL(SceneTag GJBLGBOBAMI, [Out] NativeArrayAsync<Entity> JHNFBPKNCCI, Allocator MBGJLDPPIJN = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x5E18420", Offset = "0x5E17220", VA = "0x185E18420")]
	public bool CHIIPFDEOAP(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x5E184A0", Offset = "0x5E172A0", VA = "0x185E184A0")]
	public bool DGOPEJKDEPE(Entity HHHGBIJCKBC, [Out] HCNMEMGOJBN JHNFBPKNCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x5E18570", Offset = "0x5E17370", VA = "0x185E18570")]
	public void LDFOHDJJEAF(Entity HHHGBIJCKBC, HCNMEMGOJBN JHNFBPKNCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x5E18180", Offset = "0x5E16F80", VA = "0x185E18180")]
	public bool AHPGMCOCKHP(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public HGOHMLDHGIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal class OJGPDKICOCK : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private EntityQuery DPKOHHDKGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private JNDGIDLEBEK IFKIGJDABJA;

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FC80", Offset = "0x5E1EA80", VA = "0x185E1FC80", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FCD0", Offset = "0x5E1EAD0", VA = "0x185E1FCD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FD90", Offset = "0x5E1EB90", VA = "0x185E1FD90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x250A7D0", Offset = "0x25095D0", VA = "0x18250A7D0")]
	private bool ANGDOPFDJKB<TComponentData>(EntityQuery GJGJMLNNIOK, [Out] NativeArray<Entity> DDIFFODKOKJ, [Out] NativeArray<TComponentData> NDFBKPCIBAL) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FBF0", Offset = "0x5E1E9F0", VA = "0x185E1FBF0")]
	public KJKIANDJMFH AMMFLIJLIIP(Entity HHHGBIJCKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public OJGPDKICOCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public class ILHCEJDJDLM : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private EntityQuery NBBEGEDPHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private EntityQuery PODMOPKHMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery GPFLKCKHBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private EntityQuery OMKDCCJJKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private ABOCLKIIMFN IFKIGJDABJA;

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A800", Offset = "0x5E19600", VA = "0x185E1A800", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A8E0", Offset = "0x5E196E0", VA = "0x185E1A8E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AB60", Offset = "0x5E19960", VA = "0x185E1AB60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A3F0", Offset = "0x5E191F0", VA = "0x185E1A3F0")]
	private void EJEJBLJEAIN(EntityQuery GJGJMLNNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A850", Offset = "0x5E19650", VA = "0x185E1A850")]
	private void KCJHGNBNEJA(EntityQuery GJGJMLNNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AAD0", Offset = "0x5E198D0", VA = "0x185E1AAD0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1A480", Offset = "0x5E19280", VA = "0x185E1A480")]
	private void IGAJCIJGBGH(EntityQuery GJGJMLNNIOK, bool MMCBDJIKKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public ILHCEJDJDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public sealed class ACANAOONEAP : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private JDGDANEDDKA LEAHHBMJDIE;

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D190", Offset = "0x5E0BF90", VA = "0x185E0D190", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D1F0", Offset = "0x5E0BFF0", VA = "0x185E0D1F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public ACANAOONEAP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	public class GatherModifiedParentsSystem : DBMABBOGEPD, GOMKIFEKCFK
	{
		[Cpp2IlInjected.Token(Token = "0x20000F6")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct GatherModifiedParents_AddNewParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			public NativeList<PPNLIJLNAOJ> newParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __currentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x5E17DA0", Offset = "0x5E16BA0", VA = "0x185E17DA0")]
			private void IOJGJCNCGIC(Entity entity, [In][NoAlias] ParentData current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0x5E17C80", Offset = "0x5E16A80", VA = "0x185E17C80", Slot = "4")]
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
			public NativeList<CFACDODIOOC> changedParents;

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
			[Cpp2IlInjected.Address(RVA = "0x5E17BC0", Offset = "0x5E169C0", VA = "0x185E17BC0")]
			private void IOJGJCNCGIC(Entity entity, [In][NoAlias] ParentData current, [In][NoAlias] PreviousParentData previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063A")]
			[Cpp2IlInjected.Address(RVA = "0x5E17A20", Offset = "0x5E16820", VA = "0x185E17A20", Slot = "4")]
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
			public NativeList<PPNLIJLNAOJ> oldParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			[ReadOnly]
			public ComponentTypeHandle<PreviousParentData> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0x5E17F40", Offset = "0x5E16D40", VA = "0x185E17F40")]
			private void IOJGJCNCGIC(Entity entity, [In][NoAlias] PreviousParentData previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x5E17E20", Offset = "0x5E16C20", VA = "0x185E17E20", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private JNOBPLOAHCA parentEvents;

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
		[Cpp2IlInjected.Address(RVA = "0x5E16C60", Offset = "0x5E15A60", VA = "0x185E16C60", Slot = "14")]
		public void FEHCJNGFIKF(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x5E176B0", Offset = "0x5E164B0", VA = "0x185E176B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x5E16D40", Offset = "0x5E15B40", VA = "0x185E16D40")]
		private JobHandle GCFHKBFHKLA(NativeList<PPNLIJLNAOJ> newParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x5E16F80", Offset = "0x5E15D80", VA = "0x185E16F80")]
		private JobHandle MNFNDJJNMLI(NativeList<CFACDODIOOC> changedParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x5E16E60", Offset = "0x5E15C60", VA = "0x185E16E60")]
		private JobHandle GMALHDBBAAD(NativeList<PPNLIJLNAOJ> oldParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x5E170E0", Offset = "0x5E15EE0", VA = "0x185E170E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public GatherModifiedParentsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public class NFDJALDLHOD : ParentSystemBase<ParentData, PreviousParentData, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FA80", Offset = "0x5E1E880", VA = "0x185E1FA80", Slot = "14")]
	protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc GJGJMLNNIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C30", Offset = "0x7E3A30", VA = "0x1807E4C30", Slot = "15")]
	protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc GJGJMLNNIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FA40", Offset = "0x5E1E840", VA = "0x185E1FA40", Slot = "16")]
	protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc GJGJMLNNIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FA00", Offset = "0x5E1E800", VA = "0x185E1FA00", Slot = "17")]
	protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc GJGJMLNNIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FAC0", Offset = "0x5E1E8C0", VA = "0x185E1FAC0")]
	public NFDJALDLHOD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public abstract class ParentSystemBase<TParentData, TPreviousParentData, TChildrenData> : DBMABBOGEPD where TParentData : struct, IComponentData, IPMLIMBHIHK where TPreviousParentData : struct, IComponentData, IPMLIMBHIHK where TChildrenData : struct, ISystemStateBufferElementData, IEquatable<TChildrenData>, IPMLIMBHIHK
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
			[Cpp2IlInjected.Address(RVA = "0x3547410", Offset = "0x3546210", VA = "0x183547410", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x33EC0A0", Offset = "0x33EAEA0", VA = "0x1833EC0A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x33F4A10", Offset = "0x33F3810", VA = "0x1833F4A10")]
			private int FindChildIndex(DynamicBuffer<TChildrenData> children, Entity entity)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x33F4AF0", Offset = "0x33F38F0", VA = "0x1833F4AF0")]
			private void RemoveChildrenFromParent(Entity parent, DynamicBuffer<TChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0x33F4530", Offset = "0x33F3330", VA = "0x1833F4530")]
			private void AddChildrenToParent(Entity parent, DynamicBuffer<TChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x33F4670", Offset = "0x33F3470", VA = "0x1833F4670", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3547B30", Offset = "0x3546930", VA = "0x183547B30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E127E0", Offset = "0x3E115E0", VA = "0x183E127E0")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x3E10090", Offset = "0x3E0EE90", VA = "0x183E10090")]
		private int FindChildIndex(DynamicBuffer<TChildrenData> children, Entity entity)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x3E10B80", Offset = "0x3E0F980", VA = "0x183E10B80")]
		private void RemoveChildFromParent(Entity childEntity, Entity parentEntity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C30", Offset = "0x7E3A30", VA = "0x1807E4C30", Slot = "14")]
		protected virtual EntityQueryDesc FilterNewParentQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C30", Offset = "0x7E3A30", VA = "0x1807E4C30", Slot = "15")]
		protected virtual EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C30", Offset = "0x7E3A30", VA = "0x1807E4C30", Slot = "16")]
		protected virtual EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc query);

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x3E10190", Offset = "0x3E0EF90", VA = "0x183E10190", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x3E12310", Offset = "0x3E11110", VA = "0x183E12310")]
		private void UpdateNewParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x3E125F0", Offset = "0x3E113F0", VA = "0x183E125F0")]
		private void UpdateRemoveParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x3E11380", Offset = "0x3E10180", VA = "0x183E11380")]
		private JobHandle UpdateChangeParents(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x3E11E00", Offset = "0x3E10C00", VA = "0x183E11E00")]
		private void UpdateDeletedParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x3E10900", Offset = "0x3E0F700", VA = "0x183E10900", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x3E108D0", Offset = "0x3E0F6D0", VA = "0x183E108D0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[AlwaysUpdateSystem]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public abstract class PPHDJOMMNJK : DBMABBOGEPD, GOMKIFEKCFK
{
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private struct IDDKLJPFHCL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public NativeListAsync<Entity> DICAJOIAKCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public NativeListAsync<Entity> COOBMGCFPLC;

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A300", Offset = "0x5E19100", VA = "0x185E1A300")]
		public IDDKLJPFHCL(NativeList<Entity> DICAJOIAKCB, NativeList<Entity> COOBMGCFPLC, JobHandle GIFCONDMHLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A1F0", Offset = "0x5E18FF0", VA = "0x185E1A1F0")]
		public JobHandle APAFJOIFLII(JobHandle EJGMMMMHMMK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x5E1A270", Offset = "0x5E19070", VA = "0x185E1A270", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[BurstCompile]
	private struct PJFOIJEHIHP : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[Flags]
		public enum OBNMIKAFMMG
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
		public NativeList<Entity> CGNFHHCAOJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		[WriteOnly]
		public NativeList<Entity> CHOFOPPEAOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		[ReadOnly]
		public NativeArray<Entity> OPEGAJBKIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> BJIICIHIEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		[ReadOnly]
		public ComponentDataFromEntity FNIAPKFBBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		[ReadOnly]
		public ComponentDataFromEntity NMODANMDLLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> DFOGLPGHNBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public int IKDMDGEBPGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public int MEDHDMKJFDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private OBNMIKAFMMG NBPHMHIHAME;

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x5E21C20", Offset = "0x5E20A20", VA = "0x185E21C20", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x5E22290", Offset = "0x5E21090", VA = "0x185E22290")]
		private bool NOKCJJECLEK(Entity HHHGBIJCKBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x5E223C0", Offset = "0x5E211C0", VA = "0x185E223C0")]
		private void PDNDJHONJAE(Entity HHHGBIJCKBC, bool AIKPMELLEGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x5E220B0", Offset = "0x5E20EB0", VA = "0x185E220B0")]
		private void NHFLFINBIAC(Entity HHHGBIJCKBC, bool AIKPMELLEGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x5E22340", Offset = "0x5E21140", VA = "0x185E22340")]
		public IDDKLJPFHCL OILGGLBMMGJ(NativeArray<Entity> FDDNGNHADLG, JobHandle EJGMMMMHMMK)
		{
			return default(IDDKLJPFHCL);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x5E21AC0", Offset = "0x5E208C0", VA = "0x185E21AC0")]
		public IDDKLJPFHCL ADDNMHLOBKL(NativeArray<Entity> FDDNGNHADLG, JobHandle EJGMMMMHMMK)
		{
			return default(IDDKLJPFHCL);
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x5E21B40", Offset = "0x5E20940", VA = "0x185E21B40")]
		public IDDKLJPFHCL ADMHNAMLKBD(NativeList<PPNLIJLNAOJ> MJLHCFFNENL, JobHandle EJGMMMMHMMK)
		{
			return default(IDDKLJPFHCL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x5E221B0", Offset = "0x5E20FB0", VA = "0x185E221B0")]
		public IDDKLJPFHCL NNAPIKDLLAC(NativeList<PPNLIJLNAOJ> MJLHCFFNENL, JobHandle EJGMMMMHMMK)
		{
			return default(IDDKLJPFHCL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x5E21D50", Offset = "0x5E20B50", VA = "0x185E21D50")]
		public IDDKLJPFHCL HJBCFHIMGGB(NativeList<CFACDODIOOC> MJLHCFFNENL, JobHandle EJGMMMMHMMK)
		{
			return default(IDDKLJPFHCL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x2999080", Offset = "0x2997E80", VA = "0x182999080")]
		private IDDKLJPFHCL MKHCMGJALEP<T>(NativeList<T> MJLHCFFNENL, int LKNAFGDJIBI, int NALFDKEKEPL, OBNMIKAFMMG BPBBIDFIPLA, JobHandle EJGMMMMHMMK) where T : struct
		{
			return default(IDDKLJPFHCL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x5E21E30", Offset = "0x5E20C30", VA = "0x185E21E30")]
		private IDDKLJPFHCL MKHCMGJALEP(NativeArray<Entity> DDIFFODKOKJ, int LKNAFGDJIBI, int NALFDKEKEPL, OBNMIKAFMMG BPBBIDFIPLA, JobHandle EJGMMMMHMMK)
		{
			return default(IDDKLJPFHCL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	private EntityQuery JFHAEGDJHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private EntityQuery HJLIPPMKDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private JNOBPLOAHCA NLPCDONCAPF;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected abstract ComponentType OOIDENOGGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	protected abstract ComponentType HAKABMAJJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	protected abstract ComponentType OELANMLMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000659")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x5E240E0", Offset = "0x5E22EE0", VA = "0x185E240E0")]
	protected PPHDJOMMNJK(HICMFDICNOL DFCBIKLJFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x5E22770", Offset = "0x5E21570", VA = "0x185E22770", Slot = "14")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x5E22BE0", Offset = "0x5E219E0", VA = "0x185E22BE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x5E22DF0", Offset = "0x5E21BF0", VA = "0x185E22DF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x7FD220", Offset = "0x7FC020", VA = "0x1807FD220", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x5E228C0", Offset = "0x5E216C0", VA = "0x185E228C0")]
	private void IHFOMDLHDKA(NativeArray<Entity> MJLHCFFNENL, EntityCommandBuffer LLLOCGMAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x5E22450", Offset = "0x5E21250", VA = "0x185E22450")]
	private void BAFFDLKKEHD(NativeArray<Entity> MJLHCFFNENL, EntityCommandBuffer LLLOCGMAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x5E22620", Offset = "0x5E21420", VA = "0x185E22620")]
	private void DCKGDFKIDCJ(IDDKLJPFHCL ENGNHJHEIAM, string ODENANPFPNO, EntityCommandBuffer LLLOCGMAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x5E224F0", Offset = "0x5E212F0", VA = "0x185E224F0")]
	private void DCKGDFKIDCJ(NativeListAsync<Entity> EPJDOGLKNED, string ODENANPFPNO, EntityCommandBuffer LLLOCGMAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x5E22A90", Offset = "0x5E21890", VA = "0x185E22A90")]
	private void LHKAGIGFHNJ(IDDKLJPFHCL ENGNHJHEIAM, string ODENANPFPNO, EntityCommandBuffer LLLOCGMAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x5E22960", Offset = "0x5E21760", VA = "0x185E22960")]
	private void LHKAGIGFHNJ(NativeListAsync<Entity> EPJDOGLKNED, string ODENANPFPNO, EntityCommandBuffer LLLOCGMAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x5E22850", Offset = "0x5E21650", VA = "0x185E22850")]
	private bool HAIFLGMAECG()
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
	[CompilerGenerated]
	public class PhysicsSceneAddCollidersSystem : DBMABBOGEPD, ENEHADLKBBF
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
			[Cpp2IlInjected.Address(RVA = "0x5E24310", Offset = "0x5E23110", VA = "0x185E24310")]
			private void IOJGJCNCGIC(Entity e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x5E24260", Offset = "0x5E23060", VA = "0x185E24260", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private GLCCDNGIEHA ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private AEPPNFHDEIC colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private EntityQuery PhysicsSceneAddCollidersSystem_Query;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x5E24600", Offset = "0x5E23400", VA = "0x185E24600", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x5E24200", Offset = "0x5E23000", VA = "0x185E24200", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x5E24660", Offset = "0x5E23460", VA = "0x185E24660", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x5E24110", Offset = "0x5E22F10", VA = "0x185E24110")]
		private void DFLLAAHOEGF(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x5E24430", Offset = "0x5E23230", VA = "0x185E24430", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PhysicsSceneAddCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[MDNKGKCJEFA(LJHGMNIEOPD.OMRoom)]
[MPJBDEDKJDC]
public class MAJICHDFKMF : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private AEPPNFHDEIC GNHKLJELDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private PAPIHHEIJJK GAKKCIMPKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DE00", Offset = "0x5E1CC00", VA = "0x185E1DE00", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DE70", Offset = "0x5E1CC70", VA = "0x185E1DE70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DF20", Offset = "0x5E1CD20", VA = "0x185E1DF20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067F")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public MAJICHDFKMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public struct CKNHINLFPPF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	public HBHNGGLABBL OFGGCMDABFP;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00")]
	public static CKNHINLFPPF KFCNDMGKJHB([In] HBHNGGLABBL GBGGKBHPFIN)
	{
		return default(CKNHINLFPPF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0xAADA00", Offset = "0xAAC800", VA = "0x180AADA00")]
	public static HBHNGGLABBL KFCNDMGKJHB([In] CKNHINLFPPF KCKDJANICKN)
	{
		return default(HBHNGGLABBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
[AlwaysUpdateSystem]
public class GLCCDNGIEHA : HHGLAFOEFFN
{
	[Cpp2IlInjected.Token(Token = "0x6000682")]
	[Cpp2IlInjected.Address(RVA = "0x5E16BC0", Offset = "0x5E159C0", VA = "0x185E16BC0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000683")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public GLCCDNGIEHA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
	[AlwaysUpdateSystem]
	public class PhysicsSceneRemoveCollidersSystem : DBMABBOGEPD, ENEHADLKBBF
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
			public ComponentTypeHandle<CKNHINLFPPF> __chTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x5E24A10", Offset = "0x5E23810", VA = "0x185E24A10")]
			private void IOJGJCNCGIC(Entity e, [In] CKNHINLFPPF ch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x5E248F0", Offset = "0x5E236F0", VA = "0x185E248F0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private GLCCDNGIEHA ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private AEPPNFHDEIC colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private EntityQuery PhysicsSceneRemoveCollidersSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private ComponentTypeHandle<CKNHINLFPPF> __RecRoom_ObjectModel_Systems_PhysicsSceneColliderHandleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x5E24CD0", Offset = "0x5E23AD0", VA = "0x185E24CD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x5E24890", Offset = "0x5E23690", VA = "0x185E24890", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x5E24D30", Offset = "0x5E23B30", VA = "0x185E24D30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x5E24760", Offset = "0x5E23560", VA = "0x185E24760")]
		private void CHJCBMHLEOP(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x5E24AC0", Offset = "0x5E238C0", VA = "0x185E24AC0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PhysicsSceneRemoveCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public class GKGBPONMCNN : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	private struct MCJBKKNBGOI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public GENLCCCIOIL FGGAOAAIACJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public NativeParallelHashSet<Entity> DDIFFODKOKJ;

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E390", Offset = "0x5E1D190", VA = "0x185E1E390")]
		public MCJBKKNBGOI(int LCFOKPAENOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E320", Offset = "0x5E1D120", VA = "0x185E1E320", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[BurstCompile]
	private struct EPJGAJLADHD : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		[ReadOnly]
		public NativeArray<Entity> DDIFFODKOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		[ReadOnly]
		public ComponentDataFromEntity<FDAMELIEKPC> ILMIFIPNIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		[ReadOnly]
		public ComponentDataFromEntity<PEEBINOFCDG> DGKECCFCNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		[ReadOnly]
		public ComponentDataFromEntity<NAEDGOKFECF> MGODGLKJHOK;

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x5E138A0", Offset = "0x5E126A0", VA = "0x185E138A0", Slot = "4")]
		public void Execute(int OCMJNDDMDAL, TransformAccess ILMBKONFEEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[BurstCompile]
	private struct HPAKMFAOKOK : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		[ReadOnly]
		public NativeArray<Entity> DDIFFODKOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		[ReadOnly]
		public ComponentDataFromEntity<FDAMELIEKPC> ILMIFIPNIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		[ReadOnly]
		public ComponentDataFromEntity<NAEDGOKFECF> MGODGLKJHOK;

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x5E18920", Offset = "0x5E17720", VA = "0x185E18920", Slot = "4")]
		public void Execute(int OCMJNDDMDAL, TransformAccess ILMBKONFEEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private AEPPNFHDEIC GNHKLJELDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private EntityQuery NGMIBAIBGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private EntityQuery BPDGDNEGLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private EntityQuery OAHCBLIANLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	private EntityQuery LAGLBONMJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	private EntityQuery DLGJMDMPMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private JobHandle PNCPIPGBNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private MCJBKKNBGOI ALBHMAEEOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private MCJBKKNBGOI AKHOJOGKEKI;

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x5E15960", Offset = "0x5E14760", VA = "0x185E15960", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x5E16020", Offset = "0x5E14E20", VA = "0x185E16020", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x5E16300", Offset = "0x5E15100", VA = "0x185E16300", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x5E16310", Offset = "0x5E15110", VA = "0x185E16310", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x5E156C0", Offset = "0x5E144C0", VA = "0x185E156C0")]
	private void DFFAFHNFLLC(EntityQuery GJGJMLNNIOK, [Out] (NativeArrayAsync<CKNHINLFPPF> handles, NativeArrayAsync<KCDEJHDGIAK> bounds) LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x5E15470", Offset = "0x5E14270", VA = "0x185E15470")]
	private void DDJJIIOEIOL((NativeArrayAsync<CKNHINLFPPF> handles, NativeArrayAsync<KCDEJHDGIAK> bounds) LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x5E159C0", Offset = "0x5E147C0", VA = "0x185E159C0")]
	private void KAEKJJNJHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x5E15AC0", Offset = "0x5E148C0", VA = "0x185E15AC0")]
	private void KEALHGFFOPO(EntityQuery GJGJMLNNIOK, [Out] (NativeArrayAsync<Entity> entities, NativeArrayAsync<CKNHINLFPPF> handles) LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x5E15D60", Offset = "0x5E14B60", VA = "0x185E15D60")]
	private void OCKAMEMKBJF((NativeArrayAsync<Entity> entities, NativeArrayAsync<CKNHINLFPPF> handles) LMCJHCIOIIP, MCJBKKNBGOI ADJNHCLNKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x5E15C00", Offset = "0x5E14A00", VA = "0x185E15C00")]
	private JobHandle LJDDJGDKIEJ(MCJBKKNBGOI ADJNHCLNKGJ, ComponentDataFromEntity<FDAMELIEKPC> ILMIFIPNIEL, ComponentDataFromEntity<NAEDGOKFECF> MGODGLKJHOK, ComponentDataFromEntity<PEEBINOFCDG> DGKECCFCNMD)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	[Cpp2IlInjected.Address(RVA = "0x5E15800", Offset = "0x5E14600", VA = "0x185E15800")]
	private JobHandle EEIBGNBMKFO(MCJBKKNBGOI ADJNHCLNKGJ, ComponentDataFromEntity<FDAMELIEKPC> ILMIFIPNIEL, ComponentDataFromEntity<NAEDGOKFECF> MGODGLKJHOK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public GKGBPONMCNN()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010E")]
public struct HACOGBNGGIO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[MPJBDEDKJDC]
public class KOODOGCAAIH : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	[BurstCompile]
	private struct NIOLHFCICIE : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		[ReadOnly]
		public NativeArray<Entity> MGEDAHLCBHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		[ReadOnly]
		public ComponentDataFromEntity<MDLBCMGPBBP> BDFCJPOJANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		[ReadOnly]
		public ComponentDataFromEntity<KCDEJHDGIAK> EEONKKLKGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		[ReadOnly]
		public EntityExistenceLookupByEntity DOAPJAEFIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		[WriteOnly]
		public NativeParallelHashSet<Entity>.ParallelWriter HEMENDODKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter HLCDCDIGBJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter IEGCEAGGEFI;

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FB00", Offset = "0x5E1E900", VA = "0x185E1FB00", Slot = "4")]
		public void Execute(int OCMJNDDMDAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[BurstCompile]
	private struct EOFGEIMPJBO : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		[ReadOnly]
		public NativeArray<Entity> CEPNOLNADOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> NDMHNAMFDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		[ReadOnly]
		public ComponentDataFromEntity<LNMINBHKCKD> ODLBCDIBMPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		[ReadOnly]
		public ComponentDataFromEntity<OKDPLEMLFKK> JJHBANBIOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		[NativeDisableContainerSafetyRestriction]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<KCDEJHDGIAK> HOPBMICJLKB;

		[Cpp2IlInjected.Token(Token = "0x60006AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E13620", Offset = "0x5E12420", VA = "0x185E13620", Slot = "4")]
		public void Execute(int OCMJNDDMDAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private EntityQuery NOBCLKDBIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000367")]
	private EntityQuery LNKMNLBOHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private EntityQuery HGAGMGICHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private EntityQuery AELGACPJNEG;

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D520", Offset = "0x5E1C320", VA = "0x185E1D520", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D750", Offset = "0x5E1C550", VA = "0x185E1D750", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C790", Offset = "0x5E1B590", VA = "0x185E1C790")]
	private JobHandle BAMBLJCJMJC(NativeArrayAsync<Entity> OBEMKDLNKLE, int JGMNJBPPKGP, JobHandle EJGMMMMHMMK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C870", Offset = "0x5E1B670", VA = "0x185E1C870")]
	private JobHandle BAMBLJCJMJC(NativeArray<Entity> CLDGADPMADG, int JGMNJBPPKGP, [Optional] JobHandle EJGMMMMHMMK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CDE0", Offset = "0x5E1BBE0", VA = "0x185E1CDE0")]
	private (NativeListAsync<Entity>, NativeListAsync<Entity>) JCOONPAEEOE(NativeArrayAsync<Entity> KABIIFBODMG)
	{
		return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CA80", Offset = "0x5E1B880", VA = "0x185E1CA80")]
	private void BKHGGIDHOCA([Out] NativeArray<Entity> DDIFFODKOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D240", Offset = "0x5E1C040", VA = "0x185E1D240")]
	private void MMGIMMJIPDP(NativeList<Entity> DDIFFODKOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D2D0", Offset = "0x5E1C0D0", VA = "0x185E1D2D0")]
	private void MMGIMMJIPDP(NativeArray<Entity> DDIFFODKOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D3B0", Offset = "0x5E1C1B0", VA = "0x185E1D3B0")]
	private void OMMOCHJLHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void AOMMDJBKFFN(int NKNIHLDIBGI, int JPIGCDBNKKC, int AIBGCFFEECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CB00", Offset = "0x5E1B900", VA = "0x185E1CB00")]
	private static KCDEJHDGIAK ICJNLNOMIBK(NativeArray<Entity> HHFNBCBGEHD, ComponentDataFromEntity<LNMINBHKCKD> ODLBCDIBMPN, ComponentDataFromEntity<OKDPLEMLFKK> JJHBANBIOFG)
	{
		return default(KCDEJHDGIAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public KOODOGCAAIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
[MPJBDEDKJDC]
public class CJBMGBDAIKK : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000376")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x4000377")]
	private static readonly HICMFDICNOL INKHENECNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	[PDOCKCLGMBB]
	private CCAABBKKMFL MIFGFMNKAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	[PDOCKCLGMBB]
	private GNIFDDKOOBH DLKOKMHJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	[PDOCKCLGMBB]
	private ANNAAAPLMJK LJEKNAPCIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	private EntityQuery NOEANDDFENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400037C")]
	private EntityQuery OMKDCCJJKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400037D")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E0E430", Offset = "0x5E0D230", VA = "0x185E0E430", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E0E330", Offset = "0x5E0D130", VA = "0x185E0E330")]
	public bool BIFJIAPGGJG(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E0E6D0", Offset = "0x5E0D4D0", VA = "0x185E0E6D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E0E410", Offset = "0x5E0D210", VA = "0x185E0E410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0xF08B90", Offset = "0xF07990", VA = "0x180F08B90", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E0E7C0", Offset = "0x5E0D5C0", VA = "0x185E0E7C0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E0E410", Offset = "0x5E0D210", VA = "0x185E0E410")]
	private void FDBAHIDDJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E0E4C0", Offset = "0x5E0D2C0", VA = "0x185E0E4C0")]
	private void JAEFGGIFMFE(EntityQuery GJGJMLNNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E0E7E0", Offset = "0x5E0D5E0", VA = "0x185E0E7E0")]
	private void PIBOBFKIEOO(NativeArray<Entity> DDIFFODKOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public CJBMGBDAIKK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000113")]
internal struct GNJFHEBGAOI : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
	[CompilerGenerated]
	internal class CopyOwnerToEntitySystem : DBMABBOGEPD, ENEHADLKBBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000115")]
		private struct CopyOwnerToEntitySystem_RemoveDisembodied_Job
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public CopyOwnerToEntitySystem __this;

			[Cpp2IlInjected.Token(Token = "0x60006C9")]
			[Cpp2IlInjected.Address(RVA = "0x5E11130", Offset = "0x5E0FF30", VA = "0x185E11130")]
			public void OKGBGOHBAKN(EntityQuery query)
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
			[Cpp2IlInjected.Address(RVA = "0x5E0FDA0", Offset = "0x5E0EBA0", VA = "0x185E0FDA0")]
			public void OKGBGOHBAKN(EntityQuery query)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		private CCAABBKKMFL objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private IAOACMBPLEE dependencies;

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
		private ComponentTypeHandle<HEBJDKCKFEA> __RecRoom_Components_PhotonOwnerData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private ComponentTypeHandle<IFBFLGEFADP> __RecRoom_Components_PhotonOwnerWatcherData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E10280", Offset = "0x5E0F080", VA = "0x185E10280", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E10EC0", Offset = "0x5E0FCC0", VA = "0x185E10EC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E11060", Offset = "0x5E0FE60", VA = "0x185E11060", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E10F90", Offset = "0x5E0FD90", VA = "0x185E10F90", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E10620", Offset = "0x5E0F420", VA = "0x185E10620")]
		private void ONHJBJPKEJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E10110", Offset = "0x5E0EF10", VA = "0x185E10110")]
		private void HLICEKKKDKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E102F0", Offset = "0x5E0F0F0", VA = "0x185E102F0")]
		private void JOBBDLAELDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E103B0", Offset = "0x5E0F1B0", VA = "0x185E103B0")]
		private void LLPCGFHNAPM(Entity e, [In] IFBFLGEFADP watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E10040", Offset = "0x5E0EE40", VA = "0x185E10040")]
		private void DCDFEJKHKLO(EPCANLGBBON localId, int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E0FCE0", Offset = "0x5E0EAE0", VA = "0x185E0FCE0")]
		private void AMHACCMHPGM(Entity e, [In] HEBJDKCKFEA _, [In] IFBFLGEFADP watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x5E101D0", Offset = "0x5E0EFD0", VA = "0x185E101D0")]
		private void INCCMBHKLPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x5E0FCE0", Offset = "0x5E0EAE0", VA = "0x185E0FCE0")]
		private void BIGOHDEBEFF(Entity e, [In] HEBJDKCKFEA _, [In] IFBFLGEFADP watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E0FCF0", Offset = "0x5E0EAF0", VA = "0x185E0FCF0")]
		private void CIACINONPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E10B00", Offset = "0x5E0F900", VA = "0x185E10B00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public CopyOwnerToEntitySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E0FCE0", Offset = "0x5E0EAE0", VA = "0x185E0FCE0")]
		[CompilerGenerated]
		private void IKCEEMGEJGC(Entity e, [In] HEBJDKCKFEA _, [In] IFBFLGEFADP watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E0FCE0", Offset = "0x5E0EAE0", VA = "0x185E0FCE0")]
		[CompilerGenerated]
		private void INDEFMMOAHA(Entity e, [In] HEBJDKCKFEA _, [In] IFBFLGEFADP watcherData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal class NBDPFDCIICI : DBMABBOGEPD, ENEHADLKBBF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private struct GGCIEBLOKKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public NativeParallelHashMap<Entity, int> modifiedOwners;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public ComponentDataFromEntity<HEBJDKCKFEA> ownershipDataRO;
	}

	[Cpp2IlInjected.Token(Token = "0x400038A")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400038B")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400038C")]
	private IAOACMBPLEE GENEKCHGPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400038D")]
	private GCMLJOOJHLC HKDKCBJGGAA;

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E1ED50", Offset = "0x5E1DB50", VA = "0x185E1ED50", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F400", Offset = "0x5E1E200", VA = "0x185E1F400", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F4E0", Offset = "0x5E1E2E0", VA = "0x185E1F4E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EDC0", Offset = "0x5E1DBC0", VA = "0x185E1EDC0")]
	private void MPKGPIHJGKD(NativeArray<Entity> DDIFFODKOKJ, NativeParallelHashMap<Entity, int> BABDMABPLPK, ComponentDataFromEntity<HEBJDKCKFEA> BECKNIFBDII, BufferFromEntity<ChildrenData> FIPOIJIIDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public NBDPFDCIICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E1ECC0", Offset = "0x5E1DAC0", VA = "0x185E1ECC0")]
	[CompilerGenerated]
	internal static int EGPMFJHOKDC(Entity HHHGBIJCKBC, GGCIEBLOKKG P_1)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
[AlwaysUpdateSystem]
public class ICKBBNHBGLM : DBMABBOGEPD, ENEHADLKBBF, EPBKMCPBINK
{
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class FFPPFPDKPKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public EPCANLGBBON localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public CEKEAEGJOJK collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		public bool collidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		public BPEBBLFKHME containerFlags;

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
		public ICKBBNHBGLM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public FFPPFPDKPKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E13C10", Offset = "0x5E12A10", VA = "0x185E13C10")]
		internal void HCCCIBDCDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E13D10", Offset = "0x5E12B10", VA = "0x185E13D10")]
		internal void IFDOMNBNADA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E13AF0", Offset = "0x5E128F0", VA = "0x185E13AF0")]
		internal void EHGAOKKJGHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	[PDOCKCLGMBB]
	private NEGNBENACNL MDAHCKBLFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	[PDOCKCLGMBB]
	private CIBALBEFCIK ENAGKCDJIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	[PDOCKCLGMBB]
	private KDAEPEHHCFM PPDBKHFGBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000395")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000396")]
	public ComponentTypeHandle<BPEBBLFKHME> NLBJOPHBKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	public ComponentTypeHandle<DKEIMJFADKA> AKHICAEBGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	public ComponentTypeHandle<MOMDAFKMLNP> MIHBDOKHMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	public ComponentTypeHandle<LIELCEKBGND> HIODHLDGFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public ComponentTypeHandle<HNEIOIKHEOK> MFLIPLLOPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	public DynamicComponentTypeHandle ACLFJGJEKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public EntityTypeHandle BNBPCPHFCBF;

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E18F40", Offset = "0x5E17D40", VA = "0x185E18F40", Slot = "15")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E19010", Offset = "0x5E17E10", VA = "0x185E19010", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E190C0", Offset = "0x5E17EC0", VA = "0x185E190C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E18A80", Offset = "0x5E17880", VA = "0x185E18A80")]
	private void GGLBJMBGLJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E18C40", Offset = "0x5E17A40", VA = "0x185E18C40")]
	private bool HAIFLGMAECG([Out] int FMPANPJBLEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public ICKBBNHBGLM()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[AlwaysUpdateSystem]
	[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
	[CompilerGenerated]
	public class UpdateSplineGameCollidersSystem : DBMABBOGEPD, ENEHADLKBBF
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
			public ComponentDataFromEntity<FHFFBJLOOCP> splineComponentAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			[ReadOnly]
			public ComponentTypeHandle<DKEIMJFADKA> __collisionModeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public BufferTypeHandle<ChildrenData> __childrenTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x5E251F0", Offset = "0x5E23FF0", VA = "0x185E251F0")]
			private void IOJGJCNCGIC([In] DKEIMJFADKA collisionMode, DynamicBuffer<ChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0x5E25080", Offset = "0x5E23E80", VA = "0x185E25080", Slot = "4")]
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
			public ComponentDataFromEntity<DKEIMJFADKA> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0x5E24FA0", Offset = "0x5E23DA0", VA = "0x185E24FA0")]
			private void IOJGJCNCGIC(Entity entity, [In] ParentData parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0x5E24E80", Offset = "0x5E23C80", VA = "0x185E24E80", Slot = "4")]
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
			public ComponentDataFromEntity<DKEIMJFADKA> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x5E25690", Offset = "0x5E24490", VA = "0x185E25690")]
			private void IOJGJCNCGIC(Entity entity, [In] ParentData parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x5E25570", Offset = "0x5E24370", VA = "0x185E25570", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E299B0", Offset = "0x5E287B0", VA = "0x185E299B0")]
			private void IOJGJCNCGIC(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x5E29900", Offset = "0x5E28700", VA = "0x185E29900", Slot = "4")]
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
			public ComponentTypeHandle<MDLBCMGPBBP> splinePointParentHandle;

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
			[Cpp2IlInjected.Address(RVA = "0x5E25770", Offset = "0x5E24570", VA = "0x185E25770")]
			private void IOJGJCNCGIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x5E25760", Offset = "0x5E24560", VA = "0x185E25760", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E25CC0", Offset = "0x5E24AC0", VA = "0x185E25CC0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void JDDJFCNHKOI(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private IHIHFIGNGCB splineCollisionService;

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
		private ComponentTypeHandle<DKEIMJFADKA> __RecRoom_Components_ContainerCollisionModeData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E29520", Offset = "0x5E28320", VA = "0x185E29520", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A4C0", Offset = "0x5E292C0", VA = "0x185E2A4C0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A6A0", Offset = "0x5E294A0", VA = "0x185E2A6A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E28E60", Offset = "0x5E27C60", VA = "0x185E28E60")]
		private void DCGLKFOBLMG(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E29260", Offset = "0x5E28060", VA = "0x185E29260")]
		private void IJHDOMGCLAL(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x5E29660", Offset = "0x5E28460", VA = "0x185E29660")]
		private void KFLCKCBJPJI(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E29810", Offset = "0x5E28610", VA = "0x185E29810")]
		private void LODOLFKBBGL(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E29070", Offset = "0x5E27E70", VA = "0x185E29070")]
		private void HAAEPCNFFKF(EntityCommandBuffer ecb, ComponentDataFromEntity<FHFFBJLOOCP> splineComponentAccess, ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E28D00", Offset = "0x5E27B00", VA = "0x185E28D00")]
		private void CJKKNKAKPIA(EntityCommandBuffer ecb, ComponentDataFromEntity<DKEIMJFADKA> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E29A60", Offset = "0x5E28860", VA = "0x185E29A60")]
		private void MHILNMPGIDB(EntityCommandBuffer ecb, ComponentDataFromEntity<DKEIMJFADKA> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E29570", Offset = "0x5E28370", VA = "0x185E29570")]
		private void JJIANBEGEBM(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E29BC0", Offset = "0x5E289C0", VA = "0x185E29BC0")]
		private void NBGJACFHPOO(ComponentTypeHandle<MDLBCMGPBBP> splinePointParentHandle, EntityTypeHandle entityHandle, ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess, EntityQueryInJob splinePointEditedQueryInJob, EntityQueryInJob splineStructureChangedQueryInJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E29D00", Offset = "0x5E28B00", VA = "0x185E29D00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public UpdateSplineGameCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
[MPJBDEDKJDC]
public class OMCNFNLJAFO : DBMABBOGEPD, EPBKMCPBINK, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[BurstCompile]
	private struct MKLKBAOBHOL : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		[ReadOnly]
		public EntityTypeHandle MAEOIHKFLDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		[ReadOnly]
		public ComponentTypeHandle<FDAMELIEKPC> DOHOEDPOCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		[WriteOnly]
		public NativeList<FCFCCPMBGOI>.ParallelWriter BAHLLPFGOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public ComponentTypeHandle<FCDCEIPDNLI> FMEBBEOACND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public float3 PABBJIBBIGE;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private static readonly float4x2 OAMDILPBICM;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private static readonly float4x2 CEJHLBCPOKP;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private static readonly int4x2 MPAMDDKIEGH;

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E760", Offset = "0x5E1D560", VA = "0x185E1E760", Slot = "4")]
		public void Execute(ArchetypeChunk PKPEFKLAONK, int NJOIONKFGCF, int DOJOFDMCBIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003CC")]
	private static HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003CD")]
	private EntityQuery KMPALPGFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private EntityQuery PJOPFMMKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	private double BHLFDNIBJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	private GCMLJOOJHLC IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	private LEDNNBIOKKJ IIHEBLHKNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private FNOCCIFKHLE MJDGLHMPNEP;

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E20390", Offset = "0x5E1F190", VA = "0x185E20390", Slot = "14")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E203A0", Offset = "0x5E1F1A0", VA = "0x185E203A0", Slot = "15")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E20430", Offset = "0x5E1F230", VA = "0x185E20430", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E205A0", Offset = "0x5E1F3A0", VA = "0x185E205A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E20080", Offset = "0x5E1EE80", VA = "0x185E20080")]
	private bool EKGPLLDHLEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E200F0", Offset = "0x5E1EEF0", VA = "0x185E200F0")]
	private void IENOBHEAGNM(EntityQuery GJGJMLNNIOK, float3 EFEIFDIIBED, string MEBBBIMBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public OMCNFNLJAFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public struct FCFCCPMBGOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003DB")]
	public Entity HHHGBIJCKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003DC")]
	public ECMHEOBCCNJ ICMOHCKEJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public ECMHEOBCCNJ LMBCAMGCODH;
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public class GPBEGMMPFOL : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	private LEDNNBIOKKJ IIHEBLHKNLN;

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x5E16BF0", Offset = "0x5E159F0", VA = "0x185E16BF0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x5E16C40", Offset = "0x5E15A40", VA = "0x185E16C40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public GPBEGMMPFOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public class MKLFMKHKLCC : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E430", Offset = "0x5E1D230", VA = "0x185E1E430", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E4F0", Offset = "0x5E1D2F0", VA = "0x185E1E4F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public MKLFMKHKLCC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
	public class UpdateInertialPropertiesSystem : DBMABBOGEPD, ENEHADLKBBF
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
				[Cpp2IlInjected.Address(RVA = "0x5E25D10", Offset = "0x5E24B10", VA = "0x185E25D10")]
				[BurstDiscard]
				private static void BDGGAJCACMB(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000718")]
				[Cpp2IlInjected.Address(RVA = "0x5E26010", Offset = "0x5E24E10", VA = "0x185E26010")]
				private static IntPtr INKJJMNPBJM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000719")]
				[Cpp2IlInjected.Address(RVA = "0x5E26170", Offset = "0x5E24F70", VA = "0x185E26170")]
				public static void NPHJPMPOKKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600071A")]
				[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
				public static void HCKCHEHGBKI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600071C")]
				[Cpp2IlInjected.Address(RVA = "0x5E25E40", Offset = "0x5E24C40", VA = "0x185E25E40")]
				public static void FKGDFLCAOJM(IntPtr jobPtr)
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
			public ComponentTypeHandle<DCDOGDEOKDP> rbexRootTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			[ReadOnly]
			public ComponentDataFromEntity<BGPOLLLCAGL> rbexIsKinematicRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x5E26DD0", Offset = "0x5E25BD0", VA = "0x185E26DD0")]
			private void IOJGJCNCGIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x5E26DC0", Offset = "0x5E25BC0", VA = "0x185E26DC0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x5E27420", Offset = "0x5E26220", VA = "0x185E27420")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void JDDJFCNHKOI(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x5E27630", Offset = "0x5E26430", VA = "0x185E27630")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void NDCLMIELBLG(IntPtr jobPtr)
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
		private NEGNBENACNL rbexServiceCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private CCAABBKKMFL objects;

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x5E26CB0", Offset = "0x5E25AB0", VA = "0x185E26CB0", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x5E27770", Offset = "0x5E26570", VA = "0x185E27770", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x5E27B10", Offset = "0x5E26910", VA = "0x185E27B10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x5E26500", Offset = "0x5E25300", VA = "0x185E26500")]
		protected void CCFHKDJKOEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x5E26D20", Offset = "0x5E25B20", VA = "0x185E26D20")]
		protected void LOBBEIFIKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x5E26880", Offset = "0x5E25680", VA = "0x185E26880")]
		private bool DJCPJJNCAHC(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, [Out] NativeList<Entity> results)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x5E26220", Offset = "0x5E25020", VA = "0x185E26220")]
		private void BFOKMDOKLPH(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, ChunkFilterAnyOf5ComponentsChanged changeFilter, int maxEntityCount, NativeList<Entity> changedRoots, EntityExistenceLookupByEntity entityExists, EntityTypeHandle entityTypeRO, ComponentTypeHandle<DCDOGDEOKDP> rbexRootTypeRO, ComponentDataFromEntity<BGPOLLLCAGL> rbexIsKinematicRO, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x5E27680", Offset = "0x5E26480", VA = "0x185E27680", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public UpdateInertialPropertiesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x5E26840", Offset = "0x5E25640", VA = "0x185E26840")]
		public static void COOLPMHMCKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	public class UpdateMassOfShapesSystem : DBMABBOGEPD
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
			public ComponentDataFromEntity<EHOKBACLKBI> worldDeformableScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			[ReadOnly]
			public ComponentDataFromEntity<NAEDGOKFECF> worldUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			[ReadOnly]
			public ComponentDataFromEntity<EIPOINIIFNE> physicsMaterialsRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			[ReadOnly]
			public ComponentDataFromEntity<FINJEIJKLHL> primitiveShapesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			[ReadOnly]
			public ComponentDataFromEntity<GKEHOBJBFLL> localUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public ComponentDataFromEntity<OIEPOLDIGIP> massesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public ComponentDataFromEntity<FJJNPEHKKCI> centerOfMassesRW;

			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x5E27DA0", Offset = "0x5E26BA0", VA = "0x185E27DA0")]
			private void IOJGJCNCGIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x5E27D90", Offset = "0x5E26B90", VA = "0x185E27D90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private EntityQuery query;

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x5E28500", Offset = "0x5E27300", VA = "0x185E28500", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x5E28640", Offset = "0x5E27440", VA = "0x185E28640", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x5E281F0", Offset = "0x5E26FF0", VA = "0x185E281F0")]
		private void NDFOMGGBCLF(NativeList<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x5E27BC0", Offset = "0x5E269C0", VA = "0x185E27BC0")]
		private JobHandle FNHFDKDEJOL(NativeList<Entity> entities, ComponentDataFromEntity<EHOKBACLKBI> worldDeformableScalesRO, ComponentDataFromEntity<NAEDGOKFECF> worldUniformScalesRO, ComponentDataFromEntity<EIPOINIIFNE> physicsMaterialsRO, ComponentDataFromEntity<FINJEIJKLHL> primitiveShapesRO, ComponentDataFromEntity<GKEHOBJBFLL> localUniformScalesRO, ComponentDataFromEntity<OIEPOLDIGIP> massesRW, ComponentDataFromEntity<FJJNPEHKKCI> centerOfMassesRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public UpdateMassOfShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public class BNLBAIAFDNK : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[BurstCompile]
	private struct JNBFGLOGBCO : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		[ReadOnly]
		public int KGIPLFOGFFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		[ReadOnly]
		public EntityQueryInJob DALFPFOOGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		[ReadOnly]
		public EntityQueryInJob BICENAACHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		[ReadOnly]
		public ChunkFilterAnyOf3ComponentsChanged KDEJABGKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[ReadOnly]
		public EntityTypeHandle BNBPCPHFCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		[ReadOnly]
		public ComponentDataFromEntity<EIPOINIIFNE> IALLDEBKGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		[ReadOnly]
		public ComponentDataFromEntity<NAEDGOKFECF> GEDLEICDECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> JBCIOAAPMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		[ReadOnly]
		public ComponentTypeHandle<MDLBCMGPBBP> INDOCBOHDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		[ReadOnly]
		public ComponentDataFromEntity<LNMINBHKCKD> DOJFGDGDNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		[ReadOnly]
		public ComponentDataFromEntity<OKDPLEMLFKK> JJHBANBIOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		[WriteOnly]
		public ComponentDataFromEntity<OIEPOLDIGIP> PGKOHDIINMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		[WriteOnly]
		public ComponentDataFromEntity<FJJNPEHKKCI> DPOMAGHLCBD;

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B590", Offset = "0x5E1A390", VA = "0x185E1B590", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1BC40", Offset = "0x5E1AA40", VA = "0x185E1BC40")]
		private void KMFGNHOBJJM(NativeList<Entity> MJJCNMCHEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B750", Offset = "0x5E1A550", VA = "0x185E1B750")]
		private void HLNBFGMMCKE(Entity DNGAALMGOEC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private EntityQuery BDKFJIMIMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private EntityQuery ABECNBIALOL;

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x5E0DD30", Offset = "0x5E0CB30", VA = "0x185E0DD30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x5E0DF10", Offset = "0x5E0CD10", VA = "0x185E0DF10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x218E740", Offset = "0x218D540", VA = "0x18218E740")]
	private bool LOJCLMPHFKJ<T>(T OAENDNKDOBL, [Out] int MIIGHHMMGIK) where T : struct, IChunkChangeFilter
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public BNLBAIAFDNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
[MPJBDEDKJDC]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public class EGLGAFIOKEB : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000411")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000412")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> IHNLLJBABBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000413")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> IHNHPKOLKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000414")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> NILNLALKELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000415")]
	private IEOGICFOKCI HOPPKIBMPGE;

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x5E11BF0", Offset = "0x5E109F0", VA = "0x185E11BF0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x5E12400", Offset = "0x5E11200", VA = "0x185E12400", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x5E11DD0", Offset = "0x5E10BD0", VA = "0x185E11DD0")]
	private void KDCFJIGMEME(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MJLHCFFNENL, EntityQueryDesc EMEONBCJPNG, bool ANDHNALLMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x5E11C40", Offset = "0x5E10A40", VA = "0x185E11C40")]
	private void KDCFJIGMEME(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> MJLHCFFNENL, EntityQueryDesc EMEONBCJPNG, bool ANDHNALLMFE, bool JIJAOBLIPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x5E12670", Offset = "0x5E11470", VA = "0x185E12670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x5E11F80", Offset = "0x5E10D80", VA = "0x185E11F80")]
	private void LEFEOLICJHK(EntityQuery GJGJMLNNIOK, bool PDBEFEPHJHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x5E11890", Offset = "0x5E10690", VA = "0x185E11890")]
	private void ICJODIDOAII(EntityQuery GJGJMLNNIOK, bool NPPKPKGNBNE, bool PDBEFEPHJHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x5E12190", Offset = "0x5E10F90", VA = "0x185E12190")]
	private void MKEAHHBPGCP(NativeArray<Entity> DDIFFODKOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x5E12970", Offset = "0x5E11770", VA = "0x185E12970")]
	private void PLEIMBPMEPB(NativeList<Entity> DDIFFODKOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x5E11AB0", Offset = "0x5E108B0", VA = "0x185E11AB0")]
	private void ILNOGCHFOFD(NativeArray<Entity> DDIFFODKOKJ, bool NPPKPKGNBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(RVA = "0x5E114A0", Offset = "0x5E102A0", VA = "0x185E114A0")]
	private NativeList<Entity> CKEOIDEKPPK(NativeArray<Entity> DDIFFODKOKJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x5E11460", Offset = "0x5E10260", VA = "0x185E11460")]
	private NativeList<Entity> CBHMELLCHEA(NativeArray<Entity> DDIFFODKOKJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x5E11F40", Offset = "0x5E10D40", VA = "0x185E11F40")]
	private NativeList<Entity> KFPKLGIBKKG(NativeArray<Entity> DDIFFODKOKJ)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x5E116B0", Offset = "0x5E104B0", VA = "0x185E116B0")]
	private NativeList<Entity> EIDPIMBIFFO(NativeArray<Entity> DDIFFODKOKJ, bool OMOKLIIAHAD)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x5E12B90", Offset = "0x5E11990", VA = "0x185E12B90")]
	public EGLGAFIOKEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public class ACPLILBKBKE : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000416")]
	private IEOGICFOKCI HOPPKIBMPGE;

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D210", Offset = "0x5E0C010", VA = "0x185E0D210", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D260", Offset = "0x5E0C060", VA = "0x185E0D260", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public ACPLILBKBKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
public class FGCMLIHGACH : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private CCAABBKKMFL MIFGFMNKAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private NEGNBENACNL IIKFOMOINJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private EntityQuery BLGOOIHKGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private EntityQuery AJHMJDLMOKM;

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x5E13E20", Offset = "0x5E12C20", VA = "0x185E13E20", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x5E13E90", Offset = "0x5E12C90", VA = "0x185E13E90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x5E13FA0", Offset = "0x5E12DA0", VA = "0x185E13FA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public FGCMLIHGACH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public class OMDFKKFPOAJ : LLHIKPBJIAL
{
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private static HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private EntityQuery GNOHBEEFBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private EntityQuery PEICCPNELPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private EntityQuery FFIIOFONJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private EntityQuery ECKILKOOAPD;

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x5E20BF0", Offset = "0x5E1F9F0", VA = "0x185E20BF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x5E20DD0", Offset = "0x5E1FBD0", VA = "0x185E20DD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x5E20A20", Offset = "0x5E1F820", VA = "0x185E20A20")]
	private void NGLCIILJPLP(EntityQuery GJGJMLNNIOK, bool KGNHAOBOCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x5E20850", Offset = "0x5E1F650", VA = "0x185E20850")]
	private void BAEFBADKHHF(EntityQuery GJGJMLNNIOK, bool KGNHAOBOCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public OMDFKKFPOAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
[AlwaysUpdateSystem]
public class KOAMHGFHAIK : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	[PDOCKCLGMBB]
	private KAFALIKLKOG KIGOEGBOPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	[PDOCKCLGMBB]
	private NEGNBENACNL MDAHCKBLFBB;

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C2C0", Offset = "0x5E1B0C0", VA = "0x185E1C2C0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C350", Offset = "0x5E1B150", VA = "0x185E1C350")]
	protected void MCOOFMBJLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C3D0", Offset = "0x5E1B1D0", VA = "0x185E1C3D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public KOAMHGFHAIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal class PAMBGEILLHE : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private GCMLJOOJHLC IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private EntityQuery CFIGLMOFIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private EntityQuery OOPLABCAPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private PAPIHHEIJJK BEEHCIODHCL;

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x5E21640", Offset = "0x5E20440", VA = "0x185E21640", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x5E218F0", Offset = "0x5E206F0", VA = "0x185E218F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x5E21A10", Offset = "0x5E20810", VA = "0x185E21A10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x5E20EE0", Offset = "0x5E1FCE0", VA = "0x185E20EE0")]
	private void CJKLCJDIGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x5E216B0", Offset = "0x5E204B0", VA = "0x185E216B0")]
	private void JPJBBDKHFCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x5E211C0", Offset = "0x5E1FFC0", VA = "0x185E211C0")]
	private void GAGDOAJLAAA(NativeArray<Entity> DDIFFODKOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x5E21030", Offset = "0x5E1FE30", VA = "0x185E21030")]
	private void DDIINNLMLDB(NativeArray<Entity> DDIFFODKOKJ, int MKGGDBDAAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x5E21530", Offset = "0x5E20330", VA = "0x185E21530")]
	private void IENOIOGJLIL(NativeArray<Entity> DDIFFODKOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(RVA = "0x5E21870", Offset = "0x5E20670", VA = "0x185E21870")]
	private void ONMCJNIDBLL(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000758")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void PIMOAKAFIGN(int IOPJNMNEAKH, Transform ILMBKONFEEP, Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000759")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public PAMBGEILLHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
internal static class JDMIDKBKCHE
{
	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1AD90", Offset = "0x5E19B90", VA = "0x185E1AD90")]
	public static bool DANHCGHEKJF(this SystemBase BBNGNPEAOHB, [Out] Entity HHHGBIJCKBC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal class BMIMHCGLCIA : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private EntityQuery LFIAKHIOCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private BHGAALGADLM GEAKPGBGEOP;

	[Cpp2IlInjected.Token(Token = "0x600075C")]
	[Cpp2IlInjected.Address(RVA = "0x5E0DB20", Offset = "0x5E0C920", VA = "0x185E0DB20", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x5E0DB70", Offset = "0x5E0C970", VA = "0x185E0DB70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x5E0DC30", Offset = "0x5E0CA30", VA = "0x185E0DC30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075F")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public BMIMHCGLCIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal class EJEHNKDAAFL : JPPIFOBDJNP<PCJKNKEOLIH>, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	private BEFNJLBOONF GCPBHOAHJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private EntityQuery CMEOIFEFBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private BKMELGCLBCN FJBBAPCHENE;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private Entity HPMINFGKGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x5E133A0", Offset = "0x5E121A0", VA = "0x185E133A0")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x5E13050", Offset = "0x5E11E50", VA = "0x185E13050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public EPCANLGBBON BCEEMGAFPDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x5E12F40", Offset = "0x5E11D40", VA = "0x185E12F40")]
		get
		{
			return default(EPCANLGBBON);
		}
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x5E13340", Offset = "0x5E12140", VA = "0x185E13340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000765")]
	[Cpp2IlInjected.Address(RVA = "0x5E13400", Offset = "0x5E12200", VA = "0x185E13400", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000766")]
	[Cpp2IlInjected.Address(RVA = "0x5E12FC0", Offset = "0x5E11DC0", VA = "0x185E12FC0", Slot = "15")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0x5E134B0", Offset = "0x5E122B0", VA = "0x185E134B0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000768")]
	[Cpp2IlInjected.Address(RVA = "0x5E12D80", Offset = "0x5E11B80", VA = "0x185E12D80", Slot = "14")]
	protected override void CHPDFLOLKMH(NativeArray<Entity> DDIFFODKOKJ, NativeArray<Entity> OOLDMIJKHHI, NativeArray<Entity> LMPOIFGBMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000769")]
	[Cpp2IlInjected.Address(RVA = "0x5E12CA0", Offset = "0x5E11AA0", VA = "0x185E12CA0")]
	private void CADPHALKBHB(NativeArray<Entity> DDIFFODKOKJ, NativeArray<Entity> LMPOIFGBMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x5E130B0", Offset = "0x5E11EB0", VA = "0x185E130B0")]
	private void JJDMPHEAHDF(Entity HHHGBIJCKBC, Entity DIFFABPOKED, Entity DLENBEFNLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0x224B310", Offset = "0x224A110", VA = "0x18224B310")]
	private bool HBHBLNKJFLH<T>([Out] T POACLGOFKAJ) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x224B210", Offset = "0x224A010", VA = "0x18224B210")]
	private void FKDIOPKPPCN<T>(T POACLGOFKAJ) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076D")]
	[Cpp2IlInjected.Address(RVA = "0x5E12EC0", Offset = "0x5E11CC0", VA = "0x185E12EC0")]
	public bool DMIAICDAKEI(EPCANLGBBON MPNNAPKLBDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600076E")]
	[Cpp2IlInjected.Address(RVA = "0x5E12C80", Offset = "0x5E11A80", VA = "0x185E12C80")]
	private static bool BIHIPEKPJLE(EPCANLGBBON IEDPABBGLNM, EPCANLGBBON LEFADFKHCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600076F")]
	[Cpp2IlInjected.Address(RVA = "0x5E135E0", Offset = "0x5E123E0", VA = "0x185E135E0")]
	public EJEHNKDAAFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal class BCJKKJEPCLE : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.Token(Token = "0x6000771")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D4F0", Offset = "0x5E0C2F0", VA = "0x185E0D4F0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000772")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D540", Offset = "0x5E0C340", VA = "0x185E0D540", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D610", Offset = "0x5E0C410", VA = "0x185E0D610", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D3B0", Offset = "0x5E0C1B0", VA = "0x185E0D3B0")]
	private NativeArray<Entity> GNMCMIJACFO(int NENAAIFMEME)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x5E0D280", Offset = "0x5E0C080", VA = "0x185E0D280")]
	private void DEDALOEDJIK(NativeArray<Entity> EEKMIKBKPCD, NativeArray<Entity> KDKNNCNCILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public BCJKKJEPCLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal class LMIBGFBJHOL : DBMABBOGEPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private EntityQuery FOCNJAJDAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private EntityQuery KCACFFAMNHJ;

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B410", Offset = "0x5E3A210", VA = "0x185E3B410", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B510", Offset = "0x5E3A310", VA = "0x185E3B510", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public LMIBGFBJHOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
internal static class AIPMOLHHHJH
{
	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x29BEC50", Offset = "0x29BDA50", VA = "0x1829BEC50")]
	public static NativeArray<T> MKHCMGJALEP<T>(NativeArray<Entity> DDIFFODKOKJ, EntityManager GMDAKDJOHKE) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D7C0", Offset = "0x5E2C5C0", VA = "0x185E2D7C0")]
	public static void IPJJGNOKOHN(EntityQuery GJGJMLNNIOK, EntityManager GMDAKDJOHKE, CCAABBKKMFL ACIEHBFKONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DA90", Offset = "0x5E2C890", VA = "0x185E2DA90")]
	public static void NHPHKGOAIEO(NativeArray<Entity> EEKMIKBKPCD, CCAABBKKMFL ACIEHBFKONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D950", Offset = "0x5E2C750", VA = "0x185E2D950")]
	public static void MPENKFNAAPP(NativeArray<Entity> EEKMIKBKPCD, CCAABBKKMFL ACIEHBFKONJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal class BMODMHAHNGM : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private LNMNHIICBIB FGGAOAAIACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private ANNAAAPLMJK NAMNFILNEBJ;

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x5E30730", Offset = "0x5E2F530", VA = "0x185E30730", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x5E30C50", Offset = "0x5E2FA50", VA = "0x185E30C50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x5E30D00", Offset = "0x5E2FB00", VA = "0x185E30D00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x5E30120", Offset = "0x5E2EF20", VA = "0x185E30120")]
	private void FHPBMAAIOMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F290", Offset = "0x5E2E090", VA = "0x185E2F290")]
	private void BGFKICLFLFK(NativeArray<Entity> EEKMIKBKPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000784")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F840", Offset = "0x5E2E640", VA = "0x185E2F840")]
	private void FDEHHODBMCO(NativeArray<Entity> DDIFFODKOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000785")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F3A0", Offset = "0x5E2E1A0", VA = "0x185E2F3A0")]
	private void EFJDFIPDABO(NativeArray<Entity> KDKNNCNCILI, NativeArray<RigidTransform> PPKFCCHEMKA, NativeArray<RigidTransform> IOJADENJEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000786")]
	[Cpp2IlInjected.Address(RVA = "0x5E307C0", Offset = "0x5E2F5C0", VA = "0x185E307C0")]
	private void MJGILBNPBOD(NativeArray<RigidTransform> IOJADENJEPI, NativeArray<Entity> KDKNNCNCILI, NativeList<Entity> BEMMNAGDEMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000787")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public BMODMHAHNGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal class IMAIHCIDBOP : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private EntityQuery LFIAKHIOCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private EntityQuery BPPAPEFOGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private HOEKJKFPHNL IFKIGJDABJA;

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0x5E379B0", Offset = "0x5E367B0", VA = "0x185E379B0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078A")]
	[Cpp2IlInjected.Address(RVA = "0x5E37A00", Offset = "0x5E36800", VA = "0x185E37A00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x5E37B60", Offset = "0x5E36960", VA = "0x185E37B60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x5E37940", Offset = "0x5E36740", VA = "0x185E37940")]
	private void ACIHCMFPLEN(EntityQuery GJGJMLNNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public IMAIHCIDBOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal class MMMCGELIPJK : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private EntityQuery NHBCKFLHNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private LOCNOIPHBCK JMDECJAJJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private BHGAALGADLM GEAKPGBGEOP;

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B630", Offset = "0x5E3A430", VA = "0x185E3B630", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B6C0", Offset = "0x5E3A4C0", VA = "0x185E3B6C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B770", Offset = "0x5E3A570", VA = "0x185E3B770", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public MMMCGELIPJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal class GDGDNNLDNON : JPPIFOBDJNP<FBDODGCKIDH>
{
	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x5E365D0", Offset = "0x5E353D0", VA = "0x185E365D0", Slot = "14")]
	protected override void CHPDFLOLKMH(NativeArray<Entity> DDIFFODKOKJ, NativeArray<Entity> OOLDMIJKHHI, NativeArray<Entity> LMPOIFGBMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x5E36730", Offset = "0x5E35530", VA = "0x185E36730")]
	private static void CHPDFLOLKMH(NativeArray<Entity> DDIFFODKOKJ, NativeArray<Entity> LMPOIFGBMBA, ComponentDataFromEntity<global::BNCEKKNHINK> GBPKCOAFOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x5E36800", Offset = "0x5E35600", VA = "0x185E36800")]
	public GDGDNNLDNON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal abstract class JPPIFOBDJNP<TPlayerTag> : DBMABBOGEPD where TPlayerTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery FFMJOBEJOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private EntityQuery HDFDNNJBKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private EntityQuery DFNOOLFICPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	private EntityQuery GJNDLMNKEDP;

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x3866E90", Offset = "0x3865C90", VA = "0x183866E90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x38670D0", Offset = "0x3865ED0", VA = "0x1838670D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x38670A0", Offset = "0x3865EA0", VA = "0x1838670A0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0x3866950", Offset = "0x3865750", VA = "0x183866950")]
	private void MKHKDDMFEMP(EntityQuery GJGJMLNNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079C")]
	[Cpp2IlInjected.Address(RVA = "0x38660C0", Offset = "0x3864EC0", VA = "0x1838660C0")]
	private void MGJDACLIFNC(EntityQuery GJGJMLNNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0x3865A40", Offset = "0x3864840", VA = "0x183865A40")]
	private void GJJFAPHFJOI(EntityQuery GJGJMLNNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract void CHPDFLOLKMH(NativeArray<Entity> DDIFFODKOKJ, NativeArray<Entity> OOLDMIJKHHI, NativeArray<Entity> LMPOIFGBMBA);

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	protected JPPIFOBDJNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct BLOLCOEHHPK : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public int FCFMLMDMJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public int MNNENJOIOME;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct OMANLLGKCEO : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public static class IJHPIFKNPCI
{
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly (ComponentType userTag, ComponentType stateTag, ComponentType componentTag)[] OOBALMCAGLM;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000143")]
internal struct AFKEBDKKINN : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000144")]
internal struct LHAHKHCNGAJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000145")]
public class CHDJJIMACAK : DBMABBOGEPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private EntityQuery MKNGONOJBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private ComponentTypes JPMNJGKAPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private NativeParallelHashSet<int> EPIHMANGDEO;

	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E30F80", Offset = "0x5E2FD80", VA = "0x185E30F80", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E31310", Offset = "0x5E30110", VA = "0x185E31310", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E31390", Offset = "0x5E30190", VA = "0x185E31390", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E30EE0", Offset = "0x5E2FCE0", VA = "0x185E30EE0")]
	public JobHandle HDAMPLINGCA(JobHandle EJGMMMMHMMK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public CHDJJIMACAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public struct IDOEAIHJCJE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private NativeArray<IAIFOJGGPJK> IADOMFGEKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private NativeArray<int> HJJCGBFGODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private NativeParallelHashMap<int, IAIFOJGGPJK> DACMEPFOPJJ;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public readonly int GMMOICEMMFL
	{
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x769310", Offset = "0x768110", VA = "0x180769310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public readonly int NLKPOFFOJDP
	{
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0xAE4E50", Offset = "0xAE3C50", VA = "0x180AE4E50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E37170", Offset = "0x5E35F70", VA = "0x185E37170")]
	public IDOEAIHJCJE(IReadOnlyCollection<KHNKJBOEAPI> NDFBKPCIBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E37000", Offset = "0x5E35E00", VA = "0x185E37000")]
	public readonly ECDAJHEINPN CNFPBIHNDCL(int NGICFBMMBFC)
	{
		return default(ECDAJHEINPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E370F0", Offset = "0x5E35EF0", VA = "0x185E370F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
[DefaultMember("Item")]
public readonly struct ECDAJHEINPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private readonly int NGICFBMMBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private readonly int FPHAJLKLNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	private readonly NativeArray<IAIFOJGGPJK>.ReadOnly NAFNNIMKNLM;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public int GFHGMKIJCDL
	{
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E33460", Offset = "0x5E32260", VA = "0x185E33460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public ENNIBPBCEGO CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E33390", Offset = "0x5E32190", VA = "0x185E33390")]
		get
		{
			return default(ENNIBPBCEGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public int ABICHDDOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x200C8C0", Offset = "0x200B6C0", VA = "0x18200C8C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public NativeArray<IAIFOJGGPJK>.ReadOnly ELOJPKIMNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x392C850", Offset = "0x392B650", VA = "0x18392C850")]
		get
		{
			return default(NativeArray<IAIFOJGGPJK>.ReadOnly);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E33490", Offset = "0x5E32290", VA = "0x185E33490")]
	public ECDAJHEINPN(int NGICFBMMBFC, int FPHAJLKLNGL, NativeArray<IAIFOJGGPJK>.ReadOnly NAFNNIMKNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
public readonly struct LJMAIKKINIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public NativeList<Entity> DDBNEKJPCCN
	{
		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public NativeList<Entity> ANMKODNKCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99990", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public NativeList<byte> NGMINLACLDG
	{
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0xD63290", Offset = "0xD62090", VA = "0x180D63290")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public NativeList<byte> BFKJMOKJPOE
	{
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0xD77A70", Offset = "0xD76870", VA = "0x180D77A70")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NativeList<byte> LEJIOEDFCOL
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x89D980", Offset = "0x89C780", VA = "0x18089D980")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public ComponentType OMIDCDABMGL
	{
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x760F10", Offset = "0x75FD10", VA = "0x180760F10")]
		[CompilerGenerated]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public JobHandle LPNGOAIBOHF
	{
		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x95F260", Offset = "0x95E060", VA = "0x18095F260")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public int ABICHDDOCKG
	{
		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x95F270", Offset = "0x95E070", VA = "0x18095F270")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public int EAAIEOPFIFP
	{
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x795020", Offset = "0x793E20", VA = "0x180795020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public bool MAIIJMCDKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B000", Offset = "0x5E39E00", VA = "0x185E3B000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B080", Offset = "0x5E39E80", VA = "0x185E3B080")]
	public LJMAIKKINIL(ComponentType AGCPJNMOOIE, JobHandle OFGGCMDABFP, NativeList<Entity> DDIFFODKOKJ, NativeList<Entity> PDKGBHIOLFC, NativeList<byte> IHFBBAMDCDM, NativeList<byte> JGMCCNMCFPL, NativeList<byte> OPIGJKADGOE, int FPHAJLKLNGL, int IIHCPBHDJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AEE0", Offset = "0x5E39CE0", VA = "0x185E3AEE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
internal interface HDLLCGPJIMD
{
	[Cpp2IlInjected.Token(Token = "0x17000102")]
	bool MAIIJMCDKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	NativeArray<GFPOPKJOMLL> GPBCJPJNEDF
	{
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	NativeArray<JJPHEIKOGBI> JBADHHPOHAC
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	NativeArray<GFPOPKJOMLL> JKELMJGOHEG
	{
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BCFDPMFFOJA([Out] NativeArray<int> GABGGKOHHGO, Allocator MBGJLDPPIJN);

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CIKKAIOKBNP(ComponentType AGCPJNMOOIE, [Out] LJMAIKKINIL MCIICNJOFOB, [Out] ECDAJHEINPN EANGOGNHDFA);

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeMultiHashMapAsync<Entity, HKOKMGPELNC> OKBLIODPAHD();
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
internal static class JGPJOLJPPJL
{
	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E382A0", Offset = "0x5E370A0", VA = "0x185E382A0")]
	public static bool CJGICLGHAMA(this HDLLCGPJIMD KIGOLAOAAMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
[OCEGCBKNAGD(LJHGMNIEOPD.LoadInstance)]
internal interface NBFMIMBNCND
{
	[Cpp2IlInjected.Token(Token = "0x17000106")]
	NativeParallelMultiHashMap<Entity, HKOKMGPELNC> NHHBJDEMOJP
	{
		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	uint ENCFLFLAEED
	{
		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MGMKMCCHCLA(NativeArray<GFPOPKJOMLL> LNKIEKGIJPO, NativeArray<JJPHEIKOGBI> BLKDAKGGOEB, NativeArray<GFPOPKJOMLL> BPMLECOAJOG, int FFMHELFKIKP);

	[Cpp2IlInjected.Token(Token = "0x60007CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGMOBFJDMGC([In] LJMAIKKINIL EGPNIHDCHPC);

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNCCNLKEELP(JobHandle OFGGCMDABFP);
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
public readonly struct LMFJFLHHBOG : IEquatable<LMFJFLHHBOG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly FGBENGKJFDK KKIIDNMAMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private readonly int IIHCPBHDJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private readonly int EHMEGEAADJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private readonly int IKBIAFEOEKJ;

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public FGBENGKJFDK IOFNGFNIBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330")]
		get
		{
			return default(FGBENGKJFDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B2F0", Offset = "0x5E3A0F0", VA = "0x185E3B2F0")]
	public unsafe ReadOnlySpan<byte> LKGCANGJOMO(void* FDPGGMGFLCN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B380", Offset = "0x5E3A180", VA = "0x185E3B380")]
	public unsafe ReadOnlySpan<byte> OOIBHDJFBNI(void* FDPGGMGFLCN)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D3")]
	[Cpp2IlInjected.Address(RVA = "0x108F4A0", Offset = "0x108E2A0", VA = "0x18108F4A0")]
	public LMFJFLHHBOG(FGBENGKJFDK KKIIDNMAMKF, int GINFBCJKIJI, int EHMEGEAADJE, int IKBIAFEOEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B0E0", Offset = "0x5E39EE0", VA = "0x185E3B0E0", Slot = "4")]
	public bool Equals(LMFJFLHHBOG LKMMHIOOCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B170", Offset = "0x5E39F70", VA = "0x185E3B170", Slot = "0")]
	public override bool Equals(object DGPHOMINFCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B280", Offset = "0x5E3A080", VA = "0x185E3B280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
public readonly struct HKOKMGPELNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly FGBENGKJFDK KKIIDNMAMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly int IIHCPBHDJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private unsafe readonly byte* EHMEGEAADJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private unsafe readonly byte* IKBIAFEOEKJ;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public FGBENGKJFDK IOFNGFNIBGB
	{
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D5330", Offset = "0x7D4130", VA = "0x1807D5330")]
		get
		{
			return default(FGBENGKJFDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public int MGLJLKOIJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x200C8C0", Offset = "0x200B6C0", VA = "0x18200C8C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public unsafe byte* GECENEIGLEC
	{
		[Cpp2IlInjected.Token(Token = "0x60007DC")]
		[Cpp2IlInjected.Address(RVA = "0x998FA0", Offset = "0x997DA0", VA = "0x180998FA0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public unsafe byte* LKCKIMLMELN
	{
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E36EF0", Offset = "0x5E35CF0", VA = "0x185E36EF0")]
	public EBLDEHNKIAL OOIBHDJFBNI(Type FLHOFPAHPKL)
	{
		return default(EBLDEHNKIAL);
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x23D6340", Offset = "0x23D5140", VA = "0x1823D6340")]
	public T LKGCANGJOMO<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x23D6360", Offset = "0x23D5160", VA = "0x1823D6360")]
	public T OOIBHDJFBNI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E36FE0", Offset = "0x5E35DE0", VA = "0x185E36FE0")]
	public unsafe HKOKMGPELNC(FGBENGKJFDK KKIIDNMAMKF, int GINFBCJKIJI, byte* EHMEGEAADJE, byte* IKBIAFEOEKJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
public readonly struct ENNIBPBCEGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private readonly int NGICFBMMBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private readonly int KKIIDNMAMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private readonly IAIFOJGGPJK NFGCMBPOMHF;

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public IAIFOJGGPJK EBFCKPHPCCE
	{
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x998FA0", Offset = "0x997DA0", VA = "0x180998FA0")]
		get
		{
			return default(IAIFOJGGPJK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E346B0", Offset = "0x5E334B0", VA = "0x185E346B0")]
	public ENNIBPBCEGO(int NGICFBMMBFC, int KKIIDNMAMKF, IAIFOJGGPJK NFGCMBPOMHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal abstract class FIFEHJIAPGL : MJGNCFJNMEO, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	private GCIHPKBFCDJ NBCMBPJPEOA;

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	protected abstract PKPEFMCEJFH CCAHIPEENBD
	{
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E35670", Offset = "0x5E34470", VA = "0x185E35670", Slot = "16")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E35A60", Offset = "0x5E34860", VA = "0x185E35A60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E356C0", Offset = "0x5E344C0", VA = "0x185E356C0", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	protected FIFEHJIAPGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
internal class KBJLBBEHFIC : FIFEHJIAPGL
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	protected override PKPEFMCEJFH CCAHIPEENBD
	{
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "17")]
		get
		{
			return default(PKPEFMCEJFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E39420", Offset = "0x5E38220", VA = "0x185E39420")]
	public KBJLBBEHFIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal class FMGDKBCMMJP : FIFEHJIAPGL
{
	[Cpp2IlInjected.Token(Token = "0x17000110")]
	protected override PKPEFMCEJFH CCAHIPEENBD
	{
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x7DD200", Offset = "0x7DC000", VA = "0x1807DD200", Slot = "17")]
		get
		{
			return default(PKPEFMCEJFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E35BA0", Offset = "0x5E349A0", VA = "0x185E35BA0")]
	public FMGDKBCMMJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
public class GFOPCHGFEEJ : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	[PDOCKCLGMBB]
	private GCIHPKBFCDJ JEPEKDIIMFA;

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E36840", Offset = "0x5E35640", VA = "0x185E36840", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E36890", Offset = "0x5E35690", VA = "0x185E36890", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public GFOPCHGFEEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
[AlwaysUpdateSystem]
public class BDHGAEBPPGB : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	public enum EJFINEOECLK
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
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	[PDOCKCLGMBB]
	private GCIHPKBFCDJ NBCMBPJPEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private AECKGKNMLHE EDOPBLFDADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private OCNJLCFFBGI OBMLLMAAEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private NFMCHNOFGDE HLKDBNHEFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private MNAMHMJCFGM COLLIIONBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private EGGELEBCEOK ANJCIDHJCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private JOKJNDOIBEL PHDNCAKOMDB;

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E300", Offset = "0x5E2D100", VA = "0x185E2E300", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E690", Offset = "0x5E2D490", VA = "0x185E2E690", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E800", Offset = "0x5E2D600", VA = "0x185E2E800", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E180", Offset = "0x5E2CF80", VA = "0x185E2E180")]
	private void IOGONCCJJBE([Out] NativeArray<GFPOPKJOMLL> LNKIEKGIJPO, [Out] NativeArray<JJPHEIKOGBI> BLKDAKGGOEB, [Out] NativeArray<GFPOPKJOMLL> BPMLECOAJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E7B0", Offset = "0x5E2D5B0", VA = "0x185E2E7B0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E710", Offset = "0x5E2D510", VA = "0x185E2E710", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public BDHGAEBPPGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000157")]
internal readonly struct AECKGKNMLHE
{
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private static readonly ProfilerMarker DDALCKBENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private readonly DBMABBOGEPD BBNGNPEAOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private readonly World HDEJEAONPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private readonly EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private readonly EntityQuery NFMCFJFKPME;

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CE70", Offset = "0x5E2BC70", VA = "0x185E2CE70")]
	public AECKGKNMLHE(DBMABBOGEPD BBNGNPEAOHB, World HDEJEAONPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C910", Offset = "0x5E2B710", VA = "0x185E2C910")]
	public (NativeArray<GFPOPKJOMLL>, NativeArray<JJPHEIKOGBI>) NCDLFODJGAN()
	{
		return default((NativeArray<GFPOPKJOMLL>, NativeArray<JJPHEIKOGBI>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct JOKJNDOIBEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private static readonly ProfilerMarker DDALCKBENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private readonly DBMABBOGEPD BBNGNPEAOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private NativeList<(EntityQuery query, int componentIndex)> OJIMFBANEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private NativeList<(EntityQuery query, int componentIndex)> MMJAMPHKBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private NativeList<(EntityQuery query, int componentIndex)> FLAEFFBFGKP;

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E39220", Offset = "0x5E38020", VA = "0x185E39220")]
	public JOKJNDOIBEL(DBMABBOGEPD BBNGNPEAOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E38760", Offset = "0x5E37560", VA = "0x185E38760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E38AB0", Offset = "0x5E378B0", VA = "0x185E38AB0")]
	public NativeList<(EntityQuery, int, int, BDHGAEBPPGB.EJFINEOECLK)> JCFPMBKNBIE(uint NBLCMKNKIHK, [Out] int NLDALDCKPJH)
	{
		return default(NativeList<(EntityQuery, int, int, BDHGAEBPPGB.EJFINEOECLK)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E38F20", Offset = "0x5E37D20", VA = "0x185E38F20")]
	private int KPEAOEOAOBH(BDHGAEBPPGB.EJFINEOECLK BPBBIDFIPLA, NativeList<(EntityQuery query, int typeIndex)> KHNEEJJPNNH, NativeList<(EntityQuery query, int typeIndex, int count, BDHGAEBPPGB.EJFINEOECLK mode)> BDDEOEOKOJN, uint NBLCMKNKIHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E390D0", Offset = "0x5E37ED0", VA = "0x185E390D0")]
	private NativeList<(EntityQuery, int)> LBIBEFBLIMC(NativeParallelHashSet<int> NDFBKPCIBAL, int MPAIDLLNEEO)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E38E80", Offset = "0x5E37C80", VA = "0x185E38E80")]
	private NativeList<(EntityQuery, int)> JKALBGKLIAI(NativeParallelHashSet<int> NDFBKPCIBAL, int MPAIDLLNEEO)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E383B0", Offset = "0x5E371B0", VA = "0x185E383B0")]
	private NativeList<(EntityQuery, int)> BNMGJPEHJEL(NativeParallelHashSet<int> NDFBKPCIBAL, int MPAIDLLNEEO, BDHGAEBPPGB.EJFINEOECLK BPBBIDFIPLA)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E387C0", Offset = "0x5E375C0", VA = "0x185E387C0")]
	private NativeList<(EntityQuery, int)> ICCGGGJBCPO()
	{
		return default(NativeList<(EntityQuery, int)>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal readonly struct EGGELEBCEOK
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[BurstCompile]
	private struct AFLAOCJCFAC : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		[ReadOnly]
		public EntityTypeHandle HLEJBJPAOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		[ReadOnly]
		public ComponentDataFromEntity<BLOLCOEHHPK> BEDDEFNFCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		[ReadOnly]
		public DynamicComponentTypeHandle NLKIJOPFFFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> LNFILNLEJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> FGDEOHMIIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		[ReadOnly]
		public ComponentDataFromEntity BNPODKOEGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		[ReadOnly]
		public NativeArray<byte>.ReadOnly CALBMAJKOJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		[ReadOnly]
		public NativeArray<IAIFOJGGPJK>.ReadOnly JIKGLINNCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public ComponentDataFromEntity MOKBJIOGCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public NativeList<Entity> ABPDAGDADKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public NativeList<Entity> FHGHGEOEELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public NativeList<byte> NOPFKHPIKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public NativeList<byte> LNCGEDDEDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public NativeList<byte> GBKPLJFEFMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int IIHCPBHDJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int FPHAJLKLNGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public bool CAAHOMEJEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public BDHGAEBPPGB.EJFINEOECLK BPBBIDFIPLA;

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D0B0", Offset = "0x5E2BEB0", VA = "0x185E2D0B0", Slot = "4")]
		public void Execute(ArchetypeChunk PKPEFKLAONK, int NJOIONKFGCF, int DOJOFDMCBIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D5A0", Offset = "0x5E2C3A0", VA = "0x185E2D5A0")]
		private unsafe bool PPIHKMAFKNB(Entity GLFENPJIMCC, Entity JHEAJJFNCCB, byte* KNDCNCJHGHP, byte* GBJPHPADLGB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D090", Offset = "0x5E2BE90", VA = "0x185E2D090")]
		private unsafe void DPPGELLEEGP(byte* KNDCNCJHGHP, byte* GBJPHPADLGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D4D0", Offset = "0x5E2C2D0", VA = "0x185E2D4D0")]
		private unsafe byte* JNLKJEEDHBB(NativeArray<byte> LENKDNOGEPK, int NAKKFLBPDCC)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D460", Offset = "0x5E2C260", VA = "0x185E2D460")]
		private unsafe byte* HGALJKMMNGF(Entity JHEAJJFNCCB)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CFA0", Offset = "0x5E2BDA0", VA = "0x185E2CFA0")]
		private unsafe byte* CCLHHOIJOEH(ArchetypeChunk PKPEFKLAONK)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x5E2D570", Offset = "0x5E2C370", VA = "0x185E2D570")]
		private static Entity LBPOGKIKIIO([In] BLOLCOEHHPK LMCJHCIOIIP)
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[BurstCompile]
	private struct ALLOHNFBCNP : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		[ReadOnly]
		public NativeList<Entity> KKONCENCFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		[ReadOnly]
		public NativeList<byte> NGNLHNFEAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		[ReadOnly]
		public NativeList<byte> FLDKOBPLOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		[ReadOnly]
		public NativeList<byte> LKFOFIGOPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		[ReadOnly]
		public NativeArray<IAIFOJGGPJK>.ReadOnly JIKGLINNCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public NativeParallelMultiHashMap<Entity, HKOKMGPELNC> OFFBABBKDMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int IIHCPBHDJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public int FPHAJLKLNGL;

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x5E2DBD0", Offset = "0x5E2C9D0", VA = "0x185E2DBD0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly ProfilerMarker DDALCKBENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly DBMABBOGEPD BBNGNPEAOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private readonly World HDEJEAONPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private readonly IDOEAIHJCJE NEFOAPGGIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private readonly NativeParallelHashMap<int, Entity> JJJOCFBKELL;

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x5E342B0", Offset = "0x5E330B0", VA = "0x185E342B0")]
	public EGGELEBCEOK(DBMABBOGEPD BBNGNPEAOHB, World HDEJEAONPBA, GCIHPKBFCDJ NBCMBPJPEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000802")]
	[Cpp2IlInjected.Address(RVA = "0x5E33A70", Offset = "0x5E32870", VA = "0x185E33A70")]
	public JobHandle NCDLFODJGAN(NBFMIMBNCND KIGOLAOAAMI, NativeList<(EntityQuery query, int typeIndex, int count, BDHGAEBPPGB.EJFINEOECLK mode)> FKKFOAHHICD, JobHandle EJGMMMMHMMK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x5E338B0", Offset = "0x5E326B0", VA = "0x185E338B0")]
	private ALLOHNFBCNP GNBGMGBLEPN([In] AFLAOCJCFAC DNKIHNHNBCE, NativeParallelMultiHashMap<Entity, HKOKMGPELNC> JLCJENHKHNF)
	{
		return default(ALLOHNFBCNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x5E334A0", Offset = "0x5E322A0", VA = "0x185E334A0")]
	private AFLAOCJCFAC GCNILEKGIFA(ComponentType AGCPJNMOOIE, EntityManager PNIKEMCNJGA, int BPHMAIFHHNN, BDHGAEBPPGB.EJFINEOECLK BPBBIDFIPLA)
	{
		return default(AFLAOCJCFAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x5E33910", Offset = "0x5E32710", VA = "0x185E33910")]
	private static void LEACAJLHDDK(NBFMIMBNCND KIGOLAOAAMI, ComponentType AGCPJNMOOIE, JobHandle GIFCONDMHLL, [In] AFLAOCJCFAC DNKIHNHNBCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal readonly struct MNAMHMJCFGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private readonly CHDJJIMACAK GEBKAHBCGKI;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private static readonly ProfilerMarker DDALCKBENBK;

	[Cpp2IlInjected.Token(Token = "0x600080F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BA40", Offset = "0x5E3A840", VA = "0x185E3BA40")]
	public MNAMHMJCFGM(World HDEJEAONPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000810")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B810", Offset = "0x5E3A610", VA = "0x185E3B810")]
	public JobHandle NCDLFODJGAN(JobHandle GHHELGOMLKM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal readonly struct OCNJLCFFBGI
{
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private static readonly ProfilerMarker DDALCKBENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private readonly DBMABBOGEPD BBNGNPEAOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private readonly World HDEJEAONPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private readonly EntityQuery PGNLJEHHMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private readonly EntityQuery HOIJKFEFBHM;

	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D790", Offset = "0x5E3C590", VA = "0x185E3D790")]
	public OCNJLCFFBGI(DBMABBOGEPD BBNGNPEAOHB, World HDEJEAONPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D220", Offset = "0x5E3C020", VA = "0x185E3D220")]
	public NativeArray<GFPOPKJOMLL> NCDLFODJGAN()
	{
		return default(NativeArray<GFPOPKJOMLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D180", Offset = "0x5E3BF80", VA = "0x185E3D180")]
	public void DCECJIGJBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D3A0", Offset = "0x5E3C1A0", VA = "0x185E3D3A0")]
	private NativeArray<GFPOPKJOMLL> PKCLAOPMEIK(EntityQuery GJGJMLNNIOK)
	{
		return default(NativeArray<GFPOPKJOMLL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal readonly struct NFMCHNOFGDE
{
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	[CompilerGenerated]
	private sealed class CPDFBJMIKDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public DBMABBOGEPD system;

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public CPDFBJMIKDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x5E31810", Offset = "0x5E30610", VA = "0x185E31810")]
		internal (EntityQuery, ComponentType) INGIALJGPGJ((ComponentType userTag, ComponentType stateTag, ComponentType componentTag) t)
		{
			return default((EntityQuery, ComponentType));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private static readonly ProfilerMarker DDALCKBENBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private readonly DBMABBOGEPD BBNGNPEAOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private readonly (EntityQuery userTagQuery, ComponentType stateTag)[] JKOANKHAPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private readonly EntityQuery DJOPKDOCJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private readonly EntityQuery COFDHGEKAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private readonly ComponentTypes LPEHGAPJCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private readonly ComponentTypes DHLEGBNJCKG;

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C650", Offset = "0x5E3B450", VA = "0x185E3C650")]
	public NFMCHNOFGDE(DBMABBOGEPD BBNGNPEAOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000818")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C2D0", Offset = "0x5E3B0D0", VA = "0x185E3C2D0")]
	public void NCDLFODJGAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
internal class DCJKJCHOJCH : PPHDJOMMNJK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	public struct AGEBHJLOFLK : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	protected override ComponentType OOIDENOGGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x5E31900", Offset = "0x5E30700", VA = "0x185E31900", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	protected override ComponentType HAKABMAJJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x5E31960", Offset = "0x5E30760", VA = "0x185E31960", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	protected override ComponentType OELANMLMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x5E31930", Offset = "0x5E30730", VA = "0x185E31930", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x5E31A20", Offset = "0x5E30820", VA = "0x185E31A20")]
	public DCJKJCHOJCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
internal class LIJMMFBBGFL : PPHDJOMMNJK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	public struct FAMICENDIPC : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	protected override ComponentType OOIDENOGGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AD60", Offset = "0x5E39B60", VA = "0x185E3AD60", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	protected override ComponentType HAKABMAJJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x5E3ADC0", Offset = "0x5E39BC0", VA = "0x185E3ADC0", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	protected override ComponentType OELANMLMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AD90", Offset = "0x5E39B90", VA = "0x185E3AD90", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000825")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AE80", Offset = "0x5E39C80", VA = "0x185E3AE80")]
	public LIJMMFBBGFL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000165")]
public struct LNLIMKBEBEF : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
[MPJBDEDKJDC]
public class HGJPBGBICEE : LLHIKPBJIAL
{
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	private struct KEFPCKNHPME : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		[ReadOnly]
		public NativeParallelHashSet<int> OHLIJJOAFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		[ReadOnly]
		public EntityTypeHandle BNBPCPHFCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> KKOPCOICHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public NativeList<Entity>.ParallelWriter IBAFLKEGKHB;

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x5E39470", Offset = "0x5E38270", VA = "0x185E39470", Slot = "4")]
		public void Execute(ArchetypeChunk PKPEFKLAONK, int NJOIONKFGCF, int DOJOFDMCBIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x600082A")]
	[Cpp2IlInjected.Address(RVA = "0x5E36980", Offset = "0x5E35780", VA = "0x185E36980", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082B")]
	[Cpp2IlInjected.Address(RVA = "0x5E36A10", Offset = "0x5E35810", VA = "0x185E36A10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082C")]
	[Cpp2IlInjected.Address(RVA = "0x5E36930", Offset = "0x5E35730", VA = "0x185E36930")]
	private EntityCommandBufferSystem MKBINIFPCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600082D")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public HGJPBGBICEE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[MPJBDEDKJDC]
	[CompilerGenerated]
	public class DebugPostDeserializeRemoveOrphanedSplinePointsSystem : LLHIKPBJIAL
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
			public ComponentDataFromEntity<FHFFBJLOOCP> splineDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004CA")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public ComponentTypeHandle<MDLBCMGPBBP> __pointTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000836")]
			[Cpp2IlInjected.Address(RVA = "0x5E32080", Offset = "0x5E30E80", VA = "0x185E32080")]
			private void IOJGJCNCGIC(Entity entity, [In][NoAlias] MDLBCMGPBBP point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000837")]
			[Cpp2IlInjected.Address(RVA = "0x5E31F60", Offset = "0x5E30D60", VA = "0x185E31F60", Slot = "4")]
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
		private ComponentTypeHandle<MDLBCMGPBBP> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x5E32340", Offset = "0x5E31140", VA = "0x185E32340", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x5E32580", Offset = "0x5E31380", VA = "0x185E32580")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void PAIKNFMIKJG(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x5E32110", Offset = "0x5E30F10", VA = "0x185E32110")]
		private EntityCommandBufferSystem MKBINIFPCGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0x5E31E20", Offset = "0x5E30C20", VA = "0x185E31E20")]
		private JobHandle EKENFDAFBCK(EntityCommandBuffer ecb, ComponentDataFromEntity<FHFFBJLOOCP> splineDataRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0x5E32160", Offset = "0x5E30F60", VA = "0x185E32160", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public DebugPostDeserializeRemoveOrphanedSplinePointsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
[MPJBDEDKJDC]
public class IMBEKNBPFLK : LLHIKPBJIAL
{
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0x5E37D00", Offset = "0x5E36B00", VA = "0x185E37D00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000839")]
	[Cpp2IlInjected.Address(RVA = "0x5E37DA0", Offset = "0x5E36BA0", VA = "0x185E37DA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x5E37CB0", Offset = "0x5E36AB0", VA = "0x185E37CB0")]
	private EntityCommandBufferSystem MKBINIFPCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public IMBEKNBPFLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
[MPJBDEDKJDC]
public class FFAOEAMEJJO : LLHIKPBJIAL
{
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x5E34FC0", Offset = "0x5E33DC0", VA = "0x185E34FC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x5E35080", Offset = "0x5E33E80", VA = "0x185E35080", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083F")]
	[Cpp2IlInjected.Address(RVA = "0x5E34F70", Offset = "0x5E33D70", VA = "0x185E34F70")]
	private EntityCommandBufferSystem MKBINIFPCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000840")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public FFAOEAMEJJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[UpdateAfter(typeof(HGJPBGBICEE))]
public class MOEHDGFCLID : DBMABBOGEPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private EntityArchetype LEKKFMKFJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x6000842")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BAF0", Offset = "0x5E3A8F0", VA = "0x185E3BAF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000843")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BC10", Offset = "0x5E3AA10", VA = "0x185E3BC10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000844")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BAA0", Offset = "0x5E3A8A0", VA = "0x185E3BAA0")]
	private EntityCommandBufferSystem MKBINIFPCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000845")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public MOEHDGFCLID()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	internal class PostDeserializeAddSplinePointsToSplinesSystem : DBMABBOGEPD
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
			[Cpp2IlInjected.Address(RVA = "0x5E3F6E0", Offset = "0x5E3E4E0", VA = "0x185E3F6E0")]
			private void IOJGJCNCGIC(Entity spline)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600084E")]
			[Cpp2IlInjected.Address(RVA = "0x5E3F630", Offset = "0x5E3E430", VA = "0x185E3F630", Slot = "4")]
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
			public ComponentTypeHandle<MDLBCMGPBBP> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0x5E3F8B0", Offset = "0x5E3E6B0", VA = "0x185E3F8B0")]
			private void IOJGJCNCGIC(Entity splinePoint, [In][NoAlias] MDLBCMGPBBP splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0x5E3F790", Offset = "0x5E3E590", VA = "0x185E3F790", Slot = "4")]
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
		private ComponentTypeHandle<MDLBCMGPBBP> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000846")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FCC0", Offset = "0x5E3EAC0", VA = "0x185E3FCC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000847")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FD80", Offset = "0x5E3EB80", VA = "0x185E3FD80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F960", Offset = "0x5E3E760", VA = "0x185E3F960")]
		private EntityCommandBufferSystem MKBINIFPCGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F3E0", Offset = "0x5E3E1E0", VA = "0x185E3F3E0")]
		private void BIKBFKHMANL(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F4E0", Offset = "0x5E3E2E0", VA = "0x185E3F4E0")]
		private void KGBIGHCHEJB(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F9B0", Offset = "0x5E3E7B0", VA = "0x185E3F9B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PostDeserializeAddSplinePointsToSplinesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
public class CIBDMOAOANG : DBMABBOGEPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x6000851")]
	[Cpp2IlInjected.Address(RVA = "0x5E314D0", Offset = "0x5E302D0", VA = "0x185E314D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000852")]
	[Cpp2IlInjected.Address(RVA = "0x5E315A0", Offset = "0x5E303A0", VA = "0x185E315A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000853")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public CIBDMOAOANG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal sealed class GHEHGBGEMGF : ParentSystemBase<ParentData, PreviousParentData, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000854")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C30", Offset = "0x7E3A30", VA = "0x1807E4C30", Slot = "14")]
	protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc GJGJMLNNIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C30", Offset = "0x7E3A30", VA = "0x1807E4C30", Slot = "15")]
	protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc GJGJMLNNIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C30", Offset = "0x7E3A30", VA = "0x1807E4C30", Slot = "16")]
	protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc GJGJMLNNIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000857")]
	[Cpp2IlInjected.Address(RVA = "0x5E368B0", Offset = "0x5E356B0", VA = "0x185E368B0", Slot = "17")]
	protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc GJGJMLNNIOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000858")]
	[Cpp2IlInjected.Address(RVA = "0x5E368F0", Offset = "0x5E356F0", VA = "0x185E368F0")]
	public GHEHGBGEMGF()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[MPJBDEDKJDC]
	[CompilerGenerated]
	public class PostDeserializeRemoveComponentSerializedVersionDataSystem : DBMABBOGEPD
	{
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x5E40290", Offset = "0x5E3F090", VA = "0x185E40290", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x5E40330", Offset = "0x5E3F130", VA = "0x185E40330", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x5E400A0", Offset = "0x5E3EEA0", VA = "0x185E400A0")]
		private EntityCommandBufferSystem MKBINIFPCGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x5E400F0", Offset = "0x5E3EEF0", VA = "0x185E400F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PostDeserializeRemoveComponentSerializedVersionDataSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
public class LHMHAJFCBIL : ILBBJHAOAMI
{
	[Cpp2IlInjected.Token(Token = "0x600085F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AD00", Offset = "0x5E39B00", VA = "0x185E3AD00", Slot = "14")]
	protected override EntityCommandBufferSystem MKBINIFPCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000860")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AD50", Offset = "0x5E39B50", VA = "0x185E3AD50")]
	public LHMHAJFCBIL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	internal class PostDeserializeSortSplinePointsSystem : DBMABBOGEPD
	{
		[Cpp2IlInjected.Token(Token = "0x2000175")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public ComponentDataFromEntity<OPJBGANEPIB> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0x5E3DAE0", Offset = "0x5E3C8E0", VA = "0x185E3DAE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E406E0", Offset = "0x5E3F4E0", VA = "0x185E406E0")]
			private void IOJGJCNCGIC(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0x5E405B0", Offset = "0x5E3F3B0", VA = "0x185E405B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E40BA0", Offset = "0x5E3F9A0", VA = "0x185E40BA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x5E40770", Offset = "0x5E3F570", VA = "0x185E40770")]
		private void MDEANACJCDI(OrderComparer comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x5E408A0", Offset = "0x5E3F6A0", VA = "0x185E408A0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PostDeserializeSortSplinePointsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	public class PostDeserializeTransformRootsSystem : DBMABBOGEPD
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
			public ComponentTypeHandle<LMOBHKOOHGM> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000871")]
			[Cpp2IlInjected.Address(RVA = "0x5E2B0C0", Offset = "0x5E29EC0", VA = "0x185E2B0C0")]
			private void IOJGJCNCGIC([NoAlias] LMOBHKOOHGM data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000872")]
			[Cpp2IlInjected.Address(RVA = "0x5E41200", Offset = "0x5E40000", VA = "0x185E41200", Slot = "4")]
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
			public ComponentTypeHandle<GKEHOBJBFLL> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0x5E2B2F0", Offset = "0x5E2A0F0", VA = "0x185E2B2F0")]
			private void IOJGJCNCGIC([NoAlias] GKEHOBJBFLL data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000874")]
			[Cpp2IlInjected.Address(RVA = "0x5E412D0", Offset = "0x5E400D0", VA = "0x185E412D0", Slot = "4")]
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
			public ComponentTypeHandle<APKJEEPOAEH> __authoredPoseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			[ReadOnly]
			public ComponentTypeHandle<LMOBHKOOHGM> __poseTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0x5E2B300", Offset = "0x5E2A100", VA = "0x185E2B300")]
			private void IOJGJCNCGIC([NoAlias] APKJEEPOAEH authoredPose, [In][NoAlias] LMOBHKOOHGM pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x5E413A0", Offset = "0x5E401A0", VA = "0x185E413A0", Slot = "4")]
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
			public ComponentTypeHandle<LHBHLBPKJPB> __authoredScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			[ReadOnly]
			public ComponentTypeHandle<GKEHOBJBFLL> __scaleTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0x5E2B320", Offset = "0x5E2A120", VA = "0x185E2B320")]
			private void IOJGJCNCGIC([NoAlias] LHBHLBPKJPB authoredScale, [In][NoAlias] GKEHOBJBFLL scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x5E414F0", Offset = "0x5E402F0", VA = "0x185E414F0", Slot = "4")]
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
		private ComponentTypeHandle<LMOBHKOOHGM> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private ComponentTypeHandle<GKEHOBJBFLL> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private ComponentTypeHandle<APKJEEPOAEH> __RecRoom_Components_AuthoredLocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private ComponentTypeHandle<LMOBHKOOHGM> __RecRoom_Components_LocalPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private ComponentTypeHandle<LHBHLBPKJPB> __RecRoom_Components_AuthoredLocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private ComponentTypeHandle<GKEHOBJBFLL> __RecRoom_Components_LocalUniformScaleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x5E42330", Offset = "0x5E41130", VA = "0x185E42330", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x5E41780", Offset = "0x5E40580", VA = "0x185E41780")]
		private void OGCPPFJNLKP([In] AGHGNCPPGHC transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x5E40E90", Offset = "0x5E3FC90", VA = "0x185E40E90")]
		private void FMBHMJGKOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x5E410D0", Offset = "0x5E3FED0", VA = "0x185E410D0")]
		private JobHandle LPGMFJCJFFG(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x5E419A0", Offset = "0x5E407A0", VA = "0x185E419A0")]
		private JobHandle OGIOELOBNEI(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x5E40D50", Offset = "0x5E3FB50", VA = "0x185E40D50")]
		private JobHandle FLJFPFJIAOO(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x5E41640", Offset = "0x5E40440", VA = "0x185E41640")]
		private JobHandle MHLLJNGCJJM(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x5E41AA0", Offset = "0x5E408A0", VA = "0x185E41AA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000870")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PostDeserializeTransformRootsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
public static class KPFAMFDLJPP
{
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	public interface FELOBHBIDFA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	public interface BFNAMLGCDJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	public class NONAMPABPIH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	public class PHPKLCMHNFJ : BFNAMLGCDJB
	{
		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x5E3F180", Offset = "0x5E3DF80", VA = "0x185E3F180")]
		public PHPKLCMHNFJ(ComponentType PGGBKFCMLMO, ComponentType EMPJNOJFEPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000182")]
	public class DPCNDEGHCME : BFNAMLGCDJB
	{
		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x353AC30", Offset = "0x3539A30", VA = "0x18353AC30")]
		public DPCNDEGHCME(ComponentType PGGBKFCMLMO, ComponentType[] EMPJNOJFEPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000183")]
	public class MGNJCLOPIAK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600087B")]
	[Cpp2IlInjected.Address(RVA = "0x244CF90", Offset = "0x244BD90", VA = "0x18244CF90")]
	public static BFNAMLGCDJB BOBJGBBPJMA<TFrom, TTo>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600087C")]
	[Cpp2IlInjected.Address(RVA = "0x244CE70", Offset = "0x244BC70", VA = "0x18244CE70")]
	public static BFNAMLGCDJB ALEFOOBPKML<TFrom>(params ComponentType[] NCEKPMLHDJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public class GDGBNBJOBKF : ANIFJPLLIHB
{
	[Cpp2IlInjected.Token(Token = "0x600087F")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	public GDGBNBJOBKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class NABFCINPLHJ : LLHIKPBJIAL
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x6000880")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BDE0", Offset = "0x5E3ABE0", VA = "0x185E3BDE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000881")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BD90", Offset = "0x5E3AB90", VA = "0x185E3BD90")]
	private EntityCommandBufferSystem MKBINIFPCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000882")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public NABFCINPLHJ()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	[GDGBNBJOBKF]
	public class PostDeserializeUpgrade_Convert_ObjectPolicyData : AMNOJKEFNHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000188")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_ObjectPolicyData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			public CONCCCIHFGK<MMJCBEIAILP> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			public CONCCCIHFGK<DBJNHIIMIFI> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			public CONCCCIHFGK<POHPIAKBMGL> v2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000505")]
			public CONCCCIHFGK<CHAHCFOICGN> v3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000506")]
			public JFMGIICFIGK<NDMPDKHIOLE> v4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000507")]
			public POHPIAKBMGL v2Default;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x5E43C20", Offset = "0x5E42A20", VA = "0x185E43C20")]
			private void IOJGJCNCGIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0x5E43C10", Offset = "0x5E42A10", VA = "0x185E43C10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		protected override HICMFDICNOL Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0x5E433D0", Offset = "0x5E421D0", VA = "0x185E433D0", Slot = "14")]
			get
			{
				return default(HICMFDICNOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x5E43A30", Offset = "0x5E42830", VA = "0x185E43A30", Slot = "15")]
		public override IEnumerable<KPFAMFDLJPP.BFNAMLGCDJB> HCCIDLCOLPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x5E43050", Offset = "0x5E41E50", VA = "0x185E43050", Slot = "16")]
		protected override void BCDNJAKHNEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x5E43770", Offset = "0x5E42570", VA = "0x185E43770")]
		private static void FEEPNECAOCE(FFFGNJDCJAI<DBJNHIIMIFI> srcVersion, FFFGNJDCJAI<POHPIAKBMGL> dstVersion, POHPIAKBMGL dstDefault)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x5E43910", Offset = "0x5E42710", VA = "0x185E43910")]
		private static void GJABDMLOFEK(FFFGNJDCJAI<POHPIAKBMGL> srcVersion, FFFGNJDCJAI<CHAHCFOICGN> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x5E43420", Offset = "0x5E42220", VA = "0x185E43420")]
		private static void DGKNLDGCELG(FFFGNJDCJAI<CHAHCFOICGN> srcVersion, FFFGNJDCJAI<NDMPDKHIOLE> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x5E43550", Offset = "0x5E42350", VA = "0x185E43550")]
		private JobHandle ELFBKPHMBLN(CONCCCIHFGK<MMJCBEIAILP> v0, CONCCCIHFGK<DBJNHIIMIFI> v1, CONCCCIHFGK<POHPIAKBMGL> v2, CONCCCIHFGK<CHAHCFOICGN> v3, JFMGIICFIGK<NDMPDKHIOLE> v4, POHPIAKBMGL v2Default, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PostDeserializeUpgrade_Convert_ObjectPolicyData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	[CompilerGenerated]
	[GDGBNBJOBKF]
	public class PostDeserializeUpgrade_Convert_OMShapeContainerData : AMNOJKEFNHF
	{
		[Cpp2IlInjected.Token(Token = "0x200018A")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_OMShapeContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000509")]
			public CONCCCIHFGK<OCADONEBDKH> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public JFMGIICFIGK<LIELCEKBGND> v2;

			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0x5E42B80", Offset = "0x5E41980", VA = "0x185E42B80")]
			private void IOJGJCNCGIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x5E42B70", Offset = "0x5E41970", VA = "0x185E42B70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		protected override HICMFDICNOL Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0x5E42990", Offset = "0x5E41790", VA = "0x185E42990", Slot = "14")]
			get
			{
				return default(HICMFDICNOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x5E42AB0", Offset = "0x5E418B0", VA = "0x185E42AB0", Slot = "15")]
		public override IEnumerable<KPFAMFDLJPP.BFNAMLGCDJB> HCCIDLCOLPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x5E42820", Offset = "0x5E41620", VA = "0x185E42820", Slot = "16")]
		protected override void BCDNJAKHNEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x5E429E0", Offset = "0x5E417E0", VA = "0x185E429E0")]
		private static void FEEPNECAOCE(FFFGNJDCJAI<OCADONEBDKH> srcVersion, FFFGNJDCJAI<LIELCEKBGND> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x5E42E90", Offset = "0x5E41C90", VA = "0x185E42E90")]
		private JobHandle NMMNDPMPIFC(CONCCCIHFGK<OCADONEBDKH> v1, JFMGIICFIGK<LIELCEKBGND> v2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PostDeserializeUpgrade_Convert_OMShapeContainerData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	[GDGBNBJOBKF]
	[MPJBDEDKJDC]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data : AMNOJKEFNHF, KPFAMFDLJPP.FELOBHBIDFA
	{
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		private struct PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public CONCCCIHFGK<HPKHIAPFDOP> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public CONCCCIHFGK<NBGIAMMLLME> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x5E44A00", Offset = "0x5E43800", VA = "0x185E44A00")]
			private void IOJGJCNCGIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0x5E449F0", Offset = "0x5E437F0", VA = "0x185E449F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		protected override HICMFDICNOL Log
		{
			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x5E44730", Offset = "0x5E43530", VA = "0x185E44730", Slot = "14")]
			get
			{
				return default(HICMFDICNOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x5E448D0", Offset = "0x5E436D0", VA = "0x185E448D0", Slot = "15")]
		public override IEnumerable<KPFAMFDLJPP.BFNAMLGCDJB> HCCIDLCOLPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x5E44370", Offset = "0x5E43170", VA = "0x185E44370", Slot = "16")]
		protected override void BCDNJAKHNEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E445A0", Offset = "0x5E433A0", VA = "0x185E445A0")]
		private static void CCEAENIAGIK(HIICAJGBODO<NBGIAMMLLME> d1, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E44780", Offset = "0x5E43580", VA = "0x185E44780")]
		private JobHandle EEELPIPCPKL(CONCCCIHFGK<HPKHIAPFDOP> v0, CONCCCIHFGK<NBGIAMMLLME> v1, EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	[GDGBNBJOBKF]
	public class PostDeserializeUpgrade_Convert_SerializeEmbodiedData : AMNOJKEFNHF
	{
		[Cpp2IlInjected.Token(Token = "0x200018E")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_SerializeEmbodiedData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public CONCCCIHFGK<CPBHHEEJHDC> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public JFMGIICFIGK<DFILKBOMIIH> v1;

			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0x5E45270", Offset = "0x5E44070", VA = "0x185E45270")]
			private void IOJGJCNCGIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0x5E45260", Offset = "0x5E44060", VA = "0x185E45260", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		protected override HICMFDICNOL Log
		{
			[Cpp2IlInjected.Token(Token = "0x60008A7")]
			[Cpp2IlInjected.Address(RVA = "0x5E45020", Offset = "0x5E43E20", VA = "0x185E45020", Slot = "14")]
			get
			{
				return default(HICMFDICNOL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E451A0", Offset = "0x5E43FA0", VA = "0x185E451A0", Slot = "15")]
		public override IEnumerable<KPFAMFDLJPP.BFNAMLGCDJB> HCCIDLCOLPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E44EB0", Offset = "0x5E43CB0", VA = "0x185E44EB0", Slot = "16")]
		protected override void BCDNJAKHNEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E45070", Offset = "0x5E43E70", VA = "0x185E45070")]
		private JobHandle EIHLOKFEBJF(CONCCCIHFGK<CPBHHEEJHDC> v0, JFMGIICFIGK<DFILKBOMIIH> v1, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PostDeserializeUpgrade_Convert_SerializeEmbodiedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[GDGBNBJOBKF]
public class OACJICHIOBO : DBMABBOGEPD, KPFAMFDLJPP.FELOBHBIDFA
{
	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public IEnumerable<Type> BHCOKHOHLHD
	{
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E3CBA0", Offset = "0x5E3B9A0", VA = "0x185E3CBA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CE60", Offset = "0x5E3BC60", VA = "0x185E3CE60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CE10", Offset = "0x5E3BC10", VA = "0x185E3CE10")]
	private EntityCommandBufferSystem MKBINIFPCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008B3")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public OACJICHIOBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
public class BENPFODMPPE : BANKPNPLKEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	protected override HFNPLAKMHJA FGIIFCOGBDB
	{
		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "15")]
		get
		{
			return default(HFNPLAKMHJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E2ED20", Offset = "0x5E2DB20", VA = "0x185E2ED20", Slot = "16")]
	protected override void ILDGOOODFFH(HFNPLAKMHJA FBJEHMGCPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EF90", Offset = "0x5E2DD90", VA = "0x185E2EF90")]
	private EntityCommandBufferSystem MKBINIFPCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F070", Offset = "0x5E2DE70", VA = "0x185E2F070")]
	public BENPFODMPPE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[GDGBNBJOBKF]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Split_ContainerData : DBMABBOGEPD, KPFAMFDLJPP.FELOBHBIDFA
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
			public NativeArray<MBDNOENDJEK> v1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public ComponentTypes newComponents;

			[Cpp2IlInjected.Token(Token = "0x60008C0")]
			[Cpp2IlInjected.Address(RVA = "0x5E45620", Offset = "0x5E44420", VA = "0x185E45620")]
			private void IOJGJCNCGIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008C1")]
			[Cpp2IlInjected.Address(RVA = "0x5E45610", Offset = "0x5E44410", VA = "0x185E45610", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private ComponentType[] newComponentTypes;

		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E45550", Offset = "0x5E44350", VA = "0x185E45550", Slot = "14")]
		public IEnumerable<KPFAMFDLJPP.BFNAMLGCDJB> HCCIDLCOLPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E45A90", Offset = "0x5E44890", VA = "0x185E45A90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E45900", Offset = "0x5E44700", VA = "0x185E45900")]
		private EntityCommandBufferSystem MKBINIFPCGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E45950", Offset = "0x5E44750", VA = "0x185E45950")]
		private JobHandle OLGPMLDKOFF(EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<MBDNOENDJEK> v1Data, ComponentTypes newComponents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E45F70", Offset = "0x5E44D70", VA = "0x185E45F70")]
		public PostDeserializeUpgrade_Split_ContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
[AlwaysUpdateSystem]
public abstract class AMNOJKEFNHF : DBMABBOGEPD, KPFAMFDLJPP.FELOBHBIDFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private NativeList<EntityQuery> FKKFOAHHICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private bool CCNCMAIPJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private EntityCommandBufferSystem NFGGBBOFGOH;

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	protected bool LOJCLMPHFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x5580270", Offset = "0x557F070", VA = "0x185580270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	protected abstract HICMFDICNOL BPAIBICBBJL
	{
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract IEnumerable<KPFAMFDLJPP.BFNAMLGCDJB> HCCIDLCOLPD();

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DE60", Offset = "0x5E2CC60", VA = "0x185E2DE60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DF80", Offset = "0x5E2CD80", VA = "0x185E2DF80", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DF30", Offset = "0x5E2CD30", VA = "0x185E2DF30", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void BCDNJAKHNEK();

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DE10", Offset = "0x5E2CC10", VA = "0x185E2DE10")]
	protected EntityCommandBufferSystem MKBINIFPCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008CA")]
	[Cpp2IlInjected.Address(RVA = "0x29C2580", Offset = "0x29C1380", VA = "0x1829C2580")]
	protected EntityQuery KFMDAAEMHNI<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CB")]
	[Cpp2IlInjected.Address(RVA = "0x29C1880", Offset = "0x29C0680", VA = "0x1829C1880")]
	protected CONCCCIHFGK<T> JKHDDFKJODM<T>() where T : struct, IComponentData
	{
		return default(CONCCCIHFGK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0x29C2A80", Offset = "0x29C1880", VA = "0x1829C2A80")]
	protected JFMGIICFIGK<T> LOMCCPIJGEN<T>() where T : struct, IComponentData
	{
		return default(JFMGIICFIGK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CD")]
	[Cpp2IlInjected.Address(RVA = "0x29C1600", Offset = "0x29C0400", VA = "0x1829C1600")]
	protected static void GKDAPAIAJHJ<T1, T2>(HIICAJGBODO<T1> NDDCMDKEHJD, HIICAJGBODO<T2> FEIDJIMNJCD) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0x29C1600", Offset = "0x29C0400", VA = "0x1829C1600")]
	protected static void GKDAPAIAJHJ<T1, T2>(HIICAJGBODO<T1> NDDCMDKEHJD, NKLFMHFHNDB<T2> FEIDJIMNJCD) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0x29C1540", Offset = "0x29C0340", VA = "0x1829C1540")]
	private static void GKDAPAIAJHJ<T1, T2>(FFFGNJDCJAI<T1> NDDCMDKEHJD, FFFGNJDCJAI<T2> FEIDJIMNJCD) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D0")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	protected AMNOJKEFNHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public abstract class BANKPNPLKEJ : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	protected virtual HFNPLAKMHJA AJPBOFNPNBP
	{
		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "14")]
		get
		{
			return default(HFNPLAKMHJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	protected virtual HFNPLAKMHJA FGIIFCOGBDB
	{
		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x7DD200", Offset = "0x7DC000", VA = "0x1807DD200", Slot = "15")]
		get
		{
			return default(HFNPLAKMHJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void ILDGOOODFFH(HFNPLAKMHJA FBJEHMGCPKI);

	[Cpp2IlInjected.Token(Token = "0x60008D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E040", Offset = "0x5E2CE40", VA = "0x185E2E040", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DFE0", Offset = "0x5E2CDE0", VA = "0x185E2DFE0")]
	private HFNPLAKMHJA AECMIHCCDAK()
	{
		return default(HFNPLAKMHJA);
	}

	[Cpp2IlInjected.Token(Token = "0x60008D6")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	protected BANKPNPLKEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
public class OCOEOIGNGAM : DBMABBOGEPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private JCKLIMAKHJH NFGGBBOFGOH;

	[Cpp2IlInjected.Token(Token = "0x60008D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D8C0", Offset = "0x5E3C6C0", VA = "0x185E3D8C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D990", Offset = "0x5E3C790", VA = "0x185E3D990", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DA")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public OCOEOIGNGAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
public class PLOMPBNODOG : DBMABBOGEPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private JCKLIMAKHJH NFGGBBOFGOH;

	[Cpp2IlInjected.Token(Token = "0x60008DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F1C0", Offset = "0x5E3DFC0", VA = "0x185E3F1C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F290", Offset = "0x5E3E090", VA = "0x185E3F290", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DD")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public PLOMPBNODOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
public class EKANIHCPOEP : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private OOCJGLJECEA JOJOJMCMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.Token(Token = "0x60008DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E343A0", Offset = "0x5E331A0", VA = "0x185E343A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E34330", Offset = "0x5E33130", VA = "0x185E34330", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E34470", Offset = "0x5E33270", VA = "0x185E34470", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E1")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public EKANIHCPOEP()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	public class DebugPostLoadValidateNetworkIdSystem : LLHIKPBJIAL, ENEHADLKBBF
	{
		[Cpp2IlInjected.Token(Token = "0x2000199")]
		private struct DebugPostLoadValidateNetworkIdSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public NativeParallelHashMap<GFPOPKJOMLL, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			[ReadOnly]
			public ComponentTypeHandle<HFLMCEGCJME> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0x5E32880", Offset = "0x5E31680", VA = "0x185E32880")]
			private void IOJGJCNCGIC(Entity entity, [In] HFLMCEGCJME networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E9")]
			[Cpp2IlInjected.Address(RVA = "0x5E32760", Offset = "0x5E31560", VA = "0x185E32760", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private GNIFDDKOOBH networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private EntityQuery DebugPostLoadValidateNetworkIdSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private ComponentTypeHandle<HFLMCEGCJME> __RecRoom_Components_ObjectNetworkIdComponentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E32700", Offset = "0x5E31500", VA = "0x185E32700", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E32B00", Offset = "0x5E31900", VA = "0x185E32B00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E32610", Offset = "0x5E31410", VA = "0x185E32610")]
		private void BPOOHBNKJBM(NativeParallelHashMap<GFPOPKJOMLL, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E32900", Offset = "0x5E31700", VA = "0x185E32900", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public DebugPostLoadValidateNetworkIdSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	public class DebugPostLoadValidateParentDataSystem : LLHIKPBJIAL, ENEHADLKBBF
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
			[Cpp2IlInjected.Address(RVA = "0x5E32FC0", Offset = "0x5E31DC0", VA = "0x185E32FC0")]
			private void IOJGJCNCGIC(Entity entity, [In] ParentData parentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x5E32EA0", Offset = "0x5E31CA0", VA = "0x185E32EA0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private CCAABBKKMFL objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private EntityQuery DebugPostLoadValidateParentDataSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E32E40", Offset = "0x5E31C40", VA = "0x185E32E40", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E32D70", Offset = "0x5E31B70", VA = "0x185E32D70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E32D70", Offset = "0x5E31B70", VA = "0x185E32D70")]
		private void FHHCBPDFEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E33190", Offset = "0x5E31F90", VA = "0x185E33190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public DebugPostLoadValidateParentDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E32BF0", Offset = "0x5E319F0", VA = "0x185E32BF0")]
		[CompilerGenerated]
		private void CJJFBINHKAG(Entity entity, [In] ParentData parentData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
public class MCAOODAALJP : LLHIKPBJIAL, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private PAPIHHEIJJK BEEHCIODHCL;

	[Cpp2IlInjected.Token(Token = "0x60008F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B5D0", Offset = "0x5E3A3D0", VA = "0x185E3B5D0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F3")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F4")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public MCAOODAALJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
[UpdateBefore(typeof(DOBCGAPDAKI))]
public class BIPGADNOFLD : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x60008F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F0C0", Offset = "0x5E2DEC0", VA = "0x185E2F0C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F170", Offset = "0x5E2DF70", VA = "0x185E2F170", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F7")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public BIPGADNOFLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
public class PDPIIOAKLMN : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[BurstCompile]
	private struct DPBDJJDFDLO : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		[ReadOnly]
		public NativeArray<KBFKCEBOJDO> GAJFOOHOLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		[ReadOnly]
		public NativeArray<Entity> DDIFFODKOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public ComponentDataFromEntity ENFPBOBJFFF;

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x5E31D10", Offset = "0x5E30B10", VA = "0x185E31D10", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[BurstCompile]
	private struct GCMOCHDALFN : IJob, INativeDisposable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> NMKOCPMHMLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		[ReadOnly]
		public NativeParallelHashMap<int, EntityArchetype> MOEPENAGPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		[ReadOnly]
		public NativeParallelHashMap<int, int> ONKNMCFGJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> IGLIEKIMGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> ELGONBFFAGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public NativeList<EntityArchetype> JGJLKOJCGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public NativeList<EntityArchetype> LIDLLGECMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public NativeList<IAIFOJGGPJK> CDKPJPDPMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public NativeList<IAIFOJGGPJK> AJOLCAKGFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public NativeList<KBFKCEBOJDO> MCACOJHAKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public NativeList<ComponentType> EPGGIHGBGEL;

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x5E36590", Offset = "0x5E35390", VA = "0x185E36590", Slot = "6")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x5E35BF0", Offset = "0x5E349F0", VA = "0x185E35BF0", Slot = "5")]
		public JobHandle Dispose(JobHandle OFGGCMDABFP)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x5E35E00", Offset = "0x5E34C00", VA = "0x185E35E00", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x5E36300", Offset = "0x5E35100", VA = "0x185E36300")]
		private int HPLEHJHFMLI(IAIFOJGGPJK EMMJCKMLADB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x5E363A0", Offset = "0x5E351A0", VA = "0x185E363A0")]
		private bool KAEFLONFKDF(int MEJGIHNADCD, EntityArchetype HBHGJBAOMCD, [Out] EntityArchetype CKMJBGEBHJD, [Out] Entity PJFHNEPDALE)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001A1")]
	[BurstCompile]
	private struct MGDMIKHDLDE : IComparer<KBFKCEBOJDO>
	{
		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x95B7A0", Offset = "0x95A5A0", VA = "0x18095B7A0", Slot = "4")]
		public int Compare(KBFKCEBOJDO NPDPLEIHBMM, KBFKCEBOJDO CINKHPOEGPD)
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[BurstCompile]
	private struct BHOCDOBKJII : GHLDNAHLONK<KBFKCEBOJDO, int>
	{
		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0xE07980", Offset = "0xE06780", VA = "0x180E07980")]
		public int DENFBJJPHJF([In] KBFKCEBOJDO ECAFGEFAJGI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0xE07980", Offset = "0xE06780", VA = "0x180E07980", Slot = "4")]
		private int NJABDEDCPEF([In] KBFKCEBOJDO POACLGOFKAJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	private struct KBFKCEBOJDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public Entity PJFHNEPDALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public IAIFOJGGPJK DDIFFODKOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int FECKDBAKPKI;
	}

	[Cpp2IlInjected.Token(Token = "0x4000534")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private NDPEAMPCMHG KDKGHICNAPC;

	[Cpp2IlInjected.Token(Token = "0x60008F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DB70", Offset = "0x5E3C970", VA = "0x185E3DB70", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E9D0", Offset = "0x5E3D7D0", VA = "0x185E3E9D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EA90", Offset = "0x5E3D890", VA = "0x185E3EA90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DE60", Offset = "0x5E3CC60", VA = "0x185E3DE60")]
	private GCMOCHDALFN LPACEEAKGEL(NativeArray<ArchetypeChunk> NEAMHCCEFPP)
	{
		return default(GCMOCHDALFN);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E680", Offset = "0x5E3D480", VA = "0x185E3E680")]
	private void NLJPNPGHKHH(NativeArray<EntityArchetype> LIDLLGECMBF, NativeArray<IAIFOJGGPJK> CDKPJPDPMLC, NativeArray<IAIFOJGGPJK> AJOLCAKGFFK, NativeArray<ComponentType> EPGGIHGBGEL, NativeArray<ArchetypeChunk> NEAMHCCEFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DBC0", Offset = "0x5E3C9C0", VA = "0x185E3DBC0")]
	private EntityArchetype LLHGOIKKGAN(EntityArchetype IHHEGCJCCAC, NativeArray<ComponentType> EPGGIHGBGEL, IAIFOJGGPJK NFGCMBPOMHF)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60008FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E0A0", Offset = "0x5E3CEA0", VA = "0x185E3E0A0")]
	private JobHandle MIJNGBFOICO(NativeList<KBFKCEBOJDO> GAJFOOHOLOD, NativeArray<Entity> DDIFFODKOKJ, JobHandle EJGMMMMHMMK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000900")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E800", Offset = "0x5E3D600", VA = "0x185E3E800")]
	private JobHandle OBIBBDIFFGC(NativeArray<Entity> DDIFFODKOKJ, NativeArray<KBFKCEBOJDO> GAJFOOHOLOD, int NGICFBMMBFC, IAIFOJGGPJK NFGCMBPOMHF, JobHandle EJGMMMMHMMK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000901")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DB60", Offset = "0x5E3C960", VA = "0x185E3DB60")]
	public static bool HCPGPJIDBKL(ComponentType AGCPJNMOOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000902")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public PDPIIOAKLMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
[UpdateBefore(typeof(PDPIIOAKLMN))]
public class DOBCGAPDAKI : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private PAPIHHEIJJK BEEHCIODHCL;

	[Cpp2IlInjected.Token(Token = "0x600090D")]
	[Cpp2IlInjected.Address(RVA = "0x5E31A80", Offset = "0x5E30880", VA = "0x185E31A80", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090E")]
	[Cpp2IlInjected.Address(RVA = "0x5E31AD0", Offset = "0x5E308D0", VA = "0x185E31AD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600090F")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public DOBCGAPDAKI()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[MDNKGKCJEFA(LJHGMNIEOPD.OMRoom)]
	[CompilerGenerated]
	public class PostLoadInitializeNetworkIdSystem : DBMABBOGEPD, ENEHADLKBBF
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
				[Cpp2IlInjected.Address(RVA = "0x5E4CBA0", Offset = "0x5E4B9A0", VA = "0x185E4CBA0")]
				[BurstDiscard]
				private static void BDGGAJCACMB(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092A")]
				[Cpp2IlInjected.Address(RVA = "0x5E4CEC0", Offset = "0x5E4BCC0", VA = "0x185E4CEC0")]
				private static IntPtr INKJJMNPBJM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x600092B")]
				[Cpp2IlInjected.Address(RVA = "0x5E4D020", Offset = "0x5E4BE20", VA = "0x185E4D020")]
				public static void NPHJPMPOKKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092C")]
				[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
				public static void HCKCHEHGBKI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092E")]
				[Cpp2IlInjected.Address(RVA = "0x5E4CCD0", Offset = "0x5E4BAD0", VA = "0x185E4CCD0")]
				public static void FKGDFLCAOJM(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000556")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000557")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public NativeParallelHashMap<GFPOPKJOMLL, Entity> map;

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
			public ComponentTypeHandle<HFLMCEGCJME> __dstValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0x5E468A0", Offset = "0x5E456A0", VA = "0x185E468A0")]
			private void IOJGJCNCGIC(Entity entity, int entityInQueryIndex, [NoAlias] HFLMCEGCJME dstValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000924")]
			[Cpp2IlInjected.Address(RVA = "0x5E46760", Offset = "0x5E45560", VA = "0x185E46760", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0x5E46930", Offset = "0x5E45730", VA = "0x185E46930")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void JDDJFCNHKOI(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0x5E46B50", Offset = "0x5E45950", VA = "0x185E46B50")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void NDCLMIELBLG(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
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
				[Cpp2IlInjected.Address(RVA = "0x5E4D0D0", Offset = "0x5E4BED0", VA = "0x185E4D0D0")]
				[BurstDiscard]
				private static void BDGGAJCACMB(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000936")]
				[Cpp2IlInjected.Address(RVA = "0x5E4D3F0", Offset = "0x5E4C1F0", VA = "0x185E4D3F0")]
				private static IntPtr INKJJMNPBJM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000937")]
				[Cpp2IlInjected.Address(RVA = "0x5E4D550", Offset = "0x5E4C350", VA = "0x185E4D550")]
				public static void NPHJPMPOKKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000938")]
				[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
				public static void HCKCHEHGBKI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600093A")]
				[Cpp2IlInjected.Address(RVA = "0x5E4D200", Offset = "0x5E4C000", VA = "0x185E4D200")]
				public static void FKGDFLCAOJM(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400055F")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000560")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public NativeParallelHashMap<GFPOPKJOMLL, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			public ComponentTypeHandle<HFLMCEGCJME> __dstValueTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600092F")]
			[Cpp2IlInjected.Address(RVA = "0x5E46D60", Offset = "0x5E45B60", VA = "0x185E46D60")]
			private void IOJGJCNCGIC(Entity entity, [NoAlias] HFLMCEGCJME dstValue, [In][NoAlias] OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0x5E46BC0", Offset = "0x5E459C0", VA = "0x185E46BC0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000931")]
			[Cpp2IlInjected.Address(RVA = "0x5E46DD0", Offset = "0x5E45BD0", VA = "0x185E46DD0")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void JDDJFCNHKOI(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0x5E46FF0", Offset = "0x5E45DF0", VA = "0x185E46FF0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void NDCLMIELBLG(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001AC")]
		private struct PostLoadInitializeNetworkIdSystem_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public NativeParallelHashMap<GFPOPKJOMLL, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600093B")]
			[Cpp2IlInjected.Address(RVA = "0x5E47180", Offset = "0x5E45F80", VA = "0x185E47180")]
			private void IOJGJCNCGIC(Entity entity, [In] OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600093C")]
			[Cpp2IlInjected.Address(RVA = "0x5E47060", Offset = "0x5E45E60", VA = "0x185E47060", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public static readonly HICMFDICNOL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[PDOCKCLGMBB]
		private GNIFDDKOOBH networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		[PDOCKCLGMBB]
		private PAPIHHEIJJK scenes;

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
		private ComponentTypeHandle<HFLMCEGCJME> __RecRoom_Components_ObjectNetworkIdComponentData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private ComponentTypeHandle<OverrideObjectNetworkIdData> __RecRoom_Components_OverrideObjectNetworkIdData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x5E466F0", Offset = "0x5E454F0", VA = "0x185E466F0", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x5E47B80", Offset = "0x5E46980", VA = "0x185E47B80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x5E47CC0", Offset = "0x5E46AC0", VA = "0x185E47CC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x5E47290", Offset = "0x5E46090", VA = "0x185E47290")]
		public void NBDLGHFJBAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x5E48390", Offset = "0x5E47190", VA = "0x185E48390")]
		private void PFFAOCOKDAH(NativeParallelHashMap<GFPOPKJOMLL, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x5E48060", Offset = "0x5E46E60", VA = "0x185E48060")]
		private void PBHLPDCPNPG(NativeParallelHashMap<GFPOPKJOMLL, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x5E463B0", Offset = "0x5E451B0", VA = "0x185E463B0")]
		private void IIECLPGHFHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x5E46240", Offset = "0x5E45040", VA = "0x185E46240")]
		private void FMJPNHCHJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0x5E46140", Offset = "0x5E44F40", VA = "0x185E46140")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void BMEMJPDMGGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x5E46160", Offset = "0x5E44F60", VA = "0x185E46160")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void EJMNCHKDAMM(NativeParallelHashMap<GFPOPKJOMLL, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x5E465A0", Offset = "0x5E453A0", VA = "0x185E465A0")]
		private void IMDBPAIGEAK(NativeParallelHashMap<GFPOPKJOMLL, Entity> map, uint playerId, uint offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x5E488F0", Offset = "0x5E476F0", VA = "0x185E488F0")]
		private void PICFBDOIOAK(NativeParallelHashMap<GFPOPKJOMLL, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x5E47340", Offset = "0x5E46140", VA = "0x185E47340")]
		private void OOFEOJCNAHF(NativeParallelHashMap<GFPOPKJOMLL, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x5E47430", Offset = "0x5E46230", VA = "0x185E47430", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PostLoadInitializeNetworkIdSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x5E47300", Offset = "0x5E46100", VA = "0x185E47300")]
		public static void OAMMLNLLFJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x5E46560", Offset = "0x5E45360", VA = "0x185E46560")]
		public static void IKAEBNOGDKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	public class PostLoadMoveRootsUnderParentSystem : DBMABBOGEPD
	{
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x5E48C90", Offset = "0x5E47A90", VA = "0x185E48C90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x5E48D70", Offset = "0x5E47B70", VA = "0x185E48D70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x5E48AF0", Offset = "0x5E478F0", VA = "0x185E48AF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PostLoadMoveRootsUnderParentSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	[MDNKGKCJEFA(LJHGMNIEOPD.OMRoom)]
	public class PostLoadRemapCircuitIdsSystem : DBMABBOGEPD, ENEHADLKBBF
	{
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		private struct PostLoadRemapCircuitIdsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public LGELJLLCKKD remap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			public ComponentTypeHandle<HOAJNLKDONE> __nodeTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000948")]
			[Cpp2IlInjected.Address(RVA = "0x5E49470", Offset = "0x5E48270", VA = "0x185E49470")]
			private void IOJGJCNCGIC(HOAJNLKDONE node)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0x5E493A0", Offset = "0x5E481A0", VA = "0x185E493A0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		[PDOCKCLGMBB]
		private OLMMANKNKNE serialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private EntityQuery PostLoadRemapCircuitIdsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private ComponentTypeHandle<HOAJNLKDONE> __RecRoom_Components_ObjectBoardNodeData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x5E49270", Offset = "0x5E48070", VA = "0x185E49270", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x5E49880", Offset = "0x5E48680", VA = "0x185E49880", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x5E492C0", Offset = "0x5E480C0", VA = "0x185E492C0")]
		private void JBMDBPNAKAM(LGELJLLCKKD remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x5E49190", Offset = "0x5E47F90", VA = "0x185E49190")]
		private void DFPEBMJGHFH(LGELJLLCKKD remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x5E49680", Offset = "0x5E48480", VA = "0x185E49680", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PostLoadRemapCircuitIdsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class FAEDLAEAHCA : DBMABBOGEPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x600094A")]
	[Cpp2IlInjected.Address(RVA = "0x5E346C0", Offset = "0x5E334C0", VA = "0x185E346C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094B")]
	[Cpp2IlInjected.Address(RVA = "0x5E34750", Offset = "0x5E33550", VA = "0x185E34750", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public FAEDLAEAHCA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B1")]
	[CompilerGenerated]
	public class PreSerializeDowngrade_RRObjectPrefabTypeData : DBMABBOGEPD
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
			public HDANJAJMBEO.JCKLAGFOOND<ArchetypeChunk, JGHMMKKLNOL<RRObjectPrefabV2Data>> it;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public NativeList<NBGIAMMLLME> prefabTypeData;

			[Cpp2IlInjected.Token(Token = "0x6000954")]
			[Cpp2IlInjected.Address(RVA = "0x5E4A680", Offset = "0x5E49480", VA = "0x185E4A680")]
			private void IOJGJCNCGIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000955")]
			[Cpp2IlInjected.Address(RVA = "0x5E4A670", Offset = "0x5E49470", VA = "0x185E4A670", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private EntityQuery queryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AB30", Offset = "0x5E49930", VA = "0x185E4AB30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x5E4ABD0", Offset = "0x5E499D0", VA = "0x185E4ABD0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A940", Offset = "0x5E49740", VA = "0x185E4A940")]
		private EntityCommandBufferSystem MKBINIFPCGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B5C0", Offset = "0x5E4A3C0", VA = "0x185E4B5C0")]
		private JobHandle PGOJHAMCNKG(SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO, EntityTypeHandle entityTypeHandleRO, NativeArray<ArchetypeChunk> chunksRO, NativeParallelHashMap<int, int> prefabTypeFromIndexRO, HDANJAJMBEO.JCKLAGFOOND<ArchetypeChunk, JGHMMKKLNOL<RRObjectPrefabV2Data>> it, NativeList<Entity> entities, NativeList<NBGIAMMLLME> prefabTypeData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A990", Offset = "0x5E49790", VA = "0x185E4A990", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PreSerializeDowngrade_RRObjectPrefabTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B3")]
	[CompilerGenerated]
	public class PreSerializeConditionTagsSystem : DBMABBOGEPD, ENEHADLKBBF
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
			[Cpp2IlInjected.Address(RVA = "0x5E49B40", Offset = "0x5E48940", VA = "0x185E49B40")]
			private void IOJGJCNCGIC(Entity entity, OACFAECLOFC tags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095D")]
			[Cpp2IlInjected.Address(RVA = "0x5E49D30", Offset = "0x5E48B30", VA = "0x185E49D30")]
			public void OKGBGOHBAKN(EntityQuery query)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		[PDOCKCLGMBB]
		private JNDGIDLEBEK spawnableToolDependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		[PDOCKCLGMBB]
		private KAFALIKLKOG singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		[PDOCKCLGMBB]
		private CCAABBKKMFL objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private EntityQuery PreSerializeConditionTagsSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private EntityQuery __query_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private ComponentTypeHandle<OACFAECLOFC> __RecRoom_Components_PersistentUserTagData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x5E49AB0", Offset = "0x5E488B0", VA = "0x185E49AB0", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x5E4A330", Offset = "0x5E49130", VA = "0x185E4A330", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x5E499E0", Offset = "0x5E487E0", VA = "0x185E499E0")]
		private void HAMAHMKNIGA(Dictionary<string, int> tagToIdMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x5E49FF0", Offset = "0x5E48DF0", VA = "0x185E49FF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PreSerializeConditionTagsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B5")]
public class JEIPHHAJOHD : DBMABBOGEPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000586")]
	private EntityQuery DKFKPAJGAFK;

	[Cpp2IlInjected.Token(Token = "0x600095E")]
	[Cpp2IlInjected.Address(RVA = "0x5E38060", Offset = "0x5E36E60", VA = "0x185E38060", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600095F")]
	[Cpp2IlInjected.Address(RVA = "0x5E38110", Offset = "0x5E36F10", VA = "0x185E38110", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000960")]
	[Cpp2IlInjected.Address(RVA = "0x5E38010", Offset = "0x5E36E10", VA = "0x185E38010")]
	private EntityCommandBufferSystem LBILBKBMPOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000961")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public JEIPHHAJOHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
[AlwaysUpdateSystem]
public class BPANKACJADN : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x6000962")]
	[Cpp2IlInjected.Address(RVA = "0x5E30DA0", Offset = "0x5E2FBA0", VA = "0x185E30DA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000963")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public BPANKACJADN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public class FGPGLOLEMMD : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x4000587")]
	private static HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000588")]
	private EntityQuery GJGEIEBDBGO;

	[Cpp2IlInjected.Token(Token = "0x6000964")]
	[Cpp2IlInjected.Address(RVA = "0x5E352E0", Offset = "0x5E340E0", VA = "0x185E352E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000965")]
	[Cpp2IlInjected.Address(RVA = "0x5E35560", Offset = "0x5E34360", VA = "0x185E35560", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000966")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public FGPGLOLEMMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
public class NPJNINPOFCE : ILBBJHAOAMI
{
	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CB50", Offset = "0x5E3B950", VA = "0x185E3CB50", Slot = "14")]
	protected override EntityCommandBufferSystem MKBINIFPCGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000969")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AD50", Offset = "0x5E39B50", VA = "0x185E3AD50")]
	public NPJNINPOFCE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B9")]
	[CompilerGenerated]
	public class PreSerializeSaveNetworkIdsSystem : DBMABBOGEPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B9F0", Offset = "0x5E4A7F0", VA = "0x185E4B9F0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x5E4BA80", Offset = "0x5E4A880", VA = "0x185E4BA80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B800", Offset = "0x5E4A600", VA = "0x185E4B800")]
		private EntityCommandBufferSystem LBILBKBMPOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B850", Offset = "0x5E4A650", VA = "0x185E4B850", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PreSerializeSaveNetworkIdsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[CompilerGenerated]
	public class PreSerializeTransformRootsSystem : DBMABBOGEPD
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
			public ComponentTypeHandle<LMOBHKOOHGM> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000975")]
			[Cpp2IlInjected.Address(RVA = "0x5E2C6D0", Offset = "0x5E2B4D0", VA = "0x185E2C6D0")]
			private void IOJGJCNCGIC([NoAlias] LMOBHKOOHGM data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000976")]
			[Cpp2IlInjected.Address(RVA = "0x5E4C030", Offset = "0x5E4AE30", VA = "0x185E4C030", Slot = "4")]
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
			public ComponentTypeHandle<GKEHOBJBFLL> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000977")]
			[Cpp2IlInjected.Address(RVA = "0x5E2B2F0", Offset = "0x5E2A0F0", VA = "0x185E2B2F0")]
			private void IOJGJCNCGIC([NoAlias] GKEHOBJBFLL data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000978")]
			[Cpp2IlInjected.Address(RVA = "0x5E4C100", Offset = "0x5E4AF00", VA = "0x185E4C100", Slot = "4")]
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
		private ComponentTypeHandle<LMOBHKOOHGM> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private ComponentTypeHandle<GKEHOBJBFLL> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C8C0", Offset = "0x5E4B6C0", VA = "0x185E4C8C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C1D0", Offset = "0x5E4AFD0", VA = "0x185E4C1D0")]
		private void OGCPPFJNLKP([In] AGHGNCPPGHC transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0x5E4BE00", Offset = "0x5E4AC00", VA = "0x185E4BE00")]
		private JobHandle BMLNCKKHINI(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0x5E4BF30", Offset = "0x5E4AD30", VA = "0x185E4BF30")]
		private JobHandle EJNGEJFAPDG(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C3F0", Offset = "0x5E4B1F0", VA = "0x185E4C3F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PreSerializeTransformRootsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BD")]
[AlwaysUpdateSystem]
public class FBLOJFINGNI : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x5E347E0", Offset = "0x5E335E0", VA = "0x185E347E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public FBLOJFINGNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public static class KPELNJJPMEB
{
	[Cpp2IlInjected.Token(Token = "0x20001BF")]
	[BurstCompile]
	private struct CMABFFJBKAG : IJob, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		[ReadOnly]
		public NativeParallelHashSet<int> DKKDBJCAEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> IGLIEKIMGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public NativeList<EntityArchetype> LJBPODJCCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public NativeList<IAIFOJGGPJK> CDKPJPDPMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public NativeList<IAIFOJGGPJK> AJOLCAKGFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public NativeList<ComponentType> JCPKMMOKJGG;

		[Cpp2IlInjected.Token(Token = "0x6000985")]
		[Cpp2IlInjected.Address(RVA = "0x5E51640", Offset = "0x5E50440", VA = "0x185E51640", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000986")]
		[Cpp2IlInjected.Address(RVA = "0x5E515B0", Offset = "0x5E503B0", VA = "0x185E515B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x5E39E50", Offset = "0x5E38C50", VA = "0x185E39E50")]
	public static NativeParallelHashSet<int> BMGHACNBHHA(Allocator MBGJLDPPIJN)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A230", Offset = "0x5E39030", VA = "0x185E3A230")]
	public static NativeParallelHashSet<int> DLBGBNCBIPH(Allocator MBGJLDPPIJN)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A370", Offset = "0x5E39170", VA = "0x185E3A370")]
	private static void EPOOIBFEEKC(NativeParallelHashSet<int> ADJNHCLNKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x5E39F10", Offset = "0x5E38D10", VA = "0x185E39F10")]
	private static bool CDNBFNFJJIJ(Type FLHOFPAHPKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A6E0", Offset = "0x5E394E0", VA = "0x185E3A6E0")]
	private static void GKPCMCIHBKM(NativeParallelHashSet<int> ADJNHCLNKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A920", Offset = "0x5E39720", VA = "0x185E3A920")]
	private static void LLEEHPKGCOM(NativeParallelHashSet<int> ADJNHCLNKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x5E39FF0", Offset = "0x5E38DF0", VA = "0x185E39FF0")]
	private static void DGDKOINCNOF(NativeParallelHashSet<int> ADJNHCLNKGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x5E39550", Offset = "0x5E38350", VA = "0x185E39550")]
	public static void AGENAJHFMEH(EntityManager GMDAKDJOHKE, EntityQuery GJGJMLNNIOK, NativeParallelHashSet<int> EPIHMANGDEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AB60", Offset = "0x5E39960", VA = "0x185E3AB60")]
	public static void MFFKLMBBLBF(EntityManager GMDAKDJOHKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public static class HJFMDIHKEFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x5E54BC0", Offset = "0x5E539C0", VA = "0x185E54BC0")]
	public static NativeParallelHashSet<int> KCNPNEEOEEL(EntityManager GMDAKDJOHKE, Allocator MBGJLDPPIJN)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x5E550B0", Offset = "0x5E53EB0", VA = "0x185E550B0")]
	public static NativeParallelHashMap<int, int> MBJCGNBLJCF(EntityManager GMDAKDJOHKE, Allocator MBGJLDPPIJN)
	{
		return default(NativeParallelHashMap<int, int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
public abstract class ILBBJHAOAMI : DBMABBOGEPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	private EntityQuery GJGJMLNNIOK;

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract EntityCommandBufferSystem MKBINIFPCGA();

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x5E55F30", Offset = "0x5E54D30", VA = "0x185E55F30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098B")]
	[Cpp2IlInjected.Address(RVA = "0x5E55FC0", Offset = "0x5E54DC0", VA = "0x185E55FC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098C")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	protected ILBBJHAOAMI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001C2")]
public struct HIAAMIPNAIA : CHEGBPBCJJE<ParentData>
{
	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x5E54B90", Offset = "0x5E53990", VA = "0x185E54B90", Slot = "4")]
	public bool LPCEPMDACBO(ParentData POACLGOFKAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
[BurstCompile]
public struct JGHMMKKLNOL<T> : IEqualityComparer<ArchetypeChunk> where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	[ReadOnly]
	public SharedComponentTypeHandle<T> ELGONBFFAGA;

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x1649990", Offset = "0x1648790", VA = "0x181649990")]
	public JGHMMKKLNOL(SharedComponentTypeHandle<T> ELGONBFFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x3855000", Offset = "0x3853E00", VA = "0x183855000", Slot = "4")]
	public bool Equals(ArchetypeChunk NPDPLEIHBMM, ArchetypeChunk CINKHPOEGPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000990")]
	[Cpp2IlInjected.Address(RVA = "0x3855100", Offset = "0x3853F00", VA = "0x183855100", Slot = "5")]
	public int GetHashCode(ArchetypeChunk PKPEFKLAONK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
public struct NKLFMHFHNDB<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	private FFFGNJDCJAI<T> FBJEHMGCPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	private EntityCommandBuffer LLLOCGMAOIH;

	[Cpp2IlInjected.Token(Token = "0x6000991")]
	[Cpp2IlInjected.Address(RVA = "0x35DE7A0", Offset = "0x35DD5A0", VA = "0x1835DE7A0")]
	public NKLFMHFHNDB(FFFGNJDCJAI<T> FBJEHMGCPKI, EntityCommandBuffer LLLOCGMAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000992")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2C00", Offset = "0x3BF1A00", VA = "0x183BF2C00", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x3391890", Offset = "0x3390690", VA = "0x183391890")]
	public static FFFGNJDCJAI<T> KFCNDMGKJHB(NKLFMHFHNDB<T> ABBNPGBNHJD)
	{
		return default(FFFGNJDCJAI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
public struct JFMGIICFIGK<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A0")]
	private DHBIAAOJNPE<T> FBJEHMGCPKI;

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0x384C2A0", Offset = "0x384B0A0", VA = "0x18384C2A0")]
	public JFMGIICFIGK(DHBIAAOJNPE<T> FBJEHMGCPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0x384C1B0", Offset = "0x384AFB0", VA = "0x18384C1B0")]
	public NKLFMHFHNDB<T> AJCDDBHHNNC()
	{
		return default(NKLFMHFHNDB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C6")]
public struct HIICAJGBODO<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	private FFFGNJDCJAI<T> FBJEHMGCPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A2")]
	private EntityCommandBuffer LLLOCGMAOIH;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public FFFGNJDCJAI<T> LHPHMONAAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x3391890", Offset = "0x3390690", VA = "0x183391890")]
		get
		{
			return default(FFFGNJDCJAI<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000997")]
	[Cpp2IlInjected.Address(RVA = "0x35DE7A0", Offset = "0x35DD5A0", VA = "0x1835DE7A0")]
	public HIICAJGBODO(FFFGNJDCJAI<T> FBJEHMGCPKI, EntityCommandBuffer LLLOCGMAOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000998")]
	[Cpp2IlInjected.Address(RVA = "0x35DD7C0", Offset = "0x35DC5C0", VA = "0x1835DD7C0")]
	public void DECDCAAHMKN(DHBIAAOJNPE<T> ADEACNPFCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000999")]
	[Cpp2IlInjected.Address(RVA = "0x35DE2A0", Offset = "0x35DD0A0", VA = "0x1835DE2A0", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600099A")]
	[Cpp2IlInjected.Address(RVA = "0x3391890", Offset = "0x3390690", VA = "0x183391890")]
	public static FFFGNJDCJAI<T> KFCNDMGKJHB(HIICAJGBODO<T> ABBNPGBNHJD)
	{
		return default(FFFGNJDCJAI<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C7")]
public struct CONCCCIHFGK<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A3")]
	private DHBIAAOJNPE<T> FBJEHMGCPKI;

	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0x384C2A0", Offset = "0x384B0A0", VA = "0x18384C2A0")]
	public CONCCCIHFGK(DHBIAAOJNPE<T> FBJEHMGCPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AD00", Offset = "0x4A39B00", VA = "0x184A3AD00")]
	public HIICAJGBODO<T> IGFBOFFJNDD()
	{
		return default(HIICAJGBODO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C8")]
[DefaultMember("Item")]
public struct FFFGNJDCJAI<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A4")]
	public NativeList<Entity> DDIFFODKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A5")]
	public NativeList<T> LMCJHCIOIIP;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public int GFHGMKIJCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x33A4340", Offset = "0x33A3140", VA = "0x1833A4340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public (Entity entity, T value) CNLGKPLLPHE
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x33A3660", Offset = "0x33A2460", VA = "0x1833A3660")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099F")]
	[Cpp2IlInjected.Address(RVA = "0x33A2AB0", Offset = "0x33A18B0", VA = "0x1833A2AB0")]
	public void EJEJBLJEAIN(Entity HHHGBIJCKBC, T POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A0")]
	[Cpp2IlInjected.Address(RVA = "0x33A39E0", Offset = "0x33A27E0", VA = "0x1833A39E0")]
	public void KLGCAOGBKEK(NativeArray<Entity> HHHGBIJCKBC, NativeArray<T> POACLGOFKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C9")]
public struct DHBIAAOJNPE<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A6")]
	[ReadOnly]
	public EntityQueryInJob GJGJMLNNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A7")]
	[ReadOnly]
	public EntityTypeHandle ONLJGFNDNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A8")]
	[ReadOnly]
	public ComponentTypeHandle<T> KPEHCPLFLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A9")]
	[WriteOnly]
	public EntityCommandBuffer LLLOCGMAOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005AA")]
	public AllocatorManager.AllocatorHandle MBGJLDPPIJN;

	[Cpp2IlInjected.Token(Token = "0x60009A1")]
	[Cpp2IlInjected.Address(RVA = "0x4C637D0", Offset = "0x4C625D0", VA = "0x184C637D0")]
	public FFFGNJDCJAI<T> AJCDDBHHNNC()
	{
		return default(FFFGNJDCJAI<T>);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001CA")]
	[CompilerGenerated]
	public class SplineGeometryVersionSystem : DBMABBOGEPD
	{
		[Cpp2IlInjected.Token(Token = "0x20001CB")]
		private struct SplinePointGeometryVersionJob : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			[ReadOnly]
			public ComponentTypeHandle<LNMINBHKCKD> positionDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			[ReadOnly]
			public ComponentTypeHandle<COFPHJFJKHO> rotationDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			[ReadOnly]
			public ComponentTypeHandle<OKDPLEMLFKK> scaleDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			[ReadOnly]
			public ComponentTypeHandle<MDLBCMGPBBP> splinePointParentDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			public ComponentDataFromEntity<BJPHEDCKDGP> geometryVersionFromEntityRW;

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
			[Cpp2IlInjected.Address(RVA = "0x5E6B620", Offset = "0x5E6A420", VA = "0x185E6B620", Slot = "4")]
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
			public ComponentTypeHandle<BJPHEDCKDGP> __geometryVersionDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009A8")]
			[Cpp2IlInjected.Address(RVA = "0x2980040", Offset = "0x297EE40", VA = "0x182980040")]
			private void IOJGJCNCGIC([NoAlias] BJPHEDCKDGP geometryVersionData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A9")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AE40", Offset = "0x5E69C40", VA = "0x185E6AE40", Slot = "4")]
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
		private ComponentTypeHandle<BJPHEDCKDGP> __RecRoom_Components_SplineGeometryVersionData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B160", Offset = "0x5E69F60", VA = "0x185E6B160", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B280", Offset = "0x5E6A080", VA = "0x185E6B280", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AD40", Offset = "0x5E69B40", VA = "0x185E6AD40")]
		private JobHandle EGBBPLCKKMC(uint thisSystemVersion, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AF10", Offset = "0x5E69D10", VA = "0x185E6AF10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A6")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public SplineGeometryVersionSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001CD")]
	[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
	[CompilerGenerated]
	internal class SplinePointOrderingUpdateSystem : DBMABBOGEPD, ENEHADLKBBF
	{
		[Cpp2IlInjected.Token(Token = "0x20001CE")]
		[BurstCompile]
		private struct AddSplinePointInsertsIndiciesJob : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BD")]
			[ReadOnly]
			public NativeArray<global::GFAMIIBKJBJ> indexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005BE")]
			[ReadOnly]
			public ComponentDataFromEntity<MDLBCMGPBBP> splinePointParentDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			public ComponentDataFromEntity<OPJBGANEPIB> splinePointOrderDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.Token(Token = "0x60009B3")]
			[Cpp2IlInjected.Address(RVA = "0x5E4FDB0", Offset = "0x5E4EBB0", VA = "0x185E4FDB0", Slot = "4")]
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
			public ComponentDataFromEntity<OPJBGANEPIB> orderRO;

			[Cpp2IlInjected.Token(Token = "0x60009B4")]
			[Cpp2IlInjected.Address(RVA = "0x5E67170", Offset = "0x5E65F70", VA = "0x185E67170", Slot = "4")]
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
			public ComponentTypeHandle<BJPHEDCKDGP> __versionDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009B5")]
			[Cpp2IlInjected.Address(RVA = "0x5E6C0A0", Offset = "0x5E6AEA0", VA = "0x185E6C0A0")]
			private void IOJGJCNCGIC(DynamicBuffer<LinkedEntityGroup> buffer, [NoAlias] BJPHEDCKDGP versionData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E6BF50", Offset = "0x5E6AD50", VA = "0x185E6BF50", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private EntityQuery needsUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		[PDOCKCLGMBB]
		private KAFALIKLKOG singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private EntityQuery SplinePointOrderingUpdateSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private ComponentTypeHandle<BJPHEDCKDGP> __RecRoom_Components_SplineGeometryVersionData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BF00", Offset = "0x5E6AD00", VA = "0x185E6BF00", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C540", Offset = "0x5E6B340", VA = "0x185E6C540", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B7C0", Offset = "0x5E6A5C0", VA = "0x185E6B7C0")]
		private void AFDMAKDMDLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BC70", Offset = "0x5E6AA70", VA = "0x185E6BC70")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void GNMOMOCDKGN(NativeArray<global::GFAMIIBKJBJ> indexUpdatesRO, ComponentDataFromEntity<MDLBCMGPBBP> splinePointParentDataRO, ComponentDataFromEntity<OPJBGANEPIB> splinePointOrderDataRW, BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C140", Offset = "0x5E6AF40", VA = "0x185E6C140")]
		private void OEPDOJAFHKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BDC0", Offset = "0x5E6ABC0", VA = "0x185E6BDC0")]
		private static GLGCLMKBLKL HNJEIEDAFPO(int insertionIndex, ComponentDataFromEntity<OPJBGANEPIB> splinePointOrderDataRO, NativeArray<Entity> children)
		{
			return default(GLGCLMKBLKL);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BB20", Offset = "0x5E6A920", VA = "0x185E6BB20")]
		private JobHandle BNIGKCHBHEK(OrderComparer comparer, uint thisSystemVersion, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C2D0", Offset = "0x5E6B0D0", VA = "0x185E6C2D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public SplinePointOrderingUpdateSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001D1")]
	[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
	[CompilerGenerated]
	internal class SplinePointParentChangedSystem : DBMABBOGEPD, ENEHADLKBBF
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
			public DynamicBuffer<global::GFAMIIBKJBJ> splineIndexUpdatesRO;

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
			public ComponentTypeHandle<MDLBCMGPBBP> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x5E6CD90", Offset = "0x5E6BB90", VA = "0x185E6CD90")]
			private void IOJGJCNCGIC(Entity splinePoint, [In][NoAlias] MDLBCMGPBBP splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0x5E6CC70", Offset = "0x5E6BA70", VA = "0x185E6CC70", Slot = "4")]
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
			public ComponentTypeHandle<global::GBHFKGKBLOK> __splinePointParentSystemDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009C3")]
			[Cpp2IlInjected.Address(RVA = "0x5E6D030", Offset = "0x5E6BE30", VA = "0x185E6D030")]
			private void IOJGJCNCGIC(Entity splinePoint, [In][NoAlias] global::GBHFKGKBLOK splinePointParentSystemData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C4")]
			[Cpp2IlInjected.Address(RVA = "0x5E6CF10", Offset = "0x5E6BD10", VA = "0x185E6CF10", Slot = "4")]
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
		[PDOCKCLGMBB]
		private KAFALIKLKOG singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private ComponentTypeHandle<MDLBCMGPBBP> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private ComponentTypeHandle<global::GBHFKGKBLOK> __RecRoom_Components_SplinePointParentSystemData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C980", Offset = "0x5E6B780", VA = "0x185E6C980", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D560", Offset = "0x5E6C360", VA = "0x185E6D560", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D550", Offset = "0x5E6C350", VA = "0x185E6D550", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C9D0", Offset = "0x5E6B7D0", VA = "0x185E6C9D0")]
		private void LAELDBMFGGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D580", Offset = "0x5E6C380", VA = "0x185E6D580")]
		private void PJHAOFGLBPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D160", Offset = "0x5E6BF60", VA = "0x185E6D160")]
		private EntityCommandBufferSystem MKBINIFPCGA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C6E0", Offset = "0x5E6B4E0", VA = "0x185E6C6E0")]
		private JobHandle DDJKOHFHOLD(EntityCommandBuffer ecb, DynamicBuffer<global::GFAMIIBKJBJ> splineIndexUpdatesRO, BufferFromEntity<LinkedEntityGroup> linkedEntityGroupByEntity, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C850", Offset = "0x5E6B650", VA = "0x185E6C850")]
		private JobHandle FNIEJEBCACE(BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D1B0", Offset = "0x5E6BFB0", VA = "0x185E6D1B0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public SplinePointParentChangedSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal sealed class AGALDIJCGAJ : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E330", Offset = "0x5E4D130", VA = "0x185E4E330", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public AGALDIJCGAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal sealed class DDGMPDIHJMD : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E51B50", Offset = "0x5E50950", VA = "0x185E51B50", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public DDGMPDIHJMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal sealed class EOAPCHGAAGG : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E528F0", Offset = "0x5E516F0", VA = "0x185E528F0", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public EOAPCHGAAGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal sealed class JMJNNBJIFAJ : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A540", Offset = "0x5E59340", VA = "0x185E5A540", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public JMJNNBJIFAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal sealed class EDDLADBJGCC : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E523D0", Offset = "0x5E511D0", VA = "0x185E523D0", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public EDDLADBJGCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal sealed class AODPOKEHLKK : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FAC0", Offset = "0x5E4E8C0", VA = "0x185E4FAC0", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public AODPOKEHLKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
[ExecuteAlways]
public class BMHCKKNLGMA : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	public BMHCKKNLGMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal sealed class PAHOGHIHLGA : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E671F0", Offset = "0x5E65FF0", VA = "0x185E671F0", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public PAHOGHIHLGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
internal class IKGOEMGHEIC : MOBNIBIKMKJ
{
	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public IKGOEMGHEIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DD")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal sealed class JAOFDGIGAIK : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E58200", Offset = "0x5E57000", VA = "0x185E58200", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public JAOFDGIGAIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DE")]
internal class PIBIBOGGALP : MOBNIBIKMKJ
{
	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public PIBIBOGGALP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DF")]
internal class HLGAFNCFDHO : MOBNIBIKMKJ
{
	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public HLGAFNCFDHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E0")]
public sealed class NEAGAHENBEK : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FEE0", Offset = "0x5E5ECE0", VA = "0x185E5FEE0", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public NEAGAHENBEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E1")]
[ExecuteAlways]
public class JCKLIMAKHJH : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	public JCKLIMAKHJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
public class EOIICCBEBIO : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public EOIICCBEBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E3")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
[MPJBDEDKJDC]
public class IELEMMKNOEI : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private FNOCCIFKHLE MJDGLHMPNEP;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E558C0", Offset = "0x5E546C0", VA = "0x185E558C0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E55910", Offset = "0x5E54710", VA = "0x185E55910", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public IELEMMKNOEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E4")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public class HDIHBEIOGAG : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x20001E5")]
	[BurstCompile]
	private struct MDMGIDMKEPP : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		[ReadOnly]
		public NativeArray<Entity> DDIFFODKOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<LMOBHKOOHGM> KKIDBJDDGAI;

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D870", Offset = "0x5E5C670", VA = "0x185E5D870", Slot = "4")]
		public void Execute(int OCMJNDDMDAL, TransformAccess ILMBKONFEEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DA40", Offset = "0x5E5C840", VA = "0x185E5DA40")]
		private bool JHNADNNJHLB(float3 LMBCAMGCODH, float3 ICMOHCKEJOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DA70", Offset = "0x5E5C870", VA = "0x185E5DA70")]
		private bool OBAPLMACLBN(quaternion LMBCAMGCODH, quaternion ICMOHCKEJOO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001E6")]
	[BurstCompile]
	private struct CNDEJCFGEMJ : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		[ReadOnly]
		public NativeArray<Entity> DDIFFODKOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<GKEHOBJBFLL> GKNAEFMGCFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<EHOKBACLKBI> FGEFAOCAJAL;

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E518F0", Offset = "0x5E506F0", VA = "0x185E518F0", Slot = "4")]
		public void Execute(int OCMJNDDMDAL, TransformAccess ILMBKONFEEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	private static readonly HICMFDICNOL ELJFFFANDKE;

	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	private static readonly HICMFDICNOL AIFMBCGOGIN;

	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	private static readonly HICMFDICNOL AELJMGIBJME;

	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private static readonly ProfilerMarker KOJGODHHLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private JCAPAODMBEM NPIFIPIJBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E545C0", Offset = "0x5E533C0", VA = "0x185E545C0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E54630", Offset = "0x5E53430", VA = "0x185E54630", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E54670", Offset = "0x5E53470", VA = "0x185E54670", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public HDIHBEIOGAG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001E7")]
	[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
	[CompilerGenerated]
	public class RegisterTransformsSystem : DBMABBOGEPD, ENEHADLKBBF
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
			public ComponentTypeHandle<BMKEBCADHBB> __arrayIndexTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			public ComponentTypeHandle<Transform> __transformTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009F8")]
			[Cpp2IlInjected.Address(RVA = "0x5E69C30", Offset = "0x5E68A30", VA = "0x185E69C30")]
			private void OriginalLambdaBody(Entity entity, [In] BMKEBCADHBB arrayIndex, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0x5E69A40", Offset = "0x5E68840", VA = "0x185E69A40", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private JCAPAODMBEM embodiedTransforms;

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
		private ComponentTypeHandle<BMKEBCADHBB> __RecRoom_Components_TransformAccessArrayIndexData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E699F0", Offset = "0x5E687F0", VA = "0x185E699F0", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E69F40", Offset = "0x5E68D40", VA = "0x185E69F40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A210", Offset = "0x5E69010", VA = "0x185E6A210", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E69600", Offset = "0x5E68400", VA = "0x185E69600")]
		private void AddTransforms(EntityQuery query, GENLCCCIOIL accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A520", Offset = "0x5E69320", VA = "0x185E6A520")]
		private void RemoveTransforms(EntityQuery query, GENLCCCIOIL accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A180", Offset = "0x5E68F80", VA = "0x185E6A180", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E694A0", Offset = "0x5E682A0", VA = "0x185E694A0")]
		private void AddNewTransforms(NativeArray<Entity> entities, GENLCCCIOIL accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A300", Offset = "0x5E69100", VA = "0x185E6A300")]
		internal static void RemoveOldTransforms(NativeArray<BMKEBCADHBB> arrayIndices, ComponentDataFromEntity<BMKEBCADHBB> transformAccess, GENLCCCIOIL accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F2")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
		private static void DebugLogRemove(int index, GENLCCCIOIL accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E698A0", Offset = "0x5E686A0", VA = "0x185E698A0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DebugLogUninitializedTransformAccessArrayIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E698A0", Offset = "0x5E686A0", VA = "0x185E698A0")]
		private void RegisterTransformsSystem_LambdaJob_0_Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E69D40", Offset = "0x5E68B40", VA = "0x185E69D40", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F6")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public RegisterTransformsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EA")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public class IPHICNKKMPE : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x20001EB")]
	[BurstCompile]
	private struct HJHMDLODCEC : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		[ReadOnly]
		public ComponentDataFromEntity<LMOBHKOOHGM> KKIDBJDDGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		[ReadOnly]
		public NativeArray<Entity> DDIFFODKOKJ;

		[Cpp2IlInjected.Token(Token = "0x6000A04")]
		[Cpp2IlInjected.Address(RVA = "0x5E55560", Offset = "0x5E54360", VA = "0x185E55560", Slot = "4")]
		public void Execute(int OCMJNDDMDAL, TransformAccess ILMBKONFEEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	[BurstCompile]
	private struct LJNMMKIIDNG : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		[ReadOnly]
		public ComponentDataFromEntity<GKEHOBJBFLL> GKNAEFMGCFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		[ReadOnly]
		public NativeArray<Entity> DDIFFODKOKJ;

		[Cpp2IlInjected.Token(Token = "0x6000A05")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D230", Offset = "0x5E5C030", VA = "0x185E5D230", Slot = "4")]
		public void Execute(int OCMJNDDMDAL, TransformAccess ILMBKONFEEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001ED")]
	[BurstCompile]
	private struct HPADKBCNPLK : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		[ReadOnly]
		public ComponentDataFromEntity<GKEHOBJBFLL> GKNAEFMGCFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		[ReadOnly]
		public ComponentDataFromEntity<EHOKBACLKBI> FGEFAOCAJAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		[ReadOnly]
		public NativeArray<Entity> DDIFFODKOKJ;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x5E55640", Offset = "0x5E54440", VA = "0x185E55640", Slot = "4")]
		public void Execute(int OCMJNDDMDAL, TransformAccess ILMBKONFEEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005EF")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x40005F0")]
	private static readonly HICMFDICNOL ELJFFFANDKE;

	[Cpp2IlInjected.Token(Token = "0x40005F1")]
	private static readonly HICMFDICNOL AIFMBCGOGIN;

	[Cpp2IlInjected.Token(Token = "0x40005F2")]
	private static readonly HICMFDICNOL AELJMGIBJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F3")]
	private JCAPAODMBEM NPIFIPIJBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private EntityQuery GPGMNJMOMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005F5")]
	private EntityQuery MBAMFOABLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005F6")]
	private EntityQuery KKNNJANMDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005F7")]
	private TransformAccessArray MJDMAIEBLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private TransformAccessArray OGDEEPGAIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005F9")]
	private TransformAccessArray EMDDEFFLCLD;

	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E571E0", Offset = "0x5E55FE0", VA = "0x185E571E0", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E573B0", Offset = "0x5E561B0", VA = "0x185E573B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E575C0", Offset = "0x5E563C0", VA = "0x185E575C0", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E57650", Offset = "0x5E56450", VA = "0x185E57650", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x5E57680", Offset = "0x5E56480", VA = "0x185E57680", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0x5E57230", Offset = "0x5E56030", VA = "0x185E57230")]
	private NativeArray<Entity> JEMFADBBHDL(NativeArray<BMKEBCADHBB> FEIMIFBBIKL, NativeList<Entity> GECODIGACIA, TransformAccessArray BBGHEGFAKFJ, TransformAccessArray JMNHDNHMDGL)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A02")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public IPHICNKKMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EE")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public class ILNLAAGFHAN : DBMABBOGEPD, GOMKIFEKCFK
{
	[Cpp2IlInjected.Token(Token = "0x4000601")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000602")]
	private JDGDANEDDKA LEAHHBMJDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000603")]
	private JNOBPLOAHCA IMNBHGEKNIE;

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B770", Offset = "0x5E3A570", VA = "0x185E3B770", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x5E56410", Offset = "0x5E55210", VA = "0x185E56410", Slot = "14")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x5E56720", Offset = "0x5E55520", VA = "0x185E56720", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x5E56510", Offset = "0x5E55310", VA = "0x185E56510")]
	private static void KLMHFNDKNPM(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, Entity LPDGANJNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x5E56680", Offset = "0x5E55480", VA = "0x185E56680")]
	private static bool OMALGOFDFEG(EntityManager GMDAKDJOHKE, Entity HHHGBIJCKBC, [Out] Transform ILMBKONFEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public ILNLAAGFHAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EF")]
public class IKLDNODMMDO : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x20001F0")]
	[BurstCompile]
	private struct DINMANILKMC : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		[ReadOnly]
		public ComponentTypeHandle<FMBCLJELFDP> NBBPEKPDGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		[ReadOnly]
		public BufferTypeHandle<ChildrenData> PNHMGGDACKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> BJIICIHIEMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		[ReadOnly]
		public ComponentDataFromEntity<FMBCLJELFDP> BJJPLLBJPJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public ComponentTypeHandle<JNGNBCKOIMO> LMGMNMPOOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<JNGNBCKOIMO> ALMPMFLPAHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public uint ENCFLFLAEED;

		[Cpp2IlInjected.Token(Token = "0x6000A12")]
		[Cpp2IlInjected.Address(RVA = "0x5E520D0", Offset = "0x5E50ED0", VA = "0x185E520D0", Slot = "4")]
		public void Execute(ArchetypeChunk PKPEFKLAONK, int OCMJNDDMDAL, int PGCNKLLBBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A13")]
		[Cpp2IlInjected.Address(RVA = "0x5E51CF0", Offset = "0x5E50AF0", VA = "0x185E51CF0")]
		private void ACPELMEGBPC(float4x4 EJEGFOFAOLD, Entity HHHGBIJCKBC, bool APCJJJFBOBI, int OBEANJHCKOF = 1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	private EntityQuery OONAAHIKAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	private EntityQuery LLDNHADNCJP;

	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x5E55AD0", Offset = "0x5E548D0", VA = "0x185E55AD0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x5E55C00", Offset = "0x5E54A00", VA = "0x185E55C00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public IKLDNODMMDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F1")]
public class IPBKPGPLJBK : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x20001F2")]
	[BurstCompile]
	private struct IIOLMBMBEGD : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		[ReadOnly]
		public ComponentTypeHandle<FMBCLJELFDP> NBBPEKPDGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		public ComponentTypeHandle<JNGNBCKOIMO> LMGMNMPOOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		public uint ENCFLFLAEED;

		[Cpp2IlInjected.Token(Token = "0x6000A17")]
		[Cpp2IlInjected.Address(RVA = "0x5E559C0", Offset = "0x5E547C0", VA = "0x185E559C0", Slot = "4")]
		public void Execute(ArchetypeChunk PKPEFKLAONK, int OCMJNDDMDAL, int PGCNKLLBBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0x5E55930", Offset = "0x5E54730", VA = "0x185E55930")]
		public bool CJIHFPEMOHB(ArchetypeChunk PKPEFKLAONK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private EntityQuery OONAAHIKAAL;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x5E56F70", Offset = "0x5E55D70", VA = "0x185E56F70", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x5E570A0", Offset = "0x5E55EA0", VA = "0x185E570A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public IPBKPGPLJBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F3")]
public class EJDNBCFECMG : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x20001F4")]
	[BurstCompile]
	private struct CCMBPIJMFBH : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		[ReadOnly]
		public ComponentTypeHandle<JNGNBCKOIMO> MPGBILIGEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		public ComponentTypeHandle<FDAMELIEKPC> JJPJGKKCOBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		public ComponentTypeHandle<NAEDGOKFECF> LOILCFBJFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public ComponentTypeHandle<PEEBINOFCDG> OMHKDJBOJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public uint ENCFLFLAEED;

		[Cpp2IlInjected.Token(Token = "0x6000A1C")]
		[Cpp2IlInjected.Address(RVA = "0x5E50D40", Offset = "0x5E4FB40", VA = "0x185E50D40", Slot = "4")]
		public void Execute(ArchetypeChunk PKPEFKLAONK, int OCMJNDDMDAL, int PGCNKLLBBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A1D")]
		[Cpp2IlInjected.Address(RVA = "0x5E50CB0", Offset = "0x5E4FAB0", VA = "0x185E50CB0")]
		public bool CJIHFPEMOHB(ArchetypeChunk PKPEFKLAONK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private EntityQuery FGGAOAAIACJ;

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x5E52620", Offset = "0x5E51420", VA = "0x185E52620", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x5E52730", Offset = "0x5E51530", VA = "0x185E52730", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public EJDNBCFECMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F5")]
public class HJHHOGEOHCJ : DBMABBOGEPD
{
	[Cpp2IlInjected.Token(Token = "0x20001F6")]
	[BurstCompile]
	private struct JCENGFMJCDK : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		[ReadOnly]
		public ComponentTypeHandle<LMOBHKOOHGM> HFMLNOFNGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		[ReadOnly]
		public ComponentTypeHandle<EHOKBACLKBI> ALGAABICEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		[ReadOnly]
		public ComponentTypeHandle<GKEHOBJBFLL> KKMHPGOFLIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		public ComponentTypeHandle<FMBCLJELFDP> NNEHBOGBJAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public uint ENCFLFLAEED;

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x5E592C0", Offset = "0x5E580C0", VA = "0x185E592C0", Slot = "4")]
		public void Execute(ArchetypeChunk PKPEFKLAONK, int OCMJNDDMDAL, int PGCNKLLBBIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x5E591C0", Offset = "0x5E57FC0", VA = "0x185E591C0")]
		public bool CJIHFPEMOHB(ArchetypeChunk PKPEFKLAONK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private EntityQuery FGGAOAAIACJ;

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x5E55270", Offset = "0x5E54070", VA = "0x185E55270", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x5E553A0", Offset = "0x5E541A0", VA = "0x185E553A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public HJHHOGEOHCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F7")]
public class GODGJCFMJNE : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x400061E")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061F")]
	[PDOCKCLGMBB]
	private GCIHPKBFCDJ JEPEKDIIMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000620")]
	[PDOCKCLGMBB]
	private GNIFDDKOOBH INFNDHMCBBM;

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x5E54070", Offset = "0x5E52E70", VA = "0x185E54070", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x5E54410", Offset = "0x5E53210", VA = "0x185E54410", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x5E540E0", Offset = "0x5E52EE0", VA = "0x185E540E0")]
	private void JIIIFMFOKCP(NativeArray<GFPOPKJOMLL> CHBOJEHPMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public GODGJCFMJNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F8")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal class LEBKPBKHFOK : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000621")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000622")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000623")]
	private GCIHPKBFCDJ CEHJJGNBFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000624")]
	private ANNAAAPLMJK NAMNFILNEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000625")]
	private PEIDJIEIOHO LGOEJDFNDBM;

	[Cpp2IlInjected.Token(Token = "0x6000A28")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CC20", Offset = "0x5E5BA20", VA = "0x185E5CC20", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CCD0", Offset = "0x5E5BAD0", VA = "0x185E5CCD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public LEBKPBKHFOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F9")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public sealed class NPOGEKOJKMK : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000626")]
	private GIBPJGGCEHP AMCDJKCDDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000627")]
	private GCIHPKBFCDJ NBCMBPJPEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000628")]
	private PEIDJIEIOHO LGOEJDFNDBM;

	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0x5E62580", Offset = "0x5E61380", VA = "0x185E62580", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2D")]
	[Cpp2IlInjected.Address(RVA = "0x5E62610", Offset = "0x5E61410", VA = "0x185E62610", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public NPOGEKOJKMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FA")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal class NNILLFAKHLF : DBMABBOGEPD, ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000629")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x400062A")]
	private static readonly HICMFDICNOL COMIKHNKACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400062B")]
	[PDOCKCLGMBB]
	private EHGJMOLBODP KOPAGBBKACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400062C")]
	[PDOCKCLGMBB]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	[PDOCKCLGMBB]
	private FLHIJLBPMGI PNHOMDGKKCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	[PDOCKCLGMBB]
	private MFLLDFGILPC GIOMBIPFKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	[PDOCKCLGMBB]
	private KJNEFHMCGBH JMLFAPGHNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	[PDOCKCLGMBB]
	private HCELPLBJMPB NCJBOOFHFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private CMOPEOPPFKC.BHMAHCDKPCC HHFNKPIDPCD;

	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0x5E61A00", Offset = "0x5E60800", VA = "0x185E61A00", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A30")]
	[Cpp2IlInjected.Address(RVA = "0x5E60A50", Offset = "0x5E5F850", VA = "0x185E60A50", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A31")]
	[Cpp2IlInjected.Address(RVA = "0x5E61E70", Offset = "0x5E60C70", VA = "0x185E61E70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0x5E61270", Offset = "0x5E60070", VA = "0x185E61270")]
	private void HBDLDJIAJNJ(LNIKGFKEIBE GMOPMNAPKBE, NativeArray<byte> IMBCEPDODAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0x5E609F0", Offset = "0x5E5F7F0", VA = "0x185E609F0")]
	private bool DCMJHDFFGDD(LNIKGFKEIBE GMOPMNAPKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x5E61D20", Offset = "0x5E60B20", VA = "0x185E61D20")]
	private CMOPEOPPFKC.KFDPEDPLGJG NCPLIIMEGBN(NativeArray<byte> IMBCEPDODAI, Allocator MBGJLDPPIJN)
	{
		return default(CMOPEOPPFKC.KFDPEDPLGJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x5E61C40", Offset = "0x5E60A40", VA = "0x185E61C40")]
	private void KANMLNEBMAJ(CMOPEOPPFKC.KFDPEDPLGJG GHGGDHPIPFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0x5E607F0", Offset = "0x5E5F5F0", VA = "0x185E607F0")]
	private void AELPGBAJEKO(NativeList<GFPOPKJOMLL> LNKIEKGIJPO, NativeList<JJPHEIKOGBI> BLKDAKGGOEB, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x5E60D80", Offset = "0x5E5FB80", VA = "0x185E60D80")]
	private void GACCMLHCHLE(NativeParallelMultiHashMap<GFPOPKJOMLL, LMFJFLHHBOG> DDIHMPHDDHK, NativeList<byte> DCKDGKNBKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x5E60AF0", Offset = "0x5E5F8F0", VA = "0x185E60AF0")]
	private void FKHNECEFEBI(NativeList<GFPOPKJOMLL> BPMLECOAJOG, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0x5E61860", Offset = "0x5E60660", VA = "0x185E61860")]
	private void IPGFGHEEIGF(CMOPEOPPFKC.KFDPEDPLGJG LMCJHCIOIIP, bool IFFCGLLMPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x5E617C0", Offset = "0x5E605C0", VA = "0x185E617C0")]
	private void IACAFDLMJHN(NativeList<GFPOPKJOMLL> LNKIEKGIJPO, NativeList<JJPHEIKOGBI> BLKDAKGGOEB, bool IFFCGLLMPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0x5E61E90", Offset = "0x5E60C90", VA = "0x185E61E90")]
	private void PCLMCONFGNH(NativeParallelMultiHashMap<GFPOPKJOMLL, LMFJFLHHBOG> DDIHMPHDDHK, NativeList<byte> DCKDGKNBKJK, bool IFFCGLLMPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0x5E61BA0", Offset = "0x5E609A0", VA = "0x185E61BA0")]
	private void JECJGBNELDJ(NativeList<GFPOPKJOMLL> BPMLECOAJOG, bool IFFCGLLMPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void FKIHBFPMMPE(LNIKGFKEIBE GMOPMNAPKBE, bool IFFCGLLMPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public NNILLFAKHLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FB")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal class BPONOFMCFBI : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private OJJJKLOBGFC GGFBOHOPFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private GCIHPKBFCDJ CEHJJGNBFLE;

	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x5E50870", Offset = "0x5E4F670", VA = "0x185E50870", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0x5E508E0", Offset = "0x5E4F6E0", VA = "0x185E508E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public BPONOFMCFBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FC")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal class JLBKMFLILLK : DBMABBOGEPD, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private COAMDDAKEMC HAHKEFILEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private GCIHPKBFCDJ CEHJJGNBFLE;

	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A280", Offset = "0x5E59080", VA = "0x185E5A280", Slot = "14")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A2F0", Offset = "0x5E590F0", VA = "0x185E5A2F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public JLBKMFLILLK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001FD")]
	[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
	[AlwaysUpdateSystem]
	[CompilerGenerated]
	internal sealed class WriteDiffChangePacketToNetworkSystem : DBMABBOGEPD, ENEHADLKBBF
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
				[Cpp2IlInjected.Address(RVA = "0x5E6A830", Offset = "0x5E69630", VA = "0x185E6A830")]
				[BurstDiscard]
				private static void BDGGAJCACMB(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A62")]
				[Cpp2IlInjected.Address(RVA = "0x5E6AB30", Offset = "0x5E69930", VA = "0x185E6AB30")]
				private static IntPtr INKJJMNPBJM()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A63")]
				[Cpp2IlInjected.Address(RVA = "0x5E6AC90", Offset = "0x5E69A90", VA = "0x185E6AC90")]
				public static void NPHJPMPOKKJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A64")]
				[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
				public static void HCKCHEHGBKI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A66")]
				[Cpp2IlInjected.Address(RVA = "0x5E6A960", Offset = "0x5E69760", VA = "0x185E6A960")]
				public static void FKGDFLCAOJM(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400063F")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000640")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			public PCBHLHDFJKC replication;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			public NativeBitArray entityByProperty;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000643")]
			[ReadOnly]
			public NativeArray<GFPOPKJOMLL> srcCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000644")]
			[ReadOnly]
			public NativeArray<JJPHEIKOGBI> srcCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			[ReadOnly]
			public NativeArray<GFPOPKJOMLL> srcDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000646")]
			[ReadOnly]
			public NativeKeyValueArrays<Entity, HKOKMGPELNC> srcPropertyKeyValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000647")]
			public NativeList<GFPOPKJOMLL> dstCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000648")]
			public NativeList<JJPHEIKOGBI> dstCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000649")]
			public NativeList<GFPOPKJOMLL> dstDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400064A")]
			public NativeParallelMultiHashMap<GFPOPKJOMLL, LMFJFLHHBOG> dstProperties;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400064B")]
			public NativeList<byte> dstPropertyData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			public ComponentDataFromEntity<HFLMCEGCJME> __RecRoom_Components_ObjectNetworkIdComponentData_FromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000A5B")]
			[Cpp2IlInjected.Address(RVA = "0x5E6E650", Offset = "0x5E6D450", VA = "0x185E6E650")]
			private void IOJGJCNCGIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5C")]
			[Cpp2IlInjected.Address(RVA = "0x5E6E640", Offset = "0x5E6D440", VA = "0x185E6E640", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0x5E6EAB0", Offset = "0x5E6D8B0", VA = "0x185E6EAB0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void JDDJFCNHKOI(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0x5E6ECC0", Offset = "0x5E6DAC0", VA = "0x185E6ECC0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void NDCLMIELBLG(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private static readonly HICMFDICNOL logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		[PDOCKCLGMBB]
		private BHGJIPLOBOI packetService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		[PDOCKCLGMBB]
		private GCIHPKBFCDJ diffService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		[PDOCKCLGMBB]
		private CFKGEIBPPPD editorEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		[PDOCKCLGMBB]
		private DICMBGCFOEP transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private CMOPEOPPFKC.BHMAHCDKPCC utilServices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		private bool HasEditorListeners
		{
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		private MCKFKIDJMKM EventFlagsForPhase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4C")]
			[Cpp2IlInjected.Address(RVA = "0x5E6DEE0", Offset = "0x5E6CCE0", VA = "0x185E6DEE0")]
			get
			{
				return default(MCKFKIDJMKM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E360", Offset = "0x5E6D160", VA = "0x185E6E360", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x5E6FB60", Offset = "0x5E6E960", VA = "0x185E6FB60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E570", Offset = "0x5E6D370", VA = "0x185E6E570")]
		private bool LFBBKJCGCCM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF80", Offset = "0x5E6CD80", VA = "0x185E6DF80")]
		private bool AMCAFEHBFIJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E0A0", Offset = "0x5E6CEA0", VA = "0x185E6E0A0")]
		private bool GKKOAFGNACD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6ED10", Offset = "0x5E6DB10", VA = "0x185E6ED10")]
		private CMOPEOPPFKC.KFDPEDPLGJG MJEEAGAAIEM(HDLLCGPJIMD state)
		{
			return default(CMOPEOPPFKC.KFDPEDPLGJG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DBE0", Offset = "0x5E6C9E0", VA = "0x185E6DBE0")]
		private NativeKeyValueArrays<Entity, HKOKMGPELNC> ABIJMPLFJBA(HDLLCGPJIMD state, [Out] int capacity)
		{
			return default(NativeKeyValueArrays<Entity, HKOKMGPELNC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A50")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F5C0", Offset = "0x5E6E3C0", VA = "0x185E6F5C0")]
		private void OINKPFIJPJA(CMOPEOPPFKC.KFDPEDPLGJG data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A51")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E490", Offset = "0x5E6D290", VA = "0x185E6E490")]
		private void KFKEPNNIBIJ(CMOPEOPPFKC.KFDPEDPLGJG data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A52")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E120", Offset = "0x5E6CF20", VA = "0x185E6E120")]
		private void IPGFGHEEIGF(CMOPEOPPFKC.KFDPEDPLGJG data, HDLLCGPJIMD state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A53")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E0F0", Offset = "0x5E6CEF0", VA = "0x185E6E0F0")]
		private void IACAFDLMJHN(NativeArray<GFPOPKJOMLL> createdIds, NativeArray<JJPHEIKOGBI> creationData, MCKFKIDJMKM flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A54")]
		[Cpp2IlInjected.Address(RVA = "0x5E70000", Offset = "0x5E6EE00", VA = "0x185E70000")]
		private void PCLMCONFGNH(NativeMultiHashMapAsync<Entity, HKOKMGPELNC> differences, MCKFKIDJMKM flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A55")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E420", Offset = "0x5E6D220", VA = "0x185E6E420")]
		private void JECJGBNELDJ(NativeArray<GFPOPKJOMLL> destroyedIds, MCKFKIDJMKM flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A56")]
		[Cpp2IlInjected.Address(RVA = "0x5E707A0", Offset = "0x5E6F5A0", VA = "0x185E707A0")]
		private void PNCEMNDHKPG(PCBHLHDFJKC replication, NativeBitArray entityByProperty, NativeArray<GFPOPKJOMLL> srcCreatedIds, NativeArray<JJPHEIKOGBI> srcCreationData, NativeArray<GFPOPKJOMLL> srcDestroyedIds, NativeKeyValueArrays<Entity, HKOKMGPELNC> srcPropertyKeyValues, NativeList<GFPOPKJOMLL> dstCreatedIds, NativeList<JJPHEIKOGBI> dstCreationData, NativeList<GFPOPKJOMLL> dstDestroyedIds, NativeParallelMultiHashMap<GFPOPKJOMLL, LMFJFLHHBOG> dstProperties, NativeList<byte> dstPropertyData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A57")]
		[Cpp2IlInjected.Address(RVA = "0x5E6F8F0", Offset = "0x5E6E6F0", VA = "0x185E6F8F0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A58")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public WriteDiffChangePacketToNetworkSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E450", Offset = "0x5E6D250", VA = "0x185E6E450")]
		public static void JGLLHGPBHNG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000201")]
internal class IBGOKAOHPPD : PPHDJOMMNJK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000202")]
	public struct IJEKLHKACAG : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x400064F")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	protected override ComponentType OOIDENOGGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0x5E55740", Offset = "0x5E54540", VA = "0x185E55740", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	protected override ComponentType HAKABMAJJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0x5E557A0", Offset = "0x5E545A0", VA = "0x185E557A0", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	protected override ComponentType OELANMLMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A6A")]
		[Cpp2IlInjected.Address(RVA = "0x5E55770", Offset = "0x5E54570", VA = "0x185E55770", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x5E55860", Offset = "0x5E54660", VA = "0x185E55860")]
	public IBGOKAOHPPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000203")]
public sealed class JHJJIBDNNMK : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x5E59A30", Offset = "0x5E58830", VA = "0x185E59A30", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public JHJJIBDNNMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000204")]
[ExecuteAlways]
public class ANMKIGKIGOJ : HHGLAFOEFFN
{
	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public ANMKIGKIGOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000205")]
public sealed class BBMAJIPBGDC : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x5E50110", Offset = "0x5E4EF10", VA = "0x185E50110", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public BBMAJIPBGDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000206")]
public sealed class KNONKKGBNHA : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C550", Offset = "0x5E5B350", VA = "0x185E5C550", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public KNONKKGBNHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000207")]
[ExecuteAlways]
public class HECICGFIOLB : HHGLAFOEFFN
{
	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
	public HECICGFIOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000208")]
public sealed class AOJAJKDLLHP : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FCE0", Offset = "0x5E4EAE0", VA = "0x185E4FCE0", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A75")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public AOJAJKDLLHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000209")]
[BNEEAEKLIEP(typeof(LNONMHFEMMB))]
[PMDCDBMECJP(typeof(NKBJOPBBMIN), new string[] { })]
public class FMIIKJOJEED : NKBJOPBBMIN, EPBKMCPBINK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	private readonly Dictionary<int, KHNKJBOEAPI> PCLEEMOAGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	private readonly Dictionary<Type, KHNKJBOEAPI> MDNKOPFCDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	private readonly Dictionary<Type, KHNKJBOEAPI> CCNBBPBJMHF;

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public IReadOnlyCollection<KHNKJBOEAPI> LLIHFMLNDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000A76")]
		[Cpp2IlInjected.Address(RVA = "0x5E52BC0", Offset = "0x5E519C0", VA = "0x185E52BC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x5E52C10", Offset = "0x5E51A10", VA = "0x185E52C10", Slot = "7")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x5E52F50", Offset = "0x5E51D50", VA = "0x185E52F50", Slot = "6")]
	public KHNKJBOEAPI LAKBMJNLEDH(Type FLHOFPAHPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x5E52B00", Offset = "0x5E51900", VA = "0x185E52B00", Slot = "5")]
	public bool COHLMKIJFBJ(int NGICFBMMBFC, [Out] KHNKJBOEAPI NAFNNIMKNLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x5E52B70", Offset = "0x5E51970", VA = "0x185E52B70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7B")]
	[Cpp2IlInjected.Address(RVA = "0x5E52FD0", Offset = "0x5E51DD0", VA = "0x185E52FD0")]
	public FMIIKJOJEED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020A")]
[PMDCDBMECJP(typeof(GPLPDCIMGEL), new string[] { })]
[BNEEAEKLIEP(typeof(LNONMHFEMMB))]
public class FPODHGGNFKI : GPLPDCIMGEL, EPBKMCPBINK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private readonly Dictionary<int, GIIOFPANJDM> JNOCJDJJJLG;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public IEnumerable<GIIOFPANJDM> HLJNOLKDEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000A7C")]
		[Cpp2IlInjected.Address(RVA = "0x5E530E0", Offset = "0x5E51EE0", VA = "0x185E530E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7D")]
	[Cpp2IlInjected.Address(RVA = "0x5E53180", Offset = "0x5E51F80", VA = "0x185E53180", Slot = "6")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x5E53570", Offset = "0x5E52370", VA = "0x185E53570", Slot = "5")]
	public bool MCBMKHFHNOD(int NGICFBMMBFC, [Out] GIIOFPANJDM GFNIJJJMCDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x5E53130", Offset = "0x5E51F30", VA = "0x185E53130", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A80")]
	[Cpp2IlInjected.Address(RVA = "0x5E535E0", Offset = "0x5E523E0", VA = "0x185E535E0")]
	public FPODHGGNFKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020B")]
[PMDCDBMECJP(typeof(KPOMLECKFFC), new string[] { })]
[BNEEAEKLIEP(typeof(LNONMHFEMMB))]
public class KEJFPMFGLFH : KPOMLECKFFC, EPBKMCPBINK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private static readonly Dictionary<int, int> FIPGBICAGKP;

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B280", Offset = "0x5E5A080", VA = "0x185E5B280", Slot = "5")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B170", Offset = "0x5E59F70", VA = "0x185E5B170", Slot = "4")]
	public int AECMIHCCDAK(int NGICFBMMBFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A83")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B210", Offset = "0x5E5A010", VA = "0x185E5B210", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public KEJFPMFGLFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020C")]
[PMDCDBMECJP(typeof(MODGIOJDNBG), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
internal class MODGIOJDNBG : GOMKIFEKCFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private DIAGGAOEFEM<AuthoredParentData, AuthoredPreviousParentData, KFEHODPCKJL, AuthoredChildrenData> DGJBMCNIONJ;

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DAE0", Offset = "0x5E5C8E0", VA = "0x185E5DAE0", Slot = "4")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MODGIOJDNBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020D")]
[PMDCDBMECJP(typeof(LOCNOIPHBCK), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
internal sealed class LOCNOIPHBCK : ENEHADLKBBF, GOMKIFEKCFK
{
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	[PDOCKCLGMBB]
	private CJJPMIMHLNN FGGAOAAIACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000658")]
	private KPOPJMLJIEE<Entity> GHOAJKHDDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000659")]
	private DIAGGAOEFEM<ParentData, PreviousParentData, ELEBGMBHELL, ChildrenData> DGJBMCNIONJ;

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D4F0", Offset = "0x5E5C2F0", VA = "0x185E5D4F0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D380", Offset = "0x5E5C180", VA = "0x185E5D380", Slot = "5")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D4A0", Offset = "0x5E5C2A0", VA = "0x185E5D4A0")]
	public Entity IJFJAGHBHFC(Entity HHHGBIJCKBC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D780", Offset = "0x5E5C580", VA = "0x185E5D780")]
	public bool NBCOHGLKHJP(Entity HHHGBIJCKBC, Entity CEBKCILOOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D2E0", Offset = "0x5E5C0E0", VA = "0x185E5D2E0")]
	public bool AIEIBGACDCB(Entity HHHGBIJCKBC, Entity CEBKCILOOLP, bool OLCOCKBEOFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D540", Offset = "0x5E5C340", VA = "0x185E5D540")]
	private bool KDLELAADLIE(Entity HHHGBIJCKBC, Entity CEBKCILOOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LOCNOIPHBCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020E")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(CHBMOFLCNPL), new string[] { })]
internal sealed class CHBMOFLCNPL : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400065A")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400065B")]
	private EntityQuery NFHDEJNJDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400065C")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x5E511D0", Offset = "0x5E4FFD0", VA = "0x185E511D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x5E513B0", Offset = "0x5E501B0", VA = "0x185E513B0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x5E51220", Offset = "0x5E50020", VA = "0x185E51220", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0x5E51300", Offset = "0x5E50100", VA = "0x185E51300")]
	public bool HLEKOIFPNCB(Entity HHHGBIJCKBC, Entity PJMEKLHJGLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x5E51500", Offset = "0x5E50300", VA = "0x185E51500")]
	public bool PKJACENFGMC(Entity HHHGBIJCKBC, Entity NINKJFKPIPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A95")]
	[Cpp2IlInjected.Address(RVA = "0x5E51130", Offset = "0x5E4FF30", VA = "0x185E51130")]
	public Entity BGLIKGBFACL(Entity HHHGBIJCKBC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A96")]
	[Cpp2IlInjected.Address(RVA = "0x5E514B0", Offset = "0x5E502B0", VA = "0x185E514B0")]
	public NativeArray<Entity> KBHKCHGHILL()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A97")]
	[Cpp2IlInjected.Address(RVA = "0x5E51240", Offset = "0x5E50040", VA = "0x185E51240")]
	public bool ECOIFBFLNNA(Entity PABBJIBBIGE, Entity GICCMHHJDGA, [Out] Entity BDEDPDJICOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public CHBMOFLCNPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020F")]
public static class IPICOHNBHPF
{
	[Cpp2IlInjected.Token(Token = "0x400065D")]
	internal static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0x23EC770", Offset = "0x23EB570", VA = "0x1823EC770")]
	public static void LKOIJBFKMJL<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(NFHEEPPLDKB MBMNNOGNPON, HPFFBCFNPLK<Entity> CJKMAIBCGPM, [Out] DIAGGAOEFEM<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> JEJMBFKDNDO) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, IPMLIMBHIHK where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, IPMLIMBHIHK, IEquatable<TChildrenData>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x5E57EF0", Offset = "0x5E56CF0", VA = "0x185E57EF0")]
	public static bool ALLOBMNEEIB(ELJLMFEGKCH KBMGDEBBCNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000210")]
public class DIAGGAOEFEM<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, IPMLIMBHIHK where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, IPMLIMBHIHK, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private readonly BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private readonly KPOPJMLJIEE<Entity> GHOAJKHDDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private readonly PIFEBGBCHME HBAGGGDJGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	private readonly IPEMFFHKPFK LPDGANJNOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private readonly EntityManager GMDAKDJOHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private readonly JNOBPLOAHCA IMNBHGEKNIE;

	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x4C68BA0", Offset = "0x4C679A0", VA = "0x184C68BA0")]
	public DIAGGAOEFEM(NFHEEPPLDKB MBMNNOGNPON, HPFFBCFNPLK<Entity> CJKMAIBCGPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0x4C669D0", Offset = "0x4C657D0", VA = "0x184C669D0")]
	private bool BCDDHDJBOKA(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x4C66AD0", Offset = "0x4C658D0", VA = "0x184C66AD0")]
	private bool CDNLJELDFPE(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x4C668D0", Offset = "0x4C656D0", VA = "0x184C668D0")]
	private bool ADNKKLJCPMA(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA0")]
	[Cpp2IlInjected.Address(RVA = "0x4C68510", Offset = "0x4C67310", VA = "0x184C68510")]
	private bool PLADMBPFNAJ(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA1")]
	[Cpp2IlInjected.Address(RVA = "0x4C68450", Offset = "0x4C67250", VA = "0x184C68450")]
	public bool NBCOHGLKHJP(Entity HHHGBIJCKBC, [In] Entity CEBKCILOOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA2")]
	[Cpp2IlInjected.Address(RVA = "0x4C67090", Offset = "0x4C65E90", VA = "0x184C67090")]
	public bool GAOOJIIIIDJ(Entity HHHGBIJCKBC, [In] Entity CEBKCILOOLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0x4C670D0", Offset = "0x4C65ED0", VA = "0x184C670D0")]
	private bool GAOOJIIIIDJ(Entity HHHGBIJCKBC, [In] Entity CEBKCILOOLP, bool MADAKMFEMPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void PKBGDOIAEMA(Entity HHHGBIJCKBC, [In] Entity CEBKCILOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void DKDPCEILDKE(Entity HHHGBIJCKBC, [In] Entity CEBKCILOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void MHBDIGLEJDF(Entity HHHGBIJCKBC, [In] Entity CEBKCILOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void NOPIIBPCCMC(Entity HHHGBIJCKBC, [In] Entity CEBKCILOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void PLENJKGPFEI(Entity HHHGBIJCKBC, [In] Entity CEBKCILOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x4C67D40", Offset = "0x4C66B40", VA = "0x184C67D40")]
	private bool HLEKOIFPNCB(Entity HHHGBIJCKBC, Entity PJMEKLHJGLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x4C67E30", Offset = "0x4C66C30", VA = "0x184C67E30")]
	private void IGAAMBBBKHN(Entity HHHGBIJCKBC, [In] Entity EDMIEMPCIAB, [In] Entity CEBKCILOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x4C67810", Offset = "0x4C66610", VA = "0x184C67810")]
	private void GCMOPMOCKIN(Entity HHHGBIJCKBC, [In] Entity EDMIEMPCIAB, [In] Entity CEBKCILOOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAC")]
	[Cpp2IlInjected.Address(RVA = "0x4C68070", Offset = "0x4C66E70", VA = "0x184C68070")]
	private bool IJAMPFJCCOE(FLHIJLBPMGI PNHGPEHNJLC, [In] GFPOPKJOMLL NAODMBOPENE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x4C66D90", Offset = "0x4C65B90", VA = "0x184C66D90")]
	private void FAGKNOIOPHJ(Entity LPDGANJNOMK, Entity KGAHDFAFPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x4C66BD0", Offset = "0x4C659D0", VA = "0x184C66BD0")]
	private void CLPCBEDDCDJ(Entity LPDGANJNOMK, Entity KGAHDFAFPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private void IDCDNMNIAEM(Entity HHHGBIJCKBC, Entity EDMIEMPCIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private void MGEBLKGPPKE(Entity HHHGBIJCKBC, Entity CEBKCILOOLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000211")]
[PMDCDBMECJP(typeof(OJJJKLOBGFC), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
internal sealed class OJJJKLOBGFC : MPCGKLABPGO, EPBKMCPBINK, ENEHADLKBBF, GOMKIFEKCFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000666")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000667")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000668")]
	[PDOCKCLGMBB]
	private CJJPMIMHLNN FGGAOAAIACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000669")]
	[PDOCKCLGMBB]
	private GDDGINCANAF IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400066A")]
	[PDOCKCLGMBB]
	private CNBPFEEKBEF AENJCIFEOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	[PDOCKCLGMBB]
	private INNJFFIHMKD EKJHKHKDMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	[PDOCKCLGMBB]
	private BEJFNELDFAM BHPBEGGGKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	[PDOCKCLGMBB]
	private PEIDJIEIOHO LGOEJDFNDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private readonly Dictionary<GFPOPKJOMLL, KJKIANDJMFH> JPCENNDLCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private readonly List<NetworkedTransformEntity> GMLPDBLLHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000670")]
	private HGOHMLDHGIP MCCMDGOLLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000671")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000AB2")]
		[Cpp2IlInjected.Address(RVA = "0x5E62FA0", Offset = "0x5E61DA0", VA = "0x185E62FA0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x1C215C0", Offset = "0x1C203C0", VA = "0x181C215C0", Slot = "4")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x5E644C0", Offset = "0x5E632C0", VA = "0x185E644C0", Slot = "5")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x5E65F80", Offset = "0x5E64D80", VA = "0x185E65F80")]
	public void MLDKAKBPOJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x5E63BB0", Offset = "0x5E629B0", VA = "0x185E63BB0", Slot = "6")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x5E63100", Offset = "0x5E61F00", VA = "0x185E63100", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x5E626F0", Offset = "0x5E614F0", VA = "0x185E626F0")]
	public int AFJDLADJANC(SceneTag GJBLGBOBAMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0x5E65250", Offset = "0x5E64050", VA = "0x185E65250")]
	public bool JOHHGOIEBAA(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x5E62C90", Offset = "0x5E61A90", VA = "0x185E62C90")]
	public bool CHIIPFDEOAP(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0x5E62FF0", Offset = "0x5E61DF0", VA = "0x185E62FF0")]
	public bool DGOPEJKDEPE(Entity HHHGBIJCKBC, [Out] KJKIANDJMFH JHNFBPKNCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x5E63060", Offset = "0x5E61E60", VA = "0x185E63060")]
	private bool DGOPEJKDEPE(Transform ILMBKONFEEP, [Out] KJKIANDJMFH JHNFBPKNCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x5E65910", Offset = "0x5E64710", VA = "0x185E65910")]
	private void LDFOHDJJEAF(Entity HHHGBIJCKBC, KJKIANDJMFH JHNFBPKNCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x5E62710", Offset = "0x5E61510", VA = "0x185E62710")]
	private bool AHPGMCOCKHP(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x5E65420", Offset = "0x5E64220", VA = "0x185E65420")]
	public void LAPCBGMBHPD(GFPOPKJOMLL OEAOJAGKHME, KJKIANDJMFH KPGCDKGOCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x5E655C0", Offset = "0x5E643C0", VA = "0x185E655C0")]
	public void LAPCBGMBHPD(EPCANLGBBON GOOJPBOEHHC, KJKIANDJMFH KPGCDKGOCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC1")]
	[Cpp2IlInjected.Address(RVA = "0x5E656A0", Offset = "0x5E644A0", VA = "0x185E656A0")]
	public void LCDIPEIONIJ(GFPOPKJOMLL[] AINFNEHLDGJ, GameObject LEMKPNELLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x5E66660", Offset = "0x5E65460", VA = "0x185E66660")]
	public bool OFIEHJHCFMC(EPCANLGBBON GOOJPBOEHHC, object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC3")]
	[Cpp2IlInjected.Address(RVA = "0x5E66BD0", Offset = "0x5E659D0", VA = "0x185E66BD0")]
	public bool OFIEHJHCFMC(Entity HHHGBIJCKBC, [Optional] object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC4")]
	[Cpp2IlInjected.Address(RVA = "0x5E66630", Offset = "0x5E65430", VA = "0x185E66630")]
	public bool OFIEHJHCFMC(KJKIANDJMFH KBMGDEBBCNM, object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC5")]
	[Cpp2IlInjected.Address(RVA = "0x5E65A30", Offset = "0x5E64830", VA = "0x185E65A30")]
	public bool MLBLDAGPMKH(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC6")]
	[Cpp2IlInjected.Address(RVA = "0x5E66600", Offset = "0x5E65400", VA = "0x185E66600")]
	public bool OFIEHJHCFMC(KJKIANDJMFH JHNFBPKNCCI, bool PIOPLCOODHB, [Optional] object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC7")]
	[Cpp2IlInjected.Address(RVA = "0x5E631C0", Offset = "0x5E61FC0", VA = "0x185E631C0")]
	private bool EEMEIMJBKAD(KJKIANDJMFH JHNFBPKNCCI, object EKDHBKMFLGI, bool PIOPLCOODHB, bool JABJMGBJPNB, bool OEKJMEILOEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x5E639C0", Offset = "0x5E627C0", VA = "0x185E639C0")]
	public Transform FDHGLFEJDAB(Entity HHHGBIJCKBC, [Optional] object EKDHBKMFLGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x5E66C30", Offset = "0x5E65A30", VA = "0x185E66C30")]
	public bool OMALGOFDFEG(Entity HHHGBIJCKBC, [Out] Transform ILMBKONFEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x5E62BA0", Offset = "0x5E619A0", VA = "0x185E62BA0")]
	public KJKIANDJMFH CGBHEPDCDGI(Entity HHHGBIJCKBC, [Optional] object EKDHBKMFLGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x5E66200", Offset = "0x5E65000", VA = "0x185E66200")]
	public void NKGOGEPMABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x5E640E0", Offset = "0x5E62EE0", VA = "0x185E640E0")]
	public void IPJAPKBPIFL(SceneTag GJBLGBOBAMI, bool JABJMGBJPNB, NativeParallelHashSet<int> KCGOKJGMKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x5E64640", Offset = "0x5E63440", VA = "0x185E64640")]
	private void JKMIODOHNJO(Entity HHHGBIJCKBC, bool JABJMGBJPNB, bool OEKJMEILOEB, NativeParallelHashSet<int> KCGOKJGMKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x5E659A0", Offset = "0x5E647A0", VA = "0x185E659A0")]
	private bool LIODFMEFOFF(KJKIANDJMFH JHNFBPKNCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x5E63DE0", Offset = "0x5E62BE0", VA = "0x185E63DE0")]
	public bool FLOIJGBPJPG(Entity HHHGBIJCKBC, object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x5E63D60", Offset = "0x5E62B60", VA = "0x185E63D60")]
	public bool FLIIGKPHFHP(Entity HHHGBIJCKBC, object EKDHBKMFLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x5E63E60", Offset = "0x5E62C60", VA = "0x185E63E60")]
	public bool GLDIEMNMLNA(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x5E64000", Offset = "0x5E62E00", VA = "0x185E64000")]
	private void HPBDIAKFLLO(bool IDJFMAENEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x5E63F40", Offset = "0x5E62D40", VA = "0x185E63F40")]
	private bool GMOOCOMDMGA(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0x5E645F0", Offset = "0x5E633F0", VA = "0x185E645F0")]
	public KJKIANDJMFH JECOILNIJAG(Entity HHHGBIJCKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x5E66D00", Offset = "0x5E65B00", VA = "0x185E66D00")]
	private KJKIANDJMFH PDHAEOGIBBA(Entity HHHGBIJCKBC, object EKDHBKMFLGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD6")]
	[Cpp2IlInjected.Address(RVA = "0x5E636B0", Offset = "0x5E624B0", VA = "0x185E636B0")]
	private KJKIANDJMFH EGBOOLLLLBC(Entity HHHGBIJCKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x5E660B0", Offset = "0x5E64EB0", VA = "0x185E660B0")]
	public void NKAMDPJDEIG(NativeArray<GFPOPKJOMLL> AINFNEHLDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x5E66530", Offset = "0x5E65330", VA = "0x185E66530")]
	private void NODCCJLOHOG(KJKIANDJMFH KPGCDKGOCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD9")]
	[Cpp2IlInjected.Address(RVA = "0x5E62CB0", Offset = "0x5E61AB0", VA = "0x185E62CB0")]
	private void CKMLBMCAGED(KJKIANDJMFH JHNFBPKNCCI, Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADA")]
	[Cpp2IlInjected.Address(RVA = "0x5E66DA0", Offset = "0x5E65BA0", VA = "0x185E66DA0")]
	private void PKMJGPPGLOG(Entity HHHGBIJCKBC, KJKIANDJMFH JHNFBPKNCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADB")]
	[Cpp2IlInjected.Address(RVA = "0x5E65FD0", Offset = "0x5E64DD0", VA = "0x185E65FD0")]
	private void MMFNDIDKNEO(Entity HHHGBIJCKBC, Transform ILMBKONFEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADC")]
	[Cpp2IlInjected.Address(RVA = "0x5E62730", Offset = "0x5E61530", VA = "0x185E62730")]
	private void BODABAENHMG(GFPOPKJOMLL OEAOJAGKHME, NetworkedTransformEntity BAPGFOLNAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x5E65000", Offset = "0x5E63E00", VA = "0x185E65000")]
	private void JNHJLALICKK(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x5E63960", Offset = "0x5E62760", VA = "0x185E63960")]
	private List<NetworkedTransformEntity> FAAODJPCGMD(GameObject LEMKPNELLPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0x5DDBC50", Offset = "0x5DDAA50", VA = "0x185DDBC50")]
	private EPCANLGBBON PPCFKLECJPN(Entity HHHGBIJCKBC)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0x5E670A0", Offset = "0x5E65EA0", VA = "0x185E670A0")]
	public OJJJKLOBGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x5E63C90", Offset = "0x5E62A90", VA = "0x185E63C90")]
	[CompilerGenerated]
	private void FHNCCLOMLEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000213")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(ANNAAAPLMJK), new string[] { })]
internal sealed class ANNAAAPLMJK : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private OJJJKLOBGFC JHNFBPKNCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	private CJBMGBDAIKK EDOOADMCLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	[CompilerGenerated]
	private Action<NativeArray<GFPOPKJOMLL>> JNPCDMHLDOA;

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E7C0", Offset = "0x5E4D5C0", VA = "0x185E4E7C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<NativeArray<GFPOPKJOMLL>, NativeArray<GPKGCNFDJCC>> ADEMPHPHHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE6")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E4B0", Offset = "0x5E4D2B0", VA = "0x185E4E4B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x5E4F920", Offset = "0x5E4E720", VA = "0x185E4F920")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<LLKJHKLONBK> JKIHAIEJMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x5E4EB80", Offset = "0x5E4D980", VA = "0x185E4EB80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E5C0", Offset = "0x5E4D3C0", VA = "0x185E4E5C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F2D0", Offset = "0x5E4E0D0", VA = "0x185E4F2D0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x202C240", Offset = "0x202B040", VA = "0x18202C240", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E470", Offset = "0x5E4D270", VA = "0x185E4E470")]
	public void AILOKOPBEFH(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F740", Offset = "0x5E4E540", VA = "0x185E4F740")]
	public void JNHNKJGGPKG(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEF")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ECA0", Offset = "0x5E4DAA0", VA = "0x185E4ECA0")]
	private bool GOIALJPJPKB(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EC30", Offset = "0x5E4DA30", VA = "0x185E4EC30")]
	public void GJFIGHFIJPA(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF1")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E9A0", Offset = "0x5E4D7A0", VA = "0x185E4E9A0")]
	private bool FNCHNNJFBCK(Entity HHHGBIJCKBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF2")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E670", Offset = "0x5E4D470", VA = "0x185E4E670")]
	public void BOBMPBDLCLM(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF3")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E560", Offset = "0x5E4D360", VA = "0x185E4E560")]
	private void BILAODDDHDE(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF4")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F510", Offset = "0x5E4E310", VA = "0x185E4F510")]
	private void JDEDILLBACA(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF5")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F9D0", Offset = "0x5E4E7D0", VA = "0x185E4F9D0")]
	private void NBCCDOMGDJE(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF6")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F000", Offset = "0x5E4DE00", VA = "0x185E4F000")]
	private void IIFIHCMCOEI(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF7")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F370", Offset = "0x5E4E170", VA = "0x185E4F370")]
	public void JAENFMKGNJI(NativeArray<GFPOPKJOMLL> AINFNEHLDGJ, NativeArray<GPKGCNFDJCC> JHHBEFKAAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF8")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E810", Offset = "0x5E4D610", VA = "0x185E4E810")]
	public void FKEFDIPJEDE(NativeArray<GFPOPKJOMLL> AINFNEHLDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AF9")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F790", Offset = "0x5E4E590", VA = "0x185E4F790")]
	public void LEAAPCAHBCO(LLKJHKLONBK HJJLFLCDILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFA")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private void PNEJACLCPCP(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFB")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EDF0", Offset = "0x5E4DBF0", VA = "0x185E4EDF0")]
	private void IHNNFKDJHGI(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AFC")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public ANNAAAPLMJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000215")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(NDPEAMPCMHG), new string[] { })]
internal class NDPEAMPCMHG : CCPNBGLJBDC, ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000217")]
	[CompilerGenerated]
	private sealed class JANGBNBEBEA : IEnumerable<(JFBOGCJIFLL, GPKGCNFDJCC)>, IEnumerable, IEnumerator<(JFBOGCJIFLL, GPKGCNFDJCC)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private (JFBOGCJIFLL primitiveType, GPKGCNFDJCC prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public NDPEAMPCMHG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		private (JFBOGCJIFLL, GPKGCNFDJCC) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B20")]
			[Cpp2IlInjected.Address(RVA = "0x30A8E80", Offset = "0x30A7C80", VA = "0x1830A8E80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((JFBOGCJIFLL, GPKGCNFDJCC));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000B22")]
			[Cpp2IlInjected.Address(RVA = "0x5E581B0", Offset = "0x5E56FB0", VA = "0x185E581B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x32FE2C0", Offset = "0x32FD0C0", VA = "0x1832FE2C0")]
		[DebuggerHidden]
		public JANGBNBEBEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x5E57FB0", Offset = "0x5E56DB0", VA = "0x185E57FB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B21")]
		[Cpp2IlInjected.Address(RVA = "0x5E58160", Offset = "0x5E56F60", VA = "0x185E58160", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B23")]
		[Cpp2IlInjected.Address(RVA = "0x5E580B0", Offset = "0x5E56EB0", VA = "0x185E580B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(JFBOGCJIFLL, GPKGCNFDJCC)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000B24")]
		[Cpp2IlInjected.Address(RVA = "0x5E580B0", Offset = "0x5E56EB0", VA = "0x185E580B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private World JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private NativeParallelHashMap<int, Entity> LLOAICEJOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private NativeParallelHashMap<int, EntityArchetype> LJBPODJCCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private NativeParallelHashMap<int, int> ONKNMCFGJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private GPKGCNFDJCC[] JHHBEFKAAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private readonly Dictionary<JFBOGCJIFLL, GPKGCNFDJCC> NNALDMKIILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private readonly Dictionary<CJHIJPGGEAF, GPKGCNFDJCC> FCHNGNGLDGI;

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F7D0", Offset = "0x5E5E5D0", VA = "0x185E5F7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x760F30", Offset = "0x75FD30", VA = "0x180760F30")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B05")]
		[Cpp2IlInjected.Address(RVA = "0x188A1A0", Offset = "0x1888FA0", VA = "0x18188A1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E850", Offset = "0x5E5D650", VA = "0x185E5E850", Slot = "5")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E090", Offset = "0x5E5CE90", VA = "0x185E5E090", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B08")]
	[Cpp2IlInjected.Address(RVA = "0xD63290", Offset = "0xD62090", VA = "0x180D63290")]
	internal NativeParallelHashMap<int, Entity> EGNIHFEKDCB()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B09")]
	[Cpp2IlInjected.Address(RVA = "0xD77A70", Offset = "0xD76870", VA = "0x180D77A70")]
	internal NativeParallelHashMap<int, EntityArchetype> PPFNHICJLFH()
	{
		return default(NativeParallelHashMap<int, EntityArchetype>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0A")]
	[Cpp2IlInjected.Address(RVA = "0x89D980", Offset = "0x89C780", VA = "0x18089D980")]
	internal NativeParallelHashMap<int, int> PINDGHNJGEF()
	{
		return default(NativeParallelHashMap<int, int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F770", Offset = "0x5E5E570", VA = "0x185E5F770")]
	internal IEnumerable<Type> NCHEMOKIAAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F700", Offset = "0x5E5E500", VA = "0x185E5F700")]
	internal CCFHNOEHJDA MLFJAJMKFLB(Type FLHOFPAHPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E7E0", Offset = "0x5E5D5E0", VA = "0x185E5E7E0")]
	public EntityArchetype ILAJLDPCNND(GPKGCNFDJCC LEGGGLNIAOM)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F680", Offset = "0x5E5E480", VA = "0x185E5F680", Slot = "4")]
	[IteratorStateMachine(typeof(JANGBNBEBEA))]
	public IEnumerable<(JFBOGCJIFLL, GPKGCNFDJCC)> MAHNOIGMGPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F810", Offset = "0x5E5E610", VA = "0x185E5F810")]
	public Entity OPCJGNACCBJ(GPKGCNFDJCC LEGGGLNIAOM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F3E0", Offset = "0x5E5E1E0", VA = "0x185E5F3E0")]
	public void JDFNMIMOMBE(NativeArray<GPKGCNFDJCC> JHHBEFKAAPJ, NativeArray<Entity> MMMPGPKJOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B11")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E750", Offset = "0x5E5D550", VA = "0x185E5E750")]
	public void HNGPHNAIOLJ(GPKGCNFDJCC LEGGGLNIAOM, NativeArray<Entity> DDIFFODKOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B12")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DBA0", Offset = "0x5E5C9A0", VA = "0x185E5DBA0")]
	public GPKGCNFDJCC AKPDNKCPINE(JFBOGCJIFLL FLHOFPAHPKL)
	{
		return default(GPKGCNFDJCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B13")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F590", Offset = "0x5E5E390", VA = "0x185E5F590")]
	public Entity LLJPGHGBEII(GPKGCNFDJCC LEGGGLNIAOM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B14")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DD90", Offset = "0x5E5CB90", VA = "0x185E5DD90")]
	private void BPKDKKMEFDO(CCFHNOEHJDA FGMBKNPLJMK, NativeList<int> JHHBEFKAAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B15")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E440", Offset = "0x5E5D240", VA = "0x185E5E440")]
	internal void GLFOMLFMCGM(GPKGCNFDJCC LEGGGLNIAOM, ComponentTypeList EPGGIHGBGEL, GHGNJELMMHP AFELIGFNFDE, CCFHNOEHJDA FGMBKNPLJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DC00", Offset = "0x5E5CA00", VA = "0x185E5DC00")]
	private EntityArchetype APAIBBOCOII(GPKGCNFDJCC LEGGGLNIAOM, ComponentTypeList NDFBKPCIBAL)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B17")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F9C0", Offset = "0x5E5E7C0", VA = "0x185E5F9C0")]
	public NDPEAMPCMHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000218")]
public enum PKPEFMCEJFH
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
internal interface DKGJEBHICHP
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	World IKHONICOMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B25")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	World NGPIPCJIPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B26")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	IDOEAIHJCJE LGGEBNLHMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B27")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	uint ENCFLFLAEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000B28")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000B29")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	bool LIODFMEFOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200021A")]
internal class KNJKIHNPEMA : NBFMIMBNCND, HDLLCGPJIMD
{
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private readonly DKGJEBHICHP FPOEPHMJOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private readonly PKPEFMCEJFH HMFMKKPCCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private readonly World HDEJEAONPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private readonly List<LJMAIKKINIL> FIAEEAFELMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private NativeParallelMultiHashMap<Entity, HKOKMGPELNC> OGAGGNHLNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private NativeParallelHashMap<int, int> ELGJGLHDICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private NativeArray<GFPOPKJOMLL> LNKIEKGIJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private NativeArray<JJPHEIKOGBI> BLKDAKGGOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private NativeArray<GFPOPKJOMLL> BPMLECOAJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	private JobHandle DCHIJADAAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	private JobHandle ECJGNLEJKGI;

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	private NativeParallelMultiHashMap<Entity, HKOKMGPELNC> HAPFOEDPKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0xD77A70", Offset = "0xD76870", VA = "0x180D77A70", Slot = "4")]
		get
		{
			return default(NativeParallelMultiHashMap<Entity, HKOKMGPELNC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	private uint AFABOLDFGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C380", Offset = "0x5E5B180", VA = "0x185E5C380", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool NKNPGMLPEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x5E5BDE0", Offset = "0x5E5ABE0", VA = "0x185E5BDE0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	private NativeArray<GFPOPKJOMLL> MDPFBBHHPCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x1A19DB0", Offset = "0x1A18BB0", VA = "0x181A19DB0", Slot = "10")]
		get
		{
			return default(NativeArray<GFPOPKJOMLL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private NativeArray<JJPHEIKOGBI> ADAHONONDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0xEC53B0", Offset = "0xEC41B0", VA = "0x180EC53B0", Slot = "11")]
		get
		{
			return default(NativeArray<JJPHEIKOGBI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	private NativeArray<GFPOPKJOMLL> JCMFDOGOHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x33D1670", Offset = "0x33D0470", VA = "0x1833D1670", Slot = "12")]
		get
		{
			return default(NativeArray<GFPOPKJOMLL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C460", Offset = "0x5E5B260", VA = "0x185E5C460")]
	public KNJKIHNPEMA(DKGJEBHICHP FPOEPHMJOKA, PKPEFMCEJFH HMFMKKPCCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C190", Offset = "0x5E5AF90", VA = "0x185E5C190", Slot = "6")]
	private bool PKLAJOFPPJK(NativeArray<GFPOPKJOMLL> LNKIEKGIJPO, NativeArray<JJPHEIKOGBI> BLKDAKGGOEB, NativeArray<GFPOPKJOMLL> BPMLECOAJOG, int FFMHELFKIKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B2F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C020", Offset = "0x5E5AE20", VA = "0x185E5C020", Slot = "7")]
	private void OPDJALEBEKI([In] LJMAIKKINIL EGPNIHDCHPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B30")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BC60", Offset = "0x5E5AA60", VA = "0x185E5BC60", Slot = "8")]
	private void LIFBGKHNDGB(JobHandle OFGGCMDABFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B35")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B600", Offset = "0x5E5A400", VA = "0x185E5B600", Slot = "13")]
	private bool FLPGBIPLKCK([Out] NativeArray<int> GABGGKOHHGO, Allocator MBGJLDPPIJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B36")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B6B0", Offset = "0x5E5A4B0", VA = "0x185E5B6B0", Slot = "14")]
	private bool HFEDNPMLOJF(ComponentType AGCPJNMOOIE, [Out] LJMAIKKINIL MCIICNJOFOB, [Out] ECDAJHEINPN EANGOGNHDFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B890", Offset = "0x5E5A690", VA = "0x185E5B890", Slot = "15")]
	private NativeMultiHashMapAsync<Entity, HKOKMGPELNC> KJECMOMNKDP()
	{
		return default(NativeMultiHashMapAsync<Entity, HKOKMGPELNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B38")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B910", Offset = "0x5E5A710", VA = "0x185E5B910")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B39")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BDF0", Offset = "0x5E5ABF0", VA = "0x185E5BDF0")]
	private bool OOMLNFEKGLK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200021B")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(GCIHPKBFCDJ), new string[] { })]
internal class GCIHPKBFCDJ : ENEHADLKBBF, GOMKIFEKCFK, DKGJEBHICHP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200021C")]
	internal readonly struct FKBDMIJPDDK : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private readonly PKPEFMCEJFH DPGNBMJJLBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private readonly GCIHPKBFCDJ PLJNIEKIKFG;

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x5E52AB0", Offset = "0x5E518B0", VA = "0x185E52AB0")]
		public FKBDMIJPDDK(GCIHPKBFCDJ PLJNIEKIKFG, PKPEFMCEJFH GJDAMGEOKDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x5E52A90", Offset = "0x5E51890", VA = "0x185E52A90", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private static readonly HICMFDICNOL EEGBNCCECMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	[PDOCKCLGMBB]
	private NKBJOPBBMIN MFNODIMGLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	[PDOCKCLGMBB]
	private NDPEAMPCMHG KDKGHICNAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private readonly KNJKIHNPEMA[] IHDFMFMDIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private IDOEAIHJCJE NEFOAPGGIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private NativeParallelHashMap<int, Entity> JJJOCFBKELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private PKPEFMCEJFH NKENIKHKALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public World IKHONICOMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3B")]
		[Cpp2IlInjected.Address(RVA = "0x5E53F00", Offset = "0x5E52D00", VA = "0x185E53F00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public World NGPIPCJIPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3C")]
		[Cpp2IlInjected.Address(RVA = "0x7678E0", Offset = "0x7666E0", VA = "0x1807678E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x7678D0", Offset = "0x7666D0", VA = "0x1807678D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public IDOEAIHJCJE LGGEBNLHMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x20297F0", Offset = "0x20285F0", VA = "0x1820297F0", Slot = "8")]
		get
		{
			return default(IDOEAIHJCJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public uint ENCFLFLAEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0xD04070", Offset = "0xD02E70", VA = "0x180D04070", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0xD04810", Offset = "0xD03610", VA = "0x180D04810", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	private bool LHHHJHFOGFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x9B3640", Offset = "0x9B2440", VA = "0x1809B3640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool LIODFMEFOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B42")]
		[Cpp2IlInjected.Address(RVA = "0xCEDCF0", Offset = "0xCECAF0", VA = "0x180CEDCF0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public NativeParallelHashMap<int, Entity> CLCHFADDDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000B43")]
		[Cpp2IlInjected.Address(RVA = "0xD48C10", Offset = "0xD47A10", VA = "0x180D48C10")]
		get
		{
			return default(NativeParallelHashMap<int, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public HDLLCGPJIMD FAIIEECHLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x5E53670", Offset = "0x5E52470", VA = "0x185E53670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public NBFMIMBNCND JFCEMHLLDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B47")]
		[Cpp2IlInjected.Address(RVA = "0x5E53670", Offset = "0x5E52470", VA = "0x185E53670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public PKPEFMCEJFH IGIDPCKNCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B48")]
		[Cpp2IlInjected.Address(RVA = "0x95F250", Offset = "0x95E050", VA = "0x18095F250")]
		get
		{
			return default(PKPEFMCEJFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B44")]
	[Cpp2IlInjected.Address(RVA = "0x1B90360", Offset = "0x1B8F160", VA = "0x181B90360")]
	public HDLLCGPJIMD ODPCOGDIIJF(PKPEFMCEJFH HMFMKKPCCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B45")]
	[Cpp2IlInjected.Address(RVA = "0x1B90360", Offset = "0x1B8F160", VA = "0x181B90360")]
	public NBFMIMBNCND JPANBNCCEGI(PKPEFMCEJFH HMFMKKPCCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B49")]
	[Cpp2IlInjected.Address(RVA = "0x5E53A60", Offset = "0x5E52860", VA = "0x185E53A60", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4A")]
	[Cpp2IlInjected.Address(RVA = "0x5E53810", Offset = "0x5E52610", VA = "0x185E53810", Slot = "5")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4B")]
	[Cpp2IlInjected.Address(RVA = "0x5E53B80", Offset = "0x5E52980", VA = "0x185E53B80")]
	private NativeParallelHashMap<int, Entity> KCPFGFKLNII()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4C")]
	[Cpp2IlInjected.Address(RVA = "0x5E53B30", Offset = "0x5E52930", VA = "0x185E53B30")]
	public void JOEEHCCNLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4D")]
	[Cpp2IlInjected.Address(RVA = "0x5E53EC0", Offset = "0x5E52CC0", VA = "0x185E53EC0")]
	public void LHLJEDFLAKN(PKPEFMCEJFH HMFMKKPCCOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4E")]
	[Cpp2IlInjected.Address(RVA = "0x5E53E00", Offset = "0x5E52C00", VA = "0x185E53E00")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4F")]
	[Cpp2IlInjected.Address(RVA = "0x5E53700", Offset = "0x5E52500", VA = "0x185E53700", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x5E536A0", Offset = "0x5E524A0", VA = "0x185E536A0")]
	public FKBDMIJPDDK DBGMEFBNFPJ(PKPEFMCEJFH HMFMKKPCCOG)
	{
		return default(FKBDMIJPDDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B51")]
	[Cpp2IlInjected.Address(RVA = "0x5E54010", Offset = "0x5E52E10", VA = "0x185E54010")]
	public GCIHPKBFCDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021D")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(PAPIHHEIJJK), new string[] { })]
internal class PAPIHHEIJJK : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006B2")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	public static readonly SceneTag MLEIJBCFBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	[PDOCKCLGMBB]
	private PJCKAEPBFOA ADOHNLJAIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	[PDOCKCLGMBB]
	private OJJJKLOBGFC JHNFBPKNCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	[PDOCKCLGMBB]
	private PIFEBGBCHME FKKFOAHHICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	[PDOCKCLGMBB]
	private KAFALIKLKOG JHLBKLCHFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	[PDOCKCLGMBB]
	private HNIIJBEOOFD GGEEECICIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private EntityQuery ELFPBNPPFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private EntityQuery DPACPIOOBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006BC")]
	private EntityQuery FLPKCKNNKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006BD")]
	private Entity EOPNKJCHJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40006BE")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public NativeArray<Entity> AALHMECILGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0xBE46B0", Offset = "0xBE34B0", VA = "0x180BE46B0")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B56")]
		[Cpp2IlInjected.Address(RVA = "0xBE3AF0", Offset = "0xBE28F0", VA = "0x180BE3AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public Entity MGEOFGLCIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B57")]
		[Cpp2IlInjected.Address(RVA = "0x5E68F70", Offset = "0x5E67D70", VA = "0x185E68F70")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public SceneTag AMAOPJGLKCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x5E68A30", Offset = "0x5E67830", VA = "0x185E68A30")]
		get
		{
			return default(SceneTag);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public Entity OCFBLDCDAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x5E68A30", Offset = "0x5E67830", VA = "0x185E68A30")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x5E68A80", Offset = "0x5E67880", VA = "0x185E68A80")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	private EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B5B")]
		[Cpp2IlInjected.Address(RVA = "0x5E67ED0", Offset = "0x5E66CD0", VA = "0x185E67ED0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5C")]
	[Cpp2IlInjected.Address(RVA = "0x5E690C0", Offset = "0x5E67EC0", VA = "0x185E690C0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5D")]
	[Cpp2IlInjected.Address(RVA = "0x5E684E0", Offset = "0x5E672E0", VA = "0x185E684E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5E")]
	[Cpp2IlInjected.Address(RVA = "0x5E69080", Offset = "0x5E67E80", VA = "0x185E69080")]
	public void IHHCKKFAJPF(Entity HHHGBIJCKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5F")]
	[Cpp2IlInjected.Address(RVA = "0x5E68860", Offset = "0x5E67660", VA = "0x185E68860")]
	public NativeArray<Entity> FNLLHHFBAIA(Allocator MBGJLDPPIJN = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B60")]
	[Cpp2IlInjected.Address(RVA = "0x5E69260", Offset = "0x5E68060", VA = "0x185E69260")]
	public void NPIMMODHEOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B61")]
	[Cpp2IlInjected.Address(RVA = "0x5E682D0", Offset = "0x5E670D0", VA = "0x185E682D0")]
	public void DBKKKGBJDMP(Entity GJBLGBOBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B62")]
	[Cpp2IlInjected.Address(RVA = "0x5E686E0", Offset = "0x5E674E0", VA = "0x185E686E0")]
	public Entity FACJHDJBPMJ(string MEBBBIMBIJO = "")
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B63")]
	[Cpp2IlInjected.Address(RVA = "0x5E68A10", Offset = "0x5E67810", VA = "0x185E68A10")]
	public void GIBNLHMAFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B64")]
	[Cpp2IlInjected.Address(RVA = "0x5E68F50", Offset = "0x5E67D50", VA = "0x185E68F50")]
	public void IGOAHECIGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B65")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	public void KLABDEGJJJG(Entity GJBLGBOBAMI, string MEBBBIMBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B66")]
	[Cpp2IlInjected.Address(RVA = "0x5E692B0", Offset = "0x5E680B0", VA = "0x185E692B0")]
	public void OMOGLNBCDNN(Entity GJBLGBOBAMI, bool MJAPFEGGCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B67")]
	[Cpp2IlInjected.Address(RVA = "0x5E68D20", Offset = "0x5E67B20", VA = "0x185E68D20")]
	public void IENBOJGAJLI(Entity HHHGBIJCKBC, Entity GJBLGBOBAMI, bool JFFIEJFALLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B68")]
	[Cpp2IlInjected.Address(RVA = "0x5E68AF0", Offset = "0x5E678F0", VA = "0x185E68AF0")]
	public void IENBOJGAJLI(NativeArray<Entity> DDIFFODKOKJ, Entity GJBLGBOBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B69")]
	[Cpp2IlInjected.Address(RVA = "0x5E68520", Offset = "0x5E67320", VA = "0x185E68520")]
	private void EDMMOLPABIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6A")]
	[Cpp2IlInjected.Address(RVA = "0x5E67D20", Offset = "0x5E66B20", VA = "0x185E67D20")]
	private void BOKFNCEKCPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6B")]
	[Cpp2IlInjected.Address(RVA = "0x5E68F70", Offset = "0x5E67D70", VA = "0x185E68F70")]
	private Entity IHBEDKMFGHJ()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6C")]
	[Cpp2IlInjected.Address(RVA = "0x5E67F20", Offset = "0x5E66D20", VA = "0x185E67F20")]
	private void CMLPPGBNGMH(EntityQuery NHDBPKNPPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6D")]
	[Cpp2IlInjected.Address(RVA = "0x5E68000", Offset = "0x5E66E00", VA = "0x185E68000")]
	private void CMLPPGBNGMH(NativeArray<Entity> GAKKCIMPKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6E")]
	[Cpp2IlInjected.Address(RVA = "0x5E683F0", Offset = "0x5E671F0", VA = "0x185E683F0")]
	private void DENCEKOOKHJ(Entity GJBLGBOBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6F")]
	[Cpp2IlInjected.Address(RVA = "0x5E68790", Offset = "0x5E67590", VA = "0x185E68790")]
	private void FJGPPCGNLDB(Entity GJBLGBOBAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B70")]
	[Cpp2IlInjected.Address(RVA = "0x5E67D50", Offset = "0x5E66B50", VA = "0x185E67D50")]
	private void CEABLKBMNBD(SceneTag OEPGAFOLKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B71")]
	[Cpp2IlInjected.Address(RVA = "0x5E68890", Offset = "0x5E67690", VA = "0x185E68890")]
	private void GFJLJABFNFI(SceneTag OEPGAFOLKKI, NativeParallelHashSet<int> KCGOKJGMKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B72")]
	[Cpp2IlInjected.Address(RVA = "0x5E688D0", Offset = "0x5E676D0", VA = "0x185E688D0")]
	private void GHPDBGACNNI(SceneTag OEPGAFOLKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x5E691C0", Offset = "0x5E67FC0", VA = "0x185E691C0")]
	private void MLOMAFFMJGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B74")]
	[Cpp2IlInjected.Address(RVA = "0x250DB80", Offset = "0x250C980", VA = "0x18250DB80")]
	private void MHNLAIKIHKF<T>() where T : ComponentSystemBase
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B75")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public PAPIHHEIJJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021E")]
[OCEGCBKNAGD(LJHGMNIEOPD.PhotonRoom)]
[PMDCDBMECJP(typeof(MDOHJIEGLJN), new string[] { })]
internal class NFFJLFBNJHM : ENEHADLKBBF, MDOHJIEGLJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C0")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C1")]
	[PDOCKCLGMBB]
	private PAPIHHEIJJK GAKKCIMPKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C2")]
	private readonly Dictionary<int, Entity> KFBGHLNJFHI;

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x5E602F0", Offset = "0x5E5F0F0", VA = "0x185E602F0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B78")]
	[Cpp2IlInjected.Address(RVA = "0x5E60500", Offset = "0x5E5F300", VA = "0x185E60500", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B79")]
	[Cpp2IlInjected.Address(RVA = "0x5E603B0", Offset = "0x5E5F1B0", VA = "0x185E603B0", Slot = "5")]
	public void IHHCKKFAJPF(EPCANLGBBON GOOJPBOEHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x5E60590", Offset = "0x5E5F390", VA = "0x185E60590", Slot = "6")]
	public bool OEGEJKLAGIE(EPCANLGBBON GOOJPBOEHHC, Transform ILMBKONFEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7B")]
	[Cpp2IlInjected.Address(RVA = "0x5E60340", Offset = "0x5E5F140", VA = "0x185E60340")]
	private bool CODHDCFACDI(Scene GJBLGBOBAMI, [Out] Entity FKJIDINAOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7C")]
	[Cpp2IlInjected.Address(RVA = "0x5E60760", Offset = "0x5E5F560", VA = "0x185E60760")]
	public NFFJLFBNJHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021F")]
[PMDCDBMECJP(typeof(KAFALIKLKOG), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
internal sealed class KAFALIKLKOG : ENEHADLKBBF, GOMKIFEKCFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006C3")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C4")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C5")]
	[PDOCKCLGMBB]
	private PIFEBGBCHME FKKFOAHHICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006C6")]
	private Entity HHHGBIJCKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006C7")]
	private ComponentTypeList NDFBKPCIBAL;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5A590", Offset = "0x5E59390", VA = "0x185E5A590")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7E")]
	[Cpp2IlInjected.Address(RVA = "0x2421B70", Offset = "0x2420970", VA = "0x182421B70")]
	public T HAMDPAFEPLN<T>() where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7F")]
	[Cpp2IlInjected.Address(RVA = "0x2421DF0", Offset = "0x2420BF0", VA = "0x182421DF0")]
	public void MFACMGCFCOL<T>(T POACLGOFKAJ) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x2421960", Offset = "0x2420760", VA = "0x182421960")]
	public DynamicBuffer<T> DHPCOENMKHN<T>(bool IGEJIDKFEOB = false) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x2421C80", Offset = "0x2420A80", VA = "0x182421C80")]
	public void LBMIOCMADJG<T>(T POACLGOFKAJ) where T : struct, IBufferElementData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AC30", Offset = "0x5E59A30", VA = "0x185E5AC30", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A6E0", Offset = "0x5E594E0", VA = "0x185E5A6E0", Slot = "5")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A6E0", Offset = "0x5E594E0", VA = "0x185E5A6E0")]
	private void DKKIFCNOENC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A8D0", Offset = "0x5E596D0", VA = "0x185E5A8D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x5E5ACA0", Offset = "0x5E59AA0", VA = "0x185E5ACA0")]
	private ComponentTypeList PBNHMBCJIPL()
	{
		return default(ComponentTypeList);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void MJCPMMGLIPM(int NENAAIFMEME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0")]
	private static void JDOKFHODHJO(Type FLHOFPAHPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B89")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A5E0", Offset = "0x5E593E0", VA = "0x185E5A5E0")]
	private static void DAINDNBKOHC(Type FLHOFPAHPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8A")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public KAFALIKLKOG()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000220")]
[IMFHLDEPPHL]
internal struct HNIDJKMLKKO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000221")]
[PMDCDBMECJP(typeof(BEJFNELDFAM), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
internal sealed class BEJFNELDFAM : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	private static readonly HICMFDICNOL CHMBILIIBIB;

	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private static readonly HICMFDICNOL CIDPGEFIJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	private FDPPKGIBNLD<OJDBNGOKNMF, Entity> MFKLGGBLAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	private CPPFANIHADA<GGCBBOHACPM> FEEEKIJOPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	private CPPFANIHADA<BGPOLLLCAGL> ACGBKEEPDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	private CPPFANIHADA<NJBHJLNLMEM> JIHCOEEIAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	private CPPFANIHADA<EAGFNLPLLAE> GHHCALAOOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	private CPPFANIHADA<DEBILCAOODK> GGFBOHOPFHI;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public JKCHEBEIFJC<Entity> BBMKCCOOGDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8C")]
		[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public FLHKDBJMMJA ILNGIPDLFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8D")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public FLHKDBJMMJA DLCPMPCEAJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8E")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public FLHKDBJMMJA EHEMHABIHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B8F")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public FLHKDBJMMJA DODNKGHDKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B90")]
		[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public FLHKDBJMMJA KMJLCACMMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000B91")]
		[Cpp2IlInjected.Address(RVA = "0x769880", Offset = "0x768680", VA = "0x180769880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	private EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B92")]
		[Cpp2IlInjected.Address(RVA = "0x5E73B50", Offset = "0x5E72950", VA = "0x185E73B50")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x5E73C90", Offset = "0x5E72A90", VA = "0x185E73C90", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x5E73BA0", Offset = "0x5E729A0", VA = "0x185E73BA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B95")]
	[Cpp2IlInjected.Address(RVA = "0x2160B00", Offset = "0x215F900", VA = "0x182160B00")]
	private void LKOIJBFKMJL<T>(CPPFANIHADA<T> HAAKHKPMLLI, EntityCommandBufferSystem NFGGBBOFGOH, HICMFDICNOL DFCBIKLJFPD) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B96")]
	[Cpp2IlInjected.Address(RVA = "0x2160BB0", Offset = "0x215F9B0", VA = "0x182160BB0")]
	private void LKOIJBFKMJL<TC, TV>(FDPPKGIBNLD<TC, TV> HAAKHKPMLLI) where TC : struct, KMGHKNHPEGG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B97")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BEJFNELDFAM()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000222")]
public struct BGPOLLLCAGL : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000223")]
public struct GGCBBOHACPM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000224")]
public struct NJBHJLNLMEM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000225")]
public struct EAGFNLPLLAE : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000226")]
public struct DEBILCAOODK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000227")]
[ExecuteAlways]
public class JAJBDFDDDNN : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000B99")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	public JAJBDFDDDNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000228")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(JCAPAODMBEM), new string[] { })]
internal sealed class JCAPAODMBEM : EPBKMCPBINK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	private GENLCCCIOIL OLFHCKEFDEI;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public GENLCCCIOIL AHDHOFLHMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0x1C04D30", Offset = "0x1C03B30", VA = "0x181C04D30")]
		get
		{
			return default(GENLCCCIOIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x5E78D30", Offset = "0x5E77B30", VA = "0x185E78D30", Slot = "4")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x5E78D20", Offset = "0x5E77B20", VA = "0x185E78D20", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public JCAPAODMBEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000229")]
[PMDCDBMECJP(typeof(PEIDJIEIOHO), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
internal sealed class PEIDJIEIOHO
{
	[Cpp2IlInjected.Token(Token = "0x200022A")]
	public enum KNBLGMBHCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		Gameplay,
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		ObjectModel
	}

	[Cpp2IlInjected.Token(Token = "0x200022B")]
	public struct IPBFKHMGJOI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private KNBLGMBHCPJ HHHHIBHJAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private readonly PEIDJIEIOHO LPDGANJNOMK;

		[Cpp2IlInjected.Token(Token = "0x6000BA5")]
		[Cpp2IlInjected.Address(RVA = "0x5E78CD0", Offset = "0x5E77AD0", VA = "0x185E78CD0")]
		public IPBFKHMGJOI(PEIDJIEIOHO LPDGANJNOMK, KNBLGMBHCPJ HMFMKKPCCOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BA6")]
		[Cpp2IlInjected.Address(RVA = "0x5E78CB0", Offset = "0x5E77AB0", VA = "0x185E78CB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	public KNBLGMBHCPJ HMFMKKPCCOG;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public KNBLGMBHCPJ IGIDPCKNCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B9E")]
		[Cpp2IlInjected.Address(RVA = "0x75D180", Offset = "0x75BF80", VA = "0x18075D180")]
		get
		{
			return default(KNBLGMBHCPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B9F")]
		[Cpp2IlInjected.Address(RVA = "0x76B340", Offset = "0x76A140", VA = "0x18076B340")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool OGJJPDEPHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000BA0")]
		[Cpp2IlInjected.Address(RVA = "0x4F3CF40", Offset = "0x4F3BD40", VA = "0x184F3CF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x5E7ED70", Offset = "0x5E7DB70", VA = "0x185E7ED70")]
	public IPBFKHMGJOI HBKOGAJHFCL()
	{
		return default(IPBFKHMGJOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA2")]
	[Cpp2IlInjected.Address(RVA = "0x5E7ED20", Offset = "0x5E7DB20", VA = "0x185E7ED20")]
	public IPBFKHMGJOI AKNPFPEFOLG()
	{
		return default(IPBFKHMGJOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA3")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public PEIDJIEIOHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022C")]
[PMDCDBMECJP(typeof(KOHKCDKIBEL), new string[] { })]
internal class PNGIJEHHGHJ : KOHKCDKIBEL, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	[PDOCKCLGMBB]
	private NMGOMOEFNEJ FFEDJHJFICN;

	[Cpp2IlInjected.Token(Token = "0x6000BA7")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F200", Offset = "0x5E7E000", VA = "0x185E7F200", Slot = "8")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA8")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F380", Offset = "0x5E7E180", VA = "0x185E7F380", Slot = "4")]
	public World PEOMDAHDFPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA9")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F160", Offset = "0x5E7DF60", VA = "0x185E7F160", Slot = "5")]
	public World HNCACBLJOBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAA")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F0C0", Offset = "0x5E7DEC0", VA = "0x185E7F0C0", Slot = "6")]
	public World FNMIPCEAAII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F250", Offset = "0x5E7E050", VA = "0x185E7F250", Slot = "7")]
	public World MCOCCPCJLBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAC")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F2F0", Offset = "0x5E7E0F0", VA = "0x185E7F2F0")]
	private World NEIJJJNPIGA(string MEBBBIMBIJO, JDCCDMKNOIF INEMIPHENMH, Type GNNGCDCGAIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAD")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public PNGIJEHHGHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022D")]
[PMDCDBMECJP(typeof(MMKPBHDHKLP), new string[] { })]
public class AGLGOPJGDGP : ENEHADLKBBF, MMKPBHDHKLP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200022E")]
	[CompilerGenerated]
	private struct BMCGMOKLDEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		public EPCANLGBBON parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		public AGLGOPJGDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public FCKGLGLACJO objBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private ELJLMFEGKCH <parentObject>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x5E741A0", Offset = "0x5E72FA0", VA = "0x185E741A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x5E746E0", Offset = "0x5E734E0", VA = "0x185E746E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200022F")]
	[CompilerGenerated]
	private struct IAJKIBDOENH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		public AGLGOPJGDGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		public ELJLMFEGKCH obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x5E786F0", Offset = "0x5E774F0", VA = "0x185E786F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC3")]
		[Cpp2IlInjected.Address(RVA = "0x5E78BE0", Offset = "0x5E779E0", VA = "0x185E78BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private Dictionary<EPCANLGBBON, Task> FDPPNHGJMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	[PDOCKCLGMBB]
	private EFHPECABBJE JOJOJMCMCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private EntityManager GMDAKDJOHKE;

	[Cpp2IlInjected.Token(Token = "0x6000BAE")]
	[Cpp2IlInjected.Address(RVA = "0x5E719C0", Offset = "0x5E707C0", VA = "0x185E719C0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAF")]
	[Cpp2IlInjected.Address(RVA = "0x5E71C00", Offset = "0x5E70A00", VA = "0x185E71C00", Slot = "5")]
	public bool MJNKJJPJMAK(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB0")]
	[Cpp2IlInjected.Address(RVA = "0x5E70C70", Offset = "0x5E6FA70", VA = "0x185E70C70", Slot = "7")]
	public bool CAJIKPFIFHH(EPCANLGBBON GOOJPBOEHHC, [Out] Guid BELINILLNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB1")]
	[Cpp2IlInjected.Address(RVA = "0x5E712C0", Offset = "0x5E700C0", VA = "0x185E712C0", Slot = "8")]
	public Guid GGBGIKFBMHH(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB2")]
	[Cpp2IlInjected.Address(RVA = "0x5E710E0", Offset = "0x5E6FEE0", VA = "0x185E710E0", Slot = "9")]
	public void FIOBPOGNLNA(EPCANLGBBON GOOJPBOEHHC, Guid BELINILLNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB3")]
	[Cpp2IlInjected.Address(RVA = "0x5E71020", Offset = "0x5E6FE20", VA = "0x185E71020", Slot = "10")]
	public bool DFLBDCNEMHK(EPCANLGBBON GOOJPBOEHHC, [Out] Guid CIANJEHDGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB4")]
	[Cpp2IlInjected.Address(RVA = "0x5E71DA0", Offset = "0x5E70BA0", VA = "0x185E71DA0", Slot = "11")]
	public Guid NFEJDCLDFCI(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB5")]
	[Cpp2IlInjected.Address(RVA = "0x5E70E40", Offset = "0x5E6FC40", VA = "0x185E70E40", Slot = "12")]
	public void COLMAAEJCHC(EPCANLGBBON GOOJPBOEHHC, Guid CIANJEHDGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB6")]
	[Cpp2IlInjected.Address(RVA = "0x5E70BE0", Offset = "0x5E6F9E0", VA = "0x185E70BE0", Slot = "13")]
	public void BDLIBDBKHNA(EPCANLGBBON GOOJPBOEHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB7")]
	[Cpp2IlInjected.Address(RVA = "0x5E71650", Offset = "0x5E70450", VA = "0x185E71650", Slot = "14")]
	public void IKMANBGJFGJ(EPCANLGBBON PABBJIBBIGE, EPCANLGBBON LPDGANJNOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB8")]
	[Cpp2IlInjected.Address(RVA = "0x5E70D30", Offset = "0x5E6FB30", VA = "0x185E70D30")]
	[AsyncStateMachine(typeof(BMCGMOKLDEN))]
	private Task CDMMAAEAIIC(FCKGLGLACJO ONKHEEOKAJF, EPCANLGBBON LPDGANJNOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB9")]
	[Cpp2IlInjected.Address(RVA = "0x5E71A60", Offset = "0x5E70860", VA = "0x185E71A60")]
	private void MBJNFHIHPHM(FCKGLGLACJO ONKHEEOKAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBA")]
	[Cpp2IlInjected.Address(RVA = "0x5E71CC0", Offset = "0x5E70AC0", VA = "0x185E71CC0")]
	[AsyncStateMachine(typeof(IAJKIBDOENH))]
	private Task MNOLPHDPGEM(ELJLMFEGKCH DGPHOMINFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBB")]
	[Cpp2IlInjected.Address(RVA = "0x5E71380", Offset = "0x5E70180", VA = "0x185E71380")]
	private Task GJFJILLPENL(ELJLMFEGKCH DGPHOMINFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBC")]
	[Cpp2IlInjected.Address(RVA = "0x5E71550", Offset = "0x5E70350", VA = "0x185E71550")]
	private Task IBIAPICLJJD(ELJLMFEGKCH DGPHOMINFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBD")]
	[Cpp2IlInjected.Address(RVA = "0x5E714D0", Offset = "0x5E702D0", VA = "0x185E714D0", Slot = "6")]
	public bool IBELBOAPPGN(EPCANLGBBON ALPEICGOMCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBE")]
	[Cpp2IlInjected.Address(RVA = "0x5E71EF0", Offset = "0x5E70CF0", VA = "0x185E71EF0")]
	public AGLGOPJGDGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000230")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[PMDCDBMECJP(typeof(BBHMMLFFNGO), new string[] { })]
public class BBHMMLFFNGO : ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EC")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006ED")]
	[PDOCKCLGMBB]
	private NKBJOPBBMIN MFNODIMGLDN;

	[Cpp2IlInjected.Token(Token = "0x6000BC4")]
	[Cpp2IlInjected.Address(RVA = "0x5E73230", Offset = "0x5E72030", VA = "0x185E73230", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC5")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public BBHMMLFFNGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000231")]
[PMDCDBMECJP(typeof(CDHIAMFLODP), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
internal sealed class CDHIAMFLODP : ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x40006EE")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F0")]
	[PDOCKCLGMBB]
	private OCBCABNBPGK OAOKOGKMONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	[PDOCKCLGMBB]
	private PEBNOEHGCDD IOCIENKFOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	[PDOCKCLGMBB]
	private GNIFDDKOOBH DLKOKMHJHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	[PDOCKCLGMBB]
	private NDPEAMPCMHG KDKGHICNAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	[PDOCKCLGMBB]
	private GHPEHOJGHEO LLKEADDLDLF;

	[Cpp2IlInjected.Token(Token = "0x6000BC6")]
	[Cpp2IlInjected.Address(RVA = "0x5E74AD0", Offset = "0x5E738D0", VA = "0x185E74AD0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC7")]
	[Cpp2IlInjected.Address(RVA = "0x5E747E0", Offset = "0x5E735E0", VA = "0x185E747E0")]
	public void FEMICPIABAA(NativeArray<GPKGCNFDJCC> JHHBEFKAAPJ, NativeArray<GFPOPKJOMLL> AINFNEHLDGJ, NativeArray<Entity> MMMPGPKJOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC8")]
	[Cpp2IlInjected.Address(RVA = "0x5E747D0", Offset = "0x5E735D0", VA = "0x185E747D0")]
	public Entity FEMICPIABAA(GPKGCNFDJCC LEGGGLNIAOM, GFPOPKJOMLL OEAOJAGKHME)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC9")]
	[Cpp2IlInjected.Address(RVA = "0x5E74930", Offset = "0x5E73730", VA = "0x185E74930")]
	public Entity FLLGFEEDHEM(GPKGCNFDJCC LEGGGLNIAOM, bool JIDJICCOGJB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCA")]
	[Cpp2IlInjected.Address(RVA = "0x5E74980", Offset = "0x5E73780", VA = "0x185E74980")]
	public Entity FLLGFEEDHEM(GPKGCNFDJCC LEGGGLNIAOM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCB")]
	[Cpp2IlInjected.Address(RVA = "0x5E74740", Offset = "0x5E73540", VA = "0x185E74740")]
	public Entity FACHJNNMDGJ()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCC")]
	[Cpp2IlInjected.Address(RVA = "0x5E74780", Offset = "0x5E73580", VA = "0x185E74780")]
	public Entity FCOBDHJJCKJ(JFBOGCJIFLL FLHOFPAHPKL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCD")]
	[Cpp2IlInjected.Address(RVA = "0x5E74E60", Offset = "0x5E73C60", VA = "0x185E74E60")]
	public LLKJHKLONBK OPCJGNACCBJ(LLKJHKLONBK PJFCFEHPPLM, Allocator MBGJLDPPIJN)
	{
		return default(LLKJHKLONBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCE")]
	[Cpp2IlInjected.Address(RVA = "0x5E74A90", Offset = "0x5E73890", VA = "0x185E74A90")]
	public EntityArchetype ILAJLDPCNND(GPKGCNFDJCC LEGGGLNIAOM)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCF")]
	[Cpp2IlInjected.Address(RVA = "0x5E74D10", Offset = "0x5E73B10", VA = "0x185E74D10")]
	public Entity KNKDPFLNNOD(GPKGCNFDJCC LEGGGLNIAOM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD0")]
	[Cpp2IlInjected.Address(RVA = "0x5E74930", Offset = "0x5E73730", VA = "0x185E74930")]
	private Entity NGDNFFFEKAC(GPKGCNFDJCC LEGGGLNIAOM, bool JIDJICCOGJB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD1")]
	[Cpp2IlInjected.Address(RVA = "0x5E74980", Offset = "0x5E73780", VA = "0x185E74980")]
	private Entity NGDNFFFEKAC(GPKGCNFDJCC LEGGGLNIAOM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD2")]
	[Cpp2IlInjected.Address(RVA = "0x5E74D30", Offset = "0x5E73B30", VA = "0x185E74D30")]
	private Entity NGDNFFFEKAC(GPKGCNFDJCC LEGGGLNIAOM, GFPOPKJOMLL OEAOJAGKHME)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD3")]
	[Cpp2IlInjected.Address(RVA = "0x5E749C0", Offset = "0x5E737C0", VA = "0x185E749C0")]
	private void HNGPHNAIOLJ(GPKGCNFDJCC LEGGGLNIAOM, NativeArray<GFPOPKJOMLL> AINFNEHLDGJ, NativeArray<Entity> MMMPGPKJOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD4")]
	[Cpp2IlInjected.Address(RVA = "0x5E74BC0", Offset = "0x5E739C0", VA = "0x185E74BC0")]
	private void JDFNMIMOMBE(NativeArray<GPKGCNFDJCC> JHHBEFKAAPJ, NativeArray<GFPOPKJOMLL> AINFNEHLDGJ, NativeArray<Entity> MMMPGPKJOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD5")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public CDHIAMFLODP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000232")]
[PMDCDBMECJP(typeof(GNIFDDKOOBH), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
internal sealed class GNIFDDKOOBH : ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	public static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	[PDOCKCLGMBB]
	private BPHHNANPLNM LEEGGEIACAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	[PDOCKCLGMBB]
	private OCBCABNBPGK NIEPCIAKCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	[PDOCKCLGMBB]
	private PEBNOEHGCDD AEPFPJHLCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006F9")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006FA")]
	private NativeParallelHashMap<GFPOPKJOMLL, Entity> DALECIECPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006FB")]
	private EntityManager GMDAKDJOHKE;

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	internal NativeParallelHashMap<GFPOPKJOMLL, Entity> COKPJOPJOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD7")]
		[Cpp2IlInjected.Address(RVA = "0xD77A70", Offset = "0xD76870", VA = "0x180D77A70")]
		get
		{
			return default(NativeParallelHashMap<GFPOPKJOMLL, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	internal uint AHMAGANMBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD8")]
		[Cpp2IlInjected.Address(RVA = "0x5E77890", Offset = "0x5E76690", VA = "0x185E77890")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	private bool LIODFMEFOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD9")]
		[Cpp2IlInjected.Address(RVA = "0x856A80", Offset = "0x855880", VA = "0x180856A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDA")]
	[Cpp2IlInjected.Address(RVA = "0x5E77C30", Offset = "0x5E76A30", VA = "0x185E77C30", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDB")]
	[Cpp2IlInjected.Address(RVA = "0x5E778C0", Offset = "0x5E766C0", VA = "0x185E778C0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDC")]
	[Cpp2IlInjected.Address(RVA = "0x5E78090", Offset = "0x5E76E90", VA = "0x185E78090")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDD")]
	[Cpp2IlInjected.Address(RVA = "0x5E77FC0", Offset = "0x5E76DC0", VA = "0x185E77FC0")]
	public GFPOPKJOMLL JIGNFGLPOBN(int NENAAIFMEME)
	{
		return default(GFPOPKJOMLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDE")]
	[Cpp2IlInjected.Address(RVA = "0x5E77930", Offset = "0x5E76730", VA = "0x185E77930")]
	public void ENHGJKAMMEG(GFPOPKJOMLL OEAOJAGKHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDF")]
	[Cpp2IlInjected.Address(RVA = "0x5E77D50", Offset = "0x5E76B50", VA = "0x185E77D50")]
	public EPCANLGBBON JBAAODIOIGA(GFPOPKJOMLL OEAOJAGKHME)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE0")]
	[Cpp2IlInjected.Address(RVA = "0x5E78110", Offset = "0x5E76F10", VA = "0x185E78110")]
	public bool NLAJJAMPGCF(GFPOPKJOMLL OEAOJAGKHME, [Out] EPCANLGBBON GOOJPBOEHHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE1")]
	[Cpp2IlInjected.Address(RVA = "0x5E77E90", Offset = "0x5E76C90", VA = "0x185E77E90")]
	public LLKJHKLONBK JBAAODIOIGA(NativeArray<GFPOPKJOMLL> OEAOJAGKHME, Allocator MBGJLDPPIJN)
	{
		return default(LLKJHKLONBK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE2")]
	[Cpp2IlInjected.Address(RVA = "0x5E77B80", Offset = "0x5E76980", VA = "0x185E77B80")]
	public GFPOPKJOMLL GONHBLIMNHN(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(GFPOPKJOMLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE3")]
	[Cpp2IlInjected.Address(RVA = "0x5E77AF0", Offset = "0x5E768F0", VA = "0x185E77AF0")]
	public GFPOPKJOMLL GONHBLIMNHN(Entity HHHGBIJCKBC)
	{
		return default(GFPOPKJOMLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE4")]
	[Cpp2IlInjected.Address(RVA = "0x5E78210", Offset = "0x5E77010", VA = "0x185E78210")]
	public void ODBCIKEIBBL(NativeArray<Entity> DDIFFODKOKJ, NativeArray<GFPOPKJOMLL> AINFNEHLDGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE5")]
	[Cpp2IlInjected.Address(RVA = "0x5E78370", Offset = "0x5E77170", VA = "0x185E78370")]
	private EPCANLGBBON PPCFKLECJPN(Entity HHHGBIJCKBC)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE6")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public GNIFDDKOOBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000233")]
[PMDCDBMECJP(typeof(AEPPNFHDEIC), new string[] { })]
public sealed class JFCNABBCFHK : AEPPNFHDEIC, CDMEBCJCIKK, EPBKMCPBINK, ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006FD")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006FE")]
	[PDOCKCLGMBB]
	private CNBPFEEKBEF AENJCIFEOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006FF")]
	private Collider[] KANCHEFAGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000700")]
	private RaycastHit[] BJPBMPPNBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000701")]
	private OGJMEHDNBBP<HBHNGGLABBL, BoxCollider> BHINPNEJICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000702")]
	private Scene GJBLGBOBAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000703")]
	private PhysicsScene EHOFODPKLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000704")]
	private GameObject LHMPGCOFOMN;

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x5E79CB0", Offset = "0x5E78AB0", VA = "0x185E79CB0", Slot = "9")]
	public void IODBNFIJEID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x5E79E10", Offset = "0x5E78C10", VA = "0x185E79E10", Slot = "10")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x5E79570", Offset = "0x5E78370", VA = "0x185E79570", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A1D0", Offset = "0x5E78FD0", VA = "0x185E7A1D0", Slot = "4")]
	public HBHNGGLABBL MPKMIHOGHGG(Entity HHHGBIJCKBC)
	{
		return default(HBHNGGLABBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEC")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A310", Offset = "0x5E79110", VA = "0x185E7A310", Slot = "5")]
	public void PBIAJLAEGKI(NativeArray<HBHNGGLABBL> BCGILKHGDIO, NativeArray<KCDEJHDGIAK> FIHPOMHFCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x5E794B0", Offset = "0x5E782B0", VA = "0x185E794B0", Slot = "6")]
	public void BOHPCGLHLGM(HBHNGGLABBL OFGGCMDABFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x5E79EE0", Offset = "0x5E78CE0", VA = "0x185E79EE0", Slot = "7")]
	public bool JCPHKOFOKIE(HBHNGGLABBL OFGGCMDABFP, [Out] Collider DOMPEOMIALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x5E799D0", Offset = "0x5E787D0", VA = "0x185E799D0")]
	public bool IIAOEKBAMIF([In] float3 IEGMKHJBCLL, [In] float3 EFMDODKKOAD, float HGECKMNELOA, Allocator MBGJLDPPIJN, [Out] NativeArray<Entity> DDIFFODKOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF0")]
	[Cpp2IlInjected.Address(RVA = "0x5E79880", Offset = "0x5E78680", VA = "0x185E79880")]
	private void FJLMKGGCHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF1")]
	[Cpp2IlInjected.Address(RVA = "0x872670", Offset = "0x871470", VA = "0x180872670")]
	private void OPLOGGBNJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF2")]
	[Cpp2IlInjected.Address(RVA = "0x5E79680", Offset = "0x5E78480", VA = "0x185E79680")]
	private void EENOJCFPBED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF3")]
	[Cpp2IlInjected.Address(RVA = "0x59B5670", Offset = "0x59B4470", VA = "0x1859B5670")]
	private void FHKMNPGOEPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF4")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A570", Offset = "0x5E79370", VA = "0x185E7A570")]
	private BoxCollider PJAIKKIAGKA(Entity HHHGBIJCKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF5")]
	[Cpp2IlInjected.Address(RVA = "0x5E793E0", Offset = "0x5E781E0", VA = "0x185E793E0")]
	private void AFGFFDIJAJI(BoxCollider GACEJMKPDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF6")]
	[Cpp2IlInjected.Address(RVA = "0x5E796D0", Offset = "0x5E784D0", VA = "0x185E796D0")]
	private void FEBFHIJDKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF7")]
	[Cpp2IlInjected.Address(RVA = "0x5E798D0", Offset = "0x5E786D0", VA = "0x185E798D0")]
	private void FMCFAOLEELF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF8")]
	[Cpp2IlInjected.Address(RVA = "0x5E79FC0", Offset = "0x5E78DC0", VA = "0x185E79FC0")]
	private void LKBBDEICLCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF9")]
	[Cpp2IlInjected.Address(RVA = "0x5E79F80", Offset = "0x5E78D80", VA = "0x185E79F80")]
	private void KJEGNFCOGIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFA")]
	[Cpp2IlInjected.Address(RVA = "0x5E79FB0", Offset = "0x5E78DB0", VA = "0x185E79FB0")]
	private void KLFMNJBBOFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFB")]
	[Cpp2IlInjected.Address(RVA = "0x5E79470", Offset = "0x5E78270", VA = "0x185E79470")]
	private void BLCJNAFPIGK(Scene EGCAOPOCPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFC")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public JFCNABBCFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFE")]
	[Cpp2IlInjected.Address(RVA = "0x5E79460", Offset = "0x5E78260", VA = "0x185E79460", Slot = "8")]
	private bool BBGIHLEKENM([In] float3 IEGMKHJBCLL, [In] float3 EFMDODKKOAD, float HGECKMNELOA, Allocator MBGJLDPPIJN, [Out] NativeArray<Entity> DDIFFODKOKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000234")]
[OCEGCBKNAGD(LJHGMNIEOPD.OMRoom)]
[MOIMDPIFMGK(typeof(KDKEOLOEKEJ))]
[PMDCDBMECJP(typeof(KJNEFHMCGBH), new string[] { })]
internal class KJNEFHMCGBH : ENEHADLKBBF, KDKEOLOEKEJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000705")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000707")]
	[PDOCKCLGMBB]
	private DICMBGCFOEP AANIPHFOBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000708")]
	private CFKGEIBPPPD NJJFALNEFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private NativeList<byte> LMCJHCIOIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400070A")]
	private NativeList<LNIKGFKEIBE> NABJACIPLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400070B")]
	private NativeList<IAIFOJGGPJK> IDIDNDJBJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400070C")]
	private int DHAGOCMAJEP;

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<LNIKGFKEIBE, NativeArray<byte>> IEMPGKINGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A850", Offset = "0x5E79650", VA = "0x185E7A850")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A720", Offset = "0x5E79520", VA = "0x185E7A720")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C01")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A900", Offset = "0x5E79700", VA = "0x185E7A900", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C02")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A7D0", Offset = "0x5E795D0", VA = "0x185E7A7D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AAB0", Offset = "0x5E798B0", VA = "0x185E7AAB0", Slot = "5")]
	public void MNKLGPMCNLK(LNIKGFKEIBE PGGBKFCMLMO, ReadOnlySpan<byte> JOPBACODGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AA30", Offset = "0x5E79830", VA = "0x185E7AA30")]
	public void LHLJEDFLAKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C05")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public KJNEFHMCGBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000235")]
[PMDCDBMECJP(typeof(GFJMBCLPNDO), new string[] { })]
internal class LHNCOBBENJA : GFJMBCLPNDO, ENEHADLKBBF, GOMKIFEKCFK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000236")]
	[CompilerGenerated]
	private sealed class BEHHFDDGJJI : IEnumerable<EPCANLGBBON>, IEnumerable, IEnumerator<EPCANLGBBON>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		private EPCANLGBBON <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public LHNCOBBENJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		private EPCANLGBBON localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		public EPCANLGBBON <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		private NativeArray<Entity> <childEntitiesCopy>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		private NativeArray<Entity>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		private EPCANLGBBON System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C28")]
			[Cpp2IlInjected.Address(RVA = "0x30A8E80", Offset = "0x30A7C80", VA = "0x1830A8E80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(EPCANLGBBON);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C2A")]
			[Cpp2IlInjected.Address(RVA = "0x5E739C0", Offset = "0x5E727C0", VA = "0x185E739C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x32FE2C0", Offset = "0x32FD0C0", VA = "0x1832FE2C0")]
		[DebuggerHidden]
		public BEHHFDDGJJI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x5E73A10", Offset = "0x5E72810", VA = "0x185E73A10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x5E73530", Offset = "0x5E72330", VA = "0x185E73530", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x5E734E0", Offset = "0x5E722E0", VA = "0x185E734E0")]
		private void LAJOCHINEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x5E73490", Offset = "0x5E72290", VA = "0x185E73490")]
		private void KMKNJEPJJNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x5E73970", Offset = "0x5E72770", VA = "0x185E73970", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0x5E738C0", Offset = "0x5E726C0", VA = "0x185E738C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EPCANLGBBON> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0x5E738C0", Offset = "0x5E726C0", VA = "0x185E738C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400070D")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.Token(Token = "0x400070E")]
	private static readonly HICMFDICNOL HPPDHANLJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000713")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000714")]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000715")]
	private JIPIIDIJFIE IFKIGJDABJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000716")]
	private GIBPJGGCEHP KKMEMAJNNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private KPOPJMLJIEE<Entity> HLKCBBNLLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	private KPOPJMLJIEE<float3> LKKADGNLGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private KPOPJMLJIEE<quaternion> IMKLEBLONGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private KPOPJMLJIEE<float> IHJECMMKCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400071B")]
	private HashSet<Entity> LAODOFDPBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400071C")]
	private HashSet<Entity> IDHLKEGCJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400071D")]
	private EntityQuery NFHDEJNJDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400071E")]
	private bool FGEBCHHJFIF;

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<EPCANLGBBON, EPCANLGBBON> DPIAIGFNPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C5E0", Offset = "0x5E7B3E0", VA = "0x185E7C5E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C000", Offset = "0x5E7AE00", VA = "0x185E7C000", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<EPCANLGBBON, EPCANLGBBON> GFCEFHLMEGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C09")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B7F0", Offset = "0x5E7A5F0", VA = "0x185E7B7F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B060", Offset = "0x5E79E60", VA = "0x185E7B060", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<EPCANLGBBON, EPCANLGBBON, EPCANLGBBON> LCPNHMOJDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CB10", Offset = "0x5E7B910", VA = "0x185E7CB10", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C0C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C2A0", Offset = "0x5E7B0A0", VA = "0x185E7C2A0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<EPCANLGBBON> KPAKICBDBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B3F0", Offset = "0x5E7A1F0", VA = "0x185E7B3F0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C690", Offset = "0x5E7B490", VA = "0x185E7C690", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C140", Offset = "0x5E7AF40", VA = "0x185E7C140", Slot = "22")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C10")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B8A0", Offset = "0x5E7A6A0", VA = "0x185E7B8A0", Slot = "23")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C11")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B4A0", Offset = "0x5E7A2A0", VA = "0x185E7B4A0", Slot = "24")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C12")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B110", Offset = "0x5E79F10", VA = "0x185E7B110")]
	private void AMBKHKGDOEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C13")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C350", Offset = "0x5E7B150", VA = "0x185E7C350")]
	private void LLFBPEKDDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C14")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C740", Offset = "0x5E7B540", VA = "0x185E7C740")]
	private void OANBEAKMFIG(NGPHMHKDGKO LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C15")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CC60", Offset = "0x5E7BA60", VA = "0x185E7CC60")]
	private void PONDODJCGHP(NGPHMHKDGKO LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C16")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B170", Offset = "0x5E79F70", VA = "0x185E7B170", Slot = "12")]
	public bool CBBIGLCEEOL(EPCANLGBBON GOOJPBOEHHC, EPCANLGBBON KGBHCEEKCPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C17")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CBC0", Offset = "0x5E7B9C0", VA = "0x185E7CBC0", Slot = "13")]
	public EPCANLGBBON PNAFHJEGBOG(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C18")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C9C0", Offset = "0x5E7B7C0", VA = "0x185E7C9C0", Slot = "16")]
	public void PAKMLPCDEOO(EPCANLGBBON GOOJPBOEHHC, Vector3 FGKFJPNFICF, Quaternion FCCPNIOKMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C19")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C560", Offset = "0x5E7B360", VA = "0x185E7C560", Slot = "17")]
	public void MEIHDIDBFME(EPCANLGBBON GOOJPBOEHHC, float IAHLFMLLBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C4D0", Offset = "0x5E7B2D0", VA = "0x185E7C4D0", Slot = "20")]
	public float3 LLLIOBJIPJF(MODNCCBFLGM JDIGONPMMKC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C940", Offset = "0x5E7B740", VA = "0x185E7C940", Slot = "21")]
	public quaternion ODHLNELIIHA(MODNCCBFLGM JDIGONPMMKC)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7B210", Offset = "0x5E7A010", VA = "0x185E7B210", Slot = "18")]
	public bool CJBOJNNIMNM(EPCANLGBBON GOOJPBOEHHC, [Out] RigidTransform CFHNOHGOGGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7AEF0", Offset = "0x5E79CF0", VA = "0x185E7AEF0", Slot = "19")]
	public bool AANJGKIPHKH(EPCANLGBBON GOOJPBOEHHC, [Out] float IAHLFMLLBJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7C0B0", Offset = "0x5E7AEB0", VA = "0x185E7C0B0", Slot = "14")]
	[IteratorStateMachine(typeof(BEHHFDDGJJI))]
	public IEnumerable<EPCANLGBBON> IONHFFFECPD(EPCANLGBBON GOOJPBOEHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7BEA0", Offset = "0x5E7ACA0", VA = "0x185E7BEA0", Slot = "15")]
	public EPCANLGBBON FJLDKAGDPAH(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C20")]
	[Cpp2IlInjected.Address(RVA = "0x5E7BD80", Offset = "0x5E7AB80", VA = "0x185E7BD80")]
	private Entity FJLDKAGDPAH(Entity HHHGBIJCKBC)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C21")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CDE0", Offset = "0x5E7BBE0", VA = "0x185E7CDE0")]
	public LHNCOBBENJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000237")]
[PMDCDBMECJP(typeof(ODAIDNHAJCE), new string[] { })]
public sealed class FDNBIHCHFDO : ODAIDNHAJCE, ENEHADLKBBF
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000238")]
	private struct FJLBLKLEIEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072A")]
		public float JHLLJPIPCOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072B")]
		public uint NBENGMJKPEI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000727")]
	[PDOCKCLGMBB]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000728")]
	[PDOCKCLGMBB]
	private CDMEBCJCIKK GFNJMBDCLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000729")]
	[PDOCKCLGMBB]
	private ACBNOOGCDBD OLLLANMLPCG;

	[Cpp2IlInjected.Token(Token = "0x6000C2D")]
	[Cpp2IlInjected.Address(RVA = "0x5E757D0", Offset = "0x5E745D0", VA = "0x185E757D0", Slot = "5")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2E")]
	[Cpp2IlInjected.Address(RVA = "0x5E75320", Offset = "0x5E74120", VA = "0x185E75320")]
	public bool IIAOEKBAMIF([In] float3 IEGMKHJBCLL, [In] float3 EFMDODKKOAD, float HGECKMNELOA, [Out] JDFLAHFKFDI HKLCFOEHNBH, [Out] EPCANLGBBON DNGAALMGOEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2F")]
	[Cpp2IlInjected.Address(RVA = "0x5E75240", Offset = "0x5E74040", VA = "0x185E75240")]
	public static bool IDPKBCGOCCP([In] Span<JDFLAHFKFDI> EDNOJHAFLIE, float HGECKMNELOA, [Out] int OCMJNDDMDAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C30")]
	[Cpp2IlInjected.Address(RVA = "0x5E75860", Offset = "0x5E74660", VA = "0x185E75860")]
	public static float KPEENOJECIL(float JHLLJPIPCOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C31")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FDNBIHCHFDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C32")]
	[Cpp2IlInjected.Address(RVA = "0x5E75890", Offset = "0x5E74690", VA = "0x185E75890", Slot = "4")]
	private bool NHEHHADKJII([In] float3 IEGMKHJBCLL, [In] float3 EFMDODKKOAD, float HGECKMNELOA, [Out] JDFLAHFKFDI HKLCFOEHNBH, [Out] EPCANLGBBON DNGAALMGOEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000239")]
[PMDCDBMECJP(typeof(ACBNOOGCDBD), new string[] { })]
public sealed class MFGBIPPGMDP : ACBNOOGCDBD, ENEHADLKBBF
{
	[Cpp2IlInjected.Token(Token = "0x200023A")]
	[BurstCompile]
	private struct AOODJKLKOFN : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		[ReadOnly]
		public NativeArray<Entity> DDIFFODKOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		[ReadOnly]
		public float3 CMNMNMKHDDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		[ReadOnly]
		public float3 KOAMPMFIMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> IAMJIKAPFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		[ReadOnly]
		public ComponentDataFromEntity<JNGNBCKOIMO> NDGBPIHMNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> NDMHNAMFDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		[ReadOnly]
		public ComponentDataFromEntity<LNMINBHKCKD> DOJFGDGDNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		[ReadOnly]
		public ComponentDataFromEntity<OKDPLEMLFKK> JJHBANBIOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		[WriteOnly]
		public NativeArray<JDFLAHFKFDI> LBADDLEAAFC;

		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private static readonly JDFLAHFKFDI EPMNKDIFHKF;

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x5E725D0", Offset = "0x5E713D0", VA = "0x185E725D0", Slot = "4")]
		public void Execute(int OCMJNDDMDAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x5E72EC0", Offset = "0x5E71CC0", VA = "0x185E72EC0")]
		private static float3 LCDGDHDHHOC([In] float4x4 POOGPMAGLDE, [In] float3 ADKJANDCMME)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x5E73070", Offset = "0x5E71E70", VA = "0x185E73070")]
		private static float3 ONPEOKHEAHF([In] float4x4 POOGPMAGLDE, [In] float3 GBNHGJEMKMH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x5E72F70", Offset = "0x5E71D70", VA = "0x185E72F70")]
		private static float3 NNHHPBJJMPA([In] float4x4 POOGPMAGLDE, [In] float3 ADKJANDCMME)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x5E723F0", Offset = "0x5E711F0", VA = "0x185E723F0")]
		private static float3 EBKHFDOOLCI([In] float4x4 POOGPMAGLDE, [In] float3 GBNHGJEMKMH)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x5E720E0", Offset = "0x5E70EE0", VA = "0x185E720E0")]
		private bool ANPEEIMEAMB([In] float3 IEGMKHJBCLL, [In] float3 EFMDODKKOAD, [In] NativeArray<Entity> PCAKKOHGLED, [Out] float3 HKLCFOEHNBH, [Out] float3 ABLMGKFECDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x5E72870", Offset = "0x5E71670", VA = "0x185E72870")]
		public static bool JNKKDGINAIP([In] float3 HINADHGKFEK, [In] float3 PGIBLGFHKBF, [In] float3 HDOMMMODGKA, [In] float3 NIMJOJMBMAK, float PNONDEMOJBC, float MKBDEAJHHMH, [Out] float EGGPNONKPNJ, [Out] float3 JHBLIKOABFH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072C")]
	private EntityManager GMDAKDJOHKE;

	[Cpp2IlInjected.Token(Token = "0x6000C33")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D4F0", Offset = "0x5E7C2F0", VA = "0x185E7D4F0", Slot = "5")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C34")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D0B0", Offset = "0x5E7BEB0", VA = "0x185E7D0B0")]
	public void IIAOEKBAMIF([In] NativeArray<Entity> DDIFFODKOKJ, [In] float3 IEGMKHJBCLL, [In] float3 EFMDODKKOAD, [In] NativeArray<JDFLAHFKFDI> PEFDEFHJIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C35")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MFGBIPPGMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C36")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D570", Offset = "0x5E7C370", VA = "0x185E7D570", Slot = "4")]
	private void KOGIPFEDAGK([In] NativeArray<Entity> DDIFFODKOKJ, [In] float3 IEGMKHJBCLL, [In] float3 EFMDODKKOAD, [In] NativeArray<JDFLAHFKFDI> PEFDEFHJIFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023B")]
[MOIMDPIFMGK(typeof(AOCFLNALOKJ))]
[PMDCDBMECJP(typeof(GIBPJGGCEHP), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.LoadInstance)]
public class GIBPJGGCEHP : AOCFLNALOKJ, ENEHADLKBBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200023C")]
	private struct GBFKMLHGGII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public AJFPEFELLGP OGHBBALLGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public Type FLHOFPAHPKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200023D")]
	private struct BACMMPLCMFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public GBFKMLHGGII[] NAFNNIMKNLM;
	}

	[Cpp2IlInjected.Token(Token = "0x200023E")]
	[BurstCompile]
	private struct DNPAKMEBEJA : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		[ReadOnly]
		public NativeArray<byte> HKPPGJFAKGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		[ReadOnly]
		public NativeArray<Entity> MAEOIHKFLDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		[ReadOnly]
		public NativeArray<byte> GKNALEBCDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		[ReadOnly]
		public NativeArray<byte> FCDOIKAIOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		[WriteOnly]
		public NativeList<Entity> JNCCBGHOEOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		[WriteOnly]
		public NativeList<byte> PLCBCDJFNKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		[WriteOnly]
		public NativeList<byte> IDJPFIGBDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public int HDBOLFEMKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public int PGJECECPFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public int APGAOKACNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public int BJIJMLIHINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public int JKCKKMIKFIE;

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x5E74F90", Offset = "0x5E73D90", VA = "0x185E74F90", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000737")]
	private static readonly HICMFDICNOL DFCBIKLJFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400073A")]
	private readonly Dictionary<FGBENGKJFDK, AJFPEFELLGP> HAACFNIBEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	private readonly Dictionary<int, BACMMPLCMFM> ECGGENJLLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	private PCGDABHJAAB NAFNNIMKNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action EAONFGFBDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x5E75E60", Offset = "0x5E74C60", VA = "0x185E75E60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x5E770E0", Offset = "0x5E75EE0", VA = "0x185E770E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action MAOLMENGJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x5E76690", Offset = "0x5E75490", VA = "0x185E76690")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x5E773C0", Offset = "0x5E761C0", VA = "0x185E773C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C43")]
	[Cpp2IlInjected.Address(RVA = "0x5E76730", Offset = "0x5E75530", VA = "0x185E76730", Slot = "6")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C44")]
	[Cpp2IlInjected.Address(RVA = "0x5E75F00", Offset = "0x5E74D00", VA = "0x185E75F00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C45")]
	[Cpp2IlInjected.Address(RVA = "0x5E77180", Offset = "0x5E75F80", VA = "0x185E77180", Slot = "4")]
	public void LAPCBGMBHPD(BKOKDGLHFLO GHOAJKHDDHN, AJFPEFELLGP ONPHIIHFHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C46")]
	[Cpp2IlInjected.Address(RVA = "0x5E75D10", Offset = "0x5E74B10", VA = "0x185E75D10", Slot = "5")]
	public void CGLEMEJEKGC(BKOKDGLHFLO GHOAJKHDDHN, AJFPEFELLGP ONPHIIHFHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C47")]
	[Cpp2IlInjected.Address(RVA = "0x5E772D0", Offset = "0x5E760D0", VA = "0x185E772D0", Slot = "8")]
	public void LAPCBGMBHPD(FGBENGKJFDK OGIJMJFMMHK, AJFPEFELLGP PMOMGAGBHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C48")]
	[Cpp2IlInjected.Address(RVA = "0x5E75BF0", Offset = "0x5E749F0", VA = "0x185E75BF0", Slot = "9")]
	public void CGLEMEJEKGC(FGBENGKJFDK OGIJMJFMMHK, AJFPEFELLGP PMOMGAGBHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C49")]
	[Cpp2IlInjected.Address(RVA = "0x5E76060", Offset = "0x5E74E60", VA = "0x185E76060")]
	private void GABGEIJPKFE(FGBENGKJFDK OGIJMJFMMHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4A")]
	[Cpp2IlInjected.Address(RVA = "0x5E763A0", Offset = "0x5E751A0", VA = "0x185E763A0")]
	internal void GKPCFBAOOGM(HDLLCGPJIMD KIGOLAOAAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4B")]
	[Cpp2IlInjected.Address(RVA = "0x5E767A0", Offset = "0x5E755A0", VA = "0x185E767A0")]
	private void JEAKNNJFLHN(HDLLCGPJIMD KIGOLAOAAMI, int NGICFBMMBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4C")]
	[Cpp2IlInjected.Address(RVA = "0x5E77460", Offset = "0x5E76260", VA = "0x185E77460")]
	private void PLGLJEADAHK(JAPFLFMMLAJ CONHAFAMJMM, NPIECMPEGKH KBONLMJECMN, GBFKMLHGGII NLMNDHCJMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4D")]
	[Cpp2IlInjected.Address(RVA = "0x5E76220", Offset = "0x5E75020", VA = "0x185E76220")]
	private BACMMPLCMFM GFPAPMOLFPJ(JAPFLFMMLAJ CONHAFAMJMM, NPIECMPEGKH KBONLMJECMN)
	{
		return default(BACMMPLCMFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4E")]
	[Cpp2IlInjected.Address(RVA = "0x5E75F90", Offset = "0x5E74D90", VA = "0x185E75F90")]
	private GBFKMLHGGII FKHLMEICDFK(BACMMPLCMFM EANGOGNHDFA, JAPFLFMMLAJ CONHAFAMJMM, NPIECMPEGKH KBONLMJECMN)
	{
		return default(GBFKMLHGGII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4F")]
	[Cpp2IlInjected.Address(RVA = "0x5E77740", Offset = "0x5E76540", VA = "0x185E77740")]
	public GIBPJGGCEHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023F")]
[PMDCDBMECJP(typeof(EOJHDACEBHO), new string[] { })]
public class MJEFEPHNBKA : ENEHADLKBBF, GOMKIFEKCFK, EOJHDACEBHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000240")]
	[CompilerGenerated]
	private sealed class LBANEAMPAGJ : IEnumerable<EPCANLGBBON>, IEnumerable, IEnumerator<EPCANLGBBON>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		private EPCANLGBBON <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public MJEFEPHNBKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private EPCANLGBBON splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		public EPCANLGBBON <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		private EPCANLGBBON System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C67")]
			[Cpp2IlInjected.Address(RVA = "0x30A8E80", Offset = "0x30A7C80", VA = "0x1830A8E80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(EPCANLGBBON);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C69")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AEA0", Offset = "0x5E79CA0", VA = "0x185E7AEA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x32FE2C0", Offset = "0x32FD0C0", VA = "0x1832FE2C0")]
		[DebuggerHidden]
		public LBANEAMPAGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C65")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x5E7ACE0", Offset = "0x5E79AE0", VA = "0x185E7ACE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C68")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AE50", Offset = "0x5E79C50", VA = "0x185E7AE50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7ADA0", Offset = "0x5E79BA0", VA = "0x185E7ADA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EPCANLGBBON> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7ADA0", Offset = "0x5E79BA0", VA = "0x185E7ADA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400074D")]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400074E")]
	private CCAABBKKMFL ACIEHBFKONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400074F")]
	private NKBJOPBBMIN MFNODIMGLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000750")]
	private CDHIAMFLODP LLOAICEJOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private ANNAAAPLMJK NAMNFILNEBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private KAFALIKLKOG KIGOEGBOPCN;

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	private EntityManager LHLNHKNJLMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D7D0", Offset = "0x5E7C5D0", VA = "0x185E7D7D0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C53")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D8F0", Offset = "0x5E7C6F0", VA = "0x185E7D8F0", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C54")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
	public void FEHCJNGFIKF(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C55")]
	[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C56")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DE90", Offset = "0x5E7CC90", VA = "0x185E7DE90")]
	private void NBKMLIBCBHH(Entity DJGHIGBIJOM, int OCMJNDDMDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C57")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DAE0", Offset = "0x5E7C8E0", VA = "0x185E7DAE0", Slot = "10")]
	public void LFCJHBKKNAE(EPCANLGBBON GOOJPBOEHHC, LCDOAOMGIMC APKDPMMLKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C58")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D730", Offset = "0x5E7C530", VA = "0x185E7D730", Slot = "9")]
	public LCDOAOMGIMC CJFLOPDCIDH(EPCANLGBBON GOOJPBOEHHC)
	{
		return default(LCDOAOMGIMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C59")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D820", Offset = "0x5E7C620", VA = "0x185E7D820", Slot = "11")]
	public EPCANLGBBON HCGLHAEKFBM(EPCANLGBBON GJLPEMHCMDK, [Optional] float3? CMKBDFOJBFE, [Optional] quaternion? ALADLBOMNEP, [Optional] float3? KLPLLOPDNNO)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5A")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D9E0", Offset = "0x5E7C7E0", VA = "0x185E7D9E0", Slot = "12")]
	public EPCANLGBBON JAAADAADMEB(EPCANLGBBON GJLPEMHCMDK, int OCMJNDDMDAL, [Optional] float3? CMKBDFOJBFE, [Optional] quaternion? ALADLBOMNEP, [Optional] float3? KLPLLOPDNNO)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DC10", Offset = "0x5E7CA10", VA = "0x185E7DC10")]
	private EPCANLGBBON MIFGMLPEGFH(EPCANLGBBON GJLPEMHCMDK, int OCMJNDDMDAL, [Optional] float3? CMKBDFOJBFE, [Optional] quaternion? ALADLBOMNEP, [Optional] float3? KLPLLOPDNNO)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5C")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DF10", Offset = "0x5E7CD10", VA = "0x185E7DF10", Slot = "7")]
	public EPCANLGBBON NMNMPAAEBFG(EPCANLGBBON GJLPEMHCMDK, int OCMJNDDMDAL)
	{
		return default(EPCANLGBBON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5D")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D890", Offset = "0x5E7C690", VA = "0x185E7D890", Slot = "16")]
	public void IKHECIBLMGO(EPCANLGBBON GJLPEMHCMDK, EPCANLGBBON DJGHIGBIJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5E")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D610", Offset = "0x5E7C410", VA = "0x185E7D610", Slot = "13")]
	public void CCADPBMAKCE(EPCANLGBBON GJLPEMHCMDK, int OCMJNDDMDAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5F")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DFF0", Offset = "0x5E7CDF0", VA = "0x185E7DFF0", Slot = "14")]
	public void OLAMMJHDBNO(EPCANLGBBON GJLPEMHCMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DA50", Offset = "0x5E7C850", VA = "0x185E7DA50", Slot = "8")]
	public int KHNBCFOAIGM(EPCANLGBBON GJLPEMHCMDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D580", Offset = "0x5E7C380", VA = "0x185E7D580", Slot = "6")]
	[IteratorStateMachine(typeof(LBANEAMPAGJ))]
	public IEnumerable<EPCANLGBBON> AFMNGIOJGGI(EPCANLGBBON GJLPEMHCMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x5E7DB80", Offset = "0x5E7C980", VA = "0x185E7DB80")]
	private bool LNPLLOAHJAB(EPCANLGBBON GJLPEMHCMDK, [Out] NativeArray<Entity> JNHIBBPLDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public MJEFEPHNBKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000241")]
[PMDCDBMECJP(typeof(HBAAAFNLJEC), new string[] { })]
[OCEGCBKNAGD(LJHGMNIEOPD.LoadInstance)]
public class HBAAAFNLJEC : ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	[PDOCKCLGMBB]
	private KAFALIKLKOG ALFBBPEFDJC;

	[Cpp2IlInjected.Token(Token = "0x6000C6C")]
	[Cpp2IlInjected.Address(RVA = "0x5E78440", Offset = "0x5E77240", VA = "0x185E78440", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6D")]
	[Cpp2IlInjected.Address(RVA = "0x5E78490", Offset = "0x5E77290", VA = "0x185E78490")]
	public void KFPCGMOFGBO(IEnumerable<string> NIONJCPCPOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public HBAAAFNLJEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000242")]
[OCEGCBKNAGD(LJHGMNIEOPD.LoadInstance)]
[PMDCDBMECJP(typeof(GIJJMCKCKCF), new string[] { })]
internal sealed class GIJJMCKCKCF : ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	private BPHHNANPLNM JDDIMGOGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	private PEIDJIEIOHO OHIJLKGECAP;

	[Cpp2IlInjected.Token(Token = "0x6000C6F")]
	[Cpp2IlInjected.Address(RVA = "0x5E77810", Offset = "0x5E76610", VA = "0x185E77810", Slot = "4")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C70")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public GIJJMCKCKCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000243")]
[DefaultMember("Item")]
public struct FFHOFNIGAJE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075E")]
	private T[] LMCJHCIOIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075F")]
	private int JGMNJBPPKGP;

	[Cpp2IlInjected.Token(Token = "0x6000C71")]
	[Cpp2IlInjected.Address(RVA = "0x33A43E0", Offset = "0x33A31E0", VA = "0x1833A43E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000244")]
[DefaultMember("Item")]
public struct FHCACDMOPAJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000760")]
	private FFHOFNIGAJE<T> LMCJHCIOIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private int JGMNJBPPKGP;

	[Cpp2IlInjected.Token(Token = "0x6000C72")]
	[Cpp2IlInjected.Address(RVA = "0x33A4E50", Offset = "0x33A3C50", VA = "0x1833A4E50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C73")]
	[Cpp2IlInjected.Address(RVA = "0x33A4E90", Offset = "0x33A3C90", VA = "0x1833A4E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000245")]
public struct GENLCCCIOIL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private NativeList<Entity> DDIFFODKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000763")]
	private TransformAccessArray FGGAOAAIACJ;

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public int GJPDNICHPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C75")]
		[Cpp2IlInjected.Address(RVA = "0x5E75AE0", Offset = "0x5E748E0", VA = "0x185E75AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	public NativeList<Entity> DDBNEKJPCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000C76")]
		[Cpp2IlInjected.Address(RVA = "0xA9ABA0", Offset = "0xA999A0", VA = "0x180A9ABA0")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	public TransformAccessArray BBHCNKDGIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000C77")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool LIODFMEFOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x5E758A0", Offset = "0x5E746A0", VA = "0x185E758A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C74")]
	[Cpp2IlInjected.Address(RVA = "0x5E75B60", Offset = "0x5E74960", VA = "0x185E75B60")]
	public GENLCCCIOIL(int LCFOKPAENOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C79")]
	[Cpp2IlInjected.Address(RVA = "0x5E75A90", Offset = "0x5E74890", VA = "0x185E75A90")]
	public Entity IAHKBMCJKGC(int OCMJNDDMDAL)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7A")]
	[Cpp2IlInjected.Address(RVA = "0x5E75A40", Offset = "0x5E74840", VA = "0x185E75A40")]
	public void GKGIALNDHHO(int LCFOKPAENOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x5E75940", Offset = "0x5E74740", VA = "0x185E75940")]
	public int EJEJBLJEAIN(Transform ILMBKONFEEP, Entity HHHGBIJCKBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x5E75AF0", Offset = "0x5E748F0", VA = "0x185E75AF0")]
	public int PEMBFGDGKGO(int OCMJNDDMDAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x5E758C0", Offset = "0x5E746C0", VA = "0x185E758C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x5E75A00", Offset = "0x5E74800", VA = "0x185E75A00")]
	private void FHMCPHEHKPL(int KBICEDELGNE = 0)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000246")]
public struct AMBFHPBIOML : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x4000764")]
	public static readonly AMBFHPBIOML IKMLLOOIGKE;

	[Cpp2IlInjected.Token(Token = "0x6000C7F")]
	[Cpp2IlInjected.Address(RVA = "0x5E72060", Offset = "0x5E70E60", VA = "0x185E72060", Slot = "4")]
	public bool Equals(LinkedEntityGroup NPDPLEIHBMM, LinkedEntityGroup CINKHPOEGPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C80")]
	[Cpp2IlInjected.Address(RVA = "0x5E72080", Offset = "0x5E70E80", VA = "0x185E72080", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup DGPHOMINFCK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000247")]
internal class CAOGMHKKOKI
{
	[Cpp2IlInjected.Token(Token = "0x6000C81")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public CAOGMHKKOKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000248")]
public struct CFACDODIOOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000765")]
	public Entity HHHGBIJCKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000766")]
	public Entity EDMIEMPCIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000767")]
	public Entity CEBKCILOOLP;

	[Cpp2IlInjected.Token(Token = "0x6000C82")]
	[Cpp2IlInjected.Address(RVA = "0x42936E0", Offset = "0x42924E0", VA = "0x1842936E0")]
	public CFACDODIOOC(Entity HHHGBIJCKBC, Entity EDMIEMPCIAB, Entity CEBKCILOOLP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C83")]
	[Cpp2IlInjected.Address(RVA = "0x5E74F70", Offset = "0x5E73D70", VA = "0x185E74F70")]
	public static CFACDODIOOC KFCNDMGKJHB((Entity entity, Entity oldParent, Entity newParent) FFINMMNCMFN)
	{
		return default(CFACDODIOOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C84")]
	[Cpp2IlInjected.Address(RVA = "0x5E74F50", Offset = "0x5E73D50", VA = "0x185E74F50")]
	public void BLKEKIPLEEN([Out] Entity HHHGBIJCKBC, [Out] Entity EDMIEMPCIAB, [Out] Entity CEBKCILOOLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000249")]
public struct PPNLIJLNAOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000768")]
	public Entity HHHGBIJCKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000769")]
	public Entity LPDGANJNOMK;

	[Cpp2IlInjected.Token(Token = "0x6000C85")]
	[Cpp2IlInjected.Address(RVA = "0x2029A50", Offset = "0x2028850", VA = "0x182029A50")]
	public PPNLIJLNAOJ(Entity HHHGBIJCKBC, Entity LPDGANJNOMK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C86")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F4A0", Offset = "0x5E7E2A0", VA = "0x185E7F4A0")]
	public static PPNLIJLNAOJ KFCNDMGKJHB((Entity entity, Entity parent) FFINMMNCMFN)
	{
		return default(PPNLIJLNAOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C87")]
	[Cpp2IlInjected.Address(RVA = "0x5E7F490", Offset = "0x5E7E290", VA = "0x185E7F490")]
	public void BLKEKIPLEEN([Out] Entity HHHGBIJCKBC, [Out] Entity LPDGANJNOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024A")]
public struct OJGACDPHEGG<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400076A")]
	private GCHandle OFGGCMDABFP;

	[Cpp2IlInjected.Token(Token = "0x6000C88")]
	[Cpp2IlInjected.Address(RVA = "0x3CDA3F0", Offset = "0x3CD91F0", VA = "0x183CDA3F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024B")]
public enum CIGEKCLFFFN
{
	[Cpp2IlInjected.Token(Token = "0x400076C")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x400076D")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x400076E")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x200024C")]
public struct KHDCIJCBGLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400076F")]
	public CIGEKCLFFFN JALLFNOMJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000770")]
	public int PPABMNCHLOC;

	[Cpp2IlInjected.Token(Token = "0x6000C89")]
	[Cpp2IlInjected.Address(RVA = "0x97A610", Offset = "0x979410", VA = "0x18097A610")]
	public KHDCIJCBGLA(CIGEKCLFFFN JALLFNOMJIO, int PPABMNCHLOC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C8A")]
	[Cpp2IlInjected.Address(RVA = "0x5D634E0", Offset = "0x5D622E0", VA = "0x185D634E0")]
	public static KHDCIJCBGLA KFCNDMGKJHB((CIGEKCLFFFN eventType, int eventIndex) NPDPLEIHBMM)
	{
		return default(KHDCIJCBGLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8B")]
	[Cpp2IlInjected.Address(RVA = "0x5E7A710", Offset = "0x5E79510", VA = "0x185E7A710")]
	public void BLKEKIPLEEN([Out] CIGEKCLFFFN JALLFNOMJIO, [Out] int PPABMNCHLOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024D")]
[PMDCDBMECJP(typeof(CDMEBCJCIKK), new string[] { })]
public sealed class FCCAMGMHOHF : CDMEBCJCIKK, ENEHADLKBBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000771")]
	private AEPPNFHDEIC GNHKLJELDDH;

	[Cpp2IlInjected.Token(Token = "0x6000C8C")]
	[Cpp2IlInjected.Address(RVA = "0x5E751F0", Offset = "0x5E73FF0", VA = "0x185E751F0", Slot = "5")]
	public void InitReferences(NFHEEPPLDKB MBMNNOGNPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8D")]
	[Cpp2IlInjected.Address(RVA = "0x5E75150", Offset = "0x5E73F50", VA = "0x185E75150")]
	public bool IIAOEKBAMIF([In] float3 IEGMKHJBCLL, [In] float3 EFMDODKKOAD, float HGECKMNELOA, Allocator MBGJLDPPIJN, [Out] NativeArray<Entity> DDIFFODKOKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8E")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public FCCAMGMHOHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C8F")]
	[Cpp2IlInjected.Address(RVA = "0x5E75150", Offset = "0x5E73F50", VA = "0x185E75150", Slot = "4")]
	private bool BBGIHLEKENM([In] float3 IEGMKHJBCLL, [In] float3 EFMDODKKOAD, float HGECKMNELOA, Allocator MBGJLDPPIJN, [Out] NativeArray<Entity> DDIFFODKOKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200024E")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
public sealed class PFFFIAKIEJC : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000C90")]
	[Cpp2IlInjected.Address(RVA = "0x5E7EE50", Offset = "0x5E7DC50", VA = "0x185E7EE50", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C91")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public PFFFIAKIEJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024F")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal sealed class OJIHOKOGPGG : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000C92")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E3A0", Offset = "0x5E7D1A0", VA = "0x185E7E3A0", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C93")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public OJIHOKOGPGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000250")]
internal class OHAPMKFKODL : MOBNIBIKMKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000C94")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public OHAPMKFKODL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000251")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal sealed class MKEJEOPJLLN : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000C95")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E280", Offset = "0x5E7D080", VA = "0x185E7E280", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C96")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public MKEJEOPJLLN()
	{
	}
}
namespace RecRoom.ObjectModel.Systems.Tags
{
	[Cpp2IlInjected.Token(Token = "0x2000252")]
	[CompilerGenerated]
	public class PostInstantiatePushTagsToTaggedEntitiesSystem : DBMABBOGEPD, ENEHADLKBBF
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
			[Cpp2IlInjected.Address(RVA = "0x5E7F620", Offset = "0x5E7E420", VA = "0x185E7F620")]
			private void IOJGJCNCGIC(Entity entity, OACFAECLOFC tags)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C9E")]
			[Cpp2IlInjected.Address(RVA = "0x5E7F9A0", Offset = "0x5E7E7A0", VA = "0x185E7F9A0")]
			public void OKGBGOHBAKN(EntityQuery query)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000772")]
		private static readonly HICMFDICNOL log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		[PDOCKCLGMBB]
		private JNDGIDLEBEK spawnableToolDependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		[PDOCKCLGMBB]
		private CCAABBKKMFL objectService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		[PDOCKCLGMBB]
		private KAFALIKLKOG singletonComponentService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private EntityQuery PostInstantiatePushTagsToTaggedEntitiesSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private ComponentTypeHandle<OACFAECLOFC> __RecRoom_Components_PersistentUserTagData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000C97")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F590", Offset = "0x5E7E390", VA = "0x185E7F590", Slot = "14")]
		public void InitReferences(NFHEEPPLDKB services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C98")]
		[Cpp2IlInjected.Address(RVA = "0x5E7FE60", Offset = "0x5E7EC60", VA = "0x185E7FE60", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C99")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F4C0", Offset = "0x5E7E2C0", VA = "0x185E7F4C0")]
		private void DIGBLCAHJFK(Dictionary<int, FixedString32Bytes> serializedTagMap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7FC60", Offset = "0x5E7EA60", VA = "0x185E7FC60", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C9B")]
		[Cpp2IlInjected.Address(RVA = "0x3867160", Offset = "0x3865F60", VA = "0x183867160")]
		public PostInstantiatePushTagsToTaggedEntitiesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000254")]
internal class MLPDCCKOHLL : FIFEHJIAPGL
{
	[Cpp2IlInjected.Token(Token = "0x17000164")]
	protected override PKPEFMCEJFH CCAHIPEENBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000C9F")]
		[Cpp2IlInjected.Address(RVA = "0x7CF820", Offset = "0x7CE620", VA = "0x1807CF820", Slot = "17")]
		get
		{
			return default(PKPEFMCEJFH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA0")]
	[Cpp2IlInjected.Address(RVA = "0x5E7E350", Offset = "0x5E7D150", VA = "0x185E7E350")]
	public MLPDCCKOHLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000255")]
[MDNKGKCJEFA(LJHGMNIEOPD.LoadInstance)]
internal sealed class JDBAJBIBDFL : MJGNCFJNMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000CA1")]
	[Cpp2IlInjected.Address(RVA = "0x5E78DC0", Offset = "0x5E77BC0", VA = "0x185E78DC0", Slot = "15")]
	protected override ComponentSystemBase LEEJNJLKEEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA2")]
	[Cpp2IlInjected.Address(RVA = "0x5DBD970", Offset = "0x5DBC770", VA = "0x185DBD970")]
	public JDBAJBIBDFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000256")]
public class PKNKAMFMFLC : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000CA3")]
	[Cpp2IlInjected.Address(RVA = "0x76E100", Offset = "0x76CF00", VA = "0x18076E100")]
	public PKNKAMFMFLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000257")]
[HHEFILAIABA(typeof(APKJEEPOAEH))]
public sealed class MCDPJGJHHLJ : MKODIBOHOOB
{
	[Cpp2IlInjected.Token(Token = "0x6000CA4")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CFA0", Offset = "0x5E7BDA0", VA = "0x185E7CFA0", Slot = "8")]
	protected override bool NGJOIMFOKBM(ReadOnlySpan<APKJEEPOAEH> KJFBOMAGMGG, KGPPHNCOAFD DPJAFHOCHKL, [Out] ReadOnlySpan<byte> HGPPIPGOKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA5")]
	[Cpp2IlInjected.Address(RVA = "0x5E7CEA0", Offset = "0x5E7BCA0", VA = "0x185E7CEA0", Slot = "9")]
	protected override bool ENADNEDIEBN(int FBJEHMGCPKI, Span<APKJEEPOAEH> KJFBOMAGMGG, [In] ReadOnlySpan<byte> HGPPIPGOKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA6")]
	[Cpp2IlInjected.Address(RVA = "0x5E7D0A0", Offset = "0x5E7BEA0", VA = "0x185E7D0A0")]
	public MCDPJGJHHLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000258")]
[HHEFILAIABA(typeof(LMOBHKOOHGM))]
public sealed class BKNKAONFCMM : GOAJFGGEPEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000CA7")]
	[Cpp2IlInjected.Address(RVA = "0x5E74090", Offset = "0x5E72E90", VA = "0x185E74090", Slot = "8")]
	protected override bool NGJOIMFOKBM(ReadOnlySpan<LMOBHKOOHGM> KJFBOMAGMGG, KGPPHNCOAFD DPJAFHOCHKL, [Out] ReadOnlySpan<byte> HGPPIPGOKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA8")]
	[Cpp2IlInjected.Address(RVA = "0x5E73F90", Offset = "0x5E72D90", VA = "0x185E73F90", Slot = "9")]
	protected override bool ENADNEDIEBN(int FBJEHMGCPKI, Span<LMOBHKOOHGM> KJFBOMAGMGG, [In] ReadOnlySpan<byte> HGPPIPGOKCB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000CA9")]
	[Cpp2IlInjected.Address(RVA = "0x5E74190", Offset = "0x5E72F90", VA = "0x185E74190")]
	public BKNKAONFCMM()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000259")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : MCMFKIKAHEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000CAA")]
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAB")]
		[Cpp2IlInjected.Address(RVA = "0x5E80320", Offset = "0x5E7F120", VA = "0x185E80320", Slot = "6")]
		public sealed override void DEIBGDDLADL(MMLHPMLOJHM PMOMGAGBHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CAC")]
		[Cpp2IlInjected.Address(RVA = "0x5E814E0", Offset = "0x5E802E0", VA = "0x185E814E0", Slot = "4")]
		public sealed override void MJDOOMDPGLF()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200025A")]
internal class __UnmanagedPostProcessorOutput__2808207715
{
	[Cpp2IlInjected.Token(Token = "0x6000CAD")]
	[Cpp2IlInjected.Address(RVA = "0x5E82770", Offset = "0x5E81570", VA = "0x185E82770")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200025B")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2808207715
{
	[Cpp2IlInjected.Token(Token = "0x6000CAE")]
	[Cpp2IlInjected.Address(RVA = "0x5E816B0", Offset = "0x5E804B0", VA = "0x185E816B0")]
	public static void HPOCIKEIKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000CAF")]
	[Cpp2IlInjected.Address(RVA = "0x5E816A0", Offset = "0x5E804A0", VA = "0x185E816A0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200025C")]
internal class ALNJGIODHNO : ContainerPropertyBag<HCNMEMGOJBN>
{
	[Cpp2IlInjected.Token(Token = "0x200025D")]
	private class IIENODCBEFD : Property<HCNMEMGOJBN, KJKIANDJMFH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000165")]
		public override string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB1")]
			[Cpp2IlInjected.Address(RVA = "0x5E78C80", Offset = "0x5E77A80", VA = "0x185E78C80", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		public override bool LOLLACKIPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000CB2")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB3")]
		[Cpp2IlInjected.Address(RVA = "0x5E78C40", Offset = "0x5E77A40", VA = "0x185E78C40")]
		public IIENODCBEFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB4")]
		[Cpp2IlInjected.Address(RVA = "0x5D30D90", Offset = "0x5D2FB90", VA = "0x185D30D90", Slot = "14")]
		public override KJKIANDJMFH GetValue(HCNMEMGOJBN LAJBGPNDGLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000CB5")]
		[Cpp2IlInjected.Address(RVA = "0x5D30DB0", Offset = "0x5D2FBB0", VA = "0x185D30DB0", Slot = "15")]
		public override void SetValue(HCNMEMGOJBN LAJBGPNDGLJ, KJKIANDJMFH POACLGOFKAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000CB0")]
	[Cpp2IlInjected.Address(RVA = "0x5E71F80", Offset = "0x5E70D80", VA = "0x185E71F80")]
	public ALNJGIODHNO()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x200025E")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000CB6")]
		[Cpp2IlInjected.Address(RVA = "0x5E80180", Offset = "0x5E7EF80", VA = "0x185E80180")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E802A0", Offset = "0x5E7F0A0", VA = "0x185E802A0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000260")]
public class LCOCJIOOHJG
{
	[Cpp2IlInjected.Token(Token = "0x6000CB8")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LCOCJIOOHJG()
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
