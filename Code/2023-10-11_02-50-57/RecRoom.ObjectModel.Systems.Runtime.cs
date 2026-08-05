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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
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
		[Cpp2IlInjected.Address(RVA = "0x223CCF0", Offset = "0x223BAF0", VA = "0x18223CCF0")]
		public static KDBBIBLIBHM<T> CreateTemporarySingleton<T>(this EntityManager entityManager, T componentData) where T : struct, IComponentData
		{
			return default(KDBBIBLIBHM<T>);
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal struct PDHPGBGMPDA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LBAGHLOGJIN]
public static class LNHDGFBLCPM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E33730", Offset = "0x5E32530", VA = "0x185E33730")]
	static LNHDGFBLCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x243AB90", Offset = "0x2439990", VA = "0x18243AB90")]
	public static void IGEJICFKKFB<T>(T PKELBKGJAFM, T GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E33500", Offset = "0x5E32300", VA = "0x185E33500")]
	public static void IGEJICFKKFB(FixedString32Bytes PKELBKGJAFM, string GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E33620", Offset = "0x5E32420", VA = "0x185E33620")]
	public static void IGEJICFKKFB(string PKELBKGJAFM, FixedString32Bytes GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E33530", Offset = "0x5E32330", VA = "0x185E33530")]
	public static void IGEJICFKKFB(FixedString64Bytes PKELBKGJAFM, string GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E33590", Offset = "0x5E32390", VA = "0x185E33590")]
	public static void IGEJICFKKFB(string PKELBKGJAFM, FixedString64Bytes GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E334D0", Offset = "0x5E322D0", VA = "0x185E334D0")]
	public static void IGEJICFKKFB(AFOGBMKAOAA PKELBKGJAFM, Vector3 GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A740", Offset = "0x5D69540", VA = "0x185D6A740")]
	public static void IGEJICFKKFB(Vector3 PKELBKGJAFM, AFOGBMKAOAA GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E33700", Offset = "0x5E32500", VA = "0x185E33700")]
	public static void IGEJICFKKFB(AOAALLKLCNM PKELBKGJAFM, Vector4 GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D695D0", Offset = "0x5D683D0", VA = "0x185D695D0")]
	public static void IGEJICFKKFB(Vector4 PKELBKGJAFM, AOAALLKLCNM GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E33700", Offset = "0x5E32500", VA = "0x185E33700")]
	public static void IGEJICFKKFB(AOAALLKLCNM PKELBKGJAFM, Quaternion GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D695D0", Offset = "0x5D683D0", VA = "0x185D695D0")]
	public static void IGEJICFKKFB(Quaternion PKELBKGJAFM, AOAALLKLCNM GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5E33560", Offset = "0x5E32360", VA = "0x185E33560")]
	public static void IGEJICFKKFB(AFOGBMKAOAA PKELBKGJAFM, float3 GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A740", Offset = "0x5D69540", VA = "0x185D6A740")]
	public static void IGEJICFKKFB(float3 PKELBKGJAFM, AFOGBMKAOAA GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E334B0", Offset = "0x5E322B0", VA = "0x185E334B0")]
	public static void IGEJICFKKFB(AOAALLKLCNM PKELBKGJAFM, float4 GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D695D0", Offset = "0x5D683D0", VA = "0x185D695D0")]
	public static void IGEJICFKKFB(float4 PKELBKGJAFM, AOAALLKLCNM GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E334B0", Offset = "0x5E322B0", VA = "0x185E334B0")]
	public static void IGEJICFKKFB(AOAALLKLCNM PKELBKGJAFM, quaternion GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E33660", Offset = "0x5E32460", VA = "0x185E33660")]
	public static void IGEJICFKKFB(quaternion PKELBKGJAFM, AOAALLKLCNM GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E336C0", Offset = "0x5E324C0", VA = "0x185E336C0")]
	public static void IGEJICFKKFB(Entity PKELBKGJAFM, CBLABENCEAB GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E335F0", Offset = "0x5E323F0", VA = "0x185E335F0")]
	public static void IGEJICFKKFB(CBLABENCEAB PKELBKGJAFM, Entity GCGBNKINDOP, DLOCLBOCELG DLAHENGMLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal class LMHNNHEDKFJ : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E33040", Offset = "0x5E31E40", VA = "0x185E33040", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E330F0", Offset = "0x5E31EF0", VA = "0x185E330F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public LMHNNHEDKFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NJOEKALHIJD(DAEAEJBLHHK.OMRoom)]
internal class OIGGKHOPLLO : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FALPINKOHJI IINCLMIKMJK;

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E39350", Offset = "0x5E38150", VA = "0x185E39350", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E393A0", Offset = "0x5E381A0", VA = "0x185E393A0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public OIGGKHOPLLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[UnityEngine.Scripting.Preserve]
internal class KLJFBMJKHLA : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private EntityQuery EIIFCBFPMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E32750", Offset = "0x5E31550", VA = "0x185E32750", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E327A0", Offset = "0x5E315A0", VA = "0x185E327A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E32830", Offset = "0x5E31630", VA = "0x185E32830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public KLJFBMJKHLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NJOEKALHIJD(DAEAEJBLHHK.OMRoom)]
internal class HIMGEAEIKDA : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private FALPINKOHJI IINCLMIKMJK;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A5E0", Offset = "0x5E293E0", VA = "0x185E2A5E0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A630", Offset = "0x5E29430", VA = "0x185E2A630", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public HIMGEAEIKDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NJOEKALHIJD(DAEAEJBLHHK.OMRoom)]
internal class EIKDKNFCCDA : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private OPNGBJLAHIJ JOEFEJIMKDF;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F970", Offset = "0x5E1E770", VA = "0x185E1F970", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F9C0", Offset = "0x5E1E7C0", VA = "0x185E1F9C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public EIKDKNFCCDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[UnityEngine.Scripting.Preserve]
internal sealed class NBFPDMJDJDB<T> : FMBIPPPJNCE where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB780", Offset = "0x3BBA580", VA = "0x183BBB780", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB8F0", Offset = "0x3BBA6F0", VA = "0x183BBB8F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public NBFPDMJDJDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[KOAHIMOCLPK]
public class FCFILNENGBG : ComponentSystem, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private LHNHCAPHDGO CBMBNJJFGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x76B130", Offset = "0x769F30", VA = "0x18076B130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x768570", Offset = "0x767370", VA = "0x180768570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E22520", Offset = "0x5E21320", VA = "0x185E22520", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
	public FCFILNENGBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class AIGBABGDLMJ : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B8E0", Offset = "0x5E1A6E0", VA = "0x185E1B8E0", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BAE0", Offset = "0x5E1A8E0", VA = "0x185E1BAE0")]
	[UnityEngine.Scripting.Preserve]
	private void ONDOMJJACBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public AIGBABGDLMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class PCOIFAMJJND : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E1B0", Offset = "0x5E3CFB0", VA = "0x185E3E1B0", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public PCOIFAMJJND()
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E3E100", Offset = "0x5E3CF00", VA = "0x185E3E100")]
		public static ObjectModelConfigAsset JOCPPOMJIKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84D6F0", Offset = "0x84C4F0", VA = "0x18084D6F0")]
		public ObjectModelConfigAsset()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CELJGMKNOEE
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DC50", Offset = "0x5E1CA50", VA = "0x185E1DC50")]
	public static void MAEPEJPBADI(GKFGDEJLFAD CGHEBMJOFGL, string KLFLJACKKNL, JBMJEBCFLLB CMCJHNENJPD, Action ALNJMFCGDFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DE80", Offset = "0x5E1CC80", VA = "0x185E1DE80")]
	public static void MAEPEJPBADI(GKFGDEJLFAD CGHEBMJOFGL, string KLFLJACKKNL, EOLLFEKBMDA PCNBCKNKBBB, Action ALNJMFCGDFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GMDFEECJCLF
{
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ELJHGFGHFPM
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class NBACIABDAMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private static readonly GKFGDEJLFAD CGHEBMJOFGL;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5E38850", Offset = "0x5E37650", VA = "0x185E38850")]
		public static DJMPNJEFEHC BCGFAGFOADA(int NILBMELKFHL, JLHKELLMEON ALJMPBCMDJC)
		{
			return default(DJMPNJEFEHC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5E39000", Offset = "0x5E37E00", VA = "0x185E39000")]
		private static JBMJEBCFLLB GKFPHBLAJPJ(JLHKELLMEON EKGDBFLAANH, JBMJEBCFLLB ABMOMGNDILN)
		{
			return default(JBMJEBCFLLB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E38BB0", Offset = "0x5E379B0", VA = "0x185E38BB0")]
		private static void DEOHBBODEFL(JBMJEBCFLLB DKOKBJGFBEC, JBMJEBCFLLB NECAHONKHGH, DJMPNJEFEHC IELEJBMANDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E38D30", Offset = "0x5E37B30", VA = "0x185E38D30")]
		public static int ELBJAJHHDLO(GameObject DEGGPBGPMDB, JMHOHCKHKHG HLOBJBMOOKC)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static NBKCLNBDKKE PMKEEJELEMK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static MGCBGGNJMBI CLGGHKJADNB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static MGCBGGNJMBI GHANKDLFFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5E20EE0", Offset = "0x5E1FCE0", VA = "0x185E20EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool FPALMIOADCC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E20D00", Offset = "0x5E1FB00", VA = "0x185E20D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static LHNHCAPHDGO CBMBNJJFGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5E20B10", Offset = "0x5E1F910", VA = "0x185E20B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5E1FF50", Offset = "0x5E1ED50", VA = "0x185E1FF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static PHJHPLJJLBK BCJGEGDAKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E202C0", Offset = "0x5E1F0C0", VA = "0x185E202C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public static IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E203A0", Offset = "0x5E1F1A0", VA = "0x185E203A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static FOLLILJKCFG CBJKAFKIJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5E20330", Offset = "0x5E1F130", VA = "0x185E20330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static BCDPLEGKDHC COHPGONCHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E20E70", Offset = "0x5E1FC70", VA = "0x185E20E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool KMIOKONLJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E20B90", Offset = "0x5E1F990", VA = "0x185E20B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static bool LLDLENHBKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E20180", Offset = "0x5E1EF80", VA = "0x185E20180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static ECLMNCPCDJH MMJEJEDAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E20880", Offset = "0x5E1F680", VA = "0x185E20880")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static bool NKCCOGHKBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E20920", Offset = "0x5E1F720", VA = "0x185E20920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static byte MJKJKFNBDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E20C00", Offset = "0x5E1FA00", VA = "0x185E20C00")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static byte PIFKNDGCEDK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0")]
		get
		{
			return default(byte);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool FINOCGJKHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5E206A0", Offset = "0x5E1F4A0", VA = "0x185E206A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool IBOOGJGFHBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5E20830", Offset = "0x5E1F630", VA = "0x185E20830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FE00", Offset = "0x5E1EC00", VA = "0x185E1FE00")]
	public static void CFKKKOCNPEP(NBKCLNBDKKE GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E20560", Offset = "0x5E1F360", VA = "0x185E20560")]
	public static JBMJEBCFLLB IAMCBICJENG(GameObject DEGGPBGPMDB)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1FFC0", Offset = "0x5E1EDC0", VA = "0x185E1FFC0")]
	public static ECLMNCPCDJH DJDEJILIIIN(DJMPNJEFEHC IELEJBMANDO)
	{
		return default(ECLMNCPCDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E20410", Offset = "0x5E1F210", VA = "0x185E20410")]
	public static bool HENAOLJLHFC(GameObject DEGGPBGPMDB, [Out] DJMPNJEFEHC IELEJBMANDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E206F0", Offset = "0x5E1F4F0", VA = "0x185E206F0")]
	public static GJLEGMBHFIE KHMPCLGKMPM(IEnumerable<ELKMOGAHBJM> JLIAKEMOOFF)
	{
		return default(GJLEGMBHFIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E201D0", Offset = "0x5E1EFD0", VA = "0x185E201D0")]
	private static MGCBGGNJMBI EJFPKIMKJEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E20040", Offset = "0x5E1EE40", VA = "0x185E20040")]
	private static bool DKJKLOOEJLL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class PGCHBDNMOFN
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F540", Offset = "0x5E3E340", VA = "0x185E3F540")]
	public static bool JAOJFDJLGCA(KMILLOLJKJL BBMFFOOCONB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F800", Offset = "0x5E3E600", VA = "0x185E3F800")]
	public static KMILLOLJKJL MCJJKKHGDCC(GameObject DEGGPBGPMDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F650", Offset = "0x5E3E450", VA = "0x185E3F650")]
	public static KMILLOLJKJL MCJJKKHGDCC(GameObject DEGGPBGPMDB, DJMPNJEFEHC IELEJBMANDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3FA40", Offset = "0x5E3E840", VA = "0x185E3FA40")]
	public static bool ODJOLKNEMLP(GameObject FJNLKHDMLBO, string KNKKDNJPFFO, bool OANEKJHCFIL)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class DisembodiedObjectView : MonoBehaviour, NMECIDJANKG
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool KADIPLBDHPF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public JBMJEBCFLLB OBEGLAOMPKC
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(JBMJEBCFLLB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xD1A9F0", Offset = "0xD197F0", VA = "0x180D1A9F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EAD0", Offset = "0x5E1D8D0", VA = "0x185E1EAD0")]
		public void SetName(string ONIBECKLJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[DisallowMultipleComponent]
	public sealed class EmbodiedObject : MonoBehaviour, KMILLOLJKJL, NMECIDJANKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static readonly GKFGDEJLFAD CGHEBMJOFGL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private const string FGHONBHKJKH = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CCPMDEBLILB EPLFCMFNFIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private JBMJEBCFLLB HAIBOLAMIBL;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public JBMJEBCFLLB OBEGLAOMPKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5E22300", Offset = "0x5E21100", VA = "0x185E22300", Slot = "15")]
			get
			{
				return default(JBMJEBCFLLB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ECLMNCPCDJH AFJJMLHIBKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5E223B0", Offset = "0x5E211B0", VA = "0x185E223B0", Slot = "6")]
			get
			{
				return default(ECLMNCPCDJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool KADIPLBDHPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5E222F0", Offset = "0x5E210F0", VA = "0x185E222F0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CCPMDEBLILB IIKNEOJFJGK
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x870380", Offset = "0x86F180", VA = "0x180870380", Slot = "7")]
			get
			{
				return default(CCPMDEBLILB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private NMOMJJDHINP FJFGPNMBHDB
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x5E21BA0", Offset = "0x5E209A0", VA = "0x185E21BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool FHPHKMHFNDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FBB80", VA = "0x1807FCD80", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x869AB0", Offset = "0x8688B0", VA = "0x180869AB0", Slot = "16")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<bool> JMMJNFJKDPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5E22190", Offset = "0x5E20F90", VA = "0x185E22190")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5E223C0", Offset = "0x5E211C0", VA = "0x185E223C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<KMILLOLJKJL> CKIMNNAAMBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5E22240", Offset = "0x5E21040", VA = "0x185E22240", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5E22470", Offset = "0x5E21270", VA = "0x185E22470", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E218E0", Offset = "0x5E206E0", VA = "0x185E218E0")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E21FD0", Offset = "0x5E20DD0", VA = "0x185E21FD0", Slot = "17")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E21C50", Offset = "0x5E20A50", VA = "0x185E21C50", Slot = "18")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E21F90", Offset = "0x5E20D90", VA = "0x185E21F90", Slot = "10")]
		public void OnEmbody(HBMBNCJMDAI GICLKIIJBDC, JBMJEBCFLLB HAIBOLAMIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E21FC0", Offset = "0x5E20DC0", VA = "0x185E21FC0", Slot = "11")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E21E90", Offset = "0x5E20C90", VA = "0x185E21E90", Slot = "12")]
		public void OnDisembody(bool KKAOOHAOFJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E21AC0", Offset = "0x5E208C0", VA = "0x185E21AC0")]
		private void CDHGMOABLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E21C10", Offset = "0x5E20A10", VA = "0x185E21C10", Slot = "13")]
		public void NotifyInitialized()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA22D20", Offset = "0xA21B20", VA = "0x180A22D20", Slot = "9")]
		private GameObject AFMCPGILCLO()
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
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleComponent]
	public class RbexEntity : TransformEntity
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public override FMJMJJHCMAN FANNPDHPNIN
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5E3FCE0", Offset = "0x5E3EAE0", VA = "0x185E3FCE0", Slot = "6")]
			get
			{
				return default(FMJMJJHCMAN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FC90", Offset = "0x5E3EA90", VA = "0x185E3FC90")]
		public RbexEntity()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DisallowMultipleComponent]
	public class TransformEntity : MonoBehaviour, NMECIDJANKG
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly GKFGDEJLFAD CGHEBMJOFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private FMJMJJHCMAN prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JBMJEBCFLLB OGPPAJOCABK;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public virtual FMJMJJHCMAN FANNPDHPNIN
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7646E0", VA = "0x1807658E0", Slot = "6")]
			get
			{
				return default(FMJMJJHCMAN);
			}
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7658D0", Offset = "0x7646D0", VA = "0x1807658D0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public JBMJEBCFLLB OBEGLAOMPKC
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x310D6B0", Offset = "0x310C4B0", VA = "0x18310D6B0", Slot = "5")]
			get
			{
				return default(JBMJEBCFLLB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool KADIPLBDHPF
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x10092D0", Offset = "0x10080D0", VA = "0x1810092D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x10092E0", Offset = "0x10080E0", VA = "0x1810092E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		internal Entity BBEFCNMIGNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x5E3FF50", Offset = "0x5E3ED50", VA = "0x185E3FF50")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		internal IKBNJJBMJGF OJBGOKBDOJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5E3FE50", Offset = "0x5E3EC50", VA = "0x185E3FE50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal JNPLIBJDOGK GNCACLGHEHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5E3FCF0", Offset = "0x5E3EAF0", VA = "0x185E3FCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FD70", Offset = "0x5E3EB70", VA = "0x185E3FD70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FE60", Offset = "0x5E3EC60", VA = "0x185E3FE60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FF70", Offset = "0x5E3ED70", VA = "0x185E3FF70")]
		internal void OOCIGOIJKNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FDB0", Offset = "0x5E3EBB0", VA = "0x185E3FDB0")]
		private bool BHBAJOIAIMC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FD80", Offset = "0x5E3EB80", VA = "0x185E3FD80")]
		private void BGLOJPPKJPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E3FE60", Offset = "0x5E3EC60", VA = "0x185E3FE60")]
		internal void GFINLAFBDPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E40280", Offset = "0x5E3F080", VA = "0x185E40280")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E40390", Offset = "0x5E3F190", VA = "0x185E40390")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[LKMFAIPHKDB(typeof(MGCBGGNJMBI), new string[] { })]
[GPOCAEGADIM(typeof(KMLKLGKDBAC))]
[GPOCAEGADIM(typeof(GDDGGLIBMDG))]
public class KHJFJHMCDCB : MGCBGGNJMBI, APDPPALGJBL, KMLKLGKDBAC, IDisposable, GDDGGLIBMDG
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly ProfilerMarker EJKMHNNHFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NBKCLNBDKKE PDGDCGJNEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NMOMJJDHINP DECADLJJLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JHHOBBMGMJL NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private JADOFDKKJHN DBBPJIDNNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public NBKCLNBDKKE CBMBNJJFGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public JHHOBBMGMJL IHLJFAGFAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public JADOFDKKJHN GNGFFADINGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7B04D0", Offset = "0x7AF2D0", VA = "0x1807B04D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public KHMPNKBJMCM GDNMHGNJJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x80C530", Offset = "0x80B330", VA = "0x18080C530", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(KHMPNKBJMCM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x80C520", Offset = "0x80B320", VA = "0x18080C520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool NBMNKGOJOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xDBEB20", Offset = "0xDBD920", VA = "0x180DBEB20", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1C212B0", Offset = "0x1C200B0", VA = "0x181C212B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public CKLCFHIBNGJ EHJADIEJDGC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB00", Offset = "0x7DD900", VA = "0x1807DEB00", Slot = "10")]
		get
		{
			return default(CKLCFHIBNGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5E32180", Offset = "0x5E30F80", VA = "0x185E32180", Slot = "14")]
	private void FLKBODDLNMK(bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5E323E0", Offset = "0x5E311E0", VA = "0x185E323E0")]
	public static KHJFJHMCDCB HKJMJGOBNGA(NBKCLNBDKKE PDGDCGJNEFO, KPPDDAAOJPP LCCBIJEOFHP = KPPDDAAOJPP.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void AILAKFPPBME(NBKCLNBDKKE PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void COMGHFMEFIG(NBKCLNBDKKE PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E31F70", Offset = "0x5E30D70", VA = "0x185E31F70", Slot = "11")]
	public void CAPMIKFGFII(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0xBEC700", Offset = "0xBEB500", VA = "0x180BEC700")]
	private void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E32590", Offset = "0x5E31390", VA = "0x185E32590")]
	private void MFCNEDOLDHK(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5E320F0", Offset = "0x5E30EF0", VA = "0x185E320F0", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public KHJFJHMCDCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JMLKALBJNMA
{
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[Flags]
public enum KPPDDAAOJPP
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
[LKMFAIPHKDB(typeof(JADOFDKKJHN), new string[] { })]
public class LMDAMHDOCON : JADOFDKKJHN, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static readonly GKFGDEJLFAD FCGNKOAMJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private NBKCLNBDKKE PDGDCGJNEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private GDDGGLIBMDG CNHBAMPOOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private JHHOBBMGMJL NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private MGCBGGNJMBI CLGGHKJADNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private DEHDJDPODCF IGBHKFPEPCA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool APBCJOLHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E32F20", Offset = "0x5E31D20", VA = "0x185E32F20", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PPIJPAJCPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E32BD0", Offset = "0x5E319D0", VA = "0x185E32BD0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E32D40", Offset = "0x5E31B40", VA = "0x185E32D40", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E32C70", Offset = "0x5E31A70", VA = "0x185E32C70", Slot = "12")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E329E0", Offset = "0x5E317E0", VA = "0x185E329E0", Slot = "6")]
	public void ICBCKMIIPHK(bool LEDLLMJPAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E32980", Offset = "0x5E31780", VA = "0x185E32980", Slot = "7")]
	public bool BHJIAGHHOJI(ByteString GHHJLCMBOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E329D0", Offset = "0x5E317D0", VA = "0x185E329D0", Slot = "11")]
	public void IBBGFGDFFFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1643930", Offset = "0x1642730", VA = "0x181643930", Slot = "9")]
	public void GLIMDIIGBDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E32DE0", Offset = "0x5E31BE0", VA = "0x185E32DE0", Slot = "10")]
	public void LPFNIAPEIOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LMDAMHDOCON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DefaultMember("Item")]
public class AOFHJFIHPGJ<T> : LPOILOOPBIK<T>, BMNAKPOHAKD<DJMPNJEFEHC, T>, IPPDBGPKNLI<DJMPNJEFEHC>, GKFLMNEBMJA, IDisposable, LPNKEHLCEHF where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly IPPDBGPKNLI<Entity> GGCGADADFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private Delegate LLIGPEMOCNG;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3532E90", Offset = "0x3531C90", VA = "0x183532E90", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Type DNFOEPJPNMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x35284C0", Offset = "0x35272C0", VA = "0x1835284C0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public KCIEHIFDMEB HJOIEMOJAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3527A00", Offset = "0x3526800", VA = "0x183527A00", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int FANNEMIFECB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x352DF50", Offset = "0x352CD50", VA = "0x18352DF50", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public CPBDDLOPNGI AHPEFDGNPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x352DB90", Offset = "0x352C990", VA = "0x18352DB90", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event HEKJNCAEDNB<DJMPNJEFEHC> PMJHIHPLKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x352F250", Offset = "0x352E050", VA = "0x18352F250", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x352E570", Offset = "0x352D370", VA = "0x18352E570", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3536030", Offset = "0x3534E30", VA = "0x183536030")]
	public AOFHJFIHPGJ(IPPDBGPKNLI<Entity> GGCGADADFCH, IKBNJJBMJGF CFIPHHIMOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3527D20", Offset = "0x3526B20", VA = "0x183527D20")]
	private Entity ELGLCHHLLKA(DJMPNJEFEHC IELEJBMANDO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3527A70", Offset = "0x3526870", VA = "0x183527A70")]
	private DJMPNJEFEHC ELGLCHHLLKA(Entity CCHOHIEEHEH)
	{
		return default(DJMPNJEFEHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3535510", Offset = "0x3534310", VA = "0x183535510", Slot = "4")]
	public T OMJIHOMPBMI(DJMPNJEFEHC IELEJBMANDO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x352FC80", Offset = "0x352EA80", VA = "0x18352FC80")]
	public bool KLJMIKDFPBF(DJMPNJEFEHC IELEJBMANDO, [In] T LEDLLMJPAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3528700", Offset = "0x3527500", VA = "0x183528700", Slot = "7")]
	public bool HCAMIAJDHEM(DJMPNJEFEHC IELEJBMANDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3533AE0", Offset = "0x35328E0", VA = "0x183533AE0", Slot = "8")]
	public void OMJIHOMPBMI(DJMPNJEFEHC IELEJBMANDO, GANBGEIPGLD GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x3530510", Offset = "0x352F310", VA = "0x183530510", Slot = "9")]
	public bool KLJMIKDFPBF(DJMPNJEFEHC IELEJBMANDO, ONLJEFNJJKA LEDLLMJPAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x3533070", Offset = "0x3531E70", VA = "0x183533070", Slot = "16")]
	public void NAJLLNGFBCK(NIGHLJACFIF PDNAOBFPDKH, [Optional] object GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x352EF50", Offset = "0x352DD50", VA = "0x18352EF50", Slot = "10")]
	public bool KBCPIACFDGK(DJMPNJEFEHC GCGBNKINDOP, DJMPNJEFEHC PKELBKGJAFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x3527A50", Offset = "0x3526850", VA = "0x183527A50", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x3535D70", Offset = "0x3534B70", VA = "0x183535D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x3528CA0", Offset = "0x3527AA0", VA = "0x183528CA0")]
	private void HJMJPIKDNEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x35320B0", Offset = "0x3530EB0", VA = "0x1835320B0")]
	private void LINLKLMLOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x352CBE0", Offset = "0x352B9E0", VA = "0x18352CBE0")]
	private void IGNMDMIMEGB(Entity CCHOHIEEHEH, [In] ONLJEFNJJKA FKDIDOCGBFM, [In] ONLJEFNJJKA LEDLLMJPAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x352F880", Offset = "0x352E680", VA = "0x18352F880")]
	private void KJNNLKFPAMF(Entity CCHOHIEEHEH, [In] ONLJEFNJJKA FKDIDOCGBFM, [In] ONLJEFNJJKA LEDLLMJPAFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class MLBEOODPNHF<T> : HLOLALCBGEB<T>, BMNAKPOHAKD<JBMJEBCFLLB, T>, IPPDBGPKNLI<JBMJEBCFLLB>, GKFLMNEBMJA, IDisposable, OEEJKPJCCOP where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly IPPDBGPKNLI<Entity> GGCGADADFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private Delegate LLIGPEMOCNG;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3B56BD0", Offset = "0x3B559D0", VA = "0x183B56BD0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Type DNFOEPJPNMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3B4CF60", Offset = "0x3B4BD60", VA = "0x183B4CF60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public KCIEHIFDMEB HJOIEMOJAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3B4CB50", Offset = "0x3B4B950", VA = "0x183B4CB50", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int FANNEMIFECB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3B521D0", Offset = "0x3B50FD0", VA = "0x183B521D0", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public CPBDDLOPNGI AHPEFDGNPJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x3B51FF0", Offset = "0x3B50DF0", VA = "0x183B51FF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event HEKJNCAEDNB<JBMJEBCFLLB> PMJHIHPLKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3B536B0", Offset = "0x3B524B0", VA = "0x183B536B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3B52500", Offset = "0x3B51300", VA = "0x183B52500", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3536030", Offset = "0x3534E30", VA = "0x183536030")]
	public MLBEOODPNHF(IPPDBGPKNLI<Entity> GGCGADADFCH, IKBNJJBMJGF CFIPHHIMOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3B4CD80", Offset = "0x3B4BB80", VA = "0x183B4CD80")]
	private Entity ELGLCHHLLKA(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3B4CDB0", Offset = "0x3B4BBB0", VA = "0x183B4CDB0")]
	private JBMJEBCFLLB ELGLCHHLLKA(Entity CCHOHIEEHEH)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3B58BD0", Offset = "0x3B579D0", VA = "0x183B58BD0", Slot = "4")]
	public T OMJIHOMPBMI(JBMJEBCFLLB OGPPAJOCABK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3B53D70", Offset = "0x3B52B70", VA = "0x183B53D70")]
	public bool KLJMIKDFPBF(JBMJEBCFLLB OGPPAJOCABK, [In] T LEDLLMJPAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3B4D700", Offset = "0x3B4C500", VA = "0x183B4D700", Slot = "7")]
	public bool HCAMIAJDHEM(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3533AE0", Offset = "0x35328E0", VA = "0x183533AE0", Slot = "8")]
	public void OMJIHOMPBMI(JBMJEBCFLLB OGPPAJOCABK, GANBGEIPGLD GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B53F50", Offset = "0x3B52D50", VA = "0x183B53F50", Slot = "9")]
	public bool KLJMIKDFPBF(JBMJEBCFLLB OGPPAJOCABK, ONLJEFNJJKA LEDLLMJPAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3533070", Offset = "0x3531E70", VA = "0x183533070", Slot = "16")]
	public void NAJLLNGFBCK(NIGHLJACFIF PDNAOBFPDKH, [Optional] object GMNCNEPJHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3B52DC0", Offset = "0x3B51BC0", VA = "0x183B52DC0", Slot = "10")]
	public bool KBCPIACFDGK(JBMJEBCFLLB GCGBNKINDOP, JBMJEBCFLLB PKELBKGJAFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3B4E6E0", Offset = "0x3B4D4E0", VA = "0x183B4E6E0")]
	private void HJMJPIKDNEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3B563D0", Offset = "0x3B551D0", VA = "0x183B563D0")]
	private void LINLKLMLOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3B51110", Offset = "0x3B4FF10", VA = "0x183B51110")]
	private void IGNMDMIMEGB(Entity CCHOHIEEHEH, [In] ONLJEFNJJKA FKDIDOCGBFM, [In] ONLJEFNJJKA LEDLLMJPAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3B53B80", Offset = "0x3B52980", VA = "0x183B53B80")]
	private void KJNNLKFPAMF(Entity CCHOHIEEHEH, [In] ONLJEFNJJKA FKDIDOCGBFM, [In] ONLJEFNJJKA LEDLLMJPAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2FFF110", Offset = "0x2FFDF10", VA = "0x182FFF110", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3B59460", Offset = "0x3B58260", VA = "0x183B59460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class AEKADBKHFGJ : NLKOBNHNFLA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class GHANNLALFLM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int LFJJMGJIKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D0160", Offset = "0x7CEF60", VA = "0x1807D0160", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> EFEHHOALPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA8D850", Offset = "0xA8C650", VA = "0x180A8D850", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B790", Offset = "0x5E1A590", VA = "0x185E1B790", Slot = "6")]
	public JBMJEBCFLLB IDPAAEDNDJP(JBMJEBCFLLB DJIDJBJMOLC)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public AEKADBKHFGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class FEGFAPGNKNI : NLKOBNHNFLA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> OFCFMOPBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private int OCHEPOAJMIH;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> EFEHHOALPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA8D850", Offset = "0xA8C650", VA = "0x180A8D850", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int LFJJMGJIKAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x80C540", Offset = "0x80B340", VA = "0x18080C540", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3062CD0", Offset = "0x3061AD0", VA = "0x183062CD0")]
	public FEGFAPGNKNI(NativeArray<EntityRemapUtility.EntityRemapInfo> OFCFMOPBADJ, int OCHEPOAJMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E22EA0", Offset = "0x5E21CA0", VA = "0x185E22EA0", Slot = "6")]
	public JBMJEBCFLLB IDPAAEDNDJP(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E22E60", Offset = "0x5E21C60", VA = "0x185E22E60", Slot = "8")]
	public LocalId IDPAAEDNDJP(LocalId CCHOHIEEHEH)
	{
		return default(LocalId);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E22E00", Offset = "0x5E21C00", VA = "0x185E22E00", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
[LKMFAIPHKDB(typeof(EFPLPIELNNG), new string[] { "Editor" })]
public sealed class EFPLPIELNNG
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public delegate void JCAFAIOIAHJ(DJMPNJEFEHC GKJIOGGMBPG, NOGPJKFKBEI PFDMLBFKIAP, bool IFBFMGFPHKJ);

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate void EOBJAMJDNOM(DJMPNJEFEHC GKJIOGGMBPG, bool IFBFMGFPHKJ);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate void EHLJHGKGIJJ(DJMPNJEFEHC GKJIOGGMBPG, KIBKAPDMHFC GGCGADADFCH, [In] ONLJEFNJJKA GNLEHBFFNFG, bool IFBFMGFPHKJ);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public EFPLPIELNNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[Flags]
public enum MFNNHFHKGKJ
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
[LKMFAIPHKDB(typeof(OCEBOIKNKAB), new string[] { "Editor" })]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public sealed class OCEBOIKNKAB
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate void LDIDIENMHFI(DJMPNJEFEHC IELEJBMANDO, NOGPJKFKBEI PFDMLBFKIAP, MFNNHFHKGKJ LCCBIJEOFHP);

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate void HGIEOINBNIA(DJMPNJEFEHC IELEJBMANDO, MFNNHFHKGKJ LCCBIJEOFHP);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate void HCCINMAJJEO(DJMPNJEFEHC IELEJBMANDO, KIBKAPDMHFC GGCGADADFCH, ONLJEFNJJKA BOAPNJKEFEG, ONLJEFNJJKA INJCFLAHPML, MFNNHFHKGKJ LCCBIJEOFHP);

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate void DHNBDLKNILL(OMJBIJKANJG JLDFGFPAIIN, ReadOnlySpan<byte> JPGMJABDIAJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public OCEBOIKNKAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[LKMFAIPHKDB(typeof(BCDPLEGKDHC), new string[] { })]
internal class IHECKMKMODJ : BCDPLEGKDHC, IJCLFGAEMDL, IDisposable
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
	private sealed class MDBCCDKEACI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public MDBCCDKEACI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5E34050", Offset = "0x5E32E50", VA = "0x185E34050")]
		internal object NEJIFNPOAAL((string name, bool value) a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[MBPNJDODNHC]
	private EGFIAOKIMAI NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[MBPNJDODNHC]
	private KMLKLGKDBAC HNEIOJHCMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private NativeBitArray BKFLAMEBGDP;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DLNOBHFFECA GCFENELGNED
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B090", Offset = "0x5E29E90", VA = "0x185E2B090", Slot = "4")]
		get
		{
			return default(DLNOBHFFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DLNOBHFFECA EOJCPPODADG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AFF0", Offset = "0x5E29DF0", VA = "0x185E2AFF0", Slot = "5")]
		get
		{
			return default(DLNOBHFFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DLNOBHFFECA OCBHPPKFFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B230", Offset = "0x5E2A030", VA = "0x185E2B230", Slot = "6")]
		get
		{
			return default(DLNOBHFFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DLNOBHFFECA KBCPIACFDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AEF0", Offset = "0x5E29CF0", VA = "0x185E2AEF0", Slot = "7")]
		get
		{
			return default(DLNOBHFFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public DLNOBHFFECA BCHGGOGNMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B0B0", Offset = "0x5E29EB0", VA = "0x185E2B0B0", Slot = "8")]
		get
		{
			return default(DLNOBHFFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DLNOBHFFECA KGMDLKOHDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AE20", Offset = "0x5E29C20", VA = "0x185E2AE20", Slot = "9")]
		get
		{
			return default(DLNOBHFFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public DLNOBHFFECA EPOOLGOBFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B0C0", Offset = "0x5E29EC0", VA = "0x185E2B0C0", Slot = "10")]
		get
		{
			return default(DLNOBHFFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public DLNOBHFFECA DGBGLCLBOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AE30", Offset = "0x5E29C30", VA = "0x185E2AE30", Slot = "11")]
		get
		{
			return default(DLNOBHFFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public DLNOBHFFECA NFNMNEEFDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AFD0", Offset = "0x5E29DD0", VA = "0x185E2AFD0", Slot = "12")]
		get
		{
			return default(DLNOBHFFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public DLNOBHFFECA HFKGMMPIDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AFE0", Offset = "0x5E29DE0", VA = "0x185E2AFE0", Slot = "13")]
		get
		{
			return default(DLNOBHFFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public DLNOBHFFECA ONBILIDELIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B240", Offset = "0x5E2A040", VA = "0x185E2B240", Slot = "14")]
		get
		{
			return default(DLNOBHFFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public DLNOBHFFECA JHKCKMLFLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AEE0", Offset = "0x5E29CE0", VA = "0x185E2AEE0", Slot = "15")]
		get
		{
			return default(DLNOBHFFECA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private int GCMHANICHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AE40", Offset = "0x5E29C40", VA = "0x185E2AE40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B0D0", Offset = "0x5E29ED0", VA = "0x185E2B0D0", Slot = "16")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AF00", Offset = "0x5E29D00", VA = "0x185E2AF00", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B250", Offset = "0x5E2A050", VA = "0x185E2B250")]
	private void OOHLNKOFLND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B2A0", Offset = "0x5E2A0A0", VA = "0x185E2B2A0")]
	private void PGDIBBKOFAL(Flag CBPCLKCPMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B010", Offset = "0x5E29E10", VA = "0x185E2B010")]
	private DLNOBHFFECA FMELAGIPJIG(Flag CBPCLKCPMML)
	{
		return default(DLNOBHFFECA);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AFB0", Offset = "0x5E29DB0", VA = "0x185E2AFB0")]
	private DLNOBHFFECA ECFIJBGDPOF(Flag CBPCLKCPMML)
	{
		return default(DLNOBHFFECA);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IHECKMKMODJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[LKMFAIPHKDB(typeof(JMMDCOJHEDE), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
internal class JMMDCOJHEDE : POKGICLLPAE
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5E30B70", Offset = "0x5E2F970", VA = "0x185E30B70", Slot = "4")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public JMMDCOJHEDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[LKMFAIPHKDB(typeof(GLIGKLOBGBP), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal class GLIGKLOBGBP : IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly GKFGDEJLFAD CGMDGMGGBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[MBPNJDODNHC]
	private ELICKPPOGGA NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[MBPNJDODNHC]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[MBPNJDODNHC]
	private JNPLIBJDOGK HJDMFCAGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private DEHDJDPODCF IGBHKFPEPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private EntityQuery LELHECABNLA;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5E263E0", Offset = "0x5E251E0", VA = "0x185E263E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E27120", Offset = "0x5E25F20", VA = "0x185E27120", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5E26600", Offset = "0x5E25400", VA = "0x185E26600", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E27A60", Offset = "0x5E26860", VA = "0x185E27A60")]
	public GJLEGMBHFIE KHMPCLGKMPM(IEnumerable<ELKMOGAHBJM> BGECBMHGIKJ)
	{
		return default(GJLEGMBHFIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5E26610", Offset = "0x5E25410", VA = "0x185E26610")]
	public static bool EGHLEEFJKCG(ELKMOGAHBJM GDHOLDPNHCL, [Out] DJMPNJEFEHC IELEJBMANDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5E26980", Offset = "0x5E25780", VA = "0x185E26980")]
	private GJLEGMBHFIE FDMENPAIMKN(IEnumerable<ELKMOGAHBJM> BGECBMHGIKJ)
	{
		return default(GJLEGMBHFIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5E25DF0", Offset = "0x5E24BF0", VA = "0x185E25DF0")]
	private (List<ELKMOGAHBJM>, int[], int) BLEAKNMMFHC(IEnumerable<ELKMOGAHBJM> BGECBMHGIKJ)
	{
		return default((List<ELKMOGAHBJM>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5E27060", Offset = "0x5E25E60", VA = "0x185E27060")]
	private Dictionary<DJMPNJEFEHC, (ELKMOGAHBJM, int)> IIFNCIABKHD(IEnumerable<ELKMOGAHBJM> BGECBMHGIKJ, Entity NEOCFGHCMGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5E25FF0", Offset = "0x5E24DF0", VA = "0x185E25FF0")]
	private void BOHJCFICHDE(Dictionary<DJMPNJEFEHC, (ELKMOGAHBJM request, int srcIndex)> MFNMDNHFIBO, IEnumerable<ELKMOGAHBJM> BGECBMHGIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5E26710", Offset = "0x5E25510", VA = "0x185E26710")]
	private void EPMKLFLIDEK(Dictionary<DJMPNJEFEHC, (ELKMOGAHBJM request, int srcIndex)> MFNMDNHFIBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5E25920", Offset = "0x5E24720", VA = "0x185E25920")]
	private void BAINCCAIBPD(Dictionary<DJMPNJEFEHC, (ELKMOGAHBJM request, int srcIndex)> MFNMDNHFIBO, DJMPNJEFEHC IELEJBMANDO, string ONIBECKLJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5E27380", Offset = "0x5E26180", VA = "0x185E27380")]
	private void JFEHOKLNKKE(Dictionary<DJMPNJEFEHC, (ELKMOGAHBJM request, int srcIndex)> MFNMDNHFIBO, Entity NEOCFGHCMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5E27B60", Offset = "0x5E26960", VA = "0x185E27B60")]
	private (List<ELKMOGAHBJM>, int[], int) MHDNODDAPAF(Dictionary<DJMPNJEFEHC, (ELKMOGAHBJM request, int srcIndex)> MFNMDNHFIBO, Entity NEOCFGHCMGN)
	{
		return default((List<ELKMOGAHBJM>, int[], int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5E27770", Offset = "0x5E26570", VA = "0x185E27770")]
	private void KHCENBHPFFE(Dictionary<DJMPNJEFEHC, (ELKMOGAHBJM request, int srcIndex)> MFNMDNHFIBO, List<ELKMOGAHBJM> AGKPJGBEMGF, int[] IJJGFGJFKPE, NativeArray<Entity> PFOPLIKJCHB, NativeList<DJMPNJEFEHC> OEHBGDNEBEK, NativeList<Entity> MJPEHPDJMGB, Entity NEOCFGHCMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E26E70", Offset = "0x5E25C70", VA = "0x185E26E70")]
	private static bool GLNFFMMIACA(Entity CCHOHIEEHEH, ComponentDataFromEntity<ParentData> NLDJBCJEIKA, Entity NEOCFGHCMGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5E28160", Offset = "0x5E26F60", VA = "0x185E28160")]
	private void NPIDPJBPIGI(Dictionary<DJMPNJEFEHC, (ELKMOGAHBJM request, int srcIndex)> MFNMDNHFIBO, List<ELKMOGAHBJM> AGKPJGBEMGF, int[] IJJGFGJFKPE, NativeList<Entity> MJPEHPDJMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5E27F40", Offset = "0x5E26D40", VA = "0x185E27F40")]
	private NativeList<DJMPNJEFEHC> NDIKJNBLCLJ(Dictionary<DJMPNJEFEHC, (ELKMOGAHBJM request, int srcIndex)> MFNMDNHFIBO)
	{
		return default(NativeList<DJMPNJEFEHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5E26430", Offset = "0x5E25230", VA = "0x185E26430")]
	private NativeArray<Entity> DIPHIIKOOBE(NativeList<DJMPNJEFEHC> OEHBGDNEBEK)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5E26F40", Offset = "0x5E25D40", VA = "0x185E26F40")]
	private static void HFICGKGCJCM(Dictionary<DJMPNJEFEHC, (ELKMOGAHBJM request, int srcIndex)> MFNMDNHFIBO, DJMPNJEFEHC IELEJBMANDO, ELKMOGAHBJM GDHOLDPNHCL, string ONIBECKLJDD, int CDEDOPIOFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5E25860", Offset = "0x5E24660", VA = "0x185E25860")]
	private void AHJEJAEGBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public GLIGKLOBGBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
[LKMFAIPHKDB(typeof(ONBPEAJPLJK), new string[] { })]
internal class ONBPEAJPLJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	public void ACNOHEDMAIM(string ONIBECKLJDD, EntityManager FMCNCDMBJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public ONBPEAJPLJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[GPOCAEGADIM(typeof(BEBADJBLANP))]
[LKMFAIPHKDB(typeof(DEHDJDPODCF), new string[] { })]
internal class BEBADJBLANP : DEHDJDPODCF, IDisposable, IJCLFGAEMDL, CNAEOKMDOKG
{
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly GKFGDEJLFAD FCGNKOAMJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[MBPNJDODNHC]
	private JHHOBBMGMJL NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[MBPNJDODNHC]
	private JADOFDKKJHN DBBPJIDNNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[MBPNJDODNHC]
	private OONGDMENFCB HOIBAOKBKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private MGCBGGNJMBI CLGGHKJADNB;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool BFCNAIMILPG
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7B04D0", Offset = "0x7AF2D0", VA = "0x1807B04D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0AE0", Offset = "0x7AF8E0", VA = "0x1807B0AE0", Slot = "18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool EFKMKMMJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x10BAE60", Offset = "0x10B9C60", VA = "0x1810BAE60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool JCAIDEPELCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x80C530", Offset = "0x80B330", VA = "0x18080C530", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x80C520", Offset = "0x80B320", VA = "0x18080C520", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public JLHKELLMEON LIFDLEADJEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x76B130", Offset = "0x769F30", VA = "0x18076B130")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CC60", Offset = "0x5E1BA60", VA = "0x185E1CC60", Slot = "15")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C8B0", Offset = "0x5E1B6B0", VA = "0x185E1C8B0", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CAA0", Offset = "0x5E1B8A0", VA = "0x185E1CAA0", Slot = "8")]
	public JMHOHCKHKHG FHPJAFEEALF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C910", Offset = "0x5E1B710", VA = "0x185E1C910")]
	public JMHOHCKHKHG EMPHFDOKFGP(IEnumerable<JBMJEBCFLLB> DJIDJBJMOLC, [In] GNMGEBAMPGE ANIJGCJFDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C6F0", Offset = "0x5E1B4F0", VA = "0x185E1C6F0", Slot = "10")]
	public EMJHMNIPEIP BMOHCMFPPLK(ByteString GHHJLCMBOHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D370", Offset = "0x5E1C170", VA = "0x185E1D370")]
	public LOHFJLILNBF NEEIJFLOIKI(ByteString GHHJLCMBOHI, JBMJEBCFLLB LBLLNFOEKNE, [In] GNMGEBAMPGE PLFGJOHLOMF, BJAAPCICCEH NOIKMIGAMKD, bool APKAALJJFLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D0A0", Offset = "0x5E1BEA0", VA = "0x185E1D0A0", Slot = "12")]
	public void LIGPOGPCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CD10", Offset = "0x5E1BB10", VA = "0x185E1CD10", Slot = "13")]
	public GJLEGMBHFIE KHMPCLGKMPM(IEnumerable<ELKMOGAHBJM> JLIAKEMOOFF)
	{
		return default(GJLEGMBHFIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C5F0", Offset = "0x5E1B3F0", VA = "0x185E1C5F0")]
	public static bool BHJIAGHHOJI(ByteString GHHJLCMBOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C8B0", Offset = "0x5E1B6B0", VA = "0x185E1C8B0")]
	private void OJHMLIONAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D280", Offset = "0x5E1C080", VA = "0x185E1D280")]
	private void MEAIHMHJMGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D2A0", Offset = "0x5E1C0A0", VA = "0x185E1D2A0")]
	private void MKKDMCPEFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CBB0", Offset = "0x5E1B9B0", VA = "0x185E1CBB0", Slot = "16")]
	public void HCNPFHEKKOM(LHNHCAPHDGO AANMFFBJNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BEBADJBLANP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D520", Offset = "0x5E1C320", VA = "0x185E1D520", Slot = "9")]
	private JMHOHCKHKHG ONIFMKCNMBL(IEnumerable<JBMJEBCFLLB> DJIDJBJMOLC, [In] GNMGEBAMPGE ANIJGCJFDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5E1CEE0", Offset = "0x5E1BCE0", VA = "0x185E1CEE0", Slot = "11")]
	private LOHFJLILNBF KNGJBFBKJJH(ByteString GHHJLCMBOHI, JBMJEBCFLLB LBLLNFOEKNE, [In] GNMGEBAMPGE PLFGJOHLOMF, BJAAPCICCEH NOIKMIGAMKD, bool APKAALJJFLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[GPOCAEGADIM(typeof(OONGDMENFCB))]
[LKMFAIPHKDB(typeof(EPCLCPFGOIL), new string[] { })]
internal class OONGDMENFCB : EPCLCPFGOIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[CompilerGenerated]
	private Action<NLKOBNHNFLA> COHKGJDFBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[CompilerGenerated]
	private Action ENNFLFKBLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[CompilerGenerated]
	private Action<NLKOBNHNFLA> BGPGMOFLKDF;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action LPFNIAPEIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DCC0", Offset = "0x5E3CAC0", VA = "0x185E3DCC0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DD60", Offset = "0x5E3CB60", VA = "0x185E3DD60", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action OFPADFALJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DE00", Offset = "0x5E3CC00", VA = "0x185E3DE00", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5E3DC20", Offset = "0x5E3CA20", VA = "0x185E3DC20", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0xADB470", Offset = "0xADA270", VA = "0x180ADB470")]
	public void LIGPOGPCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0xADBCA0", Offset = "0xADAAA0", VA = "0x180ADBCA0")]
	public void FBJOHPHHEOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0xADFC90", Offset = "0xADEA90", VA = "0x180ADFC90")]
	public void HJGOAGDNINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x11C9320", Offset = "0x11C8120", VA = "0x1811C9320")]
	public void OPADJDNBMJK(NLKOBNHNFLA LBGMFGOFDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x1740840", Offset = "0x173F640", VA = "0x181740840")]
	public void PFHIECABLCE(NLKOBNHNFLA LBGMFGOFDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public OONGDMENFCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal interface CJNOCCAJLJM
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IFGPJCBFCFI(global::GCDKFGEHHBL OOKHLDCPNDD);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[GPOCAEGADIM(typeof(CJNOCCAJLJM))]
[LKMFAIPHKDB(typeof(FOLLILJKCFG), new string[] { })]
public class KHEIIDGHOEB : FOLLILJKCFG, NDDDEAMKNGH, POKGICLLPAE, IJCLFGAEMDL, FKNGAHGHIJP, IDisposable, CJNOCCAJLJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private IDFADMBGMDJ OIMODIDGOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private CCJGFPJKFGE DBLGDEINOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private GNJPLCKBNJA MENCLGMKPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private global::GCDKFGEHHBL BFGOKNKBHFB;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private HLOLALCBGEB<JBMJEBCFLLB> ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x76B170", Offset = "0x769F70", VA = "0x18076B170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5E31410", Offset = "0x5E30210", VA = "0x185E31410")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<POEBJJFCPOJ> DCJMCAACAJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5E31960", Offset = "0x5E30760", VA = "0x185E31960", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5E314E0", Offset = "0x5E302E0", VA = "0x185E314E0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x1599020", Offset = "0x1597E20", VA = "0x181599020", Slot = "17")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5E31D40", Offset = "0x5E30B40", VA = "0x185E31D40", Slot = "18")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5E31E10", Offset = "0x5E30C10", VA = "0x185E31E10", Slot = "19")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x768570", Offset = "0x767370", VA = "0x180768570", Slot = "21")]
	private void KIKGGKIKLMP(global::GCDKFGEHHBL OOKHLDCPNDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1598F70", Offset = "0x1597D70", VA = "0x181598F70", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5E31AF0", Offset = "0x5E308F0", VA = "0x185E31AF0")]
	private JBMJEBCFLLB GHFHFHGBBJA(Entity CCHOHIEEHEH)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5E31540", Offset = "0x5E30340", VA = "0x185E31540", Slot = "6")]
	public JBMJEBCFLLB DLNLOPFGNBL(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5E31740", Offset = "0x5E30540", VA = "0x185E31740", Slot = "7")]
	public void EIMAADJFFBG(List<JBMJEBCFLLB> HACNEBJEDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x5E31C80", Offset = "0x5E30A80", VA = "0x185E31C80", Slot = "11")]
	public int IHHGAJPDPHK(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5E31630", Offset = "0x5E30430", VA = "0x185E31630", Slot = "12")]
	public EOLLFEKBMDA DPHGBCBMJIH(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5E31BC0", Offset = "0x5E309C0", VA = "0x185E31BC0", Slot = "15")]
	public JBMJEBCFLLB ICGNFBGHFEG(JBMJEBCFLLB CJKEIGLKDDB, JBMJEBCFLLB FPDPCPLHJFJ)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5E319C0", Offset = "0x5E307C0", VA = "0x185E319C0", Slot = "16")]
	public bool FBILGEPLNJE(JBMJEBCFLLB CJKEIGLKDDB, JBMJEBCFLLB FPDPCPLHJFJ, [Out] JBMJEBCFLLB KAAGEJFEMGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5E31460", Offset = "0x5E30260", VA = "0x185E31460", Slot = "8")]
	public JBMJEBCFLLB DGLCEEOLIGB(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5E31A80", Offset = "0x5E30880", VA = "0x185E31A80", Slot = "14")]
	public bool FOIIPDKECAK(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB IKGHEPBMABE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5E31F00", Offset = "0x5E30D00", VA = "0x185E31F00", Slot = "13")]
	public bool PCKJBELCCCI(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB EMABGINODJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5E31B30", Offset = "0x5E30930", VA = "0x185E31B30", Slot = "9")]
	public bool HDGBCFAMPCN(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB LBLLNFOEKNE, bool CANHJIIKAKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5E315C0", Offset = "0x5E303C0", VA = "0x185E315C0", Slot = "10")]
	public bool DOEKFLCEILH(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB LBLLNFOEKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public KHEIIDGHOEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(KBGIFACAFJI), new string[] { })]
internal class KBGIFACAFJI : IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[MBPNJDODNHC]
	private FCEELEODMDI EKODFEEOAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly Dictionary<int, HBFNKHCAGGC> CBKLNIBDJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5E31000", Offset = "0x5E2FE00", VA = "0x185E31000", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5E30BC0", Offset = "0x5E2F9C0", VA = "0x185E30BC0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5E31050", Offset = "0x5E2FE50", VA = "0x185E31050")]
	public HBFNKHCAGGC JDMICDABIIJ(FIAJLECAKMM COPMFEAGFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5E31150", Offset = "0x5E2FF50", VA = "0x185E31150")]
	public HBFNKHCAGGC JDMICDABIIJ(KIBKAPDMHFC NLJCIKGMHGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5E30E50", Offset = "0x5E2FC50", VA = "0x185E30E50")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5E31380", Offset = "0x5E30180", VA = "0x185E31380")]
	public KBGIFACAFJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class HBFNKHCAGGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private NativeList<AECPNGMKDBE> MOHIMOPJBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private NativeList<HDFBIPFPCNK> IHKCEEDNGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private NativeList<CIINDJLMCOJ> NJIBMPKJNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private NativeList<HDFBIPFPCNK> NGPMAIFBJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public NativeList<AECPNGMKDBE> MGOOLKPKKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA8D850", Offset = "0xA8C650", VA = "0x180A8D850")]
		get
		{
			return default(NativeList<AECPNGMKDBE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public NativeList<HDFBIPFPCNK> FAMNPFBFFPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD47AA0", VA = "0x180D48CA0")]
		get
		{
			return default(NativeList<HDFBIPFPCNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public NativeList<CIINDJLMCOJ> BMGNFMKBJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5E260", VA = "0x180D5F460")]
		get
		{
			return default(NativeList<CIINDJLMCOJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public NativeList<HDFBIPFPCNK> CKMOCFBOJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x89C9C0", Offset = "0x89B7C0", VA = "0x18089C9C0")]
		get
		{
			return default(NativeList<HDFBIPFPCNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public JobHandle CEFNBLMIONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x955D60", Offset = "0x954B60", VA = "0x180955D60")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xFED1E0", Offset = "0xFEBFE0", VA = "0x180FED1E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool JNOCDEHEBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x5E288D0", Offset = "0x5E276D0", VA = "0x185E288D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5E28B30", Offset = "0x5E27930", VA = "0x185E28B30")]
	public HBFNKHCAGGC(Allocator JFLEKJGGDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5E28AA0", Offset = "0x5E278A0", VA = "0x185E28AA0")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5E28970", Offset = "0x5E27770", VA = "0x185E28970")]
	public void DGLGEELFCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5E28590", Offset = "0x5E27390", VA = "0x185E28590")]
	public void AAFNAGDLNDC(Entity CCHOHIEEHEH, Entity AOAOIAHJGFI, Entity KBFMMMPNLKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(FLCIMKHNFGP), new string[] { })]
public class FLCIMKHNFGP : IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[MBPNJDODNHC]
	private OPNGBJLAHIJ AIMIPJFKDIC;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5E242C0", Offset = "0x5E230C0", VA = "0x185E242C0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5E242A0", Offset = "0x5E230A0", VA = "0x185E242A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public FLCIMKHNFGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[FEFNBKCFPJG(DAEAEJBLHHK.PhotonRoom)]
[LKMFAIPHKDB(typeof(IKKGFPCGDPJ), new string[] { })]
public class IKKGFPCGDPJ : NDDDEAMKNGH, POKGICLLPAE, IJCLFGAEMDL, FKNGAHGHIJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private CENEGDPHJKH NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private JADOFDKKJHN KCCIMONFLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private NativeList<int> OJMHKLADHIG;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B560", Offset = "0x5E2A360", VA = "0x185E2B560", Slot = "4")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B8B0", Offset = "0x5E2A6B0", VA = "0x185E2B8B0", Slot = "5")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B920", Offset = "0x5E2A720", VA = "0x185E2B920", Slot = "6")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B7B0", Offset = "0x5E2A5B0", VA = "0x185E2B7B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B5C0", Offset = "0x5E2A3C0", VA = "0x185E2B5C0")]
	public void BKBFGJOLCMA(NativeParallelHashSet<int> HCHNKFGPAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B870", Offset = "0x5E2A670", VA = "0x185E2B870")]
	public void HENLNJOKGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IKKGFPCGDPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal abstract class OPLIAEFHMKJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private uint PAHNAJHPKMN;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public abstract uint KMOGDEIELOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3B0DAE0", Offset = "0x3B0C8E0", VA = "0x183B0DAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DF40", Offset = "0x5E3CD40", VA = "0x185E3DF40")]
	public DJMPNJEFEHC EGGEIHGGLPI()
	{
		return default(DJMPNJEFEHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DFB0", Offset = "0x5E3CDB0", VA = "0x185E3DFB0")]
	public void HOPDFKOHLHH(NativeArray<DJMPNJEFEHC> OEHBGDNEBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DF90", Offset = "0x5E3CD90", VA = "0x185E3DF90")]
	public void HOPDFKOHLHH(DJMPNJEFEHC IELEJBMANDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xA9D050", Offset = "0xA9BE50", VA = "0x180A9D050", Slot = "6")]
	public virtual void AOMGIBAKPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DEA0", Offset = "0x5E3CCA0", VA = "0x185E3DEA0")]
	private unsafe void EECJMPAFMGP(DJMPNJEFEHC* LHIMHDOIJFI, int HLFCMANHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E020", Offset = "0x5E3CE20", VA = "0x185E3E020")]
	private unsafe void HOPDFKOHLHH(DJMPNJEFEHC* LHIMHDOIJFI, int HLFCMANHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected OPLIAEFHMKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[LKMFAIPHKDB(typeof(MHGJLNHJKDD), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal sealed class MHGJLNHJKDD : OPLIAEFHMKJ, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[MBPNJDODNHC]
	private HLMBCPKELME NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private uint LKPDEMOKJBN;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override uint KMOGDEIELOI
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x80C540", Offset = "0x80B340", VA = "0x18080C540", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5E38040", Offset = "0x5E36E40", VA = "0x185E38040", Slot = "7")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5E380D0", Offset = "0x5E36ED0", VA = "0x185E380D0")]
	private void ONEMKFEELFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5E37FE0", Offset = "0x5E36DE0", VA = "0x185E37FE0", Slot = "6")]
	public override void AOMGIBAKPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public MHGJLNHJKDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(BOMPJJILJFM), new string[] { })]
internal sealed class BOMPJJILJFM : OPLIAEFHMKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public override uint KMOGDEIELOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BOMPJJILJFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[LKMFAIPHKDB(typeof(FCKMNLHDJPO), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal sealed class FCKMNLHDJPO : NDDDEAMKNGH, POKGICLLPAE, IJCLFGAEMDL, FKNGAHGHIJP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private EntityQuery JFNBCFHDFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private EntityQuery DCNDJLHIEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private EntityQuery JJCNBCFAONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private EntityQuery LMCHKJELFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private EntityQuery DLAEINFCMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private EntityQuery ALJHJAHFFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private EntityQuery PNFILHIMIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5E22660", Offset = "0x5E21460", VA = "0x185E22660")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EntityQuery HCEIOCCJDDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x955D80", Offset = "0x954B80", VA = "0x180955D80")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5E22790", Offset = "0x5E21590", VA = "0x185E22790", Slot = "5")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5E22890", Offset = "0x5E21690", VA = "0x185E22890", Slot = "6")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5E22720", Offset = "0x5E21520", VA = "0x185E22720")]
	private EntityQueryDesc ICONKIHIDJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5E226B0", Offset = "0x5E214B0", VA = "0x185E226B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5E22590", Offset = "0x5E21390", VA = "0x185E22590")]
	public IBDEBMIBBIB ALCOCMIFPNC(JBMJEBCFLLB HAIBOLAMIBL)
	{
		return default(IBDEBMIBBIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5E227E0", Offset = "0x5E215E0", VA = "0x185E227E0")]
	public FMJMJJHCMAN JEDJPNAIPIE(Entity CCHOHIEEHEH)
	{
		return default(FMJMJJHCMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5E22DF0", Offset = "0x5E21BF0", VA = "0x185E22DF0")]
	public FCKMNLHDJPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[LKMFAIPHKDB(typeof(IKBNJJBMJGF), new string[] { })]
public class ILCGIJKPEHM : IJCLFGAEMDL, IKBNJJBMJGF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static readonly GKFGDEJLFAD LEPIMGGBLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[MBPNJDODNHC]
	private NMOMJJDHINP DECADLJJLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[MBPNJDODNHC]
	private GNBAGIHPECL JKMCJDKCAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[MBPNJDODNHC]
	private GNJPLCKBNJA NPHELGDJFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[MBPNJDODNHC]
	private APCELKGPEPM IPGJNLBLKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[MBPNJDODNHC]
	private FCKMNLHDJPO DOBOMMPHLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private HDEKOHKCIPA JPFJLMHLIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private KOHELDMJMKP BGNKJBDOIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public KHMPNKBJMCM GDNMHGNJJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x76EAB0", Offset = "0x76D8B0", VA = "0x18076EAB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(KHMPNKBJMCM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x76EBA0", Offset = "0x76D9A0", VA = "0x18076EBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action<EOLLFEKBMDA, NativeArray<FMJMJJHCMAN>> MDBAKLKDBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C820", Offset = "0x5E2B620", VA = "0x185E2C820", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C1D0", Offset = "0x5E2AFD0", VA = "0x185E2C1D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event Action<EOLLFEKBMDA> EPJAIFJBMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E2BA60", Offset = "0x5E2A860", VA = "0x185E2BA60", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E2BFA0", Offset = "0x5E2ADA0", VA = "0x185E2BFA0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C4D0", Offset = "0x5E2B2D0", VA = "0x185E2C4D0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C050", Offset = "0x5E2AE50", VA = "0x185E2C050", Slot = "40")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C7D0", Offset = "0x5E2B5D0", VA = "0x185E2C7D0")]
	private void KEHOEJOAMBM(EOLLFEKBMDA BCFDFNJIOHD, NativeArray<FMJMJJHCMAN> CKFMLBNEDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C410", Offset = "0x5E2B210", VA = "0x185E2C410")]
	private void HNOCOMIBLNI(EOLLFEKBMDA BCFDFNJIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C2E0", Offset = "0x5E2B0E0", VA = "0x185E2C2E0")]
	internal JBMJEBCFLLB GHFHFHGBBJA(Entity CCHOHIEEHEH)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BBA0", Offset = "0x5E2A9A0", VA = "0x185E2BBA0", Slot = "11")]
	public IBDEBMIBBIB ALCOCMIFPNC(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(IBDEBMIBBIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C770", Offset = "0x5E2B570", VA = "0x185E2C770", Slot = "12")]
	public FMJMJJHCMAN JEDJPNAIPIE(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(FMJMJJHCMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C320", Offset = "0x5E2B120", VA = "0x185E2C320", Slot = "39")]
	public bool HCAMIAJDHEM(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BDC0", Offset = "0x5E2ABC0", VA = "0x185E2BDC0", Slot = "34")]
	public void CGMMBIMCGNC(EOLLFEKBMDA DJIDJBJMOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CC40", Offset = "0x5E2BA40", VA = "0x185E2CC40", Slot = "35")]
	public void OKHJEEBGOJC(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C170", Offset = "0x5E2AF70", VA = "0x185E2C170", Slot = "36")]
	public void GAOMNJBAIKD(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BED0", Offset = "0x5E2ACD0", VA = "0x185E2BED0", Slot = "37")]
	public void CGMMBIMCGNC(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C470", Offset = "0x5E2B270", VA = "0x185E2C470", Slot = "24")]
	public EOLLFEKBMDA IAMCBICJENG(NativeArray<DJMPNJEFEHC> IELEJBMANDO, Allocator JFLEKJGGDHL)
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CCA0", Offset = "0x5E2BAA0", VA = "0x185E2CCA0", Slot = "25")]
	public EOLLFEKBMDA PDJBMEBOODM(NativeArray<DJMPNJEFEHC> IELEJBMANDO, NativeArray<NOGPJKFKBEI> EIBIAHGBKEB, Allocator JFLEKJGGDHL)
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CA10", Offset = "0x5E2B810", VA = "0x185E2CA10", Slot = "26")]
	public ECLMNCPCDJH LOLHPIIPICI(FMJMJJHCMAN CMNEDOHOKIA, bool EFMKMAPHEAG)
	{
		return default(ECLMNCPCDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C9B0", Offset = "0x5E2B7B0", VA = "0x185E2C9B0", Slot = "27")]
	public ECLMNCPCDJH LOLHPIIPICI(FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(ECLMNCPCDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C280", Offset = "0x5E2B080", VA = "0x185E2C280", Slot = "28")]
	public ECLMNCPCDJH GBGNNNGDFPA(FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(ECLMNCPCDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BCD0", Offset = "0x5E2AAD0", VA = "0x185E2BCD0", Slot = "29")]
	public ECLMNCPCDJH BJIPHNHAEML(FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(ECLMNCPCDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CDC0", Offset = "0x5E2BBC0", VA = "0x185E2CDC0", Slot = "30")]
	public ECLMNCPCDJH PDJBMEBOODM(DJMPNJEFEHC IELEJBMANDO, FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(ECLMNCPCDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CBD0", Offset = "0x5E2B9D0", VA = "0x185E2CBD0", Slot = "31")]
	public GMKHMIPPILJ OGKAMDNAFHE()
	{
		return default(GMKHMIPPILJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C920", Offset = "0x5E2B720", VA = "0x185E2C920", Slot = "32")]
	public PAEMMLCLHJM LLPIPGIIHHE()
	{
		return default(PAEMMLCLHJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BB10", Offset = "0x5E2A910", VA = "0x185E2BB10", Slot = "33")]
	public LPBJFDJKJEF AHMFCFGLLII(NJGEKDIELMJ PEMNIEMPPLO)
	{
		return default(LPBJFDJKJEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CA70", Offset = "0x5E2B870", VA = "0x185E2CA70", Slot = "13")]
	public void MCJJKKHGDCC(DJMPNJEFEHC IELEJBMANDO, KMILLOLJKJL CEGGCCELOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CA90", Offset = "0x5E2B890", VA = "0x185E2CA90", Slot = "14")]
	public ECLMNCPCDJH MEMNMGJANNO(JBMJEBCFLLB OGPPAJOCABK, [Optional] object PFKLELGAJPH)
	{
		return default(ECLMNCPCDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CB80", Offset = "0x5E2B980", VA = "0x185E2CB80", Slot = "15")]
	public bool NNMNOGEKHAN(JBMJEBCFLLB OGPPAJOCABK, [Out] KMILLOLJKJL EKOLPKLNMBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BC80", Offset = "0x5E2AA80", VA = "0x185E2BC80", Slot = "16")]
	public bool AMDJHMKKENI(JBMJEBCFLLB OGPPAJOCABK, [Out] Transform GNLAIPIBJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CE90", Offset = "0x5E2BC90", VA = "0x185E2CE90", Slot = "17")]
	public bool PIACKBAOBEI(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BF20", Offset = "0x5E2AD20", VA = "0x185E2BF20", Slot = "18")]
	public void DFKCBNKAFIM(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C3C0", Offset = "0x5E2B1C0", VA = "0x185E2C3C0", Slot = "19")]
	public bool HKNOPCPJEPF(LocalId OGPPAJOCABK, object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C8D0", Offset = "0x5E2B6D0", VA = "0x185E2C8D0", Slot = "20")]
	public bool LDOHKGPKLNJ(LocalId OGPPAJOCABK, object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CB20", Offset = "0x5E2B920", VA = "0x185E2CB20", Slot = "38")]
	public EOLLFEKBMDA NKCHKCJIHIJ(EOLLFEKBMDA GCHHFEIHBEL, Allocator JFLEKJGGDHL)
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C150", Offset = "0x5E2AF50", VA = "0x185E2C150", Slot = "23")]
	public DJMPNJEFEHC FKGNNMHAONN(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(DJMPNJEFEHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C450", Offset = "0x5E2B250", VA = "0x185E2C450", Slot = "21")]
	public JBMJEBCFLLB IAMCBICJENG(DJMPNJEFEHC IELEJBMANDO)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C7B0", Offset = "0x5E2B5B0", VA = "0x185E2C7B0", Slot = "22")]
	public bool JIAOCCHKBED(DJMPNJEFEHC IELEJBMANDO, [Out] JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BF60", Offset = "0x5E2AD60", VA = "0x185E2BF60")]
	private void DLAOPKODDHP(FMJMJJHCMAN AMKLAEEOILO, JBMJEBCFLLB OGPPAJOCABK, DJMPNJEFEHC IELEJBMANDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E2CF40", Offset = "0x5E2BD40", VA = "0x185E2CF40")]
	public ILCGIJKPEHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[LKMFAIPHKDB(typeof(EGHONEJJMPI), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal sealed class EGHONEJJMPI : IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private APCELKGPEPM IPGJNLBLKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[MBPNJDODNHC]
	private FCKMNLHDJPO DOBOMMPHLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[MBPNJDODNHC]
	private IHJBEAAMNEB MGEIMBMEALC;

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EFD0", Offset = "0x5E1DDD0", VA = "0x185E1EFD0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F080", Offset = "0x5E1DE80", VA = "0x185E1F080")]
	public EOLLFEKBMDA NKCHKCJIHIJ(EOLLFEKBMDA GCHHFEIHBEL, Allocator JFLEKJGGDHL)
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F1D0", Offset = "0x5E1DFD0", VA = "0x185E1F1D0")]
	private void OJJMHKCHFCB(NativeParallelMultiHashMap<int, (JBMJEBCFLLB src, JBMJEBCFLLB dst)> AMFBNBAHPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E1F400", Offset = "0x5E1E200", VA = "0x185E1F400")]
	private void PFBMANKFCED(NativeParallelMultiHashMap<int, (JBMJEBCFLLB src, JBMJEBCFLLB dst)> AMFBNBAHPJH, int CMNEDOHOKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EE60", Offset = "0x5E1DC60", VA = "0x185E1EE60")]
	private void IDAALJNCBNM(NativeParallelMultiHashMap<int, (JBMJEBCFLLB src, JBMJEBCFLLB dst)> AMFBNBAHPJH, int CMNEDOHOKIA, MFGAIFFIFKP EKODFEEOAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E1EBF0", Offset = "0x5E1D9F0", VA = "0x185E1EBF0")]
	private NativeParallelMultiHashMap<int, (JBMJEBCFLLB, JBMJEBCFLLB)> CIOAFJNIDDE(Allocator JFLEKJGGDHL, EOLLFEKBMDA GCHHFEIHBEL, [Out] EOLLFEKBMDA HANALCIHNHE)
	{
		return default(NativeParallelMultiHashMap<int, (JBMJEBCFLLB, JBMJEBCFLLB)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public EGHONEJJMPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[LKMFAIPHKDB(typeof(JNPLIBJDOGK), new string[] { })]
[GPOCAEGADIM(typeof(MDOBHIFKKDP))]
public class MDOBHIFKKDP : JNPLIBJDOGK, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static readonly GKFGDEJLFAD FLLIABGAFCC;

	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private static readonly GKFGDEJLFAD NOBFHELJDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private CDNOLOGJCIN NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private OHEAJDCELJE JOEFEJIMKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private FOLLILJKCFG IAMHOIOBMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private IOPAEIMLPMI OJLHNOIOHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private GNJPLCKBNJA NPHELGDJFPC;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	private EntityManager FMCNCDMBJDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5E352C0", Offset = "0x5E340C0", VA = "0x185E352C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E36140", Offset = "0x5E34F40", VA = "0x185E36140", Slot = "34")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E36250", Offset = "0x5E35050", VA = "0x185E36250", Slot = "35")]
	public bool JIAOCCHKBED(Transform GNLAIPIBJPM, [Out] JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E34D10", Offset = "0x5E33B10", VA = "0x185E34D10", Slot = "36")]
	public Transform DFALHKGGGDO(Entity CCHOHIEEHEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E34240", Offset = "0x5E33040", VA = "0x185E34240", Slot = "31")]
	public bool AMDJHMKKENI(Entity CCHOHIEEHEH, [Out] Transform GNLAIPIBJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E34930", Offset = "0x5E33730", VA = "0x185E34930")]
	private void CHPLIFGIINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E37D10", Offset = "0x5E36B10", VA = "0x185E37D10", Slot = "30")]
	public void POBFHNNFDCL(Entity CCHOHIEEHEH, [Out] float4x4 HOBNMCCMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E346B0", Offset = "0x5E334B0", VA = "0x185E346B0", Slot = "4")]
	public void CCOHGCIOGNE(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E340D0", Offset = "0x5E32ED0", VA = "0x185E340D0", Slot = "28")]
	public void AJMIJDIDCFO(Entity CCHOHIEEHEH, [Out] float4x4 HOBNMCCMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E35BF0", Offset = "0x5E349F0", VA = "0x185E35BF0")]
	public void IOOBAHDFEOG(Entity CCHOHIEEHEH, [In] float4x4 HOBNMCCMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E34580", Offset = "0x5E33380", VA = "0x185E34580")]
	public void BLGAAIADLPP(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E370F0", Offset = "0x5E35EF0", VA = "0x185E370F0", Slot = "6")]
	public float3 MJOKFPDKCOJ(Entity CCHOHIEEHEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E34A30", Offset = "0x5E33830", VA = "0x185E34A30")]
	public void FHKHLABDHDC(Entity CCHOHIEEHEH, [In] quaternion GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E34DE0", Offset = "0x5E33BE0", VA = "0x185E34DE0", Slot = "8")]
	public quaternion FBBALPCBFHP(Entity CCHOHIEEHEH)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E36FC0", Offset = "0x5E35DC0", VA = "0x185E36FC0")]
	public void OHAGLNPDEOK(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E37DC0", Offset = "0x5E36BC0", VA = "0x185E37DC0", Slot = "12")]
	public float3 PODHOBKEHKG(Entity CCHOHIEEHEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E34950", Offset = "0x5E33750", VA = "0x185E34950", Slot = "15")]
	public float CICGGLJGLCK(Entity CCHOHIEEHEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E36B30", Offset = "0x5E35930", VA = "0x185E36B30", Slot = "14")]
	public void KOABEJLMHIM(Entity CCHOHIEEHEH, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E34B50", Offset = "0x5E33950", VA = "0x185E34B50", Slot = "17")]
	public float3 DEJHDPELPNE(Entity CCHOHIEEHEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E363D0", Offset = "0x5E351D0", VA = "0x185E363D0")]
	public void JPIPCOGLIKJ(Entity CCHOHIEEHEH, [In] float3 HDALKMKFGHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E37540", Offset = "0x5E36340", VA = "0x185E37540", Slot = "9")]
	public void OGIDGNKLIHP(Entity CCHOHIEEHEH, [Out] float3 AILFIIEAPKM, [Out] quaternion GIBIBDOGOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E376B0", Offset = "0x5E364B0", VA = "0x185E376B0", Slot = "10")]
	public void OGIDGNKLIHP(Entity CCHOHIEEHEH, [Out] RigidTransform HKMBHMECFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E36D30", Offset = "0x5E35B30", VA = "0x185E36D30", Slot = "37")]
	public void LFDNCAOIMOF(Entity CCHOHIEEHEH, [Out] float3 AILFIIEAPKM, [Out] quaternion GIBIBDOGOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E36D10", Offset = "0x5E35B10", VA = "0x185E36D10", Slot = "11")]
	public void LFDNCAOIMOF(Entity CCHOHIEEHEH, [Out] RigidTransform HKMBHMECFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E34450", Offset = "0x5E33250", VA = "0x185E34450")]
	public void BIHKONFJOAH(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E35310", Offset = "0x5E34110", VA = "0x185E35310", Slot = "19")]
	public float3 GHFJBMOEKHB(Entity CCHOHIEEHEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E34330", Offset = "0x5E33130", VA = "0x185E34330")]
	public void BHLMGHAOHAL(Entity CCHOHIEEHEH, [In] quaternion GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E34EF0", Offset = "0x5E33CF0", VA = "0x185E34EF0", Slot = "21")]
	public quaternion FFJKEAMMJOE(Entity CCHOHIEEHEH)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E37210", Offset = "0x5E36010", VA = "0x185E37210")]
	public void NHGMNEMKFHL(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E37BF0", Offset = "0x5E369F0", VA = "0x185E37BF0", Slot = "22")]
	public float3 PLDOPHAIMOM(Entity CCHOHIEEHEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E378C0", Offset = "0x5E366C0", VA = "0x185E378C0", Slot = "24")]
	public void PIMAAAFBADI(Entity CCHOHIEEHEH, float HHNCIKLKENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E35580", Offset = "0x5E34380", VA = "0x185E35580", Slot = "25")]
	public float GLPDGGNCDBF(Entity CCHOHIEEHEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E35780", Offset = "0x5E34580", VA = "0x185E35780")]
	public void IINELJDOJLE(Entity CCHOHIEEHEH, [In] float3 OOBKEMKJMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E35130", Offset = "0x5E33F30", VA = "0x185E35130", Slot = "27")]
	public float3 GCAIJLDGBMF(Entity CCHOHIEEHEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E36550", Offset = "0x5E35350", VA = "0x185E36550", Slot = "32")]
	public void KCPBCAHHHIJ(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E35660", Offset = "0x5E34460", VA = "0x185E35660")]
	private JBMJEBCFLLB ICCGMKHGNLI(Transform GNLAIPIBJPM)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E35EC0", Offset = "0x5E34CC0", VA = "0x185E35EC0")]
	private static TransformEntity IPJKKCIKPGH(FMJMJJHCMAN PEMNIEMPPLO, GameObject FJNLKHDMLBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x244F4B0", Offset = "0x244E2B0", VA = "0x18244F4B0")]
	private static T LKOCPGAPKLB<T>(GameObject FJNLKHDMLBO) where T : MonoBehaviour
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E37420", Offset = "0x5E36220", VA = "0x185E37420", Slot = "33")]
	public void NPGLBEMPLFL(Entity CCHOHIEEHEH, Entity AOAOIAHJGFI, Entity KBFMMMPNLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public MDOBHIFKKDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E34580", Offset = "0x5E33380", VA = "0x185E34580", Slot = "5")]
	private void NNLEDGKJJGK(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E34A30", Offset = "0x5E33830", VA = "0x185E34A30", Slot = "7")]
	private void DCLBEOFJEPL(Entity CCHOHIEEHEH, [In] quaternion GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E36FC0", Offset = "0x5E35DC0", VA = "0x185E36FC0", Slot = "13")]
	private void MHCEIOJHOAN(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E363D0", Offset = "0x5E351D0", VA = "0x185E363D0", Slot = "16")]
	private void OENBOEGBJBC(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5E34450", Offset = "0x5E33250", VA = "0x185E34450", Slot = "18")]
	private void DGMBPLFGJNI(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5E34330", Offset = "0x5E33130", VA = "0x185E34330", Slot = "20")]
	private void MCIOGHIEKCA(Entity CCHOHIEEHEH, [In] quaternion GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5E34DD0", Offset = "0x5E33BD0", VA = "0x185E34DD0", Slot = "23")]
	private void DPPOEGKJOKD(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5E36B20", Offset = "0x5E35920", VA = "0x185E36B20", Slot = "26")]
	private void KFOOLGONNKE(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5E378B0", Offset = "0x5E366B0", VA = "0x185E378B0", Slot = "29")]
	private void PGNJHDFHBMB(Entity CCHOHIEEHEH, [In] float4x4 AIPDOMPIDDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class OMALPJNGPCG
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C720", Offset = "0x5E3B520", VA = "0x185E3C720")]
	public static void LMCILFPDOEO(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [In] float3 ELHIODNHAHA, [In] quaternion FIIPDOPILCE, [In] float3 MKLPPFHEAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D350", Offset = "0x5E3C150", VA = "0x185E3D350")]
	public static void POBFHNNFDCL(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [Out] float4x4 HOBNMCCMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D210", Offset = "0x5E3C010", VA = "0x185E3D210")]
	private static void POBFHNNFDCL(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, Entity LBLLNFOEKNE, [Out] float4x4 HOBNMCCMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BF80", Offset = "0x5E3AD80", VA = "0x185E3BF80")]
	public static void IOOBAHDFEOG(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [In] float4x4 HOBNMCCMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B9E0", Offset = "0x5E3A7E0", VA = "0x185E3B9E0")]
	public static void IFDPJIJBCJE(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [Out] float4x4 JKEHCMLOGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C8B0", Offset = "0x5E3B6B0", VA = "0x185E3C8B0")]
	public static void MMENBHLJKGJ(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [In] float4x4 JKEHCMLOGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C7C0", Offset = "0x5E3B5C0", VA = "0x185E3C7C0")]
	public static float3 MJOKFPDKCOJ(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3ADA0", Offset = "0x5E39BA0", VA = "0x185E3ADA0")]
	public static void BLGAAIADLPP(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B040", Offset = "0x5E39E40", VA = "0x185E3B040")]
	public static quaternion FBBALPCBFHP(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B290", Offset = "0x5E3A090", VA = "0x185E3B290")]
	public static void FHKHLABDHDC(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [In] quaternion GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D470", Offset = "0x5E3C270", VA = "0x185E3D470")]
	public static float3 PODHOBKEHKG(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CDC0", Offset = "0x5E3BBC0", VA = "0x185E3CDC0")]
	public static void OHAGLNPDEOK(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AE90", Offset = "0x5E39C90", VA = "0x185E3AE90")]
	public static float CICGGLJGLCK(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C3E0", Offset = "0x5E3B1E0", VA = "0x185E3C3E0")]
	public static void KOABEJLMHIM(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AF60", Offset = "0x5E39D60", VA = "0x185E3AF60")]
	public static float3 DEJHDPELPNE(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C310", Offset = "0x5E3B110", VA = "0x185E3C310")]
	public static void JPIPCOGLIKJ(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CCE0", Offset = "0x5E3BAE0", VA = "0x185E3CCE0")]
	public static void OGIDGNKLIHP(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [Out] RigidTransform JKEHCMLOGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CBD0", Offset = "0x5E3B9D0", VA = "0x185E3CBD0")]
	public static void OGIDGNKLIHP(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [Out] float3 AILFIIEAPKM, [Out] quaternion GIBIBDOGOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C620", Offset = "0x5E3B420", VA = "0x185E3C620")]
	public static void LLDCFOMIIEJ(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [In] float3 ELHIODNHAHA, [In] quaternion FIIPDOPILCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C490", Offset = "0x5E3B290", VA = "0x185E3C490")]
	public static void LFDNCAOIMOF(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [Out] float3 AILFIIEAPKM, [Out] quaternion GIBIBDOGOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B5E0", Offset = "0x5E3A3E0", VA = "0x185E3B5E0")]
	public static float3 GHFJBMOEKHB(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AB50", Offset = "0x5E39950", VA = "0x185E3AB50")]
	public static void BIHKONFJOAH(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A7C0", Offset = "0x5E395C0", VA = "0x185E3A7C0")]
	public static void BHLMGHAOHAL(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [In] quaternion GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B120", Offset = "0x5E39F20", VA = "0x185E3B120")]
	public static quaternion FFJKEAMMJOE(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CFF0", Offset = "0x5E3BDF0", VA = "0x185E3CFF0")]
	public static float3 PLDOPHAIMOM(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C980", Offset = "0x5E3B780", VA = "0x185E3C980")]
	public static void NHGMNEMKFHL(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B760", Offset = "0x5E3A560", VA = "0x185E3B760")]
	public static float GLPDGGNCDBF(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CEB0", Offset = "0x5E3BCB0", VA = "0x185E3CEB0")]
	public static void PIMAAAFBADI(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, float HHNCIKLKENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B380", Offset = "0x5E3A180", VA = "0x185E3B380")]
	public static float3 GCAIJLDGBMF(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BD90", Offset = "0x5E3AB90", VA = "0x185E3BD90")]
	public static void IINELJDOJLE(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [In] float3 OOBKEMKJMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B940", Offset = "0x5E3A740", VA = "0x185E3B940")]
	public static bool GONMEPBEBFM(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [Out] Entity LBLLNFOEKNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[LKMFAIPHKDB(typeof(DLDEBFMGNGC), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
internal sealed class DLDEBFMGNGC : IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[MBPNJDODNHC]
	private LJMLIKCJBGD NBBLMGDHBPE;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E980", Offset = "0x5E1D780", VA = "0x185E1E980", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E930", Offset = "0x5E1D730", VA = "0x185E1E930", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DLDEBFMGNGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[LKMFAIPHKDB(typeof(KMJGCNJDEKG), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public class KMJGCNJDEKG
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct ANKMLHEGMIP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly KMJGCNJDEKG LBLLNFOEKNE;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5E1C1C0", Offset = "0x5E1AFC0", VA = "0x185E1C1C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private int ODABFDLMPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[CompilerGenerated]
	private Action FGGLAJJHEMH;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5E32870", Offset = "0x5E31670", VA = "0x185E32870")]
	public void HDPCNNLNCKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public KMJGCNJDEKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(DLKMEGGCFLP), new string[] { })]
public class DLKMEGGCFLP
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool HNEIOJHCMIL;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool NBMNKGOJOAB
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7B46A0", Offset = "0x7B34A0", VA = "0x1807B46A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5E1EA30", Offset = "0x5E1D830", VA = "0x185E1EA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DLKMEGGCFLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[LKMFAIPHKDB(typeof(PDKDJEHAOAJ), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public class PDKDJEHAOAJ : IJCLFGAEMDL, CNAEOKMDOKG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private struct GKEJFIGPDIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private NativeArray<int> JKMMPDOKNDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private NativeArray<int> NFOFHIAHFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private Dictionary<ComponentSystemBase, int> ALIAGBHDIJF;

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5E25840", Offset = "0x5E24640", VA = "0x185E25840")]
		public GKEJFIGPDIC(NativeArray<int> JKMMPDOKNDC, NativeArray<int> NFOFHIAHFEO, Dictionary<ComponentSystemBase, int> ALIAGBHDIJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5E25420", Offset = "0x5E24220", VA = "0x185E25420")]
		public static void HFPOBHKOPJF(World GICLKIIJBDC, DAEAEJBLHHK CONFCDPIHFL, NativeArray<int> JKMMPDOKNDC, NativeArray<int> NFOFHIAHFEO, Dictionary<ComponentSystemBase, int> ALIAGBHDIJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5E25550", Offset = "0x5E24350", VA = "0x185E25550")]
		public void JMMNJJEKEHM(IEnumerable<ComponentSystemBase> DECADLJJLLJ, DAEAEJBLHHK CONFCDPIHFL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class BNFDLHKFMGN : IEnumerable<ComponentSystemBase>, IEnumerable, IEnumerator<ComponentSystemBase>, IEnumerator, IDisposable
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
		public PDKDJEHAOAJ <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x863A90", Offset = "0x862890", VA = "0x180863A90")]
		[DebuggerHidden]
		public BNFDLHKFMGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D770", Offset = "0x5E1C570", VA = "0x185E1D770", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D950", Offset = "0x5E1C750", VA = "0x185E1D950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D8A0", Offset = "0x5E1C6A0", VA = "0x185E1D8A0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<ComponentSystemBase> IEnumerable<ComponentSystemBase>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x5E1D8A0", Offset = "0x5E1C6A0", VA = "0x185E1D8A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly GKFGDEJLFAD PJLMGJOFCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private World GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private LHNHCAPHDGO PDGDCGJNEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private NativeArray<int> OIFKKNBKFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private NativeArray<int> PIEDENGADAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int KCPGKFKLEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private DAEAEJBLHHK HCCCLMJAGJN;

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E830", Offset = "0x5E3D630", VA = "0x185E3E830", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E390", Offset = "0x5E3D190", VA = "0x185E3E390", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E9C0", Offset = "0x5E3D7C0", VA = "0x185E3E9C0")]
	[IteratorStateMachine(typeof(BNFDLHKFMGN))]
	private IEnumerable<ComponentSystemBase> LCCPHJHGEKG(int KMFMMHANJHK, int MCKBHHHCKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E730", Offset = "0x5E3D530", VA = "0x185E3E730", Slot = "5")]
	public void HCNPFHEKKOM(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E730", Offset = "0x5E3D530", VA = "0x185E3E730")]
	private void GKEKNPBDJLH(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E5E0", Offset = "0x5E3D3E0", VA = "0x185E3E5E0")]
	public void GKEKNPBDJLH(DAEAEJBLHHK BMLHFLIHEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F1F0", Offset = "0x5E3DFF0", VA = "0x185E3F1F0")]
	private void PHICPOIKKJB(DAEAEJBLHHK BMLHFLIHEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E400", Offset = "0x5E3D200", VA = "0x185E3E400")]
	private void FCKHHHELENK(DAEAEJBLHHK BMLHFLIHEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EAB0", Offset = "0x5E3D8B0", VA = "0x185E3EAB0")]
	private void NCHLBFOJMLH(DAEAEJBLHHK BMLHFLIHEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EA60", Offset = "0x5E3D860", VA = "0x185E3EA60")]
	private void MMNHECEJANO(int KMFMMHANJHK, int MCKBHHHCKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E4C0", Offset = "0x5E3D2C0", VA = "0x185E3E4C0")]
	private void FIDNIABEBBF(int KMFMMHANJHK, int MCKBHHHCKCE, bool HNEIOJHCMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E810", Offset = "0x5E3D610", VA = "0x185E3E810")]
	private int IFNGHLCCCDP(DAEAEJBLHHK BMLHFLIHEDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EC30", Offset = "0x5E3DA30", VA = "0x185E3EC30")]
	private bool OCFHMBGGMBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EB40", Offset = "0x5E3D940", VA = "0x185E3EB40")]
	private Dictionary<ComponentSystemBase, int> NKNELDEOHGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E350", Offset = "0x5E3D150", VA = "0x185E3E350")]
	private void AHPDKBMNMAI(NativeArray<int> JKMMPDOKNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E910", Offset = "0x5E3D710", VA = "0x185E3E910")]
	private void JKDEAEFEBAL(NativeArray<int> NFOFHIAHFEO, NativeArray<int> JKMMPDOKNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E580", Offset = "0x5E3D380", VA = "0x185E3E580")]
	private static DAEAEJBLHHK FIMOKCBBHIC(Type PEMNIEMPPLO, DAEAEJBLHHK HEDIGKLLBHN)
	{
		return default(DAEAEJBLHHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F530", Offset = "0x5E3E330", VA = "0x185E3F530")]
	public PDKDJEHAOAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E2F0", Offset = "0x5E3D0F0", VA = "0x185E3E2F0")]
	[CompilerGenerated]
	private void AADIJGNCPAJ(IJCLFGAEMDL PFBEHMOEMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E7B0", Offset = "0x5E3D5B0", VA = "0x185E3E7B0")]
	[CompilerGenerated]
	private void HAIPLMEGMJJ(FKNGAHGHIJP PFBEHMOEMND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[LKMFAIPHKDB(typeof(ODLGBANKCLJ), new string[] { })]
public class GGHELAODDJP : IJCLFGAEMDL, ODLGBANKCLJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[MBPNJDODNHC]
	private DEHDJDPODCF IGBHKFPEPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[MBPNJDODNHC]
	private INAOLEEONGL GDJHDOEIOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[MBPNJDODNHC]
	private KMLKLGKDBAC EHCHOJJHPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[MBPNJDODNHC]
	private IOPAEIMLPMI GKIKJJGHLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[MBPNJDODNHC]
	private BOGMJJODDAE NCGAGJLPMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private World FGNLGFEOMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private GEHGGFOMCDP HMBJIHJDLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private GEHGGFOMCDP CHLKCDKPHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private GEHGGFOMCDP HACDOLEDGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private GEHGGFOMCDP FLPLOGJGCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private GEHGGFOMCDP DLGAFABKEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private GEHGGFOMCDP JKIENHMMGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private GEHGGFOMCDP CLBANONHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private GEHGGFOMCDP NLJDIEOABGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private GEHGGFOMCDP LJFEENCEPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private GEHGGFOMCDP DPLPKNNHEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private GEHGGFOMCDP GPEMKBDODMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private GEHGGFOMCDP DIKPNKDPEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private GEHGGFOMCDP IOEALIIOMEH;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private bool ALMFJFKGPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5E25290", Offset = "0x5E24090", VA = "0x185E25290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private bool POAFNLEHEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x5E24750", Offset = "0x5E23550", VA = "0x185E24750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private bool EGIHKGMPDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5E24660", Offset = "0x5E23460", VA = "0x185E24660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private bool ILMGJFGEBPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5E24660", Offset = "0x5E23460", VA = "0x185E24660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5E24DD0", Offset = "0x5E23BD0", VA = "0x185E24DD0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x2358460", Offset = "0x2357260", VA = "0x182358460")]
	private GEHGGFOMCDP GNOJFHCBDAA<T>() where T : MLIOKEAIOIH
	{
		return default(GEHGGFOMCDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x5E24CE0", Offset = "0x5E23AE0", VA = "0x185E24CE0")]
	private GEHGGFOMCDP GNOJFHCBDAA(Type PEMNIEMPPLO)
	{
		return default(GEHGGFOMCDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x5E25260", Offset = "0x5E24060", VA = "0x185E25260", Slot = "14")]
	public void KPJPIMLJGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x5E24630", Offset = "0x5E23430", VA = "0x185E24630", Slot = "15")]
	public void AFMHCKBDBMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x5E247C0", Offset = "0x5E235C0", VA = "0x185E247C0", Slot = "5")]
	public void COIEFNNLDLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x5E24D50", Offset = "0x5E23B50", VA = "0x185E24D50", Slot = "6")]
	public void IAHDPFNBOKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5E24800", Offset = "0x5E23600", VA = "0x185E24800", Slot = "7")]
	public void DJENHNKCJPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x5E251E0", Offset = "0x5E23FE0", VA = "0x185E251E0", Slot = "8")]
	public void KHMKHIOJJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x5E24C60", Offset = "0x5E23A60", VA = "0x185E24C60", Slot = "9")]
	public void GFEAFEOKKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x5E24670", Offset = "0x5E23470", VA = "0x185E24670", Slot = "10")]
	public void BBKOGNMKOEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5E25310", Offset = "0x5E24110", VA = "0x185E25310", Slot = "11")]
	public void NIGOMGLPENK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5E24D10", Offset = "0x5E23B10", VA = "0x185E24D10", Slot = "12")]
	public void HKFFMDJBNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x5E24910", Offset = "0x5E23710", VA = "0x185E24910", Slot = "13")]
	public void GDEEGPBGDEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x5E24880", Offset = "0x5E23680", VA = "0x185E24880")]
	private void DOFKEEPDGPM(GEHGGFOMCDP LOFHIHDMJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x5E245A0", Offset = "0x5E233A0", VA = "0x185E245A0")]
	private void ABHEABEIIGB(GEHGGFOMCDP LOFHIHDMJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x5E247E0", Offset = "0x5E235E0", VA = "0x185E247E0")]
	private void DFBNBKPENIH(GEHGGFOMCDP LOFHIHDMJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public GGHELAODDJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal readonly struct GEHGGFOMCDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly ComponentSystemBase LOFHIHDMJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly ProfilerMarker MKAIGIFCHJM;

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x5E243E0", Offset = "0x5E231E0", VA = "0x185E243E0")]
	public GEHGGFOMCDP(World GICLKIIJBDC, Type PEMNIEMPPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5E24310", Offset = "0x5E23110", VA = "0x185E24310")]
	public void DFBNBKPENIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[LKMFAIPHKDB(typeof(HBMBNCJMDAI), new string[] { })]
public class OMDJNKDAJEJ : HBMBNCJMDAI, IDisposable, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[MBPNJDODNHC]
	private FBHFKMFDFBO AGKPCNNDNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[MBPNJDODNHC]
	private OCEBOIKNKAB KFOLJGBPMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private World FGNLGFEOMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private World AEALPKECAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private bool COJBLOIGHMP;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public World IIPPIBCPIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public World LLDCDMOFHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D5B0", Offset = "0x5E3C3B0", VA = "0x185E3D5B0", Slot = "6")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x36462C0", Offset = "0x36450C0", VA = "0x1836462C0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D9F0", Offset = "0x5E3C7F0", VA = "0x185E3D9F0", Slot = "10")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D8C0", Offset = "0x5E3C6C0", VA = "0x185E3D8C0")]
	private void HKJMJGOBNGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D5D0", Offset = "0x5E3C3D0", VA = "0x185E3D5D0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D8A0", Offset = "0x5E3C6A0", VA = "0x185E3D8A0", Slot = "8")]
	public ComponentSystemBase GNOJFHCBDAA(Type PEMNIEMPPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public OMDJNKDAJEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[LKMFAIPHKDB(typeof(HCOENBONPFB), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public class HCOENBONPFB : APDPPALGJBL, NDDDEAMKNGH, POKGICLLPAE, IJCLFGAEMDL, FKNGAHGHIJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CCLGGCIFAJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public LHNHCAPHDGO services;

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public CCLGGCIFAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DBF0", Offset = "0x5E1C9F0", VA = "0x185E1DBF0")]
		internal void OEFCNJGCNNM(IJCLFGAEMDL svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class ABLHDKHGFOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public LHNHCAPHDGO services;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ABLHDKHGFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5E1B730", Offset = "0x5E1A530", VA = "0x185E1B730")]
		internal void POJEABCFNEF(FKNGAHGHIJP svc)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	[MBPNJDODNHC]
	private ECLOMGLPHEH DIBBHMNKGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	[MBPNJDODNHC]
	private IHJBEAAMNEB IGNGKFHFNKM;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public CKLCFHIBNGJ EHJADIEJDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB00", Offset = "0x7DD900", VA = "0x1807DEB00", Slot = "4")]
		get
		{
			return default(CKLCFHIBNGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x5E29F30", Offset = "0x5E28D30", VA = "0x185E29F30", Slot = "5")]
	public void CAPMIKFGFII(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x5E29E10", Offset = "0x5E28C10", VA = "0x185E29E10", Slot = "6")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A0E0", Offset = "0x5E28EE0", VA = "0x185E2A0E0", Slot = "7")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A1C0", Offset = "0x5E28FC0", VA = "0x185E2A1C0", Slot = "8")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5E29FC0", Offset = "0x5E28DC0", VA = "0x185E29FC0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x23718E0", Offset = "0x23706E0", VA = "0x1823718E0")]
	private void NOIPAMJDMIP<T>(Action<T> PFOFEBMPOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HCOENBONPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[DefaultMember("Item")]
[LKMFAIPHKDB(typeof(FCEELEODMDI), new string[] { })]
public class HCJOLOMFMHL : FCEELEODMDI, IEnumerable<MDMHNBKGCGM>, IEnumerable, NDDDEAMKNGH, POKGICLLPAE, IJCLFGAEMDL, FKNGAHGHIJP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	[MBPNJDODNHC]
	private CGEIDIOBIMG EKODFEEOAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly Dictionary<(Type, string), int> LJGEDKAINBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private NativeBitArray MCBBCKADLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private NativeArray<int> HMMFJLNICIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private JPECEOLNNNA OHJGIJCOJAF;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public NativeBitArray DGOLIHEDBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD47AA0", VA = "0x180D48CA0", Slot = "4")]
		get
		{
			return default(NativeBitArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public NativeArray<int> NEEBFOINBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5E260", VA = "0x180D5F460", Slot = "5")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private int GCOMKNKLCMA
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x840D40", Offset = "0x83FB40", VA = "0x180840D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5E28F00", Offset = "0x5E27D00", VA = "0x185E28F00", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public MDMHNBKGCGM BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x5E28DF0", Offset = "0x5E27BF0", VA = "0x185E28DF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public MDMHNBKGCGM BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5E28DF0", Offset = "0x5E27BF0", VA = "0x185E28DF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x5E28DA0", Offset = "0x5E27BA0", VA = "0x185E28DA0", Slot = "13")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x5E28E80", Offset = "0x5E27C80", VA = "0x185E28E80", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "15")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5E29300", Offset = "0x5E28100", VA = "0x185E29300")]
	private void NOPBDLMLGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5E29150", Offset = "0x5E27F50", VA = "0x185E29150", Slot = "9")]
	public MDMHNBKGCGM LIEBIFDEGDP(FIAJLECAKMM COPMFEAGFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5E29C30", Offset = "0x5E28A30", VA = "0x185E29C30")]
	private bool PJHOAILPMGM(Type DICNFKPOPON, string ONIBECKLJDD, [Out] MDMHNBKGCGM BHGDMLDFEHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x5E28F20", Offset = "0x5E27D20", VA = "0x185E28F20", Slot = "10")]
	public KIBKAPDMHFC KOKNIMMMGEC(FIAJLECAKMM COPMFEAGFCB)
	{
		return default(KIBKAPDMHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x5E28E60", Offset = "0x5E27C60", VA = "0x185E28E60", Slot = "11")]
	public IEnumerator<MDMHNBKGCGM> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x5E28E60", Offset = "0x5E27C60", VA = "0x185E28E60", Slot = "12")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5E28E10", Offset = "0x5E27C10", VA = "0x185E28E10", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5E29D80", Offset = "0x5E28B80", VA = "0x185E29D80")]
	public HCJOLOMFMHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DefaultMember("Item")]
[LKMFAIPHKDB(typeof(KCJDDJBIGAA), new string[] { })]
public class MOAKOOOLIMB : KCJDDJBIGAA, IEnumerable<LPNKEHLCEHF>, IEnumerable, NDDDEAMKNGH, POKGICLLPAE, IJCLFGAEMDL, FKNGAHGHIJP, NIGHLJACFIF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	[MBPNJDODNHC]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[MBPNJDODNHC]
	private FCEELEODMDI PEEDPFPJBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private LPNKEHLCEHF[] EDPNPIPIFKE;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x5304AA0", Offset = "0x53038A0", VA = "0x185304AA0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public LPNKEHLCEHF BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x5E38120", Offset = "0x5E36F20", VA = "0x185E38120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "10")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5E38360", Offset = "0x5E37160", VA = "0x185E38360", Slot = "11")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "12")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5E38710", Offset = "0x5E37510", VA = "0x185E38710", Slot = "6")]
	public LPNKEHLCEHF LIEBIFDEGDP(FIAJLECAKMM COPMFEAGFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E38640", Offset = "0x5E37440", VA = "0x185E38640", Slot = "7")]
	public KIBKAPDMHFC KOKNIMMMGEC(FIAJLECAKMM COPMFEAGFCB)
	{
		return default(KIBKAPDMHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5E38280", Offset = "0x5E37080", VA = "0x185E38280", Slot = "8")]
	public IEnumerator<LPNKEHLCEHF> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E38830", Offset = "0x5E37630", VA = "0x185E38830", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x245A260", Offset = "0x2459060", VA = "0x18245A260", Slot = "13")]
	public void GFMLFOCOKCN<TKey, T>(BMNAKPOHAKD<TKey, T> GGCGADADFCH, [Optional] object GMNCNEPJHHN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E38150", Offset = "0x5E36F50", VA = "0x185E38150", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public MOAKOOOLIMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E38120", Offset = "0x5E36F20", VA = "0x185E38120")]
	[CompilerGenerated]
	private LPNKEHLCEHF LFIMAPKDCHH(int FJLKBMOCNHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[LKMFAIPHKDB(typeof(GALOHLLCPLH), new string[] { })]
[DefaultMember("Item")]
public class EMNMHDABLIG : GALOHLLCPLH, IEnumerable<OEEJKPJCCOP>, IEnumerable, IJCLFGAEMDL, FKNGAHGHIJP, NIGHLJACFIF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[MBPNJDODNHC]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[MBPNJDODNHC]
	private FCEELEODMDI PEEDPFPJBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private OEEJKPJCCOP[] EDPNPIPIFKE;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E215E0", Offset = "0x5E203E0", VA = "0x185E215E0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public OEEJKPJCCOP BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E21110", Offset = "0x5E1FF10", VA = "0x185E21110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E212D0", Offset = "0x5E200D0", VA = "0x185E212D0", Slot = "10")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E21340", Offset = "0x5E20140", VA = "0x185E21340", Slot = "11")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E21820", Offset = "0x5E20620", VA = "0x185E21820")]
	private OEEJKPJCCOP NINENOPLAKC(int DOJILIOCHKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E21700", Offset = "0x5E20500", VA = "0x185E21700", Slot = "6")]
	public OEEJKPJCCOP LIEBIFDEGDP(FIAJLECAKMM COPMFEAGFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E21630", Offset = "0x5E20430", VA = "0x185E21630", Slot = "7")]
	public KIBKAPDMHFC KOKNIMMMGEC(FIAJLECAKMM COPMFEAGFCB)
	{
		return default(KIBKAPDMHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E211C0", Offset = "0x5E1FFC0", VA = "0x185E211C0", Slot = "8")]
	public IEnumerator<OEEJKPJCCOP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E211C0", Offset = "0x5E1FFC0", VA = "0x185E211C0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x2218290", Offset = "0x2217090", VA = "0x182218290", Slot = "12")]
	public void GFMLFOCOKCN<TKey, T>(BMNAKPOHAKD<TKey, T> GGCGADADFCH, [Optional] object GMNCNEPJHHN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E21120", Offset = "0x5E1FF20", VA = "0x185E21120", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public EMNMHDABLIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E21110", Offset = "0x5E1FF10", VA = "0x185E21110")]
	[CompilerGenerated]
	private OEEJKPJCCOP LFIMAPKDCHH(int FJLKBMOCNHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[LKMFAIPHKDB(typeof(CGEIDIOBIMG), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal class CGEIDIOBIMG : IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private FCEELEODMDI PEEDPFPJBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private GALOHLLCPLH LEPKALEHGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private KCJDDJBIGAA KJCLGBIHPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[MBPNJDODNHC]
	private IHJBEAAMNEB IGNGKFHFNKM;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public JPECEOLNNNA DMCDJFBBHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x76B130", Offset = "0x769F30", VA = "0x18076B130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E190", Offset = "0x5E1CF90", VA = "0x185E1E190", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E2E0", Offset = "0x5E1D0E0", VA = "0x185E1E2E0")]
	private void KNEDFBOJPHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E0C0", Offset = "0x5E1CEC0", VA = "0x185E1E0C0")]
	public MDMHNBKGCGM CDLJMDGKCPO(FIAJLECAKMM ONIBECKLJDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x21CBDA0", Offset = "0x21CABA0", VA = "0x1821CBDA0")]
	public MLBEOODPNHF<T> KEANLOMPLLB<T>(FIAJLECAKMM ONIBECKLJDD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public CGEIDIOBIMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal static class NCHLLCJGALC
{
	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x24BCE80", Offset = "0x24BBC80", VA = "0x1824BCE80")]
	public static CMIFDPMNHCO<T> CDLJMDGKCPO<T>(this CGEIDIOBIMG BIBCBJNKKOD, DKCNFDOHIPC<T> ONIBECKLJDD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(BOGMJJODDAE), new string[] { })]
public class BOGMJJODDAE : POKGICLLPAE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	[MBPNJDODNHC]
	private LGMAMHNDHAH HGJMOLFPFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private bool EDKGNNKEKHG;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public TimeData CJPOLAFDMCF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DA90", Offset = "0x5E1C890", VA = "0x185E1DA90")]
		get
		{
			return default(TimeData);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E1DB00", Offset = "0x5E1C900", VA = "0x185E1DB00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool CEAPPBPCEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BF0", Offset = "0x7CF9F0", VA = "0x1807D0BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0xB81DE0", Offset = "0xB80BE0", VA = "0x180B81DE0", Slot = "4")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E1DA40", Offset = "0x5E1C840", VA = "0x185E1DA40", Slot = "5")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E1D9A0", Offset = "0x5E1C7A0", VA = "0x185E1D9A0")]
	public void GCEIODDNBLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	[Conditional("UNITY_DOTS_DEBUG")]
	public void MJDHFFNIJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BOGMJJODDAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(BDMEKDJBKEP), new string[] { })]
public class BDMEKDJBKEP : IJCLFGAEMDL, FKNGAHGHIJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private HDEKOHKCIPA JPFJLMHLIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private KCJDDJBIGAA EKODFEEOAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private KIBKAPDMHFC[] NCDBOJJBMNB;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C200", Offset = "0x5E1B000", VA = "0x185E1C200", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C390", Offset = "0x5E1B190", VA = "0x185E1C390", Slot = "5")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E1C270", Offset = "0x5E1B070", VA = "0x185E1C270")]
	public void JFNOAKJCCHP(DJMPNJEFEHC IELEJBMANDO, bool FOFHNEBBKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BDMEKDJBKEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[LKMFAIPHKDB(typeof(JDAEBEPDJOB), new string[] { })]
public sealed class OKIFKMNMAEK : JDAEBEPDJOB, NDDDEAMKNGH, POKGICLLPAE, IJCLFGAEMDL, FKNGAHGHIJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class HFAHDGLGBKL : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x955D30", Offset = "0x954B30", VA = "0x180955D30", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E2A590", Offset = "0x5E29390", VA = "0x185E2A590", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x1B32A80", Offset = "0x1B31880", VA = "0x181B32A80")]
		[DebuggerHidden]
		public HFAHDGLGBKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A2A0", Offset = "0x5E290A0", VA = "0x185E2A2A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A540", Offset = "0x5E29340", VA = "0x185E2A540", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A490", Offset = "0x5E29290", VA = "0x185E2A490", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A490", Offset = "0x5E29290", VA = "0x185E2A490", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	[MBPNJDODNHC]
	private GALOHLLCPLH EKODFEEOAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly FLDPNFONGFG OGKLFPONHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly Dictionary<string, AHFEJKCJGNP> MPIJMKLLOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Dictionary<int, AABJKBCCJJP> IKFGFPLHDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly List<OEEJKPJCCOP> FEGJNNJPFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private AELOEGFEFHM JADKMGFABGI;

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public AABJKBCCJJP CDHOKCCMLEK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E393C0", Offset = "0x5E381C0", VA = "0x185E393C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public List<OEEJKPJCCOP> BNHHNNINPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "9")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E39BB0", Offset = "0x5E389B0", VA = "0x185E39BB0", Slot = "10")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E39CC0", Offset = "0x5E38AC0", VA = "0x185E39CC0", Slot = "11")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E39750", Offset = "0x5E38550", VA = "0x185E39750", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E39860", Offset = "0x5E38660", VA = "0x185E39860", Slot = "6")]
	public bool IJLNDIHIHKI(OEEJKPJCCOP GGCGADADFCH, [Out] AABJKBCCJJP EODEKLAMAOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A060", Offset = "0x5E38E60", VA = "0x185E3A060")]
	private void NLKEEDCBOML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E395A0", Offset = "0x5E383A0", VA = "0x185E395A0")]
	private void CGPOOBBDLBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E39800", Offset = "0x5E38600", VA = "0x185E39800")]
	private AHFEJKCJGNP ENBIOFEIFFH(string BMOEKFBAJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E393C0", Offset = "0x5E381C0", VA = "0x185E393C0")]
	private AHFEJKCJGNP BEACBIICJCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E398F0", Offset = "0x5E386F0", VA = "0x185E398F0")]
	private AHFEJKCJGNP IMFENIEHJPE(string BMOEKFBAJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A440", Offset = "0x5E39240", VA = "0x185E3A440")]
	private AHFEJKCJGNP POGOKGCFCGB(string GKNFKOKBKMK, string PFKLELGAJPH, [Optional] AHFEJKCJGNP DIIEMNCLHFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E39D70", Offset = "0x5E38B70", VA = "0x185E39D70")]
	[IteratorStateMachine(typeof(HFAHDGLGBKL))]
	private IEnumerable<(string, string)> JPEOKCMECKL(string BMOEKFBAJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E39D20", Offset = "0x5E38B20", VA = "0x185E39D20")]
	private bool JLNGHPEIOFL(OEEJKPJCCOP GGCGADADFCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E39F30", Offset = "0x5E38D30", VA = "0x185E39F30")]
	private FLDPNFONGFG MIFAGEHOALA(OEEJKPJCCOP GGCGADADFCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A010", Offset = "0x5E38E10", VA = "0x185E3A010")]
	private FLDPNFONGFG NEDBAKFHJGB(OEEJKPJCCOP GGCGADADFCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E39420", Offset = "0x5E38220", VA = "0x185E39420")]
	private FLDPNFONGFG BGEBCLJBHNA(OEEJKPJCCOP GGCGADADFCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x24F6640", Offset = "0x24F5440", VA = "0x1824F6640")]
	private T OCJEOEGONBJ<T>(OEEJKPJCCOP GGCGADADFCH) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E394B0", Offset = "0x5E382B0", VA = "0x185E394B0")]
	private FieldInfo BMAEALGOCGB(OEEJKPJCCOP GGCGADADFCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E39E80", Offset = "0x5E38C80", VA = "0x185E39E80", Slot = "7")]
	public void MCJJKKHGDCC(OEEJKPJCCOP GGCGADADFCH, CBFDMKOCAMK JGGDOEKFOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E39C10", Offset = "0x5E38A10", VA = "0x185E39C10", Slot = "8")]
	public void JKGGMKNLLFM(OEEJKPJCCOP GGCGADADFCH, CBFDMKOCAMK JGGDOEKFOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A630", Offset = "0x5E39430", VA = "0x185E3A630")]
	public OKIFKMNMAEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E39DF0", Offset = "0x5E38BF0", VA = "0x185E39DF0")]
	[CompilerGenerated]
	private int MADAJLJGGME(OEEJKPJCCOP MACGGKMNKNM, OEEJKPJCCOP JHKDDIMPPGN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class AHFEJKCJGNP : AABJKBCCJJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public readonly string COHKBPEJOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public readonly AHFEJKCJGNP DIIEMNCLHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public readonly List<AHFEJKCJGNP> CBAFGLLABBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public readonly List<OEEJKPJCCOP> EKODFEEOAPM;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public string CPAAHMIJEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public AABJKBCCJJP GLPBCJEELBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public IEnumerable<AABJKBCCJJP> JAPDKOPAOPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E1B7D0", Offset = "0x5E1A5D0", VA = "0x185E1B7D0")]
	public AHFEJKCJGNP(string ONIBECKLJDD, AHFEJKCJGNP LBLLNFOEKNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[LKMFAIPHKDB(typeof(global::GCDKFGEHHBL), new string[] { })]
internal class DANPLFGALBO : global::GCDKFGEHHBL, IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	[MBPNJDODNHC]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	[MBPNJDODNHC]
	private CJNOCCAJLJM IAMHOIOBMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	[MBPNJDODNHC]
	private CGEIDIOBIMG EKODFEEOAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	[MBPNJDODNHC]
	private AELOEGFEFHM EILPDJCOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private Action<POEBJJFCPOJ> MEKLMIFMFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private CMIFDPMNHCO<Entity> LBLLNFOEKNE;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<POEBJJFCPOJ> DCJMCAACAJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E4F0", Offset = "0x5E1D2F0", VA = "0x185E1E4F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E1E380", Offset = "0x5E1D180", VA = "0x185E1E380", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E780", Offset = "0x5E1D580", VA = "0x185E1E780", Slot = "6")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E670", Offset = "0x5E1D470", VA = "0x185E1E670", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E4F0", Offset = "0x5E1D2F0", VA = "0x185E1E4F0")]
	private void AKPBDFKEHNP(Action<POEBJJFCPOJ> GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E380", Offset = "0x5E1D180", VA = "0x185E1E380")]
	private void AJOBBNDMMNE(Action<POEBJJFCPOJ> GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E1E8C0", Offset = "0x5E1D6C0", VA = "0x185E1E8C0")]
	private void OKPKMACENKE(FKIAGMFJAHK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DANPLFGALBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
[LKMFAIPHKDB(typeof(NKPDGCNJLED), new string[] { })]
public class NKPDGCNJLED : IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	[MBPNJDODNHC]
	private DLKMEGGCFLP MDHNFJOCHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[MBPNJDODNHC]
	private PDKDJEHAOAJ FFALNFCDHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[MBPNJDODNHC]
	private OPNGBJLAHIJ AIMIPJFKDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	[MBPNJDODNHC]
	private GNJPLCKBNJA MENCLGMKPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E39210", Offset = "0x5E38010", VA = "0x185E39210", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E390E0", Offset = "0x5E37EE0", VA = "0x185E390E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E39130", Offset = "0x5E37F30", VA = "0x185E39130")]
	private void GDGADFLAIHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E390E0", Offset = "0x5E37EE0", VA = "0x185E390E0")]
	private void PCOPKDJHBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E391C0", Offset = "0x5E37FC0", VA = "0x185E391C0")]
	private void GNHIFEGKCIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public NKPDGCNJLED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[LKMFAIPHKDB(typeof(KHOPPHCEAEP), new string[] { })]
public class FEIIFOCCGGL : KHOPPHCEAEP, IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[MBPNJDODNHC]
	private IKBNJJBMJGF OHBJBALPNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[MBPNJDODNHC]
	private AEONNHMKDNI PMOGFFGKDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly List<NativeListAsync<Entity>> DLHJLCIPGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly List<(NativeListAsync<Entity>, bool)> AFFCFBMJLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private ECDFNMEFCMB IGCLMELEMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private Dictionary<Entity, HIPJNBHFBBL> BCAOEEAGGPB;

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E23B80", Offset = "0x5E22980", VA = "0x185E23B80", Slot = "8")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E23AB0", Offset = "0x5E228B0", VA = "0x185E23AB0", Slot = "4")]
	public void IOJBEJCIBEJ(NativeListAsync<Entity> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E23BF0", Offset = "0x5E229F0", VA = "0x185E23BF0", Slot = "5")]
	public void KGPPCNDIJJH(ECDFNMEFCMB IGCLMELEMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E22F20", Offset = "0x5E21D20", VA = "0x185E22F20", Slot = "6")]
	public void AKJCGIACOLB(NativeListAsync<Entity> PFOPLIKJCHB, bool MJPIEFIOAEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E23050", Offset = "0x5E21E50", VA = "0x185E23050", Slot = "7")]
	public void BFAHPPJFBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5E233D0", Offset = "0x5E221D0", VA = "0x185E233D0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5E23C40", Offset = "0x5E22A40", VA = "0x185E23C40")]
	private int LKHDJFDBBJJ(NativeListAsync<Entity> DLHJLCIPGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5E23E80", Offset = "0x5E22C80", VA = "0x185E23E80")]
	private int NGMJGFPJLED()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5E23860", Offset = "0x5E22660", VA = "0x185E23860")]
	private int FEFFCHDIFMO(NativeListAsync<Entity> AFFCFBMJLIC, bool EEGCEDGCFFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5E24180", Offset = "0x5E22F80", VA = "0x185E24180")]
	public FEIIFOCCGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5E23A80", Offset = "0x5E22880", VA = "0x185E23A80")]
	[CompilerGenerated]
	private JBMJEBCFLLB FOCOIDNHFFI(Entity CCHOHIEEHEH)
	{
		return default(JBMJEBCFLLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[LKMFAIPHKDB(typeof(HOPJJNIFNBD), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public class HOPJJNIFNBD : IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly List<NativeListAsync<LGOKMKLDMLD>> PBEEENJPJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A7E0", Offset = "0x5E295E0", VA = "0x185E2A7E0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A830", Offset = "0x5E29630", VA = "0x185E2A830")]
	public void KHOENHHDAAD(NativeListAsync<LGOKMKLDMLD> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A900", Offset = "0x5E29700", VA = "0x185E2A900")]
	public void POPOGBCAJBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A660", Offset = "0x5E29460", VA = "0x185E2A660", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AD90", Offset = "0x5E29B90", VA = "0x185E2AD90")]
	public HOPJJNIFNBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[LKMFAIPHKDB(typeof(HKANIBGKHCE), new string[] { })]
public class ALHMNCEHDIN : IJCLFGAEMDL, HKANIBGKHCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private EntityManager FMCNCDMBJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private EPMCOHFCLHA NDJADLFMBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private AEONNHMKDNI PMOGFFGKDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BD60", Offset = "0x5E1AB60", VA = "0x185E1BD60", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BC40", Offset = "0x5E1AA40", VA = "0x185E1BC40", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BFF0", Offset = "0x5E1ADF0", VA = "0x185E1BFF0", Slot = "5")]
	public bool NCIKCPMABBB(JBMJEBCFLLB OGPPAJOCABK, [Out] Collider BHBBEPIOBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BE30", Offset = "0x5E1AC30", VA = "0x185E1BE30", Slot = "6")]
	public GameObject KNHDBGFOBBD(JBMJEBCFLLB HGOOKKDMMIH, GameObject IHGMHOAKNLL, Vector3 ELHIODNHAHA, Quaternion FIIPDOPILCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BC50", Offset = "0x5E1AA50", VA = "0x185E1BC50", Slot = "7")]
	public void IKCIMMEEIKI(GameObject BHBBEPIOBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x29B4C90", Offset = "0x29B3A90", VA = "0x1829B4C90", Slot = "8")]
	public TCollider HFEDKOEAPCG<TCollider>(GameObject HLPGFBKAPLH) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x5E1BB70", Offset = "0x5E1A970", VA = "0x185E1BB70", Slot = "9")]
	public void BINICBPEPPD(Collider BHBBEPIOBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x29B4C90", Offset = "0x29B3A90", VA = "0x1829B4C90", Slot = "10")]
	public GameObject PMOPNLJDGAA<TCollider>(string ONIBECKLJDD) where TCollider : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public ALHMNCEHDIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[LKMFAIPHKDB(typeof(BGJEPDMMNIC), new string[] { })]
public class JKNKJCLBCBF : IJCLFGAEMDL, BGJEPDMMNIC
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class CICFIMKJLMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public JBMJEBCFLLB localId;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public CICFIMKJLMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x5E45530", Offset = "0x5E44330", VA = "0x185E45530")]
		internal object LMNABECDEMB(JKNKJCLBCBF a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class NEJHOPDECKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public JBMJEBCFLLB localId;

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public NEJHOPDECKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x5E571B0", Offset = "0x5E55FB0", VA = "0x185E571B0")]
		internal object IDPCBMONGME(JKNKJCLBCBF a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private JNPLIBJDOGK HJDMFCAGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private World GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private CGGDHOPMPPP CBFDDFCILBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	[MBPNJDODNHC]
	private LGMAMHNDHAH HGJMOLFPFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private EntityManager CNBNANJMIGO;

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F120", Offset = "0x5E2DF20", VA = "0x185E2F120", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E290", Offset = "0x5E2D090", VA = "0x185E2E290", Slot = "6")]
	public HDDDKCEGLNC FFBBHAGPCMO(JBMJEBCFLLB OGPPAJOCABK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FD80", Offset = "0x5E2EB80", VA = "0x185E2FD80", Slot = "5")]
	public void MFILNGPPBFG(JBMJEBCFLLB OGPPAJOCABK, HDDDKCEGLNC GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F860", Offset = "0x5E2E660", VA = "0x185E2F860", Slot = "31")]
	public CollisionDetectionMode LCCENIFADAO(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(CollisionDetectionMode);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EDF0", Offset = "0x5E2DBF0", VA = "0x185E2EDF0", Slot = "32")]
	public void IIEAFLGOFCN(JBMJEBCFLLB OGPPAJOCABK, CollisionDetectionMode GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F2A0", Offset = "0x5E2E0A0", VA = "0x185E2F2A0", Slot = "33")]
	public EPMFMHNHMEG JLJFAEGNKHM(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(EPMFMHNHMEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E770", Offset = "0x5E2D570", VA = "0x185E2E770", Slot = "34")]
	public void HBMMNFDPAIH(JBMJEBCFLLB OGPPAJOCABK, EPMFMHNHMEG GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DEF0", Offset = "0x5E2CCF0", VA = "0x185E2DEF0", Slot = "35")]
	public bool EDNFLGOKNHC(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DC70", Offset = "0x5E2CA70", VA = "0x185E2DC70", Slot = "36")]
	public void DLHKNJKHKLB(JBMJEBCFLLB OGPPAJOCABK, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DCE0", Offset = "0x5E2CAE0", VA = "0x185E2DCE0", Slot = "37")]
	public JBMJEBCFLLB DLNLOPFGNBL(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E150", Offset = "0x5E2CF50", VA = "0x185E2E150", Slot = "38")]
	public void EPBCEIHCGLA(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DBD0", Offset = "0x5E2C9D0", VA = "0x185E2DBD0", Slot = "39")]
	public JBMJEBCFLLB DGLCEEOLIGB(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E8C0", Offset = "0x5E2D6C0", VA = "0x185E2E8C0", Slot = "40")]
	public void HDGBCFAMPCN(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E960", Offset = "0x5E2D760", VA = "0x185E2E960", Slot = "7")]
	public void HHIIPGJELHJ(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5E307B0", Offset = "0x5E2F5B0", VA = "0x185E307B0", Slot = "8")]
	public void OHPPCLKLOPE(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5E2ED20", Offset = "0x5E2DB20", VA = "0x185E2ED20", Slot = "9")]
	public int IHHGAJPDPHK(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F680", Offset = "0x5E2E480", VA = "0x185E2F680", Slot = "10")]
	public JBMJEBCFLLB KNHMBBGLEOH(JBMJEBCFLLB OGPPAJOCABK, int DOJILIOCHKM)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E080", Offset = "0x5E2CE80", VA = "0x185E2E080", Slot = "11")]
	public void EOGBCPCBPOK(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D950", Offset = "0x5E2C750", VA = "0x185E2D950", Slot = "12")]
	public void CHDCKKAABMF(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH, JBMJEBCFLLB GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DB40", Offset = "0x5E2C940", VA = "0x185E2DB40", Slot = "13")]
	public void DBDEMJAPOPA(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x5E302D0", Offset = "0x5E2F0D0", VA = "0x185E302D0", Slot = "14")]
	public bool NIICEMMGANB(JBMJEBCFLLB OGPPAJOCABK, [Out] JBMJEBCFLLB GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E820", Offset = "0x5E2D620", VA = "0x185E2E820", Slot = "15")]
	public void HDBFHOEDAPD(JBMJEBCFLLB OGPPAJOCABK, float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EBC0", Offset = "0x5E2D9C0", VA = "0x185E2EBC0", Slot = "16")]
	public bool IFDDAHGKLGG(JBMJEBCFLLB OGPPAJOCABK, [Out] float3 GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FBD0", Offset = "0x5E2E9D0", VA = "0x185E2FBD0", Slot = "17")]
	public void MCKINOAFOEM(JBMJEBCFLLB OGPPAJOCABK, float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FA70", Offset = "0x5E2E870", VA = "0x185E2FA70", Slot = "18")]
	public bool MCKFBGDGNMI(JBMJEBCFLLB OGPPAJOCABK, [Out] float3 GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FC70", Offset = "0x5E2EA70", VA = "0x185E2FC70", Slot = "23")]
	[Obsolete("Use SetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	public float3 MFGLGFDGIJH(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D350", Offset = "0x5E2C150", VA = "0x185E2D350", Slot = "24")]
	public float3 ACLMLIIAFGO(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E1F0", Offset = "0x5E2CFF0", VA = "0x185E2E1F0", Slot = "25")]
	public void FBJBEDNFGNF(JBMJEBCFLLB OGPPAJOCABK, float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DAA0", Offset = "0x5E2C8A0", VA = "0x185E2DAA0", Slot = "26")]
	public void DAHLMAOKMDD(JBMJEBCFLLB OGPPAJOCABK, float3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5E305B0", Offset = "0x5E2F3B0", VA = "0x185E305B0", Slot = "27")]
	[Obsolete("Use GetMassOfSelf or TryGetMassOfHierarchy")]
	public float OCHPILIKBCO(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E000", Offset = "0x5E2CE00", VA = "0x185E2E000", Slot = "28")]
	public float EJENFJGAEBA(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EAB0", Offset = "0x5E2D8B0", VA = "0x185E2EAB0", Slot = "29")]
	public void ICLAJDHLMGP(JBMJEBCFLLB OGPPAJOCABK, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F9E0", Offset = "0x5E2E7E0", VA = "0x185E2F9E0", Slot = "30")]
	public void LPLKODMKIHI(JBMJEBCFLLB OGPPAJOCABK, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D7C0", Offset = "0x5E2C5C0", VA = "0x185E2D7C0", Slot = "19")]
	public void CBOJPAHDILH(JBMJEBCFLLB OGPPAJOCABK, (Quaternion rot, Vector3 moments) IGICCOJIDDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FFF0", Offset = "0x5E2EDF0", VA = "0x185E2FFF0", Slot = "20")]
	public bool MNFEAKNJFHC(JBMJEBCFLLB OGPPAJOCABK, [Out] quaternion KAHMHDLHHJI, [Out] float3 KAGPJIKKGFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x5E30410", Offset = "0x5E2F210", VA = "0x185E30410", Slot = "41")]
	public GOIKPLFAGFM NKEAAKLJPDG(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(GOIKPLFAGFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F4F0", Offset = "0x5E2E2F0", VA = "0x185E2F4F0", Slot = "42")]
	public void KHODBMHLJAC(JBMJEBCFLLB OGPPAJOCABK, GOIKPLFAGFM GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F380", Offset = "0x5E2E180", VA = "0x185E2F380", Slot = "66")]
	public void JOGDLGNCAEP(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E530", Offset = "0x5E2D330", VA = "0x185E2E530", Slot = "67")]
	public void GFBLKJEIEFM(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D2E0", Offset = "0x5E2C0E0", VA = "0x185E2D2E0", Slot = "68")]
	public bool ACKBBILJDDB(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DDF0", Offset = "0x5E2CBF0", VA = "0x185E2DDF0", Slot = "82")]
	public bool EAAEJMCMHOM(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5E2FE40", Offset = "0x5E2EC40", VA = "0x185E2FE40", Slot = "83")]
	public void MJKFFEJNBJC(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH, bool JJIMCKPIKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F970", Offset = "0x5E2E770", VA = "0x185E2F970", Slot = "84")]
	public void LIKNGICEEOK(JBMJEBCFLLB OGPPAJOCABK, bool FMIANILELJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F400", Offset = "0x5E2E200", VA = "0x185E2F400", Slot = "86")]
	public bool KFOAKOCCFBA(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E440", Offset = "0x5E2D240", VA = "0x185E2E440", Slot = "85")]
	public void GEFOBJBPKGJ(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EB40", Offset = "0x5E2D940", VA = "0x185E2EB40", Slot = "43")]
	public bool IDKCKGIDLIN(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x5E30A80", Offset = "0x5E2F880", VA = "0x185E30A80", Slot = "44")]
	public void PJNJLGILILP(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F0A0", Offset = "0x5E2DEA0", VA = "0x185E2F0A0", Slot = "45")]
	public bool IPJPBJEDKGG(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E700", Offset = "0x5E2D500", VA = "0x185E2E700", Slot = "46")]
	public void HBEGPADBLCH(JBMJEBCFLLB OGPPAJOCABK, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D570", Offset = "0x5E2C370", VA = "0x185E2D570", Slot = "47")]
	public bool BGCJGOFELNA(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EA40", Offset = "0x5E2D840", VA = "0x185E2EA40", Slot = "48")]
	public void HLBHNEKDGMC(JBMJEBCFLLB OGPPAJOCABK, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F7E0", Offset = "0x5E2E5E0", VA = "0x185E2F7E0", Slot = "49")]
	public RigidbodyConstraints KOPNCGOHOFJ(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(RigidbodyConstraints);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x5E30520", Offset = "0x5E2F320", VA = "0x185E30520", Slot = "50")]
	public void NPCAPKJGFCJ(JBMJEBCFLLB OGPPAJOCABK, RigidbodyConstraints GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x5E306A0", Offset = "0x5E2F4A0", VA = "0x185E306A0", Slot = "51")]
	public float ODPHGDNALHH(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E5C0", Offset = "0x5E2D3C0", VA = "0x185E2E5C0", Slot = "52")]
	public void GJPAFEMHBDN(JBMJEBCFLLB OGPPAJOCABK, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5E30990", Offset = "0x5E2F790", VA = "0x185E30990", Slot = "53")]
	public float PANAOACOLNK(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F8E0", Offset = "0x5E2E6E0", VA = "0x185E2F8E0", Slot = "54")]
	public void LGOCOEBFKFF(JBMJEBCFLLB OGPPAJOCABK, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E4B0", Offset = "0x5E2D2B0", VA = "0x185E2E4B0", Slot = "55")]
	public bool GEGFMJAIJPE(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F030", Offset = "0x5E2DE30", VA = "0x185E2F030", Slot = "56")]
	public void ILOOOMLDBEO(JBMJEBCFLLB OGPPAJOCABK, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D4F0", Offset = "0x5E2C2F0", VA = "0x185E2D4F0", Slot = "57")]
	public bool BBMOMJNHBHH(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DD80", Offset = "0x5E2CB80", VA = "0x185E2DD80", Slot = "58")]
	public void DNPPNLAIBNC(JBMJEBCFLLB OGPPAJOCABK, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E3B0", Offset = "0x5E2D1B0", VA = "0x185E2E3B0", Slot = "59")]
	public void GEDCBIHGDPP(JBMJEBCFLLB OGPPAJOCABK, int GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x5E30490", Offset = "0x5E2F290", VA = "0x185E30490", Slot = "73")]
	public Rigidbody NLPINAOPGDP(JBMJEBCFLLB OGPPAJOCABK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D190", Offset = "0x5E2BF90", VA = "0x185E2D190", Slot = "74")]
	public void ABIAFIMBDJA(JBMJEBCFLLB OGPPAJOCABK, Rigidbody GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x5E30890", Offset = "0x5E2F690", VA = "0x185E30890", Slot = "75")]
	public void OJJAOMJIFMM(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EE80", Offset = "0x5E2DC80", VA = "0x185E2EE80", Slot = "76")]
	public void IIIGLEPLPKA(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x5E30A10", Offset = "0x5E2F810", VA = "0x185E30A10", Slot = "77")]
	public bool PJILPBKDMPC(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DF70", Offset = "0x5E2CD70", VA = "0x185E2DF70", Slot = "60")]
	public object EHHMEDBDPLI(JBMJEBCFLLB OGPPAJOCABK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D040", Offset = "0x5E2BE40", VA = "0x185E2D040", Slot = "61")]
	public void ABBODHLOGKM(JBMJEBCFLLB OGPPAJOCABK, object GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x5E301F0", Offset = "0x5E2EFF0", VA = "0x185E301F0", Slot = "62")]
	public object NBMOFDBLGLI(JBMJEBCFLLB OGPPAJOCABK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D670", Offset = "0x5E2C470", VA = "0x185E2D670", Slot = "63")]
	public void BPJKJNFMDJM(JBMJEBCFLLB OGPPAJOCABK, object GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x5E30910", Offset = "0x5E2F710", VA = "0x185E30910", Slot = "64")]
	public float ONABKFMFIBK(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x5E30720", Offset = "0x5E2F520", VA = "0x185E30720", Slot = "65")]
	public void OFGOENDFDNK(JBMJEBCFLLB OGPPAJOCABK, float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F470", Offset = "0x5E2E270", VA = "0x185E2F470", Slot = "69")]
	public void KFPPLJOFDCN(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E320", Offset = "0x5E2D120", VA = "0x185E2E320", Slot = "70")]
	public void FPKHDIIMCPG(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EFC0", Offset = "0x5E2DDC0", VA = "0x185E2EFC0", Slot = "71")]
	public bool IJANIGIKMNH(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F240", Offset = "0x5E2E040", VA = "0x185E2F240", Slot = "21")]
	public void JHCFJLKEMGJ(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F780", Offset = "0x5E2E580", VA = "0x185E2F780", Slot = "22")]
	public void KNKCNKEADAA(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D5F0", Offset = "0x5E2C3F0", VA = "0x185E2D5F0", Slot = "72")]
	public bool BIMHFMBDNAG(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D3F0", Offset = "0x5E2C1F0", VA = "0x185E2D3F0", Slot = "78")]
	public void APFKKFNNHGI(JBMJEBCFLLB OGPPAJOCABK, float3 HPJBBHHJIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F580", Offset = "0x5E2E380", VA = "0x185E2F580", Slot = "79")]
	public void KJACOMCANHP(JBMJEBCFLLB OGPPAJOCABK, float3 LMHADGEOOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x5E2DA50", Offset = "0x5E2C850", VA = "0x185E2DA50", Slot = "80")]
	public bool CHLCDOHAEFA(JBMJEBCFLLB OGPPAJOCABK, [Out] float3 HPJBBHHJIEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0x5E30280", Offset = "0x5E2F080", VA = "0x185E30280", Slot = "81")]
	public bool NCJFEGIOHHB(JBMJEBCFLLB OGPPAJOCABK, [Out] float3 LMHADGEOOGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E650", Offset = "0x5E2D450", VA = "0x185E2E650")]
	private DynamicBuffer<Entity> GLDDHDNLJFD(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EF10", Offset = "0x5E2DD10", VA = "0x185E2EF10")]
	private DynamicBuffer<Entity> IIKHGPFELEB(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(DynamicBuffer<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x23C8C10", Offset = "0x23C7A10", VA = "0x1823C8C10")]
	private void KBCMOEAPIIO<T>(JBMJEBCFLLB OGPPAJOCABK, object GNLEHBFFNFG, Func<object, T> ALNJMFCGDFM) where T : class, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public JKNKJCLBCBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
[LKMFAIPHKDB(typeof(GDEJBPMFJOE), new string[] { })]
public class GDEJBPMFJOE : IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class EBALMBPOLHK : IEnumerable<HDDDKCEGLNC>, IEnumerable, IEnumerator<HDDDKCEGLNC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private HDDDKCEGLNC <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public GDEJBPMFJOE <>4__this;

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
		private HDDDKCEGLNC System.Collections.Generic.IEnumerator<RecRoom.Rbex.IOMRigidbodyExImpl>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x863A90", Offset = "0x862890", VA = "0x180863A90")]
		[DebuggerHidden]
		public EBALMBPOLHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5E47990", Offset = "0x5E46790", VA = "0x185E47990", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5E47660", Offset = "0x5E46460", VA = "0x185E47660", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x5E47610", Offset = "0x5E46410", VA = "0x185E47610")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x5E47940", Offset = "0x5E46740", VA = "0x185E47940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x5E47890", Offset = "0x5E46690", VA = "0x185E47890", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HDDDKCEGLNC> System.Collections.Generic.IEnumerable<RecRoom.Rbex.IOMRigidbodyExImpl>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5E47890", Offset = "0x5E46690", VA = "0x185E47890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly List<(NativeArray<Entity> entities, bool awake, bool hasRigidbody)> JCLLBICMGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x5E49AB0", Offset = "0x5E488B0", VA = "0x185E49AB0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x5E49B00", Offset = "0x5E48900", VA = "0x185E49B00")]
	public void KHOENHHDAAD(NativeArray<Entity> PFOPLIKJCHB, bool PMKCOIKGKHH, bool AIMLOELNFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A500", Offset = "0x5E49300", VA = "0x185E4A500")]
	public void POPOGBCAJBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5E49CF0", Offset = "0x5E48AF0", VA = "0x185E49CF0")]
	private void OPJKBGELCCO(NativeArray<Entity> PFOPLIKJCHB, bool PMKCOIKGKHH, bool AIMLOELNFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x5E49C60", Offset = "0x5E48A60", VA = "0x185E49C60")]
	[IteratorStateMachine(typeof(EBALMBPOLHK))]
	private IEnumerable<HDDDKCEGLNC> NHNFHPKDEBO(NativeArray<Entity> PFOPLIKJCHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x5E49940", Offset = "0x5E48740", VA = "0x185E49940", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A7D0", Offset = "0x5E495D0", VA = "0x185E4A7D0")]
	public GDEJBPMFJOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[LKMFAIPHKDB(typeof(GKJLLKLKGFO), new string[] { })]
public class JNDHCABOBAD : GKJLLKLKGFO, IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class AFKFACHBLPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public List<CapsuleCollider> POJEOCGHIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public List<SphereCollider> FCFFKLPKPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public GameObject BJIONNNACJE;

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x5E41380", Offset = "0x5E40180", VA = "0x185E41380")]
		public AFKFACHBLPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	[MBPNJDODNHC]
	private IKBNJJBMJGF OHBJBALPNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	[MBPNJDODNHC]
	private HKANIBGKHCE BIEFBJNEMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<Entity, AFKFACHBLPO> COPOOJOCBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private GameObject GKENKGLPCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private GameObject KPKCEMPBKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private GameObject OHHJOIIKDCK;

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private GameObject MJOBPMEKHJA
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x5E50C70", Offset = "0x5E4FA70", VA = "0x185E50C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FED0", Offset = "0x5E4ECD0", VA = "0x185E4FED0", Slot = "6")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F0E0", Offset = "0x5E4DEE0", VA = "0x185E4F0E0", Slot = "4")]
	public void DADOKLAAMEJ(Entity INDGKNGOKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F980", Offset = "0x5E4E780", VA = "0x185E4F980", Slot = "5")]
	public void IJKIMAFKFIK(Entity INDGKNGOKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F320", Offset = "0x5E4E120", VA = "0x185E4F320", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F440", Offset = "0x5E4E240", VA = "0x185E4F440")]
	private AFKFACHBLPO EDNJGBBFIIB(Entity INDGKNGOKKL, PAEMMLCLHJM PPEPGBPKJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x5E50120", Offset = "0x5E4EF20", VA = "0x185E50120")]
	private void NGGENAACOKL(PAEMMLCLHJM PPEPGBPKJPK, AFKFACHBLPO DMGIABMMKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x5E4FF40", Offset = "0x5E4ED40", VA = "0x185E4FF40")]
	private void MFKGKGPBKEH(PAEMMLCLHJM PPEPGBPKJPK, AFKFACHBLPO DMGIABMMKHN, int LPFJLNMFDDL, Vector3 AILFIIEAPKM, Quaternion GIBIBDOGOLL, float OMKKAIJAKIM, float ADIMMNOIADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EF20", Offset = "0x5E4DD20", VA = "0x185E4EF20")]
	private void CDNBBDNEOLD(AFKFACHBLPO DMGIABMMKHN, int BJKJDNPFGMO, Vector3 AILFIIEAPKM, float OMKKAIJAKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5E4F6A0", Offset = "0x5E4E4A0", VA = "0x185E4F6A0")]
	private void EHMEMEGMHCH(PAEMMLCLHJM PPEPGBPKJPK, AFKFACHBLPO DMGIABMMKHN, int JCFGEOALKID, int EBNNLBMLFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x23E1670", Offset = "0x23E0470", VA = "0x1823E1670")]
	private T PNPLGBMMAKC<T>(PAEMMLCLHJM PPEPGBPKJPK, GameObject MCMNAIINBFO, Vector3 ELHIODNHAHA, Quaternion FIIPDOPILCE) where T : Collider
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x5E50DC0", Offset = "0x5E4FBC0", VA = "0x185E50DC0")]
	public JNDHCABOBAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[LKMFAIPHKDB(typeof(PHJHPLJJLBK), new string[] { })]
public class NJAADHKOAAC : IJCLFGAEMDL, FKNGAHGHIJP, PHJHPLJJLBK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private FOLLILJKCFG IAMHOIOBMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private IHNPEEDGEBA PNGBIGHMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private AELOEGFEFHM JADKMGFABGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private PMGEMNOIPGF JOEJCOCBPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private int CKDBIBLDPJP;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public bool KMIOKONLJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E57E90", Offset = "0x5E56C90", VA = "0x185E57E90", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public JBMJEBCFLLB GINMDPAEHPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E57380", Offset = "0x5E56180", VA = "0x185E57380", Slot = "9")]
		get
		{
			return default(JBMJEBCFLLB);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E576A0", Offset = "0x5E564A0", VA = "0x185E576A0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public ECLMNCPCDJH MMJEJEDAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E57DC0", Offset = "0x5E56BC0", VA = "0x185E57DC0", Slot = "11")]
		get
		{
			return default(ECLMNCPCDJH);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E576A0", Offset = "0x5E564A0", VA = "0x185E576A0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private uint BKDIKDKJGLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E57F30", Offset = "0x5E56D30", VA = "0x185E57F30")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event DLIEKIDHGAE HCNPFHEKKOM
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5E57D20", Offset = "0x5E56B20", VA = "0x185E57D20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5E57DF0", Offset = "0x5E56BF0", VA = "0x185E57DF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E57AC0", Offset = "0x5E568C0", VA = "0x185E57AC0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E57B90", Offset = "0x5E56990", VA = "0x185E57B90", Slot = "5")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E575B0", Offset = "0x5E563B0", VA = "0x185E575B0", Slot = "19")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E57800", Offset = "0x5E56600", VA = "0x185E57800")]
	private void GLKCCHBCGBH(FKIAGMFJAHK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E579F0", Offset = "0x5E567F0", VA = "0x185E579F0", Slot = "13")]
	public JBMJEBCFLLB ICGNFBGHFEG(JBMJEBCFLLB CJKEIGLKDDB, JBMJEBCFLLB FPDPCPLHJFJ)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E57710", Offset = "0x5E56510", VA = "0x185E57710", Slot = "14")]
	public bool FBILGEPLNJE(JBMJEBCFLLB CJKEIGLKDDB, JBMJEBCFLLB FPDPCPLHJFJ, [Out] JBMJEBCFLLB KAAGEJFEMGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E57450", Offset = "0x5E56250", VA = "0x185E57450", Slot = "15")]
	public void DLALNIEGMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E57EC0", Offset = "0x5E56CC0", VA = "0x185E57EC0", Slot = "16")]
	public void PAKDCNBAHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E57260", Offset = "0x5E56060", VA = "0x185E57260", Slot = "17")]
	public bool AALPPKOGDBB(JBMJEBCFLLB CJKEIGLKDDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E573A0", Offset = "0x5E561A0", VA = "0x185E573A0", Slot = "18")]
	public bool CJCBPKALELG(JBMJEBCFLLB CJKEIGLKDDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E576A0", Offset = "0x5E564A0", VA = "0x185E576A0")]
	private void ICDCABPNMFL(JBMJEBCFLLB CJLPEOINJCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public NJAADHKOAAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[LKMFAIPHKDB(typeof(POCKFOBPLKI), new string[] { })]
public class LCLFLAMPKAC : IJCLFGAEMDL, POCKFOBPLKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private EntityManager FMCNCDMBJDH;

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E50FD0", Offset = "0x5E4FDD0", VA = "0x185E50FD0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E50F70", Offset = "0x5E4FD70", VA = "0x185E50F70", Slot = "5")]
	public void BAKLNMGDAIJ(JBMJEBCFLLB HAIBOLAMIBL, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x2407530", Offset = "0x2406330", VA = "0x182407530")]
	private void KLJMIKDFPBF<T>(JBMJEBCFLLB HAIBOLAMIBL, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LCLFLAMPKAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[LKMFAIPHKDB(typeof(JLJJHKEDFND), new string[] { })]
public class BCBJCNNLHFI : IJCLFGAEMDL, JLJJHKEDFND
{
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private EntityManager FMCNCDMBJDH;

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E438D0", Offset = "0x5E426D0", VA = "0x185E438D0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E43730", Offset = "0x5E42530", VA = "0x185E43730", Slot = "5")]
	public void EDPGOEDGMCL(JBMJEBCFLLB HAIBOLAMIBL, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E43870", Offset = "0x5E42670", VA = "0x185E43870", Slot = "6")]
	public void GCOHMEAEJFA(JBMJEBCFLLB HAIBOLAMIBL, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E43790", Offset = "0x5E42590", VA = "0x185E43790", Slot = "7")]
	public void FJFGKMHJMOC(JBMJEBCFLLB HAIBOLAMIBL, int GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x2169FA0", Offset = "0x2168DA0", VA = "0x182169FA0")]
	private void KLJMIKDFPBF<T>(JBMJEBCFLLB HAIBOLAMIBL, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x2169F10", Offset = "0x2168D10", VA = "0x182169F10")]
	private void KLJMIKDFPBF<T>(JBMJEBCFLLB HAIBOLAMIBL, T PFDMLBFKIAP) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BCBJCNNLHFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
[LKMFAIPHKDB(typeof(PLJPGNGGPNP), new string[] { })]
public class PLJPGNGGPNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly Dictionary<NJGEKDIELMJ, string> PDBPFAMINMC;

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E59540", Offset = "0x5E58340", VA = "0x185E59540")]
	public GameObject DBAPLOEIKCB(NJGEKDIELMJ MFNGBEAMPOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E59610", Offset = "0x5E58410", VA = "0x185E59610")]
	public PLJPGNGGPNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
[LKMFAIPHKDB(typeof(GEDBNPDIKLI), new string[] { })]
internal class GEDBNPDIKLI : IJCLFGAEMDL, FKNGAHGHIJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private JNPLIBJDOGK HJDMFCAGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private CMIFDPMNHCO<Entity> LBLLNFOEKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private GNJPLCKBNJA NPHELGDJFPC;

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AA40", Offset = "0x5E49840", VA = "0x185E4AA40", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AAB0", Offset = "0x5E498B0", VA = "0x185E4AAB0", Slot = "5")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A860", Offset = "0x5E49660", VA = "0x185E4A860", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E4A900", Offset = "0x5E49700", VA = "0x185E4A900")]
	private void FEGJOBFJJFC(Entity CCHOHIEEHEH, [In] ONLJEFNJJKA FKDIDOCGBFM, [In] ONLJEFNJJKA LEDLLMJPAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public GEDBNPDIKLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DefaultMember("Item")]
public class AMKHJONGCKH<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[DefaultMember("Item")]
public class IEMMCHJCGDI<From, To>
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DefaultMember("Item")]
public class ELNAKCLHHCD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly Func<From, To> AFPLDOJPIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Func<To, From> DGNFCMPNDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public NativeArray<From> FNIMPMJDPGM;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public To BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x3063300", Offset = "0x3062100", VA = "0x183063300", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x3063360", Offset = "0x3062160", VA = "0x183063360", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x30632F0", Offset = "0x30620F0", VA = "0x1830632F0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public bool MGKAFOIHMEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x76A6C0", Offset = "0x7694C0", VA = "0x18076A6C0")]
	public ELNAKCLHHCD(Func<From, To> AFPLDOJPIOH, Func<To, From> DGNFCMPNDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x3062E30", Offset = "0x3061C30", VA = "0x183062E30", Slot = "11")]
	public void Add(To PEGAJFMFKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3062E80", Offset = "0x3061C80", VA = "0x183062E80", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3062ED0", Offset = "0x3061CD0", VA = "0x183062ED0", Slot = "13")]
	public bool Contains(To PEGAJFMFKFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3062FB0", Offset = "0x3061DB0", VA = "0x183062FB0", Slot = "14")]
	public void CopyTo(To[] FNIMPMJDPGM, int KOPIDODGMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3063070", Offset = "0x3061E70", VA = "0x183063070", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x3063130", Offset = "0x3061F30", VA = "0x183063130", Slot = "6")]
	public int IndexOf(To PEGAJFMFKFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x30631D0", Offset = "0x3061FD0", VA = "0x1830631D0", Slot = "7")]
	public void Insert(int DOJILIOCHKM, To PEGAJFMFKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x3063270", Offset = "0x3062070", VA = "0x183063270", Slot = "15")]
	public bool Remove(To PEGAJFMFKFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x3063220", Offset = "0x3062020", VA = "0x183063220", Slot = "8")]
	public void RemoveAt(int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x30632C0", Offset = "0x30620C0", VA = "0x1830632C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct CIBBJLIOJPM : IComparable<CIBBJLIOJPM>, IEquatable<CIBBJLIOJPM>
{
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public static readonly CIBBJLIOJPM LKJBFPNKADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public DJMPNJEFEHC HAIBOLAMIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public KIBKAPDMHFC NLJCIKGMHGO;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public bool EHIDAKAHKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E452D0", Offset = "0x5E440D0", VA = "0x185E452D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x9712C0", Offset = "0x9700C0", VA = "0x1809712C0")]
	public CIBBJLIOJPM(DJMPNJEFEHC HAIBOLAMIBL, KIBKAPDMHFC NLJCIKGMHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E45250", Offset = "0x5E44050", VA = "0x185E45250", Slot = "4")]
	public int CompareTo(CIBBJLIOJPM MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E45470", Offset = "0x5E44270", VA = "0x185E45470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E452E0", Offset = "0x5E440E0", VA = "0x185E452E0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E45370", Offset = "0x5E44170", VA = "0x185E45370", Slot = "5")]
	public bool Equals(CIBBJLIOJPM MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E45400", Offset = "0x5E44200", VA = "0x185E45400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public struct ODOJCDNJNEH : IEnumerable<CIBBJLIOJPM>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum BAGBMIOBCPA
	{
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public struct GNHODCOIGFL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private NativeList<byte> PFDMLBFKIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private ODOJCDNJNEH NDKEAGMKBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private readonly CIBBJLIOJPM JIHPAFENIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private readonly int KMFMMHANJHK;

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B6D0", Offset = "0x5E4A4D0", VA = "0x185E4B6D0")]
		internal GNHODCOIGFL(ODOJCDNJNEH NDKEAGMKBJJ, CIBBJLIOJPM JIHPAFENIMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B540", Offset = "0x5E4A340", VA = "0x185E4B540", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B4A0", Offset = "0x5E4A2A0", VA = "0x185E4B4A0")]
		public void CEMDPLLIPDI(ReadOnlySpan<byte> GNLEHBFFNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B630", Offset = "0x5E4A430", VA = "0x185E4B630")]
		private void NDHEFBHKNAB(ReadOnlySpan<byte> GNLEHBFFNFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B5D0", Offset = "0x5E4A3D0", VA = "0x185E4B5D0")]
		private unsafe void NDHEFBHKNAB(void* LHIMHDOIJFI, int JMNJMKJAMOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct EIIBFHIHLBE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private ODOJCDNJNEH NDKEAGMKBJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private NativeArray<byte> PFDMLBFKIAP;

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E48500", Offset = "0x5E47300", VA = "0x185E48500")]
		internal EIIBFHIHLBE(ODOJCDNJNEH NDKEAGMKBJJ, NativeArray<byte> PFDMLBFKIAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E48450", Offset = "0x5E47250", VA = "0x185E48450", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E48390", Offset = "0x5E47190", VA = "0x185E48390")]
		public NativeArray<byte> BHHEIEHNADH(int JMNJMKJAMOL)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E48460", Offset = "0x5E47260", VA = "0x185E48460")]
		public void OGDPKOKMHKJ(Span<byte> GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct EPLEADLMJCI : IEnumerator<CIBBJLIOJPM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private readonly NativeList<CIBBJLIOJPM> FNIMPMJDPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int DOJILIOCHKM;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public CIBBJLIOJPM MNPEEGLNGOK
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x5E48AC0", Offset = "0x5E478C0", VA = "0x185E48AC0", Slot = "4")]
			get
			{
				return default(CIBBJLIOJPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E48A70", Offset = "0x5E47870", VA = "0x185E48A70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E48920", Offset = "0x5E47720", VA = "0x185E48920", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E48A20", Offset = "0x5E47820", VA = "0x185E48A20", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private struct DKBBMDAGCEB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private NativeArray<int> PFDMLBFKIAP;

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool HDOIMIGPILP
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x5E473F0", Offset = "0x5E461F0", VA = "0x185E473F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public int NPGFKJDEHKG
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x5E47530", Offset = "0x5E46330", VA = "0x185E47530")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x5E47520", Offset = "0x5E46320", VA = "0x185E47520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public BAGBMIOBCPA MNIJECPENNO
		{
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x5E47540", Offset = "0x5E46340", VA = "0x185E47540")]
			get
			{
				return default(BAGBMIOBCPA);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x5E47490", Offset = "0x5E46290", VA = "0x185E47490")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public bool HCCFBNLCJPP
		{
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x5E47430", Offset = "0x5E46230", VA = "0x185E47430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public bool GIMKBCFPLMK
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x5E474B0", Offset = "0x5E462B0", VA = "0x185E474B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E47580", Offset = "0x5E46380", VA = "0x185E47580")]
		public DKBBMDAGCEB(BAGBMIOBCPA IKLCLFGAMBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x5E47550", Offset = "0x5E46350", VA = "0x185E47550")]
		private int OMJIHOMPBMI(int HLAIJKBFIJH, int ONFFEEEJGNF = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x5E474D0", Offset = "0x5E462D0", VA = "0x185E474D0")]
		private void KLJMIKDFPBF(int HLAIJKBFIJH, int GNLEHBFFNFG, int ONFFEEEJGNF = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x5E47450", Offset = "0x5E46250", VA = "0x185E47450", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static readonly CIBBJLIOJPM NDHPEBOCHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeParallelHashMap<CIBBJLIOJPM, int> MKBOHHLFADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeList<CIBBJLIOJPM> HOIBAOKBKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeList<int> PIEDENGADAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeList<byte> CEFMPMPJGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private NativeList<byte> PFDMLBFKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private DKBBMDAGCEB FJDDANGEILG;

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5E58A90", Offset = "0x5E57890", VA = "0x185E58A90")]
	public static ODOJCDNJNEH HKJMJGOBNGA(BAGBMIOBCPA IKLCLFGAMBI = BAGBMIOBCPA.Last, int ACNFGPCNILI = 16, int EIJGMIMEFAM = 256)
	{
		return default(ODOJCDNJNEH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5E59160", Offset = "0x5E57F60", VA = "0x185E59160")]
	private ODOJCDNJNEH(BAGBMIOBCPA IKLCLFGAMBI, int ACNFGPCNILI, int EIJGMIMEFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E58710", Offset = "0x5E57510", VA = "0x185E58710", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E58BD0", Offset = "0x5E579D0", VA = "0x185E58BD0")]
	public GNHODCOIGFL JDNOEBOJLLM(CIBBJLIOJPM JIHPAFENIMM)
	{
		return default(GNHODCOIGFL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E588F0", Offset = "0x5E576F0", VA = "0x185E588F0")]
	public bool FIOKLHEPADH(CIBBJLIOJPM JIHPAFENIMM, [Out] EIIBFHIHLBE AOKGLFIDFCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E58CC0", Offset = "0x5E57AC0", VA = "0x185E58CC0")]
	public bool JNABINLAEJD(CIBBJLIOJPM JIHPAFENIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E58AD0", Offset = "0x5E578D0", VA = "0x185E58AD0")]
	public bool HLAEELAGFEH(CIBBJLIOJPM JIHPAFENIMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E58810", Offset = "0x5E57610", VA = "0x185E58810")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E58DF0", Offset = "0x5E57BF0", VA = "0x185E58DF0")]
	private void OBJEHBLMHGA(CIBBJLIOJPM JIHPAFENIMM, int KMFMMHANJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E58630", Offset = "0x5E57430", VA = "0x185E58630")]
	private void DDHCDIDMGMM(int JLKPFEJMOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E58D10", Offset = "0x5E57B10", VA = "0x185E58D10")]
	private void LPELOMADAKK(CIBBJLIOJPM JIHPAFENIMM, int KMFMMHANJHK, int JMNJMKJAMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E590B0", Offset = "0x5E57EB0", VA = "0x185E590B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E59060", Offset = "0x5E57E60", VA = "0x185E59060", Slot = "4")]
	private IEnumerator<CIBBJLIOJPM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DefaultMember("Item")]
public class GCENJPJBKBB<From, To> where From : struct, IEquatable<From>
{
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class EDFNIPLGLEF
{
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class ACPIHNHDPEL
{
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class DEOBDDLPNBA
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class MBEBIMDKKIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public LHNHCAPHDGO services;

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public MBEBIMDKKIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x5E54880", Offset = "0x5E53680", VA = "0x185E54880")]
		internal void ONEGFODMAOP(IJCLFGAEMDL svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5E54820", Offset = "0x5E53620", VA = "0x185E54820")]
		internal void IHLPHJELFPB(FKNGAHGHIJP svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5E46CB0", Offset = "0x5E45AB0", VA = "0x185E46CB0")]
	public static void AJMLCFIONDD(this World GICLKIIJBDC, LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x21F1100", Offset = "0x21EFF00", VA = "0x1821F1100")]
	public static void BBNMLNFHNEN<T>(this World GICLKIIJBDC, Action<T> PFOFEBMPOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x21F1390", Offset = "0x21F0190", VA = "0x1821F1390")]
	public static void JOMNJPKBEDH<T>(this World GICLKIIJBDC, Action<T> PFOFEBMPOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x21F1110", Offset = "0x21EFF10", VA = "0x1821F1110")]
	public static void JOMNJPKBEDH<T>(IEnumerable<ComponentSystemBase> DECADLJJLLJ, Action<T> PFOFEBMPOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class BJIGCJKLKJO
{
	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5E44AE0", Offset = "0x5E438E0", VA = "0x185E44AE0")]
	public static void KJHKBPGKLIM(ComponentSystemBase LOFHIHDMJIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class GOMLDMHGDFH
{
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class DOFCGGBJJEP
{
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class EHFLLILBHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		private sealed class <<CalculateTransformPath>g__getNames|0>d
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public EHFLLILBHBJ()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class OLCANLFGODF
{
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class KHOBNKBOIMB
{
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class HACFNIECLML
{
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class GOAJBOOJCIN
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal static class LMFGOGMLJCO
{
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private static readonly ProfilerMarker HGOMPOAEGGM;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static readonly ProfilerMarker IDFNEIIFFEI;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5E53FA0", Offset = "0x5E52DA0", VA = "0x185E53FA0")]
	public static void CNKHFOKLDEM(this NBKCLNBDKKE PDGDCGJNEFO, KPPDDAAOJPP LCCBIJEOFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5E54540", Offset = "0x5E53340", VA = "0x185E54540")]
	public static void POPGDHLNIHI(this NBKCLNBDKKE PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5E53E90", Offset = "0x5E52C90", VA = "0x185E53E90")]
	private static string[] CNHNPGNCIGB(KPPDDAAOJPP LCCBIJEOFHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5E543E0", Offset = "0x5E531E0", VA = "0x185E543E0")]
	private static bool IONPNEKKHMA(KPPDDAAOJPP LCCBIJEOFHP, [Out] string[] DHIIFFMPDHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370")]
	private static bool KIJPIAPBFPK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public abstract class BMMLBIDOHCI : MFKEPAEKLHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private readonly MethodInfo CDDBKGIAIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly Type[] HGIPKCLMBHH;

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5E44D10", Offset = "0x5E43B10", VA = "0x185E44D10")]
	public BMMLBIDOHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action DJEGAIJHJGL();

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x5E44B40", Offset = "0x5E43940", VA = "0x185E44B40")]
	public MethodInfo JILOGEOIBOK(Action HMHDIIODGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x5E44B80", Offset = "0x5E43980", VA = "0x185E44B80", Slot = "4")]
	public void MCJJKKHGDCC(Type PEMNIEMPPLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public abstract class OBOABLJLEBL : BMMLBIDOHCI
{
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	private enum OEGHJEMMLGG
	{

	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x5E582D0", Offset = "0x5E570D0", VA = "0x185E582D0", Slot = "5")]
	public override Action DJEGAIJHJGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void FHJGIAOCKFC<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x5E58370", Offset = "0x5E57170", VA = "0x185E58370")]
	[UnityEngine.Scripting.Preserve]
	public void KGKEBIFCIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5E48FD0", Offset = "0x5E47DD0", VA = "0x185E48FD0")]
	protected OBOABLJLEBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public abstract class FHAIBMMKCLC : BMMLBIDOHCI
{
	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5E48EA0", Offset = "0x5E47CA0", VA = "0x185E48EA0", Slot = "5")]
	public override Action DJEGAIJHJGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void DNOOLGABFPH<T>() where T : MGELDCPHNEL;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5E48F40", Offset = "0x5E47D40", VA = "0x185E48F40")]
	[UnityEngine.Scripting.Preserve]
	public void KGKEBIFCIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5E48FD0", Offset = "0x5E47DD0", VA = "0x185E48FD0")]
	protected FHAIBMMKCLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public abstract class OMDOCLJHEGD : BMMLBIDOHCI
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5E59350", Offset = "0x5E58150", VA = "0x185E59350", Slot = "5")]
	public override Action DJEGAIJHJGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[UnityEngine.Scripting.Preserve]
	public abstract void KGGMAGAMOMP<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x5E593F0", Offset = "0x5E581F0", VA = "0x185E593F0")]
	[UnityEngine.Scripting.Preserve]
	public void KGKEBIFCIGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x5E48FD0", Offset = "0x5E47DD0", VA = "0x185E48FD0")]
	protected OMDOCLJHEGD()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct PPIINCIBGDM : ISystem
{
	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
	public void OnCreate(SystemState EPLFCMFNFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
	public void OnDestroy(SystemState EPLFCMFNFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A330", Offset = "0x5E59130", VA = "0x185E5A330", Slot = "6")]
	public void OnUpdate(SystemState EPLFCMFNFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void HPHLJGHBJEK(IntPtr LNKCIHFCLHG, IntPtr EPLFCMFNFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A330", Offset = "0x5E59130", VA = "0x185E5A330")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void OOCOPFPBION(IntPtr LNKCIHFCLHG, IntPtr EPLFCMFNFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
	internal static void GEHDFLCCPEN(IntPtr LNKCIHFCLHG, IntPtr EPLFCMFNFIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class NPIFDAGNADM
{
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public static readonly ComponentType[] KODJNECALKE;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5E58150", Offset = "0x5E56F50", VA = "0x185E58150")]
	public static Entity CAEKNHEBBDH(this EntityManager FMCNCDMBJDH)
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class JDOEJAIDDMA
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class BGFHAEEGKOA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class HFMBEKKOPHK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class GMILMPNIHAO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D670", Offset = "0x5E4C470", VA = "0x185E4D670")]
	public static Entity NLFFGFCFCMP(this EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D5E0", Offset = "0x5E4C3E0", VA = "0x185E4D5E0")]
	public static DynamicBuffer<ChildrenData> IIKHGPFELEB(this EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(DynamicBuffer<ChildrenData>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CB30", Offset = "0x5E4B930", VA = "0x185E4CB30")]
	public static bool EKGFGLOFIDC(this EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, Allocator JFLEKJGGDHL, [Out] NativeArray<Entity> DAPAFBOMGEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CED0", Offset = "0x5E4BCD0", VA = "0x185E4CED0")]
	public static NativeArray<Entity> FIBDDJBEECJ(this EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D4B0", Offset = "0x5E4C2B0", VA = "0x185E4D4B0")]
	public static int IHHGAJPDPHK(this EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D220", Offset = "0x5E4C020", VA = "0x185E4D220")]
	public static void IBIJCMFMLCG(NativeArray<Entity> IKFJPFDDMNM, NativeArray<Entity> MKILDJBBDMJ, EntityManager FMCNCDMBJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D050", Offset = "0x5E4BE50", VA = "0x185E4D050")]
	public static bool FOIIPDKECAK(this EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, Entity IKGHEPBMABE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D6E0", Offset = "0x5E4C4E0", VA = "0x185E4D6E0")]
	public static bool PCKJBELCCCI(this EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, Entity EMABGINODJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C970", Offset = "0x5E4B770", VA = "0x185E4C970")]
	public static NativeList<Entity> ECFMIELNDED(this EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, bool KAFIBMPCONB = false, Allocator JFLEKJGGDHL = Allocator.Temp)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C840", Offset = "0x5E4B640", VA = "0x185E4C840")]
	public static Entity DLNLOPFGNBL(this EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5E4CC00", Offset = "0x5E4BA00", VA = "0x185E4CC00")]
	public static bool FBILGEPLNJE(this EntityManager FMCNCDMBJDH, Entity CJKEIGLKDDB, Entity FPDPCPLHJFJ, [Out] Entity JMGECOLEFEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C720", Offset = "0x5E4B520", VA = "0x185E4C720")]
	internal static void BHOPGBOFNPG(EntityManager FMCNCDMBJDH, Entity LBLLNFOEKNE, Entity FKKAOLHJCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5E4D8E0", Offset = "0x5E4C6E0", VA = "0x185E4D8E0")]
	private static bool PFCJJDIMENA(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, Entity IKGHEPBMABE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[LKMFAIPHKDB(typeof(PIEEKNGCHCO), new string[] { })]
internal sealed class BDOHINENHAH : PIEEKNGCHCO, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	[MBPNJDODNHC]
	private BCDPLEGKDHC MECFDKBDFFA;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public CKHCAMABHCH.EAOJJPGHAKL.HFADAIOELAM FMHGNFEFLAE
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x5E439E0", Offset = "0x5E427E0", VA = "0x185E439E0", Slot = "4")]
		get
		{
			return default(CKHCAMABHCH.EAOJJPGHAKL.HFADAIOELAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5E43A50", Offset = "0x5E42850", VA = "0x185E43A50", Slot = "5")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BDOHINENHAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
internal class LLONPIJOALE
{
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private static readonly GKFGDEJLFAD INOLMADPMPJ;

	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private static readonly GKFGDEJLFAD FCGNKOAMJGF;

	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private static readonly ProfilerMarker HMOGCDKBEDA;

	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private static readonly ProfilerMarker BLGPALHFHFG;

	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private static readonly ProfilerMarker JGDNJNKPJIB;

	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private static readonly ProfilerMarker CDMBFMLPOFI;

	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private static readonly ProfilerMarker AEOBGIBOLLF;

	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private static readonly ProfilerMarker GMEFOFHAEAM;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static readonly ProfilerMarker EGHCJFEIINP;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static readonly ProfilerMarker PFJHDMCEDDA;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly ProfilerMarker CFAKHCAJJKI;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static readonly ProfilerMarker EKLLIGKLKIP;

	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private static readonly ProfilerMarker MPCBFCPINLP;

	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private static readonly ProfilerMarker LHIPGNHDDIK;

	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private static readonly ProfilerMarker CPNNMBPMPFD;

	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private static readonly ProfilerMarker JIMPCNLGKFN;

	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private static readonly ProfilerMarker PJMALHIKPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly ECKFJEDNCFM OPOMANFJMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private readonly ByteString GHHJLCMBOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private readonly NBKCLNBDKKE PDGDCGJNEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly DPKMGAFCFKE NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private readonly BEBADJBLANP GHGEHOABFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private readonly OONGDMENFCB HOIBAOKBKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private readonly ONBPEAJPLJK KGJLCMCEIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private readonly TaskCompletionSource<bool> LKHHMKEMOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private readonly NJODKDAGNIO FJDDANGEILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private readonly PHJDNJAHMOO.GCKLKBJFMHK MMNEBNFEOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private FBHFKMFDFBO HPNJDFFLOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private ODLGBANKCLJ IFKLIOOADDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private CKHCAMABHCH LCDEAFNEFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private NLKOBNHNFLA LBGMFGOFDOD;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public Action AHILKNLILCG
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x818420", Offset = "0x817220", VA = "0x180818420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D30", Offset = "0x8B3B30", VA = "0x1808B4D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public Action DOGFDCGMBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A60", Offset = "0x8B3860", VA = "0x1808B4A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8B4CD0", Offset = "0x8B3AD0", VA = "0x1808B4CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public Action CHDEIBOCKDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x76C190", Offset = "0x76AF90", VA = "0x18076C190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x76C0E0", Offset = "0x76AEE0", VA = "0x18076C0E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public IEnumerable<ELKMOGAHBJM> LEJCHMHOCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE00", Offset = "0x7DAC00", VA = "0x1807DBE00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE10", Offset = "0x7DAC10", VA = "0x1807DBE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public GJLEGMBHFIE IAOEEJIBPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x5E518D0", Offset = "0x5E506D0", VA = "0x185E518D0")]
		[CompilerGenerated]
		get
		{
			return default(GJLEGMBHFIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x5E51D70", Offset = "0x5E50B70", VA = "0x185E51D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public NLKOBNHNFLA EKFPKHCMDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A50", Offset = "0x8B3850", VA = "0x1808B4A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public JCIHCELLDEO LNCJDKAMEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x19EF310", Offset = "0x19EE110", VA = "0x1819EF310")]
		get
		{
			return default(JCIHCELLDEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public LocalId ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x5E51630", Offset = "0x5E50430", VA = "0x185E51630")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public Task LALLLIAJMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x5E52950", Offset = "0x5E51750", VA = "0x185E52950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5E53BC0", Offset = "0x5E529C0", VA = "0x185E53BC0")]
	public LLONPIJOALE(ByteString GHHJLCMBOHI, JCIHCELLDEO FALCLNHHOJK, [In] NJODKDAGNIO FJDDANGEILG, NBKCLNBDKKE PDGDCGJNEFO, JLHKELLMEON MFHIHFBGILP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x5E51280", Offset = "0x5E50080", VA = "0x185E51280")]
	public void DGLGEELFCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5E51640", Offset = "0x5E50440", VA = "0x185E51640")]
	public bool FEFPMOEDJPP(JCIHCELLDEO CJKEIGLKDDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x5E51360", Offset = "0x5E50160", VA = "0x185E51360")]
	private bool EKGHGLPBEIG(JCIHCELLDEO FAKOLMHKKAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x5E511D0", Offset = "0x5E4FFD0", VA = "0x185E511D0")]
	private void BGDPAJJANAH(JCIHCELLDEO HMKEIJBJANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x5E52B40", Offset = "0x5E51940", VA = "0x185E52B40")]
	private bool LADIPKLBKIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5E53440", Offset = "0x5E52240", VA = "0x185E53440")]
	public bool PAPABNLHAPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x5E51DA0", Offset = "0x5E50BA0", VA = "0x185E51DA0")]
	private bool IMOOEMJIJPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x5E52EF0", Offset = "0x5E51CF0", VA = "0x185E52EF0")]
	private bool NFPILCBEOCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x5E51050", Offset = "0x5E4FE50", VA = "0x185E51050")]
	private bool AFNKPNLNPNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5E52EC0", Offset = "0x5E51CC0", VA = "0x185E52EC0")]
	private bool MDOKJOGGCEI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x5E52710", Offset = "0x5E51510", VA = "0x185E52710")]
	private bool KFBKEFJHEPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5E51920", Offset = "0x5E50720", VA = "0x185E51920")]
	public void HNOEJDFOBOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5E51660", Offset = "0x5E50460", VA = "0x185E51660")]
	[CompilerGenerated]
	private void FKNHEIJFNMF(JCIHCELLDEO FAKOLMHKKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x5E531C0", Offset = "0x5E51FC0", VA = "0x185E531C0")]
	[CompilerGenerated]
	private bool NHNFOHBHGMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5E522B0", Offset = "0x5E510B0", VA = "0x185E522B0")]
	[CompilerGenerated]
	private void JMHIPDKJFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5E53310", Offset = "0x5E52110", VA = "0x185E53310")]
	[CompilerGenerated]
	private World OEFELKHJBKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x5E517A0", Offset = "0x5E505A0", VA = "0x185E517A0")]
	[CompilerGenerated]
	private void GOGAMCFBBGA(World JJJMMJIPGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5E52D60", Offset = "0x5E51B60", VA = "0x185E52D60")]
	[CompilerGenerated]
	private int LKGHLGLABLK(World JJJMMJIPGJK, ByteString GHHJLCMBOHI, CKHCAMABHCH.EAOJJPGHAKL.HFADAIOELAM KCPGKFKLEJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5E535A0", Offset = "0x5E523A0", VA = "0x185E535A0")]
	[CompilerGenerated]
	private void PKNFIALOGFE(World GICLKIIJBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x5E52990", Offset = "0x5E51790", VA = "0x185E52990")]
	[CompilerGenerated]
	internal static FEGFAPGNKNI KPDCIHBKFMK(EntityManager MHDBGMGJHDG, EntityManager MGHFJNGPEKF, int OCHEPOAJMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x5E51690", Offset = "0x5E50490", VA = "0x185E51690")]
	[CompilerGenerated]
	private void FPBCCPMECED(NLKOBNHNFLA LBGMFGOFDOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5E520F0", Offset = "0x5E50EF0", VA = "0x185E520F0")]
	[CompilerGenerated]
	private void JAJLMAKECBF(EntityManager FMCNCDMBJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5E52850", Offset = "0x5E51650", VA = "0x185E52850")]
	[CompilerGenerated]
	private void KIFOPGANAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x5E51900", Offset = "0x5E50700", VA = "0x185E51900")]
	[CompilerGenerated]
	private void HMADFNNFPMM(string ONIBECKLJDD, EntityManager FMCNCDMBJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x5E51160", Offset = "0x5E4FF60", VA = "0x185E51160")]
	[CompilerGenerated]
	private KDBBIBLIBHM<NJODKDAGNIO> APEAGLHABJJ(EntityManager FMCNCDMBJDH)
	{
		return default(KDBBIBLIBHM<NJODKDAGNIO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
internal class ECKFJEDNCFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private enum NFMHAGMIEOI
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
	private sealed class JECLNJIAPOM : IEnumerable<JCIHCELLDEO>, IEnumerable, IEnumerator<JCIHCELLDEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private JCIHCELLDEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public ECKFJEDNCFM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private JCIHCELLDEO target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public JCIHCELLDEO <>3__target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private int <allowedTarget>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		private JCIHCELLDEO System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.Serialization.DeserializePhases>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x8C3030", Offset = "0x8C1E30", VA = "0x1808C3030", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JCIHCELLDEO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x5E4DC20", Offset = "0x5E4CA20", VA = "0x185E4DC20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xCB4B30", Offset = "0xCB3930", VA = "0x180CB4B30")]
		[DebuggerHidden]
		public JECLNJIAPOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DAA0", Offset = "0x5E4C8A0", VA = "0x185E4DAA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DBD0", Offset = "0x5E4C9D0", VA = "0x185E4DBD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DB20", Offset = "0x5E4C920", VA = "0x185E4DB20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JCIHCELLDEO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Serialization.DeserializePhases>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x5E4DB20", Offset = "0x5E4C920", VA = "0x185E4DB20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class KOFFHOHCMPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public JCIHCELLDEO phase;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public KOFFHOHCMPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x5E50F00", Offset = "0x5E4FD00", VA = "0x185E50F00")]
		internal object JFAEJENKCJN(JCIHCELLDEO a)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static readonly GKFGDEJLFAD FCGNKOAMJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly JCIHCELLDEO FALCLNHHOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Func<JCIHCELLDEO, bool> PGJKJHLFIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private readonly Action<JCIHCELLDEO> COIBIOPBNIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private int CJPHNEGOCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private NFMHAGMIEOI EPLFCMFNFIK;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public JCIHCELLDEO LNCJDKAMEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75FF80", VA = "0x180761180")]
		get
		{
			return default(JCIHCELLDEO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x5E47E40", Offset = "0x5E46C40", VA = "0x185E47E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x5E47F50", Offset = "0x5E46D50", VA = "0x185E47F50")]
	public ECKFJEDNCFM(JCIHCELLDEO FALCLNHHOJK, Func<JCIHCELLDEO, bool> PGJKJHLFIHE, Action<JCIHCELLDEO> COIBIOPBNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x5E47A20", Offset = "0x5E46820", VA = "0x185E47A20")]
	[IteratorStateMachine(typeof(JECLNJIAPOM))]
	private IEnumerable<JCIHCELLDEO> DKIPJHLHJNE(JCIHCELLDEO CJKEIGLKDDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x5E47AB0", Offset = "0x5E468B0", VA = "0x185E47AB0")]
	public bool FEFPMOEDJPP(JCIHCELLDEO CJKEIGLKDDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x5E47E50", Offset = "0x5E46C50", VA = "0x185E47E50")]
	private void HONJIECJPOJ(JCIHCELLDEO FAKOLMHKKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x5E21FC0", Offset = "0x5E20DC0", VA = "0x185E21FC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
internal class GNHFKIFFEKJ : LOHFJLILNBF, JLHKELLMEON, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private readonly LLONPIJOALE ALJMPBCMDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private readonly FALPINKOHJI GHNPBHAOPHA;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public BJAAPCICCEH NMABGCAJHOB
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public LocalId JFHIGDLHEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x5E4B330", Offset = "0x5E4A130", VA = "0x185E4B330", Slot = "9")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public Task LALLLIAJMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AD40", Offset = "0x5E49B40", VA = "0x185E4AD40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public IEnumerable<ELKMOGAHBJM> LEJCHMHOCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AC60", Offset = "0x5E49A60", VA = "0x185E4AC60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public GJLEGMBHFIE IAOEEJIBPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x5E4ACE0", Offset = "0x5E49AE0", VA = "0x185E4ACE0", Slot = "8")]
		get
		{
			return default(GJLEGMBHFIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public NLKOBNHNFLA GCPCKNINGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AD20", Offset = "0x5E49B20", VA = "0x185E4AD20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B390", Offset = "0x5E4A190", VA = "0x185E4B390")]
	public GNHFKIFFEKJ(ByteString GHHJLCMBOHI, BJAAPCICCEH EEKCCCEJAPF, [In] NJODKDAGNIO FJDDANGEILG, NBKCLNBDKKE PDGDCGJNEFO, Action FABLEFHCLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B360", Offset = "0x5E4A160", VA = "0x185E4B360", Slot = "5")]
	public void ODBEBJNFCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ACB0", Offset = "0x5E49AB0", VA = "0x185E4ACB0", Slot = "12")]
	public bool FEFPMOEDJPP(JCIHCELLDEO FAKOLMHKKAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B310", Offset = "0x5E4A110", VA = "0x185E4B310", Slot = "6")]
	public void HNOEJDFOBOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AC90", Offset = "0x5E49A90", VA = "0x185E4AC90", Slot = "13")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
internal class GGOKPLNBLMO : EMJHMNIPEIP, JLHKELLMEON, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private readonly LLONPIJOALE ALJMPBCMDJC;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public LocalId JFHIGDLHEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AD90", Offset = "0x5E49B90", VA = "0x185E4AD90", Slot = "6")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public IEnumerable<ELKMOGAHBJM> LEJCHMHOCHE
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AC60", Offset = "0x5E49A60", VA = "0x185E4AC60", Slot = "4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public GJLEGMBHFIE IAOEEJIBPDH
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x5E4ACE0", Offset = "0x5E49AE0", VA = "0x185E4ACE0", Slot = "5")]
		get
		{
			return default(GJLEGMBHFIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task LALLLIAJMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AD40", Offset = "0x5E49B40", VA = "0x185E4AD40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public NLKOBNHNFLA GCPCKNINGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4AD20", Offset = "0x5E49B20", VA = "0x185E4AD20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ADA0", Offset = "0x5E49BA0", VA = "0x185E4ADA0")]
	public GGOKPLNBLMO(ByteString GHHJLCMBOHI, NBKCLNBDKKE PDGDCGJNEFO, Action KINJFJBCJOP, Action FOIGOLPOJHP, Action FABLEFHCLJG, bool KAOJKCFFLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ACB0", Offset = "0x5E49AB0", VA = "0x185E4ACB0", Slot = "9")]
	public bool FEFPMOEDJPP(JCIHCELLDEO FAKOLMHKKAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AC90", Offset = "0x5E49A90", VA = "0x185E4AC90", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
internal struct NJODKDAGNIO : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public GNMGEBAMPGE PLFGJOHLOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public Entity LBLLNFOEKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public FNBJPBCJEMD LANJILPEPCC;

	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public static readonly KFOHILCLCBE<NJODKDAGNIO> BKEFLEENBBL;
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
internal class FMJCHGONJLE : JMHOHCKHKHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public NLKOBNHNFLA EKFPKHCMDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x5E49860", Offset = "0x5E48660", VA = "0x185E49860", Slot = "5")]
	public ByteString AAKHFJHDIIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x5E498C0", Offset = "0x5E486C0", VA = "0x185E498C0")]
	public FMJCHGONJLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface PIEEKNGCHCO
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	CKHCAMABHCH.EAOJJPGHAKL.HFADAIOELAM FMHGNFEFLAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
internal abstract class BJGGFHMPPPM : JMHOHCKHKHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	private static readonly ProfilerMarker JGDNJNKPJIB;

	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	private static readonly ProfilerMarker GDAKEOHIMNA;

	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private static readonly ProfilerMarker CDMBFMLPOFI;

	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private static readonly ProfilerMarker AJCMPAMDAJE;

	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private static readonly ProfilerMarker GMEFOFHAEAM;

	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private static readonly ProfilerMarker FJCBGBPNBIJ;

	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	private static readonly ProfilerMarker BLMBFGFNCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	private readonly NBKCLNBDKKE PDGDCGJNEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly FBHFKMFDFBO HPNJDFFLOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly ONBPEAJPLJK KGJLCMCEIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly OONGDMENFCB HOIBAOKBKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly GKFGDEJLFAD FCGNKOAMJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly PHJDNJAHMOO.GCKLKBJFMHK MMNEBNFEOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private World IPDGMHLGOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private NLKOBNHNFLA LBGMFGOFDOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private IDisposable LIKMLEAFBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private ByteString IICIAOIFJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private CKHCAMABHCH.EAOJJPGHAKL.HFADAIOELAM LJOBOHAOCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private bool KBJJAFHGPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private OCEBOIKNKAB KFOLJGBPMID;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	protected World BPHCCBOGPOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x764C00", Offset = "0x763A00", VA = "0x180764C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	protected World IIPPIBCPIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x5E43BE0", Offset = "0x5E429E0", VA = "0x185E43BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public NLKOBNHNFLA EKFPKHCMDCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x764C10", Offset = "0x763A10", VA = "0x180764C10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x5E44940", Offset = "0x5E43740", VA = "0x185E44940")]
	public BJGGFHMPPPM(NBKCLNBDKKE PDGDCGJNEFO, GKFGDEJLFAD CGHEBMJOFGL, GKFGDEJLFAD FCGNKOAMJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x5E43AA0", Offset = "0x5E428A0", VA = "0x185E43AA0", Slot = "5")]
	public ByteString AAKHFJHDIIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x5E43C90", Offset = "0x5E42A90", VA = "0x185E43C90", Slot = "7")]
	public void ODBEBJNFCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x5E43C30", Offset = "0x5E42A30", VA = "0x185E43C30", Slot = "8")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x5E43B20", Offset = "0x5E42920", VA = "0x185E43B20", Slot = "9")]
	protected virtual HEIHHPFKNIC AKELGLKFEEI()
	{
		return default(HEIHHPFKNIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void GIIECIOEDKK();

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract NativeArray<EntityRemapUtility.EntityRemapInfo> PFNEIHAIAHJ(NativeArray<EntityRemapUtility.EntityRemapInfo> BPKNOFJDFDB);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[OJLGNJNGAKP]
internal struct HEIHHPFKNIC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public GNMGEBAMPGE ANIJGCJFDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public KMHHHJLNOEJ LANJILPEPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public CKHCAMABHCH.EAOJJPGHAKL.HFADAIOELAM KCPGKFKLEJL;

	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public static readonly KFOHILCLCBE<HEIHHPFKNIC> BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B780", Offset = "0x5E4A580", VA = "0x185E4B780")]
	public static HEIHHPFKNIC EOLNNGNHJIK([In] GNMGEBAMPGE ANIJGCJFDNC)
	{
		return default(HEIHHPFKNIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
internal class IGNCOBHBBJG : BJGGFHMPPPM
{
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private static readonly GKFGDEJLFAD FCGNKOAMJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly HEIHHPFKNIC FJDDANGEILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private NativeList<Entity> AEAPPCGLCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private NativeArray<Entity> LFOABCMKFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> PEJPACHGPMJ;

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C2A0", Offset = "0x5E4B0A0", VA = "0x185E4C2A0")]
	public IGNCOBHBBJG(IEnumerable<JBMJEBCFLLB> DJIDJBJMOLC, [In] HEIHHPFKNIC FJDDANGEILG, NBKCLNBDKKE PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BE20", Offset = "0x5E4AC20", VA = "0x185E4BE20", Slot = "9")]
	protected override HEIHHPFKNIC AKELGLKFEEI()
	{
		return default(HEIHHPFKNIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BF00", Offset = "0x5E4AD00", VA = "0x185E4BF00", Slot = "10")]
	protected override void GIIECIOEDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C090", Offset = "0x5E4AE90", VA = "0x185E4C090", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> PFNEIHAIAHJ(NativeArray<EntityRemapUtility.EntityRemapInfo> BPKNOFJDFDB)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BE50", Offset = "0x5E4AC50", VA = "0x185E4BE50", Slot = "8")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
internal class OCLOGEKDNHE : BJGGFHMPPPM
{
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private static readonly GKFGDEJLFAD FCGNKOAMJGF;

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E58570", Offset = "0x5E57370", VA = "0x185E58570")]
	public OCLOGEKDNHE(NBKCLNBDKKE PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E58400", Offset = "0x5E57200", VA = "0x185E58400", Slot = "10")]
	protected override void GIIECIOEDKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0xD6A210", Offset = "0xD69010", VA = "0x180D6A210", Slot = "11")]
	protected override NativeArray<EntityRemapUtility.EntityRemapInfo> PFNEIHAIAHJ(NativeArray<EntityRemapUtility.EntityRemapInfo> BPKNOFJDFDB)
	{
		return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
internal static class JJCIKKBABIF
{
	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E890", Offset = "0x5E4D690", VA = "0x185E4E890")]
	public static PHJDNJAHMOO.GCKLKBJFMHK HCDBMBACKKB(NBKCLNBDKKE PDGDCGJNEFO)
	{
		return default(PHJDNJAHMOO.GCKLKBJFMHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E950", Offset = "0x5E4D750", VA = "0x185E4E950")]
	public static NativeList<Entity> LOLKAJEHHFN(EntityManager FMCNCDMBJDH, IEnumerable<JBMJEBCFLLB> DJIDJBJMOLC)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EC50", Offset = "0x5E4DA50", VA = "0x185E4EC50")]
	public static void PFNEIHAIAHJ(NativeArray<Entity> LFOABCMKFND, NativeList<Entity> AEAPPCGLCGC, NativeArray<EntityRemapUtility.EntityRemapInfo> BPKNOFJDFDB, NativeArray<EntityRemapUtility.EntityRemapInfo> PEJPACHGPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x23C2180", Offset = "0x23C0F80", VA = "0x1823C2180")]
	public static Entity NLOAGGCHIFP<T>(EntityManager FMCNCDMBJDH, [In] T GNLEHBFFNFG) where T : struct, IComponentData
	{
		return default(Entity);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class HOFIGPMMKGP
{
	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BD50", Offset = "0x5E4AB50", VA = "0x185E4BD50")]
	public static GNMGEBAMPGE BJCOLEAHLJM(ECLMNCPCDJH LBLLNFOEKNE)
	{
		return default(GNMGEBAMPGE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct KDBBIBLIBHM<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private EntityManager FMCNCDMBJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly Entity EHFEIPEPHEO;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x3881D50", Offset = "0x3880B50", VA = "0x183881D50")]
	public KDBBIBLIBHM(EntityManager FMCNCDMBJDH, [In] T FJDDANGEILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x3881C30", Offset = "0x3880A30", VA = "0x183881C30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[LKMFAIPHKDB(typeof(JHHOBBMGMJL), new string[] { })]
public class DBKJLDONAMH : JHHOBBMGMJL, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public LJMLIKCJBGD CFEHPIOIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x763960", Offset = "0x762760", VA = "0x180763960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private FPJFHPMDDGC IBDGFOCDNCI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x761630", Offset = "0x760430", VA = "0x180761630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private IBOMJCPFPBJ OOAELMHAHEN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x761680", Offset = "0x760480", VA = "0x180761680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	private EGFIAOKIMAI NNEDGDPDPEN
	{
		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x768590", Offset = "0x767390", VA = "0x180768590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public ELICKPPOGGA AKGBOHJKIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x7658F0", Offset = "0x7646F0", VA = "0x1807658F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public MFEFBFNBPNO FHEMMGCLFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x76B130", Offset = "0x769F30", VA = "0x18076B130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CENEGDPHJKH JAIDGMBANJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x768550", Offset = "0x767350", VA = "0x180768550", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x768570", Offset = "0x767370", VA = "0x180768570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public GHMFBCIFKGP MNPKDMPOKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x76B160", Offset = "0x769F60", VA = "0x18076B160", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x76B170", Offset = "0x769F70", VA = "0x18076B170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private DPKMGAFCFKE LAJFDHKJLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x764C30", Offset = "0x763A30", VA = "0x180764C30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public HLMBCPKELME BOIJLKCOKOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x764C20", Offset = "0x763A20", VA = "0x180764C20", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x764BE0", Offset = "0x7639E0", VA = "0x180764BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public PEAALCEGOHC AJIDOCBGJFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x764C00", Offset = "0x763A00", VA = "0x180764C00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x764BF0", Offset = "0x7639F0", VA = "0x180764BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private LCDCAHKPFOP BBFKLMFALHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x764BD0", Offset = "0x7639D0", VA = "0x180764BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public KPIPKBHPNOA NGKBECMKJPH
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x766D10", Offset = "0x765B10", VA = "0x180766D10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x766D00", Offset = "0x765B00", VA = "0x180766D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private MBCPGIKDGBD BCJGEGDAKEC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x76FC40", Offset = "0x76EA40", VA = "0x18076FC40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private CDNOLOGJCIN OEDMLDOIPJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x76FC10", Offset = "0x76EA10", VA = "0x18076FC10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E469F0", Offset = "0x5E457F0", VA = "0x185E469F0", Slot = "13")]
	public virtual void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DBKJLDONAMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[LKMFAIPHKDB(typeof(NMOMJJDHINP), new string[] { })]
public class EIJKJNIICKO : NMOMJJDHINP, APDPPALGJBL, CNAEOKMDOKG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private LHNHCAPHDGO PDGDCGJNEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private JHHOBBMGMJL NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private ODLGBANKCLJ IFKLIOOADDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private MGCBGGNJMBI CLGGHKJADNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private FOLLILJKCFG IAMHOIOBMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private JNPLIBJDOGK HJDMFCAGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private DEHDJDPODCF IGBHKFPEPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private GALOHLLCPLH EKODFEEOAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private MAEKAKNNECM JMCBAOHMCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private MOMEIDDAEBF LMEPOAMFDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private FAMDMBCKPIO MDFJDMLIHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private PHJHPLJJLBK AOKGLFIDFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private HKANIBGKHCE MBDNOEEJLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private POCKFOBPLKI AONGCICHAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private JLJJHKEDFND ENOFJELHNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private PNFCPLLCHJK CAGKEPBHJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private ILHIPOGALPJ IICMJOKPKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private BGJEPDMMNIC HHJJKPNJLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private BCDPLEGKDHC NLLAIOCDMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private IHJBEAAMNEB IGNGKFHFNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public LHNHCAPHDGO CBMBNJJFGJM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public JHHOBBMGMJL IHLJFAGFAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public HBMBNCJMDAI ALGMCKADIHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public MGCBGGNJMBI GHANKDLFFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public FOLLILJKCFG CBJKAFKIJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x768550", Offset = "0x767350", VA = "0x180768550", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public JNPLIBJDOGK GNCACLGHEHI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x76B160", Offset = "0x769F60", VA = "0x18076B160", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public DEHDJDPODCF FFCPIKAPOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x764C40", Offset = "0x763A40", VA = "0x180764C40", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public MAEKAKNNECM CDIIFGPPIKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x764C00", Offset = "0x763A00", VA = "0x180764C00", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public MOMEIDDAEBF NPGJMKHHHPO
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x764C10", Offset = "0x763A10", VA = "0x180764C10", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public FAMDMBCKPIO HCGCMNNEFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x766D10", Offset = "0x765B10", VA = "0x180766D10", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public PHJHPLJJLBK BCJGEGDAKEC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x76FD20", Offset = "0x76EB20", VA = "0x18076FD20", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public HKANIBGKHCE EPOOLGOBFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x76FD10", Offset = "0x76EB10", VA = "0x18076FD10", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public POCKFOBPLKI OMCBFGLHPOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x76FCA0", Offset = "0x76EAA0", VA = "0x18076FCA0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public JLJJHKEDFND DGEOMMEHEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x8125E0", Offset = "0x8113E0", VA = "0x1808125E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public PNFCPLLCHJK LMKOPFMPBKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x76FC50", Offset = "0x76EA50", VA = "0x18076FC50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public ILHIPOGALPJ CKKFLLLGKFO
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x89C9D0", Offset = "0x89B7D0", VA = "0x18089C9D0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public BGJEPDMMNIC MMIHJMDBJKN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x76C140", Offset = "0x76AF40", VA = "0x18076C140", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public BCDPLEGKDHC COHPGONCHAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A00", Offset = "0x8B3800", VA = "0x1808B4A00", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public IHJBEAAMNEB ODLBANJHKGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x83E3C0", Offset = "0x83D1C0", VA = "0x18083E3C0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public CKLCFHIBNGJ EHJADIEJDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC30", Offset = "0x7DDA30", VA = "0x1807DEC30", Slot = "24")]
		get
		{
			return default(CKLCFHIBNGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E48550", Offset = "0x5E47350", VA = "0x185E48550", Slot = "25")]
	public void CAPMIKFGFII(LHNHCAPHDGO AANMFFBJNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E48850", Offset = "0x5E47650", VA = "0x185E48850", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E48860", Offset = "0x5E47660", VA = "0x185E48860", Slot = "26")]
	public void HCNPFHEKKOM(LHNHCAPHDGO AANMFFBJNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public EIJKJNIICKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[DefaultMember("Item")]
public class FJPFIFGAKKL : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class FFCKPBDKHFI : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public FJPFIFGAKKL <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8C3030", Offset = "0x8C1E30", VA = "0x1808C3030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E48E50", Offset = "0x5E47C50", VA = "0x185E48E50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x765650", Offset = "0x764450", VA = "0x180765650")]
		[DebuggerHidden]
		public FFCKPBDKHFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E48C90", Offset = "0x5E47A90", VA = "0x185E48C90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E48E00", Offset = "0x5E47C00", VA = "0x185E48E00", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private readonly List<ulong> PPCAPPENFHK;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7646E0", VA = "0x1807658E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E497D0", Offset = "0x5E485D0", VA = "0x185E497D0")]
	public FJPFIFGAKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E49750", Offset = "0x5E48550", VA = "0x185E49750", Slot = "4")]
	[IteratorStateMachine(typeof(FFCKPBDKHFI))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E49750", Offset = "0x5E48550", VA = "0x185E49750", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[CBDJBBOKHOJ(typeof(JMMDCOJHEDE))]
[LKMFAIPHKDB(typeof(CNMKNCKCMAL), new string[] { })]
public class FHIMCJGJFBN : CNMKNCKCMAL, POKGICLLPAE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private readonly Dictionary<int, FPKCPFBLOPG> LNKOMNKLKGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private readonly Dictionary<FPKCPFBLOPG, int> ALHIILFAMCG;

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E490A0", Offset = "0x5E47EA0", VA = "0x185E490A0", Slot = "6")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E491D0", Offset = "0x5E47FD0", VA = "0x185E491D0", Slot = "7")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E49420", Offset = "0x5E48220", VA = "0x185E49420")]
	private void NGCJDAEKLED(List<(FPKCPFBLOPG nameHash, KEDJJAGCMFO stableTypeHash, Type type)> NDKEAGMKBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E492D0", Offset = "0x5E480D0", VA = "0x185E492D0", Slot = "4")]
	public FPKCPFBLOPG JLJAHFLHHBJ(int IDDPEMOGPEO)
	{
		return default(FPKCPFBLOPG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E49160", Offset = "0x5E47F60", VA = "0x185E49160", Slot = "5")]
	public int HPGAGKLDLFN(FPKCPFBLOPG IHPNAJENOLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E49630", Offset = "0x5E48430", VA = "0x185E49630")]
	public FHIMCJGJFBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[LKMFAIPHKDB(typeof(IHNPEEDGEBA), new string[] { })]
public class CPNLJFKBOGD : IHNPEEDGEBA, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	[MBPNJDODNHC]
	private HLMBCPKELME NBBLMGDHBPE;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private uint AJJFHKBNDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E455F0", Offset = "0x5E443F0", VA = "0x185E455F0", Slot = "4")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E455A0", Offset = "0x5E443A0", VA = "0x185E455A0", Slot = "5")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public CPNLJFKBOGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[LKMFAIPHKDB(typeof(FENEGJKBICD), new string[] { })]
public class JJCHCDBKNKD : FENEGJKBICD, POKGICLLPAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private ODOJCDNJNEH PBLAPNNAGLB;

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DC70", Offset = "0x5E4CA70", VA = "0x185E4DC70", Slot = "8")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DD40", Offset = "0x5E4CB40", VA = "0x185E4DD40", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E170", Offset = "0x5E4CF70", VA = "0x185E4E170", Slot = "4")]
	public void NAEBAPOGBLA(DJMPNJEFEHC HAIBOLAMIBL, KIBKAPDMHFC NLJCIKGMHGO, ReadOnlySpan<byte> FPCLKFNNOEC, ReadOnlySpan<byte> LEKCIABMLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DDC0", Offset = "0x5E4CBC0", VA = "0x185E4DDC0", Slot = "7")]
	public bool KFLAGNHDOGP(DJMPNJEFEHC HAIBOLAMIBL, KIBKAPDMHFC NLJCIKGMHGO, Span<byte> FPCLKFNNOEC, Span<byte> LEKCIABMLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E770", Offset = "0x5E4D570", VA = "0x185E4E770", Slot = "5")]
	public bool PABCKECIPAF(DJMPNJEFEHC HAIBOLAMIBL, KIBKAPDMHFC NLJCIKGMHGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5E4DD90", Offset = "0x5E4CB90", VA = "0x185E4DD90", Slot = "6")]
	public bool EGHCFEPEBCC(DJMPNJEFEHC HAIBOLAMIBL, KIBKAPDMHFC NLJCIKGMHGO, ReadOnlySpan<byte> LEKCIABMLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E3D0", Offset = "0x5E4D1D0", VA = "0x185E4E3D0")]
	private bool OLHLIENKMJB(DJMPNJEFEHC HAIBOLAMIBL, KIBKAPDMHFC NLJCIKGMHGO, ReadOnlySpan<byte> LEKCIABMLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public JJCHCDBKNKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class AJBNBLFKJCK<T> : DJCDONHNJCH<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	protected JKCINGAAMFK<T> HBGELNOCAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	protected OGFJDDPEKCB<T> JAOIAENJHCN;

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x33CC3A0", Offset = "0x33CB1A0", VA = "0x1833CC3A0")]
	public AJBNBLFKJCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x3515240", Offset = "0x3514040", VA = "0x183515240")]
	public AJBNBLFKJCK(JKCINGAAMFK<T> HBGELNOCAJE, OGFJDDPEKCB<T> JAOIAENJHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x3514B60", Offset = "0x3513960", VA = "0x183514B60", Slot = "10")]
	protected override T EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x3514EF0", Offset = "0x3513CF0", VA = "0x183514EF0", Slot = "11")]
	protected override void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC, T GNLEHBFFNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class EAFCMFNDMEA
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public sealed class IAOAPPHPDLM<T> : AJBNBLFKJCK<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x3642A20", Offset = "0x3641820", VA = "0x183642A20")]
	public IAOAPPHPDLM(T GBOBLEMPFME, T COGFLCBHIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class PPFAFGJDLIN<T> : DJCDONHNJCH<T> where T : struct, MGELDCPHNEL
{
	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x3E113F0", Offset = "0x3E101F0", VA = "0x183E113F0", Slot = "10")]
	protected override T EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x3E11570", Offset = "0x3E10370", VA = "0x183E11570", Slot = "11")]
	protected override void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x300DF90", Offset = "0x300CD90", VA = "0x18300DF90")]
	public PPFAFGJDLIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
internal static class MEGFMFFNEBK
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	private class PIHLCOOJEDD
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[CompilerGenerated]
		private sealed class CFKHAKHGKBL<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000244")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public CFKHAKHGKBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x4818890", Offset = "0x4817690", VA = "0x184818890")]
			internal void CKJKMICMJIP(HOFPAEMDILJ writer, T value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x4818AA0", Offset = "0x48178A0", VA = "0x184818AA0")]
			internal T GFINFEFOPCF(KEBCPOHPOJM reader)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x5E59480", Offset = "0x5E58280", VA = "0x185E59480")]
		public static void ONNHHAGELCO(DGFEGLOPOPB NLFJDPDMBPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x297F870", Offset = "0x297E670", VA = "0x18297F870")]
		private static void JLNOEMDEMFH<T>(DGFEGLOPOPB NLFJDPDMBPJ, int COGFLCBHIIG) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x297F7E0", Offset = "0x297E5E0", VA = "0x18297F7E0")]
		private static void BJNLMLHACOO<T>(HOFPAEMDILJ LCMOFCIALJC, T PMHKKHBJKIH, int COGFLCBHIIG) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x297F9A0", Offset = "0x297E7A0", VA = "0x18297F9A0")]
		private static T PIHMMLFEHAB<T>(KEBCPOHPOJM POOKDLGIHHA, int COGFLCBHIIG) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public PIHLCOOJEDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	private class KJIJMJLCDCB : OBOABLJLEBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private DGFEGLOPOPB NLFJDPDMBPJ;

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x297F390", Offset = "0x297E190", VA = "0x18297F390", Slot = "6")]
		public override void FHJGIAOCKFC<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x5E50E50", Offset = "0x5E4FC50", VA = "0x185E50E50")]
		public static void ALOCNANKLKG(DGFEGLOPOPB NLFJDPDMBPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x5E48FD0", Offset = "0x5E47DD0", VA = "0x185E48FD0")]
		public KJIJMJLCDCB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x5E55470", Offset = "0x5E54270", VA = "0x185E55470")]
	public static void NPEFKILHNOH(DGFEGLOPOPB NLFJDPDMBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x5E55370", Offset = "0x5E54170", VA = "0x185E55370")]
	private static void GMHLPLCONBL(HOFPAEMDILJ LOKDBOGNGFK, quaternion PMHKKHBJKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x5E56F00", Offset = "0x5E55D00", VA = "0x185E56F00")]
	private static quaternion PGNGHKNOGIM(KEBCPOHPOJM HFPPDNNHFOK)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x244F550", Offset = "0x244E350", VA = "0x18244F550")]
	public static void ABCDBFFLEJP<T>(DGFEGLOPOPB NLFJDPDMBPJ, JKCINGAAMFK<T> HBGELNOCAJE, OGFJDDPEKCB<T> JAOIAENJHCN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x244F5F0", Offset = "0x244E3F0", VA = "0x18244F5F0")]
	public static void POIBAOJFLJL<T>(DGFEGLOPOPB KPBDFPNEODJ) where T : struct, MGELDCPHNEL
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public abstract class HJEHNLGBLJN : EAMGFLAKCOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public abstract Type MAFMPFOLJKP
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA, Span<byte> GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC, ReadOnlySpan<byte> GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	protected HJEHNLGBLJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public abstract class DJCDONHNJCH<T> : HJEHNLGBLJN where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public override Type MAFMPFOLJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x4CEC280", Offset = "0x4CEB080", VA = "0x184CEC280", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract T EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA);

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC, T GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x4CEB5D0", Offset = "0x4CEA3D0", VA = "0x184CEB5D0", Slot = "8")]
	public override void EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA, Span<byte> CJKEIGLKDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x4CEBC00", Offset = "0x4CEAA00", VA = "0x184CEBC00", Slot = "9")]
	public override void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC, ReadOnlySpan<byte> JIHPAFENIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
	protected DJCDONHNJCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
internal static class AGFBHJPABAL
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public struct IKGDINIIFJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public IKBNJJBMJGF CFIPHHIMOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public KCJDDJBIGAA LEMFKLBLNPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public FCEELEODMDI PEEDPFPJBGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public HDEKOHKCIPA JPFJLMHLIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public FENEGJKBICD DDKNPKAHBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public EGIJLNKKPDN NLFJDPDMBPJ;

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C4D0", Offset = "0x5E4B2D0", VA = "0x185E4C4D0")]
		public void PCPNMJLBOGM(LHNHCAPHDGO PDGDCGJNEFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct MJMLLNFMPBE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public NativeList<DJMPNJEFEHC> BNJMINPAMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public NativeList<NOGPJKFKBEI> EIBIAHGBKEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public NativeList<DJMPNJEFEHC> FFLLOLHFKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public NativeParallelMultiHashMap<DJMPNJEFEHC, ELBMLKGPNPA> EKODFEEOAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public NativeList<byte> HLHICDLJGCI;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public bool IMIPDCGIEFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x5E57080", Offset = "0x5E55E80", VA = "0x185E57080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x5E56FE0", Offset = "0x5E55DE0", VA = "0x185E56FE0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	private struct NAFGEDBGBID : IComparer<ELBMLKGPNPA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x5E57110", Offset = "0x5E55F10", VA = "0x185E57110", Slot = "4")]
		public int Compare(ELBMLKGPNPA HOELCINBFKH, ELBMLKGPNPA JOHINIOFBIJ)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private static readonly GKFGDEJLFAD FNLOJBGHDNH;

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x5E43020", Offset = "0x5E41E20", VA = "0x185E43020")]
	public static void NLKEMDFOKBD(HOFPAEMDILJ LCMOFCIALJC, MJMLLNFMPBE PFDMLBFKIAP, IKGDINIIFJG PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x5E432C0", Offset = "0x5E420C0", VA = "0x185E432C0")]
	public static MJMLLNFMPBE PBLODNAKHMM(KEBCPOHPOJM POOKDLGIHHA, Allocator JFLEKJGGDHL, IKGDINIIFJG PDGDCGJNEFO)
	{
		return default(MJMLLNFMPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x5E42C20", Offset = "0x5E41A20", VA = "0x185E42C20")]
	public static void NAEBAPOGBLA(MJMLLNFMPBE PFDMLBFKIAP, IKGDINIIFJG PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x5E42550", Offset = "0x5E41350", VA = "0x185E42550")]
	public static void EGHCFEPEBCC(MJMLLNFMPBE PFDMLBFKIAP, IKGDINIIFJG PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5E42840", Offset = "0x5E41640", VA = "0x185E42840")]
	public static int HFLGMBKNLED(MJMLLNFMPBE PFDMLBFKIAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5E41450", Offset = "0x5E40250", VA = "0x185E41450")]
	private static void AIEFHDPBDFJ(HOFPAEMDILJ LCMOFCIALJC, NativeArray<DJMPNJEFEHC> BNJMINPAMOL, NativeArray<NOGPJKFKBEI> EIBIAHGBKEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5E42990", Offset = "0x5E41790", VA = "0x185E42990")]
	private static void IGFOBMEBMPK(KEBCPOHPOJM POOKDLGIHHA, Allocator JFLEKJGGDHL, [Out] NativeList<DJMPNJEFEHC> BNJMINPAMOL, [Out] NativeList<NOGPJKFKBEI> FBOLPOHAIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5E435D0", Offset = "0x5E423D0", VA = "0x185E435D0")]
	private static void PGAMJHDEPHH(HOFPAEMDILJ LCMOFCIALJC, NativeArray<DJMPNJEFEHC> FFLLOLHFKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5E42B20", Offset = "0x5E41920", VA = "0x185E42B20")]
	private static void JLEEGPFPDAJ(KEBCPOHPOJM POOKDLGIHHA, Allocator JFLEKJGGDHL, [Out] NativeList<DJMPNJEFEHC> FFLLOLHFKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5E41BB0", Offset = "0x5E409B0", VA = "0x185E41BB0")]
	private static void DPAICABLLKB(HOFPAEMDILJ LCMOFCIALJC, NativeParallelMultiHashMap<DJMPNJEFEHC, ELBMLKGPNPA> EKODFEEOAPM, NativeList<byte> HLHICDLJGCI, IKGDINIIFJG PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5E41540", Offset = "0x5E40340", VA = "0x185E41540")]
	private static void BFFHDHNPENB(KEBCPOHPOJM POOKDLGIHHA, Allocator JFLEKJGGDHL, [Out] NativeParallelMultiHashMap<DJMPNJEFEHC, ELBMLKGPNPA> EKODFEEOAPM, [Out] NativeList<byte> HLHICDLJGCI, IKGDINIIFJG PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5E41B90", Offset = "0x5E40990", VA = "0x185E41B90")]
	private static void DDOABIDFPKI(int EPLGMDCPCGP, int MDIFGFIGNPI, HOFPAEMDILJ LCMOFCIALJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5E41520", Offset = "0x5E40320", VA = "0x185E41520")]
	private static int ALCGPODJOEI(int MDIFGFIGNPI, KEBCPOHPOJM POOKDLGIHHA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
[LKMFAIPHKDB(typeof(JIFHFMEONHJ), new string[] { })]
internal sealed class JJPLHBONJLL : JIFHFMEONHJ, POKGICLLPAE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private readonly Dictionary<KIBKAPDMHFC, FCKPHFHKGNB> FDPNNCEMADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private KCJDDJBIGAA EKODFEEOAPM;

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ED00", Offset = "0x5E4DB00", VA = "0x185E4ED00", Slot = "6")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4ED50", Offset = "0x5E4DB50", VA = "0x185E4ED50", Slot = "7")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EE20", Offset = "0x5E4DC20", VA = "0x185E4EE20", Slot = "4")]
	public void MCJJKKHGDCC(KIBKAPDMHFC NLJCIKGMHGO, Type HLIBKIJEOFP, FCKPHFHKGNB KMCININDODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EDB0", Offset = "0x5E4DBB0", VA = "0x185E4EDB0", Slot = "5")]
	public bool JEJBDNAMOGD(KIBKAPDMHFC NLJCIKGMHGO, [Out] FCKPHFHKGNB KMCININDODP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EE90", Offset = "0x5E4DC90", VA = "0x185E4EE90")]
	public JJPLHBONJLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
[LKMFAIPHKDB(typeof(JEOFEPALLKF), new string[] { })]
internal class DIKFBIICPBN : IJCLFGAEMDL, JEOFEPALLKF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	[MBPNJDODNHC]
	private IHNPEEDGEBA PNGBIGHMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private INNOGIJFPDG KNMKLOLJEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private int DLHPPKCKOPH;

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x5E47380", Offset = "0x5E46180", VA = "0x185E47380", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5E47240", Offset = "0x5E46040", VA = "0x185E47240", Slot = "5")]
	public OMJBIJKANJG DJDNJHJMAMO(ReadOnlySpan<byte> JPGMJABDIAJ)
	{
		return default(OMJBIJKANJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5E47370", Offset = "0x5E46170", VA = "0x185E47370", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DIKFBIICPBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[LKMFAIPHKDB(typeof(HDEKOHKCIPA), new string[] { })]
internal sealed class PLMCONPAECP : HDEKOHKCIPA, IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	[MBPNJDODNHC]
	private KCJDDJBIGAA EKODFEEOAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private NativeBitArray BKFLAMEBGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private NativeParallelHashMap<DJMPNJEFEHC, int> NPIMNPJFOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private NativeList<int> PNKCJLEKBKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private int GIENFLEIHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private int OGHJOHMKJMJ;

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool NBMNKGOJOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x5E59C40", Offset = "0x5E58A40", VA = "0x185E59C40", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public CANNBGFMJBJ HAINDCGDEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x5E59CF0", Offset = "0x5E58AF0", VA = "0x185E59CF0", Slot = "7")]
		get
		{
			return default(CANNBGFMJBJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A2B0", Offset = "0x5E590B0", VA = "0x185E5A2B0", Slot = "4")]
	public bool PPOEKCLKIDK(DJMPNJEFEHC IELEJBMANDO, KIBKAPDMHFC GGCGADADFCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x5E59D40", Offset = "0x5E58B40", VA = "0x185E59D40", Slot = "8")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A120", Offset = "0x5E58F20", VA = "0x185E5A120", Slot = "6")]
	public void KJKOPGBNDCE(NativeArray<DJMPNJEFEHC> OEHBGDNEBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x5E59EA0", Offset = "0x5E58CA0", VA = "0x185E59EA0", Slot = "5")]
	public void JKPMHHNBHBM(DJMPNJEFEHC IELEJBMANDO, Span<KIBKAPDMHFC> EKODFEEOAPM, bool BAICLDMINPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x5E59C60", Offset = "0x5E58A60", VA = "0x185E59C60", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public PLMCONPAECP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[LKMFAIPHKDB(typeof(EGIJLNKKPDN), new string[] { })]
public sealed class MDOBPJFDJLL : EGIJLNKKPDN, BNDOPICGFOA<EGIJLNKKPDN>, POKGICLLPAE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private readonly Dictionary<KIBKAPDMHFC, EAMGFLAKCOJ> NLFJDPDMBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private DGFEGLOPOPB IADFBENCGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private KCJDDJBIGAA EKODFEEOAPM;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool MNCJJPHIOHE
	{
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x7FCD80", Offset = "0x7FBB80", VA = "0x1807FCD80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x5E54C70", Offset = "0x5E53A70", VA = "0x185E54C70")]
	public MDOBPJFDJLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x5E548E0", Offset = "0x5E536E0", VA = "0x185E548E0", Slot = "5")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x5E54B60", Offset = "0x5E53960", VA = "0x185E54B60", Slot = "6")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x5E54940", Offset = "0x5E53740", VA = "0x185E54940", Slot = "4")]
	public bool COFEFJFFGMK(KIBKAPDMHFC NBHCOBHPFBM, [Out] EAMGFLAKCOJ KPBDFPNEODJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(DGFEGLOPOPB), new string[] { })]
internal sealed class DGFEGLOPOPB : POKGICLLPAE
{
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private readonly Dictionary<Type, EAMGFLAKCOJ> NLFJDPDMBPJ;

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x5E46EE0", Offset = "0x5E45CE0", VA = "0x185E46EE0", Slot = "4")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x5E47000", Offset = "0x5E45E00", VA = "0x185E47000")]
	public void MCJJKKHGDCC(Type PEMNIEMPPLO, EAMGFLAKCOJ KPBDFPNEODJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x5E46F30", Offset = "0x5E45D30", VA = "0x185E46F30")]
	public bool COFEFJFFGMK(Type PEMNIEMPPLO, [Out] EAMGFLAKCOJ KPBDFPNEODJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x5E471B0", Offset = "0x5E45FB0", VA = "0x185E471B0")]
	public DGFEGLOPOPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
internal static class ILNGONPEAKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x5E4C5C0", Offset = "0x5E4B3C0", VA = "0x185E4C5C0")]
	public static void MCJJKKHGDCC(this DGFEGLOPOPB KCDMGGDCPJH, EAMGFLAKCOJ KPBDFPNEODJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[AlwaysUpdateSystem]
internal class JAAAIPJEJIE : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public JAAAIPJEJIE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public class UpdateAuthoredChildrenFromParent : ParentSystemBase<AuthoredParentData, AuthoredPreviousParentData, AuthoredChildrenData>
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B010", Offset = "0x5E59E10", VA = "0x185E5B010", Slot = "14")]
		protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x89AA00", Offset = "0x899800", VA = "0x18089AA00", Slot = "15")]
		protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5AFD0", Offset = "0x5E59DD0", VA = "0x185E5AFD0", Slot = "16")]
		protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5AF90", Offset = "0x5E59D90", VA = "0x185E5AF90", Slot = "17")]
		protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B050", Offset = "0x5E59E50", VA = "0x185E5B050")]
		public UpdateAuthoredChildrenFromParent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal class EEAKHKABHCM : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private object ACEFCEIFFAO;

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5E47FC0", Offset = "0x5E46DC0", VA = "0x185E47FC0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5E48040", Offset = "0x5E46E40", VA = "0x185E48040", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5E480F0", Offset = "0x5E46EF0", VA = "0x185E480F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public EEAKHKABHCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
internal class CHEGLIMBMPA : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private object ACEFCEIFFAO;

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5E44E80", Offset = "0x5E43C80", VA = "0x185E44E80", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5E44F00", Offset = "0x5E43D00", VA = "0x185E44F00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5E44FB0", Offset = "0x5E43DB0", VA = "0x185E44FB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public CHEGLIMBMPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[InternalBufferCapacity(1)]
internal struct IIODAEJLJLP : ISystemStateBufferElementData, IBufferElementData, IEquatable<IIODAEJLJLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public EPIGKLHPIIP KMOBDGPHBOK;

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x5E48880", Offset = "0x5E47680", VA = "0x185E48880", Slot = "4")]
	public bool Equals(IIODAEJLJLP MFMJJEFODHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static IIODAEJLJLP FMKGPFEKDFI(EPIGKLHPIIP KMOBDGPHBOK)
	{
		return default(IIODAEJLJLP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[InternalBufferCapacity(4)]
internal struct FOCLNLPCCKA : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public EPIGKLHPIIP KMOBDGPHBOK;
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal abstract class GMNAIHHHGDI : MEBPPBHMHCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x5E4AF40", Offset = "0x5E49D40", VA = "0x185E4AF40", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B220", Offset = "0x5E4A020", VA = "0x185E4B220", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5E44E30", Offset = "0x5E43C30", VA = "0x185E44E30")]
	protected GMNAIHHHGDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
[ICOGLANPNEA]
internal abstract class MEBPPBHMHCD : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	protected IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	protected BGJEPDMMNIC HHJJKPNJLAD;

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	protected abstract NGFHGKLKAOE IOPNCBDOBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5E55200", Offset = "0x5E54000", VA = "0x185E55200", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5E54D00", Offset = "0x5E53B00", VA = "0x185E54D00")]
	protected void AJNGHCODAFE(EntityQuery LKMIGFDOIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5E54F80", Offset = "0x5E53D80", VA = "0x185E54F80")]
	protected void IOFFAHDPIJF(EntityQuery LKMIGFDOIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5E55270", Offset = "0x5E54070", VA = "0x185E55270")]
	protected EOLLFEKBMDA PEEOEDGFCCD(EntityQuery LKMIGFDOIIA)
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	protected MEBPPBHMHCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
internal abstract class HKMJBPKAFMB : MEBPPBHMHCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private EntityQuery EKIJNIEANOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private EntityQuery IBDDADFAFJE;

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B940", Offset = "0x5E4A740", VA = "0x185E4B940", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x5E4BCA0", Offset = "0x5E4AAA0", VA = "0x185E4BCA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x5E4B850", Offset = "0x5E4A650", VA = "0x185E4B850")]
	private void CPEJNMAIOMF(EntityQuery LKMIGFDOIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x5E49050", Offset = "0x5E47E50", VA = "0x185E49050")]
	protected HKMJBPKAFMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal class NAHHJMJLGJP : GMNAIHHHGDI
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	protected override NGFHGKLKAOE IOPNCBDOBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x5E57140", Offset = "0x5E55F40", VA = "0x185E57140", Slot = "15")]
		get
		{
			return default(NGFHGKLKAOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x5E44E30", Offset = "0x5E43C30", VA = "0x185E44E30")]
	public NAHHJMJLGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal class NONLEPKJLIE : HKMJBPKAFMB
{
	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	protected override NGFHGKLKAOE IOPNCBDOBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x5E580E0", Offset = "0x5E56EE0", VA = "0x185E580E0", Slot = "15")]
		get
		{
			return default(NGFHGKLKAOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x5E49050", Offset = "0x5E47E50", VA = "0x185E49050")]
	public NONLEPKJLIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal class CCNFBCCKFKH : GMNAIHHHGDI
{
	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	protected override NGFHGKLKAOE IOPNCBDOBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x5E44DC0", Offset = "0x5E43BC0", VA = "0x185E44DC0", Slot = "15")]
		get
		{
			return default(NGFHGKLKAOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x5E44E30", Offset = "0x5E43C30", VA = "0x185E44E30")]
	public CCNFBCCKFKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
internal class IHDMGEPLMNM : HKMJBPKAFMB
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	protected override NGFHGKLKAOE IOPNCBDOBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x5E4C460", Offset = "0x5E4B260", VA = "0x185E4C460", Slot = "15")]
		get
		{
			return default(NGFHGKLKAOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x5E49050", Offset = "0x5E47E50", VA = "0x185E49050")]
	public IHDMGEPLMNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
internal class NLJOGHKEFOB : GMNAIHHHGDI
{
	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	protected override NGFHGKLKAOE IOPNCBDOBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x5E58070", Offset = "0x5E56E70", VA = "0x185E58070", Slot = "15")]
		get
		{
			return default(NGFHGKLKAOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E44E30", Offset = "0x5E43C30", VA = "0x185E44E30")]
	public NLJOGHKEFOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
internal class FHCOGAFAPBJ : HKMJBPKAFMB
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	protected override NGFHGKLKAOE IOPNCBDOBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E48FE0", Offset = "0x5E47DE0", VA = "0x185E48FE0", Slot = "15")]
		get
		{
			return default(NGFHGKLKAOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E49050", Offset = "0x5E47E50", VA = "0x185E49050")]
	public FHCOGAFAPBJ()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
internal struct CMFJBENKMEB : ISystemStateComponentData, IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DA")]
internal struct HDECBNJBOJP : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DB")]
internal struct OIGGPPPAKGD : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public readonly struct NGFHGKLKAOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly ComponentType? GEFPMCPMBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly ComponentType? GPBKAFGHKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly ComponentType NDJLOKDDIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly object PFKLELGAJPH;

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E57220", Offset = "0x5E56020", VA = "0x185E57220")]
	public NGFHGKLKAOE(ComponentType? GEFPMCPMBGC, ComponentType? GPBKAFGHKAO, ComponentType NDJLOKDDIPA, object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x24CF960", Offset = "0x24CE760", VA = "0x1824CF960")]
	public static NGFHGKLKAOE IHONDGNHKNK<TReq, TTag>(object PFKLELGAJPH)
	{
		return default(NGFHGKLKAOE);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x24CF740", Offset = "0x24CE540", VA = "0x1824CF740")]
	public static NGFHGKLKAOE DMMCMJEALFD<TReq, TMissing, TTag>(object PFKLELGAJPH)
	{
		return default(NGFHGKLKAOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public static class FDDGDIFEPGP
{
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public static readonly NGFHGKLKAOE DGEOMMEHEDE;

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public static readonly NGFHGKLKAOE NJNJEHENFOM;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public static readonly NGFHGKLKAOE JDLIFOFDBOO;
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal struct EPIGKLHPIIP : BLILJFBNCDH, IEquatable<EPIGKLHPIIP>
{
	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public int CPCFHDJMLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x9906E0", Offset = "0x98F4E0", VA = "0x1809906E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B50", Offset = "0x7F0950", VA = "0x1807F1B50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public int MMJFKHJNAML
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x1FBBF30", Offset = "0x1FBAD30", VA = "0x181FBBF30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x51FC460", Offset = "0x51FB260", VA = "0x1851FC460", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E48880", Offset = "0x5E47680", VA = "0x185E48880", Slot = "8")]
	public bool Equals(EPIGKLHPIIP MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E488D0", Offset = "0x5E476D0", VA = "0x185E488D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
	[CompilerGenerated]
	[ICOGLANPNEA]
	public class UpdateConnectableVisualsSystem : FMBIPPPJNCE, IJCLFGAEMDL
	{
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		private struct HandlePosition
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AF")]
			public EPIGKLHPIIP handle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002B0")]
			public float3 position;

			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x42138A0", Offset = "0x42126A0", VA = "0x1842138A0")]
			public HandlePosition(EPIGKLHPIIP handle, float3 position)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x5E4BE00", Offset = "0x5E4AC00", VA = "0x185E4BE00")]
			public void EIMGPDKFHGM([Out] EPIGKLHPIIP handle, [Out] float3 position)
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
			public ComponentTypeHandle<GLPHDKJHCLN> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public BufferTypeHandle<FOCLNLPCCKA> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x5E5FF80", Offset = "0x5E5ED80", VA = "0x185E5FF80")]
			private void LFGCENJAPBK(Entity entity, [In] GLPHDKJHCLN pose, DynamicBuffer<FOCLNLPCCKA> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x5E5FDC0", Offset = "0x5E5EBC0", VA = "0x185E5FDC0", Slot = "4")]
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
			public ComponentTypeHandle<GLPHDKJHCLN> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			public BufferTypeHandle<IIODAEJLJLP> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0x5E5FCD0", Offset = "0x5E5EAD0", VA = "0x185E5FCD0")]
			private void LFGCENJAPBK([In][NoAlias] GLPHDKJHCLN pose, DynamicBuffer<IIODAEJLJLP> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x5E5FB60", Offset = "0x5E5E960", VA = "0x185E5FB60", Slot = "4")]
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
			public ComponentTypeHandle<GLPHDKJHCLN> __poseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			[ReadOnly]
			public ComponentTypeHandle<LGDFPOGFODA> __comTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			public BufferTypeHandle<IIODAEJLJLP> __stateTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x5E5F9F0", Offset = "0x5E5E7F0", VA = "0x185E5F9F0")]
			private void LFGCENJAPBK([In][NoAlias] GLPHDKJHCLN pose, [In][NoAlias] LGDFPOGFODA com, DynamicBuffer<IIODAEJLJLP> state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0x5E5F810", Offset = "0x5E5E610", VA = "0x185E5F810", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private static readonly GKFGDEJLFAD log;

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
		private DAMCLELNJPB<EPIGKLHPIIP, EAKFNHOGHCF> linkVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private ILHIPOGALPJ connectables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private IKBNJJBMJGF objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private PHJHPLJJLBK scope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private FKKFPKNDNMB makerPen;

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
		private ComponentTypeHandle<GLPHDKJHCLN> __RecRoom_Components_WorldPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private ComponentTypeHandle<LGDFPOGFODA> __RecRoom_Rbex_RbexLocalCenterOfMassOfSelfData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x5E5D560", Offset = "0x5E5C360", VA = "0x185E5D560")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B450", Offset = "0x5E5A250", VA = "0x185E5B450")]
		internal EAKFNHOGHCF BAJOPKGAOAM(EPIGKLHPIIP handle)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CCA0", Offset = "0x5E5BAA0", VA = "0x185E5CCA0", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EB20", Offset = "0x5E5D920", VA = "0x185E5EB20", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EDB0", Offset = "0x5E5DBB0", VA = "0x185E5EDB0", Slot = "6")]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EF40", Offset = "0x5E5DD40", VA = "0x185E5EF40", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E5ED70", Offset = "0x5E5DB70", VA = "0x185E5ED70", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DBD0", Offset = "0x5E5C9D0", VA = "0x185E5DBD0")]
		private void MPIELHPANOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DEB0", Offset = "0x5E5CCB0", VA = "0x185E5DEB0")]
		private void OHALMHOOOFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D850", Offset = "0x5E5C650", VA = "0x185E5D850")]
		private void MCOEGDEIOIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EF80", Offset = "0x5E5DD80", VA = "0x185E5EF80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F180", Offset = "0x5E5DF80", VA = "0x185E5F180")]
		private void PFMOOMMEHLD(EntityQuery add, EntityQuery update, EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CA20", Offset = "0x5E5B820", VA = "0x185E5CA20")]
		private void ILBKIBAINPM(EntityQuery remove)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D2F0", Offset = "0x5E5C0F0", VA = "0x185E5D2F0")]
		private void JNBFENMFPCC(NativeArrayAsync<Entity> oldEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C080", Offset = "0x5E5AE80", VA = "0x185E5C080")]
		private void FKNLHAFCIIL(NativeArrayAsync<Entity> newEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C1C0", Offset = "0x5E5AFC0", VA = "0x185E5C1C0")]
		private void FMMCMHMICOA(NativeArrayAsync<Entity> updateEntities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E5BCA0", Offset = "0x5E5AAA0", VA = "0x185E5BCA0")]
		private void EIKCBABJNAG(NativeList<EPIGKLHPIIP> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C310", Offset = "0x5E5B110", VA = "0x185E5C310")]
		private NativeList<EPIGKLHPIIP> HIOOMLEDFCJ(NativeArray<Entity> entities)
		{
			return default(NativeList<EPIGKLHPIIP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B630", Offset = "0x5E5A430", VA = "0x185E5B630")]
		private void ECGHJAEGKBM(NativeArray<Entity> entities, NativeList<EPIGKLHPIIP> freeLinks)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CD60", Offset = "0x5E5BB60", VA = "0x185E5CD60")]
		private void JDCAHAIEJBG(NativeArray<Entity> addParents, NativeArray<Entity> addChildren, NativeList<EPIGKLHPIIP> freeList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E000", Offset = "0x5E5CE00", VA = "0x185E5E000")]
		private void OJGJGMCGGLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D5A0", Offset = "0x5E5C3A0", VA = "0x185E5D5A0")]
		private NativeListAsync<HandlePosition> KOJCKJMKPOI(EntityQuery query, Func<NativeList<HandlePosition>, JobHandle> populateHandles)
		{
			return default(NativeListAsync<HandlePosition>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B090", Offset = "0x5E59E90", VA = "0x185E5B090")]
		private JobHandle ACEFBLKOJCC(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D6E0", Offset = "0x5E5C4E0", VA = "0x185E5D6E0")]
		private JobHandle LBGFPDKLKGF(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CB10", Offset = "0x5E5B910", VA = "0x185E5CB10")]
		private JobHandle INOLMMFKMPJ(NativeList<HandlePosition> list)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5BE20", Offset = "0x5E5AC20", VA = "0x185E5BE20")]
		private void FGJBMBHJMAI(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B1F0", Offset = "0x5E59FF0", VA = "0x185E5B1F0")]
		private void ADIKCCOCJJK(NativeListAsync<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x5E5BC20", Offset = "0x5E5AA20", VA = "0x185E5BC20")]
		private bool EGHBBBJPIFG(Entity entity)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F0B0", Offset = "0x5E5DEB0", VA = "0x185E5F0B0")]
		private NativeArray<Entity> PDNPCFJFMEK(Entity entity)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DCF0", Offset = "0x5E5CAF0", VA = "0x185E5DCF0")]
		private EPIGKLHPIIP NAGCLFBJPMJ(NativeList<EPIGKLHPIIP> freeList)
		{
			return default(EPIGKLHPIIP);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C130", Offset = "0x5E5AF30", VA = "0x185E5C130")]
		private void FMJPHFGJEII(EPIGKLHPIIP handle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F640", Offset = "0x5E5E440", VA = "0x185E5F640")]
		private void PMBIMIFHNKK(NativeList<HandlePosition> list)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C8C0", Offset = "0x5E5B6C0", VA = "0x185E5C8C0")]
		private JobHandle HJCEIHCEPDK(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B4A0", Offset = "0x5E5A2A0", VA = "0x185E5B4A0")]
		private JobHandle DBHMOACGKAC(NativeList<HandlePosition> list, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E4E0", Offset = "0x5E5D2E0", VA = "0x185E5E4E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public UpdateConnectableVisualsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	public class CalculateCollisionIslandUpdatesSystem : FMBIPPPJNCE, IJCLFGAEMDL
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
			public ComponentTypeHandle<EJJFAPGOCID> collisionIslandRootDataHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002C8")]
			[ReadOnly]
			public ComponentDataFromEntity<EJJFAPGOCID> collisionIslandRootDataFromEntityRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002C9")]
			[ReadOnly]
			public ComponentTypeHandle<OKOJMLFLNIA> splineParentHandleRO;

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
			[Cpp2IlInjected.Address(RVA = "0x5E45840", Offset = "0x5E44640", VA = "0x185E45840")]
			private void LFGCENJAPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x5E45830", Offset = "0x5E44630", VA = "0x185E45830", Slot = "4")]
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
		private KHOPPHCEAEP collisionIslandService;

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E45640", Offset = "0x5E44440", VA = "0x185E45640", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E46040", Offset = "0x5E44E40", VA = "0x185E46040", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E463D0", Offset = "0x5E451D0", VA = "0x185E463D0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E45690", Offset = "0x5E44490", VA = "0x185E45690")]
		private JobHandle LBBMCFKGLKN(NativeList<Entity> rootsWithForcedCollisionUpdate, NativeList<Entity> rootsWithoutForcedCollisionUpdate, ComponentTypeHandle<EJJFAPGOCID> collisionIslandRootDataHandleRO, ComponentDataFromEntity<EJJFAPGOCID> collisionIslandRootDataFromEntityRO, ComponentTypeHandle<OKOJMLFLNIA> splineParentHandleRO, EntityQueryInJob changedLocalPoseQueryInJob, EntityQueryInJob changedSplinePointsQueryInJob, EntityQueryInJob splinesWithChangedChildrenQueryInJob, EntityQueryInJob changedCollisionModeQueryInJob, EntityQueryInJob changedScopeRootQueryInJob, Allocator allocator, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public CalculateCollisionIslandUpdatesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
[BurstCompatible]
internal readonly struct FHMIMDOPKNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	private readonly MDBNEJGOCFE CNFAPNGILPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private readonly EDLMMIAOCLP OHBNMFIHJMC;

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x9712C0", Offset = "0x9700C0", VA = "0x1809712C0")]
	public FHMIMDOPKNL(MDBNEJGOCFE CNFAPNGILPM, EDLMMIAOCLP OHBNMFIHJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x1B54480", Offset = "0x1B53280", VA = "0x181B54480")]
	public bool HMGIBKOHDCN(FHMIMDOPKNL LBLLNFOEKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x1B54480", Offset = "0x1B53280", VA = "0x181B54480")]
	public bool JEEEIANGELP(FHMIMDOPKNL FKKAOLHJCBE)
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
	public class CalculateContainerCollisionIslandGraphChangesSystem : FMBIPPPJNCE, IJCLFGAEMDL
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
			public ComponentTypeHandle<FAMLAGKPFED> islandRootSystemDataTypeHandleRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40002E2")]
			[ReadOnly]
			public ComponentDataFromEntity<MHCAEFKDDBJ> dontPropagatePhysicsPropertiesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			[ReadOnly]
			public ComponentDataFromEntity<MDBNEJGOCFE> containerCollisionModeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			[ReadOnly]
			public ComponentDataFromEntity<EDLMMIAOCLP> containerCollisionLayerRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			[ReadOnly]
			public ComponentDataFromEntity<PJDPKOPAPBO> containerCollisionIslandRootTagRO;

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
			public NativeList<HCJNPEJCLCD> changedIslandRootsWO;

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
			public ComponentDataFromEntity<EJJFAPGOCID> collisionIslandRootDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public NativeParallelHashSet<Entity> visitedRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			private int bufferHead;

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x5E6BA20", Offset = "0x5E6A820", VA = "0x185E6BA20", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x5E6C4A0", Offset = "0x5E6B2A0", VA = "0x185E6C4A0")]
			private void PKCANILADGK(Entity startEntity, bool checkForUnchanged)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x5E6C420", Offset = "0x5E6B220", VA = "0x185E6C420")]
			private Entity MFPCKCNJDOG(Entity curEntity, FHMIMDOPKNL classifier)
			{
				return default(Entity);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x5E6B960", Offset = "0x5E6A760", VA = "0x185E6B960")]
			private bool DFNAPLDDBDP(Entity curEntity, FHMIMDOPKNL classifier, [Out] Entity parentEntity, [Out] FHMIMDOPKNL parentClassifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F4")]
			[Cpp2IlInjected.Address(RVA = "0x5E6C1E0", Offset = "0x5E6AFE0", VA = "0x185E6C1E0")]
			private void HJLKDBLDDCC(Entity islandRoot, FHMIMDOPKNL classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E6C650", Offset = "0x5E6B450", VA = "0x185E6C650")]
			private void PKKKNHHILLE(Entity islandRoot, Entity entity, FHMIMDOPKNL classifier)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F6")]
			[Cpp2IlInjected.Address(RVA = "0x5E6C0D0", Offset = "0x5E6AED0", VA = "0x185E6C0D0")]
			private void HDAFDFBGCMP(Entity islandRoot, Entity component)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x5E6C390", Offset = "0x5E6B190", VA = "0x185E6C390")]
			private bool LHOMHFNGOGD(Entity entity, [Out] FHMIMDOPKNL classifier)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x5E6C2F0", Offset = "0x5E6B0F0", VA = "0x185E6C2F0")]
			private FHMIMDOPKNL IOJBGACJFCL(Entity entity)
			{
				return default(FHMIMDOPKNL);
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
			[Cpp2IlInjected.Address(RVA = "0x5E64580", Offset = "0x5E63380", VA = "0x185E64580")]
			private void LFGCENJAPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x5E64570", Offset = "0x5E63370", VA = "0x185E64570", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		[MBPNJDODNHC]
		private KHOPPHCEAEP collisionIslandService;

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
		private FBFDNMIKAOM ecbs;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E63CC0", Offset = "0x5E62AC0", VA = "0x185E63CC0", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x5E646B0", Offset = "0x5E634B0", VA = "0x185E646B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E64B00", Offset = "0x5E63900", VA = "0x185E64B00", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E63D10", Offset = "0x5E62B10", VA = "0x185E63D10")]
		private JobHandle JEILDMMPFDM(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E63A00", Offset = "0x5E62800", VA = "0x185E63A00")]
		private JobHandle BMJPHOBJBIL(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E64470", Offset = "0x5E63270", VA = "0x185E64470")]
		private JobHandle KAEAKNNEDLD(EntityCommandBuffer ecb, NativeList<Entity> removedIslandRootsWO, EntityTypeHandle entityType, EntityQueryInJob queryInJob, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public CalculateContainerCollisionIslandGraphChangesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
[AlwaysUpdateSystem]
public class HINGBAHPKBG : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	[MBPNJDODNHC]
	private KHOPPHCEAEP BFEFFOGLFLJ;

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E8C0", Offset = "0x5E6D6C0", VA = "0x185E6E8C0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E910", Offset = "0x5E6D710", VA = "0x185E6E910", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public HINGBAHPKBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class CIFDLNLNABK : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	private FOLLILJKCFG IAMHOIOBMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private BCHNGJMGJNJ FGGANFOPJKB;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E63320", Offset = "0x5E62120", VA = "0x185E63320", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E63290", Offset = "0x5E62090", VA = "0x185E63290", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x5E63430", Offset = "0x5E62230", VA = "0x185E63430", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public CIFDLNLNABK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public class HCOMBLFGMEK : ISystemStateComponentData, IComponentData, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	public KMILLOLJKJL MENCLGMKPHE;

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HCOMBLFGMEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	public HCOMBLFGMEK(KMILLOLJKJL MENCLGMKPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E850", Offset = "0x5E6D650", VA = "0x185E6E850", Slot = "4")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EE")]
public abstract class BHLLPIOEAIP : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private GNJPLCKBNJA NPHELGDJFPC;

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x5E62020", Offset = "0x5E60E20", VA = "0x185E62020", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x5E62080", Offset = "0x5E60E80", VA = "0x185E62080", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x5E620B0", Offset = "0x5E60EB0", VA = "0x185E620B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	protected BHLLPIOEAIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class AGEMENJDFMK : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private EntityQuery LILOGMIAINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private EntityQuery IPPFDPBLGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private EntityQuery ILEHEKIOEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private EntityQuery MPCGOHDFAHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private GNJPLCKBNJA FNJFKCMGFOC;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public int ILOEKEIGPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x5E61340", Offset = "0x5E60140", VA = "0x185E61340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0x5E61500", Offset = "0x5E60300", VA = "0x185E61500", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x5E61940", Offset = "0x5E60740", VA = "0x185E61940", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x5E61B70", Offset = "0x5E60970", VA = "0x185E61B70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0x5E61320", Offset = "0x5E60120", VA = "0x185E61320")]
	public int ACCKIFBHHNL(SceneTag PIOKEHOJBEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0x5E615B0", Offset = "0x5E603B0", VA = "0x185E615B0")]
	protected void KMLFHNBGCIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0x5E613D0", Offset = "0x5E601D0", VA = "0x185E613D0")]
	protected void IMHOCOKEBLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0x5E61560", Offset = "0x5E60360", VA = "0x185E61560")]
	public NativeArrayAsync<Entity> JPBCBMLHKBK(SceneTag PIOKEHOJBEJ, Allocator JFLEKJGGDHL = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x5E618F0", Offset = "0x5E606F0", VA = "0x185E618F0")]
	public NativeArrayAsync<Entity> OFOGNNAELIK(SceneTag PIOKEHOJBEJ, Allocator JFLEKJGGDHL = Allocator.TempJob)
	{
		return default(NativeArrayAsync<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x5E617F0", Offset = "0x5E605F0", VA = "0x185E617F0")]
	public bool NHEGDEPJBIA(SceneTag PIOKEHOJBEJ, [Out] NativeArrayAsync<Entity> MENCLGMKPHE, Allocator JFLEKJGGDHL = Allocator.TempJob)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x5E61B90", Offset = "0x5E60990", VA = "0x185E61B90")]
	public bool PIACKBAOBEI(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x5E61880", Offset = "0x5E60680", VA = "0x185E61880")]
	public bool NNMNOGEKHAN(Entity CCHOHIEEHEH, [Out] HCOMBLFGMEK MENCLGMKPHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x5E61350", Offset = "0x5E60150", VA = "0x185E61350")]
	public void GICDIFJLFBE(Entity CCHOHIEEHEH, HCOMBLFGMEK MENCLGMKPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x5E61770", Offset = "0x5E60570", VA = "0x185E61770")]
	public bool KNHEAKNNENC(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public AGEMENJDFMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
internal class PIFECOBBOKF : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private EntityQuery GMGINOKMDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private CDNOLOGJCIN NBBLMGDHBPE;

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x5E789D0", Offset = "0x5E777D0", VA = "0x185E789D0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x5E78AB0", Offset = "0x5E778B0", VA = "0x185E78AB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x5E78B70", Offset = "0x5E77970", VA = "0x185E78B70", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x250AA70", Offset = "0x2509870", VA = "0x18250AA70")]
	private bool BACLOCJMPFD<TComponentData>(EntityQuery LKMIGFDOIIA, [Out] NativeArray<Entity> PFOPLIKJCHB, [Out] NativeArray<TComponentData> IAEGOGAHMLB) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x5E78A20", Offset = "0x5E77820", VA = "0x185E78A20")]
	public KMILLOLJKJL NHOCPLLDCPG(Entity CCHOHIEEHEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public PIFECOBBOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public class NOCNJKNKOHJ : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private EntityQuery OPEGEHMAALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private EntityQuery AJKMAONELCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private EntityQuery FDCOIMPGAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private EntityQuery OKMLGKHOHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private ELICKPPOGGA NBBLMGDHBPE;

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x5E76FB0", Offset = "0x5E75DB0", VA = "0x185E76FB0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x5E77000", Offset = "0x5E75E00", VA = "0x185E77000", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x5E77280", Offset = "0x5E76080", VA = "0x185E77280", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x5E76B10", Offset = "0x5E75910", VA = "0x185E76B10")]
	private void AAFNAGDLNDC(EntityQuery LKMIGFDOIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x5E76F20", Offset = "0x5E75D20", VA = "0x185E76F20")]
	private void ILBKIBAINPM(EntityQuery LKMIGFDOIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x5E771F0", Offset = "0x5E75FF0", VA = "0x185E771F0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x5E76BA0", Offset = "0x5E759A0", VA = "0x185E76BA0")]
	private void BNLNCFEGHFC(EntityQuery LKMIGFDOIIA, bool JHIOODBNMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public NOCNJKNKOHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
public sealed class IPEPIBMCBBA : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private KBGIFACAFJI GDPHBAAKIOG;

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EAE0", Offset = "0x5E6D8E0", VA = "0x185E6EAE0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EB40", Offset = "0x5E6D940", VA = "0x185E6EB40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public IPEPIBMCBBA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	public class GatherModifiedParentsSystem : FMBIPPPJNCE, FKNGAHGHIJP
	{
		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct GatherModifiedParents_AddNewParents_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public NativeList<HDFBIPFPCNK> newParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __currentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0x5E6E630", Offset = "0x5E6D430", VA = "0x185E6E630")]
			private void LFGCENJAPBK(Entity entity, [In][NoAlias] ParentData current)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x5E6E510", Offset = "0x5E6D310", VA = "0x185E6E510", Slot = "4")]
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
			public NativeList<CIINDJLMCOJ> changedParents;

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
			[Cpp2IlInjected.Address(RVA = "0x5E6E450", Offset = "0x5E6D250", VA = "0x185E6E450")]
			private void LFGCENJAPBK(Entity entity, [In][NoAlias] ParentData current, [In][NoAlias] PreviousParentData previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x5E6E2B0", Offset = "0x5E6D0B0", VA = "0x185E6E2B0", Slot = "4")]
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
			public NativeList<HDFBIPFPCNK> oldParents;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000317")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000318")]
			[ReadOnly]
			public ComponentTypeHandle<PreviousParentData> __previousTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000636")]
			[Cpp2IlInjected.Address(RVA = "0x5E6E7D0", Offset = "0x5E6D5D0", VA = "0x185E6E7D0")]
			private void LFGCENJAPBK(Entity entity, [In][NoAlias] PreviousParentData previous)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x5E6E6B0", Offset = "0x5E6D4B0", VA = "0x185E6E6B0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private HBFNKHCAGGC parentEvents;

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
		[Cpp2IlInjected.Address(RVA = "0x5E6D4F0", Offset = "0x5E6C2F0", VA = "0x185E6D4F0", Slot = "14")]
		public void JKGLFHNGJKP(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DDE0", Offset = "0x5E6CBE0", VA = "0x185E6DDE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D5D0", Offset = "0x5E6C3D0", VA = "0x185E6D5D0")]
		private JobHandle LACBHPGBGGO(NativeList<HDFBIPFPCNK> newParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E150", Offset = "0x5E6CF50", VA = "0x185E6E150")]
		private JobHandle PKKIBOBPDFC(NativeList<CIINDJLMCOJ> changedParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D6F0", Offset = "0x5E6C4F0", VA = "0x185E6D6F0")]
		private JobHandle LAEGINHCNJE(NativeList<HDFBIPFPCNK> oldParents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D810", Offset = "0x5E6C610", VA = "0x185E6D810", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public GatherModifiedParentsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public class GDGLBBGBILL : ParentSystemBase<ParentData, PreviousParentData, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C910", Offset = "0x5E6B710", VA = "0x185E6C910", Slot = "14")]
	protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc LKMIGFDOIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x89AA00", Offset = "0x899800", VA = "0x18089AA00", Slot = "15")]
	protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc LKMIGFDOIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C8D0", Offset = "0x5E6B6D0", VA = "0x185E6C8D0", Slot = "16")]
	protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc LKMIGFDOIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C890", Offset = "0x5E6B690", VA = "0x185E6C890", Slot = "17")]
	protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc LKMIGFDOIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C950", Offset = "0x5E6B750", VA = "0x185E6C950")]
	public GDGLBBGBILL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000F8")]
	public abstract class ParentSystemBase<TParentData, TPreviousParentData, TChildrenData> : FMBIPPPJNCE where TParentData : struct, IComponentData, DPJHIPLKBBA where TPreviousParentData : struct, IComponentData, DPJHIPLKBBA where TChildrenData : struct, ISystemStateBufferElementData, IEquatable<TChildrenData>, DPJHIPLKBBA
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
			[Cpp2IlInjected.Address(RVA = "0x34E38B0", Offset = "0x34E26B0", VA = "0x1834E38B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x3423600", Offset = "0x3422400", VA = "0x183423600", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x342BC90", Offset = "0x342AA90", VA = "0x18342BC90")]
			private int FindChildIndex(DynamicBuffer<TChildrenData> children, Entity entity)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x342BD70", Offset = "0x342AB70", VA = "0x18342BD70")]
			private void RemoveChildrenFromParent(Entity parent, DynamicBuffer<TChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600064F")]
			[Cpp2IlInjected.Address(RVA = "0x342B7B0", Offset = "0x342A5B0", VA = "0x18342B7B0")]
			private void AddChildrenToParent(Entity parent, DynamicBuffer<TChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x342B8F0", Offset = "0x342A6F0", VA = "0x18342B8F0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x34E3FD0", Offset = "0x34E2DD0", VA = "0x1834E3FD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E27000", Offset = "0x3E25E00", VA = "0x183E27000")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x3E248B0", Offset = "0x3E236B0", VA = "0x183E248B0")]
		private int FindChildIndex(DynamicBuffer<TChildrenData> children, Entity entity)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x3E253A0", Offset = "0x3E241A0", VA = "0x183E253A0")]
		private void RemoveChildFromParent(Entity childEntity, Entity parentEntity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x89AA00", Offset = "0x899800", VA = "0x18089AA00", Slot = "14")]
		protected virtual EntityQueryDesc FilterNewParentQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x89AA00", Offset = "0x899800", VA = "0x18089AA00", Slot = "15")]
		protected virtual EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x89AA00", Offset = "0x899800", VA = "0x18089AA00", Slot = "16")]
		protected virtual EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc query)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc query);

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x3E249B0", Offset = "0x3E237B0", VA = "0x183E249B0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x3E26B30", Offset = "0x3E25930", VA = "0x183E26B30")]
		private void UpdateNewParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x3E26E10", Offset = "0x3E25C10", VA = "0x183E26E10")]
		private void UpdateRemoveParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x3E25BA0", Offset = "0x3E249A0", VA = "0x183E25BA0")]
		private JobHandle UpdateChangeParents(JobHandle dependsOn)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x3E26620", Offset = "0x3E25420", VA = "0x183E26620")]
		private void UpdateDeletedParents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x3E25120", Offset = "0x3E23F20", VA = "0x183E25120", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x3E250F0", Offset = "0x3E23EF0", VA = "0x183E250F0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
[AlwaysUpdateSystem]
public abstract class NMDHNPPDADH : FMBIPPPJNCE, FKNGAHGHIJP
{
	[Cpp2IlInjected.Token(Token = "0x20000FE")]
	private struct CBGEHEHEGCA : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public NativeListAsync<Entity> GILJENBMFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public NativeListAsync<Entity> LBEJPKAEAPF;

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x5E629B0", Offset = "0x5E617B0", VA = "0x185E629B0")]
		public CBGEHEHEGCA(NativeList<Entity> GILJENBMFFK, NativeList<Entity> LBEJPKAEAPF, JobHandle GLEFMKPHENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x5E628A0", Offset = "0x5E616A0", VA = "0x185E628A0")]
		public JobHandle DONELOPJMFI(JobHandle AHKLOHOGJID)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x5E62920", Offset = "0x5E61720", VA = "0x185E62920", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[BurstCompile]
	private struct EODCKCKDDPN : IJob
	{
		[Cpp2IlInjected.Token(Token = "0x2000100")]
		[Flags]
		public enum BEDFIKBILCJ
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
		public NativeList<Entity> JGIIPONOCDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		[WriteOnly]
		public NativeList<Entity> ODLFFKOMBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		[ReadOnly]
		public NativeArray<Entity> NPBLDFEAKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> HMPKEEFNECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[ReadOnly]
		public ComponentDataFromEntity ACBMGOBOINJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[ReadOnly]
		public ComponentDataFromEntity BMLLOOIMGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> AINNNNJOPIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public int DIPDPLIJENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public int FIOKCFHNOCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private BEDFIKBILCJ EPFBMJBFGDE;

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x5E699A0", Offset = "0x5E687A0", VA = "0x185E699A0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x5E69700", Offset = "0x5E68500", VA = "0x185E69700")]
		private bool BHKCMKPPAJN(Entity CCHOHIEEHEH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x5E69890", Offset = "0x5E68690", VA = "0x185E69890")]
		private void DOCLMDCIOKO(Entity CCHOHIEEHEH, bool NFKJAHBMBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x5E69DD0", Offset = "0x5E68BD0", VA = "0x185E69DD0")]
		private void KKDLGHFDKJA(Entity CCHOHIEEHEH, bool NFKJAHBMBCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x5E69920", Offset = "0x5E68720", VA = "0x185E69920")]
		public CBGEHEHEGCA ECOPFLPEFIJ(NativeArray<Entity> HACNEBJEDOA, JobHandle AHKLOHOGJID)
		{
			return default(CBGEHEHEGCA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x5E69D50", Offset = "0x5E68B50", VA = "0x185E69D50")]
		public CBGEHEHEGCA HNKDHPIJLAG(NativeArray<Entity> HACNEBJEDOA, JobHandle AHKLOHOGJID)
		{
			return default(CBGEHEHEGCA);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x5E69FB0", Offset = "0x5E68DB0", VA = "0x185E69FB0")]
		public CBGEHEHEGCA OGFAMEFKMIH(NativeList<HDFBIPFPCNK> NDKEAGMKBJJ, JobHandle AHKLOHOGJID)
		{
			return default(CBGEHEHEGCA);
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x5E69ED0", Offset = "0x5E68CD0", VA = "0x185E69ED0")]
		public CBGEHEHEGCA NAOLBEBNPGC(NativeList<HDFBIPFPCNK> NDKEAGMKBJJ, JobHandle AHKLOHOGJID)
		{
			return default(CBGEHEHEGCA);
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x5E697B0", Offset = "0x5E685B0", VA = "0x185E697B0")]
		public CBGEHEHEGCA BOHEAMMFLFC(NativeList<CIINDJLMCOJ> NDKEAGMKBJJ, JobHandle AHKLOHOGJID)
		{
			return default(CBGEHEHEGCA);
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x297EE30", Offset = "0x297DC30", VA = "0x18297EE30")]
		private CBGEHEHEGCA FHLKAPEODEP<T>(NativeList<T> NDKEAGMKBJJ, int FGOFPANOEFL, int ABKPOMCOPON, BEDFIKBILCJ CPGOEPLHNCL, JobHandle AHKLOHOGJID) where T : struct
		{
			return default(CBGEHEHEGCA);
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x5E69AD0", Offset = "0x5E688D0", VA = "0x185E69AD0")]
		private CBGEHEHEGCA FHLKAPEODEP(NativeArray<Entity> PFOPLIKJCHB, int FGOFPANOEFL, int ABKPOMCOPON, BEDFIKBILCJ CPGOEPLHNCL, JobHandle AHKLOHOGJID)
		{
			return default(CBGEHEHEGCA);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	private readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	private EntityQuery HBADEEIBLHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	private EntityQuery KJHAFHJBMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	private HBFNKHCAGGC OEPFLMLINJK;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	protected abstract ComponentType GMGOAKOIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	protected abstract ComponentType DBDCLBELNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	protected abstract ComponentType GJDPPILFOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x5E76AE0", Offset = "0x5E758E0", VA = "0x185E76AE0")]
	protected NMDHNPPDADH(GKFGDEJLFAD CGHEBMJOFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x5E75280", Offset = "0x5E74080", VA = "0x185E75280", Slot = "14")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x5E75360", Offset = "0x5E74160", VA = "0x185E75360", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x5E75570", Offset = "0x5E74370", VA = "0x185E75570", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x7E7EE0", Offset = "0x7E6CE0", VA = "0x1807E7EE0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x5E74E50", Offset = "0x5E73C50", VA = "0x185E74E50")]
	private void GOCLFGKFBBH(NativeArray<Entity> NDKEAGMKBJJ, EntityCommandBuffer GFFHLFCGKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x5E751E0", Offset = "0x5E73FE0", VA = "0x185E751E0")]
	private void JCKFLBAGBLA(NativeArray<Entity> NDKEAGMKBJJ, EntityCommandBuffer GFFHLFCGKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x5E76990", Offset = "0x5E75790", VA = "0x185E76990")]
	private void PNHLOPCFDAN(CBGEHEHEGCA JFLGAAJGNGP, string GHLBNBHOOGO, EntityCommandBuffer GFFHLFCGKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x5E76860", Offset = "0x5E75660", VA = "0x185E76860")]
	private void PNHLOPCFDAN(NativeListAsync<Entity> GOGGDHJNJPD, string GHLBNBHOOGO, EntityCommandBuffer GFFHLFCGKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x5E74EF0", Offset = "0x5E73CF0", VA = "0x185E74EF0")]
	private void HGMFEDLBBMK(CBGEHEHEGCA JFLGAAJGNGP, string GHLBNBHOOGO, EntityCommandBuffer GFFHLFCGKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0x5E75040", Offset = "0x5E73E40", VA = "0x185E75040")]
	private void HGMFEDLBBMK(NativeListAsync<Entity> GOGGDHJNJPD, string GHLBNBHOOGO, EntityCommandBuffer GFFHLFCGKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x5E75170", Offset = "0x5E73F70", VA = "0x185E75170")]
	private bool HIFOIFBFODK()
	{
		return default(bool);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
	public class PhysicsSceneAddCollidersSystem : FMBIPPPJNCE, IJCLFGAEMDL
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
			[Cpp2IlInjected.Address(RVA = "0x5E799E0", Offset = "0x5E787E0", VA = "0x185E799E0")]
			private void LFGCENJAPBK(Entity e)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x5E79930", Offset = "0x5E78730", VA = "0x185E79930", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private OKHDDGEJIGL ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private EPMCOHFCLHA colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private EntityQuery PhysicsSceneAddCollidersSystem_Query;

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x5E79CD0", Offset = "0x5E78AD0", VA = "0x185E79CD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(RVA = "0x5E798D0", Offset = "0x5E786D0", VA = "0x185E798D0", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x5E79D30", Offset = "0x5E78B30", VA = "0x185E79D30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x5E797E0", Offset = "0x5E785E0", VA = "0x185E797E0")]
		private void IMPJCDJJNNO(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x5E79B00", Offset = "0x5E78900", VA = "0x185E79B00", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PhysicsSceneAddCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
[NJOEKALHIJD(DAEAEJBLHHK.OMRoom)]
[ICOGLANPNEA]
public class DBCNICBCAAM : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private EPMCOHFCLHA JDJHJONLFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private OPNGBJLAHIJ JOEFEJIMKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x6000677")]
	[Cpp2IlInjected.Address(RVA = "0x5E66370", Offset = "0x5E65170", VA = "0x185E66370", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000678")]
	[Cpp2IlInjected.Address(RVA = "0x5E663E0", Offset = "0x5E651E0", VA = "0x185E663E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000679")]
	[Cpp2IlInjected.Address(RVA = "0x5E66490", Offset = "0x5E65290", VA = "0x185E66490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067A")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public DBCNICBCAAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public struct OADLEILHLGN : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	public LGJKCIBNPJM KMOBDGPHBOK;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600067B")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
	public static OADLEILHLGN FMKGPFEKDFI([In] LGJKCIBNPJM JKCOLLFGDGD)
	{
		return default(OADLEILHLGN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600067C")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
	public static LGJKCIBNPJM FMKGPFEKDFI([In] OADLEILHLGN AILGJCEMMJC)
	{
		return default(LGJKCIBNPJM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
[AlwaysUpdateSystem]
public class OKHDDGEJIGL : BDBHKBBMOIC
{
	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0x5E777E0", Offset = "0x5E765E0", VA = "0x185E777E0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public OKHDDGEJIGL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	[AlwaysUpdateSystem]
	[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
	public class PhysicsSceneRemoveCollidersSystem : FMBIPPPJNCE, IJCLFGAEMDL
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
			public ComponentTypeHandle<OADLEILHLGN> __chTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0x5E79FB0", Offset = "0x5E78DB0", VA = "0x185E79FB0")]
			private void LFGCENJAPBK(Entity e, [In] OADLEILHLGN ch)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x5E79E90", Offset = "0x5E78C90", VA = "0x185E79E90", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private OKHDDGEJIGL ecbs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private EPMCOHFCLHA colliderService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private EntityQuery PhysicsSceneRemoveCollidersSystem_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private ComponentTypeHandle<OADLEILHLGN> __RecRoom_ObjectModel_Systems_PhysicsSceneColliderHandleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A3A0", Offset = "0x5E791A0", VA = "0x185E7A3A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x5E79E30", Offset = "0x5E78C30", VA = "0x185E79E30", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A400", Offset = "0x5E79200", VA = "0x185E7A400", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A060", Offset = "0x5E78E60", VA = "0x185E7A060")]
		private void NODKEEGMGFB(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A190", Offset = "0x5E78F90", VA = "0x185E7A190", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PhysicsSceneRemoveCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
public class JFKCABLPFFC : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	private struct HMPAGOLEOEO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public GHKCPNCBNDO HJDMFCAGMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public NativeParallelHashSet<Entity> PFOPLIKJCHB;

		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E9D0", Offset = "0x5E6D7D0", VA = "0x185E6E9D0")]
		public HMPAGOLEOEO(int DECKGNHFLHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E960", Offset = "0x5E6D760", VA = "0x185E6E960", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[BurstCompile]
	private struct NGLEEDOFAGD : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[ReadOnly]
		public NativeArray<Entity> PFOPLIKJCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[ReadOnly]
		public ComponentDataFromEntity<GLPHDKJHCLN> NIDINNKANNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		[ReadOnly]
		public ComponentDataFromEntity<CBNJLCMNPAA> EFOHNBEOGGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		[ReadOnly]
		public ComponentDataFromEntity<CJHAAIFGNDF> ADOEDOABNKH;

		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x5E72540", Offset = "0x5E71340", VA = "0x185E72540", Slot = "4")]
		public void Execute(int DOJILIOCHKM, TransformAccess GNLAIPIBJPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[BurstCompile]
	private struct FNKJHLMOKAA : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		[ReadOnly]
		public NativeArray<Entity> PFOPLIKJCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		[ReadOnly]
		public ComponentDataFromEntity<GLPHDKJHCLN> NIDINNKANNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		[ReadOnly]
		public ComponentDataFromEntity<CJHAAIFGNDF> ADOEDOABNKH;

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B800", Offset = "0x5E6A600", VA = "0x185E6B800", Slot = "4")]
		public void Execute(int DOJILIOCHKM, TransformAccess GNLAIPIBJPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private EPMCOHFCLHA JDJHJONLFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private EntityQuery LIMPGAIBDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private EntityQuery NNCENAGOBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private EntityQuery GPMEDHMEOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private EntityQuery IGGJPJLIMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private EntityQuery PPOHECAHFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	private JobHandle PONBBIBJHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	private HMPAGOLEOEO PDALKKNAJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	private HMPAGOLEOEO CPJKGDLPJIJ;

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F210", Offset = "0x5E6E010", VA = "0x185E6F210", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F8D0", Offset = "0x5E6E6D0", VA = "0x185E6F8D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x5E6FBB0", Offset = "0x5E6E9B0", VA = "0x185E6FBB0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6FBC0", Offset = "0x5E6E9C0", VA = "0x185E6FBC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F270", Offset = "0x5E6E070", VA = "0x185E6F270")]
	private void JPEEOMCILOG(EntityQuery LKMIGFDOIIA, [Out] (NativeArrayAsync<OADLEILHLGN> handles, NativeArrayAsync<KIFLAPEGCAF> bounds) PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EFC0", Offset = "0x5E6DDC0", VA = "0x185E6EFC0")]
	private void EMEKKBMOJIK((NativeArrayAsync<OADLEILHLGN> handles, NativeArrayAsync<KIFLAPEGCAF> bounds) PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F7D0", Offset = "0x5E6E5D0", VA = "0x185E6F7D0")]
	private void NDGPLOODIPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EE80", Offset = "0x5E6DC80", VA = "0x185E6EE80")]
	private void EIFJHIOEIKF(EntityQuery LKMIGFDOIIA, [Out] (NativeArrayAsync<Entity> entities, NativeArrayAsync<OADLEILHLGN> handles) PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F3B0", Offset = "0x5E6E1B0", VA = "0x185E6F3B0")]
	private void KINCPAGDHKF((NativeArrayAsync<Entity> entities, NativeArrayAsync<OADLEILHLGN> handles) PFDMLBFKIAP, HMPAGOLEOEO IAJACANMJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x5E6F670", Offset = "0x5E6E470", VA = "0x185E6F670")]
	private JobHandle MFGGNFABFLD(HMPAGOLEOEO IAJACANMJMF, ComponentDataFromEntity<GLPHDKJHCLN> NIDINNKANNC, ComponentDataFromEntity<CJHAAIFGNDF> ADOEDOABNKH, ComponentDataFromEntity<CBNJLCMNPAA> EFOHNBEOGGE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x5E6ED20", Offset = "0x5E6DB20", VA = "0x185E6ED20")]
	private JobHandle EHCDHHANCLD(HMPAGOLEOEO IAJACANMJMF, ComponentDataFromEntity<GLPHDKJHCLN> NIDINNKANNC, ComponentDataFromEntity<CJHAAIFGNDF> ADOEDOABNKH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public JFKCABLPFFC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200010C")]
public struct MCFNHHCKAFM : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
[ICOGLANPNEA]
public class DMABAGDCBID : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[BurstCompile]
	private struct CHJLMCGJFNL : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		[ReadOnly]
		public NativeArray<Entity> CDOBNFLOOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		[ReadOnly]
		public ComponentDataFromEntity<OKOJMLFLNIA> INGPGIBEHLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		[ReadOnly]
		public ComponentDataFromEntity<KIFLAPEGCAF> HLBCLCJLOHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		[WriteOnly]
		public NativeParallelHashSet<Entity>.ParallelWriter PGPBCGFBGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter NCMJHBPBDBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		[WriteOnly]
		public NativeList<Entity>.ParallelWriter GMLJFAJAJPF;

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E631B0", Offset = "0x5E61FB0", VA = "0x185E631B0", Slot = "4")]
		public void Execute(int DOJILIOCHKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[BurstCompile]
	private struct LIENKJBBKOE : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		[ReadOnly]
		public NativeArray<Entity> CGCPDMJAGEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> DHFFEBIBLMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		[ReadOnly]
		public ComponentDataFromEntity<NBKIDJCCNAD> FLEPJDKBBDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		[ReadOnly]
		public ComponentDataFromEntity<PFPLHPDBGCJ> PFAOOOCNDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		[NativeDisableParallelForRestriction]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<KIFLAPEGCAF> EGBBBICLIPA;

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E70CE0", Offset = "0x5E6FAE0", VA = "0x185E70CE0", Slot = "4")]
		public void Execute(int DOJILIOCHKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400036E")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400036F")]
	private EntityQuery CFCHOMFJPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000370")]
	private EntityQuery AJMECHBIMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private EntityQuery DELHCDEFBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000372")]
	private EntityQuery DNMHINODMJP;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x5E68DA0", Offset = "0x5E67BA0", VA = "0x185E68DA0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x5E68FD0", Offset = "0x5E67DD0", VA = "0x185E68FD0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x5E68CC0", Offset = "0x5E67AC0", VA = "0x185E68CC0")]
	private JobHandle JNJBBGLHBMJ(NativeArrayAsync<Entity> FNIMPMJDPGM, int JMNJMKJAMOL, JobHandle AHKLOHOGJID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x5E68AB0", Offset = "0x5E678B0", VA = "0x185E68AB0")]
	private JobHandle JNJBBGLHBMJ(NativeArray<Entity> PPIPNNMCDJE, int JMNJMKJAMOL, [Optional] JobHandle AHKLOHOGJID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x5E68220", Offset = "0x5E67020", VA = "0x185E68220")]
	private (NativeListAsync<Entity>, NativeListAsync<Entity>) FOLKANLHBMN(NativeArrayAsync<Entity> FJEEONBKAGE)
	{
		return default((NativeListAsync<Entity>, NativeListAsync<Entity>));
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x5E695F0", Offset = "0x5E683F0", VA = "0x185E695F0")]
	private void PFHLGDFMKAK([Out] NativeArray<Entity> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x5E680B0", Offset = "0x5E66EB0", VA = "0x185E680B0")]
	private void FACOAMDKGLL(NativeList<Entity> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x5E68140", Offset = "0x5E66F40", VA = "0x185E68140")]
	private void FACOAMDKGLL(NativeArray<Entity> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E68660", Offset = "0x5E67460", VA = "0x185E68660")]
	private void IFLKKOMONCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A1")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void NEKCFGHOAMK(int NAPOOJPCLPJ, int ELLNAICIHKB, int AOBMGGGJENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E687D0", Offset = "0x5E675D0", VA = "0x185E687D0")]
	private static KIFLAPEGCAF JKOEJPPBCCE(NativeArray<Entity> OAHPBKPFFBB, ComponentDataFromEntity<NBKIDJCCNAD> FLEPJDKBBDI, ComponentDataFromEntity<PFPLHPDBGCJ> PFAOOOCNDKO)
	{
		return default(KIFLAPEGCAF);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public DMABAGDCBID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[ICOGLANPNEA]
public class CBPKPGHBMDE : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x400037E")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x400037F")]
	private static readonly GKFGDEJLFAD NMHBNNGLCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000380")]
	[MBPNJDODNHC]
	private KOHELDMJMKP BGNKJBDOIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000381")]
	private EntityQuery LJGFIFNCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000382")]
	private EntityQuery OKMLGKHOHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000383")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E62F70", Offset = "0x5E61D70", VA = "0x185E62F70", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E62AA0", Offset = "0x5E618A0", VA = "0x185E62AA0")]
	public bool BPJKEAABLEN(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x5E62FE0", Offset = "0x5E61DE0", VA = "0x185E62FE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E62FC0", Offset = "0x5E61DC0", VA = "0x185E62FC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x81A510", Offset = "0x819310", VA = "0x18081A510", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E630D0", Offset = "0x5E61ED0", VA = "0x185E630D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E62FC0", Offset = "0x5E61DC0", VA = "0x185E62FC0")]
	private void OAKKNLNKPHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E62B80", Offset = "0x5E61980", VA = "0x185E62B80")]
	private void FGCJFKECNFG(EntityQuery LKMIGFDOIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E62E20", Offset = "0x5E61C20", VA = "0x185E62E20")]
	private void INECLDDKIEI(NativeArray<Entity> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public CBPKPGHBMDE()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000111")]
internal struct NIICFNHPPGM : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[CompilerGenerated]
	[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
	internal class CopyOwnerToEntitySystem : FMBIPPPJNCE, IJCLFGAEMDL
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct CopyOwnerToEntitySystem_RemoveDisembodied_Job
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public CopyOwnerToEntitySystem __this;

			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x5E66040", Offset = "0x5E64E40", VA = "0x185E66040")]
			public void FNGBIBLNCLD(EntityQuery query)
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
			[Cpp2IlInjected.Address(RVA = "0x5E64CC0", Offset = "0x5E63AC0", VA = "0x185E64CC0")]
			public void FNGBIBLNCLD(EntityQuery query)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private IKBNJJBMJGF objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private FPJFHPMDDGC dependencies;

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
		private ComponentTypeHandle<NEPMLPNCDKA> __RecRoom_Components_PhotonOwnerData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private ComponentTypeHandle<GBBEHLEGGAO> __RecRoom_Components_PhotonOwnerWatcherData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E65010", Offset = "0x5E63E10", VA = "0x185E65010", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x5E65AA0", Offset = "0x5E648A0", VA = "0x185E65AA0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E65C40", Offset = "0x5E64A40", VA = "0x185E65C40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x5E65B70", Offset = "0x5E64970", VA = "0x185E65B70", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E65130", Offset = "0x5E63F30", VA = "0x185E65130")]
		private void OLJHPANNBEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E64C00", Offset = "0x5E63A00", VA = "0x185E64C00")]
		private void BDBNKHKLPDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x5E65D10", Offset = "0x5E64B10", VA = "0x185E65D10")]
		private void PFIOMBAEGFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x5E65DD0", Offset = "0x5E64BD0", VA = "0x185E65DD0")]
		private void PHPKIMADHNF(Entity e, [In] GBBEHLEGGAO watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x5E65610", Offset = "0x5E64410", VA = "0x185E65610")]
		private void OPOOLLBCMAN(JBMJEBCFLLB localId, int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E64BF0", Offset = "0x5E639F0", VA = "0x185E64BF0")]
		private void GOLGBLMJCBB(Entity e, [In] NEPMLPNCDKA _, [In] GBBEHLEGGAO watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x5E64F60", Offset = "0x5E63D60", VA = "0x185E64F60")]
		private void HACOAJGOLFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E64BF0", Offset = "0x5E639F0", VA = "0x185E64BF0")]
		private void KNJKLKIDELE(Entity e, [In] NEPMLPNCDKA _, [In] GBBEHLEGGAO watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x5E65080", Offset = "0x5E63E80", VA = "0x185E65080")]
		private void JONCOHCAANI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x5E656E0", Offset = "0x5E644E0", VA = "0x185E656E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public CopyOwnerToEntitySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x5E64BF0", Offset = "0x5E639F0", VA = "0x185E64BF0")]
		[CompilerGenerated]
		private void AAMMHFFMAAE(Entity e, [In] NEPMLPNCDKA _, [In] GBBEHLEGGAO watcherData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x5E64BF0", Offset = "0x5E639F0", VA = "0x185E64BF0")]
		[CompilerGenerated]
		private void PBIBOFIGFOJ(Entity e, [In] NEPMLPNCDKA _, [In] GBBEHLEGGAO watcherData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal class MBGGBBAKGJB : FMBIPPPJNCE, IJCLFGAEMDL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private struct ADLNHOIGDNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public NativeParallelHashMap<Entity, int> modifiedOwners;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public ComponentDataFromEntity<NEPMLPNCDKA> ownershipDataRO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private FPJFHPMDDGC BBCJNGKGCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private HLMBCPKELME DPIBHKLBMGJ;

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x5E71E40", Offset = "0x5E70C40", VA = "0x185E71E40", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E71EB0", Offset = "0x5E70CB0", VA = "0x185E71EB0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E71F90", Offset = "0x5E70D90", VA = "0x185E71F90", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x5E71800", Offset = "0x5E70600", VA = "0x185E71800")]
	private void CIGPJAKLOJB(NativeArray<Entity> PFOPLIKJCHB, NativeParallelHashMap<Entity, int> OKBNPKBDJFI, ComponentDataFromEntity<NEPMLPNCDKA> ODBKHEENABC, BufferFromEntity<ChildrenData> FCOAKPOHDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public MBGGBBAKGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E72420", Offset = "0x5E71220", VA = "0x185E72420")]
	[CompilerGenerated]
	internal static int PFDEEEGEHPA(Entity CCHOHIEEHEH, ADLNHOIGDNC P_1)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
[AlwaysUpdateSystem]
public class FDEKNBFIEOD : FMBIPPPJNCE, IJCLFGAEMDL, POKGICLLPAE
{
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class ADAAGPALNGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		public JBMJEBCFLLB localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		public KJMNOPEJLKJ collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public bool collidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public IHGPMFPNODN containerFlags;

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
		public FDEKNBFIEOD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ADAAGPALNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x5E61110", Offset = "0x5E5FF10", VA = "0x185E61110")]
		internal void GNDAPCGILAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E61210", Offset = "0x5E60010", VA = "0x185E61210")]
		internal void IKILFNHDNDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x5E60FF0", Offset = "0x5E5FDF0", VA = "0x185E60FF0")]
		internal void FIJCLAGKLHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000396")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000397")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000398")]
	[MBPNJDODNHC]
	private AOFEKDJFLMC GONDDAJKLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	[MBPNJDODNHC]
	private AEONNHMKDNI PMOGFFGKDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400039A")]
	[MBPNJDODNHC]
	private BCDPLEGKDHC NLLAIOCDMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400039B")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400039C")]
	public ComponentTypeHandle<IHGPMFPNODN> NKDIFEKADLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400039D")]
	public ComponentTypeHandle<MDBNEJGOCFE> FOIAEBKPEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400039E")]
	public ComponentTypeHandle<EDLMMIAOCLP> OAODPHHENPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400039F")]
	public ComponentTypeHandle<AGDPGJDMHLG> EKHHJINDHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	public ComponentTypeHandle<AOAIOFODAEG> HIMBDIGNJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	public DynamicComponentTypeHandle HKKONIBPKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public EntityTypeHandle JEDKCNAJPAO;

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A090", Offset = "0x5E68E90", VA = "0x185E6A090", Slot = "15")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A460", Offset = "0x5E69260", VA = "0x185E6A460", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A510", Offset = "0x5E69310", VA = "0x185E6A510", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B5B0", Offset = "0x5E6A3B0", VA = "0x185E6B5B0")]
	private void PNEFEAIIMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A160", Offset = "0x5E68F60", VA = "0x185E6A160")]
	private bool HIFOIFBFODK([Out] int KALDBFGOBLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public FDEKNBFIEOD()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[AlwaysUpdateSystem]
	[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
	[CompilerGenerated]
	public class UpdateSplineGameCollidersSystem : FMBIPPPJNCE, IJCLFGAEMDL
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
			public ComponentDataFromEntity<GHJGKJPPKGB> splineComponentAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			[ReadOnly]
			public ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			[ReadOnly]
			public ComponentTypeHandle<MDBNEJGOCFE> __collisionModeTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public BufferTypeHandle<ChildrenData> __childrenTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A8C0", Offset = "0x5E796C0", VA = "0x185E7A8C0")]
			private void LFGCENJAPBK([In] MDBNEJGOCFE collisionMode, DynamicBuffer<ChildrenData> children)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A750", Offset = "0x5E79550", VA = "0x185E7A750", Slot = "4")]
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
			public ComponentDataFromEntity<MDBNEJGOCFE> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A670", Offset = "0x5E79470", VA = "0x185E7A670")]
			private void LFGCENJAPBK(Entity entity, [In] ParentData parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A550", Offset = "0x5E79350", VA = "0x185E7A550", Slot = "4")]
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
			public ComponentDataFromEntity<MDBNEJGOCFE> containerCollisionModeAccess;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			[ReadOnly]
			public ComponentTypeHandle<ParentData> __parentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AD60", Offset = "0x5E79B60", VA = "0x185E7AD60")]
			private void LFGCENJAPBK(Entity entity, [In] ParentData parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AC40", Offset = "0x5E79A40", VA = "0x185E7AC40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E7F320", Offset = "0x5E7E120", VA = "0x185E7F320")]
			private void LFGCENJAPBK(Entity entity)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0x5E7F270", Offset = "0x5E7E070", VA = "0x185E7F270", Slot = "4")]
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
			public ComponentTypeHandle<OKOJMLFLNIA> splinePointParentHandle;

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
			[Cpp2IlInjected.Address(RVA = "0x5E7AE90", Offset = "0x5E79C90", VA = "0x185E7AE90")]
			private void LFGCENJAPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AE30", Offset = "0x5E79C30", VA = "0x185E7AE30", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x5E7AE40", Offset = "0x5E79C40", VA = "0x185E7AE40")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void JDKFJNMCLOL(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private GKJLLKLKGFO splineCollisionService;

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
		private ComponentTypeHandle<MDBNEJGOCFE> __RecRoom_Components_ContainerCollisionModeData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x5E7EDD0", Offset = "0x5E7DBD0", VA = "0x185E7EDD0", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E7FB90", Offset = "0x5E7E990", VA = "0x185E7FB90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E7FD70", Offset = "0x5E7EB70", VA = "0x185E7FD70", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E880", Offset = "0x5E7D680", VA = "0x185E7E880")]
		private void GEOENFPECOF(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E5C0", Offset = "0x5E7D3C0", VA = "0x185E7E5C0")]
		private void DFBOBDJMBLC(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F0C0", Offset = "0x5E7DEC0", VA = "0x185E7F0C0")]
		private void LHNMBGEFEOF(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E7ECE0", Offset = "0x5E7DAE0", VA = "0x185E7ECE0")]
		private void IOAKLECPDFI(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E7E3D0", Offset = "0x5E7D1D0", VA = "0x185E7E3D0")]
		private void ACIEPGMEOEM(EntityCommandBuffer ecb, ComponentDataFromEntity<GHJGKJPPKGB> splineComponentAccess, ComponentDataFromEntity<SplineGameCollisionSystemTag> systemStateAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E7EF60", Offset = "0x5E7DD60", VA = "0x185E7EF60")]
		private void JMKHOKFKPDN(EntityCommandBuffer ecb, ComponentDataFromEntity<MDBNEJGOCFE> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E7EB80", Offset = "0x5E7D980", VA = "0x185E7EB80")]
		private void HLNEILJJJPG(EntityCommandBuffer ecb, ComponentDataFromEntity<MDBNEJGOCFE> containerCollisionModeAccess)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x5E7EA90", Offset = "0x5E7D890", VA = "0x185E7EA90")]
		private void HJDKOPONBFP(EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E7EE20", Offset = "0x5E7DC20", VA = "0x185E7EE20")]
		private void JMKAEAGHPBK(ComponentTypeHandle<OKOJMLFLNIA> splinePointParentHandle, EntityTypeHandle entityHandle, ComponentDataFromEntity<SplineGameCollisionSystemTag> systemTagAccess, EntityQueryInJob splinePointEditedQueryInJob, EntityQueryInJob splineStructureChangedQueryInJob)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E7F3D0", Offset = "0x5E7E1D0", VA = "0x185E7F3D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public UpdateSplineGameCollidersSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
[ICOGLANPNEA]
public class BNDBBCKCEIE : FMBIPPPJNCE, POKGICLLPAE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[BurstCompile]
	private struct JIFGMGKJCBJ : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		[ReadOnly]
		public EntityTypeHandle GHHNLHEMMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		[ReadOnly]
		public ComponentTypeHandle<GLPHDKJHCLN> LDOGEKKMMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		[WriteOnly]
		public NativeList<LGOKMKLDMLD>.ParallelWriter PHHKLHPCNJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public ComponentTypeHandle<PICECHDBAOI> FFEJEMOMHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public float3 CJKEIGLKDDB;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private static readonly float4x2 JNPGBHCPOCO;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private static readonly float4x2 KNGKJMJCOAL;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private static readonly int4x2 ILHPBLJAHCI;

		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E70470", Offset = "0x5E6F270", VA = "0x185E70470", Slot = "4")]
		public void Execute(ArchetypeChunk NEFPDCFOPMI, int FDCDMNHMNAG, int PKLNFOPBAHA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D2")]
	private static GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D3")]
	private EntityQuery HENMLJPJMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003D4")]
	private EntityQuery FAPLGGAFAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private double MIFHNLCAIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private HLMBCPKELME NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private HOPJJNIFNBD PCHCEADMGNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	private BOGMJJODDAE NCGAGJLPMMN;

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E620D0", Offset = "0x5E60ED0", VA = "0x185E620D0", Slot = "14")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E62380", Offset = "0x5E61180", VA = "0x185E62380", Slot = "15")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E62480", Offset = "0x5E61280", VA = "0x185E62480", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E625F0", Offset = "0x5E613F0", VA = "0x185E625F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E62410", Offset = "0x5E61210", VA = "0x185E62410")]
	private bool MHJBBAADKHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E620E0", Offset = "0x5E60EE0", VA = "0x185E620E0")]
	private void DAFGKOFGKKO(EntityQuery LKMIGFDOIIA, float3 LKADOCCHFLP, string ONIBECKLJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public BNDBBCKCEIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public struct LGOKMKLDMLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	public Entity CCHOHIEEHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	public IBCCCJOGKLP BOAPNJKEFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	public IBCCCJOGKLP INJCFLAHPML;
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
public class ILAIHAHFGJP : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private HOPJJNIFNBD PCHCEADMGNF;

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EA70", Offset = "0x5E6D870", VA = "0x185E6EA70", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EAC0", Offset = "0x5E6D8C0", VA = "0x185E6EAC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public ILAIHAHFGJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public class ODBGEHPHHKA : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E774B0", Offset = "0x5E762B0", VA = "0x185E774B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E77570", Offset = "0x5E76370", VA = "0x185E77570", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public ODBGEHPHHKA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
	[CompilerGenerated]
	public class UpdateInertialPropertiesSystem : FMBIPPPJNCE, IJCLFGAEMDL
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
				[Cpp2IlInjected.Address(RVA = "0x5E7B5F0", Offset = "0x5E7A3F0", VA = "0x185E7B5F0")]
				[BurstDiscard]
				private static void IEGAEKHJOOB(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000713")]
				[Cpp2IlInjected.Address(RVA = "0x5E7B3E0", Offset = "0x5E7A1E0", VA = "0x185E7B3E0")]
				private static IntPtr CNABIEPBNDL()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000714")]
				[Cpp2IlInjected.Address(RVA = "0x5E7B540", Offset = "0x5E7A340", VA = "0x185E7B540")]
				public static void EICHAODCKAA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000715")]
				[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
				public static void OOCIGOIJKNJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000717")]
				[Cpp2IlInjected.Address(RVA = "0x5E7B720", Offset = "0x5E7A520", VA = "0x185E7B720")]
				public static void LBCPFKCIFOM(IntPtr jobPtr)
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
			public ComponentTypeHandle<NKPFKMGPKJB> rbexRootTypeRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			[ReadOnly]
			public ComponentDataFromEntity<OHHMNJBHJAJ> rbexIsKinematicRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			public Allocator allocator;

			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C0E0", Offset = "0x5E7AEE0", VA = "0x185E7C0E0")]
			private void LFGCENJAPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x5E7BE70", Offset = "0x5E7AC70", VA = "0x185E7BE70", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x5E7BED0", Offset = "0x5E7ACD0", VA = "0x185E7BED0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void JDKFJNMCLOL(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x5E7BE80", Offset = "0x5E7AC80", VA = "0x185E7BE80")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void IGHOIHMPPNE(IntPtr jobPtr)
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
		private AOFEKDJFLMC rbexServiceCallbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private IKBNJJBMJGF objects;

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BD60", Offset = "0x5E7AB60", VA = "0x185E7BD60", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000703")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CB00", Offset = "0x5E7B900", VA = "0x185E7CB00", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000704")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CEA0", Offset = "0x5E7BCA0", VA = "0x185E7CEA0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000705")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CF50", Offset = "0x5E7BD50", VA = "0x185E7CF50")]
		protected void PNBEMPHMPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BDD0", Offset = "0x5E7ABD0", VA = "0x185E7BDD0")]
		protected void JJGABIMLAMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B930", Offset = "0x5E7A730", VA = "0x185E7B930")]
		private bool ILNCABCIJMA(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, [Out] NativeList<Entity> results)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000708")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C730", Offset = "0x5E7B530", VA = "0x185E7C730")]
		private void NBADKIDKLFA(EntityQueryInJob isTaggedForUpdate, EntityQueryInJob rootRbexChangedQuery, EntityQueryInJob deformationScaleChangedQuery, EntityQueryInJob generalRbexChangedQuery, ChunkFilterAnyOf5ComponentsChanged changeFilter, int maxEntityCount, NativeList<Entity> changedRoots, EntityExistenceLookupByEntity entityExists, EntityTypeHandle entityTypeRO, ComponentTypeHandle<NKPFKMGPKJB> rbexRootTypeRO, ComponentDataFromEntity<OHHMNJBHJAJ> rbexIsKinematicRO, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000709")]
		[Cpp2IlInjected.Address(RVA = "0x5E7CA10", Offset = "0x5E7B810", VA = "0x185E7CA10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public UpdateInertialPropertiesSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B8F0", Offset = "0x5E7A6F0", VA = "0x185E7B8F0")]
		public static void CEAKJFHCCED()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	public class UpdateMassOfShapesSystem : FMBIPPPJNCE
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
			public ComponentDataFromEntity<GLDJHBJAKIA> worldDeformableScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			[ReadOnly]
			public ComponentDataFromEntity<CJHAAIFGNDF> worldUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			[ReadOnly]
			public ComponentDataFromEntity<DFOBAGCJCAG> physicsMaterialsRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			[ReadOnly]
			public ComponentDataFromEntity<AJJHCLCGOEI> primitiveShapesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			[ReadOnly]
			public ComponentDataFromEntity<PEDPLCBIGKO> localUniformScalesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			public ComponentDataFromEntity<HOLDFGNFCDO> massesRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public ComponentDataFromEntity<LGDFPOGFODA> centerOfMassesRW;

			[Cpp2IlInjected.Token(Token = "0x600071F")]
			[Cpp2IlInjected.Address(RVA = "0x5E7D5B0", Offset = "0x5E7C3B0", VA = "0x185E7D5B0")]
			private void LFGCENJAPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000720")]
			[Cpp2IlInjected.Address(RVA = "0x5E7D5A0", Offset = "0x5E7C3A0", VA = "0x185E7D5A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private EntityQuery query;

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DBD0", Offset = "0x5E7C9D0", VA = "0x185E7DBD0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DD10", Offset = "0x5E7CB10", VA = "0x185E7DD10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7D290", Offset = "0x5E7C090", VA = "0x185E7D290")]
		private void AANPEAPHBJF(NativeList<Entity> entities)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7DA00", Offset = "0x5E7C800", VA = "0x185E7DA00")]
		private JobHandle ODPDJLAGEHP(NativeList<Entity> entities, ComponentDataFromEntity<GLDJHBJAKIA> worldDeformableScalesRO, ComponentDataFromEntity<CJHAAIFGNDF> worldUniformScalesRO, ComponentDataFromEntity<DFOBAGCJCAG> physicsMaterialsRO, ComponentDataFromEntity<AJJHCLCGOEI> primitiveShapesRO, ComponentDataFromEntity<PEDPLCBIGKO> localUniformScalesRO, ComponentDataFromEntity<HOLDFGNFCDO> massesRW, ComponentDataFromEntity<LGDFPOGFODA> centerOfMassesRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public UpdateMassOfShapesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
public class PIBJFCPHKBH : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[BurstCompile]
	private struct NKLLBGMAOEP : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		[ReadOnly]
		public int IDEJGHLFALH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[ReadOnly]
		public EntityQueryInJob BAPOOGIIADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		[ReadOnly]
		public EntityQueryInJob DBLBOMNHNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		[ReadOnly]
		public ChunkFilterAnyOf3ComponentsChanged DMDAIFPGHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		[ReadOnly]
		public EntityTypeHandle JEDKCNAJPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		[ReadOnly]
		public ComponentDataFromEntity<DFOBAGCJCAG> GPFLIMIDDJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		[ReadOnly]
		public ComponentDataFromEntity<CJHAAIFGNDF> LCKGKEEOGEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> IFGEFIEMBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		[ReadOnly]
		public ComponentTypeHandle<OKOJMLFLNIA> PBGJHAKKKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		[ReadOnly]
		public ComponentDataFromEntity<NBKIDJCCNAD> EIAEKKDDAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		[ReadOnly]
		public ComponentDataFromEntity<PFPLHPDBGCJ> PFAOOOCNDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		[WriteOnly]
		public ComponentDataFromEntity<HOLDFGNFCDO> EOLEIFIKIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		[WriteOnly]
		public ComponentDataFromEntity<LGDFPOGFODA> BGDADAAPENI;

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x5E74200", Offset = "0x5E73000", VA = "0x185E74200", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x5E74880", Offset = "0x5E73680", VA = "0x185E74880")]
		private void KAIFKNEBGNK(NativeList<Entity> LMEPOAMFDLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x5E743C0", Offset = "0x5E731C0", VA = "0x185E743C0")]
		private void HNHJBJNNLJP(Entity PPEPGBPKJPK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private EntityQuery APALGBCJLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	private EntityQuery LHEOEDHIBLC;

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x5E783F0", Offset = "0x5E771F0", VA = "0x185E783F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x5E785B0", Offset = "0x5E773B0", VA = "0x185E785B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x250A9D0", Offset = "0x25097D0", VA = "0x18250A9D0")]
	private bool GBAJLLCPBJD<T>(T MOIEGKDAMBH, [Out] int NDCFPGDMBDI) where T : struct, IChunkChangeFilter
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public PIBJFCPHKBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
[ICOGLANPNEA]
public class DDLKNDOKBEA : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000417")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000418")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> PCKHALNEEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000419")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> OAEGIFIGDPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041A")]
	private readonly List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> AHKGJCPLOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private GDEJBPMFJOE NEFMIHGBNNA;

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x5E672F0", Offset = "0x5E660F0", VA = "0x185E672F0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x5E679C0", Offset = "0x5E667C0", VA = "0x185E679C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x5E66A10", Offset = "0x5E65810", VA = "0x185E66A10")]
	private void BIKEDCPJGHN(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> NDKEAGMKBJJ, EntityQueryDesc NLBGKCPKFJC, bool MAAIGBPPBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x5E66B80", Offset = "0x5E65980", VA = "0x185E66B80")]
	private void BIKEDCPJGHN(List<(EntityQuery query, bool hasRigidbody, bool hasCustomVelocity)> NDKEAGMKBJJ, EntityQueryDesc NLBGKCPKFJC, bool MAAIGBPPBFP, bool HPJBBHHJIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x5E67C30", Offset = "0x5E66A30", VA = "0x185E67C30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x5E67340", Offset = "0x5E66140", VA = "0x185E67340")]
	private void JBPIAAMLKCO(EntityQuery LKMIGFDOIIA, bool CPEHCKIJNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x5E67590", Offset = "0x5E66390", VA = "0x185E67590")]
	private void KDDIIMDAEEA(EntityQuery LKMIGFDOIIA, bool AIMLOELNFKI, bool CPEHCKIJNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x5E66D10", Offset = "0x5E65B10", VA = "0x185E66D10")]
	private void BKONGJMEFJE(NativeArray<Entity> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0x5E66F80", Offset = "0x5E65D80", VA = "0x185E66F80")]
	private void CIIJOPENDHF(NativeList<Entity> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x5E668D0", Offset = "0x5E656D0", VA = "0x185E668D0")]
	private void BDOMPKBNBCO(NativeArray<Entity> PFOPLIKJCHB, bool AIMLOELNFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x5E677B0", Offset = "0x5E665B0", VA = "0x185E677B0")]
	private NativeList<Entity> MPHBNOBFELJ(NativeArray<Entity> PFOPLIKJCHB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x5E66890", Offset = "0x5E65690", VA = "0x185E66890")]
	private NativeList<Entity> BDGHEMKMKGI(NativeArray<Entity> PFOPLIKJCHB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x5E67550", Offset = "0x5E66350", VA = "0x185E67550")]
	private NativeList<Entity> JIDJAOJEECL(NativeArray<Entity> PFOPLIKJCHB)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x5E67110", Offset = "0x5E65F10", VA = "0x185E67110")]
	private NativeList<Entity> CIKGJCNDCLM(NativeArray<Entity> PFOPLIKJCHB, bool OGKJHKIBDAL)
	{
		return default(NativeList<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x5E67FC0", Offset = "0x5E66DC0", VA = "0x185E67FC0")]
	public DDLKNDOKBEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
public class KHAFLJEBJFM : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private GDEJBPMFJOE NEFMIHGBNNA;

	[Cpp2IlInjected.Token(Token = "0x6000738")]
	[Cpp2IlInjected.Address(RVA = "0x5E70BE0", Offset = "0x5E6F9E0", VA = "0x185E70BE0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000739")]
	[Cpp2IlInjected.Address(RVA = "0x5E70C30", Offset = "0x5E6FA30", VA = "0x185E70C30", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073A")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public KHAFLJEBJFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
public class GOKBNLKHPNC : IALGNLMAPEN
{
	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private static GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private EntityQuery FINLAJAKHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private EntityQuery NCLAEPDDKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private EntityQuery JJBCKLFCONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private EntityQuery NNHGDNAAAGN;

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D030", Offset = "0x5E6BE30", VA = "0x185E6D030", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D210", Offset = "0x5E6C010", VA = "0x185E6D210", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CE60", Offset = "0x5E6BC60", VA = "0x185E6CE60")]
	private void GOOFFMJLOCO(EntityQuery LKMIGFDOIIA, bool AMKLAEEOILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D290", Offset = "0x5E6C090", VA = "0x185E6D290")]
	private void PIALGPPBJOI(EntityQuery LKMIGFDOIIA, bool AMKLAEEOILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public GOKBNLKHPNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
[AlwaysUpdateSystem]
public class GDIJGLIBNAN : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	[MBPNJDODNHC]
	private LGMAMHNDHAH HGJMOLFPFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000424")]
	[MBPNJDODNHC]
	private AOFEKDJFLMC GONDDAJKLCI;

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C990", Offset = "0x5E6B790", VA = "0x185E6C990", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000742")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CA20", Offset = "0x5E6B820", VA = "0x185E6CA20")]
	protected void NBOGFCCBOCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000743")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CAA0", Offset = "0x5E6B8A0", VA = "0x185E6CAA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public GDIJGLIBNAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal class PDAFIENOFHA : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000425")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000426")]
	private HLMBCPKELME NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000427")]
	private EntityQuery MCOJCFDOPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000428")]
	private EntityQuery CBLHJPECEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000429")]
	private OPNGBJLAHIJ AIMIPJFKDIC;

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x5E77F10", Offset = "0x5E76D10", VA = "0x185E77F10", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x5E78220", Offset = "0x5E77020", VA = "0x185E78220", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x5E78340", Offset = "0x5E77140", VA = "0x185E78340", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000748")]
	[Cpp2IlInjected.Address(RVA = "0x5E77810", Offset = "0x5E76610", VA = "0x185E77810")]
	private void ABKAFFKEEMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000749")]
	[Cpp2IlInjected.Address(RVA = "0x5E779E0", Offset = "0x5E767E0", VA = "0x185E779E0")]
	private void BFDMHLJEIBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x5E77BA0", Offset = "0x5E769A0", VA = "0x185E77BA0")]
	private void GGJOEEICIFK(NativeArray<Entity> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x5E78090", Offset = "0x5E76E90", VA = "0x185E78090")]
	private void OIGACNHILAH(NativeArray<Entity> PFOPLIKJCHB, int KAPJKPOHEMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x5E77F80", Offset = "0x5E76D80", VA = "0x185E77F80")]
	private void LIAGONMHPGP(NativeArray<Entity> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x5E77960", Offset = "0x5E76760", VA = "0x185E77960")]
	private void BAAKMFPLDCD(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void DFLKJOJJJAJ(int LKPDEMOKJBN, Transform GNLAIPIBJPM, Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public PDAFIENOFHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal static class KKLBGIFNDKM
{
	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x5E70C50", Offset = "0x5E6FA50", VA = "0x185E70C50")]
	public static bool MLEALOEHODH(this SystemBase LOFHIHDMJIG, [Out] Entity CCHOHIEEHEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal class JIHFDPPNOCM : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x400042A")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400042B")]
	private EntityQuery PADHHKPKEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400042C")]
	private PHJHPLJJLBK GCJOAKHEKAP;

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x5E709D0", Offset = "0x5E6F7D0", VA = "0x185E709D0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x5E70A20", Offset = "0x5E6F820", VA = "0x185E70A20", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0x5E70AE0", Offset = "0x5E6F8E0", VA = "0x185E70AE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public JIHFDPPNOCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal class PMGEMNOIPGF : IJBEOJNEGGD<EOJGLAGNFDA>, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x400042D")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400042E")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400042F")]
	private POCKFOBPLKI AONGCICHAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000430")]
	private EntityQuery NEFLGCPJJCP;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private Entity LHMLGKEAABL
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x5E78FA0", Offset = "0x5E77DA0", VA = "0x185E78FA0")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x5E78F40", Offset = "0x5E77D40", VA = "0x185E78F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public JBMJEBCFLLB DGDHDLOAFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x5E79690", Offset = "0x5E78490", VA = "0x185E79690")]
		get
		{
			return default(JBMJEBCFLLB);
		}
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x5E79070", Offset = "0x5E77E70", VA = "0x185E79070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600075B")]
	[Cpp2IlInjected.Address(RVA = "0x5E79520", Offset = "0x5E78320", VA = "0x185E79520", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075C")]
	[Cpp2IlInjected.Address(RVA = "0x5E79000", Offset = "0x5E77E00", VA = "0x185E79000", Slot = "15")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075D")]
	[Cpp2IlInjected.Address(RVA = "0x5E795D0", Offset = "0x5E783D0", VA = "0x185E795D0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075E")]
	[Cpp2IlInjected.Address(RVA = "0x5E790D0", Offset = "0x5E77ED0", VA = "0x185E790D0", Slot = "14")]
	protected override void KGLKJLCHLKD(NativeArray<Entity> PFOPLIKJCHB, NativeArray<Entity> EFKAHNGKMND, NativeArray<Entity> NLOEOKCCIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600075F")]
	[Cpp2IlInjected.Address(RVA = "0x5E78E60", Offset = "0x5E77C60", VA = "0x185E78E60")]
	private void BGEEILPDKLC(NativeArray<Entity> PFOPLIKJCHB, NativeArray<Entity> NLOEOKCCIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000760")]
	[Cpp2IlInjected.Address(RVA = "0x5E79290", Offset = "0x5E78090", VA = "0x185E79290")]
	private void MNPBNLLGJBI(Entity CCHOHIEEHEH, Entity JAFMIMELIJJ, Entity EPGAKHMFIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000761")]
	[Cpp2IlInjected.Address(RVA = "0x250C480", Offset = "0x250B280", VA = "0x18250C480")]
	private bool COFEFJFFGMK<T>([Out] T GNLEHBFFNFG) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000762")]
	[Cpp2IlInjected.Address(RVA = "0x250C510", Offset = "0x250B310", VA = "0x18250C510")]
	private void LDGCOHGCBKK<T>(T GNLEHBFFNFG) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000763")]
	[Cpp2IlInjected.Address(RVA = "0x5E79210", Offset = "0x5E78010", VA = "0x185E79210")]
	public bool KPDFJMDFNLG(JBMJEBCFLLB MALDBOALFEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000764")]
	[Cpp2IlInjected.Address(RVA = "0x5E79670", Offset = "0x5E78470", VA = "0x185E79670")]
	private static bool PECPDPOOHFK(JBMJEBCFLLB DMOKCBFEAPK, JBMJEBCFLLB DAJDFFEBPLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000765")]
	[Cpp2IlInjected.Address(RVA = "0x5E797A0", Offset = "0x5E785A0", VA = "0x185E797A0")]
	public PMGEMNOIPGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal class LKFCEMLBDPK : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000431")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000432")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000433")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.Token(Token = "0x6000767")]
	[Cpp2IlInjected.Address(RVA = "0x5E710A0", Offset = "0x5E6FEA0", VA = "0x185E710A0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000768")]
	[Cpp2IlInjected.Address(RVA = "0x5E71220", Offset = "0x5E70020", VA = "0x185E71220", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000769")]
	[Cpp2IlInjected.Address(RVA = "0x5E712F0", Offset = "0x5E700F0", VA = "0x185E712F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076A")]
	[Cpp2IlInjected.Address(RVA = "0x5E70F60", Offset = "0x5E6FD60", VA = "0x185E70F60")]
	private NativeArray<Entity> BPNFFFDIOKC(int HLFCMANHPKF)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x600076B")]
	[Cpp2IlInjected.Address(RVA = "0x5E710F0", Offset = "0x5E6FEF0", VA = "0x185E710F0")]
	private void KPPPGEGHBBN(NativeArray<Entity> DJOOCKLMDFF, NativeArray<Entity> CGLGAGKJKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public LKFCEMLBDPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal class JBGLJIOFBFO : FMBIPPPJNCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000434")]
	private EntityQuery NGBIDJHMAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000435")]
	private EntityQuery BLGGELIHAEH;

	[Cpp2IlInjected.Token(Token = "0x600076E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EB60", Offset = "0x5E6D960", VA = "0x185E6EB60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076F")]
	[Cpp2IlInjected.Address(RVA = "0x5E6EC60", Offset = "0x5E6DA60", VA = "0x185E6EC60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000770")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public JBGLJIOFBFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal static class BGDHJGOMLEO
{
	[Cpp2IlInjected.Token(Token = "0x6000771")]
	[Cpp2IlInjected.Address(RVA = "0x216D0E0", Offset = "0x216BEE0", VA = "0x18216D0E0")]
	public static NativeArray<T> FHLKAPEODEP<T>(NativeArray<Entity> PFOPLIKJCHB, EntityManager FMCNCDMBJDH) where T : struct, IComponentData
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000772")]
	[Cpp2IlInjected.Address(RVA = "0x5E61C10", Offset = "0x5E60A10", VA = "0x185E61C10")]
	public static void HHLFLDADPKM(EntityQuery LKMIGFDOIIA, EntityManager FMCNCDMBJDH, IKBNJJBMJGF CFIPHHIMOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000773")]
	[Cpp2IlInjected.Address(RVA = "0x5E61EE0", Offset = "0x5E60CE0", VA = "0x185E61EE0")]
	public static void MKIEKAFNDOH(NativeArray<Entity> DJOOCKLMDFF, IKBNJJBMJGF CFIPHHIMOMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000774")]
	[Cpp2IlInjected.Address(RVA = "0x5E61DA0", Offset = "0x5E60BA0", VA = "0x185E61DA0")]
	public static void HIHNBGCOGPN(NativeArray<Entity> DJOOCKLMDFF, IKBNJJBMJGF CFIPHHIMOMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal class NKFHIMJNCGA : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000436")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000437")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000438")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000439")]
	private MDOBHIFKKDP HJDMFCAGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private GNBAGIHPECL JKMCJDKCAIG;

	[Cpp2IlInjected.Token(Token = "0x6000775")]
	[Cpp2IlInjected.Address(RVA = "0x5E732B0", Offset = "0x5E720B0", VA = "0x185E732B0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0x5E740B0", Offset = "0x5E72EB0", VA = "0x185E740B0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x5E74160", Offset = "0x5E72F60", VA = "0x185E74160", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x5E72800", Offset = "0x5E71600", VA = "0x185E72800")]
	private void DPEFDLLCMBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x5E726F0", Offset = "0x5E714F0", VA = "0x185E726F0")]
	private void CBDNAMPGGLA(NativeArray<Entity> DJOOCKLMDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x5E73340", Offset = "0x5E72140", VA = "0x185E73340")]
	private void LDECDFICPJB(NativeArray<Entity> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x5E72E10", Offset = "0x5E71C10", VA = "0x185E72E10")]
	private void HMINCLNNKNK(NativeArray<Entity> CGLGAGKJKKE, NativeArray<RigidTransform> ACHDKBJOFNO, NativeArray<RigidTransform> HEMPGBBMPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077C")]
	[Cpp2IlInjected.Address(RVA = "0x5E73C20", Offset = "0x5E72A20", VA = "0x185E73C20")]
	private void MOEKHBFKGMF(NativeArray<RigidTransform> HEMPGBBMPGL, NativeArray<Entity> CGLGAGKJKKE, NativeList<Entity> BCOPHLIOEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public NKFHIMJNCGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal class GFFHIMMCEAP : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	private EntityQuery PADHHKPKEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	private EntityQuery ALKKJLGCKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private MBCPGIKDGBD NBBLMGDHBPE;

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0x5E872A0", Offset = "0x5E860A0", VA = "0x185E872A0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x5E872F0", Offset = "0x5E860F0", VA = "0x185E872F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x5E87450", Offset = "0x5E86250", VA = "0x185E87450", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x5E87230", Offset = "0x5E86030", VA = "0x185E87230")]
	private void CPEJNMAIOMF(EntityQuery LKMIGFDOIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public GFFHIMMCEAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal class DIDAAKCNCCI : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private EntityQuery KALMBIBBFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private IDFADMBGMDJ OIMODIDGOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private PHJHPLJJLBK GCJOAKHEKAP;

	[Cpp2IlInjected.Token(Token = "0x6000785")]
	[Cpp2IlInjected.Address(RVA = "0x5E840C0", Offset = "0x5E82EC0", VA = "0x185E840C0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000786")]
	[Cpp2IlInjected.Address(RVA = "0x5E84150", Offset = "0x5E82F50", VA = "0x185E84150", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000787")]
	[Cpp2IlInjected.Address(RVA = "0x5E84200", Offset = "0x5E83000", VA = "0x185E84200", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000788")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000789")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public DIDAAKCNCCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal class BNNIKKJMLDG : IJBEOJNEGGD<FBBDPNEHODE>
{
	[Cpp2IlInjected.Token(Token = "0x600078B")]
	[Cpp2IlInjected.Address(RVA = "0x5E82AF0", Offset = "0x5E818F0", VA = "0x185E82AF0", Slot = "14")]
	protected override void KGLKJLCHLKD(NativeArray<Entity> PFOPLIKJCHB, NativeArray<Entity> EFKAHNGKMND, NativeArray<Entity> NLOEOKCCIAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078C")]
	[Cpp2IlInjected.Address(RVA = "0x5E82C50", Offset = "0x5E81A50", VA = "0x185E82C50")]
	private static void KGLKJLCHLKD(NativeArray<Entity> PFOPLIKJCHB, NativeArray<Entity> NLOEOKCCIAH, ComponentDataFromEntity<global::CEGOIFELBED> CJHCFBEKFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x5E82D20", Offset = "0x5E81B20", VA = "0x185E82D20")]
	public BNNIKKJMLDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal abstract class IJBEOJNEGGD<TPlayerTag> : FMBIPPPJNCE where TPlayerTag : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private EntityQuery KPLOGBDCHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000445")]
	private EntityQuery PGHFCDFFLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private EntityQuery KBGOADGEIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000447")]
	private EntityQuery KNFEAIOEFIG;

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x36824A0", Offset = "0x36812A0", VA = "0x1836824A0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0x36826E0", Offset = "0x36814E0", VA = "0x1836826E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x36826B0", Offset = "0x36814B0", VA = "0x1836826B0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x3681A00", Offset = "0x3680800", VA = "0x183681A00")]
	private void EIDKIFFOEEP(EntityQuery LKMIGFDOIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x3681D30", Offset = "0x3680B30", VA = "0x183681D30")]
	private void JCNLBFGKJBE(EntityQuery LKMIGFDOIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x3681390", Offset = "0x3680190", VA = "0x183681390")]
	private void BGDKKFEKONI(EntityQuery LKMIGFDOIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract void KGLKJLCHLKD(NativeArray<Entity> PFOPLIKJCHB, NativeArray<Entity> EFKAHNGKMND, NativeArray<Entity> NLOEOKCCIAH);

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	protected IJBEOJNEGGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct CBIJPBKAOGI : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000448")]
	public int CPCFHDJMLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000449")]
	public int MMJFKHJNAML;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal struct JJGIJMPCIEG : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
public static class FFPMINPHOAO
{
	[Cpp2IlInjected.Token(Token = "0x400044A")]
	public static readonly (ComponentType userTag, ComponentType stateTag, ComponentType componentTag)[] BNAPPDKFBMB;
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000140")]
internal struct OFMHPOJCDCO : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000141")]
internal struct BGLDGMMEOJL : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
public class JLONNJHCOLN : FMBIPPPJNCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400044B")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	private EntityQuery HGBCDCOKBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400044D")]
	private ComponentTypes IDDONGMLPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	private NativeParallelHashSet<int> DHCANGLNDPB;

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B430", Offset = "0x5E8A230", VA = "0x185E8B430", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000798")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B7C0", Offset = "0x5E8A5C0", VA = "0x185E8B7C0", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000799")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B840", Offset = "0x5E8A640", VA = "0x185E8B840", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B390", Offset = "0x5E8A190", VA = "0x185E8B390")]
	public JobHandle BIMKNHCKLFD(JobHandle AHKLOHOGJID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600079B")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public JLONNJHCOLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000144")]
public struct FAOMFNKBCCM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private NativeArray<NGLDHKJAKDF> OBBJCDLHAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private NativeArray<int> GLIJFENGDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000454")]
	private NativeParallelHashMap<int, NGLDHKJAKDF> IPICIFCIEDJ;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public readonly int LNNNHJDOAMM
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x768180", Offset = "0x766F80", VA = "0x180768180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public readonly int KFBIDNKJJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0xADED20", Offset = "0xADDB20", VA = "0x180ADED20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x5E86580", Offset = "0x5E85380", VA = "0x185E86580")]
	public FAOMFNKBCCM(IReadOnlyCollection<MFGAIFFIFKP> IAEGOGAHMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E86490", Offset = "0x5E85290", VA = "0x185E86490")]
	public readonly LFFECALJCKG LKLFMILIDDD(int IDDPEMOGPEO)
	{
		return default(LFFECALJCKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E86410", Offset = "0x5E85210", VA = "0x185E86410", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000146")]
[DefaultMember("Item")]
public readonly struct LFFECALJCKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	private readonly int IDDPEMOGPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	private readonly int EDCLJBDOLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400045B")]
	private readonly NativeArray<NGLDHKJAKDF>.ReadOnly EKODFEEOAPM;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public int DCLHHJJDFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E8FFD0", Offset = "0x5E8EDD0", VA = "0x185E8FFD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public JDMAGEFMCIA BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60007AA")]
		[Cpp2IlInjected.Address(RVA = "0x5E8FF00", Offset = "0x5E8ED00", VA = "0x185E8FF00")]
		get
		{
			return default(JDMAGEFMCIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public int PMHKLIEDACO
	{
		[Cpp2IlInjected.Token(Token = "0x60007AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FBBF30", Offset = "0x1FBAD30", VA = "0x181FBBF30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public NativeArray<NGLDHKJAKDF>.ReadOnly ANDHJGEHEHH
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x3915B00", Offset = "0x3914900", VA = "0x183915B00")]
		get
		{
			return default(NativeArray<NGLDHKJAKDF>.ReadOnly);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E90000", Offset = "0x5E8EE00", VA = "0x185E90000")]
	public LFFECALJCKG(int IDDPEMOGPEO, int EDCLJBDOLOM, NativeArray<NGLDHKJAKDF>.ReadOnly EKODFEEOAPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
public readonly struct GKAAFOJHJKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public NativeList<Entity> BNLDGEIHFLO
	{
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public NativeList<Entity> MJAIMCMFLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0xA8D850", Offset = "0xA8C650", VA = "0x180A8D850")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public NativeList<byte> JCLAGBAANBG
	{
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD47AA0", VA = "0x180D48CA0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public NativeList<byte> HGMJHJBJGID
	{
		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5E260", VA = "0x180D5F460")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public NativeList<byte> KJONAICKLBP
	{
		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x89C9C0", Offset = "0x89B7C0", VA = "0x18089C9C0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<byte>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public ComponentType NEECIPJKOED
	{
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x764C40", Offset = "0x763A40", VA = "0x180764C40")]
		[CompilerGenerated]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public JobHandle GDNMHGNJJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x955D60", Offset = "0x954B60", VA = "0x180955D60")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public int PMHKLIEDACO
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x955D70", Offset = "0x954B70", VA = "0x180955D70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public int BCKEKODBDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x799220", Offset = "0x798020", VA = "0x180799220")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public bool MEGNBPIKOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E87900", Offset = "0x5E86700", VA = "0x185E87900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E87AA0", Offset = "0x5E868A0", VA = "0x185E87AA0")]
	public GKAAFOJHJKF(ComponentType ACNKJFPHPMG, JobHandle KMOBDGPHBOK, NativeList<Entity> PFOPLIKJCHB, NativeList<Entity> NCAHACNMMCC, NativeList<byte> LBFMJBKGAEE, NativeList<byte> BIGGMJNDPAF, NativeList<byte> LBIILAEFGHH, int EDCLJBDOLOM, int BAJPLFICGDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E87980", Offset = "0x5E86780", VA = "0x185E87980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
internal interface NHNJJHDMCBN
{
	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	bool MEGNBPIKOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	NativeArray<DJMPNJEFEHC> FJGELDALDBN
	{
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	NativeArray<NOGPJKFKBEI> FGECJAFMIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	NativeArray<DJMPNJEFEHC> LMPNEKGMPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JDHDOFLEGND([Out] NativeArray<int> DFFEGDMICHO, Allocator JFLEKJGGDHL);

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JMFIEBCFJEN(ComponentType ACNKJFPHPMG, [Out] GKAAFOJHJKF OEFJMJNGBID, [Out] LFFECALJCKG JEPAAHKBIBH);

	[Cpp2IlInjected.Token(Token = "0x60007BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NativeMultiHashMapAsync<Entity, CEIPHBPAHMF> KKIFMJAMFCA();
}
[Cpp2IlInjected.Token(Token = "0x2000149")]
internal static class AFHNCCPPCMG
{
	[Cpp2IlInjected.Token(Token = "0x60007C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E82070", Offset = "0x5E80E70", VA = "0x185E82070")]
	public static bool IMIPDCGIEFG(this NHNJJHDMCBN EPLFCMFNFIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014A")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
internal interface CDPGLFJJDKD
{
	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	NativeParallelMultiHashMap<Entity, CEIPHBPAHMF> HDHILDGHCOF
	{
		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	uint DLKOOFAOEBH
	{
		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AKKMLLFOHFF(NativeArray<DJMPNJEFEHC> BNJMINPAMOL, NativeArray<NOGPJKFKBEI> EIBIAHGBKEB, NativeArray<DJMPNJEFEHC> FFLLOLHFKDL, int POIEBPNEPKE);

	[Cpp2IlInjected.Token(Token = "0x60007C4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EDPMEGHKCGP([In] GKAAFOJHJKF HIKCEFIDFEJ);

	[Cpp2IlInjected.Token(Token = "0x60007C5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CDGOKLFMLDM(JobHandle KMOBDGPHBOK);
}
[Cpp2IlInjected.Token(Token = "0x200014B")]
public readonly struct ELBMLKGPNPA : IEquatable<ELBMLKGPNPA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	private readonly KIBKAPDMHFC NBHCOBHPFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	private readonly int BAJPLFICGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	private readonly int GBIFEPLNOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	private readonly int IPNEBMFIFEG;

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public KIBKAPDMHFC FNEOLKMBLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x9906E0", Offset = "0x98F4E0", VA = "0x1809906E0")]
		get
		{
			return default(KIBKAPDMHFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C7")]
	[Cpp2IlInjected.Address(RVA = "0x5E85C40", Offset = "0x5E84A40", VA = "0x185E85C40")]
	public unsafe ReadOnlySpan<byte> ADLJNDMGKOA(void* LOEJNMCLMMH)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C8")]
	[Cpp2IlInjected.Address(RVA = "0x5E85BB0", Offset = "0x5E849B0", VA = "0x185E85BB0")]
	public unsafe ReadOnlySpan<byte> ABOGMKEGJFD(void* LOEJNMCLMMH)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007C9")]
	[Cpp2IlInjected.Address(RVA = "0x106C320", Offset = "0x106B120", VA = "0x18106C320")]
	public ELBMLKGPNPA(KIBKAPDMHFC NBHCOBHPFBM, int MEDHPDICIDE, int GBIFEPLNOAI, int IPNEBMFIFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E85DE0", Offset = "0x5E84BE0", VA = "0x185E85DE0", Slot = "4")]
	public bool Equals(ELBMLKGPNPA MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E85CD0", Offset = "0x5E84AD0", VA = "0x185E85CD0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x5E85E70", Offset = "0x5E84C70", VA = "0x185E85E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200014C")]
public readonly struct CEIPHBPAHMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly KIBKAPDMHFC NBHCOBHPFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly int BAJPLFICGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private unsafe readonly byte* GBIFEPLNOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private unsafe readonly byte* IPNEBMFIFEG;

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public KIBKAPDMHFC FNEOLKMBLMK
	{
		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x9906E0", Offset = "0x98F4E0", VA = "0x1809906E0")]
		get
		{
			return default(KIBKAPDMHFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public int ALAHGBICDEI
	{
		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x1FBBF30", Offset = "0x1FBAD30", VA = "0x181FBBF30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public unsafe byte* NLFAGNNBFMH
	{
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x990730", Offset = "0x98F530", VA = "0x180990730")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public unsafe byte* LDECMAFCBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E82D60", Offset = "0x5E81B60", VA = "0x185E82D60")]
	public ONLJEFNJJKA ABOGMKEGJFD(Type PEMNIEMPPLO)
	{
		return default(ONLJEFNJJKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0x21CA0F0", Offset = "0x21C8EF0", VA = "0x1821CA0F0")]
	public T ADLJNDMGKOA<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007D1")]
	[Cpp2IlInjected.Address(RVA = "0x21CA0D0", Offset = "0x21C8ED0", VA = "0x1821CA0D0")]
	public T ABOGMKEGJFD<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E82E50", Offset = "0x5E81C50", VA = "0x185E82E50")]
	public unsafe CEIPHBPAHMF(KIBKAPDMHFC NBHCOBHPFBM, int MEDHPDICIDE, byte* GBIFEPLNOAI, byte* IPNEBMFIFEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
public readonly struct JDMAGEFMCIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private readonly int IDDPEMOGPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private readonly int NBHCOBHPFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	private readonly NGLDHKJAKDF OCEFOKCLIAN;

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public NGLDHKJAKDF MFFPLEFBKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x990730", Offset = "0x98F530", VA = "0x180990730")]
		get
		{
			return default(NGLDHKJAKDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A2A0", Offset = "0x5E890A0", VA = "0x185E8A2A0")]
	public JDMAGEFMCIA(int IDDPEMOGPEO, int NBHCOBHPFBM, NGLDHKJAKDF OCEFOKCLIAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014E")]
internal abstract class EPHOBAKOJBC : LNDOMDEMCJJ, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000471")]
	private FALPINKOHJI GHNPBHAOPHA;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	protected abstract CIDKNADIFBP GLKOKGCIDPI
	{
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60007D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E86280", Offset = "0x5E85080", VA = "0x185E86280", Slot = "16")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E862D0", Offset = "0x5E850D0", VA = "0x185E862D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E85EE0", Offset = "0x5E84CE0", VA = "0x185E85EE0", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	protected EPHOBAKOJBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200014F")]
internal class CHLIBOKHBDG : EPHOBAKOJBC
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	protected override CIDKNADIFBP GLKOKGCIDPI
	{
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "17")]
		get
		{
			return default(CIDKNADIFBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E83AE0", Offset = "0x5E828E0", VA = "0x185E83AE0")]
	public CHLIBOKHBDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000150")]
internal class JFDIEOAIPEI : EPHOBAKOJBC
{
	[Cpp2IlInjected.Token(Token = "0x17000108")]
	protected override CIDKNADIFBP GLKOKGCIDPI
	{
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC30", Offset = "0x7DDA30", VA = "0x1807DEC30", Slot = "17")]
		get
		{
			return default(CIDKNADIFBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A2B0", Offset = "0x5E890B0", VA = "0x185E8A2B0")]
	public JFDIEOAIPEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
public class CKLDEJCOMAD : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000472")]
	[MBPNJDODNHC]
	private FALPINKOHJI FDHNMOPAKHB;

	[Cpp2IlInjected.Token(Token = "0x60007E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E83B30", Offset = "0x5E82930", VA = "0x185E83B30", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E83B80", Offset = "0x5E82980", VA = "0x185E83B80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E3")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public CKLDEJCOMAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
[AlwaysUpdateSystem]
public class GNBGAJLOAOF : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	public enum LELNEBADDIB
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
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	[MBPNJDODNHC]
	private FALPINKOHJI GHNPBHAOPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	private JJMKMPFKOHD NDLIMBHAJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	private JCLKKNBMDMM DFNEODEDJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	private JKAFFFDGPDJ IOIBIJOKCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	private CFJGOCCOJIL DIEOPJMCHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	private KJABHDMIINH MGDBHBNGPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	private JPJIFPLCBDJ LBBNHAJPENO;

	[Cpp2IlInjected.Token(Token = "0x60007E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E87FF0", Offset = "0x5E86DF0", VA = "0x185E87FF0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E88380", Offset = "0x5E87180", VA = "0x185E88380", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E884F0", Offset = "0x5E872F0", VA = "0x185E884F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E87E70", Offset = "0x5E86C70", VA = "0x185E87E70")]
	private void ENFOJMMLMDP([Out] NativeArray<DJMPNJEFEHC> BNJMINPAMOL, [Out] NativeArray<NOGPJKFKBEI> EIBIAHGBKEB, [Out] NativeArray<DJMPNJEFEHC> FFLLOLHFKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E884A0", Offset = "0x5E872A0", VA = "0x185E884A0", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E88400", Offset = "0x5E87200", VA = "0x185E88400", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public GNBGAJLOAOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
internal readonly struct JJMKMPFKOHD
{
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000480")]
	private static readonly ProfilerMarker MKAIGIFCHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	private readonly FMBIPPPJNCE LOFHIHDMJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	private readonly World AEALPKECAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	private readonly EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	private readonly EntityQuery DKOAPOKGCDO;

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A9E0", Offset = "0x5E897E0", VA = "0x185E8A9E0")]
	public JJMKMPFKOHD(FMBIPPPJNCE LOFHIHDMJIG, World AEALPKECAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A480", Offset = "0x5E89280", VA = "0x185E8A480")]
	public (NativeArray<DJMPNJEFEHC>, NativeArray<NOGPJKFKBEI>) PFMOOMMEHLD()
	{
		return default((NativeArray<DJMPNJEFEHC>, NativeArray<NOGPJKFKBEI>));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct JPJIFPLCBDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000486")]
	private static readonly ProfilerMarker MKAIGIFCHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	private readonly FMBIPPPJNCE LOFHIHDMJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	private NativeList<(EntityQuery query, int componentIndex)> KIBAOHMPBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	private NativeList<(EntityQuery query, int componentIndex)> AMGPHMHFLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	private NativeList<(EntityQuery query, int componentIndex)> BPONHBBFEGO;

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C7F0", Offset = "0x5E8B5F0", VA = "0x185E8C7F0")]
	public JPJIFPLCBDJ(FMBIPPPJNCE LOFHIHDMJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BD50", Offset = "0x5E8AB50", VA = "0x185E8BD50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E8B980", Offset = "0x5E8A780", VA = "0x185E8B980")]
	public NativeList<(EntityQuery, int, int, GNBGAJLOAOF.LELNEBADDIB)> AIGBPIOINHN(uint PNIAGCFFKCJ, [Out] int OAJAPMKKPKH)
	{
		return default(NativeList<(EntityQuery, int, int, GNBGAJLOAOF.LELNEBADDIB)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C160", Offset = "0x5E8AF60", VA = "0x185E8C160")]
	private int JBKNJOMJMEF(GNBGAJLOAOF.LELNEBADDIB CPGOEPLHNCL, NativeList<(EntityQuery query, int typeIndex)> ENGEPLNNBDC, NativeList<(EntityQuery query, int typeIndex, int count, GNBGAJLOAOF.LELNEBADDIB mode)> PAGBPKBIGDK, uint PNIAGCFFKCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C6A0", Offset = "0x5E8B4A0", VA = "0x185E8C6A0")]
	private NativeList<(EntityQuery, int)> NGGOFABHGKH(NativeParallelHashSet<int> IAEGOGAHMLB, int LPMIKIHABEB)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C600", Offset = "0x5E8B400", VA = "0x185E8C600")]
	private NativeList<(EntityQuery, int)> LBBDKDIBACE(NativeParallelHashSet<int> IAEGOGAHMLB, int LPMIKIHABEB)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E8BDB0", Offset = "0x5E8ABB0", VA = "0x185E8BDB0")]
	private NativeList<(EntityQuery, int)> GCBKNKPPDOJ(NativeParallelHashSet<int> IAEGOGAHMLB, int LPMIKIHABEB, GNBGAJLOAOF.LELNEBADDIB CPGOEPLHNCL)
	{
		return default(NativeList<(EntityQuery, int)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E8C310", Offset = "0x5E8B110", VA = "0x185E8C310")]
	private NativeList<(EntityQuery, int)> KLGMKJOIDJH()
	{
		return default(NativeList<(EntityQuery, int)>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal readonly struct KJABHDMIINH
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[BurstCompile]
	private struct KKNGGAOJPHD : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		[ReadOnly]
		public EntityTypeHandle PEHFGIDIHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		[ReadOnly]
		public ComponentDataFromEntity<CBIJPBKAOGI> FFANNPNMHPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		[ReadOnly]
		public DynamicComponentTypeHandle HONPHMNBNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> LIPFCBBNAFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> MOGLPADALIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		[ReadOnly]
		public ComponentDataFromEntity HMKKEOLGEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		[ReadOnly]
		public NativeArray<byte>.ReadOnly CGOLGBPDGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		[ReadOnly]
		public NativeArray<NGLDHKJAKDF>.ReadOnly KOEHAKHEPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public ComponentDataFromEntity EIJJCFEBJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public NativeList<Entity> DFDFBFDIPIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public NativeList<Entity> KKOPCHCMCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public NativeList<byte> EAOCBBMIHMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public NativeList<byte> JMMLHKHKFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public NativeList<byte> GLEKPMPOBAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int BAJPLFICGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int EDCLJBDOLOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public bool NHDLCDIJMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public GNBGAJLOAOF.LELNEBADDIB CPGOEPLHNCL;

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DD60", Offset = "0x5E8CB60", VA = "0x185E8DD60", Slot = "4")]
		public void Execute(ArchetypeChunk NEFPDCFOPMI, int FDCDMNHMNAG, int PKLNFOPBAHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E1D0", Offset = "0x5E8CFD0", VA = "0x185E8E1D0")]
		private unsafe bool NJMFAILCJKO(Entity PIDOBPKJFID, Entity DFJLGBJLDPB, byte* MIEHPKKGJMC, byte* PGFMKGLAALO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E1B0", Offset = "0x5E8CFB0", VA = "0x185E8E1B0")]
		private unsafe void KBCPIACFDGK(byte* MIEHPKKGJMC, byte* PGFMKGLAALO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DCC0", Offset = "0x5E8CAC0", VA = "0x185E8DCC0")]
		private unsafe byte* CFFPLOFADGC(NativeArray<byte> IJDELNDAEIB, int FJLKBMOCNHL)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E140", Offset = "0x5E8CF40", VA = "0x185E8E140")]
		private unsafe byte* FNMLDDNLIII(Entity DFJLGBJLDPB)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x5E8DBD0", Offset = "0x5E8C9D0", VA = "0x185E8DBD0")]
		private unsafe byte* BLIJCFGPGFN(ArchetypeChunk NEFPDCFOPMI)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x5E8E110", Offset = "0x5E8CF10", VA = "0x185E8E110")]
		private static Entity FLENJCFICFO([In] CBIJPBKAOGI PFDMLBFKIAP)
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[BurstCompile]
	private struct MLPCIFFAKMI : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		[ReadOnly]
		public NativeList<Entity> KGHMAEHJKNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		[ReadOnly]
		public NativeList<byte> LKJNMKBGEEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		[ReadOnly]
		public NativeList<byte> BPLPBEBNEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		[ReadOnly]
		public NativeList<byte> MLCFGIPPJDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		[ReadOnly]
		public NativeArray<NGLDHKJAKDF>.ReadOnly KOEHAKHEPGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public NativeParallelMultiHashMap<Entity, CEIPHBPAHMF> GIGKMHAADHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int BAJPLFICGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public int EDCLJBDOLOM;

		[Cpp2IlInjected.Token(Token = "0x6000804")]
		[Cpp2IlInjected.Address(RVA = "0x5E900A0", Offset = "0x5E8EEA0", VA = "0x185E900A0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400048B")]
	private static readonly ProfilerMarker MKAIGIFCHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	private readonly FMBIPPPJNCE LOFHIHDMJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	private readonly World AEALPKECAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	private readonly FAOMFNKBCCM KFABJAFELAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	private readonly NativeParallelHashMap<int, Entity> GEAHAHPJBLF;

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D980", Offset = "0x5E8C780", VA = "0x185E8D980")]
	public KJABHDMIINH(FMBIPPPJNCE LOFHIHDMJIG, World AEALPKECAAC, FALPINKOHJI GHNPBHAOPHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E8D140", Offset = "0x5E8BF40", VA = "0x185E8D140")]
	public JobHandle PFMOOMMEHLD(CDPGLFJJDKD EPLFCMFNFIK, NativeList<(EntityQuery query, int typeIndex, int count, GNBGAJLOAOF.LELNEBADDIB mode)> DOBOMMPHLFG, JobHandle AHKLOHOGJID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CF80", Offset = "0x5E8BD80", VA = "0x185E8CF80")]
	private MLPCIFFAKMI INLJBPHNMGK([In] KKNGGAOJPHD GDEEEEKICEP, NativeParallelMultiHashMap<Entity, CEIPHBPAHMF> ONFNEGFDINN)
	{
		return default(MLPCIFFAKMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CB70", Offset = "0x5E8B970", VA = "0x185E8CB70")]
	private KKNGGAOJPHD FKPBLMJOCEE(ComponentType ACNKJFPHPMG, EntityManager DMFKBGANKCG, int HBIPBLIPABI, GNBGAJLOAOF.LELNEBADDIB CPGOEPLHNCL)
	{
		return default(KKNGGAOJPHD);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CFE0", Offset = "0x5E8BDE0", VA = "0x185E8CFE0")]
	private static void JBHNDFJBDCJ(CDPGLFJJDKD EPLFCMFNFIK, ComponentType ACNKJFPHPMG, JobHandle GLEFMKPHENM, [In] KKNGGAOJPHD GDEEEEKICEP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal readonly struct CFJGOCCOJIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private readonly JLONNJHCOLN HECCKCPKGGB;

	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private static readonly ProfilerMarker MKAIGIFCHJM;

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0x5E83A80", Offset = "0x5E82880", VA = "0x185E83A80")]
	public CFJGOCCOJIL(World AEALPKECAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x5E83850", Offset = "0x5E82650", VA = "0x185E83850")]
	public JobHandle PFMOOMMEHLD(JobHandle DEMPBJMFGPI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal readonly struct JCLKKNBMDMM
{
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private static readonly ProfilerMarker MKAIGIFCHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private readonly FMBIPPPJNCE LOFHIHDMJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	private readonly World AEALPKECAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	private readonly EntityQuery OAPMPEPJLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	private readonly EntityQuery OMMNDFNCIPD;

	[Cpp2IlInjected.Token(Token = "0x6000808")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A170", Offset = "0x5E88F70", VA = "0x185E8A170")]
	public JCLKKNBMDMM(FMBIPPPJNCE LOFHIHDMJIG, World AEALPKECAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000809")]
	[Cpp2IlInjected.Address(RVA = "0x5E89F40", Offset = "0x5E88D40", VA = "0x185E89F40")]
	public NativeArray<DJMPNJEFEHC> PFMOOMMEHLD()
	{
		return default(NativeArray<DJMPNJEFEHC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x5E89B60", Offset = "0x5E88960", VA = "0x185E89B60")]
	public void ALHGPKEGBPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0x5E89C00", Offset = "0x5E88A00", VA = "0x185E89C00")]
	private NativeArray<DJMPNJEFEHC> FEFPMOEDJPP(EntityQuery LKMIGFDOIIA)
	{
		return default(NativeArray<DJMPNJEFEHC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal readonly struct JKAFFFDGPDJ
{
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private sealed class ANBAPNAOCHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public FMBIPPPJNCE system;

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ANBAPNAOCHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x5E82180", Offset = "0x5E80F80", VA = "0x185E82180")]
		internal (EntityQuery, ComponentType) HFHOEBPBINJ((ComponentType userTag, ComponentType stateTag, ComponentType componentTag) t)
		{
			return default((EntityQuery, ComponentType));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	private static readonly ProfilerMarker MKAIGIFCHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	private readonly FMBIPPPJNCE LOFHIHDMJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	private readonly (EntityQuery userTagQuery, ComponentType stateTag)[] JLJGDDIPCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private readonly EntityQuery EEAKPIDNBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private readonly EntityQuery PIEFKGMMJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private readonly ComponentTypes MPJMHHNOBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private readonly ComponentTypes HGOGLIAAJDM;

	[Cpp2IlInjected.Token(Token = "0x600080D")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AE90", Offset = "0x5E89C90", VA = "0x185E8AE90")]
	public JKAFFFDGPDJ(FMBIPPPJNCE LOFHIHDMJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x5E8AB10", Offset = "0x5E89910", VA = "0x185E8AB10")]
	public void PFMOOMMEHLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200015E")]
internal class KFMFEBILOJB : NMDHNPPDADH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200015F")]
	public struct GAGADHOIOEK : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	protected override ComponentType GMGOAKOIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x5E8CA50", Offset = "0x5E8B850", VA = "0x185E8CA50", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	protected override ComponentType DBDCLBELNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x5E8C9F0", Offset = "0x5E8B7F0", VA = "0x185E8C9F0", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	protected override ComponentType GJDPPILFOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x5E8CA20", Offset = "0x5E8B820", VA = "0x185E8CA20", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x5E8CB10", Offset = "0x5E8B910", VA = "0x185E8CB10")]
	public KFMFEBILOJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal class JGABELLBPOK : NMDHNPPDADH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	public struct CDHJAKECGBD : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	protected override ComponentType GMGOAKOIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A360", Offset = "0x5E89160", VA = "0x185E8A360", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	protected override ComponentType DBDCLBELNDH
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A300", Offset = "0x5E89100", VA = "0x185E8A300", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	protected override ComponentType GJDPPILFOPC
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x5E8A330", Offset = "0x5E89130", VA = "0x185E8A330", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x5E8A420", Offset = "0x5E89220", VA = "0x185E8A420")]
	public JGABELLBPOK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000162")]
public struct BBBLBPDLMMJ : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[ICOGLANPNEA]
public class BHOFKGENKOE : IALGNLMAPEN
{
	[Cpp2IlInjected.Token(Token = "0x2000164")]
	private struct LCHHHBGKAMC : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		[ReadOnly]
		public NativeParallelHashSet<int> NCCJHBFCKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		[ReadOnly]
		public EntityTypeHandle JEDKCNAJPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> CKDCLLCPHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public NativeList<Entity>.ParallelWriter GKNBKLENGDC;

		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0x5E8FB30", Offset = "0x5E8E930", VA = "0x185E8FB30", Slot = "4")]
		public void Execute(ArchetypeChunk NEFPDCFOPMI, int FDCDMNHMNAG, int PKLNFOPBAHA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x6000820")]
	[Cpp2IlInjected.Address(RVA = "0x5E82580", Offset = "0x5E81380", VA = "0x185E82580", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x5E82610", Offset = "0x5E81410", VA = "0x185E82610", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x5E82530", Offset = "0x5E81330", VA = "0x185E82530")]
	private EntityCommandBufferSystem FIIENAOFPBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000823")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public BHOFKGENKOE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000165")]
	[CompilerGenerated]
	[ICOGLANPNEA]
	public class DebugPostDeserializeRemoveOrphanedSplinePointsSystem : IALGNLMAPEN
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
			public ComponentDataFromEntity<GHJGKJPPKGB> splineDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004CA")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			[ReadOnly]
			public ComponentTypeHandle<OKOJMLFLNIA> __pointTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0x5E845E0", Offset = "0x5E833E0", VA = "0x185E845E0")]
			private void LFGCENJAPBK(Entity entity, [In][NoAlias] OKOJMLFLNIA point)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0x5E844C0", Offset = "0x5E832C0", VA = "0x185E844C0", Slot = "4")]
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
		private ComponentTypeHandle<OKOJMLFLNIA> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0x5E84850", Offset = "0x5E83650", VA = "0x185E84850", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000827")]
		[Cpp2IlInjected.Address(RVA = "0x5E842A0", Offset = "0x5E830A0", VA = "0x185E842A0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void BLCJENAAJFH(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000828")]
		[Cpp2IlInjected.Address(RVA = "0x5E84470", Offset = "0x5E83270", VA = "0x185E84470")]
		private EntityCommandBufferSystem FIIENAOFPBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x5E84330", Offset = "0x5E83130", VA = "0x185E84330")]
		private JobHandle ENDDOFGCLLB(EntityCommandBuffer ecb, ComponentDataFromEntity<GHJGKJPPKGB> splineDataRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x5E84670", Offset = "0x5E83470", VA = "0x185E84670", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public DebugPostDeserializeRemoveOrphanedSplinePointsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
[ICOGLANPNEA]
public class GGMOJLAHPBP : IALGNLMAPEN
{
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x600082E")]
	[Cpp2IlInjected.Address(RVA = "0x5E875F0", Offset = "0x5E863F0", VA = "0x185E875F0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600082F")]
	[Cpp2IlInjected.Address(RVA = "0x5E87690", Offset = "0x5E86490", VA = "0x185E87690", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000830")]
	[Cpp2IlInjected.Address(RVA = "0x5E875A0", Offset = "0x5E863A0", VA = "0x185E875A0")]
	private EntityCommandBufferSystem FIIENAOFPBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000831")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public GGMOJLAHPBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
[ICOGLANPNEA]
public class GKMEDOHKCHL : IALGNLMAPEN
{
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x6000833")]
	[Cpp2IlInjected.Address(RVA = "0x5E87B50", Offset = "0x5E86950", VA = "0x185E87B50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000834")]
	[Cpp2IlInjected.Address(RVA = "0x5E87C10", Offset = "0x5E86A10", VA = "0x185E87C10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0x5E87B00", Offset = "0x5E86900", VA = "0x185E87B00")]
	private EntityCommandBufferSystem FIIENAOFPBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public GKMEDOHKCHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
[UpdateAfter(typeof(BHOFKGENKOE))]
public class LEBBEIDHMJO : FMBIPPPJNCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	private EntityArchetype ONDNKKGIOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x6000838")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FC60", Offset = "0x5E8EA60", VA = "0x185E8FC60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000839")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FD80", Offset = "0x5E8EB80", VA = "0x185E8FD80", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083A")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FC10", Offset = "0x5E8EA10", VA = "0x185E8FC10")]
	private EntityCommandBufferSystem FIIENAOFPBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public LEBBEIDHMJO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	internal class PostDeserializeAddSplinePointsToSplinesSystem : FMBIPPPJNCE
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
			[Cpp2IlInjected.Address(RVA = "0x5E93B70", Offset = "0x5E92970", VA = "0x185E93B70")]
			private void LFGCENJAPBK(Entity spline)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0x5E93AC0", Offset = "0x5E928C0", VA = "0x185E93AC0", Slot = "4")]
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
			public ComponentTypeHandle<OKOJMLFLNIA> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000845")]
			[Cpp2IlInjected.Address(RVA = "0x5E93D40", Offset = "0x5E92B40", VA = "0x185E93D40")]
			private void LFGCENJAPBK(Entity splinePoint, [In][NoAlias] OKOJMLFLNIA splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(RVA = "0x5E93C20", Offset = "0x5E92A20", VA = "0x185E93C20", Slot = "4")]
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
		private ComponentTypeHandle<OKOJMLFLNIA> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x5E94100", Offset = "0x5E92F00", VA = "0x185E94100", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x5E941C0", Offset = "0x5E92FC0", VA = "0x185E941C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0x5E93A70", Offset = "0x5E92870", VA = "0x185E93A70")]
		private EntityCommandBufferSystem FIIENAOFPBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083F")]
		[Cpp2IlInjected.Address(RVA = "0x5E93970", Offset = "0x5E92770", VA = "0x185E93970")]
		private void COMPOHGLJIK(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000840")]
		[Cpp2IlInjected.Address(RVA = "0x5E93820", Offset = "0x5E92620", VA = "0x185E93820")]
		private void BDAPOHKKOBM(EntityCommandBuffer cb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x5E93DF0", Offset = "0x5E92BF0", VA = "0x185E93DF0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PostDeserializeAddSplinePointsToSplinesSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
public class PKAAOPLHBPG : FMBIPPPJNCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x6000847")]
	[Cpp2IlInjected.Address(RVA = "0x5E92EE0", Offset = "0x5E91CE0", VA = "0x185E92EE0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000848")]
	[Cpp2IlInjected.Address(RVA = "0x5E92FB0", Offset = "0x5E91DB0", VA = "0x185E92FB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000849")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public PKAAOPLHBPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
internal sealed class NNNJEBOAJEO : ParentSystemBase<ParentData, PreviousParentData, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x600084A")]
	[Cpp2IlInjected.Address(RVA = "0x89AA00", Offset = "0x899800", VA = "0x18089AA00", Slot = "14")]
	protected override EntityQueryDesc FilterNewParentQuery(EntityQueryDesc LKMIGFDOIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600084B")]
	[Cpp2IlInjected.Address(RVA = "0x89AA00", Offset = "0x899800", VA = "0x18089AA00", Slot = "15")]
	protected override EntityQueryDesc FilterRemovedParentsQuery(EntityQueryDesc LKMIGFDOIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600084C")]
	[Cpp2IlInjected.Address(RVA = "0x89AA00", Offset = "0x899800", VA = "0x18089AA00", Slot = "16")]
	protected override EntityQueryDesc FilterExistingParentsQuery(EntityQueryDesc LKMIGFDOIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600084D")]
	[Cpp2IlInjected.Address(RVA = "0x5E925E0", Offset = "0x5E913E0", VA = "0x185E925E0", Slot = "17")]
	protected override EntityQueryDesc FilterDeletedParentsQuery(EntityQueryDesc LKMIGFDOIIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600084E")]
	[Cpp2IlInjected.Address(RVA = "0x5E92620", Offset = "0x5E91420", VA = "0x185E92620")]
	public NNNJEBOAJEO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[ICOGLANPNEA]
	[CompilerGenerated]
	public class PostDeserializeRemoveComponentSerializedVersionDataSystem : FMBIPPPJNCE
	{
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0x5E946D0", Offset = "0x5E934D0", VA = "0x185E946D0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0x5E94770", Offset = "0x5E93570", VA = "0x185E94770", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0x5E944E0", Offset = "0x5E932E0", VA = "0x185E944E0")]
		private EntityCommandBufferSystem FIIENAOFPBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x5E94530", Offset = "0x5E93330", VA = "0x185E94530", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PostDeserializeRemoveComponentSerializedVersionDataSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
public class BAECCKHLGHO : GAFMEHPPBBK
{
	[Cpp2IlInjected.Token(Token = "0x6000855")]
	[Cpp2IlInjected.Address(RVA = "0x5E824E0", Offset = "0x5E812E0", VA = "0x185E824E0", Slot = "14")]
	protected override EntityCommandBufferSystem FIIENAOFPBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000856")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public BAECCKHLGHO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	internal class PostDeserializeSortSplinePointsSystem : FMBIPPPJNCE
	{
		[Cpp2IlInjected.Token(Token = "0x2000172")]
		private struct OrderComparer : IComparer<Entity>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			[ReadOnly]
			public ComponentDataFromEntity<DJJFFCHIFLN> orderRO;

			[Cpp2IlInjected.Token(Token = "0x600085B")]
			[Cpp2IlInjected.Address(RVA = "0x5E92DE0", Offset = "0x5E91BE0", VA = "0x185E92DE0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E94C50", Offset = "0x5E93A50", VA = "0x185E94C50")]
			private void LFGCENJAPBK(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600085D")]
			[Cpp2IlInjected.Address(RVA = "0x5E94B20", Offset = "0x5E93920", VA = "0x185E94B20", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E94FE0", Offset = "0x5E93DE0", VA = "0x185E94FE0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x5E949F0", Offset = "0x5E937F0", VA = "0x185E949F0")]
		private void FENBBNIIDII(OrderComparer comparer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x5E94CE0", Offset = "0x5E93AE0", VA = "0x185E94CE0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PostDeserializeSortSplinePointsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000174")]
	[CompilerGenerated]
	public class PostDeserializeTransformRootsSystem : FMBIPPPJNCE
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
			public ComponentTypeHandle<HDEJALOFGAC> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000867")]
			[Cpp2IlInjected.Address(RVA = "0x5E80790", Offset = "0x5E7F590", VA = "0x185E80790")]
			private void LFGCENJAPBK([NoAlias] HDEJALOFGAC data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000868")]
			[Cpp2IlInjected.Address(RVA = "0x5E952C0", Offset = "0x5E940C0", VA = "0x185E952C0", Slot = "4")]
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
			public ComponentTypeHandle<PEDPLCBIGKO> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000869")]
			[Cpp2IlInjected.Address(RVA = "0x5E809C0", Offset = "0x5E7F7C0", VA = "0x185E809C0")]
			private void LFGCENJAPBK([NoAlias] PEDPLCBIGKO data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0x5E95390", Offset = "0x5E94190", VA = "0x185E95390", Slot = "4")]
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
			public ComponentTypeHandle<BOMPBJOFHHO> __authoredPoseTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			[ReadOnly]
			public ComponentTypeHandle<HDEJALOFGAC> __poseTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600086B")]
			[Cpp2IlInjected.Address(RVA = "0x5E809D0", Offset = "0x5E7F7D0", VA = "0x185E809D0")]
			private void LFGCENJAPBK([NoAlias] BOMPBJOFHHO authoredPose, [In][NoAlias] HDEJALOFGAC pose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0x5E95460", Offset = "0x5E94260", VA = "0x185E95460", Slot = "4")]
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
			public ComponentTypeHandle<CBCEOBHEKLO> __authoredScaleTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			[ReadOnly]
			public ComponentTypeHandle<PEDPLCBIGKO> __scaleTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0x5E809F0", Offset = "0x5E7F7F0", VA = "0x185E809F0")]
			private void LFGCENJAPBK([NoAlias] CBCEOBHEKLO authoredScale, [In][NoAlias] PEDPLCBIGKO scale)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600086E")]
			[Cpp2IlInjected.Address(RVA = "0x5E955B0", Offset = "0x5E943B0", VA = "0x185E955B0", Slot = "4")]
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
		private ComponentTypeHandle<HDEJALOFGAC> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private ComponentTypeHandle<PEDPLCBIGKO> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private ComponentTypeHandle<BOMPBJOFHHO> __RecRoom_Components_AuthoredLocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private ComponentTypeHandle<HDEJALOFGAC> __RecRoom_Components_LocalPoseData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private ComponentTypeHandle<CBCEOBHEKLO> __RecRoom_Components_AuthoredLocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private ComponentTypeHandle<PEDPLCBIGKO> __RecRoom_Components_LocalUniformScaleData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600085E")]
		[Cpp2IlInjected.Address(RVA = "0x5E96630", Offset = "0x5E95430", VA = "0x185E96630", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x5E95700", Offset = "0x5E94500", VA = "0x185E95700")]
		private void MJGHIEAMPBC([In] GNMGEBAMPGE transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0x5E95B60", Offset = "0x5E94960", VA = "0x185E95B60")]
		private void ONJGCKHNBBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x5E95190", Offset = "0x5E93F90", VA = "0x185E95190")]
		private JobHandle DOMMBPPGEDH(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x5E95920", Offset = "0x5E94720", VA = "0x185E95920")]
		private JobHandle MOMKPBEIMDJ(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x5E96B20", Offset = "0x5E95920", VA = "0x185E96B20")]
		private JobHandle PGIJDIPBFIG(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x5E95A20", Offset = "0x5E94820", VA = "0x185E95A20")]
		private JobHandle ODIIKMOIBNB(JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0x5E95DA0", Offset = "0x5E94BA0", VA = "0x185E95DA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PostDeserializeTransformRootsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
public static class KFFGGADLIKP
{
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	public interface ENLDGKCFABN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017C")]
	public interface NCLKCICFIDF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	public class LNGGMPCCCFI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200017E")]
	public class NKLBNPLMOCH : NCLKCICFIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0x5E92060", Offset = "0x5E90E60", VA = "0x185E92060")]
		public NKLBNPLMOCH(ComponentType JIHPAFENIMM, ComponentType MOELNMOKDBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017F")]
	public class BIODAFCNNHI : NCLKCICFIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x369A320", Offset = "0x3699120", VA = "0x18369A320")]
		public BIODAFCNNHI(ComponentType JIHPAFENIMM, ComponentType[] MOELNMOKDBA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000180")]
	public class KKOPLJIMEKI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x23FC520", Offset = "0x23FB320", VA = "0x1823FC520")]
	public static NCLKCICFIDF IGEJICFKKFB<TFrom, TTo>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x23FC400", Offset = "0x23FB200", VA = "0x1823FC400")]
	public static NCLKCICFIDF HJCFNFBNLLH<TFrom>(params ComponentType[] IMLAGLECAAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
public class OBAGHMFMHNL : FIEEDLLEKHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770F00", VA = "0x180772100")]
	public OBAGHMFMHNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
public class NMHINHEPLMB : IALGNLMAPEN
{
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x5E920F0", Offset = "0x5E90EF0", VA = "0x185E920F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000877")]
	[Cpp2IlInjected.Address(RVA = "0x5E920A0", Offset = "0x5E90EA0", VA = "0x185E920A0")]
	private EntityCommandBufferSystem FIIENAOFPBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000878")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public NMHINHEPLMB()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000184")]
	[CompilerGenerated]
	[OBAGHMFMHNL]
	public class PostDeserializeUpgrade_Convert_ObjectPolicyData : KKFDAOOLJNI
	{
		[Cpp2IlInjected.Token(Token = "0x2000185")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PostDeserializeUpgrade_Convert_ObjectPolicyData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			public GNDAPMOFICG<DHPHIHHLCAG> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			public GNDAPMOFICG<JKNDOMJBHAG> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			public GNDAPMOFICG<HGJMAKDKJAP> v2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000505")]
			public GNDAPMOFICG<IIKFGABJCHA> v3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000506")]
			public EPFBIHFMNAJ<OLLGOOGNBNN> v4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000507")]
			public HGJMAKDKJAP v2Default;

			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0x5E97E40", Offset = "0x5E96C40", VA = "0x185E97E40")]
			private void LFGCENJAPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0x5E97E30", Offset = "0x5E96C30", VA = "0x185E97E30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		protected override GKFGDEJLFAD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600087D")]
			[Cpp2IlInjected.Address(RVA = "0x5E97DE0", Offset = "0x5E96BE0", VA = "0x185E97DE0", Slot = "14")]
			get
			{
				return default(GKFGDEJLFAD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x5E97810", Offset = "0x5E96610", VA = "0x185E97810", Slot = "15")]
		public override IEnumerable<KFFGGADLIKP.NCLKCICFIDF> BCNDOAJLFIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x5E97490", Offset = "0x5E96290", VA = "0x185E97490", Slot = "16")]
		protected override void ANBFDMHLINP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x5E979F0", Offset = "0x5E967F0", VA = "0x185E979F0")]
		private static void DMLDLPBHLHN(HJCCEALEOGO<JKNDOMJBHAG> srcVersion, HJCCEALEOGO<HGJMAKDKJAP> dstVersion, HGJMAKDKJAP dstDefault)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x5E97CC0", Offset = "0x5E96AC0", VA = "0x185E97CC0")]
		private static void LBJNKPEHOPK(HJCCEALEOGO<HGJMAKDKJAP> srcVersion, HJCCEALEOGO<IIKFGABJCHA> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x5E97B90", Offset = "0x5E96990", VA = "0x185E97B90")]
		private static void GPOPAOJAIMM(HJCCEALEOGO<IIKFGABJCHA> srcVersion, HJCCEALEOGO<OLLGOOGNBNN> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x5E98500", Offset = "0x5E97300", VA = "0x185E98500")]
		private JobHandle NLBMBLGLKLP(GNDAPMOFICG<DHPHIHHLCAG> v0, GNDAPMOFICG<JKNDOMJBHAG> v1, GNDAPMOFICG<HGJMAKDKJAP> v2, GNDAPMOFICG<IIKFGABJCHA> v3, EPFBIHFMNAJ<OLLGOOGNBNN> v4, HGJMAKDKJAP v2Default, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PostDeserializeUpgrade_Convert_ObjectPolicyData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000186")]
	[OBAGHMFMHNL]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_OMShapeContainerData : KKFDAOOLJNI
	{
		[Cpp2IlInjected.Token(Token = "0x2000187")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_OMShapeContainerData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000509")]
			public GNDAPMOFICG<GBFDACAEBKA> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050A")]
			public EPFBIHFMNAJ<AGDPGJDMHLG> v2;

			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x5E970F0", Offset = "0x5E95EF0", VA = "0x185E970F0")]
			private void LFGCENJAPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0x5E970E0", Offset = "0x5E95EE0", VA = "0x185E970E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		protected override GKFGDEJLFAD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0x5E97090", Offset = "0x5E95E90", VA = "0x185E97090", Slot = "14")]
			get
			{
				return default(GKFGDEJLFAD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x5E96DD0", Offset = "0x5E95BD0", VA = "0x185E96DD0", Slot = "15")]
		public override IEnumerable<KFFGGADLIKP.NCLKCICFIDF> BCNDOAJLFIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x5E96C60", Offset = "0x5E95A60", VA = "0x185E96C60", Slot = "16")]
		protected override void ANBFDMHLINP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x5E96E90", Offset = "0x5E95C90", VA = "0x185E96E90")]
		private static void DMLDLPBHLHN(HJCCEALEOGO<GBFDACAEBKA> srcVersion, HJCCEALEOGO<AGDPGJDMHLG> dstVersion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x5E96F60", Offset = "0x5E95D60", VA = "0x185E96F60")]
		private JobHandle EDNHKNJNOGF(GNDAPMOFICG<GBFDACAEBKA> v1, EPFBIHFMNAJ<AGDPGJDMHLG> v2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PostDeserializeUpgrade_Convert_OMShapeContainerData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	[OBAGHMFMHNL]
	[ICOGLANPNEA]
	public class PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data : KKFDAOOLJNI, KFFGGADLIKP.ENLDGKCFABN
	{
		[Cpp2IlInjected.Token(Token = "0x2000189")]
		private struct PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400050C")]
			public GNDAPMOFICG<CPAHCBLMOCH> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400050D")]
			public GNDAPMOFICG<PDKKPKEINKD> v1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400050E")]
			public EntityCommandBuffer ecb;

			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0x5E98E40", Offset = "0x5E97C40", VA = "0x185E98E40")]
			private void LFGCENJAPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0x5E98E30", Offset = "0x5E97C30", VA = "0x185E98E30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		protected override GKFGDEJLFAD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0x5E98DE0", Offset = "0x5E97BE0", VA = "0x185E98DE0", Slot = "14")]
			get
			{
				return default(GKFGDEJLFAD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x5E989E0", Offset = "0x5E977E0", VA = "0x185E989E0", Slot = "15")]
		public override IEnumerable<KFFGGADLIKP.NCLKCICFIDF> BCNDOAJLFIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x5E987B0", Offset = "0x5E975B0", VA = "0x185E987B0", Slot = "16")]
		protected override void ANBFDMHLINP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x5E98C50", Offset = "0x5E97A50", VA = "0x185E98C50")]
		private static void GHNPJEMJEHN(BOKLHAJOLDD<PDKKPKEINKD> d1, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x5E98B00", Offset = "0x5E97900", VA = "0x185E98B00")]
		private JobHandle FCLEMMPMCNG(GNDAPMOFICG<CPAHCBLMOCH> v0, GNDAPMOFICG<PDKKPKEINKD> v1, EntityCommandBuffer ecb, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PostDeserializeUpgrade_Convert_RRObjectPrefabV1Data()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[OBAGHMFMHNL]
	[CompilerGenerated]
	public class PostDeserializeUpgrade_Convert_SerializeEmbodiedData : KKFDAOOLJNI
	{
		[Cpp2IlInjected.Token(Token = "0x200018B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PostDeserializeUpgrade_Convert_SerializeEmbodiedData_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public GNDAPMOFICG<FBOKOEFEHLE> v0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public EPFBIHFMNAJ<PHGGCAODHCI> v1;

			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0x5E996B0", Offset = "0x5E984B0", VA = "0x185E996B0")]
			private void LFGCENJAPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x5E996A0", Offset = "0x5E984A0", VA = "0x185E996A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		protected override GKFGDEJLFAD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0x5E99650", Offset = "0x5E98450", VA = "0x185E99650", Slot = "14")]
			get
			{
				return default(GKFGDEJLFAD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x5E99460", Offset = "0x5E98260", VA = "0x185E99460", Slot = "15")]
		public override IEnumerable<KFFGGADLIKP.NCLKCICFIDF> BCNDOAJLFIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x5E992F0", Offset = "0x5E980F0", VA = "0x185E992F0", Slot = "16")]
		protected override void ANBFDMHLINP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E99520", Offset = "0x5E98320", VA = "0x185E99520")]
		private JobHandle KEOFCCPKNGF(GNDAPMOFICG<FBOKOEFEHLE> v0, EPFBIHFMNAJ<PHGGCAODHCI> v1, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PostDeserializeUpgrade_Convert_SerializeEmbodiedData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[OBAGHMFMHNL]
public class OMNEELDOBBL : FMBIPPPJNCE, KFFGGADLIKP.ENLDGKCFABN
{
	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public IEnumerable<Type> EFHEHGGBKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E92850", Offset = "0x5E91650", VA = "0x185E92850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008A7")]
	[Cpp2IlInjected.Address(RVA = "0x5E92AC0", Offset = "0x5E918C0", VA = "0x185E92AC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A8")]
	[Cpp2IlInjected.Address(RVA = "0x5E92800", Offset = "0x5E91600", VA = "0x185E92800")]
	private EntityCommandBufferSystem FIIENAOFPBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008A9")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public OMNEELDOBBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
public class EIJLKGDAKCL : NPDCGAHEIOF
{
	[Cpp2IlInjected.Token(Token = "0x4000512")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	protected override AKACOOECCNI BEKNGGGDLIC
	{
		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "15")]
		get
		{
			return default(AKACOOECCNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E85860", Offset = "0x5E84660", VA = "0x185E85860", Slot = "16")]
	protected override void PGFBJGGICAE(AKACOOECCNI KCPGKFKLEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E85810", Offset = "0x5E84610", VA = "0x185E85810")]
	private EntityCommandBufferSystem FIIENAOFPBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E85B60", Offset = "0x5E84960", VA = "0x185E85B60")]
	public EIJLKGDAKCL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200018E")]
	[CompilerGenerated]
	[OBAGHMFMHNL]
	public class PostDeserializeUpgrade_Split_ContainerData : FMBIPPPJNCE, KFFGGADLIKP.ENLDGKCFABN
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
			public NativeArray<MPEAMMCMNBD> v1Data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public ComponentTypes newComponents;

			[Cpp2IlInjected.Token(Token = "0x60008B6")]
			[Cpp2IlInjected.Address(RVA = "0x5E99BF0", Offset = "0x5E989F0", VA = "0x185E99BF0")]
			private void LFGCENJAPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0x5E99BE0", Offset = "0x5E989E0", VA = "0x185E99BE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private ComponentType[] newComponentTypes;

		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E99990", Offset = "0x5E98790", VA = "0x185E99990", Slot = "14")]
		public IEnumerable<KFFGGADLIKP.NCLKCICFIDF> BCNDOAJLFIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E99ED0", Offset = "0x5E98CD0", VA = "0x185E99ED0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x5E99A50", Offset = "0x5E98850", VA = "0x185E99A50")]
		private EntityCommandBufferSystem FIIENAOFPBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x5E99AA0", Offset = "0x5E988A0", VA = "0x185E99AA0")]
		private JobHandle KADJNKDJLPF(EntityCommandBuffer ecb, NativeArray<Entity> entities, NativeArray<MPEAMMCMNBD> v1Data, ComponentTypes newComponents, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008B3")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A3B0", Offset = "0x5E991B0", VA = "0x185E9A3B0")]
		public PostDeserializeUpgrade_Split_ContainerData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
[AlwaysUpdateSystem]
public abstract class KKFDAOOLJNI : FMBIPPPJNCE, KFFGGADLIKP.ENLDGKCFABN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private NativeList<EntityQuery> DOBOMMPHLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private bool NIKALCFCBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400051B")]
	private EntityCommandBufferSystem NGLMJAHNOHO;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	protected bool GBAJLLCPBJD
	{
		[Cpp2IlInjected.Token(Token = "0x60008B8")]
		[Cpp2IlInjected.Address(RVA = "0x55CC370", Offset = "0x55CB170", VA = "0x1855CC370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	protected abstract GKFGDEJLFAD NGLKBDEIIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60008B9")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60008BA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public abstract IEnumerable<KFFGGADLIKP.NCLKCICFIDF> BCNDOAJLFIB();

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DA50", Offset = "0x5E8C850", VA = "0x185E8DA50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DB70", Offset = "0x5E8C970", VA = "0x185E8DB70", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DB20", Offset = "0x5E8C920", VA = "0x185E8DB20", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void ANBFDMHLINP();

	[Cpp2IlInjected.Token(Token = "0x60008BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E8DA00", Offset = "0x5E8C800", VA = "0x185E8DA00")]
	protected EntityCommandBufferSystem FIIENAOFPBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60008C0")]
	[Cpp2IlInjected.Address(RVA = "0x23FFFB0", Offset = "0x23FEDB0", VA = "0x1823FFFB0")]
	protected EntityQuery EFJGDOIBNCL<T>() where T : struct, IComponentData
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C1")]
	[Cpp2IlInjected.Address(RVA = "0x23FF1A0", Offset = "0x23FDFA0", VA = "0x1823FF1A0")]
	protected GNDAPMOFICG<T> AFEEGENDFIH<T>() where T : struct, IComponentData
	{
		return default(GNDAPMOFICG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C2")]
	[Cpp2IlInjected.Address(RVA = "0x23FFEA0", Offset = "0x23FECA0", VA = "0x1823FFEA0")]
	protected EPFBIHFMNAJ<T> BKHNEMMBJCD<T>() where T : struct, IComponentData
	{
		return default(EPFBIHFMNAJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C3")]
	[Cpp2IlInjected.Address(RVA = "0x2400570", Offset = "0x23FF370", VA = "0x182400570")]
	protected static void OKGCMHNCDCG<T1, T2>(BOKLHAJOLDD<T1> FNHKBKFHCBA, BOKLHAJOLDD<T2> ENGIIBEHEGI) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C4")]
	[Cpp2IlInjected.Address(RVA = "0x2400570", Offset = "0x23FF370", VA = "0x182400570")]
	protected static void OKGCMHNCDCG<T1, T2>(BOKLHAJOLDD<T1> FNHKBKFHCBA, NGLEJMHDBBB<T2> ENGIIBEHEGI) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x24004B0", Offset = "0x23FF2B0", VA = "0x1824004B0")]
	private static void OKGCMHNCDCG<T1, T2>(HJCCEALEOGO<T1> FNHKBKFHCBA, HJCCEALEOGO<T2> ENGIIBEHEGI) where T1 : struct, IComponentData where T2 : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	protected KKFDAOOLJNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
public abstract class NPDCGAHEIOF : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	protected virtual AKACOOECCNI HIKNALLHAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "14")]
		get
		{
			return default(AKACOOECCNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	protected virtual AKACOOECCNI BEKNGGGDLIC
	{
		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC30", Offset = "0x7DDA30", VA = "0x1807DEC30", Slot = "15")]
		get
		{
			return default(AKACOOECCNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C9")]
	[Cpp2IlInjected.Address(Slot = "16")]
	protected abstract void PGFBJGGICAE(AKACOOECCNI KCPGKFKLEJL);

	[Cpp2IlInjected.Token(Token = "0x60008CA")]
	[Cpp2IlInjected.Address(RVA = "0x5E92660", Offset = "0x5E91460", VA = "0x185E92660", Slot = "13")]
	protected sealed override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CB")]
	[Cpp2IlInjected.Address(RVA = "0x5E92710", Offset = "0x5E91510", VA = "0x185E92710")]
	private AKACOOECCNI PCGHMBNENOA()
	{
		return default(AKACOOECCNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60008CC")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	protected NPDCGAHEIOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
public class PODGCFGNDKE : FMBIPPPJNCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	private FHPOCBKLNBE NGLMJAHNOHO;

	[Cpp2IlInjected.Token(Token = "0x60008CE")]
	[Cpp2IlInjected.Address(RVA = "0x5E93270", Offset = "0x5E92070", VA = "0x185E93270", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008CF")]
	[Cpp2IlInjected.Address(RVA = "0x5E93340", Offset = "0x5E92140", VA = "0x185E93340", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D0")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public PODGCFGNDKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
public class HAMNLKOMNAI : FMBIPPPJNCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private FHPOCBKLNBE NGLMJAHNOHO;

	[Cpp2IlInjected.Token(Token = "0x60008D1")]
	[Cpp2IlInjected.Address(RVA = "0x5E88A10", Offset = "0x5E87810", VA = "0x185E88A10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E88AE0", Offset = "0x5E878E0", VA = "0x185E88AE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D3")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public HAMNLKOMNAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
public class MPIDEIPICNC : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000521")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000522")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000523")]
	private KPJDKLLIHBP EILPDJCOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.Token(Token = "0x60008D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E91C10", Offset = "0x5E90A10", VA = "0x185E91C10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E91BA0", Offset = "0x5E909A0", VA = "0x185E91BA0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E91CE0", Offset = "0x5E90AE0", VA = "0x185E91CE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008D7")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public MPIDEIPICNC()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	public class DebugPostLoadValidateNetworkIdSystem : IALGNLMAPEN, IJCLFGAEMDL
	{
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		private struct DebugPostLoadValidateNetworkIdSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000528")]
			public NativeParallelHashMap<DJMPNJEFEHC, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000529")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400052A")]
			[ReadOnly]
			public ComponentTypeHandle<KFNLPBLECCI> __networkComponentTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60008DE")]
			[Cpp2IlInjected.Address(RVA = "0x5E84D00", Offset = "0x5E83B00", VA = "0x185E84D00")]
			private void LFGCENJAPBK(Entity entity, [In] KFNLPBLECCI networkComponent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008DF")]
			[Cpp2IlInjected.Address(RVA = "0x5E84BE0", Offset = "0x5E839E0", VA = "0x185E84BE0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private KOHELDMJMKP networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private EntityQuery DebugPostLoadValidateNetworkIdSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private ComponentTypeHandle<KFNLPBLECCI> __RecRoom_Components_ObjectNetworkIdComponentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x5E84A90", Offset = "0x5E83890", VA = "0x185E84A90", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E84F80", Offset = "0x5E83D80", VA = "0x185E84F80", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E84AF0", Offset = "0x5E838F0", VA = "0x185E84AF0")]
		private void KABECPEAJHL(NativeParallelHashMap<DJMPNJEFEHC, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0x5E84D80", Offset = "0x5E83B80", VA = "0x185E84D80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public DebugPostLoadValidateNetworkIdSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	public class DebugPostLoadValidateParentDataSystem : IALGNLMAPEN, IJCLFGAEMDL
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
			[Cpp2IlInjected.Address(RVA = "0x5E85440", Offset = "0x5E84240", VA = "0x185E85440")]
			private void LFGCENJAPBK(Entity entity, [In] ParentData parentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0x5E85320", Offset = "0x5E84120", VA = "0x185E85320", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private IKBNJJBMJGF objects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private EntityQuery DebugPostLoadValidateParentDataSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private ComponentTypeHandle<ParentData> __RecRoom_Components_ParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E851F0", Offset = "0x5E83FF0", VA = "0x185E851F0", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E85250", Offset = "0x5E84050", VA = "0x185E85250", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0x5E85250", Offset = "0x5E84050", VA = "0x185E85250")]
		private void LPIMDCEOKIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E85610", Offset = "0x5E84410", VA = "0x185E85610", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public DebugPostLoadValidateParentDataSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E85070", Offset = "0x5E83E70", VA = "0x185E85070")]
		[CompilerGenerated]
		private void AFNCICJOLOL(Entity entity, [In] ParentData parentData)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
public class LICKEOEGHPM : IALGNLMAPEN, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	private OPNGBJLAHIJ AIMIPJFKDIC;

	[Cpp2IlInjected.Token(Token = "0x60008E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E90010", Offset = "0x5E8EE10", VA = "0x185E90010", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008E9")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EA")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public LICKEOEGHPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[UpdateBefore(typeof(HJFHCLMCBFG))]
public class HBNHGEAIIAN : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x60008EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E88C30", Offset = "0x5E87A30", VA = "0x185E88C30", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E88CE0", Offset = "0x5E87AE0", VA = "0x185E88CE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008ED")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public HBNHGEAIIAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
public class LBDDEPFPDHG : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[BurstCompile]
	private struct MOLGGPGKGJL : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		[ReadOnly]
		public NativeArray<OIICFNMGKEN> EOICPPODFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		[ReadOnly]
		public NativeArray<Entity> PFOPLIKJCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public ComponentDataFromEntity LFCDBFPOGEM;

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E91A90", Offset = "0x5E90890", VA = "0x185E91A90", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[BurstCompile]
	private struct CELCHEDOIGB : IJob, INativeDisposable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		[ReadOnly]
		public NativeParallelHashMap<int, Entity> ILAJMHNJILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		[ReadOnly]
		public NativeParallelHashMap<int, EntityArchetype> GPAMMDOADDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		[ReadOnly]
		public NativeParallelHashMap<int, int> PCDCCNOPEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> DCDJLNNDLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		[ReadOnly]
		public SharedComponentTypeHandle<RRObjectPrefabV2Data> MDILOFHINGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public NativeList<EntityArchetype> AEALPKIIMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public NativeList<EntityArchetype> KLJIDCLFIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public NativeList<NGLDHKJAKDF> AFIALHBEJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public NativeList<NGLDHKJAKDF> IGFKCPPALLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public NativeList<OIICFNMGKEN> KEJLBJECLFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public NativeList<ComponentType> EHIKNGOOIMM;

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E83810", Offset = "0x5E82610", VA = "0x185E83810", Slot = "6")]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E82F10", Offset = "0x5E81D10", VA = "0x185E82F10", Slot = "5")]
		public JobHandle Dispose(JobHandle KMOBDGPHBOK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E83120", Offset = "0x5E81F20", VA = "0x185E83120", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E82E70", Offset = "0x5E81C70", VA = "0x185E82E70")]
		private int APMJFCIIPMO(NGLDHKJAKDF IDKEHBOKIKI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E83620", Offset = "0x5E82420", VA = "0x185E83620")]
		private bool MNBDFGADLCK(int MBLBMGAAEEI, EntityArchetype LPFCOFENPPF, [Out] EntityArchetype NPNEGPCGBNN, [Out] Entity KCJAAHNFACK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[BurstCompile]
	private struct BHCJNKKJGIL : IComparer<OIICFNMGKEN>
	{
		[Cpp2IlInjected.Token(Token = "0x6000900")]
		[Cpp2IlInjected.Address(RVA = "0x9524C0", Offset = "0x9512C0", VA = "0x1809524C0", Slot = "4")]
		public int Compare(OIICFNMGKEN HOELCINBFKH, OIICFNMGKEN JOHINIOFBIJ)
		{
			return default(int);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200019F")]
	[BurstCompile]
	private struct KBEBMLGCDBK : JBFCEFLGDIE<OIICFNMGKEN, int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000901")]
		[Cpp2IlInjected.Address(RVA = "0xDF33A0", Offset = "0xDF21A0", VA = "0x180DF33A0")]
		public int JJBOMBABIFH([In] OIICFNMGKEN PKELBKGJAFM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000902")]
		[Cpp2IlInjected.Address(RVA = "0xDF33A0", Offset = "0xDF21A0", VA = "0x180DF33A0", Slot = "4")]
		private int EHECJALOABD([In] OIICFNMGKEN GNLEHBFFNFG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	private struct OIICFNMGKEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		public Entity KCJAAHNFACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		public NGLDHKJAKDF PFOPLIKJCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int MHAOMEBFJEI;
	}

	[Cpp2IlInjected.Token(Token = "0x4000534")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000536")]
	private LHACECFODGE LJJOHJIGONP;

	[Cpp2IlInjected.Token(Token = "0x60008EF")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EAB0", Offset = "0x5E8D8B0", VA = "0x185E8EAB0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F0")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F260", Offset = "0x5E8E060", VA = "0x185E8F260", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F1")]
	[Cpp2IlInjected.Address(RVA = "0x5E8F320", Offset = "0x5E8E120", VA = "0x185E8F320", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E870", Offset = "0x5E8D670", VA = "0x185E8E870")]
	private CELCHEDOIGB GNOHFGPKBMF(NativeArray<ArchetypeChunk> DMPBGKOFGFL)
	{
		return default(CELCHEDOIGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EB00", Offset = "0x5E8D900", VA = "0x185E8EB00")]
	private void KNCBDGOBGHF(NativeArray<EntityArchetype> KLJIDCLFIIA, NativeArray<NGLDHKJAKDF> AFIALHBEJAI, NativeArray<NGLDHKJAKDF> IGFKCPPALLP, NativeArray<ComponentType> EHIKNGOOIMM, NativeArray<ArchetypeChunk> DMPBGKOFGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E5D0", Offset = "0x5E8D3D0", VA = "0x185E8E5D0")]
	private EntityArchetype DMDNIPIIFAH(EntityArchetype NFODAFBPFBD, NativeArray<ComponentType> EHIKNGOOIMM, NGLDHKJAKDF OCEFOKCLIAN)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F5")]
	[Cpp2IlInjected.Address(RVA = "0x5E8EC80", Offset = "0x5E8DA80", VA = "0x185E8EC80")]
	private JobHandle ONGLJKBLFAO(NativeList<OIICFNMGKEN> EOICPPODFLD, NativeArray<Entity> PFOPLIKJCHB, JobHandle AHKLOHOGJID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F6")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E400", Offset = "0x5E8D200", VA = "0x185E8E400")]
	private JobHandle CPBGCOHEMKM(NativeArray<Entity> PFOPLIKJCHB, NativeArray<OIICFNMGKEN> EOICPPODFLD, int IDDPEMOGPEO, NGLDHKJAKDF OCEFOKCLIAN, JobHandle AHKLOHOGJID)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E8E3F0", Offset = "0x5E8D1F0", VA = "0x185E8E3F0")]
	public static bool BFBAJGGJDAM(ComponentType ACNKJFPHPMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008F8")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public LBDDEPFPDHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[UpdateBefore(typeof(LBDDEPFPDHG))]
public class HJFHCLMCBFG : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000548")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000549")]
	private OPNGBJLAHIJ AIMIPJFKDIC;

	[Cpp2IlInjected.Token(Token = "0x6000903")]
	[Cpp2IlInjected.Address(RVA = "0x5E89590", Offset = "0x5E88390", VA = "0x185E89590", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000904")]
	[Cpp2IlInjected.Address(RVA = "0x5E895E0", Offset = "0x5E883E0", VA = "0x185E895E0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000905")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public HJFHCLMCBFG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001A2")]
	[CompilerGenerated]
	[NJOEKALHIJD(DAEAEJBLHHK.OMRoom)]
	public class PostLoadInitializeNetworkIdSystem : FMBIPPPJNCE, IJCLFGAEMDL
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
				[Cpp2IlInjected.Address(RVA = "0x5EA05D0", Offset = "0x5E9F3D0", VA = "0x185EA05D0")]
				[BurstDiscard]
				private static void IEGAEKHJOOB(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000920")]
				[Cpp2IlInjected.Address(RVA = "0x5EA03C0", Offset = "0x5E9F1C0", VA = "0x185EA03C0")]
				private static IntPtr CNABIEPBNDL()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000921")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0520", Offset = "0x5E9F320", VA = "0x185EA0520")]
				public static void EICHAODCKAA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000922")]
				[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
				public static void OOCIGOIJKNJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000924")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0700", Offset = "0x5E9F500", VA = "0x185EA0700")]
				public static void LBCPFKCIFOM(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000556")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000557")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public NativeParallelHashMap<DJMPNJEFEHC, Entity> map;

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
			public ComponentTypeHandle<KFNLPBLECCI> __dstValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B190", Offset = "0x5E99F90", VA = "0x185E9B190")]
			private void LFGCENJAPBK(Entity entity, int entityInQueryIndex, [NoAlias] KFNLPBLECCI dstValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600091A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9ADC0", Offset = "0x5E99BC0", VA = "0x185E9ADC0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex, int indexOfFirstEntityInQuery)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600091B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9AF70", Offset = "0x5E99D70", VA = "0x185E9AF70")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void JDKFJNMCLOL(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0x5E9AF00", Offset = "0x5E99D00", VA = "0x185E9AF00")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			public static void IGHOIHMPPNE(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
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
				[Cpp2IlInjected.Address(RVA = "0x5EA0B00", Offset = "0x5E9F900", VA = "0x185EA0B00")]
				[BurstDiscard]
				private static void IEGAEKHJOOB(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092C")]
				[Cpp2IlInjected.Address(RVA = "0x5EA08F0", Offset = "0x5E9F6F0", VA = "0x185EA08F0")]
				private static IntPtr CNABIEPBNDL()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x600092D")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0A50", Offset = "0x5E9F850", VA = "0x185EA0A50")]
				public static void EICHAODCKAA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600092E")]
				[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
				public static void OOCIGOIJKNJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000930")]
				[Cpp2IlInjected.Address(RVA = "0x5EA0C30", Offset = "0x5E9FA30", VA = "0x185EA0C30")]
				public static void LBCPFKCIFOM(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x400055F")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000560")]
			internal static InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public NativeParallelHashMap<DJMPNJEFEHC, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			public ComponentTypeHandle<KFNLPBLECCI> __dstValueTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000925")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B650", Offset = "0x5E9A450", VA = "0x185E9B650")]
			private void LFGCENJAPBK(Entity entity, [NoAlias] KFNLPBLECCI dstValue, [In][NoAlias] OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000926")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B220", Offset = "0x5E9A020", VA = "0x185E9B220", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000927")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B430", Offset = "0x5E9A230", VA = "0x185E9B430")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void JDKFJNMCLOL(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000928")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B3C0", Offset = "0x5E9A1C0", VA = "0x185E9B3C0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobEntityBatchRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void IGHOIHMPPNE(ArchetypeChunkIterator archetypeChunkIterator, IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		private struct PostLoadInitializeNetworkIdSystem_LambdaJob_2_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000567")]
			public NativeParallelHashMap<DJMPNJEFEHC, Entity> map;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000568")]
			[ReadOnly]
			public EntityTypeHandle __entityTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000569")]
			[ReadOnly]
			public ComponentTypeHandle<OverrideObjectNetworkIdData> __srcValueTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000931")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B7E0", Offset = "0x5E9A5E0", VA = "0x185E9B7E0")]
			private void LFGCENJAPBK(Entity entity, [In] OverrideObjectNetworkIdData srcValue)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B6C0", Offset = "0x5E9A4C0", VA = "0x185E9B6C0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		[MBPNJDODNHC]
		private KOHELDMJMKP networkToLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		[MBPNJDODNHC]
		private OPNGBJLAHIJ scenes;

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
		private ComponentTypeHandle<KFNLPBLECCI> __RecRoom_Components_ObjectNetworkIdComponentData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private ComponentTypeHandle<OverrideObjectNetworkIdData> __RecRoom_Components_OverrideObjectNetworkIdData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AAB0", Offset = "0x5E998B0", VA = "0x185E9AAB0", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C780", Offset = "0x5E9B580", VA = "0x185E9C780", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C8C0", Offset = "0x5E9B6C0", VA = "0x185E9C8C0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A8F0", Offset = "0x5E996F0", VA = "0x185E9A8F0")]
		public void GNHIFEGKCIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BA60", Offset = "0x5E9A860", VA = "0x185E9BA60")]
		private void MFKKKJOHNCJ(NativeParallelHashMap<DJMPNJEFEHC, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A580", Offset = "0x5E99380", VA = "0x185E9A580")]
		private void AFEJHIOJPNB(NativeParallelHashMap<DJMPNJEFEHC, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CD40", Offset = "0x5E9BB40", VA = "0x185E9CD40")]
		private void PGNADKPELPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B8F0", Offset = "0x5E9A6F0", VA = "0x185E9B8F0")]
		private void MDGKIDAHHNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CEF0", Offset = "0x5E9BCF0", VA = "0x185E9CEF0")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void PKLLOPBLADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CC60", Offset = "0x5E9BA60", VA = "0x185E9CC60")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void PAGLMFJEIHC(NativeParallelHashMap<DJMPNJEFEHC, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A960", Offset = "0x5E99760", VA = "0x185E9A960")]
		private void ILNFOCBFEHO(NativeParallelHashMap<DJMPNJEFEHC, Entity> map, uint playerId, uint offset)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AC50", Offset = "0x5E99A50", VA = "0x185E9AC50")]
		private void LLOIHCKLAML(NativeParallelHashMap<DJMPNJEFEHC, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AB60", Offset = "0x5E99960", VA = "0x185E9AB60")]
		private void LCIENHJENHI(NativeParallelHashMap<DJMPNJEFEHC, Entity> map)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C030", Offset = "0x5E9AE30", VA = "0x185E9C030", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PostLoadInitializeNetworkIdSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A8B0", Offset = "0x5E996B0", VA = "0x185E9A8B0")]
		public static void GACIIHJJPEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AB20", Offset = "0x5E99920", VA = "0x185E9AB20")]
		public static void JIOMBANEAFC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	public class PostLoadMoveRootsUnderParentSystem : FMBIPPPJNCE
	{
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D140", Offset = "0x5E9BF40", VA = "0x185E9D140", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D220", Offset = "0x5E9C020", VA = "0x185E9D220", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CFA0", Offset = "0x5E9BDA0", VA = "0x185E9CFA0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PostLoadMoveRootsUnderParentSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[NJOEKALHIJD(DAEAEJBLHHK.OMRoom)]
	[CompilerGenerated]
	public class PostLoadRemapCircuitIdsSystem : FMBIPPPJNCE, IJCLFGAEMDL
	{
		[Cpp2IlInjected.Token(Token = "0x20001AC")]
		private struct PostLoadRemapCircuitIdsSystem_LambdaJob_0_Job : IJobEntityBatch
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public BJAAPCICCEH remap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			public ComponentTypeHandle<KJJOIOAKAKH> __nodeTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x600093E")]
			[Cpp2IlInjected.Address(RVA = "0x5E9D840", Offset = "0x5E9C640", VA = "0x185E9D840")]
			private void LFGCENJAPBK(KJJOIOAKAKH node)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600093F")]
			[Cpp2IlInjected.Address(RVA = "0x5E9D770", Offset = "0x5E9C570", VA = "0x185E9D770", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		[MBPNJDODNHC]
		private DEHDJDPODCF serialization;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private EntityQuery PostLoadRemapCircuitIdsSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private ComponentTypeHandle<KJJOIOAKAKH> __RecRoom_Components_ObjectBoardNodeData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D720", Offset = "0x5E9C520", VA = "0x185E9D720", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DD30", Offset = "0x5E9CB30", VA = "0x185E9DD30", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D640", Offset = "0x5E9C440", VA = "0x185E9D640")]
		private void CMAEGAHLOIK(BJAAPCICCEH remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DA50", Offset = "0x5E9C850", VA = "0x185E9DA50")]
		private void OMJPHHIOHCO(BJAAPCICCEH remap)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DB30", Offset = "0x5E9C930", VA = "0x185E9DB30", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PostLoadRemapCircuitIdsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001AD")]
public class LBMMCKGHKEE : FMBIPPPJNCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x6000940")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FA10", Offset = "0x5E8E810", VA = "0x185E8FA10", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000941")]
	[Cpp2IlInjected.Address(RVA = "0x5E8FAA0", Offset = "0x5E8E8A0", VA = "0x185E8FAA0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000942")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public LBMMCKGHKEE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	public class PreSerializeDowngrade_RRObjectPrefabTypeData : FMBIPPPJNCE
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
			public CNNDJLCOJEC.CDLOGHFHACM<ArchetypeChunk, EEAALDGHAOB<RRObjectPrefabV2Data>> it;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400057B")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400057C")]
			public NativeList<PDKKPKEINKD> prefabTypeData;

			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E0A0", Offset = "0x5E9CEA0", VA = "0x185E9E0A0")]
			private void LFGCENJAPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9E090", Offset = "0x5E9CE90", VA = "0x185E9E090", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private EntityQuery queryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E500", Offset = "0x5E9D300", VA = "0x185E9E500", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E5A0", Offset = "0x5E9D3A0", VA = "0x185E9E5A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E040", Offset = "0x5E9CE40", VA = "0x185E9E040")]
		private EntityCommandBufferSystem FIIENAOFPBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DE90", Offset = "0x5E9CC90", VA = "0x185E9DE90")]
		private JobHandle CMEIGLEIMHP(SharedComponentTypeHandle<RRObjectPrefabV2Data> prefabTypeHandleRO, EntityTypeHandle entityTypeHandleRO, NativeArray<ArchetypeChunk> chunksRO, NativeParallelHashMap<int, int> prefabTypeFromIndexRO, CNNDJLCOJEC.CDLOGHFHACM<ArchetypeChunk, EEAALDGHAOB<RRObjectPrefabV2Data>> it, NativeList<Entity> entities, NativeList<PDKKPKEINKD> prefabTypeData, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E360", Offset = "0x5E9D160", VA = "0x185E9E360", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PreSerializeDowngrade_RRObjectPrefabTypeData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B0")]
public class AOBFBFMGIIG : FMBIPPPJNCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057D")]
	private EntityQuery LILOGMIAINN;

	[Cpp2IlInjected.Token(Token = "0x600094C")]
	[Cpp2IlInjected.Address(RVA = "0x5E822C0", Offset = "0x5E810C0", VA = "0x185E822C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094D")]
	[Cpp2IlInjected.Address(RVA = "0x5E82350", Offset = "0x5E81150", VA = "0x185E82350", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600094E")]
	[Cpp2IlInjected.Address(RVA = "0x5E82270", Offset = "0x5E81070", VA = "0x185E82270")]
	private EntityCommandBufferSystem NGFOFBPAJHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600094F")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public AOBFBFMGIIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
[AlwaysUpdateSystem]
public class NAGLIFAIECC : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x6000950")]
	[Cpp2IlInjected.Address(RVA = "0x5E91F20", Offset = "0x5E90D20", VA = "0x185E91F20", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000951")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public NAGLIFAIECC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class PPEHNPMLIJJ : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x400057E")]
	private static GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400057F")]
	private EntityQuery LCAKLMHECIN;

	[Cpp2IlInjected.Token(Token = "0x6000952")]
	[Cpp2IlInjected.Address(RVA = "0x5E93490", Offset = "0x5E92290", VA = "0x185E93490", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000953")]
	[Cpp2IlInjected.Address(RVA = "0x5E93710", Offset = "0x5E92510", VA = "0x185E93710", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000954")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public PPEHNPMLIJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public class PKDDHNFLBGE : GAFMEHPPBBK
{
	[Cpp2IlInjected.Token(Token = "0x6000956")]
	[Cpp2IlInjected.Address(RVA = "0x5E93220", Offset = "0x5E92020", VA = "0x185E93220", Slot = "14")]
	protected override EntityCommandBufferSystem FIIENAOFPBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000957")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public PKDDHNFLBGE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	[CompilerGenerated]
	public class PreSerializeSaveNetworkIdsSystem : FMBIPPPJNCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private EntityQuery query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F210", Offset = "0x5E9E010", VA = "0x185E9F210", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F2A0", Offset = "0x5E9E0A0", VA = "0x185E9F2A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F020", Offset = "0x5E9DE20", VA = "0x185E9F020")]
		private EntityCommandBufferSystem NGFOFBPAJHF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F070", Offset = "0x5E9DE70", VA = "0x185E9F070", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PreSerializeSaveNetworkIdsSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	[CompilerGenerated]
	public class PreSerializeTransformRootsSystem : FMBIPPPJNCE
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
			public ComponentTypeHandle<HDEJALOFGAC> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0x5E81DA0", Offset = "0x5E80BA0", VA = "0x185E81DA0")]
			private void LFGCENJAPBK([NoAlias] HDEJALOFGAC data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0x5E9F850", Offset = "0x5E9E650", VA = "0x185E9F850", Slot = "4")]
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
			public ComponentTypeHandle<PEDPLCBIGKO> __dataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0x5E809C0", Offset = "0x5E7F7C0", VA = "0x185E809C0")]
			private void LFGCENJAPBK([NoAlias] PEDPLCBIGKO data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0x5E9F920", Offset = "0x5E9E720", VA = "0x185E9F920", Slot = "4")]
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
		private ComponentTypeHandle<HDEJALOFGAC> __RecRoom_Components_LocalPoseData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private ComponentTypeHandle<PEDPLCBIGKO> __RecRoom_Components_LocalUniformScaleData_RW_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA00E0", Offset = "0x5E9EEE0", VA = "0x185EA00E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F9F0", Offset = "0x5E9E7F0", VA = "0x185E9F9F0")]
		private void MJGHIEAMPBC([In] GNMGEBAMPGE transform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F620", Offset = "0x5E9E420", VA = "0x185E9F620")]
		private JobHandle DICKNOJLOIJ(RigidTransform pose, float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F750", Offset = "0x5E9E550", VA = "0x185E9F750")]
		private JobHandle IPAFEDPJOLI(float scale, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FC10", Offset = "0x5E9EA10", VA = "0x185E9FC10", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public PreSerializeTransformRootsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B8")]
[AlwaysUpdateSystem]
public class HDNNKLLNODG : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x400058C")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x6000967")]
	[Cpp2IlInjected.Address(RVA = "0x5E88E00", Offset = "0x5E87C00", VA = "0x185E88E00", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000968")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public HDNNKLLNODG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public static class MOBAPGKDONO
{
	[Cpp2IlInjected.Token(Token = "0x20001BA")]
	[BurstCompile]
	private struct IKDICJPAECG : IJob, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		[ReadOnly]
		public NativeParallelHashSet<int> JOCMNEBPEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		[ReadOnly]
		public NativeArray<ArchetypeChunk> DCDJLNNDLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		public NativeList<EntityArchetype> MLOIHHALAEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public NativeList<NGLDHKJAKDF> AFIALHBEJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public NativeList<NGLDHKJAKDF> IGFKCPPALLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public NativeList<ComponentType> FLEFLKGKAEG;

		[Cpp2IlInjected.Token(Token = "0x6000973")]
		[Cpp2IlInjected.Address(RVA = "0x5E898B0", Offset = "0x5E886B0", VA = "0x185E898B0", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000974")]
		[Cpp2IlInjected.Address(RVA = "0x5E89820", Offset = "0x5E88620", VA = "0x185E89820", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600096A")]
	[Cpp2IlInjected.Address(RVA = "0x5E902E0", Offset = "0x5E8F0E0", VA = "0x185E902E0")]
	public static NativeParallelHashSet<int> CHNNELBPFDO(Allocator JFLEKJGGDHL)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600096B")]
	[Cpp2IlInjected.Address(RVA = "0x5E90AF0", Offset = "0x5E8F8F0", VA = "0x185E90AF0")]
	public static NativeParallelHashSet<int> HCIGNIPHEOL(Allocator JFLEKJGGDHL)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600096C")]
	[Cpp2IlInjected.Address(RVA = "0x5E90780", Offset = "0x5E8F580", VA = "0x185E90780")]
	private static void GMDDPBBNNBM(NativeParallelHashSet<int> IAJACANMJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096D")]
	[Cpp2IlInjected.Address(RVA = "0x5E919B0", Offset = "0x5E907B0", VA = "0x185E919B0")]
	private static bool OJDMMFMJGJC(Type PEMNIEMPPLO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600096E")]
	[Cpp2IlInjected.Address(RVA = "0x5E90540", Offset = "0x5E8F340", VA = "0x185E90540")]
	private static void EHFJFCHHOOF(NativeParallelHashSet<int> IAJACANMJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600096F")]
	[Cpp2IlInjected.Address(RVA = "0x5E90C30", Offset = "0x5E8FA30", VA = "0x185E90C30")]
	private static void JKKKKKHKFCG(NativeParallelHashSet<int> IAJACANMJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000970")]
	[Cpp2IlInjected.Address(RVA = "0x5E91770", Offset = "0x5E90570", VA = "0x185E91770")]
	private static void NLLMCNBLIBL(NativeParallelHashSet<int> IAJACANMJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000971")]
	[Cpp2IlInjected.Address(RVA = "0x5E90E70", Offset = "0x5E8FC70", VA = "0x185E90E70")]
	public static void MJLMHLILADH(EntityManager FMCNCDMBJDH, EntityQuery LKMIGFDOIIA, NativeParallelHashSet<int> DHCANGLNDPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000972")]
	[Cpp2IlInjected.Address(RVA = "0x5E903A0", Offset = "0x5E8F1A0", VA = "0x185E903A0")]
	public static void DMBIBMPADAL(EntityManager FMCNCDMBJDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public static class DGFICBJKJHN
{
	[Cpp2IlInjected.Token(Token = "0x6000975")]
	[Cpp2IlInjected.Address(RVA = "0x5E83BA0", Offset = "0x5E829A0", VA = "0x185E83BA0")]
	public static NativeParallelHashSet<int> KJMCDJANFND(EntityManager FMCNCDMBJDH, Allocator JFLEKJGGDHL)
	{
		return default(NativeParallelHashSet<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000976")]
	[Cpp2IlInjected.Address(RVA = "0x5E83F00", Offset = "0x5E82D00", VA = "0x185E83F00")]
	public static NativeParallelHashMap<int, int> NCLMAMGIPDC(EntityManager FMCNCDMBJDH, Allocator JFLEKJGGDHL)
	{
		return default(NativeParallelHashMap<int, int>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BC")]
public abstract class GAFMEHPPBBK : FMBIPPPJNCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000593")]
	private EntityQuery LKMIGFDOIIA;

	[Cpp2IlInjected.Token(Token = "0x6000977")]
	[Cpp2IlInjected.Address(Slot = "14")]
	protected abstract EntityCommandBufferSystem FIIENAOFPBL();

	[Cpp2IlInjected.Token(Token = "0x6000978")]
	[Cpp2IlInjected.Address(RVA = "0x5E86D50", Offset = "0x5E85B50", VA = "0x185E86D50", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000979")]
	[Cpp2IlInjected.Address(RVA = "0x5E86DE0", Offset = "0x5E85BE0", VA = "0x185E86DE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	protected GAFMEHPPBBK()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20001BD")]
public struct LMCGBNPCLHM : EJCPJGFADGE<ParentData>
{
	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0x5E90070", Offset = "0x5E8EE70", VA = "0x185E90070", Slot = "4")]
	public bool HJEGGAICAPE(ParentData GNLEHBFFNFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
[BurstCompile]
public struct EEAALDGHAOB<T> : IEqualityComparer<ArchetypeChunk> where T : struct, ISharedComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000594")]
	[ReadOnly]
	public SharedComponentTypeHandle<T> MDILOFHINGK;

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public EEAALDGHAOB(SharedComponentTypeHandle<T> MDILOFHINGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0x3023110", Offset = "0x3021F10", VA = "0x183023110", Slot = "4")]
	public bool Equals(ArchetypeChunk HOELCINBFKH, ArchetypeChunk JOHINIOFBIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0x3023210", Offset = "0x3022010", VA = "0x183023210", Slot = "5")]
	public int GetHashCode(ArchetypeChunk NEFPDCFOPMI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public struct NGLEJMHDBBB<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000595")]
	private HJCCEALEOGO<T> KCPGKFKLEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000596")]
	private EntityCommandBuffer GFFHLFCGKFL;

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0x3BD18F0", Offset = "0x3BD06F0", VA = "0x183BD18F0")]
	public NGLEJMHDBBB(HJCCEALEOGO<T> KCPGKFKLEJL, EntityCommandBuffer GFFHLFCGKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0x3BD1220", Offset = "0x3BD0020", VA = "0x183BD1220", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0x35BC300", Offset = "0x35BB100", VA = "0x1835BC300")]
	public static HJCCEALEOGO<T> FMKGPFEKDFI(NGLEJMHDBBB<T> PMHKKHBJKIH)
	{
		return default(HJCCEALEOGO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public struct EPFBIHFMNAJ<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000597")]
	private EGIONDKHNPN<T> KCPGKFKLEJL;

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0x3084E50", Offset = "0x3083C50", VA = "0x183084E50")]
	public EPFBIHFMNAJ(EGIONDKHNPN<T> KCPGKFKLEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0x3084D60", Offset = "0x3083B60", VA = "0x183084D60")]
	public NGLEJMHDBBB<T> FGKNEJBNAKB()
	{
		return default(NGLEJMHDBBB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
public struct BOKLHAJOLDD<T> : IDisposable where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000598")]
	private HJCCEALEOGO<T> KCPGKFKLEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000599")]
	private EntityCommandBuffer GFFHLFCGKFL;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public HJCCEALEOGO<T> NEBGPCGIKLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000984")]
		[Cpp2IlInjected.Address(RVA = "0x35BC300", Offset = "0x35BB100", VA = "0x1835BC300")]
		get
		{
			return default(HJCCEALEOGO<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0x3BD18F0", Offset = "0x3BD06F0", VA = "0x183BD18F0")]
	public BOKLHAJOLDD(HJCCEALEOGO<T> KCPGKFKLEJL, EntityCommandBuffer GFFHLFCGKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0x444CA90", Offset = "0x444B890", VA = "0x18444CA90")]
	public void GFMIILMIKLO(EGIONDKHNPN<T> CMKAJHNKAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0x444BAB0", Offset = "0x444A8B0", VA = "0x18444BAB0", Slot = "4")]
	public void Dispose()
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0x35BC300", Offset = "0x35BB100", VA = "0x1835BC300")]
	public static HJCCEALEOGO<T> FMKGPFEKDFI(BOKLHAJOLDD<T> PMHKKHBJKIH)
	{
		return default(HJCCEALEOGO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
public struct GNDAPMOFICG<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059A")]
	private EGIONDKHNPN<T> KCPGKFKLEJL;

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x3084E50", Offset = "0x3083C50", VA = "0x183084E50")]
	public GNDAPMOFICG(EGIONDKHNPN<T> KCPGKFKLEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098A")]
	[Cpp2IlInjected.Address(RVA = "0x34D6E80", Offset = "0x34D5C80", VA = "0x1834D6E80")]
	public BOKLHAJOLDD<T> FCNAJBMNNMK()
	{
		return default(BOKLHAJOLDD<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C3")]
[DefaultMember("Item")]
public struct HJCCEALEOGO<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059B")]
	public NativeList<Entity> PFOPLIKJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059C")]
	public NativeList<T> PFDMLBFKIAP;

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public int DCLHHJJDFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x3595F50", Offset = "0x3594D50", VA = "0x183595F50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public (Entity entity, T value) BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0x35956C0", Offset = "0x35944C0", VA = "0x1835956C0")]
		get
		{
			return default((Entity, T));
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600098D")]
	[Cpp2IlInjected.Address(RVA = "0x3594D90", Offset = "0x3593B90", VA = "0x183594D90")]
	public void AAFNAGDLNDC(Entity CCHOHIEEHEH, T GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600098E")]
	[Cpp2IlInjected.Address(RVA = "0x3596110", Offset = "0x3594F10", VA = "0x183596110")]
	public void NLKAJOFEENO(NativeArray<Entity> CCHOHIEEHEH, NativeArray<T> GNLEHBFFNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C4")]
public struct EGIONDKHNPN<T> where T : struct, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059D")]
	[ReadOnly]
	public EntityQueryInJob LKMIGFDOIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059E")]
	[ReadOnly]
	public EntityTypeHandle DJHLBMJLNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400059F")]
	[ReadOnly]
	public ComponentTypeHandle<T> IDNGANPKCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A0")]
	[WriteOnly]
	public EntityCommandBuffer GFFHLFCGKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005A1")]
	public AllocatorManager.AllocatorHandle JFLEKJGGDHL;

	[Cpp2IlInjected.Token(Token = "0x600098F")]
	[Cpp2IlInjected.Address(RVA = "0x303EF70", Offset = "0x303DD70", VA = "0x18303EF70")]
	public HJCCEALEOGO<T> FGKNEJBNAKB()
	{
		return default(HJCCEALEOGO<T>);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001C5")]
	[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
	[CompilerGenerated]
	internal class SplinePointOrderingUpdateSystem : FMBIPPPJNCE, IJCLFGAEMDL
	{
		[Cpp2IlInjected.Token(Token = "0x20001C6")]
		[BurstCompile]
		private struct UpdateSplineIndexJob : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A5")]
			[ReadOnly]
			public NativeArray<global::KEBJOMPDFBL> indexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			[ReadOnly]
			public ComponentDataFromEntity<OKOJMLFLNIA> splinePointParentDataRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			public ComponentDataFromEntity<DJJFFCHIFLN> splinePointOrderDataRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005A8")]
			public BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW;

			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x5EA2CC0", Offset = "0x5EA1AC0", VA = "0x185EA2CC0", Slot = "4")]
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
			public ComponentDataFromEntity<DJJFFCHIFLN> orderRO;

			[Cpp2IlInjected.Token(Token = "0x6000999")]
			[Cpp2IlInjected.Address(RVA = "0x5E92E60", Offset = "0x5E91C60", VA = "0x185E92E60", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x5EA1700", Offset = "0x5EA0500", VA = "0x185EA1700")]
			private void LFGCENJAPBK(Entity spline, DynamicBuffer<LinkedEntityGroup> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600099B")]
			[Cpp2IlInjected.Address(RVA = "0x5EA15D0", Offset = "0x5EA03D0", VA = "0x185EA15D0", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private EntityQuery needsUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		[MBPNJDODNHC]
		private LGMAMHNDHAH singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private EntityQuery SplinePointOrderingUpdateSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0x5EA11F0", Offset = "0x5E9FFF0", VA = "0x185EA11F0", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0x5EA19A0", Offset = "0x5EA07A0", VA = "0x185EA19A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1240", Offset = "0x5EA0040", VA = "0x185EA1240")]
		private void LFPKJHNMAHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000993")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0F50", Offset = "0x5E9FD50", VA = "0x185EA0F50")]
		private void GLOJOHLIHGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000994")]
		[Cpp2IlInjected.Address(RVA = "0x5EA10B0", Offset = "0x5E9FEB0", VA = "0x185EA10B0")]
		private static OODAAJNAONI IGFKHAAFPON(int insertionIndex, ComponentDataFromEntity<DJJFFCHIFLN> splinePointOrderDataRO, NativeArray<Entity> children)
		{
			return default(OODAAJNAONI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000995")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0E20", Offset = "0x5E9FC20", VA = "0x185EA0E20")]
		private JobHandle FJDHOPLOMDN(OrderComparer comparer, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000996")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1790", Offset = "0x5EA0590", VA = "0x185EA1790", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public SplinePointOrderingUpdateSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[CompilerGenerated]
	[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
	internal class SplinePointParentChangedSystem : FMBIPPPJNCE, IJCLFGAEMDL
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
			public DynamicBuffer<global::KEBJOMPDFBL> splineIndexUpdatesRO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			[ReadOnly]
			public EntityTypeHandle __splinePointTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			[ReadOnly]
			public ComponentTypeHandle<OKOJMLFLNIA> __splinePointParentDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009A6")]
			[Cpp2IlInjected.Address(RVA = "0x5EC3A90", Offset = "0x5EC2890", VA = "0x185EC3A90")]
			private void LFGCENJAPBK(Entity splinePoint, [In][NoAlias] OKOJMLFLNIA splinePointParentData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A7")]
			[Cpp2IlInjected.Address(RVA = "0x5EC3970", Offset = "0x5EC2770", VA = "0x185EC3970", Slot = "4")]
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
			public ComponentTypeHandle<global::NEHHHLOLDGB> __splinePointParentSystemDataTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009A8")]
			[Cpp2IlInjected.Address(RVA = "0x5EC3D00", Offset = "0x5EC2B00", VA = "0x185EC3D00")]
			private void LFGCENJAPBK(Entity splinePoint, [In][NoAlias] global::NEHHHLOLDGB splinePointParentSystemData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009A9")]
			[Cpp2IlInjected.Address(RVA = "0x5EC3BE0", Offset = "0x5EC29E0", VA = "0x185EC3BE0", Slot = "4")]
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
		[MBPNJDODNHC]
		private LGMAMHNDHAH singletonService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_0_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		private EntityQuery SplinePointParentChangedSystem_LambdaJob_1_Query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private ComponentTypeHandle<OKOJMLFLNIA> __RecRoom_Components_SplinePointParentData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private ComponentTypeHandle<global::NEHHHLOLDGB> __RecRoom_Components_SplinePointParentSystemData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1F50", Offset = "0x5EA0D50", VA = "0x185EA1F50", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2590", Offset = "0x5EA1390", VA = "0x185EA2590", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2580", Offset = "0x5EA1380", VA = "0x185EA2580", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1FA0", Offset = "0x5EA0DA0", VA = "0x185EA1FA0")]
		private void ONMCLAEEMNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1C50", Offset = "0x5EA0A50", VA = "0x185EA1C50")]
		private void EKNEPFBPIFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1F00", Offset = "0x5EA0D00", VA = "0x185EA1F00")]
		private EntityCommandBufferSystem FIIENAOFPBL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1B00", Offset = "0x5EA0900", VA = "0x185EA1B00")]
		private JobHandle EDINJLDENCA(EntityCommandBuffer ecb, DynamicBuffer<global::KEBJOMPDFBL> splineIndexUpdatesRO, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x5EA27D0", Offset = "0x5EA15D0", VA = "0x185EA27D0")]
		private JobHandle POCAFBKMBCM(BufferFromEntity<LinkedEntityGroup> linkedEntityGroupRW, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x5EA21E0", Offset = "0x5EA0FE0", VA = "0x185EA21E0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A5")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public SplinePointParentChangedSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CC")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal sealed class ENEIHBMOBDF : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8F40", Offset = "0x5EA7D40", VA = "0x185EA8F40", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public ENEIHBMOBDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal sealed class AJKKNINFPFB : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3BB0", Offset = "0x5EA29B0", VA = "0x185EA3BB0", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public AJKKNINFPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal sealed class FNPHJMEODCG : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0x5EABB30", Offset = "0x5EAA930", VA = "0x185EABB30", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public FNPHJMEODCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CF")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal sealed class KKJJNBEBHBA : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB69E0", Offset = "0x5EB57E0", VA = "0x185EB69E0", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public KKJJNBEBHBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D0")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal sealed class HAHJJMJMBOL : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x60009B2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2E70", Offset = "0x5EB1C70", VA = "0x185EB2E70", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public HAHJJMJMBOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal sealed class NONDGPAJBJA : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x5EBF840", Offset = "0x5EBE640", VA = "0x185EBF840", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public NONDGPAJBJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
[ExecuteAlways]
public class FBFDNMIKAOM : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770F00", VA = "0x180772100")]
	public FBFDNMIKAOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal sealed class NDPKNLILGBC : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE860", Offset = "0x5EBD660", VA = "0x185EBE860", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public NDPKNLILGBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D4")]
internal class NGEBOEEAOGB : NBIHFNKMCJC
{
	[Cpp2IlInjected.Token(Token = "0x60009B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public NGEBOEEAOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D5")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal sealed class AOFLGCMDACJ : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x60009BA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3DB0", Offset = "0x5EA2BB0", VA = "0x185EA3DB0", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public AOFLGCMDACJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D6")]
internal class LJDPAJMALJP : NBIHFNKMCJC
{
	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public LJDPAJMALJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D7")]
internal class EGIDOMBMKFO : NBIHFNKMCJC
{
	[Cpp2IlInjected.Token(Token = "0x60009BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public EGIDOMBMKFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D8")]
public sealed class NDDGIALHLLA : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x60009BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EBE450", Offset = "0x5EBD250", VA = "0x185EBE450", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public NDDGIALHLLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D9")]
[ExecuteAlways]
public class FHPOCBKLNBE : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x60009C0")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770F00", VA = "0x180772100")]
	public FHPOCBKLNBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DA")]
public class JMPOPHDPGFO : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x60009C1")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C2")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public JMPOPHDPGFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DB")]
[ICOGLANPNEA]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
public class HKFIIHLCDHM : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005BB")]
	private BOGMJJODDAE NCGAGJLPMMN;

	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3C90", Offset = "0x5EB2A90", VA = "0x185EB3C90", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3CE0", Offset = "0x5EB2AE0", VA = "0x185EB3CE0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public HKFIIHLCDHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001DC")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
public class HIMKJMHHCCO : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x20001DD")]
	[BurstCompile]
	private struct AHMHGOGNJLJ : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		[ReadOnly]
		public NativeArray<Entity> PFOPLIKJCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<HDEJALOFGAC> IFFPEEKCNAO;

		[Cpp2IlInjected.Token(Token = "0x60009CB")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3940", Offset = "0x5EA2740", VA = "0x185EA3940", Slot = "4")]
		public void Execute(int DOJILIOCHKM, TransformAccess GNLAIPIBJPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3B10", Offset = "0x5EA2910", VA = "0x185EA3B10")]
		private bool HKHGIBEGPLK(float3 INJCFLAHPML, float3 BOAPNJKEFEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3B40", Offset = "0x5EA2940", VA = "0x185EA3B40")]
		private bool NJGJAMGMCBE(quaternion INJCFLAHPML, quaternion BOAPNJKEFEG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001DE")]
	[BurstCompile]
	private struct BLKHEFNBNNK : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		[ReadOnly]
		public NativeArray<Entity> PFOPLIKJCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<PEDPLCBIGKO> GFALGFBDJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		[NativeDisableParallelForRestriction]
		public ComponentDataFromEntity<GLDJHBJAKIA> GNEFNJALMBL;

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5C10", Offset = "0x5EA4A10", VA = "0x185EA5C10", Slot = "4")]
		public void Execute(int DOJILIOCHKM, TransformAccess GNLAIPIBJPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005BC")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private static readonly GKFGDEJLFAD PEKFNAOKKPD;

	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private static readonly GKFGDEJLFAD MDFPCLOJOKO;

	[Cpp2IlInjected.Token(Token = "0x40005BF")]
	private static readonly GKFGDEJLFAD LADNJGGKHCD;

	[Cpp2IlInjected.Token(Token = "0x40005C0")]
	private static readonly ProfilerMarker FJBCCNPPOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005C1")]
	private ANNHLNEFMPH NFIJIELDCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005C2")]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EB36C0", Offset = "0x5EB24C0", VA = "0x185EB36C0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3730", Offset = "0x5EB2530", VA = "0x185EB3730", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3770", Offset = "0x5EB2570", VA = "0x185EB3770", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public HIMKJMHHCCO()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001DF")]
	[CompilerGenerated]
	[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
	public class RegisterTransformsSystem : FMBIPPPJNCE, IJCLFGAEMDL
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
			public ComponentTypeHandle<FPKGPMINNAO> __arrayIndexTypeHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005D3")]
			public ComponentTypeHandle<Transform> __transformTypeHandle;

			[Cpp2IlInjected.Token(Token = "0x60009DD")]
			[Cpp2IlInjected.Address(RVA = "0x5EC2860", Offset = "0x5EC1660", VA = "0x185EC2860")]
			private void OriginalLambdaBody(Entity entity, [In] FPKGPMINNAO arrayIndex, Transform transform)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009DE")]
			[Cpp2IlInjected.Address(RVA = "0x5EC2670", Offset = "0x5EC1470", VA = "0x185EC2670", Slot = "4")]
			public void Execute(ArchetypeChunk chunk, int batchIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		private static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		private ANNHLNEFMPH embodiedTransforms;

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
		private ComponentTypeHandle<FPKGPMINNAO> __RecRoom_Components_TransformAccessArrayIndexData_RO_ComponentTypeHandle;

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2620", Offset = "0x5EC1420", VA = "0x185EC2620", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D0")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2B70", Offset = "0x5EC1970", VA = "0x185EC2B70", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D1")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2E40", Offset = "0x5EC1C40", VA = "0x185EC2E40", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2230", Offset = "0x5EC1030", VA = "0x185EC2230")]
		private void AddTransforms(EntityQuery query, GHKCPNCBNDO accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D3")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3150", Offset = "0x5EC1F50", VA = "0x185EC3150")]
		private void RemoveTransforms(EntityQuery query, GHKCPNCBNDO accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D4")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2DB0", Offset = "0x5EC1BB0", VA = "0x185EC2DB0", Slot = "7")]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D5")]
		[Cpp2IlInjected.Address(RVA = "0x5EC20D0", Offset = "0x5EC0ED0", VA = "0x185EC20D0")]
		private void AddNewTransforms(NativeArray<Entity> entities, GHKCPNCBNDO accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D6")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2F30", Offset = "0x5EC1D30", VA = "0x185EC2F30")]
		internal static void RemoveOldTransforms(NativeArray<FPKGPMINNAO> arrayIndices, ComponentDataFromEntity<FPKGPMINNAO> transformAccess, GHKCPNCBNDO accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D7")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
		private static void DebugLogRemove(int index, GHKCPNCBNDO accessList)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D8")]
		[Cpp2IlInjected.Address(RVA = "0x5EC24D0", Offset = "0x5EC12D0", VA = "0x185EC24D0")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void DebugLogUninitializedTransformAccessArrayIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x5EC24D0", Offset = "0x5EC12D0", VA = "0x185EC24D0")]
		private void RegisterTransformsSystem_LambdaJob_0_Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DA")]
		[Cpp2IlInjected.Address(RVA = "0x5EC2970", Offset = "0x5EC1770", VA = "0x185EC2970", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009DB")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public RegisterTransformsSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E2")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
public class FGMJNLHJPFM : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x20001E3")]
	[BurstCompile]
	private struct IFNGLEHKFIA : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		[ReadOnly]
		public ComponentDataFromEntity<HDEJALOFGAC> IFFPEEKCNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		[ReadOnly]
		public NativeArray<Entity> PFOPLIKJCHB;

		[Cpp2IlInjected.Token(Token = "0x60009E9")]
		[Cpp2IlInjected.Address(RVA = "0x5EB5830", Offset = "0x5EB4630", VA = "0x185EB5830", Slot = "4")]
		public void Execute(int DOJILIOCHKM, TransformAccess GNLAIPIBJPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001E4")]
	[BurstCompile]
	private struct CFDLGMOPJHE : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		[ReadOnly]
		public ComponentDataFromEntity<PEDPLCBIGKO> GFALGFBDJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		[ReadOnly]
		public NativeArray<Entity> PFOPLIKJCHB;

		[Cpp2IlInjected.Token(Token = "0x60009EA")]
		[Cpp2IlInjected.Address(RVA = "0x5EA63B0", Offset = "0x5EA51B0", VA = "0x185EA63B0", Slot = "4")]
		public void Execute(int DOJILIOCHKM, TransformAccess GNLAIPIBJPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001E5")]
	[BurstCompile]
	private struct AGDFELGGFLD : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		[ReadOnly]
		public ComponentDataFromEntity<PEDPLCBIGKO> GFALGFBDJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		[ReadOnly]
		public ComponentDataFromEntity<GLDJHBJAKIA> GNEFNJALMBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		[ReadOnly]
		public NativeArray<Entity> PFOPLIKJCHB;

		[Cpp2IlInjected.Token(Token = "0x60009EB")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3840", Offset = "0x5EA2640", VA = "0x185EA3840", Slot = "4")]
		public void Execute(int DOJILIOCHKM, TransformAccess GNLAIPIBJPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005D5")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x40005D6")]
	private static readonly GKFGDEJLFAD PEKFNAOKKPD;

	[Cpp2IlInjected.Token(Token = "0x40005D7")]
	private static readonly GKFGDEJLFAD MDFPCLOJOKO;

	[Cpp2IlInjected.Token(Token = "0x40005D8")]
	private static readonly GKFGDEJLFAD LADNJGGKHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005D9")]
	private ANNHLNEFMPH NFIJIELDCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005DA")]
	private EntityQuery HFFBELKMMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40005DB")]
	private EntityQuery EDNJFENCBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40005DC")]
	private EntityQuery ABKABGILDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40005DD")]
	private TransformAccessArray IDLCPMOHMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40005DE")]
	private TransformAccessArray MPFFMENLFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40005DF")]
	private TransformAccessArray AIKICOOJMCP;

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAFA0", Offset = "0x5EA9DA0", VA = "0x185EAAFA0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E2")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAFF0", Offset = "0x5EA9DF0", VA = "0x185EAAFF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E3")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB200", Offset = "0x5EAA000", VA = "0x185EAB200", Slot = "6")]
	protected override void OnStartRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB290", Offset = "0x5EAA090", VA = "0x185EAB290", Slot = "7")]
	protected override void OnStopRunning()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E5")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB2C0", Offset = "0x5EAA0C0", VA = "0x185EAB2C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E6")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAE20", Offset = "0x5EA9C20", VA = "0x185EAAE20")]
	private NativeArray<Entity> ADMNMNHCLGA(NativeArray<FPKGPMINNAO> NFOFHIAHFEO, NativeList<Entity> FNKMIOLKILH, TransformAccessArray POLOLMFMHAE, TransformAccessArray FBAADIHJAFO)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public FGMJNLHJPFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E6")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
public class JLLBIMLHODE : FMBIPPPJNCE, FKNGAHGHIJP
{
	[Cpp2IlInjected.Token(Token = "0x40005E7")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E8")]
	private KBGIFACAFJI GDPHBAAKIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40005E9")]
	private HBFNKHCAGGC MKEMCEBLCJD;

	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E84200", Offset = "0x5E83000", VA = "0x185E84200", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6090", Offset = "0x5EB4E90", VA = "0x185EB6090", Slot = "14")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6190", Offset = "0x5EB4F90", VA = "0x185EB6190", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5F20", Offset = "0x5EB4D20", VA = "0x185EB5F20")]
	private static void COKPANKGLCC(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, Entity LBLLNFOEKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5E80", Offset = "0x5EB4C80", VA = "0x185EB5E80")]
	private static bool AMDJHMKKENI(EntityManager FMCNCDMBJDH, Entity CCHOHIEEHEH, [Out] Transform GNLAIPIBJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public JLLBIMLHODE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E7")]
public class FBFAKAFALPH : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x20001E8")]
	[BurstCompile]
	private struct GDBPLHJKGHO : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		[ReadOnly]
		public ComponentTypeHandle<IMBFFICPOKD> PMODCOEDJIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		[ReadOnly]
		public BufferTypeHandle<ChildrenData> ENBMPJKJGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		[ReadOnly]
		public BufferFromEntity<ChildrenData> HMPKEEFNECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		[ReadOnly]
		public ComponentDataFromEntity<IMBFFICPOKD> LEGFBMMNIAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public ComponentTypeHandle<APOICHPMLJB> LEEJDMFBIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		[NativeDisableContainerSafetyRestriction]
		public ComponentDataFromEntity<APOICHPMLJB> GJMBCDCNJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public uint DLKOOFAOEBH;

		[Cpp2IlInjected.Token(Token = "0x60009F7")]
		[Cpp2IlInjected.Address(RVA = "0x5EABCD0", Offset = "0x5EAAAD0", VA = "0x185EABCD0", Slot = "4")]
		public void Execute(ArchetypeChunk NEFPDCFOPMI, int DOJILIOCHKM, int MIOMJOANCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009F8")]
		[Cpp2IlInjected.Address(RVA = "0x5EABFD0", Offset = "0x5EAADD0", VA = "0x185EABFD0")]
		private void FKAOJJJFOFK(float4x4 GCMNHHCGJKP, Entity CCHOHIEEHEH, bool JECIIJDAPCI, int LHFEFLHGBJE = 1)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40005EA")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005EB")]
	private EntityQuery AHCEMNCGHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40005EC")]
	private EntityQuery BEJEFFEJLEA;

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA9C0", Offset = "0x5EA97C0", VA = "0x185EAA9C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAAF0", Offset = "0x5EA98F0", VA = "0x185EAAAF0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public FBFAKAFALPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001E9")]
public class HPJBMLIDACD : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x20001EA")]
	[BurstCompile]
	private struct BFBHEBMFALD : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		[ReadOnly]
		public ComponentTypeHandle<IMBFFICPOKD> PMODCOEDJIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		public ComponentTypeHandle<APOICHPMLJB> LEEJDMFBIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		public uint DLKOOFAOEBH;

		[Cpp2IlInjected.Token(Token = "0x60009FC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5810", Offset = "0x5EA4610", VA = "0x185EA5810", Slot = "4")]
		public void Execute(ArchetypeChunk NEFPDCFOPMI, int DOJILIOCHKM, int MIOMJOANCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009FD")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5920", Offset = "0x5EA4720", VA = "0x185EA5920")]
		public bool KODOCNFJGGF(ArchetypeChunk NEFPDCFOPMI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F4")]
	private EntityQuery AHCEMNCGHHG;

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5030", Offset = "0x5EB3E30", VA = "0x185EB5030", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5160", Offset = "0x5EB3F60", VA = "0x185EB5160", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public HPJBMLIDACD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EB")]
public class HBLGENBECNG : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x20001EC")]
	[BurstCompile]
	private struct GIIHPAFLKMD : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		[ReadOnly]
		public ComponentTypeHandle<APOICHPMLJB> CPIABNHPHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public ComponentTypeHandle<GLPHDKJHCLN> HBKDGMFMJOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public ComponentTypeHandle<CJHAAIFGNDF> BBHOOAHCBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public ComponentTypeHandle<CBNJLCMNPAA> HHPLBAKPKFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public uint DLKOOFAOEBH;

		[Cpp2IlInjected.Token(Token = "0x6000A01")]
		[Cpp2IlInjected.Address(RVA = "0x5EAD3C0", Offset = "0x5EAC1C0", VA = "0x185EAD3C0", Slot = "4")]
		public void Execute(ArchetypeChunk NEFPDCFOPMI, int DOJILIOCHKM, int MIOMJOANCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A02")]
		[Cpp2IlInjected.Address(RVA = "0x5EAD7B0", Offset = "0x5EAC5B0", VA = "0x185EAD7B0")]
		public bool KODOCNFJGGF(ArchetypeChunk NEFPDCFOPMI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005F8")]
	private EntityQuery HJDMFCAGMOH;

	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3380", Offset = "0x5EB2180", VA = "0x185EB3380", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3490", Offset = "0x5EB2290", VA = "0x185EB3490", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public HBLGENBECNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001ED")]
public class DOLMMGLJBJG : FMBIPPPJNCE
{
	[Cpp2IlInjected.Token(Token = "0x20001EE")]
	[BurstCompile]
	private struct DEKBEMNIGCK : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		[ReadOnly]
		public ComponentTypeHandle<HDEJALOFGAC> EAAONGNIGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		[ReadOnly]
		public ComponentTypeHandle<GLDJHBJAKIA> AIOPJEEOBEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		[ReadOnly]
		public ComponentTypeHandle<PEDPLCBIGKO> DBLALIAFGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public ComponentTypeHandle<IMBFFICPOKD> PCEKCCACAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public uint DLKOOFAOEBH;

		[Cpp2IlInjected.Token(Token = "0x6000A06")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7520", Offset = "0x5EA6320", VA = "0x185EA7520", Slot = "4")]
		public void Execute(ArchetypeChunk NEFPDCFOPMI, int DOJILIOCHKM, int MIOMJOANCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A07")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7C90", Offset = "0x5EA6A90", VA = "0x185EA7C90")]
		public bool KODOCNFJGGF(ArchetypeChunk NEFPDCFOPMI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005FE")]
	private EntityQuery HJDMFCAGMOH;

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7D90", Offset = "0x5EA6B90", VA = "0x185EA7D90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7EC0", Offset = "0x5EA6CC0", VA = "0x185EA7EC0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public DOLMMGLJBJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001EF")]
public class CNNDBMLNFAP : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000604")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000605")]
	[MBPNJDODNHC]
	private FALPINKOHJI FDHNMOPAKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000606")]
	[MBPNJDODNHC]
	private KOHELDMJMKP DKGDJCHEOEJ;

	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6CE0", Offset = "0x5EA5AE0", VA = "0x185EA6CE0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6D50", Offset = "0x5EA5B50", VA = "0x185EA6D50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA68A0", Offset = "0x5EA56A0", VA = "0x185EA68A0")]
	private void FAPKAFBICGC(NativeArray<DJMPNJEFEHC> POLJANCAGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public CNNDBMLNFAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F0")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal class FBBIGEPKDHL : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private FALPINKOHJI PPEOLCMIHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private GNBAGIHPECL JKMCJDKCAIG;

	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA1E0", Offset = "0x5EA8FE0", VA = "0x185EAA1E0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA270", Offset = "0x5EA9070", VA = "0x185EAA270", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public FBBIGEPKDHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F1")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
public sealed class OHKIJKNNKGA : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private AELOEGFEFHM OHOLEEOLBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private FALPINKOHJI GHNPBHAOPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private IOPAEIMLPMI LMOOLMEGLJN;

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFAD0", Offset = "0x5EBE8D0", VA = "0x185EBFAD0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFB60", Offset = "0x5EBE960", VA = "0x185EBFB60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public OHKIJKNNKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F2")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal class MCIDNPODDHF : FMBIPPPJNCE, IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private static readonly GKFGDEJLFAD CDHDAAMKPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	[MBPNJDODNHC]
	private IHNPEEDGEBA PNGBIGHMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	[MBPNJDODNHC]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	[MBPNJDODNHC]
	private FENEGJKBICD DDKNPKAHBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	[MBPNJDODNHC]
	private JIFHFMEONHJ KMCININDODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	[MBPNJDODNHC]
	private BLNCLHPGCCL MLBBGJOFHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	[MBPNJDODNHC]
	private EFPLPIELNNG KFOLJGBPMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	private AGFBHJPABAL.IKGDINIIFJG AILPLIAOPNP;

	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB290", Offset = "0x5EBA090", VA = "0x185EBB290", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAE70", Offset = "0x5EB9C70", VA = "0x185EBAE70", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBEB0", Offset = "0x5EBACB0", VA = "0x185EBBEB0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB430", Offset = "0x5EBA230", VA = "0x185EBB430")]
	private void JCFEKCNOANN(OMJBIJKANJG JLDFGFPAIIN, NativeArray<byte> JLFDJCNLEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A18")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAFF0", Offset = "0x5EB9DF0", VA = "0x185EBAFF0")]
	private bool EMGFMFCFFNP(OMJBIJKANJG JLDFGFPAIIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBED0", Offset = "0x5EBACD0", VA = "0x185EBBED0")]
	private AGFBHJPABAL.MJMLLNFMPBE PBLODNAKHMM(NativeArray<byte> JLFDJCNLEKC, Allocator JFLEKJGGDHL)
	{
		return default(AGFBHJPABAL.MJMLLNFMPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAF10", Offset = "0x5EB9D10", VA = "0x185EBAF10")]
	private void EGHCFEPEBCC(AGFBHJPABAL.MJMLLNFMPBE PBLAPNNAGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB980", Offset = "0x5EBA780", VA = "0x185EBB980")]
	private void JLELNODDBAH(NativeList<DJMPNJEFEHC> BNJMINPAMOL, NativeList<NOGPJKFKBEI> EIBIAHGBKEB, Allocator JFLEKJGGDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA980", Offset = "0x5EB9780", VA = "0x185EBA980")]
	private void DJIHBPEMLHJ(NativeParallelMultiHashMap<DJMPNJEFEHC, ELBMLKGPNPA> PPANLMCJPFH, NativeList<byte> JLOPJDHEGCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBB80", Offset = "0x5EBA980", VA = "0x185EBBB80")]
	private void LIIOKHMDFBD(NativeList<DJMPNJEFEHC> FFLLOLHFKDL, Allocator JFLEKJGGDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB050", Offset = "0x5EB9E50", VA = "0x185EBB050")]
	private void FPDJFCODMPB(AGFBHJPABAL.MJMLLNFMPBE PFDMLBFKIAP, bool BDNICFFMHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1F")]
	[Cpp2IlInjected.Address(RVA = "0x5EBBE10", Offset = "0x5EBAC10", VA = "0x185EBBE10")]
	private void OOHDPHCGPOD(NativeList<DJMPNJEFEHC> BNJMINPAMOL, NativeList<NOGPJKFKBEI> EIBIAHGBKEB, bool BDNICFFMHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC020", Offset = "0x5EBAE20", VA = "0x185EBC020")]
	private void PJJMGBBLKPP(NativeParallelMultiHashMap<DJMPNJEFEHC, ELBMLKGPNPA> PPANLMCJPFH, NativeList<byte> JLOPJDHEGCL, bool BDNICFFMHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB1F0", Offset = "0x5EB9FF0", VA = "0x185EBB1F0")]
	private void GKIPBNNNFGO(NativeList<DJMPNJEFEHC> FFLLOLHFKDL, bool BDNICFFMHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void DAMCNPAGMGJ(OMJBIJKANJG JLDFGFPAIIN, bool BDNICFFMHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public MCIDNPODDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F3")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal class IGOOAJLHABB : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	private GNJPLCKBNJA NPHELGDJFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	private FALPINKOHJI PPEOLCMIHEH;

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5910", Offset = "0x5EB4710", VA = "0x185EB5910", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5980", Offset = "0x5EB4780", VA = "0x185EB5980", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A27")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public IGOOAJLHABB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F4")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal class HBKHHLGCAPK : FMBIPPPJNCE, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private HDEKOHKCIPA JPFJLMHLIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private FALPINKOHJI PPEOLCMIHEH;

	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x5EB30C0", Offset = "0x5EB1EC0", VA = "0x185EB30C0", Slot = "14")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3130", Offset = "0x5EB1F30", VA = "0x185EB3130", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2B")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public HBKHHLGCAPK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20001F5")]
	[CompilerGenerated]
	[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
	[AlwaysUpdateSystem]
	internal sealed class WriteDiffChangePacketToNetworkSystem : FMBIPPPJNCE, IJCLFGAEMDL
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
				[Cpp2IlInjected.Address(RVA = "0x5EC3670", Offset = "0x5EC2470", VA = "0x185EC3670")]
				[BurstDiscard]
				private static void IEGAEKHJOOB(IntPtr P_0)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A47")]
				[Cpp2IlInjected.Address(RVA = "0x5EC3460", Offset = "0x5EC2260", VA = "0x185EC3460")]
				private static IntPtr CNABIEPBNDL()
				{
					return default(IntPtr);
				}

				[Cpp2IlInjected.Token(Token = "0x6000A48")]
				[Cpp2IlInjected.Address(RVA = "0x5EC35C0", Offset = "0x5EC23C0", VA = "0x185EC35C0")]
				public static void EICHAODCKAA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A49")]
				[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
				public static void OOCIGOIJKNJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000A4B")]
				[Cpp2IlInjected.Address(RVA = "0x5EC37A0", Offset = "0x5EC25A0", VA = "0x185EC37A0")]
				public static void LBCPFKCIFOM(IntPtr jobPtr)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000624")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldNoBurst;

			[Cpp2IlInjected.Token(Token = "0x4000625")]
			internal static InternalCompilerInterface.JobRunWithoutJobSystemDelegate FunctionPtrFieldBurst;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000626")]
			public CANNBGFMJBJ replication;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000627")]
			public NativeBitArray entityByProperty;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000628")]
			[ReadOnly]
			public NativeArray<DJMPNJEFEHC> srcCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000629")]
			[ReadOnly]
			public NativeArray<NOGPJKFKBEI> srcCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			[ReadOnly]
			public NativeArray<DJMPNJEFEHC> srcDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			[ReadOnly]
			public NativeKeyValueArrays<Entity, CEIPHBPAHMF> srcPropertyKeyValues;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			public NativeList<DJMPNJEFEHC> dstCreatedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400062D")]
			public NativeList<NOGPJKFKBEI> dstCreationData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400062E")]
			public NativeList<DJMPNJEFEHC> dstDestroyedIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400062F")]
			public NativeParallelMultiHashMap<DJMPNJEFEHC, ELBMLKGPNPA> dstProperties;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000630")]
			public NativeList<byte> dstPropertyData;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000631")]
			public ComponentDataFromEntity<KFNLPBLECCI> __RecRoom_Components_ObjectNetworkIdComponentData_FromEntity;

			[Cpp2IlInjected.Token(Token = "0x6000A40")]
			[Cpp2IlInjected.Address(RVA = "0x5EC5A00", Offset = "0x5EC4800", VA = "0x185EC5A00")]
			private void LFGCENJAPBK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A41")]
			[Cpp2IlInjected.Address(RVA = "0x5EC5790", Offset = "0x5EC4590", VA = "0x185EC5790", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A42")]
			[Cpp2IlInjected.Address(RVA = "0x5EC57F0", Offset = "0x5EC45F0", VA = "0x185EC57F0")]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			public static void JDKFJNMCLOL(IntPtr jobPtr)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A43")]
			[Cpp2IlInjected.Address(RVA = "0x5EC57A0", Offset = "0x5EC45A0", VA = "0x185EC57A0")]
			[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
			[MonoPInvokeCallback(typeof(InternalCompilerInterface.JobRunWithoutJobSystemDelegate))]
			public static void IGHOIHMPPNE(IntPtr jobPtr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private static readonly GKFGDEJLFAD log;

		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private static readonly GKFGDEJLFAD logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		[MBPNJDODNHC]
		private JEOFEPALLKF packetService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		[MBPNJDODNHC]
		private FALPINKOHJI diffService;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		[MBPNJDODNHC]
		private OCEBOIKNKAB editorEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		[MBPNJDODNHC]
		private DLKMEGGCFLP transmission;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private AGFBHJPABAL.IKGDINIIFJG utilServices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private EntityQuery __query_0;

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		private bool HasEditorListeners
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2E")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		private MFNNHFHKGKJ EventFlagsForPhase
		{
			[Cpp2IlInjected.Token(Token = "0x6000A31")]
			[Cpp2IlInjected.Address(RVA = "0x5EC56F0", Offset = "0x5EC44F0", VA = "0x185EC56F0")]
			get
			{
				return default(MFNNHFHKGKJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5440", Offset = "0x5EC4240", VA = "0x185EC5440", Slot = "14")]
		public void InitReferences(LHNHCAPHDGO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC61E0", Offset = "0x5EC4FE0", VA = "0x185EC61E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5620", Offset = "0x5EC4420", VA = "0x185EC5620")]
		private bool KMJBEJEKJEA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5500", Offset = "0x5EC4300", VA = "0x185EC5500")]
		private bool JAOPANNDDHE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A32")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4260", Offset = "0x5EC3060", VA = "0x185EC4260")]
		private bool CBPOAALKAJI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A33")]
		[Cpp2IlInjected.Address(RVA = "0x5EC42B0", Offset = "0x5EC30B0", VA = "0x185EC42B0")]
		private AGFBHJPABAL.MJMLLNFMPBE DALNNDGJAJM(NHNJJHDMCBN state)
		{
			return default(AGFBHJPABAL.MJMLLNFMPBE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A34")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4BA0", Offset = "0x5EC39A0", VA = "0x185EC4BA0")]
		private NativeKeyValueArrays<Entity, CEIPHBPAHMF> FHOACGFCFAB(NHNJJHDMCBN state, [Out] int capacity)
		{
			return default(NativeKeyValueArrays<Entity, CEIPHBPAHMF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A35")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5110", Offset = "0x5EC3F10", VA = "0x185EC5110")]
		private void HBLCIMGLAHB(AGFBHJPABAL.MJMLLNFMPBE data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A36")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5E60", Offset = "0x5EC4C60", VA = "0x185EC5E60")]
		private void NAEBAPOGBLA(AGFBHJPABAL.MJMLLNFMPBE data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A37")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4EA0", Offset = "0x5EC3CA0", VA = "0x185EC4EA0")]
		private void FPDJFCODMPB(AGFBHJPABAL.MJMLLNFMPBE data, NHNJJHDMCBN state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A38")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5F40", Offset = "0x5EC4D40", VA = "0x185EC5F40")]
		private void OOHDPHCGPOD(NativeArray<DJMPNJEFEHC> createdIds, NativeArray<NOGPJKFKBEI> creationData, MFNNHFHKGKJ flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A39")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6680", Offset = "0x5EC5480", VA = "0x185EC6680")]
		private void PJJMGBBLKPP(NativeMultiHashMapAsync<Entity, CEIPHBPAHMF> differences, MFNNHFHKGKJ flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC50E0", Offset = "0x5EC3EE0", VA = "0x185EC50E0")]
		private void GKIPBNNNFGO(NativeArray<DJMPNJEFEHC> destroyedIds, MFNNHFHKGKJ flags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC3F90", Offset = "0x5EC2D90", VA = "0x185EC3F90")]
		private void ANBHNFJFPNJ(CANNBGFMJBJ replication, NativeBitArray entityByProperty, NativeArray<DJMPNJEFEHC> srcCreatedIds, NativeArray<NOGPJKFKBEI> srcCreationData, NativeArray<DJMPNJEFEHC> srcDestroyedIds, NativeKeyValueArrays<Entity, CEIPHBPAHMF> srcPropertyKeyValues, NativeList<DJMPNJEFEHC> dstCreatedIds, NativeList<NOGPJKFKBEI> dstCreationData, NativeList<DJMPNJEFEHC> dstDestroyedIds, NativeParallelMultiHashMap<DJMPNJEFEHC, ELBMLKGPNPA> dstProperties, NativeList<byte> dstPropertyData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC5F70", Offset = "0x5EC4D70", VA = "0x185EC5F70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3D")]
		[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
		public WriteDiffChangePacketToNetworkSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A3F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC4B60", Offset = "0x5EC3960", VA = "0x185EC4B60")]
		public static void DEIBFAOCOPN()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001F9")]
internal class PIAPPKFHKHB : NMDHNPPDADH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20001FA")]
	public struct MJAGLOLOCFC : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	protected override ComponentType GMGOAKOIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1EE0", Offset = "0x5EC0CE0", VA = "0x185EC1EE0", Slot = "15")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	protected override ComponentType DBDCLBELNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1E80", Offset = "0x5EC0C80", VA = "0x185EC1E80", Slot = "16")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	protected override ComponentType GJDPPILFOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1EB0", Offset = "0x5EC0CB0", VA = "0x185EC1EB0", Slot = "17")]
		get
		{
			return default(ComponentType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1FA0", Offset = "0x5EC0DA0", VA = "0x185EC1FA0")]
	public PIAPPKFHKHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FB")]
public sealed class EALKIFLBBMD : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8080", Offset = "0x5EA6E80", VA = "0x185EA8080", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public EALKIFLBBMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FC")]
[ExecuteAlways]
public class FOEMPFOLBAM : BDBHKBBMOIC
{
	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public FOEMPFOLBAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FD")]
public sealed class EOCIAOLEKIJ : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9080", Offset = "0x5EA7E80", VA = "0x185EA9080", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public EOCIAOLEKIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FE")]
public sealed class ELENMGMJNID : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x5EA88D0", Offset = "0x5EA76D0", VA = "0x185EA88D0", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public ELENMGMJNID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001FF")]
[ExecuteAlways]
public class JJCNGIKKPNO : BDBHKBBMOIC
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x3682770", Offset = "0x3681570", VA = "0x183682770")]
	public JJCNGIKKPNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000200")]
public sealed class PODLNAHKDLL : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x5EC2000", Offset = "0x5EC0E00", VA = "0x185EC2000", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public PODLNAHKDLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000201")]
[CBDJBBOKHOJ(typeof(JMMDCOJHEDE))]
[LKMFAIPHKDB(typeof(IHJBEAAMNEB), new string[] { })]
public class MIDEBIJKOGO : IHJBEAAMNEB, POKGICLLPAE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private readonly Dictionary<int, MFGAIFFIFKP> CJLBKHDJGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private readonly Dictionary<Type, MFGAIFFIFKP> JNPAFKHGODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000637")]
	private readonly Dictionary<Type, MFGAIFFIFKP> LOKOIJHPDAO;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public IReadOnlyCollection<MFGAIFFIFKP> OOKPONCCHOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x5EBCB20", Offset = "0x5EBB920", VA = "0x185EBCB20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBC710", Offset = "0x5EBB510", VA = "0x185EBC710", Slot = "7")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCAA0", Offset = "0x5EBB8A0", VA = "0x185EBCAA0", Slot = "6")]
	public MFGAIFFIFKP ELJBJJLNHJK(Type PEMNIEMPPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCB70", Offset = "0x5EBB970", VA = "0x185EBCB70", Slot = "5")]
	public bool MHHFINHOFOD(int IDDPEMOGPEO, [Out] MFGAIFFIFKP EKODFEEOAPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5F")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCA50", Offset = "0x5EBB850", VA = "0x185EBCA50", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A60")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCBE0", Offset = "0x5EBB9E0", VA = "0x185EBCBE0")]
	public MIDEBIJKOGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000202")]
[CBDJBBOKHOJ(typeof(JMMDCOJHEDE))]
[LKMFAIPHKDB(typeof(ECLOMGLPHEH), new string[] { })]
public class OLFKEJLINOJ : ECLOMGLPHEH, POKGICLLPAE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000638")]
	private readonly Dictionary<int, NKGJKGDJEJL> FGPMAEEBAOE;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public IEnumerable<NKGJKGDJEJL> PABBENILDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x5EBFC70", Offset = "0x5EBEA70", VA = "0x185EBFC70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A62")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFD30", Offset = "0x5EBEB30", VA = "0x185EBFD30", Slot = "6")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A63")]
	[Cpp2IlInjected.Address(RVA = "0x5EBFCC0", Offset = "0x5EBEAC0", VA = "0x185EBFCC0", Slot = "5")]
	public bool BBKKGHFJJOA(int IDDPEMOGPEO, [Out] NKGJKGDJEJL KPBDFPNEODJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A64")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0120", Offset = "0x5EBEF20", VA = "0x185EC0120", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0170", Offset = "0x5EBEF70", VA = "0x185EC0170")]
	public OLFKEJLINOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000203")]
[CBDJBBOKHOJ(typeof(JMMDCOJHEDE))]
[LKMFAIPHKDB(typeof(AMENGEAIDBL), new string[] { })]
public class LMPJNFEINDJ : AMENGEAIDBL, POKGICLLPAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000639")]
	private static readonly Dictionary<int, int> KGCDGGINCMP;

	[Cpp2IlInjected.Token(Token = "0x6000A66")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA4F0", Offset = "0x5EB92F0", VA = "0x185EBA4F0", Slot = "5")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA850", Offset = "0x5EB9650", VA = "0x185EBA850", Slot = "4")]
	public int PCGHMBNENOA(int IDDPEMOGPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0x5EBA7E0", Offset = "0x5EB95E0", VA = "0x185EBA7E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A69")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LMPJNFEINDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000204")]
[LKMFAIPHKDB(typeof(BMLAACMLOPO), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal class BMLAACMLOPO : FKNGAHGHIJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063A")]
	private IHDLIDLJDJH<AuthoredParentData, AuthoredPreviousParentData, IHIJNEKFLEC, AuthoredChildrenData> AJHNCEFGMNL;

	[Cpp2IlInjected.Token(Token = "0x6000A6B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5E70", Offset = "0x5EA4C70", VA = "0x185EA5E70", Slot = "4")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6C")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BMLAACMLOPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000205")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(IDFADMBGMDJ), new string[] { })]
internal sealed class IDFADMBGMDJ : IJCLFGAEMDL, FKNGAHGHIJP
{
	[Cpp2IlInjected.Token(Token = "0x400063B")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063C")]
	[MBPNJDODNHC]
	private JNPLIBJDOGK HJDMFCAGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400063D")]
	private CMIFDPMNHCO<Entity> GGCGADADFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400063E")]
	private IHDLIDLJDJH<ParentData, PreviousParentData, BKFCADMOBLH, ChildrenData> AJHNCEFGMNL;

	[Cpp2IlInjected.Token(Token = "0x6000A6D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5630", Offset = "0x5EB4430", VA = "0x185EB5630", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5680", Offset = "0x5EB4480", VA = "0x185EB5680", Slot = "5")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A6F")]
	[Cpp2IlInjected.Address(RVA = "0x5EB52A0", Offset = "0x5EB40A0", VA = "0x185EB52A0")]
	public Entity DGLCEEOLIGB(Entity CCHOHIEEHEH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A70")]
	[Cpp2IlInjected.Address(RVA = "0x5EB52F0", Offset = "0x5EB40F0", VA = "0x185EB52F0")]
	public bool DOEKFLCEILH(Entity CCHOHIEEHEH, Entity KBFMMMPNLKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A71")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5590", Offset = "0x5EB4390", VA = "0x185EB5590")]
	public bool HDGBCFAMPCN(Entity CCHOHIEEHEH, Entity KBFMMMPNLKE, bool CANHJIIKAKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5350", Offset = "0x5EB4150", VA = "0x185EB5350")]
	private bool GJNLLOOFOOI(Entity CCHOHIEEHEH, Entity KBFMMMPNLKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IDFADMBGMDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000206")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(CCJGFPJKFGE), new string[] { })]
internal sealed class CCJGFPJKFGE : IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400063F")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000640")]
	private EntityQuery IILINADNFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A75")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5F30", Offset = "0x5EA4D30", VA = "0x185EA5F30")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A76")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6200", Offset = "0x5EA5000", VA = "0x185EA6200", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A77")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6020", Offset = "0x5EA4E20", VA = "0x185EA6020", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A78")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6150", Offset = "0x5EA4F50", VA = "0x185EA6150")]
	public bool FOIIPDKECAK(Entity CCHOHIEEHEH, Entity IKGHEPBMABE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A79")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6300", Offset = "0x5EA5100", VA = "0x185EA6300")]
	public bool PCKJBELCCCI(Entity CCHOHIEEHEH, Entity EMABGINODJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5F80", Offset = "0x5EA4D80", VA = "0x185EA5F80")]
	public Entity DLNLOPFGNBL(Entity CCHOHIEEHEH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6040", Offset = "0x5EA4E40", VA = "0x185EA6040")]
	public NativeArray<Entity> EIMAADJFFBG()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6090", Offset = "0x5EA4E90", VA = "0x185EA6090")]
	public bool FBILGEPLNJE(Entity CJKEIGLKDDB, Entity FPDPCPLHJFJ, [Out] Entity KAAGEJFEMGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public CCJGFPJKFGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000207")]
public static class GDDGJKODMLG
{
	[Cpp2IlInjected.Token(Token = "0x4000642")]
	internal static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x6000A7E")]
	[Cpp2IlInjected.Address(RVA = "0x2357CE0", Offset = "0x2356AE0", VA = "0x182357CE0")]
	public static void PCPNMJLBOGM<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData>(LHNHCAPHDGO PDGDCGJNEFO, DKCNFDOHIPC<Entity> COPMFEAGFCB, [Out] IHDLIDLJDJH<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> PPIIKGKEPEP) where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, DPJHIPLKBBA where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, DPJHIPLKBBA, IEquatable<TChildrenData>
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A7F")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC3B0", Offset = "0x5EAB1B0", VA = "0x185EAC3B0")]
	public static bool HJKEFPJACFA(ECLMNCPCDJH IHHDBAHIMPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000208")]
public class IHDLIDLJDJH<TParentData, TPreviousParentData, TParentRemovedTag, TChildrenData> where TParentData : struct, IComponentData where TPreviousParentData : struct, IComponentData, DPJHIPLKBBA where TParentRemovedTag : struct, IComponentData where TChildrenData : struct, IBufferElementData, DPJHIPLKBBA, IEquatable<TChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x4000643")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000644")]
	private readonly HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000645")]
	private readonly CMIFDPMNHCO<Entity> GGCGADADFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000646")]
	private readonly FCKMNLHDJPO HIKPEAINMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000647")]
	private readonly LPNKEHLCEHF LBLLNFOEKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000648")]
	private readonly EntityManager FMCNCDMBJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000649")]
	private readonly HBFNKHCAGGC MKEMCEBLCJD;

	[Cpp2IlInjected.Token(Token = "0x6000A81")]
	[Cpp2IlInjected.Address(RVA = "0x365C8B0", Offset = "0x365B6B0", VA = "0x18365C8B0")]
	public IHDLIDLJDJH(LHNHCAPHDGO PDGDCGJNEFO, DKCNFDOHIPC<Entity> COPMFEAGFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A82")]
	[Cpp2IlInjected.Address(RVA = "0x365A840", Offset = "0x3659640", VA = "0x18365A840")]
	private bool DGKFOPIIEAD(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A83")]
	[Cpp2IlInjected.Address(RVA = "0x365A740", Offset = "0x3659540", VA = "0x18365A740")]
	private bool DEEGALMDNLG(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A84")]
	[Cpp2IlInjected.Address(RVA = "0x365C220", Offset = "0x365B020", VA = "0x18365C220")]
	private bool PLAHJEJCOAE(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A85")]
	[Cpp2IlInjected.Address(RVA = "0x365AB80", Offset = "0x3659980", VA = "0x18365AB80")]
	public bool DOEKFLCEILH(Entity CCHOHIEEHEH, [In] Entity KBFMMMPNLKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A86")]
	[Cpp2IlInjected.Address(RVA = "0x365B110", Offset = "0x3659F10", VA = "0x18365B110")]
	public bool GLIGBOMDPNM(Entity CCHOHIEEHEH, [In] Entity KBFMMMPNLKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A87")]
	[Cpp2IlInjected.Address(RVA = "0x365B150", Offset = "0x3659F50", VA = "0x18365B150")]
	private bool GLIGBOMDPNM(Entity CCHOHIEEHEH, [In] Entity KBFMMMPNLKE, bool NNBOEIGOMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A88")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void CFNBPPEGCMI(Entity CCHOHIEEHEH, [In] Entity KBFMMMPNLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A89")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void KPGJEAFLBJP(Entity CCHOHIEEHEH, [In] Entity KBFMMMPNLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8A")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void DIDCCFPFHIA(Entity CCHOHIEEHEH, [In] Entity KBFMMMPNLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8B")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void ACAHJCLAAGI(Entity CCHOHIEEHEH, [In] Entity KBFMMMPNLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8C")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void FJEPHIKAFPA(Entity CCHOHIEEHEH, [In] Entity KBFMMMPNLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8D")]
	[Cpp2IlInjected.Address(RVA = "0x365ACB0", Offset = "0x3659AB0", VA = "0x18365ACB0")]
	private bool FOIIPDKECAK(Entity CCHOHIEEHEH, Entity IKGHEPBMABE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8E")]
	[Cpp2IlInjected.Address(RVA = "0x365AA60", Offset = "0x3659860", VA = "0x18365AA60")]
	private void DIOIAKHHOAO(Entity CCHOHIEEHEH, [In] Entity AOAOIAHJGFI, [In] Entity KBFMMMPNLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A8F")]
	[Cpp2IlInjected.Address(RVA = "0x365B680", Offset = "0x365A480", VA = "0x18365B680")]
	private void LGNLFNFNPEM(Entity CCHOHIEEHEH, [In] Entity AOAOIAHJGFI, [In] Entity KBFMMMPNLKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A90")]
	[Cpp2IlInjected.Address(RVA = "0x365BCB0", Offset = "0x365AAB0", VA = "0x18365BCB0")]
	private bool ODKKNIDIBDJ(FENEGJKBICD GMMGPPEKOEC, [In] DJMPNJEFEHC HGPHANECFOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A91")]
	[Cpp2IlInjected.Address(RVA = "0x365BEA0", Offset = "0x365ACA0", VA = "0x18365BEA0")]
	private void OHPPCLKLOPE(Entity LBLLNFOEKNE, Entity FKKAOLHJCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A92")]
	[Cpp2IlInjected.Address(RVA = "0x365B4C0", Offset = "0x365A2C0", VA = "0x18365B4C0")]
	private void HHIIPGJELHJ(Entity LBLLNFOEKNE, Entity FKKAOLHJCBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A93")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private void NJBNEOPNPIG(Entity CCHOHIEEHEH, Entity AOAOIAHJGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A94")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private void IBICKEBOIAD(Entity CCHOHIEEHEH, Entity KBFMMMPNLKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000209")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(GNJPLCKBNJA), new string[] { })]
internal sealed class GNJPLCKBNJA : NDDDEAMKNGH, POKGICLLPAE, IJCLFGAEMDL, FKNGAHGHIJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400064A")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400064B")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400064C")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400064D")]
	[MBPNJDODNHC]
	private JNPLIBJDOGK HJDMFCAGMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400064E")]
	[MBPNJDODNHC]
	private JHHOBBMGMJL NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400064F")]
	[MBPNJDODNHC]
	private EPCLCPFGOIL IGBHKFPEPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000650")]
	[MBPNJDODNHC]
	private BDMEKDJBKEP FDMBINFGKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000651")]
	[MBPNJDODNHC]
	private CGGDHOPMPPP LFJPIAOIGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000652")]
	[MBPNJDODNHC]
	private IOPAEIMLPMI LMOOLMEGLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000653")]
	private readonly Dictionary<DJMPNJEFEHC, KMILLOLJKJL> AMLIODFKNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000654")]
	private AGEMENJDFMK NMGNICEIDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000655")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000A96")]
		[Cpp2IlInjected.Address(RVA = "0x5EAF090", Offset = "0x5EADE90", VA = "0x185EAF090")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A97")]
	[Cpp2IlInjected.Address(RVA = "0xB14A20", Offset = "0xB13820", VA = "0x180B14A20", Slot = "4")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A98")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0450", Offset = "0x5EAF250", VA = "0x185EB0450", Slot = "5")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A99")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0320", Offset = "0x5EAF120", VA = "0x185EB0320")]
	public void HNNLNDIOFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0DC0", Offset = "0x5EAFBC0", VA = "0x185EB0DC0", Slot = "6")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9B")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFE20", Offset = "0x5EAEC20", VA = "0x185EAFE20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9C")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEA60", Offset = "0x5EAD860", VA = "0x185EAEA60")]
	public int ACCKIFBHHNL(SceneTag PIOKEHOJBEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2350", Offset = "0x5EB1150", VA = "0x185EB2350")]
	public bool NPEOAMFOMEA(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9E")]
	[Cpp2IlInjected.Address(RVA = "0x5EB27D0", Offset = "0x5EB15D0", VA = "0x185EB27D0")]
	public bool PIACKBAOBEI(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A9F")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2240", Offset = "0x5EB1040", VA = "0x185EB2240")]
	public bool NNMNOGEKHAN(Entity CCHOHIEEHEH, [Out] KMILLOLJKJL MENCLGMKPHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB22B0", Offset = "0x5EB10B0", VA = "0x185EB22B0")]
	private bool NNMNOGEKHAN(Transform GNLAIPIBJPM, [Out] KMILLOLJKJL MENCLGMKPHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA1")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0210", Offset = "0x5EAF010", VA = "0x185EB0210")]
	private void GICDIFJLFBE(Entity CCHOHIEEHEH, KMILLOLJKJL MENCLGMKPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1030", Offset = "0x5EAFE30", VA = "0x185EB1030")]
	private bool KNHEAKNNENC(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1D80", Offset = "0x5EB0B80", VA = "0x185EB1D80")]
	public void MCJJKKHGDCC(DJMPNJEFEHC IELEJBMANDO, KMILLOLJKJL CEGGCCELOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA4")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1F20", Offset = "0x5EB0D20", VA = "0x185EB1F20")]
	public void MCJJKKHGDCC(JBMJEBCFLLB OGPPAJOCABK, KMILLOLJKJL CEGGCCELOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA5")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF780", Offset = "0x5EAE580", VA = "0x185EAF780")]
	public bool DOPJEBMGADA(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA6")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFDC0", Offset = "0x5EAEBC0", VA = "0x185EAFDC0")]
	public bool DOPJEBMGADA(Entity CCHOHIEEHEH, [Optional] object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA7")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFD90", Offset = "0x5EAEB90", VA = "0x185EAFD90")]
	public bool DOPJEBMGADA(KMILLOLJKJL IHHDBAHIMPL, object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF0E0", Offset = "0x5EADEE0", VA = "0x185EAF0E0")]
	public bool DFKCBNKAFIM(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AA9")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFD60", Offset = "0x5EAEB60", VA = "0x185EAFD60")]
	public bool DOPJEBMGADA(KMILLOLJKJL MENCLGMKPHE, bool PJCPHDDKADF, [Optional] object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB27F0", Offset = "0x5EB15F0", VA = "0x185EB27F0")]
	private bool PLABBKJLIKN(KMILLOLJKJL MENCLGMKPHE, object PFKLELGAJPH, bool PJCPHDDKADF, bool JGBDIEFNNFB, bool FILCELEFOOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAB")]
	[Cpp2IlInjected.Address(RVA = "0x5EB10D0", Offset = "0x5EAFED0", VA = "0x185EB10D0")]
	public Transform LMIKGINGFEF(Entity CCHOHIEEHEH, [Optional] object PFKLELGAJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAC")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEB60", Offset = "0x5EAD960", VA = "0x185EAEB60")]
	public bool AMDJHMKKENI(Entity CCHOHIEEHEH, [Out] Transform GNLAIPIBJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAD")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2000", Offset = "0x5EB0E00", VA = "0x185EB2000")]
	public KMILLOLJKJL MEMNMGJANNO(Entity CCHOHIEEHEH, [Optional] object PFKLELGAJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAE")]
	[Cpp2IlInjected.Address(RVA = "0x5EAFEE0", Offset = "0x5EAECE0", VA = "0x185EAFEE0")]
	public void ELNONIFPABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AAF")]
	[Cpp2IlInjected.Address(RVA = "0x5EB09E0", Offset = "0x5EAF7E0", VA = "0x185EB09E0")]
	public void JFAMCPDIFJP(SceneTag PIOKEHOJBEJ, bool JGBDIEFNNFB, NativeParallelHashSet<int> BCIMDALNOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1350", Offset = "0x5EB0150", VA = "0x185EB1350")]
	private void MBKHGAPLPBH(Entity CCHOHIEEHEH, bool JGBDIEFNNFB, bool FILCELEFOOB, NativeParallelHashSet<int> BCIMDALNOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB1")]
	[Cpp2IlInjected.Address(RVA = "0x5EB12C0", Offset = "0x5EB00C0", VA = "0x185EB12C0")]
	private bool LPLEMOIFKPC(KMILLOLJKJL MENCLGMKPHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB02A0", Offset = "0x5EAF0A0", VA = "0x185EB02A0")]
	public bool HKNOPCPJEPF(Entity CCHOHIEEHEH, object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB1050", Offset = "0x5EAFE50", VA = "0x185EB1050")]
	public bool LDOHKGPKLNJ(Entity CCHOHIEEHEH, object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAF6A0", Offset = "0x5EAE4A0", VA = "0x185EAF6A0")]
	public bool DKIGKLGMCFC(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB5")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEA80", Offset = "0x5EAD880", VA = "0x185EAEA80")]
	private void AGCGFDJCLFE(bool AAAMOCNCFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB6")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0EA0", Offset = "0x5EAFCA0", VA = "0x185EB0EA0")]
	private bool JMOMIDHBIDD(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB7")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2780", Offset = "0x5EB1580", VA = "0x185EB2780")]
	public KMILLOLJKJL PBANDCDIDJA(Entity CCHOHIEEHEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEC30", Offset = "0x5EADA30", VA = "0x185EAEC30")]
	private KMILLOLJKJL APCHEHAMEBB(Entity CCHOHIEEHEH, object PFKLELGAJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AB9")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2520", Offset = "0x5EB1320", VA = "0x185EB2520")]
	private KMILLOLJKJL OOKEIFOPFDB(Entity CCHOHIEEHEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB20F0", Offset = "0x5EB0EF0", VA = "0x185EB20F0")]
	public void NICLOBFGKNN(NativeArray<DJMPNJEFEHC> OEHBGDNEBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABB")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0F60", Offset = "0x5EAFD60", VA = "0x185EB0F60")]
	private void KKOPHOHPIPG(KMILLOLJKJL CEGGCCELOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABC")]
	[Cpp2IlInjected.Address(RVA = "0x5EAECD0", Offset = "0x5EADAD0", VA = "0x185EAECD0")]
	private void BKFGGKFKHPM(KMILLOLJKJL MENCLGMKPHE, Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABD")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0580", Offset = "0x5EAF380", VA = "0x185EB0580")]
	private void JBNBGLNJDHH(Entity CCHOHIEEHEH, KMILLOLJKJL MENCLGMKPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB0370", Offset = "0x5EAF170", VA = "0x185EB0370")]
	private void IKMLBCAKGLL(Entity CCHOHIEEHEH, Transform GNLAIPIBJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ABF")]
	[Cpp2IlInjected.Address(RVA = "0x5E31AF0", Offset = "0x5E308F0", VA = "0x185E31AF0")]
	private JBMJEBCFLLB OFMNGHJEOGI(Entity CCHOHIEEHEH)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB2DE0", Offset = "0x5EB1BE0", VA = "0x185EB2DE0")]
	public GNJPLCKBNJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC2")]
	[Cpp2IlInjected.Address(RVA = "0x5EAEFC0", Offset = "0x5EADDC0", VA = "0x185EAEFC0")]
	[CompilerGenerated]
	private void BNFCKNDCACM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020A")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(GNBAGIHPECL), new string[] { })]
internal sealed class GNBAGIHPECL : IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000656")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000657")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000658")]
	private GNJPLCKBNJA MENCLGMKPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000659")]
	private CBPKPGHBMDE NFOHENADJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400065A")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC7")]
		[Cpp2IlInjected.Address(RVA = "0x5EADBE0", Offset = "0x5EAC9E0", VA = "0x185EADBE0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<EOLLFEKBMDA, NativeArray<FMJMJJHCMAN>> MDBAKLKDBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC3")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE680", Offset = "0x5EAD480", VA = "0x185EAE680")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000AC4")]
		[Cpp2IlInjected.Address(RVA = "0x5EAE2A0", Offset = "0x5EAD0A0", VA = "0x185EAE2A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<EOLLFEKBMDA> EPJAIFJBMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AC5")]
		[Cpp2IlInjected.Address(RVA = "0x5EAD890", Offset = "0x5EAC690", VA = "0x185EAD890")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000AC6")]
		[Cpp2IlInjected.Address(RVA = "0x5EADE80", Offset = "0x5EACC80", VA = "0x185EADE80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE3B0", Offset = "0x5EAD1B0", VA = "0x185EAE3B0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AC9")]
	[Cpp2IlInjected.Address(RVA = "0x19940E0", Offset = "0x1992EE0", VA = "0x1819940E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACA")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE260", Offset = "0x5EAD060", VA = "0x185EAE260")]
	public void GAOMNJBAIKD(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACB")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE630", Offset = "0x5EAD430", VA = "0x185EAE630")]
	public void JINOLDDPMBP(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACC")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD940", Offset = "0x5EAC740", VA = "0x185EAD940")]
	private bool BLPIFLIBKGF(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACD")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE960", Offset = "0x5EAD760", VA = "0x185EAE960")]
	public void OKHJEEBGOJC(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACE")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE450", Offset = "0x5EAD250", VA = "0x185EAE450")]
	private bool JEKDAJLCJPM(Entity CCHOHIEEHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000ACF")]
	[Cpp2IlInjected.Address(RVA = "0x5EADA90", Offset = "0x5EAC890", VA = "0x185EADA90")]
	public void CGMMBIMCGNC(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD0")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE350", Offset = "0x5EAD150", VA = "0x185EAE350")]
	private void IBGHIALHNFN(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD1")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE730", Offset = "0x5EAD530", VA = "0x185EAE730")]
	private void MFIOLIOPMFM(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD2")]
	[Cpp2IlInjected.Address(RVA = "0x5EAE200", Offset = "0x5EAD000", VA = "0x185EAE200")]
	private void FNLEEPJACIG(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD3")]
	[Cpp2IlInjected.Address(RVA = "0x5EADF30", Offset = "0x5EACD30", VA = "0x185EADF30")]
	private void FJLPIMNHCOA(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD840", Offset = "0x5EAC640", VA = "0x185EAD840")]
	public void AANJBHMELPH(EOLLFEKBMDA BCFDFNJIOHD, NativeArray<FMJMJJHCMAN> CKFMLBNEDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD5")]
	[Cpp2IlInjected.Address(RVA = "0x5EADE40", Offset = "0x5EACC40", VA = "0x185EADE40")]
	public void DAJIHGBKEIO(EOLLFEKBMDA BCFDFNJIOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD6")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private void KAIMLDAEEEC(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD7")]
	[Cpp2IlInjected.Address(RVA = "0x5EADC30", Offset = "0x5EACA30", VA = "0x185EADC30")]
	private void CPEPHAICBGN(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AD8")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public GNBAGIHPECL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020B")]
[LKMFAIPHKDB(typeof(LHACECFODGE), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal class LHACECFODGE : NADKLGCBGPO, IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200020D")]
	[CompilerGenerated]
	private sealed class DBIACMFKGBK : IEnumerable<(NJGEKDIELMJ, FMJMJJHCMAN)>, IEnumerable, IEnumerator<(NJGEKDIELMJ, FMJMJJHCMAN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private (NJGEKDIELMJ primitiveType, FMJMJJHCMAN prefabType) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		public LHACECFODGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private int <i>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		private (NJGEKDIELMJ, FMJMJJHCMAN) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF7")]
			[Cpp2IlInjected.Address(RVA = "0x30DFE60", Offset = "0x30DEC60", VA = "0x1830DFE60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((NJGEKDIELMJ, FMJMJJHCMAN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF9")]
			[Cpp2IlInjected.Address(RVA = "0x5EA74D0", Offset = "0x5EA62D0", VA = "0x185EA74D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF4")]
		[Cpp2IlInjected.Address(RVA = "0x3260C70", Offset = "0x325FA70", VA = "0x183260C70")]
		[DebuggerHidden]
		public DBIACMFKGBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF5")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF6")]
		[Cpp2IlInjected.Address(RVA = "0x5EA72D0", Offset = "0x5EA60D0", VA = "0x185EA72D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7480", Offset = "0x5EA6280", VA = "0x185EA7480", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFA")]
		[Cpp2IlInjected.Address(RVA = "0x5EA73D0", Offset = "0x5EA61D0", VA = "0x185EA73D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(NJGEKDIELMJ, FMJMJJHCMAN)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000AFB")]
		[Cpp2IlInjected.Address(RVA = "0x5EA73D0", Offset = "0x5EA61D0", VA = "0x185EA73D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400065D")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400065E")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400065F")]
	private World GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000660")]
	private NativeParallelHashMap<int, Entity> IPGJNLBLKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000661")]
	private NativeParallelHashMap<int, EntityArchetype> MLOIHHALAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000662")]
	private NativeParallelHashMap<int, int> PCDCCNOPEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000663")]
	private FMJMJJHCMAN[] CKFMLBNEDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000664")]
	private readonly Dictionary<NJGEKDIELMJ, FMJMJJHCMAN> JLJHEIHLPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000665")]
	private readonly Dictionary<MGAKHNOAGMM, FMJMJJHCMAN> NGILLCMCDHA;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADA")]
		[Cpp2IlInjected.Address(RVA = "0x5EB9760", Offset = "0x5EB8560", VA = "0x185EB9760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000ADB")]
		[Cpp2IlInjected.Address(RVA = "0x764C10", Offset = "0x763A10", VA = "0x180764C10")]
		[CompilerGenerated]
		get
		{
			return default(EntityManager);
		}
		[Cpp2IlInjected.Token(Token = "0x6000ADC")]
		[Cpp2IlInjected.Address(RVA = "0x185C4A0", Offset = "0x185B2A0", VA = "0x18185C4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADD")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8B70", Offset = "0x5EB7970", VA = "0x185EB8B70", Slot = "5")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB82B0", Offset = "0x5EB70B0", VA = "0x185EB82B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000ADF")]
	[Cpp2IlInjected.Address(RVA = "0xD48CA0", Offset = "0xD47AA0", VA = "0x180D48CA0")]
	internal NativeParallelHashMap<int, Entity> LAFGCFKBIFA()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE0")]
	[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5E260", VA = "0x180D5F460")]
	internal NativeParallelHashMap<int, EntityArchetype> KFFKAOBIPCK()
	{
		return default(NativeParallelHashMap<int, EntityArchetype>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE1")]
	[Cpp2IlInjected.Address(RVA = "0x89C9C0", Offset = "0x89B7C0", VA = "0x18089C9C0")]
	internal NativeParallelHashMap<int, int> DHKLPKJFNDP()
	{
		return default(NativeParallelHashMap<int, int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9A30", Offset = "0x5EB8830", VA = "0x185EB9A30")]
	internal IEnumerable<Type> LGEAGFNFNHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB81C0", Offset = "0x5EB6FC0", VA = "0x185EB81C0")]
	internal MEHAHPMDPEP DIJJLHEPDBL(Type PEMNIEMPPLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE4")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8660", Offset = "0x5EB7460", VA = "0x185EB8660")]
	public EntityArchetype EBKDNDOHKDL(FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE5")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8230", Offset = "0x5EB7030", VA = "0x185EB8230", Slot = "4")]
	[IteratorStateMachine(typeof(DBIACMFKGBK))]
	public IEnumerable<(NJGEKDIELMJ, FMJMJJHCMAN)> DLBCJGGIHAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE6")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9E20", Offset = "0x5EB8C20", VA = "0x185EB9E20")]
	public Entity NKCHKCJIHIJ(FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE7")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9880", Offset = "0x5EB8680", VA = "0x185EB9880")]
	public void KKPFLAJCCGH(NativeArray<FMJMJJHCMAN> CKFMLBNEDOK, NativeArray<Entity> BIJMENJNFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE8")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9A90", Offset = "0x5EB8890", VA = "0x185EB9A90")]
	public void MJJHHKCBPGG(FMJMJJHCMAN CMNEDOHOKIA, NativeArray<Entity> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AE9")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9700", Offset = "0x5EB8500", VA = "0x185EB9700")]
	public FMJMJJHCMAN JEDJPNAIPIE(NJGEKDIELMJ PEMNIEMPPLO)
	{
		return default(FMJMJJHCMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB97A0", Offset = "0x5EB85A0", VA = "0x185EB97A0")]
	public Entity KIKPCJBAMBB(FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEB")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9B20", Offset = "0x5EB8920", VA = "0x185EB9B20")]
	private void NAEKICCHFKG(MEHAHPMDPEP ANGDKKJLJBG, NativeList<int> CKFMLBNEDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEC")]
	[Cpp2IlInjected.Address(RVA = "0x5EB8860", Offset = "0x5EB7660", VA = "0x185EB8860")]
	internal void HJAINFCBFOM(FMJMJJHCMAN CMNEDOHOKIA, ComponentTypeList EHIKNGOOIMM, HKCAMDPDJCF EMFEFHHOEDC, MEHAHPMDPEP ANGDKKJLJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000AED")]
	[Cpp2IlInjected.Address(RVA = "0x5EB86D0", Offset = "0x5EB74D0", VA = "0x185EB86D0")]
	private EntityArchetype FGOFMKKMPGL(FMJMJJHCMAN CMNEDOHOKIA, ComponentTypeList IAEGOGAHMLB)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000AEE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB9FD0", Offset = "0x5EB8DD0", VA = "0x185EB9FD0")]
	public LHACECFODGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200020E")]
public enum CIDKNADIFBP
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
internal interface JKPKLADFGOH
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	World IIPPIBCPIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	World LLDCDMOFHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	FAOMFNKBCCM IKFKDDIPNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	uint DLKOOFAOEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000AFF")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000B00")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B01")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000210")]
internal class GHACJPKLCDE : CDPGLFJJDKD, NHNJJHDMCBN
{
	[Cpp2IlInjected.Token(Token = "0x4000674")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000675")]
	private readonly JKPKLADFGOH PFBEHMOEMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000676")]
	private readonly CIDKNADIFBP FAKOLMHKKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000677")]
	private readonly World AEALPKECAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000678")]
	private readonly List<GKAAFOJHJKF> MLOJIGCKENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000679")]
	private NativeParallelMultiHashMap<Entity, CEIPHBPAHMF> BEHOKHIBDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400067A")]
	private NativeParallelHashMap<int, int> DJIPDHPJPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400067B")]
	private NativeArray<DJMPNJEFEHC> BNJMINPAMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400067C")]
	private NativeArray<NOGPJKFKBEI> EIBIAHGBKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	private NativeArray<DJMPNJEFEHC> FFLLOLHFKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private JobHandle LPLCJFKHGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	private JobHandle EACJKFCPAOP;

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private NativeParallelMultiHashMap<Entity, CEIPHBPAHMF> ONGCBGOPKHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B03")]
		[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5E260", VA = "0x180D5F460", Slot = "4")]
		get
		{
			return default(NativeParallelMultiHashMap<Entity, CEIPHBPAHMF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private uint AHICDBOBGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000B04")]
		[Cpp2IlInjected.Address(RVA = "0x5EAD1F0", Offset = "0x5EABFF0", VA = "0x185EAD1F0", Slot = "5")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private bool EJEDJOLNFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B08")]
		[Cpp2IlInjected.Address(RVA = "0x5EAC5F0", Offset = "0x5EAB3F0", VA = "0x185EAC5F0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private NativeArray<DJMPNJEFEHC> NDGCHALGLLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B09")]
		[Cpp2IlInjected.Address(RVA = "0x19E84B0", Offset = "0x19E72B0", VA = "0x1819E84B0", Slot = "10")]
		get
		{
			return default(NativeArray<DJMPNJEFEHC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private NativeArray<NOGPJKFKBEI> IHADHNODPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0A")]
		[Cpp2IlInjected.Address(RVA = "0xEB77E0", Offset = "0xEB65E0", VA = "0x180EB77E0", Slot = "11")]
		get
		{
			return default(NativeArray<NOGPJKFKBEI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	private NativeArray<DJMPNJEFEHC> IPLJFIEDCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B0B")]
		[Cpp2IlInjected.Address(RVA = "0x3BC72A0", Offset = "0x3BC60A0", VA = "0x183BC72A0", Slot = "12")]
		get
		{
			return default(NativeArray<DJMPNJEFEHC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B02")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD2D0", Offset = "0x5EAC0D0", VA = "0x185EAD2D0")]
	public GHACJPKLCDE(JKPKLADFGOH PFBEHMOEMND, CIDKNADIFBP FAKOLMHKKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B05")]
	[Cpp2IlInjected.Address(RVA = "0x5EACBF0", Offset = "0x5EAB9F0", VA = "0x185EACBF0", Slot = "6")]
	private bool MNKBLBDAHBL(NativeArray<DJMPNJEFEHC> BNJMINPAMOL, NativeArray<NOGPJKFKBEI> EIBIAHGBKEB, NativeArray<DJMPNJEFEHC> FFLLOLHFKDL, int POIEBPNEPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B06")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC950", Offset = "0x5EAB750", VA = "0x185EAC950", Slot = "7")]
	private void FPPNCDALBLN([In] GKAAFOJHJKF HIKCEFIDFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B07")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC470", Offset = "0x5EAB270", VA = "0x185EAC470", Slot = "8")]
	private void ALFPDKGLBKO(JobHandle KMOBDGPHBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0C")]
	[Cpp2IlInjected.Address(RVA = "0x5EACAC0", Offset = "0x5EAB8C0", VA = "0x185EACAC0", Slot = "13")]
	private bool JHFCKBOBCNP([Out] NativeArray<int> DFFEGDMICHO, Allocator JFLEKJGGDHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0D")]
	[Cpp2IlInjected.Address(RVA = "0x5EAD010", Offset = "0x5EABE10", VA = "0x185EAD010", Slot = "14")]
	private bool ONKHCMCKHEC(ComponentType ACNKJFPHPMG, [Out] GKAAFOJHJKF OEFJMJNGBID, [Out] LFFECALJCKG JEPAAHKBIBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x5EACB70", Offset = "0x5EAB970", VA = "0x185EACB70", Slot = "15")]
	private NativeMultiHashMapAsync<Entity, CEIPHBPAHMF> KGLLICLBEAP()
	{
		return default(NativeMultiHashMapAsync<Entity, CEIPHBPAHMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B0F")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC600", Offset = "0x5EAB400", VA = "0x185EAC600")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B10")]
	[Cpp2IlInjected.Address(RVA = "0x5EACDE0", Offset = "0x5EABBE0", VA = "0x185EACDE0")]
	private bool NJEDLLKBOFE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000211")]
[LKMFAIPHKDB(typeof(FALPINKOHJI), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal class FALPINKOHJI : IJCLFGAEMDL, FKNGAHGHIJP, JKPKLADFGOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000212")]
	internal readonly struct OFKBFGENONC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private readonly CIDKNADIFBP NDNOOCOFBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private readonly FALPINKOHJI KCDMGGDCPJH;

		[Cpp2IlInjected.Token(Token = "0x6000B2A")]
		[Cpp2IlInjected.Address(RVA = "0x5EBFA80", Offset = "0x5EBE880", VA = "0x185EBFA80")]
		public OFKBFGENONC(FALPINKOHJI KCDMGGDCPJH, CIDKNADIFBP PFPHDBMCMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B2B")]
		[Cpp2IlInjected.Address(RVA = "0x5EBFA60", Offset = "0x5EBE860", VA = "0x185EBFA60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000680")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private static readonly GKFGDEJLFAD FPGOCJOJKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	[MBPNJDODNHC]
	private IHJBEAAMNEB IGNGKFHFNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	[MBPNJDODNHC]
	private LHACECFODGE LJJOHJIGONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000685")]
	private readonly GHACJPKLCDE[] LKPNHDDFNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000686")]
	private FAOMFNKBCCM KFABJAFELAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000687")]
	private NativeParallelHashMap<int, Entity> GEAHAHPJBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000688")]
	private CIDKNADIFBP JIPIAJGELHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000689")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public World IIPPIBCPIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B12")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9870", Offset = "0x5EA8670", VA = "0x185EA9870", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public World LLDCDMOFHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B13")]
		[Cpp2IlInjected.Address(RVA = "0x76FD10", Offset = "0x76EB10", VA = "0x18076FD10", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000B14")]
		[Cpp2IlInjected.Address(RVA = "0x76FC10", Offset = "0x76EA10", VA = "0x18076FC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public FAOMFNKBCCM IKFKDDIPNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B15")]
		[Cpp2IlInjected.Address(RVA = "0x1FD0970", Offset = "0x1FCF770", VA = "0x181FD0970", Slot = "8")]
		get
		{
			return default(FAOMFNKBCCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public uint DLKOOFAOEBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000B16")]
		[Cpp2IlInjected.Address(RVA = "0xCE92E0", Offset = "0xCE80E0", VA = "0x180CE92E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B17")]
		[Cpp2IlInjected.Address(RVA = "0xCE9B90", Offset = "0xCE8990", VA = "0x180CE9B90", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	private bool BAGBPDCOMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000B18")]
		[Cpp2IlInjected.Address(RVA = "0x9AA140", Offset = "0x9A8F40", VA = "0x1809AA140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B19")]
		[Cpp2IlInjected.Address(RVA = "0xCD3490", Offset = "0xCD2290", VA = "0x180CD3490", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public NativeParallelHashMap<int, Entity> FLAFEACOJBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B1A")]
		[Cpp2IlInjected.Address(RVA = "0x4646A80", Offset = "0x4645880", VA = "0x184646A80")]
		get
		{
			return default(NativeParallelHashMap<int, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public NHNJJHDMCBN PMJOENNHBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B1D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA97E0", Offset = "0x5EA85E0", VA = "0x185EA97E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public CDPGLFJJDKD LPMHCPBHJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000B1E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA97E0", Offset = "0x5EA85E0", VA = "0x185EA97E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public CIDKNADIFBP IGABJCNMKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B1F")]
		[Cpp2IlInjected.Address(RVA = "0x955D50", Offset = "0x954B50", VA = "0x180955D50")]
		get
		{
			return default(CIDKNADIFBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1B")]
	[Cpp2IlInjected.Address(RVA = "0x1B5BA10", Offset = "0x1B5A810", VA = "0x181B5BA10")]
	public NHNJJHDMCBN CCDJFBOJIPJ(CIDKNADIFBP FAKOLMHKKAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B1C")]
	[Cpp2IlInjected.Address(RVA = "0x1B5BA10", Offset = "0x1B5A810", VA = "0x181B5BA10")]
	public CDPGLFJJDKD GDPCALMJDLP(CIDKNADIFBP FAKOLMHKKAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B20")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9AD0", Offset = "0x5EA88D0", VA = "0x185EA9AD0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B21")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9BA0", Offset = "0x5EA89A0", VA = "0x185EA9BA0", Slot = "5")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B22")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9DF0", Offset = "0x5EA8BF0", VA = "0x185EA9DF0")]
	private NativeParallelHashMap<int, Entity> MIIBKDOLHDF()
	{
		return default(NativeParallelHashMap<int, Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B23")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA070", Offset = "0x5EA8E70", VA = "0x185EAA070")]
	public void PJHBDJHNFOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B24")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9A90", Offset = "0x5EA8890", VA = "0x185EA9A90")]
	public void EOCKAINKMIG(CIDKNADIFBP FAKOLMHKKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B25")]
	[Cpp2IlInjected.Address(RVA = "0x5EA99D0", Offset = "0x5EA87D0", VA = "0x185EA99D0")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B26")]
	[Cpp2IlInjected.Address(RVA = "0x5EA98C0", Offset = "0x5EA86C0", VA = "0x185EA98C0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B27")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9810", Offset = "0x5EA8610", VA = "0x185EA9810")]
	public OFKBFGENONC CLIJKAKDGFL(CIDKNADIFBP FAKOLMHKKAI)
	{
		return default(OFKBFGENONC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B28")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA180", Offset = "0x5EA8F80", VA = "0x185EAA180")]
	public FALPINKOHJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000213")]
[LKMFAIPHKDB(typeof(OPNGBJLAHIJ), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal class OPNGBJLAHIJ : IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400068F")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000690")]
	public static readonly SceneTag GPCCDHCMIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000691")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000692")]
	[MBPNJDODNHC]
	private ODLGBANKCLJ IFKLIOOADDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000693")]
	[MBPNJDODNHC]
	private GNJPLCKBNJA MENCLGMKPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000694")]
	[MBPNJDODNHC]
	private FCKMNLHDJPO DOBOMMPHLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000695")]
	[MBPNJDODNHC]
	private LGMAMHNDHAH MHNAACPKPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000696")]
	[MBPNJDODNHC]
	private IKKGFPCGDPJ KBDODPJHAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000697")]
	private EntityQuery MHHIKDHCGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000698")]
	private EntityQuery LAIEAODCPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000699")]
	private EntityQuery ANJNBHABIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400069A")]
	private Entity FHOFBJDFPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400069B")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public NativeArray<Entity> HABEHCIDCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2C")]
		[Cpp2IlInjected.Address(RVA = "0xBD2130", Offset = "0xBD0F30", VA = "0x180BD2130")]
		[CompilerGenerated]
		get
		{
			return default(NativeArray<Entity>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B2D")]
		[Cpp2IlInjected.Address(RVA = "0xBD0DD0", Offset = "0xBCFBD0", VA = "0x180BD0DD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public Entity LNPDEEGEMCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0250", Offset = "0x5EBF050", VA = "0x185EC0250")]
		get
		{
			return default(Entity);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public SceneTag MIKMONHHMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000B2F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0200", Offset = "0x5EBF000", VA = "0x185EC0200")]
		get
		{
			return default(SceneTag);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public Entity LKLGGDADFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000B30")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0200", Offset = "0x5EBF000", VA = "0x185EC0200")]
		get
		{
			return default(Entity);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B31")]
		[Cpp2IlInjected.Address(RVA = "0x5EC16C0", Offset = "0x5EC04C0", VA = "0x185EC16C0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	private EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B32")]
		[Cpp2IlInjected.Address(RVA = "0x5EC0360", Offset = "0x5EBF160", VA = "0x185EC0360")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B33")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1250", Offset = "0x5EC0050", VA = "0x185EC1250", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B34")]
	[Cpp2IlInjected.Address(RVA = "0x5EC04F0", Offset = "0x5EBF2F0", VA = "0x185EC04F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B35")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0ED0", Offset = "0x5EBFCD0", VA = "0x185EC0ED0")]
	public void GLLCPDLJJPB(Entity CCHOHIEEHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B36")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1540", Offset = "0x5EC0340", VA = "0x185EC1540")]
	public NativeArray<Entity> KAMAOMFAEHD(Allocator JFLEKJGGDHL = Allocator.TempJob)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B37")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1570", Offset = "0x5EC0370", VA = "0x185EC1570")]
	public void MBMBJMFOJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B38")]
	[Cpp2IlInjected.Address(RVA = "0x5EC03D0", Offset = "0x5EBF1D0", VA = "0x185EC03D0")]
	public void DDHODININJG(Entity PIOKEHOJBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B39")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1350", Offset = "0x5EC0150", VA = "0x185EC1350")]
	public Entity JDGLKJPHEBE(string ONIBECKLJDD = "")
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC03B0", Offset = "0x5EBF1B0", VA = "0x185EC03B0")]
	public void CLDDHLNONIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1820", Offset = "0x5EC0620", VA = "0x185EC1820")]
	public void NCKPNILIODL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3C")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	public void ODNLDGGMPNN(Entity PIOKEHOJBEJ, string ONIBECKLJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0920", Offset = "0x5EBF720", VA = "0x185EC0920")]
	public void GAJIKIKGGJL(Entity PIOKEHOJBEJ, bool ECHDBNFCLBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0CA0", Offset = "0x5EBFAA0", VA = "0x185EC0CA0")]
	public void GJDPJHPMMMF(Entity CCHOHIEEHEH, Entity PIOKEHOJBEJ, bool LCCEJHKIICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B3F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0A70", Offset = "0x5EBF870", VA = "0x185EC0A70")]
	public void GJDPJHPMMMF(NativeArray<Entity> PFOPLIKJCHB, Entity PIOKEHOJBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B40")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0F10", Offset = "0x5EBFD10", VA = "0x185EC0F10")]
	private void HHMNDMPPDBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B41")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1690", Offset = "0x5EC0490", VA = "0x185EC1690")]
	private void MKEKDHDKIAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B42")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0250", Offset = "0x5EBF050", VA = "0x185EC0250")]
	private Entity CCAAFDDADFO()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B43")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0840", Offset = "0x5EBF640", VA = "0x185EC0840")]
	private void FFIKKCDFGJK(EntityQuery GNFFKDPMJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B44")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0570", Offset = "0x5EBF370", VA = "0x185EC0570")]
	private void FFIKKCDFGJK(NativeArray<Entity> JOEFEJIMKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B45")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1730", Offset = "0x5EC0530", VA = "0x185EC1730")]
	private void NCJHMEHMOOA(Entity PIOKEHOJBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B46")]
	[Cpp2IlInjected.Address(RVA = "0x5EC15C0", Offset = "0x5EC03C0", VA = "0x185EC15C0")]
	private void MEHADBKEBIK(Entity PIOKEHOJBEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B47")]
	[Cpp2IlInjected.Address(RVA = "0x5EC10D0", Offset = "0x5EBFED0", VA = "0x185EC10D0")]
	private void ILJNKPKJKJA(SceneTag FPKFDLHKCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B48")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0530", Offset = "0x5EBF330", VA = "0x185EC0530")]
	private void EPIMGIKNHKP(SceneTag FPKFDLHKCKM, NativeParallelHashSet<int> BCIMDALNOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B49")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1400", Offset = "0x5EC0200", VA = "0x185EC1400")]
	private void JFBCLAAOGOC(SceneTag FPKFDLHKCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1840", Offset = "0x5EC0640", VA = "0x185EC1840")]
	private void PAGLPDLFHPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4B")]
	[Cpp2IlInjected.Address(RVA = "0x24FDB30", Offset = "0x24FC930", VA = "0x1824FDB30")]
	private void JPPHMCMMMJM<T>() where T : ComponentSystemBase
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4C")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public OPNGBJLAHIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000214")]
[LKMFAIPHKDB(typeof(OHEAJDCELJE), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.PhotonRoom)]
internal class PAJCLOIDIBL : IJCLFGAEMDL, OHEAJDCELJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	[MBPNJDODNHC]
	private OPNGBJLAHIJ JOEFEJIMKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private readonly Dictionary<int, Entity> BHNIFGADBDJ;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	private EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B4E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC1980", Offset = "0x5EC0780", VA = "0x185EC1980")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B4F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1CF0", Offset = "0x5EC0AF0", VA = "0x185EC1CF0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B50")]
	[Cpp2IlInjected.Address(RVA = "0x5EC19D0", Offset = "0x5EC07D0", VA = "0x185EC19D0", Slot = "5")]
	public void GLLCPDLJJPB(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B51")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1B20", Offset = "0x5EC0920", VA = "0x185EC1B20", Slot = "6")]
	public bool HIKELNOMGDD(JBMJEBCFLLB OGPPAJOCABK, Transform GNLAIPIBJPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B52")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1D80", Offset = "0x5EC0B80", VA = "0x185EC1D80")]
	private bool NAODOJCHGOL(Scene PIOKEHOJBEJ, [Out] Entity FLLDOBGDPCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B53")]
	[Cpp2IlInjected.Address(RVA = "0x5EC1DF0", Offset = "0x5EC0BF0", VA = "0x185EC1DF0")]
	public PAJCLOIDIBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000215")]
[LKMFAIPHKDB(typeof(LGMAMHNDHAH), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal sealed class LGMAMHNDHAH : IJCLFGAEMDL, FKNGAHGHIJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006A0")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A1")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	[MBPNJDODNHC]
	private FCKMNLHDJPO DOBOMMPHLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private Entity CCHOHIEEHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006A4")]
	private ComponentTypeList IAEGOGAHMLB;

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x5EB75E0", Offset = "0x5EB63E0", VA = "0x185EB75E0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B55")]
	[Cpp2IlInjected.Address(RVA = "0x240A6A0", Offset = "0x24094A0", VA = "0x18240A6A0")]
	public T OMJIHOMPBMI<T>() where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B56")]
	[Cpp2IlInjected.Address(RVA = "0x240A580", Offset = "0x2409380", VA = "0x18240A580")]
	public void KLJMIKDFPBF<T>(T GNLEHBFFNFG) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B57")]
	[Cpp2IlInjected.Address(RVA = "0x240A2B0", Offset = "0x24090B0", VA = "0x18240A2B0")]
	public DynamicBuffer<T> BOHCMJDGGDC<T>(bool PFJGIECBADF = false) where T : struct, IBufferElementData
	{
		return default(DynamicBuffer<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B58")]
	[Cpp2IlInjected.Address(RVA = "0x240A410", Offset = "0x2409210", VA = "0x18240A410")]
	public void DDFBBMAKMCB<T>(T GNLEHBFFNFG) where T : struct, IBufferElementData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B59")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7C80", Offset = "0x5EB6A80", VA = "0x185EB7C80", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5A")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7630", Offset = "0x5EB6430", VA = "0x185EB7630", Slot = "5")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5B")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7630", Offset = "0x5EB6430", VA = "0x185EB7630")]
	private void CKCLEHLKMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5C")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7820", Offset = "0x5EB6620", VA = "0x185EB7820", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5D")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7CF0", Offset = "0x5EB6AF0", VA = "0x185EB7CF0")]
	private ComponentTypeList KCOIGGOIPEM()
	{
		return default(ComponentTypeList);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5E")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void KDNBGFCKJKP(int HLFCMANHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B5F")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void DDGKJHKOJAO(Type PEMNIEMPPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B60")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7B80", Offset = "0x5EB6980", VA = "0x185EB7B80")]
	private static void HCHNDFDAIMD(Type PEMNIEMPPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B61")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LGMAMHNDHAH()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000216")]
[BBGAKOBIAGC]
internal struct MDOHPDHOGOO : ISystemStateComponentData, IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x2000217")]
[LKMFAIPHKDB(typeof(CGGDHOPMPPP), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal sealed class CGGDHOPMPPP : IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006A5")]
	private static readonly GKFGDEJLFAD PKALLLKAOEM;

	[Cpp2IlInjected.Token(Token = "0x40006A6")]
	private static readonly GKFGDEJLFAD LAFKCKHDCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A7")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A8")]
	private FOOOBLMDMNH<AMJJEAJMPPH, Entity> EOANAAJMIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006A9")]
	private DCCBDAOFFHB<KODMMNPPJII> EOOIKAJGFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006AA")]
	private DCCBDAOFFHB<OHHMNJBHJAJ> DIIPIGIGAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006AB")]
	private DCCBDAOFFHB<EPHGHPLLHCD> CDDLDKJFFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private DCCBDAOFFHB<CPEJNFIIIMM> LBNGJMFFBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private DCCBDAOFFHB<ABKCBBPHCGA> NPHELGDJFPC;

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public CHMOADEILFB<Entity> OIFENAIBBEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000B63")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public OJMBFAMANPH OEJDOEJCIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public OJMBFAMANPH CBCCNNLLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x768580", Offset = "0x767380", VA = "0x180768580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public OJMBFAMANPH FIINFACICGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0x765900", Offset = "0x764700", VA = "0x180765900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public OJMBFAMANPH EGKPHJEOANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000B67")]
		[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public OJMBFAMANPH DINDDEAMLOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B68")]
		[Cpp2IlInjected.Address(RVA = "0x768550", Offset = "0x767350", VA = "0x180768550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	private EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6460", Offset = "0x5EA5260", VA = "0x185EA6460")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA65A0", Offset = "0x5EA53A0", VA = "0x185EA65A0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA64B0", Offset = "0x5EA52B0", VA = "0x185EA64B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6C")]
	[Cpp2IlInjected.Address(RVA = "0x21CBE40", Offset = "0x21CAC40", VA = "0x1821CBE40")]
	private void PCPNMJLBOGM<T>(DCCBDAOFFHB<T> GHECIKKJJFO, EntityCommandBufferSystem NGLMJAHNOHO, GKFGDEJLFAD CGHEBMJOFGL) where T : struct, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6D")]
	[Cpp2IlInjected.Address(RVA = "0x21CBEF0", Offset = "0x21CACF0", VA = "0x1821CBEF0")]
	private void PCPNMJLBOGM<TC, TV>(FOOOBLMDMNH<TC, TV> GHECIKKJJFO) where TC : struct, JECAHKJAFHM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B6E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public CGGDHOPMPPP()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000218")]
public struct OHHMNJBHJAJ : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000219")]
public struct KODMMNPPJII : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200021A")]
public struct EPHGHPLLHCD : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200021B")]
public struct CPEJNFIIIMM : IComponentData
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200021C")]
public struct ABKCBBPHCGA : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x200021D")]
[ExecuteAlways]
public class NGMHAEHFNJO : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000B70")]
	[Cpp2IlInjected.Address(RVA = "0x772100", Offset = "0x770F00", VA = "0x180772100")]
	public NGMHAEHFNJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021E")]
[LKMFAIPHKDB(typeof(ANNHLNEFMPH), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal sealed class ANNHLNEFMPH : POKGICLLPAE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	private GHKCPNCBNDO FJHBJHPEOBB;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public GHKCPNCBNDO HHHAEEJBIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000B71")]
		[Cpp2IlInjected.Address(RVA = "0x1BD03E0", Offset = "0x1BCF1E0", VA = "0x181BD03E0")]
		get
		{
			return default(GHKCPNCBNDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B72")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3D50", Offset = "0x5EA2B50", VA = "0x185EA3D50", Slot = "4")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B73")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3DA0", Offset = "0x5EA2BA0", VA = "0x185EA3DA0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B74")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public ANNHLNEFMPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200021F")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(IOPAEIMLPMI), new string[] { })]
internal sealed class IOPAEIMLPMI
{
	[Cpp2IlInjected.Token(Token = "0x2000220")]
	public enum OHJFLKECPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		Gameplay,
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		ObjectModel
	}

	[Cpp2IlInjected.Token(Token = "0x2000221")]
	public struct HFFFJACNGAC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private OHJFLKECPDJ JEKOEJKKJOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private readonly IOPAEIMLPMI LBLLNFOEKNE;

		[Cpp2IlInjected.Token(Token = "0x6000B7C")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3670", Offset = "0x5EB2470", VA = "0x185EB3670")]
		public HFFFJACNGAC(IOPAEIMLPMI LBLLNFOEKNE, OHJFLKECPDJ FAKOLMHKKAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B7D")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3650", Offset = "0x5EB2450", VA = "0x185EB3650", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006AF")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B0")]
	public OHJFLKECPDJ FAKOLMHKKAI;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public OHJFLKECPDJ IGABJCNMKHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000B75")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75FF80", VA = "0x180761180")]
		get
		{
			return default(OHJFLKECPDJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000B76")]
		[Cpp2IlInjected.Address(RVA = "0x761610", Offset = "0x760410", VA = "0x180761610")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public bool AFGKKDHKMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000B77")]
		[Cpp2IlInjected.Address(RVA = "0x4FB75B0", Offset = "0x4FB63B0", VA = "0x184FB75B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000B78")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5D50", Offset = "0x5EB4B50", VA = "0x185EB5D50")]
	public HFFFJACNGAC CKAGENPHLBC()
	{
		return default(HFFFJACNGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B79")]
	[Cpp2IlInjected.Address(RVA = "0x5EB5DA0", Offset = "0x5EB4BA0", VA = "0x185EB5DA0")]
	public HFFFJACNGAC DEHJEEABBEI()
	{
		return default(HFFFJACNGAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7A")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IOPAEIMLPMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000222")]
[LKMFAIPHKDB(typeof(FBHFKMFDFBO), new string[] { })]
internal class COFKLFANJII : FBHFKMFDFBO, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B6")]
	[MBPNJDODNHC]
	private INAOLEEONGL GDJHDOEIOBN;

	[Cpp2IlInjected.Token(Token = "0x6000B7E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7150", Offset = "0x5EA5F50", VA = "0x185EA7150", Slot = "8")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B7F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7040", Offset = "0x5EA5E40", VA = "0x185EA7040", Slot = "4")]
	public World IAIGAEKPMDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B80")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6FA0", Offset = "0x5EA5DA0", VA = "0x185EA6FA0", Slot = "5")]
	public World EDBLOGHGOMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B81")]
	[Cpp2IlInjected.Address(RVA = "0x5EA71A0", Offset = "0x5EA5FA0", VA = "0x185EA71A0", Slot = "6")]
	public World JGIBLONFDHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B82")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6F00", Offset = "0x5EA5D00", VA = "0x185EA6F00", Slot = "7")]
	public World AEFNDMAOHAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B83")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7240", Offset = "0x5EA6040", VA = "0x185EA7240")]
	private World MCMPLNJPIGJ(string ONIBECKLJDD, PFMJKAHLNBE LCCBIJEOFHP, Type MJFCJMCEPBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B84")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public COFKLFANJII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000223")]
[LKMFAIPHKDB(typeof(PNFCPLLCHJK), new string[] { })]
public class MIMCKIPLFNA : IJCLFGAEMDL, PNFCPLLCHJK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000224")]
	[CompilerGenerated]
	private struct MJGBGLCOANL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public JBMJEBCFLLB parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public MIMCKIPLFNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public KJEDHMGGDOO objBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private ECLMNCPCDJH <parentObject>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x5EBDEB0", Offset = "0x5EBCCB0", VA = "0x185EBDEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x5EBE3F0", Offset = "0x5EBD1F0", VA = "0x185EBE3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000225")]
	[CompilerGenerated]
	private struct NHAKLAEDJAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public MIMCKIPLFNA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public ECLMNCPCDJH obj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF3A0", Offset = "0x5EBE1A0", VA = "0x185EBF3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x5EBF7E0", Offset = "0x5EBE5E0", VA = "0x185EBF7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	[MBPNJDODNHC]
	private HEBAFELDAAJ EILPDJCOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	private EntityManager FMCNCDMBJDH;

	[Cpp2IlInjected.Token(Token = "0x6000B85")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD510", Offset = "0x5EBC310", VA = "0x185EBD510", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B86")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD450", Offset = "0x5EBC250", VA = "0x185EBD450", Slot = "5")]
	public bool IHKKIGALKIE(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B87")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDC50", Offset = "0x5EBCA50", VA = "0x185EBDC50", Slot = "7")]
	public bool NHIBNJLLPFN(JBMJEBCFLLB OGPPAJOCABK, [Out] Guid JLBBMGLDMCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B88")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDB90", Offset = "0x5EBC990", VA = "0x185EBDB90", Slot = "8")]
	public Guid MOOIMHLEIJE(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B89")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD1F0", Offset = "0x5EBBFF0", VA = "0x185EBD1F0", Slot = "9")]
	public void FGAMPHDBOOH(JBMJEBCFLLB OGPPAJOCABK, Guid JLBBMGLDMCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8A")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD790", Offset = "0x5EBC590", VA = "0x185EBD790", Slot = "10")]
	public bool KKIKEPLPJBP(JBMJEBCFLLB OGPPAJOCABK, [Out] Guid HPBOKIMIODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8B")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD930", Offset = "0x5EBC730", VA = "0x185EBD930", Slot = "11")]
	public Guid LOJCBFMKOCH(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD5B0", Offset = "0x5EBC3B0", VA = "0x185EBD5B0", Slot = "12")]
	public void JLFJOPFBMPN(JBMJEBCFLLB OGPPAJOCABK, Guid HPBOKIMIODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCCF0", Offset = "0x5EBBAF0", VA = "0x185EBCCF0", Slot = "13")]
	public void AAIKOHIJOHH(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8E")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCE80", Offset = "0x5EBBC80", VA = "0x185EBCE80", Slot = "14")]
	public void EIHGJKNDEFI(JBMJEBCFLLB CJKEIGLKDDB, JBMJEBCFLLB LBLLNFOEKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B8F")]
	[Cpp2IlInjected.Address(RVA = "0x5EBDD10", Offset = "0x5EBCB10", VA = "0x185EBDD10")]
	[AsyncStateMachine(typeof(MJGBGLCOANL))]
	private Task OKNJLFHOBIG(KJEDHMGGDOO CCFPECMLFDF, JBMJEBCFLLB LBLLNFOEKNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B90")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD9F0", Offset = "0x5EBC7F0", VA = "0x185EBD9F0")]
	private void MNIHPMMMGAH(KJEDHMGGDOO CCFPECMLFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B91")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD850", Offset = "0x5EBC650", VA = "0x185EBD850")]
	[AsyncStateMachine(typeof(NHAKLAEDJAM))]
	private Task LFMBKGIPAEH(ECLMNCPCDJH HBDENJGMDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B92")]
	[Cpp2IlInjected.Address(RVA = "0x5EBCD80", Offset = "0x5EBBB80", VA = "0x185EBCD80")]
	private Task BAFCHGDADEH(ECLMNCPCDJH HBDENJGMDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000B93")]
	[Cpp2IlInjected.Address(RVA = "0x5EBD3D0", Offset = "0x5EBC1D0", VA = "0x185EBD3D0", Slot = "6")]
	public bool HNCCOEIJFOE(JBMJEBCFLLB HAIBOLAMIBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B94")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public MIMCKIPLFNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000226")]
[LKMFAIPHKDB(typeof(BFIMJCIFCBA), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public class BFIMJCIFCBA : IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C8")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	[MBPNJDODNHC]
	private IHJBEAAMNEB IGNGKFHFNKM;

	[Cpp2IlInjected.Token(Token = "0x6000B9A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA59B0", Offset = "0x5EA47B0", VA = "0x185EA59B0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9B")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BFIMJCIFCBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000227")]
[LKMFAIPHKDB(typeof(APCELKGPEPM), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
internal sealed class APCELKGPEPM : IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006CB")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CC")]
	[MBPNJDODNHC]
	private BOMPJJILJFM HKJBAEEPEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006CD")]
	[MBPNJDODNHC]
	private MHGJLNHJKDD DHJDOAHLJJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006CE")]
	[MBPNJDODNHC]
	private KOHELDMJMKP BGNKJBDOIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006CF")]
	[MBPNJDODNHC]
	private LHACECFODGE LJJOHJIGONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006D0")]
	[MBPNJDODNHC]
	private EGHONEJJMPI BGLGGIPOFNF;

	[Cpp2IlInjected.Token(Token = "0x6000B9C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA51D0", Offset = "0x5EA3FD0", VA = "0x185EA51D0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5730", Offset = "0x5EA4530", VA = "0x185EA5730")]
	public void PDJBMEBOODM(NativeArray<FMJMJJHCMAN> CKFMLBNEDOK, NativeArray<DJMPNJEFEHC> OEHBGDNEBEK, NativeArray<Entity> BIJMENJNFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5770", Offset = "0x5EA4570", VA = "0x185EA5770")]
	public Entity PDJBMEBOODM(FMJMJJHCMAN CMNEDOHOKIA, DJMPNJEFEHC IELEJBMANDO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000B9F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4E40", Offset = "0x5EA3C40", VA = "0x185EA4E40")]
	public Entity LOLHPIIPICI(FMJMJJHCMAN CMNEDOHOKIA, bool EFMKMAPHEAG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA0")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4E00", Offset = "0x5EA3C00", VA = "0x185EA4E00")]
	public Entity LOLHPIIPICI(FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA1")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5570", Offset = "0x5EA4370", VA = "0x185EA5570")]
	public Entity LLPIPGIIHHE()
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA2")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4D70", Offset = "0x5EA3B70", VA = "0x185EA4D70")]
	public Entity AHMFCFGLLII(NJGEKDIELMJ PEMNIEMPPLO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA3")]
	[Cpp2IlInjected.Address(RVA = "0x5EA56D0", Offset = "0x5EA44D0", VA = "0x185EA56D0")]
	public EOLLFEKBMDA NKCHKCJIHIJ(EOLLFEKBMDA GCHHFEIHBEL, Allocator JFLEKJGGDHL)
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5020", Offset = "0x5EA3E20", VA = "0x185EA5020")]
	public EntityArchetype EBKDNDOHKDL(FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA5")]
	[Cpp2IlInjected.Address(RVA = "0x5EA50A0", Offset = "0x5EA3EA0", VA = "0x185EA50A0")]
	public Entity GBGNNNGDFPA(FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA6")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4E40", Offset = "0x5EA3C40", VA = "0x185EA4E40")]
	private Entity CAKIGHKJFGJ(FMJMJJHCMAN CMNEDOHOKIA, bool EFMKMAPHEAG)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA7")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4E00", Offset = "0x5EA3C00", VA = "0x185EA4E00")]
	private Entity CAKIGHKJFGJ(FMJMJJHCMAN CMNEDOHOKIA)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA8")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4E90", Offset = "0x5EA3C90", VA = "0x185EA4E90")]
	private Entity CAKIGHKJFGJ(FMJMJJHCMAN CMNEDOHOKIA, DJMPNJEFEHC IELEJBMANDO)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BA9")]
	[Cpp2IlInjected.Address(RVA = "0x5EA55B0", Offset = "0x5EA43B0", VA = "0x185EA55B0")]
	private void MJJHHKCBPGG(FMJMJJHCMAN CMNEDOHOKIA, NativeArray<DJMPNJEFEHC> OEHBGDNEBEK, NativeArray<Entity> BIJMENJNFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA52C0", Offset = "0x5EA40C0", VA = "0x185EA52C0")]
	private void KKPFLAJCCGH(NativeArray<FMJMJJHCMAN> CKFMLBNEDOK, NativeArray<DJMPNJEFEHC> OEHBGDNEBEK, NativeArray<Entity> BIJMENJNFDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BAB")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public APCELKGPEPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000228")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(KOHELDMJMKP), new string[] { })]
internal sealed class KOHELDMJMKP : IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006D1")]
	public static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006D2")]
	[MBPNJDODNHC]
	private HBMBNCJMDAI CFIOKNDAAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006D3")]
	[MBPNJDODNHC]
	private BOMPJJILJFM LEBFOELNIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006D4")]
	[MBPNJDODNHC]
	private MHGJLNHJKDD OPGDJOOAJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006D5")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006D6")]
	private NativeParallelHashMap<DJMPNJEFEHC, Entity> OCOOEJAFFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006D7")]
	private EntityManager FMCNCDMBJDH;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	internal NativeParallelHashMap<DJMPNJEFEHC, Entity> HBKEKGILMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAD")]
		[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5E260", VA = "0x180D5F460")]
		get
		{
			return default(NativeParallelHashMap<DJMPNJEFEHC, Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	internal uint MCJJKAIIDDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAE")]
		[Cpp2IlInjected.Address(RVA = "0x5EB7160", Offset = "0x5EB5F60", VA = "0x185EB7160")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	private bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000BAF")]
		[Cpp2IlInjected.Address(RVA = "0x849470", Offset = "0x848270", VA = "0x180849470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7190", Offset = "0x5EB5F90", VA = "0x185EB7190", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB1")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6BF0", Offset = "0x5EB59F0", VA = "0x185EB6BF0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6C60", Offset = "0x5EB5A60", VA = "0x185EB6C60")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6E20", Offset = "0x5EB5C20", VA = "0x185EB6E20")]
	public DJMPNJEFEHC GIJAMCPDPAN(int HLFCMANHPKF)
	{
		return default(DJMPNJEFEHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB4")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6A30", Offset = "0x5EB5830", VA = "0x185EB6A30")]
	public void BGDDOKMEPFB(DJMPNJEFEHC IELEJBMANDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB5")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6EF0", Offset = "0x5EB5CF0", VA = "0x185EB6EF0")]
	public JBMJEBCFLLB IAMCBICJENG(DJMPNJEFEHC IELEJBMANDO)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB6")]
	[Cpp2IlInjected.Address(RVA = "0x5EB72B0", Offset = "0x5EB60B0", VA = "0x185EB72B0")]
	public bool JIAOCCHKBED(DJMPNJEFEHC IELEJBMANDO, [Out] JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB7")]
	[Cpp2IlInjected.Address(RVA = "0x5EB7030", Offset = "0x5EB5E30", VA = "0x185EB7030")]
	public EOLLFEKBMDA IAMCBICJENG(NativeArray<DJMPNJEFEHC> IELEJBMANDO, Allocator JFLEKJGGDHL)
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB8")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6CE0", Offset = "0x5EB5AE0", VA = "0x185EB6CE0")]
	public DJMPNJEFEHC FKGNNMHAONN(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(DJMPNJEFEHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BB9")]
	[Cpp2IlInjected.Address(RVA = "0x5EB6D90", Offset = "0x5EB5B90", VA = "0x185EB6D90")]
	public DJMPNJEFEHC FKGNNMHAONN(Entity CCHOHIEEHEH)
	{
		return default(DJMPNJEFEHC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB73F0", Offset = "0x5EB61F0", VA = "0x185EB73F0")]
	public void PCINBOPDPMO(NativeArray<Entity> PFOPLIKJCHB, NativeArray<DJMPNJEFEHC> OEHBGDNEBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBB")]
	[Cpp2IlInjected.Address(RVA = "0x5EB73B0", Offset = "0x5EB61B0", VA = "0x185EB73B0")]
	private JBMJEBCFLLB OFMNGHJEOGI(Entity CCHOHIEEHEH)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBC")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public KOHELDMJMKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000229")]
[LKMFAIPHKDB(typeof(EPMCOHFCLHA), new string[] { })]
public sealed class HMGEGPIGKGA : EPMCOHFCLHA, BODAMAGMDOF, POKGICLLPAE, IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006D9")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DA")]
	[MBPNJDODNHC]
	private EPCLCPFGOIL IGBHKFPEPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private Collider[] PGPBOCIHBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private RaycastHit[] JEKLDINPFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private DAMCLELNJPB<LGJKCIBNPJM, BoxCollider> IFPBCDCBNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private Scene PIOKEHOJBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private PhysicsScene BBLPFJDGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private GameObject MCMNAIINBFO;

	[Cpp2IlInjected.Token(Token = "0x6000BBE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3D40", Offset = "0x5EB2B40", VA = "0x185EB3D40", Slot = "9")]
	public void BEGCIGPPLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BBF")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4920", Offset = "0x5EB3720", VA = "0x185EB4920", Slot = "10")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4590", Offset = "0x5EB3390", VA = "0x185EB4590", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC1")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4B10", Offset = "0x5EB3910", VA = "0x185EB4B10", Slot = "4")]
	public LGJKCIBNPJM MLPIPIIKNNF(Entity CCHOHIEEHEH)
	{
		return default(LGJKCIBNPJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC2")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4D40", Offset = "0x5EB3B40", VA = "0x185EB4D40", Slot = "5")]
	public void POCAKCKGKCJ(NativeArray<LGJKCIBNPJM> OBGOLLJIMAP, NativeArray<KIFLAPEGCAF> PBNGHKJFNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC3")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4C50", Offset = "0x5EB3A50", VA = "0x185EB4C50", Slot = "6")]
	public void OJAIKMBNFHA(LGJKCIBNPJM KMOBDGPHBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC4")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4730", Offset = "0x5EB3530", VA = "0x185EB4730", Slot = "7")]
	public bool HNIFBNKHJIE(LGJKCIBNPJM KMOBDGPHBOK, [Out] Collider BHBBEPIOBCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC5")]
	[Cpp2IlInjected.Address(RVA = "0x5EB40B0", Offset = "0x5EB2EB0", VA = "0x185EB40B0")]
	public bool CLAGLDDIBEG([In] float3 JLBMPBJBLDH, [In] float3 IELHLOGPMDL, float NGLNDDJFMFL, Allocator JFLEKJGGDHL, [Out] NativeArray<Entity> PFOPLIKJCHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC6")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4390", Offset = "0x5EB3190", VA = "0x185EB4390")]
	private void DENFHOPDDCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC7")]
	[Cpp2IlInjected.Address(RVA = "0xD4CC60", Offset = "0xD4BA60", VA = "0x180D4CC60")]
	private void DDGPGOCBBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC8")]
	[Cpp2IlInjected.Address(RVA = "0x5EB47D0", Offset = "0x5EB35D0", VA = "0x185EB47D0")]
	private void IFCCLHKJGLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BC9")]
	[Cpp2IlInjected.Address(RVA = "0x84B4C0", Offset = "0x84A2C0", VA = "0x18084B4C0")]
	private void EPOMOHKNEAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCA")]
	[Cpp2IlInjected.Address(RVA = "0x5EB49F0", Offset = "0x5EB37F0", VA = "0x185EB49F0")]
	private BoxCollider JMMDAJKPAEK(Entity CCHOHIEEHEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCB")]
	[Cpp2IlInjected.Address(RVA = "0x5EB46A0", Offset = "0x5EB34A0", VA = "0x185EB46A0")]
	private void EGOGCMPOLEP(BoxCollider OAGFNOLDAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCC")]
	[Cpp2IlInjected.Address(RVA = "0x5EB43E0", Offset = "0x5EB31E0", VA = "0x185EB43E0")]
	private void DKGGCMMMIKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCD")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4820", Offset = "0x5EB3620", VA = "0x185EB4820")]
	private void IMKFIMDIGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCE")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3EA0", Offset = "0x5EB2CA0", VA = "0x185EB3EA0")]
	private void BHPDAHILCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCF")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4D10", Offset = "0x5EB3B10", VA = "0x185EB4D10")]
	private void OJKLBBIJDBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD0")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4B00", Offset = "0x5EB3900", VA = "0x185EB4B00")]
	private void MKJGKBCMDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD1")]
	[Cpp2IlInjected.Address(RVA = "0x5EB3D00", Offset = "0x5EB2B00", VA = "0x185EB3D00")]
	private void ADCLBLNPKDP(Scene HFICFMOHIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD2")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public HMGEGPIGKGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD4")]
	[Cpp2IlInjected.Address(RVA = "0x5EB4720", Offset = "0x5EB3520", VA = "0x185EB4720", Slot = "8")]
	private bool EMGBLMALAJP([In] float3 JLBMPBJBLDH, [In] float3 IELHLOGPMDL, float NGLNDDJFMFL, Allocator JFLEKJGGDHL, [Out] NativeArray<Entity> PFOPLIKJCHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200022A")]
[GPOCAEGADIM(typeof(HMLNPAANDIJ))]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[LKMFAIPHKDB(typeof(BLNCLHPGCCL), new string[] { })]
internal class BLNCLHPGCCL : IJCLFGAEMDL, HMLNPAANDIJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006E3")]
	[MBPNJDODNHC]
	private DLKMEGGCFLP MDHNFJOCHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006E4")]
	private OCEBOIKNKAB LPIBCCADALP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006E5")]
	private NativeList<byte> PFDMLBFKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E6")]
	private NativeList<OMJBIJKANJG> PFJPBOOCGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006E7")]
	private NativeList<NGLDHKJAKDF> PJPIGJPBDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006E8")]
	private int CFEGEPNAMPO;

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<OMJBIJKANJG, NativeArray<byte>> IHKPMAOHHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BD5")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8F80", Offset = "0x5EC7D80", VA = "0x185EC8F80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BD6")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8C30", Offset = "0x5EC7A30", VA = "0x185EC8C30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD7")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9030", Offset = "0x5EC7E30", VA = "0x185EC9030", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD8")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8E80", Offset = "0x5EC7C80", VA = "0x185EC8E80", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BD9")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8CE0", Offset = "0x5EC7AE0", VA = "0x185EC8CE0", Slot = "5")]
	public void DKGPDAHFCBE(OMJBIJKANJG JIHPAFENIMM, ReadOnlySpan<byte> JPGMJABDIAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDA")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8F00", Offset = "0x5EC7D00", VA = "0x185EC8F00")]
	public void EOCKAINKMIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BDB")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BLNCLHPGCCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022B")]
[LKMFAIPHKDB(typeof(ILHIPOGALPJ), new string[] { })]
internal class EEHOIBALEMF : ILHIPOGALPJ, IJCLFGAEMDL, FKNGAHGHIJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200022C")]
	[CompilerGenerated]
	private sealed class DFGOIEFKFDL : IEnumerable<JBMJEBCFLLB>, IEnumerable, IEnumerator<JBMJEBCFLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private JBMJEBCFLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		public EEHOIBALEMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private JBMJEBCFLLB localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		public JBMJEBCFLLB <>3__localId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private NativeArray<Entity> <childEntitiesCopy>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private NativeArray<Entity>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		private JBMJEBCFLLB System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C02")]
			[Cpp2IlInjected.Address(RVA = "0x30DFE60", Offset = "0x30DEC60", VA = "0x1830DFE60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JBMJEBCFLLB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C04")]
			[Cpp2IlInjected.Address(RVA = "0x5ECA390", Offset = "0x5EC9190", VA = "0x185ECA390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x3260C70", Offset = "0x325FA70", VA = "0x183260C70")]
		[DebuggerHidden]
		public DFGOIEFKFDL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA3E0", Offset = "0x5EC91E0", VA = "0x185ECA3E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFF")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9EB0", Offset = "0x5EC8CB0", VA = "0x185EC9EB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9E60", Offset = "0x5EC8C60", VA = "0x185EC9E60")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA240", Offset = "0x5EC9040", VA = "0x185ECA240")]
		private void NPKEOFGCBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C03")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA340", Offset = "0x5EC9140", VA = "0x185ECA340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA290", Offset = "0x5EC9090", VA = "0x185ECA290", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JBMJEBCFLLB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA290", Offset = "0x5EC9090", VA = "0x185ECA290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private static readonly GKFGDEJLFAD OPFMOLBIJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006EF")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006F0")]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private IBOMJCPFPBJ NBBLMGDHBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private AELOEGFEFHM JADKMGFABGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40006F3")]
	private CMIFDPMNHCO<Entity> LDHENOLAOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40006F4")]
	private CMIFDPMNHCO<float3> PKKFHFPJMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40006F5")]
	private CMIFDPMNHCO<quaternion> IKEPKOKHIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40006F6")]
	private CMIFDPMNHCO<float> FNOPJKONKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40006F7")]
	private HashSet<Entity> APIBHNJKLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40006F8")]
	private HashSet<Entity> JPLOGMAGNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40006F9")]
	private EntityQuery IILINADNFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40006FA")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public Func<EAKFNHOGHCF> APGEJDHLHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE5")]
		[Cpp2IlInjected.Address(RVA = "0x76FC50", Offset = "0x76EA50", VA = "0x18076FC50", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000BE6")]
		[Cpp2IlInjected.Address(RVA = "0x76FC70", Offset = "0x76EA70", VA = "0x18076FC70", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<JBMJEBCFLLB, JBMJEBCFLLB> PLLINGFOKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BDD")]
		[Cpp2IlInjected.Address(RVA = "0x5ECAC50", Offset = "0x5EC9A50", VA = "0x185ECAC50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BDE")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB8C0", Offset = "0x5ECA6C0", VA = "0x185ECB8C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<JBMJEBCFLLB, JBMJEBCFLLB> ONMNDDBKNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000BDF")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB460", Offset = "0x5ECA260", VA = "0x185ECB460", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BE0")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA8E0", Offset = "0x5EC96E0", VA = "0x185ECA8E0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<JBMJEBCFLLB, JBMJEBCFLLB, JBMJEBCFLLB> IKEAJOBMJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE1")]
		[Cpp2IlInjected.Address(RVA = "0x5ECB510", Offset = "0x5ECA310", VA = "0x185ECB510", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BE2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC660", Offset = "0x5ECB460", VA = "0x185ECC660", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<JBMJEBCFLLB> FNGAHBMKAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000BE3")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC430", Offset = "0x5ECB230", VA = "0x185ECC430", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000BE4")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC380", Offset = "0x5ECB180", VA = "0x185ECC380", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE7")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB9F0", Offset = "0x5ECA7F0", VA = "0x185ECB9F0", Slot = "26")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE8")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBDE0", Offset = "0x5ECABE0", VA = "0x185ECBDE0", Slot = "27")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BE9")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAE30", Offset = "0x5EC9C30", VA = "0x185ECAE30", Slot = "28")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEA")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB400", Offset = "0x5ECA200", VA = "0x185ECB400")]
	private void FJPCEDPKCPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEB")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC4E0", Offset = "0x5ECB2E0", VA = "0x185ECC4E0")]
	private void NLIGLALCJKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEC")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA6E0", Offset = "0x5EC94E0", VA = "0x185ECA6E0")]
	private void AMPDJNEGMKL(FKIAGMFJAHK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BED")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC2C0", Offset = "0x5ECB0C0", VA = "0x185ECC2C0")]
	private void JNHKHHGPMOP(FKIAGMFJAHK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEE")]
	[Cpp2IlInjected.Address(RVA = "0x819AA0", Offset = "0x8188A0", VA = "0x180819AA0", Slot = "14")]
	public Color DNKKBPJAFMF(JBMJEBCFLLB OGPPAJOCABK, int OAOCMPKBOKO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BEF")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBBE0", Offset = "0x5ECA9E0", VA = "0x185ECBBE0", Slot = "15")]
	public float3 JDAOKOPJKII(JBMJEBCFLLB OGPPAJOCABK, int OAOCMPKBOKO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF0")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB5C0", Offset = "0x5ECA3C0", VA = "0x185ECB5C0", Slot = "16")]
	public bool GEMMKEJCCOB(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB GGLMLEJEMJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF1")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAD90", Offset = "0x5EC9B90", VA = "0x185ECAD90", Slot = "17")]
	public JBMJEBCFLLB DACEGHKKBLJ(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF2")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA990", Offset = "0x5EC9790", VA = "0x185ECA990", Slot = "20")]
	public void CAPAFOKKIKK(JBMJEBCFLLB OGPPAJOCABK, Vector3 EHGGAOCNEOE, Quaternion DPFBIDMPMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF3")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB970", Offset = "0x5ECA770", VA = "0x185ECB970", Slot = "21")]
	public void ILJFFCKCHLA(JBMJEBCFLLB OGPPAJOCABK, float JDLJFLJJFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF4")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAD00", Offset = "0x5EC9B00", VA = "0x185ECAD00", Slot = "24")]
	public float3 CMAIIDJGBPI(KMGAICBJFML DNEJIMMAEIK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB840", Offset = "0x5ECA640", VA = "0x185ECB840", Slot = "25")]
	public quaternion HKNCBJCLIOC(KMGAICBJFML DNEJIMMAEIK)
	{
		return default(quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF6")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB660", Offset = "0x5ECA460", VA = "0x185ECB660", Slot = "22")]
	public bool HCGMEBHPIEC(JBMJEBCFLLB OGPPAJOCABK, [Out] RigidTransform HNBGPOGFKLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF7")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAAE0", Offset = "0x5EC98E0", VA = "0x185ECAAE0", Slot = "23")]
	public bool CCOMIKHACLK(JBMJEBCFLLB OGPPAJOCABK, [Out] float JDLJFLJJFBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF8")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBB50", Offset = "0x5ECA950", VA = "0x185ECBB50", Slot = "18")]
	[IteratorStateMachine(typeof(DFGOIEFKFDL))]
	public IEnumerable<JBMJEBCFLLB> JBPIIBOGFGP(JBMJEBCFLLB OGPPAJOCABK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000BF9")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB2A0", Offset = "0x5ECA0A0", VA = "0x185ECB2A0", Slot = "19")]
	public JBMJEBCFLLB EMIGMBAKIEI(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFA")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB180", Offset = "0x5EC9F80", VA = "0x185ECB180")]
	private Entity EMIGMBAKIEI(Entity CCHOHIEEHEH)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000BFB")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC7D0", Offset = "0x5ECB5D0", VA = "0x185ECC7D0")]
	public EEHOIBALEMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200022D")]
[LKMFAIPHKDB(typeof(FAMDMBCKPIO), new string[] { })]
public sealed class LIOEEJHNEKB : FAMDMBCKPIO, IJCLFGAEMDL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200022E")]
	private struct ECJGLPIAEEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public float HAPHGEIIOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public uint JKDACOMACIH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000704")]
	[MBPNJDODNHC]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000705")]
	[MBPNJDODNHC]
	private BODAMAGMDOF JLCKOHIJOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000706")]
	[MBPNJDODNHC]
	private KFABHNDEFJP EKGPCJENNJO;

	[Cpp2IlInjected.Token(Token = "0x6000C07")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8E0", Offset = "0x5ECD6E0", VA = "0x185ECE8E0", Slot = "5")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C08")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE310", Offset = "0x5ECD110", VA = "0x185ECE310")]
	public bool CLAGLDDIBEG([In] float3 JLBMPBJBLDH, [In] float3 IELHLOGPMDL, float NGLNDDJFMFL, [Out] GFODINBMJOG EADAPKBIBFH, [Out] JBMJEBCFLLB PPEPGBPKJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C09")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE800", Offset = "0x5ECD600", VA = "0x185ECE800")]
	public static bool IIBLAJMCKIN([In] Span<GFODINBMJOG> OENHMFIBPIO, float NGLNDDJFMFL, [Out] int DOJILIOCHKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE7D0", Offset = "0x5ECD5D0", VA = "0x185ECE7D0")]
	public static float HEIJJLEKJLL(float HAPHGEIIOOB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0B")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public LIOEEJHNEKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE7C0", Offset = "0x5ECD5C0", VA = "0x185ECE7C0", Slot = "4")]
	private bool GHFGDKEBOIL([In] float3 JLBMPBJBLDH, [In] float3 IELHLOGPMDL, float NGLNDDJFMFL, [Out] GFODINBMJOG EADAPKBIBFH, [Out] JBMJEBCFLLB PPEPGBPKJPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200022F")]
[LKMFAIPHKDB(typeof(KFABHNDEFJP), new string[] { })]
public sealed class NBLHEIDIMMO : KFABHNDEFJP, IJCLFGAEMDL
{
	[Cpp2IlInjected.Token(Token = "0x2000230")]
	[BurstCompile]
	private struct FJMIKMHALOP : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		[ReadOnly]
		public NativeArray<Entity> PFOPLIKJCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		[ReadOnly]
		public float3 NPOBJBFAAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		[ReadOnly]
		public float3 HBJOLGGKBNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> ABKCHHFJEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		[ReadOnly]
		public ComponentDataFromEntity<APOICHPMLJB> BLFGJDBGHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> DHFFEBIBLMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		[ReadOnly]
		public ComponentDataFromEntity<NBKIDJCCNAD> EIAEKKDDAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		[ReadOnly]
		public ComponentDataFromEntity<PFPLHPDBGCJ> PFAOOOCNDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		[WriteOnly]
		public NativeArray<GFODINBMJOG> HGHLDLHMPHM;

		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private static readonly GFODINBMJOG HNJBMGLFCIN;

		[Cpp2IlInjected.Token(Token = "0x6000C11")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCC70", Offset = "0x5ECBA70", VA = "0x185ECCC70", Slot = "4")]
		public void Execute(int DOJILIOCHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C12")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC9E0", Offset = "0x5ECB7E0", VA = "0x185ECC9E0")]
		private static float3 DHOGHGFFMCM([In] float4x4 HBAJCNLPOIC, [In] float3 DPGDANDOGFG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C13")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD870", Offset = "0x5ECC670", VA = "0x185ECD870")]
		private static float3 MCMMCMHPNAI([In] float4x4 HBAJCNLPOIC, [In] float3 BIGGLMECNJE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C14")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC8E0", Offset = "0x5ECB6E0", VA = "0x185ECC8E0")]
		private static float3 BMJAGCIJIFL([In] float4x4 HBAJCNLPOIC, [In] float3 DPGDANDOGFG)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C15")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCA90", Offset = "0x5ECB890", VA = "0x185ECCA90")]
		private static float3 DKABDPGOJND([In] float4x4 HBAJCNLPOIC, [In] float3 BIGGLMECNJE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD560", Offset = "0x5ECC360", VA = "0x185ECD560")]
		private bool KMILOLLDAOJ([In] float3 JLBMPBJBLDH, [In] float3 IELHLOGPMDL, [In] NativeArray<Entity> HKKGDIHCKNC, [Out] float3 EADAPKBIBFH, [Out] float3 LNAACFFHHMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCF10", Offset = "0x5ECBD10", VA = "0x185ECCF10")]
		public static bool KCBDCABDFBM([In] float3 EINOCEPDJFP, [In] float3 BBEJDCLLPPI, [In] float3 MEAIFCJPKAP, [In] float3 HEMLEEICKDB, float NHMJBGBMAAM, float BELIJAOOPOK, [Out] float MOEPCGBEMKK, [Out] float3 EJIPIDNGAFP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000709")]
	private EntityManager FMCNCDMBJDH;

	[Cpp2IlInjected.Token(Token = "0x6000C0D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEEA0", Offset = "0x5ECDCA0", VA = "0x185ECEEA0", Slot = "5")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEA60", Offset = "0x5ECD860", VA = "0x185ECEA60")]
	public void CLAGLDDIBEG([In] NativeArray<Entity> PFOPLIKJCHB, [In] float3 JLBMPBJBLDH, [In] float3 IELHLOGPMDL, [In] NativeArray<GFODINBMJOG> CGBDKDNCGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C0F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public NBLHEIDIMMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C10")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEF20", Offset = "0x5ECDD20", VA = "0x185ECEF20", Slot = "4")]
	private void NFANKIJNGDK([In] NativeArray<Entity> PFOPLIKJCHB, [In] float3 JLBMPBJBLDH, [In] float3 IELHLOGPMDL, [In] NativeArray<GFODINBMJOG> CGBDKDNCGFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000231")]
[LKMFAIPHKDB(typeof(AELOEGFEFHM), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
[GPOCAEGADIM(typeof(MAEKAKNNECM))]
public class AELOEGFEFHM : MAEKAKNNECM, IJCLFGAEMDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000232")]
	private struct EALPHHKJNJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		public CBFDMKOCAMK CBDJMGNPMLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		public Type PEMNIEMPPLO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000233")]
	private struct OMHKCOLCJNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		public EALPHHKJNJP[] EKODFEEOAPM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000234")]
	[BurstCompile]
	private struct EDPHEHBDINN : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		[ReadOnly]
		public NativeArray<byte> NFIGOBBANPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		[ReadOnly]
		public NativeArray<Entity> GHHNLHEMMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		[ReadOnly]
		public NativeArray<byte> KHEGPNNNKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		[ReadOnly]
		public NativeArray<byte> OOCBDHIIDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		[WriteOnly]
		public NativeList<Entity> KDDBBMNMDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000723")]
		[WriteOnly]
		public NativeList<byte> PNGOEGOGNDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000724")]
		[WriteOnly]
		public NativeList<byte> DNCLLJLAHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000725")]
		public int OGHJOHMKJMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000726")]
		public int JLOGJEHOJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000727")]
		public int CCHIKIDPIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000728")]
		public int APHNPJDNMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000729")]
		public int FCBJBEGKILC;

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA520", Offset = "0x5EC9320", VA = "0x185ECA520", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000714")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000717")]
	private readonly Dictionary<KIBKAPDMHFC, CBFDMKOCAMK> PCMBEDAKFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000718")]
	private readonly Dictionary<int, OMHKCOLCJNF> NMJOOFHADLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000719")]
	private FCEELEODMDI EKODFEEOAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400071A")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action OAJBLGNGCBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x5EC89C0", Offset = "0x5EC77C0", VA = "0x185EC89C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC81E0", Offset = "0x5EC6FE0", VA = "0x185EC81E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action FKKFLPHFFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7800", Offset = "0x5EC6600", VA = "0x185EC7800")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC82F0", Offset = "0x5EC70F0", VA = "0x185EC82F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8280", Offset = "0x5EC7080", VA = "0x185EC8280", Slot = "6")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7520", Offset = "0x5EC6320", VA = "0x185EC7520", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C1F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8600", Offset = "0x5EC7400", VA = "0x185EC8600", Slot = "4")]
	public void MCJJKKHGDCC(FIAJLECAKMM GGCGADADFCH, CBFDMKOCAMK JGGDOEKFOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C20")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8390", Offset = "0x5EC7190", VA = "0x185EC8390", Slot = "5")]
	public void JKGGMKNLLFM(FIAJLECAKMM GGCGADADFCH, CBFDMKOCAMK JGGDOEKFOFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C21")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8750", Offset = "0x5EC7550", VA = "0x185EC8750", Slot = "8")]
	public void MCJJKKHGDCC(KIBKAPDMHFC NLJCIKGMHGO, CBFDMKOCAMK MEKLMIFMFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C22")]
	[Cpp2IlInjected.Address(RVA = "0x5EC84E0", Offset = "0x5EC72E0", VA = "0x185EC84E0", Slot = "9")]
	public void JKGGMKNLLFM(KIBKAPDMHFC NLJCIKGMHGO, CBFDMKOCAMK MEKLMIFMFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C23")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7360", Offset = "0x5EC6160", VA = "0x185EC7360")]
	private void COLNAMDMKAD(KIBKAPDMHFC NLJCIKGMHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C24")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6FA0", Offset = "0x5EC5DA0", VA = "0x185EC6FA0")]
	internal void BIMLAENOOAA(NHNJJHDMCBN EPLFCMFNFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C25")]
	[Cpp2IlInjected.Address(RVA = "0x5EC78A0", Offset = "0x5EC66A0", VA = "0x185EC78A0")]
	private void GJFKFJHBIJH(NHNJJHDMCBN EPLFCMFNFIK, int IDDPEMOGPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C26")]
	[Cpp2IlInjected.Address(RVA = "0x5EC75B0", Offset = "0x5EC63B0", VA = "0x185EC75B0")]
	private void EIGIGLDLENH(MDMHNBKGCGM BHGDMLDFEHD, KCIEHIFDMEB CPCHHNAJJCG, EALPHHKJNJP HEHEGOCBPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C27")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8840", Offset = "0x5EC7640", VA = "0x185EC8840")]
	private OMHKCOLCJNF NPCOHHCNNFN(MDMHNBKGCGM BHGDMLDFEHD, KCIEHIFDMEB CPCHHNAJJCG)
	{
		return default(OMHKCOLCJNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C28")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7290", Offset = "0x5EC6090", VA = "0x185EC7290")]
	private EALPHHKJNJP BNMOENGKILN(OMHKCOLCJNF JEPAAHKBIBH, MDMHNBKGCGM BHGDMLDFEHD, KCIEHIFDMEB CPCHHNAJJCG)
	{
		return default(EALPHHKJNJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C29")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8AF0", Offset = "0x5EC78F0", VA = "0x185EC8AF0")]
	public AELOEGFEFHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000235")]
[LKMFAIPHKDB(typeof(MOMEIDDAEBF), new string[] { })]
public class OOLPCOEPNHH : IJCLFGAEMDL, FKNGAHGHIJP, MOMEIDDAEBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000236")]
	[CompilerGenerated]
	private sealed class NJLDNDLOAPE : IEnumerable<JBMJEBCFLLB>, IEnumerable, IEnumerator<JBMJEBCFLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		private JBMJEBCFLLB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		public OOLPCOEPNHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private JBMJEBCFLLB splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public JBMJEBCFLLB <>3__splineId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		private JBMJEBCFLLB System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C41")]
			[Cpp2IlInjected.Address(RVA = "0x30DFE60", Offset = "0x30DEC60", VA = "0x1830DFE60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JBMJEBCFLLB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000C43")]
			[Cpp2IlInjected.Address(RVA = "0x5ECF0F0", Offset = "0x5ECDEF0", VA = "0x185ECF0F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x3260C70", Offset = "0x325FA70", VA = "0x183260C70")]
		[DebuggerHidden]
		public NJLDNDLOAPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEF30", Offset = "0x5ECDD30", VA = "0x185ECEF30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF0A0", Offset = "0x5ECDEA0", VA = "0x185ECF0A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEFF0", Offset = "0x5ECDDF0", VA = "0x185ECEFF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JBMJEBCFLLB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEFF0", Offset = "0x5ECDDF0", VA = "0x185ECEFF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400072A")]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400072B")]
	private IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400072C")]
	private IHJBEAAMNEB IGNGKFHFNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400072D")]
	private APCELKGPEPM IPGJNLBLKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400072E")]
	private GNBAGIHPECL JKMCJDKCAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400072F")]
	private LGMAMHNDHAH HGJMOLFPFCP;

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF930", Offset = "0x5ECE730", VA = "0x185ECF930")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFD00", Offset = "0x5ECEB00", VA = "0x185ECFD00", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2E")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
	public void JKGLFHNGJKP(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2F")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "15")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C30")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF980", Offset = "0x5ECE780", VA = "0x185ECF980")]
	private void DOBKDFKAOJB(Entity DEGOJJNLONC, int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C31")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFB20", Offset = "0x5ECE920", VA = "0x185ECFB20", Slot = "10")]
	public void GIMKLHNKJIC(JBMJEBCFLLB OGPPAJOCABK, HGKFIBGMEHG FJDDANGEILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C32")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF790", Offset = "0x5ECE590", VA = "0x185ECF790", Slot = "9")]
	public HGKFIBGMEHG AKELGLKFEEI(JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(HGKFIBGMEHG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C33")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF690", Offset = "0x5ECE490", VA = "0x185ECF690", Slot = "11")]
	public JBMJEBCFLLB ABCLIHPBHBP(JBMJEBCFLLB PGMLFLIAHBD, [Optional] float3? AILFIIEAPKM, [Optional] quaternion? GIBIBDOGOLL, [Optional] float3? GBJGBGCFEKM)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C34")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF830", Offset = "0x5ECE630", VA = "0x185ECF830", Slot = "12")]
	public JBMJEBCFLLB APKPDMDHFCB(JBMJEBCFLLB PGMLFLIAHBD, int DOJILIOCHKM, [Optional] float3? AILFIIEAPKM, [Optional] quaternion? GIBIBDOGOLL, [Optional] float3? GBJGBGCFEKM)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C35")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0110", Offset = "0x5ECEF10", VA = "0x185ED0110")]
	private JBMJEBCFLLB PFMKBCIPKEH(JBMJEBCFLLB PGMLFLIAHBD, int DOJILIOCHKM, [Optional] float3? AILFIIEAPKM, [Optional] quaternion? GIBIBDOGOLL, [Optional] float3? GBJGBGCFEKM)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C36")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFC20", Offset = "0x5ECEA20", VA = "0x185ECFC20", Slot = "7")]
	public JBMJEBCFLLB IFJKGBNBGHN(JBMJEBCFLLB PGMLFLIAHBD, int DOJILIOCHKM)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C37")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFBC0", Offset = "0x5ECE9C0", VA = "0x185ECFBC0", Slot = "16")]
	public void HGGBBKJPLIJ(JBMJEBCFLLB PGMLFLIAHBD, JBMJEBCFLLB DEGOJJNLONC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C38")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFA00", Offset = "0x5ECE800", VA = "0x185ECFA00", Slot = "13")]
	public void GIGJHEJMLOJ(JBMJEBCFLLB PGMLFLIAHBD, int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C39")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFDF0", Offset = "0x5ECEBF0", VA = "0x185ECFDF0", Slot = "14")]
	public void MNKMCCHACLH(JBMJEBCFLLB PGMLFLIAHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF700", Offset = "0x5ECE500", VA = "0x185ECF700", Slot = "8")]
	public int AFABCEOCJBO(JBMJEBCFLLB PGMLFLIAHBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF8A0", Offset = "0x5ECE6A0", VA = "0x185ECF8A0", Slot = "6")]
	[IteratorStateMachine(typeof(NJLDNDLOAPE))]
	public IEnumerable<JBMJEBCFLLB> BLIEALJGNCD(JBMJEBCFLLB PGMLFLIAHBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0080", Offset = "0x5ECEE80", VA = "0x185ED0080")]
	private bool OAMKBBCFMCK(JBMJEBCFLLB PGMLFLIAHBD, [Out] NativeArray<Entity> MKILDJBBDMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public OOLPCOEPNHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000237")]
[LKMFAIPHKDB(typeof(CHHENEBMPJM), new string[] { })]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
internal sealed class CHHENEBMPJM : IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000738")]
	private HBMBNCJMDAI GICLKIIJBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000739")]
	private IOPAEIMLPMI GKIKJJGHLHM;

	[Cpp2IlInjected.Token(Token = "0x6000C46")]
	[Cpp2IlInjected.Address(RVA = "0x5EC92D0", Offset = "0x5EC80D0", VA = "0x185EC92D0", Slot = "4")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C47")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public CHHENEBMPJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000238")]
[DefaultMember("Item")]
public struct FPLEEDDEFPP<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073A")]
	private T[] PFDMLBFKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073B")]
	private int JMNJMKJAMOL;

	[Cpp2IlInjected.Token(Token = "0x6000C48")]
	[Cpp2IlInjected.Address(RVA = "0x340D5D0", Offset = "0x340C3D0", VA = "0x18340D5D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000239")]
[DefaultMember("Item")]
public struct ILAEFIJCEBJ<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073C")]
	private FPLEEDDEFPP<T> PFDMLBFKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073D")]
	private int JMNJMKJAMOL;

	[Cpp2IlInjected.Token(Token = "0x6000C49")]
	[Cpp2IlInjected.Address(RVA = "0x3685770", Offset = "0x3684570", VA = "0x183685770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4A")]
	[Cpp2IlInjected.Address(RVA = "0x36857B0", Offset = "0x36845B0", VA = "0x1836857B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200023A")]
public struct GHKCPNCBNDO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400073E")]
	private NativeList<Entity> PFOPLIKJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400073F")]
	private TransformAccessArray HJDMFCAGMOH;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE060", Offset = "0x5ECCE60", VA = "0x185ECE060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public NativeList<Entity> BNLDGEIHFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D860", Offset = "0xA8C660", VA = "0x180A8D860")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public TransformAccessArray IDKMOFPDNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDFF0", Offset = "0x5ECCDF0", VA = "0x185ECDFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE100", Offset = "0x5ECCF00", VA = "0x185ECE100")]
	public GHKCPNCBNDO(int DECKGNHFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C50")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE0B0", Offset = "0x5ECCEB0", VA = "0x185ECE0B0")]
	public Entity NGJHNMOJDOD(int DOJILIOCHKM)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C51")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE010", Offset = "0x5ECCE10", VA = "0x185ECE010")]
	public void HCLOHPLECKH(int DECKGNHFLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C52")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDE40", Offset = "0x5ECCC40", VA = "0x185ECDE40")]
	public int AAFNAGDLNDC(Transform GNLAIPIBJPM, Entity CCHOHIEEHEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C53")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDF00", Offset = "0x5ECCD00", VA = "0x185ECDF00")]
	public int AGGMCKBKNMH(int DOJILIOCHKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C54")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDF70", Offset = "0x5ECCD70", VA = "0x185ECDF70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C55")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE070", Offset = "0x5ECCE70", VA = "0x185ECE070")]
	private void KKONCNCFOBO(int NDPJFEJOCKC = 0)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200023B")]
public struct KHPHGFJFGGE : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x4000740")]
	public static readonly KHPHGFJFGGE BKEFLEENBBL;

	[Cpp2IlInjected.Token(Token = "0x6000C56")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE290", Offset = "0x5ECD090", VA = "0x185ECE290", Slot = "4")]
	public bool Equals(LinkedEntityGroup HOELCINBFKH, LinkedEntityGroup JOHINIOFBIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C57")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE2B0", Offset = "0x5ECD0B0", VA = "0x185ECE2B0", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup HBDENJGMDDF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200023C")]
internal class FPLLIAECOON
{
	[Cpp2IlInjected.Token(Token = "0x6000C58")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public FPLLIAECOON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023D")]
public struct CIINDJLMCOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000741")]
	public Entity CCHOHIEEHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000742")]
	public Entity AOAOIAHJGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000743")]
	public Entity KBFMMMPNLKE;

	[Cpp2IlInjected.Token(Token = "0x6000C59")]
	[Cpp2IlInjected.Address(RVA = "0x42A51F0", Offset = "0x42A3FF0", VA = "0x1842A51F0")]
	public CIINDJLMCOJ(Entity CCHOHIEEHEH, Entity AOAOIAHJGFI, Entity KBFMMMPNLKE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C5A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9370", Offset = "0x5EC8170", VA = "0x185EC9370")]
	public static CIINDJLMCOJ FMKGPFEKDFI((Entity entity, Entity oldParent, Entity newParent) GEBKCACDGIB)
	{
		return default(CIINDJLMCOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9350", Offset = "0x5EC8150", VA = "0x185EC9350")]
	public void EIMGPDKFHGM([Out] Entity CCHOHIEEHEH, [Out] Entity AOAOIAHJGFI, [Out] Entity KBFMMMPNLKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023E")]
public struct HDFBIPFPCNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000744")]
	public Entity CCHOHIEEHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000745")]
	public Entity LBLLNFOEKNE;

	[Cpp2IlInjected.Token(Token = "0x6000C5C")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA270", Offset = "0x1FE9070", VA = "0x181FEA270")]
	public HDFBIPFPCNK(Entity CCHOHIEEHEH, Entity LBLLNFOEKNE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C5D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE270", Offset = "0x5ECD070", VA = "0x185ECE270")]
	public static HDFBIPFPCNK FMKGPFEKDFI((Entity entity, Entity parent) GEBKCACDGIB)
	{
		return default(HDFBIPFPCNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C5E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE260", Offset = "0x5ECD060", VA = "0x185ECE260")]
	public void EIMGPDKFHGM([Out] Entity CCHOHIEEHEH, [Out] Entity LBLLNFOEKNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200023F")]
public struct PJGOHHKPPOB<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000746")]
	private GCHandle KMOBDGPHBOK;

	[Cpp2IlInjected.Token(Token = "0x6000C5F")]
	[Cpp2IlInjected.Address(RVA = "0x3DEA6F0", Offset = "0x3DE94F0", VA = "0x183DEA6F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000240")]
public enum IBOKNNCIPOF
{
	[Cpp2IlInjected.Token(Token = "0x4000748")]
	NewParent,
	[Cpp2IlInjected.Token(Token = "0x4000749")]
	ChangedParent,
	[Cpp2IlInjected.Token(Token = "0x400074A")]
	OldParent
}
[Cpp2IlInjected.Token(Token = "0x2000241")]
public struct AECPNGMKDBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400074B")]
	public IBOKNNCIPOF FOMIHPGFJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400074C")]
	public int JLKPFEJMOME;

	[Cpp2IlInjected.Token(Token = "0x6000C60")]
	[Cpp2IlInjected.Address(RVA = "0x9712C0", Offset = "0x9700C0", VA = "0x1809712C0")]
	public AECPNGMKDBE(IBOKNNCIPOF FOMIHPGFJFH, int JLKPFEJMOME)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000C61")]
	[Cpp2IlInjected.Address(RVA = "0x5DB9050", Offset = "0x5DB7E50", VA = "0x185DB9050")]
	public static AECPNGMKDBE FMKGPFEKDFI((IBOKNNCIPOF eventType, int eventIndex) HOELCINBFKH)
	{
		return default(AECPNGMKDBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C62")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6F90", Offset = "0x5EC5D90", VA = "0x185EC6F90")]
	public void EIMGPDKFHGM([Out] IBOKNNCIPOF FOMIHPGFJFH, [Out] int JLKPFEJMOME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000242")]
[LKMFAIPHKDB(typeof(BODAMAGMDOF), new string[] { })]
public sealed class MHOJCIAOMGP : BODAMAGMDOF, IJCLFGAEMDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400074D")]
	private EPMCOHFCLHA JDJHJONLFGA;

	[Cpp2IlInjected.Token(Token = "0x6000C63")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEA10", Offset = "0x5ECD810", VA = "0x185ECEA10", Slot = "5")]
	public void InitReferences(LHNHCAPHDGO PDGDCGJNEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C64")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE970", Offset = "0x5ECD770", VA = "0x185ECE970")]
	public bool CLAGLDDIBEG([In] float3 JLBMPBJBLDH, [In] float3 IELHLOGPMDL, float NGLNDDJFMFL, Allocator JFLEKJGGDHL, [Out] NativeArray<Entity> PFOPLIKJCHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C65")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public MHOJCIAOMGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C66")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE970", Offset = "0x5ECD770", VA = "0x185ECE970", Slot = "4")]
	private bool EMGBLMALAJP([In] float3 JLBMPBJBLDH, [In] float3 IELHLOGPMDL, float NGLNDDJFMFL, Allocator JFLEKJGGDHL, [Out] NativeArray<Entity> PFOPLIKJCHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000243")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
public sealed class FNEPAKJHMIH : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000C67")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDA30", Offset = "0x5ECC830", VA = "0x185ECDA30", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C68")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public FNEPAKJHMIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000244")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal sealed class DDPFEMICEOG : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000C69")]
	[Cpp2IlInjected.Address(RVA = "0x5EC95A0", Offset = "0x5EC83A0", VA = "0x185EC95A0", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6A")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public DDPFEMICEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000245")]
internal class MEMPJANMJGD : NBIHFNKMCJC
{
	[Cpp2IlInjected.Token(Token = "0x6000C6B")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public MEMPJANMJGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000246")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal sealed class GJFLCELBHMK : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000C6C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE190", Offset = "0x5ECCF90", VA = "0x185ECE190", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6D")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public GJFLCELBHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000247")]
internal class FBMADDDJOGG : EPHOBAKOJBC
{
	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	protected override CIDKNADIFBP GLKOKGCIDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x7D0CD0", Offset = "0x7CFAD0", VA = "0x1807D0CD0", Slot = "17")]
		get
		{
			return default(CIDKNADIFBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C6F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC890", Offset = "0x5ECB690", VA = "0x185ECC890")]
	public FBMADDDJOGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000248")]
[NJOEKALHIJD(DAEAEJBLHHK.LoadInstance)]
internal sealed class OHHPFIJHCDE : LNDOMDEMCJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000C70")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF140", Offset = "0x5ECDF40", VA = "0x185ECF140", Slot = "15")]
	protected override ComponentSystemBase COLCFNMLCIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C71")]
	[Cpp2IlInjected.Address(RVA = "0x5E06DF0", Offset = "0x5E05BF0", VA = "0x185E06DF0")]
	public OHHPFIJHCDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000249")]
[IDPOCOKGLBE(typeof(BOMPBJOFHHO))]
public sealed class COKNFJLFAMD : LOPFHJFKEDE
{
	[Cpp2IlInjected.Token(Token = "0x6000C72")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9490", Offset = "0x5EC8290", VA = "0x185EC9490", Slot = "8")]
	protected override bool FDKJPOPDMPK(ReadOnlySpan<BOMPBJOFHHO> GBGFELNIFAG, DLOCLBOCELG DLAHENGMLBI, [Out] ReadOnlySpan<byte> GHHJLCMBOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C73")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9390", Offset = "0x5EC8190", VA = "0x185EC9390", Slot = "9")]
	protected override bool CFACIFEFFID(int KCPGKFKLEJL, Span<BOMPBJOFHHO> GBGFELNIFAG, [In] ReadOnlySpan<byte> GHHJLCMBOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C74")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9590", Offset = "0x5EC8390", VA = "0x185EC9590")]
	public COKNFJLFAMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024A")]
[IDPOCOKGLBE(typeof(HDEJALOFGAC))]
public sealed class GEDOCNCLLMD : KGHGOKIGDDF
{
	[Cpp2IlInjected.Token(Token = "0x6000C75")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDD30", Offset = "0x5ECCB30", VA = "0x185ECDD30", Slot = "8")]
	protected override bool FDKJPOPDMPK(ReadOnlySpan<HDEJALOFGAC> GBGFELNIFAG, DLOCLBOCELG DLAHENGMLBI, [Out] ReadOnlySpan<byte> GHHJLCMBOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C76")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDC30", Offset = "0x5ECCA30", VA = "0x185ECDC30", Slot = "9")]
	protected override bool CFACIFEFFID(int KCPGKFKLEJL, Span<HDEJALOFGAC> GBGFELNIFAG, [In] ReadOnlySpan<byte> GHHJLCMBOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C77")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDE30", Offset = "0x5ECCC30", VA = "0x185ECDE30")]
	public GEDOCNCLLMD()
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200024B")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : LHFJOJDLFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000C78")]
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C79")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0520", Offset = "0x5ECF320", VA = "0x185ED0520", Slot = "6")]
		public sealed override void CNKHFOKLDEM(AIEDCKEDGIE MEKLMIFMFCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C7A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1660", Offset = "0x5ED0460", VA = "0x185ED1660", Slot = "4")]
		public sealed override void JDGHKCFEBFB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200024C")]
internal class __UnmanagedPostProcessorOutput__4026771082
{
	[Cpp2IlInjected.Token(Token = "0x6000C7B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2890", Offset = "0x5ED1690", VA = "0x185ED2890")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024D")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__4026771082
{
	[Cpp2IlInjected.Token(Token = "0x6000C7C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1820", Offset = "0x5ED0620", VA = "0x185ED1820")]
	public static void ECNIMMIDEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2880", Offset = "0x5ED1680", VA = "0x185ED2880")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200024E")]
internal class BNMDCJDMGPB : ContainerPropertyBag<HCOMBLFGMEK>
{
	[Cpp2IlInjected.Token(Token = "0x200024F")]
	private class AIMOHFMDJIO : Property<HCOMBLFGMEK, KMILLOLJKJL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public override string KKCKMDALLNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000C7F")]
			[Cpp2IlInjected.Address(RVA = "0x5EC8C00", Offset = "0x5EC7A00", VA = "0x185EC8C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public override bool MGKAFOIHMEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000C80")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C81")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8BC0", Offset = "0x5EC79C0", VA = "0x185EC8BC0")]
		public AIMOHFMDJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C82")]
		[Cpp2IlInjected.Address(RVA = "0x5D88A60", Offset = "0x5D87860", VA = "0x185D88A60", Slot = "14")]
		public override KMILLOLJKJL GetValue(HCOMBLFGMEK NFDHIFFHPGD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C83")]
		[Cpp2IlInjected.Address(RVA = "0x5D88A80", Offset = "0x5D87880", VA = "0x185D88A80", Slot = "15")]
		public override void SetValue(HCOMBLFGMEK NFDHIFFHPGD, KMILLOLJKJL GNLEHBFFNFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C7E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC91F0", Offset = "0x5EC7FF0", VA = "0x185EC91F0")]
	public BNMDCJDMGPB()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x2000250")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000C84")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0380", Offset = "0x5ECF180", VA = "0x185ED0380")]
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
	[Cpp2IlInjected.Address(RVA = "0x5ED04A0", Offset = "0x5ECF2A0", VA = "0x185ED04A0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000252")]
public class IKMPJPADFGH
{
	[Cpp2IlInjected.Token(Token = "0x6000C86")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IKMPJPADFGH()
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
